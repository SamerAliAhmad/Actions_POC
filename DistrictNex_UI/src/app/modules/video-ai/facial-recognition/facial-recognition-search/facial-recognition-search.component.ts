import { Component, HostListener, Input, OnDestroy, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { SafeResourceUrl } from '@angular/platform-browser';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Fetch_Facial_Recognition_Response_Content, Floor, Space, Video_ai_asset } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { VideoAIService } from './../../video-ai.service';
import { FacialRecognitionFiltersComponent } from './facial-recognition-filters/facial-recognition-filters.component';

export class Facial_Recognition_Filters {
    endDate: Date;
    startDate: Date;
    HasMask: boolean;
    Target_Name: string;
    Selected_Gender: string;
    Selected_Emotion: string;
    Selected_Age_Group: string;
    List_Selected_Category: string[];
    Recognition_Score: number;
}

@Component({
    selector: 'facial-recognition-search',
    templateUrl: './facial-recognition-search.component.html',
    styleUrls: ['./facial-recognition-search.component.scss']
})
export class FacialRecognitionSearchComponent implements OnInit, OnDestroy {
    @Input() oEntity: Entity;

    oList_Search_Categories: string[] = [];
    oFacial_Recognition_Filters: Facial_Recognition_Filters = new Facial_Recognition_Filters();

    isSearching = false;
    contentLoaded = false;
    isNoFacesDetected = false;
    oList_Filter: string[] = [];

    dataSource = new MatTableDataSource<Fetch_Facial_Recognition_Response_Content>();
    displayedColumns: string[] = ['Detected Face', 'Face Image', 'Target Details', 'Time'];

    pageIndex = 0;
    pageSize = 10;
    facialRecognitionDataCount = 0;

    floorSearchInput = '';
    spaceSearchInput = '';
    cameraSearchInput = '';
    searchBox = new FormControl('');
    oSelected_Search_Category: string;
    oList_Selected_Floor: Floor[] = [];
    oList_Selected_Space: Space[] = [];
    oList_Video_ai_asset: Video_ai_asset[] = [];
    oList_Selected_Video_ai_asset: Video_ai_asset[] = [];

    numberOfRequests = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private MapService: MapService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
    ) {
        this.oList_Search_Categories = this.CmSvc.oList_Face_Target_List.map(category => category.Name).filter(Name => Name == 'AI-Team');
        this.oList_Video_ai_asset = this.CmSvc.oStream_Data.List_Video_ai_asset.filter(oVideo_ai_asset => oVideo_ai_asset.VIDEO_AI_INSTANCE_ID == 5);
        this.oFacial_Recognition_Filters.Recognition_Score = 70;
        this.oFacial_Recognition_Filters.startDate = new Date();
        this.oFacial_Recognition_Filters.endDate = new Date();
        try {
            if (localStorage.getItem('facialRecognitionSearchDataSet' + this.CmSvc.oUser_Details.USER_ID)) {
                if (localStorage.getItem('facialRecognitionFilters' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.oFacial_Recognition_Filters = JSON.parse(localStorage.getItem('facialRecognitionFilters' + this.CmSvc.oUser_Details.USER_ID)) || new Facial_Recognition_Filters;
                    this.oFacial_Recognition_Filters.startDate = new Date(this.oFacial_Recognition_Filters.startDate);
                    this.oFacial_Recognition_Filters.endDate = new Date(this.oFacial_Recognition_Filters.endDate);
                }
                if (localStorage.getItem('facialRecognitionSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Floor = JSON.parse(localStorage.getItem('facialRecognitionSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedFloor => this.oEntity.List_Floor.some(floor => floor.FLOOR_ID == selectedFloor.FLOOR_ID)) || [];
                    } catch {
                        this.oList_Selected_Floor = [];
                    }
                }
                if (localStorage.getItem('facialRecognitionSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Space = JSON.parse(localStorage.getItem('facialRecognitionSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedSpace => ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).some(space => space.SPACE_ID == selectedSpace.SPACE_ID)) || [];
                    } catch {
                        this.oList_Selected_Space = [];
                    }
                }
                if (localStorage.getItem('facialRecognitionSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Video_ai_asset = JSON.parse(localStorage.getItem('facialRecognitionSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedCamera => this.oList_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == selectedCamera.VIDEO_AI_ASSET_ID)) || [];
                    } catch {
                        this.oList_Selected_Video_ai_asset = [];
                    }
                }
            } else {
                this.oFacial_Recognition_Filters.startDate.setDate(this.oFacial_Recognition_Filters.startDate.getDate() - 3);
                this.oFacial_Recognition_Filters.endDate.setDate(this.oFacial_Recognition_Filters.endDate.getDate() + 1);
                this.oFacial_Recognition_Filters.Recognition_Score = 70;
            }
        } catch {
            this.oFacial_Recognition_Filters.startDate.setDate(this.oFacial_Recognition_Filters.startDate.getDate() - 3);
            this.oFacial_Recognition_Filters.endDate.setDate(this.oFacial_Recognition_Filters.endDate.getDate() + 1);
            this.oFacial_Recognition_Filters.Recognition_Score = 70;
        }
    }

    ngOnInit(): void {
        this.VideoAIService.facialRecognitionBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(fetchFacialRecognitionResponse => {
            if (fetchFacialRecognitionResponse) {
                this.dataSource.data = fetchFacialRecognitionResponse.Content.map(facialRecognition => {
                    facialRecognition.Datetime = facialRecognition.Datetime.split('.')[0].replace('T', ' ');
                    return facialRecognition;
                });
                this.facialRecognitionDataCount = fetchFacialRecognitionResponse.TotalElements;
                this.isNoFacesDetected = false;
                if (this.facialRecognitionDataCount == 0) {
                    this.isNoFacesDetected = true;
                }
            } else {
                this.facialRecognitionDataCount = 0;
                this.isNoFacesDetected = true;
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
        this.searchFacialRecognition();
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('facialRecognitionSearchDataSet' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(true));
        localStorage.setItem('facialRecognitionFilters' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oFacial_Recognition_Filters));
        localStorage.setItem('facialRecognitionSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Floor));
        localStorage.setItem('facialRecognitionSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Space));
        localStorage.setItem('facialRecognitionSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Video_ai_asset));
        return true;
    }

    setPage(event: PageEvent) {
        this.pageIndex = event.pageIndex;
        this.searchFacialRecognition();
    }

    searchFacialRecognition() {
        if (this.oList_Selected_Video_ai_asset && this.oList_Selected_Video_ai_asset.length > 0) {
            this.isSearching = true;
            this.isNoFacesDetected = false;

            this.VideoAIService.fetchFacialRecognition(this.oList_Selected_Video_ai_asset, this.oFacial_Recognition_Filters, this.pageSize, this.pageIndex).then(() => {
                this.isSearching = false;
            });
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
            this.searchFacialRecognition();
        }
    }

    removeCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.oList_Selected_Video_ai_asset.splice(this.oList_Selected_Video_ai_asset.indexOf(chosenCamera), 1);
        if (isSearchScene) {
            this.searchFacialRecognition();
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
                this.searchFacialRecognition();
            });
        } else {
            i_Floor.List_Space.filter(space => !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
                this.addSpaceChoice(space, false);
            });
            this.searchFacialRecognition();
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
            this.searchFacialRecognition();
        }
    }

    addSpaceChoice(i_Space: Space, isSearchScene = true): void {
        this.spaceSearchInput = '';
        this.oList_Selected_Space.unshift(i_Space);
        this.oList_Video_ai_asset.filter(oCamera => !this.oList_Selected_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == oCamera.VIDEO_AI_ASSET_ID) && i_Space.List_Space_asset?.some(space_asset => space_asset.SPACE_ASSET_ID == oCamera.SPACE_ASSET_ID)).forEach(camera => {
            this.addCameraChoice(camera, isSearchScene);
        });
        if (isSearchScene) {
            this.searchFacialRecognition();
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
            this.searchFacialRecognition();
        }
        return wasCameraSelected;
    }

    clearChosenCamera(): void {
        this.oList_Selected_Video_ai_asset = [];
        this.searchFacialRecognition();
    }

    openFiltersModal() {
        const dialogRef = this.dialog.open(FacialRecognitionFiltersComponent, {
            width: '400px',
            hasBackdrop: true,
            autoFocus: false,
            data: {
                categories: this.oList_Search_Categories,
                facial_recognition_filters: this.oFacial_Recognition_Filters
            }
        });
        dialogRef.afterClosed().subscribe(result => {
            if (result == true) {
                this.oFacial_Recognition_Filters = dialogRef.componentInstance.oFacial_Recognition_Filters;
                this.searchFacialRecognition();
            }
        });
    }

    removeNameChoice(): void {
        this.oFacial_Recognition_Filters.Target_Name = null;
        this.searchFacialRecognition();
    }

    removeGenderChoice(): void {
        this.oFacial_Recognition_Filters.Selected_Gender = null;
        this.searchFacialRecognition();
    }

    removeEmotionChoice(): void {
        this.oFacial_Recognition_Filters.Selected_Emotion = null;
        this.searchFacialRecognition();
    }

    removeHasMaskChoice(): void {
        this.oFacial_Recognition_Filters.HasMask = null;
        this.searchFacialRecognition();
    }

    removeAgeGroupChoice(): void {
        this.oFacial_Recognition_Filters.Selected_Age_Group = null;
        this.searchFacialRecognition();
    }

    removeCategoryChoice(category: string): void {
        this.oFacial_Recognition_Filters.List_Selected_Category.splice(this.oFacial_Recognition_Filters.List_Selected_Category.indexOf(category), 1);
        this.searchFacialRecognition();
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
