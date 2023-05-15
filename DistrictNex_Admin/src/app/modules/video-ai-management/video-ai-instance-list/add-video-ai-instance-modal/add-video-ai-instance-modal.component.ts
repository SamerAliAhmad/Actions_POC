import { Component, Inject, OnInit } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { VideoAiInstanceListService } from '../video-ai-instance-list.service';
import { Setup_category, Video_ai_instance } from 'app/core/Services/proxy.service';

@Component({
    selector: 'add-video-ai-instance-modal',
    templateUrl: './add-video-ai-instance-modal.component.html',
    styleUrls: ['./add-video-ai-instance-modal.component.scss']
})

export class AddVideoAiInstanceModalComponent implements OnInit {

    oVideo_ai_instance: Video_ai_instance = new Video_ai_instance();
    oConnection_Type_Setup_category: Setup_category = new Setup_category();

    videoAiInstanceForm: FormGroup;

    isLoading = false;
    isForceConnection = false;

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        private VideoAiInstanceListService: VideoAiInstanceListService,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) {
        this.oConnection_Type_Setup_category = this.CmSvc.oList_Setup_category.filter(setup => {
            return setup.SETUP_CATEGORY_NAME === 'Connection Type';
        })[0];
    }

    ngOnInit(): void {

        this.videoAiInstanceForm = this.initializeForm();
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            INSTANCE_NAME: ['', [Validators.pattern('[ a-zA-Z0-9]*'), Validators.required]],
            USERNAME: ['', [Validators.pattern('[ a-zA-Z0-9]*'), Validators.required]],
            FUNCTIONAL_NAME: ['', [Validators.required]],
            CONNECTION_URL: ['', [Validators.required]],
            CONNECTION_TYPE_SETUP_ID: ['', [Validators.required]],
            PASSWORD: ['', [Validators.required, Validators.minLength(6)]],
            CONFIRM_PASSWORD: ['', [Validators.required, Validators.minLength(6)]],
            IS_LPR: [false],
        });
    };

    checkPasswords(): boolean {
        let pass = this.videoAiInstanceForm.get('PASSWORD').value;
        let confirmPass = this.videoAiInstanceForm.get('CONFIRM_PASSWORD').value;
        return this.CmSvc.Are_Passwords_Equal(pass, confirmPass);
    }

    createVideoAiInstance(): void {
        if (this.checkPasswords()) {
            if (this.videoAiInstanceForm.controls.INSTANCE_NAME.value.trim() != '' &&
                this.videoAiInstanceForm.controls.FUNCTIONAL_NAME.value.trim() != '' &&
                this.videoAiInstanceForm.controls.CONNECTION_URL.value.trim() != '' &&
                this.videoAiInstanceForm.controls.USERNAME.value.trim() != '' &&
                this.videoAiInstanceForm.controls.PASSWORD.value.trim() != '' &&
                this.videoAiInstanceForm.controls.CONFIRM_PASSWORD.value.trim() != '' &&
                this.videoAiInstanceForm.controls.CONNECTION_TYPE_SETUP_ID.value != null &&
                this.videoAiInstanceForm.controls.CONNECTION_TYPE_SETUP_ID.value > 0) {
                this.isLoading = true;

                this.oVideo_ai_instance.FRIENDLY_NAME = this.videoAiInstanceForm.controls.INSTANCE_NAME.value.trim();
                this.oVideo_ai_instance.FUNCTIONAL_NAME = this.videoAiInstanceForm.controls.FUNCTIONAL_NAME.value.trim();
                this.oVideo_ai_instance.CONNECTION_URL = this.videoAiInstanceForm.controls.CONNECTION_URL.value.trim();
                this.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID = this.videoAiInstanceForm.controls.CONNECTION_TYPE_SETUP_ID.value;
                this.oVideo_ai_instance.PASSWORD = this.videoAiInstanceForm.controls.PASSWORD.value.trim();
                this.oVideo_ai_instance.USERNAME = this.videoAiInstanceForm.controls.USERNAME.value.trim();
                this.oVideo_ai_instance.IS_LPR = this.videoAiInstanceForm.controls.IS_LPR.value;

                this.videoAiInstanceForm.disable();
                this.VideoAiInstanceListService.createVideoAiInstance(this.oVideo_ai_instance).then(result => {
                    this.isLoading = false;
                    this.dialog.closeAll();
                });
                this.videoAiInstanceForm.enable();
            }
            else {
                this.CmSvc.ShowMessage('Invalid Input');
            }
        }
        else {
            this.CmSvc.ShowMessage('Passwords Don\'t Match! Try Again.');
        }
    }
}
