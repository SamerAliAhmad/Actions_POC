import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Resolve } from '@angular/router';
import { Loader } from '@googlemaps/js-api-loader';
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
    favIcon: HTMLLinkElement = document.querySelector('#appIcon');
    loaderImage = document.getElementById('appLogo') as HTMLImageElement;

    constructor(
        private proxy: Proxy,
        private http: HttpClient,
        private CmSvc: CommonService,
        private _smartrNavigationService: SmartrNavigationService,
    ) { }
    Load_Config(): Promise<any> {
        return new Promise((resolve, reject) => {
            this.http.get(this.configUrl).subscribe((response: any) => {
                this.CmSvc.APIUrl = response.APIUrl;
                resolve(true);
            }, reject);
        });
    }
    Get_Initial_Districtnex_Admin_Settings(): Promise<boolean> {
        return new Promise(resolve => {
            this.Load_Config().then(_ => {
                this.proxy.Get_Initial_Districtnex_Admin_Settings().subscribe({
                    next: result => {
                        if (result) {
                            this.CmSvc.defaultSettings = result.Default_settings;
                            environment.Build_Number = result.BUILD_NUMBER;
                            new Loader({ version: "weekly", apiKey: result.Default_settings.GOOGLE_MAP_API_TOKEN }).load().then(() => {
                                this.CmSvc.Is_Google_Map_Loaded = true;
                                resolve(true);
                            }).catch((e) => {
                                this.CmSvc.Is_Google_Map_Loaded = false;
                                resolve(true);
                            });
                        }
                    }
                });
            });
        })
    }
    resolve(): Observable<any> {
        return forkJoin([
            this._smartrNavigationService.get(),
            this.Get_Initial_Districtnex_Admin_Settings().catch(error => {
                this.CmSvc.ShowMessage(error);
            }),
        ]);
    }
}
