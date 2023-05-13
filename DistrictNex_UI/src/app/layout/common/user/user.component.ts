import { ChangeDetectionStrategy, Component, ViewEncapsulation } from '@angular/core';
import { Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { User_Details } from 'app/core/Services/proxy.service';
import { SharedService } from 'app/shared/services/shared.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { BdcWalkService } from 'bdc-walkthrough';


@Component({
    selector: 'user',
    templateUrl: './user.component.html',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    exportAs: 'user'
})
export class UserComponent {

    isSuperAdmin = false;

    oUser_Details: User_Details;

    constructor(
        private _router: Router,
        private CmSvc: CommonService,
        private SharedService: SharedService,
        private BdcWalkService: BdcWalkService,
        public TimezoneService: TimezoneService,
    ) {
        this.oUser_Details = this.CmSvc.oUser_Details;
        this.isSuperAdmin = (this.oUser_Details.USER_TYPE_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("user type", "super admin"));
    }
    goToProfile(): void {
        this._router.navigate(['/profile']);
    }
    changeOrganization() {
        if (this.isSuperAdmin) {
            this.CmSvc.oToggle_Change_Organization_Subject.next();
        }
    }
    signOut(): void {
        this._router.navigate(['/sign-out']);
    }
    resetGuide() {
        this.BdcWalkService.reset();
        this.CmSvc.oResetBdcWalkthroughSubject.next();
        this.SharedService.Edit_User_Walkthrough();
    }
}
