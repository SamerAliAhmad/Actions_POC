import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { MatDialog } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Area, District, Entity, Organization, Params_Edit_Area_kpi_user_access_List, Params_Edit_District_kpi_user_access_List, Params_Edit_Entity_kpi_user_access_List, Params_Edit_Site_kpi_user_access_List, Params_Edit_User_Data_Access, Setup, Site, User, User_Data_Access, User_level_access } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { cloneDeep } from 'lodash';
import { UserDataAccessModalComponent } from './user-data-access-modal/user-data-access-modal.component';

@Component({
    selector: 'user-data-access',
    templateUrl: './user-data-access.component.html',
    styleUrls: ['./user-data-access.component.scss']
})
export class UserDataAccessComponent implements OnInit {
    value = 50;
    pageSize = 20;
    pageIndex = 0;

    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';

    oUser: User;
    oOrganization: Organization;
    oUser_data_access: User_Data_Access;
    oList_User_level_access: User_level_access[];


    oList_Site_With_Kpi: Site[];
    oList_Area_With_Kpi: Area[];
    oList_Entity_With_Kpi: Entity[];
    oList_District_With_Kpi: District[];

    oList_Site: Site[];
    oList_Area: Area[];
    oList_Entity: Entity[];
    oList_District: District[];

    oList_Data_access_level_setup: Setup[];
    oSelected_Data_access_level_Setup: Setup;

    isFetchingSites = false;
    isFetchingAreas = false;
    isMyOrganization = false;
    isFetchingEntities = false;
    isFetchingDistricts = false;
    isFetchingTopLevels = false;
    previousExpansionValue = false;
    displayProgressSpinner = false;

    searchInputValue = '';

    constructor(
        private Router: Router,
        private dialog: MatDialog,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _changeDetectorRef: ChangeDetectorRef,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Data_access_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup;
        this.oList_Data_access_level_setup = this.oList_Data_access_level_setup.filter(oSetup => oSetup.VALUE != "Top-Level");
        this.oList_Data_access_level_setup = this.oList_Data_access_level_setup.filter(oSetup => oSetup.VALUE != "Floor");
        this.oList_Data_access_level_setup = this.oList_Data_access_level_setup.filter(oSetup => oSetup.VALUE != "Space");
        this.oSelected_Data_access_level_Setup = this.oList_Data_access_level_setup[0];
    }

    ngOnInit(): void {
        const routes = this.Router.url.split('/');
        routes.shift();

        const isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == parseInt(routes[1]));
        }
        this.OrganizationManagementService.get_User_Details(this.oOrganization, this.ActivatedRoute.snapshot.params.userId).then(result => {
            this.oUser = cloneDeep(result);

            this.OrganizationManagementService.Get_User_Data_Access(this.oOrganization, this.oUser).then(result => {
                this.oList_District_With_Kpi = result.LIST_DISTRICT;
                this.oList_Area_With_Kpi = result.LIST_AREA;
                this.oList_Site_With_Kpi = result.LIST_SITE;
                this.oList_Entity_With_Kpi = result.LIST_ENTITY;
                this.oUser_data_access = cloneDeep(result);
            })
            this.OrganizationManagementService.Get_User_Entity_By_ENTITY_ID_List(this.oUser).then(result => {
                this.oList_Entity = result;
            });
            this.OrganizationManagementService.Get_User_Site_By_SITE_ID_List(this.oUser).then(result => {
                this.oList_Site = result;
            });
            this.OrganizationManagementService.Get_User_Area_By_AREA_ID_List(this.oUser).then(result => {
                this.oList_Area = result;
            });
            this.OrganizationManagementService.Get_User_District_By_DISTRICT_ID_List(this.oUser).then(result => {
                this.oList_District = result;
            });
        });
    }

    getLevels() {
        switch (this.oSelected_Data_access_level_Setup.SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return this.oList_Entity;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District;
        }
        this.pageIndex = 0;
        this.detectChanges();
    }

    disableAddButton() {
        return (
            (this.oSelected_Data_access_level_Setup.VALUE == 'District' && !this.oList_District) ||
            (this.oSelected_Data_access_level_Setup.VALUE == 'Area' && !this.oList_Area) ||
            (this.oSelected_Data_access_level_Setup.VALUE == 'Site' && !this.oList_Site) ||
            (this.oSelected_Data_access_level_Setup.VALUE == 'Entity' && !this.oList_Entity)
        );
    }

    isDataLoaded() {
        return (this.oUser_data_access && this.oList_District && this.oList_Area && this.oList_Site && this.oList_Entity);
    }

    getSetupValue(Data_level_setup_ID: number): string {
        return this.oList_Data_access_level_setup.find(setup => setup.SETUP_ID == Data_level_setup_ID)?.VALUE ?? "Choose Data Level First";
    }

    detectChanges() {
        this._changeDetectorRef.detectChanges();
    }

    changePage(paginatorEvent) {
        this.pageSize = paginatorEvent.pageSize;
        this.pageIndex = paginatorEvent.pageIndex;
    }

    createOrganizationDataAccess() {
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.oList_District && this.oUser_data_access) {
                    if (this.oList_District.every(oDistrict => this.oUser_data_access.LIST_DISTRICT.some(_District => _District.DISTRICT_ID == oDistrict.DISTRICT_ID))) {
                        this.Level_Kpi_Filled("District");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
            case "Area":
                if (this.oList_Area && this.oUser_data_access) {
                    if (this.oList_Area.every(oArea => this.oUser_data_access.LIST_AREA.some(_Area => _Area.AREA_ID == oArea.AREA_ID))) {
                        this.Level_Kpi_Filled("Area");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
            case "Site":
                if (this.oList_Site && this.oUser_data_access) {
                    if (this.oList_Site.every(oSite => this.oUser_data_access.LIST_SITE.some(_Site => _Site.SITE_ID == oSite.SITE_ID))) {
                        this.Level_Kpi_Filled("Site");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
            case "Entity":
                if (this.oList_Entity && this.oUser_data_access) {
                    if (this.oList_Entity.every(oEntity => this.oUser_data_access.LIST_ENTITY.some(_Entity => _Entity.ENTITY_ID == oEntity.ENTITY_ID))) {
                        this.Level_Kpi_Filled("Entity");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
        }
    }

    openDialog(Level: any = null) {
        const dialogRef = this.dialog.open(UserDataAccessModalComponent, {
            width: '800px',
            data: {
                USER_ID: this.ActivatedRoute.snapshot.params.userId,
                Level: Level,
                oList_District: this.oList_District,
                oList_Area: this.oList_Area,
                oList_Site: this.oList_Site,
                oList_Entity: this.oList_Entity,
                oUser_data_access: this.oUser_data_access,
                oSelected_Data_access_level_Setup: this.oSelected_Data_access_level_Setup
            }
        })
        dialogRef.afterClosed().subscribe(result => {
            if (result) {
                result.AddToChildren instanceof Boolean;
                if (result.AddToChildren) {
                    result.response instanceof Params_Edit_User_Data_Access;
                    //#region District_kpi_user_access
                    if (result.response.List_To_Edit_District_kpi_user_access) {
                        result.response.List_To_Edit_District_kpi_user_access.forEach(oDistrict_kpi_user_access => {
                            this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.push(oDistrict_kpi_user_access);
                        });
                    }
                    if (result.response.List_To_Delete_District_kpi_user_access) {
                        var List_To_Delete = result.response.List_To_Delete_District_kpi_user_access.map(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID);
                        this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS = this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.filter(oDistrict_kpi_user_access => !List_To_Delete.some(_District_kpi_user_access_ID => _District_kpi_user_access_ID == oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID));
                    }
                    var List_District_ID = this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.map(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_ID);
                    this.oUser_data_access.LIST_DISTRICT = [];
                    this.oUser_data_access.LIST_DISTRICT = this.oList_District.filter(oDistrict => List_District_ID.some(DISTRICT_ID => DISTRICT_ID == oDistrict.DISTRICT_ID));
                    this.oList_District_With_Kpi = [];
                    this.oList_District_With_Kpi = cloneDeep(this.oUser_data_access.LIST_DISTRICT);
                    //#endregion
                    //#region Area_kpi_user_access
                    if (result.response.List_To_Edit_Area_kpi_user_access) {
                        result.response.List_To_Edit_Area_kpi_user_access.forEach(oArea_kpi_user_access => {
                            this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.push(oArea_kpi_user_access);
                        });
                    }
                    if (result.response.List_To_Delete_Area_kpi_user_access) {
                        var List_To_Delete = result.response.List_To_Delete_Area_kpi_user_access.map(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID);
                        this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS = this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.filter(oArea_kpi_user_access => !List_To_Delete.some(_Area_kpi_user_access_ID => _Area_kpi_user_access_ID == oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID));
                    }
                    var List_Area_ID = this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.map(oArea_kpi_user_access => oArea_kpi_user_access.AREA_ID);
                    this.oUser_data_access.LIST_AREA = [];
                    this.oUser_data_access.LIST_AREA = this.oList_Area.filter(oArea => List_Area_ID.some(AREA_ID => AREA_ID == oArea.AREA_ID));
                    this.oList_Area_With_Kpi = [];
                    this.oList_Area_With_Kpi = cloneDeep(this.oUser_data_access.LIST_AREA);
                    //#endregion
                    //#region Site_kpi_user_access
                    if (result.response.List_To_Edit_Site_kpi_user_access) {
                        result.response.List_To_Edit_Site_kpi_user_access.forEach(oSite_kpi_user_access => {
                            this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.push(oSite_kpi_user_access);
                        });
                    }
                    if (result.response.List_To_Delete_Site_kpi_user_access) {
                        var List_To_Delete = result.response.List_To_Delete_Site_kpi_user_access.map(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID);
                        this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS = this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.filter(oSite_kpi_user_access => !List_To_Delete.some(_Site_kpi_user_access_ID => _Site_kpi_user_access_ID == oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID));
                    }
                    var List_Site_ID = this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.map(oSite_kpi_user_access => oSite_kpi_user_access.SITE_ID);
                    this.oUser_data_access.LIST_SITE = [];
                    this.oUser_data_access.LIST_SITE = this.oList_Site.filter(oSite => List_Site_ID.some(SITE_ID => SITE_ID == oSite.SITE_ID));
                    this.oList_Site_With_Kpi = [];
                    this.oList_Site_With_Kpi = cloneDeep(this.oUser_data_access.LIST_SITE);
                    //#endregion
                    //#region Entity_kpi_user_access
                    if (result.response.List_To_Edit_Entity_kpi_user_access) {
                        result.response.List_To_Edit_Entity_kpi_user_access.forEach(oEntity_kpi_user_access => {
                            this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.push(oEntity_kpi_user_access);
                        });
                    }
                    if (result.response.List_To_Delete_Entity_kpi_user_access) {
                        var List_To_Delete = result.response.List_To_Delete_Entity_kpi_user_access.map(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID);
                        this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS = this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.filter(oEntity_kpi_user_access => !List_To_Delete.some(_Entity_kpi_user_access_ID => _Entity_kpi_user_access_ID == oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID));
                    }
                    var List_Entity_ID = this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.map(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID);
                    this.oUser_data_access.LIST_ENTITY = [];
                    this.oUser_data_access.LIST_ENTITY = this.oList_Entity.filter(oEntity => List_Entity_ID.some(ENTITY_ID => ENTITY_ID == oEntity.ENTITY_ID));
                    this.oList_Entity_With_Kpi = [];
                    this.oList_Entity_With_Kpi = cloneDeep(this.oUser_data_access.LIST_ENTITY);
                    //#endregion
                } else {
                    switch (this.oSelected_Data_access_level_Setup.VALUE) {
                        case "District":
                            result.response instanceof Params_Edit_District_kpi_user_access_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS = this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.filter(oDistrict_kpi_user_access => !result.response.List_To_Delete.some(_District_kpi_user_access_ID => _District_kpi_user_access_ID == oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oDistrict_kpi_user_access => {
                                    this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.push(oDistrict_kpi_user_access);
                                });
                            }
                            var List_District_ID = this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.map(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_ID);
                            this.oUser_data_access.LIST_DISTRICT = [];
                            this.oUser_data_access.LIST_DISTRICT = this.oList_District.filter(oDistrict => List_District_ID.some(DISTRICT_ID => DISTRICT_ID == oDistrict.DISTRICT_ID));
                            this.oList_District_With_Kpi = [];
                            this.oList_District_With_Kpi = cloneDeep(this.oUser_data_access.LIST_DISTRICT);
                            break;
                        case "Area":
                            result.response instanceof Params_Edit_Area_kpi_user_access_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS = this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.filter(oArea_kpi_user_access => !result.response.List_To_Delete.some(_Area_kpi_user_access_ID => _Area_kpi_user_access_ID == oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oArea_kpi_user_access => {
                                    this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.push(oArea_kpi_user_access);
                                });
                            }
                            var List_Area_ID = this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.map(oArea_kpi_user_access => oArea_kpi_user_access.AREA_ID);
                            this.oUser_data_access.LIST_AREA = [];
                            this.oUser_data_access.LIST_AREA = this.oList_Area.filter(oArea => List_Area_ID.some(AREA_ID => AREA_ID == oArea.AREA_ID));
                            this.oList_Area_With_Kpi = [];
                            this.oList_Area_With_Kpi = cloneDeep(this.oUser_data_access.LIST_AREA);
                            break;
                        case "Site":
                            result.response instanceof Params_Edit_Site_kpi_user_access_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS = this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.filter(oSite_kpi_user_access => !result.response.List_To_Delete.some(_Site_kpi_user_access_ID => _Site_kpi_user_access_ID == oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oSite_kpi_user_access => {
                                    this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.push(oSite_kpi_user_access);
                                });
                            }
                            var List_Site_ID = this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.map(oSite_kpi_user_access => oSite_kpi_user_access.SITE_ID);
                            this.oUser_data_access.LIST_SITE = [];
                            this.oUser_data_access.LIST_SITE = this.oList_Site.filter(oSite => List_Site_ID.some(SITE_ID => SITE_ID == oSite.SITE_ID));
                            this.oList_Site_With_Kpi = [];
                            this.oList_Site_With_Kpi = cloneDeep(this.oUser_data_access.LIST_SITE);
                            break;
                        case "Entity":
                            result.response instanceof Params_Edit_Entity_kpi_user_access_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS = this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.filter(oEntity_kpi_user_access => !result.response.List_To_Delete.some(_Entity_kpi_user_access_ID => _Entity_kpi_user_access_ID == oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oEntity_kpi_user_access => {
                                    this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.push(oEntity_kpi_user_access);
                                });
                            }
                            var List_Entity_ID = this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.map(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID);
                            this.oUser_data_access.LIST_ENTITY = [];
                            this.oUser_data_access.LIST_ENTITY = this.oList_Entity.filter(oEntity => List_Entity_ID.some(ENTITY_ID => ENTITY_ID == oEntity.ENTITY_ID));
                            this.oList_Entity_With_Kpi = [];
                            this.oList_Entity_With_Kpi = cloneDeep(this.oUser_data_access.LIST_ENTITY);
                            break;
                    }
                }
            }
        })
    }

    Level_Kpi_Filled(level: string) {
        this.CmSvc.ShowMessage("No Available " + level + " To Assign.")
    }

}
