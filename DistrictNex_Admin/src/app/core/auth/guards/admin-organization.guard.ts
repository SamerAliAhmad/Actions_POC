import { Injectable } from '@angular/core';
import { CanActivate, Router, UrlTree } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class AdminOrganizationGuard implements CanActivate {
    constructor(
        private router: Router,
        private CmSvc: CommonService,
    ) { }

    canActivate(): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
        if (this.CmSvc.oOrganization.Organization_type_setup.VALUE == 'Super Organization') {
            return true;
        } else {
            this.router.navigateByUrl('/my-organization/user-management');
            return false;
        }
    }

}
