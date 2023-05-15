import { Injectable } from '@angular/core';
import { Resolve } from '@angular/router';
import { ColoringService } from 'app/shared/services/coloring.service';
import { forkJoin, Observable } from 'rxjs';
import { AuthService } from './core/auth/auth.service';
import { CommonService } from './core/Services/common.service';
import { Params_Get_Admin_Data, Proxy } from './core/Services/proxy.service';
import { SmartrNavigationService } from './shared/navigation/navigation.service';

@Injectable({
    providedIn: 'root'
})
export class InitialDataResolver implements Resolve<any> {
    favIcon: HTMLLinkElement;
    loaderImage: HTMLImageElement;

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
        private AuthService: AuthService,
        private ColoringService: ColoringService,
        private _smartrNavigationService: SmartrNavigationService,
    ) {
        this.favIcon = document.querySelector('#appIcon');
        this.loaderImage = document.getElementById('appLogo') as HTMLImageElement;
    }

    Get_Admin_Data(): Promise<any> {
        return new Promise((resolve, reject) => {
            let oParams_Get_Admin_Data = new Params_Get_Admin_Data();
            oParams_Get_Admin_Data.USER_ID = this.CmSvc.oUser_Details.USER_ID;
            oParams_Get_Admin_Data.IS_GET_IMAGES_FROM_Cloud = true;
            this.proxy.Get_Admin_Data(oParams_Get_Admin_Data).subscribe(result => {
                if (result) {
                    result.List_Setup_category = result.List_Setup_category.filter(setup_category => !setup_category.IS_DELETED);
                    result.List_Setup_category.forEach(setup_category => {
                        setup_category.List_Setup = setup_category.List_Setup.filter(setup => !setup.IS_DELETED).sort((a, b) => a.DISPLAY_ORDER - b.DISPLAY_ORDER);
                    });
                    this.CmSvc.oOrganization = result.Organization;
                    this.CmSvc.oList_Setup_category = result.List_Setup_category;
                    this.CmSvc.oList_Setup = [].concat(...result.List_Setup_category.map(setup_category => setup_category.List_Setup));
                    this.CmSvc.oList_Dimension = result.List_Dimension;
                    this.CmSvc.oList_Site = result.List_Site.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    this.CmSvc.oList_Entity = result.List_Entity.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    this.CmSvc.NUMBER_OF_USERS = result.NUMBER_OF_USERS;
                    this.CmSvc.oList_Kpi = [].concat(...result.List_Dimension.map(dimension => dimension.List_Kpi));
                    this.CmSvc.oList_Districtnex_module = result.List_Districtnex_module;

                    if (result.Organization.List_Organization_color_scheme[0]) {
                        localStorage.setItem('dnaPrimaryColor', result.Organization.List_Organization_color_scheme[0].PLATFORM_PRIMARY);
                        localStorage.setItem('dnaSecondaryColor', result.Organization.List_Organization_color_scheme[0].PLATFORM_BUTTON);

                        document.documentElement.style.setProperty('--chart1-color', result.Organization.List_Organization_color_scheme[0].List_Organization_chart_color[0].COLOR);
                        localStorage.setItem('dnaChart1Color', result.Organization.List_Organization_color_scheme[0].List_Organization_chart_color[0].COLOR);
                        document.documentElement.style.setProperty('--chart2-color', result.Organization.List_Organization_color_scheme[0].List_Organization_chart_color[0].COLOR);
                        localStorage.setItem('dnaChart2Color', result.Organization.List_Organization_color_scheme[0].List_Organization_chart_color[0].COLOR);
                        document.documentElement.style.setProperty('--chart3-color', result.Organization.List_Organization_color_scheme[0].List_Organization_chart_color[0].COLOR);
                        localStorage.setItem('dnaChart3Color', result.Organization.List_Organization_color_scheme[0].List_Organization_chart_color[0].COLOR);

                        this.ColoringService.generateThemeColor(result.Organization.List_Organization_color_scheme[0].PLATFORM_PRIMARY)
                        document.documentElement.style.setProperty('--smartr-button', result.Organization.List_Organization_color_scheme[0].PLATFORM_BUTTON);

                        if (this.CmSvc.isDark(result.Organization.List_Organization_color_scheme[0].PLATFORM_BUTTON)) {
                            document.documentElement.style.setProperty('--smartr-button-text', 'white')
                        } else {
                            document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
                        }
                    } else {
                        localStorage.setItem('dnaPrimaryColor', this.CmSvc.defaultSettings.PLATFORM_PRIMARY);
                        localStorage.setItem('dnaSecondaryColor', this.CmSvc.defaultSettings.PLATFORM_BUTTON);
                        document.documentElement.style.setProperty('--chart1-color', this.CmSvc.defaultSettings.List_Default_chart_color[0].COLOR);
                        document.documentElement.style.setProperty('--chart2-color', this.CmSvc.defaultSettings.List_Default_chart_color[1].COLOR);
                        document.documentElement.style.setProperty('--chart3-color', this.CmSvc.defaultSettings.List_Default_chart_color[2].COLOR);
                        localStorage.setItem('dnaChart1Color', this.CmSvc.defaultSettings.List_Default_chart_color[0].COLOR);
                        localStorage.setItem('dnaChart2Color', this.CmSvc.defaultSettings.List_Default_chart_color[1].COLOR);
                        localStorage.setItem('dnaChart3Color', this.CmSvc.defaultSettings.List_Default_chart_color[2].COLOR);

                        this.ColoringService.generateThemeColor(this.CmSvc.defaultSettings.PLATFORM_PRIMARY)
                        document.documentElement.style.setProperty('--smartr-button', this.CmSvc.defaultSettings.PLATFORM_BUTTON);

                        if (this.CmSvc.isDark(this.CmSvc.defaultSettings.PLATFORM_BUTTON)) {
                            document.documentElement.style.setProperty('--smartr-button-text', 'white')
                        } else {
                            document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
                        }
                    }

                    if (result.Organization.ORGANIZATION_FAVICON_URL) {
                        this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL = result.Organization.ORGANIZATION_FAVICON_URL;
                    } else {
                        if (this.CmSvc.defaultSettings.ORGANIZATION_FAVICON_URL) {
                            this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL = this.CmSvc.defaultSettings.ORGANIZATION_FAVICON_URL;
                        }
                    }

                    if (result.Organization.DARK_RECTANGLE_LOGO_URL) {
                        this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL = result.Organization.DARK_RECTANGLE_LOGO_URL;
                    } else {
                        if (this.CmSvc.defaultSettings.DARK_RECTANGLE_LOGO_URL) {
                            this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL = this.CmSvc.defaultSettings.DARK_RECTANGLE_LOGO_URL;
                        }
                    }

                    if (result.Organization.DARK_SQUARE_LOGO_URL) {
                        this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL = result.Organization.DARK_SQUARE_LOGO_URL;
                    } else {
                        if (this.CmSvc.defaultSettings.DARK_SQUARE_LOGO_URL) {
                            this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL = this.CmSvc.defaultSettings.DARK_SQUARE_LOGO_URL;
                        }
                    }

                    if (result.Organization.LIGHT_RECTANGLE_LOGO_URL) {
                        this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL = result.Organization.LIGHT_RECTANGLE_LOGO_URL;
                    } else {
                        if (this.CmSvc.defaultSettings.LIGHT_RECTANGLE_LOGO_URL) {
                            this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL = this.CmSvc.defaultSettings.LIGHT_RECTANGLE_LOGO_URL;
                        }
                    }

                    if (result.Organization.LIGHT_SQUARE_LOGO_URL) {
                        this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL = result.Organization.LIGHT_SQUARE_LOGO_URL
                    } else {
                        if (this.CmSvc.defaultSettings.LIGHT_SQUARE_LOGO_URL) {
                            this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL = this.CmSvc.defaultSettings.LIGHT_SQUARE_LOGO_URL;
                        }
                    }
                    this.favIcon.href = this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL;
                    this.loaderImage.src = this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL;
                    localStorage.setItem('dna_favi_ico_url', this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL);
                    localStorage.setItem('dna_dark_logo_url', this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL);
                    localStorage.setItem('dna_light_logo_url', this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL);
                    localStorage.setItem('dna_dark_logo_square_url', this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL);
                    localStorage.setItem('dna_light_logo_square_url', this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL);
                    setTimeout(() => {
                        this.CmSvc.signInSubject.next();
                    }, 300);
                    resolve(true);
                } else {
                    this.AuthService.signOut();
                    resolve(null);
                }
            }, reject);
        });
    }
    resolve(): Observable<any> {
        return forkJoin([
            this.Get_Admin_Data(),
            this._smartrNavigationService.get(),
        ]);
    }
}
