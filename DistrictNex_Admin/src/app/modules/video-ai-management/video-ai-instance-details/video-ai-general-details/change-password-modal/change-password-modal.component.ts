import { Component, Inject, OnInit } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { VideoAiInstanceDetailsService } from '../../video-ai-instance-details.service';

@Component({
    selector: 'change-password-modal',
    templateUrl: './change-password-modal.component.html',
    styleUrls: ['./change-password-modal.component.scss']
})

export class ChangeInstancePasswordModalComponent implements OnInit {

    changePasswordForm: FormGroup;

    isLoading = false;
    isForceConnection = false;
    isShowForceConnection = false;

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private VideoAiInstanceDetailsService: VideoAiInstanceDetailsService
    ) { }

    ngOnInit(): void {
        this.changePasswordForm = this.initializePasswordForm();
    }

    initializePasswordForm() {
        return this._formBuilder.group({
            newPassword: ['', [Validators.required, Validators.minLength(6)]],
            confirmPassword: ['', [Validators.required]],
        })
    }

    checkPasswords(): boolean {
        let pass = this.changePasswordForm.get('newPassword').value;
        let confirmPass = this.changePasswordForm.get('confirmPassword').value;
        return this.CmSvc.Are_Passwords_Equal(pass, confirmPass);
    }

    changePassword() {
        if (this.changePasswordForm.valid) {
            if (this.checkPasswords()) {
                this.isLoading = true;
                this.VideoAiInstanceDetailsService.changeInstancePassword(this.changePasswordForm.get('newPassword').value, this.data.video_ai_instance_id, this.isForceConnection).then(result => {
                    if (result?.SUCCESSFUL_PASSWORD_CHANGE) {
                        this.CmSvc.Handle_Success();
                        this.dialog.closeAll();
                    }
                    if (result?.IS_FORCE_CONNECTION) {
                        this.isShowForceConnection = true;
                        this.CmSvc.ShowMessage(result?.RESPONSE_MESSAGE);
                    }
                    this.isLoading = false;
                })
            } else {
                this.CmSvc.ShowMessage('Passwords Do Not Match!');
            }
        }
        else {
            this.CmSvc.ShowMessage('Invalid Input');
        }
    }

}
