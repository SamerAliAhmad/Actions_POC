import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ThemePalette } from '@angular/material/core';
import { CommonService } from 'app/core/Services/common.service';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { Organization, Params_Delete_Organization_Picture, Setup } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { UploadPictureModalComponent } from 'app/shared/components/organization-management/upload-picture-modal/upload-picture-modal.component';

@Component({
    selector: 'organization-images',
    templateUrl: './organization-images.component.html',
    styleUrls: ['./organization-images.component.scss']
})
export class OrganizationImagesComponent implements OnInit {

    value = 50;

    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';

    isMyOrganization = false;
    isProgressSpinnerVisible = false;

    oList_Image_Type_Setup: Setup[];
    oOrganization: Organization;

    favIcon: HTMLLinkElement = document.querySelector('#appIcon');
    loaderImage = document.getElementById('appLogo') as HTMLImageElement;

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrConfirmationService: SmartrConfirmationService,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Image_Type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Image Type")[0].List_Setup;
    }

    ngOnInit(): void {
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
    }

    openChangePictureDialog(Image_Type_Setup_Value: string, isIco: boolean): void {
        const dialogRef = this.dialog.open(UploadPictureModalComponent, {
            width: '400px',
            data: {
                organizationDetails: this.oOrganization,
                isIco: isIco,
                imageTypeSetupID: this.oList_Image_Type_Setup.filter(x => x.VALUE == Image_Type_Setup_Value)[0].SETUP_ID,
                imageTypeSetupValue: Image_Type_Setup_Value
            },
            autoFocus: false
        })

        dialogRef.afterClosed().subscribe(() => {
            if (this.isMyOrganization) {
                if (this.oOrganization.ORGANIZATION_FAVICON_URL) {
                    this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL = this.oOrganization.ORGANIZATION_FAVICON_URL;
                    this.favIcon.href = this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL;
                    localStorage.setItem('dna_favi_ico_url', this.oOrganization.ORGANIZATION_FAVICON_URL);
                } else {
                    this.CmSvc.userTheme.ORGANIZATION_FAVICON_URL = this.CmSvc.defaultSettings.ORGANIZATION_FAVICON_URL;
                    localStorage.removeItem('dna_favi_ico_url');
                }
                if (this.oOrganization.DARK_RECTANGLE_LOGO_URL) {
                    this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL = this.oOrganization.DARK_RECTANGLE_LOGO_URL;
                    localStorage.setItem('dna_dark_logo_url', this.oOrganization.DARK_RECTANGLE_LOGO_URL);
                } else {
                    this.CmSvc.userTheme.DARK_RECTANGLE_LOGO_URL = this.CmSvc.defaultSettings.DARK_RECTANGLE_LOGO_URL;
                    localStorage.removeItem('dna_dark_logo_url');
                }
                if (this.oOrganization.DARK_SQUARE_LOGO_URL) {
                    this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL = this.oOrganization.DARK_SQUARE_LOGO_URL;
                    localStorage.setItem('dna_dark_logo_square_url', this.oOrganization.DARK_SQUARE_LOGO_URL);
                } else {
                    this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL = this.CmSvc.defaultSettings.DARK_SQUARE_LOGO_URL;
                    localStorage.removeItem('dna_dark_logo_square_url');
                }
                if (this.oOrganization.LIGHT_RECTANGLE_LOGO_URL) {
                    this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL = this.oOrganization.LIGHT_RECTANGLE_LOGO_URL;
                    localStorage.setItem('dna_light_logo_url', this.oOrganization.LIGHT_RECTANGLE_LOGO_URL);
                } else {
                    this.CmSvc.userTheme.LIGHT_RECTANGLE_LOGO_URL = this.CmSvc.defaultSettings.LIGHT_RECTANGLE_LOGO_URL;
                    localStorage.removeItem('dna_light_logo_url');
                }
                if (this.oOrganization.LIGHT_SQUARE_LOGO_URL) {
                    this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL = this.oOrganization.LIGHT_SQUARE_LOGO_URL
                    this.loaderImage.src = this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL;
                    localStorage.setItem('dna_light_logo_square_url', this.oOrganization.LIGHT_SQUARE_LOGO_URL);
                } else {
                    this.CmSvc.userTheme.LIGHT_SQUARE_LOGO_URL = this.CmSvc.defaultSettings.LIGHT_SQUARE_LOGO_URL;
                    localStorage.removeItem('dna_light_logo_square_url');
                }
                this.CmSvc.onDisplayImageChanged.next();
            }
        });
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
                this.isProgressSpinnerVisible = true;
                const oParams_Delete_Organization_Picture: Params_Delete_Organization_Picture = new Params_Delete_Organization_Picture();
                oParams_Delete_Organization_Picture.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                oParams_Delete_Organization_Picture.IMAGE_TYPE_SETUP_ID = this.oList_Image_Type_Setup.filter(x => x.VALUE == Image_Type_Setup_Value)[0].SETUP_ID;
                this.OrganizationManagementService.deleteFile(this.oOrganization, oParams_Delete_Organization_Picture, Image_Type_Setup_Value).then(result => {
                    if (result == true) {
                        this.CmSvc.ShowMessage('Picture Removed');
                    }
                    this.isProgressSpinnerVisible = false;
                })
            }
        });
    }

    onRemove(event) {
    }
}
