using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Organization_color_scheme_Reset
        public void BLC_OnPostEvent_Edit_Organization_color_scheme_Reset(Organization_color_scheme i_Organization_color_scheme, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Organization_color_scheme != null)
            {
                if (i_Organization_color_scheme.List_Organization_chart_color != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Organization_color_scheme.List_Organization_chart_color.Count == 0)
                        {
                            Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(new Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID()
                            {
                                ORGANIZATION_COLOR_SCHEME_ID = i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Organization_chart_color
                            // -----------------------------
                            List<Organization_chart_color> oList_Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(new Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID()
                            {
                                ORGANIZATION_COLOR_SCHEME_ID = i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID
                            });
                            if (oList_Organization_chart_color != null && oList_Organization_chart_color.Count > 0)
                            {
                                oList_Organization_chart_color = oList_Organization_chart_color.Where(oOrganization_chart_color => !i_Organization_color_scheme.List_Organization_chart_color.Any(oCurrent_Organization_chart_color => oCurrent_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID == oOrganization_chart_color.ORGANIZATION_CHART_COLOR_ID)).ToList();
                                if (oList_Organization_chart_color.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Organization_chart_color_List(new Params_Edit_Organization_chart_color_List()
                                    {
                                        List_To_Delete = oList_Organization_chart_color.Select(oOrganization_chart_color => oOrganization_chart_color.ORGANIZATION_CHART_COLOR_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Organization_chart_color
                    // -----------------------------
                    if (i_Organization_color_scheme.List_Organization_chart_color != null && i_Organization_color_scheme.List_Organization_chart_color.Count > 0)
                    {
                        foreach (var oOrganization_chart_color in i_Organization_color_scheme.List_Organization_chart_color)
                        {
                            oOrganization_chart_color.ORGANIZATION_COLOR_SCHEME_ID = i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID;
                            Edit_Organization_chart_color(oOrganization_chart_color);
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
                                Delete_Organization_level_access_By_ORGANIZATION_ID(new Params_Delete_Organization_level_access_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_level_access
                                // -----------------------------
                                List<Organization_level_access> oList_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID(new Params_Get_Organization_level_access_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                                if (oList_Organization_level_access != null && oList_Organization_level_access.Count > 0)
                                {
                                    oList_Organization_level_access = oList_Organization_level_access.Where(oOrganization_level_access => !Organization_level_access_List.Any(oCurrent_Organization_level_access => oCurrent_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID == oOrganization_level_access.ORGANIZATION_LEVEL_ACCESS_ID)).ToList();
                                    if (oList_Organization_level_access.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        Edit_Organization_level_access_List(new Params_Edit_Organization_level_access_List()
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
                                Edit_Organization_level_access(oOrganization_level_access);
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
                                Delete_Organization_districtnex_module_By_ORGANIZATION_ID(new Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_districtnex_module
                                // -----------------------------
                                List<Organization_districtnex_module> oList_Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_ID(new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                                if (oList_Organization_districtnex_module != null && oList_Organization_districtnex_module.Count > 0)
                                {
                                    oList_Organization_districtnex_module = oList_Organization_districtnex_module.Where(oOrganization_districtnex_module => !Organization_districtnex_module_List.Any(oCurrent_Organization_districtnex_module => oCurrent_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID)).ToList();
                                    if (oList_Organization_districtnex_module.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        Edit_Organization_districtnex_module_List(new Params_Edit_Organization_districtnex_module_List()
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
                                Edit_Organization_districtnex_module(oOrganization_districtnex_module);
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
                                Delete_Organization_color_scheme_By_ORGANIZATION_ID(new Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_color_scheme
                                // -----------------------------
                                List<Organization_color_scheme> oList_Organization_color_scheme = Get_Organization_color_scheme_By_ORGANIZATION_ID(new Params_Get_Organization_color_scheme_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                                if (oList_Organization_color_scheme != null && oList_Organization_color_scheme.Count > 0)
                                {
                                    oList_Organization_color_scheme = oList_Organization_color_scheme.Where(oOrganization_color_scheme => !Organization_color_scheme_List.Any(oCurrent_Organization_color_scheme => oCurrent_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID == oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID)).ToList();
                                    if (oList_Organization_color_scheme.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        Edit_Organization_color_scheme_List(new Params_Edit_Organization_color_scheme_List()
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
                                Edit_Organization_color_scheme(oOrganization_color_scheme);
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
                                Delete_Organization_log_config_By_ORGANIZATION_ID(new Params_Delete_Organization_log_config_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                            }
                            else
                            {
                                // -----------------------------
                                // Get related Organization_log_config
                                // -----------------------------
                                List<Organization_log_config> oList_Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_ID(new Params_Get_Organization_log_config_By_ORGANIZATION_ID()
                                {
                                    ORGANIZATION_ID = Organization_ID
                                });
                                if (oList_Organization_log_config != null && oList_Organization_log_config.Count > 0)
                                {
                                    oList_Organization_log_config = oList_Organization_log_config.Where(oOrganization_log_config => !Organization_log_config_List.Any(oCurrent_Organization_log_config => oCurrent_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID == oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID)).ToList();
                                    if (oList_Organization_log_config.Count > 0)
                                    {
                                        // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                        Edit_Organization_log_config_List(new Params_Edit_Organization_log_config_List()
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
                                Edit_Organization_log_config(oOrganization_log_config);
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
            this.OnPostEvent_Edit_Organization_color_scheme += new PostEvent_Handler_Edit_Organization_color_scheme(BLC_OnPostEvent_Edit_Organization_color_scheme_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            this.OnPostEvent_Edit_Organization += new PostEvent_Handler_Edit_Organization(BLC_OnPostEvent_Edit_Organization_Reset);
            #endregion
        }
        #endregion
    }
}