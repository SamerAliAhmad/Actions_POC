import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CommonService } from 'app/core/Services/common.service';
import { Params_Send_Share_Link_By_Email } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';

@Component({
    selector: 'share-email-modal',
    templateUrl: './share-email-modal.component.html',
    styleUrls: ['./share-email-modal.component.scss']
})
export class ShareEmailModalComponent {

    isLoading = false;
    oList_Selected_email: string[] = [];

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        @Inject(MAT_DIALOG_DATA) public oLink: string,
        private dialogRef: MatDialogRef<ShareEmailModalComponent>
    ) { }

    sendEmail() {
        if (this.oList_Selected_email.length == 0) {
            this.CmSvc.ShowMessage("Choose at least 1 email");
            return;
        }
        const oParams_Send_Share_Link_By_Email = new Params_Send_Share_Link_By_Email();
        oParams_Send_Share_Link_By_Email.List_Email = this.oList_Selected_email;
        oParams_Send_Share_Link_By_Email.SHARE_DATA_LINK = this.oLink;
        this.MapService.Send_Share_Link_By_Email(oParams_Send_Share_Link_By_Email).then(() => {
            this.dialogRef.close();
            this.CmSvc.ShowMessage("Email will be sent shortly");
        });
    }

    addEmailByEnter(event: KeyboardEvent, emailInput: HTMLInputElement) {
        if (event.key == 'Enter') {
            this.addEmail(emailInput.value);
            emailInput.value = '';
        }
    }

    addEmail(email: string) {
        if (!/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email)) {
            this.CmSvc.ShowMessage("You have entered an invalid email address!");
            return;
        }
        if (this.oList_Selected_email.includes(email)) {
            this.CmSvc.ShowMessage("Email already added");
            return;
        }
        this.oList_Selected_email.push(email);
    }

    removeEmail(emailIndex: number) {
        this.oList_Selected_email.splice(emailIndex, 1);
    }
}
