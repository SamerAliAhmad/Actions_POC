import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Proxy } from 'app/core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class SharedService {

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService
    ) { }

    Edit_User_Walkthrough() {
        if (this.CmSvc.oUser_Details) {
            this.CmSvc.oUser_Details.USER_ADMIN_WALKTHROUGH = localStorage.getItem('bdcWalkthrough');
            localStorage.setItem("userDetails", JSON.stringify(this.CmSvc.oUser_Details));
            this.proxy.Edit_User_Walkthrough({
                IS_ADMIN_UI: true,
                USER_WALKTHROUGH: localStorage.getItem('bdcWalkthrough'),
            }).subscribe();
        }
    }
}
