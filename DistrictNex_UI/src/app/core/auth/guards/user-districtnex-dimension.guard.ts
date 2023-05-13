import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { InitialDataResolver } from 'app/app.resolvers';
import { CommonService } from 'app/core/Services/common.service';
import { MapService } from 'app/modules/map/map.service';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { Observable } from 'rxjs';
import { AuthService } from '../auth.service';

@Injectable({
    providedIn: 'root'
})
export class UserDistrictnexDimensionGuard implements CanActivate {

    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private MapService: MapService,
        private _authService: AuthService,
        private InitialDataResolver: InitialDataResolver,
        private SmartrSplashScreenService: SmartrSplashScreenService
    ) { }

    canActivate(
        route: ActivatedRouteSnapshot,
        state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        return new Promise(resolve => {
            const oUser_Access_Promise = new Promise<void>(resolve => {
                if (this.CmSvc.oList_Accessible_districtnex_module.length > 0) {
                    resolve();
                }
                else {
                    this.InitialDataResolver.Get_Initial_Data().then(() => {
                        resolve();
                    }).catch(error => {
                        if (error) {
                            this.CmSvc.ShowMessage(error);
                        }
                        this._authService.signOut();
                        this.router.navigate(['/sign-in']);
                        this.CmSvc.oSignOutSubject.next();
                    });
                }
            });
            oUser_Access_Promise.then(() => {
                if (this.CmSvc.oUser_Accessible_Level_List) {
                    if (route.routeConfig.path == "map" && !this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "map")) {
                        this.router.navigateByUrl('/reports');
                        resolve(false);
                    }
                    if (route.routeConfig.path == "reports" && !this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "reports")) {
                        this.router.navigateByUrl('/video-ai');
                        resolve(false);
                    }
                    if (route.routeConfig.path == "video-ai" && !this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "video ai")) {
                        this.router.navigateByUrl('/map');
                        resolve(false);
                    }
                    resolve(true);
                } else {
                    this.CmSvc.chosen_route = route.routeConfig.path;
                    let organization_ID = localStorage.getItem('organization_id');
                    let saved_top_level_id = localStorage.getItem('top_level_id');
                    if (this.CmSvc.CheckString(saved_top_level_id) && this.CmSvc.CheckString(organization_ID)) {
                        this.CmSvc.saved_top_level_id = Number.parseInt(saved_top_level_id);
                        this.CmSvc.saved_organization_id = Number.parseInt(organization_ID);
                        this.CmSvc.Set_Application_Theme();
                        this.SmartrSplashScreenService.show();
                        this.Get_Map_Data().then(() => {
                            resolve(true);
                        });
                    }
                    else {
                        if (route.routeConfig.path == "map" && !this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "map")) {
                            this.router.navigateByUrl('/reports');
                            resolve(false);
                        }
                        if (route.routeConfig.path == "reports" && this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "reports")) {
                            this.router.navigateByUrl('/organization-selection');
                            resolve(false);
                        }
                        if (route.routeConfig.path == "video-ai" && this.CmSvc.oList_Accessible_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME.toLowerCase() == "video ai")) {
                            this.router.navigateByUrl('/organization-selection');
                            resolve(false);
                        }
                        resolve(true);
                    }
                }
            })
        });
    }


    Get_Map_Data(): Promise<boolean> {
        this.SmartrSplashScreenService.show();
        return new Promise((resolve, reject) => {
            this.MapService.Get_Initial_Top_Level_Data().then(result => {
                if (result) {
                    if (!this.CmSvc.chosen_route) {
                        this.CmSvc.chosen_route = 'map';
                        this.router.navigateByUrl(this.CmSvc.chosen_route);
                    }
                    resolve(true);
                } else {
                    reject();
                }
            }).catch(_ => {
                if (this.CmSvc.oList_Accessible_districtnex_module.find(oModule => oModule.Districtnex_module.NAME.toLowerCase() == "video ai")) {
                    this.router.navigateByUrl('/video-ai');
                }
                else if (this.CmSvc.oList_Accessible_districtnex_module.find(oModule => oModule.Districtnex_module.NAME.toLowerCase() == "reports")) {
                    this.router.navigateByUrl('/reports');
                }
                else {
                    this.router.navigateByUrl('/sign-out');
                }
                resolve(true);
            })
        });
    }
}
