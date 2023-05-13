import { animate, state, style, transition, trigger } from '@angular/animations';
import { AfterViewInit, ChangeDetectorRef, Component, HostListener, Input, OnDestroy, OnInit, QueryList, ViewChild, ViewChildren } from '@angular/core';
import { MatCheckboxChange } from '@angular/material/checkbox';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Camera_Lines, Entity, Floor, Space, Vehicle_Counting, Vehicle_Counting_Table_Data } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import { cloneDeep } from 'lodash';
import { BaseChartDirective } from 'ng2-charts';
import { Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { VideoAIService } from '../video-ai.service';

@Component({
    selector: 'vehicle-counting',
    templateUrl: './vehicle-counting.component.html',
    styleUrls: ['./vehicle-counting.component.scss'],
    animations: [
        trigger('detailExpand', [
            state('collapsed', style({ height: '0px', minHeight: '0' })),
            state('expanded', style({ height: '*' })),
            transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
        ]),
    ],
})
export class VehicleCountingComponent implements OnInit, AfterViewInit, OnDestroy {
    @Input() oEntity: Entity;
    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort, { static: true }) sort: MatSort;
    @ViewChildren(BaseChartDirective) oList_Chart: QueryList<BaseChartDirective>;

    isShowIn = true;
    isShowOut = true;
    isTableView = false;
    isSearching = false;
    isShowOccupency = false;

    objectTypes = [
        'car in',
        'car out',
        'car occupancy',
        'bus in',
        'bus out',
        'bus occupancy',
        'truck in',
        'truck out',
        'truck occupancy',
        'motorbike in',
        'motorbike out',
        'motorbike occupancy',
        'bicycle in',
        'bicycle out',
        'bicycle occupancy',
    ];
    colors = [
        '#225774',
        '#507e9a',
        '#7ca7c1',

        '#aa0000',
        '#e08372',
        '#cd5c41',

        '#1a6209',
        '#3d772c',
        '#5b8d4a',

        '#452a62',
        '#60457a',
        '#7b6094',

        '#282828',
        '#676767',
        '#969696',
    ];
    endDate = new Date();
    maxDate = new Date();
    startDate = new Date();

    LineSearchInput = '';
    typeSearchInput = '';
    floorSearchInput = '';
    spaceSearchInput = '';
    oMeasure = "Hourly";
    oListMeasure = ["Hourly", "Daily", "Weekly", "Monthly"];
    oList_Type: string[] = [];
    oList_Selected_Type: string[] = [];
    oList_Selected_Floor: Floor[] = [];
    oList_Selected_Space: Space[] = [];
    oList_Camera_Vehicle_Lines: Camera_Lines[] = [];
    oList_Original_Vehicle_Camera_lines: Camera_Lines[] = [];
    oList_Selected_Camera_Vehicle_Lines: Camera_Lines[] = [];

    expandedElement: Vehicle_Counting_Table_Data | null;
    displayedColumns: string[] = ['time', 'ins', 'outs', 'occupancies'];
    dataSource = new MatTableDataSource<Vehicle_Counting_Table_Data>();

    checkboxDebouncer: {
        timeout: any;
        option: string;
    }[] = [];

    oBarChart: ChartConfiguration = {
        options: {
            plugins: {
                legend: {
                    display: true,
                },
                tooltip: {
                    mode: 'x',
                    intersect: false,
                    position: 'nearest',
                },
            },
            maintainAspectRatio: false,
            responsive: true,
            scales: {
                x: {
                    stacked: true,
                    ticks: {
                        autoSkip: true,
                        padding: 10,
                        display: true,
                    },
                    type: 'time',
                    time: {
                        unit: 'hour',
                        displayFormats: {
                            hour: 'DD MMM h:mm a'
                        }
                    }
                },
                y: {
                    stacked: true
                }
            }
        },
        type: 'bar',
        data: {
            datasets: [],
            labels: [],
        },
    };

    numberOfRequests = [];

    oVehicle_Counting: Vehicle_Counting;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.oList_Original_Vehicle_Camera_lines = cloneDeep(this.VideoAIService.cameraLines);
        this.oList_Type = this.VideoAIService.vehicleTypes;
        if (this.oList_Original_Vehicle_Camera_lines) {
            this.oList_Original_Vehicle_Camera_lines.forEach(cameraLine => {
                cameraLine.LineSets = cameraLine.LineSets.filter(line => line.Type == "VehicleCounting");
            });
            const oList_Vehicle_lines = [].concat(...this.oList_Original_Vehicle_Camera_lines.map(cameraLine => cameraLine.LineSets));
            if (oList_Vehicle_lines) {
                oList_Vehicle_lines.forEach(vehicleLine => {
                    const cameraLine = new Camera_Lines();
                    cameraLine.Camera = this.oList_Original_Vehicle_Camera_lines.filter(cameraLine => cameraLine.Camera.CameraId == vehicleLine.CameraId)[0].Camera;
                    cameraLine.LineSets = [vehicleLine];
                    this.oList_Camera_Vehicle_Lines.push(cameraLine);
                });
            }
        }
        try {
            if (localStorage.getItem('vehicleCountingDataSet' + this.CmSvc.oUser_Details.USER_ID)) {
                let vehicleCountingStartTime = localStorage.getItem('vehicleCountingStartTime' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingEndTime = localStorage.getItem('vehicleCountingEndTime' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingSelectedFloors = localStorage.getItem('vehicleCountingSelectedFloors' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingSelectedSpaces = localStorage.getItem('vehicleCountingSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingSelectedCameras = localStorage.getItem('vehicleCountingSelectedCameras' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingSelectedCategories = localStorage.getItem('vehicleCountingSelectedCategories' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingIsTable = localStorage.getItem('vehicleCountingIsTable' + this.CmSvc.oUser_Details.USER_ID);
                let vehicleCountingPeriod = localStorage.getItem('vehicleCountingPeriod' + this.CmSvc.oUser_Details.USER_ID);
                if (this.CmSvc.CheckString(vehicleCountingStartTime)) {
                    this.startDate = new Date(JSON.parse(vehicleCountingStartTime)) || new Date();
                }
                if (this.CmSvc.CheckString(vehicleCountingEndTime)) {
                    this.endDate = new Date(JSON.parse(vehicleCountingEndTime)) || new Date();
                }
                if (this.CmSvc.CheckString(vehicleCountingSelectedFloors)) {
                    try {
                        this.oList_Selected_Floor = JSON.parse(vehicleCountingSelectedFloors).filter(selectedFloor => this.oEntity.List_Floor.some(floor => floor.FLOOR_ID == selectedFloor.FLOOR_ID)) || [];
                    } catch {
                        this.oList_Selected_Floor = [];
                    }
                }
                if (this.CmSvc.CheckString(vehicleCountingSelectedSpaces)) {
                    try {
                        this.oList_Selected_Space = JSON.parse(vehicleCountingSelectedSpaces).filter(selectedSpace => ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).some(space => space.SPACE_ID == selectedSpace.SPACE_ID)) || [];
                    } catch {
                        this.oList_Selected_Space = [];
                    }
                }
                if (this.CmSvc.CheckString(vehicleCountingSelectedCameras)) {
                    try {
                        this.oList_Selected_Camera_Vehicle_Lines = JSON.parse(vehicleCountingSelectedCameras).filter(selectedLine => this.oList_Camera_Vehicle_Lines.some(line => line.LineSets[0].LineSetId == selectedLine.LineSets[0].LineSetId)) || [];
                    } catch {
                        this.oList_Selected_Camera_Vehicle_Lines = [];
                    }
                }
                if (this.CmSvc.CheckString(vehicleCountingSelectedCategories)) {
                    try {
                        this.oList_Selected_Type = JSON.parse(vehicleCountingSelectedCategories).filter(selectedCategory => this.oList_Type.some(type => type == selectedCategory)) || [];
                    } catch {
                        this.oList_Selected_Type = [];
                    }
                }
                if (vehicleCountingIsTable) {
                    this.isTableView = JSON.parse(vehicleCountingIsTable) || false;
                }
                if (vehicleCountingPeriod) {
                    this.oMeasure = JSON.parse(vehicleCountingPeriod) || "Hourly";
                    if (!this.oListMeasure.includes(this.oMeasure)) {
                        this.oMeasure = "Hourly"
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
        if (this.oEntity) {
            if (this.oEntity.List_Floor.some(floor => floor.List_Space.some(space => !space.List_Space_asset))) {
                this.numberOfRequests.push(true);
                this.MapService.Get_Space_asset_By_SPACE_ID_List_Adv([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space))).then(() => {
                    this.numberOfRequests.splice(0, 1);
                });
            }
            this.floorSearchInput = '';
        }
        this.getCountings();
    }

    ngAfterViewInit(): void {
        let i = 0;
        this.oBarChart.data.datasets = [];
        this.objectTypes.forEach(objectType => {
            const color = this.colors[i++];
            if (objectType.includes('in')) {
                this.oBarChart.data.datasets.push({
                    data: [],
                    stack: 'in',
                    backgroundColor: color,
                    label: objectType,
                    borderColor: 'transparent',
                });
            } else if (objectType.includes('out')) {
                this.oBarChart.data.datasets.push({
                    data: [],
                    stack: 'out',
                    backgroundColor: color,
                    label: objectType,
                    borderColor: 'transparent',
                });
            } else {
                this.oBarChart.data.datasets.push({
                    data: [],
                    label: objectType,
                    borderColor: color,
                    pointBackgroundColor: color,
                    pointHoverBorderColor: color + '80',
                    pointHoverRadius: 4,
                    pointHoverBorderWidth: 6,
                    type: 'line',
                    stack: 'occupancy',
                });
            }
        });

        this.updateChartData();

        this.VideoAIService.vehicleCountingSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(GetCountingsResponse => {
            if (this.oList_Selected_Type.length > 0 && this.oList_Selected_Camera_Vehicle_Lines.length > 0) {
                this.oVehicle_Counting = GetCountingsResponse;
                this.dataSource.data = this.oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST;
                this._changeDetectorRef.detectChanges();
                this.dataSource.sort = this.sort;
                this.dataSource.paginator = this.paginator;
                this.updateChartData();
            }
        });

        this.updateSeriesVisibile('in');
        this.updateSeriesVisibile('out');
        this.updateSeriesVisibile('occupancy');
    }

    @HostListener('window:beforeunload')
    saveConfig() {
        localStorage.setItem('vehicleCountingDataSet' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(true));
        localStorage.setItem('vehicleCountingStartTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.startDate));
        localStorage.setItem('vehicleCountingEndTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.endDate));
        localStorage.setItem('vehicleCountingSelectedFloors' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Floor));
        localStorage.setItem('vehicleCountingSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Space));
        localStorage.setItem('vehicleCountingSelectedCameras' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Camera_Vehicle_Lines));
        localStorage.setItem('vehicleCountingSelectedCategories' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Type));
        localStorage.setItem('vehicleCountingIsTable' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.isTableView));
        localStorage.setItem('vehicleCountingPeriod' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oMeasure));
        return true;
    }

    updateChartData() {
        this.oBarChart.data.labels = [];
        this.oBarChart.data.datasets.forEach(dataset => {
            dataset.data = [];
        });
        if (this.oVehicle_Counting) {
            this.oVehicle_Counting.GET_COUNTINGS_RESPONSE_LIST.forEach(counting => {
                const oListSerie = this.oBarChart.data.datasets.filter(dataset => dataset.label.includes(counting.TYPE));
                oListSerie.find(serie => (serie as any).stack.includes('in')).data.push({
                    x: new Date(counting.DATETIME),
                    y: counting.OBJECTIN
                } as any);
                oListSerie.find(serie => (serie as any).stack.includes('out')).data.push({
                    x: new Date(counting.DATETIME),
                    y: counting.OBJECTOUT
                } as any);
                oListSerie.find(serie => (serie as any).stack.includes('occupancy')).data.push({
                    x: new Date(counting.DATETIME),
                    y: counting.OCCUPANCY
                } as any);
            });
            this.oList_Chart.forEach(chart => {
                chart.update();
                chart.render();
            });
        }
    }

    updateTable() {
        this._changeDetectorRef.detectChanges();
        this.dataSource.sort = this.sort;
        this.dataSource.paginator = this.paginator;
    }

    getCountings() {
        this.isSearching = true;
        if (this.oList_Selected_Type.length > 0 && this.oList_Selected_Camera_Vehicle_Lines.length > 0) {
            this.VideoAIService.getVehicleCounting(this.startDate, this.endDate, this.oMeasure, this.oList_Selected_Camera_Vehicle_Lines.map(line => line.LineSets[0].LineSetId), this.oList_Selected_Type).then(() => {
                this.isSearching = false;
            });;
        } else {
            this.isSearching = false;
            this.oVehicle_Counting = {
                GET_COUNTINGS_RESPONSE_LIST: [],
                VEHICLE_COUNTING_TABLE_DATA_LIST: [],
            };
            this.dataSource.data = this.oVehicle_Counting.VEHICLE_COUNTING_TABLE_DATA_LIST;
            this._changeDetectorRef.detectChanges();
            this.dataSource.sort = this.sort;
            this.dataSource.paginator = this.paginator;
            this.updateChartData();
        }
    }

    filter_Types() {
        return this.oList_Type.filter(oType => !this.oList_Selected_Type.some(type => type == oType) && oType.toLowerCase().includes(this.typeSearchInput.toLowerCase()));
    }

    filter_Lines() {
        return this.oList_Camera_Vehicle_Lines.filter(oLine => !this.oList_Selected_Camera_Vehicle_Lines.some(line => line.LineSets[0].LineSetId == oLine.LineSets[0].LineSetId) && (oLine.LineSets[0].Name.toLowerCase().includes(this.LineSearchInput.toLowerCase()) || oLine.Camera.Name.toLowerCase().includes(this.LineSearchInput.toLowerCase())));
    }

    filter_Floors() {
        return this.oEntity.List_Floor.filter(floor => floor.List_Space.some(space => space.HAS_VIDEO_AI_ASSETS) && !this.oList_Selected_Floor.some(oFloor => oFloor.FLOOR_ID == floor.FLOOR_ID) && floor.NAME.toLowerCase().includes(this.floorSearchInput.toLowerCase()));
    }

    filter_Spaces() {
        return ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).filter(space => space.HAS_VIDEO_AI_ASSETS && !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID) && space.NAME.toLowerCase().includes(this.spaceSearchInput.toLowerCase()));
    }

    Get_Autocomplete_List(): string[] {
        return [];
    }

    toggleObjectTypeChoice(matCheckboxChange: MatCheckboxChange, chosenObjectType: string): void {
        const index = this.checkboxDebouncer.findIndex(checkboxDebouncer => checkboxDebouncer.option == chosenObjectType);
        if (index == -1) {
            this.checkboxDebouncer.push({
                option: chosenObjectType,
                timeout: setTimeout(() => {
                    if (this.oList_Selected_Type.includes(chosenObjectType) && !matCheckboxChange.checked) {
                        this.removeObjectTypeChoice(chosenObjectType);
                    } else if (!this.oList_Selected_Type.includes(chosenObjectType)) {
                        this.addObjectTypeChoice(chosenObjectType);
                    }
                }, 300),
            });
        } else {
            clearTimeout(this.checkboxDebouncer[index].timeout);
            this.checkboxDebouncer[index].timeout = setTimeout(() => {
                if (this.oList_Selected_Type.includes(chosenObjectType) && !matCheckboxChange.checked) {
                    this.removeObjectTypeChoice(chosenObjectType);
                } else if (!this.oList_Selected_Type.includes(chosenObjectType)) {
                    this.addObjectTypeChoice(chosenObjectType);
                }
            }, 300);
        }
    }

    toggleLineChoice(chosenLine: Camera_Lines): void {
        if (this.oList_Selected_Camera_Vehicle_Lines.includes(chosenLine)) {
            this.removeLineChoice(chosenLine);
        }
        else {
            this.addLineChoice(chosenLine);
        }
    }

    addObjectTypeChoice(chosenObjectType: string): void {
        this.oList_Selected_Type.unshift(chosenObjectType);
        this.getCountings();
        this.typeSearchInput = '';
    }

    removeObjectTypeChoice(chosenObjectType: string): void {
        this.oList_Selected_Type.splice(this.oList_Selected_Type.indexOf(chosenObjectType), 1);
        this.getCountings();
    }

    isObjectTypeChecked(option: string) {
        return this.oList_Selected_Type.includes(option)
    }

    addLineChoice(chosenLine: Camera_Lines, isSearchScene = true): void {
        this.LineSearchInput = '';
        this.oList_Selected_Camera_Vehicle_Lines.unshift(chosenLine);
        if (isSearchScene) {
            this.getCountings();
        }
    }

    removeLineChoice(chosenLine: Camera_Lines, isSearchScene = true): void {
        this.oList_Selected_Camera_Vehicle_Lines.splice(this.oList_Selected_Camera_Vehicle_Lines.indexOf(chosenLine), 1);
        if (isSearchScene) {
            this.getCountings();
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
                this.getCountings();
            });
        } else {
            i_Floor.List_Space.filter(space => !this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
                this.addSpaceChoice(space, false);
            });
            this.getCountings();
        }
    }

    removeFloorChoice(i_Floor: Floor): void {
        this.oList_Selected_Floor.splice(this.oList_Selected_Floor.indexOf(i_Floor), 1);
        let wasLineSelected = false;
        i_Floor.List_Space.filter(space => this.oList_Selected_Space.some(oSpace => oSpace.SPACE_ID == space.SPACE_ID)).forEach(space => {
            const result = this.removeSpaceChoice(space, false);
            if (result) {
                wasLineSelected = true;
            }
        });
        if (wasLineSelected) {
            this.getCountings();
        }
    }

    addSpaceChoice(i_Space: Space, isSearchScene = true): void {
        this.spaceSearchInput = '';
        this.oList_Selected_Space.unshift(i_Space);
        this.oList_Camera_Vehicle_Lines.filter(oLine => !this.oList_Selected_Camera_Vehicle_Lines.some(line => line.LineSets[0].LineSetId == oLine.LineSets[0].LineSetId) && i_Space.List_Space_asset?.some(space_asset => space_asset.List_Video_ai_asset.some(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == oLine.Camera.CameraId))).forEach(camera => {
            this.addLineChoice(camera, isSearchScene);
        });
        if (isSearchScene) {
            this.getCountings();
        }
    }

    removeSpaceChoice(i_Space: Space, isSearchScene = true): boolean {
        this.oList_Selected_Space.splice(this.oList_Selected_Space.indexOf(i_Space), 1);
        let wasLineSelected = false;
        i_Space.List_Space_asset?.forEach(space_asset => {
            let oVideo_ai_asset = this.oList_Selected_Camera_Vehicle_Lines.find(camera_line => space_asset.List_Video_ai_asset.some(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == camera_line.Camera.CameraId));
            if (oVideo_ai_asset) {
                this.removeLineChoice(oVideo_ai_asset, false);
                wasLineSelected = true;
            }
        });
        if (isSearchScene) {
            this.getCountings();
        }
        return wasLineSelected;
    }

    clearObjectFilter(): void {
        this.oList_Selected_Type = [];
        this.getCountings();
    }

    clearChosenLine(): void {
        this.oList_Selected_Camera_Vehicle_Lines = [];
        this.getCountings();
    }

    updateSeriesVisibile(type) {
        if (type == 'in') {
            this.oBarChart.data.datasets.filter(dataset => dataset.label.includes('in')).forEach(dataset => {
                (dataset as any).hidden = !this.isShowIn;
            })
        } else if (type == 'out') {
            this.oBarChart.data.datasets.filter(dataset => dataset.label.includes('out')).forEach(dataset => {
                (dataset as any).hidden = !this.isShowOut;
            })
        } else {
            this.oBarChart.data.datasets.filter(dataset => dataset.label.includes('occupancy')).forEach(dataset => {
                (dataset as any).hidden = !this.isShowOccupency;
            })
        }
        this.oList_Chart.forEach(chart => {
            chart.update();
        });
    }

    ngOnDestroy() {
        this.saveConfig();
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
