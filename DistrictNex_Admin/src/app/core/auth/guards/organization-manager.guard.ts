import { Injectable } from '@angular/core';
import { CanActivate, Router, UrlTree } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class OrganizationManagerGuard implements CanActivate {
    constructor(
        private router: Router,
        private CmSvc: CommonService,
    ) { }

    canActivate(): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        if (this.CmSvc.oUser_Details && this.CmSvc.oUser_Details.User_type_setup && this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin") {
            return true;
        } else {
            this.router.navigateByUrl('/my-organization/user-management');
            return false;
        }
    }
}
