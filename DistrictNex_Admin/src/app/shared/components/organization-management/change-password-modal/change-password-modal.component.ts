import { Clipboard } from '@angular/cdk/clipboard';
import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { CommonService } from 'app/core/Services/common.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'change-password-modal',
    templateUrl: './change-password-modal.component.html',
    styleUrls: ['./change-password-modal.component.scss']
})
export class ChangePasswordModalComponent implements OnInit {

    changePasswordForm: FormGroup;
    loading = false;
    passwordStrength = 0;

    constructor(
        public dialog: MatDialog,
        private Clipboard: Clipboard,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private OrganizationManagementService: OrganizationManagementService,
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
        let confirmPass = this.changePasswordForm.get('confirmPassword').value
        return this.CmSvc.Are_Passwords_Equal(pass, confirmPass);
    }

    changePassword() {
        if (this.changePasswordForm.valid) {
            if (this.checkPasswords()) {
                if (this.passwordStrength <= 2) {
                    this.CmSvc.ShowMessage("Password is not strong enough");
                    return;
                }
                this.loading = true;
                this.OrganizationManagementService.changeUserPassword(this.data.UserID, this.changePasswordForm.get('newPassword').value).then(result => {
                    if (result) {
                        this.dialog.closeAll();
                        this.changePasswordForm = this.initializePasswordForm();
                    }
                    this.loading = false;
                })
            } else {
                this.CmSvc.ShowMessage('Passwords Do Not Match!');
            }
        }
        else {
            this.CmSvc.ShowMessage('Invalid Inputs');
        }
    }

    autoGeneratePassword() {
        let generatedPassword = this.CmSvc.Generate_Random_String(12);
        this.changePasswordForm.patchValue({
            newPassword: generatedPassword,
            confirmPassword: generatedPassword
        });
        this.Clipboard.copy(generatedPassword);
        this.CmSvc.ShowMessage("Password copied to clipboard");
    }
}
