import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Resolve } from '@angular/router';
import { environment } from 'environments/environment';
import { forkJoin, Observable } from 'rxjs';
import { CommonService } from './core/Services/common.service';
import { Proxy } from './core/Services/proxy.service';
import { SmartrNavigationService } from './shared/navigation/navigation.service';

@Injectable({
    providedIn: 'root'
})
export class InitialDataInitializer implements Resolve<any> {
    configUrl = 'assets/config/app.config.json';

    constructor(
        private proxy: Proxy,
        private http: HttpClient,
        private CmSvc: CommonService,
        private _smartrNavigationService: SmartrNavigationService,
    ) { }

    Load_Config(): Promise<any> {
        return new Promise((resolve, reject) => {
            this.http.get(this.configUrl).subscribe({
                next: (response: any) => {
                    this.CmSvc.APIUrl = response.APIUrl;
                    this.CmSvc.Asset_Endpoint = `${response.APIUrl}/Api/FileManagement/Files`;
                    this.CmSvc.SignalR_Realtime_Server_Endpoint = response.SignalR_Realtime_Server_Endpoint;
                    this.CmSvc.oList_Preset_time = response.List_Preset_time;
                    resolve(true);
                },
                error: () => reject
            });
        });
    }
    Get_Initial_Districtnex_Settings(): Promise<boolean> {
        return new Promise(resolve => {
            this.Load_Config().then(_ => {
                this.proxy.Get_Initial_Districtnex_UI_Settings().subscribe({
                    next: result => {
                        if (result) {
                            environment.MapBox_Token = result.Default_settings.MAPBOX_GL_TOKEN;
                            environment.Build_Number = result.BUILD_NUMBER;
                            this.CmSvc.oDefaultSettings = result.Default_settings;
                            this.CmSvc.Update_Default_Settings(result?.Default_settings);
                        }
                        resolve(true);
                    }
                });
            });
        })
    }
    resolve(): Observable<any> {
        return forkJoin([
            this._smartrNavigationService.get(),
            this.Get_Initial_Districtnex_Settings().catch(error => {
                this.CmSvc.ShowMessage(error);
            }),
        ]);
    }
}
