import { ChangeDetectorRef, Component, OnInit, QueryList, ViewChild, ViewChildren } from '@angular/core';
import { ThemePalette } from '@angular/material/core';
import { MatAccordion, MatExpansionPanel } from '@angular/material/expansion';
import { ProgressSpinnerMode } from '@angular/material/progress-spinner';
import { ActivatedRoute, Router } from '@angular/router';
import { Access_Control_Object } from 'app/core/Models/Access_Control';
import { CommonService } from 'app/core/Services/common.service';
import { Area, District, Entity, Organization, Params_Edit_User_level_access_List, Setup, Site, Top_level, User, User_level_access } from 'app/core/Services/proxy.service';
import { OrganizationManagementService } from 'app/modules/organization-management/organization-management.service';
import { cloneDeep } from 'lodash';

@Component({
    selector: 'user-access-control',
    templateUrl: './user-access-control.component.html',
    styleUrls: ['./user-access-control.component.scss']
})
export class UserAccessControlComponent implements OnInit {

    value = 50;
    pageSize = 20;
    pageIndex = 0;

    oTheme_Palette_Color: ThemePalette = 'accent';
    oProgress_Spinner_Mode: ProgressSpinnerMode = 'indeterminate';

    oUser: User;
    oOrganization: Organization;

    oList_User_level_access: User_level_access[] = [];
    oList_Access_Control_Object: Access_Control_Object[];

    oList_Site: Site[];
    oList_Area: Area[];
    oList_Entity: Entity[];
    oList_District: District[];
    oList_Top_level: Top_level[];
    oList_Data_access_level_setup: Setup[];

    isFetchingSites = false;
    isFetchingAreas = false;
    isFetchingEntities = false;
    isFetchingDistricts = false;
    isFetchingTopLevels = false;
    isProgressSpinnerVisible = false;
    isPreviousExpansionValue = false;

    searchInputValue = '';

    @ViewChild('mainAccordion') mainAccordion: MatAccordion;
    @ViewChildren('accessControlPanel') oList_Access_control_expansion_panel: QueryList<MatExpansionPanel>;

    constructor(
        private router: Router,
        private CmSvc: CommonService,
        private ActivatedRoute: ActivatedRoute,
        private _changeDetectorRef: ChangeDetectorRef,
        private OrganizationManagementService: OrganizationManagementService,
    ) {
        this.oList_Data_access_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup;
        this.oList_Data_access_level_setup = this.oList_Data_access_level_setup.filter(oSetup => oSetup.VALUE != "Floor");
        this.oList_Data_access_level_setup = this.oList_Data_access_level_setup.filter(oSetup => oSetup.VALUE != "Space");
    }

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
            this.resetUserAccess();
        });
    }

    //#region All Objects
    getObject(i_User_level_access: User_level_access): any {
        switch (i_User_level_access.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return this.oList_Entity.find(entity => entity.ENTITY_ID == i_User_level_access.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site.find(site => site.SITE_ID == i_User_level_access.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area.find(area => area.AREA_ID == i_User_level_access.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District.find(district => district.DISTRICT_ID == i_User_level_access.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                return this.oList_Top_level.find(top_level => top_level.TOP_LEVEL_ID == i_User_level_access.LEVEL_ID);
        }
    }

    getObjectFromAccessControl(i_Access_Control_Object: Access_Control_Object): any {
        switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return this.oList_Entity.find(entity => entity.ENTITY_ID == i_Access_Control_Object.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site.find(site => site.SITE_ID == i_Access_Control_Object.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area.find(area => area.AREA_ID == i_Access_Control_Object.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District.find(district => district.DISTRICT_ID == i_Access_Control_Object.LEVEL_ID);
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                return this.oList_Top_level.find(top_level => top_level.TOP_LEVEL_ID == i_Access_Control_Object.LEVEL_ID);
        }
    }

    getObjects(i_Access_Control_Object: Access_Control_Object): any {
        var super_organization_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Organization Type", "Super Organization");
        if (this.oOrganization.ORGANIZATION_TYPE_SETUP_ID == super_organization_setup_id) {
            switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                    if (!this.oList_Entity && !this.isFetchingEntities) {
                        this.isFetchingEntities = true;
                        this.OrganizationManagementService.Get_Entity_By_OWNER_ID().then(result => {
                            this.oList_Entity = result;
                            this.isFetchingEntities = false;
                        });
                    } else {
                        return this.getEntities(i_Access_Control_Object);
                    }
                    break;
                case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                    if (!this.oList_Site && !this.isFetchingSites) {
                        this.isFetchingSites = true;
                        this.OrganizationManagementService.Get_Site_By_OWNER_ID().then(result => {
                            this.oList_Site = result;
                            this.isFetchingSites = false;
                        });
                    } else {
                        return this.getSites(i_Access_Control_Object);
                    }
                    break;
                case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                    if (!this.oList_Area && !this.isFetchingAreas) {
                        this.isFetchingAreas = true;
                        this.OrganizationManagementService.Get_Area_By_OWNER_ID().then(result => {
                            this.oList_Area = result;
                            this.isFetchingAreas = false;
                        });
                    } else {
                        return this.getAreas(i_Access_Control_Object);
                    }
                    break;
                case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                    if (!this.oList_District && !this.isFetchingDistricts) {
                        this.isFetchingDistricts = true;
                        this.OrganizationManagementService.Get_District_By_OWNER_ID().then(result => {
                            this.oList_District = result;
                            this.isFetchingDistricts = false;
                        });
                    } else {
                        return this.getDistricts(i_Access_Control_Object);
                    }
                    break;
                case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                    if (!this.oList_Top_level && !this.isFetchingTopLevels) {
                        this.isFetchingTopLevels = true;
                        this.OrganizationManagementService.Get_Top_level_By_OWNER_ID().then(result => {
                            this.oList_Top_level = result;
                            this.isFetchingTopLevels = false;
                        });
                    } else {
                        return this.getTopLevels(i_Access_Control_Object);
                    }
                    break;
            }
        } else {
            if (this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin") {
                switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                        if (!this.oList_Entity && !this.isFetchingEntities) {
                            this.isFetchingEntities = true;
                            this.OrganizationManagementService.Get_Entity_By_OWNER_ID().then(result => {
                                this.oList_Entity = result.filter(entity => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && user_access.LEVEL_ID == entity.ENTITY_ID));
                                this.isFetchingEntities = false;
                            });
                        } else {
                            return this.getEntities(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                        if (!this.oList_Site && !this.isFetchingSites) {
                            this.isFetchingSites = true;
                            this.OrganizationManagementService.Get_Site_By_OWNER_ID().then(result => {
                                this.oList_Site = result.filter(site => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && user_access.LEVEL_ID == site.SITE_ID));
                                this.isFetchingSites = false;
                            });
                        } else {
                            return this.getSites(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                        if (!this.oList_Area && !this.isFetchingAreas) {
                            this.isFetchingAreas = true;
                            this.OrganizationManagementService.Get_Area_By_OWNER_ID().then(result => {
                                this.oList_Area = result.filter(area => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && user_access.LEVEL_ID == area.AREA_ID));
                                this.isFetchingAreas = false;
                            });
                        } else {
                            return this.getAreas(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                        if (!this.oList_District && !this.isFetchingDistricts) {
                            this.isFetchingDistricts = true;
                            this.OrganizationManagementService.Get_District_By_OWNER_ID().then(result => {
                                this.oList_District = result.filter(district => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && user_access.LEVEL_ID == district.DISTRICT_ID));
                                this.isFetchingDistricts = false;
                            });
                        } else {
                            return this.getDistricts(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                        if (!this.oList_Top_level && !this.isFetchingTopLevels) {
                            this.isFetchingTopLevels = true;
                            this.OrganizationManagementService.Get_Top_level_By_OWNER_ID().then(result => {
                                this.oList_Top_level = result.filter(top_level => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && user_access.LEVEL_ID == top_level.TOP_LEVEL_ID));
                                this.isFetchingTopLevels = false;
                            });
                        } else {
                            return this.getTopLevels(i_Access_Control_Object);
                        }
                        break;
                }
            } else {
                switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                        if (!this.oList_Entity && !this.isFetchingEntities) {
                            this.isFetchingEntities = true;
                            this.OrganizationManagementService.Get_Entity_By_ENTITY_ID_List(this.oOrganization).then(result => {
                                this.oList_Entity = result.filter(entity => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && user_access.LEVEL_ID == entity.ENTITY_ID));
                                this.isFetchingEntities = false;
                            });
                        } else {
                            return this.getEntities(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                        if (!this.oList_Site && !this.isFetchingSites) {
                            this.isFetchingSites = true;
                            this.OrganizationManagementService.Get_Site_By_SITE_ID_List(this.oOrganization).then(result => {
                                this.oList_Site = result.filter(site => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && user_access.LEVEL_ID == site.SITE_ID));
                                this.isFetchingSites = false;
                            });
                        } else {
                            return this.getSites(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                        if (!this.oList_Area && !this.isFetchingAreas) {
                            this.isFetchingAreas = true;
                            this.OrganizationManagementService.Get_Area_By_AREA_ID_List(this.oOrganization).then(result => {
                                this.oList_Area = result.filter(area => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && user_access.LEVEL_ID == area.AREA_ID));
                                this.isFetchingAreas = false;
                            });
                        } else {
                            return this.getAreas(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                        if (!this.oList_District && !this.isFetchingDistricts) {
                            this.isFetchingDistricts = true;
                            this.OrganizationManagementService.Get_District_By_DISTRICT_ID_List(this.oOrganization).then(result => {
                                this.oList_District = result.filter(district => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && user_access.LEVEL_ID == district.DISTRICT_ID));
                                this.isFetchingDistricts = false;
                            });
                        } else {
                            return this.getDistricts(i_Access_Control_Object);
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                        if (!this.oList_Top_level && !this.isFetchingTopLevels) {
                            this.isFetchingTopLevels = true;
                            this.OrganizationManagementService.Get_Top_level_By_TOP_LEVEL_ID_List(this.oOrganization).then(result => {
                                this.oList_Top_level = result.filter(top_level => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && user_access.LEVEL_ID == top_level.TOP_LEVEL_ID));
                                this.isFetchingTopLevels = false;
                            });
                        } else {
                            return this.getTopLevels(i_Access_Control_Object);
                        }
                        break;
                }
            }
        }
        return [];
    }

    getObjectsAsync(i_Access_Control_Object: Access_Control_Object): Promise<any> {
        return new Promise<any>(resolve => {
            var super_organization_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Organization Type", "Super Organization");
            if (this.oOrganization.ORGANIZATION_TYPE_SETUP_ID == super_organization_setup_id) {
                switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                        if (!this.oList_Entity) {
                            if (!this.isFetchingEntities) {
                                this.isFetchingEntities = true;
                                this.OrganizationManagementService.Get_Entity_By_OWNER_ID().then(result => {
                                    this.oList_Entity = result;
                                    this.isFetchingEntities = false;
                                    resolve(this.getEntities(i_Access_Control_Object));
                                });
                            }
                        } else {
                            resolve(this.getEntities(i_Access_Control_Object));
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                        if (!this.oList_Site) {
                            if (!this.isFetchingSites) {
                                this.isFetchingSites = true;
                                this.OrganizationManagementService.Get_Site_By_OWNER_ID().then(result => {
                                    this.oList_Site = result;
                                    this.isFetchingSites = false;
                                    resolve(this.getSites(i_Access_Control_Object));
                                });
                            }
                        } else {
                            resolve(this.getSites(i_Access_Control_Object));
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                        if (!this.oList_Area) {
                            if (!this.isFetchingAreas) {
                                this.isFetchingAreas = true;
                                this.OrganizationManagementService.Get_Area_By_OWNER_ID().then(result => {
                                    this.oList_Area = result;
                                    this.isFetchingAreas = false;
                                    resolve(this.getAreas(i_Access_Control_Object));
                                });
                            }
                        } else {
                            resolve(this.getAreas(i_Access_Control_Object));
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                        if (!this.oList_District) {
                            if (!this.isFetchingDistricts) {
                                this.isFetchingDistricts = true;
                                this.OrganizationManagementService.Get_District_By_OWNER_ID().then(result => {
                                    this.oList_District = result;
                                    this.isFetchingDistricts = false;
                                    resolve(this.getDistricts(i_Access_Control_Object));
                                });
                            }
                        } else {
                            resolve(this.getDistricts(i_Access_Control_Object));
                        }
                        break;
                    case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                        if (!this.oList_Top_level) {
                            if (!this.isFetchingTopLevels) {
                                this.isFetchingTopLevels = true;
                                this.OrganizationManagementService.Get_Top_level_By_OWNER_ID().then(result => {
                                    this.oList_Top_level = result;
                                    this.isFetchingTopLevels = false;
                                    resolve(this.getTopLevels(i_Access_Control_Object));
                                });
                            }
                        } else {
                            resolve(this.getTopLevels(i_Access_Control_Object));
                        }
                        break;
                }
            } else {
                if (this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin") {
                    switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                            if (!this.oList_Entity) {
                                if (!this.isFetchingEntities) {
                                    this.isFetchingEntities = true;
                                    this.OrganizationManagementService.Get_Entity_By_OWNER_ID().then(result => {
                                        this.oList_Entity = result.filter(entity => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && user_access.LEVEL_ID == entity.ENTITY_ID));
                                        this.isFetchingEntities = false;
                                        resolve(this.getEntities(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getEntities(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                            if (!this.oList_Site) {
                                if (!this.isFetchingSites) {
                                    this.isFetchingSites = true;
                                    this.OrganizationManagementService.Get_Site_By_OWNER_ID().then(result => {
                                        this.oList_Site = result.filter(site => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && user_access.LEVEL_ID == site.SITE_ID));
                                        this.isFetchingSites = false;
                                        resolve(this.getSites(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getSites(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                            if (!this.oList_Area) {
                                if (!this.isFetchingAreas) {
                                    this.isFetchingAreas = true;
                                    this.OrganizationManagementService.Get_Area_By_OWNER_ID().then(result => {
                                        this.oList_Area = result.filter(area => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && user_access.LEVEL_ID == area.AREA_ID));
                                        this.isFetchingAreas = false;
                                        resolve(this.getAreas(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getAreas(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                            if (!this.oList_District) {
                                if (!this.isFetchingDistricts) {
                                    this.isFetchingDistricts = true;
                                    this.OrganizationManagementService.Get_District_By_OWNER_ID().then(result => {
                                        this.oList_District = result.filter(district => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && user_access.LEVEL_ID == district.DISTRICT_ID));
                                        this.isFetchingDistricts = false;
                                        resolve(this.getDistricts(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getDistricts(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                            if (!this.oList_Top_level) {
                                if (!this.isFetchingTopLevels) {
                                    this.isFetchingTopLevels = true;
                                    this.OrganizationManagementService.Get_Top_level_By_OWNER_ID().then(result => {
                                        this.oList_Top_level = result.filter(top_level => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && user_access.LEVEL_ID == top_level.TOP_LEVEL_ID));
                                        this.isFetchingTopLevels = false;
                                        resolve(this.getTopLevels(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getTopLevels(i_Access_Control_Object));
                            }
                            break;
                    }
                } else {
                    switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                            if (!this.oList_Entity) {
                                if (!this.isFetchingEntities) {
                                    this.isFetchingEntities = true;
                                    this.OrganizationManagementService.Get_Entity_By_ENTITY_ID_List(this.oOrganization).then(result => {
                                        this.oList_Entity = result.filter(entity => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && user_access.LEVEL_ID == entity.ENTITY_ID));
                                        this.isFetchingEntities = false;
                                        resolve(this.getEntities(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getEntities(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                            if (!this.oList_Site) {
                                if (!this.isFetchingSites) {
                                    this.isFetchingSites = true;
                                    this.OrganizationManagementService.Get_Site_By_SITE_ID_List(this.oOrganization).then(result => {
                                        this.oList_Site = result.filter(site => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && user_access.LEVEL_ID == site.SITE_ID));
                                        this.isFetchingSites = false;
                                        resolve(this.getSites(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getSites(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                            if (!this.oList_Area) {
                                if (!this.isFetchingAreas) {
                                    this.isFetchingAreas = true;
                                    this.OrganizationManagementService.Get_Area_By_AREA_ID_List(this.oOrganization).then(result => {
                                        this.oList_Area = result.filter(area => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && user_access.LEVEL_ID == area.AREA_ID));
                                        this.isFetchingAreas = false;
                                        resolve(this.getAreas(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getAreas(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                            if (!this.oList_District) {
                                if (!this.isFetchingDistricts) {
                                    this.isFetchingDistricts = true;
                                    this.OrganizationManagementService.Get_District_By_DISTRICT_ID_List(this.oOrganization).then(result => {
                                        this.oList_District = result.filter(district => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && user_access.LEVEL_ID == district.DISTRICT_ID));
                                        this.isFetchingDistricts = false;
                                        resolve(this.getDistricts(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getDistricts(i_Access_Control_Object));
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                            if (!this.oList_Top_level) {
                                if (!this.isFetchingTopLevels) {
                                    this.isFetchingTopLevels = true;
                                    this.OrganizationManagementService.Get_Top_level_By_TOP_LEVEL_ID_List(this.oOrganization).then(result => {
                                        this.oList_Top_level = result.filter(top_level => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && user_access.LEVEL_ID == top_level.TOP_LEVEL_ID));
                                        this.isFetchingTopLevels = false;
                                        resolve(this.getTopLevels(i_Access_Control_Object));
                                    });
                                }
                            } else {
                                resolve(this.getTopLevels(i_Access_Control_Object));
                            }
                            break;
                    }
                }
            }
        });
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
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                return i_Object.TOP_LEVEL_ID;
        }
    }

    getObjectName(Data_level_setup_ID: number, LEVEL_ID: number): string {
        switch (Data_level_setup_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                return this.oList_Entity.find(entity => entity.ENTITY_ID == LEVEL_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                return this.oList_Site.find(site => site.SITE_ID == LEVEL_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                return this.oList_Area.find(area => area.AREA_ID == LEVEL_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                return this.oList_District.find(district => district.DISTRICT_ID == LEVEL_ID).NAME;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                return this.oList_Top_level.find(top_level => top_level.TOP_LEVEL_ID == LEVEL_ID).NAME;
        }
    }

    getSetupValue(Data_level_setup_ID: number): string {
        return this.oList_Data_access_level_setup.find(setup => setup.SETUP_ID == Data_level_setup_ID)?.VALUE ?? "Choose Data Level First";
    }

    changePage(paginatorEvent) {
        this.pageSize = paginatorEvent.pageSize;
        this.pageIndex = paginatorEvent.pageIndex;
    }

    detectChanges() {
        this._changeDetectorRef.detectChanges();
    }
    //#endregion

    //#region Getting Assignement data
    getTopLevels(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Top_level?.filter(top_level => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && access_control_object.LEVEL_ID == top_level.TOP_LEVEL_ID && i_Access_Control_Object.LEVEL_ID != top_level.TOP_LEVEL_ID));
    }

    getDistricts(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_District?.filter(district => this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && access_control_object.LEVEL_ID == district.TOP_LEVEL_ID)).filter(district => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && access_control_object.LEVEL_ID == district.DISTRICT_ID && i_Access_Control_Object.LEVEL_ID != district.DISTRICT_ID));
    }

    getAreas(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Area?.filter(area => this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && access_control_object.LEVEL_ID == area.TOP_LEVEL_ID)).filter(area => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && access_control_object.LEVEL_ID == area.AREA_ID && i_Access_Control_Object.LEVEL_ID != area.AREA_ID));
    }

    getSites(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Site?.filter(site => this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && access_control_object.LEVEL_ID == site.TOP_LEVEL_ID)).filter(site => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && access_control_object.LEVEL_ID == site.SITE_ID && i_Access_Control_Object.LEVEL_ID != site.SITE_ID));
    }

    getEntities(i_Access_Control_Object: Access_Control_Object) {
        return this.oList_Entity?.filter(entity => this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && access_control_object.LEVEL_ID == entity.TOP_LEVEL_ID)).filter(entity => !this.oList_Access_Control_Object.some(access_control_object => access_control_object.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && access_control_object.LEVEL_ID == entity.ENTITY_ID && i_Access_Control_Object.LEVEL_ID != entity.ENTITY_ID));
    }
    //#endregion

    //#region Add All Children
    addAllChildren(i_Access_Control_Object: Access_Control_Object) {
        switch (i_Access_Control_Object.DATA_LEVEL_SETUP_ID) {
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                this.getObjectsAsync({
                    DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID,
                    Object: null,
                    LEVEL_ID: null,
                }).then(result => {
                    (result as Entity[]).filter(entity => entity.SITE_ID == i_Access_Control_Object.LEVEL_ID).forEach(entity => {
                        const oAccess_Control_Object: Access_Control_Object = {
                            DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID,
                            Object: entity,
                            LEVEL_ID: entity.ENTITY_ID,
                        };
                        this.oList_Access_Control_Object.push(oAccess_Control_Object);
                    });
                });
                break;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                this.getObjectsAsync({
                    DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID,
                    Object: null,
                    LEVEL_ID: null,
                }).then(result => {
                    (result as Site[]).filter(site => site.AREA_ID == i_Access_Control_Object.LEVEL_ID).forEach(site => {
                        const oAccess_Control_Object: Access_Control_Object = {
                            DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID,
                            Object: site,
                            LEVEL_ID: site.SITE_ID,
                        };
                        this.oList_Access_Control_Object.push(oAccess_Control_Object);
                        this.addAllChildren(oAccess_Control_Object);
                    });
                });
                break;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                this.getObjectsAsync({
                    DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID,
                    Object: null,
                    LEVEL_ID: null,
                }).then(result => {
                    (result as Area[]).filter(area => area.DISTRICT_ID == i_Access_Control_Object.LEVEL_ID).forEach(area => {
                        const oAccess_Control_Object: Access_Control_Object = {
                            DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID,
                            Object: area,
                            LEVEL_ID: area.AREA_ID,
                        };
                        this.oList_Access_Control_Object.push(oAccess_Control_Object);
                        this.addAllChildren(oAccess_Control_Object);
                    });
                });
                break;
            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                this.getObjectsAsync({
                    DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID,
                    Object: null,
                    LEVEL_ID: null,
                }).then(result => {
                    (result as District[]).filter(district => district.TOP_LEVEL_ID == i_Access_Control_Object.LEVEL_ID).forEach(district => {
                        const oAccess_Control_Object: Access_Control_Object = {
                            DATA_LEVEL_SETUP_ID: this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID,
                            Object: district,
                            LEVEL_ID: district.DISTRICT_ID,
                        };
                        this.oList_Access_Control_Object.push(oAccess_Control_Object);
                        this.addAllChildren(oAccess_Control_Object);
                    });
                });
                break;
        }
    }
    //#endregion

    addAccessControlObject() {
        const oAccess_Control_Object = new Access_Control_Object();
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

    isSomePanelClosed() {
        let isCheck = false;
        if (this.isPreviousExpansionValue != this.oList_Access_control_expansion_panel?.some(panel => !panel.expanded)) {
            isCheck = true;
        }
        this.isPreviousExpansionValue = this.oList_Access_control_expansion_panel?.some(panel => !panel.expanded);
        if (isCheck) {
            this._changeDetectorRef.detectChanges();
        }
        return this.oList_Access_control_expansion_panel?.some(panel => !panel.expanded);
    }

    resetUserAccess() {
        this.oList_User_level_access = cloneDeep(this.oUser.List_User_level_access);
        const promises: Promise<void>[] = [];
        [...new Set(this.oList_User_level_access.map(user_access => user_access.DATA_LEVEL_SETUP_ID))].forEach(data_level_setup_id => {
            promises.push(new Promise(resolve => {
                var super_organization_setup_id = this.CmSvc.Get_Setup_ID_By_Setup_Category_Name_And_Setup_VALUE("Organization Type", "Super Organization");
                if (this.oOrganization.ORGANIZATION_TYPE_SETUP_ID == super_organization_setup_id) {
                    switch (data_level_setup_id) {
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                            if (!this.oList_Entity && !this.isFetchingEntities) {
                                this.isFetchingEntities = true;
                                this.OrganizationManagementService.Get_Entity_By_OWNER_ID().then(result => {
                                    this.oList_Entity = result;
                                    this.isFetchingEntities = false;
                                    resolve();
                                });
                            } else {
                                resolve();
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                            if (!this.oList_Site && !this.isFetchingSites) {
                                this.isFetchingSites = true;
                                this.OrganizationManagementService.Get_Site_By_OWNER_ID().then(result => {
                                    this.oList_Site = result;
                                    this.isFetchingSites = false;
                                    resolve();
                                });
                            } else {
                                resolve();
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                            if (!this.oList_Area && !this.isFetchingAreas) {
                                this.isFetchingAreas = true;
                                this.OrganizationManagementService.Get_Area_By_OWNER_ID().then(result => {
                                    this.oList_Area = result;
                                    this.isFetchingAreas = false;
                                    resolve();
                                });
                            } else {
                                resolve();
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                            if (!this.oList_District && !this.isFetchingDistricts) {
                                this.isFetchingDistricts = true;
                                this.OrganizationManagementService.Get_District_By_OWNER_ID().then(result => {
                                    this.oList_District = result;
                                    this.isFetchingDistricts = false;
                                    resolve();
                                });
                            } else {
                                resolve();
                            }
                            break;
                        case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                            if (!this.oList_Top_level && !this.isFetchingTopLevels) {
                                this.isFetchingTopLevels = true;
                                this.OrganizationManagementService.Get_Top_level_By_OWNER_ID().then(result => {
                                    this.oList_Top_level = result;
                                    this.isFetchingTopLevels = false;
                                    resolve();
                                });
                            } else {
                                resolve();
                            }
                            break;
                    }
                } else {
                    if (this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin") {
                        switch (data_level_setup_id) {
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                                if (!this.oList_Entity && !this.isFetchingEntities) {
                                    this.isFetchingEntities = true;
                                    this.OrganizationManagementService.Get_Entity_By_OWNER_ID().then(result => {
                                        this.oList_Entity = result.filter(entity => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && user_access.LEVEL_ID == entity.ENTITY_ID));
                                        this.isFetchingEntities = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                                if (!this.oList_Site && !this.isFetchingSites) {
                                    this.isFetchingSites = true;
                                    this.OrganizationManagementService.Get_Site_By_OWNER_ID().then(result => {
                                        this.oList_Site = result.filter(site => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && user_access.LEVEL_ID == site.SITE_ID));
                                        this.isFetchingSites = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                                if (!this.oList_Area && !this.isFetchingAreas) {
                                    this.isFetchingAreas = true;
                                    this.OrganizationManagementService.Get_Area_By_OWNER_ID().then(result => {
                                        this.oList_Area = result.filter(area => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && user_access.LEVEL_ID == area.AREA_ID));
                                        this.isFetchingAreas = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                                if (!this.oList_District && !this.isFetchingDistricts) {
                                    this.isFetchingDistricts = true;
                                    this.OrganizationManagementService.Get_District_By_OWNER_ID().then(result => {
                                        this.oList_District = result.filter(district => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && user_access.LEVEL_ID == district.DISTRICT_ID));
                                        this.isFetchingDistricts = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                                if (!this.oList_Top_level && !this.isFetchingTopLevels) {
                                    this.isFetchingTopLevels = true;
                                    this.OrganizationManagementService.Get_Top_level_By_OWNER_ID().then(result => {
                                        this.oList_Top_level = result.filter(top_level => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && user_access.LEVEL_ID == top_level.TOP_LEVEL_ID));
                                        this.isFetchingTopLevels = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                        }
                    } else {
                        switch (data_level_setup_id) {
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID:
                                if (!this.oList_Entity && !this.isFetchingEntities) {
                                    this.isFetchingEntities = true;
                                    this.OrganizationManagementService.Get_Entity_By_ENTITY_ID_List(this.oOrganization).then(result => {
                                        this.oList_Entity = result.filter(entity => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID && user_access.LEVEL_ID == entity.ENTITY_ID));
                                        this.isFetchingEntities = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID:
                                if (!this.oList_Site && !this.isFetchingSites) {
                                    this.isFetchingSites = true;
                                    this.OrganizationManagementService.Get_Site_By_SITE_ID_List(this.oOrganization).then(result => {
                                        this.oList_Site = result.filter(site => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID && user_access.LEVEL_ID == site.SITE_ID));
                                        this.isFetchingSites = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID:
                                if (!this.oList_Area && !this.isFetchingAreas) {
                                    this.isFetchingAreas = true;
                                    this.OrganizationManagementService.Get_Area_By_AREA_ID_List(this.oOrganization).then(result => {
                                        this.oList_Area = result.filter(area => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID && user_access.LEVEL_ID == area.AREA_ID));
                                        this.isFetchingAreas = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID:
                                if (!this.oList_District && !this.isFetchingDistricts) {
                                    this.isFetchingDistricts = true;
                                    this.OrganizationManagementService.Get_District_By_DISTRICT_ID_List(this.oOrganization).then(result => {
                                        this.oList_District = result.filter(district => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "District").SETUP_ID && user_access.LEVEL_ID == district.DISTRICT_ID));
                                        this.isFetchingDistricts = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                            case this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID:
                                if (!this.oList_Top_level && !this.isFetchingTopLevels) {
                                    this.isFetchingTopLevels = true;
                                    this.OrganizationManagementService.Get_Top_level_By_TOP_LEVEL_ID_List(this.oOrganization).then(result => {
                                        this.oList_Top_level = result.filter(top_level => this.oOrganization.List_Organization_level_access.some(user_access => user_access.DATA_LEVEL_SETUP_ID == this.oList_Data_access_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID && user_access.LEVEL_ID == top_level.TOP_LEVEL_ID));
                                        this.isFetchingTopLevels = false;
                                        resolve();
                                    });
                                } else {
                                    resolve();
                                }
                                break;
                        }
                    }
                }
            }));
        });
        Promise.all(promises).then(() => {
            this.oList_Access_Control_Object = [];
            const map = new Map();
            for (const user_access of this.oList_User_level_access) {
                if (!map.has(user_access.LEVEL_ID + "," + user_access.DATA_LEVEL_SETUP_ID)) {
                    map.set(user_access.LEVEL_ID + "," + user_access.DATA_LEVEL_SETUP_ID, true);    // set any value to Map
                    this.oList_Access_Control_Object.unshift({
                        DATA_LEVEL_SETUP_ID: user_access.DATA_LEVEL_SETUP_ID,
                        Object: this.getObject(user_access),
                        LEVEL_ID: user_access.LEVEL_ID,
                    });
                }
            }
            this._changeDetectorRef.detectChanges();
        });
    }

    saveUserAccess() {
        this.oList_User_level_access = this.oList_Access_Control_Object.map(access_control_object => {
            const oUser_level_access = new User_level_access();
            oUser_level_access.USER_LEVEL_ACCESS_ID = -1;
            oUser_level_access.ORGANIZATION_LEVEL_ACCESS_ID = null;
            oUser_level_access.DATA_LEVEL_SETUP_ID = access_control_object.DATA_LEVEL_SETUP_ID;
            oUser_level_access.USER_ID = this.oUser.USER_ID;
            oUser_level_access.LEVEL_ID = access_control_object.LEVEL_ID;
            return oUser_level_access;
        });
        const oParams_Edit_User_level_access_List = new Params_Edit_User_level_access_List();
        oParams_Edit_User_level_access_List.List_To_Delete = this.oUser.List_User_level_access.filter(user_level_access => !this.oList_User_level_access.some(oUser_level_access => oUser_level_access.DATA_LEVEL_SETUP_ID == user_level_access.DATA_LEVEL_SETUP_ID && oUser_level_access.LEVEL_ID == user_level_access.LEVEL_ID)).map(user_level_access => user_level_access.USER_LEVEL_ACCESS_ID);
        oParams_Edit_User_level_access_List.List_To_Edit = this.oList_User_level_access;



        if (oParams_Edit_User_level_access_List.List_To_Delete.length == 0 && oParams_Edit_User_level_access_List.List_To_Edit.length == 0) {
            this.CmSvc.ShowMessage("No changes were made");
            return;
        }
        this.OrganizationManagementService.Edit_User_level_access_List(this.oOrganization, this.oUser, oParams_Edit_User_level_access_List).then(result => {
            if (result) {
                this.OrganizationManagementService.oList_User_District = null;
                this.OrganizationManagementService.oList_User_Area = null;
                this.OrganizationManagementService.oList_User_Site = null;
                this.OrganizationManagementService.oList_User_Entity = null;
                this.CmSvc.Handle_Success();
                this.resetUserAccess();
            }
        })
    }
}
