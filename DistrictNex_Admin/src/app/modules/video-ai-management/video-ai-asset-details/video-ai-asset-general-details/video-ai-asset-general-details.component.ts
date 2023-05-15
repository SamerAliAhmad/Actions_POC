import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { VideoAiInstanceDetailsService } from './../../video-ai-instance-details/video-ai-instance-details.service';
import { Entity, Floor, Sites_and_Entities, Space, Space_asset, Surveillance_Camera_Content, Video_ai_asset } from 'app/core/Services/proxy.service';

@Component({
    selector: 'video-ai-asset-general-details',
    templateUrl: './video-ai-asset-general-details.component.html',
    styleUrls: ['./video-ai-asset-general-details.component.scss']
})
export class VideoAiAssetGeneralDetailsComponent implements OnInit {

    @Input() oVideo_ai_asset: Video_ai_asset;
    oSites_and_Entities: Sites_and_Entities = new Sites_and_Entities();

    oList_Floor: Floor[] = [];
    oList_Space: Space[] = [];
    oList_Space_Asset: Space_asset[] = [];
    oList_Entity_To_Show: Entity[] = [];
    oList_Engine_Asset: Surveillance_Camera_Content[] = [];

    isFetchingData = false;
    isFloorsVisible = false;
    isSpacesVisible = false;
    isEntitiesVisible = false;
    isSpaceAssetsVisible = false;

    videoAiAssetForm: FormGroup;

    constructor(
        private _formBuilder: FormBuilder,
        private VideoAiInstanceDetailsService: VideoAiInstanceDetailsService,
    ) { }

    ngOnInit(): void {
        this.VideoAiInstanceDetailsService.Get_sites_and_entities().then(result => {
            this.oSites_and_Entities = result;
        })

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
