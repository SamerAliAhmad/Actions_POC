import { Injectable, OnDestroy } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRouteSnapshot, Router, RouterStateSnapshot } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import {
    Change_Video_ai_instance_Password_Response,
    Floor,
    Params_Create_Video_ai_asset,
    Params_Delete_Video_ai_asset_Custom,
    Params_Get_Floor_By_ENTITY_ID,
    Params_Get_Space_asset_By_SPACE_ID,
    Params_Get_Space_By_FLOOR_ID, Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID, Proxy,
    Sites_and_Entities,
    Space,
    Space_asset,
    Video_ai_asset, Video_ai_assets_with_engine_assets, Video_ai_instance, Video_ai_instance_with_connection_flag
} from 'app/core/Services/proxy.service';
import FuzzySearch from 'fuzzy-search';
import { cloneDeep } from 'lodash';
import { Observable, Subject } from 'rxjs';

@Injectable({
    providedIn: 'root'
})
export class VideoAiInstanceDetailsService implements OnDestroy {
    id: number;
    route = '';

    onInstanceDetailsChanged: Subject<Video_ai_instance>;
    onVideoAiAssetsChanged: Subject<Video_ai_assets_with_engine_assets>;
    onSitesAndEntitiesChanged: Subject<Sites_and_Entities>;
    isConnectionUrlValid: Subject<boolean>;

    oVideo_ai_instance: Video_ai_instance = new Video_ai_instance();
    oVideo_ai_assets_with_engine_assets: Video_ai_assets_with_engine_assets = new Video_ai_assets_with_engine_assets();
    oSites_and_Entities: Sites_and_Entities = new Sites_and_Entities();
    oList_Floor: Floor[] = [];
    oList_Space: Space[] = [];
    oList_Space_asset: Space_asset[] = [];
    oList_Video_ai_asset: Video_ai_asset[];

    constructor(
        private proxy: Proxy,
        private router: Router,
        public dialog: MatDialog,
        private CmSvc: CommonService,
    ) {
        this.onInstanceDetailsChanged = new Subject();
        this.onVideoAiAssetsChanged = new Subject();
        this.onSitesAndEntitiesChanged = new Subject();
        this.isConnectionUrlValid = new Subject();
    }

    resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<any> | Promise<any> | any {
        return new Promise<void>((resolve, reject) => {
            this.id = route.params.videoAiInstanceId;
            Promise.all([
            ]).then(
                () => {
                    this.getInstanceDetails();
                    resolve();
                },
                reject
            );
        });
    }

    getInstanceDetails(): Promise<Video_ai_instance> {
        return new Promise((resolve, reject) => {
            if (!isNaN(this.id) && !isNaN(this.id - 0)) {

                let oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID: Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID();
                oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID = this.id;
                this.proxy.Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID)
                    .subscribe(result_instance => {
                        if (result_instance != null) {
                            this.oVideo_ai_instance = result_instance;
                            this.onInstanceDetailsChanged.next(result_instance);
                            resolve(result_instance);
                        } else {
                            this.onInstanceDetailsChanged.next(null);
                            this.router.navigateByUrl("/video-ai-management");
                            resolve(null);
                        }
                    });
            }
            else {
                this.onInstanceDetailsChanged.next(null);
                this.router.navigateByUrl("/video-ai-management");
                resolve(null);
            }
        });
    }

    editVideoAiInstance(i_Video_ai_instance: Video_ai_instance, force_connection: boolean): Promise<Video_ai_instance_with_connection_flag> {
        return new Promise((resolve) => {
            this.proxy.Edit_Video_ai_instance_custom({
                Video_ai_instance: i_Video_ai_instance,
                FORCE_CONNECTION: force_connection,
            }).subscribe(result => {
                if (result.oVideo_ai_instance) {
                    this.CmSvc.Handle_Success();
                    this.onInstanceDetailsChanged.next(result.oVideo_ai_instance);
                }
                resolve(result);
            });
        });
    }

    getVideoAiAssets(): Promise<Video_ai_assets_with_engine_assets> {
        return new Promise((resolve) => {
            let oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID: Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID();
            oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID = this.id;
            this.proxy.Get_Video_ai_assets_with_engine_assets(oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID).subscribe(result => {
                if (result) {
                    this.oVideo_ai_assets_with_engine_assets = result;
                    this.oVideo_ai_assets_with_engine_assets.VIDEO_AI_ASSET_WITH_FLAG_LIST.filter(x => !x.IS_DELETED);
                    this.onVideoAiAssetsChanged.next(this.oVideo_ai_assets_with_engine_assets);
                }
                resolve(result);
            })
        })
    }

    filterSearchVideoAiAssets(videoAiAssetName: string): void {
        let resultList = cloneDeep(this.oVideo_ai_assets_with_engine_assets);
        if (videoAiAssetName && videoAiAssetName.trim() != '') {
            const searcher = new FuzzySearch(resultList.VIDEO_AI_ASSET_WITH_FLAG_LIST, ['FRIENDLY_NAME']);
            resultList.VIDEO_AI_ASSET_WITH_FLAG_LIST = searcher.search(videoAiAssetName);
        }
        this.onVideoAiAssetsChanged.next(resultList);
    }

    deleteVideoAiAsset(videoAiAssetID: number): Promise<boolean> {
        return new Promise((resolve, reject) => {
            let oParams_Delete_Video_ai_asset_Custom: Params_Delete_Video_ai_asset_Custom = new Params_Delete_Video_ai_asset_Custom();
            oParams_Delete_Video_ai_asset_Custom.VIDEO_AI_ASSET_ID = videoAiAssetID;
            this.proxy.Delete_Video_ai_asset_Custom(oParams_Delete_Video_ai_asset_Custom).subscribe(result => {
                this.oVideo_ai_assets_with_engine_assets.VIDEO_AI_ASSET_WITH_FLAG_LIST.splice(this.oVideo_ai_assets_with_engine_assets.VIDEO_AI_ASSET_WITH_FLAG_LIST.map(x => x.VIDEO_AI_ASSET_ID).indexOf(videoAiAssetID), 1);
                this.onVideoAiAssetsChanged.next(this.oVideo_ai_assets_with_engine_assets);
                resolve(result);
            })
        });
    }

    Get_sites_and_entities(): Promise<Sites_and_Entities> {
        return new Promise((resolve, reject) => {
            this.proxy.Get_Sites_and_Entities().subscribe(result => {
                this.oSites_and_Entities = result;
                resolve(result);
            });
        });
    }

    Get_Video_ai_assets(): Promise<Video_ai_asset[]> {
        return new Promise(resolve => {
            if (this.oList_Video_ai_asset) {
                resolve(this.oList_Video_ai_asset);
            } else {
                this.proxy.Get_Video_ai_asset_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.oList_Video_ai_asset = result;
                    resolve(this.oList_Video_ai_asset);
                });
            }
        });
    }

    changeInstancePassword(NewPassword: string, videoAiInstanceId: number, forceConnection = false): Promise<Change_Video_ai_instance_Password_Response> {
        return new Promise((resolve, reject) => {
            this.proxy.Change_Video_ai_instance_Password({
                NEW_PASSWORD: NewPassword,
                VIDEO_AI_INSTANCE_ID: videoAiInstanceId,
                FORCE_CONNECTION: forceConnection,
            }).subscribe(result => {
                resolve(result);
            });
        });
    }

    Get_Floor_By_ENTITY_ID(entity_id: number): Promise<Floor[]> {
        return new Promise((resolve, reject) => {
            let oParams_Get_Floor_By_ENTITY_ID: Params_Get_Floor_By_ENTITY_ID = new Params_Get_Floor_By_ENTITY_ID();
            oParams_Get_Floor_By_ENTITY_ID.ENTITY_ID = entity_id;
            this.proxy.Get_Floor_By_ENTITY_ID(oParams_Get_Floor_By_ENTITY_ID).subscribe(result_floors => {
                this.oList_Floor = result_floors;
                resolve(result_floors);
            });
        });
    }

    Get_Space_By_FLOOR_ID(floor_id: number): Promise<Space[]> {
        return new Promise((resolve, reject) => {
            let oParams_Get_Space_By_FLOOR_ID: Params_Get_Space_By_FLOOR_ID = new Params_Get_Space_By_FLOOR_ID();
            oParams_Get_Space_By_FLOOR_ID.FLOOR_ID = floor_id;
            this.proxy.Get_Space_By_FLOOR_ID(oParams_Get_Space_By_FLOOR_ID).subscribe(result_spaces => {
                this.oList_Space = result_spaces;
                resolve(result_spaces);
            });
        });
    }

    Get_Space_asset_By_SPACE_ID(space_id: number): Promise<Space_asset[]> {
        return new Promise((resolve, reject) => {
            let oParams_Get_Space_asset_By_SPACE_ID: Params_Get_Space_asset_By_SPACE_ID = new Params_Get_Space_asset_By_SPACE_ID();
            oParams_Get_Space_asset_By_SPACE_ID.SPACE_ID = space_id;
            this.proxy.Get_Space_asset_By_SPACE_ID_Adv(oParams_Get_Space_asset_By_SPACE_ID).subscribe(result_space_assets => {
                this.oList_Space_asset = result_space_assets;
                resolve(result_space_assets);
            });
        });
    }

    createVideoAiAsset(space_asset_id: number, entity_id: number, friendly_name: string, functional_name: string, cameraId: number, resolution_x: number = null, resolution_y: number = null, video_ai_instance_id: number): Promise<Video_ai_asset> {
        return new Promise((resolve) => {
            let oParams_Create_Video_ai_asset: Params_Create_Video_ai_asset = new Params_Create_Video_ai_asset();
            oParams_Create_Video_ai_asset.ENTITY_ID = entity_id;
            oParams_Create_Video_ai_asset.FRIENDLY_NAME = friendly_name;
            oParams_Create_Video_ai_asset.FUNCTIONAL_NAME = functional_name;
            oParams_Create_Video_ai_asset.SPACE_ASSET_ID = space_asset_id;
            oParams_Create_Video_ai_asset.VIDEO_AI_ASSET_ID_REF = cameraId;
            oParams_Create_Video_ai_asset.VIDEO_AI_INSTANCE_ID = video_ai_instance_id;
            oParams_Create_Video_ai_asset.RESOLUTION_X = resolution_x;
            oParams_Create_Video_ai_asset.RESOLUTION_Y = resolution_y;
            this.proxy.Create_Video_ai_asset(oParams_Create_Video_ai_asset).subscribe(result => {
                this.oVideo_ai_assets_with_engine_assets.VIDEO_AI_ASSET_WITH_FLAG_LIST.unshift(result);
                this.onVideoAiAssetsChanged.next(this.oVideo_ai_assets_with_engine_assets);
                if (this.oList_Video_ai_asset) {
                    this.oList_Video_ai_asset.push(result);
                }
                this.CmSvc.Handle_Success();
                resolve(result);
            });
        });
    }

    ngOnDestroy(): void {
        this.onInstanceDetailsChanged.unsubscribe();
        this.onVideoAiAssetsChanged.unsubscribe();
        this.onSitesAndEntitiesChanged.unsubscribe();
        this.isConnectionUrlValid.unsubscribe();
    }
}
