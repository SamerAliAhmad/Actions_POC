import { CommonService } from 'app/core/Services/common.service';
import { Video_ai_engine } from 'app/core/Services/proxy.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Component, HostListener, Inject, OnInit } from '@angular/core';
import { VideoAiEngineListService } from '../video-ai-engine-list.service';

@Component({
    selector: 'add-video-ai-engine-modal',
    templateUrl: './add-video-ai-engine-modal.component.html',
    styleUrls: ['./add-video-ai-engine-modal.component.scss']
})
export class AddVideoAiEngineModalComponent implements OnInit {

    oVideo_ai_engine: Video_ai_engine = new Video_ai_engine();
    videoAiEngineForm: FormGroup;
    
    isLoading = false;
    isMobileView = false;

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        private VideoAiEngineListService: VideoAiEngineListService,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) {
    }

    ngOnInit(): void {
        this.videoAiEngineForm = this.initializeForm();
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            ENGINE_NAME: ['', [Validators.pattern('[ a-zA-Z0-9()]*'), Validators.required]],
        });
    };

    createVideoAiEngine(): void {
        if (this.videoAiEngineForm.controls.ENGINE_NAME.value.trim() != '') {
            this.isLoading = true;
            this.videoAiEngineForm.disable();

            this.oVideo_ai_engine.ENGINE_NAME = this.videoAiEngineForm.controls.ENGINE_NAME.value;
            this.oVideo_ai_engine.VIDEO_AI_ENGINE_ID = -1;

            this.VideoAiEngineListService.createVideoAiEngine(this.oVideo_ai_engine).then(result => {
                this.isLoading = false;
                this.dialog.closeAll();
            });
            this.videoAiEngineForm.enable();
        }
        else {
            this.CmSvc.ShowMessage('Invalid Input');
        }
    }

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }


}
