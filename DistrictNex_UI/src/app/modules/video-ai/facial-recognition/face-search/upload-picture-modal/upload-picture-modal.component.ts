import { Component, Inject } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { CommonService } from 'app/core/Services/common.service';
import { Detect_Face_Response } from 'app/core/Services/proxyExt.service';
import { VideoAIService } from './../../../video-ai.service';

@Component({
    selector: 'upload-picture-modal',
    templateUrl: './upload-picture-modal.component.html',
    styleUrls: ['./upload-picture-modal.component.scss']
})
export class UploadPictureModalComponent {
    file: File;
    imageSrc: string = '';
    supportedExtensions = ".png, .jpg, .jpeg";

    value = 50;
    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';
    displayProgressSpinner = false;
    oDetect_Face_Response: Detect_Face_Response;

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private VideoAIService: VideoAIService,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private dialogRef: MatDialogRef<UploadPictureModalComponent>
    ) {
    }

    onFileChange(event): void {
        if (event.addedFiles.length > 0) {
            this.file = event.addedFiles[0];
            this.uploadSingleFile();
        }
    }

    private uploadSingleFile(): void {
        this.displayProgressSpinner = true;
        this.VideoAIService
            .Detect_Face_In_Image(this.file)
            .then(res => {
                this.displayProgressSpinner = false;
                if (res) {
                    this.oDetect_Face_Response = res;
                    this.dialogRef.close(true);
                }
                else {
                    this.file = null;
                    this.CmSvc.ShowMessage("Error While Uploading! Try Again!", 2000);
                }
            });
    }
}