import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { MatDialog } from '@angular/material/dialog';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { ActivatedRoute } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Area, District, Entity, Organization, Organization_Data_Access, Organization_level_access, Params_Edit_Area_kpi_List, Params_Edit_District_kpi_List, Params_Edit_Entity_kpi_List, Params_Edit_Organization_Data_Access, Params_Edit_Site_kpi_List, Setup, Site } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { cloneDeep } from 'lodash';
import { OrganizationDataAccessModalComponent } from './organization-data-access-modal/organization-data-access-modal.component';

@Component({
    selector: 'organization-data-access',
    templateUrl: './organization-data-access.component.html',
    styleUrls: ['./organization-data-access.component.scss']
})
export class OrganizationDataAccessComponent implements OnInit {

    value = 50;
    pageIndex = 0;
    pageSize = 20;

    color: ThemePalette = 'accent';
    mode: ProgressSpinnerMode = 'indeterminate';

    oOrganization: Organization;
    oList_Organization_level_access: Organization_level_access[];

    oOrganization_data_access: Organization_Data_Access;

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

    searchInputValue = '';

    isFetchingSites = false;
    isFetchingAreas = false;
    isMyOrganization = false;
    isFetchingEntities = false;
    isFetchingDistricts = false;
    isFetchingTopLevels = false;
    isPreviousExpansionValue = false;
    isProgressSpinnerVisible = false;

    constructor(
        public dialog: MatDialog,
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
        this.isMyOrganization = this.ActivatedRoute.snapshot.data['isMyOrganization'];
        if (this.isMyOrganization) {
            this.oOrganization = this.CmSvc.oOrganization;
        } else {
            this.oOrganization = this.OrganizationManagementService.oList_Organization.find(organization => organization.ORGANIZATION_ID == this.ActivatedRoute.snapshot.params.id);
        }
        this.OrganizationManagementService.Get_Organization_Data_Access(this.oOrganization).then(result => {
            this.oList_District_With_Kpi = result.LIST_DISTRICT;
            this.oList_Area_With_Kpi = result.LIST_AREA;
            this.oList_Site_With_Kpi = result.LIST_SITE;
            this.oList_Entity_With_Kpi = result.LIST_ENTITY;
            this.oOrganization_data_access = cloneDeep(result);
        })
        this.OrganizationManagementService.Get_Entity_By_ENTITY_ID_List(this.oOrganization).then(result => {
            this.oList_Entity = result;
        });
        this.OrganizationManagementService.Get_Site_By_SITE_ID_List(this.oOrganization).then(result => {
            this.oList_Site = result;
        });
        this.OrganizationManagementService.Get_Area_By_AREA_ID_List(this.oOrganization).then(result => {
            this.oList_Area = result;
        });
        this.OrganizationManagementService.Get_District_By_DISTRICT_ID_List(this.oOrganization).then(result => {
            this.oList_District = result;
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
        return (this.oOrganization_data_access && this.oList_District && this.oList_Area && this.oList_Site && this.oList_Entity);
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
                if (this.oList_District && this.oOrganization_data_access) {
                    if (this.oList_District.every(oDistrict => this.oOrganization_data_access.LIST_DISTRICT.some(_District => _District.DISTRICT_ID == oDistrict.DISTRICT_ID))) {
                        this.Level_Kpi_Filled("District");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
            case "Area":
                if (this.oList_Area && this.oOrganization_data_access) {
                    if (this.oList_Area.every(oArea => this.oOrganization_data_access.LIST_AREA.some(_Area => _Area.AREA_ID == oArea.AREA_ID))) {
                        this.Level_Kpi_Filled("Area");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
            case "Site":
                if (this.oList_Site && this.oOrganization_data_access) {
                    if (this.oList_Site.every(oSite => this.oOrganization_data_access.LIST_SITE.some(_Site => _Site.SITE_ID == oSite.SITE_ID))) {
                        this.Level_Kpi_Filled("Site");
                    }
                    else {
                        this.openDialog();
                    }
                }
                break;
            case "Entity":
                if (this.oList_Entity && this.oOrganization_data_access) {
                    if (this.oList_Entity.every(oEntity => this.oOrganization_data_access.LIST_ENTITY.some(_Entity => _Entity.ENTITY_ID == oEntity.ENTITY_ID))) {
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
        const dialogRef = this.dialog.open(OrganizationDataAccessModalComponent, {
            width: '800px',
            data: {
                Level: Level,
                oList_District: this.oList_District,
                oList_Area: this.oList_Area,
                oList_Site: this.oList_Site,
                oList_Entity: this.oList_Entity,
                oOrganization_data_access: this.oOrganization_data_access,
                oSelected_Data_access_level_Setup: this.oSelected_Data_access_level_Setup
            }
        })
        dialogRef.afterClosed().subscribe(result => {
            if (result) {
                result.AddToChildren instanceof Boolean;
                if (result.AddToChildren) {
                    result.response instanceof Params_Edit_Organization_Data_Access;
                    //#region  District_kpi
                    if (result.response.List_To_Edit_District_kpi) {
                        result.response.List_To_Edit_District_kpi.forEach(oDistrict_kpi => {
                            this.oOrganization_data_access.LIST_DISTRICT_KPI.push(oDistrict_kpi);
                        });
                    }
                    if (result.response.List_To_Delete_District_kpi) {
                        var List_To_Delete = result.response.List_To_Delete_District_kpi.map(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID);
                        this.oOrganization_data_access.LIST_DISTRICT_KPI = this.oOrganization_data_access.LIST_DISTRICT_KPI.filter(oDistrict_kpi => !List_To_Delete.some(_District_kpi_ID => _District_kpi_ID == oDistrict_kpi.DISTRICT_KPI_ID));
                    }
                    var List_District_ID = this.oOrganization_data_access.LIST_DISTRICT_KPI.map(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID);
                    this.oOrganization_data_access.LIST_DISTRICT = [];
                    this.oOrganization_data_access.LIST_DISTRICT = this.oList_District.filter(oDistrict => List_District_ID.some(DISTRICT_ID => DISTRICT_ID == oDistrict.DISTRICT_ID));
                    this.oList_District_With_Kpi = [];
                    this.oList_District_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_DISTRICT);
                    //#endregion
                    //#region Area_kpi
                    if (result.response.List_To_Edit_Area_kpi) {
                        result.response.List_To_Edit_Area_kpi.forEach(oArea_kpi => {
                            this.oOrganization_data_access.LIST_AREA_KPI.push(oArea_kpi);
                        });
                    }
                    if (result.response.List_To_Delete_Area_kpi) {
                        var List_To_Delete = result.response.List_To_Delete_Area_kpi.map(oArea_kpi => oArea_kpi.AREA_KPI_ID);
                        this.oOrganization_data_access.LIST_AREA_KPI = this.oOrganization_data_access.LIST_AREA_KPI.filter(oArea_kpi => !List_To_Delete.some(_Area_kpi_ID => _Area_kpi_ID == oArea_kpi.AREA_KPI_ID));
                    }
                    var List_Area_ID = this.oOrganization_data_access.LIST_AREA_KPI.map(oArea_kpi => oArea_kpi.AREA_ID);
                    this.oOrganization_data_access.LIST_AREA = [];
                    this.oOrganization_data_access.LIST_AREA = this.oList_Area.filter(oArea => List_Area_ID.some(AREA_ID => AREA_ID == oArea.AREA_ID));
                    this.oList_Area_With_Kpi = [];
                    this.oList_Area_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_AREA);
                    //#endregion
                    //#region Site_kpi
                    if (result.response.List_To_Edit_Site_kpi) {
                        result.response.List_To_Edit_Site_kpi.forEach(oSite_kpi => {
                            this.oOrganization_data_access.LIST_SITE_KPI.push(oSite_kpi);
                        });
                    }
                    if (result.response.List_To_Delete_Site_kpi) {
                        var List_To_Delete = result.response.List_To_Delete_Site_kpi.map(oSite_kpi => oSite_kpi.SITE_KPI_ID);
                        this.oOrganization_data_access.LIST_SITE_KPI = this.oOrganization_data_access.LIST_SITE_KPI.filter(oSite_kpi => !List_To_Delete.some(_Site_kpi_ID => _Site_kpi_ID == oSite_kpi.SITE_KPI_ID));
                    }
                    var List_Site_ID = this.oOrganization_data_access.LIST_SITE_KPI.map(oSite_kpi => oSite_kpi.SITE_ID);
                    this.oOrganization_data_access.LIST_SITE = [];
                    this.oOrganization_data_access.LIST_SITE = this.oList_Site.filter(oSite => List_Site_ID.some(SITE_ID => SITE_ID == oSite.SITE_ID));
                    this.oList_Site_With_Kpi = [];
                    this.oList_Site_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_SITE);
                    //#endregion
                    //#region Entity_kpi
                    if (result.response.List_To_Edit_Entity_kpi) {
                        result.response.List_To_Edit_Entity_kpi.forEach(oEntity_kpi => {
                            this.oOrganization_data_access.LIST_ENTITY_KPI.push(oEntity_kpi);
                        });
                    }
                    if (result.response.List_To_Delete_Entity_kpi) {
                        var List_To_Delete = result.response.List_To_Delete_Entity_kpi.map(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID);
                        this.oOrganization_data_access.LIST_ENTITY_KPI = this.oOrganization_data_access.LIST_ENTITY_KPI.filter(oEntity_kpi => !List_To_Delete.some(_Entity_kpi_ID => _Entity_kpi_ID == oEntity_kpi.ENTITY_KPI_ID));
                    }
                    var List_Entity_ID = this.oOrganization_data_access.LIST_ENTITY_KPI.map(oEntity_kpi => oEntity_kpi.ENTITY_ID);
                    this.oOrganization_data_access.LIST_ENTITY = [];
                    this.oOrganization_data_access.LIST_ENTITY = this.oList_Entity.filter(oEntity => List_Entity_ID.some(ENTITY_ID => ENTITY_ID == oEntity.ENTITY_ID));
                    this.oList_Entity_With_Kpi = [];
                    this.oList_Entity_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_ENTITY);
                    //#endregion
                } else {
                    switch (this.oSelected_Data_access_level_Setup.VALUE) {
                        case "District":
                            result.response instanceof Params_Edit_District_kpi_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oOrganization_data_access.LIST_DISTRICT_KPI = this.oOrganization_data_access.LIST_DISTRICT_KPI.filter(oDistrict_kpi => !result.response.List_To_Delete.some(_District_kpi_ID => _District_kpi_ID == oDistrict_kpi.DISTRICT_KPI_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oDistrict_kpi => {
                                    this.oOrganization_data_access.LIST_DISTRICT_KPI.push(oDistrict_kpi);
                                });
                            }
                            var List_District_ID = this.oOrganization_data_access.LIST_DISTRICT_KPI.map(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID);
                            this.oOrganization_data_access.LIST_DISTRICT = [];
                            this.oOrganization_data_access.LIST_DISTRICT = this.oList_District.filter(oDistrict => List_District_ID.some(DISTRICT_ID => DISTRICT_ID == oDistrict.DISTRICT_ID));
                            this.oList_District_With_Kpi = [];
                            this.oList_District_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_DISTRICT);
                            break;
                        case "Area":
                            result.response instanceof Params_Edit_Area_kpi_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oOrganization_data_access.LIST_AREA_KPI = this.oOrganization_data_access.LIST_AREA_KPI.filter(oArea_kpi => !result.response.List_To_Delete.some(_Area_kpi_ID => _Area_kpi_ID == oArea_kpi.AREA_KPI_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oArea_kpi => {
                                    this.oOrganization_data_access.LIST_AREA_KPI.push(oArea_kpi);
                                });
                            }
                            var List_Area_ID = this.oOrganization_data_access.LIST_AREA_KPI.map(oArea_kpi => oArea_kpi.AREA_ID);
                            this.oOrganization_data_access.LIST_AREA = [];
                            this.oOrganization_data_access.LIST_AREA = this.oList_Area.filter(oArea => List_Area_ID.some(AREA_ID => AREA_ID == oArea.AREA_ID));
                            this.oList_Area_With_Kpi = [];
                            this.oList_Area_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_AREA);
                            break;
                        case "Site":
                            result.response instanceof Params_Edit_Site_kpi_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oOrganization_data_access.LIST_SITE_KPI = this.oOrganization_data_access.LIST_SITE_KPI.filter(oSite_kpi => !result.response.List_To_Delete.some(_Site_kpi_ID => _Site_kpi_ID == oSite_kpi.SITE_KPI_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oSite_kpi => {
                                    this.oOrganization_data_access.LIST_SITE_KPI.push(oSite_kpi);
                                });
                            }
                            var List_Site_ID = this.oOrganization_data_access.LIST_SITE_KPI.map(oSite_kpi => oSite_kpi.SITE_ID);
                            this.oOrganization_data_access.LIST_SITE = [];
                            this.oOrganization_data_access.LIST_SITE = this.oList_Site.filter(oSite => List_Site_ID.some(SITE_ID => SITE_ID == oSite.SITE_ID));
                            this.oList_Site_With_Kpi = [];
                            this.oList_Site_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_SITE);
                            break;
                        case "Entity":
                            result.response instanceof Params_Edit_Entity_kpi_List;
                            if (result.response.List_To_Delete && result.response.List_To_Delete.length > 0) {
                                this.oOrganization_data_access.LIST_ENTITY_KPI = this.oOrganization_data_access.LIST_ENTITY_KPI.filter(oEntity_kpi => !result.response.List_To_Delete.some(_Entity_kpi_ID => _Entity_kpi_ID == oEntity_kpi.ENTITY_KPI_ID));
                            }
                            if (result.response.List_To_Edit && result.response.List_To_Edit.length > 0) {
                                result.response.List_To_Edit.forEach(oEntity_kpi => {
                                    this.oOrganization_data_access.LIST_ENTITY_KPI.push(oEntity_kpi);
                                });
                            }
                            var List_Entity_ID = this.oOrganization_data_access.LIST_ENTITY_KPI.map(oEntity_kpi => oEntity_kpi.ENTITY_ID);
                            this.oOrganization_data_access.LIST_ENTITY = [];
                            this.oOrganization_data_access.LIST_ENTITY = this.oList_Entity.filter(oEntity => List_Entity_ID.some(ENTITY_ID => ENTITY_ID == oEntity.ENTITY_ID));
                            this.oList_Entity_With_Kpi = [];
                            this.oList_Entity_With_Kpi = cloneDeep(this.oOrganization_data_access.LIST_ENTITY);
                            break;
                    }
                }
            }
        })
    }

    Level_Kpi_Filled(level: string) {
        this.CmSvc.ShowMessage("All " + level + " KPIs have been assigned")
    }

}
