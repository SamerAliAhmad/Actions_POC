import { Component, HostListener, Input, OnDestroy, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { PageEvent } from '@angular/material/paginator';
import { SafeResourceUrl } from '@angular/platform-browser';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Face_Key_Response, Floor, Search_Face_Target_Key_Response, Space, Video_ai_asset } from 'app/core/Services/proxy.service';
import { Detect_Face_Response } from 'app/core/Services/proxyExt.service';
import { MapService } from 'app/modules/map/map.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { VideoAIService } from './../../video-ai.service';
import { UploadPictureModalComponent } from './upload-picture-modal/upload-picture-modal.component';

@Component({
    selector: 'face-search',
    templateUrl: './face-search.component.html',
    styleUrls: ['./face-search.component.scss']
})
export class FaceSearchComponent implements OnInit, OnDestroy {
    @Input() oEntity: Entity;

    oDetect_Face_Response: Detect_Face_Response;
    recognitionScore: FormControl = new FormControl(70);

    isFaceMatch = true;
    isSearching = false;
    contentLoaded = false;
    isNoMatchesFound = false;

    numberOfRequests = [];
    oList_Filter: string[] = [];
    oList_Selected_Floor: Floor[] = [];
    oList_Selected_Space: Space[] = [];
    oList_Search_Categories: string[] = [];
    oList_Video_ai_asset: Video_ai_asset[] = [];
    List_Face_Key_Response: Face_Key_Response[];
    oList_Selected_Video_ai_asset: Video_ai_asset[] = [];
    List_Search_Face_Target_Key_Response: Search_Face_Target_Key_Response[];

    pageIndex = 0;
    pageSize = 10;
    faceSearchDataCount = 0;

    endDate = new Date();
    startDate = new Date();

    floorSearchInput = '';
    spaceSearchInput = '';
    cameraSearchInput = '';
    searchBox = new FormControl('');
    oSelected_Search_Category: string;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private MapService: MapService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
    ) {
        this.oList_Search_Categories = this.CmSvc.oList_Face_Target_List.map(category => category.Name).filter(Name => Name == 'AI-Team');
        this.oList_Video_ai_asset = this.CmSvc.oStream_Data.List_Video_ai_asset;

        try {
            if (localStorage.getItem('faceSearchDataSet' + this.CmSvc.oUser_Details.USER_ID)) {
                if (localStorage.getItem('faceSearchStartTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.startDate = new Date(JSON.parse(localStorage.getItem('faceSearchStartTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('faceSearchEndTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.endDate = new Date(JSON.parse(localStorage.getItem('faceSearchEndTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('faceSearchSimilarity' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.recognitionScore.setValue(JSON.parse(localStorage.getItem('faceSearchSimilarity' + this.CmSvc.oUser_Details.USER_ID)) || 70);
                }
                if (localStorage.getItem('faceSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Floor = JSON.parse(localStorage.getItem('faceSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedFloor => this.oEntity.List_Floor.some(floor => floor.FLOOR_ID == selectedFloor.FLOOR_ID)) || [];
                    } catch {
                        this.oList_Selected_Floor = [];
                    }
                }
                if (localStorage.getItem('faceSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Space = JSON.parse(localStorage.getItem('faceSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedSpace => ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).some(space => space.SPACE_ID == selectedSpace.SPACE_ID)) || [];
                    } catch {
                        this.oList_Selected_Space = [];
                    }
                }
                if (localStorage.getItem('faceSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Video_ai_asset = JSON.parse(localStorage.getItem('faceSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedCamera => this.oList_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == selectedCamera.VIDEO_AI_ASSET_ID)) || [];
                    } catch {
                        this.oList_Selected_Video_ai_asset = [];
                    }
                }
            } else {
                this.startDate.setDate(this.startDate.getDate() - 3);
                this.endDate.setDate(this.endDate.getDate() + 1);
                this.recognitionScore.setValue(70);
            }
        } catch {
            this.startDate.setDate(this.startDate.getDate() - 3);
            this.endDate.setDate(this.endDate.getDate() + 1);
            this.recognitionScore.setValue(70);
        }
    }

    ngOnInit(): void {
        this.VideoAIService.faceSearchBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(faceSearchResponse => {
            if (faceSearchResponse) {
                this.List_Face_Key_Response = faceSearchResponse.FACET_KEY_RESPONSE_LIST.map(faceSearch => {
                    faceSearch.Datetime = faceSearch.Datetime.split('.')[0].replace('T', ' ');
                    return faceSearch;
                });
                this.faceSearchDataCount = faceSearchResponse.TOTAL_ELEMENTS;
                this.isNoMatchesFound = false;
                if (this.faceSearchDataCount == 0) {
                    this.isNoMatchesFound = true;
                }
            } else {
                this.faceSearchDataCount = 0;
                this.isNoMatchesFound = true;
            }
        });
        this.VideoAIService.faceTargetKeySearchBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(faceTargetKeySearchResponse => {
            if (faceTargetKeySearchResponse) {
                this.List_Search_Face_Target_Key_Response = faceTargetKeySearchResponse.SEARCH_FACE_TARGET_KEY_RESPONSE_LIST.map(face_key_target => {
                    return face_key_target;
                });
                this.faceSearchDataCount = faceTargetKeySearchResponse.TOTAL_ELEMENTS;
                this.isNoMatchesFound = false;
                if (this.faceSearchDataCount == 0) {
                    this.isNoMatchesFound = true;
                }
            } else {
                this.faceSearchDataCount = 0;
                this.isNoMatchesFound = true;
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
        this.faceSearch();

        this.recognitionScore.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(1000),
                distinctUntilChanged()
            )
            .subscribe(score => {
                this.faceSearch();
            });
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('faceSearchDataSet' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(true));
        localStorage.setItem('faceSearchEndTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.endDate));
        localStorage.setItem('faceSearchStartTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.startDate));
        localStorage.setItem('faceSearchSimilarity' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.recognitionScore.value));
        localStorage.setItem('faceSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Floor));
        localStorage.setItem('faceSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Space));
        localStorage.setItem('faceSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Video_ai_asset));
        return true;
    }

    setPage(event: PageEvent) {
        this.pageIndex = event.pageIndex;
        this.faceSearch();
    }

    faceSearch() {
        if (this.oDetect_Face_Response && this.oDetect_Face_Response.Descriptor != '') {
            if (this.isFaceMatch) {
                if (this.oList_Selected_Video_ai_asset && this.oList_Selected_Video_ai_asset.length) {
                    this.isSearching = true;
                    this.isNoMatchesFound = false;
                    this.VideoAIService.faceSearch(this.oList_Selected_Video_ai_asset, this.oDetect_Face_Response.Descriptor, 1000, this.recognitionScore.value, this.startDate, this.endDate, this.pageIndex * this.pageSize, this.pageSize).then(() => {
                        this.isSearching = false;
                    });
                }
                else {
                    this.CmSvc.ShowMessage("Image Uploaded, Select Cameras to Search")
                }
            }
            else {
                this.isSearching = true;
                this.isNoMatchesFound = false;
                this.VideoAIService.faceTargetKeySearch(this.oDetect_Face_Response.Descriptor, 1000, this.recognitionScore.value, this.pageIndex * this.pageSize, this.pageSize).then(() => {
                    this.isSearching = false;
                });
            }
        }
        else {
            this.CmSvc.ShowMessage("No Image Uploaded")
        }
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

    addCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.cameraSearchInput = '';
        this.oList_Selected_Video_ai_asset.unshift(chosenCamera);
        if (isSearchScene) {
            this.faceSearch();
        }
    }

    removeCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.oList_Selected_Video_ai_asset.splice(this.oList_Selected_Video_ai_asset.indexOf(chosenCamera), 1);
        if (isSearchScene) {
            this.faceSearch();
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
                this.faceSearch();
            });
        } else {
            i_Floor.List_Space.filter(space => !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
                this.addSpaceChoice(space, false);
            });
            this.faceSearch();
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
            this.faceSearch();
        }
    }

    addSpaceChoice(i_Space: Space, isSearchScene = true): void {
        this.spaceSearchInput = '';
        this.oList_Selected_Space.unshift(i_Space);
        this.oList_Video_ai_asset.filter(oCamera => !this.oList_Selected_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == oCamera.VIDEO_AI_ASSET_ID) && i_Space.List_Space_asset?.some(space_asset => space_asset.SPACE_ASSET_ID == oCamera.SPACE_ASSET_ID)).forEach(camera => {
            this.addCameraChoice(camera, isSearchScene);
        });
        if (isSearchScene) {
            this.faceSearch();
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
            this.faceSearch();
        }
        return wasCameraSelected;
    }

    clearChosenCamera(): void {
        this.oList_Selected_Video_ai_asset = [];
        this.faceSearch();
    }

    uploadPictureDialog(): void {
        const dialogRef = this.dialog.open(UploadPictureModalComponent, {
            width: '400px',
            autoFocus: false
        })

        dialogRef.afterClosed().subscribe(result => {
            if (result == true) {
                this.oDetect_Face_Response = dialogRef.componentInstance.oDetect_Face_Response;
                this.faceSearch();
            }
        });
    }

    removeImage() {
        this.oDetect_Face_Response = null;
        this.List_Face_Key_Response = [];
        this.List_Search_Face_Target_Key_Response = [];
        this.faceSearchDataCount = 0;
        this.faceSearch();
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }

}
