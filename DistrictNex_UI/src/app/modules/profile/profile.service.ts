import { Injectable } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { Params_Change_Password, Params_Edit_User_Details, Proxy, User_Details } from 'app/core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class ProfileService {

    constructor(
        private proxy: Proxy,
        private CmSvc: CommonService,
    ) { }

    Edit_User_Details(userDetails: User_Details): Promise<boolean> {
        return new Promise(resolve => {
            const oParams_Edit_User_Details = new Params_Edit_User_Details();
            oParams_Edit_User_Details.PHONE_NUMBER = userDetails.PHONE_NUMBER;
            oParams_Edit_User_Details.USER_ID = userDetails.USER_ID;

            this.proxy.Edit_User_Details(oParams_Edit_User_Details)
                .subscribe(result => {
                    if (result) {
                        this.CmSvc.ShowMessage('Success!');
                        resolve(true);
                    } else {
                        this.CmSvc.ShowMessage('Error, Wrong Data Input.');
                        resolve(false);
                    }
                },
                    error => {
                        this.CmSvc.ShowMessage(error)
                        resolve(false);
                    });
        })
    }

    Change_Password(oldPassword, newPassword): Promise<boolean> {
        return new Promise(resolve => {
            const oParams_Change_Password = new Params_Change_Password();
            oParams_Change_Password.OLD_PASSWORD = oldPassword;
            oParams_Change_Password.NEW_PASSWORD = newPassword;
            oParams_Change_Password.USER_ID = this.CmSvc.oUser_Details.USER_ID;

            this.proxy.Change_Password(oParams_Change_Password).subscribe(result => {
                if (result) {
                    this.CmSvc.ShowMessage("Success!");
                    resolve(true);
                } else {
                    resolve(false);
                }
            })
        })
    }
}
