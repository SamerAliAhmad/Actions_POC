import { animate, style, transition, trigger } from '@angular/animations';
import { Component, EventEmitter, OnDestroy, OnInit, Output } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Organization_data_source_kpi_with_Direction } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Alert, Alert_settings, Organization_data_source_kpi, Params_Edit_Alert_settings_List, Setup } from 'app/core/Services/proxy.service';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { ArrayFilterPipe } from 'app/shared/pipes/array-filter.pipe';
import { TimezoneService } from 'app/shared/services/timezone.service';
import { cloneDeep } from 'lodash';
import { Subject, takeUntil } from 'rxjs';
import { MapService } from '../map.service';

@Component({
    selector: 'alerts-drawer',
    templateUrl: './alerts-drawer.component.html',
    styleUrls: ['./alerts-drawer.component.scss'],
    animations: [
        trigger('expandableState', [
            transition(':enter', [
                style({ height: '0' }),
                animate('200ms ease-in-out', style({ height: '*' })),
            ]),
            transition(':leave', [
                style({ height: '*' }),
                animate('200ms ease-in-out', style({ height: '0' })),
            ]),
        ])
    ]
})
export class AlertsDrawerComponent implements OnInit, OnDestroy {

    @Output() CloseDrawerEventEmitter = new EventEmitter<void>();

    oList_Alert: Alert[];
    oList_Site_Alert: Alert[] = [];
    oList_Area_Alert: Alert[] = [];
    oList_Alert_Original: Alert[] = [];
    oList_District_Alert: Alert[] = [];

    page = 1;
    searchInputValue = "";
    oList_Site_Alert_To_Show: Alert[] = [];
    oList_Area_Alert_To_Show: Alert[] = [];
    oList_District_Alert_To_Show: Alert[] = [];

    oList_Alert_operation_Setup: Setup[] = [];
    oList_Alert_value_type_Setup: Setup[] = [];
    oList_Alert_settings: Alert_settings[] = [];
    oList_Organization_data_source_kpi_with_alerts: Organization_data_source_kpi[] = [];
    oList_Organization_data_source_kpi_with_Direction: Organization_data_source_kpi_with_Direction[];

    isLoading = false;
    openDataLevel = null;
    isShowSettings = false;
    oOrganization_data_source_kpi_with_Direction: Organization_data_source_kpi_with_Direction;

    private _unsubscribeAll = new Subject<void>();

    constructor(
        private CmSvc: CommonService,
        private MapService: MapService,
        public TimezoneService: TimezoneService,
        private ArrayFilterPipe: ArrayFilterPipe,
        private _smartrConfirmationService: SmartrConfirmationService,
    ) {
        this.oList_Organization_data_source_kpi_with_alerts = this.CmSvc.oList_Organization_data_source_kpi.filter(oORGANIZATION_DATA_SOURCE_KPI_ID => oORGANIZATION_DATA_SOURCE_KPI_ID.Kpi.HAS_ALERTS);
        this.oList_Alert_operation_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Operation").List_Setup;
        this.oList_Alert_value_type_Setup = this.CmSvc.oList_Setup_category.find(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Alert Value Type").List_Setup;
        this.oList_Organization_data_source_kpi_with_Direction = [];
        this.oList_Organization_data_source_kpi_with_alerts.forEach(oORGANIZATION_DATA_SOURCE_KPI_ID => {
            this.oList_Alert_operation_Setup.forEach(setup => {
                if (oORGANIZATION_DATA_SOURCE_KPI_ID.Kpi.NAME == "Bylaw Complaints" && setup.SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Alert Operation", "Drop")) {
                    return;
                }
                this.oList_Organization_data_source_kpi_with_Direction.push({
                    Organization_data_source_kpi: oORGANIZATION_DATA_SOURCE_KPI_ID,
                    Alert_operation_Setup: setup,
                });
            });
        });
    }

    ngOnInit(): void {
        this.fetchAlerts();
        this.MapService.Get_Alert_settings().then(result => {
            this.oList_Alert_settings = cloneDeep(result);
        });
        this.MapService.oApply_Filter_Subject.pipe(takeUntil(this._unsubscribeAll)).subscribe(() => {
            this.fetchAlerts();
        });
    }

    fetchAlerts() {
        this.MapService.Get_Alerts_For_Levels({
            ALERT_ID_LIST: null,
            IS_ACKNOWLEDGED: null,
            ORGANIZATION_DATA_SOURCE_KPI_ID_LIST: this.CmSvc.oList_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.HAS_ALERTS).map(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID),
            USER_ID_LIST: [this.CmSvc.oUser_Details.USER_ID],
            END_DATE: this.MapService.oEnd_Date_Filter.toISOString(),
            START_DATE: this.MapService.oStart_Date_Filter.toISOString(),
            DISTRICT_ID_LIST: this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST.map(oDistrict => oDistrict.DISTRICT_ID),
            AREA_ID_LIST: this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST.map(oArea => oArea.AREA_ID),
            SITE_ID_LIST: this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST.map(oSite => oSite.SITE_ID),
        }).then(result => {
            this.oList_Alert_Original = result;
            this.sortAlerts();
        });
    }

    sortAlerts() {
        this.oList_Alert = cloneDeep(this.oList_Alert_Original);
        if (this.oOrganization_data_source_kpi_with_Direction) {
            this.oList_Alert = this.oList_Alert.filter(alert => alert.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oOrganization_data_source_kpi_with_Direction.Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID && alert.OPERATION_TYPE_SETUP_ID == this.oOrganization_data_source_kpi_with_Direction.Alert_operation_Setup.SETUP_ID);
        }
        this.oList_Alert = this.oList_Alert.sort((a, b) => {
            if (a.IS_ACKNOWLEDGED !== b.IS_ACKNOWLEDGED) {
                return a.IS_ACKNOWLEDGED ? 1 : -1;
            } else {
                return new Date(b.RECORD_DATE).getTime() - new Date(a.RECORD_DATE).getTime();
            }
        });
        this.oList_Site_Alert = this.oList_Alert.filter(alert => alert.LEVEL_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "site"));
        this.oList_Area_Alert = this.oList_Alert.filter(alert => alert.LEVEL_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "area"));
        this.oList_District_Alert = this.oList_Alert.filter(alert => alert.LEVEL_SETUP_ID == this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Data level", "district"));
        this.fixPaginatedAlerts();
    }

    acknowledgeAlert(i_Alert: Alert) {
        this.MapService.Acknowledge_Alert(i_Alert).then(() => {
            this.oList_Alert_Original.find(alert => alert.ALERT_ID == i_Alert.ALERT_ID).IS_ACKNOWLEDGED = true;
            this.MapService.oUpdate_Alert_Count_Subject.next(-1);
            this.sortAlerts();
        });
    }

    acknowledgeAlertList(i_List_Alert: Alert[]) {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Acknowledgement',
            message: 'Are you sure you want to acknowledge all the alerts in the selected level?',
            actions: {
                confirm: {
                    show: true,
                    label: 'Yes',
                    color: 'primary',
                },
                cancel: {
                    show: true,
                    label: 'No',
                }
            }
        });

        dialogRef.afterClosed().subscribe((result) => {
            if (result === 'confirmed') {
                i_List_Alert = i_List_Alert.filter(alert => !alert.IS_ACKNOWLEDGED);
                this.MapService.Acknowledge_Alert_List(i_List_Alert).then(() => {
                    i_List_Alert.forEach(oAlert => {
                        this.oList_Alert_Original.find(alert => alert.ALERT_ID == oAlert.ALERT_ID).IS_ACKNOWLEDGED = true;
                    });
                    this.MapService.oUpdate_Alert_Count_Subject.next(-i_List_Alert.length);
                    this.sortAlerts();
                });
            }
        });
    }

    showAcknowledgeAll(i_List_Alert: Alert[]) {
        return i_List_Alert.some(alert => !alert.IS_ACKNOWLEDGED);
    }

    toggleOpenDataLevel(dataLevel: number) {
        this.page = 1;
        this.fixPaginatedAlerts();
        if (this.openDataLevel == dataLevel) {
            this.openDataLevel = null;
        } else {
            this.openDataLevel = dataLevel;
        }
    }

    fixPaginatedAlerts() {
        switch (this.openDataLevel) {
            case 0:
                this.oList_District_Alert_To_Show = this.oList_District_Alert.slice(0, 20 * this.page);
                if (this.ArrayFilterPipe.transform(this.oList_District_Alert_To_Show, this.searchInputValue).length < 20 && this.oList_District_Alert.length > 20 * this.page) {
                    this.page++;
                    this.fixPaginatedAlerts();
                }
                break;
            case 1:
                this.oList_Area_Alert_To_Show = this.oList_Area_Alert.slice(0, 20 * this.page);
                if (this.ArrayFilterPipe.transform(this.oList_Area_Alert_To_Show, this.searchInputValue).length < 20 && this.oList_Area_Alert.length > 20 * this.page) {
                    this.page++;
                    this.fixPaginatedAlerts();
                }
                break;
            case 2:
                this.oList_Site_Alert_To_Show = this.oList_Site_Alert.slice(0, 20 * this.page);
                if (this.ArrayFilterPipe.transform(this.oList_Site_Alert_To_Show, this.searchInputValue).length < 20 && this.oList_Site_Alert.length > 20 * this.page) {
                    this.page++;
                    this.fixPaginatedAlerts();
                }
                break;
            default:
                this.oList_District_Alert_To_Show = this.oList_District_Alert.slice(0, 20 * this.page);
                this.oList_Area_Alert_To_Show = this.oList_Area_Alert.slice(0, 20 * this.page);
                this.oList_Site_Alert_To_Show = this.oList_Site_Alert.slice(0, 20 * this.page);
                break;
        }
    }

    onScrollDown() {
        this.page++;
        this.fixPaginatedAlerts();
    }

    getKpiName(i_Alert: Alert) {
        return this.oList_Organization_data_source_kpi_with_alerts.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == i_Alert.ORGANIZATION_DATA_SOURCE_KPI_ID)?.Kpi.NAME;
    }

    getKeyword2(i_Alert: Alert) {
        return i_Alert.VALUE_TYPE_SETUP_ID == this.oList_Alert_operation_Setup.find(setup => setup.VALUE.toLowerCase() == "drop").SETUP_ID ? 'Dropped' : 'Spiked';
    }

    getObjectName(i_Alert: Alert) {
        return (i_Alert.Object as any).NAME;
    }

    addAlertSettings() {
        const oAlert_settings = new Alert_settings();
        oAlert_settings.ALERT_SETTINGS_ID = -1;
        oAlert_settings.IS_ACTIVE = true;
        oAlert_settings.USER_ID = this.CmSvc.oUser_Details.USER_ID;
        this.oList_Alert_settings.push(oAlert_settings);
    }

    removeAlertSettings(i_Alert_settings: Alert_settings, alertSettingsForm: NgForm) {
        this.oList_Alert_settings.splice(this.oList_Alert_settings.indexOf(i_Alert_settings), 1);
        alertSettingsForm.form.markAsDirty();
    }

    editAlertSettings(alertSettingsForm: NgForm) {
        if (alertSettingsForm.invalid) {
            this.CmSvc.ShowMessage("Some data is missing or wrong");
            return;
        }
        const oParams_Edit_Alert_settings_List = new Params_Edit_Alert_settings_List();
        oParams_Edit_Alert_settings_List.List_To_Edit = this.oList_Alert_settings;
        oParams_Edit_Alert_settings_List.List_To_Delete = this.CmSvc.oList_Alert_settings.filter(alert_settings => !this.oList_Alert_settings.some(oAlert_settings => oAlert_settings.ALERT_SETTINGS_ID == alert_settings.ALERT_SETTINGS_ID)).map(alert_settings => alert_settings.ALERT_SETTINGS_ID);
        this.isLoading = true;
        this.MapService.Edit_Alert_settings_List(oParams_Edit_Alert_settings_List).then(result => {
            this.isLoading = false;
            this.oList_Alert_settings = cloneDeep(this.CmSvc.oList_Alert_settings);
            alertSettingsForm.form.markAsPristine();
        });
    }

    resetAlertSettings(alertSettingsForm: NgForm): void {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Reset',
            message: 'Are you sure you want to reset to the last time data settings were saved?',
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
                this.oList_Alert_settings = cloneDeep(this.CmSvc.oList_Alert_settings);
                alertSettingsForm.form.markAsPristine();
            }
        });
    }

    ngOnDestroy(): void {
        this._unsubscribeAll.next();
        this._unsubscribeAll.complete();
    }
}
