import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { CommonService } from 'app/core/Services/common.service';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { Districtnex_module, Organization, Organization_districtnex_module, Params_Edit_Organization_districtnex_module_List } from 'app/core/Services/proxy.service';
import { cloneDeep } from 'lodash';

@Component({
    selector: 'organization-module-access',
    templateUrl: './organization-module-access.component.html',
    styleUrls: ['./organization-module-access.component.scss']
})
export class OrganizationModuleAccessComponent implements OnInit {

    value = 50;

    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';

    isMyOrganization = false;
    displayProgressSpinner = false;

    oOrganization: Organization;
    
    oList_Districtnex_module: Districtnex_module[];
    oList_Organization_districtnex_module: Organization_districtnex_module[];

    constructor(
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrConfirmationService: SmartrConfirmationService,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        if (this.oOrganization.List_Organization_districtnex_module.length > 0 && !this.oOrganization.List_Organization_districtnex_module[0].Districtnex_module) {
            this.oOrganization.List_Organization_districtnex_module.forEach(organization_districtnex_module => {
                organization_districtnex_module.Districtnex_module = this.CmSvc.oList_Districtnex_module.find(districtnex_module => districtnex_module.DISTRICTNEX_MODULE_ID == organization_districtnex_module.DISTRICTNEX_MODULE_ID);
            });
        }
        this.oList_Districtnex_module = this.CmSvc.oList_Districtnex_module;
        this.oList_Organization_districtnex_module = cloneDeep(this.oOrganization.List_Organization_districtnex_module);
    }

    //#region organization districtnex module
    isDistrictNexModuleChecked(i_Districtnex_module: Districtnex_module) {
        return this.oList_Organization_districtnex_module.some(organization_districtnex_module => organization_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID);
    }

    checkDistrictNexModule(i_Districtnex_module: Districtnex_module) {
        if (this.oList_Organization_districtnex_module.some(organization_districtnex_module => organization_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID)) {
            if (i_Districtnex_module.NAME == "Map" && this.oList_Organization_districtnex_module.some(organization_districtnex_module => organization_districtnex_module.Districtnex_module.NAME == "Insights")) {
                this.oList_Organization_districtnex_module.splice(this.oList_Organization_districtnex_module.findIndex(organization_districtnex_module => organization_districtnex_module.Districtnex_module.NAME == "Insights"), 1);
            }
            this.oList_Organization_districtnex_module.splice(this.oList_Organization_districtnex_module.findIndex(organization_districtnex_module => organization_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID), 1);
        } else {
            if (this.oOrganization.List_Organization_districtnex_module.some(organization_districtnex_module => i_Districtnex_module.DISTRICTNEX_MODULE_ID == organization_districtnex_module.DISTRICTNEX_MODULE_ID)) {
                this.oList_Organization_districtnex_module.push(cloneDeep(this.oOrganization.List_Organization_districtnex_module.find(organization_districtnex_module => organization_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID)));
            } else {
                const oOrganization_districtnex_module = new Organization_districtnex_module();
                oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID = -1;
                oOrganization_districtnex_module.DISTRICTNEX_MODULE_ID = i_Districtnex_module.DISTRICTNEX_MODULE_ID;
                oOrganization_districtnex_module.ORGANIZATION_ID = this.oOrganization.ORGANIZATION_ID;
                oOrganization_districtnex_module.Districtnex_module = this.oList_Districtnex_module.find(districtnex_module => districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID);
                this.oList_Organization_districtnex_module.push(oOrganization_districtnex_module);
            }
        }
    }

    showInsightsCheck() {
        return this.oList_Organization_districtnex_module.some(organization_districtnex_module => organization_districtnex_module.Districtnex_module.NAME == "Map");
    }

    saveOrganizationDistrictNexModules() {
        const oParams_Edit_Organization_districtnex_module_List = new Params_Edit_Organization_districtnex_module_List();
        oParams_Edit_Organization_districtnex_module_List.List_To_Edit = this.oList_Organization_districtnex_module.filter(organization_districtnex_module => organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == -1);
        oParams_Edit_Organization_districtnex_module_List.List_To_Delete = this.oOrganization.List_Organization_districtnex_module.filter(organization_districtnex_module => !this.oList_Organization_districtnex_module.some(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID)).map(organization_districtnex_module => organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID);
        this.displayProgressSpinner = true;
        this.OrganizationManagementService.Edit_Organization_districtnex_module_List(this.oOrganization, oParams_Edit_Organization_districtnex_module_List).then(result => {
            if (result) {
                this.oList_Organization_districtnex_module = cloneDeep(this.oOrganization.List_Organization_districtnex_module);
                this.CmSvc.Handle_Success();
            }
            this.displayProgressSpinner = false;
        });
    }

    canSaveOrganizationDistrictNexModules() {
        return this.oOrganization.List_Organization_districtnex_module.some(organization_districtnex_module => !this.oList_Organization_districtnex_module.some(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID)) || this.oList_Organization_districtnex_module.some(organization_districtnex_module => organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == -1);
    }

    resetDistrictnexModule() {
        const dialogRef = this._smartrConfirmationService.open({
            title: 'Confirm Reset',
            message: 'Are you sure you want to reset to the last time this entity was saved?',
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
                this.oList_Organization_districtnex_module = cloneDeep(this.oOrganization.List_Organization_districtnex_module);
            }
        });
    }
    //#endregion
}
