import { Injectable } from '@angular/core';
import { Resolve, Router } from '@angular/router';
import { Observable, forkJoin } from 'rxjs';
import { CommonService } from './core/Services/common.service';
import { LogsService } from './core/Services/logs.service';
import { Proxy } from './core/Services/proxy.service';
import { AuthService } from './core/auth/auth.service';
import { SmartrSplashScreenService } from './shared/components/splash-screen/splash-screen.service';
import { SmartrNavigationService } from './shared/navigation/navigation.service';

@Injectable({
    providedIn: 'root'
})
export class InitialDataResolver implements Resolve<any> {
    constructor(
        private proxy: Proxy,
        private router: Router,
        private CmSvc: CommonService,
        private LogsService: LogsService,
        private _authService: AuthService,
        private _smartrNavigationService: SmartrNavigationService,
        private SmartrSplashScreenService: SmartrSplashScreenService,
    ) { }

    Get_Initial_Data(): Promise<void> {
        return new Promise((resolve, reject) => {
            if (this.CmSvc.oList_Accessible_districtnex_module.length > 0) {
                resolve();
            } else {
                this.proxy.Get_Initial_Data({ USER_ID: this.CmSvc.oUser_Details.USER_ID, ORGANIZATION_ID: this.CmSvc.oUser_Details.ORGANIZATION_ID }).subscribe(result => {
                    if (result) {
                        if (result.LIST_USER_DISTRICT_NEX_MODULE && result.LIST_USER_DISTRICT_NEX_MODULE.length > 0) {
                            this.CmSvc.oList_Dimension_chart_configuration = result.LIST_DIMENSION_CHART_CONFIGURATION;
                            this.CmSvc.oList_Kpi_chart_configuration = result.LIST_KPI_CHART_CONFIGURATION.sort((a, b) => {
                                if (a.CHART_ORDER === b.CHART_ORDER) {
                                    return result.LIST_KPI_CHART_CONFIGURATION.indexOf(a) - result.LIST_KPI_CHART_CONFIGURATION.indexOf(b);
                                }
                                return a.CHART_ORDER - b.CHART_ORDER;
                            });
                            this.CmSvc.oList_Specialized_chart_configuration = result.LIST_SPECIALIZED_CHART_CONFIGURATION;
                            this.CmSvc.oUser_Details.Organization.List_Organization_color_scheme = result.LIST_ORGANIZATION_COLOR_SCHEME;
                            localStorage.setItem("userDetails", JSON.stringify(this.CmSvc.oUser_Details));
                            this.CmSvc.oList_Setup_category = result.LIST_SETUP_CATEGORY;
                            this.CmSvc.oList_Setup = [].concat(...result.LIST_SETUP_CATEGORY.map(setup_category => setup_category.List_Setup));
                            this.CmSvc.oList_Accessible_districtnex_module = result.LIST_USER_DISTRICT_NEX_MODULE;
                            this.CmSvc.oList_Niche_categories = result.LIST_NICHE_CATEGORIES;
                            this.CmSvc.oList_Organization_Data_with_Accessible_Top_Level_Data = result.LIST_ORGANIZATION_DATA_WITH_ACCESSIBLE_TOP_LEVEL_DATA;

                            this.LogsService.oList_Log_Type_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Log Type").List_Setup;
                            this.LogsService.oList_Access_Type_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Access Type").List_Setup;
                            this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Signed In",
                                this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Sign In-Out").SETUP_ID,
                                this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Access").SETUP_ID);
                            this.CmSvc.oSignInSubject.next();

                            this._smartrNavigationService.get();
                            if (this.CmSvc.oUser_Details.USER_TYPE_SETUP_ID != this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("user type", "super admin")) {
                                this.CmSvc.oToggle_Module_Subject.next(true);
                            }
                            this.CmSvc.oUser_theme = result.USER_THEME;
                            let organization_ID = localStorage.getItem('organization_id');
                            let saved_top_level_id = localStorage.getItem('top_level_id');
                            if (this.CmSvc.CheckString(saved_top_level_id) && this.CmSvc.CheckString(organization_ID)) {
                                this.CmSvc.saved_top_level_id = Number.parseInt(saved_top_level_id);
                                this.CmSvc.saved_organization_id = Number.parseInt(organization_ID);
                                this.CmSvc.Set_Application_Theme();
                            }
                            else {
                                this.CmSvc.Set_Application_Theme();
                            }
                        } else {
                            this.SmartrSplashScreenService.hide();
                            reject("You do not have access to any modules.");
                        }
                        resolve();
                    }
                });
            }
        });
    }

    resolve(): Observable<any> {
        return forkJoin([
            this._smartrNavigationService.get(),
            this.Get_Initial_Data().catch(error => {
                if (error) {
                    this.CmSvc.ShowMessage(error);
                }
                this._authService.signOut();
                this.router.navigate(['/sign-in']);
                this.CmSvc.oSignOutSubject.next();
            }),
        ]);
    }
}
