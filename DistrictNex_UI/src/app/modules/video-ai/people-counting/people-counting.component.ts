import { DatePipe } from '@angular/common';
import { ChangeDetectorRef, Component, HostListener, Input, OnDestroy, OnInit, QueryList, ViewChild, ViewChildren } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { CommonService } from 'app/core/Services/common.service';
import { Camera_Lines, Entity, Floor, Get_Countings_Response, Space } from 'app/core/Services/proxy.service';
import { MapService } from 'app/modules/map/map.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import { cloneDeep } from 'lodash';
import { BaseChartDirective } from 'ng2-charts';
import { ReplaySubject, Subject } from 'rxjs';
import { takeUntil } from 'rxjs/operators';
import { VideoAIService } from '../video-ai.service';

@Component({
    selector: 'people-counting',
    templateUrl: './people-counting.component.html',
    styleUrls: ['./people-counting.component.scss']
})
export class PeopleCountingComponent implements OnInit, OnDestroy {
    @Input() oEntity: Entity;

    isShowIn = true;
    isShowOut = true;
    isSearching = false;
    isTableView = false;
    isShowOccupency = false;

    endDate = new Date();
    maxDate = new Date();
    startDate = new Date();

    oMeasure = "Hourly";
    LineSearchInput = '';
    typeSearchInput = '';
    floorSearchInput = '';
    spaceSearchInput = '';
    oList_Selected_Floor: Floor[] = [];
    oList_Selected_Space: Space[] = [];
    oList_Camera_People_lines: Camera_Lines[] = [];
    oListMeasure = ["Hourly", "Daily", "Weekly", "Monthly"];
    oList_Original_People_Camera_lines: Camera_Lines[] = [];
    oList_Selected_Camera_People_lines: Camera_Lines[] = [];

    expandedElement: Get_Countings_Response | null;
    dataSource = new MatTableDataSource<Get_Countings_Response>();
    displayedColumns: string[] = ['time', 'ins', 'outs', 'occupancies'];

    @ViewChild(MatPaginator) paginator: MatPaginator;
    @ViewChild(MatSort, { static: true }) sort: MatSort;

    oPeople_Counting: Get_Countings_Response[];

    oBarChart: ChartConfiguration = {
        options: {
            plugins: {
                legend: {
                    display: true,
                },
                tooltip: {
                    mode: 'index',
                    intersect: false,
                    position: 'nearest'
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

    @ViewChildren(BaseChartDirective) oList_Chart: QueryList<BaseChartDirective>;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        private VideoAIService: VideoAIService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.VideoAIService.countingSubject = new ReplaySubject<Get_Countings_Response[]>(1);
        this.oList_Original_People_Camera_lines = cloneDeep(this.VideoAIService.cameraLines);
        if (this.oList_Original_People_Camera_lines) {
            this.oList_Original_People_Camera_lines.forEach(cameraLine => {
                cameraLine.LineSets = cameraLine.LineSets.filter(line => line.Type == "PeopleCounting");
            });
            const oList_Camera_People_lines = [].concat(...this.oList_Original_People_Camera_lines.map(cameraLine => cameraLine.LineSets));
            if (oList_Camera_People_lines) {
                oList_Camera_People_lines.forEach(peopleLine => {
                    const cameraLine = new Camera_Lines();
                    cameraLine.Camera = this.oList_Original_People_Camera_lines.filter(cameraLine => cameraLine.Camera.CameraId == peopleLine.CameraId)[0].Camera;
                    cameraLine.LineSets = [peopleLine];
                    this.oList_Camera_People_lines.push(cameraLine);
                });
            }
        }
        try {
            if (localStorage.getItem('peopleCountingDataSet' + this.CmSvc.oUser_Details.USER_ID)) {
                if (localStorage.getItem('peopleCountingStartTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.startDate = new Date(JSON.parse(localStorage.getItem('peopleCountingStartTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('peopleCountingEndTime' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.endDate = new Date(JSON.parse(localStorage.getItem('peopleCountingEndTime' + this.CmSvc.oUser_Details.USER_ID))) || new Date();
                }
                if (localStorage.getItem('peopleCountingSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Floor = JSON.parse(localStorage.getItem('peopleCountingSelectedFloors' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedFloor => this.oEntity.List_Floor.some(floor => floor.FLOOR_ID == selectedFloor.FLOOR_ID)) || [];
                    } catch {
                        this.oList_Selected_Floor = [];
                    }
                }
                if (localStorage.getItem('peopleCountingSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Space = JSON.parse(localStorage.getItem('peopleCountingSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedSpace => ([].concat(...this.oEntity.List_Floor.map(floor => floor.List_Space)) as Space[]).some(space => space.SPACE_ID == selectedSpace.SPACE_ID)) || [];
                    } catch {
                        this.oList_Selected_Space = [];
                    }
                }
                if (localStorage.getItem('peopleCountingSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)) {
                    try {
                        this.oList_Selected_Camera_People_lines = JSON.parse(localStorage.getItem('peopleCountingSelectedCameras' + this.CmSvc.oUser_Details.USER_ID)).filter(selectedLine => this.oList_Camera_People_lines.some(line => line.LineSets[0].LineSetId == selectedLine.LineSets[0].LineSetId)) || [];
                    } catch {
                        this.oList_Selected_Camera_People_lines = [];
                    }
                }
                if (localStorage.getItem('peopleCountingIsTable' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.isTableView = JSON.parse(localStorage.getItem('peopleCountingIsTable' + this.CmSvc.oUser_Details.USER_ID)) || false;
                }
                if (localStorage.getItem('peopleCountingPeriod' + this.CmSvc.oUser_Details.USER_ID)) {
                    this.oMeasure = JSON.parse(localStorage.getItem('peopleCountingPeriod' + this.CmSvc.oUser_Details.USER_ID)) || "Hourly";
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
        this.oBarChart.data.datasets.push({
            data: [],
            label: 'Inbound',
            borderColor: 'transparent',
        });
        this.oBarChart.data.datasets.push({
            data: [],
            label: 'Outbound',
            borderColor: 'transparent',
        });
        this.oBarChart.data.datasets.push({
            data: [],
            stack: 'in',
            label: 'Occupancy',
            borderColor: 'transparent',
        });

        this.VideoAIService.countingSubject.pipe(takeUntil(this._unsubscribeAll)).subscribe(GetCountingsResponse => {
            if (this.oList_Selected_Camera_People_lines.length > 0) {
                this.oPeople_Counting = GetCountingsResponse;
                this.dataSource.data = GetCountingsResponse;
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
        localStorage.setItem('peopleCountingDataSet' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(true));
        localStorage.setItem('peopleCountingStartTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.startDate));
        localStorage.setItem('peopleCountingEndTime' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.endDate));
        localStorage.setItem('peopleCountingSelectedFloors' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Floor));
        localStorage.setItem('peopleCountingSelectedSpaces' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Space));
        localStorage.setItem('peopleCountingSelectedCameras' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oList_Selected_Camera_People_lines));
        localStorage.setItem('peopleCountingIsTable' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.isTableView));
        localStorage.setItem('peopleCountingPeriod' + this.CmSvc.oUser_Details.USER_ID, JSON.stringify(this.oMeasure));
        return true;
    }

    updateChartData() {
        this.oBarChart.data.labels = [];
        this.oBarChart.data.datasets.forEach(dataset => {
            dataset.data = [];
        });
        if (this.oPeople_Counting) {
            this.oPeople_Counting.forEach(counting => {
                const numberOfHours = new Date(counting.DATETIME).getTime();
                const oListSerie = this.oBarChart.data.datasets;
                oListSerie[0].data.push(counting.OBJECTIN);
                oListSerie[1].data.push(counting.OBJECTOUT);
                oListSerie[2].data.push(counting.OCCUPANCY);
                let countingDatetime = this.DatePipe.transform(counting.DATETIME, 'short', this.TimezoneService.oCurrent_Timezone_Offset);
                if (!this.oBarChart.data.labels.some(label => label == countingDatetime)) {
                    this.oBarChart.data.labels.push(countingDatetime);
                }
            });
            this.oList_Chart.forEach(chart => {
                chart.update();
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
        if (this.oList_Selected_Camera_People_lines.length > 0) {
            this.VideoAIService.getCountingData(this.startDate, this.endDate, this.oMeasure, this.oList_Selected_Camera_People_lines.map(line => line.LineSets[0].LineSetId), ["person"]).then(() => {
                this.isSearching = false;
            });
        } else {
            this.isSearching = false;
            this.oPeople_Counting = [];
            this.dataSource.data = [];
            this._changeDetectorRef.detectChanges();
            this.dataSource.sort = this.sort;
            this.dataSource.paginator = this.paginator;
            this.updateChartData();
        }
    }

    filter_Lines() {
        return this.oList_Camera_People_lines.filter(oLine => !this.oList_Selected_Camera_People_lines.some(line => line.LineSets[0].LineSetId == oLine.LineSets[0].LineSetId) && (oLine.LineSets[0].Name.toLowerCase().includes(this.LineSearchInput.toLowerCase()) || oLine.Camera.Name.toLowerCase().includes(this.LineSearchInput.toLowerCase())));
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

    toggleLineChoice(chosenLine: Camera_Lines): void {
        if (this.oList_Selected_Camera_People_lines.includes(chosenLine)) {
            this.removeLineChoice(chosenLine);
        }
        else {
            this.addLineChoice(chosenLine);
        }
    }

    addLineChoice(chosenLine: Camera_Lines, isSearchScene = true): void {
        this.LineSearchInput = '';
        this.oList_Selected_Camera_People_lines.unshift(chosenLine);
        if (isSearchScene) {
            this.getCountings();
        }
    }

    removeLineChoice(chosenLine: Camera_Lines, isSearchScene = true): void {
        this.oList_Selected_Camera_People_lines.splice(this.oList_Selected_Camera_People_lines.indexOf(chosenLine), 1);
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
        this.oList_Camera_People_lines.filter(oLine => !this.oList_Selected_Camera_People_lines.some(line => line.LineSets[0].LineSetId == oLine.LineSets[0].LineSetId) && i_Space.List_Space_asset?.some(space_asset => space_asset.List_Video_ai_asset.some(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == oLine.Camera.CameraId))).forEach(line => {
            this.addLineChoice(line, isSearchScene);
        });
        if (isSearchScene) {
            this.getCountings();
        }
    }

    removeSpaceChoice(i_Space: Space, isSearchScene = true): boolean {
        this.oList_Selected_Space.splice(this.oList_Selected_Space.indexOf(i_Space), 1);
        let wasLineSelected = false;
        i_Space.List_Space_asset?.forEach(space_asset => {
            let oVideo_ai_asset = this.oList_Selected_Camera_People_lines.find(camera_line => space_asset.List_Video_ai_asset.some(video_ai_asset => video_ai_asset.VIDEO_AI_ASSET_ID_REF == camera_line.Camera.CameraId));
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

    clearChosenLine(): void {
        this.oList_Selected_Camera_People_lines = [];
        this.getCountings();
    }

    updateSeriesVisibile(type) {
        if (type == 'in') {
            (this.oBarChart.data.datasets[0] as any).hidden = !this.isShowIn;
        } else if (type == 'out') {
            (this.oBarChart.data.datasets[1] as any).hidden = !this.isShowOut;
        } else {
            (this.oBarChart.data.datasets[2] as any).hidden = !this.isShowOccupency;
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
