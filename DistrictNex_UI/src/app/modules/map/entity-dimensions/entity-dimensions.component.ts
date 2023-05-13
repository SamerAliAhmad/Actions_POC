import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnDestroy, OnInit, Output } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Dimension_data } from 'app/core/Models/models';
import { Dimension_Index_With_Simple_Upper_Level, Dimension_chart_configuration, Dimension_index, Enum_Dimension_Status, Params_Get_Dimension_Index_With_Simple_Upper_Level, Upper_Level } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import { cloneDeep } from 'lodash';
import { Subject, takeUntil } from 'rxjs';
import { ChartModalComponent } from '../chart-modal/chart-modal.component';
import { Entity_Dialog_input, MapService } from '../map.service';
import { CommonService } from './../../../core/Services/common.service';

@Component({
    selector: 'entity-dimensions',
    templateUrl: './entity-dimensions.component.html',
    styleUrls: ['./entity-dimensions.component.scss']
})

export class EntityDimensionsComponent implements OnInit, OnDestroy {

    Enum_Dimension_Status = Enum_Dimension_Status;

    oList_Dimension_data: Dimension_data[];
    oList_Dimension_chart_configuration: Dimension_chart_configuration[];

    @Input() oUpper_Level: Upper_Level;
    @Input() oEntity_Dialog: Entity_Dialog_input;

    @Output() isChartsLoadedChange = new EventEmitter<boolean>();

    isChartsLoaded = false;
    data_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("data level", "entity");

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private dialog: MatDialog,
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        public TimezoneService: TimezoneService,
    ) {
        let setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend position", "building basic info");
        this.oList_Dimension_chart_configuration = this.CmSvc.oList_Dimension_chart_configuration.filter(oDimension_chart_configuration => oDimension_chart_configuration.POSITION_SETUP_ID == setup_id);
    }

    ngOnInit() {
        this.updateData();
        this.MapService.oApply_Filter_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.updateData(true);
        });
    }

    updateData(isRefresh = false) {
        if (!this.oEntity_Dialog.oList_Dimension_data || this.oEntity_Dialog.oList_Dimension_data?.length == 0 || isRefresh) {
            this.oList_Dimension_data = [];
            let oList_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(level_dimension_with_status => level_dimension_with_status.DATA_LEVEL_SETUP_ID == this.data_level_setup_id && level_dimension_with_status.LEVEL_ID_LIST.includes(this.oEntity_Dialog.ENTITY.ENTITY_ID));
            this.Get_dimension_index_with_simple_upper_level().then(oDimension_Index_With_Simple_Upper_Level => {
                oList_Level_Dimension_With_Status.forEach(level_dimension_with_status => {
                    const oDimension_With_Status = level_dimension_with_status;
                    const oDimension_chart_configuration = this.oList_Dimension_chart_configuration.find(_dimension_chart_configuration => _dimension_chart_configuration.CHART_ORDER == level_dimension_with_status.DIMENSION.DIMENSION_ORDER);
                    const oChart_settings = (JSON.parse(oDimension_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration);
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
                        oDimension_data.CssClass += " cursor-pointer";
                    } else if (oDimension_data.LEVEL_DIMENSION_WITH_STATUS.ENUM_DIMENSION_STATUS == Enum_Dimension_Status.DISABLED) {
                        oChart_settings.options['plugins']['tooltip'] = null;
                        oDimension_data.CssClass += "opacity-50 ";
                    } else {
                        oDimension_data.CssClass += " bg-gray-900 cursor-auto ";
                    }
                    let oList_Site_Dimension_index: Dimension_index[] = oDimension_Index_With_Simple_Upper_Level.LIST_UPPER_LEVEL_DIMENSION_INDEX.sort((a, b) => {
                        if (a.RECORD_DATE > b.RECORD_DATE) {
                            return 1;
                        }
                        if (a.RECORD_DATE < b.RECORD_DATE) {
                            return -1;
                        }
                        return 0;
                    });
                    oList_Site_Dimension_index = oList_Site_Dimension_index.filter(_Dimension_index => _Dimension_index.DIMENSION_METADATA.LEVEL_ID == this.oEntity_Dialog.ENTITY.SITE_ID && _Dimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID);
                    if (oDimension_data.Enum_Dimension_Status == Enum_Dimension_Status.HIDDEN) {
                        oList_Site_Dimension_index = [];
                    }
                    var Site_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
                    (this.CmSvc.oUser_Details.Organization)
                    let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID).COLOR;
                    if (!color) {
                        this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID).COLOR
                    }
                    const oSiteSeriesSettings = (JSON.parse(oDimension_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oDimension_Index_With_Simple_Upper_Level.FATHER_UPPER_LEVEL.NAME)) as ChartConfiguration['data']['datasets'][0]);
                    oSiteSeriesSettings.data = oList_Site_Dimension_index.map(datum => datum.VALUE);
                    oDimension_data.ChartConfiguration.data.datasets.push(oSiteSeriesSettings);

                    let oList_Entity_Dimension_index: Dimension_index[] = oDimension_Index_With_Simple_Upper_Level.LIST_SELECTED_LEVEL_DIMENSION_INDEX.sort((a, b) => {
                        if (a.RECORD_DATE > b.RECORD_DATE) {
                            return 1;
                        }
                        if (a.RECORD_DATE < b.RECORD_DATE) {
                            return -1;
                        }
                        return 0;
                    });
                    oList_Entity_Dimension_index = oList_Entity_Dimension_index.filter(_Dimension_index => _Dimension_index.DIMENSION_METADATA.LEVEL_ID == this.oEntity_Dialog.ENTITY.ENTITY_ID && _Dimension_index.DIMENSION_METADATA.DIMENSION_ID == oDimension_data.LEVEL_DIMENSION_WITH_STATUS.DIMENSION.DIMENSION_ID);
                    if (oDimension_data.Enum_Dimension_Status == Enum_Dimension_Status.HIDDEN) {
                        oList_Entity_Dimension_index = [];
                    }
                    var Entity_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity");
                    color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Entity_Setup_ID).COLOR;
                    if (!color) {
                        this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Entity_Setup_ID).COLOR
                    }
                    const oEntitySeriesSettings = (JSON.parse(oDimension_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, this.oEntity_Dialog.ENTITY.NAME)) as ChartConfiguration['data']['datasets'][0]);
                    oEntitySeriesSettings.data = oList_Entity_Dimension_index.map(datum => datum.VALUE);
                    oDimension_data.ChartConfiguration.data.datasets.push(oEntitySeriesSettings);
                    oDimension_data.ChartConfiguration.data.labels = oList_Entity_Dimension_index.map(datum => this.DatePipe.transform(datum.RECORD_DATE, null, this.TimezoneService.oCurrent_Timezone_Offset));
                    oDimension_data.ChartConfiguration.options.plugins.title.display = false;
                    this.oList_Dimension_data.push(oDimension_data);
                });
                this.oList_Dimension_data = this.oList_Dimension_data.sort((a, b) => a.Enum_Dimension_Status - b.Enum_Dimension_Status);
                this.oEntity_Dialog.oList_Dimension_data = cloneDeep(this.oList_Dimension_data);
                this.isChartsLoaded = true;
                this.isChartsLoadedChange.emit(this.isChartsLoaded);
            })
        }
        else {
            this.Get_dimension_index_with_simple_upper_level();
            this.oList_Dimension_data = this.oEntity_Dialog.oList_Dimension_data;
            this.isChartsLoaded = true;
            this.isChartsLoadedChange.emit(this.isChartsLoaded);
        }

    }

    Get_dimension_index_with_simple_upper_level(): Promise<Dimension_Index_With_Simple_Upper_Level> {
        return new Promise(resolve => {
            let upper_level_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
            let oParams_Get_dimension_index_with_simple_upper_level = new Params_Get_Dimension_Index_With_Simple_Upper_Level();
            oParams_Get_dimension_index_with_simple_upper_level.ENUM_TIMESPAN = this.MapService.oEnum_Timespan_Filter;
            oParams_Get_dimension_index_with_simple_upper_level.START_DATE = this.MapService.oStart_Date_Filter?.toISOString();
            oParams_Get_dimension_index_with_simple_upper_level.END_DATE = this.MapService.oEnd_Date_Filter?.toISOString();
            oParams_Get_dimension_index_with_simple_upper_level.UPPER_LEVEL_ID = this.oEntity_Dialog.ENTITY.SITE_ID;
            oParams_Get_dimension_index_with_simple_upper_level.SELECTED_DATA_LEVEL_SETUP_ID = this.data_level_setup_id;
            oParams_Get_dimension_index_with_simple_upper_level.SELECTED_LEVEL_ID = this.oEntity_Dialog.ENTITY.ENTITY_ID;
            let oList_Filtered_Selected_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension_With_Status =>
                oLevel_Dimension_With_Status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_Dimension_With_Status.DATA_LEVEL_SETUP_ID == oParams_Get_dimension_index_with_simple_upper_level.SELECTED_DATA_LEVEL_SETUP_ID && oLevel_Dimension_With_Status.LEVEL_ID_LIST.includes(this.oEntity_Dialog.ENTITY.ENTITY_ID));
            oParams_Get_dimension_index_with_simple_upper_level.LIST_SELECTED_DIMENSION_ID = oList_Filtered_Selected_Level_Dimension_With_Status.map(oLevel_Dimension_With_Status => oLevel_Dimension_With_Status.DIMENSION.DIMENSION_ID);
            let oList_Filtered_Upper_Level_Dimension_With_Status = this.CmSvc.oUser_Accessible_Level_List.LIST_LEVEL_DIMENSION_WITH_STATUS.filter(oLevel_Dimension_With_Status =>
                oLevel_Dimension_With_Status.ENUM_DIMENSION_STATUS != Enum_Dimension_Status.HIDDEN && oLevel_Dimension_With_Status.DATA_LEVEL_SETUP_ID == upper_level_setup_id && oLevel_Dimension_With_Status.LEVEL_ID_LIST.includes(this.oEntity_Dialog.ENTITY.SITE_ID));
            oParams_Get_dimension_index_with_simple_upper_level.LIST_UPPER_DIMENSION_ID = oList_Filtered_Upper_Level_Dimension_With_Status.map(oLevel_Dimension_With_Status => oLevel_Dimension_With_Status.DIMENSION.DIMENSION_ID);

            this.MapService.Get_dimension_index_with_simple_upper_level(oParams_Get_dimension_index_with_simple_upper_level).then(result => {
                this.MapService.oUpper_Level = result.FATHER_UPPER_LEVEL;
                this.CmSvc.oList_Dimension_Index = result.LIST_UPPER_LEVEL_DIMENSION_INDEX;
                this.MapService.oLocation_Changed_Subject.next({ level_location: this.oEntity_Dialog.ENTITY, List_Upper_Level_Dimension_index: [] })
                resolve(result);
            })
        })
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
