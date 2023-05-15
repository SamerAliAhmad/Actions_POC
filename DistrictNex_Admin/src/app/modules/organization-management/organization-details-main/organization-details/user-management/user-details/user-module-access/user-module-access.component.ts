import { cloneDeep } from 'lodash';
import { Component, OnInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { SmartrConfirmationService } from 'app/shared/components/confirmation/confirmation.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { Districtnex_module, Organization, Params_Edit_User_districtnex_module_List, User, User_districtnex_module } from 'app/core/Services/proxy.service';

@Component({
    selector: 'user-module-access',
    templateUrl: './user-module-access.component.html',
    styleUrls: ['./user-module-access.component.scss']
})
export class UserModuleAccessComponent implements OnInit {

    value = 50;
    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';

    isProgressSpinnerVisible = false;

    oUser: User;
    oOrganization: Organization;
    
    oList_Districtnex_module: Districtnex_module[];
    oList_User_districtnex_module: User_districtnex_module[];

    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _smartrConfirmationService: SmartrConfirmationService,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        const routes = this.router.url.split('/');
        routes.shift();

        const isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == parseInt(routes[1]));
        }

        this.OrganizationManagementService.get_User_Details(this.oOrganization, this.ActivatedRoute.snapshot.params.userId).then(result => {
            this.oUser = result;
            if (this.oUser.List_User_districtnex_module.length > 0 && !this.oUser.List_User_districtnex_module[0].Districtnex_module) {
                this.oUser.List_User_districtnex_module.forEach(user_districtnex_module => {
                    user_districtnex_module.Districtnex_module = this.CmSvc.oList_Districtnex_module.find(districtnex_module => districtnex_module.DISTRICTNEX_MODULE_ID == user_districtnex_module.DISTRICTNEX_MODULE_ID);
                });
            }
            this.oList_User_districtnex_module = cloneDeep(this.oUser.List_User_districtnex_module);
            var super_organization_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Organization Type", "Super Organization");
            if (this.oOrganization.ORGANIZATION_TYPE_SETUP_ID == super_organization_setup_id) {
                this.oList_Districtnex_module = this.CmSvc.oList_Districtnex_module;
            } else {
                this.oList_Districtnex_module = this.oOrganization.List_Organization_districtnex_module.map(organization_districtnex_module => {
                    return this.CmSvc.oList_Districtnex_module.find(districtnex_module => districtnex_module.DISTRICTNEX_MODULE_ID == organization_districtnex_module.DISTRICTNEX_MODULE_ID);
                });
            }
        });
    }

    isDistrictNexModuleChecked(i_Districtnex_module: Districtnex_module) {
        return this.oList_User_districtnex_module.some(user_districtnex_module => user_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID);
    }

    checkDistrictNexModule(i_Districtnex_module: Districtnex_module) {
        if (this.oList_User_districtnex_module.some(user_districtnex_module => user_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID)) {
            if (i_Districtnex_module.NAME == "Map" && this.oList_User_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME == "Insights")) {
                this.oList_User_districtnex_module.splice(this.oList_User_districtnex_module.findIndex(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME == "Insights"), 1);
            }
            this.oList_User_districtnex_module.splice(this.oList_User_districtnex_module.findIndex(user_districtnex_module => user_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID), 1);
        } else {
            if (this.oUser.List_User_districtnex_module.some(user_districtnex_module => i_Districtnex_module.DISTRICTNEX_MODULE_ID == user_districtnex_module.DISTRICTNEX_MODULE_ID)) {
                this.oList_User_districtnex_module.push(cloneDeep(this.oUser.List_User_districtnex_module.find(user_districtnex_module => user_districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID)));
            } else {
                const oUser_districtnex_module = new User_districtnex_module();
                oUser_districtnex_module.USER_DISTRICTNEX_MODULE_ID = -1;
                oUser_districtnex_module.DISTRICTNEX_MODULE_ID = i_Districtnex_module.DISTRICTNEX_MODULE_ID;
                oUser_districtnex_module.USER_ID = this.oUser.USER_ID;
                oUser_districtnex_module.Districtnex_module = this.oList_Districtnex_module.find(districtnex_module => districtnex_module.DISTRICTNEX_MODULE_ID == i_Districtnex_module.DISTRICTNEX_MODULE_ID);
                this.oList_User_districtnex_module.push(oUser_districtnex_module);
            }
        }
    }

    showInsightsCheck() {
        return this.oList_User_districtnex_module.some(user_districtnex_module => user_districtnex_module.Districtnex_module.NAME == "Map");
    }

    saveUserDistrictNexModules() {
        const oParams_Edit_User_districtnex_module_List = new Params_Edit_User_districtnex_module_List();
        oParams_Edit_User_districtnex_module_List.List_To_Edit = this.oList_User_districtnex_module.filter(user_districtnex_module => user_districtnex_module.USER_DISTRICTNEX_MODULE_ID == -1);
        oParams_Edit_User_districtnex_module_List.List_To_Delete = this.oUser.List_User_districtnex_module.filter(user_districtnex_module => !this.oList_User_districtnex_module.some(oUser_districtnex_module => oUser_districtnex_module.USER_DISTRICTNEX_MODULE_ID == user_districtnex_module.USER_DISTRICTNEX_MODULE_ID)).map(user_districtnex_module => user_districtnex_module.USER_DISTRICTNEX_MODULE_ID);
        this.isProgressSpinnerVisible = true;
        this.OrganizationManagementService.Edit_User_districtnex_module_List(this.oOrganization, this.oUser, oParams_Edit_User_districtnex_module_List).then(result => {
            if (result) {
                this.oList_User_districtnex_module = cloneDeep(this.oUser.List_User_districtnex_module);
                this.CmSvc.Handle_Success();
            }
            this.isProgressSpinnerVisible = false;
        });
    }

    canSaveUserDistrictNexModules() {
        return this.oUser.List_User_districtnex_module.some(user_districtnex_module => !this.oList_User_districtnex_module.some(oUser_districtnex_module => oUser_districtnex_module.USER_DISTRICTNEX_MODULE_ID == user_districtnex_module.USER_DISTRICTNEX_MODULE_ID)) || this.oList_User_districtnex_module.some(user_districtnex_module => user_districtnex_module.USER_DISTRICTNEX_MODULE_ID == -1);
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
                this.oList_User_districtnex_module = cloneDeep(this.oUser.List_User_districtnex_module);
            }
        });
    }
}
