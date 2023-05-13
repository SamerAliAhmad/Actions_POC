import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnChanges, OnDestroy, OnInit, Output, QueryList, SimpleChanges, ViewChildren } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Dimension_data, Kpi_data } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Dimension, Dimension_index, Dimension_index_By_Level, Enum_Dimension_Status, Floor, Site, Space_asset, Wifi_signal } from 'app/core/Services/proxy.service';
import { ViewShareService } from 'app/modules/view-share/view-share.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import { BaseChartDirective } from 'ng2-charts';
import { Subject, takeUntil } from 'rxjs';
import { ChartModalComponent } from '../../chart-modal/chart-modal.component';
import { MapService } from '../../map.service';
import { Entity, Entity_Incidents, Entity_Kpi_Dialog_Data, Floor_Kpi_Dialog_Data, Kpi_chart_configuration, Level_Dimension_with_Status, Params_Get_Entity_Kpi_Dialog_Data, Params_Get_Intersection_Kpi_Dialog_Data, Setup } from './../../../../core/Services/proxy.service';

@Component({
    selector: 'building-summary',
    templateUrl: './building-summary.component.html',
    styleUrls: ['./building-summary.component.scss']
})
export class BuildingSummaryComponent implements OnInit, OnChanges, OnDestroy {

    @Input() isShareView = false;
    @Input() oSite: Site;
    @Input() oFloor: Floor;
    @Input() oEntity: Entity;

    @Input() isFloorKpiView: boolean;
    @Input() isIntersectionPanel: boolean = false;

    @Input() oList_Wifi_signal: Wifi_signal[];
    @Input() oList_Space_asset: Space_asset[];
    @Input() oList_Floor_Kpi_Data: Floor_Kpi_Dialog_Data[] = [];
    @Input() oList_Dimension_index_for_floors: Dimension_index_By_Level[] = [];

    @Input() oDimension_index_for_entity: Dimension_index_By_Level = new Dimension_index_By_Level();

    @Output() tabIndexChanedEventEmitter = new EventEmitter<number>();
    @Output() dimensionChangedEventEmitter = new EventEmitter<Dimension>();
    @Output() FloorKpiDataChangedEventEmitter = new EventEmitter<Floor_Kpi_Dialog_Data[]>();

    @ViewChildren(BaseChartDirective) oList_Chart: QueryList<BaseChartDirective>;

    oChosen_Dimension: Dimension;
    Enum_Dimension_Status = Enum_Dimension_Status;
    oEntity_Incidents = new Entity_Incidents();

    oChosen_Alerts_Setup: Setup;

    oList_Severity_Setup: Setup[];
    oList_Category_Setup: Setup[];
    oList_Incident_Category_Setup: Setup[] = [];

    chosen_severity_setup_id: number;
    chosen_category_setup_id: number;

    isChartsLoaded = false;
    isIncidentsLoaded = false;
    isDimensionsHidden = false;

    tabIndex = 0;

    oList_Kpi_data: Kpi_data[] = [];
    oList_Wifi_signal_Kpi_data: Kpi_data[] = [];
    oList_Dimension_data: Dimension_data[] = [];
    oList_Entity_Kpi_Dialog_Data: Entity_Kpi_Dialog_Data[] = [];
    oList_Current_Dimension_index: Dimension_index[] = [];
    oList_Kpi_chart_configuration: Kpi_chart_configuration[] = [];
    oList_Level_Dimension_with_Status: Level_Dimension_with_Status[] = [];

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private dialog: MatDialog,
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        public TimezoneService: TimezoneService,
        private ViewShareService: ViewShareService,
    ) {
        let setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Building info");
        this.oList_Kpi_chart_configuration = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
        let oIncident_type_Setup_Category = this.CmSvc.oList_Setup_category.find(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Security Incident Category Type");
        this.oList_Incident_Category_Setup = oIncident_type_Setup_Category.List_Setup.filter(setup => setup.VALUE == "Access Control" || setup.VALUE == "Suspicious Behavior" || setup.VALUE == "Fire Alarm" || setup.VALUE == "Blacklisted Person" || setup.VALUE == "Blacklisted Plate");
        this.oChosen_Alerts_Setup = this.oList_Incident_Category_Setup[0];
        this.oList_Severity_Setup = this.CmSvc.oList_Setup_category.find(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Severity Type").List_Setup;
        this.oList_Category_Setup = this.CmSvc.oList_Setup_category.find(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Security Incident Category Type").List_Setup;
        this.chosen_category_setup_id = this.oList_Category_Setup[0].SETUP_ID;
        this.chosen_severity_setup_id = this.oList_Severity_Setup[0].SETUP_ID;
    }

    ngOnInit() {
        let data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");
        if (!this.isShareView) {
            this.oList_Level_Dimension_with_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension_With_Status => oLevel_Dimension_With_Status.DATA_LEVEL_SETUP_ID == data_level_setup_id && oLevel_Dimension_With_Status.LEVEL_ID_LIST.includes(this.oEntity.ENTITY_ID));
        } else {
            this.oList_Level_Dimension_with_Status = this.ViewShareService.oEntity_share_view_data.List_Entity_Level_Dimension_with_Status;
        }
        if (!(this.oList_Level_Dimension_with_Status.some(oLevel_dimension_with_status => oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN))) {
            this.isDimensionsHidden = true;
        }

        this.isFloorKpiView = (this.oList_Dimension_index_for_floors && this.oList_Dimension_index_for_floors.length > 0);
        this.Fill_Current_Dimension_index_List();
        this.Fill_Dimension_Data().then(result => {
            if (this.isShareView) {
                this.oChosen_Dimension = this.oList_Dimension_data.find(oDimension_data => oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.ViewShareService.oEntity_share_view_data.DIMENSION_ID).LEVEL_DIMENSION_WITH_STATUS.DIMENSION;
                this.dimensionChangedEventEmitter.emit(this.oChosen_Dimension);
                let oDimension_data = this.oList_Dimension_data.find(_Dimension_data => _Dimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oChosen_Dimension.DIMENSION_ID);
                this.oList_Dimension_data[this.oList_Dimension_data.indexOf(oDimension_data)].CssClass += "border-2 border-primary ";
            }
            if (!this.oChosen_Dimension) {
                this.oChosen_Dimension = this.oList_Dimension_data[0].LEVEL_DIMENSION_WITH_STATUS.DIMENSION;
                this.dimensionChangedEventEmitter.emit(this.oChosen_Dimension);
                let oDimension_data = this.oList_Dimension_data.find(_Dimension_data => _Dimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oChosen_Dimension.DIMENSION_ID);
                this.oList_Dimension_data[this.oList_Dimension_data.indexOf(oDimension_data)].CssClass += "border-2 border-primary ";
            }
            if (!this.isIntersectionPanel) {
                if (this.oList_Wifi_signal) {
                    this.configureWifiSignals();
                }
            }
            else {
                this.Get_Intersection_Kpi_Dialog_Data();
            }
        });
        this.MapService.oEntity_Incidents_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(result => {
            if (result.LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT && result.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT && result.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT && result.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT && result.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT) {
                this.oEntity_Incidents = result;
            } else {
                if (result.LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT) {
                    this.oEntity_Incidents.LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT = result.LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT;
                }
                if (result.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT) {
                    this.oEntity_Incidents.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT = result.LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT;
                }
                if (result.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT) {
                    this.oEntity_Incidents.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT = result.LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT;
                }
                if (result.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT) {
                    this.oEntity_Incidents.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT = result.LIST_FIRE_ALARM_INCIDENT_WITH_COUNT;
                }
                if (result.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT) {
                    this.oEntity_Incidents.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT = result.LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT;
                }
                if (result.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT) {
                    this.oEntity_Incidents.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT = result.LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT;
                }
            }
            this.isIncidentsLoaded = true;
        });
        this.MapService.oApply_Filter_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            if (!this.isIntersectionPanel) {
                if (!this.isFloorKpiView) {
                    this.Get_Entity_Kpi_Dialog_Data();
                }
                if (this.oList_Wifi_signal) {
                    this.configureWifiSignals();
                }
            }
            else {
                this.Get_Intersection_Kpi_Dialog_Data();
            }
        });
        if (this.isShareView) {
            this.oSite = this.oEntity.Site;
            if (!this.ViewShareService.oEntity_share_view_data.IS_ALERT) {
                if (this.ViewShareService.oEntity_share_view_data.IS_ENTITY_SUMMARY_DRAWER_VISIBLE) {
                    this.Fill_Chart_Data(this.ViewShareService.oEntity_share_view_data.List_Entity_kpi_data).then(result => {
                        if (result) {
                            this.updateCharts();
                            this.isChartsLoaded = true;
                        }
                    });
                } else {
                    this.Fill_Chart_Data(this.ViewShareService.oEntity_share_view_data.List_Floor_kpi_data).then(result => {
                        if (result) {
                            this.updateCharts();
                            this.isChartsLoaded = true;
                        }
                    });
                    this.oList_Wifi_signal = this.ViewShareService.oEntity_share_view_data.List_Floor_chart_Wifi_signal;
                    this.configureWifiSignals();
                }
            } else {
                this.tabIndex = 1;
                this.isIncidentsLoaded = true;
                let oIncident_Setup_category = this.CmSvc.oList_Setup_category.find(oSetup_category => oSetup_category.SETUP_CATEGORY_NAME == "Security Incident Category Type");
                let oList_Security_Incident_Category_Setup = oIncident_Setup_category.List_Setup.filter(setup => setup.VALUE == "Access Control" || setup.VALUE == "Suspicious Behavior" || setup.VALUE == "Fire Alarm" || setup.VALUE == "Blacklisted Person" || setup.VALUE == "Blacklisted Plate");
                this.oChosen_Alerts_Setup = oList_Security_Incident_Category_Setup.find(oSetup => oSetup.SETUP_ID == this.ViewShareService.oEntity_share_view_data.INCIDENT_CATEGORY_SETUP_ID);
            }
        }
    }

    ngOnChanges(changes: SimpleChanges) {
        this.Fill_Current_Dimension_index_List().then(result => {
            if (result) {
                this.Fill_Dimension_Data().then(result => {
                    if (!this.oChosen_Dimension) {
                        this.oChosen_Dimension = this.oList_Dimension_data[0].LEVEL_DIMENSION_WITH_STATUS.DIMENSION;
                        this.dimensionChangedEventEmitter.emit(this.oChosen_Dimension);
                        let oDimension_data = this.oList_Dimension_data.find(_Dimension_data => _Dimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oChosen_Dimension.DIMENSION_ID);
                        this.oList_Dimension_data[this.oList_Dimension_data.indexOf(oDimension_data)].CssClass += "border-2 border-primary ";
                    }
                    if (!this.isIntersectionPanel) {
                        if (!this.isFloorKpiView && !this.isShareView) {
                            this.Get_Entity_Kpi_Dialog_Data();
                        }
                        if (changes['oList_Wifi_signal'] && this.oList_Wifi_signal && this.oList_Kpi_chart_configuration && this.oList_Kpi_chart_configuration.length > 0) {
                            this.configureWifiSignals();
                        }
                    }
                    else {
                        this.Get_Intersection_Kpi_Dialog_Data();
                    }
                });
            }
        });
        if (changes['oList_Floor_Kpi_Data'] && this.isFloorKpiView) {
            this.isDimensionsHidden = false;
            if (this.oList_Floor_Kpi_Data && this.oList_Floor_Kpi_Data.length > 0) {
                this.Fill_Chart_Data(this.oList_Floor_Kpi_Data).then(result => {
                    if (result) {
                        this.updateCharts();
                        this.isChartsLoaded = true;
                    }
                });
            }
            else {
                this.isDimensionsHidden = true;
                this.isChartsLoaded = true;
            }
        }
    }

    Fill_Current_Dimension_index_List(): Promise<boolean> {
        return new Promise(resolve => {
            if (this.isFloorKpiView) {
                this.oList_Current_Dimension_index = this.oList_Dimension_index_for_floors?.find(oDimension_index_by_level => oDimension_index_by_level.LEVEL_ID == this.oFloor.FLOOR_ID)?.LIST_DIMENSION_INDEX?.sort((a, b) => {
                    if (a.RECORD_DATE > b.RECORD_DATE) {
                        return 1;
                    }
                    if (a.RECORD_DATE < b.RECORD_DATE) {
                        return -1;
                    }
                    return 0;
                });
            }
            else {

                this.oList_Current_Dimension_index = this.oDimension_index_for_entity?.LIST_DIMENSION_INDEX.sort((a, b) => {
                    if (a.RECORD_DATE > b.RECORD_DATE) {
                        return 1;
                    }
                    if (a.RECORD_DATE < b.RECORD_DATE) {
                        return -1;
                    }
                    return 0;
                });
            }
            resolve(true);
        })
    }

    changeAlertCategory(setup) {
        if (!this.isShareView) {
            this.oChosen_Alerts_Setup = setup;
        }
    }

    Fill_Dimension_Data(): Promise<Dimension_data[]> {
        return new Promise(resolve => {
            this.oList_Dimension_data = this.oList_Level_Dimension_with_Status.map(oLevel_Dimension_With_Status => {
                const oDimension_data = new Dimension_data();
                oDimension_data.LEVEL_DIMENSION_WITH_STATUS = oLevel_Dimension_With_Status;
                const oDimension_index = this.oList_Current_Dimension_index?.find(oDimension_index => oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID);
                if (oDimension_index) {
                    oDimension_data.INDEX_VALUE = Math.round(oDimension_index.VALUE);
                    oDimension_data.INDEX_COLOR = oDimension_data.INDEX_VALUE > 66 ? 'text-highIndexColor' : oDimension_data.INDEX_VALUE > 33 ? 'text-averageIndexColor' : 'text-lowIndexColor';
                } else {
                    oDimension_data.INDEX_VALUE = 0;
                    oDimension_data.INDEX_COLOR = 'text-neutralIndexColor';
                }
                oDimension_data.CssClass = "";
                if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.ENABLED) {
                    oDimension_data.CssClass += "cursor-pointer ";
                }
                if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.DISABLED) {
                    oDimension_data.CssClass += 'opacity-40 ';
                }
                if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.ENABLED) {
                    oDimension_data.CssClass += 'cursor-auto !pointer-events-none ';
                }
                if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.HIDDEN) {
                    oDimension_data.CssClass += '!bg-gray-700 ';
                }
                else {
                    oDimension_data.CssClass += "bg-chartBackgroundColor ";
                }
                if (this.oChosen_Dimension) {
                    if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oChosen_Dimension.DIMENSION_ID) {
                        oDimension_data.CssClass += "border-2 border-primary ";
                    }
                }
                return oDimension_data;
            }).sort((a, b) => a.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS - b.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS);
            resolve(this.oList_Dimension_data);
        })
    }

    changeKpiDimension(i_Dimension: Dimension) {
        if (this.isShareView) {
            return;
        }
        if (this.oChosen_Dimension != i_Dimension) {
            this.isChartsLoaded = false;
            this.isDimensionsHidden = false;
            this.oChosen_Dimension = i_Dimension;
            this.dimensionChangedEventEmitter.emit(this.oChosen_Dimension);

            this.oList_Dimension_data.forEach(oDimension_Data => {
                if (oDimension_Data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oChosen_Dimension.DIMENSION_ID && !oDimension_Data.CssClass.includes('border-2 border-primary')) {
                    oDimension_Data.CssClass += ' border-2 border-primary ';
                }
                else {
                    oDimension_Data.CssClass = oDimension_Data.CssClass.replace('border-2 border-primary', ' ').trim();
                }
            })
            if (!this.isIntersectionPanel) {
                if (!this.isFloorKpiView) {
                    this.Get_Entity_Kpi_Dialog_Data();
                }
                if (this.oList_Wifi_signal) {
                    this.configureWifiSignals();
                }
            }
            else {
                this.Get_Intersection_Kpi_Dialog_Data();
            }
        }

    }

    removeFirstWord(WORD: string) {
        return WORD.substring(WORD.indexOf(" ") + 1);
    }

    Get_Entity_Kpi_Dialog_Data() {
        let oParams_Get_Entity_Kpi_Dialog_Data = new Params_Get_Entity_Kpi_Dialog_Data();
        var setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Building info");
        var oList_KPI_chart_configuration_Building_Info = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
        var List_Entity_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.find(oOrganization_Data_Source_Kpi_ID => oOrganization_Data_Source_Kpi_ID.LEVEL_ID == this.oEntity.ENTITY_ID)?.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
        if (List_Entity_Organization_data_source_kpi) {
            List_Entity_Organization_data_source_kpi = List_Entity_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Building_Info.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
            oParams_Get_Entity_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = List_Entity_Organization_data_source_kpi.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
        }
        oParams_Get_Entity_Kpi_Dialog_Data.DIMENSION_ID = this.oChosen_Dimension.DIMENSION_ID;
        oParams_Get_Entity_Kpi_Dialog_Data.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        oParams_Get_Entity_Kpi_Dialog_Data.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
        oParams_Get_Entity_Kpi_Dialog_Data.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
        oParams_Get_Entity_Kpi_Dialog_Data.ENTITY_ID = this.oEntity.ENTITY_ID;
        this.MapService.Get_Entity_Kpi_Dialog_Data(oParams_Get_Entity_Kpi_Dialog_Data).then(result => {
            if (result && result.length > 0) {
                this.oList_Entity_Kpi_Dialog_Data = result;
                this.Fill_Chart_Data(result).then(result => {
                    if (result) {
                        this.updateCharts();
                        this.isChartsLoaded = true;
                    }
                });
            }
            else {
                this.isDimensionsHidden = true;
                this.isChartsLoaded = true;
            }
        })
    }

    Get_Intersection_Kpi_Dialog_Data() {
        let oParams_Get_Intersection_Kpi_Dialog_Data = new Params_Get_Intersection_Kpi_Dialog_Data();
        var setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Building info");
        var oList_KPI_chart_configuration_Building_Info = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
        var List_Entity_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.find(oOrganization_Data_Source_Kpi_ID => oOrganization_Data_Source_Kpi_ID.LEVEL_ID == this.oEntity.ENTITY_ID)?.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
        if (List_Entity_Organization_data_source_kpi) {
            List_Entity_Organization_data_source_kpi = List_Entity_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Building_Info.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
            oParams_Get_Intersection_Kpi_Dialog_Data.LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = List_Entity_Organization_data_source_kpi.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
        }
        oParams_Get_Intersection_Kpi_Dialog_Data.DIMENSION_ID = this.oChosen_Dimension.DIMENSION_ID;
        oParams_Get_Intersection_Kpi_Dialog_Data.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
        oParams_Get_Intersection_Kpi_Dialog_Data.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
        oParams_Get_Intersection_Kpi_Dialog_Data.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
        oParams_Get_Intersection_Kpi_Dialog_Data.ENTITY_ID = this.oEntity.ENTITY_ID;
        this.MapService.Get_Intersection_Kpi_Dialog_Data(oParams_Get_Intersection_Kpi_Dialog_Data).then(result => {
            if (result && result.length > 0) {
                this.oList_Entity_Kpi_Dialog_Data = result;
                this.Fill_Chart_Data(result).then(result => {
                    if (result) {
                        this.updateCharts();
                        this.isChartsLoaded = true;
                    }
                });
            }
            else {
                this.isDimensionsHidden = true;
                this.isChartsLoaded = true;
            }
        })
    }

    Update_Chart_Data() {
        if (this.isFloorKpiView) {
            this.Fill_Chart_Data(this.oList_Floor_Kpi_Data).then(result => {
                if (result) {
                    this.updateCharts();
                }
            })
        }
        else {
            this.Fill_Chart_Data(this.oList_Entity_Kpi_Dialog_Data).then(result => {
                if (result) {
                    this.updateCharts();
                }
            })
        }
    }

    Fill_Chart_Data(i_List_Kpi_Data): Promise<boolean> {
        this.oList_Kpi_data = [];
        return new Promise(resolve => {
            this.oList_Kpi_chart_configuration.forEach(oKpi_chart_configuration => {
                const oKpi_data = new Kpi_data();
                const oLevel_Kpi_data = i_List_Kpi_Data.find(oLevel_Kpi_data => oKpi_chart_configuration.KPI_ID == oLevel_Kpi_data.KPI_ID);

                if (oLevel_Kpi_data) {
                    oKpi_data.Kpi_chart_configuration = oKpi_chart_configuration;
                    oKpi_data.List_Action_Button = [];
                    if (oKpi_chart_configuration.LIST_SETTING.length > 1) {
                        oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "heroicons_outline:chevron-double-right" });
                    }

                    oKpi_data.ChartConfiguration = JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;
                    let titleText = '';
                    if (oLevel_Kpi_data.TITLE.toLowerCase().includes("from")) {
                        const fromIndex = oLevel_Kpi_data.TITLE.toLowerCase().indexOf("from");
                        const tillIndex = oLevel_Kpi_data.TITLE.toLowerCase().indexOf("till");
                        if (fromIndex >= 0 && tillIndex >= 0) {
                            titleText = oLevel_Kpi_data.TITLE.substring(0, fromIndex).trim();
                            const fromDate = oLevel_Kpi_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                            const toDate = oLevel_Kpi_data.TITLE.substring(tillIndex + 4).trim();
                            oKpi_data.From_Date = fromDate;
                            oKpi_data.To_Date = toDate;
                        }
                    }
                    else {
                        titleText = oLevel_Kpi_data.TITLE;
                    }
                    oKpi_data.CHART_TITLE = titleText;
                    let oData_Point = oLevel_Kpi_data.LIST_KPI_DATA.find(oKPI_DATA => (
                        (oKPI_DATA.INCIDENT_CATEGORY_SETUP_ID == this.chosen_category_setup_id && oKPI_DATA.SEVERITY_TYPE_SETUP_ID == this.chosen_severity_setup_id)
                        || (oKPI_DATA.INCIDENT_CATEGORY_SETUP_ID == 0 && oKPI_DATA.SEVERITY_TYPE_SETUP_ID == this.chosen_severity_setup_id)
                        || (oKPI_DATA.INCIDENT_CATEGORY_SETUP_ID == this.chosen_category_setup_id && oKPI_DATA.SEVERITY_TYPE_SETUP_ID == 0)
                        || (oKPI_DATA.INCIDENT_CATEGORY_SETUP_ID == 0 && oKPI_DATA.SEVERITY_TYPE_SETUP_ID == 0)
                    ));

                    if (oData_Point && oData_Point.LIST_DATASET.length > 0 && oData_Point.LIST_LABEL.length > 0) {
                        oKpi_data.isDataAvailable = true;
                        if (oKpi_data.ChartConfiguration.type != "treemap") {
                            for (let index = 0; index < oData_Point.LIST_DATASET.length; index++) {
                                let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme?.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oData_Point.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                if (!color) {
                                    color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oData_Point.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR
                                }
                                oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oData_Point.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                oKpi_data.ChartConfiguration.data.datasets[index].data = oData_Point.LIST_DATASET[index]?.LIST_POINT;
                            }
                            oKpi_data.ChartConfiguration.data.labels = oData_Point.LIST_LABEL;
                        }
                        else {
                            var Floor_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Floor");
                            let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme?.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Floor_Setup_ID).COLOR;
                            if (!color) {
                                color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Floor_Setup_ID).COLOR
                            }
                            oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oData_Point.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                            oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oData_Point.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                return {
                                    value: point,
                                    title: oData_Point.LIST_LABEL[i]
                                }
                            });
                            oKpi_data.ChartConfiguration.options.plugins.tooltip.callbacks.title = eval(`(${oKpi_data.ChartConfiguration.options.plugins.tooltip.callbacks.title})`);
                            oKpi_data.ChartConfiguration.data.datasets[0]['labels'].color = eval(`(${oKpi_data.ChartConfiguration.data.datasets[0][`labels`].color})`);
                            oKpi_data.ChartConfiguration.data.datasets[0].backgroundColor = eval(`(${oKpi_data.ChartConfiguration.data.datasets[0].backgroundColor})`);

                        }
                    }
                    else {
                        oKpi_data.isDataAvailable = false;
                    }
                    oKpi_data.ChartConfiguration.options.plugins.title.display = false;
                    this.oList_Kpi_data.push(oKpi_data);

                }
            })
            resolve(true);
        })
    }

    configureWifiSignals() {
        this.oList_Wifi_signal_Kpi_data = [];
        this.oList_Space_asset?.forEach(space_asset => {
            const oKpi_data = new Kpi_data();
            oKpi_data.CHART_TITLE = space_asset.CUSTOM_NAME;
            oKpi_data.Kpi_chart_configuration = this.oList_Kpi_chart_configuration[0];
            oKpi_data.ChartConfiguration = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration);
            oKpi_data.ChartConfiguration.options.plugins.title.display = false;
            oKpi_data.ChartConfiguration.options.plugins.tooltip.callbacks = {
                label: (tooltipItems) => {
                    return tooltipItems.dataset.label + ': ' + tooltipItems.raw + 'dbm';
                }
            }
            const chartData = this.oList_Wifi_signal.filter(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID == space_asset.SPACE_ASSET_ID);
            oKpi_data.isDataAvailable = chartData.length > 0
            if (oKpi_data.isDataAvailable) {
                oKpi_data.From_Date = this.DatePipe.transform(chartData[0]?.RECORD_DATE, null, this.TimezoneService.oCurrent_Timezone_Offset);
                oKpi_data.To_Date = this.DatePipe.transform(chartData[chartData.length - 1]?.RECORD_DATE, null, this.TimezoneService.oCurrent_Timezone_Offset);
            }
            let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme?.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Floor")).COLOR;
            if (!color) {
                color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Floor")).COLOR;
            }
            const oSeriesSettings = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, space_asset.CUSTOM_NAME)) as ChartConfiguration['data']['datasets'][0]);
            oSeriesSettings.data = chartData.sort((a, b) => new Date(a.RECORD_DATE).getTime() - new Date(b.RECORD_DATE).getTime()).map(datum => datum.VALUE);
            oKpi_data.ChartConfiguration.data.datasets[0] = oSeriesSettings;
            oKpi_data.ChartConfiguration.data.labels = chartData.map(datum => this.DatePipe.transform(datum.RECORD_DATE, "medium", this.TimezoneService.oCurrent_Timezone_Offset));
            this.oList_Wifi_signal_Kpi_data.push(oKpi_data);
        });
        this.updateCharts();
    }

    updateCharts() {
        this.oList_Chart?.forEach(chart => {
            chart?.update();
            chart?.render();
        });
    }

    changeDimension() {
        this.tabIndexChanedEventEmitter.emit(this.tabIndex);
        this.changeKpiDimension(this.oChosen_Dimension);

        this.MapService.Get_Entity_Incidents(this.oEntity, null, null, this.oList_Incident_Category_Setup);
    }

    isShowWifiSignals() {
        return this.oChosen_Dimension.NAME.toLowerCase().includes("living");
    }

    openChartModal(i_ChartConfiguration: ChartConfiguration, title: string) {
        this.dialog.open(ChartModalComponent, {
            width: '1200px',
            height: '750px',
            data: {
                title: title,
                ChartConfiguration: i_ChartConfiguration,
            },
            autoFocus: false,
            disableClose: false,
            panelClass: ['chart-container-panel'],
        });
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
