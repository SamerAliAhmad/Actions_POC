import { Clipboard } from '@angular/cdk/clipboard';
import { ChangeDetectorRef, Component, HostListener, OnDestroy, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Organization_theme, User_Details, User_theme } from 'app/core/Services/proxy.service';
import { ArrayFilterPipe } from 'app/shared/pipes/array-filter.pipe';
import { SharedService } from 'app/shared/services/shared.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { environment } from 'environments/environment';
import { Subject } from 'rxjs';
import { ProfileService } from './profile.service';

@Component({
    selector: 'profile',
    templateUrl: './profile.component.html',
    styleUrls: ['./profile.component.scss']
})

export class ProfileComponent implements OnInit, OnDestroy {
    @ViewChild('changePasswordDialog', { static: true }) changePasswordDialog: TemplateRef<any>;

    isLoading = false;
    isEditMode = false;
    isMobileView = false;

    profileForm: FormGroup;
    oUser_Details: User_Details;
    changePasswordForm: FormGroup;

    Build_Number = '';
    passwordStrength = 0;
    timezoneSearchValue = "";
    oList_Timezone_To_Show: string[] = [];

    oUser_theme: User_theme;
    oList_Organization_theme: Organization_theme[];

    private _unsubscribeAll = new Subject<void>();

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }

    constructor(
        private _router: Router,
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private Clipboard: Clipboard,
        private _formBuilder: FormBuilder,
        private SharedService: SharedService,
        private profileService: ProfileService,
        public TimezoneService: TimezoneService,
        private ArrayFilterPipe: ArrayFilterPipe,
        private _changeDetectorRef: ChangeDetectorRef
    ) {
        this.Build_Number = environment.Build_Number;
        this.oUser_Details = this.CmSvc.oUser_Details;
        this.oUser_theme = this.CmSvc.oUser_theme;
        this.oList_Organization_theme = this.CmSvc.oList_Organization_theme;
    }

    ngOnInit(): void {
        this.CmSvc.oToggle_Module_Subject.next(true);
        this.isMobileView = window.innerWidth < 600;

        this.profileForm = this.initializeForm();
        this.changePasswordForm = this.initializePasswordForm();
        this.filterTimezones();
    }

    getOrganizationThemeName() {
        return this.oList_Organization_theme.find(oOrganization_theme => oOrganization_theme.ORGANIZATION_THEME_ID == this.oUser_theme.ORGANIZATION_THEME_ID)?.THEME_NAME;
    }

    Go_To_Build_History() {
        this._router.navigateByUrl('/build-history')
    }

    filterTimezones() {
        this.oList_Timezone_To_Show = this.ArrayFilterPipe.transform(this.TimezoneService.oList_Timezone, this.timezoneSearchValue);
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            PHONE_NUMBER: [this.oUser_Details.PHONE_NUMBER, [Validators.required, Validators.pattern('[ 0-9-+]*'), Validators.minLength(5)]],
            ORGANIZATION_THEME_ID: [this.oUser_theme?.ORGANIZATION_THEME_ID, [Validators.required]],
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
            this.isEditMode = false;

            if (this.oUser_theme) {
                this.oUser_theme.ORGANIZATION_THEME_ID = this.profileForm.controls['ORGANIZATION_THEME_ID'].value;
                if (this.CmSvc.oUser_Details.User_type_setup.VALUE != "Super Admin") {
                    this.SharedService.Edit_User_theme(this.oUser_theme).then(result => {
                        this.oUser_theme = result;
                        this.CmSvc.oUser_theme = this.oUser_theme;
                    });
                }
                else {
                    this.CmSvc.oUser_theme = this.oUser_theme;
                }
            }
            if (this.oUser_Details.PHONE_NUMBER != this.profileForm.controls['PHONE_NUMBER'].value) {
                this.profileForm.disable();
                this.isLoading = true;
                this.oUser_Details.PHONE_NUMBER = this.profileForm.controls['PHONE_NUMBER'].value;
                this.profileService.Edit_User_Details(this.oUser_Details).then(result => {
                    if (result) {
                        this.CmSvc.oUser_Details = this.oUser_Details;
                        localStorage.setItem("userDetails", JSON.stringify(this.oUser_Details));
                        this.profileForm.markAsPristine();
                    }

                    this.profileForm.enable();
                    this.isLoading = false;
                });
            }
        } else {
            this.CmSvc.ShowMessage("Wrong Input Data");
        }
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

}
