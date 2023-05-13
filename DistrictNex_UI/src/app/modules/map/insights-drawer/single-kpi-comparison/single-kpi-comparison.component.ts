import { DatePipe, DecimalPipe } from '@angular/common';
import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Access_Control_Object, Kpi_data } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, District, Enum_Timespan, Organization_data_source_kpi, Organization_data_source_kpi_Simple, Setup, Site, Specialized_chart_configuration } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import moment from 'moment';
import { BaseChartDirective } from 'ng2-charts';
import { ChartModalComponent } from '../../chart-modal/chart-modal.component';
import { MapService } from '../../map.service';

@Component({
    selector: 'single-kpi-comparison',
    templateUrl: './single-kpi-comparison.component.html',
    styleUrls: ['./single-kpi-comparison.component.scss']
})
export class SingleKpiComparisonComponent implements OnInit {

    @Input() oDistrict: District;

    @Output() oToggle_Share_Button_EventEmitter = new EventEmitter<boolean>();

    isDark = false;
    isDataLoading = false;
    isThresholdInput = false;
    isMinButtonPressed = false;
    isMaxButtonPressed = false;
    isShowGeneratedData = false;
    isAverageButtonPressed = false;
    isThresholdInputVisible = false;

    oList_Site: Site[];
    oList_Area: Area[];
    oList_District: District[];
    oList_Data_access_level_setup: Setup[];
    oSpecialized_chart_configuration: Specialized_chart_configuration;
    oList_Organization_data_source_kpi: Organization_data_source_kpi[];
    oList_Filtered_Organization_data_source_kpi: Organization_data_source_kpi[];

    oKpi_data = new Kpi_data();
    oAccess_Control_Object: Access_Control_Object = new Access_Control_Object();

    minValue: number;
    maxValue: number;
    avgValue: number;
    threshold: number;
    Resolution: number;
    oEnum_Timespan: number;

    oEnd_Date: Date;
    oStart_Date: Date;
    oToday_Date = new Date();

    Enum_Timespan = Enum_Timespan;
    oOrganization_data_souce_KPI: Organization_data_source_kpi;

    @ViewChild(BaseChartDirective) chart: BaseChartDirective;

    constructor(
        private dialog: MatDialog,
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        private DecimalPipe: DecimalPipe,
        public TimezoneService: TimezoneService,
    ) {
        this.isDark = this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-button'));
        this.oList_Data_access_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.filter(setup => setup.VALUE == "Site" || setup.VALUE == "Area" || setup.VALUE == "District");
        this.oList_Organization_data_source_kpi = this.CmSvc.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE || oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints" || oOrganization_data_source_kpi.Kpi.NAME == "Public Events");
        this.oSpecialized_chart_configuration = this.CmSvc.oList_Specialized_chart_configuration.find(oSpecialized_chart_configuration => oSpecialized_chart_configuration.MODULE == "Insights" && oSpecialized_chart_configuration.NAME == "Single Kpi Analysis");
        this.oKpi_data.ChartConfiguration = (JSON.parse(this.oSpecialized_chart_configuration.CHART_SETTINGS) as ChartConfiguration);
    }

    ngOnInit() {
        this.oList_District = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.filter(district => district.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Area = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.filter(area => area.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Site = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.filter(site => site.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
    }

    Filter_KPI_List() {
        let oList_Organization_data_source_kpi_Simple: Organization_data_source_kpi_Simple[] = [];
        switch (this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site"):
                oList_Organization_data_source_kpi_Simple = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == this.oAccess_Control_Object.LEVEL_ID).LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                break;
            case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area"):
                oList_Organization_data_source_kpi_Simple = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == this.oAccess_Control_Object.LEVEL_ID).LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                break;
            case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District"):
                oList_Organization_data_source_kpi_Simple = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == this.oAccess_Control_Object.LEVEL_ID).LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                break;
            default:
                break;
        }
        this.oOrganization_data_souce_KPI = null
        this.oList_Filtered_Organization_data_source_kpi = this.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_Organization_data_source_kpi_Simple.some(oOrganization_data_source_kpi_Simple => oOrganization_data_source_kpi_Simple.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID));
    }

    endDateFilter = (date: Date | null): boolean => {
        if (!date || !this.oStart_Date) {
            return true;
        }
        const startDateMoment = moment(this.oStart_Date);
        const endDateMoment = moment(date);
        const daysDifference = endDateMoment.diff(startDateMoment, 'days');
        let daysApart = 1;
        switch (this.oEnum_Timespan) {
            case Enum_Timespan.X_DAILY_COLLECTION:
                daysApart = 1;
                break;
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                daysApart = 7;
                break;
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                daysApart = 30;
                break;
        }
        return daysDifference % daysApart === 0 && endDateMoment.isAfter(startDateMoment);
    }

    getSetupValue(Data_level_setup_ID: number): string {
        return this.oList_Data_access_level_setup.find(setup => setup.SETUP_ID == Data_level_setup_ID)?.VALUE ?? "Choose Data Level First";
    }

    getDistricts(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_District?.filter(district => !(this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && this.oAccess_Control_Object.LEVEL_ID == district.DISTRICT_ID && i_Access_Control_Object.LEVEL_ID != district.DISTRICT_ID));
    }

    getAreas(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Area?.filter(area => !(this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && this.oAccess_Control_Object.LEVEL_ID == area.AREA_ID && i_Access_Control_Object.LEVEL_ID != area.AREA_ID));
    }

    getSites(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Site?.filter(site => !(this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && this.oAccess_Control_Object.LEVEL_ID == site.SITE_ID && i_Access_Control_Object.LEVEL_ID != site.SITE_ID));
    }

    getObject(i_Access_Control_Object: Access_Control_Object): any {
        switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site.find(site => site.SITE_ID == i_Access_Control_Object.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area.find(area => area.AREA_ID == i_Access_Control_Object.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District.find(district => district.DISTRICT_ID == i_Access_Control_Object.LEVEL_ID);
        }
    }

    getObjectId(Data_level_setup_ID: number, i_Object: any): number {
        switch (Data_level_setup_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return i_Object.SITE_ID;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return i_Object.AREA_ID;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return i_Object.DISTRICT_ID;
        }
    }

    getObjectName(Data_level_setup_ID: number, OBJECT_ID: number): string {
        switch (Data_level_setup_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site.find(site => site.SITE_ID == OBJECT_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area.find(area => area.AREA_ID == OBJECT_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District.find(district => district.DISTRICT_ID == OBJECT_ID).NAME;
        }
    }


    getObjects(i_Access_Control_Object: Access_Control_Object): any {
        switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.getSites(i_Access_Control_Object);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.getAreas(i_Access_Control_Object);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.getDistricts(i_Access_Control_Object);
        }
        return [];
    }

    getEnumsToDisplay() {
        return [Enum_Timespan.X_DAILY_COLLECTION, Enum_Timespan.X_WEEKLY_COLLECTION, Enum_Timespan.X_MONTHLY_COLLECTION];
    }

    getEnumCollectionValue(i_Enum_Timespan) {
        switch (i_Enum_Timespan) {
            case Enum_Timespan.X_HOURLY_COLLECTION:
                return "Hourly";
            case Enum_Timespan.X_DAILY_COLLECTION:
                return "Daily";
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                return "Weekly";
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                return "Monthly";
            case Enum_Timespan.X_QUARTERLY_COLLECTION:
                return "Quarterly";
        }
    }

    getMinimumNumberOfDays(): number {
        switch (this.oEnum_Timespan) {
            case Enum_Timespan.X_DAILY_COLLECTION:
                return 1;
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                return 7;
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                return 30;
        }
    }

    areDatesValid(): boolean {
        if (this.oStart_Date && this.oEnd_Date) {
            return this.getDaysBetweenDates(this.oStart_Date, this.oEnd_Date) % this.getMinimumNumberOfDays() == 0 && this.oEnd_Date > this.oStart_Date;
        }
        return false;
    }

    getDaysBetweenDates(date1: Date, date2: Date): number {
        const startDateMoment = moment(date1);
        const endDateMoment = moment(date2);
        return endDateMoment.diff(startDateMoment, 'days');
    }

    getMaxStartDate() {
        if (this.oEnd_Date) {
            return this.oEnd_Date > this.oToday_Date ? this.oToday_Date : this.oEnd_Date;
        }
        return this.oToday_Date;
    }

    generateCharts(correlationParamsForm: NgForm) {
        if (correlationParamsForm.invalid || !this.areDatesValid()) {
            this.CmSvc.ShowMessage("Some data is invalid");
            return;
        }
        this.isAverageButtonPressed = false;
        this.isMaxButtonPressed = false;
        this.isMinButtonPressed = false;
        this.isThresholdInputVisible = false;

        this.oKpi_data.CHART_TITLE = this.oOrganization_data_souce_KPI.Kpi.NAME;
        let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID).COLOR;
        if (!color) {
            color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID).COLOR;
        }
        this.oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(this.oSpecialized_chart_configuration.SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, '')) as ChartConfiguration['data']['datasets'][0]);

        this.isDataLoading = true;
        this.MapService.Get_Single_kpi_comparison({
            DATA_LEVEL_SETUP_ID: this.oAccess_Control_Object.DATA_LEVEL_SETUP_ID,
            LEVEL_ID: this.oAccess_Control_Object.LEVEL_ID,
            END_DATE: this.TimezoneService.Transform_Date_To_Current_Timezone(this.oEnd_Date, true)?.toISOString(),
            START_DATE: this.TimezoneService.Transform_Date_To_Current_Timezone(this.oStart_Date, true)?.toISOString(),
            ORGANIZATION_DATA_SOURCE_KPI_ID: this.oOrganization_data_souce_KPI.ORGANIZATION_DATA_SOURCE_KPI_ID,
            ENUM_TIMESPAN: this.oEnum_Timespan,
            ORGANIZATION_ID: this.CmSvc.saved_organization_id,
        }).then(result => {
            this.oKpi_data.ChartConfiguration.data.datasets[0].data = result.map(kpi_value_by_date => kpi_value_by_date.VALUE);
            this.oKpi_data.ChartConfiguration.data.labels = result.map(kpi_value_by_date => this.DatePipe.transform(kpi_value_by_date.RECORD_DATE, null, this.TimezoneService.oCurrent_Timezone_Offset));
            this.minValue = Math.min(...result.map(kpi_value_by_date => kpi_value_by_date.VALUE));
            this.maxValue = Math.max(...result.map(kpi_value_by_date => kpi_value_by_date.VALUE));
            this.avgValue = result.map(kpi_value_by_date => kpi_value_by_date.VALUE).reduce((a, b) => a + b, 0) / result.length;
            this.oKpi_data.ChartConfiguration.options.plugins.annotation = {
                annotations: {
                    average: {
                        type: 'line',
                        yMin: this.avgValue,
                        yMax: this.avgValue,
                        borderColor: 'rgb(255, 99, 132)',
                        borderWidth: 2,
                        display: this.isAverageButtonPressed,
                        label: {
                            display: true,
                            content: 'Avg: ' + this.DecimalPipe.transform(this.avgValue),
                        },
                    },
                    threshold: {
                        type: 'line',
                        yMin: this.threshold,
                        yMax: this.threshold,
                        display: this.isThresholdInput && this.isThresholdInputVisible,
                        borderColor: 'rgb(255, 99, 132)',
                        borderWidth: 2,
                        label: {
                            display: true,
                            content: 'Benchmark: ' + this.DecimalPipe.transform(this.threshold),
                        },
                    },
                    Minimum: {
                        type: 'line',
                        yMin: this.minValue,
                        yMax: this.minValue,
                        display: this.isMinButtonPressed,
                        borderColor: 'rgb(255, 99, 132)',
                        borderWidth: 2,
                        label: {
                            display: true,
                            content: 'Min: ' + this.DecimalPipe.transform(this.minValue),
                        },
                    },
                    Maximum: {
                        type: 'line',
                        yMin: this.maxValue,
                        yMax: this.maxValue,
                        display: this.isMaxButtonPressed,
                        borderColor: 'rgb(255, 99, 132)',
                        borderWidth: 2,
                        label: {
                            display: true,
                            content: 'Max: ' + this.DecimalPipe.transform(this.maxValue),
                        },
                    }
                }
            }

            this.isShowGeneratedData = true;
            this.isDataLoading = false;
            this.oToggle_Share_Button_EventEmitter.emit(true);
        }).catch(() => {
            this.isDataLoading = false;
        });
    }

    goBack() {
        this.isShowGeneratedData = false;
        this.oToggle_Share_Button_EventEmitter.emit(false);
    }

    Toggle_Threshold_Input() {
        this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['threshold'].display = this.isThresholdInput && this.isThresholdInputVisible;
        this.chart?.update();
        this.chart?.render();
    }

    Toggle_Threshold() {
        if (this.threshold > 0) {
            this.isThresholdInput = true;
            this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['threshold'].display = this.isThresholdInput && this.isThresholdInputVisible;
            this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['threshold'].yMin = this.threshold;
            this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['threshold'].yMax = this.threshold;
            this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['threshold'].label.content = 'Benchmark: ' + this.DecimalPipe.transform(this.threshold);
            this.chart?.update();
            this.chart?.render();
        }
    }

    Toggle_Min_Value() {
        this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['Minimum'].display = this.isMinButtonPressed;
        this.chart?.update();
        this.chart?.render();
    }

    Toggle_Max_Value() {
        this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['Maximum'].display = this.isMaxButtonPressed;
        this.chart?.update();
        this.chart?.render();
    }

    Toggle_Average_Value() {
        this.oKpi_data.ChartConfiguration.options.plugins.annotation.annotations['average'].display = this.isAverageButtonPressed;
        this.chart?.update();
        this.chart?.render();
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
}
