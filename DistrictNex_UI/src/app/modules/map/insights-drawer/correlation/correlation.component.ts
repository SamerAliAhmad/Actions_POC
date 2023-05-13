import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Access_Control_Object } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Comparison_Data, Correlation_method, District, Enum_Timespan, Organization_data_source_kpi, Setup, Site } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import moment from 'moment';
import { ChartModalComponent } from '../../chart-modal/chart-modal.component';
import { MapService } from '../../map.service';
import { CorrelationMethodDetailsModalComponent } from './correlation-method-details-modal/correlation-method-details-modal.component';

@Component({
    selector: 'correlation',
    templateUrl: './correlation.component.html',
    styleUrls: ['./correlation.component.scss']
})
export class CorrelationComponent implements OnInit {

    @Input() oDistrict: District;

    @Output() oToggle_Share_Button_EventEmitter = new EventEmitter<boolean>();

    isDark = false;
    isDataLoading = false;
    isSomeDataNull = false;
    isShowGeneratedData = false;

    oList_Site: Site[];
    oList_Area: Area[];
    oList_District: District[];
    oList_Selected_Site: Site[];
    oList_Selected_Area: Area[];
    oList_Selected_District: District[];
    oList_Data_access_level_setup: Setup[];
    oList_Correlation_method: Correlation_method[];
    oList_Correlated_Organization_data_source_kpi: Organization_data_source_kpi[];

    oFirst_Access_Control_Object: Access_Control_Object = new Access_Control_Object();
    oSecond_Access_Control_Object: Access_Control_Object = new Access_Control_Object();

    END_DATE: Date;
    START_DATE: Date;
    today = new Date();

    Resolution: number;
    oEnum_Timespan: number;
    oCorrelation_method_ID: number;

    oComparison_Data: Comparison_Data;
    Enum_Timespan = Enum_Timespan;

    oLineChart: ChartConfiguration;

    constructor(
        private dialog: MatDialog,
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        public TimezoneService: TimezoneService,
    ) {
        this.isDark = this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-button'));
        this.oList_Data_access_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.filter(setup => setup.VALUE == "Site" || setup.VALUE == "Area" || setup.VALUE == "District");
        this.oList_Correlated_Organization_data_source_kpi = this.CmSvc.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.HAS_CORRELATION);
        this.oLineChart = (JSON.parse(this.CmSvc.oList_Specialized_chart_configuration.find(oSpecialized_chart_configuration => oSpecialized_chart_configuration.MODULE == "Insights" && oSpecialized_chart_configuration.NAME == "Correlation").CHART_SETTINGS) as ChartConfiguration);
        this.MapService.Get_Correlation_method_By_OWNER_ID().then(result => {
            this.oList_Correlation_method = result;
        });
    }

    ngOnInit(): void {
        this.oList_District = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.filter(district => district.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Area = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.filter(area => area.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Site = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.filter(site => site.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
    }

    getObjects(i_Access_Control_Object: Access_Control_Object): any {
        switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District;
        }
        return [];
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

    getSetupValue(Data_level_setup_ID: number): string {
        return this.oList_Data_access_level_setup.find(setup => setup.SETUP_ID == Data_level_setup_ID)?.VALUE ?? "Choose Data Level First";
    }

    getXAssignableKpis() {
        if (this.oSecond_Access_Control_Object.Selected_Organization_data_source_kpi && this.oFirst_Access_Control_Object.LEVEL_ID == this.oSecond_Access_Control_Object.LEVEL_ID) {
            return this.oList_Correlated_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID != this.oSecond_Access_Control_Object.Selected_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
        }
        return this.oList_Correlated_Organization_data_source_kpi;
    }

    getYAssignableKpis() {
        if (this.oFirst_Access_Control_Object.Selected_Organization_data_source_kpi && this.oFirst_Access_Control_Object.LEVEL_ID == this.oSecond_Access_Control_Object.LEVEL_ID) {
            return this.oList_Correlated_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID != this.oFirst_Access_Control_Object.Selected_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
        }
        return this.oList_Correlated_Organization_data_source_kpi;
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

    areDatesValid(): boolean {
        if (this.START_DATE && this.END_DATE) {
            return this.getDaysBetweenDates(this.START_DATE, this.END_DATE) % this.getMinimumNumberOfDays() == 0 && this.END_DATE > this.START_DATE;
        }
        return false;
    }

    getDaysBetweenDates(date1: Date, date2: Date): number {
        const startDateMoment = moment(date1);
        const endDateMoment = moment(date2);
        return endDateMoment.diff(startDateMoment, 'days');
    }

    getResolutionWord() {
        switch (this.oEnum_Timespan) {
            case Enum_Timespan.X_DAILY_COLLECTION:
                return "Day";
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                return "Week";
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                return "Month";
        }
    }

    getMaxStartDate() {
        if (this.END_DATE) {
            return this.END_DATE > this.today ? this.today : this.END_DATE;
        }
        return this.today;
    }

    setMaxResolution() {
        let numberOfDaysDifference = Math.round(Math.abs(this.END_DATE.getTime() - this.START_DATE.getTime()) / (1000 * 3600 * 24));
        switch (this.oEnum_Timespan) {
            case Enum_Timespan.X_DAILY_COLLECTION:
                this.Resolution = numberOfDaysDifference;
                break;
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                this.Resolution = Math.round(numberOfDaysDifference / 7);
                break;
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                this.Resolution = Math.round(numberOfDaysDifference / 30);
                break;
        }
    }

    isResolutionValid() {
        if (!this.START_DATE || !this.END_DATE) {
            return true;
        }
        let isNumberValid = true;
        let numberOfDaysDifference = Math.round(Math.abs(this.END_DATE.getTime() - this.START_DATE.getTime()) / (1000 * 3600 * 24));
        switch (this.oEnum_Timespan) {
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                if (numberOfDaysDifference / 7 < this.Resolution) {
                    isNumberValid = false;
                }
                break;
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                if (numberOfDaysDifference / 30 < this.Resolution) {
                    isNumberValid = false;
                }
                break;
        }
        return isNumberValid && this.Resolution > 1;
    }

    generateCharts(correlationParamsForm: NgForm) {
        if (correlationParamsForm.invalid || !this.areDatesValid() || !this.isResolutionValid()) {
            this.CmSvc.ShowMessage("Some data is invalid");
            return;
        }
        this.isDataLoading = true;
        this.MapService.Get_Correlation({
            END_DATE: this.TimezoneService.Transform_Date_To_Current_Timezone(this.END_DATE, true)?.toISOString(),
            START_DATE: this.TimezoneService.Transform_Date_To_Current_Timezone(this.START_DATE, true)?.toISOString(),
            ENUM_TIMESPAN: this.oEnum_Timespan,
            RESOLUTION: this.Resolution,
            ORGANIZATION_ID: this.CmSvc.saved_organization_id,
            CORRELATION_METHOD_ID: this.oCorrelation_method_ID,
            First_Organization_data_source_kpi_By_Level: {
                DATA_LEVEL_SETUP_ID: this.oFirst_Access_Control_Object.DATA_LEVEL_SETUP_ID,
                LEVEL_ID: this.oFirst_Access_Control_Object.LEVEL_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID: this.oFirst_Access_Control_Object.Selected_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
            },
            Second_Organization_data_source_kpi_By_Level: {
                DATA_LEVEL_SETUP_ID: this.oSecond_Access_Control_Object.DATA_LEVEL_SETUP_ID,
                LEVEL_ID: this.oSecond_Access_Control_Object.LEVEL_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID: this.oSecond_Access_Control_Object.Selected_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
            },
        }).then(result => {
            this.isSomeDataNull = result.some(object_count_by_date => object_count_by_date.VALUE == null);
            this.oLineChart.options.plugins.tooltip = {
                callbacks: {
                    footer: (tooltipItems) => {
                        if (tooltipItems?.length > 0) {
                            if ((tooltipItems[0].raw as number) < -0.7) {
                                return 'strong negative correlation';
                            } else if ((tooltipItems[0].raw as number) < -0.3) {
                                return 'moderate negative correlation';
                            } else if ((tooltipItems[0].raw as number) < -0.1) {
                                return 'weak negative correlation';
                            } else if ((tooltipItems[0].raw as number) < 0.1) {
                                return 'no correlation';
                            } else if ((tooltipItems[0].raw as number) < 0.3) {
                                return 'weak positive correlation';
                            } else if ((tooltipItems[0].raw as number) < 0.7) {
                                return 'moderate positive correlation';
                            } else {
                                return 'strong positive correlation';
                            }
                        }
                    }
                }
            }
            this.oLineChart.data.datasets = [{
                data: result.map(kpi_value_by_date => kpi_value_by_date.VALUE),
            }];
            this.oLineChart.data.labels = result.map(kpi_value_by_date => this.DatePipe.transform(kpi_value_by_date.RECORD_DATE, null, this.TimezoneService.oCurrent_Timezone_Offset));
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

    endDateFilter = (date: Date | null): boolean => {
        if (!date || !this.START_DATE) {
            return true;
        }
        const startDateMoment = moment(this.START_DATE);
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

    Open_Correlation_Method_Details() {
        if (this.oCorrelation_method_ID) {
            this.dialog.open(CorrelationMethodDetailsModalComponent, {
                width: '500px',
                autoFocus: false,
                hasBackdrop: true,
                data: this.oList_Correlation_method.find(oCorrelation_method => oCorrelation_method.CORRELATION_METHOD_ID == this.oCorrelation_method_ID),
            });
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
}
