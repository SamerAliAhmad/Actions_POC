import { Component, HostListener, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Area_kpi_user_access, Dimension, District, District_kpi_user_access, Entity, Entity_kpi_user_access, Organization_data_source_kpi, Params_Edit_Area_kpi_user_access_List, Params_Edit_District_kpi_user_access_List, Params_Edit_Entity_kpi_user_access_List, Params_Edit_Site_kpi_user_access_List, Params_Edit_User_Data_Access, Setup, Site, Site_kpi_user_access, User_Data_Access } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'user-data-access-modal',
    templateUrl: './user-data-access-modal.component.html',
    styleUrls: ['./user-data-access-modal.component.scss']
})
export class UserDataAccessModalComponent implements OnInit {

    loading = false;
    isCreating = true;
    mobileView = false;
    isListChanged = false;
    AddToChildren: boolean = false;

    oSelected_Data_access_level_Setup: Setup;

    USER_ID: number;
    LEVEL_ID: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID_TO_DELETE: number[] = [];

    oDimension: Dimension;
    oList_Dimension: Dimension[];
    oList_Dimension_filtered: Dimension[];

    oSelected_Area_kpi_user_access: Area_kpi_user_access;
    oSelected_Site_kpi_user_access: Site_kpi_user_access;
    oSelected_Entity_kpi_user_access: Entity_kpi_user_access;
    oSelected_District_kpi_user_access: District_kpi_user_access;

    oList_Available_Area_kpi_user_access: Area_kpi_user_access[] = [];
    oList_Available_Site_kpi_user_access: Site_kpi_user_access[] = [];
    oList_Available_Entity_kpi_user_access: Entity_kpi_user_access[] = [];
    oList_Available_District_kpi_user_access: District_kpi_user_access[] = [];

    oList_Selected_Area_kpi_user_access: Area_kpi_user_access[];
    oList_Selected_Site_kpi_user_access: Site_kpi_user_access[];
    oList_Selected_Entity_kpi_user_access: Entity_kpi_user_access[];
    oList_Selected_District_kpi_user_access: District_kpi_user_access[];

    oList_Site: Site[];
    oList_Area: Area[];
    oList_Entity: Entity[];
    oList_District: District[];
    oUser_data_access: User_Data_Access;
    oList_Organization_data_source_kpi: Organization_data_source_kpi[];

    constructor(
        private CmSvc: CommonService,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private dialogRef: MatDialogRef<UserDataAccessModalComponent>,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.isCreating = this.data.Level ? false : true;
        this.USER_ID = this.data.USER_ID;
        this.oList_Dimension = this.CmSvc.oList_Dimension;
        this.oList_Dimension_filtered = this.CmSvc.oList_Dimension;
        if (!this.isCreating) {
            this.oDimension = this.oList_Dimension[0];
        }
        this.oUser_data_access = this.data.oUser_data_access;
        this.oSelected_Data_access_level_Setup = this.data.oSelected_Data_access_level_Setup;

        this.LoadData();
    }

    getDimensionName(DIMENSION_ID: number) {
        let oDimension = this.oList_Dimension.find(oDimension => oDimension.DIMENSION_ID == DIMENSION_ID);
        if (oDimension) {
            return oDimension.NAME;
        }
    }

    disableAddAllButton() {
        var length = 0;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                length = this.oList_Available_District_kpi_user_access.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
            case "Area":
                length = this.oList_Available_Area_kpi_user_access.filter(oArea_kpi_user_access => oArea_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
            case "Site":
                length = this.oList_Available_Site_kpi_user_access.filter(oSite_kpi_user_access => oSite_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
            case "Entity":
                length = this.oList_Available_Entity_kpi_user_access.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
        }
        return (length == 0) ? true : false;
    }

    LoadData() {
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.isCreating) {
                    this.oList_District = this.data.oList_District.filter(oDistrict => !this.data.oUser_data_access.LIST_DISTRICT.some(_District => _District.DISTRICT_ID == oDistrict.DISTRICT_ID))
                }
                else {
                    this.oList_District = this.data.oList_District;
                    this.LEVEL_ID = this.data.Level.DISTRICT_ID;
                    this.Update_Level_kpi_List();
                }
                break;
            case "Area":
                if (this.isCreating) {
                    this.oList_Area = this.data.oList_Area.filter(oArea => !this.data.oUser_data_access.LIST_AREA.some(_Area => _Area.AREA_ID == oArea.AREA_ID))
                }
                else {
                    this.oList_Area = this.data.oList_Area;
                    this.LEVEL_ID = this.data.Level.AREA_ID;
                    this.Update_Level_kpi_List();
                }
                break;
            case "Site":
                if (this.isCreating) {
                    this.oList_Site = this.data.oList_Site.filter(oSite => !this.data.oUser_data_access.LIST_SITE.some(_Site => _Site.SITE_ID == oSite.SITE_ID))
                }
                else {
                    this.oList_Site = this.data.oList_Site;
                    this.LEVEL_ID = this.data.Level.SITE_ID;
                    this.Update_Level_kpi_List();
                }
                break;
            case "Entity":
                if (this.isCreating) {
                    this.oList_Entity = this.data.oList_Entity.filter(oEntity => !this.data.oUser_data_access.LIST_ENTITY.some(_Entity => _Entity.ENTITY_ID == oEntity.ENTITY_ID))
                }
                else {
                    this.oList_Entity = this.data.oList_Entity;
                    this.LEVEL_ID = this.data.Level.ENTITY_ID;
                    this.Update_Level_kpi_List();
                }
                break;
        }
    }

    Update_Level_kpi_List() {
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.LEVEL_ID) {
                    this.oList_Selected_District_kpi_user_access = this.oUser_data_access.LIST_DISTRICT_KPI_USER_ACCESS.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_ID == this.LEVEL_ID);
                    this.oList_Selected_District_kpi_user_access.forEach(oDistrict_kpi_user_access => {
                        oDistrict_kpi_user_access.Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_District_kpi_user_access.some(oDistrict_kpi => oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oDistrict_kpi_user_access = new District_kpi_user_access();
                        oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID = -1;
                        oDistrict_kpi_user_access.USER_ID = this.USER_ID;
                        oDistrict_kpi_user_access.DISTRICT_ID = this.LEVEL_ID;
                        oDistrict_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oDistrict_kpi_user_access.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_District_kpi_user_access.push(oDistrict_kpi_user_access);
                    });
                }
                break;
            case "Area":
                if (this.LEVEL_ID) {
                    this.oList_Selected_Area_kpi_user_access = this.oUser_data_access.LIST_AREA_KPI_USER_ACCESS.filter(oArea_kpi_user_access => oArea_kpi_user_access.AREA_ID == this.LEVEL_ID);
                    this.oList_Selected_Area_kpi_user_access.forEach(oArea_kpi_user_access => {
                        oArea_kpi_user_access.Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_Area_kpi_user_access.some(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oArea_kpi_user_access = new Area_kpi_user_access();
                        oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID = -1;
                        oArea_kpi_user_access.USER_ID = this.USER_ID;
                        oArea_kpi_user_access.AREA_ID = this.LEVEL_ID;
                        oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oArea_kpi_user_access.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_Area_kpi_user_access.push(oArea_kpi_user_access);
                    });
                }
                break;
            case "Site":
                if (this.LEVEL_ID) {
                    this.oList_Selected_Site_kpi_user_access = this.oUser_data_access.LIST_SITE_KPI_USER_ACCESS.filter(oSite_kpi_user_access => oSite_kpi_user_access.SITE_ID == this.LEVEL_ID);
                    this.oList_Selected_Site_kpi_user_access.forEach(oSite_kpi_user_access => {
                        oSite_kpi_user_access.Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_Site_kpi_user_access.some(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oSite_kpi_user_access = new Site_kpi_user_access();
                        oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID = -1;
                        oSite_kpi_user_access.USER_ID = this.USER_ID;
                        oSite_kpi_user_access.SITE_ID = this.LEVEL_ID;
                        oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oSite_kpi_user_access.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_Site_kpi_user_access.push(oSite_kpi_user_access);
                    });
                }
                break;
            case "Entity":
                if (this.LEVEL_ID) {
                    this.oList_Selected_Entity_kpi_user_access = this.oUser_data_access.LIST_ENTITY_KPI_USER_ACCESS.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_ID == this.LEVEL_ID);
                    this.oList_Selected_Entity_kpi_user_access.forEach(oEntity_kpi_user_access => {
                        oEntity_kpi_user_access.Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oUser_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_Entity_kpi_user_access.some(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oEntity_kpi_user_access = new Entity_kpi_user_access();
                        oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID = -1;
                        oEntity_kpi_user_access.USER_ID = this.USER_ID;
                        oEntity_kpi_user_access.ENTITY_ID = this.LEVEL_ID;
                        oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oEntity_kpi_user_access.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_Entity_kpi_user_access.push(oEntity_kpi_user_access);
                    });
                }
                break;
        }
        this.oList_Dimension_filtered = this.CmSvc.oList_Dimension.filter(oDimension => this.oList_Organization_data_source_kpi.some(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.DIMENSION_ID == oDimension.DIMENSION_ID));
    }

    Add_Level_kpi() {
        this.isListChanged = true;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.oSelected_District_kpi_user_access) {
                    this.oList_Selected_District_kpi_user_access.push(this.oSelected_District_kpi_user_access);
                    var index = this.oList_Available_District_kpi_user_access.findIndex(oDistrict_kpi_user_access => oDistrict_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_District_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_District_kpi_user_access.splice(index, 1);
                    this.oList_Selected_District_kpi_user_access.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_District_kpi_user_access = null;
                }
                break;
            case "Area":
                if (this.oSelected_Area_kpi_user_access) {
                    this.oList_Selected_Area_kpi_user_access.push(this.oSelected_Area_kpi_user_access);
                    var index = this.oList_Available_Area_kpi_user_access.findIndex(oArea_kpi_user_access => oArea_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_Area_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_Area_kpi_user_access.splice(index, 1);
                    this.oList_Selected_Area_kpi_user_access.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_Area_kpi_user_access = null;
                }
                break;
            case "Site":
                if (this.oSelected_Site_kpi_user_access) {
                    this.oList_Selected_Site_kpi_user_access.push(this.oSelected_Site_kpi_user_access);
                    var index = this.oList_Available_Site_kpi_user_access.findIndex(oSite_kpi_user_access => oSite_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_Site_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_Site_kpi_user_access.splice(index, 1);
                    this.oList_Selected_Site_kpi_user_access.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_Site_kpi_user_access = null;
                }
                break;
            case "Entity":
                if (this.oSelected_Entity_kpi_user_access) {
                    this.oList_Selected_Entity_kpi_user_access.push(this.oSelected_Entity_kpi_user_access);
                    var index = this.oList_Available_Entity_kpi_user_access.findIndex(oEntity_kpi_user_access => oEntity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_Entity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_Entity_kpi_user_access.splice(index, 1);
                    this.oList_Selected_Entity_kpi_user_access.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_Entity_kpi_user_access = null;
                }
                break;
        }
    }

    Add_Add_Level_kpi_Per_Dimension() {
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                var oList_District_kpi_user_access = this.oList_Available_District_kpi_user_access.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_District_kpi_user_access.forEach(oDistrict_kpi_user_access => {
                    this.oSelected_District_kpi_user_access = oDistrict_kpi_user_access;
                    this.Add_Level_kpi();
                });
                break
            case "Area":
                var oList_Area_kpi_user_access = this.oList_Available_Area_kpi_user_access.filter(oArea_kpi_user_access => oArea_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_Area_kpi_user_access.forEach(oArea_kpi => {
                    this.oSelected_Area_kpi_user_access = oArea_kpi;
                    this.Add_Level_kpi();
                });
                break
            case "Site":
                var oList_Site_kpi_user_access = this.oList_Available_Site_kpi_user_access.filter(oSite_kpi_user_access => oSite_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_Site_kpi_user_access.forEach(oSite_kpi => {
                    this.oSelected_Site_kpi_user_access = oSite_kpi;
                    this.Add_Level_kpi();
                });
                break
            case "Entity":
                var oList_Entity_kpi_user_access = this.oList_Available_Entity_kpi_user_access.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_Entity_kpi_user_access.forEach(oEntity_kpi => {
                    this.oSelected_Entity_kpi_user_access = oEntity_kpi;
                    this.Add_Level_kpi();
                });
                break
        }
    }

    Remove_Level_kpi(index: number) {
        this.isListChanged = true;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                let oDistrict_kpi_user_access = this.oList_Selected_District_kpi_user_access[index];
                this.oList_Available_District_kpi_user_access.push(oDistrict_kpi_user_access);
                this.oList_Selected_District_kpi_user_access.splice(index, 1);
                break;
            case "Area":
                let oArea_kpi_user_access = this.oList_Selected_Area_kpi_user_access[index];
                this.oList_Available_Area_kpi_user_access.push(oArea_kpi_user_access);
                this.oList_Selected_Area_kpi_user_access.splice(index, 1);
                break;
            case "Site":
                let oSite_kpi_user_access = this.oList_Selected_Site_kpi_user_access[index];
                this.oList_Available_Site_kpi_user_access.push(oSite_kpi_user_access);
                this.oList_Selected_Site_kpi_user_access.splice(index, 1);
                break;
            case "Entity":
                let oEntity_kpi_user_access = this.oList_Selected_Entity_kpi_user_access[index];
                this.oList_Available_Entity_kpi_user_access.push(oEntity_kpi_user_access);
                this.oList_Selected_Entity_kpi_user_access.splice(index, 1);
                break;
        }
    }

    Reset_Organization_Data_Access() {
        this.Update_Level_kpi_List();
        this.isListChanged = false;
    }

    Edit_Organization_Data_Access() {
        this.loading = true;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.AddToChildren) {
                    const oParams_Edit_User_Data_Access = new Params_Edit_User_Data_Access();
                    oParams_Edit_User_Data_Access.List_To_Edit_District_kpi_user_access = this.oList_Selected_District_kpi_user_access.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_User_Data_Access.List_To_Delete_District_kpi_user_access = this.oList_Available_District_kpi_user_access.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID != -1);
                    oParams_Edit_User_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_User_Data_Access(oParams_Edit_User_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.loading = false;
                    })
                } else {
                    const oParams_Edit_District_kpi_user_access_List = new Params_Edit_District_kpi_user_access_List();
                    oParams_Edit_District_kpi_user_access_List.List_To_Edit = this.oList_Selected_District_kpi_user_access.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_District_kpi_user_access_List.List_To_Delete = this.oList_Available_District_kpi_user_access.filter(oDistrict_kpi_user_access => oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID != -1).map(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_USER_ACCESS_ID);
                    this.OrganizationManagementService.Edit_District_kpi_user_access_List(oParams_Edit_District_kpi_user_access_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.loading = false;
                    })
                }
                break;
            case "Area":
                if (this.AddToChildren) {
                    const oParams_Edit_User_Data_Access = new Params_Edit_User_Data_Access();
                    oParams_Edit_User_Data_Access.List_To_Edit_Area_kpi_user_access = this.oList_Selected_Area_kpi_user_access.filter(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_User_Data_Access.List_To_Delete_Area_kpi_user_access = this.oList_Available_Area_kpi_user_access.filter(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID != -1);
                    oParams_Edit_User_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_User_Data_Access(oParams_Edit_User_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.loading = false;
                    })
                } else {
                    const oParams_Edit_Area_kpi_user_access_List = new Params_Edit_Area_kpi_user_access_List();
                    oParams_Edit_Area_kpi_user_access_List.List_To_Edit = this.oList_Selected_Area_kpi_user_access.filter(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_Area_kpi_user_access_List.List_To_Delete = this.oList_Available_Area_kpi_user_access.filter(oArea_kpi_user_access => oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID != -1).map(oArea_kpi => oArea_kpi.AREA_KPI_USER_ACCESS_ID);
                    this.OrganizationManagementService.Edit_Area_kpi_user_access_List(oParams_Edit_Area_kpi_user_access_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.loading = false;
                    })
                }
                break;
            case "Site":
                if (this.AddToChildren) {
                    const oParams_Edit_User_Data_Access = new Params_Edit_User_Data_Access();
                    oParams_Edit_User_Data_Access.List_To_Edit_Site_kpi_user_access = this.oList_Selected_Site_kpi_user_access.filter(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_User_Data_Access.List_To_Delete_Site_kpi_user_access = this.oList_Available_Site_kpi_user_access.filter(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID != -1);
                    oParams_Edit_User_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_User_Data_Access(oParams_Edit_User_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.loading = false;
                    })
                } else {
                    const oParams_Edit_Site_kpi_user_access_List = new Params_Edit_Site_kpi_user_access_List();
                    oParams_Edit_Site_kpi_user_access_List.List_To_Edit = this.oList_Selected_Site_kpi_user_access.filter(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_Site_kpi_user_access_List.List_To_Delete = this.oList_Available_Site_kpi_user_access.filter(oSite_kpi_user_access => oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID != -1).map(oSite_kpi => oSite_kpi.SITE_KPI_USER_ACCESS_ID);
                    this.OrganizationManagementService.Edit_Site_kpi_user_access_List(oParams_Edit_Site_kpi_user_access_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.loading = false;
                    })
                }
                break;
            case "Entity":
                if (this.AddToChildren) {
                    const oParams_Edit_User_Data_Access = new Params_Edit_User_Data_Access();
                    oParams_Edit_User_Data_Access.List_To_Edit_Entity_kpi_user_access = this.oList_Selected_Entity_kpi_user_access.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_User_Data_Access.List_To_Delete_Entity_kpi_user_access = this.oList_Available_Entity_kpi_user_access.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID != -1);
                    oParams_Edit_User_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_User_Data_Access(oParams_Edit_User_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.loading = false;
                    })
                } else {
                    const oParams_Edit_Entity_kpi_user_access_List = new Params_Edit_Entity_kpi_user_access_List();
                    oParams_Edit_Entity_kpi_user_access_List.List_To_Edit = this.oList_Selected_Entity_kpi_user_access.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID == -1);
                    oParams_Edit_Entity_kpi_user_access_List.List_To_Delete = this.oList_Available_Entity_kpi_user_access.filter(oEntity_kpi_user_access => oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID != -1).map(oEntity_kpi => oEntity_kpi.ENTITY_KPI_USER_ACCESS_ID);
                    this.OrganizationManagementService.Edit_Entity_kpi_user_access_List(oParams_Edit_Entity_kpi_user_access_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.loading = false;
                    })
                }
                break;
        }
    }

    @HostListener('window:resize', ['$event'])
    onResize(event) {
        this.mobileView = window.innerWidth < 600;
    }

}
