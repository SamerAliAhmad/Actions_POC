import { Component, Inject } from '@angular/core';
import { SettingsService } from '../settings.service';
import { ThemePalette } from '@angular/material/core';
import { CommonService } from 'app/core/Services/common.service';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { Params_Upload_Default_Settings_Picture } from 'app/core/Services/proxyExt.service';

@Component({
    selector: 'default-picture-modal',
    templateUrl: './default-picture-modal.component.html',
    styleUrls: ['./default-picture-modal.component.scss']
})

export class DefaultPictureModalComponent {

    oFile: File;
    supportedExtensions = ".png, .jpg, .jpeg";

    value = 50;
    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';

    isProgressSpinnerVisible = false;

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private SettingsService: SettingsService,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) {
        if (this.data.isIco == true) {
            this.supportedExtensions = ".ico"
        }
    }

    onFileChange(event): void {
        if (event.addedFiles.length > 0) {
            this.oFile = event.addedFiles[0];
            this.uploadSingleFile();
        }
    }

    private uploadSingleFile(): void {
        let oParams_Upload_Default_Settings_Picture: Params_Upload_Default_Settings_Picture = new Params_Upload_Default_Settings_Picture();
        oParams_Upload_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID = this.data.imageTypeSetupID;
        this.isProgressSpinnerVisible = true;
        this.SettingsService
            .uploadFile(this.oFile, oParams_Upload_Default_Settings_Picture)
            .then(res => {
                this.isProgressSpinnerVisible = false;
                if (res) {
                    switch (this.data.imageTypeSetupValue) {
                        case 'Dark_Square_Logo':
                            this.CmSvc.defaultSettings.DARK_SQUARE_LOGO_URL = res;
                            break;
                        case 'Dark_Rect_Logo':
                            this.CmSvc.defaultSettings.DARK_RECTANGLE_LOGO_URL = res;
                            break;
                        case 'Light_Square_Logo':
                            this.CmSvc.defaultSettings.LIGHT_SQUARE_LOGO_URL = res;
                            break;
                        case 'Light_Rect_Logo':
                            this.CmSvc.defaultSettings.LIGHT_RECTANGLE_LOGO_URL = res;
                            break;
                        case 'Favicon':
                            this.CmSvc.defaultSettings.ORGANIZATION_FAVICON_URL = res;
                            break;
                    }
                    this.CmSvc.ShowMessage("Success!", 2000);
                    this.dialog.closeAll();
                }
                else {
                    this.oFile = null;
                    this.CmSvc.ShowMessage("Error While Uploading! Try Again!", 2000);
                }
            });
    }
}