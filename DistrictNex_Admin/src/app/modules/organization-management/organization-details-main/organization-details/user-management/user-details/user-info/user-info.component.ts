import { cloneDeep } from 'lodash';
import { NgForm } from '@angular/forms';
import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { Organization, Params_Restore_User, Params_Schedule_User_for_Delete, Setup, User } from 'app/core/Services/proxy.service';
import { ChangePasswordModalComponent } from 'app/shared/components/organization-management/change-password-modal/change-password-modal.component';

@Component({
    selector: 'user-info',
    templateUrl: './user-info.component.html',
    styleUrls: ['./user-info.component.scss']
})
export class UserInfoComponent implements OnInit {

    oUser: User;
    oUser_Original: User;
    oOrganization: Organization;

    oList_User_type_setup: Setup[];

    isLoading = false;
    isSuperAdmin = false;

    constructor(
        private router: Router,
        public dialog: MatDialog,
        private Location: Location,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrConfirmationService: SmartrConfirmationService,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.isSuperAdmin = this.CmSvc.oUser_Details.User_type_setup.VALUE == 'Super Admin';
        if (this.isSuperAdmin) {
            this.oList_User_type_setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup;
        }
        else {
            this.oList_User_type_setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "User Type")[0].List_Setup.filter(userType => userType.VALUE != 'Super Admin');
        }

        const routes = this.router.url.split('/');
        routes.shift();

        const isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == parseInt(routes[1]));
        }

        this.OrganizationManagementService.get_User_Details(this.oOrganization, this.ActivatedRoute.snapshot.params.userId).then(result => {
            this.oUser_Original = result;
            this.oUser = cloneDeep(result);
        });
    }

    resetUserDetails(): void {
        this.oUser = cloneDeep(this.oUser_Original);
    }

    editUser(userForm: NgForm) {
        if (userForm.invalid) {
            this.CmSvc.ShowMessage("Some data is missing or wrong");
            return;
        }
        this.isLoading = true;

        this.OrganizationManagementService.Modify_User_Details(this.oUser).then(result => {
            if (result) {
                this.oOrganization.List_User[this.oOrganization.List_User.findIndex(user => user.USER_ID == result.USER_ID)] = result;
                this.OrganizationManagementService.refetchRouteSubject.next();
                this.oUser_Original = result;
                this.oUser = cloneDeep(result);
                this.CmSvc.Handle_Success();
            }
            this.isLoading = false;
        });
    }

    deletePicture(): void {
        this.CmSvc.ShowMessage('This feature is currently inactive');
    }

    deactivateUser(): void {
        let displayMessage = '';
        if (this.oOrganization.DATA_RETENTION_PERIOD > 0) {
            displayMessage = 'Are you sure you want to deactivate this user? Data will be wiped in ' + this.oOrganization.DATA_RETENTION_PERIOD + ' days';
        } else if (this.oOrganization.DATA_RETENTION_PERIOD == 0) {
            displayMessage = 'Are you sure you want to deactivate this user? Data will be wiped immediately';
        } else {
            this.CmSvc.ShowMessage('Data retention period not specified, contact support');
            return;
        }
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm User Deactivation',
            message: displayMessage,
            actions: {
                confirm: {
                    show: true,
                    label: 'Yes',
                    color: 'warn',
                },
                cancel: {
                    show: true,
                    label: 'No',
                }
            }
        });
        dialogRef.afterClosed().subscribe((result) => {
            if (result === 'confirmed') {
                this.isLoading = true;
                const oParams_Schedule_User_for_Delete: Params_Schedule_User_for_Delete = new Params_Schedule_User_for_Delete();
                oParams_Schedule_User_for_Delete.USER_ID = this.oUser.USER_ID;
                this.OrganizationManagementService.deactivateUser(this.oOrganization, oParams_Schedule_User_for_Delete).then(result => {
                    if (result) {
                        this.oUser_Original.IS_ACTIVE = false;
                        this.oUser_Original.DATE_DELETED = new Date().toString();
                        this.oUser_Original.DATA_RETENTION_PERIOD = this.oOrganization.DATA_RETENTION_PERIOD;
                        this.oUser = cloneDeep(this.oUser_Original);
                    }
                    this.isLoading = false;
                })
            }
        });
    }

    restoreUser(): void {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm User Reactivation',
            message: 'Are you sure you want to reactivate this user?',
            icon: {
                color: 'primary',
                name: 'heroicons_outline:library',
                show: false
            },
            actions: {
                confirm: {
                    show: true,
                    label: 'Yes',
                },
                cancel: {
                    show: true,
                    label: 'No',
                }
            }
        });
        dialogRef.afterClosed().subscribe((result) => {
            if (result === 'confirmed') {
                this.isLoading = true;
                const oParams_Restore_User: Params_Restore_User = new Params_Restore_User();
                oParams_Restore_User.USER_ID = this.oUser.USER_ID;
                this.OrganizationManagementService.restoreUser(this.oOrganization, oParams_Restore_User).then(result => {
                    if (result) {
                        this.oUser_Original.IS_ACTIVE = true;
                        this.oUser_Original.DATE_DELETED = null;
                        this.oUser_Original.DATA_RETENTION_PERIOD = null;
                        this.oUser = cloneDeep(this.oUser_Original);
                    }
                    this.isLoading = false;
                })
            }
        });
    }

    getDeleteDate(): string {
        if (this.oUser.DATE_DELETED && this.oUser.DATA_RETENTION_PERIOD != null) {
            const deleteDay = new Date(this.oUser.DATE_DELETED)
            deleteDay.setDate(deleteDay.getDate() + this.oUser.DATA_RETENTION_PERIOD)
            return deleteDay.toDateString();
        }
        else {
            return '';
        }
    }

    openChangePasswordDialog(): void {
        this.dialog.open(ChangePasswordModalComponent, {
            width: '400px',
            data: {
                UserID: this.oUser.USER_ID,
            }
        })
    }

    goBack(): void {
        this.Location.back();
    }
}
