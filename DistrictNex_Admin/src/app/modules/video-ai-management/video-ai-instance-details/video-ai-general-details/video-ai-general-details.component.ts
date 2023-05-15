import { MatDialog } from '@angular/material/dialog';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Component, HostListener, Input, OnInit } from '@angular/core';
import { Setup_category, Video_ai_instance } from 'app/core/Services/proxy.service';
import { VideoAiInstanceDetailsService } from '../video-ai-instance-details.service';
import { ChangeInstancePasswordModalComponent } from './change-password-modal/change-password-modal.component';

@Component({
    selector: 'video-ai-general-details',
    templateUrl: './video-ai-general-details.component.html',
    styleUrls: ['./video-ai-general-details.component.scss']
})
export class VideoAiGeneralDetailsComponent implements OnInit {

    @Input() oVideo_ai_instance: Video_ai_instance;
    oConnection_Type_Setup_category: Setup_category = new Setup_category();

    isLoading = false;
    isMobileView = false;
    isThereChange = false;
    isForceConnection = false;

    videoAiInstanceDetailsForm: FormGroup;

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        private VideoAiInstanceDetailsService: VideoAiInstanceDetailsService
    ) {
        this.oConnection_Type_Setup_category = this.CmSvc.oList_Setup_category.filter(setup => {
            return setup.SETUP_CATEGORY_NAME === 'Connection Type';
        })[0];
    }

    ngOnInit(): void {
        if (this.oVideo_ai_instance) {
            this.videoAiInstanceDetailsForm = this.initializeForm();
        }
        this.videoAiInstanceDetailsForm.valueChanges.subscribe(videoAiInstanceDetailsFormValues => {
            if (videoAiInstanceDetailsFormValues.FRIENDLY_NAME == this.oVideo_ai_instance.FRIENDLY_NAME &&
                videoAiInstanceDetailsFormValues.USERNAME == this.oVideo_ai_instance.USERNAME &&
                videoAiInstanceDetailsFormValues.FUNCTIONAL_NAME == this.oVideo_ai_instance.FUNCTIONAL_NAME &&
                videoAiInstanceDetailsFormValues.CONNECTION_URL == this.oVideo_ai_instance.CONNECTION_URL &&
                videoAiInstanceDetailsFormValues.IS_LPR == this.oVideo_ai_instance.IS_LPR &&
                videoAiInstanceDetailsFormValues.CONNECTION_TYPE_SETUP_ID == this.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID &&
                !this.isForceConnection) {

                this.isThereChange = false;
            }
            else {
                this.isThereChange = true;
            }
        })
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            FRIENDLY_NAME: [this.oVideo_ai_instance.FRIENDLY_NAME, [Validators.required]],
            FUNCTIONAL_NAME: [this.oVideo_ai_instance.FUNCTIONAL_NAME, [Validators.required]],
            CONNECTION_URL: [this.oVideo_ai_instance.CONNECTION_URL, [Validators.required]],
            USERNAME: [this.oVideo_ai_instance.USERNAME, [Validators.required]],
            IS_FORCE_CONNECTION: [false],
            IS_LPR: [this.oVideo_ai_instance.IS_LPR],
            CONNECTION_TYPE_SETUP_ID: [this.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID, [Validators.required]],
        });
    };

    editVideoAiInstance(): void {
        if (this.videoAiInstanceDetailsForm.valid) {
            this.isLoading = true;
            if (this.videoAiInstanceDetailsForm.controls.FRIENDLY_NAME.value.trim() != '' &&
                this.videoAiInstanceDetailsForm.controls.USERNAME.value.trim() != '' &&
                this.videoAiInstanceDetailsForm.controls.FUNCTIONAL_NAME.value.trim() != '' &&
                this.videoAiInstanceDetailsForm.controls.CONNECTION_URL.value.trim() != '' &&
                this.videoAiInstanceDetailsForm.controls.CONNECTION_TYPE_SETUP_ID.value != null &&
                this.videoAiInstanceDetailsForm.controls.CONNECTION_TYPE_SETUP_ID.value > 0) {

                this.oVideo_ai_instance.FRIENDLY_NAME = this.videoAiInstanceDetailsForm.controls.FRIENDLY_NAME.value.trim();
                this.oVideo_ai_instance.FUNCTIONAL_NAME = this.videoAiInstanceDetailsForm.controls.FUNCTIONAL_NAME.value.trim();
                this.oVideo_ai_instance.CONNECTION_URL = this.videoAiInstanceDetailsForm.controls.CONNECTION_URL.value.trim();
                this.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID = this.videoAiInstanceDetailsForm.controls.CONNECTION_TYPE_SETUP_ID.value;
                this.oVideo_ai_instance.USERNAME = this.videoAiInstanceDetailsForm.controls.USERNAME.value.trim();
                this.oVideo_ai_instance.IS_LPR = this.videoAiInstanceDetailsForm.controls.IS_LPR.value;

                this.VideoAiInstanceDetailsService.editVideoAiInstance(this.oVideo_ai_instance, this.videoAiInstanceDetailsForm.controls.IS_FORCE_CONNECTION.value).then(result_instance => {
                    if (result_instance.IS_FORCE_CONNECTION) {
                        this.isLoading = false;
                        this.isForceConnection = true;
                        this.CmSvc.ShowMessage(result_instance.RESPONSE_MESSAGE);
                    }
                    else {
                        this.isForceConnection = false;

                        this.videoAiInstanceDetailsForm.get('FRIENDLY_NAME').patchValue(result_instance.oVideo_ai_instance.FRIENDLY_NAME);
                        this.videoAiInstanceDetailsForm.get('FUNCTIONAL_NAME').patchValue(result_instance.oVideo_ai_instance.FUNCTIONAL_NAME);
                        this.videoAiInstanceDetailsForm.get('CONNECTION_URL').patchValue(result_instance.oVideo_ai_instance.CONNECTION_URL);
                        this.videoAiInstanceDetailsForm.get('USERNAME').patchValue(result_instance.oVideo_ai_instance.USERNAME);
                        this.videoAiInstanceDetailsForm.get('CONNECTION_TYPE_SETUP_ID').patchValue(result_instance.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID);
                        this.videoAiInstanceDetailsForm.get('IS_FORCE_CONNECTION').patchValue(false);
                        this.videoAiInstanceDetailsForm.get('IS_LPR').patchValue(result_instance.oVideo_ai_instance.IS_LPR);
                        this.isLoading = false;
                        this.isThereChange = false;
                    }
                })
            }
        }
    }

    cancelChanges(): void {
        this.videoAiInstanceDetailsForm.get('FRIENDLY_NAME').patchValue(this.oVideo_ai_instance.FRIENDLY_NAME);
        this.videoAiInstanceDetailsForm.get('FUNCTIONAL_NAME').patchValue(this.oVideo_ai_instance.FUNCTIONAL_NAME);
        this.videoAiInstanceDetailsForm.get('CONNECTION_URL').patchValue(this.oVideo_ai_instance.CONNECTION_URL);
        this.videoAiInstanceDetailsForm.get('USERNAME').patchValue(this.oVideo_ai_instance.USERNAME);
        this.videoAiInstanceDetailsForm.get('CONNECTION_TYPE_SETUP_ID').patchValue(this.oVideo_ai_instance.CONNECTION_TYPE_SETUP_ID);
        this.videoAiInstanceDetailsForm.get('IS_LPR').patchValue(this.oVideo_ai_instance.IS_LPR);
        this.isThereChange = false;
    }

    changePassword(): void {
        this.dialog.open(ChangeInstancePasswordModalComponent, {
            width: '400px',
            data: {
                video_ai_instance_id: this.oVideo_ai_instance.VIDEO_AI_INSTANCE_ID
            }
        })
    }

    @HostListener('window:resize', ['$event'])
    onResize() {
        this.isMobileView = window.innerWidth < 600;
    }
}
