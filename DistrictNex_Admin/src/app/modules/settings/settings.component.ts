import { Subject } from 'rxjs';
import { cloneDeep } from 'lodash';
import { Chart } from 'highcharts';
import { SettingsService } from './settings.service';
import { MatDialog } from '@angular/material/dialog';
import { ThemePalette } from '@angular/material/core';
import { CommonService } from 'app/core/Services/common.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { DefaultPictureModalComponent } from './default-picture-modal/default-picture-modal.component';
import { Default_chart_color, Default_settings, Organization, Params_Delete_Default_Settings_Picture, Params_Edit_Default_chart_color_List, Setup } from 'app/core/Services/proxy.service';

@Component({
    selector: 'settings',
    templateUrl: './settings.component.html',
    styleUrls: ['./settings.component.scss']
})

export class SettingsComponent implements OnInit {

    value = 50;
    matTabIndex = 0;

    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';

    loading = false;
    isShowAdmin = false;
    isThereChange = false;
    openPrimaryColorPicker = false;
    isProgressSpinnerVisible = false;
    openSecondaryColorPicker = false;

    oList_Image_Type_Setup: Setup[];

    oDefault_settings: Default_settings;
    oOriginal_Default_settings: Default_settings;

    oChart: Chart;
    themeForm: FormGroup;
    oOrganization_Details: Organization;

    oList_Color_Picker: boolean[] = [];
    oList_Default_Chart_Color: Default_chart_color[];

    oParams_Edit_Default_Chart_Color_List = new Params_Edit_Default_chart_color_List();

    private _unsubscribeAll = new Subject<void>();

    constructor(
        public dialog: MatDialog,
        private CmSvc: CommonService,
        private _formBuilder: FormBuilder,
        private SettingsService: SettingsService,
        private _changeDetectorRef: ChangeDetectorRef,
        private _smartrConfirmationService: SmartrConfirmationService,
    ) {
        this.oList_Image_Type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Image Type")[0].List_Setup;
    }

    ngOnInit(): void {
        this.refreshData();
        this.Get_Default_Chart_Color_List()
    }

    Get_Default_Chart_Color_List() {
        this.SettingsService.Get_Default_Chart_Color_List().then(result => {
            this.oList_Color_Picker = [];
            this.oList_Default_Chart_Color = result;
            result.forEach(oDefault_chart_color => {
                this.oList_Color_Picker.push(false);
            })
        })
    }

    Edit_Default_Chart_Color_List(i_List_Default_chart_color: Default_chart_color[]) {
        this.SettingsService.Edit_Default_Chart_Color_List(i_List_Default_chart_color).then(result => {
            this.oParams_Edit_Default_Chart_Color_List = result;
        })
    }

    refreshData() {
        this.oDefault_settings = this.CmSvc.defaultSettings;
        this.themeForm = this.initializeForm();
        this.oOriginal_Default_settings = cloneDeep(this.oDefault_settings);
        this.isThereChange = false;

        this.themeForm.controls.mainColors.valueChanges.subscribe(() => {
            this.isThereChange = true;
        });
        this.themeForm.controls.dataSettings.valueChanges.subscribe(() => {
            this.isThereChange = true;
        });
    }

    initializeForm(): FormGroup {
        return this._formBuilder.group({
            mainColors: this._formBuilder.group({
                PRIMARY_COLOR: [this.oDefault_settings.PLATFORM_PRIMARY || this.CmSvc.defaultSettings.PLATFORM_PRIMARY, Validators.required],
                SECONDARY_COLOR: [this.oDefault_settings.PLATFORM_BUTTON || this.CmSvc.defaultSettings.PLATFORM_BUTTON, Validators.required],
                IS_SHOW_ADMIN: [true],
            }),
            dataSettings: this._formBuilder.group({
                dataRetention: [this.oDefault_settings.DATA_RETENTION_PERIOD || this.CmSvc.defaultSettings.DATA_RETENTION_PERIOD, Validators.required],
                otpDurationInSeconds: [this.oDefault_settings.OTP_TTL_IN_SECONDS || this.CmSvc.defaultSettings.OTP_TTL_IN_SECONDS, Validators.required],
                ticketDurationInMinutes: [this.oDefault_settings.TICKET_DURATION_IN_MINUTES || this.CmSvc.defaultSettings.TICKET_DURATION_IN_MINUTES, [Validators.required, Validators.min(60)]],
                mapBoxGlToken: [this.oDefault_settings.MAPBOX_GL_TOKEN || this.CmSvc.defaultSettings.MAPBOX_GL_TOKEN, Validators.required],
                googleMapApiToken: [this.oDefault_settings.GOOGLE_MAP_API_TOKEN || this.CmSvc.defaultSettings.GOOGLE_MAP_API_TOKEN, Validators.required],
                telusRequestID: [this.oDefault_settings.TELUS_REQUEST_ID || this.CmSvc.defaultSettings.TELUS_REQUEST_ID, Validators.required],
            })
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

    loadChart() {
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
            "series": this.oList_Default_Chart_Color.map(oDefault_chart_color => {
                return {
                    "name": oDefault_chart_color.Data_level_setup.VALUE,
                    "data": [Math.round(Math.random() * 10), Math.round(Math.random() * 10), Math.round(Math.random() * 10), Math.round(Math.random() * 10), Math.round(Math.random() * 10)],
                    "type": "line",
                    "color": oDefault_chart_color.COLOR
                }
            })

        })
    }

    goToTab(tabNumber: number) {
        if (tabNumber != null) {
            this.matTabIndex = tabNumber;
            if (this.matTabIndex == 1) {
                this._changeDetectorRef.detectChanges();
                this.loadChart();
            }
        }
    }

    updateChartColors() {
        if (this.oChart) {
            this.oChart.series.forEach((serie, i) => {
                serie.options.color = this.oList_Default_Chart_Color[i].COLOR;
                serie.update(serie.options);
            });
            this.isThereChange = true;
        }
    }

    checkMainColorsDefaultTheme(event) {
        if (event.checked) {
            this.themeForm.get('mainColors').get('PRIMARY_COLOR').setValue(this.CmSvc.defaultSettings.PLATFORM_PRIMARY);
            this.themeForm.get('mainColors').get('PRIMARY_COLOR').disable();
            this.themeForm.get('mainColors').get('SECONDARY_COLOR').setValue(this.CmSvc.defaultSettings.PLATFORM_BUTTON);
            this.themeForm.get('mainColors').get('SECONDARY_COLOR').disable();
        } else {
            this.themeForm.get('mainColors').get('PRIMARY_COLOR').enable();
            this.themeForm.get('mainColors').get('SECONDARY_COLOR').enable();
        }
    }

    checkChartColorsDefaultTheme(event) {
        if (event.checked) {
            this.themeForm.get('chartColors').get('CHART_1_COLOR').setValue(this.CmSvc.defaultSettings.List_Default_chart_color[0].COLOR);
            this.themeForm.get('chartColors').get('CHART_1_COLOR').disable();
            this.themeForm.get('chartColors').get('CHART_2_COLOR').setValue(this.CmSvc.defaultSettings.List_Default_chart_color[1].COLOR);
            this.themeForm.get('chartColors').get('CHART_2_COLOR').disable();
            this.themeForm.get('chartColors').get('CHART_3_COLOR').setValue(this.CmSvc.defaultSettings.List_Default_chart_color[2].COLOR);
            this.themeForm.get('chartColors').get('CHART_3_COLOR').disable();
        } else {
            this.themeForm.get('chartColors').get('CHART_1_COLOR').enable();
            this.themeForm.get('chartColors').get('CHART_2_COLOR').enable();
            this.themeForm.get('chartColors').get('CHART_3_COLOR').enable();
        }
    }

    editDefaultSettings() {
        this.oDefault_settings.PLATFORM_PRIMARY = this.themeForm.get('mainColors').get('PRIMARY_COLOR').value;
        this.oDefault_settings.PLATFORM_BUTTON = this.themeForm.get('mainColors').get('SECONDARY_COLOR').value;
        this.Edit_Default_Chart_Color_List(this.oList_Default_Chart_Color);
        this.oDefault_settings.DATA_RETENTION_PERIOD = this.themeForm.get('dataSettings').get('dataRetention').value;
        this.oDefault_settings.OTP_TTL_IN_SECONDS = this.themeForm.get('dataSettings').get('otpDurationInSeconds').value;
        this.oDefault_settings.TICKET_DURATION_IN_MINUTES = this.themeForm.get('dataSettings').get('ticketDurationInMinutes').value;
        this.oDefault_settings.MAPBOX_GL_TOKEN = this.themeForm.get('dataSettings').get('mapBoxGlToken').value;
        this.oDefault_settings.GOOGLE_MAP_API_TOKEN = this.themeForm.get('dataSettings').get('googleMapApiToken').value;
        this.oDefault_settings.TELUS_REQUEST_ID = this.themeForm.get('dataSettings').get('telusRequestID').value;
        this.loading = true;
        this.SettingsService.EditDefaultSettings(this.oDefault_settings).then(() => {
            this.refreshData();
            this.loading = false;
        })
    }

    resetOrganizationTheme(): void {
        this.oDefault_settings.PLATFORM_PRIMARY = cloneDeep(this.oOriginal_Default_settings.PLATFORM_PRIMARY);
        this.oDefault_settings.PLATFORM_BUTTON = cloneDeep(this.oOriginal_Default_settings.PLATFORM_BUTTON);
        this.oDefault_settings.List_Default_chart_color[0].COLOR = cloneDeep(this.oOriginal_Default_settings.List_Default_chart_color[0].COLOR);
        this.oDefault_settings.List_Default_chart_color[1].COLOR = cloneDeep(this.oOriginal_Default_settings.List_Default_chart_color[1].COLOR);
        this.oDefault_settings.List_Default_chart_color[2].COLOR = cloneDeep(this.oOriginal_Default_settings.List_Default_chart_color[2].COLOR);
        this.oDefault_settings.DATA_RETENTION_PERIOD = cloneDeep(this.oOriginal_Default_settings.DATA_RETENTION_PERIOD);

        this.themeForm.get('mainColors').get('PRIMARY_COLOR').patchValue(this.oOriginal_Default_settings.PLATFORM_PRIMARY)
        this.themeForm.get('mainColors').get('SECONDARY_COLOR').patchValue(this.oOriginal_Default_settings.PLATFORM_BUTTON)
        this.themeForm.get('chartColors').get('CHART_1_COLOR').patchValue(this.oOriginal_Default_settings.List_Default_chart_color[0].COLOR);
        this.themeForm.get('chartColors').get('CHART_2_COLOR').patchValue(this.oOriginal_Default_settings.List_Default_chart_color[1].COLOR);
        this.themeForm.get('chartColors').get('CHART_3_COLOR').patchValue(this.oOriginal_Default_settings.List_Default_chart_color[2].COLOR);
        this.themeForm.get('dataSettings').get('dataRetention').patchValue(this.oOriginal_Default_settings.DATA_RETENTION_PERIOD);
        this.themeForm.get('dataSettings').get('otpDurationInSeconds').patchValue(this.oOriginal_Default_settings.OTP_TTL_IN_SECONDS);
        this.themeForm.get('dataSettings').get('ticketDurationInMinutes').patchValue(this.oOriginal_Default_settings.TICKET_DURATION_IN_MINUTES);
        this.themeForm.get('dataSettings').get('mapBoxGlToken').patchValue(this.oOriginal_Default_settings.MAPBOX_GL_TOKEN);
        this.themeForm.get('dataSettings').get('googleMapApiToken').patchValue(this.oOriginal_Default_settings.GOOGLE_MAP_API_TOKEN);

        this.isThereChange = false;
    }

    openChangePictureDialog(Image_Type_Setup_Value: string, isIco: boolean): void {
        const dialogRef = this.dialog.open(DefaultPictureModalComponent, {
            width: '400px',
            data: {
                isIco: isIco,
                imageTypeSetupID: this.oList_Image_Type_Setup.filter(x => x.VALUE == Image_Type_Setup_Value)[0].SETUP_ID,
                imageTypeSetupValue: Image_Type_Setup_Value
            },
            autoFocus: false
        })
        dialogRef.afterClosed().subscribe(() => {
            this.oDefault_settings = this.CmSvc.defaultSettings;
        });
    }

    deletePicture(Image_Type_Setup_Value): void {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Delete',
            message: 'Are you sure you want to delete this image?',
            actions: {
                confirm: {
                    show: true,
                    label: 'Yes',
                    color: 'warn',
                },
                cancel: {
                    show: true,
                    label: 'No',
                }
            }
        });
        dialogRef.afterClosed().subscribe((result) => {
            if (result === 'confirmed') {
                this.isProgressSpinnerVisible = true;
                const oParams_Delete_Default_Settings_Picture: Params_Delete_Default_Settings_Picture = new Params_Delete_Default_Settings_Picture();
                oParams_Delete_Default_Settings_Picture.IMAGE_TYPE_SETUP_ID = this.oList_Image_Type_Setup.filter(x => x.VALUE == Image_Type_Setup_Value)[0].SETUP_ID;
                this.SettingsService.deleteFile(oParams_Delete_Default_Settings_Picture, Image_Type_Setup_Value).then(result => {
                    if (result == true) {
                        this.CmSvc.ShowMessage('Picture Removed');
                        this.oDefault_settings = this.CmSvc.defaultSettings;
                    }
                    this.isProgressSpinnerVisible = false;
                })
            }
        });
    }

    ngOnDestroy() {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
