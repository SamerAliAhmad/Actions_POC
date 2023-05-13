import { ChangeDetectorRef, Component, EventEmitter, Input, OnDestroy, OnInit, Output, QueryList, ViewChildren } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Enum_Map_view } from 'app/core/Models/constants';
import { Dimension_data, Kpi_data } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area_Kpi_Dialog_Data, Dimension, Dimension_ID_By_Level_ID, Dimension_index, Enum_Dimension_Status, Level_Dimension_with_Status, Params_Get_Dimension_Index_With_Simple_Upper_Level, Params_Get_Latest_Dimension_index_By_Where, Site_Kpi_Dialog_Data, Visitor_Origins } from 'app/core/Services/proxy.service';
import { ChartConfiguration } from 'chart.js';
import { color } from 'chart.js/helpers';
import { cloneDeep } from 'lodash';
import { BaseChartDirective } from 'ng2-charts';
import { Subject, takeUntil } from 'rxjs';
import { ChartModalComponent } from '../chart-modal/chart-modal.component';
import { Dialog_input, MapService } from '../map.service';
import { Params_Get_Area_Kpi_Dialog_Data, Params_Get_Site_Kpi_Dialog_Data } from './../../../core/Services/proxy.service';

@Component({
    selector: 'level-kpi-charts',
    templateUrl: './level-kpi-charts.component.html',
    styleUrls: ['./level-kpi-charts.component.scss']
})
export class LevelKpiChartsComponent implements OnInit, OnDestroy {

    @Input() oDialog_input: Dialog_input;

    @Output() isChartsLoadedChange = new EventEmitter<boolean>();
    @Output() VisitorOriginsEventEmitter = new EventEmitter<Visitor_Origins>();

    @ViewChildren(BaseChartDirective) oList_Chart: QueryList<BaseChartDirective>;

    coordinates;

    isChartsLoaded = false;
    isButtonsEnabled = true;
    isDimensionsHidden = false;

    level_id: number;
    upper_level_id: number;
    grandfather_level_id: number;

    view_type: string;
    upper_level_name: string;
    grandfather_level_name: string;

    Enum_Dimension_Status = Enum_Dimension_Status;

    List_Checked_Buttons: boolean[] = []
    original_dwell_time_labels: string[] = [];

    Enum_Map_view = Enum_Map_view;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private MapService: MapService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) { }

    ngOnInit() {
        this.upper_level_name = this.oDialog_input.properties.upper_level_name;
        this.grandfather_level_name = this.oDialog_input.properties.grandfather_level_name;
        this.grandfather_level_id = this.oDialog_input.properties.grandfather_level_id;
        this.oDialog_input.properties.oClicked_Level_Location.NAME = this.oDialog_input.properties.level_location.NAME;
        this.oDialog_input.properties.oClicked_Level_Location.LOCATION = this.oDialog_input.properties.level_location.LOCATION;
        this.oDialog_input.properties.oClicked_Level_Location.IMAGE_URL = this.oDialog_input.properties.level_location.IMAGE_URL;
        this.isButtonsEnabled = true;
        this.level_id = this.oDialog_input.level_id;
        this.view_type = this.oDialog_input.properties.Current_view_type.toLowerCase();
        let upper_level_value;
        if (this.oDialog_input.properties.oEnum_Map_View == Enum_Map_view.area) {
            upper_level_value = 'district';
        }
        else if (this.oDialog_input.properties.oEnum_Map_View == Enum_Map_view.site) {
            upper_level_value = 'area';
        }
        this.upper_level_id = this.oDialog_input.properties.level_location[`${upper_level_value.toUpperCase()}_ID`];
        this.coordinates = [this.oDialog_input.properties.oClicked_Level_Location.CENTER_LONGITUDE, this.oDialog_input.properties.oClicked_Level_Location.CENTER_LATITUDE]
        this.oDialog_input.properties.oClicked_Level_Location.ID = this.oDialog_input.properties.level_location[`${this.oDialog_input.properties.Current_view_type.toUpperCase()}_ID`];
        let setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Level Modal");
        this.oDialog_input.properties.oList_Kpi_chart_configuration = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
        if (this.oDialog_input.properties.oList_Action_Button && this.oDialog_input.properties.oList_Action_Button.length > 0) {
            this.oDialog_input.properties.oList_Kpi_chart_configuration.forEach((kpiConfig) => {
                kpiConfig.LIST_ACTION_BUTTON.map((actionBtn) => {
                    const matchingBtn = this.oDialog_input.properties.oList_Action_Button.find((otherBtn) => otherBtn.FUNCTIONALITY === actionBtn.FUNCTIONALITY);
                    if (matchingBtn) {
                        actionBtn.IS_CHECKED = matchingBtn.IS_CHECKED;
                    }
                    return actionBtn;
                });
            });
        }
        else {
            this.oDialog_input.properties.oList_Kpi_chart_configuration =
                this.oDialog_input.properties.oList_Kpi_chart_configuration.map(
                    item => ({
                        ...item,
                        LIST_ACTION_BUTTON: item.LIST_ACTION_BUTTON.map(button => ({ ...button, IS_CHECKED: false }))
                    })
                );
        }
        if (!this.oDialog_input.properties.oList_Dimension_index || this.oDialog_input.properties.oList_Dimension_index?.length == 0) {
            this.Get_Dimensions().then(result => {
                this.oDialog_input.properties.isIndexValuesLoaded = result;
                if (this.oDialog_input.properties.oList_Dimension_data != null && this.oDialog_input.properties.oList_Dimension_data.length > 0) {
                    this.changeKpiDimension(this.oDialog_input.properties.oList_Dimension_data[0].LEVEL_DIMENSION_WITH_STATUS.DIMENSION);
                }
                this._changeDetectorRef.detectChanges();
            });
        }
        else {
            this.oDialog_input.properties.isIndexValuesLoaded = true;
            if (this.oDialog_input.properties.oList_Dimension_data != null && this.oDialog_input.properties.oList_Dimension_data.length > 0) {
                this.changeKpiDimension(this.oDialog_input.properties.oList_Dimension_data[0].LEVEL_DIMENSION_WITH_STATUS.DIMENSION);
            }
            this._changeDetectorRef.detectChanges();
        }
        this.MapService.oApply_Filter_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.oDialog_input.properties.isIndexValuesLoaded = false;
            this.Get_Kpi_Data(this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID, true);
            this.Get_Level_Dimension_List().then(oList_Level_Dimension_With_Status => {
                this.Get_Latest_Dimension_index().then(oList_Dimension_index => {
                    this.Update_List_Dimension_Data(oList_Level_Dimension_With_Status, oList_Dimension_index);
                })
            })
        });
        if (!this.oDialog_input.properties.oList_Kpi_data) {
            this.oDialog_input.properties.oList_Kpi_data = [];
        }

        this.MapService.oChange_Map_View_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(_Enum_map_view => {
            if (_Enum_map_view != this.oDialog_input.properties.oEnum_Map_View) {
                this.isButtonsEnabled = false;
            }
            else {
                this.isButtonsEnabled = true;
            }
        })

        this.MapService.oToggle_Action_Button_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(data => {
            if (data) {
                if (data.level_id != this.level_id && data.view_type == this.view_type && data.upper_level_id == this.upper_level_id) {
                    this.oDialog_input.properties.oList_Kpi_data.forEach((kpiData) => {
                        const actionButton = kpiData.List_Action_Button.find((btn) => btn.FUNCTIONALITY.toLowerCase() === data.Action_Button.FUNCTIONALITY.toLowerCase());
                        if (actionButton) {
                            if (actionButton.FUNCTIONALITY.toLowerCase() != "toggle visitor origins") {
                                actionButton.IS_CHECKED = !actionButton.IS_CHECKED;
                            }
                            else {
                                actionButton.IS_CHECKED = false;
                            }
                        }
                    });

                }
                else if (data.level_id != this.level_id && data.view_type == this.view_type && data.upper_level_id != this.upper_level_id) {
                    this.oDialog_input.properties.oList_Kpi_data.forEach((kpiData) => {
                        const actionButton = kpiData.List_Action_Button.find((btn) => btn.FUNCTIONALITY.toLowerCase() === data.Action_Button.FUNCTIONALITY.toLowerCase());
                        if (actionButton) {
                            actionButton.IS_CHECKED = false;
                        }
                    });
                }
            }
            else {
                this.oDialog_input.properties.oList_Kpi_data.forEach((kpiData) => {
                    kpiData.List_Action_Button.forEach((actionButton) => {
                        actionButton.IS_CHECKED = false;
                    })
                });
            }
        })
    }

    Get_Dimension_index_list(): Promise<any> {
        return new Promise(resolve => {
            if (this.oDialog_input.properties.oList_Dimension_index && this.oDialog_input.properties.oList_Dimension_index.length > 0) {
                resolve(this.oDialog_input.properties.oList_Dimension_index);
            }
            else {
                let upper_level_view_type = Enum_Map_view[this.oDialog_input.properties.oEnum_Map_View + 1];
                let selected_level_view_type = Enum_Map_view[this.oDialog_input.properties.oEnum_Map_View];
                let upper_data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", upper_level_view_type);
                let upper_level_id = this.oDialog_input.properties.level_location[`${upper_level_view_type.toUpperCase()}_ID`]
                let oParams_Get_dimension_index_with_simple_upper_level = new Params_Get_Dimension_Index_With_Simple_Upper_Level();
                oParams_Get_dimension_index_with_simple_upper_level.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
                oParams_Get_dimension_index_with_simple_upper_level.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
                oParams_Get_dimension_index_with_simple_upper_level.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
                oParams_Get_dimension_index_with_simple_upper_level.UPPER_LEVEL_ID = upper_level_id;
                oParams_Get_dimension_index_with_simple_upper_level.SELECTED_DATA_LEVEL_SETUP_ID = this.oDialog_input.properties.Data_Level_Setup_ID;
                oParams_Get_dimension_index_with_simple_upper_level.SELECTED_LEVEL_ID = this.oDialog_input.properties.level_location[`${selected_level_view_type.toUpperCase()}_ID`];
                oParams_Get_dimension_index_with_simple_upper_level.LIST_SELECTED_DIMENSION_ID = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_dimension_with_status => oLevel_dimension_with_status.DATA_LEVEL_SETUP_ID == this.oDialog_input.properties.Data_Level_Setup_ID && oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_dimension_with_status.LEVEL_ID_LIST.includes(this.oDialog_input.properties.level_location[`${selected_level_view_type.toUpperCase()}_ID`])).map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
                oParams_Get_dimension_index_with_simple_upper_level.LIST_UPPER_DIMENSION_ID = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_dimension_with_status => oLevel_dimension_with_status.DATA_LEVEL_SETUP_ID == upper_data_level_setup_id && oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_dimension_with_status.LEVEL_ID_LIST.includes(upper_level_id)).map(oLevel_Dimension => oLevel_Dimension.DIMENSION.DIMENSION_ID);
                this.MapService.Get_dimension_index_with_simple_upper_level(oParams_Get_dimension_index_with_simple_upper_level).then(result => {
                    this.MapService.oUpper_Level.NAME = result.FATHER_UPPER_LEVEL.NAME;
                    this.MapService.oUpper_Level.LOCATION = result.FATHER_UPPER_LEVEL.LOCATION;
                    this.MapService.oUpper_Level.IMAGE_URL = result.FATHER_UPPER_LEVEL.IMAGE_URL;
                    this.MapService.oUpper_Level.LOGO_URL = result.FATHER_UPPER_LEVEL.LOGO_URL;
                    this.CmSvc.oList_Dimension_Index = result.LIST_UPPER_LEVEL_DIMENSION_INDEX;
                    this.oDialog_input.properties.upper_level_name = result.FATHER_UPPER_LEVEL.NAME;
                    this.oDialog_input.properties.grandfather_level_name = result.GRANDFATHER_UPPER_LEVEL.NAME;
                    this.oDialog_input.properties.grandfather_level_id = result.GRANDFATHER_UPPER_LEVEL.LEVEL_ID;
                    this.grandfather_level_name = result.GRANDFATHER_UPPER_LEVEL.NAME;
                    this.grandfather_level_id = result.GRANDFATHER_UPPER_LEVEL.LEVEL_ID;
                    this.upper_level_name = this.oDialog_input.properties.upper_level_name;
                    setTimeout(() => {
                        this.MapService.oLocation_Changed_Subject.next({ level_location: this[`oCurrent_${this.CmSvc.ToTitleCase(selected_level_view_type)}`], List_Upper_Level_Dimension_index: [] });
                    }, 50);
                    this.oDialog_input.properties.oList_Dimension_index = result.LIST_SELECTED_LEVEL_DIMENSION_INDEX;
                    resolve(result.LIST_SELECTED_LEVEL_DIMENSION_INDEX)
                })
            }
        })
    }

    Get_Level_Dimension_List(): Promise<Level_Dimension_with_Status[]> {
        return new Promise(resolve => {
            this.oDialog_input.properties.oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(Level_Dimension_With_Status => Level_Dimension_With_Status.DATA_LEVEL_SETUP_ID == this.oDialog_input.properties.Data_Level_Setup_ID && Level_Dimension_With_Status.LEVEL_ID_LIST.includes(this.level_id))
            if (!this.oDialog_input.properties.oList_Level_Dimension_With_Status.some(oLevel_dimension_with_status => oLevel_dimension_with_status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN)) {
                this.isDimensionsHidden = true;
            }
            resolve(this.oDialog_input.properties.oList_Level_Dimension_With_Status);
        })
    }

    Get_Dimensions(): Promise<boolean> {
        return new Promise(resolve => {
            this.oDialog_input.properties.Data_Level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", this.oDialog_input.properties.Current_view_type);
            this.Get_Level_Dimension_List().then(oList_Level_Dimension_With_Status => {
                this.Get_Dimension_index_list().then(oList_Dimension_index => {
                    this.Update_List_Dimension_Data(oList_Level_Dimension_With_Status, oList_Dimension_index);
                    resolve(true);
                })
            })
        })
    }

    Get_Latest_Dimension_index(): Promise<Dimension_index[]> {
        return new Promise(resolve => {
            let oParams_Get_Latest_Dimension_Index_By_Where = new Params_Get_Latest_Dimension_index_By_Where();
            oParams_Get_Latest_Dimension_Index_By_Where.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
            let level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", this.view_type);
            oParams_Get_Latest_Dimension_Index_By_Where.LEVEL_SETUP_ID = level_setup_id;
            oParams_Get_Latest_Dimension_Index_By_Where.START_DATE = this.MapService.oStart_Date_Filter.toISOString();
            oParams_Get_Latest_Dimension_Index_By_Where.END_DATE = this.MapService.oEnd_Date_Filter.toISOString();
            let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(level_dimension => level_dimension.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && level_dimension.DATA_LEVEL_SETUP_ID == level_setup_id && level_dimension.LEVEL_ID_LIST.includes(this.oDialog_input.level_id));
            let oDimension_id_by_level_id = new Dimension_ID_By_Level_ID();
            oDimension_id_by_level_id.LEVEL_ID = this.oDialog_input.level_id;
            oDimension_id_by_level_id.LIST_DIMENSION_ID = oList_Level_Dimension_With_Status.map(oLevel_Dimension_With_Status => oLevel_Dimension_With_Status.DIMENSION.DIMENSION_ID);
            oParams_Get_Latest_Dimension_Index_By_Where.LIST_DIMENSION_ID_BY_LEVEL_ID = [oDimension_id_by_level_id];
            this.MapService.Get_Latest_Dimension_index_By_Where(oParams_Get_Latest_Dimension_Index_By_Where).then(result => {
                if (result && result.length > 0) {
                    this.oDialog_input.properties.oList_Dimension_index = result[0].LIST_DIMENSION_INDEX;
                    resolve(result[0].LIST_DIMENSION_INDEX);
                }
                else {
                    resolve([])
                }
            })
        })
    }

    Update_List_Dimension_Data(i_List_Level_Dimension_With_Status: Level_Dimension_with_Status[], i_List_Dimension_index: Dimension_index[]) {
        this.oDialog_input.properties.oList_Dimension_data = i_List_Level_Dimension_With_Status.map(oLevel_Dimension_With_Status => {
            const oDimension_data = new Dimension_data();
            this._changeDetectorRef.detectChanges();
            oDimension_data.LEVEL_DIMENSION_WITH_STATUS = oLevel_Dimension_With_Status;
            const _List_Dimension_index = i_List_Dimension_index.filter(oDimension_index => oDimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID);
            if (_List_Dimension_index.length > 0 && oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN) {
                oDimension_data.INDEX_VALUE = Math.round(_List_Dimension_index[_List_Dimension_index.length - 1].VALUE);
                oDimension_data.INDEX_COLOR = oDimension_data.INDEX_VALUE > 66 ? 'text-highIndexColor' : oDimension_data.INDEX_VALUE > 33 ? 'text-averageIndexColor' : 'text-lowIndexColor';
            } else {
                oDimension_data.INDEX_VALUE = 0;
                oDimension_data.INDEX_COLOR = 'text-neutralIndexColor';
            }
            oDimension_data.CssClass = "";
            this._changeDetectorRef.detectChanges();

            if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.ENABLED) {
                oDimension_data.CssClass += " cursor-pointer ";
                this._changeDetectorRef.detectChanges();
            }
            else {
                oDimension_data.CssClass += ' cursor-auto !pointer-events-none ';
                this._changeDetectorRef.detectChanges();
            }
            if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.DISABLED) {
                oDimension_data.CssClass += ' opacity-40 ';
                this._changeDetectorRef.detectChanges();
            }
            if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.HIDDEN) {
                oDimension_data.CssClass += ' !bg-gray-700 ';
                this._changeDetectorRef.detectChanges();
            }
            else {
                oDimension_data.CssClass += " bg-chartBackgroundColor ";
                this._changeDetectorRef.detectChanges();
            }
            if (this.oDialog_input.properties.oChosen_Dimension) {
                if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID) {
                    oDimension_data.CssClass += " border-2 border-primary ";
                    this._changeDetectorRef.detectChanges();
                }
            }
            return oDimension_data;
        }).sort((a, b) => a.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS - b.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS);
        if (!this.oDialog_input.properties.oChosen_Dimension) {
            this.oDialog_input.properties.oChosen_Dimension = this.oDialog_input.properties.oList_Dimension_data[0].LEVEL_DIMENSION_WITH_STATUS.DIMENSION;
            let oDimension_data = this.oDialog_input.properties.oList_Dimension_data.find(_Dimension_data => _Dimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID);
            this.oDialog_input.properties.oList_Dimension_data[this.oDialog_input.properties.oList_Dimension_data.indexOf(oDimension_data)].CssClass += "border-2 border-primary ";
            this.Get_Kpi_Data(this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID);
            this._changeDetectorRef.detectChanges();
            this.oDialog_input.properties.oList_Dimension_data.forEach(oDimension_Data => {
                if (oDimension_Data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID && !oDimension_Data.CssClass.includes('border-2 border-primary')) {
                    oDimension_Data.CssClass += ' border-2 border-primary ';
                    this._changeDetectorRef.detectChanges();
                }
                else {
                    oDimension_Data.CssClass = oDimension_Data.CssClass.replace('border-2 border-primary', ' ').trim();
                    this._changeDetectorRef.detectChanges();
                }
            })
        }
        this.oDialog_input.properties.isIndexValuesLoaded = true;
    }

    Get_Kpi_Data(dimension_ID: number, isRefresh = false): Promise<Boolean> {
        return new Promise(resolve => {
            switch (this.oDialog_input.properties.oEnum_Map_View) {
                case Enum_Map_view.area:
                    let oParams_Get_Area_Kpi_Data = new Params_Get_Area_Kpi_Dialog_Data();
                    var setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Level Modal");
                    var oList_KPI_chart_configuration_Level_Modal = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
                    var List_District_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.find(oOrganization_Data_Source_Kpi_ID => oOrganization_Data_Source_Kpi_ID.LEVEL_ID == this.upper_level_id)?.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                    if (List_District_Organization_data_source_kpi) {
                        List_District_Organization_data_source_kpi = List_District_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Level_Modal.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
                        oParams_Get_Area_Kpi_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = List_District_Organization_data_source_kpi.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    }
                    var List_Area_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.find(oOrganization_Data_Source_Kpi_ID => oOrganization_Data_Source_Kpi_ID.LEVEL_ID == this.level_id)?.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                    if (List_Area_Organization_data_source_kpi) {
                        List_Area_Organization_data_source_kpi = List_Area_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Level_Modal.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
                        oParams_Get_Area_Kpi_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = List_Area_Organization_data_source_kpi.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    }
                    oParams_Get_Area_Kpi_Data.DIMENSION_ID = dimension_ID
                    oParams_Get_Area_Kpi_Data.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
                    oParams_Get_Area_Kpi_Data.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
                    oParams_Get_Area_Kpi_Data.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
                    oParams_Get_Area_Kpi_Data.AREA_ID = this.oDialog_input.properties.oClicked_Level_Location.ID;
                    oParams_Get_Area_Kpi_Data.DISTRICT_ID = this.oDialog_input.properties.level_location.DISTRICT_ID;
                    if (!this.oDialog_input.properties.oList_Area_Kpi_Data || this.oDialog_input.properties.oList_Area_Kpi_Data?.length <= 0 || isRefresh) {
                        this.MapService.Get_Area_Kpi_Data(oParams_Get_Area_Kpi_Data).then(result => {
                            if (result && result.length > 0) {
                                this.oDialog_input.properties.oList_Area_Kpi_Data = result;
                                this.oDialog_input.properties.oList_Kpi_data = [];
                                this.isDimensionsHidden = false;
                                this.Fill_Chart_Data();
                            }
                            else {
                                this.oDialog_input.properties.oList_Kpi_data = [];
                                this.isChartsLoaded = true;
                                this.isDimensionsHidden = true;
                            }
                        })
                    }
                    else {
                        this.Fill_Chart_Data();
                    }
                    resolve(true);
                    break;
                case Enum_Map_view.site:
                    let oParams_Get_Site_Kpi_Data = new Params_Get_Site_Kpi_Dialog_Data();
                    var setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "Level Modal");
                    var oList_KPI_chart_configuration_Level_Modal = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == setup_id);
                    var oDistrict_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.find(oOrganization_Data_Source_Kpi_By_Level_ID => oOrganization_Data_Source_Kpi_By_Level_ID.LEVEL_ID == this.grandfather_level_id);
                    if (oDistrict_Organization_data_source_kpi) {
                        var oList_District_Organization_data_source_kpi_simple = oDistrict_Organization_data_source_kpi.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                        oList_District_Organization_data_source_kpi_simple = oList_District_Organization_data_source_kpi_simple.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Level_Modal.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
                        oParams_Get_Site_Kpi_Data.LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oList_District_Organization_data_source_kpi_simple.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    }
                    var oArea_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.find(oOrganization_Data_Source_Kpi_By_Level_ID => oOrganization_Data_Source_Kpi_By_Level_ID.LEVEL_ID == this.upper_level_id);
                    if (oArea_Organization_data_source_kpi) {
                        var oList_Area_Organization_data_source_kpi_simple = oArea_Organization_data_source_kpi.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                        oList_Area_Organization_data_source_kpi_simple = oList_Area_Organization_data_source_kpi_simple.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Level_Modal.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
                        oParams_Get_Site_Kpi_Data.LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oList_Area_Organization_data_source_kpi_simple.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    }

                    var oSite_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE.find(oOrganization_Data_Source_Kpi_By_Level_ID => oOrganization_Data_Source_Kpi_By_Level_ID.LEVEL_ID == this.level_id);
                    if (oSite_Organization_data_source_kpi) {
                        var oList_Site_Organization_data_source_kpi_simple = oSite_Organization_data_source_kpi.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                        oList_Site_Organization_data_source_kpi_simple = oList_Site_Organization_data_source_kpi_simple.filter(oOrganization_data_source_kpi => oList_KPI_chart_configuration_Level_Modal.some(oKPI_chart_configuration => oKPI_chart_configuration.KPI_ID == oOrganization_data_source_kpi.KPI_ID));
                        oParams_Get_Site_Kpi_Data.LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID = oList_Site_Organization_data_source_kpi_simple.map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    }
                    oParams_Get_Site_Kpi_Data.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
                    oParams_Get_Site_Kpi_Data.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
                    oParams_Get_Site_Kpi_Data.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
                    oParams_Get_Site_Kpi_Data.DIMENSION_ID = dimension_ID;
                    oParams_Get_Site_Kpi_Data.SITE_ID = this.oDialog_input.properties.oClicked_Level_Location.SITE_ID;
                    oParams_Get_Site_Kpi_Data.AREA_ID = this.oDialog_input.properties.level_location.AREA_ID;
                    oParams_Get_Site_Kpi_Data.DISTRICT_ID = this.oDialog_input.properties.level_location.DISTRICT_ID;
                    if (!this.oDialog_input.properties.oList_Site_Kpi_Data || this.oDialog_input.properties.oList_Site_Kpi_Data?.length <= 0 || isRefresh) {
                        this.MapService.Get_Site_Kpi_Data(oParams_Get_Site_Kpi_Data).then(result => {
                            if (result && result.length > 0) {
                                this.oDialog_input.properties.oList_Site_Kpi_Data = result;
                                this.oDialog_input.properties.oList_Kpi_data = [];
                                this.isDimensionsHidden = false;
                                this.Fill_Chart_Data();
                            }
                            else {
                                this.oDialog_input.properties.oList_Kpi_data = [];
                                this.isChartsLoaded = true;
                                this.isDimensionsHidden = true;
                            }
                        })
                    }
                    else {
                        this.Fill_Chart_Data();
                    }
                    resolve(true);
                    break;
            }
        })
    }

    Fill_Chart_Data() {
        if (this.oDialog_input.properties.oList_Kpi_data != null && this.oDialog_input.properties.oList_Kpi_data.length > 0) {
            this.oDialog_input.properties.oList_Kpi_data = [];
        }
        switch (this.oDialog_input.properties.oEnum_Map_View) {
            case Enum_Map_view.area:
                this.oDialog_input.properties.oList_Kpi_chart_configuration.forEach(oKpi_chart_configuration => {
                    const oKpi_data = new Kpi_data();
                    const oArea_Kpi_data = this.oDialog_input.properties.oList_Area_Kpi_Data.find(oArea_Kpi_data => oKpi_chart_configuration.KPI_ID == oArea_Kpi_data.KPI_ID);

                    if (oArea_Kpi_data) {
                        oKpi_data.Kpi_chart_configuration = oKpi_chart_configuration;
                        oKpi_data.List_Action_Button = [];
                        if (oKpi_chart_configuration.LIST_SETTING.length > 1) {
                            oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "mat_outline:legend_toggle" });
                        }
                        if (oKpi_chart_configuration.LIST_ACTION_BUTTON && oKpi_chart_configuration.LIST_ACTION_BUTTON.length > 0) {
                            oKpi_chart_configuration.LIST_ACTION_BUTTON.forEach(oAction_button => {
                                oKpi_data.List_Action_Button.push(oAction_button);
                            })

                        }
                        oKpi_data.ChartConfiguration = JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;

                        let titleText = '';
                        if (oArea_Kpi_data.TITLE.toLowerCase().includes("from")) {
                            const fromIndex = oArea_Kpi_data.TITLE.toLowerCase().indexOf("from");
                            const tillIndex = oArea_Kpi_data.TITLE.toLowerCase().indexOf("till");
                            if (fromIndex >= 0 && tillIndex >= 0) {
                                titleText = oArea_Kpi_data.TITLE.substring(0, fromIndex).trim();
                                const fromDate = oArea_Kpi_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                                const toDate = oArea_Kpi_data.TITLE.substring(tillIndex + 4).trim();
                                oKpi_data.From_Date = fromDate;
                                oKpi_data.To_Date = toDate;
                            }
                        }
                        else {
                            titleText = oArea_Kpi_data.TITLE;
                        }
                        oKpi_data.CHART_TITLE = titleText;
                        if (titleText.toLowerCase().includes("dwell time")) {
                            oArea_Kpi_data.KPI_DATA.LIST_LABEL.forEach(label => {
                                this.List_Checked_Buttons.push(true)
                            });
                            this.original_dwell_time_labels = oArea_Kpi_data.KPI_DATA.LIST_LABEL;

                        }
                        if (oArea_Kpi_data.KPI_DATA && oArea_Kpi_data.KPI_DATA.LIST_DATASET?.length > 0 && oArea_Kpi_data.KPI_DATA.LIST_LABEL.length > 0) {
                            oKpi_data.isDataAvailable = true;
                            if (oKpi_data.ChartConfiguration.type != "treemap") {
                                for (let index = 0; index < oArea_Kpi_data.KPI_DATA.LIST_DATASET.length; index++) {
                                    let color: string;
                                    if (oArea_Kpi_data.TITLE != "Businesses Vacancy") {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oArea_Kpi_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oArea_Kpi_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        }
                                    }
                                    else {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                                        }
                                    }
                                    oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oArea_Kpi_data.KPI_DATA.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                    oKpi_data.ChartConfiguration.data.datasets[index].data = oArea_Kpi_data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT;
                                }
                                oKpi_data.ChartConfiguration.data.labels = oArea_Kpi_data.KPI_DATA.LIST_LABEL;
                            }
                            else {
                                var Area_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area");
                                let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Area_Setup_ID).COLOR;
                                if (!color) {
                                    color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Area_Setup_ID).COLOR;
                                }
                                oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oArea_Kpi_data.KPI_DATA.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oArea_Kpi_data.KPI_DATA.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                    return {
                                        value: point,
                                        title: oArea_Kpi_data.KPI_DATA.LIST_LABEL[i]
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

                        if (!oKpi_data.isDataAvailable) {
                            oKpi_data.isButtonClickable = false;
                        }
                        oArea_Kpi_data.KPI_DATA?.LIST_DATASET?.forEach(dataset => {
                            if (dataset?.LIST_POINT?.some(point => point != 0)) {
                                oKpi_data.isButtonClickable = true;
                            }
                        });
                        oKpi_data.ChartConfiguration.options.plugins.title.display = false;
                        this.oDialog_input.properties.oList_Kpi_data.push(oKpi_data);
                    }
                })
                break;
            case Enum_Map_view.site:
                this.oDialog_input.properties.oList_Kpi_chart_configuration.forEach(oKpi_chart_configuration => {
                    const oKpi_data = new Kpi_data();
                    const oSite_Kpi_data = this.oDialog_input.properties.oList_Site_Kpi_Data.find(oSite_Kpi_data => oKpi_chart_configuration.KPI_ID == oSite_Kpi_data.KPI_ID);
                    if (oSite_Kpi_data) {
                        oKpi_data.Kpi_chart_configuration = oKpi_chart_configuration;
                        oKpi_data.List_Action_Button = [];
                        if (oKpi_chart_configuration.LIST_SETTING.length > 1) {
                            oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "mat_outline:legend_toggle" });
                        }
                        if (oKpi_chart_configuration.LIST_ACTION_BUTTON && oKpi_chart_configuration.LIST_ACTION_BUTTON.length > 0) {
                            oKpi_chart_configuration.LIST_ACTION_BUTTON.forEach(oAction_button => {
                                oKpi_data.List_Action_Button.push(oAction_button);
                            })
                        }
                        oKpi_data.ChartConfiguration = JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;
                        let titleText = '';
                        if (oSite_Kpi_data.TITLE.toLowerCase().includes("from")) {
                            const fromIndex = oSite_Kpi_data.TITLE.toLowerCase().indexOf("from");
                            const tillIndex = oSite_Kpi_data.TITLE.toLowerCase().indexOf("till");
                            if (fromIndex >= 0 && tillIndex >= 0) {
                                titleText = oSite_Kpi_data.TITLE.substring(0, fromIndex).trim();
                                const fromDate = oSite_Kpi_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                                const toDate = oSite_Kpi_data.TITLE.substring(tillIndex + 4).trim();
                                oKpi_data.From_Date = fromDate;
                                oKpi_data.To_Date = toDate;
                            }
                        }
                        else {
                            titleText = oSite_Kpi_data.TITLE;
                        }
                        oKpi_data.CHART_TITLE = titleText;
                        if (titleText.toLowerCase().includes("dwell time")) {
                            oSite_Kpi_data.KPI_DATA.LIST_LABEL.forEach(label => {
                                this.List_Checked_Buttons.push(true)
                            });
                            this.original_dwell_time_labels = oSite_Kpi_data.KPI_DATA.LIST_LABEL;

                        }

                        if (oSite_Kpi_data.KPI_DATA && oSite_Kpi_data.KPI_DATA.LIST_DATASET?.length > 0 && oSite_Kpi_data.KPI_DATA?.LIST_LABEL.length > 0) {
                            oKpi_data.isDataAvailable = true;
                            if (oKpi_data.ChartConfiguration.type != "treemap") {
                                for (let index = 0; index < oSite_Kpi_data.KPI_DATA.LIST_DATASET.length; index++) {
                                    let color: string;
                                    if (oSite_Kpi_data.TITLE != "Businesses Vacancy") {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oSite_Kpi_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oSite_Kpi_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        }
                                    }
                                    else {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                                        }
                                    }
                                    oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oSite_Kpi_data.KPI_DATA.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                    oKpi_data.ChartConfiguration.data.datasets[index].data = oSite_Kpi_data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT;
                                }
                                oKpi_data.ChartConfiguration.data.labels = oSite_Kpi_data.KPI_DATA.LIST_LABEL;
                            }
                            else {
                                var Site_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
                                let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID).COLOR;
                                if (!color) {
                                    color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID).COLOR;
                                }
                                oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oSite_Kpi_data.KPI_DATA.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oSite_Kpi_data.KPI_DATA.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                    return {
                                        value: point,
                                        title: oSite_Kpi_data.KPI_DATA.LIST_LABEL[i]
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
                        if (!oKpi_data.isDataAvailable) {
                            oKpi_data.isButtonClickable = false;
                        }
                        oSite_Kpi_data.KPI_DATA?.LIST_DATASET?.forEach(dataset => {
                            if (dataset?.LIST_POINT?.some(point => point != 0)) {
                                oKpi_data.isButtonClickable = true;
                            }
                        });
                        oKpi_data.ChartConfiguration.data.labels = oSite_Kpi_data.KPI_DATA.LIST_LABEL;
                        oKpi_data.ChartConfiguration.options.plugins.title.display = false;
                        this.oDialog_input.properties.oList_Kpi_data.push(oKpi_data);
                    }
                })
                break;
        }
        this.updateCharts();
        this.isChartsLoaded = true;
        this.isChartsLoadedChange.emit(this.isChartsLoaded);
    };

    Toggle_Chart_Configuration(i_Kpi_Data: Kpi_data) {
        this.oDialog_input.properties.chart_index++;
        let oKpi_Data = this.oDialog_input.properties.oList_Kpi_data[this.oDialog_input.properties.oList_Kpi_data.indexOf(i_Kpi_Data)];
        if (this.oDialog_input.properties.chart_index == oKpi_Data.Kpi_chart_configuration.LIST_SETTING.length) {
            this.oDialog_input.properties.chart_index = 0;
        }

        oKpi_Data.ChartConfiguration = JSON.parse(oKpi_Data.Kpi_chart_configuration.LIST_SETTING[this.oDialog_input.properties.chart_index].CHART_SETTINGS) as ChartConfiguration;
        this.Toggle_Chart_Setting(oKpi_Data, this.oDialog_input.properties.chart_index);
    }

    Toggle_Chart_Setting(i_Kpi_Data: Kpi_data, configuration_index: number) {
        let kpi_data_index = this.oDialog_input.properties.oList_Kpi_data.indexOf(i_Kpi_Data);
        let oKpi_Data: Area_Kpi_Dialog_Data | Site_Kpi_Dialog_Data;
        if (this.oDialog_input.properties.oEnum_Map_View == Enum_Map_view.area) {
            oKpi_Data = this.oDialog_input.properties.oList_Area_Kpi_Data.find(_Area_Kpi_data => _Area_Kpi_data.KPI_ID == i_Kpi_Data.Kpi_chart_configuration.KPI_ID);
        }
        else if (this.oDialog_input.properties.oEnum_Map_View == Enum_Map_view.site) {
            oKpi_Data = this.oDialog_input.properties.oList_Site_Kpi_Data.find(_Site_Kpi_data => _Site_Kpi_data.KPI_ID == i_Kpi_Data.Kpi_chart_configuration.KPI_ID);
        }
        if (configuration_index != 0) {
            let data_points: number[] = [];
            let data_labels: string[] = [];

            for (let index = 0; index < oKpi_Data.KPI_DATA.LIST_DATASET.length; index++) {
                data_points.push(oKpi_Data.KPI_DATA.LIST_DATASET[index].LIST_POINT.reduce((total, current) => total + current, 0));
                data_labels.push(oKpi_Data.KPI_DATA.LIST_DATASET[index].LABEL);
            }

            i_Kpi_Data.ChartConfiguration.data.labels = data_labels;
            i_Kpi_Data.ChartConfiguration.data.datasets = [];
            i_Kpi_Data.ChartConfiguration.data.datasets[0] = { data: data_points };
        }
        else {
            for (let index = 0; index < oKpi_Data.KPI_DATA.LIST_DATASET.length; index++) {
                let color: string;
                if (oKpi_Data.TITLE != "Businesses Vacancy") {
                    color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oKpi_Data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                    if (!color) {
                        color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oKpi_Data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                    }
                }
                else {
                    color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                    if (!color) {
                        color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                    }
                }
                i_Kpi_Data.ChartConfiguration.data.datasets[index] = (JSON.parse(i_Kpi_Data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oKpi_Data.KPI_DATA.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                i_Kpi_Data.ChartConfiguration.data.datasets[index].data = oKpi_Data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT;
            }
            i_Kpi_Data.ChartConfiguration.data.labels = oKpi_Data.KPI_DATA.LIST_LABEL;

        }
        this.oDialog_input.properties.oList_Kpi_data[kpi_data_index] = cloneDeep(i_Kpi_Data);
    }

    Toggle_Functionality(action_button: any) {
        action_button.IS_CHECKED = !action_button.IS_CHECKED;
        if (!this.oDialog_input.properties.oList_Action_Button) {
            this.oDialog_input.properties.oList_Action_Button = [];
        }
        let index = this.oDialog_input.properties.oList_Action_Button.findIndex(oAction_button => oAction_button.FUNCTIONALITY == action_button.FUNCTIONALITY);
        if (index != -1) {
            this.oDialog_input.properties.oList_Action_Button[index] = action_button;
        }
        else {
            this.oDialog_input.properties.oList_Action_Button.push(action_button);
        }
        this.MapService.oToggle_Action_Button_Subject.next({ Action_Button: action_button, level_id: this.level_id, upper_level_id: this.upper_level_id, view_type: this.view_type });

        let function_name = action_button.FUNCTIONALITY.replace(/ /g, "_");
        this[function_name]();
    }

    Toggle_Visitor_Origins() {
        this.MapService.oToggle_Visitor_Origins_Subject.next({ level_id: this.level_id, coordinates: this.coordinates, data_level_setup_id: this.oDialog_input.properties.Data_Level_Setup_ID });
    }

    Toggle_Visitor_Heatmap() {
        this.MapService.oToggle_Visitor_Heatmap_Subject.next({ level_id: this.level_id, upper_level_id: this.upper_level_id, view_type: this.view_type });
    }

    Toggle_Businesses_Pins() {
        this.MapService.oToggle_Business_Pins_Subject.next({ level_id: this.level_id, upper_level_id: this.upper_level_id, view_type: this.view_type });
    }

    Toggle_Businesses_Heatmap() {
        this.MapService.oToggle_Business_Heatmap_Subject.next({ level_id: this.level_id, upper_level_id: this.upper_level_id, view_type: this.view_type });
    }

    getColor(ctx, data, i_Color: string = '#002439') {
        if (ctx.type !== 'data') {
            return 'transparent';
        }
        const max = Math.max(...data);
        const min = Math.min(...data);
        const range = Math.log(max) - Math.log(min);
        const value = ctx.raw.v;
        let alpha = 1 - 0.9 * (Math.log(max) - Math.log(value)) / range;
        return color(i_Color)
            .alpha(alpha)
            .rgbString();
    }

    changeKpiDimension(i_Dimension: Dimension) {
        if (this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID != i_Dimension.DIMENSION_ID || !this.isChartsLoaded) {
            this.isChartsLoaded = false;
            this.isChartsLoadedChange.emit(this.isChartsLoaded);
            this.oDialog_input.properties.oChosen_Dimension = i_Dimension;
            this.oDialog_input.properties.oList_Dimension_data.forEach(oDimension_Data => {
                if (oDimension_Data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID == this.oDialog_input.properties.oChosen_Dimension.DIMENSION_ID && !oDimension_Data.CssClass.includes('border-2 border-primary')) {
                    oDimension_Data.CssClass += ' border-2 border-primary ';
                    this._changeDetectorRef.detectChanges();
                }
                else {
                    oDimension_Data.CssClass = oDimension_Data.CssClass.replace('border-2 border-primary', ' ').trim();
                    this._changeDetectorRef.detectChanges();
                }
            })
            this.Get_Kpi_Data(i_Dimension.DIMENSION_ID, true);
        }
    }

    removeFirstWord(WORD: string) {
        return WORD.substring(WORD.indexOf(" ") + 1);
    }

    updateCharts() {
        this.oList_Chart?.forEach(chart => {
            chart?.update();
            chart?.render();
        });
    }

    updateDwellTime(i_Kpi_data: Kpi_data) {
        let chart = this.oList_Chart.find(chart => chart.options.plugins.title.text == i_Kpi_data.CHART_TITLE)
        if (chart) {
            switch (this.oDialog_input.properties.oEnum_Map_View) {
                case Enum_Map_view.area:
                    let oArea_Kpi_Data = this.oDialog_input.properties.oList_Area_Kpi_Data.find(_Area_Kpi_Data => _Area_Kpi_Data.KPI_ID == i_Kpi_data.Kpi_chart_configuration.KPI_ID);
                    for (let index = 0; index < oArea_Kpi_Data.KPI_DATA.LIST_DATASET.length; index++) {
                        i_Kpi_data.ChartConfiguration.data.datasets[index].data = oArea_Kpi_Data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT.filter((_, i) => this.List_Checked_Buttons[i]);
                    }
                    i_Kpi_data.ChartConfiguration.data.labels = oArea_Kpi_Data.KPI_DATA.LIST_LABEL.filter((_, i) => this.List_Checked_Buttons[i]);
                    break;
                case Enum_Map_view.site:
                    let oSite_Kpi_Data = this.oDialog_input.properties.oList_Site_Kpi_Data.find(_Site_Kpi_Data => _Site_Kpi_Data.KPI_ID == i_Kpi_data.Kpi_chart_configuration.KPI_ID);
                    for (let index = 0; index < oSite_Kpi_Data.KPI_DATA.LIST_DATASET.length; index++) {
                        i_Kpi_data.ChartConfiguration.data.datasets[index].data = oSite_Kpi_Data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT.filter((_, i) => this.List_Checked_Buttons[i]);
                    }
                    i_Kpi_data.ChartConfiguration.data.labels = oSite_Kpi_Data.KPI_DATA.LIST_LABEL.filter((_, i) => this.List_Checked_Buttons[i]);
                    break;
            }
            chart.update();
            chart.render();
        }
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