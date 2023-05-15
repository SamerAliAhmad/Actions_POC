import { Component, Inject, OnInit } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { VideoAiInstanceDetailsService } from './../../video-ai-instance-details.service';
import { Entity, Floor, Sites_and_Entities, Space, Space_asset, Surveillance_Camera_Content } from 'app/core/Services/proxy.service';

@Component({
    selector: 'add-video-ai-asset-modal',
    templateUrl: './add-video-ai-asset-modal.component.html',
    styleUrls: ['./add-video-ai-asset-modal.component.scss']
})
export class AddVideoAiAssetModalComponent implements OnInit {

    oSites_and_Entities: Sites_and_Entities = new Sites_and_Entities();

    oList_Floor: Floor[] = [];
    oList_Space: Space[] = [];
    oList_Entity_To_Show: Entity[] = [];
    oList_Space_Asset: Space_asset[] = [];
    oList_Engine_Asset: Surveillance_Camera_Content[] = [];

    isLoading = false;
    isFetchingData = false;
    isFloorsVisible = false;
    isSpacesVisible = false;
    isEntitiesVisible = false;
    isSpaceAssetsVisible = false;

    videoAiAssetForm: FormGroup;

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        private VideoAiInstanceDetailsService: VideoAiInstanceDetailsService,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) { }

    ngOnInit(): void {
        this.isFetchingData = true;
        this.VideoAiInstanceDetailsService.Get_sites_and_entities().then(result => {
            this.isFetchingData = false;
            this.oSites_and_Entities = result;
        })
        this.oList_Engine_Asset = this.data.engine_assets;

        this.videoAiAssetForm = this.initializeForm();

        this.videoAiAssetForm.controls['SITE_ID'].valueChanges.subscribe(site_id => {
            if (site_id != null) {
                this.videoAiAssetForm.controls['FLOOR_ID'].reset();
                this.videoAiAssetForm.controls['SPACE_ID'].reset();
                this.videoAiAssetForm.controls['SPACE_ASSET_ID'].reset();
                this.isEntitiesVisible = true;
                this.isFloorsVisible = false;
                this.isSpacesVisible = false;
                this.isSpaceAssetsVisible = false;
                this.oList_Entity_To_Show = this.oSites_and_Entities.ENTITIES.filter(entity => entity.SITE_ID == site_id);
            }
        });

        this.videoAiAssetForm.controls['ENTITY_ID'].valueChanges.subscribe(entity_id => {
            if (entity_id != null) {
                this.isFetchingData = true;
                this.videoAiAssetForm.controls['FLOOR_ID'].reset();
                this.videoAiAssetForm.controls['SPACE_ID'].reset();
                this.videoAiAssetForm.controls['SPACE_ASSET_ID'].reset();
                this.VideoAiInstanceDetailsService.Get_Floor_By_ENTITY_ID(entity_id).then(list_floor => {
                    this.oList_Floor = list_floor;
                    this.isFetchingData = false;
                    this.isFloorsVisible = true;
                    this.isSpacesVisible = false;
                    this.isSpaceAssetsVisible = false;
                })
            }
        });

        this.videoAiAssetForm.controls['FLOOR_ID'].valueChanges.subscribe(floor_id => {
            if (floor_id != null) {
                this.isFetchingData = true;
                this.videoAiAssetForm.controls['SPACE_ID'].reset();
                this.videoAiAssetForm.controls['SPACE_ASSET_ID'].reset();
                this.VideoAiInstanceDetailsService.Get_Space_By_FLOOR_ID(floor_id).then(list_space => {
                    this.oList_Space = list_space;
                    this.isFetchingData = false;
                    this.isSpacesVisible = true;
                    this.isSpaceAssetsVisible = false;
                })
            }
        });

        this.videoAiAssetForm.controls['SPACE_ID'].valueChanges.subscribe(space_id => {
            if (space_id != null) {
                this.isFetchingData = true;
                this.videoAiAssetForm.controls['SPACE_ASSET_ID'].reset();
                this.VideoAiInstanceDetailsService.Get_Space_asset_By_SPACE_ID(space_id).then(list_space_asset => {
                    this.oList_Space_Asset = list_space_asset;
                    this.isFetchingData = false;
                    this.isSpaceAssetsVisible = true;
                })
            }
        });
    }

    createVideoAiAsset(): void {
        if (this.videoAiAssetForm.controls.FRIENDLY_NAME.value.trim() != '' &&
            this.videoAiAssetForm.controls.VIDEO_AI_ENGINE_ASSET.value != null &&
            this.videoAiAssetForm.controls.SITE_ID.value != null &&
            this.videoAiAssetForm.controls.SITE_ID.value > 0 &&
            this.videoAiAssetForm.controls.ENTITY_ID.value != null &&
            this.videoAiAssetForm.controls.ENTITY_ID.value > 0 &&
            this.videoAiAssetForm.controls.FLOOR_ID.value != null &&
            this.videoAiAssetForm.controls.FLOOR_ID.value > 0 &&
            this.videoAiAssetForm.controls.SPACE_ASSET_ID.value != null &&
            this.videoAiAssetForm.controls.SPACE_ASSET_ID.value > 0 &&
            this.videoAiAssetForm.controls.SPACE_ID.value != null &&
            this.videoAiAssetForm.controls.SPACE_ID.value > 0) {
            this.isLoading = true;
            var resolution;
            if (this.videoAiAssetForm.controls.VIDEO_AI_ENGINE_ASSET.value.Resolution) {
                resolution = this.videoAiAssetForm.controls.VIDEO_AI_ENGINE_ASSET.value.Resolution.split("x", 2);
            }
            else {
                resolution = null;
            }
            this.VideoAiInstanceDetailsService
                .createVideoAiAsset(this.videoAiAssetForm.controls.SPACE_ASSET_ID.value,
                    this.videoAiAssetForm.controls.ENTITY_ID.value,
                    this.videoAiAssetForm.controls.FRIENDLY_NAME.value,
                    this.videoAiAssetForm.controls.VIDEO_AI_ENGINE_ASSET.value.Name,
                    this.videoAiAssetForm.controls.VIDEO_AI_ENGINE_ASSET.value.CameraId,
                    resolution ? resolution[0] : null,
                    resolution ? resolution[1] : null,
                    this.data.video_ai_instance_id)
                .then(result => {
                    this.isLoading = false;
                    if (result) {
                        this.dialog.closeAll();
                    }
                });
        }
        else {
            this.CmSvc.ShowMessage('Invalid Input');
        }
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            SITE_ID: ['', [Validators.required]],
            ENTITY_ID: ['', [Validators.required]],
            FLOOR_ID: ['', [Validators.required]],
            SPACE_ID: ['', [Validators.required]],
            SPACE_ASSET_ID: ['', [Validators.required]],
            FRIENDLY_NAME: ['', [Validators.required]],
            VIDEO_AI_ENGINE_ASSET: ['', [Validators.required]],
        });
    };
}
