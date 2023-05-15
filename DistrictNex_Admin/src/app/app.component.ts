import { ChangeDetectorRef, Component, HostListener, OnDestroy, OnInit } from '@angular/core';
import { BdcWalkService } from 'bdc-walkthrough';
import { Subject, takeUntil } from 'rxjs';
import { CommonService } from './core/Services/common.service';
import { SharedService } from './shared/services/shared.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, OnDestroy {
    popupLogoUrl: string;
    changeOnce = false;
    isSignedIn = false;

    private _unsubscribeAll = new Subject<void>();
    constructor(
        private CmSvc: CommonService,
        private SharedService: SharedService,
        private BdcWalkService: BdcWalkService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.popupLogoUrl = this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL;
    }

    @HostListener('window: beforeunload ')
    unloadHandler() {
        if (localStorage.getItem('bdcWalkthrough') && this.CmSvc.oUser_Details?.USER_ADMIN_WALKTHROUGH != localStorage.getItem('bdcWalkthrough')) {
            this.SharedService.Edit_User_Walkthrough();
        }
    }

    ngOnInit(): void {
        this.CmSvc.signInSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isSignedIn = true;
        });

        this.CmSvc.signedOutSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.isSignedIn = false;
            this._changeDetectorRef.detectChanges();
        });
    }

    changeImage() {
        if (!this.changeOnce) {
            this.popupLogoUrl = this.CmSvc.defaultSettings.DARK_SQUARE_LOGO_URL;
        } else {
            this.popupLogoUrl = 'assets/images/logo/telus/logo-black-square.png';
        }
        this.changeOnce = true;
    }

    skipTutorial() {
        this.BdcWalkService.setTaskCompleted('introModal', true);
        this.BdcWalkService.setTaskCompleted('dashboardPopup1', true);
        this.BdcWalkService.setTaskCompleted('logsPopup1', true);
        this.BdcWalkService.setTaskCompleted('logsPopup2', true);
        this.BdcWalkService.setTaskCompleted('organizationDataSettingsPopup1', true);
        this.BdcWalkService.setTaskCompleted('organizationGeneralDetailsPopup1', true);
        this.BdcWalkService.setTaskCompleted('organizationAccessControlPopup1', true);
        this.BdcWalkService.setTaskCompleted('userAccessControlPopup1', true);
        this.BdcWalkService.setTaskCompleted('userInfoPopup1', true);
        this.BdcWalkService.setTaskCompleted('settingsPopup1', true);
        this.BdcWalkService.setTaskCompleted('settingsPopup2', true);
        this.BdcWalkService.setTaskCompleted('settingsPopup3', true);
        this.BdcWalkService.setTaskCompleted('settingsPopup4', true);
        this.BdcWalkService.setTaskCompleted('settingsPopup5', true);
    }

    ngOnDestroy(): void {
        if (localStorage.getItem('bdcWalkthrough') && this.CmSvc.oUser_Details?.USER_ADMIN_WALKTHROUGH != localStorage.getItem('bdcWalkthrough')) {
            this.SharedService.Edit_User_Walkthrough();
        }
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
