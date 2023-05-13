import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Proxy, User_theme } from 'app/core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class SharedService {
    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
    ) {
    }

    Edit_User_theme(i_User_theme: User_theme): Promise<User_theme> {
        return new Promise((resolve, reject) => {
            this.proxy.Edit_User_theme(i_User_theme).subscribe(result => {
                if (result) {
                    this.CmSvc.oUser_theme = result;
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Edit_User_Walkthrough() {
        if (this.CmSvc.oUser_Details) {
            this.CmSvc.oUser_Details.USER_DISTRICTNEX_WALKTHROUGH = localStorage.getItem('bdcWalkthrough');
            localStorage.setItem("userDetails", JSON.stringify(this.CmSvc.oUser_Details));
            this.proxy.Edit_User_Walkthrough({
                IS_ADMIN_UI: false,
                USER_WALKTHROUGH: localStorage.getItem('bdcWalkthrough'),
            }).subscribe();
        }
    }

}
