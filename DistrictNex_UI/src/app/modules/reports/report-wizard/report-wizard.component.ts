import { ChangeDetectorRef, Component, QueryList, ViewChild, ViewChildren } from '@angular/core';
import { MatCheckbox, MatCheckboxChange } from '@angular/material/checkbox';
import { MatAccordion, MatExpansionPanel } from '@angular/material/expansion';
import { Router } from '@angular/router';
import { Access_Control_Object } from 'app/core/Models/models';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Dimension, District, Entity, Enum_Timespan, Kpi, Organization_data_source_kpi, Params_Get_Report_Details, Setup, Site } from 'app/core/Services/proxy.service';

import { SmartrSplashScreenService } from 'app/shared/components/splash-screen/splash-screen.service';
import { ReportsService } from '../reports.service';

@Component({
    selector: 'report-wizard',
    templateUrl: './report-wizard.component.html',
    styleUrls: ['./report-wizard.component.scss']
})
export class ReportWizardComponent {

    oParams_Get_Report_Details: Params_Get_Report_Details;
    maxDate = new Date();

    Enum_Timespan = Enum_Timespan;
    Enum_Timespan_Keys: string[];
    oChosen_Enum_Timespan: string;

    oList_Access_Control_Object: Access_Control_Object[] = [];

    oList_Kpi: Kpi[];
    oList_Entity: Entity[];
    oList_Site: Site[];
    oList_Area: Area[];
    oList_District: District[];
    oList_Dimension: Dimension[];
    oList_Data_access_level_setup: Setup[];
    oList_Organization_data_source_kpi: Organization_data_source_kpi[] = [];
    previousExpansionValue = false;

    @ViewChild('mainAccordion') mainAccordion: MatAccordion;
    @ViewChildren('accessControlPanel') oList_Access_control_expansion_panel: QueryList<MatExpansionPanel>;

    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private ReportsService: ReportsService,
        private _changeDetectorRef: ChangeDetectorRef,
        private SmartrSplashScreenService: SmartrSplashScreenService,
    ) {
        this.ReportsService.Get_Dimension_By_OWNER_ID().then(result => {
            this.oList_Dimension = result;
        });
        this.Enum_Timespan_Keys = Object.keys(Enum_Timespan);
        this.Enum_Timespan_Keys = this.Enum_Timespan_Keys.slice(0, this.Enum_Timespan_Keys.length / 2);
        this.Enum_Timespan_Keys.pop();
        this.Enum_Timespan_Keys.shift();
        this.oChosen_Enum_Timespan = this.Enum_Timespan_Keys[0];
        this.oList_District = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.DISTRICT_LIST;
        this.oList_Area = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.AREA_LIST;
        this.oList_Site = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.SITE_LIST;
        this.oList_Entity = this.CmSvc.oUser_Accessible_Level_List.ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL.ENTITY_LIST;
        this.oList_Data_access_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup.filter(setup => setup.IS_VISIBLE && setup.VALUE != "Top-Level" && setup.VALUE != "Space" && setup.VALUE != "Floor");
        this.oList_Organization_data_source_kpi = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST;
        this.oParams_Get_Report_Details = new Params_Get_Report_Details();
    }

    applyFilter() {
        const oList_Access_Control_Object = this.oList_Access_Control_Object.filter(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID != null && access_control_object.LEVEL_ID != null);
        if (oList_Access_Control_Object.length == 0) {
            this.CmSvc.ShowMessage("Please choose a level with the object", 3000);
            return;
        }
        if (this.oParams_Get_Report_Details.START_DATE && this.oParams_Get_Report_Details.END_DATE && this.oParams_Get_Report_Details.START_DATE > this.oParams_Get_Report_Details.END_DATE) {
            this.CmSvc.ShowMessage("Start date is greater than end date");
            return;
        }
        this.oParams_Get_Report_Details.ENUM_TIMESPAN = Number(this.oChosen_Enum_Timespan);
        this.oParams_Get_Report_Details.LIST_DISTRICT_ASSET_DEFINITION = oList_Access_Control_Object.filter(access_control_object => this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", access_control_object.DATA_LEVEL_SETUP_ID).VALUE == "District").map(access_control_object => {
            return {
                LEVEL_ID: access_control_object.LEVEL_ID,
                LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: access_control_object.List_ORGANIZATION_DATA_SOURCE_KPI_ID,
            }
        });
        this.oParams_Get_Report_Details.LIST_AREA_ASSET_DEFINITION = oList_Access_Control_Object.filter(access_control_object => this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", access_control_object.DATA_LEVEL_SETUP_ID).VALUE == "Area").map(access_control_object => {
            return {
                LEVEL_ID: access_control_object.LEVEL_ID,
                LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: access_control_object.List_ORGANIZATION_DATA_SOURCE_KPI_ID,
            }
        });
        this.oParams_Get_Report_Details.LIST_SITE_ASSET_DEFINITION = oList_Access_Control_Object.filter(access_control_object => this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", access_control_object.DATA_LEVEL_SETUP_ID).VALUE == "Site").map(access_control_object => {
            return {
                LEVEL_ID: access_control_object.LEVEL_ID,
                LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: access_control_object.List_ORGANIZATION_DATA_SOURCE_KPI_ID,
            }
        });
        this.oParams_Get_Report_Details.LIST_ENTITY_ASSET_DEFINITION = oList_Access_Control_Object.filter(access_control_object => this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", access_control_object.DATA_LEVEL_SETUP_ID).VALUE == "Entity").map(access_control_object => {
            return {
                LEVEL_ID: access_control_object.LEVEL_ID,
                LIST_ORGANIZATION_DATA_SOURCE_KPI_ID: access_control_object.List_ORGANIZATION_DATA_SOURCE_KPI_ID,
            }
        });
        this.SmartrSplashScreenService.show();
        this.ReportsService.Get_Report_Details(this.oParams_Get_Report_Details).then(result => {
            if (result) {
                this.router.navigateByUrl(this.router.url + '/generated-report');
            }
            this.SmartrSplashScreenService.hide();
        });
    }

    //#region All Objects
    getObjects(i_Access_Control_Object: Access_Control_Object): any {
        switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return this.getEntities(i_Access_Control_Object);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.getSites(i_Access_Control_Object);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.getAreas(i_Access_Control_Object);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.getDistricts(i_Access_Control_Object);
        }
        return [];
    }

    getObjectId(Data_level_setup_ID: number, i_Object: any): number {
        switch (Data_level_setup_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return i_Object.ENTITY_ID;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return i_Object.SITE_ID;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return i_Object.AREA_ID;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return i_Object.DISTRICT_ID;
        }
    }

    getObjectName(Data_level_setup_ID: number, OBJECT_ID: number): string {
        switch (Data_level_setup_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return this.oList_Entity.find(entity => entity.ENTITY_ID == OBJECT_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site.find(site => site.SITE_ID == OBJECT_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area.find(area => area.AREA_ID == OBJECT_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District.find(district => district.DISTRICT_ID == OBJECT_ID).NAME;
        }
    }

    getSetupValue(Data_level_setup_ID: number): string {
        return this.oList_Data_access_level_setup.find(setup => setup.SETUP_ID == Data_level_setup_ID)?.VALUE ?? "Choose Data Level First";
    }
    //#endregion

    //#region Getting Assignement data
    getDistricts(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_District?.filter(district => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && access_control_object.LEVEL_ID == district.DISTRICT_ID && i_Access_Control_Object.LEVEL_ID != district.DISTRICT_ID));
    }

    getAreas(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Area?.filter(area => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && access_control_object.LEVEL_ID == area.AREA_ID && i_Access_Control_Object.LEVEL_ID != area.AREA_ID));
    }

    getSites(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Site?.filter(site => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && access_control_object.LEVEL_ID == site.SITE_ID && i_Access_Control_Object.LEVEL_ID != site.SITE_ID));
    }

    getEntities(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Entity?.filter(entity => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && access_control_object.LEVEL_ID == entity.ENTITY_ID && i_Access_Control_Object.LEVEL_ID != entity.ENTITY_ID));
    }
    //#endregion

    //#region Check Dimension
    CheckOrganizationDataSourceKpi(MatCheckboxChange: MatCheckboxChange, i_Access_Control_Object: Access_Control_Object, i_Organization_data_source_kpi: Organization_data_source_kpi) {
        if (MatCheckboxChange.checked) {
            i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.push(i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
        } else {
            i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.splice(i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.findIndex(organization_data_source_kpi_id => organization_data_source_kpi_id == i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID), 1);
        }
    }

    CheckDimension(MatCheckbox: MatCheckbox, i_Access_Control_Object: Access_Control_Object, DIMENSION_ID: number) {
        let oList_Organization_data_source_kpi = i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.DIMENSION_ID == DIMENSION_ID);
        if (MatCheckbox.checked) {
            oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                if (!i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)) {
                    i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.push(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            });
        }
        else {
            oList_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                if (i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)) {
                    i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.splice(i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.findIndex(organization_data_source_kpi_id => organization_data_source_kpi_id == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID), 1);
                }
            });
        }
    }

    CheckAllOrganizationDataSourceKpi(MatCheckbox: MatCheckbox, i_Access_Control_Object: Access_Control_Object) {
        if (MatCheckbox.checked) {
            i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                if (!i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)) {
                    i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.push(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            });
        }
        else {
            i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.forEach(oOrganization_data_source_kpi => {
                if (i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID)) {
                    i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.splice(i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.findIndex(organization_data_source_kpi_id => organization_data_source_kpi_id == oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID), 1);
                }
            });
        }
    }

    isOrganizationDataSourceKpiChecked(i_Access_Control_Object: Access_Control_Object, i_Organization_data_source_kpi: Organization_data_source_kpi) {
        return i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
    }

    isDimensionChecked(i_Access_Control_Object: Access_Control_Object, DIMENSION_ID: number) {
        if (i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.length == 0) {
            return false;
        } else {
            let oList_Organization_data_source_kpi = i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.filter(oOrganization_data_source_kpi => oOrganization_data_source_kpi.Kpi.DIMENSION_ID == DIMENSION_ID);
            const allExist = oList_Organization_data_source_kpi.every(oOrganization_data_source_kpi => i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID));
            if (allExist) {
                return true;
            } else {
                return false
            }
        }
    }

    isAllOrganizationDataSourceKpiChecked(i_Access_Control_Object: Access_Control_Object) {
        if (i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.length == 0) {
            return false;
        } else {
            const allExist = i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.every(oOrganization_data_source_kpi => i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.includes(oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID));
            if (allExist) {
                return true;
            } else {
                return false
            }
        }
    }
    //#endregion

    filterOrganizationDataSourceKpis(i_Access_Control_Object: Access_Control_Object) {
        switch (this.CmSvc.Get_Setup_By_Setup_Category_Name_And_SETUP_ID("Data Level", i_Access_Control_Object.DATA_LEVEL_SETUP_ID).VALUE) {
            case "District":
                let oOrganization_data_source_kpi_Simple_District = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID);
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi = this.oList_Organization_data_source_kpi.filter(organization_data_source_kpi => oOrganization_data_source_kpi_Simple_District.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE.some(oOrganization_data_source_kpi_simple => organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi_simple.ORGANIZATION_DATA_SOURCE_KPI_ID));
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.sort((a, b) => b.Kpi.DIMENSION_ID - a.Kpi.DIMENSION_ID);
                return i_Access_Control_Object.List_Filtered_Organization_data_source_kpi;
            case "Area":
                let oOrganization_data_source_kpi_Simple_Area = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID);
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi = this.oList_Organization_data_source_kpi.filter(organization_data_source_kpi => oOrganization_data_source_kpi_Simple_Area.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE.some(oOrganization_data_source_kpi_simple => organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi_simple.ORGANIZATION_DATA_SOURCE_KPI_ID));
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.sort((a, b) => b.Kpi.DIMENSION_ID - a.Kpi.DIMENSION_ID);
                return i_Access_Control_Object.List_Filtered_Organization_data_source_kpi;
            case "Site":
                let oOrganization_data_source_kpi_Simple_Site = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID);
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi = this.oList_Organization_data_source_kpi.filter(organization_data_source_kpi => oOrganization_data_source_kpi_Simple_Site.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE.some(oOrganization_data_source_kpi_simple => organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi_simple.ORGANIZATION_DATA_SOURCE_KPI_ID));
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.sort((a, b) => b.Kpi.DIMENSION_ID - a.Kpi.DIMENSION_ID);
                return i_Access_Control_Object.List_Filtered_Organization_data_source_kpi;
            case "Entity":
                let oOrganization_data_source_kpi_Simple_Entity = this.CmSvc.oUser_Accessible_Level_List.ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY.find(oOrganization_data_source_kpi_ID_By_Level_ID => oOrganization_data_source_kpi_ID_By_Level_ID.LEVEL_ID == i_Access_Control_Object.LEVEL_ID);
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi = this.oList_Organization_data_source_kpi.filter(organization_data_source_kpi => oOrganization_data_source_kpi_Simple_Entity.LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE.some(oOrganization_data_source_kpi_simple => organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == oOrganization_data_source_kpi_simple.ORGANIZATION_DATA_SOURCE_KPI_ID));
                i_Access_Control_Object.List_Filtered_Organization_data_source_kpi.sort((a, b) => b.Kpi.DIMENSION_ID - a.Kpi.DIMENSION_ID);
                return i_Access_Control_Object.List_Filtered_Organization_data_source_kpi;
        }
    }

    getDimensionName(DIMENSION_ID: number) {
        return this.oList_Dimension.find(oDimension => oDimension.DIMENSION_ID == DIMENSION_ID).NAME;
    }

    dataLevelChanged(i_Access_Control_Object: Access_Control_Object) {
        i_Access_Control_Object.LEVEL_ID = null;
        i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID = i_Access_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID.filter(ORGANIZATION_DATA_SOURCE_KPI_ID => this.filterOrganizationDataSourceKpis(i_Access_Control_Object).some(organization_data_source_kpi => organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == ORGANIZATION_DATA_SOURCE_KPI_ID));
    }

    addAccessControlObject() {
        const oAccess_Control_Object = new Access_Control_Object();
        oAccess_Control_Object.List_ORGANIZATION_DATA_SOURCE_KPI_ID = [];
        oAccess_Control_Object.List_Filtered_Organization_data_source_kpi = [];
        this.oList_Access_Control_Object.unshift(oAccess_Control_Object);
        this._changeDetectorRef.detectChanges();
    }

    removeAccessControlObject(i_Access_Control_Object: Access_Control_Object) {
        this.oList_Access_Control_Object.splice(this.oList_Access_Control_Object.indexOf(i_Access_Control_Object), 1);
        this._changeDetectorRef.detectChanges();
    }

    togglePanels() {
        if (this.isSomePanelClosed()) {
            this.mainAccordion.openAll();
        } else {
            this.mainAccordion.closeAll();
        }
    }

    getEnumCollectionValue(i_Enum_Timespan_Key_String: string) {
        var i_Enum_Timespan_Key_Number: Number;
        i_Enum_Timespan_Key_Number = Number(i_Enum_Timespan_Key_String);
        switch (i_Enum_Timespan_Key_Number) {
            case Enum_Timespan.X_HOURLY_COLLECTION:
                return "Hourly";
            case Enum_Timespan.X_DAILY_COLLECTION:
                return "Daily";
            case Enum_Timespan.X_WEEKLY_COLLECTION:
                return "Weekly";
            case Enum_Timespan.X_MONTHLY_COLLECTION:
                return "Monthly";
        }
    }

    isSomePanelClosed() {
        let isCheck = false;
        if (this.previousExpansionValue != this.oList_Access_control_expansion_panel?.some(panel => !panel.expanded)) {
            isCheck = true;
        }
        this.previousExpansionValue = this.oList_Access_control_expansion_panel?.some(panel => !panel.expanded);
        if (isCheck) {
            this._changeDetectorRef.detectChanges();
        }
        return this.oList_Access_control_expansion_panel?.some(panel => !panel.expanded);
    }
}
