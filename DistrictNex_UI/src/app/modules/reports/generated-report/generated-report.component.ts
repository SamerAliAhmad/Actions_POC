import { Location } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Enum_Map_view } from 'app/core/Models/constants';
import { Kpi_data, Kpi_data_With_Level } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Asset_definition, District, Entity, Enum_Timespan, Kpi_chart_configuration, Params_Get_Report_Details, Report_Details, Site } from 'app/core/Services/proxy.service';
import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { ChartConfiguration } from 'chart.js';
import { color } from 'chart.js/helpers';
import { ReportsService } from '../reports.service';


@Component({
    selector: 'generated-report',
    templateUrl: './generated-report.component.html',
    styleUrls: ['./generated-report.component.scss']
})
export class GeneratedReportComponent implements OnInit {

    monthNames = ["January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"
    ];

    Enum_Map_view = Enum_Map_view;
    currentDate: Date = new Date();
    oReport_Details: Report_Details;

    oData_level_Setup_ID: number;
    oChosen_Enum_Timespan: Enum_Timespan;
    oParams_Get_Report_Details: Params_Get_Report_Details;

    oList_Area: Area[];
    oList_Site: Site[];
    oList_Entity: Entity[];
    oList_District: District[];
    oList_Area_asset_definition: Asset_definition[];
    oList_Site_asset_definition: Asset_definition[];
    oList_Entity_asset_definition: Asset_definition[];
    oList_District_asset_definition: Asset_definition[];
    oList_Kpi_data_Per_Page: Kpi_data_With_Level[] = [];
    oList_Kpi_chart_configuration: Kpi_chart_configuration[];

    logoUrl = "";
    chunkSize = 3;
    isDownloadingPdf = false;
    pdfDownloadPercentage = 0;

    constructor(
        private router: Router,
        private Location: Location,
        private CmSvc: CommonService,
        private ReportsService: ReportsService,
        public TimezoneService: TimezoneService,
        private SmartrSplashScreenService: SmartrSplashScreenService,
    ) {
        if (!this.ReportsService.oReport_Details) {
            this.router.navigateByUrl("/reports");
            return;
        }
        this.oReport_Details = this.ReportsService.oReport_Details;
        this.logoUrl = this.CmSvc.userTheme.DARK_SQUARE_LOGO_URL;
        this.oList_Kpi_chart_configuration = this.CmSvc.oList_Kpi_chart_configuration.filter(oKpi_chart_configuration => oKpi_chart_configuration.POSITION_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Frontend Position", "Reports"));
        this.oList_District = this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_DISTRICT.map(oKpi_dialog_data_by_district => this.CmSvc.oList_Accessible_District.find(oDistrict => oDistrict.DISTRICT_ID == oKpi_dialog_data_by_district.DISTRICT_ID));
        this.oList_Area = this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_AREA.map(oKpi_dialog_data_by_district => this.CmSvc.oList_Accessible_Area.find(oArea => oArea.AREA_ID == oKpi_dialog_data_by_district.AREA_ID));
        this.oList_Site = this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_SITE.map(oKpi_dialog_data_by_district => this.CmSvc.oList_Accessible_Site.find(oSite => oSite.SITE_ID == oKpi_dialog_data_by_district.SITE_ID));
        this.oList_Entity = this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_ENTITY.map(oKpi_dialog_data_by_district => this.CmSvc.oList_Accessible_Entity.find(oEntity => oEntity.ENTITY_ID == oKpi_dialog_data_by_district.ENTITY_ID));
    }

    ngOnInit(): void {
        if (this.oReport_Details) {
            this.oParams_Get_Report_Details = this.ReportsService.oParams_Get_Report_Details;
            this.oChosen_Enum_Timespan = this.ReportsService.oParams_Get_Report_Details.ENUM_TIMESPAN;
            this.oList_District_asset_definition = this.ReportsService.oParams_Get_Report_Details.LIST_DISTRICT_ASSET_DEFINITION;
            this.oList_Area_asset_definition = this.ReportsService.oParams_Get_Report_Details.LIST_AREA_ASSET_DEFINITION;
            this.oList_Site_asset_definition = this.ReportsService.oParams_Get_Report_Details.LIST_SITE_ASSET_DEFINITION;
            this.oList_Entity_asset_definition = this.ReportsService.oParams_Get_Report_Details.LIST_ENTITY_ASSET_DEFINITION;
            this.oList_Kpi_data_Per_Page = [];

            this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_DISTRICT.forEach(oKpi_dialog_data_by_district => {
                let oList_Kpi_data: Kpi_data[] = [];
                this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District");
                oKpi_dialog_data_by_district.LIST_DISTRICT_KPI_DIALOG_DATA.forEach(oDistrict_kpi_dialog_data => {
                    const oKpi_data = new Kpi_data();

                    oKpi_data.Kpi_chart_configuration = this.oList_Kpi_chart_configuration.find(oKpi_chart_configuration => oKpi_chart_configuration.KPI_ID == oDistrict_kpi_dialog_data.KPI_ID);
                    if (oKpi_data.Kpi_chart_configuration) {
                        if (oKpi_data.Kpi_chart_configuration.LIST_SETTING.length > 1) {
                            oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "heroicons_outline:chevron-double-right" });
                        }
                        if (oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON && oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.length > 0) {
                            oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.forEach(oAction_button => {
                                oKpi_data.List_Action_Button.push(oAction_button);
                            })

                        }
                        oKpi_data.ChartConfiguration = JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;

                        let titleText = '';
                        if (oDistrict_kpi_dialog_data.TITLE.toLowerCase().includes("from")) {
                            const fromIndex = oDistrict_kpi_dialog_data.TITLE.toLowerCase().indexOf("from");
                            const tillIndex = oDistrict_kpi_dialog_data.TITLE.toLowerCase().indexOf("till");
                            if (fromIndex >= 0 && tillIndex >= 0) {
                                titleText = oDistrict_kpi_dialog_data.TITLE.substring(0, fromIndex).trim();
                                const fromDate = oDistrict_kpi_dialog_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                                const toDate = oDistrict_kpi_dialog_data.TITLE.substring(tillIndex + 4).trim();
                                oKpi_data.From_Date = fromDate;
                                oKpi_data.To_Date = toDate;
                            }
                        }
                        else {
                            titleText = oDistrict_kpi_dialog_data.TITLE;
                        }
                        oKpi_data.CHART_TITLE = titleText;
                        if (oDistrict_kpi_dialog_data.KPI_DATA && oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET.length > 0 && oDistrict_kpi_dialog_data.KPI_DATA.LIST_LABEL.length > 0) {
                            oKpi_data.isDataAvailable = true;
                            if (oKpi_data.ChartConfiguration.type != "treemap") {
                                for (let index = 0; index < oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET.length; index++) {
                                    let color: string;
                                    if (oKpi_data.CHART_TITLE != "Businesses Vacancy") {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        }
                                    }
                                    else {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                                        }
                                    }
                                    oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                    oKpi_data.ChartConfiguration.data.datasets[index].data = oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT;
                                }
                                oKpi_data.ChartConfiguration.data.labels = oDistrict_kpi_dialog_data.KPI_DATA.LIST_LABEL;
                            }
                            else {
                                var District_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District");
                                let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == District_Setup_ID)?.COLOR;
                                if (!color) {
                                    color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == District_Setup_ID)?.COLOR;
                                }
                                oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oDistrict_kpi_dialog_data.KPI_DATA.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                    return {
                                        value: point,
                                        title: oDistrict_kpi_dialog_data.KPI_DATA.LIST_LABEL[i]
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
                        oList_Kpi_data.push(oKpi_data);
                    }
                });

                oList_Kpi_data = oList_Kpi_data.filter(oKpi_data => oKpi_data.isDataAvailable);
                for (let i = 0; i < oList_Kpi_data.length; i += this.chunkSize) {
                    const chunk = oList_Kpi_data.slice(i, i + this.chunkSize);
                    this.oList_Kpi_data_Per_Page.push({
                        Level: this.CmSvc.oList_Accessible_District.find(oDistrict => oDistrict.DISTRICT_ID == oKpi_dialog_data_by_district.DISTRICT_ID),
                        List_Kpi_data: chunk,
                    });
                }
            });

            this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area");
            this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_AREA.forEach(oKpi_dialog_data_by_area => {
                let oList_Kpi_data: Kpi_data[] = [];
                oKpi_dialog_data_by_area.LIST_AREA_KPI_DIALOG_DATA.forEach(oArea_kpi_dialog_data => {
                    const oKpi_data = new Kpi_data();

                    oKpi_data.Kpi_chart_configuration = this.oList_Kpi_chart_configuration.find(oKpi_chart_configuration => oKpi_chart_configuration.KPI_ID == oArea_kpi_dialog_data.KPI_ID);
                    if (oKpi_data.Kpi_chart_configuration) {
                        if (oKpi_data.Kpi_chart_configuration.LIST_SETTING.length > 1) {
                            oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "heroicons_outline:chevron-double-right" });
                        }
                        if (oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON && oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.length > 0) {
                            oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.forEach(oAction_button => {
                                oKpi_data.List_Action_Button.push(oAction_button);
                            })

                        }
                        oKpi_data.ChartConfiguration = JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;

                        let titleText = '';
                        if (oArea_kpi_dialog_data.TITLE.toLowerCase().includes("from")) {
                            const fromIndex = oArea_kpi_dialog_data.TITLE.toLowerCase().indexOf("from");
                            const tillIndex = oArea_kpi_dialog_data.TITLE.toLowerCase().indexOf("till");
                            if (fromIndex >= 0 && tillIndex >= 0) {
                                titleText = oArea_kpi_dialog_data.TITLE.substring(0, fromIndex).trim();
                                const fromDate = oArea_kpi_dialog_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                                const toDate = oArea_kpi_dialog_data.TITLE.substring(tillIndex + 4).trim();
                                oKpi_data.From_Date = fromDate;
                                oKpi_data.To_Date = toDate;
                            }
                        }
                        else {
                            titleText = oArea_kpi_dialog_data.TITLE;
                        }
                        oKpi_data.CHART_TITLE = titleText;
                        if (oArea_kpi_dialog_data.KPI_DATA && oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET.length > 0 && oArea_kpi_dialog_data.KPI_DATA.LIST_LABEL.length > 0) {
                            oKpi_data.isDataAvailable = true;
                            if (oKpi_data.ChartConfiguration.type != "treemap") {
                                for (let index = 0; index < oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET.length; index++) {
                                    let color: string;
                                    if (oKpi_data.CHART_TITLE != "Businesses Vacancy") {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        }
                                    }
                                    else {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                                        }
                                    }
                                    oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                    oKpi_data.ChartConfiguration.data.datasets[index].data = oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT;
                                }
                                oKpi_data.ChartConfiguration.data.labels = oArea_kpi_dialog_data.KPI_DATA.LIST_LABEL;
                            }
                            else {
                                var Area_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area");
                                let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Area_Setup_ID)?.COLOR;
                                if (!color) {
                                    color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Area_Setup_ID)?.COLOR;
                                }
                                oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oArea_kpi_dialog_data.KPI_DATA.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                    return {
                                        value: point,
                                        title: oArea_kpi_dialog_data.KPI_DATA.LIST_LABEL[i]
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
                        oList_Kpi_data.push(oKpi_data);
                    }
                });

                oList_Kpi_data = oList_Kpi_data.filter(oKpi_data => oKpi_data.isDataAvailable);
                for (let i = 0; i < oList_Kpi_data.length; i += this.chunkSize) {
                    const chunk = oList_Kpi_data.slice(i, i + this.chunkSize);
                    this.oList_Kpi_data_Per_Page.push({
                        Level: this.CmSvc.oList_Accessible_Area.find(oArea => oArea.AREA_ID == oKpi_dialog_data_by_area.AREA_ID),
                        List_Kpi_data: chunk,
                    });
                }
            });

            this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
            this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_SITE.forEach(oKpi_dialog_data_by_site => {
                let oList_Kpi_data: Kpi_data[] = [];
                oKpi_dialog_data_by_site.LIST_SITE_KPI_DIALOG_DATA.forEach(oSite_kpi_dialog_data => {
                    const oKpi_data = new Kpi_data();

                    oKpi_data.Kpi_chart_configuration = this.oList_Kpi_chart_configuration.find(oKpi_chart_configuration => oKpi_chart_configuration.KPI_ID == oSite_kpi_dialog_data.KPI_ID);
                    if (oKpi_data.Kpi_chart_configuration) {
                        if (oKpi_data.Kpi_chart_configuration.LIST_SETTING.length > 1) {
                            oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "heroicons_outline:chevron-double-right" });
                        }
                        if (oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON && oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.length > 0) {
                            oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.forEach(oAction_button => {
                                oKpi_data.List_Action_Button.push(oAction_button);
                            })

                        }
                        oKpi_data.ChartConfiguration = JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;

                        let titleText = '';
                        if (oSite_kpi_dialog_data.TITLE.toLowerCase().includes("from")) {
                            const fromIndex = oSite_kpi_dialog_data.TITLE.toLowerCase().indexOf("from");
                            const tillIndex = oSite_kpi_dialog_data.TITLE.toLowerCase().indexOf("till");
                            if (fromIndex >= 0 && tillIndex >= 0) {
                                titleText = oSite_kpi_dialog_data.TITLE.substring(0, fromIndex).trim();
                                const fromDate = oSite_kpi_dialog_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                                const toDate = oSite_kpi_dialog_data.TITLE.substring(tillIndex + 4).trim();
                                oKpi_data.From_Date = fromDate;
                                oKpi_data.To_Date = toDate;
                            }
                        }
                        else {
                            titleText = oSite_kpi_dialog_data.TITLE;
                        }
                        oKpi_data.CHART_TITLE = titleText;
                        if (oSite_kpi_dialog_data.KPI_DATA && oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET.length > 0 && oSite_kpi_dialog_data.KPI_DATA.LIST_LABEL.length > 0) {
                            oKpi_data.isDataAvailable = true;
                            if (oKpi_data.ChartConfiguration.type != "treemap") {
                                for (let index = 0; index < oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET.length; index++) {
                                    let color: string;
                                    if (oKpi_data.CHART_TITLE != "Businesses Vacancy") {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                        }
                                    }
                                    else {
                                        color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                                        if (!color) {
                                            color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                                        }
                                    }
                                    oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                    oKpi_data.ChartConfiguration.data.datasets[index].data = oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET[index]?.LIST_POINT;
                                }
                                oKpi_data.ChartConfiguration.data.labels = oSite_kpi_dialog_data.KPI_DATA.LIST_LABEL;
                            }
                            else {
                                var Site_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site");
                                let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID)?.COLOR;
                                if (!color) {
                                    color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Site_Setup_ID)?.COLOR;
                                }
                                oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oSite_kpi_dialog_data.KPI_DATA.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                    return {
                                        value: point,
                                        title: oSite_kpi_dialog_data.KPI_DATA.LIST_LABEL[i]
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
                        oList_Kpi_data.push(oKpi_data);
                    }
                });

                oList_Kpi_data = oList_Kpi_data.filter(oKpi_data => oKpi_data.isDataAvailable);
                for (let i = 0; i < oList_Kpi_data.length; i += this.chunkSize) {
                    const chunk = oList_Kpi_data.slice(i, i + this.chunkSize);
                    this.oList_Kpi_data_Per_Page.push({
                        Level: this.CmSvc.oList_Accessible_Site.find(oSite => oSite.SITE_ID == oKpi_dialog_data_by_site.SITE_ID),
                        List_Kpi_data: chunk,
                    });
                }
            });

            this.oData_level_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity");
            this.oReport_Details.LIST_KPI_DIALOG_DATA_BY_ENTITY.forEach(oKpi_dialog_data_by_entity => {
                let oList_Kpi_data: Kpi_data[] = [];
                oKpi_dialog_data_by_entity.LIST_ENTITY_KPI_DIALOG_DATA.forEach(oEntity_kpi_dialog_data => {
                    oEntity_kpi_dialog_data.LIST_KPI_DATA.forEach(oEntity_data_point => {
                        const oKpi_data = new Kpi_data();

                        oKpi_data.Kpi_chart_configuration = this.oList_Kpi_chart_configuration.find(oKpi_chart_configuration => oKpi_chart_configuration.KPI_ID == oEntity_kpi_dialog_data.KPI_ID);
                        if (oKpi_data.Kpi_chart_configuration) {
                            if (oKpi_data.Kpi_chart_configuration.LIST_SETTING.length > 1) {
                                oKpi_data.Setting_Toggle_Button = ({ TOOLTIP: "Toggle Chart Setting", FUNCTIONALITY: "Toggle_Chart_Setting", ICON: "heroicons_outline:chevron-double-right" });
                            }
                            if (oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON && oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.length > 0) {
                                oKpi_data.Kpi_chart_configuration.LIST_ACTION_BUTTON.forEach(oAction_button => {
                                    oKpi_data.List_Action_Button.push(oAction_button);
                                })

                            }
                            oKpi_data.ChartConfiguration = JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].CHART_SETTINGS) as ChartConfiguration;

                            let titleText = '';
                            if (oEntity_kpi_dialog_data.TITLE.toLowerCase().includes("from")) {
                                const fromIndex = oEntity_kpi_dialog_data.TITLE.toLowerCase().indexOf("from");
                                const tillIndex = oEntity_kpi_dialog_data.TITLE.toLowerCase().indexOf("till");
                                if (fromIndex >= 0 && tillIndex >= 0) {
                                    titleText = oEntity_kpi_dialog_data.TITLE.substring(0, fromIndex).trim();
                                    const fromDate = oEntity_kpi_dialog_data.TITLE.substring(fromIndex + 4, tillIndex).trim();
                                    const toDate = oEntity_kpi_dialog_data.TITLE.substring(tillIndex + 4).trim();
                                    oKpi_data.From_Date = fromDate;
                                    oKpi_data.To_Date = toDate;
                                }
                            }
                            else {
                                titleText = oEntity_kpi_dialog_data.TITLE;
                            }
                            oKpi_data.CHART_TITLE = titleText;
                            if (oEntity_data_point.INCIDENT_CATEGORY_SETUP_ID || oEntity_data_point.SEVERITY_TYPE_SETUP_ID) {
                                oKpi_data.CHART_SUBTITLE = "";
                                if (oEntity_data_point.INCIDENT_CATEGORY_SETUP_ID) {
                                    oKpi_data.CHART_SUBTITLE += "Type: " + this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Security Incident Category Type", oEntity_data_point.INCIDENT_CATEGORY_SETUP_ID).VALUE;
                                }
                                if (oEntity_data_point.SEVERITY_TYPE_SETUP_ID) {
                                    if (oEntity_data_point.INCIDENT_CATEGORY_SETUP_ID) {
                                        oKpi_data.CHART_SUBTITLE += " / ";
                                    }
                                    oKpi_data.CHART_SUBTITLE += "Severity: " + this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Severity Type", oEntity_data_point.SEVERITY_TYPE_SETUP_ID).VALUE;
                                }
                            }
                            if (oEntity_kpi_dialog_data.LIST_KPI_DATA && oEntity_data_point.LIST_DATASET.length > 0 && oEntity_data_point.LIST_LABEL.length > 0) {
                                oKpi_data.isDataAvailable = true;
                                if (oKpi_data.ChartConfiguration.type != "treemap") {
                                    for (let index = 0; index < oEntity_data_point.LIST_DATASET.length; index++) {
                                        let color: string;
                                        if (oKpi_data.CHART_TITLE != "Businesses Vacancy") {
                                            color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oEntity_data_point.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                            if (!color) {
                                                color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == oEntity_data_point.LIST_DATASET[index].DATA_LEVEL_SETUP_ID).COLOR;
                                            }
                                        }
                                        else {
                                            color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color[index].COLOR;
                                            if (!color) {
                                                color = this.CmSvc.oDefaultSettings.List_Default_chart_color[index].COLOR;
                                            }
                                        }
                                        oKpi_data.ChartConfiguration.data.datasets[index] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oEntity_data_point.LIST_DATASET[index].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                        oKpi_data.ChartConfiguration.data.datasets[index].data = oEntity_data_point.LIST_DATASET[index]?.LIST_POINT;
                                    }
                                    oKpi_data.ChartConfiguration.data.labels = oEntity_data_point.LIST_LABEL;
                                }
                                else {
                                    var Entity_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity");
                                    let color = this.CmSvc.oCurrent_Applied_Organization_color_scheme.List_Organization_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Entity_Setup_ID)?.COLOR;
                                    if (!color) {
                                        color = this.CmSvc.oDefaultSettings.List_Default_chart_color.find(chart_color => chart_color.DATA_LEVEL_SETUP_ID == Entity_Setup_ID)?.COLOR;
                                    }
                                    oKpi_data.ChartConfiguration.data.datasets[0] = (JSON.parse(oKpi_data.Kpi_chart_configuration.LIST_SETTING[0].SERIES_SETTINGS.replace(/{{SERIES_COLOR}}/g, color).replace(/{{SERIES_LABEL}}/g, oEntity_data_point.LIST_DATASET[0].LABEL)) as ChartConfiguration['data']['datasets'][0]);
                                    oKpi_data.ChartConfiguration.data.datasets[0][`tree`] = oEntity_data_point.LIST_DATASET[0]?.LIST_POINT.map((point, i) => {
                                        return {
                                            value: point,
                                            title: oEntity_data_point.LIST_LABEL[i]
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
                            oList_Kpi_data.push(oKpi_data);
                        }
                    });
                });

                oList_Kpi_data = oList_Kpi_data.filter(oKpi_data => oKpi_data.isDataAvailable);
                for (let i = 0; i < oList_Kpi_data.length; i += this.chunkSize) {
                    const chunk = oList_Kpi_data.slice(i, i + this.chunkSize);
                    this.oList_Kpi_data_Per_Page.push({
                        Level: this.CmSvc.oList_Accessible_Entity.find(oEntity => oEntity.ENTITY_ID == oKpi_dialog_data_by_entity.ENTITY_ID),
                        List_Kpi_data: chunk,
                    });
                }
            });
        } else {
            this.Location.back();
        }
        this.SmartrSplashScreenService.hide();
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

    changeImage() {
        if (this.logoUrl != this.CmSvc.oDefaultSettings.DARK_SQUARE_LOGO_URL) {
            this.logoUrl = this.CmSvc.oDefaultSettings.DARK_SQUARE_LOGO_URL;
        } else {
            this.logoUrl = 'assets/images/logo/picacity/logo-black-square.png';
        }
    }

    print(): void {
        window.print();
    }

    getAssetDefinitionDimensions(i_Asset_definition: Asset_definition) {
        return [...new Set(i_Asset_definition.LIST_ORGANIZATION_DATA_SOURCE_KPI_ID.map(organization_data_source_kpi_id => this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST.find(organization_data_source_kpi => organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == organization_data_source_kpi_id).Kpi.DIMENSION_ID))];
    }

    getEnumCollectionValue(i_Enum_Timespan: Enum_Timespan) {
        switch (i_Enum_Timespan) {
            case Enum_Timespan.X_HOURLY_COLLECTION:
                return "Hourly";
            case Enum_Timespan.X_DAILY_COLLECTION:
                return "Daily";
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                return "Weekly";
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                return "Monthly";
        }
    }

    goBack(): void {
        this.Location.back();
    }
}
