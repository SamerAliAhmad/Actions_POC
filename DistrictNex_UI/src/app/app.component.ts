import { ChangeDetectorRef, Component, HostListener, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BdcWalkService } from 'bdc-walkthrough';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { openDistrictInsightSubject, requestOpenDistrictInsightSubject } from './core/Models/constants';
import { CommonService } from './core/Services/common.service';
import { LogsService } from './core/Services/logs.service';
import { SharedService } from './shared/services/shared.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, OnDestroy {
    favIcon: HTMLLinkElement = document.querySelector('#appIcon');
    popupLogoUrl: string;
    changeOnce = false;
    isSignedIn = false;

    private _unsubscribeAll = new Subject<void>();
    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private LogsService: LogsService,
        private SharedService: SharedService,
        private BdcWalkService: BdcWalkService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        document.documentElement.style.setProperty('--smartr-primary', '#4B286D');
        document.documentElement.style.setProperty('--smartr-button', '#8f3293');
        if (localStorage.getItem('dnexPrimaryColor')) {
            document.documentElement.style.setProperty('--smartr-primary', localStorage.getItem('dnexPrimaryColor'));
        }
        if (localStorage.getItem('dnexSecondaryColor')) {
            document.documentElement.style.setProperty('--smartr-button', localStorage.getItem('dnexSecondaryColor'));
        }
        if (localStorage.getItem('dnex_favi_ico_url') && localStorage.getItem('dnex_favi_ico_url') != "null") {
            this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL = localStorage.getItem('dnex_favi_ico_url');
        } else {
            this.favIcon.href = this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL;
        }
        if (localStorage.getItem('dnex_dark_logo_url') && localStorage.getItem('dnex_dark_logo_url') != "null") {
            this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL = localStorage.getItem('dnex_dark_logo_url');
        }
        if (localStorage.getItem('dnex_light_logo_url') && localStorage.getItem('dnex_light_logo_url') != "null") {
            this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL = localStorage.getItem('dnex_light_logo_url');
        }
        this.popupLogoUrl = this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL;
    }

    ngOnInit() {
        requestOpenDistrictInsightSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            if (this.router.url.split('/').pop() == 'map') {
                openDistrictInsightSubject.next();
            } else {
                this.CmSvc.ShowMessage("This Feature is Only Available in the Map.", 3000);
            }
        });

        this.CmSvc.oToggle_Alerts_Drawer_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_ => {
            if (this.router.url.split('/').pop() != 'map') {
                this.CmSvc.ShowMessage("This Feature is Only Available in the Map.", 3000);
            }
        })

        this.CmSvc.oSignInSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isSignedIn = true;
        });

        this.CmSvc.oSignedOutSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isSignedIn = false;
            this._changeDetectorRef.detectChanges();
        });

        this.CmSvc.oUpdateApplicationImagesSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.favIcon.href = this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL;
            this.popupLogoUrl = this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL;
            if (this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-primary'))) {
                (document.getElementById('appLogo') as HTMLImageElement).src = this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL;
            }
            else if (!this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-primary'))) {
                (document.getElementById('appLogo') as HTMLImageElement).src = this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL;
            }
        });
    }

    @HostListener('window: beforeunload')
    unloadHandler() {
        if (this.CmSvc.oUser_Details?.USER_DISTRICTNEX_WALKTHROUGH && localStorage.getItem('bdcWalkthrough') && this.CmSvc.oUser_Details?.USER_DISTRICTNEX_WALKTHROUGH != localStorage.getItem('bdcWalkthrough')) {
            this.SharedService.Edit_User_Walkthrough();
        }
        if (this.CmSvc.oUser_Accessible_Data) {
            this.LogsService.Record_Logs(this.CmSvc.oUser_Details.FIRST_NAME + " " + this.CmSvc.oUser_Details.LAST_NAME + " Has Signed Out",
                this.LogsService.oList_Log_Type_Setup.find(setup => setup.VALUE == "Sign In-Out").SETUP_ID,
                this.LogsService.oList_Access_Type_Setup.find(setup => setup.VALUE == "Exit").SETUP_ID);
        }
        openDistrictInsightSubject.unsubscribe();
        requestOpenDistrictInsightSubject.unsubscribe();
        return true;
    }

    changeImage() {
        if (!this.changeOnce) {
            this.popupLogoUrl = this.CmSvc.oDefaultSettings.DARK_SQUARE_LOGO_URL;
        } else {
            this.popupLogoUrl = 'assets/images/logo/picacity/logo-black-square.png';
        }
        this.changeOnce = true;
    }
    skipTutorial() {
        this.BdcWalkService.setTaskCompleted('introModal', true);
        this.BdcWalkService.setTaskCompleted('mapPopup1', true);
        this.BdcWalkService.setTaskCompleted('dialogPopup1', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup1', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup2', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup3', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup4', true);
        this.BdcWalkService.setTaskCompleted('drawerPopup5', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup1', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup2', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup3', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup4', true);
        this.BdcWalkService.setTaskCompleted('drawerExtraPopup5', true);
        this.BdcWalkService.setTaskCompleted('reportPopup1', true);
        this.BdcWalkService.setTaskCompleted('reportPopup2', true);
        this.BdcWalkService.setTaskCompleted('reportPopup3', true);
        this.BdcWalkService.setTaskCompleted('videoPopup1', true);
        this.BdcWalkService.setTaskCompleted('videoPopup2', true);
        this.BdcWalkService.setTaskCompleted('levelSwitchPopup', true);
        this.BdcWalkService.setTaskCompleted('hoverPopup', true);
    }


    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
        if (localStorage.getItem('bdcWalkthrough') && this.CmSvc.oUser_Details?.USER_ADMIN_WALKTHROUGH != localStorage.getItem('bdcWalkthrough')) {
            this.SharedService.Edit_User_Walkthrough();
        }
    }
}
