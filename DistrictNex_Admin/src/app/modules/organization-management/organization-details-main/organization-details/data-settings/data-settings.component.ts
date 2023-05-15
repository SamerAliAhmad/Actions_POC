import { cloneDeep } from 'lodash-es';
import { NgForm } from '@angular/forms';
import { Location } from '@angular/common';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { CommonService } from 'app/core/Services/common.service';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { Organization, Organization_log_config, Params_Edit_Organization_log_config_List, Params_Modify_Data_Settings, Setup } from 'app/core/Services/proxy.service';

@Component({
    selector: 'data-settings',
    templateUrl: './data-settings.component.html',
    styleUrls: ['./data-settings.component.scss']
})
export class DataSettingsComponent implements OnInit {

    oOrganization: Organization;

    oList_Log_type_Setup: Setup[] = [];
    oList_Organization_log_config: Organization_log_config[];

    oParams_Modify_Data_Settings: Params_Modify_Data_Settings = new Params_Modify_Data_Settings();

    isLoading = false;
    isMyOrganization = false;

    constructor(
        private Location: Location,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrConfirmationService: SmartrConfirmationService,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Log_type_Setup = this.CmSvc.oList_Setup_category.filter(setupCategory => setupCategory.SETUP_CATEGORY_NAME == "Log Type")[0].List_Setup.sort((a, b) => a.VALUE.localeCompare(b.VALUE));
    }

    ngOnInit(): void {
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        this.oParams_Modify_Data_Settings.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
        this.oParams_Modify_Data_Settings.DATA_RETENTION_PERIOD = this.oOrganization.DATA_RETENTION_PERIOD;
        this.oParams_Modify_Data_Settings.TICKET_DURATION_IN_MINUTES = this.oOrganization.TICKET_DURATION_IN_MINUTES;
        this.oList_Organization_log_config = cloneDeep(this.oOrganization.List_Organization_log_config);
    }

    isLogConfigChecked(i_Log_type_Setup: Setup) {
        return this.oList_Organization_log_config.some(organization_log_config => organization_log_config.LOG_TYPE_SETUP_ID == i_Log_type_Setup.SETUP_ID);
    }

    checkLogConfig(i_Log_type_Setup: Setup) {
        if (this.oList_Organization_log_config.some(organization_log_config => organization_log_config.LOG_TYPE_SETUP_ID == i_Log_type_Setup.SETUP_ID)) {
            this.oList_Organization_log_config.splice(this.oList_Organization_log_config.findIndex(organization_log_config => organization_log_config.LOG_TYPE_SETUP_ID == i_Log_type_Setup.SETUP_ID), 1);
        } else {
            if (this.oOrganization.List_Organization_log_config.some(organization_log_config => i_Log_type_Setup.SETUP_ID == organization_log_config.LOG_TYPE_SETUP_ID)) {
                this.oList_Organization_log_config.push(cloneDeep(this.oOrganization.List_Organization_log_config.find(organization_log_config => organization_log_config.LOG_TYPE_SETUP_ID == i_Log_type_Setup.SETUP_ID)));
            } else {
                const oOrganization_log_config = new Organization_log_config();
                oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID = -1;
                oOrganization_log_config.LOG_TYPE_SETUP_ID = i_Log_type_Setup.SETUP_ID;
                oOrganization_log_config.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                oOrganization_log_config.Log_type_setup = this.oList_Log_type_Setup.find(log_type_setup => log_type_setup.SETUP_ID == i_Log_type_Setup.SETUP_ID);
                this.oList_Organization_log_config.push(oOrganization_log_config);
            }
        }
    }

    canSaveOrganizationLogConfig() {
        return this.oOrganization.List_Organization_log_config.some(organization_log_config => !this.oList_Organization_log_config.some(oOrganization_log_config => oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID == organization_log_config.ORGANIZATION_LOG_CONFIG_ID)) || this.oList_Organization_log_config.some(organization_log_config => organization_log_config.ORGANIZATION_LOG_CONFIG_ID == -1);
    }

    editChosenLogTypes(organizationRetentionPeriodForm: NgForm) {
        if (organizationRetentionPeriodForm.valid || this.canSaveOrganizationLogConfig()) {
            this.oParams_Modify_Data_Settings.Params_Edit_Organization_log_config_List = new Params_Edit_Organization_log_config_List();
            this.oParams_Modify_Data_Settings.Params_Edit_Organization_log_config_List.List_To_Edit = this.oList_Organization_log_config.filter(organization_log_config => organization_log_config.ORGANIZATION_LOG_CONFIG_ID == -1);
            this.oParams_Modify_Data_Settings.Params_Edit_Organization_log_config_List.List_To_Delete = this.oOrganization.List_Organization_log_config.filter(organization_log_config => !this.oList_Organization_log_config.some(oOrganization_log_config => oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID == organization_log_config.ORGANIZATION_LOG_CONFIG_ID)).map(organization_log_config => organization_log_config.ORGANIZATION_LOG_CONFIG_ID);
            this.isLoading = true;
            this.OrganizationManagementService.modifyDataSettings(this.oParams_Modify_Data_Settings).then(result => {
                if (result) {
                    organizationRetentionPeriodForm.form.markAsPristine();
                    this.oParams_Modify_Data_Settings.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                    this.oParams_Modify_Data_Settings.DATA_RETENTION_PERIOD = this.oOrganization.DATA_RETENTION_PERIOD;
                    this.oParams_Modify_Data_Settings.TICKET_DURATION_IN_MINUTES = this.oOrganization.TICKET_DURATION_IN_MINUTES;
                    this.oList_Organization_log_config = cloneDeep(this.oOrganization.List_Organization_log_config);
                    this.CmSvc.ShowMessage("Changes Saved.");
                }
                this.isLoading = false;
            });
        } else {
            this.CmSvc.ShowMessage("Some data is missing or wrong");
            return;
        }
    }

    resetChosenLogList(organizationRetentionPeriodForm: NgForm): void {
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
                this.oParams_Modify_Data_Settings.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                this.oParams_Modify_Data_Settings.DATA_RETENTION_PERIOD = this.oOrganization.DATA_RETENTION_PERIOD;
                this.oParams_Modify_Data_Settings.TICKET_DURATION_IN_MINUTES = this.oOrganization.TICKET_DURATION_IN_MINUTES;
                this.oList_Organization_log_config = cloneDeep(this.oOrganization.List_Organization_log_config);
                organizationRetentionPeriodForm.form.markAsPristine();
            }
        });
    }

    goBack(): void {
        this.Location.back();
    }
}
