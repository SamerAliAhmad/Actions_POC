import { Chart } from 'highcharts';
import { Router } from '@angular/router';
import { MatDialog } from '@angular/material/dialog';
import { Component, HostListener, OnInit } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { OrganizationManagementService } from '../organization-management.service';
import { Default_chart_color, Organization, Organization_chart_color, Organization_color_scheme, Setup } from 'app/core/Services/proxy.service';

@Component({
    selector: 'organization-modal',
    templateUrl: './organization-modal.component.html',
    styleUrls: ['./organization-modal.component.scss']
})
export class OrganizationModalComponent implements OnInit {

    oDate_Now = new Date();
    oOrganization = new Organization();
    oOrganization_color_scheme = new Organization_color_scheme();

    organizationForm: FormGroup;

    isMobileView = false;

    oList_Data_Level: Setup[];
    oList_Color_Picker: boolean[] = [];
    oList_Default_chart_color: Default_chart_color[];
    oList_Organization_chart_color: Organization_chart_color[] = [];

    oChart: Chart;
    isLoading = false;
    openPrimaryColorPicker = false;
    openSecondaryColorPicker = false;

    constructor(
        private router: Router,
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Data_Level = this.CmSvc.Get_Setup_Category_By_SETUP_CATEGORY_NAME("data level").List_Setup;
        this.oList_Default_chart_color = this.CmSvc.defaultSettings.List_Default_chart_color;

    }

    ngOnInit(): void {
        this.isMobileView = window.innerWidth < 600;
        this.oList_Default_chart_color.forEach(oDefault_chart_color => {
            let oOrganization_chart_color = new Organization_chart_color();
            oOrganization_chart_color.ORGANIZATION_CHART_COLOR_ID = -1;
            oOrganization_chart_color.ORGANIZATION_COLOR_SCHEME_ID = this.oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID;
            oOrganization_chart_color.DATA_LEVEL_SETUP_ID = oDefault_chart_color.DATA_LEVEL_SETUP_ID;
            oOrganization_chart_color.Data_level_setup = this.oList_Data_Level.find(oSetup => oSetup.SETUP_ID == oDefault_chart_color.DATA_LEVEL_SETUP_ID);
            oOrganization_chart_color.COLOR = oDefault_chart_color.COLOR;
            this.oList_Color_Picker.push(false);
            this.oList_Organization_chart_color.push(oOrganization_chart_color);
        });
        this.organizationForm = this.initializeForm();
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            step1: this._formBuilder.group({
                ORGANIZATION_NAME: ['', [Validators.pattern('[ a-zA-Z0-9]*'), Validators.required]],
                ORGANIZATION_PHONE_NUMBER: ['', [Validators.pattern('[ 0-9-+]*'), Validators.minLength(5)]],
                ORGANIZATION_EMAIL: ['', Validators.pattern(/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/)],
                ORGANIZATION_ADDRESS: ['', Validators.pattern('[ a-zA-Z0-9,-.\s\r\n]*')],
            }),
            step2: this._formBuilder.group({
                MAX_NUMBER_OF_ADMINS: ['', Validators.required],
                MAX_NUMBER_OF_USERS: ['', Validators.required],
            }),
            step3: this._formBuilder.group({
                PRIMARY_COLOR: [this.CmSvc.defaultSettings.PLATFORM_PRIMARY, Validators.required],
                SECONDARY_COLOR: [this.CmSvc.defaultSettings.PLATFORM_BUTTON, Validators.required],
                IS_USE_DEFAULT_COLOR_SCHEME: [false, Validators.required],
                IS_SHOW_ADMIN: [true],
            }),
        });
    };

    LightenColor(color, percent) {
        var num = parseInt(color.replace("#", ""), 16),
            amt = Math.round(2.55 * percent),
            R = (num >> 16) + amt,
            B = (num >> 8 & 0x00FF) + amt,
            G = (num & 0x0000FF) + amt;

        return '#' + (0x1000000 + (R < 255 ? R < 1 ? 0 : R : 255) * 0x10000 + (B < 255 ? B < 1 ? 0 : B : 255) * 0x100 + (G < 255 ? G < 1 ? 0 : G : 255)).toString(16).slice(1);
    };

    loadChart(value) {
        if (value.selectedIndex != 3) {
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

    updateChartColors() {
        if (this.oChart) {
            this.oChart.series.forEach((serie, i) => {
                serie.options.color = this.oList_Organization_chart_color[i].COLOR;
                serie.update(serie.options);
            });
        }
    }


    checkStep3DefaultTheme(event) {
        if (event.checked) {
            this.organizationForm.get('step3').get('PRIMARY_COLOR').setValue(this.CmSvc.defaultSettings.PLATFORM_PRIMARY);
            this.organizationForm.get('step3').get('PRIMARY_COLOR').disable();
            this.organizationForm.get('step3').get('SECONDARY_COLOR').setValue(this.CmSvc.defaultSettings.PLATFORM_BUTTON);
            this.organizationForm.get('step3').get('SECONDARY_COLOR').disable();
        } else {
            this.organizationForm.get('step3').get('PRIMARY_COLOR').enable();
            this.organizationForm.get('step3').get('SECONDARY_COLOR').enable();
        }
    }

    checkStep4DefaultTheme(event) {
        if (event.checked) {
            this.oList_Organization_chart_color.forEach((oOrganization_chart_color) => {
                let oDefault_chart_color = this.CmSvc.defaultSettings.List_Default_chart_color.find(oDefault_chart_color => oDefault_chart_color.DATA_LEVEL_SETUP_ID == oOrganization_chart_color.DATA_LEVEL_SETUP_ID);
                if (oDefault_chart_color) {
                    oOrganization_chart_color.COLOR = oDefault_chart_color.COLOR;
                }
            })
            this.updateChartColors();
        }
    }

    CreateOgranization() {
        this.isLoading = true;
        var Organization_Setup_ID = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Organization Type", "Organization");
        this.oOrganization.ORGANIZATION_ID = -1;
        this.oOrganization.ORGANIZATION_NAME = this.organizationForm.get('step1').get('ORGANIZATION_NAME').value.trim();
        this.oOrganization.ORGANIZATION_PHONE_NUMBER = this.organizationForm.get('step1').get('ORGANIZATION_PHONE_NUMBER').value.trim();
        this.oOrganization.ORGANIZATION_EMAIL = this.organizationForm.get('step1').get('ORGANIZATION_EMAIL').value.trim();
        this.oOrganization.ORGANIZATION_ADDRESS = this.organizationForm.get('step1').get('ORGANIZATION_ADDRESS').value.trim();
        this.oOrganization.DATA_RETENTION_PERIOD = this.CmSvc.defaultSettings.DATA_RETENTION_PERIOD;
        this.oOrganization.TICKET_DURATION_IN_MINUTES = this.CmSvc.defaultSettings.TICKET_DURATION_IN_MINUTES;
        this.oOrganization.ORGANIZATION_TYPE_SETUP_ID = Organization_Setup_ID;
        this.oOrganization.MAX_NUMBER_OF_ADMINS = this.organizationForm.get('step2').get('MAX_NUMBER_OF_ADMINS').value;
        this.oOrganization.MAX_NUMBER_OF_USERS = this.organizationForm.get('step2').get('MAX_NUMBER_OF_USERS').value;
        this.oOrganization.IS_ACTIVE = true;
        this.oOrganization.List_Organization_color_scheme = [];

        this.oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = -1;
        if (this.organizationForm.get('step3').get('IS_USE_DEFAULT_COLOR_SCHEME').value) {
            this.oOrganization_color_scheme.PLATFORM_PRIMARY = this.CmSvc.defaultSettings.PLATFORM_PRIMARY;
            this.oOrganization_color_scheme.PLATFORM_BUTTON = this.CmSvc.defaultSettings.PLATFORM_BUTTON;
        } else {
            this.oOrganization_color_scheme.PLATFORM_PRIMARY = this.organizationForm.get('step3').get('PRIMARY_COLOR').value;
            this.oOrganization_color_scheme.PLATFORM_BUTTON = this.organizationForm.get('step3').get('SECONDARY_COLOR').value;
        }
        this.oOrganization_color_scheme.List_Organization_chart_color = this.oList_Organization_chart_color;
        this.oOrganization.List_Organization_color_scheme.push(this.oOrganization_color_scheme);
        this.organizationForm.disable();
        this.OrganizationManagementService.createOrganization(this.oOrganization).then(result => {
            if (result) {
                this.dialog.closeAll();
                this.router.navigateByUrl("/organization-management/" + result.ORGANIZATION_ID);
            }
            this.isLoading = false;
        })
    }

    @HostListener('window:resize', ['$event'])
    onResize(event) {
        this.isMobileView = window.innerWidth < 600;
    }
}
