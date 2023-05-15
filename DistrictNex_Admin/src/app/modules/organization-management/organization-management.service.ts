import { Injectable, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'app/core/Services/common.service';
import { Area, Area_kpi, District, District_kpi, Entity, Entity_kpi, Log_With_Count, Organization, Organization_Data_Access, Organization_color_scheme, Organization_data_source_kpi, Params_Change_User_Password, Params_Delete_Area_kpi, Params_Delete_District_kpi, Params_Delete_Entity_kpi, Params_Delete_Organization_Picture, Params_Delete_Site_kpi, Params_Edit_Organization_districtnex_module_List, Params_Edit_Organization_level_access_List, Params_Edit_User_districtnex_module_List, Params_Edit_User_level_access_List, Params_Get_Logs_With_Filters, Params_Get_Organization_Data_Access, Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID, Params_Modify_Organization_Details, Params_Restore_Organization, Params_Restore_User, Params_Schedule_Organization_for_Delete, Params_Schedule_User_for_Delete, Proxy, Setup, Site, Site_kpi, Top_level, User } from 'app/core/Services/proxy.service';
import { Params_Upload_Organization_Picture, ProxyExt } from 'app/core/Services/proxyExt.service';
import { AuthService } from 'app/core/auth/auth.service';
import { cloneDeep } from 'lodash';
import { Subject } from 'rxjs';
import { Data_Settings, Organization_chart_color, Params_Edit_Area_kpi_List, Params_Edit_Area_kpi_user_access_List, Params_Edit_District_kpi_List, Params_Edit_District_kpi_user_access_List, Params_Edit_Entity_kpi_List, Params_Edit_Entity_kpi_user_access_List, Params_Edit_Organization_Data_Access, Params_Edit_Organization_chart_color_List, Params_Edit_Organization_color_scheme_List, Params_Edit_Site_kpi_List, Params_Edit_Site_kpi_user_access_List, Params_Edit_User_Data_Access, Params_Get_User_Data_Access, Params_Modify_Data_Settings, User_Data_Access } from './../../core/Services/proxy.service';

@Injectable({
    providedIn: 'root'
})
export class OrganizationManagementService implements OnDestroy {

    oList_Area: Area[];
    oList_Site: Site[];
    oList_Entity: Entity[];
    oList_User_Area: Area[];
    oList_User_Site: Site[];
    oList_District: District[];
    oList_User_Entity: Entity[];
    oList_Top_level: Top_level[];
    oList_Available_Area: Area[];
    oList_Available_Site: Site[];
    oList_User_type_setup: Setup[];
    oList_Data_level_setup: Setup[];
    oList_User_District: District[];
    oList_Available_Entity: Entity[];
    oList_Organization: Organization[];
    oList_Available_District: District[];
    oList_Available_Top_level: Top_level[];
    oList_Organization_data_source_kpi: Organization_data_source_kpi[];

    refetchRouteSubject = new Subject<void>();

    constructor(
        private proxy: Proxy,
        private router: Router,
        private proxyExt: ProxyExt,
        private CmSvc: CommonService,
        private route: ActivatedRoute,
        private AuthService: AuthService,
    ) {
        this.oList_User_type_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "User Type").List_Setup;
        this.oList_Data_level_setup = this.CmSvc.oList_Setup_category.find(setup_category => setup_category.SETUP_CATEGORY_NAME == "Data Level").List_Setup;
        this.CmSvc.clearDataSubject.subscribe(() => {
            this.oList_Organization = null;
        });
    }

    //#region Organization
    get_Organizations(): Promise<Organization[]> {
        return new Promise((resolve, reject) => {
            if (this.CmSvc.oList_Organization) {
                resolve(this.CmSvc.oList_Organization)
            } else {
                this.proxy.Get_Organization_By_PARENT_ORGANIZATION_ID({
                    PARENT_ORGANIZATION_ID: this.CmSvc.oUser_Details.ORGANIZATION_ID
                }).subscribe(result => {
                    this.oList_Organization = result.sort((a, b) => a.ORGANIZATION_NAME.localeCompare(b.ORGANIZATION_NAME));
                    this.CmSvc.oList_Organization = this.oList_Organization;
                    resolve(result);
                });
            }
        });
    }

    Edit_Organization_Color_Scheme_List(i_List_Organization_color_scheme: Organization_color_scheme[]): Promise<Params_Edit_Organization_color_scheme_List> {
        return new Promise((resolve, reject) => {
            this.proxy.Edit_Organization_color_scheme_List({ List_To_Edit: i_List_Organization_color_scheme, List_Failed_Delete: [], List_Failed_Edit: [], List_To_Delete: [] }).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    Edit_Organization_Chart_Color_List(i_List_Organization_chart_color: Organization_chart_color[]) {
        let oParams_Edit_Organization_chart_color_List = new Params_Edit_Organization_chart_color_List();
        oParams_Edit_Organization_chart_color_List.List_To_Edit = i_List_Organization_chart_color;
        return new Promise((resolve, reject) => {
            this.proxy.Edit_Organization_chart_color_List(oParams_Edit_Organization_chart_color_List).subscribe(result => {
                if (result) {
                    resolve(result);
                }
                else {
                    reject();
                }
            })
        })
    }

    get_Organization_Details(ORGANIZATION_ID: number): Promise<Organization> {
        return new Promise(resolve => {
            const oOrganizations_Promise = new Promise<void>(resolve => {
                if (!this.oList_Organization) {
                    this.get_Organizations().then(() => { resolve() });
                } else {
                    resolve();
                }
            });
            oOrganizations_Promise.then(() => {
                if (this.oList_Organization.find(organization => organization.ORGANIZATION_ID == ORGANIZATION_ID)?.List_Organization_color_scheme) {
                    resolve(this.oList_Organization.find(organization => organization.ORGANIZATION_ID == ORGANIZATION_ID));
                } else {
                    this.proxy.Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading({
                        ORGANIZATION_ID: ORGANIZATION_ID,
                        LIST_EAGER_LOADED_DATA: ["User", "Organization_log_config", "Organization_image", "Organization_districtnex_module", "Organization_color_scheme", "Organization_level_access"]
                    }).subscribe(result => {
                        if (this.CmSvc.oUser_Details.User_type_setup.VALUE != "Super Admin" && this.CmSvc.oOrganization.ORGANIZATION_ID != result.ORGANIZATION_ID) {
                            this.router.navigateByUrl("/organization-management");
                        } else {
                            this.oList_Organization[this.oList_Organization.findIndex(organization => organization.ORGANIZATION_ID == result.ORGANIZATION_ID)] = result;
                            resolve(result);
                        }
                    });
                }
            })
        });
    }

    createOrganization(i_Organization: Organization): Promise<Organization> {
        return new Promise((resolve, reject) => {
            this.proxy.Edit_Organization_Custom({ ORGANIZATION: i_Organization })
                .subscribe(result => {
                    if (result != null) {
                        this.CmSvc.ShowMessage('Organization Created Successfully');
                        result.List_Organization_log_config = [];
                        result.List_User = [];
                        result.List_Organization_districtnex_module = [];
                        result.List_Organization_level_access = [];
                        this.oList_Organization.unshift(result);
                        this.oList_Organization = this.oList_Organization.sort((a, b) => a.ORGANIZATION_NAME.localeCompare(b.ORGANIZATION_NAME));
                        resolve(i_Organization);
                    } else {
                        resolve(null);
                    }
                });
        });
    }

    uploadFile(file: File, i_Params_Upload_Picture: Params_Upload_Organization_Picture): Promise<string> {
        return new Promise((resolve, reject) => {
            i_Params_Upload_Picture.FormData = new FormData();
            i_Params_Upload_Picture.FormData.append('file', file);
            this.proxyExt.Upload_Organization_Picture(i_Params_Upload_Picture).subscribe(response => {
                if (response.body.i_Result != null) {
                    resolve(response.body.i_Result);
                } else {
                    resolve(null);
                }
            });
        });
    }

    deleteFile(i_Organization: Organization, i_Params_Delete_Organization_Picture: Params_Delete_Organization_Picture, imageTypeSetupValue): Promise<boolean> {
        return new Promise((resolve, reject) => {
            this.proxy.Delete_Organization_Picture(i_Params_Delete_Organization_Picture).subscribe(response => {
                if (response) {
                    switch (imageTypeSetupValue) {
                        case 'Dark_Square_Logo':
                            i_Organization.DARK_SQUARE_LOGO_URL = '';
                            break;
                        case 'Dark_Rect_Logo':
                            i_Organization.DARK_RECTANGLE_LOGO_URL = '';
                            break;
                        case 'Light_Square_Logo':
                            i_Organization.LIGHT_SQUARE_LOGO_URL = '';
                            break;
                        case 'Light_Rect_Logo':
                            i_Organization.LIGHT_RECTANGLE_LOGO_URL = '';
                            break;
                        case 'Favicon':
                            i_Organization.ORGANIZATION_FAVICON_URL = '';
                            break;
                    }
                }
                resolve(response);
            });
        });
    }

    Modify_Organization_Details(i_Organization: Organization): Promise<Organization> {
        return new Promise((resolve, reject) => {
            let oParams_Modify_Organization_Details: Params_Modify_Organization_Details = new Params_Modify_Organization_Details();
            oParams_Modify_Organization_Details.ORGANZATION_ID = i_Organization.ORGANIZATION_ID;
            oParams_Modify_Organization_Details.ORGANIZATION_NAME = i_Organization.ORGANIZATION_NAME?.trim();
            oParams_Modify_Organization_Details.ORGANIZATION_EMAIL = i_Organization.ORGANIZATION_EMAIL?.trim();
            oParams_Modify_Organization_Details.ORGANIZATION_ADDRESS = i_Organization.ORGANIZATION_ADDRESS?.trim();
            oParams_Modify_Organization_Details.ORGANIZATION_PHONE_NUMBER = i_Organization.ORGANIZATION_PHONE_NUMBER?.trim();
            oParams_Modify_Organization_Details.MAX_NUMBER_OF_ADMINS = i_Organization.MAX_NUMBER_OF_ADMINS;
            oParams_Modify_Organization_Details.MAX_NUMBER_OF_USERS = i_Organization.MAX_NUMBER_OF_USERS;
            this.proxy.Modify_Organization_Details(oParams_Modify_Organization_Details).subscribe(result => {
                if (result) {
                    const oOrganization = this.oList_Organization.find(organization => organization.ORGANIZATION_ID == result.ORGANIZATION_ID) ?? this.CmSvc.oOrganization;
                    oOrganization.ORGANIZATION_NAME = result.ORGANIZATION_NAME;
                    oOrganization.ORGANIZATION_EMAIL = result.ORGANIZATION_EMAIL;
                    oOrganization.ORGANIZATION_ADDRESS = result.ORGANIZATION_ADDRESS;
                    oOrganization.ORGANIZATION_PHONE_NUMBER = result.ORGANIZATION_PHONE_NUMBER;
                    oOrganization.MAX_NUMBER_OF_ADMINS = result.MAX_NUMBER_OF_ADMINS;
                    oOrganization.MAX_NUMBER_OF_USERS = result.MAX_NUMBER_OF_USERS;
                    resolve(oOrganization);
                    this.refetchRouteSubject.next();
                }
                resolve(result);
            });
        })
    }

    Edit_Organization_color_scheme(i_Organization_color_scheme: Organization_color_scheme): Promise<Organization_color_scheme> {
        return new Promise(resolve => {
            this.proxy.Edit_Organization_color_scheme(i_Organization_color_scheme).subscribe(result => {
                if (result) {
                    this.CmSvc.Handle_Success();
                    const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Organization_color_scheme.ORGANIZATION_ID) ?? this.CmSvc.oOrganization;
                    oOrganization.List_Organization_color_scheme[0] = result;
                }
                resolve(result);
            })
        })
    }

    Create_User(i_Organization: Organization, i_User: User): Promise<User> {
        return new Promise(resolve => {
            this.proxy.Create_User({
                USER: i_User,
                ORGANIZATION_ID: i_Organization.ORGANIZATION_ID,
            }).subscribe(result => {
                if (result) {
                    this.CmSvc.ShowMessage("User Created Successfully");
                    result.User_type_setup = this.CmSvc.oList_Setup.find(setup => setup.SETUP_ID == result.USER_TYPE_SETUP_ID);
                    result.List_User_districtnex_module = [];
                    result.List_User_level_access = [];
                    const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Organization.ORGANIZATION_ID) ?? this.CmSvc.oOrganization;
                    oOrganization.List_User.push(result);
                }
                resolve(result);
            })
        })
    }

    //#region Getting data for organization access
    Get_Top_level_By_OWNER_ID(): Promise<Top_level[]> {
        return new Promise(resolve => {
            if (this.CmSvc.oList_Top_level) {
                resolve(this.CmSvc.oList_Top_level);
            } else {
                this.proxy.Get_Top_level_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.CmSvc.oList_Top_level = result.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    resolve(result);
                });
            }
        });
    }

    Get_District_By_OWNER_ID(): Promise<District[]> {
        return new Promise(resolve => {
            if (this.CmSvc.oList_District) {
                resolve(this.CmSvc.oList_District);
            } else {
                this.proxy.Get_District_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.CmSvc.oList_District = result.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    resolve(result);
                });
            }
        });
    }

    Get_Area_By_OWNER_ID(): Promise<Area[]> {
        return new Promise(resolve => {
            if (this.CmSvc.oList_Area) {
                resolve(this.CmSvc.oList_Area);
            } else {
                this.proxy.Get_Area_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.CmSvc.oList_Area = result.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    resolve(result);
                });
            }
        });
    }

    Get_Site_By_OWNER_ID(): Promise<Site[]> {
        return new Promise(resolve => {
            if (this.CmSvc.oList_Site) {
                resolve(this.CmSvc.oList_Site);
            } else {
                this.proxy.Get_Site_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.CmSvc.oList_Site = result.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    resolve(result);
                });
            }
        });
    }

    Get_Entity_By_OWNER_ID(): Promise<Entity[]> {
        return new Promise(resolve => {
            if (this.CmSvc.oList_Entity) {
                resolve(this.CmSvc.oList_Entity);
            } else {
                this.proxy.Get_Entity_By_OWNER_ID({ OWNER_ID: this.CmSvc.oUser_Details.OWNER_ID }).subscribe(result => {
                    this.CmSvc.oList_Entity = result.sort((a, b) => a.NAME.localeCompare(b.NAME));
                    resolve(result);
                });
            }
        });
    }
    //#endregion

    Edit_Organization_level_access_List(i_Organization: Organization, i_Params_Edit_Organization_level_access_List: Params_Edit_Organization_level_access_List): Promise<Params_Edit_Organization_level_access_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Organization_level_access_List(i_Params_Edit_Organization_level_access_List).subscribe(result => {
                if (result) {
                    const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Organization.ORGANIZATION_ID) ?? this.CmSvc.oOrganization;
                    oOrganization.List_Organization_level_access = oOrganization.List_Organization_level_access.filter(organization_access => !result.List_To_Delete.some(organization_access_id => organization_access.ORGANIZATION_LEVEL_ACCESS_ID == organization_access_id));
                    result.List_To_Edit.forEach(organization_access => {
                        const index = oOrganization.List_Organization_level_access.findIndex(oOrganization_level_access => oOrganization_level_access.ORGANIZATION_LEVEL_ACCESS_ID == organization_access.ORGANIZATION_LEVEL_ACCESS_ID);
                        if (index == -1) {
                            oOrganization.List_Organization_level_access.push(organization_access);
                        } else {
                            oOrganization.List_Organization_level_access[index] = organization_access;
                        }
                    });
                    oOrganization.List_User.forEach(user => {
                        user.List_User_level_access = null;
                    });
                }
                resolve(result);
            })
        })
    }

    Edit_District_kpi_user_access_List(i_Params_Edit_District_kpi_user_access_List: Params_Edit_District_kpi_user_access_List): Promise<Params_Edit_District_kpi_user_access_List> {
        return new Promise(resolve => {
            this.proxy.Edit_District_kpi_user_access_List(i_Params_Edit_District_kpi_user_access_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Area_kpi_user_access_List(i_Params_Edit_Area_kpi_user_access_List: Params_Edit_Area_kpi_user_access_List): Promise<Params_Edit_Area_kpi_user_access_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Area_kpi_user_access_List(i_Params_Edit_Area_kpi_user_access_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Site_kpi_user_access_List(i_Params_Edit_Site_kpi_user_access_List: Params_Edit_Site_kpi_user_access_List): Promise<Params_Edit_Site_kpi_user_access_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Site_kpi_user_access_List(i_Params_Edit_Site_kpi_user_access_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Entity_kpi_user_access_List(i_Params_Edit_Entity_kpi_user_access_List: Params_Edit_Entity_kpi_user_access_List): Promise<Params_Edit_Entity_kpi_user_access_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Entity_kpi_user_access_List(i_Params_Edit_Entity_kpi_user_access_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_District_kpi_List(i_Params_Edit_District_kpi_List: Params_Edit_District_kpi_List): Promise<Params_Edit_District_kpi_List> {
        return new Promise(resolve => {
            this.proxy.Edit_District_kpi_List(i_Params_Edit_District_kpi_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Area_kpi_List(i_Params_Edit_Area_kpi_List: Params_Edit_Area_kpi_List): Promise<Params_Edit_Area_kpi_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Area_kpi_List(i_Params_Edit_Area_kpi_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Site_kpi_List(i_Params_Edit_Site_kpi_List: Params_Edit_Site_kpi_List): Promise<Params_Edit_Site_kpi_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Site_kpi_List(i_Params_Edit_Site_kpi_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Entity_kpi_List(i_Params_Edit_Entity_kpi_List: Params_Edit_Entity_kpi_List): Promise<Params_Edit_Entity_kpi_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Entity_kpi_List(i_Params_Edit_Entity_kpi_List).subscribe(result => {
                resolve(result);
            })
        })
    }

    Delete_District_kpi(i_District_kpi: District_kpi): Promise<string> {
        const oParams_Delete_District_kpi = new Params_Delete_District_kpi();
        oParams_Delete_District_kpi.DISTRICT_KPI_ID = i_District_kpi.DISTRICT_KPI_ID;
        return new Promise(resolve => {
            this.proxy.Delete_District_kpi(oParams_Delete_District_kpi).subscribe(result => {
                resolve(result);
            })
        })
    }

    Delete_Area_kpi(i_Area_kpi: Area_kpi): Promise<string> {
        const oParams_Delete_Area_kpi = new Params_Delete_Area_kpi();
        oParams_Delete_Area_kpi.AREA_KPI_ID = i_Area_kpi.AREA_KPI_ID;
        return new Promise(resolve => {
            this.proxy.Delete_Area_kpi(oParams_Delete_Area_kpi).subscribe(result => {
                resolve(result);
            })
        })
    }

    Delete_Site_kpi(i_Site_kpi: Site_kpi): Promise<string> {
        const oParams_Delete_Site_kpi = new Params_Delete_Site_kpi();
        oParams_Delete_Site_kpi.SITE_KPI_ID = i_Site_kpi.SITE_KPI_ID;
        return new Promise(resolve => {
            this.proxy.Delete_Site_kpi(oParams_Delete_Site_kpi).subscribe(result => {
                resolve(result);
            })
        })
    }

    Delete_Entity_kpi(i_Entity_kpi: Entity_kpi): Promise<string> {
        const oParams_Delete_Entity_kpi = new Params_Delete_Entity_kpi();
        oParams_Delete_Entity_kpi.ENTITY_KPI_ID = i_Entity_kpi.ENTITY_KPI_ID;
        return new Promise(resolve => {
            this.proxy.Delete_Entity_kpi(oParams_Delete_Entity_kpi).subscribe(result => {
                resolve(result);
            })
        })
    }

    Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(i_Organization: Organization): Promise<Organization_data_source_kpi[]> {
        const oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID();
        oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID = i_Organization.ORGANIZATION_ID;
        return new Promise(resolve => {
            this.proxy.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID).subscribe(result => {
                this.oList_Organization_data_source_kpi = result;
                resolve(result);
            })
        })
    }

    Get_Organization_Data_Access(i_Organization: Organization): Promise<Organization_Data_Access> {
        const oParams_Get_Organization_Data_Access = new Params_Get_Organization_Data_Access();
        oParams_Get_Organization_Data_Access.ORGANIZATION_ID = i_Organization.ORGANIZATION_ID;
        return new Promise(resolve => {
            this.proxy.Get_Organization_Data_Access(oParams_Get_Organization_Data_Access).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_Organization_Data_Access(i_Params_Edit_Organization_Data_Access: Params_Edit_Organization_Data_Access): Promise<Params_Edit_Organization_Data_Access> {
        return new Promise(resolve => {
            this.proxy.Edit_Organization_Data_Access(i_Params_Edit_Organization_Data_Access).subscribe(result => {
                resolve(result);
            })
        })
    }

    Get_User_Data_Access(i_Organization: Organization, i_User: User): Promise<User_Data_Access> {
        const oParams_Get_User_Data_Access = new Params_Get_User_Data_Access();
        oParams_Get_User_Data_Access.ORGANIZATION_ID = i_Organization.ORGANIZATION_ID;
        oParams_Get_User_Data_Access.USER_ID = i_User.USER_ID;
        return new Promise(resolve => {
            this.proxy.Get_User_Data_Access(oParams_Get_User_Data_Access).subscribe(result => {
                resolve(result);
            })
        })
    }

    Edit_User_Data_Access(i_Params_Edit_User_Data_Access: Params_Edit_User_Data_Access): Promise<Params_Edit_User_Data_Access> {
        return new Promise(resolve => {
            this.proxy.Edit_User_Data_Access(i_Params_Edit_User_Data_Access).subscribe(result => {
                resolve(result);
            })
        })
    }

    modifyDataSettings(i_Params_Modify_Data_Settings: Params_Modify_Data_Settings): Promise<Data_Settings> {
        return new Promise(resolve => {
            this.proxy.Modify_Data_Settings(i_Params_Modify_Data_Settings).subscribe(result => {
                if (result) {
                    const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Params_Modify_Data_Settings.ORGANIZATION_ID) ?? this.CmSvc.oOrganization;
                    oOrganization.DATA_RETENTION_PERIOD = result.DATA_RETENTION_PERIOD;
                    oOrganization.TICKET_DURATION_IN_MINUTES = result.TICKET_DURATION_IN_MINUTES;
                    result.Params_Edit_Organization_log_config_List.List_To_Delete.forEach(organization_log_config_id => {
                        oOrganization.List_Organization_log_config.splice(oOrganization.List_Organization_log_config.findIndex(organization_log_config => organization_log_config.ORGANIZATION_LOG_CONFIG_ID == organization_log_config_id), 1);
                    });
                    result.Params_Edit_Organization_log_config_List.List_To_Edit.forEach(organization_log_config => {
                        const index = oOrganization.List_Organization_log_config.findIndex(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_LOG_CONFIG_ID == organization_log_config.ORGANIZATION_LOG_CONFIG_ID);
                        if (index == -1) {
                            oOrganization.List_Organization_log_config.push(organization_log_config);
                        } else {
                            oOrganization.List_Organization_log_config[index] = organization_log_config;
                        }
                    });

                    this.CmSvc.Handle_Success();
                }
                resolve(result);
            })
        })
    }

    Edit_Organization_districtnex_module_List(i_Organization: Organization, i_Params_Edit_Organization_districtnex_module_List: Params_Edit_Organization_districtnex_module_List): Promise<Params_Edit_Organization_districtnex_module_List> {
        return new Promise(resolve => {
            this.proxy.Edit_Organization_districtnex_module_List(i_Params_Edit_Organization_districtnex_module_List).subscribe(result => {
                const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Organization.ORGANIZATION_ID) ?? this.CmSvc.oOrganization;
                if (result) {
                    result.List_To_Delete.forEach(organization_districtnex_module_id => {
                        oOrganization.List_Organization_districtnex_module.splice(oOrganization.List_Organization_districtnex_module.findIndex(organization_districtnex_module => organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == organization_districtnex_module_id), 1);
                    });
                    result.List_To_Edit.forEach(organization_districtnex_module => {
                        const index = oOrganization.List_Organization_districtnex_module.findIndex(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID);
                        if (index == -1) {
                            oOrganization.List_Organization_districtnex_module.push(organization_districtnex_module);
                        } else {
                            oOrganization.List_Organization_districtnex_module[index] = organization_districtnex_module;
                        }
                    });
                }
                resolve(result);
            });
        });
    }

    calculateNumberAdmins(i_Organization: Organization): number {
        let totalNumber = 0;
        if (i_Organization) {
            totalNumber = i_Organization.List_User.filter(user =>
                user.IS_ACTIVE && user.USER_TYPE_SETUP_ID == this.oList_User_type_setup.filter(x => x.VALUE == 'Organization Admin')[0].SETUP_ID
            ).length;
            if (this.CmSvc.oUser_Details.User_type_setup.VALUE != "Super Admin" && this.CmSvc.oOrganization.ORGANIZATION_ID == i_Organization.ORGANIZATION_ID) {
                totalNumber++;
            }
            return totalNumber;
        }
        else {
            return totalNumber;
        }
    }

    calculateNumberSuperAdmins(i_Organization: Organization): number {
        let totalNumber = 0;
        if (i_Organization) {
            totalNumber = i_Organization.List_User.filter(user =>
                user.IS_ACTIVE && user.USER_TYPE_SETUP_ID == this.oList_User_type_setup.filter(x => x.VALUE == 'Super Admin')[0].SETUP_ID
            ).length;
            if (this.CmSvc.oUser_Details.User_type_setup.VALUE == "Super Admin" && this.CmSvc.oOrganization.ORGANIZATION_ID == i_Organization.ORGANIZATION_ID) {
                totalNumber++;
            }
            return totalNumber;
        }
        else {
            return totalNumber;
        }
    }

    calculateNumberUsers(organizationDetails: Organization): number {
        if (organizationDetails) {
            return organizationDetails.List_User.filter(user =>
                user.IS_ACTIVE && user.USER_TYPE_SETUP_ID == this.oList_User_type_setup.filter(x => x.VALUE == 'Organization User')[0].SETUP_ID
            ).length;
        }
        else {
            return 0;
        }
    }

    deactivateOrganization(i_Params_Schedule_Organization_for_Delete: Params_Schedule_Organization_for_Delete): Promise<Organization> {
        return new Promise(resolve => {
            this.proxy.Schedule_Organization_for_Delete(i_Params_Schedule_Organization_for_Delete).subscribe(result => {
                if (result) {
                    const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID);
                    if (oOrganization) {
                        oOrganization.IS_ACTIVE = result.IS_ACTIVE;
                        oOrganization.IS_DELETED = result.IS_DELETED;
                        oOrganization.DATE_DELETED = result.DATE_DELETED;
                    } else {
                        this.CmSvc.oOrganization.IS_ACTIVE = result.IS_ACTIVE;
                        this.CmSvc.oOrganization.IS_DELETED = result.IS_DELETED;
                        this.CmSvc.oOrganization.DATE_DELETED = result.DATE_DELETED;
                    }
                    if (this.route.snapshot.data['isMyOrganization'] == true) {
                        this.AuthService.signOut();
                        this.CmSvc.ShowMessage('Organization deactivated, you have been signed out');
                    } else {
                        if (result.IS_DELETED == true) {
                            this.router.navigateByUrl("/organization-management");
                            this.oList_Organization.splice(this.oList_Organization.findIndex(organization => organization.ORGANIZATION_ID == i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID), 1);
                            this.CmSvc.ShowMessage("Organization Deactivated. Data has been wiped.", 3000);
                        }
                        else {
                            this.oList_Organization.find(organization => organization.ORGANIZATION_ID == i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID).DATE_DELETED = result.DATE_DELETED;
                            this.oList_Organization.find(organization => organization.ORGANIZATION_ID == i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID).IS_ACTIVE = result.IS_ACTIVE;
                            this.CmSvc.ShowMessage("Organization Deactivated. Data will be wiped in " + this.oList_Organization.find(organization => organization.ORGANIZATION_ID == i_Params_Schedule_Organization_for_Delete.ORGANIZATION_ID).DATA_RETENTION_PERIOD + " days.", 3000);
                        }
                    }

                    resolve(result);
                }
                else {
                    resolve(null);
                }
            })
        })
    }

    restoreOrganization(i_Params_Restore_Organization: Params_Restore_Organization): Promise<Organization> {
        return new Promise(resolve => {
            this.proxy.Restore_Organization(i_Params_Restore_Organization).subscribe(result => {
                if (result) {
                    const oOrganization = this.oList_Organization?.find(organization => organization.ORGANIZATION_ID == i_Params_Restore_Organization.ORGANIZATION_ID);
                    if (oOrganization) {
                        oOrganization.DATE_DELETED = result.DATE_DELETED;
                        oOrganization.IS_ACTIVE = result.IS_ACTIVE;
                    } else {
                        this.CmSvc.oOrganization.DATE_DELETED = result.DATE_DELETED;
                        this.CmSvc.oOrganization.IS_ACTIVE = result.IS_ACTIVE;
                    }
                    this.CmSvc.ShowMessage("Organization Restored Successfully.", 3000);
                    resolve(result);
                }
                else {
                    resolve(null);
                }
            })
        })
    }
    //#endregion

    //#region User
    get_User_Details(i_Organization: Organization, USER_ID: number): Promise<User> {
        return new Promise(resolve => {

            if (i_Organization.List_User.find(user => user.USER_ID == USER_ID)?.List_User_level_access) {
                this.refetchRouteSubject.next();
                resolve(i_Organization.List_User.find(user => user.USER_ID == USER_ID));
            } else {
                this.proxy.Get_User_By_USER_ID_Adv({ USER_ID: USER_ID }).subscribe(result => {
                    i_Organization.List_User[i_Organization.List_User.findIndex(user => user.USER_ID == USER_ID)] = result;
                    this.refetchRouteSubject.next();
                    resolve(result);
                });
            }
        })
    }

    Modify_User_Details(i_User: User): Promise<User> {
        return new Promise(resolve => {
            this.proxy.Modify_User_Details({ User: i_User }).subscribe(result => {
                if (result) {
                    result.User_type_setup = this.CmSvc.oList_Setup.find(setup => setup.SETUP_ID == result.USER_TYPE_SETUP_ID);
                    this.CmSvc.ShowMessage("User Modified Successfully");
                }
                resolve(result);
            })
        })
    }

    getLogsWithFilters(userId: number, iListLogType: Setup[] = null, iListAccessType: Setup[] = null, startDate: Date = null, endDate: Date = null, startRow = 0, endRow = 20): Promise<Log_With_Count> {
        return new Promise((resolve, reject) => {
            const oParams_Get_Logs_With_Filters = new Params_Get_Logs_With_Filters();
            oParams_Get_Logs_With_Filters.USER_ID_LIST = [userId];
            if (iListAccessType) {
                oParams_Get_Logs_With_Filters.ACCESS_TYPE_SETUP_ID_LIST = iListAccessType.map(setup => setup.SETUP_ID);
            }
            if (iListLogType) {
                oParams_Get_Logs_With_Filters.LOG_TYPE_SETUP_ID_LIST = iListLogType.map(setup => setup.SETUP_ID);
            }
            if (startDate) {
                oParams_Get_Logs_With_Filters.START_DATE = startDate.toUTCString();
            }
            if (endDate) {
                const oEndDate = new Date(endDate);
                oEndDate.setDate(oEndDate.getDate() + 1);
                oParams_Get_Logs_With_Filters.END_DATE = oEndDate.toUTCString();
            }
            if (startRow) {
                oParams_Get_Logs_With_Filters.START_ROW = startRow;
            }
            if (endRow) {
                oParams_Get_Logs_With_Filters.END_ROW = endRow;
            }
            this.proxy.Get_Logs_With_Filters(oParams_Get_Logs_With_Filters).subscribe(result => {
                resolve(result);
            })
        })
    }

    //#region Getting data for organization access
    Get_Top_level_By_TOP_LEVEL_ID_List(i_Organization: Organization): Promise<Top_level[]> {
        return new Promise(resolve => {
            if (i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID).length > 0) {
                this.proxy.Get_Top_level_By_TOP_LEVEL_ID_List({ TOP_LEVEL_ID_LIST: i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Top-Level").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                    resolve(result);
                });
            } else {
                resolve([]);
            }
        });
    }

    Get_District_By_DISTRICT_ID_List(i_Organization: Organization): Promise<District[]> {
        return new Promise(resolve => {
            if (this.oList_Available_District) {
                resolve(this.oList_Available_District);
            }
            else {
                if (i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "District").SETUP_ID).length > 0) {
                    this.proxy.Get_District_By_DISTRICT_ID_List({ DISTRICT_ID_LIST: i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "District").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_Available_District = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }

    Get_Area_By_AREA_ID_List(i_Organization: Organization): Promise<Area[]> {
        return new Promise(resolve => {
            if (this.oList_Available_Area) {
                resolve(this.oList_Available_Area);
            }
            else {
                if (i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID).length > 0) {
                    this.proxy.Get_Area_By_AREA_ID_List({ AREA_ID_LIST: i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_Available_Area = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }

    Get_Site_By_SITE_ID_List(i_Organization: Organization): Promise<Site[]> {
        return new Promise(resolve => {
            if (this.oList_Available_Site) {
                resolve(this.oList_Available_Site);
            }
            else {
                if (i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID).length > 0) {
                    this.proxy.Get_Site_By_SITE_ID_List({ SITE_ID_LIST: i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_Available_Site = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }

    Get_Entity_By_ENTITY_ID_List(i_Organization: Organization): Promise<Entity[]> {
        return new Promise(resolve => {
            if (this.oList_Available_Entity) {
                resolve(this.oList_Available_Entity);
            }
            else {
                if (i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID).length > 0) {
                    this.proxy.Get_Entity_By_ENTITY_ID_List({ ENTITY_ID_LIST: i_Organization.List_Organization_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_Available_Entity = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }
    //#endregion

    //#region Getting data for user access

    Get_User_District_By_DISTRICT_ID_List(i_User: User): Promise<District[]> {
        return new Promise(resolve => {
            if (this.oList_User_District) {
                resolve(this.oList_User_District);
            }
            else {
                if (i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "District").SETUP_ID).length > 0) {
                    this.proxy.Get_District_By_DISTRICT_ID_List({ DISTRICT_ID_LIST: i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "District").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_User_District = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }

    Get_User_Area_By_AREA_ID_List(i_User: User): Promise<Area[]> {
        return new Promise(resolve => {
            if (this.oList_User_Area) {
                resolve(this.oList_User_Area);
            }
            else {
                if (i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID).length > 0) {
                    this.proxy.Get_Area_By_AREA_ID_List({ AREA_ID_LIST: i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Area").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_User_Area = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }

    Get_User_Site_By_SITE_ID_List(i_User: User): Promise<Site[]> {
        return new Promise(resolve => {
            if (this.oList_User_Site) {
                resolve(this.oList_User_Site);
            }
            else {
                if (i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID).length > 0) {
                    this.proxy.Get_Site_By_SITE_ID_List({ SITE_ID_LIST: i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Site").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_User_Site = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }

    Get_User_Entity_By_ENTITY_ID_List(i_User: User): Promise<Entity[]> {
        return new Promise(resolve => {
            if (this.oList_User_Entity) {
                resolve(this.oList_User_Entity);
            }
            else {
                if (i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID).length > 0) {
                    this.proxy.Get_Entity_By_ENTITY_ID_List({ ENTITY_ID_LIST: i_User.List_User_level_access.filter(organization_access => organization_access.DATA_LEVEL_SETUP_ID == this.oList_Data_level_setup.find(setup => setup.VALUE == "Entity").SETUP_ID).map(organization_access => organization_access.LEVEL_ID) }).subscribe(result => {
                        this.oList_User_Entity = cloneDeep(result);
                        resolve(result);
                    });
                } else {
                    resolve([]);
                }
            }
        });
    }
    //#endregion

    Edit_User_level_access_List(i_Organization: Organization, i_User: User, i_Params_Edit_User_level_access_List: Params_Edit_User_level_access_List): Promise<Params_Edit_User_level_access_List> {
        return new Promise(resolve => {
            this.proxy.Edit_User_level_access_List(i_Params_Edit_User_level_access_List).subscribe(result => {
                if (result) {
                    const oUser = i_Organization.List_User.find(user => user.USER_ID == i_User.USER_ID);
                    oUser.List_User_level_access = oUser.List_User_level_access.filter(user_access => !result.List_To_Delete.includes(user_access.USER_LEVEL_ACCESS_ID));
                    result.List_To_Edit.forEach(user_access => {
                        const index = oUser.List_User_level_access.findIndex(oUser_level_access => oUser_level_access.USER_LEVEL_ACCESS_ID == user_access.USER_LEVEL_ACCESS_ID);
                        if (index == -1) {
                            oUser.List_User_level_access.push(user_access);
                        } else {
                            oUser.List_User_level_access[index] = user_access;
                        }
                    });
                }
                resolve(result);
            })
        })
    }

    Edit_User_districtnex_module_List(i_Organization: Organization, i_User: User, i_Params_Edit_User_districtnex_module_List: Params_Edit_User_districtnex_module_List): Promise<Params_Edit_User_districtnex_module_List> {
        return new Promise(resolve => {
            this.proxy.Edit_User_districtnex_module_List(i_Params_Edit_User_districtnex_module_List).subscribe(result => {
                const oUser = i_Organization.List_User.find(user => user.USER_ID == i_User.USER_ID);
                if (result) {
                    result.List_To_Delete.forEach(user_districtnex_module_id => {
                        oUser.List_User_districtnex_module.splice(oUser.List_User_districtnex_module.findIndex(user_districtnex_module => user_districtnex_module.USER_DISTRICTNEX_MODULE_ID == user_districtnex_module_id), 1);
                    });
                    result.List_To_Edit.forEach(user_districtnex_module => {
                        const index = oUser.List_User_districtnex_module.findIndex(oUser_districtnex_module => oUser_districtnex_module.USER_DISTRICTNEX_MODULE_ID == user_districtnex_module.USER_DISTRICTNEX_MODULE_ID);
                        if (index == -1) {
                            oUser.List_User_districtnex_module.push(user_districtnex_module);
                        } else {
                            oUser.List_User_districtnex_module[index] = user_districtnex_module;
                        }
                    });
                }
                resolve(result);
            });
        });
    }

    deactivateUser(i_Organization: Organization, i_Params_Schedule_User_for_Delete: Params_Schedule_User_for_Delete): Promise<User> {
        return new Promise(resolve => {
            this.proxy.Schedule_User_for_Delete(i_Params_Schedule_User_for_Delete).subscribe(result_user => {
                if (result_user) {
                    if (result_user.IS_DELETED == true) {
                        const to_delete = i_Organization.List_User.filter(x => x.USER_ID == result_user.USER_ID)[0];
                        i_Organization.List_User.splice(i_Organization.List_User.indexOf(to_delete, 1), 1);
                        if (this.route.snapshot.data['isMyOrganization'] == true) {
                            this.router.navigateByUrl("/my-organization/user-management");
                        }
                        else {
                            this.router.navigateByUrl("/organization-management/" + i_Organization.ORGANIZATION_ID);
                        }
                        this.CmSvc.ShowMessage("User Deactivated. Data has been wiped.", 3000);
                    }
                    else {
                        i_Organization.List_User[i_Organization.List_User.findIndex(user => user.USER_ID == result_user.USER_ID)] = result_user;
                        this.CmSvc.ShowMessage("User Deactivated. Data will be wiped in " + result_user.DATA_RETENTION_PERIOD + " days.", 3000);
                    }

                    resolve(result_user);
                }
                else {
                    resolve(null);
                }
            })
        })
    }

    restoreUser(i_Organization: Organization, i_Params_Restore_User: Params_Restore_User): Promise<User> {
        return new Promise(resolve => {
            this.proxy.Restore_User(i_Params_Restore_User).subscribe(result_user => {
                if (result_user) {
                    i_Organization.List_User[i_Organization.List_User.findIndex(x => x.USER_ID == result_user.USER_ID)] = result_user;
                    this.CmSvc.ShowMessage("User Restored Successfully.", 3000);
                    resolve(result_user);
                }
                else {
                    resolve(null);
                }
            })
        })
    }

    changeUserPassword(UserID: number, NewPassword: string): Promise<boolean> {
        return new Promise((resolve, reject) => {
            let oParams_Change_User_Password: Params_Change_User_Password = new Params_Change_User_Password();
            oParams_Change_User_Password.NEW_PASSWORD = NewPassword;
            oParams_Change_User_Password.USER_ID = UserID;
            this.proxy.Change_User_Password(oParams_Change_User_Password)
                .subscribe(result => {
                    if (result == true) {
                        this.CmSvc.ShowMessage('User Password Changed Successfully');
                        resolve(result);
                    } else {
                        resolve(false);
                    }
                });
        });
    }
    //#endregion

    ngOnDestroy(): void {
        this.refetchRouteSubject.unsubscribe();
    }
}
