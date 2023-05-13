import { NgModule } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { ColoringService } from 'app/shared/services/coloring.service';
import { SmartrSplashScreenService } from './splash-screen.service';

@NgModule({
    providers: [
        SmartrSplashScreenService
    ]
})
export class SmartrSplashScreenModule {
    constructor(
        private CmSvc: CommonService,
        private ColoringService: ColoringService,
        private _smartrSplashScreenService: SmartrSplashScreenService
    ) {

        if (localStorage.getItem('dnexPrimaryColor')) {
            this.ColoringService.generateThemeColor(localStorage.getItem('dnexPrimaryColor'));
        } else {
            this.ColoringService.generateThemeColor(this.CmSvc.oDefaultSettings.PLATFORM_PRIMARY);

            localStorage.setItem('dnexPrimaryColor', this.CmSvc.oDefaultSettings.PLATFORM_PRIMARY);
        }
        if (localStorage.getItem('dnexSecondaryColor')) {
            document.documentElement.style.setProperty('--smartr-button', localStorage.getItem('dnexSecondaryColor'));

            if (this.CmSvc.isDark(localStorage.getItem('dnexSecondaryColor'))) {
                document.documentElement.style.setProperty('--smartr-button-text', 'white')
            } else {
                document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
            }
        } else {
            document.documentElement.style.setProperty('--smartr-button', this.CmSvc.oDefaultSettings.PLATFORM_BUTTON);
            localStorage.setItem('dnexSecondaryColor', this.CmSvc.oDefaultSettings.PLATFORM_BUTTON);

            if (this.CmSvc.isDark(this.CmSvc.oDefaultSettings.PLATFORM_BUTTON)) {
                document.documentElement.style.setProperty('--smartr-button-text', 'white')
            } else {
                document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
            }
        }
    }
}
