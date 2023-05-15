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
        private _smartrSplashScreenService: SmartrSplashScreenService,
    ) {
        if (localStorage.getItem('dnaPrimaryColor')) {
            this.ColoringService.generateThemeColor(localStorage.getItem('dnaPrimaryColor'));
        } else {
            this.ColoringService.generateThemeColor(this.CmSvc.defaultSettings.PLATFORM_PRIMARY)
            localStorage.setItem('dnaPrimaryColor', this.CmSvc.defaultSettings.PLATFORM_PRIMARY);
        }
        if (localStorage.getItem('dnaSecondaryColor')) {
            document.documentElement.style.setProperty('--smartr-button', localStorage.getItem('dnaSecondaryColor'));

            if (this.CmSvc.isDark(localStorage.getItem('dnaSecondaryColor'))) {
                document.documentElement.style.setProperty('--smartr-button-text', 'white')
            } else {
                document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
            }
        } else {
            document.documentElement.style.setProperty('--smartr-button', this.CmSvc.defaultSettings.PLATFORM_BUTTON);
            localStorage.setItem('dnaSecondaryColor', this.CmSvc.defaultSettings.PLATFORM_BUTTON);

            if (this.CmSvc.isDark(this.CmSvc.defaultSettings.PLATFORM_BUTTON)) {
                document.documentElement.style.setProperty('--smartr-button-text', 'white')
            } else {
                document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
            }
        }
    }
}
