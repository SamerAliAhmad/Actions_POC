import { animate, style, transition, trigger } from '@angular/animations';
import { DatePipe } from '@angular/common';
import { AfterViewInit, ChangeDetectorRef, Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, SimpleChanges } from '@angular/core';
import { Enum_Map_view, Enum_Up_Down } from 'app/core/Models/constants';
import { Dimension_data } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, District, Entity, Enum_Dimension_Status, Params_Get_Dimension_Index_With_Simple_Upper_Level, Params_Get_Dimension_index_By_Where, Site, Top_level } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { BdcWalkService } from 'bdc-walkthrough';
import { ChartConfiguration } from 'chart.js';
import { Subject, takeUntil } from 'rxjs';
import { MapService } from '../map.service';
import { Dimension_chart_configuration, Dimension_index } from './../../../core/Services/proxy.service';

@Component({
    selector: 'bottom-bar',
    templateUrl: './bottom-bar.component.html',
    styleUrls: ['./bottom-bar.component.scss'],
    animations: [
        trigger('slideInOut', [
            transition(':enter', [
                style({ transform: 'translateX(100%)' }),
                animate('400ms ease-in', style({ transform: 'translateX(0%)' }))
            ])
        ]),
        trigger('slideInOutMobilityButton', [
            transition(':enter', [
                style({ transform: 'translateY(129%)' }),
                animate('200ms ease-in', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('200ms ease-in', style({ transform: 'translateY(129%)' }))
            ])
        ]),
        trigger('slideInOutEntitiesButton', [
            transition(':enter', [
                style({ transform: 'translateY(258%)' }),
                animate('200ms ease-in', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('200ms ease-in', style({ transform: 'translateY(258%)' }))
            ])
        ]),
        trigger('slideInOutBorderButton', [
            transition(':enter', [
                style({ transform: 'translateY(387%)' }),
                animate('200ms ease-in', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('200ms ease-in', style({ transform: 'translateY(387%)' }))
            ])
        ]),
        trigger('slideInOutPublicEventsButton', [
            transition(':enter', [
                style({ transform: 'translateY(516%)' }),
                animate('200ms ease-in', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('200ms ease-in', style({ transform: 'translateY(516%)' }))
            ])
        ]),
        trigger('slideInOutBylawComplaintsButton', [
            transition(':enter', [
                style({ transform: 'translateY(645%)' }),
                animate('200ms ease-in', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('200ms ease-in', style({ transform: 'translateY(645%)' }))
            ])
        ]),
        trigger('slideInOutBusinessesButton', [
            transition(':enter', [
                style({ transform: 'translateY(774%)' }),
                animate('200ms ease-in', style({ transform: 'translateY(0%)' }))
            ]),
            transition(':leave', [
                animate('200ms ease-in', style({ transform: 'translateY(774%)' }))
            ])
        ]),
    ]
})
export class BottomBarComponent implements OnInit, OnChanges, AfterViewInit, OnDestroy {

    @Input() view_type: string;
    @Input() oSelected_Site: Site;
    @Input() oSelected_Area: Area;
    @Input() oTop_level: Top_level;
    @Input() drawerWidth: number = 0;
    @Input() oSelected_Location: any;
    @Input() oSelected_Entity: Entity;
    @Input() oSelected_District: District;

    @Input() isShowHeatmap = false;
    @Input() isShowMobility = false;
    @Input() isShow3dEntities = true;
    @Input() isButtonsVisible = true;
    @Input() isTransitioning = false;
    @Input() isShowBusinesses = false;
    @Input() isShowToggleButtons = true;
    @Input() isHideViewSelector = false;
    @Input() isShowPublicEvents = false;
    @Input() isShowBylawComplaints = false;
    @Input() isSwitchStyleDisabled = false;
    @Input() isShowCorrelationHeatmap = false;

    @Output() openDialogEventEmitter = new EventEmitter();
    @Output() editRemovedExtrusionsEventEmitter = new EventEmitter<void>();

    isPinned = false;
    isShowLevels = false;
    isReflowChart = false;
    isShowButtons = false;
    isRedrawSeries = false;
    isContentLoaded = false;
    isValidViewType = false;
    isShowChoicePanel = false;
    isUpperLevelLoaded = false;
    isBarHeightChangeDetected = false;
    isEditRemovedExtrusionsOn = false;
    isToggleViewUpButtonDisabled = false;
    isToggleViewDownButtonDisabled = false

    Upper_Level_Name = '';
    Current_View_Type: string;
    Upper_Level_Location = '';
    Upper_Level_Logo_URL = '';
    Upper_Level_Image_URL = '';
    oData_level_Setup_ID: number;
    oEnum_Map_view: Enum_Map_view;
    Enum_Map_view = Enum_Map_view;
    Enum_Up_Down = Enum_Up_Down;
    Enum_Dimension_Status = Enum_Dimension_Status;

    upper_level_id: number;
    upper_level_setup_id: number;

    isSiteAccessible: boolean;
    isAreaAccessible: boolean;
    isEntityAccessible: boolean;
    isDistrictAccessible: boolean;
    isTopLevelAccessible: boolean;

    oList_Site: Site[];
    oList_Area: Area[];
    oList_Entity: Entity[];
    oList_Top_level: Top_level[];
    oList_Site_to_show: Site[] = [];
    oList_District: District[] = [];
    oList_Area_to_show: Area[] = [];
    oList_Current_Level_Location = [];
    oList_Entity_to_show: Entity[] = [];
    oList_Dimension_data: Dimension_data[];
    oList_District_to_show: District[] = [];
    chartConfigurations: Dimension_chart_configuration[];
    oList_Dimension_chart_configuration: Dimension_chart_configuration[];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        private BdcWalkService: BdcWalkService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.isEditRemovedExtrusionsOn = this.CmSvc.isEditRemovedExtrusionsOn;
        this.isSiteAccessible = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.length > 0;
        this.isAreaAccessible = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.length > 0;
        this.isEntityAccessible = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.length > 0;
        this.isDistrictAccessible = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.length > 0;
        this.isTopLevelAccessible = (this.CmSvc.oUser_Accessible_Level_List.LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL.length > 1);
        this.Upper_Level_Name = this.CmSvc.oUser_Accessible_Level_List.UPPER_LEVEL.NAME;
        this.Upper_Level_Location = this.CmSvc.oUser_Accessible_Level_List.UPPER_LEVEL.LOCATION;
        this.Upper_Level_Logo_URL = this.CmSvc.oUser_Accessible_Level_List.UPPER_LEVEL.LOGO_URL;
        this.Upper_Level_Image_URL = this.CmSvc.oUser_Accessible_Level_List.UPPER_LEVEL.IMAGE_URL;
        this.isUpperLevelLoaded = true;

        let setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Bottom Bar");
        this.oList_Dimension_chart_configuration = this.CmSvc.oList_Dimension_chart_configuration.filter(oDimension_chart_configuration => oDimension_chart_configuration.POSITION_SETUP_ID == setup_id);
    }

    ngOnInit(): void {
        switch (this.view_type.toUpperCase()) {
            case 'DISTRICT':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_District;
                break;
            case 'SITE':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Site;
                break;
            case 'AREA':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Area;
                break;
        }
        this.updateData();
        let pinStatus = localStorage.getItem('pinStatus');
        if (this.CmSvc.CheckString(pinStatus)) {
            this.isPinned = JSON.parse(pinStatus);
        }
        this.MapService.oData_From_Filter_Loaded_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(status => {
            this.isContentLoaded = status;
        })
        this.MapService.oChange_Map_View_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(oEnum_Map_View => {
            this.updateData();
        })
        this.MapService.oLocation_Changed_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            this.updateData();
            this._changeDetectorRef.detectChanges();
        })
        this.MapService.oApply_Filter_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            let oParams_Get_Dimension_index_By_Where = new Params_Get_Dimension_index_By_Where();
            oParams_Get_Dimension_index_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
            oParams_Get_Dimension_index_By_Where.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
            oParams_Get_Dimension_index_By_Where.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
            oParams_Get_Dimension_index_By_Where.LIST_LEVEL_ID = [this.upper_level_id];
            oParams_Get_Dimension_index_By_Where.LEVEL_SETUP_ID = this.upper_level_setup_id;
            oParams_Get_Dimension_index_By_Where.LIST_DIMENSION_ID = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_dimension_with_status => oLevel_dimension_with_status.DATA_LEVEL_SETUP_ID == this.upper_level_setup_id && oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_dimension_with_status.LEVEL_ID_LIST.includes(this.upper_level_id)).map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
            this.MapService.Get_Dimension_index_By_Where(oParams_Get_Dimension_index_By_Where).then(result => {
                if (result) {
                    this.CmSvc.oList_Dimension_Index = result;
                    this.updateData();
                }
            })
        });
    }

    ngOnChanges(changes: SimpleChanges): void {

        this._changeDetectorRef.detectChanges();
    }

    ngAfterViewInit(): void {
        const container = document.getElementById('bar');

        let resizeObserver = new ResizeObserver(() => {
            if (!this.isBarHeightChangeDetected && container.offsetHeight > 100) {
                this.isBarHeightChangeDetected = true;
            } else {
                this.isBarHeightChangeDetected = false;
            }
            this._changeDetectorRef.detectChanges();
        });
        resizeObserver.observe(container);
    }

    updateValues() {
        switch (this.view_type.toLowerCase()) {
            case "district":
                this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District");
                this.oEnum_Map_view = Enum_Map_view.district;
                break;
            case "area":
                this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area");
                this.oEnum_Map_view = Enum_Map_view.area;
                break;
            case "site":
                this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
                this.oEnum_Map_view = Enum_Map_view.site;
                break;
            case "entity":
                this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity");
                this.oEnum_Map_view = Enum_Map_view.entity;
                break;
        }
        this.isValidViewType = (Object.values(Enum_Map_view).includes(this.view_type as unknown as Enum_Map_view));
        this.Current_View_Type = this.CmSvc.ToTitleCase(this.view_type);
        let upper_level_value = Enum_Map_view[this.oEnum_Map_view + 1];
        if (this.oEnum_Map_view == Enum_Map_view.district) {
            upper_level_value = Enum_Map_view[this.oEnum_Map_view];
        }
        this.upper_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", upper_level_value);
        this.upper_level_id = this[`oSelected_${this.CmSvc.ToTitleCase(this.view_type)}`][`${upper_level_value.toUpperCase()}_ID`];
        this.Upper_Level_Name = this.MapService.oUpper_Level.NAME;
        this.Upper_Level_Location = this.MapService.oUpper_Level.LOCATION;
        this.Upper_Level_Logo_URL = this.MapService.oUpper_Level.LOGO_URL;
        this.Upper_Level_Image_URL = this.MapService.oUpper_Level.IMAGE_URL;
    }

    updateData() {
        this.updateValues();
        this.oList_Dimension_data = [];
        let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(level_dimension_with_status => level_dimension_with_status.DATA_LEVEL_SETUP_ID == this.upper_level_setup_id && level_dimension_with_status.LEVEL_ID_LIST.includes(this.upper_level_id));
        oList_Level_Dimension_With_Status.forEach(level_dimension_with_status => {
            const oDimension_With_Status = level_dimension_with_status;
            const oDimension_chart_configuration = this.oList_Dimension_chart_configuration.find(_dimension_chart_configuration => _dimension_chart_configuration.CHART_ORDER == level_dimension_with_status.DIMENSION.DIMENSION_ORDER);
            let oChart_settings = (JSON.parse(oDimension_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration);
            oChart_settings.data.datasets = [];
            const oDimension_data: Dimension_data = {
                CssClass: '',
                LEVEL_DIMENSION_WITH_STATUS: oDimension_With_Status,
                Enum_Dimension_Status: level_dimension_with_status.ENUM_DIMENSION_STATUS,
                INDEX_VALUE: 0,
                oList_Serie: [],
                DISPLAY_ICON: 3,
                INDEX_COLOR: 'text-gray-500',
                ChartConfiguration: oChart_settings,
                DIMENSION_ICON: oDimension_With_Status.DIMENSION.DIMENSION_ICON
            };
            if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.ENABLED) {
                oDimension_data.CssClass = "cursor-pointer";
            }
            else if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.DISABLED) {
                oChart_settings.options['plugins']['tooltip'] = null;
                oDimension_data.CssClass = "opacity-50";
            } else {
                oDimension_data.CssClass = "";
            }
            let chartData: Dimension_index[] = this.CmSvc.oList_Dimension_Index.sort((a, b) => {
                if (a.RECORD_DATE > b.RECORD_DATE) {
                    return 1;
                }
                if (a.RECORD_DATE < b.RECORD_DATE) {
                    return -1;
                }
                return 0;
            });
            chartData = chartData.filter(_Dimension_index => _Dimension_index.DIMENSION_METADATA.LEVEL_ID == this.upper_level_id && _Dimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID);
            if (chartData.length > 0) {
                oDimension_data.INDEX_VALUE = Math.round(chartData[chartData.length - 1].VALUE);
            }
            if (oDimension_data.Enum_Dimension_Status == Enum_Dimension_Status.HIDDEN) {
                chartData = chartData.slice(0, 1);
                oDimension_data.ChartConfiguration.options.scales.y.grid = { color: '#6B7280' }
            }
            let low_threshhold = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.LOW_THRESHOLD;
            let high_threshhold = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.HIGH_THRESHOLD;
            if (oDimension_data.Enum_Dimension_Status != Enum_Dimension_Status.HIDDEN && chartData.length >= 2) {
                if (chartData[chartData.length - 1].VALUE > chartData[chartData.length - 2].VALUE) {
                    oDimension_data.DISPLAY_ICON = 1;
                    oDimension_data.INDEX_COLOR = 'text-highIndexColor';
                } else if (chartData[chartData.length - 1].VALUE < chartData[chartData.length - 2].VALUE) {
                    oDimension_data.DISPLAY_ICON = 2;
                    oDimension_data.INDEX_COLOR = 'text-lowIndexColor';

                } else {
                    oDimension_data.DISPLAY_ICON = 3;
                    oDimension_data.INDEX_COLOR = 'text-gray-500';
                }
            } else {
                oDimension_data.DISPLAY_ICON = 3;
                oDimension_data.INDEX_COLOR = oDimension_data.INDEX_VALUE > high_threshhold ? 'text-highIndexColor' : oDimension_data.INDEX_VALUE > low_threshhold ? 'text-yellow-400' : 'text-lowIndexColor';
            }
            let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == this.oData_level_Setup_ID).COLOR;
            if (!color) {
                color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == this.oData_level_Setup_ID).COLOR;
            }
            const oSeriesSettings = (JSON.parse(oDimension_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, this.Upper_Level_Name)) as ChartConfiguration['data']['datasets'][0]);
            oSeriesSettings.data = chartData.map(datum => datum.VALUE);
            oDimension_data.ChartConfiguration.data.datasets.push(oSeriesSettings);
            oDimension_data.ChartConfiguration.data.labels = chartData.map(datum => this.DatePipe.transform(datum.RECORD_DATE, null, this.TimezoneService.oCurrent_Timezone_Offset));

            this.oList_Dimension_data.push(oDimension_data);
        });
        this.oList_Dimension_data = this.oList_Dimension_data.sort((a, b) => a.Enum_Dimension_Status - b.Enum_Dimension_Status);

        this.Toggle_View_Buttons_Status();

        this.isContentLoaded = true;
    }

    redrawSeries() {
        this.isRedrawSeries = true;
        this._changeDetectorRef.detectChanges();
        this.isRedrawSeries = false;
    }

    showSmallBar() {
        const result = document.getElementById('bar').offsetHeight > 100;
        if (!result) {
            this.isShowLevels = false;
            if (this.isShowChoicePanel) {
                this.isShowChoicePanel = false;
                this._changeDetectorRef.detectChanges();
            }
        }
        return result;
    }


    reflowCharts() {
        this.isReflowChart = true;
        this._changeDetectorRef.detectChanges();
        this.isReflowChart = false;
    }

    changeMapView(i_Enum_Map_view: Enum_Map_view) {
        if (Enum_Map_view[i_Enum_Map_view] != this.view_type) {
            this.isContentLoaded = false;
            this.isShowChoicePanel = false;
            this.isShowLevels = false;
            let selected_data_level = Enum_Map_view[i_Enum_Map_view];
            this.openDialogEventEmitter.emit();
            let selected_data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", selected_data_level);
            let upper_level;
            if (i_Enum_Map_view == Enum_Map_view.district) {
                upper_level = Enum_Map_view[i_Enum_Map_view]
            }
            else {
                upper_level = Enum_Map_view[i_Enum_Map_view + 1]
            }
            this.upper_level_id = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL[`${selected_data_level.toUpperCase()}_LIST`][0][`${upper_level.toUpperCase()}_ID`];
            let top_level_id = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.TOP_LEVEL.TOP_LEVEL_ID;
            let list_selected_level_id: number[];

            if (selected_data_level.toLowerCase() != "entity") {
                list_selected_level_id = this.CmSvc.oUser_Accessible_Level_List.LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL.find(accessible_id_list => accessible_id_list.TOP_LEVEL_ID == top_level_id)[`${selected_data_level.toUpperCase()}_ID_LIST`];
            }
            else {
                list_selected_level_id = this.CmSvc.oUser_Accessible_Level_List.LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL.find(accessible_id_list => accessible_id_list.TOP_LEVEL_ID == top_level_id).SITE_ID_LIST;
                let list_site_id_for_entity = this.CmSvc.oList_Accessible_Entity.map(oEntity => oEntity.SITE_ID);
                list_selected_level_id = [...new Set([...list_site_id_for_entity, ...list_selected_level_id])];
            }
            let list_dimension_id = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(dimension => dimension.DATA_LEVEL_SETUP_ID == selected_data_level_setup_id && dimension.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN).map(dimension_with_status => dimension_with_status.DIMENSION.DIMENSION_ID);
            this.MapService.Get_Level_Data(this.upper_level_id, selected_data_level_setup_id, list_selected_level_id, list_dimension_id).then(result => {
                if (result) {
                    this.isUpperLevelLoaded = true;
                    this.CmSvc.GeoJSON_Source = result.GEOJSON_SRC;
                    this.CmSvc.oUser_Accessible_Level_List.GEOJSON_SRC = result.GEOJSON_SRC;
                    this.CmSvc.oList_Dimension_Index = result.LIST_DIMENSION_INDEX;
                    this.Upper_Level_Name = result.UPPER_LEVEL.NAME;
                    this.Upper_Level_Location = result.UPPER_LEVEL.LOCATION;
                    this.Upper_Level_Logo_URL = result.UPPER_LEVEL.LOGO_URL;
                    this.Upper_Level_Image_URL = result.UPPER_LEVEL.IMAGE_URL;
                    this.MapService.oChange_Map_View_Subject.next(i_Enum_Map_view);
                    this.Current_View_Type = this.CmSvc.ToTitleCase(Enum_Map_view[i_Enum_Map_view]);
                    this.oEnum_Map_view = i_Enum_Map_view;
                    this.BdcWalkService.setTaskCompleted("levelSwitchPopup", true);
                    this.isContentLoaded = false;
                    this.MapService.oApply_Filter_Subject.next();
                }
            })
        }
    }

    Change_Map_View_Using_Buttons(direction: Enum_Up_Down) {
        let Next_Enum_Map_View = this.oEnum_Map_view;

        switch (this.oEnum_Map_view) {
            case Enum_Map_view.district:
                Next_Enum_Map_View = this.isAreaAccessible ? Enum_Map_view.area :
                    (this.isSiteAccessible ? Enum_Map_view.site :
                        (this.isEntityAccessible ? Enum_Map_view.entity : Next_Enum_Map_View));
                break;
            case Enum_Map_view.area:
                Next_Enum_Map_View = direction === Enum_Up_Down.UP ?
                    (this.isDistrictAccessible ? Enum_Map_view.district : Next_Enum_Map_View) :
                    (this.isSiteAccessible ? Enum_Map_view.site :
                        (this.isEntityAccessible ? Enum_Map_view.entity : Next_Enum_Map_View));
                break;
            case Enum_Map_view.site:
                Next_Enum_Map_View = direction === Enum_Up_Down.UP ?
                    (this.isAreaAccessible ? Enum_Map_view.area :
                        (this.isDistrictAccessible ? Enum_Map_view.district : Next_Enum_Map_View)) :
                    (this.isEntityAccessible ? Enum_Map_view.entity : Next_Enum_Map_View);
                break;
            case Enum_Map_view.entity:
                Next_Enum_Map_View = this.isSiteAccessible ? Enum_Map_view.site :
                    (this.isAreaAccessible ? Enum_Map_view.area :
                        (this.isDistrictAccessible ? Enum_Map_view.district : Next_Enum_Map_View));
                break;
        }

        if (Next_Enum_Map_View != this.oEnum_Map_view) {
            this.changeMapView(Next_Enum_Map_View);
        }
    }



    Toggle_View_Buttons_Status() {
        switch (this.oEnum_Map_view) {
            case Enum_Map_view.district:
                this.isToggleViewUpButtonDisabled = true;
                this.isToggleViewDownButtonDisabled = false;
                if (!this.isAreaAccessible && !this.isSiteAccessible && !this.isEntityAccessible) {
                    this.isToggleViewDownButtonDisabled = true;
                }
                break;
            case Enum_Map_view.area:
                if (this.isDistrictAccessible) {
                    this.isToggleViewUpButtonDisabled = false;
                }
                else {
                    this.isToggleViewUpButtonDisabled = true;
                }
                if (this.isSiteAccessible || this.isEntityAccessible) {
                    this.isToggleViewDownButtonDisabled = false;
                }
                else {
                    this.isToggleViewDownButtonDisabled = true;
                }
                break;
            case Enum_Map_view.site:
                if (this.isDistrictAccessible || this.isAreaAccessible) {
                    this.isToggleViewUpButtonDisabled = false;
                }
                else {
                    this.isToggleViewUpButtonDisabled = true;
                }
                if (this.isEntityAccessible) {
                    this.isToggleViewDownButtonDisabled = false;
                }
                else {
                    this.isToggleViewDownButtonDisabled = true;
                }
                break;
            case Enum_Map_view.entity:
                this.isToggleViewDownButtonDisabled = true;
                this.isToggleViewUpButtonDisabled = false;
                if (!this.isAreaAccessible && !this.isSiteAccessible && !this.isDistrictAccessible) {
                    this.isToggleViewUpButtonDisabled = true;
                }
                break;
        }
    }

    completeHoverPopup() {
        this.BdcWalkService.setTaskCompleted("hoverPopup", true);
    }

    toggleSelection(): void {
        if (this.isTransitioning) {
            this.CmSvc.ShowMessage('Transitioning, Please Wait.', 2000);
        }
        switch (this.view_type.toUpperCase()) {
            case 'DISTRICT':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_District.filter(level_location => level_location.DISTRICT_ID != this.oSelected_District.DISTRICT_ID);
                this._changeDetectorRef.detectChanges()
                break;
            case 'SITE':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Site.filter(level_location => level_location.SITE_ID != this.oSelected_Site.SITE_ID);
                break;
            case 'AREA':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Area.filter(level_location => level_location.AREA_ID != this.oSelected_Area.AREA_ID);
                break;
            case 'ENTITY':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Entity.filter(level_location => level_location.ENTITY_ID != this.oSelected_Entity.ENTITY_ID);
                break;
        }
        if (this.oList_Current_Level_Location != null && this.oList_Current_Level_Location.length > 0) {
            this.isShowChoicePanel = !this.isShowChoicePanel;

            if (this.isShowChoicePanel == false) {
                setTimeout(() => {
                    this.reflowCharts();
                }, 10);
            }
        }

        this._changeDetectorRef.detectChanges();
    }

    togglePin() {
        this.isPinned = !this.isPinned;
        localStorage.setItem('pinStatus', String(this.isPinned));
    }

    getIconWidth() {
        return document.getElementById('site-card').offsetWidth;
    }

    selectEntity(i_Entity: Entity): void {
        this.oSelected_Entity = i_Entity;
        this.MapService.oMarker_Opened_Subject.next(false);
        this.oList_Entity_to_show = this.oList_Entity.filter(entity => entity.ENTITY_ID != i_Entity.ENTITY_ID && this.oSelected_District?.DISTRICT_ID == entity.DISTRICT_ID);
        this.isShowChoicePanel = false;
        this.MapService.oEntity_Changed_Subject.next(i_Entity);
        setTimeout(() => {
            this.reflowCharts();
        }, 10);
    }

    selectSite(i_Site: Site): void {
        this.oSelected_Site = i_Site;
        this.MapService.oMarker_Opened_Subject.next(false);
        this.oList_Site_to_show = this.oList_Site.filter(site => site.SITE_ID != i_Site.SITE_ID && this.oSelected_District?.DISTRICT_ID == site.DISTRICT_ID);
        this.isShowChoicePanel = false;
        this.MapService.oSite_Changed_Subject.next(i_Site);
        setTimeout(() => {
            this.reflowCharts();
        }, 10);
    }

    selectArea(i_Area: Area): void {
        this.oSelected_Area = i_Area;
        this.oList_Area_to_show = this.oList_Area.filter(area => area.AREA_ID != i_Area.AREA_ID && this.oSelected_District?.DISTRICT_ID == area.DISTRICT_ID);
        this.isShowChoicePanel = false;
        this.MapService.oArea_Changed_Subject.next(i_Area);
        setTimeout(() => {
            this.reflowCharts();
        }, 10);
    }

    Select_Location(i_Location): void {
        this.oSelected_Location = i_Location;
        localStorage.setItem(this.view_type + '_id', i_Location[`${this.view_type.toUpperCase()}_ID`])
        let selected_level_id: number;
        switch (this.view_type.toUpperCase()) {
            case 'DISTRICT':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_District.filter(level_location => level_location.DISTRICT_ID != i_Location.DISTRICT_ID);
                selected_level_id = i_Location.DISTRICT_ID;
                break;
            case 'SITE':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Site.filter(level_location => level_location.SITE_ID != i_Location.SITE_ID);
                selected_level_id = i_Location.SITE_ID;
                break;
            case 'AREA':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Area.filter(level_location => level_location.AREA_ID != i_Location.AREA_ID);
                selected_level_id = i_Location.AREA_ID;
                break;
            case 'ENTITY':
                this.oList_Current_Level_Location = this.CmSvc.oList_Accessible_Entity.filter(level_location => level_location.ENTITY_ID != i_Location.ENTITY_ID);
                selected_level_id = i_Location.ENTITY_ID;
                break;
        }
        this.isShowChoicePanel = false;
        let upper_level_value = Enum_Map_view[this.oEnum_Map_view + 1];
        if (this.oEnum_Map_view == Enum_Map_view.district) {
            upper_level_value = Enum_Map_view[this.oEnum_Map_view];
        }
        let upper_level_id: number;
        switch (upper_level_value) {
            case "district":
                upper_level_id = i_Location.DISTRICT_ID;
                break;
            case "area":
                upper_level_id = i_Location.AREA_ID;
                break;
            case "site":
                upper_level_id = i_Location.SITE_ID;
                break;
            case "entity":
                upper_level_id = i_Location.ENTITY_ID;
                break;
        }
        let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.view_type);
        let oParams_Get_dimension_index_with_simple_upper_level = new Params_Get_Dimension_Index_With_Simple_Upper_Level();
        oParams_Get_dimension_index_with_simple_upper_level.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        oParams_Get_dimension_index_with_simple_upper_level.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
        oParams_Get_dimension_index_with_simple_upper_level.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
        oParams_Get_dimension_index_with_simple_upper_level.UPPER_LEVEL_ID = upper_level_id;
        oParams_Get_dimension_index_with_simple_upper_level.SELECTED_DATA_LEVEL_SETUP_ID = data_level_setup_id;
        oParams_Get_dimension_index_with_simple_upper_level.SELECTED_LEVEL_ID = selected_level_id;
        oParams_Get_dimension_index_with_simple_upper_level.LIST_SELECTED_DIMENSION_ID = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_dimension_with_status => oLevel_dimension_with_status.DATA_LEVEL_SETUP_ID == data_level_setup_id && oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_dimension_with_status.LEVEL_ID_LIST.includes(selected_level_id)).map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
        oParams_Get_dimension_index_with_simple_upper_level.LIST_UPPER_DIMENSION_ID = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_dimension_with_status => oLevel_dimension_with_status.DATA_LEVEL_SETUP_ID == this.upper_level_setup_id && oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_dimension_with_status.LEVEL_ID_LIST.includes(upper_level_id)).map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
        this.MapService.Get_dimension_index_with_simple_upper_level(oParams_Get_dimension_index_with_simple_upper_level).then(result => {
            this.MapService.oUpper_Level.NAME = result.FATHER_UPPER_LEVEL.NAME;
            this.MapService.oUpper_Level.LOCATION = result.FATHER_UPPER_LEVEL.LOCATION;
            this.MapService.oUpper_Level.IMAGE_URL = result.FATHER_UPPER_LEVEL.IMAGE_URL;
            this.MapService.oUpper_Level.LOGO_URL = result.FATHER_UPPER_LEVEL.LOGO_URL;
            this.CmSvc.oList_Dimension_Index = result.LIST_UPPER_LEVEL_DIMENSION_INDEX;
            this.MapService.oLocation_Changed_Subject.next({ level_location: i_Location, List_Upper_Level_Dimension_index: [] });
            setTimeout(() => {
                this.reflowCharts();
            }, 10);
        })

    }

    recenterMap(isFocused: boolean): void {
        this.MapService.oRecenter_Map_Subject.next(isFocused);
    }

    toggleMobility() {
        if (this.isShowMobility) {
            this.MapService.oShow_Hide_Mobility_Subject.next(false);
        } else {
            this.MapService.oShow_Hide_Mobility_Subject.next(true);
        }
    }

    toggleDefaultBuildingsVisibility() {
        this.isShow3dEntities = !this.isShow3dEntities;
        this.MapService.toggleDefaultBuildingsVisibility();
    };

    toggleBordersVisibility() {
        this.MapService.toggleBordersVisibility();
    };

    toggleEntities() {
        this.MapService.oShow_Hide_Entities_Subject.next(!this.isShow3dEntities);
    }

    toggleMapStyle() {
        this.MapService.oToggle_Map_Style_Subject.next();
    }

    toggleByLawComplaints() {
        this.isShowBylawComplaints = !this.isShowBylawComplaints;
        this.MapService.oToggle_ByLaw_Complaint_Subject.next();
    }

    toggleUtility() {
        this.isShowButtons = !this.isShowButtons;
    }

    toggleIntersection() {
        this.MapService.oToggle_Intersection_Subject.next(null);
    }

    toggleCorrelationHeatmap() {
        this.MapService.oToggle_Correlation_Heatmap_Subject.next();
    }

    openTopLevelSelector() {
        this.MapService.oOpen_Top_level_Selector_Subject.next(true);
    }

    toggleBusinesses() {
        this.MapService.oToggle_Business_Subject.next();
    }

    togglePublicEvents() {
        this.MapService.oToggle_Public_event_Subject.next();
        this.isShowPublicEvents = !this.isShowPublicEvents;
    }

    editRemovedExtrusions() {
        this.editRemovedExtrusionsEventEmitter.emit();
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
