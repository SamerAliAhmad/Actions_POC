import { Router } from '@angular/router';
import { Clipboard } from '@angular/cdk/clipboard';
import { Component, Inject, OnInit } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';
import { Organization, Setup, User } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'create-user-modal',
    templateUrl: './create-user-modal.component.html',
    styleUrls: ['./create-user-modal.component.scss']
})
export class CreateUserModalComponent implements OnInit {

    userForm: FormGroup;

    isLoading = false;
    passwordStrength = 0;
    oList_Organization_User_Type_Setup: Setup[];

    constructor(
        private router: Router,
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private Clipboard: Clipboard,
        private _formBuilder: FormBuilder,
        @Inject(MAT_DIALOG_DATA) public oOrganization: Organization,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        if (this.CmSvc.oUser_Details.User_type_setup.VALUE == 'Super Admin') {
            this.oList_Organization_User_Type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup;
        }
        else {
            this.oList_Organization_User_Type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup.filter(userType => userType.VALUE != 'Super Admin');
        }
    }

    ngOnInit(): void {
        this.userForm = this.initializeForm();
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            FIRST_NAME: ['', [Validators.required]],
            LAST_NAME: ['', [Validators.required]],
            PHONE_NUMBER: ['', [Validators.pattern('[ 0-9-+]*'), Validators.minLength(5), Validators.required]],
            EMAIL: ['', [Validators.required, Validators.pattern(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/)]],
            USERNAME: ['', [Validators.required]],
            PASSWORD: ['', [Validators.required, Validators.minLength(6)]],
            CONFIRM_PASSWORD: ['', [Validators.required, Validators.minLength(6)]],
            USER_TYPE_SETUP_ID: [null, Validators.required]
        });
    };

    checkPasswords(): boolean {
        let pass = this.userForm.get('PASSWORD').value;
        let confirmPass = this.userForm.get('CONFIRM_PASSWORD').value;
        return this.CmSvc.Are_Passwords_Equal(pass, confirmPass);
    }

    createUser(): void {
        if (this.checkPasswords()) {
            if (this.passwordStrength <= 2) {
                this.CmSvc.ShowMessage("Password is not strong enough");
                return;
            }
            this.userForm.disable();
            this.isLoading = true;
            const oUser = new User();
            oUser.USER_ID = -1;
            oUser.USER_TYPE_SETUP_ID = this.userForm.controls.USER_TYPE_SETUP_ID.value;
            oUser.EMAIL = this.userForm.controls.EMAIL.value;
            oUser.PASSWORD = this.userForm.controls.PASSWORD.value;
            oUser.LAST_NAME = this.userForm.controls.LAST_NAME.value;
            oUser.FIRST_NAME = this.userForm.controls.FIRST_NAME.value;
            oUser.PHONE_NUMBER = this.userForm.controls.PHONE_NUMBER.value;
            oUser.USERNAME = this.userForm.controls.USERNAME.value;
            oUser.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
            this.OrganizationManagementService.Create_User(this.oOrganization, oUser).then(result => {
                if (result) {
                    this.router.navigateByUrl(this.router.url + "/" + result.USER_ID);
                    this.dialog.closeAll();
                }
                this.isLoading = false;
                this.userForm.enable();
            })

        }
        else {
            this.CmSvc.ShowMessage('Passwords Don\'t Match! Try Again.');
        }
    }

    autoGeneratePassword() {
        let generatedPassword = this.CmSvc.Generate_Random_String(12);
        this.userForm.patchValue({
            PASSWORD: generatedPassword,
            CONFIRM_PASSWORD: generatedPassword
        });
        this.Clipboard.copy(generatedPassword);
        this.CmSvc.ShowMessage("Password copied to clipboard");
    }
}
