import { Component, HostListener, Inject, OnInit } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Area_kpi, Dimension, District, District_kpi, Entity, Entity_kpi, Organization_Data_Access, Organization_data_source_kpi, Params_Edit_Area_kpi_List, Params_Edit_District_kpi_List, Params_Edit_Entity_kpi_List, Params_Edit_Organization_Data_Access, Params_Edit_Site_kpi_List, Setup, Site, Site_kpi } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';

@Component({
    selector: 'organization-data-access-modal',
    templateUrl: './organization-data-access-modal.component.html',
    styleUrls: ['./organization-data-access-modal.component.scss']
})

export class OrganizationDataAccessModalComponent implements OnInit {

    isLoading = false;
    isCreating = true;
    isMobileView = false;
    isListChanged = false;
    AddToChildren: boolean = false;

    oSelected_Data_access_level_Setup: Setup;

    LEVEL_ID: number;
    LIST_ORGANIZATION_DATA_SOURCE_KPI_ID_TO_DELETE: number[] = [];

    oDimension: Dimension;
    oList_Dimension: Dimension[];
    oList_Dimension_filtered: Dimension[];

    oSelected_Area_kpi: Area_kpi;
    oSelected_Site_kpi: Site_kpi;
    oSelected_Entity_kpi: Entity_kpi;
    oSelected_District_kpi: District_kpi;

    oList_Available_Area_kpi: Area_kpi[] = [];
    oList_Available_Site_kpi: Site_kpi[] = [];
    oList_Available_Entity_kpi: Entity_kpi[] = [];
    oList_Available_District_kpi: District_kpi[] = [];

    oList_Selected_Area_kpi: Area_kpi[];
    oList_Selected_Site_kpi: Site_kpi[];
    oList_Selected_Entity_kpi: Entity_kpi[];
    oList_Selected_District_kpi: District_kpi[];

    oList_Site: Site[];
    oList_Area: Area[];
    oList_Entity: Entity[];
    oList_District: District[];

    oOrganization_data_access: Organization_Data_Access;
    oList_Organization_data_source_kpi: Organization_data_source_kpi[];

    constructor(
        private dialogRef: MatDialogRef<OrganizationDataAccessModalComponent>,
        private CmSvc: CommonService,
        @Inject(MAT_DIALOG_DATA) public data: any,
        private OrganizationManagementService: OrganizationManagementService,
    ) { }

    ngOnInit(): void {
        this.isCreating = this.data.Level ? false : true;
        this.oList_Dimension = this.CmSvc.oList_Dimension;
        this.oList_Dimension_filtered = this.CmSvc.oList_Dimension;
        if (!this.isCreating) {
            this.oDimension = this.oList_Dimension[0];
        }
        this.oOrganization_data_access = this.data.oOrganization_data_access;
        this.oSelected_Data_access_level_Setup = this.data.oSelected_Data_access_level_Setup;

        this.LoadData();
    }

    getDimensionName(DIMENSION_ID: number) {
        return this.oList_Dimension.find(oDimension => oDimension.DIMENSION_ID == DIMENSION_ID).NAME;
    }

    disableAddAllButton() {
        var length = 0;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                length = this.oList_Available_District_kpi.filter(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
            case "Area":
                length = this.oList_Available_Area_kpi.filter(oArea_kpi => oArea_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
            case "Site":
                length = this.oList_Available_Site_kpi.filter(oSite_kpi => oSite_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
            case "Entity":
                length = this.oList_Available_Entity_kpi.filter(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID).length
                break;
        }
        return (length == 0) ? true : false;
    }

    LoadData() {
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.isCreating) {
                    this.oList_District = this.data.oList_District.filter(oDistrict => !this.data.oOrganization_data_access.LIST_DISTRICT.some(_District => _District.DISTRICT_ID == oDistrict.DISTRICT_ID))
                }
                else {
                    this.oList_District = this.data.oList_District;
                    this.LEVEL_ID = this.data.Level.DISTRICT_ID;
                    this.Update_Level_kpi_List();
                }
                break;
            case "Area":
                if (this.isCreating) {
                    this.oList_Area = this.data.oList_Area.filter(oArea => !this.data.oOrganization_data_access.LIST_AREA.some(_Area => _Area.AREA_ID == oArea.AREA_ID))
                }
                else {
                    this.oList_Area = this.data.oList_Area;
                    this.LEVEL_ID = this.data.Level.AREA_ID;
                    this.Update_Level_kpi_List();
                }
                break;
            case "Site":
                if (this.isCreating) {
                    this.oList_Site = this.data.oList_Site.filter(oSite => !this.data.oOrganization_data_access.LIST_SITE.some(_Site => _Site.SITE_ID == oSite.SITE_ID))
                }
                else {
                    this.oList_Site = this.data.oList_Site;
                    this.LEVEL_ID = this.data.Level.SITE_ID;
                    this.Update_Level_kpi_List();
                }
                break;
            case "Entity":
                if (this.isCreating) {
                    this.oList_Entity = this.data.oList_Entity.filter(oEntity => !this.data.oOrganization_data_access.LIST_ENTITY.some(_Entity => _Entity.ENTITY_ID == oEntity.ENTITY_ID))
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
                    this.oList_Selected_District_kpi = this.oOrganization_data_access.LIST_DISTRICT_KPI.filter(oDistrict_kpi => oDistrict_kpi.DISTRICT_ID == this.LEVEL_ID);
                    this.oList_Selected_District_kpi.forEach(oDistrict_kpi => {
                        oDistrict_kpi.Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_District_kpi.some(oDistrict_kpi => oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "District").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oDistrict_kpi = new District_kpi();
                        oDistrict_kpi.DISTRICT_KPI_ID = -1;
                        oDistrict_kpi.DISTRICT_ID = this.LEVEL_ID;
                        oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oDistrict_kpi.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_District_kpi.push(oDistrict_kpi);
                    });
                }
                break;
            case "Area":
                if (this.LEVEL_ID) {
                    this.oList_Selected_Area_kpi = this.oOrganization_data_access.LIST_AREA_KPI.filter(oArea_kpi => oArea_kpi.AREA_ID == this.LEVEL_ID);
                    this.oList_Selected_Area_kpi.forEach(oArea_kpi => {
                        oArea_kpi.Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_Area_kpi.some(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Area").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oArea_kpi = new Area_kpi();
                        oArea_kpi.AREA_KPI_ID = -1;
                        oArea_kpi.AREA_ID = this.LEVEL_ID;
                        oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oArea_kpi.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_Area_kpi.push(oArea_kpi);
                    });
                }
                break;
            case "Site":
                if (this.LEVEL_ID) {
                    this.oList_Selected_Site_kpi = this.oOrganization_data_access.LIST_SITE_KPI.filter(oSite_kpi => oSite_kpi.SITE_ID == this.LEVEL_ID);
                    this.oList_Selected_Site_kpi.forEach(oSite_kpi => {
                        oSite_kpi.Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_Site_kpi.some(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Site").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oSite_kpi = new Site_kpi();
                        oSite_kpi.SITE_KPI_ID = -1;
                        oSite_kpi.SITE_ID = this.LEVEL_ID;
                        oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oSite_kpi.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_Site_kpi.push(oSite_kpi);
                    });
                }
                break;
            case "Entity":
                if (this.LEVEL_ID) {
                    this.oList_Selected_Entity_kpi = this.oOrganization_data_access.LIST_ENTITY_KPI.filter(oEntity_kpi => oEntity_kpi.ENTITY_ID == this.LEVEL_ID);
                    this.oList_Selected_Entity_kpi.forEach(oEntity_kpi => {
                        oEntity_kpi.Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.find(oOrganization_data_source_kpi => oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    });
                    this.oList_Organization_data_source_kpi = this.oOrganization_data_access.LIST_ORGANIZATION_DATA_SOURCE_KPI.filter(oOrganization_data_source_kpi => !this.oList_Selected_Entity_kpi.some(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER <= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity").DISPLAY_ORDER
                        && this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID).DISPLAY_ORDER >= this.CmSvc.Get_Setup_By_Setup_Category_Name_And_Setup_VALUE("Data Level", "Entity").DISPLAY_ORDER);
                    this.oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                        let oEntity_kpi = new Entity_kpi();
                        oEntity_kpi.ENTITY_KPI_ID = -1;
                        oEntity_kpi.ENTITY_ID = this.LEVEL_ID;
                        oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
                        oEntity_kpi.Organization_data_source_kpi = oOrganization_data_source_kpi;
                        this.oList_Available_Entity_kpi.push(oEntity_kpi);
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
                if (this.oSelected_District_kpi) {
                    this.oList_Selected_District_kpi.push(this.oSelected_District_kpi);
                    var index = this.oList_Available_District_kpi.findIndex(oDistrict_kpi => oDistrict_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_District_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_District_kpi.splice(index, 1);
                    this.oList_Selected_District_kpi.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_District_kpi = null;
                }
                break;
            case "Area":
                if (this.oSelected_Area_kpi) {
                    this.oList_Selected_Area_kpi.push(this.oSelected_Area_kpi);
                    var index = this.oList_Available_Area_kpi.findIndex(oArea_kpi => oArea_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_Area_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_Area_kpi.splice(index, 1);
                    this.oList_Selected_Area_kpi.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_Area_kpi = null;
                }
                break;
            case "Site":
                if (this.oSelected_Site_kpi) {
                    this.oList_Selected_Site_kpi.push(this.oSelected_Site_kpi);
                    var index = this.oList_Available_Site_kpi.findIndex(oSite_kpi => oSite_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_Site_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_Site_kpi.splice(index, 1);
                    this.oList_Selected_Site_kpi.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_Site_kpi = null;
                }
                break;
            case "Entity":
                if (this.oSelected_Entity_kpi) {
                    this.oList_Selected_Entity_kpi.push(this.oSelected_Entity_kpi);
                    var index = this.oList_Available_Entity_kpi.findIndex(oEntity_kpi => oEntity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == this.oSelected_Entity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                    this.oList_Available_Entity_kpi.splice(index, 1);
                    this.oList_Selected_Entity_kpi.sort((a, b) =>
                        a.Organization_data_source_kpi.Kpi.DIMENSION_ID - b.Organization_data_source_kpi.Kpi.DIMENSION_ID
                    );
                    this.oSelected_Entity_kpi = null;
                }
                break;
        }
    }

    Add_Add_Level_kpi_Per_Dimension() {
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                var oList_District_kpi = this.oList_Available_District_kpi.filter(oDistrict_kpi => oDistrict_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_District_kpi.forEach(oDistrict_kpi => {
                    this.oSelected_District_kpi = oDistrict_kpi;
                    this.Add_Level_kpi();
                });
                break
            case "Area":
                var oList_Area_kpi = this.oList_Available_Area_kpi.filter(oArea_kpi => oArea_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_Area_kpi.forEach(oArea_kpi => {
                    this.oSelected_Area_kpi = oArea_kpi;
                    this.Add_Level_kpi();
                });
                break
            case "Site":
                var oList_Site_kpi = this.oList_Available_Site_kpi.filter(oSite_kpi => oSite_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_Site_kpi.forEach(oSite_kpi => {
                    this.oSelected_Site_kpi = oSite_kpi;
                    this.Add_Level_kpi();
                });
                break
            case "Entity":
                var oList_Entity_kpi = this.oList_Available_Entity_kpi.filter(oEntity_kpi => oEntity_kpi.Organization_data_source_kpi.Kpi.DIMENSION_ID == this.oDimension.DIMENSION_ID);
                oList_Entity_kpi.forEach(oEntity_kpi => {
                    this.oSelected_Entity_kpi = oEntity_kpi;
                    this.Add_Level_kpi();
                });
                break
        }
    }

    Remove_Level_kpi(index: number) {
        this.isListChanged = true;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                let oDistrict_kpi = this.oList_Selected_District_kpi[index];
                this.oList_Available_District_kpi.push(oDistrict_kpi);
                this.oList_Selected_District_kpi.splice(index, 1);
                break;
            case "Area":
                let oArea_kpi = this.oList_Selected_Area_kpi[index];
                this.oList_Available_Area_kpi.push(oArea_kpi);
                this.oList_Selected_Area_kpi.splice(index, 1);
                break;
            case "Site":
                let oSite_kpi = this.oList_Selected_Site_kpi[index];
                this.oList_Available_Site_kpi.push(oSite_kpi);
                this.oList_Selected_Site_kpi.splice(index, 1);
                break;
            case "Entity":
                let oEntity_kpi = this.oList_Selected_Entity_kpi[index];
                this.oList_Available_Entity_kpi.push(oEntity_kpi);
                this.oList_Selected_Entity_kpi.splice(index, 1);
                break;
        }
    }

    Reset_Organization_Data_Access() {
        this.Update_Level_kpi_List();
        this.isListChanged = false;
    }

    Edit_Organization_Data_Access() {
        this.isLoading = true;
        switch (this.oSelected_Data_access_level_Setup.VALUE) {
            case "District":
                if (this.AddToChildren) {
                    const oParams_Edit_Organization_Data_Access = new Params_Edit_Organization_Data_Access();
                    oParams_Edit_Organization_Data_Access.List_To_Edit_District_kpi = this.oList_Selected_District_kpi.filter(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID == -1);
                    oParams_Edit_Organization_Data_Access.List_To_Delete_District_kpi = this.oList_Available_District_kpi.filter(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID != -1);
                    oParams_Edit_Organization_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_Organization_Data_Access(oParams_Edit_Organization_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.isLoading = false;
                    })
                } else {
                    const oParams_Edit_District_kpi_List = new Params_Edit_District_kpi_List();
                    oParams_Edit_District_kpi_List.List_To_Edit = this.oList_Selected_District_kpi.filter(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID == -1);
                    oParams_Edit_District_kpi_List.List_To_Delete = this.oList_Available_District_kpi.filter(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID != -1).map(oDistrict_kpi => oDistrict_kpi.DISTRICT_KPI_ID);
                    this.OrganizationManagementService.Edit_District_kpi_List(oParams_Edit_District_kpi_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.isLoading = false;
                    })
                }
                break;
            case "Area":
                if (this.AddToChildren) {
                    const oParams_Edit_Organization_Data_Access = new Params_Edit_Organization_Data_Access();
                    oParams_Edit_Organization_Data_Access.List_To_Edit_Area_kpi = this.oList_Selected_Area_kpi.filter(oArea_kpi => oArea_kpi.AREA_KPI_ID == -1);
                    oParams_Edit_Organization_Data_Access.List_To_Delete_Area_kpi = this.oList_Available_Area_kpi.filter(oArea_kpi => oArea_kpi.AREA_KPI_ID != -1);
                    oParams_Edit_Organization_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_Organization_Data_Access(oParams_Edit_Organization_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.isLoading = false;
                    })
                } else {
                    const oParams_Edit_Area_kpi_List = new Params_Edit_Area_kpi_List();
                    oParams_Edit_Area_kpi_List.List_To_Edit = this.oList_Selected_Area_kpi.filter(oArea_kpi => oArea_kpi.AREA_KPI_ID == -1);
                    oParams_Edit_Area_kpi_List.List_To_Delete = this.oList_Available_Area_kpi.filter(oArea_kpi => oArea_kpi.AREA_KPI_ID != -1).map(oArea_kpi => oArea_kpi.AREA_KPI_ID);
                    this.OrganizationManagementService.Edit_Area_kpi_List(oParams_Edit_Area_kpi_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.isLoading = false;
                    })
                }
                break;
            case "Site":
                if (this.AddToChildren) {
                    const oParams_Edit_Organization_Data_Access = new Params_Edit_Organization_Data_Access();
                    oParams_Edit_Organization_Data_Access.List_To_Edit_Site_kpi = this.oList_Selected_Site_kpi.filter(oSite_kpi => oSite_kpi.SITE_KPI_ID == -1);;
                    oParams_Edit_Organization_Data_Access.List_To_Delete_Site_kpi = this.oList_Available_Site_kpi.filter(oSite_kpi => oSite_kpi.SITE_KPI_ID != -1);
                    oParams_Edit_Organization_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_Organization_Data_Access(oParams_Edit_Organization_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.isLoading = false;
                    })
                } else {
                    const oParams_Edit_Site_kpi_List = new Params_Edit_Site_kpi_List();
                    oParams_Edit_Site_kpi_List.List_To_Edit = this.oList_Selected_Site_kpi.filter(oSite_kpi => oSite_kpi.SITE_KPI_ID == -1);;
                    oParams_Edit_Site_kpi_List.List_To_Delete = this.oList_Available_Site_kpi.filter(oSite_kpi => oSite_kpi.SITE_KPI_ID != -1).map(oSite_kpi => oSite_kpi.SITE_KPI_ID);
                    this.OrganizationManagementService.Edit_Site_kpi_List(oParams_Edit_Site_kpi_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.isLoading = false;
                    })
                }
                break;
            case "Entity":
                if (this.AddToChildren) {
                    const oParams_Edit_Organization_Data_Access = new Params_Edit_Organization_Data_Access();
                    oParams_Edit_Organization_Data_Access.List_To_Edit_Entity_kpi = this.oList_Selected_Entity_kpi.filter(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID == -1);;
                    oParams_Edit_Organization_Data_Access.List_To_Delete_Entity_kpi = this.oList_Available_Entity_kpi.filter(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID != -1);
                    oParams_Edit_Organization_Data_Access.Selected_Level_Setup = this.oSelected_Data_access_level_Setup;
                    this.OrganizationManagementService.Edit_Organization_Data_Access(oParams_Edit_Organization_Data_Access).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: true
                        });
                        this.isLoading = false;
                    })
                } else {
                    const oParams_Edit_Entity_kpi_List = new Params_Edit_Entity_kpi_List();
                    oParams_Edit_Entity_kpi_List.List_To_Edit = this.oList_Selected_Entity_kpi.filter(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID == -1);;
                    oParams_Edit_Entity_kpi_List.List_To_Delete = this.oList_Available_Entity_kpi.filter(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID != -1).map(oEntity_kpi => oEntity_kpi.ENTITY_KPI_ID);
                    this.OrganizationManagementService.Edit_Entity_kpi_List(oParams_Edit_Entity_kpi_List).then(result => {
                        this.dialogRef.close({
                            response: result,
                            AddToChildren: false
                        });
                        this.isLoading = false;
                    })
                }
                break;
        }
    }

    @HostListener('window:resize', ['$event'])
    onResize(event) {
        this.isMobileView = window.innerWidth < 600;
    }
}
