import { Component, HostListener, Input, OnDestroy, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { PageEvent } from '@angular/material/paginator';
import { SafeResourceUrl } from '@angular/platform-browser';
import { Displayed_Category } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Fetch_Scenes_Response_Content, Floor, Space, Video_ai_asset } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { VideoAIService } from '../video-ai.service';
import { AdvancedSearchInstructionsComponent } from './advanced-search-instructions/advanced-search-instructions.component';
import { SceneModalComponent } from './scene-modal/scene-modal.component';

@Component({
    selector: 'scene-search',
    templateUrl: './scene-search.component.html',
    styleUrls: ['./scene-search.component.scss']
})
export class SceneSearchComponent implements OnInit, OnDestroy {
    @Input() oEntity: Entity;

    isError = false;
    errorMessage = '';
    isNoImages = false;
    isSearching = false;
    contentLoaded = false;
    oList_Filter: string[] = [];
    oList_Scene: Fetch_Scenes_Response_Content[] = [];

    oList_Operators = ['>', '<', '>=', '<=', '=', ' and ', ' or '];
    oList_Colors = ['Red', 'Green', 'Blue', 'Yellow', 'Black', 'White', 'Gray', 'Pink'];

    pageSize = 20;
    pageIndex = 0;
    imageCount = 0;

    endDate = new Date();
    maxDate = new Date();
    startDate = new Date();

    floorSearchInput = '';
    spaceSearchInput = '';
    cameraSearchInput = '';
    categorySearchInput = '';
    isAdvancedSearch = false;
    searchBox = new FormControl('');
    oList_Selected_Floor: Floor[] = [];
    oList_Selected_Space: Space[] = [];
    oList_Video_ai_asset: Video_ai_asset[] = [];
    oList_Search_Categories: Displayed_Category[] = [];
    oList_Selected_Video_ai_asset: Video_ai_asset[] = [];
    oList_Selected_Search_Categories: Displayed_Category[] = [];

    numberOfRequests = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private MapService: MapService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
    ) {
        this.oList_Search_Categories = this.CmSvc.oStream_Data.List_Search_type.map(value => {
            return {
                name: value.replace('_', ' '),
                value: value,
            };
        });
        this.oList_Video_ai_asset = this.CmSvc.oStream_Data.List_Video_ai_asset.filter(oVideo_ai_asset => oVideo_ai_asset.VIDEO_AI_INSTANCE_ID == 1);

        try {
            if (localStorage.getItem('sceneSearchDataSet' + this.CmSvc.oUser_Details.USER_ID)) {
                if (localStorage.getItem('sceneSearchAdvancedSearchValue' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.searchBox = new FormControl(JSON.parse(localStorage.getItem('sceneSearchAdvancedSearchValue' + this.CmSvc.oUser_Details.USER_ID)));
                }
                if (localStorage.getItem('sceneSearchStartTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.startDate = new Date(JSON.parse(localStorage.getItem('sceneSearchStartTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('sceneSearchEndTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.endDate = new Date(JSON.parse(localStorage.getItem('sceneSearchEndTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('sceneSearchIsAdvancedSearch' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.isAdvancedSearch = JSON.parse(localStorage.getItem('sceneSearchIsAdvancedSearch' + this.CmSvc.oUser_Details.USER_ID)) || false;
                }
                if (localStorage.getItem('sceneSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Floor = JSON.parse(localStorage.getItem('sceneSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedFloor => this.oEntity.List_Floor.some(floor => floor.FLOOR_ID == selectedFloor.FLOOR_ID)) || [];
                    } catch {
                        this.oList_Selected_Floor = [];
                    }
                }
                if (localStorage.getItem('sceneSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Space = JSON.parse(localStorage.getItem('sceneSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedSpace => ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).some(space => space.SPACE_ID == selectedSpace.SPACE_ID)) || [];
                    } catch {
                        this.oList_Selected_Space = [];
                    }
                }
                if (localStorage.getItem('sceneSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Video_ai_asset = JSON.parse(localStorage.getItem('sceneSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedCamera => this.oList_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == selectedCamera.VIDEO_AI_ASSET_ID)) || [];
                    } catch {
                        this.oList_Selected_Video_ai_asset = [];
                    }
                }
                if (localStorage.getItem('sceneSearchSelectedCategories' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Search_Categories = JSON.parse(localStorage.getItem('sceneSearchSelectedCategories' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedCategory => this.oList_Search_Categories.some(category => category.value == selectedCategory.value)) || [];
                    } catch {
                        this.oList_Selected_Search_Categories = [];
                    }
                }
            } else {
                this.startDate.setDate(this.startDate.getDate() - 3);
                this.endDate.setDate(this.endDate.getDate() + 1);
            }
        } catch {
            this.startDate.setDate(this.startDate.getDate() - 3);
            this.endDate.setDate(this.endDate.getDate() + 1);
        }
    }

    ngOnInit(): void {
        this.VideoAIService.imagesBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(fetchScenesResponse => {
            const query = this.isAdvancedSearch ? this.searchBox.value : this.oList_Selected_Search_Categories.map(category => category.value).join(" and ");
            if (fetchScenesResponse && query && this.oList_Selected_Video_ai_asset.length > 0) {
                if (fetchScenesResponse.IS_ERROR) {
                    this.imageCount = 0;
                    this.isError = this.searchBox.value && this.isAdvancedSearch;
                    this.oList_Scene = [];
                    this.isNoImages = false;
                    this.errorMessage = fetchScenesResponse.ERROR_MESSAGE;
                } else if (fetchScenesResponse.Fetch_Scenes_Api_Response && fetchScenesResponse.Fetch_Scenes_Api_Response.Content) {
                    this.imageCount = fetchScenesResponse.Fetch_Scenes_Api_Response.TotalElements;
                    this.oList_Scene = fetchScenesResponse.Fetch_Scenes_Api_Response.Content.map(scene => {
                        scene.Datetime = scene.Datetime.split('.')[0].replace('T', ' ');
                        return scene;
                    });
                    this.isError = false;
                    this.isNoImages = false;
                    if (this.oList_Scene.length == 0) {
                        this.isNoImages = true;
                    }
                } else {
                    this.imageCount = 0;
                    this.oList_Scene = [];
                    this.isError = false;
                    this.isNoImages = true;
                }
            } else {
                this.imageCount = 0;
                this.oList_Scene = [];
                this.isError = false;
                this.isNoImages = true;
            }
        });
        if (this.oEntity) {
            if (this.oEntity.List_Floor.some(floor => floor.List_Space.some(space => !space.List_Space_asset))) {
                this.numberOfRequests.push(true);
                this.MapService.Get_Space_asset_By_SPACE_ID_List_Adv([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space))).then(() => {
                    this.numberOfRequests.splice(0, 1);
                });
            }
            this.floorSearchInput = '';
        }
        this.searchScenes();
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('sceneSearchDataSet' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(true));
        localStorage.setItem('sceneSearchEndTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.endDate));
        localStorage.setItem('sceneSearchStartTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.startDate));
        localStorage.setItem('sceneSearchIsAdvancedSearch' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.isAdvancedSearch));
        localStorage.setItem('sceneSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Floor));
        localStorage.setItem('sceneSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Space));
        localStorage.setItem('sceneSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Video_ai_asset));
        localStorage.setItem('sceneSearchSelectedCategories' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Search_Categories));
        try {
            localStorage.setItem('sceneSearchAdvancedSearchValue' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.searchBox.value));
        } catch (error) {
            localStorage.setItem('sceneSearchAdvancedSearchValue' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(''));
        }
        return true;
    }

    SceneClicked(scene: Fetch_Scenes_Response_Content) {
        const dialogRef = this.dialog.open(SceneModalComponent, {
            minWidth: '744px',
            minHeight: '499.5px',
            data: {
                sceneId: scene.SceneId,
                cameraName: scene.CameraName,
                searchBoxValue: this.searchBox.value,
                isAdvancedSearch: this.isAdvancedSearch,
                oList_Selected_Search_Categories: this.oList_Selected_Search_Categories,
                camera: this.oList_Video_ai_asset.filter(camera => camera.VIDEO_AI_ASSET_ID_REF == scene.CameraId)[0],
            },
            autoFocus: false,
            panelClass: 'custom-modalbox'
        });
        dialogRef.componentInstance.goBackEventEmitter.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            const sceneIndex = this.oList_Scene.findIndex(oScene => oScene.SceneId == dialogRef.componentInstance.oSceneId);
            dialogRef.componentInstance.changeScene(this.oList_Scene[sceneIndex - 1 < 0 ? this.oList_Scene.length - 1 : sceneIndex - 1].SceneId, this.oList_Video_ai_asset.filter(camera => camera.VIDEO_AI_ASSET_ID_REF == scene.CameraId)[0].VIDEO_AI_INSTANCE_ID);
        });
        dialogRef.componentInstance.goForwardEventEmitter.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            const sceneIndex = this.oList_Scene.findIndex(oScene => oScene.SceneId == dialogRef.componentInstance.oSceneId);
            dialogRef.componentInstance.changeScene(this.oList_Scene[sceneIndex + 1 > this.oList_Scene.length - 1 ? 0 : sceneIndex + 1].SceneId, this.oList_Video_ai_asset.filter(camera => camera.VIDEO_AI_ASSET_ID_REF == scene.CameraId)[0].VIDEO_AI_INSTANCE_ID);
        });
    }

    OpenInstructionModal() {
        const dialogRef = this.dialog.open(AdvancedSearchInstructionsComponent, {
            width: '400px',
            autoFocus: false,
        })
    }

    setPage(event: PageEvent) {
        this.pageIndex = event.pageIndex;
        this.searchScenes();
    }

    searchScenes() {
        const query = this.isAdvancedSearch ? this.searchBox.value : this.oList_Selected_Search_Categories.map(category => category.value).join(" and ");
        this.isError = false;
        this.isSearching = true;
        this.isNoImages = false;
        if (query) {
            this.VideoAIService.fetchPhotos(this.startDate, this.endDate, this.oList_Selected_Video_ai_asset, query, this.pageSize, this.pageIndex).then(() => {
                this.isSearching = false;
            });;
        } else {
            this.oList_Scene = [];
            this.isSearching = false;
        }
    }

    searchScenesOnEnter(event: KeyboardEvent) {
        if (event.key == 'Enter') {
            this.searchScenes();
        }
    }

    filter_Categories() {
        return this.oList_Search_Categories.filter(oCategory => !this.oList_Selected_Search_Categories.some(category => category == oCategory) && oCategory.name.toLowerCase().includes(this.categorySearchInput.toLowerCase()));
    }

    filter_Cameras() {
        return this.oList_Video_ai_asset.filter(oCamera => !this.oList_Selected_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == oCamera.VIDEO_AI_ASSET_ID) && oCamera.FRIENDLY_NAME.toLowerCase().includes(this.cameraSearchInput.toLowerCase()));
    }

    filter_Floors() {
        return this.oEntity.List_Floor.filter(floor => floor.List_Space.some(space => space.HAS_VIDEO_AI_ASSETS) && !this.oList_Selected_Floor.some(oFloor => oFloor.FLOOR_ID == floor.FLOOR_ID) && floor.NAME.toLowerCase().includes(this.floorSearchInput.toLowerCase()));
    }

    filter_Spaces() {
        return ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).filter(space => space.HAS_VIDEO_AI_ASSETS && !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID) && space.NAME.toLowerCase().includes(this.spaceSearchInput.toLowerCase()));
    }

    getNumberOfInstances() {
        return [...new Set(this.oList_Selected_Video_ai_asset.map(video_ai_asset => video_ai_asset.VIDEO_AI_INSTANCE_ID))].length;
    }

    Get_Autocomplete_List(): string[] {
        return [];
    }

    toggleObjectTypeChoice(chosenObjectType: Displayed_Category): void {
        if (this.oList_Selected_Search_Categories.includes(chosenObjectType)) {
            this.removeObjectTypeChoice(chosenObjectType);
        }
        else {
            this.addObjectTypeChoice(chosenObjectType);
        }
    }

    toggleCameraChoice(chosenCamera: Video_ai_asset): void {
        if (this.oList_Selected_Video_ai_asset.includes(chosenCamera)) {
            this.removeCameraChoice(chosenCamera);
        }
        else {
            this.addCameraChoice(chosenCamera);
        }
    }

    addObjectTypeChoice(chosenObjectType: Displayed_Category): void {
        this.oList_Selected_Search_Categories.unshift(chosenObjectType);
        this.searchScenes();
        this.categorySearchInput = '';
    }

    removeObjectTypeChoice(chosenObjectType: Displayed_Category): void {
        this.oList_Selected_Search_Categories.splice(this.oList_Selected_Search_Categories.indexOf(chosenObjectType), 1);
        this.searchScenes();
    }

    addCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.cameraSearchInput = '';
        this.oList_Selected_Video_ai_asset.unshift(chosenCamera);
        if (isSearchScene) {
            this.searchScenes();
        }
    }

    removeCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.oList_Selected_Video_ai_asset.splice(this.oList_Selected_Video_ai_asset.indexOf(chosenCamera), 1);
        if (isSearchScene) {
            this.searchScenes();
        }
    }

    addFloorChoice(i_Floor: Floor): void {
        this.floorSearchInput = '';
        this.oList_Selected_Floor.unshift(i_Floor);
        if (i_Floor.List_Space.some(space => !space.List_Space_asset)) {
            this.numberOfRequests.push(true);
            this.MapService.Get_Space_asset_By_SPACE_ID_List_Adv(i_Floor.List_Space).then(() => {
                this.numberOfRequests.splice(0, 1);
                i_Floor.List_Space.filter(space => !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
                    this.addSpaceChoice(space, false);
                });
                this.searchScenes();
            });
        } else {
            i_Floor.List_Space.filter(space => !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
                this.addSpaceChoice(space, false);
            });
            this.searchScenes();
        }
    }

    removeFloorChoice(i_Floor: Floor): void {
        this.oList_Selected_Floor.splice(this.oList_Selected_Floor.indexOf(i_Floor), 1);
        let wasCameraSelected = false;
        i_Floor.List_Space.filter(space => this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
            const result = this.removeSpaceChoice(space, false);
            if (result) {
                wasCameraSelected = true;
            }
        });
        if (wasCameraSelected) {
            this.searchScenes();
        }
    }

    addSpaceChoice(i_Space: Space, isSearchScene = true): void {
        this.spaceSearchInput = '';
        this.oList_Selected_Space.unshift(i_Space);
        this.oList_Video_ai_asset.filter(oCamera => !this.oList_Selected_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == oCamera.VIDEO_AI_ASSET_ID) && i_Space.List_Space_asset?.some(space_asset => space_asset.SPACE_ASSET_ID == oCamera.SPACE_ASSET_ID)).forEach(camera => {
            this.addCameraChoice(camera, isSearchScene);
        });
        if (isSearchScene) {
            this.searchScenes();
        }
    }

    removeSpaceChoice(i_Space: Space, isSearchScene = true): boolean {
        this.oList_Selected_Space.splice(this.oList_Selected_Space.indexOf(i_Space), 1);
        let wasCameraSelected = false;
        i_Space.List_Space_asset?.forEach(space_asset => {
            let oVideo_ai_asset = this.oList_Selected_Video_ai_asset.find(video_ai_asset => video_ai_asset.SPACE_ASSET_ID == space_asset.SPACE_ASSET_ID);
            if (oVideo_ai_asset) {
                this.removeCameraChoice(oVideo_ai_asset, false);
                wasCameraSelected = true;
            }
        });
        if (isSearchScene) {
            this.searchScenes();
        }
        return wasCameraSelected;
    }

    clearObjectFilter(): void {
        this.oList_Selected_Search_Categories = [];
        this.searchScenes();
    }

    clearChosenCamera(): void {
        this.oList_Selected_Video_ai_asset = [];
        this.searchScenes();
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
