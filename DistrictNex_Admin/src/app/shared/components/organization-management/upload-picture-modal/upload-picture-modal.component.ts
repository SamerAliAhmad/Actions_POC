import { Component, Inject } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { CommonService } from 'app/core/Services/common.service';
import { Params_Upload_Organization_Picture } from 'app/core/Services/proxyExt.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'upload-picture-modal',
    templateUrl: './upload-picture-modal.component.html',
    styleUrls: ['./upload-picture-modal.component.scss']
})
export class UploadPictureModalComponent {
    file: File;
    supportedExtensions = ".png, .jpg, .jpeg";

    value = 50;
    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';
    displayProgressSpinner = false;

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private OrganizationManagementService: OrganizationManagementService,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) {
        if (this.data.isIco == true) {
            this.supportedExtensions = ".ico"
        }
    }

    onFileChange(event): void {
        if (event.addedFiles.length > 0) {
            this.file = event.addedFiles[0];
            this.uploadSingleFile();
        }
    }

    private uploadSingleFile(): void {
        let oParams_Upload_Organization_Picture: Params_Upload_Organization_Picture = new Params_Upload_Organization_Picture();
        oParams_Upload_Organization_Picture.ORGANIZATION_ID = this.data.organizationDetails.ORGANIZATION_ID;
        oParams_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID = this.data.imageTypeSetupID;
        this.displayProgressSpinner = true;
        this.OrganizationManagementService
            .uploadFile(this.file, oParams_Upload_Organization_Picture)
            .then(res => {
                this.displayProgressSpinner = false;
                if (res) {
                    switch (this.data.imageTypeSetupValue) {
                        case 'Dark_Square_Logo':
                            this.data.organizationDetails.DARK_SQUARE_LOGO_URL = res;
                            break;
                        case 'Dark_Rect_Logo':
                            this.data.organizationDetails.DARK_RECTANGLE_LOGO_URL = res;
                            break;
                        case 'Light_Square_Logo':
                            this.data.organizationDetails.LIGHT_SQUARE_LOGO_URL = res;
                            break;
                        case 'Light_Rect_Logo':
                            this.data.organizationDetails.LIGHT_RECTANGLE_LOGO_URL = res;
                            break;
                        case 'Favicon':
                            this.data.organizationDetails.ORGANIZATION_FAVICON_URL = res;
                            break;
                    }
                    this.CmSvc.ShowMessage("Success!", 2000);
                    this.dialog.closeAll();
                }
                else {
                    this.file = null;
                    this.CmSvc.ShowMessage("Error While Uploading! Try Again!", 2000);
                }
            });
    }
}