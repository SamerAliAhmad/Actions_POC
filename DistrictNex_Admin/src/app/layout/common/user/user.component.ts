import { BooleanInput } from '@angular/cdk/coercion';
import { ChangeDetectionStrategy, Component, Input, ViewEncapsulation } from '@angular/core';
import { Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { User_Details } from 'app/core/Services/proxy.service';
import { SharedService } from 'app/shared/services/shared.service';
import { BdcWalkService } from 'bdc-walkthrough';

@Component({
    selector: 'user',
    templateUrl: './user.component.html',
    encapsulation: ViewEncapsulation.None,
    changeDetection: ChangeDetectionStrategy.OnPush,
    exportAs: 'user'
})
export class UserComponent {
    static ngAcceptInputType_showAvatar: BooleanInput;

    @Input() showAvatar: boolean = true;
    userDetails: User_Details;

    constructor(
        private _router: Router,
        private CmSvc: CommonService,
        private SharedService: SharedService,
        private BdcWalkService: BdcWalkService,
    ) {
        this.userDetails = this.CmSvc.oUser_Details;
    }
    goToProfile(): void {
        this._router.navigate(['/profile']);
    }
    signOut(): void {
        this._router.navigate(['/sign-out']);
    }
    resetGuide() {
        this.BdcWalkService.reset();
        this.SharedService.Edit_User_Walkthrough();
    }
}
