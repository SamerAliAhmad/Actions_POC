import { Component, HostListener, Input, OnDestroy, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { PageEvent } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { SafeResourceUrl } from '@angular/platform-browser';
import { CommonService } from 'app/core/Services/common.service';
import { Entity, Fetch_License_Plate_Recognition_Response_Content, Floor, Space, Video_ai_asset } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { VideoAIService } from './../../video-ai.service';
import { LicensePlateModalComponent } from './../license-plate-modal/license-plate-modal.component';

@Component({
    selector: 'license-plate-search',
    templateUrl: './license-plate-search.component.html',
    styleUrls: ['./license-plate-search.component.scss']
})
export class LicensePlateSearchComponent implements OnInit, OnDestroy {
    @Input() oEntity: Entity;

    isError = false;
    isSearching = false;
    contentLoaded = false;
    isNoLicensePlates = false;
    oList_Filter: string[] = [];
    oList_Licesne_Plate_Recognition_Data: Fetch_License_Plate_Recognition_Response_Content[] = [];

    dataSource = new MatTableDataSource<Fetch_License_Plate_Recognition_Response_Content>();
    displayedColumns: string[] = ['License Plate Image', 'License Plate', 'License Plate Details', 'Time'];

    pageSize = 20;
    pageIndex = 0;
    licensePlateDataCount = 0;

    endDate = new Date();
    startDate = new Date();

    errorMessage = '';
    floorSearchInput = '';
    spaceSearchInput = '';
    cameraSearchInput = '';
    searchBox = new FormControl('');
    oSelected_Search_Category: string;
    oList_Selected_Floor: Floor[] = [];
    oList_Selected_Space: Space[] = [];
    oList_Search_Categories: string[] = [];
    licensePlateSearchNumberSearchInput: FormControl;
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
        this.licensePlateSearchNumberSearchInput = new FormControl('');
        this.oList_Search_Categories = this.CmSvc.oStream_Data.List_Search_type
            .filter(category => category == "vehicle" || category == "bicycle" ||
                category == "bus" || category == "car" || category == "motorcycle" ||
                category == "truck");
        this.oList_Video_ai_asset = this.CmSvc.oStream_Data.List_Video_ai_asset.filter(oVideo_ai_asset => oVideo_ai_asset.VIDEO_AI_INSTANCE_ID == 5);

        try {
            if (localStorage.getItem('licensePlateSearchDataSet' + this.CmSvc.oUser_Details.USER_ID)) {
                if (localStorage.getItem('licensePlateSearchStartTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.startDate = new Date(JSON.parse(localStorage.getItem('licensePlateSearchStartTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('licensePlateSearchEndTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.endDate = new Date(JSON.parse(localStorage.getItem('licensePlateSearchEndTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('licensePlateSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Floor = JSON.parse(localStorage.getItem('licensePlateSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedFloor => this.oEntity.List_Floor.some(floor => floor.FLOOR_ID == selectedFloor.FLOOR_ID)) || [];
                    } catch {
                        this.oList_Selected_Floor = [];
                    }
                }
                if (localStorage.getItem('licensePlateSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Space = JSON.parse(localStorage.getItem('licensePlateSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedSpace => ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).some(space => space.SPACE_ID == selectedSpace.SPACE_ID)) || [];
                    } catch {
                        this.oList_Selected_Space = [];
                    }
                }
                if (localStorage.getItem('licensePlateSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Video_ai_asset = JSON.parse(localStorage.getItem('licensePlateSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedCamera => this.oList_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == selectedCamera.VIDEO_AI_ASSET_ID)) || [];
                    } catch {
                        this.oList_Selected_Video_ai_asset = [];
                    }
                }
                if (localStorage.getItem('licensePlateSearchSelectedCategory' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oSelected_Search_Category = JSON.parse(localStorage.getItem('licensePlateSearchSelectedCategory' + this.CmSvc.oUser_Details.USER_ID));
                    } catch {
                        this.oSelected_Search_Category = null;
                    }
                }
                if (localStorage.getItem('licensePlateSearchNumberSearch' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.licensePlateSearchNumberSearchInput.setValue(JSON.parse(localStorage.getItem('licensePlateSearchNumberSearch' + this.CmSvc.oUser_Details.USER_ID)));
                    } catch {
                        this.licensePlateSearchNumberSearchInput.setValue('');
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
        this.VideoAIService.licensePlateRecognitionBehaviorSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(fetchLicensePlateResponse => {
            if (fetchLicensePlateResponse) {
                this.dataSource.data = fetchLicensePlateResponse.List_Fetch_License_Plate_Recognition_Response_Content.map(licensePlate => {
                    licensePlate.Datetime = licensePlate.Datetime.split('.')[0].replace('T', ' ');
                    return licensePlate;
                });
                this.licensePlateDataCount = fetchLicensePlateResponse.TotalElements;
                this.isNoLicensePlates = false;
                if (this.licensePlateDataCount == 0) {
                    this.isNoLicensePlates = true;
                }
            } else {
                this.licensePlateDataCount = 0;
                this.oList_Licesne_Plate_Recognition_Data = [];
                this.isError = false;
                this.isNoLicensePlates = true;
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
        this.licensePlateSearchNumberSearchInput.valueChanges
            .pipe(
                takeUntil(this._unsubscribeAll),
                debounceTime(1000),
                distinctUntilChanged()
            )
            .subscribe(licensePlateNumber => {
                this.searchLicensePlateRecognition();
            });
        this.searchLicensePlateRecognition();
    }

    Sanitize(url: string): SafeResourceUrl {
        return this.CmSvc.Sanitize(url);
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('licensePlateSearchDataSet' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(true));
        localStorage.setItem('licensePlateSearchEndTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.endDate));
        localStorage.setItem('licensePlateSearchStartTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.startDate));
        localStorage.setItem('licensePlateSearchSelectedFloors' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Floor));
        localStorage.setItem('licensePlateSearchSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Space));
        localStorage.setItem('licensePlateSearchSelectedCameras' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Video_ai_asset));
        localStorage.setItem('licensePlateSearchSelectedCategory' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oSelected_Search_Category));
        localStorage.setItem('licensePlateSearchNumberSearch' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.licensePlateSearchNumberSearchInput.value));
        return true;
    }

    SceneClicked(licensePlateData: Fetch_License_Plate_Recognition_Response_Content) {
        const dialogRef = this.dialog.open(LicensePlateModalComponent, {
            minWidth: '648px',
            minHeight: '499.5px',
            data: {
                licensePlate: licensePlateData,
                camera: this.oList_Video_ai_asset.filter(camera => camera.VIDEO_AI_ASSET_ID_REF == licensePlateData.CameraId)[0],
            },
            autoFocus: false,
            panelClass: 'custom-modalbox'
        });
    }

    setPage(event: PageEvent) {
        this.pageIndex = event.pageIndex;
        this.searchLicensePlateRecognition();
    }

    searchLicensePlateRecognition() {
        if (this.oList_Selected_Video_ai_asset && this.oList_Selected_Video_ai_asset.length > 0) {
            this.isError = false;
            this.isSearching = true;
            this.isNoLicensePlates = false;
            this.VideoAIService.fetchLicensePlateRecognition(this.startDate, this.endDate, this.oList_Selected_Video_ai_asset, this.oSelected_Search_Category, this.pageSize * this.pageIndex, (this.pageIndex + 1) * this.pageSize, this.licensePlateSearchNumberSearchInput.value).then(() => {
                this.isSearching = false;
            });
        }
    }

    searchLicensePlateRecognitionOnEnter(event: KeyboardEvent) {
        if (event.key == 'Enter') {
            this.searchLicensePlateRecognition();
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

    Get_Autocomplete_List(): string[] {
        return [];
    }

    toggleCameraChoice(chosenCamera: Video_ai_asset): void {
        if (this.oList_Selected_Video_ai_asset.includes(chosenCamera)) {
            this.removeCameraChoice(chosenCamera);
        }
        else {
            this.addCameraChoice(chosenCamera);
        }
    }

    chooseVehicleType(chosenVehicleType): void {
        this.oSelected_Search_Category = chosenVehicleType.value;
        this.searchLicensePlateRecognition();
    }

    addCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.cameraSearchInput = '';
        this.oList_Selected_Video_ai_asset.unshift(chosenCamera);
        if (isSearchScene) {
            this.searchLicensePlateRecognition();
        }
    }

    removeCameraChoice(chosenCamera: Video_ai_asset, isSearchScene = true): void {
        this.oList_Selected_Video_ai_asset.splice(this.oList_Selected_Video_ai_asset.indexOf(chosenCamera), 1);
        if (isSearchScene) {
            this.searchLicensePlateRecognition();
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
                this.searchLicensePlateRecognition();
            });
        } else {
            i_Floor.List_Space.filter(space => !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
                this.addSpaceChoice(space, false);
            });
            this.searchLicensePlateRecognition();
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
            this.searchLicensePlateRecognition();
        }
    }

    addSpaceChoice(i_Space: Space, isSearchScene = true): void {
        this.spaceSearchInput = '';
        this.oList_Selected_Space.unshift(i_Space);
        this.oList_Video_ai_asset.filter(oCamera => !this.oList_Selected_Video_ai_asset.some(camera => camera.VIDEO_AI_ASSET_ID == oCamera.VIDEO_AI_ASSET_ID) && i_Space.List_Space_asset?.some(space_asset => space_asset.SPACE_ASSET_ID == oCamera.SPACE_ASSET_ID)).forEach(camera => {
            this.addCameraChoice(camera, isSearchScene);
        });
        if (isSearchScene) {
            this.searchLicensePlateRecognition();
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
            this.searchLicensePlateRecognition();
        }
        return wasCameraSelected;
    }

    clearChosenCamera(): void {
        this.oList_Selected_Video_ai_asset = [];
        this.searchLicensePlateRecognition();
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
