import { DatePipe } from '@angular/common';
import { ChangeDetectorRef, Component, EventEmitter, Input, Output } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Access_Control_Object, Kpi_data } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, District, Entity, Enum_Timespan, Organization_data_source_kpi, Organization_data_source_kpi_By_Level, Organization_data_source_kpi_Simple, Params_Get_Multi_kpi_comparison, Setup, Site, Specialized_chart_configuration } from 'app/core/Services/proxy.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import moment from 'moment';
import { ChartModalComponent } from '../../chart-modal/chart-modal.component';
import { MapService } from '../../map.service';

@Component({
    selector: 'multiple-kpi-comparison',
    templateUrl: './multiple-kpi-comparison.component.html',
    styleUrls: ['./multiple-kpi-comparison.component.scss']
})
export class MultipleKpiComparisonComponent {

    @Input() oDistrict: District;
    @Output() oToggle_Share_Button_EventEmitter = new EventEmitter<boolean>();

    first_unit: string = null;
    second_unit: string = null;

    oKpi_data = new Kpi_data();

    isDark = false;
    isDataLoading = false;
    isShowGeneratedData = false;

    oList_Site: Site[];
    oList_Area: Area[];
    oList_Entity: Entity[];
    oList_District: District[];
    oList_Data_access_level_setup: Setup[];
    oSpecialized_chart_configuration: Specialized_chart_configuration;
    oList_Organization_data_source_kpi: Organization_data_source_kpi[];

    oAccess_Control_Object: Access_Control_Object = new Access_Control_Object();

    oList_Access_Control_Object: Access_Control_Object[] = [new Access_Control_Object()];

    oEnum_Timespan: number;

    oEnd_Date: Date;
    oStart_Date: Date;
    oToday_Date = new Date();

    Enum_Timespan = Enum_Timespan;
    oOrganization_data_souce_KPI: Organization_data_source_kpi;

    constructor(
        private dialog: MatDialog,
        private DatePipe: DatePipe,
        private CmSvc: CommonService,
        private MapService: MapService,
        public TimezoneService: TimezoneService,
        private _changeDetectorRef: ChangeDetectorRef,
    ) {
        this.isDark = this.CmSvc.isDark(document.body.style.getPropertyValue('--smartr-button'));
        this.oList_Data_access_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.filter(setup => setup.VALUE == "Site" || setup.VALUE == "Area" || setup.VALUE == "District");
        this.oList_Organization_data_source_kpi = this.CmSvc.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.IS_TRENDLINE || oOrganization_data_source_kpi.Kpi.NAME == "Bylaw Complaints" || oOrganization_data_source_kpi.Kpi.NAME == "Public Events");
        this.oSpecialized_chart_configuration = this.CmSvc.oList_Specialized_chart_configuration.find(oSpecialized_chart_configuration => oSpecialized_chart_configuration.MODULE == "Insights" && oSpecialized_chart_configuration.NAME == "Single Kpi Analysis");
    }

    ngOnInit() {
        this.oList_District = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.filter(district => district.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Area = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.filter(area => area.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Site = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.filter(site => site.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
        this.oList_Entity = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST.filter(oEntity => oEntity.DISTRICT_ID == this.oDistrict.DISTRICT_ID);
    }

    Select_KPI(i_Access_control_object: Access_Control_Object, event) {
        let i_Organization_data_source_kpi: Organization_data_source_kpi = event.value;
        i_Access_control_object.Selected_Organization_data_source_kpi = i_Organization_data_source_kpi;
        this.selectFirstAndSecondUnits();
    }

    Check_Available_Kpi_List(i_Access_control_object: Access_Control_Object) {
        let oList_Chosen_Organization_data_source_kpi: Organization_data_source_kpi[] = [];
        let oList_Matching_Object = this.oList_Access_Control_Object.filter(oAccess_Control_Object => oAccess_Control_Object.LEVEL_ID == i_Access_control_object.LEVEL_ID && oAccess_Control_Object != i_Access_control_object);
        oList_Matching_Object.forEach(oAccess_Control_Object => {
            oList_Chosen_Organization_data_source_kpi.push(oAccess_Control_Object.Selected_Organization_data_source_kpi);
        })
        if (oList_Matching_Object && oList_Matching_Object.length > 0) {
            i_Access_control_object.List_Filtered_Organization_data_source_kpi = i_Access_control_object.List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI;
            if (oList_Chosen_Organization_data_source_kpi.length > 0) {
                oList_Chosen_Organization_data_source_kpi.forEach(oChosen_Organization_data_source_kpi => {
                    let index = i_Access_control_object.List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI.findIndex(oOrganization_data_souce_KPI => oOrganization_data_souce_KPI.KPI_ID == oChosen_Organization_data_source_kpi.KPI_ID)
                    if (index > -1) {
                        i_Access_control_object.List_Filtered_Organization_data_source_kpi.splice(index, 1);
                    }
                })
            }
        }
        else {
            i_Access_control_object.List_Filtered_Organization_data_source_kpi = i_Access_control_object.List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI;
        }
    }

    Get_Multi_Kpi_Comparison() {
        this.isDataLoading = true;
        let oParams_Get_Multi_Kpi_Comparison = new Params_Get_Multi_kpi_comparison();
        oParams_Get_Multi_Kpi_Comparison.START_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(this.oStart_Date, true)?.toISOString();
        oParams_Get_Multi_Kpi_Comparison.END_DATE = this.TimezoneService.Transform_Date_To_Current_Timezone(this.oEnd_Date, true)?.toISOString();
        oParams_Get_Multi_Kpi_Comparison.ENUM_TIMESPAN = this.oEnum_Timespan;
        oParams_Get_Multi_Kpi_Comparison.ORGANIZATION_ID = this.CmSvc.saved_organization_id;
        oParams_Get_Multi_Kpi_Comparison.LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL = this.oList_Access_Control_Object.map(oAccess_Control_Object => {
            let oOrganization_data_source_kpi_by_level = new Organization_data_source_kpi_By_Level();
            oOrganization_data_source_kpi_by_level.DATA_LEVEL_SETUP_ID = oAccess_Control_Object.DATA_LEVEL_SETUP_ID;
            oOrganization_data_source_kpi_by_level.LEVEL_ID = oAccess_Control_Object.LEVEL_ID;
            oOrganization_data_source_kpi_by_level.ORGANIZATION_DATA_SOURCE_KPI_ID = oAccess_Control_Object.Selected_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
            return oOrganization_data_source_kpi_by_level;
        });

        this.MapService.Get_Multi_Kpi_Comparison(oParams_Get_Multi_Kpi_Comparison).then(result => {
            const yAxisIds = ["left-y-axis", "right-y-axis"];
            this.oKpi_data.ChartConfiguration = (JSON.parse(this.oSpecialized_chart_configuration.CHART_SETTINGS) as ChartConfiguration);
            const oList_Date: Date[] = ([].concat(...result.map(oKpi_value_by_direction => oKpi_value_by_direction.LIST_KPI_VALUE_BY_DATE.map(oKpi_value_by_direction => new Date(oKpi_value_by_direction.RECORD_DATE)))) as Date[]).sort((a, b) => a.getTime() - b.getTime());
            this.oKpi_data.ChartConfiguration.data.labels = [...new Set(oList_Date.map(date => this.DatePipe.transform(date, 'mediumDate', this.TimezoneService.oCurrent_Timezone_Offset)))];
            if (result?.some(oKpi_value_by_direction => oKpi_value_by_direction.LIST_KPI_VALUE_BY_DATE?.length > 0)) {
                result.forEach((oKpi_value_by_direction, i) => {
                    if (oKpi_value_by_direction.LIST_KPI_VALUE_BY_DATE) {
                        oKpi_value_by_direction.LIST_KPI_VALUE_BY_DATE = oKpi_value_by_direction.LIST_KPI_VALUE_BY_DATE.sort((a, b) => new Date(a.RECORD_DATE).getTime() - new Date(b.RECORD_DATE).getTime());
                        let color;
                        this.oKpi_data.ChartConfiguration.data.datasets[i] = (JSON.parse(this.oSpecialized_chart_configuration.SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, '')) as ChartConfiguration['data']['datasets'][0]);

                        this.oKpi_data.ChartConfiguration.data.datasets[i] = {
                            yAxisID: (oKpi_value_by_direction.DIRECTION == 'right') ? yAxisIds[1] : yAxisIds[0],
                            fill: true,
                            type: "line",
                            label: oKpi_value_by_direction.LABEL,
                            borderColor: `rgb(${Math.random() * 255}, ${Math.random() * 255}, ${Math.random() * 255})`,
                            borderWidth: 3,
                            cubicInterpolationMode: "monotone",
                            data: this.oKpi_data.ChartConfiguration.data.labels.map(label => oKpi_value_by_direction.LIST_KPI_VALUE_BY_DATE.find(oKpi_value_by_date => this.DatePipe.transform(oKpi_value_by_date.RECORD_DATE, 'mediumDate', this.TimezoneService.oCurrent_Timezone_Offset) == label)?.VALUE)
                        } as any;
                        this.oKpi_data.ChartConfiguration.options = this.generateOptions(this.first_unit, this.second_unit);
                    }
                })
            } else {
                this.oKpi_data.ChartConfiguration.options.plugins.title.text = "No Data to Display.";
            }
            this.isShowGeneratedData = true;
            this.isDataLoading = false;
            this.oToggle_Share_Button_EventEmitter.emit(true);
        })
    }

    goBack() {
        this.isShowGeneratedData = false;
        this.oToggle_Share_Button_EventEmitter.emit(false);
    }

    Generate_Data() {
        this.Get_Multi_Kpi_Comparison();
    }

    generateOptions(first_unit, second_unit) {
        let options = {
            scales: {
                x: {
                    grid: {
                        display: false
                    }
                }
            },
            maintainAspectRatio: false,
        };
        if (first_unit) {
            options.scales["left-y-axis"] = {
                type: "linear",
                position: "left",
                grid: {
                    borderDash: [8, 6],
                    lineWidth: 2
                },
                ticks: {
                    callback: (v) => v + " " + first_unit,
                    maxTicksLimit: 6
                },
                scaleLabel: {
                    display: true,
                    labelString: first_unit
                }
            };
        }
        if (second_unit) {
            options.scales["right-y-axis"] = {
                type: "linear",
                position: "right",
                grid: {
                    display: false
                },
                ticks: {
                    callback: (v) => v + " " + second_unit,
                    maxTicksLimit: 6
                },
                scaleLabel: {
                    display: true,
                    labelString: second_unit
                },
            };
        }
        return options;
    }

    Filter_KPI_List(i_Access_Control_Object: Access_Control_Object) {
        if (i_Access_Control_Object.LEVEL_ID) {
            let oList_Organization_data_source_kpi_Simple: Organization_data_source_kpi_Simple[] = [];
            switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site"):
                    oList_Organization_data_source_kpi_Simple = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID).LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                    break;
                case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area"):
                    oList_Organization_data_source_kpi_Simple = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID).LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                    break;
                case this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District"):
                    oList_Organization_data_source_kpi_Simple = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID).LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE;
                    break;
                default:
                    break;
            }
            i_Access_Control_Object.List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI = this.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oList_Organization_data_source_kpi_Simple.some(oOrganization_data_source_kpi_Simple => oOrganization_data_source_kpi_Simple.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID));
        }
    }

    Check_Selection(i_Access_Control_Object: Access_Control_Object, event) {
        if (event) {
            return this.oList_Access_Control_Object.some(_Access_Control_Object => _Access_Control_Object.LEVEL_ID == i_Access_Control_Object.LEVEL_ID && _Access_Control_Object.Selected_Organization_data_source_kpi?.Kpi.KPI_ID == event.Kpi.KPI_ID);
        }
        else return false;
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

    addAccessControlObject() {
        if (this.oList_Access_Control_Object.length < 5) {
            const oAccess_Control_Object = new Access_Control_Object();
            oAccess_Control_Object.List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI = [];
            this.oList_Access_Control_Object.push(oAccess_Control_Object);
            this._changeDetectorRef.detectChanges();
        }
        else {
            this.CmSvc.ShowMessage("Cannot Add More Than 5 Level KPIs!");
        }
    }

    removeAccessControlObject(i_Access_Control_Object: Access_Control_Object) {
        this.oList_Access_Control_Object.splice(this.oList_Access_Control_Object.indexOf(i_Access_Control_Object), 1);
        this.selectFirstAndSecondUnits();
        this._changeDetectorRef.detectChanges();
    }

    selectFirstAndSecondUnits() {
        const unitSet = this.oList_Access_Control_Object.filter(oAccess_Control_Object => oAccess_Control_Object.Selected_Organization_data_source_kpi).reduce((set, oAccess_Control_Object) => set.add(oAccess_Control_Object.Selected_Organization_data_source_kpi.Kpi.UNIT), new Set<string>());
        const unitArray = Array.from(unitSet);
        this.first_unit = unitArray[0];
        this.second_unit = unitArray.length > 1 ? unitArray[1] : null;
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
                return this.oList_Site;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District;
        }
        return [];
    }

    resetAccess_Control_Object(i_Access_Control_Object: Access_Control_Object) {
        i_Access_Control_Object.LEVEL_ID = null;
        i_Access_Control_Object.Selected_Organization_data_source_kpi = null;
        i_Access_Control_Object.List_Filtered_Organization_data_source_kpi = [];
        i_Access_Control_Object.List_AVAILABLE_ORGANIZATION_DATA_SOURCE_KPI = [];
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
