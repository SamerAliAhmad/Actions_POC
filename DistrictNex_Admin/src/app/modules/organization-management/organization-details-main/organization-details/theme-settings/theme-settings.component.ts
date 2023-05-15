import { cloneDeep } from 'lodash';
import { Chart } from 'highcharts';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { MatCheckboxChange } from '@angular/material/checkbox';
import { CommonService } from 'app/core/Services/common.service';
import { Component, Input, OnDestroy, OnInit } from '@angular/core';
import { ColoringService } from 'app/shared/services/coloring.service';
import { Organization, Organization_color_scheme } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { Organization_chart_color, Params_Edit_Default_chart_color_List } from './../../../../../core/Services/proxy.service';

@Component({
    selector: 'theme-settings',
    templateUrl: './theme-settings.component.html',
    styleUrls: ['./theme-settings.component.scss']
})
export class ThemeSettingsComponent implements OnInit, OnDestroy {

    matTabIndex = 0;

    oOrganization_color_scheme: Organization_color_scheme;

    oList_Color_Picker: boolean[] = [];
    oList_Organization_chart_color: Organization_chart_color[];
    oParams_Edit_Default_Chart_Color_List = new Params_Edit_Default_chart_color_List();

    @Input() oOrganization: Organization;

    oChart: Chart;

    isLoading = false;
    isShowAdmin = false;
    isThereChange = false;
    isMyOrganization = false;
    openPrimaryColorPicker = false;
    openSecondaryColorPicker = false;
    isUseDefaultColorsScheme = false;
    isUseDefaultColorsCharts = false;

    constructor(
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private ColoringService: ColoringService,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit() {
        if (!this.oOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        }
        this.oList_Organization_chart_color = this.oOrganization.List_Organization_color_scheme[0].List_Organization_chart_color;
        this.oList_Organization_chart_color.forEach(oOrganization_chart_color => {
            this.oList_Color_Picker.push(false);
        })
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        this.oOrganization_color_scheme = cloneDeep(this.oOrganization.List_Organization_color_scheme[0]);
    }

    Edit_Organization_Color_Scheme_List() {
        this.CmSvc.oOrganization.List_Organization_color_scheme[0].List_Organization_chart_color = this.oList_Organization_chart_color;
        this.OrganizationManagementService.Edit_Organization_Chart_Color_List(this.oList_Organization_chart_color).then(result => {
            if (result) {
                this.updateChartColors();
            }
        })
    }

    LightenColor(color, percent) {
        var num = parseInt(color.replace("#", ""), 16),
            amt = Math.round(2.55 * percent),
            R = (num >> 16) + amt,
            B = (num >> 8 & 0x00FF) + amt,
            G = (num & 0x0000FF) + amt;

        return '#' + (0x1000000 + (R < 255 ? R < 1 ? 0 : R : 255) * 0x10000 + (B < 255 ? B < 1 ? 0 : B : 255) * 0x100 + (G < 255 ? G < 1 ? 0 : G : 255)).toString(16).slice(1);
    };

    loadChart(value) {
        if (value.index != 1) {
            return;
        }
        this.oChart = new Chart({
            "chart": {
                "renderTo": 'demoChart',
                "animation": true,
                "backgroundColor": null
            },
            "title": {
                "text": "Consumption",
                "style": {
                    "color": "#2C2E30",
                    "fontFamily": "inherit",
                    "fontSize": "12px"
                },
                "align": "left"
            },
            "credits": {
                "enabled": false
            },
            "yAxis": {
                "labels": {
                    "enabled": true,
                    "style": {
                        "color": "#2C2E30"
                    }
                },
                "title": {
                    "text": null
                },
                "gridLineDashStyle": "LongDash",
                "gridLineColor": "#757575",
                "tickInterval": 2
            },
            "xAxis": {
                "lineColor": "gray",
                "labels": {
                    "enabled": true,
                    "rotation": 0,
                    "step": 3,
                    "style": {
                        "color": "#2C2E30",
                        "fontSize": "0.6rem"
                    }
                },
                "title": {
                    "text": null
                }
            },
            "tooltip": {
                "shared": true,
                "style": {
                    "fontSize": "0.7vw"
                },
                "outside": true
            },
            "plotOptions": {
                "line": {
                    "marker": {
                        "enabled": true
                    }
                }
            },
            "legend": {
                "enabled": false
            },
            "series": this.oList_Organization_chart_color.map(oDefault_chart_color => {
                return {
                    "name": oDefault_chart_color.Data_level_setup.VALUE,
                    "data": [Math.round(Math.random() * 10), Math.round(Math.random() * 10), Math.round(Math.random() * 10), Math.round(Math.random() * 10), Math.round(Math.random() * 10)],
                    "type": "line",
                    "color": oDefault_chart_color.COLOR
                }
            })
        })
    }

    applyChanges() {
        this.ColoringService.generateThemeColor(this.oOrganization_color_scheme.PLATFORM_PRIMARY);
        document.documentElement.style.setProperty('--smartr-button', this.oOrganization_color_scheme.PLATFORM_BUTTON);
        if (this.CmSvc.isDark(this.oOrganization_color_scheme.PLATFORM_BUTTON)) {
            document.documentElement.style.setProperty('--smartr-button-text', 'white')
        } else {
            document.documentElement.style.setProperty('--smartr-button-text', '#0f172a')
        }
    }

    updateChartColors() {
        if (this.oChart) {
            this.oChart.series.forEach((serie, i) => {
                serie.options.color = this.oList_Organization_chart_color[i].COLOR;
                serie.update(serie.options);
            });
            this.isThereChange = true;
        }
    }
    checkMainColorsDefaultTheme(event: MatCheckboxChange) {
        if (event.checked) {
            this.oOrganization_color_scheme.PLATFORM_PRIMARY = this.CmSvc.defaultSettings.PLATFORM_PRIMARY;
            this.oOrganization_color_scheme.PLATFORM_BUTTON = this.CmSvc.defaultSettings.PLATFORM_BUTTON;
        }
    }

    checkChartColorsDefaultTheme(event: MatCheckboxChange) {
        if (event.checked) {
            this.oList_Organization_chart_color.forEach((oOrganization_chart_color) => {
                let oDefault_chart_color = this.CmSvc.defaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == oOrganization_chart_color.DATA_LEVEL_SETUP_ID);
                if (oDefault_chart_color) {
                    oOrganization_chart_color.COLOR = oDefault_chart_color.COLOR;
                }
            })
            this.CmSvc.oOrganization.List_Organization_color_scheme[0].List_Organization_chart_color = this.oList_Organization_chart_color;
            this.updateChartColors();
            this.isThereChange = true;
        }
    }

    editOrganizationTheme(themeForm: NgForm): void {
        if (themeForm.invalid) {
            this.CmSvc.ShowMessage("Some data is missing or wrong");
            return;
        }
        this.isLoading = true;
        if (this.isUseDefaultColorsScheme) {
            this.oOrganization_color_scheme.PLATFORM_PRIMARY = this.CmSvc.defaultSettings.PLATFORM_PRIMARY;
            this.oOrganization_color_scheme.PLATFORM_BUTTON = this.CmSvc.defaultSettings.PLATFORM_BUTTON;
        }
        if (this.isUseDefaultColorsCharts) {
            this.oOrganization_color_scheme.List_Organization_chart_color.forEach(oOrganization_chart_color => oOrganization_chart_color.COLOR = this.CmSvc.defaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == oOrganization_chart_color.DATA_LEVEL_SETUP_ID).COLOR);
        }
        this.oOrganization_color_scheme.List_Organization_chart_color = this.oList_Organization_chart_color;
        this.OrganizationManagementService.Edit_Organization_Color_Scheme_List([this.oOrganization_color_scheme]).then(result => {
            if (result) {
                this.isLoading = false;
                themeForm.form.markAsPristine();
            }
        })
    }

    resetOrganizationTheme(themeForm: NgForm): void {
        this.oOrganization_color_scheme = cloneDeep(this.oOrganization.List_Organization_color_scheme[0]);
        themeForm?.form.markAsPristine();
        if (this.isMyOrganization) {
            this.applyChanges();
        }
    }

    ngOnDestroy() {
        if (this.isMyOrganization) {
            this.oOrganization_color_scheme = cloneDeep(this.oOrganization.List_Organization_color_scheme[0]);
            this.applyChanges();
        }
    }
}
