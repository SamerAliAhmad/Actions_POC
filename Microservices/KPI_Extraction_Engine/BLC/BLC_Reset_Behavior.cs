using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Space_Reset
        public void BLC_OnPostEvent_Edit_Space_Reset(Space i_Space, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Space != null)
            {
                if (i_Space.List_Space_asset != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Space.List_Space_asset.Count == 0)
                        {
                            this._service_mesh.Delete_Space_asset_By_SPACE_ID(new Service_Mesh.Params_Delete_Space_asset_By_SPACE_ID()
                            {
                                SPACE_ID = i_Space.SPACE_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Space_asset
                            // -----------------------------
                            List<Service_Mesh.Space_asset> oList_Space_asset = this._service_mesh.Get_Space_asset_By_SPACE_ID(new Service_Mesh.Params_Get_Space_asset_By_SPACE_ID()
                            {
                                SPACE_ID = i_Space.SPACE_ID
                            }).i_Result;
                            if (oList_Space_asset != null && oList_Space_asset.Count > 0)
                            {
                                oList_Space_asset = oList_Space_asset.Where(oSpace_asset => !i_Space.List_Space_asset.Any(oCurrent_Space_asset => oCurrent_Space_asset.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID)).ToList();
                                if (oList_Space_asset.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    this._service_mesh.Edit_Space_asset_List(new Service_Mesh.Params_Edit_Space_asset_List()
                                    {
                                        List_To_Delete = oList_Space_asset.Select(oSpace_asset => oSpace_asset.SPACE_ASSET_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Space_asset
                    // -----------------------------
                    if (i_Space.List_Space_asset != null && i_Space.List_Space_asset.Count > 0)
                    {
                        foreach (var oSpace_asset in i_Space.List_Space_asset)
                        {
                            oSpace_asset.SPACE_ID = i_Space.SPACE_ID;
                            Service_Mesh.Space_asset oSpace_asset_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Space_asset>(oSpace_asset);
                            this._service_mesh.Edit_Space_asset(oSpace_asset_mesh);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_District_Reset
        public void BLC_OnPostEvent_Edit_District_Reset(District i_District, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_District != null)
            {
                if (i_District.List_District_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_District.List_District_view.Count == 0)
                        {
                            this._service_mesh.Delete_District_view_By_DISTRICT_ID(new Service_Mesh.Params_Delete_District_view_By_DISTRICT_ID()
                            {
                                DISTRICT_ID = i_District.DISTRICT_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related District_view
                            // -----------------------------
                            List<Service_Mesh.District_view> oList_District_view = this._service_mesh.Get_District_view_By_DISTRICT_ID(new Service_Mesh.Params_Get_District_view_By_DISTRICT_ID()
                            {
                                DISTRICT_ID = i_District.DISTRICT_ID
                            }).i_Result;
                            if (oList_District_view != null && oList_District_view.Count > 0)
                            {
                                oList_District_view = oList_District_view.Where(oDistrict_view => !i_District.List_District_view.Any(oCurrent_District_view => oCurrent_District_view.DISTRICT_VIEW_ID == oDistrict_view.DISTRICT_VIEW_ID)).ToList();
                                if (oList_District_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    this._service_mesh.Edit_District_view_List(new Service_Mesh.Params_Edit_District_view_List()
                                    {
                                        List_To_Delete = oList_District_view.Select(oDistrict_view => oDistrict_view.DISTRICT_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // District_view
                    // -----------------------------
                    if (i_District.List_District_view != null && i_District.List_District_view.Count > 0)
                    {
                        foreach (var oDistrict_view in i_District.List_District_view)
                        {
                            oDistrict_view.DISTRICT_ID = i_District.DISTRICT_ID;
                            Service_Mesh.District_view oDistrict_view_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.District_view>(oDistrict_view);
                            this._service_mesh.Edit_District_view(oDistrict_view_mesh);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Site_Reset
        public void BLC_OnPostEvent_Edit_Site_Reset(Site i_Site, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Site != null)
            {
                if (i_Site.List_Site_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Site.List_Site_view.Count == 0)
                        {
                            this._service_mesh.Delete_Site_view_By_SITE_ID(new Service_Mesh.Params_Delete_Site_view_By_SITE_ID()
                            {
                                SITE_ID = i_Site.SITE_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Site_view
                            // -----------------------------
                            List<Service_Mesh.Site_view> oList_Site_view = this._service_mesh.Get_Site_view_By_SITE_ID(new Service_Mesh.Params_Get_Site_view_By_SITE_ID()
                            {
                                SITE_ID = i_Site.SITE_ID
                            }).i_Result;
                            if (oList_Site_view != null && oList_Site_view.Count > 0)
                            {
                                oList_Site_view = oList_Site_view.Where(oSite_view => !i_Site.List_Site_view.Any(oCurrent_Site_view => oCurrent_Site_view.SITE_VIEW_ID == oSite_view.SITE_VIEW_ID)).ToList();
                                if (oList_Site_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    this._service_mesh.Edit_Site_view_List(new Service_Mesh.Params_Edit_Site_view_List()
                                    {
                                        List_To_Delete = oList_Site_view.Select(oSite_view => oSite_view.SITE_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Site_view
                    // -----------------------------
                    if (i_Site.List_Site_view != null && i_Site.List_Site_view.Count > 0)
                    {
                        foreach (var oSite_view in i_Site.List_Site_view)
                        {
                            oSite_view.SITE_ID = i_Site.SITE_ID;
                            Service_Mesh.Site_view oSite_view_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Site_view>(oSite_view);
                            this._service_mesh.Edit_Site_view(oSite_view_mesh);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Entity_Reset
        public void BLC_OnPostEvent_Edit_Entity_Reset(Entity i_Entity, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Entity != null)
            {
                if (i_Entity.List_Entity_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Entity.List_Entity_view.Count == 0)
                        {
                            this._service_mesh.Delete_Entity_view_By_ENTITY_ID(new Service_Mesh.Params_Delete_Entity_view_By_ENTITY_ID()
                            {
                                ENTITY_ID = i_Entity.ENTITY_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Entity_view
                            // -----------------------------
                            List<Service_Mesh.Entity_view> oList_Entity_view = this._service_mesh.Get_Entity_view_By_ENTITY_ID(new Service_Mesh.Params_Get_Entity_view_By_ENTITY_ID()
                            {
                                ENTITY_ID = i_Entity.ENTITY_ID
                            }).i_Result;
                            if (oList_Entity_view != null && oList_Entity_view.Count > 0)
                            {
                                oList_Entity_view = oList_Entity_view.Where(oEntity_view => !i_Entity.List_Entity_view.Any(oCurrent_Entity_view => oCurrent_Entity_view.ENTITY_VIEW_ID == oEntity_view.ENTITY_VIEW_ID)).ToList();
                                if (oList_Entity_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    this._service_mesh.Edit_Entity_view_List(new Service_Mesh.Params_Edit_Entity_view_List()
                                    {
                                        List_To_Delete = oList_Entity_view.Select(oEntity_view => oEntity_view.ENTITY_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Entity_view
                    // -----------------------------
                    if (i_Entity.List_Entity_view != null && i_Entity.List_Entity_view.Count > 0)
                    {
                        foreach (var oEntity_view in i_Entity.List_Entity_view)
                        {
                            oEntity_view.ENTITY_ID = i_Entity.ENTITY_ID;
                            Service_Mesh.Entity_view oEntity_view_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Entity_view>(oEntity_view);
                            this._service_mesh.Edit_Entity_view(oEntity_view_mesh);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Setup_category_Reset
        public void BLC_OnPostEvent_Edit_Setup_category_Reset(Setup_category i_Setup_category, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Setup_category != null)
            {
                if (i_Setup_category.List_Setup != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Setup_category.List_Setup.Count == 0)
                        {
                            Delete_Setup_By_SETUP_CATEGORY_ID(new Params_Delete_Setup_By_SETUP_CATEGORY_ID()
                            {
                                SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Setup
                            // -----------------------------
                            List<Setup> oList_Setup = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID()
                            {
                                SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                            });
                            if (oList_Setup != null && oList_Setup.Count > 0)
                            {
                                oList_Setup = oList_Setup.Where(oSetup => !i_Setup_category.List_Setup.Any(oCurrent_Setup => oCurrent_Setup.SETUP_ID == oSetup.SETUP_ID)).ToList();
                                if (oList_Setup.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Setup_List(new Params_Edit_Setup_List()
                                    {
                                        List_To_Delete = oList_Setup.Select(oSetup => oSetup.SETUP_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Setup
                    // -----------------------------
                    if (i_Setup_category.List_Setup != null && i_Setup_category.List_Setup.Count > 0)
                    {
                        foreach (var oSetup in i_Setup_category.List_Setup)
                        {
                            oSetup.SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID;
                            Edit_Setup(oSetup);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Area_Reset
        public void BLC_OnPostEvent_Edit_Area_Reset(Area i_Area, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Area != null)
            {
                if (i_Area.List_Area_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Area.List_Area_view.Count == 0)
                        {
                            this._service_mesh.Delete_Area_view_By_AREA_ID(new Service_Mesh.Params_Delete_Area_view_By_AREA_ID()
                            {
                                AREA_ID = i_Area.AREA_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Area_view
                            // -----------------------------
                            List<Service_Mesh.Area_view> oList_Area_view = this._service_mesh.Get_Area_view_By_AREA_ID(new Service_Mesh.Params_Get_Area_view_By_AREA_ID()
                            {
                                AREA_ID = i_Area.AREA_ID
                            }).i_Result;
                            if (oList_Area_view != null && oList_Area_view.Count > 0)
                            {
                                oList_Area_view = oList_Area_view.Where(oArea_view => !i_Area.List_Area_view.Any(oCurrent_Area_view => oCurrent_Area_view.AREA_VIEW_ID == oArea_view.AREA_VIEW_ID)).ToList();
                                if (oList_Area_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    this._service_mesh.Edit_Area_view_List(new Service_Mesh.Params_Edit_Area_view_List()
                                    {
                                        List_To_Delete = oList_Area_view.Select(oArea_view => oArea_view.AREA_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Area_view
                    // -----------------------------
                    if (i_Area.List_Area_view != null && i_Area.List_Area_view.Count > 0)
                    {
                        foreach (var oArea_view in i_Area.List_Area_view)
                        {
                            oArea_view.AREA_ID = i_Area.AREA_ID;
                            Service_Mesh.Area_view oArea_view_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Area_view>(oArea_view);
                            this._service_mesh.Edit_Area_view(oArea_view_mesh);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Organization_Reset
        public void BLC_OnPostEvent_Edit_Organization_Reset(Organization i_Organization, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Organization != null)
            {
                var Organization_ID = i_Organization.ORGANIZATION_ID;
                var Organization_level_access_List = i_Organization.List_Organization_level_access;
                var Organization_level_access_handle = Task.Run(() =>
                {
                    if (Organization_level_access_List != null)
                    {
                        if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                        {
                            if (Organization_level_access_List.Count == 0)
                            {
                                this._service_mesh.Delete_Organization_level_access_By_ORGANIZATION_ID(new Service_Mesh.Params_Delete_Organization_level_access_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_level_access
                                // -----------------------------
                                List<Service_Mesh.Organization_level_access> oList_Organization_level_access = this._service_mesh.Get_Organization_level_access_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_level_access_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                }).i_Result;
                                if (oList_Organization_level_access != null && oList_Organization_level_access.Count > 0)
                                {
                                    oList_Organization_level_access = oList_Organization_level_access.Where(oOrganization_level_access => !Organization_level_access_List.Any(oCurrent_Organization_level_access => oCurrent_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID == oOrganization_level_access.ORGANIZATION_LEVEL_ACCESS_ID)).ToList();
                                    if (oList_Organization_level_access.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        this._service_mesh.Edit_Organization_level_access_List(new Service_Mesh.Params_Edit_Organization_level_access_List()
                                        {
                                            List_To_Delete = oList_Organization_level_access.Select(oOrganization_level_access => oOrganization_level_access.ORGANIZATION_LEVEL_ACCESS_ID)
                                        });
                                    }
                                }
                            }
                        }
                        // -----------------------------
                        // Organization_level_access
                        // -----------------------------
                        if (Organization_level_access_List != null && Organization_level_access_List.Count > 0)
                        {
                            foreach (var oOrganization_level_access in Organization_level_access_List)
                            {
                                oOrganization_level_access.ORGANIZATION_ID = Organization_ID;
                                Service_Mesh.Organization_level_access oOrganization_level_access_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Organization_level_access>(oOrganization_level_access);
                                this._service_mesh.Edit_Organization_level_access(oOrganization_level_access_mesh);
                            }
                        }
                    }
                });
                // -----------------------------
                var Organization_districtnex_module_List = i_Organization.List_Organization_districtnex_module;
                var Organization_districtnex_module_handle = Task.Run(() =>
                {
                    if (Organization_districtnex_module_List != null)
                    {
                        if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                        {
                            if (Organization_districtnex_module_List.Count == 0)
                            {
                                this._service_mesh.Delete_Organization_districtnex_module_By_ORGANIZATION_ID(new Service_Mesh.Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_districtnex_module
                                // -----------------------------
                                List<Service_Mesh.Organization_districtnex_module> oList_Organization_districtnex_module = this._service_mesh.Get_Organization_districtnex_module_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                }).i_Result;
                                if (oList_Organization_districtnex_module != null && oList_Organization_districtnex_module.Count > 0)
                                {
                                    oList_Organization_districtnex_module = oList_Organization_districtnex_module.Where(oOrganization_districtnex_module => !Organization_districtnex_module_List.Any(oCurrent_Organization_districtnex_module => oCurrent_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID)).ToList();
                                    if (oList_Organization_districtnex_module.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        this._service_mesh.Edit_Organization_districtnex_module_List(new Service_Mesh.Params_Edit_Organization_districtnex_module_List()
                                        {
                                            List_To_Delete = oList_Organization_districtnex_module.Select(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID)
                                        });
                                    }
                                }
                            }
                        }
                        // -----------------------------
                        // Organization_districtnex_module
                        // -----------------------------
                        if (Organization_districtnex_module_List != null && Organization_districtnex_module_List.Count > 0)
                        {
                            foreach (var oOrganization_districtnex_module in Organization_districtnex_module_List)
                            {
                                oOrganization_districtnex_module.ORGANIZATION_ID = Organization_ID;
                                Service_Mesh.Organization_districtnex_module oOrganization_districtnex_module_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Organization_districtnex_module>(oOrganization_districtnex_module);
                                this._service_mesh.Edit_Organization_districtnex_module(oOrganization_districtnex_module_mesh);
                            }
                        }
                    }
                });
                // -----------------------------
                var Organization_color_scheme_List = i_Organization.List_Organization_color_scheme;
                var Organization_color_scheme_handle = Task.Run(() =>
                {
                    if (Organization_color_scheme_List != null)
                    {
                        if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                        {
                            if (Organization_color_scheme_List.Count == 0)
                            {
                                this._service_mesh.Delete_Organization_color_scheme_By_ORGANIZATION_ID(new Service_Mesh.Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_color_scheme
                                // -----------------------------
                                List<Service_Mesh.Organization_color_scheme> oList_Organization_color_scheme = this._service_mesh.Get_Organization_color_scheme_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                }).i_Result;
                                if (oList_Organization_color_scheme != null && oList_Organization_color_scheme.Count > 0)
                                {
                                    oList_Organization_color_scheme = oList_Organization_color_scheme.Where(oOrganization_color_scheme => !Organization_color_scheme_List.Any(oCurrent_Organization_color_scheme => oCurrent_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID == oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID)).ToList();
                                    if (oList_Organization_color_scheme.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        this._service_mesh.Edit_Organization_color_scheme_List(new Service_Mesh.Params_Edit_Organization_color_scheme_List()
                                        {
                                            List_To_Delete = oList_Organization_color_scheme.Select(oOrganization_color_scheme => oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID)
                                        });
                                    }
                                }
                            }
                        }
                        // -----------------------------
                        // Organization_color_scheme
                        // -----------------------------
                        if (Organization_color_scheme_List != null && Organization_color_scheme_List.Count > 0)
                        {
                            foreach (var oOrganization_color_scheme in Organization_color_scheme_List)
                            {
                                oOrganization_color_scheme.ORGANIZATION_ID = Organization_ID;
                                Service_Mesh.Organization_color_scheme oOrganization_color_scheme_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Organization_color_scheme>(oOrganization_color_scheme);
                                this._service_mesh.Edit_Organization_color_scheme(oOrganization_color_scheme_mesh);
                            }
                        }
                    }
                });
                // -----------------------------
                var Organization_log_config_List = i_Organization.List_Organization_log_config;
                var Organization_log_config_handle = Task.Run(() =>
                {
                    if (Organization_log_config_List != null)
                    {
                        if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                        {
                            if (Organization_log_config_List.Count == 0)
                            {
                                this._service_mesh.Delete_Organization_log_config_By_ORGANIZATION_ID(new Service_Mesh.Params_Delete_Organization_log_config_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_log_config
                                // -----------------------------
                                List<Service_Mesh.Organization_log_config> oList_Organization_log_config = this._service_mesh.Get_Organization_log_config_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_log_config_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                }).i_Result;
                                if (oList_Organization_log_config != null && oList_Organization_log_config.Count > 0)
                                {
                                    oList_Organization_log_config = oList_Organization_log_config.Where(oOrganization_log_config => !Organization_log_config_List.Any(oCurrent_Organization_log_config => oCurrent_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID == oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID)).ToList();
                                    if (oList_Organization_log_config.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        this._service_mesh.Edit_Organization_log_config_List(new Service_Mesh.Params_Edit_Organization_log_config_List()
                                        {
                                            List_To_Delete = oList_Organization_log_config.Select(oOrganization_log_config => oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID)
                                        });
                                    }
                                }
                            }
                        }
                        // -----------------------------
                        // Organization_log_config
                        // -----------------------------
                        if (Organization_log_config_List != null && Organization_log_config_List.Count > 0)
                        {
                            foreach (var oOrganization_log_config in Organization_log_config_List)
                            {
                                oOrganization_log_config.ORGANIZATION_ID = Organization_ID;
                                Service_Mesh.Organization_log_config oOrganization_log_config_mesh = Props.Copy_Prop_Values_From_Api_Response<Service_Mesh.Organization_log_config>(oOrganization_log_config);
                                this._service_mesh.Edit_Organization_log_config(oOrganization_log_config_mesh);
                            }
                        }
                    }
                });
                // -----------------------------
                Task.WaitAll(Organization_level_access_handle, Organization_districtnex_module_handle, Organization_color_scheme_handle, Organization_log_config_handle);
            }
        }
        #endregion
        #region Initialize_Reset_Mechanism
        public void Initialize_Reset_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Edit_Space += new PostEvent_Handler_Edit_Space(BLC_OnPostEvent_Edit_Space_Reset);
            this.OnPostEvent_Edit_District += new PostEvent_Handler_Edit_District(BLC_OnPostEvent_Edit_District_Reset);
            this.OnPostEvent_Edit_Site += new PostEvent_Handler_Edit_Site(BLC_OnPostEvent_Edit_Site_Reset);
            this.OnPostEvent_Edit_Entity += new PostEvent_Handler_Edit_Entity(BLC_OnPostEvent_Edit_Entity_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            this.OnPostEvent_Edit_Area += new PostEvent_Handler_Edit_Area(BLC_OnPostEvent_Edit_Area_Reset);
            this.OnPostEvent_Edit_Organization += new PostEvent_Handler_Edit_Organization(BLC_OnPostEvent_Edit_Organization_Reset);
            #endregion
        }
        #endregion
    }
}