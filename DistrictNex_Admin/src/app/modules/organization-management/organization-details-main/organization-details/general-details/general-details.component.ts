import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ThemePalette } from '@angular/material/core';
import { MatDialog } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { ActivatedRoute } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Organization, Params_Delete_Organization_Picture, Params_Restore_Organization, Params_Schedule_Organization_for_Delete, Setup } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { UploadPictureModalComponent } from 'app/shared/components/organization-management/upload-picture-modal/upload-picture-modal.component';
import { cloneDeep } from 'lodash-es';

@Component({
    selector: 'general-details',
    templateUrl: './general-details.component.html',
    styleUrls: ['./general-details.component.scss']
})
export class GeneralDetailsComponent implements OnInit {

    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';
    
    value = 50;
    numberUsers = 0;
    numberAdmins = 0;
    
    oOrganization: Organization;
    oOrganization_Original: Organization;
    
    isLoading = false;
    isMyOrganization = false;
    isProgressSpinerVisible = false;

    oList_Image_Type_setup: Setup[];

    constructor(
        public dialog: MatDialog,
        private Location: Location,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrConfirmationService: SmartrConfirmationService,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Image_Type_setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Image Type")[0].List_Setup;
    }

    ngOnInit(): void {
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization_Original = this.CmSvc.oOrganization;
        } else {
            this.oOrganization_Original = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        this.oOrganization = cloneDeep(this.oOrganization_Original);
        this.numberAdmins = this.OrganizationManagementService.calculateNumberAdmins(this.oOrganization);
        this.numberUsers = this.OrganizationManagementService.calculateNumberUsers(this.oOrganization);
    }

    resetOrganizationDetails(organizationForm: NgForm): void {
        this.oOrganization = cloneDeep(this.oOrganization_Original);
        organizationForm.form.markAsPristine();
    }

    editOrganization(organizationForm: NgForm) {
        if (organizationForm.invalid) {
            this.CmSvc.ShowMessage("Some data is missing or wrong");
            return;
        }
        this.isLoading = true;
        this.OrganizationManagementService.Modify_Organization_Details(this.oOrganization).then(result => {
            if (result) {
                this.oOrganization_Original = result;
                this.oOrganization = cloneDeep(this.oOrganization_Original);
                this.CmSvc.Handle_Success();
                this.numberAdmins = this.OrganizationManagementService.calculateNumberAdmins(this.oOrganization);
                this.numberUsers = this.OrganizationManagementService.calculateNumberUsers(this.oOrganization);
                organizationForm.form.markAsPristine();
            }
            this.isLoading = false;
        });
    }

    openChangePictureDialog(Image_Type_Setup_Value: string, isIco: boolean): void {
        this.dialog.open(UploadPictureModalComponent, {
            width: '400px',
            data: {
                organizationDetails: this.oOrganization_Original,
                isIco: isIco,
                imageTypeSetupID: this.oList_Image_Type_setup.filter(x => x.VALUE == Image_Type_Setup_Value)[0].SETUP_ID,
                imageTypeSetupValue: Image_Type_Setup_Value
            },
            autoFocus: false
        })
    }

    deletePicture(Image_Type_Setup_Value: string): void {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Delete',
            message: 'Are you sure you want to delete this image?',
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
                this.isProgressSpinerVisible = true;
                const oParams_Delete_Organization_Picture: Params_Delete_Organization_Picture = new Params_Delete_Organization_Picture();
                oParams_Delete_Organization_Picture.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                oParams_Delete_Organization_Picture.IMAGE_TYPE_SETUP_ID = this.oList_Image_Type_setup.filter(x => x.VALUE == Image_Type_Setup_Value)[0].SETUP_ID;
                this.OrganizationManagementService.deleteFile(this.oOrganization_Original, oParams_Delete_Organization_Picture, Image_Type_Setup_Value).then(result => {
                    if (result == true) {
                        this.CmSvc.ShowMessage('Picture Removed');
                    }
                    this.isProgressSpinerVisible = false;
                })
            }
        });
    }

    deactivateOrganization(): void {
        if (this.oOrganization.ORGANIZATION_ID == 7) {
            this.CmSvc.ShowMessage("This organization can't be deleted.");
            return;
        }
        let displayMessage = '';
        if (this.oOrganization.DATA_RETENTION_PERIOD > 0) {
            displayMessage = 'Are you sure you want to deactivate this organization? Data will be wiped in ' + this.oOrganization.DATA_RETENTION_PERIOD + ' days';
        }
        else if (this.oOrganization.DATA_RETENTION_PERIOD == 0) {
            displayMessage = 'Are you sure you want to deactivate this organization? Data will be wiped immediately';
        }
        else {
            this.CmSvc.ShowMessage('Data retention period not specified, contact support');
            return;
        }
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Organization Deactivation',
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
                const oParams_Schedule_Organization_for_Delete: Params_Schedule_Organization_for_Delete = new Params_Schedule_Organization_for_Delete();
                oParams_Schedule_Organization_for_Delete.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                this.OrganizationManagementService.deactivateOrganization(oParams_Schedule_Organization_for_Delete).then(result => {
                    this.oOrganization_Original.IS_ACTIVE = result.IS_ACTIVE;
                    this.oOrganization_Original.IS_DELETED = result.IS_DELETED;
                    this.oOrganization_Original.DATE_DELETED = result.DATE_DELETED;
                    this.oOrganization = cloneDeep(this.oOrganization_Original);
                    this.isLoading = false;
                })
            }
        });
    }

    restoreOrganization(): void {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Organization Reactivation',
            message: 'Are you sure you want to reactivate this organization?',
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
                const oParams_Restore_Organization: Params_Restore_Organization = new Params_Restore_Organization();
                oParams_Restore_Organization.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                this.OrganizationManagementService.restoreOrganization(oParams_Restore_Organization).then(result => {
                    this.oOrganization_Original.IS_ACTIVE = result.IS_ACTIVE;
                    this.oOrganization_Original.IS_DELETED = result.IS_DELETED;
                    this.oOrganization_Original.DATE_DELETED = result.DATE_DELETED;
                    this.oOrganization = cloneDeep(this.oOrganization_Original);
                    this.isLoading = false;
                })
            }
        });
    }

    getDeleteDate(): string {
        if (this.oOrganization.DATE_DELETED && this.oOrganization.DATA_RETENTION_PERIOD != null) {
            const deleteDay = new Date(this.oOrganization.DATE_DELETED)
            deleteDay.setDate(deleteDay.getDate() + this.oOrganization.DATA_RETENTION_PERIOD)
            return deleteDay.toDateString();
        }
        else {
            return '';
        }
    }

    goBack(): void {
        this.Location.back();
    }
}
