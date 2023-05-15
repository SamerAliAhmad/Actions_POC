import { Subject } from 'rxjs';
import { ProfileService } from './profile.service';
import { Clipboard } from '@angular/cdk/clipboard';
import { MatDialog } from '@angular/material/dialog';
import { environment } from 'environments/environment';
import { User_Details } from 'app/core/Services/proxy.service';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ChangeDetectorRef, Component, HostListener, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

@Component({
    selector: 'profile',
    templateUrl: './profile.component.html',
    styleUrls: ['./profile.component.scss']
})

export class ProfileComponent implements OnInit {

    profileForm: FormGroup;
    changePasswordForm: FormGroup;

    isLoading = false;
    isEditMode = false;
    isMobileView = false;
    isThereChange = false;

    oUser_Details: User_Details;

    Build_Number = '';
    passwordStrength = 0;

    @ViewChild('changePasswordDialog', { static: true }) changePasswordDialog: TemplateRef<any>;

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private _router: Router,
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private Clipboard: Clipboard,
        private _formBuilder: FormBuilder,
        private profileService: ProfileService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.Build_Number = environment.Build_Number;
        this.oUser_Details = this.CmSvc.oUser_Details;
    }

    ngOnInit(): void {
        this.isMobileView = window.innerWidth < 600;

        this.profileForm = this.initializeForm();
        this.changePasswordForm = this.initializePasswordForm();

        this.profileForm.valueChanges.subscribe(() => {
            if (this.profileForm.controls['PHONE_NUMBER'].value != this.oUser_Details.PHONE_NUMBER || this.profileForm.controls['IS_RECEIVE_EMAIL'].value != this.oUser_Details.IS_RECEIVE_EMAIL) {
                this.isThereChange = true;
            }
            else {
                this.isThereChange = false;
            }

        });
    }

    Go_To_Build_History() {
        this._router.navigateByUrl('/build-history')
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            PHONE_NUMBER: [this.oUser_Details.PHONE_NUMBER, [Validators.required, Validators.pattern('[ 0-9-+]*'), Validators.minLength(5)]],
            IS_RECEIVE_EMAIL: [this.oUser_Details.IS_RECEIVE_EMAIL, [Validators.required]],
        });
    }

    initializePasswordForm(): FormGroup {
        return this._formBuilder.group({
            oldPassword: ['', [Validators.required]],
            newPassword: ['', [Validators.required, Validators.minLength(6)]],
            confirmPassword: ['', [Validators.required]],
        })
    }

    checkPasswords(): boolean {
        let pass = this.changePasswordForm.get('newPassword').value;
        let confirmPass = this.changePasswordForm.get('confirmPassword').value;
        return this.CmSvc.Are_Passwords_Equal(pass, confirmPass);
    }

    openChangePasswordDialog() {
        const dialogRef = this.dialog.open(this.changePasswordDialog, {
            width: '550px',
        });
    }

    cancelPasswordChange() {
        this.changePasswordForm = this.initializePasswordForm();
    }

    changePassword() {
        if (this.changePasswordForm.valid) {
            if (this.checkPasswords()) {
                if (this.passwordStrength <= 2) {
                    this.CmSvc.ShowMessage("Password is not strong enough");
                    return;
                }
                this.isLoading = true;
                this.changePasswordForm.disable();
                this.profileService.Change_Password(this.changePasswordForm.get('oldPassword').value, this.changePasswordForm.get('newPassword').value).then(result => {
                    if (result) {
                        this.dialog.closeAll();
                        this.changePasswordForm = this.initializePasswordForm();
                    }
                    this.changePasswordForm.enable();
                    this.isLoading = false;
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

    toggleEditMode(editMode: boolean | null = null): void {
        if (editMode === null) {
            this.isEditMode = !this.isEditMode;
        }
        else {
            this.isEditMode = editMode;
            if (editMode == false) {
                this.profileForm.controls['PHONE_NUMBER'].patchValue(this.oUser_Details.PHONE_NUMBER);
            }
        }

        this._changeDetectorRef.markForCheck();
    }

    saveForm(): void {
        if (this.profileForm.valid) {
            this.profileForm.disable();
            this.isLoading = true;

            this.oUser_Details.PHONE_NUMBER = this.profileForm.controls['PHONE_NUMBER'].value;
            this.oUser_Details.IS_RECEIVE_EMAIL = this.profileForm.controls['IS_RECEIVE_EMAIL'].value;
            this.isEditMode = false;
            this.profileService.Edit_User_Details(this.oUser_Details).then(result => {
                if (result) {
                    this.CmSvc.oUser_Details = this.oUser_Details;
                    localStorage.setItem("userDetails", JSON.stringify(this.oUser_Details));
                }

                this.profileForm.enable();
                this.isLoading = false;
            });
        } else {
            this.CmSvc.ShowMessage("Wrong Input Data");
        }
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

}
