using System;
using System.Linq;
using SmartrTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Members
        #region Used For Delete Operations
        private Organization_theme _Organization_theme;
        private List<Organization_theme> _List_Organization_theme;
        private Organization _Organization;
        private List<Organization> _List_Organization;
        private Organization_level_access _Organization_level_access;
        private List<Organization_level_access> _List_Organization_level_access;
        private Organization_log_config _Organization_log_config;
        private List<Organization_log_config> _List_Organization_log_config;
        private Organization_color_scheme _Organization_color_scheme;
        private List<Organization_color_scheme> _List_Organization_color_scheme;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Organization_image _Organization_image;
        private List<Organization_image> _List_Organization_image;
        private Organization_relation _Organization_relation;
        private List<Organization_relation> _List_Organization_relation;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Organization_data_source_kpi _Organization_data_source_kpi;
        private List<Organization_data_source_kpi> _List_Organization_data_source_kpi;
        private Organization_chart_color _Organization_chart_color;
        private List<Organization_chart_color> _List_Organization_chart_color;
        private Organization_districtnex_module _Organization_districtnex_module;
        private List<Organization_districtnex_module> _List_Organization_districtnex_module;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Organization_theme_Execution;
        private bool _Stop_Delete_Organization_theme_Execution;
        private bool _Stop_Edit_Organization_Execution;
        private bool _Stop_Delete_Organization_Execution;
        private bool _Stop_Edit_Organization_level_access_Execution;
        private bool _Stop_Delete_Organization_level_access_Execution;
        private bool _Stop_Edit_Organization_log_config_Execution;
        private bool _Stop_Delete_Organization_log_config_Execution;
        private bool _Stop_Edit_Organization_color_scheme_Execution;
        private bool _Stop_Delete_Organization_color_scheme_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Organization_image_Execution;
        private bool _Stop_Delete_Organization_image_Execution;
        private bool _Stop_Edit_Organization_relation_Execution;
        private bool _Stop_Delete_Organization_relation_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Organization_data_source_kpi_Execution;
        private bool _Stop_Delete_Organization_data_source_kpi_Execution;
        private bool _Stop_Edit_Organization_chart_color_Execution;
        private bool _Stop_Delete_Organization_chart_color_Execution;
        private bool _Stop_Edit_Organization_districtnex_module_Execution;
        private bool _Stop_Delete_Organization_districtnex_module_Execution;
        #endregion
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID
        public Organization_theme Get_Organization_theme_By_ORGANIZATION_THEME_ID(Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID)
        {
            Organization_theme oOrganization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_theme oDBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_THEME_ID(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID.ORGANIZATION_THEME_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_theme").Replace("%2", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID.ORGANIZATION_THEME_ID.ToString()));
            }
            oOrganization_theme = new Organization_theme();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_json, false);
            }
            return oOrganization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID
        public Organization Get_Organization_By_ORGANIZATION_ID(Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID)
        {
            Organization oOrganization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_ID", i_Params_Get_Organization_By_ORGANIZATION_ID_json, false);
            }
            #region PreEvent_Get_Organization_By_ORGANIZATION_ID
            if (OnPreEvent_Get_Organization_By_ORGANIZATION_ID != null)
            {
                OnPreEvent_Get_Organization_By_ORGANIZATION_ID(i_Params_Get_Organization_By_ORGANIZATION_ID);
            }
            #endregion
            #region Body Section.
            DALC.Organization oDBEntry = _AppContext.Get_Organization_By_ORGANIZATION_ID(i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization").Replace("%2", i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID.ToString()));
            }
            oOrganization = new Organization();
            Props.Copy_Prop_Values(oDBEntry, oOrganization);
            #endregion
            #region PostEvent_Get_Organization_By_ORGANIZATION_ID
            if (OnPostEvent_Get_Organization_By_ORGANIZATION_ID != null)
            {
                OnPostEvent_Get_Organization_By_ORGANIZATION_ID(oOrganization, i_Params_Get_Organization_By_ORGANIZATION_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_ID", i_Params_Get_Organization_By_ORGANIZATION_ID_json, false);
            }
            return oOrganization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        public Organization_level_access Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID)
        {
            Organization_level_access oOrganization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_level_access oDBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID.ORGANIZATION_LEVEL_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_level_access").Replace("%2", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID.ORGANIZATION_LEVEL_ACCESS_ID.ToString()));
            }
            oOrganization_level_access = new Organization_level_access();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json, false);
            }
            return oOrganization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID
        public Organization_log_config Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID(Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID)
        {
            Organization_log_config oOrganization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_log_config oDBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID.ORGANIZATION_LOG_CONFIG_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_log_config").Replace("%2", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID.ORGANIZATION_LOG_CONFIG_ID.ToString()));
            }
            oOrganization_log_config = new Organization_log_config();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_json, false);
            }
            return oOrganization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID
        public Organization_color_scheme Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID(Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID)
        {
            Organization_color_scheme oOrganization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_color_scheme oDBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_color_scheme").Replace("%2", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID.ToString()));
            }
            oOrganization_color_scheme = new Organization_color_scheme();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            return oOrganization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup_category").Replace("%2", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID.ToString()));
            }
            oSetup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID
        public Organization_image Get_Organization_image_By_ORGANIZATION_IMAGE_ID(Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID)
        {
            Organization_image oOrganization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_image oDBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_IMAGE_ID(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID.ORGANIZATION_IMAGE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_image").Replace("%2", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID.ORGANIZATION_IMAGE_ID.ToString()));
            }
            oOrganization_image = new Organization_image();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_json, false);
            }
            return oOrganization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID
        public Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID(Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID)
        {
            Organization_relation oOrganization_relation = null;
            var i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_relation oDBEntry = _AppContext.Get_Organization_relation_By_ORGANIZATION_RELATION_ID(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID.ORGANIZATION_RELATION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_relation").Replace("%2", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID.ORGANIZATION_RELATION_ID.ToString()));
            }
            oOrganization_relation = new Organization_relation();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json, false);
            }
            return oOrganization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_data_source_kpi oDBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_data_source_kpi").Replace("%2", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID.ToString()));
            }
            oOrganization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID
        public Organization_chart_color Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID(Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID)
        {
            Organization_chart_color oOrganization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_chart_color oDBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID.ORGANIZATION_CHART_COLOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_chart_color").Replace("%2", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID.ORGANIZATION_CHART_COLOR_ID.ToString()));
            }
            oOrganization_chart_color = new Organization_chart_color();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_json, false);
            }
            return oOrganization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID
        public Organization_districtnex_module Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID(Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID)
        {
            Organization_districtnex_module oOrganization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_districtnex_module oDBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID.ORGANIZATION_DISTRICTNEX_MODULE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_districtnex_module").Replace("%2", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID.ORGANIZATION_DISTRICTNEX_MODULE_ID.ToString()));
            }
            oOrganization_districtnex_module = new Organization_districtnex_module();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oOrganization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_List
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_THEME_ID_List(Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID_List", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_THEME_ID_List(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List.ORGANIZATION_THEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID_List", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List
        public List<Organization> Get_Organization_By_ORGANIZATION_ID_List(Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_ID_List", i_Params_Get_Organization_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_Organization_By_ORGANIZATION_ID_List
            if (OnPreEvent_Get_Organization_By_ORGANIZATION_ID_List != null)
            {
                OnPreEvent_Get_Organization_By_ORGANIZATION_ID_List(i_Params_Get_Organization_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_ID_List(i_Params_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Organization_By_ORGANIZATION_ID_List
            if (OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List != null)
            {
                OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List(oList_Organization, i_Params_Get_Organization_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_ID_List", i_Params_Get_Organization_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List(Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List.ORGANIZATION_LOG_CONFIG_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List(Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List.ORGANIZATION_COLOR_SCHEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List(Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List.ORGANIZATION_IMAGE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List(Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List.ORGANIZATION_RELATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List(Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List.ORGANIZATION_CHART_COLOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List(Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List.ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID(Params_Get_Organization_theme_By_ORGANIZATION_ID i_Params_Get_Organization_theme_By_ORGANIZATION_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_ID", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_ID(i_Params_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_ID", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID(Params_Get_Organization_theme_By_OWNER_ID i_Params_Get_Organization_theme_By_OWNER_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_OWNER_ID", i_Params_Get_Organization_theme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_OWNER_ID(i_Params_Get_Organization_theme_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_OWNER_ID", i_Params_Get_Organization_theme_By_OWNER_ID_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_IS_DELETED
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID_IS_DELETED(Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_IS_DELETED
        public List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED(Params_Get_Organization_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_By_OWNER_ID_IS_DELETED)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID
        public List<Organization> Get_Organization_By_OWNER_ID(Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_OWNER_ID", i_Params_Get_Organization_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Organization_By_OWNER_ID
            if (OnPreEvent_Get_Organization_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Organization_By_OWNER_ID(i_Params_Get_Organization_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_OWNER_ID(i_Params_Get_Organization_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Organization_By_OWNER_ID
            if (OnPostEvent_Get_Organization_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Organization_By_OWNER_ID(ref oList_Organization, i_Params_Get_Organization_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_OWNER_ID", i_Params_Get_Organization_By_OWNER_ID_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID(Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID.ORGANIZATION_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_IS_DELETED
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_IS_DELETED(Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID(Params_Get_Organization_level_access_By_OWNER_ID i_Params_Get_Organization_level_access_By_OWNER_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_OWNER_ID", i_Params_Get_Organization_level_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_OWNER_ID(i_Params_Get_Organization_level_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_OWNER_ID", i_Params_Get_Organization_level_access_By_OWNER_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID(Params_Get_Organization_level_access_By_ORGANIZATION_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_ID(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID(Params_Get_Organization_level_access_By_LEVEL_ID i_Params_Get_Organization_level_access_By_LEVEL_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_LEVEL_ID", i_Params_Get_Organization_level_access_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_LEVEL_ID(i_Params_Get_Organization_level_access_By_LEVEL_ID.LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_LEVEL_ID", i_Params_Get_Organization_level_access_By_LEVEL_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID, i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID(Params_Get_Organization_log_config_By_OWNER_ID i_Params_Get_Organization_log_config_By_OWNER_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_OWNER_ID", i_Params_Get_Organization_log_config_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_OWNER_ID(i_Params_Get_Organization_log_config_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_OWNER_ID", i_Params_Get_Organization_log_config_By_OWNER_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID(Params_Get_Organization_log_config_By_ORGANIZATION_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_ID(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID(Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_LOG_TYPE_SETUP_ID(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_IS_DELETED
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_IS_DELETED(Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID, i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID(Params_Get_Organization_color_scheme_By_OWNER_ID i_Params_Get_Organization_color_scheme_By_OWNER_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_OWNER_ID", i_Params_Get_Organization_color_scheme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_OWNER_ID(i_Params_Get_Organization_color_scheme_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_OWNER_ID", i_Params_Get_Organization_color_scheme_By_OWNER_ID_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_json, false);
            }
            #region PreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID
            if (OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID != null)
            {
                OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_ID(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID
            if (OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID != null)
            {
                OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID(oList_Organization_color_scheme, i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED(Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_OWNER_ID(oList_Setup_category, i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(Params_Get_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oSetup_category, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID
        public List<Organization_image> Get_Organization_image_By_OWNER_ID(Params_Get_Organization_image_By_OWNER_ID i_Params_Get_Organization_image_By_OWNER_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_OWNER_ID", i_Params_Get_Organization_image_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_OWNER_ID(i_Params_Get_Organization_image_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_OWNER_ID", i_Params_Get_Organization_image_By_OWNER_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID(Params_Get_Organization_image_By_ORGANIZATION_ID i_Params_Get_Organization_image_By_ORGANIZATION_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_ID", i_Params_Get_Organization_image_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_ID(i_Params_Get_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_ID", i_Params_Get_Organization_image_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID(Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_IMAGE_TYPE_SETUP_ID(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID_IS_DELETED
        public List<Organization_image> Get_Organization_image_By_OWNER_ID_IS_DELETED(Params_Get_Organization_image_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID", i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.ORGANIZATION_ID, i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID", i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED(Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID(Params_Get_Organization_relation_By_OWNER_ID i_Params_Get_Organization_relation_By_OWNER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_OWNER_ID", i_Params_Get_Organization_relation_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_OWNER_ID(i_Params_Get_Organization_relation_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_OWNER_ID", i_Params_Get_Organization_relation_By_OWNER_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_PARENT_ORGANIZATION_ID(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID(Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_CHILD_ORGANIZATION_ID(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID.CHILD_ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID
        public List<Organization_relation> Get_Organization_relation_By_USER_ID(Params_Get_Organization_relation_By_USER_ID i_Params_Get_Organization_relation_By_USER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_USER_ID", i_Params_Get_Organization_relation_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_USER_ID(i_Params_Get_Organization_relation_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_USER_ID", i_Params_Get_Organization_relation_By_USER_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID(Params_Get_Organization_data_source_kpi_By_OWNER_ID i_Params_Get_Organization_data_source_kpi_By_OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID(Params_Get_Organization_data_source_kpi_By_KPI_ID i_Params_Get_Organization_data_source_kpi_By_KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID(i_Params_Get_Organization_data_source_kpi_By_KPI_ID.KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID(Params_Get_Organization_chart_color_By_OWNER_ID i_Params_Get_Organization_chart_color_By_OWNER_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_OWNER_ID", i_Params_Get_Organization_chart_color_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_OWNER_ID(i_Params_Get_Organization_chart_color_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_OWNER_ID", i_Params_Get_Organization_chart_color_By_OWNER_ID_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_IS_DELETED
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_IS_DELETED(Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID(Params_Get_Organization_districtnex_module_By_OWNER_ID i_Params_Get_Organization_districtnex_module_By_OWNER_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_OWNER_ID", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_OWNER_ID(i_Params_Get_Organization_districtnex_module_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_OWNER_ID", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_ID(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_List
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_List(Params_Get_Organization_theme_By_ORGANIZATION_ID_List i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_ID_List", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_ID_List(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_ID_List", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List(Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List.ORGANIZATION_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_List(Params_Get_Organization_level_access_By_ORGANIZATION_ID_List i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_List", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_ID_List(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_List", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_List(Params_Get_Organization_level_access_By_LEVEL_ID_List i_Params_Get_Organization_level_access_By_LEVEL_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_LEVEL_ID_List", i_Params_Get_Organization_level_access_By_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_LEVEL_ID_List(i_Params_Get_Organization_level_access_By_LEVEL_ID_List.LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_LEVEL_ID_List", i_Params_Get_Organization_level_access_By_LEVEL_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_List
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_List(Params_Get_Organization_log_config_By_ORGANIZATION_ID_List i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_List", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_ID_List(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_List", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List(Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List.LOG_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_List(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID_List", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List
            if (OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List != null)
            {
                OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_ID_List(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List
            if (OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List != null)
            {
                OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List(oList_Organization_color_scheme, i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID_List", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_List
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_List(Params_Get_Organization_image_By_ORGANIZATION_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_ID_List)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_ID_List", i_Params_Get_Organization_image_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_ID_List(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_ID_List", i_Params_Get_Organization_image_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List(Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List.IMAGE_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List.PARENT_ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List(Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List.CHILD_ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_List
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_List(Params_Get_Organization_relation_By_USER_ID_List i_Params_Get_Organization_relation_By_USER_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_USER_ID_List", i_Params_Get_Organization_relation_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_USER_ID_List(i_Params_Get_Organization_relation_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_USER_ID_List", i_Params_Get_Organization_relation_By_USER_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List.DATA_SOURCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List(Params_Get_Organization_data_source_kpi_By_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID_List(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List(Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List.ORGANIZATION_COLOR_SCHEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List(Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_ID_List(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List(Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where
        public List<Organization_theme> Get_Organization_theme_By_Where(Params_Get_Organization_theme_By_Where i_Params_Get_Organization_theme_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_Where", i_Params_Get_Organization_theme_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_theme_By_Where.OWNER_ID == null || i_Params_Get_Organization_theme_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_theme_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_theme_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_theme_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_theme_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_theme_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_theme_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_Where(i_Params_Get_Organization_theme_By_Where.THEME_NAME, i_Params_Get_Organization_theme_By_Where.THEME_CLASS, i_Params_Get_Organization_theme_By_Where.OWNER_ID, i_Params_Get_Organization_theme_By_Where.OFFSET, i_Params_Get_Organization_theme_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            i_Params_Get_Organization_theme_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_Where", i_Params_Get_Organization_theme_By_Where_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where
        public List<Organization> Get_Organization_By_Where(Params_Get_Organization_By_Where i_Params_Get_Organization_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_Where", i_Params_Get_Organization_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_By_Where.OWNER_ID == null || i_Params_Get_Organization_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_Where(i_Params_Get_Organization_By_Where.ORGANIZATION_NAME, i_Params_Get_Organization_By_Where.ORGANIZATION_EMAIL, i_Params_Get_Organization_By_Where.ORGANIZATION_PHONE_NUMBER, i_Params_Get_Organization_By_Where.ORGANIZATION_ADDRESS, i_Params_Get_Organization_By_Where.OWNER_ID, i_Params_Get_Organization_By_Where.OFFSET, i_Params_Get_Organization_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            i_Params_Get_Organization_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_Where", i_Params_Get_Organization_By_Where_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where
        public List<Organization_level_access> Get_Organization_level_access_By_Where(Params_Get_Organization_level_access_By_Where i_Params_Get_Organization_level_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_Where", i_Params_Get_Organization_level_access_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_level_access_By_Where.OWNER_ID == null || i_Params_Get_Organization_level_access_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_level_access_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_level_access_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_level_access_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_level_access_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_level_access_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_level_access_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_Where(i_Params_Get_Organization_level_access_By_Where.DESCRIPTION, i_Params_Get_Organization_level_access_By_Where.OWNER_ID, i_Params_Get_Organization_level_access_By_Where.OFFSET, i_Params_Get_Organization_level_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            i_Params_Get_Organization_level_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_Where", i_Params_Get_Organization_level_access_By_Where_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where
        public List<Organization_log_config> Get_Organization_log_config_By_Where(Params_Get_Organization_log_config_By_Where i_Params_Get_Organization_log_config_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_Where", i_Params_Get_Organization_log_config_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_log_config_By_Where.OWNER_ID == null || i_Params_Get_Organization_log_config_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_log_config_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_log_config_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_log_config_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_log_config_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_log_config_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_log_config_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_Where(i_Params_Get_Organization_log_config_By_Where.DESCRIPTION, i_Params_Get_Organization_log_config_By_Where.OWNER_ID, i_Params_Get_Organization_log_config_By_Where.OFFSET, i_Params_Get_Organization_log_config_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            i_Params_Get_Organization_log_config_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_Where", i_Params_Get_Organization_log_config_By_Where_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where(Params_Get_Organization_color_scheme_By_Where i_Params_Get_Organization_color_scheme_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_Where", i_Params_Get_Organization_color_scheme_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_color_scheme_By_Where.OWNER_ID == null || i_Params_Get_Organization_color_scheme_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_color_scheme_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_color_scheme_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_color_scheme_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_color_scheme_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_color_scheme_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_color_scheme_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_Where(i_Params_Get_Organization_color_scheme_By_Where.PLATFORM_PRIMARY, i_Params_Get_Organization_color_scheme_By_Where.PLATFORM_BUTTON, i_Params_Get_Organization_color_scheme_By_Where.OWNER_ID, i_Params_Get_Organization_color_scheme_By_Where.OFFSET, i_Params_Get_Organization_color_scheme_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            i_Params_Get_Organization_color_scheme_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_Where", i_Params_Get_Organization_color_scheme_By_Where_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(Params_Get_Setup_category_By_Where i_Params_Get_Setup_category_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_category_By_Where.OWNER_ID == null || i_Params_Get_Setup_category_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_category_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_category_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_category_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_category_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_category_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_category_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_Where(i_Params_Get_Setup_category_By_Where.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_Where.DESCRIPTION, i_Params_Get_Setup_category_By_Where.OWNER_ID, i_Params_Get_Setup_category_By_Where.OFFSET, i_Params_Get_Setup_category_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            i_Params_Get_Setup_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Organization_image_By_Where
        public List<Organization_image> Get_Organization_image_By_Where(Params_Get_Organization_image_By_Where i_Params_Get_Organization_image_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_Where", i_Params_Get_Organization_image_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_image_By_Where.OWNER_ID == null || i_Params_Get_Organization_image_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_image_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_image_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_image_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_image_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_image_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_image_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_Where(i_Params_Get_Organization_image_By_Where.IMAGE_NAME, i_Params_Get_Organization_image_By_Where.IMAGE_EXTENSION, i_Params_Get_Organization_image_By_Where.OWNER_ID, i_Params_Get_Organization_image_By_Where.OFFSET, i_Params_Get_Organization_image_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            i_Params_Get_Organization_image_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_Where", i_Params_Get_Organization_image_By_Where_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where
        public List<Organization_relation> Get_Organization_relation_By_Where(Params_Get_Organization_relation_By_Where i_Params_Get_Organization_relation_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_Where", i_Params_Get_Organization_relation_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_relation_By_Where.OWNER_ID == null || i_Params_Get_Organization_relation_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_relation_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_relation_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_relation_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_relation_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_relation_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_relation_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_Where(i_Params_Get_Organization_relation_By_Where.DESCRIPTION, i_Params_Get_Organization_relation_By_Where.OWNER_ID, i_Params_Get_Organization_relation_By_Where.OFFSET, i_Params_Get_Organization_relation_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            i_Params_Get_Organization_relation_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_Where", i_Params_Get_Organization_relation_By_Where_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where.OWNER_ID == null || i_Params_Get_Setup_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where(Params_Get_Organization_data_source_kpi_By_Where i_Params_Get_Organization_data_source_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID == null || i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where(i_Params_Get_Organization_data_source_kpi_By_Where.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where(Params_Get_Organization_chart_color_By_Where i_Params_Get_Organization_chart_color_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_Where", i_Params_Get_Organization_chart_color_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_chart_color_By_Where.OWNER_ID == null || i_Params_Get_Organization_chart_color_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_chart_color_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_chart_color_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_chart_color_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_chart_color_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_chart_color_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_chart_color_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_Where(i_Params_Get_Organization_chart_color_By_Where.COLOR, i_Params_Get_Organization_chart_color_By_Where.OWNER_ID, i_Params_Get_Organization_chart_color_By_Where.OFFSET, i_Params_Get_Organization_chart_color_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            i_Params_Get_Organization_chart_color_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_Where", i_Params_Get_Organization_chart_color_By_Where_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where(Params_Get_Organization_districtnex_module_By_Where i_Params_Get_Organization_districtnex_module_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_Where", i_Params_Get_Organization_districtnex_module_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_districtnex_module_By_Where.OWNER_ID == null || i_Params_Get_Organization_districtnex_module_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_districtnex_module_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_districtnex_module_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_districtnex_module_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_districtnex_module_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_districtnex_module_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_districtnex_module_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_Where(i_Params_Get_Organization_districtnex_module_By_Where.DESCRIPTION, i_Params_Get_Organization_districtnex_module_By_Where.OWNER_ID, i_Params_Get_Organization_districtnex_module_By_Where.OFFSET, i_Params_Get_Organization_districtnex_module_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            i_Params_Get_Organization_districtnex_module_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_Where", i_Params_Get_Organization_districtnex_module_By_Where_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where_In_List
        public List<Organization_theme> Get_Organization_theme_By_Where_In_List(Params_Get_Organization_theme_By_Where_In_List i_Params_Get_Organization_theme_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_Where_In_List", i_Params_Get_Organization_theme_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_theme_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_theme_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_theme_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_theme_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_theme_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_theme_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_theme_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_theme_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_theme_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_theme_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_Where_In_List(i_Params_Get_Organization_theme_By_Where_In_List.THEME_NAME, i_Params_Get_Organization_theme_By_Where_In_List.THEME_CLASS, i_Params_Get_Organization_theme_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_theme_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_theme_By_Where_In_List.OFFSET, i_Params_Get_Organization_theme_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            i_Params_Get_Organization_theme_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_Where_In_List", i_Params_Get_Organization_theme_By_Where_In_List_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where_In_List
        public List<Organization> Get_Organization_By_Where_In_List(Params_Get_Organization_By_Where_In_List i_Params_Get_Organization_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_Where_In_List", i_Params_Get_Organization_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_Where_In_List(i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_NAME, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_EMAIL, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_PHONE_NUMBER, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_ADDRESS, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_By_Where_In_List.OFFSET, i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            i_Params_Get_Organization_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_Where_In_List", i_Params_Get_Organization_By_Where_In_List_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where_In_List
        public List<Organization_level_access> Get_Organization_level_access_By_Where_In_List(Params_Get_Organization_level_access_By_Where_In_List i_Params_Get_Organization_level_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_Where_In_List", i_Params_Get_Organization_level_access_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_level_access_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_level_access_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_level_access_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_level_access_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_level_access_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_level_access_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_level_access_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_level_access_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_level_access_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_level_access_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Organization_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_Where_In_List(i_Params_Get_Organization_level_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_level_access_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Organization_level_access_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_level_access_By_Where_In_List.OFFSET, i_Params_Get_Organization_level_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            i_Params_Get_Organization_level_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_Where_In_List", i_Params_Get_Organization_level_access_By_Where_In_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where_In_List
        public List<Organization_log_config> Get_Organization_log_config_By_Where_In_List(Params_Get_Organization_log_config_By_Where_In_List i_Params_Get_Organization_log_config_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_Where_In_List", i_Params_Get_Organization_log_config_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_log_config_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_log_config_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_log_config_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_log_config_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_log_config_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_log_config_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_log_config_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_log_config_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_log_config_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_log_config_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_log_config_By_Where_In_List.LOG_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Organization_log_config_By_Where_In_List.LOG_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_Where_In_List(i_Params_Get_Organization_log_config_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_log_config_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_log_config_By_Where_In_List.LOG_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_log_config_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_log_config_By_Where_In_List.OFFSET, i_Params_Get_Organization_log_config_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            i_Params_Get_Organization_log_config_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_Where_In_List", i_Params_Get_Organization_log_config_By_Where_In_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where_In_List
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_In_List(Params_Get_Organization_color_scheme_By_Where_In_List i_Params_Get_Organization_color_scheme_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_Where_In_List", i_Params_Get_Organization_color_scheme_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_color_scheme_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_color_scheme_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_color_scheme_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_color_scheme_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_color_scheme_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_color_scheme_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_color_scheme_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_color_scheme_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_color_scheme_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_color_scheme_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_Where_In_List(i_Params_Get_Organization_color_scheme_By_Where_In_List.PLATFORM_PRIMARY, i_Params_Get_Organization_color_scheme_By_Where_In_List.PLATFORM_BUTTON, i_Params_Get_Organization_color_scheme_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_color_scheme_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_color_scheme_By_Where_In_List.OFFSET, i_Params_Get_Organization_color_scheme_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            i_Params_Get_Organization_color_scheme_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_Where_In_List", i_Params_Get_Organization_color_scheme_By_Where_In_List_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_Where_In_List
        public List<Organization_image> Get_Organization_image_By_Where_In_List(Params_Get_Organization_image_By_Where_In_List i_Params_Get_Organization_image_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_Where_In_List", i_Params_Get_Organization_image_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_image_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_image_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_image_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_image_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_image_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_image_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_image_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_image_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_image_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_image_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Organization_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_Where_In_List(i_Params_Get_Organization_image_By_Where_In_List.IMAGE_NAME, i_Params_Get_Organization_image_By_Where_In_List.IMAGE_EXTENSION, i_Params_Get_Organization_image_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_image_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_image_By_Where_In_List.OFFSET, i_Params_Get_Organization_image_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            i_Params_Get_Organization_image_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_Where_In_List", i_Params_Get_Organization_image_By_Where_In_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where_In_List
        public List<Organization_relation> Get_Organization_relation_By_Where_In_List(Params_Get_Organization_relation_By_Where_In_List i_Params_Get_Organization_relation_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_Where_In_List", i_Params_Get_Organization_relation_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_relation_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_Where_In_List(i_Params_Get_Organization_relation_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST, i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_relation_By_Where_In_List.OFFSET, i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            i_Params_Get_Organization_relation_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_Where_In_List", i_Params_Get_Organization_relation_By_Where_In_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where_In_List.OWNER_ID == null || i_Params_Get_Setup_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST == null)
            {
                i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST = new List<int?>();
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List(Params_Get_Organization_data_source_kpi_By_Where_In_List i_Params_Get_Organization_data_source_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where_In_List", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where_In_List(i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where_In_List", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where_In_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where_In_List(Params_Get_Organization_chart_color_By_Where_In_List i_Params_Get_Organization_chart_color_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_Where_In_List", i_Params_Get_Organization_chart_color_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_chart_color_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_chart_color_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_chart_color_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_chart_color_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_chart_color_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_chart_color_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_chart_color_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_chart_color_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_chart_color_By_Where_In_List.ORGANIZATION_COLOR_SCHEME_ID_LIST == null)
            {
                i_Params_Get_Organization_chart_color_By_Where_In_List.ORGANIZATION_COLOR_SCHEME_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Organization_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_Where_In_List(i_Params_Get_Organization_chart_color_By_Where_In_List.COLOR, i_Params_Get_Organization_chart_color_By_Where_In_List.ORGANIZATION_COLOR_SCHEME_ID_LIST, i_Params_Get_Organization_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Organization_chart_color_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_chart_color_By_Where_In_List.OFFSET, i_Params_Get_Organization_chart_color_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            i_Params_Get_Organization_chart_color_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_Where_In_List", i_Params_Get_Organization_chart_color_By_Where_In_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where_In_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_In_List(Params_Get_Organization_districtnex_module_By_Where_In_List i_Params_Get_Organization_districtnex_module_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_Where_In_List", i_Params_Get_Organization_districtnex_module_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_districtnex_module_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_districtnex_module_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_districtnex_module_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_districtnex_module_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_districtnex_module_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_districtnex_module_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_districtnex_module_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_districtnex_module_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_districtnex_module_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_districtnex_module_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST == null)
            {
                i_Params_Get_Organization_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST = new List<int?>();
            }
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_Where_In_List(i_Params_Get_Organization_districtnex_module_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_districtnex_module_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST, i_Params_Get_Organization_districtnex_module_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_districtnex_module_By_Where_In_List.OFFSET, i_Params_Get_Organization_districtnex_module_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            i_Params_Get_Organization_districtnex_module_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_Where_In_List", i_Params_Get_Organization_districtnex_module_By_Where_In_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Delete_Organization_theme
        public void Delete_Organization_theme(Params_Delete_Organization_theme i_Params_Delete_Organization_theme)
        {
            var i_Params_Delete_Organization_theme_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_theme);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_theme", i_Params_Delete_Organization_theme_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID oParams_Get_Organization_theme_By_ORGANIZATION_THEME_ID = new Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID
                {
                    ORGANIZATION_THEME_ID = i_Params_Delete_Organization_theme.ORGANIZATION_THEME_ID
                };
                _Organization_theme = Get_Organization_theme_By_ORGANIZATION_THEME_ID(oParams_Get_Organization_theme_By_ORGANIZATION_THEME_ID);
                if (_Organization_theme != null)
                {
                    if (_Stop_Delete_Organization_theme_Execution)
                    {
                        _Stop_Delete_Organization_theme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_theme(i_Params_Delete_Organization_theme.ORGANIZATION_THEME_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_theme", i_Params_Delete_Organization_theme_json, false);
            }
        }
        #endregion
        #region Delete_Organization
        public void Delete_Organization(Params_Delete_Organization i_Params_Delete_Organization)
        {
            var i_Params_Delete_Organization_json = JsonConvert.SerializeObject(i_Params_Delete_Organization);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization", i_Params_Delete_Organization_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_By_ORGANIZATION_ID oParams_Get_Organization_By_ORGANIZATION_ID = new Params_Get_Organization_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization.ORGANIZATION_ID
                };
                _Organization = Get_Organization_By_ORGANIZATION_ID(oParams_Get_Organization_By_ORGANIZATION_ID);
                if (_Organization != null)
                {
                    if (_Stop_Delete_Organization_Execution)
                    {
                        _Stop_Delete_Organization_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization(i_Params_Delete_Organization.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization", i_Params_Delete_Organization_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access
        public void Delete_Organization_level_access(Params_Delete_Organization_level_access i_Params_Delete_Organization_level_access)
        {
            var i_Params_Delete_Organization_level_access_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access", i_Params_Delete_Organization_level_access_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID oParams_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID = new Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
                {
                    ORGANIZATION_LEVEL_ACCESS_ID = i_Params_Delete_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID
                };
                _Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(oParams_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID);
                if (_Organization_level_access != null)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access(i_Params_Delete_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access", i_Params_Delete_Organization_level_access_json, false);
            }
        }
        #endregion
        #region Delete_Organization_log_config
        public void Delete_Organization_log_config(Params_Delete_Organization_log_config i_Params_Delete_Organization_log_config)
        {
            var i_Params_Delete_Organization_log_config_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_log_config", i_Params_Delete_Organization_log_config_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID oParams_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID = new Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID
                {
                    ORGANIZATION_LOG_CONFIG_ID = i_Params_Delete_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID
                };
                _Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID(oParams_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID);
                if (_Organization_log_config != null)
                {
                    if (_Stop_Delete_Organization_log_config_Execution)
                    {
                        _Stop_Delete_Organization_log_config_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_log_config(i_Params_Delete_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_log_config", i_Params_Delete_Organization_log_config_json, false);
            }
        }
        #endregion
        #region Delete_Organization_color_scheme
        public void Delete_Organization_color_scheme(Params_Delete_Organization_color_scheme i_Params_Delete_Organization_color_scheme)
        {
            var i_Params_Delete_Organization_color_scheme_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_color_scheme);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_color_scheme", i_Params_Delete_Organization_color_scheme_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID oParams_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID = new Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID
                {
                    ORGANIZATION_COLOR_SCHEME_ID = i_Params_Delete_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID
                };
                _Organization_color_scheme = Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID(oParams_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID);
                if (_Organization_color_scheme != null)
                {
                    if (_Stop_Delete_Organization_color_scheme_Execution)
                    {
                        _Stop_Delete_Organization_color_scheme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_color_scheme(i_Params_Delete_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_color_scheme", i_Params_Delete_Organization_color_scheme_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
        {
            var i_Params_Delete_Setup_category_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_category.SETUP_CATEGORY_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category(i_Params_Delete_Setup_category.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
        }
        #endregion
        #region Delete_Organization_image
        public void Delete_Organization_image(Params_Delete_Organization_image i_Params_Delete_Organization_image)
        {
            var i_Params_Delete_Organization_image_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_image);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_image", i_Params_Delete_Organization_image_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID oParams_Get_Organization_image_By_ORGANIZATION_IMAGE_ID = new Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID
                {
                    ORGANIZATION_IMAGE_ID = i_Params_Delete_Organization_image.ORGANIZATION_IMAGE_ID
                };
                _Organization_image = Get_Organization_image_By_ORGANIZATION_IMAGE_ID(oParams_Get_Organization_image_By_ORGANIZATION_IMAGE_ID);
                if (_Organization_image != null)
                {
                    if (_Stop_Delete_Organization_image_Execution)
                    {
                        _Stop_Delete_Organization_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_image(i_Params_Delete_Organization_image.ORGANIZATION_IMAGE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_image", i_Params_Delete_Organization_image_json, false);
            }
        }
        #endregion
        #region Delete_Organization_relation
        public void Delete_Organization_relation(Params_Delete_Organization_relation i_Params_Delete_Organization_relation)
        {
            var i_Params_Delete_Organization_relation_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_relation);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_relation", i_Params_Delete_Organization_relation_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID oParams_Get_Organization_relation_By_ORGANIZATION_RELATION_ID = new Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID
                {
                    ORGANIZATION_RELATION_ID = i_Params_Delete_Organization_relation.ORGANIZATION_RELATION_ID
                };
                _Organization_relation = Get_Organization_relation_By_ORGANIZATION_RELATION_ID(oParams_Get_Organization_relation_By_ORGANIZATION_RELATION_ID);
                if (_Organization_relation != null)
                {
                    if (_Stop_Delete_Organization_relation_Execution)
                    {
                        _Stop_Delete_Organization_relation_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_relation(i_Params_Delete_Organization_relation.ORGANIZATION_RELATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_relation", i_Params_Delete_Organization_relation_json, false);
            }
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
        {
            var i_Params_Delete_Setup_json = JsonConvert.SerializeObject(i_Params_Delete_Setup);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_ID oParams_Get_Setup_By_SETUP_ID = new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Params_Delete_Setup.SETUP_ID
                };
                _Setup = Get_Setup_By_SETUP_ID(oParams_Get_Setup_By_SETUP_ID);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup(i_Params_Delete_Setup.SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi
        public void Delete_Organization_data_source_kpi(Params_Delete_Organization_data_source_kpi i_Params_Delete_Organization_data_source_kpi)
        {
            var i_Params_Delete_Organization_data_source_kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi", i_Params_Delete_Organization_data_source_kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_Organization_data_source_kpi != null)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi(i_Params_Delete_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi", i_Params_Delete_Organization_data_source_kpi_json, false);
            }
        }
        #endregion
        #region Delete_Organization_chart_color
        public void Delete_Organization_chart_color(Params_Delete_Organization_chart_color i_Params_Delete_Organization_chart_color)
        {
            var i_Params_Delete_Organization_chart_color_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_chart_color);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_chart_color", i_Params_Delete_Organization_chart_color_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID oParams_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID = new Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID
                {
                    ORGANIZATION_CHART_COLOR_ID = i_Params_Delete_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID
                };
                _Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID(oParams_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID);
                if (_Organization_chart_color != null)
                {
                    if (_Stop_Delete_Organization_chart_color_Execution)
                    {
                        _Stop_Delete_Organization_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_chart_color(i_Params_Delete_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_chart_color", i_Params_Delete_Organization_chart_color_json, false);
            }
        }
        #endregion
        #region Delete_Organization_districtnex_module
        public void Delete_Organization_districtnex_module(Params_Delete_Organization_districtnex_module i_Params_Delete_Organization_districtnex_module)
        {
            var i_Params_Delete_Organization_districtnex_module_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_districtnex_module);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_districtnex_module", i_Params_Delete_Organization_districtnex_module_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID oParams_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID = new Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID
                {
                    ORGANIZATION_DISTRICTNEX_MODULE_ID = i_Params_Delete_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID
                };
                _Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID(oParams_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID);
                if (_Organization_districtnex_module != null)
                {
                    #region PreEvent_Delete_Organization_districtnex_module
                    if (OnPreEvent_Delete_Organization_districtnex_module != null)
                    {
                        OnPreEvent_Delete_Organization_districtnex_module(i_Params_Delete_Organization_districtnex_module);
                    }
                    #endregion
                    if (_Stop_Delete_Organization_districtnex_module_Execution)
                    {
                        _Stop_Delete_Organization_districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_districtnex_module(i_Params_Delete_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID);
                    #region PostEvent_Delete_Organization_districtnex_module
                    if (OnPostEvent_Delete_Organization_districtnex_module != null)
                    {
                        OnPostEvent_Delete_Organization_districtnex_module(i_Params_Delete_Organization_districtnex_module);
                    }
                    #endregion
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_districtnex_module", i_Params_Delete_Organization_districtnex_module_json, false);
            }
        }
        #endregion
        #region Delete_Organization_theme_By_ORGANIZATION_ID
        public void Delete_Organization_theme_By_ORGANIZATION_ID(Params_Delete_Organization_theme_By_ORGANIZATION_ID i_Params_Delete_Organization_theme_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_theme_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_theme_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_theme_By_ORGANIZATION_ID", i_Params_Delete_Organization_theme_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_theme_By_ORGANIZATION_ID oParams_Get_Organization_theme_By_ORGANIZATION_ID = new Params_Get_Organization_theme_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_theme = Get_Organization_theme_By_ORGANIZATION_ID(oParams_Get_Organization_theme_By_ORGANIZATION_ID);
                if (_List_Organization_theme != null && _List_Organization_theme.Count > 0)
                {
                    if (_Stop_Delete_Organization_theme_Execution)
                    {
                        _Stop_Delete_Organization_theme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_theme_By_ORGANIZATION_ID(i_Params_Delete_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_theme_By_ORGANIZATION_ID", i_Params_Delete_Organization_theme_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_theme_By_OWNER_ID
        public void Delete_Organization_theme_By_OWNER_ID(Params_Delete_Organization_theme_By_OWNER_ID i_Params_Delete_Organization_theme_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_theme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_theme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_theme_By_OWNER_ID", i_Params_Delete_Organization_theme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_theme_By_OWNER_ID oParams_Get_Organization_theme_By_OWNER_ID = new Params_Get_Organization_theme_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_theme_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_theme = Get_Organization_theme_By_OWNER_ID(oParams_Get_Organization_theme_By_OWNER_ID);
                if (_List_Organization_theme != null && _List_Organization_theme.Count > 0)
                {
                    if (_Stop_Delete_Organization_theme_Execution)
                    {
                        _Stop_Delete_Organization_theme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_theme_By_OWNER_ID(i_Params_Delete_Organization_theme_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_theme_By_OWNER_ID", i_Params_Delete_Organization_theme_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_theme_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_theme_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_theme_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED oParams_Get_Organization_theme_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_theme = Get_Organization_theme_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_theme_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_theme != null && _List_Organization_theme.Count > 0)
                {
                    if (_Stop_Delete_Organization_theme_Execution)
                    {
                        _Stop_Delete_Organization_theme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_theme_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_theme_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_By_OWNER_ID_IS_DELETED oParams_Get_Organization_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization = Get_Organization_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_By_OWNER_ID_IS_DELETED);
                if (_List_Organization != null && _List_Organization.Count > 0)
                {
                    if (_Stop_Delete_Organization_Execution)
                    {
                        _Stop_Delete_Organization_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_By_OWNER_ID
        public void Delete_Organization_By_OWNER_ID(Params_Delete_Organization_By_OWNER_ID i_Params_Delete_Organization_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_By_OWNER_ID", i_Params_Delete_Organization_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_By_OWNER_ID oParams_Get_Organization_By_OWNER_ID = new Params_Get_Organization_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_By_OWNER_ID.OWNER_ID
                };
                _List_Organization = Get_Organization_By_OWNER_ID(oParams_Get_Organization_By_OWNER_ID);
                if (_List_Organization != null && _List_Organization.Count > 0)
                {
                    if (_Stop_Delete_Organization_Execution)
                    {
                        _Stop_Delete_Organization_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_By_OWNER_ID(i_Params_Delete_Organization_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_By_OWNER_ID", i_Params_Delete_Organization_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID
        public void Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID(Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID", i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID oParams_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID = new Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID
                {
                    ORGANIZATION_TYPE_SETUP_ID = i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID.ORGANIZATION_TYPE_SETUP_ID
                };
                _List_Organization = Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID(oParams_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID);
                if (_List_Organization != null && _List_Organization.Count > 0)
                {
                    if (_Stop_Delete_Organization_Execution)
                    {
                        _Stop_Delete_Organization_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID(i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID.ORGANIZATION_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID", i_Params_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_level_access_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED oParams_Get_Organization_level_access_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_level_access = Get_Organization_level_access_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_level_access_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_level_access != null && _List_Organization_level_access.Count > 0)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access_By_OWNER_ID
        public void Delete_Organization_level_access_By_OWNER_ID(Params_Delete_Organization_level_access_By_OWNER_ID i_Params_Delete_Organization_level_access_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_level_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access_By_OWNER_ID", i_Params_Delete_Organization_level_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_OWNER_ID oParams_Get_Organization_level_access_By_OWNER_ID = new Params_Get_Organization_level_access_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_level_access_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_level_access = Get_Organization_level_access_By_OWNER_ID(oParams_Get_Organization_level_access_By_OWNER_ID);
                if (_List_Organization_level_access != null && _List_Organization_level_access.Count > 0)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access_By_OWNER_ID(i_Params_Delete_Organization_level_access_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access_By_OWNER_ID", i_Params_Delete_Organization_level_access_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access_By_ORGANIZATION_ID
        public void Delete_Organization_level_access_By_ORGANIZATION_ID(Params_Delete_Organization_level_access_By_ORGANIZATION_ID i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access_By_ORGANIZATION_ID", i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_ORGANIZATION_ID oParams_Get_Organization_level_access_By_ORGANIZATION_ID = new Params_Get_Organization_level_access_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID(oParams_Get_Organization_level_access_By_ORGANIZATION_ID);
                if (_List_Organization_level_access != null && _List_Organization_level_access.Count > 0)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access_By_ORGANIZATION_ID(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access_By_ORGANIZATION_ID", i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access_By_LEVEL_ID
        public void Delete_Organization_level_access_By_LEVEL_ID(Params_Delete_Organization_level_access_By_LEVEL_ID i_Params_Delete_Organization_level_access_By_LEVEL_ID)
        {
            var i_Params_Delete_Organization_level_access_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access_By_LEVEL_ID", i_Params_Delete_Organization_level_access_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_LEVEL_ID oParams_Get_Organization_level_access_By_LEVEL_ID = new Params_Get_Organization_level_access_By_LEVEL_ID
                {
                    LEVEL_ID = i_Params_Delete_Organization_level_access_By_LEVEL_ID.LEVEL_ID
                };
                _List_Organization_level_access = Get_Organization_level_access_By_LEVEL_ID(oParams_Get_Organization_level_access_By_LEVEL_ID);
                if (_List_Organization_level_access != null && _List_Organization_level_access.Count > 0)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access_By_LEVEL_ID(i_Params_Delete_Organization_level_access_By_LEVEL_ID.LEVEL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access_By_LEVEL_ID", i_Params_Delete_Organization_level_access_By_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID
        public void Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID(Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = new Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
                {
                    DATA_LEVEL_SETUP_ID = i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID
                };
                _List_Organization_level_access = Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID);
                if (_List_Organization_level_access != null && _List_Organization_level_access.Count > 0)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID(i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
        public void Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID = new Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID,
                    DATA_LEVEL_SETUP_ID = i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID
                };
                _List_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID);
                if (_List_Organization_level_access != null && _List_Organization_level_access.Count > 0)
                {
                    if (_Stop_Delete_Organization_level_access_Execution)
                    {
                        _Stop_Delete_Organization_level_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID, i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_log_config_By_OWNER_ID
        public void Delete_Organization_log_config_By_OWNER_ID(Params_Delete_Organization_log_config_By_OWNER_ID i_Params_Delete_Organization_log_config_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_log_config_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_log_config_By_OWNER_ID", i_Params_Delete_Organization_log_config_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_log_config_By_OWNER_ID oParams_Get_Organization_log_config_By_OWNER_ID = new Params_Get_Organization_log_config_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_log_config_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_log_config = Get_Organization_log_config_By_OWNER_ID(oParams_Get_Organization_log_config_By_OWNER_ID);
                if (_List_Organization_log_config != null && _List_Organization_log_config.Count > 0)
                {
                    if (_Stop_Delete_Organization_log_config_Execution)
                    {
                        _Stop_Delete_Organization_log_config_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_log_config_By_OWNER_ID(i_Params_Delete_Organization_log_config_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_log_config_By_OWNER_ID", i_Params_Delete_Organization_log_config_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_log_config_By_ORGANIZATION_ID
        public void Delete_Organization_log_config_By_ORGANIZATION_ID(Params_Delete_Organization_log_config_By_ORGANIZATION_ID i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_log_config_By_ORGANIZATION_ID", i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_log_config_By_ORGANIZATION_ID oParams_Get_Organization_log_config_By_ORGANIZATION_ID = new Params_Get_Organization_log_config_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_ID(oParams_Get_Organization_log_config_By_ORGANIZATION_ID);
                if (_List_Organization_log_config != null && _List_Organization_log_config.Count > 0)
                {
                    if (_Stop_Delete_Organization_log_config_Execution)
                    {
                        _Stop_Delete_Organization_log_config_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_log_config_By_ORGANIZATION_ID(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_log_config_By_ORGANIZATION_ID", i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID
        public void Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID(Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID", i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID oParams_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID = new Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID
                {
                    LOG_TYPE_SETUP_ID = i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID
                };
                _List_Organization_log_config = Get_Organization_log_config_By_LOG_TYPE_SETUP_ID(oParams_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID);
                if (_List_Organization_log_config != null && _List_Organization_log_config.Count > 0)
                {
                    if (_Stop_Delete_Organization_log_config_Execution)
                    {
                        _Stop_Delete_Organization_log_config_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID(i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID", i_Params_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_log_config_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_log_config_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_log_config_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED oParams_Get_Organization_log_config_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_log_config = Get_Organization_log_config_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_log_config_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_log_config != null && _List_Organization_log_config.Count > 0)
                {
                    if (_Stop_Delete_Organization_log_config_Execution)
                    {
                        _Stop_Delete_Organization_log_config_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_log_config_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_log_config_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
        public void Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID = new Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID,
                    LOG_TYPE_SETUP_ID = i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID
                };
                _List_Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID);
                if (_List_Organization_log_config != null && _List_Organization_log_config.Count > 0)
                {
                    if (_Stop_Delete_Organization_log_config_Execution)
                    {
                        _Stop_Delete_Organization_log_config_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID, i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_color_scheme_By_OWNER_ID
        public void Delete_Organization_color_scheme_By_OWNER_ID(Params_Delete_Organization_color_scheme_By_OWNER_ID i_Params_Delete_Organization_color_scheme_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_color_scheme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_color_scheme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_color_scheme_By_OWNER_ID", i_Params_Delete_Organization_color_scheme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_color_scheme_By_OWNER_ID oParams_Get_Organization_color_scheme_By_OWNER_ID = new Params_Get_Organization_color_scheme_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_color_scheme_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_color_scheme = Get_Organization_color_scheme_By_OWNER_ID(oParams_Get_Organization_color_scheme_By_OWNER_ID);
                if (_List_Organization_color_scheme != null && _List_Organization_color_scheme.Count > 0)
                {
                    if (_Stop_Delete_Organization_color_scheme_Execution)
                    {
                        _Stop_Delete_Organization_color_scheme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_color_scheme_By_OWNER_ID(i_Params_Delete_Organization_color_scheme_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_color_scheme_By_OWNER_ID", i_Params_Delete_Organization_color_scheme_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_color_scheme_By_ORGANIZATION_ID
        public void Delete_Organization_color_scheme_By_ORGANIZATION_ID(Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_color_scheme_By_ORGANIZATION_ID", i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_color_scheme_By_ORGANIZATION_ID oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID = new Params_Get_Organization_color_scheme_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_color_scheme = Get_Organization_color_scheme_By_ORGANIZATION_ID(oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID);
                if (_List_Organization_color_scheme != null && _List_Organization_color_scheme.Count > 0)
                {
                    if (_Stop_Delete_Organization_color_scheme_Execution)
                    {
                        _Stop_Delete_Organization_color_scheme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_color_scheme_By_ORGANIZATION_ID(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_color_scheme_By_ORGANIZATION_ID", i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED oParams_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_color_scheme = Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_color_scheme != null && _List_Organization_color_scheme.Count > 0)
                {
                    if (_Stop_Delete_Organization_color_scheme_Execution)
                    {
                        _Stop_Delete_Organization_color_scheme_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(Params_Delete_Setup_category_By_OWNER_ID i_Params_Delete_Setup_category_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID oParams_Get_Setup_category_By_OWNER_ID = new Params_Get_Setup_category_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID(oParams_Get_Setup_category_By_OWNER_ID);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID(i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID_IS_DELETED oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
                {
                    SETUP_CATEGORY_NAME = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME,
                    OWNER_ID = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_image_By_OWNER_ID
        public void Delete_Organization_image_By_OWNER_ID(Params_Delete_Organization_image_By_OWNER_ID i_Params_Delete_Organization_image_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_image_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_image_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_image_By_OWNER_ID", i_Params_Delete_Organization_image_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_image_By_OWNER_ID oParams_Get_Organization_image_By_OWNER_ID = new Params_Get_Organization_image_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_image_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_image = Get_Organization_image_By_OWNER_ID(oParams_Get_Organization_image_By_OWNER_ID);
                if (_List_Organization_image != null && _List_Organization_image.Count > 0)
                {
                    if (_Stop_Delete_Organization_image_Execution)
                    {
                        _Stop_Delete_Organization_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_image_By_OWNER_ID(i_Params_Delete_Organization_image_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_image_By_OWNER_ID", i_Params_Delete_Organization_image_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_image_By_ORGANIZATION_ID
        public void Delete_Organization_image_By_ORGANIZATION_ID(Params_Delete_Organization_image_By_ORGANIZATION_ID i_Params_Delete_Organization_image_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_image_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_image_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_image_By_ORGANIZATION_ID", i_Params_Delete_Organization_image_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_image_By_ORGANIZATION_ID oParams_Get_Organization_image_By_ORGANIZATION_ID = new Params_Get_Organization_image_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_image = Get_Organization_image_By_ORGANIZATION_ID(oParams_Get_Organization_image_By_ORGANIZATION_ID);
                if (_List_Organization_image != null && _List_Organization_image.Count > 0)
                {
                    if (_Stop_Delete_Organization_image_Execution)
                    {
                        _Stop_Delete_Organization_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_image_By_ORGANIZATION_ID(i_Params_Delete_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_image_By_ORGANIZATION_ID", i_Params_Delete_Organization_image_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID
        public void Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID(Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID oParams_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID = new Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID
                {
                    IMAGE_TYPE_SETUP_ID = i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID
                };
                _List_Organization_image = Get_Organization_image_By_IMAGE_TYPE_SETUP_ID(oParams_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID);
                if (_List_Organization_image != null && _List_Organization_image.Count > 0)
                {
                    if (_Stop_Delete_Organization_image_Execution)
                    {
                        _Stop_Delete_Organization_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID(i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_image_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_image_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_image_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_image_By_OWNER_ID_IS_DELETED oParams_Get_Organization_image_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_image_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_image = Get_Organization_image_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_image_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_image != null && _List_Organization_image.Count > 0)
                {
                    if (_Stop_Delete_Organization_image_Execution)
                    {
                        _Stop_Delete_Organization_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_image_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_image_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_image_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
        public void Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID", i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID oParams_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID = new Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.ORGANIZATION_ID,
                    IMAGE_TYPE_SETUP_ID = i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID
                };
                _List_Organization_image = Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(oParams_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID);
                if (_List_Organization_image != null && _List_Organization_image.Count > 0)
                {
                    if (_Stop_Delete_Organization_image_Execution)
                    {
                        _Stop_Delete_Organization_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.ORGANIZATION_ID, i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID", i_Params_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_relation_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_relation_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED oParams_Get_Organization_relation_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_relation = Get_Organization_relation_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_relation_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_relation != null && _List_Organization_relation.Count > 0)
                {
                    if (_Stop_Delete_Organization_relation_Execution)
                    {
                        _Stop_Delete_Organization_relation_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_relation_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_relation_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID
        public void Delete_Organization_relation_By_OWNER_ID(Params_Delete_Organization_relation_By_OWNER_ID i_Params_Delete_Organization_relation_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_relation_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_relation_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_relation_By_OWNER_ID", i_Params_Delete_Organization_relation_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_relation_By_OWNER_ID oParams_Get_Organization_relation_By_OWNER_ID = new Params_Get_Organization_relation_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_relation_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_relation = Get_Organization_relation_By_OWNER_ID(oParams_Get_Organization_relation_By_OWNER_ID);
                if (_List_Organization_relation != null && _List_Organization_relation.Count > 0)
                {
                    if (_Stop_Delete_Organization_relation_Execution)
                    {
                        _Stop_Delete_Organization_relation_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_relation_By_OWNER_ID(i_Params_Delete_Organization_relation_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_relation_By_OWNER_ID", i_Params_Delete_Organization_relation_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_relation_By_PARENT_ORGANIZATION_ID
        public void Delete_Organization_relation_By_PARENT_ORGANIZATION_ID(Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_relation_By_PARENT_ORGANIZATION_ID", i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID = new Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID
                {
                    PARENT_ORGANIZATION_ID = i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID
                };
                _List_Organization_relation = Get_Organization_relation_By_PARENT_ORGANIZATION_ID(oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID);
                if (_List_Organization_relation != null && _List_Organization_relation.Count > 0)
                {
                    if (_Stop_Delete_Organization_relation_Execution)
                    {
                        _Stop_Delete_Organization_relation_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_relation_By_PARENT_ORGANIZATION_ID(i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_relation_By_PARENT_ORGANIZATION_ID", i_Params_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_relation_By_CHILD_ORGANIZATION_ID
        public void Delete_Organization_relation_By_CHILD_ORGANIZATION_ID(Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_relation_By_CHILD_ORGANIZATION_ID", i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID oParams_Get_Organization_relation_By_CHILD_ORGANIZATION_ID = new Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID
                {
                    CHILD_ORGANIZATION_ID = i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID.CHILD_ORGANIZATION_ID
                };
                _List_Organization_relation = Get_Organization_relation_By_CHILD_ORGANIZATION_ID(oParams_Get_Organization_relation_By_CHILD_ORGANIZATION_ID);
                if (_List_Organization_relation != null && _List_Organization_relation.Count > 0)
                {
                    if (_Stop_Delete_Organization_relation_Execution)
                    {
                        _Stop_Delete_Organization_relation_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_relation_By_CHILD_ORGANIZATION_ID(i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID.CHILD_ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_relation_By_CHILD_ORGANIZATION_ID", i_Params_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_relation_By_USER_ID
        public void Delete_Organization_relation_By_USER_ID(Params_Delete_Organization_relation_By_USER_ID i_Params_Delete_Organization_relation_By_USER_ID)
        {
            var i_Params_Delete_Organization_relation_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_relation_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_relation_By_USER_ID", i_Params_Delete_Organization_relation_By_USER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_relation_By_USER_ID oParams_Get_Organization_relation_By_USER_ID = new Params_Get_Organization_relation_By_USER_ID
                {
                    USER_ID = i_Params_Delete_Organization_relation_By_USER_ID.USER_ID
                };
                _List_Organization_relation = Get_Organization_relation_By_USER_ID(oParams_Get_Organization_relation_By_USER_ID);
                if (_List_Organization_relation != null && _List_Organization_relation.Count > 0)
                {
                    if (_Stop_Delete_Organization_relation_Execution)
                    {
                        _Stop_Delete_Organization_relation_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_relation_By_USER_ID(i_Params_Delete_Organization_relation_By_USER_ID.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_relation_By_USER_ID", i_Params_Delete_Organization_relation_By_USER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID_IS_DELETED oParams_Get_Setup_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup = Get_Setup_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_By_OWNER_ID_IS_DELETED);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID oParams_Get_Setup_By_SETUP_CATEGORY_ID = new Params_Get_Setup_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID
                };
                _List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(oParams_Get_Setup_By_SETUP_CATEGORY_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE = new Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID,
                    VALUE = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE
                };
                _Setup = Get_Setup_By_SETUP_CATEGORY_ID_VALUE(oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(Params_Delete_Setup_By_OWNER_ID i_Params_Delete_Setup_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID oParams_Get_Setup_By_OWNER_ID = new Params_Get_Setup_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID
                };
                _List_Setup = Get_Setup_By_OWNER_ID(oParams_Get_Setup_By_OWNER_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID(i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID
        public void Delete_Organization_data_source_kpi_By_OWNER_ID(Params_Delete_Organization_data_source_kpi_By_OWNER_ID i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_OWNER_ID oParams_Get_Organization_data_source_kpi_By_OWNER_ID = new Params_Get_Organization_data_source_kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_OWNER_ID(oParams_Get_Organization_data_source_kpi_By_OWNER_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_OWNER_ID(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public void Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID oParams_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID = new Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
                {
                    DATA_SOURCE_ID = i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(oParams_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_KPI_ID
        public void Delete_Organization_data_source_kpi_By_KPI_ID(Params_Delete_Organization_data_source_kpi_By_KPI_ID i_Params_Delete_Organization_data_source_kpi_By_KPI_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_KPI_ID", i_Params_Delete_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_KPI_ID oParams_Get_Organization_data_source_kpi_By_KPI_ID = new Params_Get_Organization_data_source_kpi_By_KPI_ID
                {
                    KPI_ID = i_Params_Delete_Organization_data_source_kpi_By_KPI_ID.KPI_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(oParams_Get_Organization_data_source_kpi_By_KPI_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_KPI_ID(i_Params_Delete_Organization_data_source_kpi_By_KPI_ID.KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_KPI_ID", i_Params_Delete_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_ORGANIZATION_ID
        public void Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_ID(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED oParams_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_chart_color_By_OWNER_ID
        public void Delete_Organization_chart_color_By_OWNER_ID(Params_Delete_Organization_chart_color_By_OWNER_ID i_Params_Delete_Organization_chart_color_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_chart_color_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_chart_color_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_chart_color_By_OWNER_ID", i_Params_Delete_Organization_chart_color_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_chart_color_By_OWNER_ID oParams_Get_Organization_chart_color_By_OWNER_ID = new Params_Get_Organization_chart_color_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_chart_color_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_chart_color = Get_Organization_chart_color_By_OWNER_ID(oParams_Get_Organization_chart_color_By_OWNER_ID);
                if (_List_Organization_chart_color != null && _List_Organization_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Organization_chart_color_Execution)
                    {
                        _Stop_Delete_Organization_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_chart_color_By_OWNER_ID(i_Params_Delete_Organization_chart_color_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_chart_color_By_OWNER_ID", i_Params_Delete_Organization_chart_color_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
        public void Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID)
        {
            var i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID", i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID oParams_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID = new Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
                {
                    ORGANIZATION_COLOR_SCHEME_ID = i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID
                };
                _List_Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(oParams_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID);
                if (_List_Organization_chart_color != null && _List_Organization_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Organization_chart_color_Execution)
                    {
                        _Stop_Delete_Organization_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID", i_Params_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED oParams_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_chart_color = Get_Organization_chart_color_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_chart_color != null && _List_Organization_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Organization_chart_color_Execution)
                    {
                        _Stop_Delete_Organization_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
        public void Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID oParams_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID = new Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
                {
                    DATA_LEVEL_SETUP_ID = i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID
                };
                _List_Organization_chart_color = Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(oParams_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID);
                if (_List_Organization_chart_color != null && _List_Organization_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Organization_chart_color_Execution)
                    {
                        _Stop_Delete_Organization_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_OWNER_ID
        public void Delete_Organization_districtnex_module_By_OWNER_ID(Params_Delete_Organization_districtnex_module_By_OWNER_ID i_Params_Delete_Organization_districtnex_module_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_districtnex_module_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_districtnex_module_By_OWNER_ID", i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_districtnex_module_By_OWNER_ID oParams_Get_Organization_districtnex_module_By_OWNER_ID = new Params_Get_Organization_districtnex_module_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_districtnex_module_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_districtnex_module = Get_Organization_districtnex_module_By_OWNER_ID(oParams_Get_Organization_districtnex_module_By_OWNER_ID);
                if (_List_Organization_districtnex_module != null && _List_Organization_districtnex_module.Count > 0)
                {
                    if (_Stop_Delete_Organization_districtnex_module_Execution)
                    {
                        _Stop_Delete_Organization_districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_districtnex_module_By_OWNER_ID(i_Params_Delete_Organization_districtnex_module_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_districtnex_module_By_OWNER_ID", i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_ORGANIZATION_ID
        public void Delete_Organization_districtnex_module_By_ORGANIZATION_ID(Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_districtnex_module_By_ORGANIZATION_ID", i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID = new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_ID(oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID);
                if (_List_Organization_districtnex_module != null && _List_Organization_districtnex_module.Count > 0)
                {
                    if (_Stop_Delete_Organization_districtnex_module_Execution)
                    {
                        _Stop_Delete_Organization_districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_districtnex_module_By_ORGANIZATION_ID(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_districtnex_module_By_ORGANIZATION_ID", i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
        public void Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID)
        {
            var i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID", i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID oParams_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID = new Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
                {
                    DISTRICTNEX_MODULE_ID = i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID
                };
                _List_Organization_districtnex_module = Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(oParams_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID);
                if (_List_Organization_districtnex_module != null && _List_Organization_districtnex_module.Count > 0)
                {
                    if (_Stop_Delete_Organization_districtnex_module_Execution)
                    {
                        _Stop_Delete_Organization_districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID", i_Params_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED oParams_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_districtnex_module = Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_districtnex_module != null && _List_Organization_districtnex_module.Count > 0)
                {
                    if (_Stop_Delete_Organization_districtnex_module_Execution)
                    {
                        _Stop_Delete_Organization_districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Edit_Organization_theme
        public void Edit_Organization_theme(Organization_theme i_Organization_theme)
        {
            var i_Organization_theme_json = JsonConvert.SerializeObject(i_Organization_theme);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_theme.ORGANIZATION_THEME_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_theme", i_Organization_theme_json, false);
            }
            #region Body Section.
            if (i_Organization_theme.ORGANIZATION_THEME_ID == null || i_Organization_theme.ORGANIZATION_THEME_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_theme");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_theme.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_theme.IS_DELETED = false;
            }
            else
            {
                _Organization_theme = Get_Organization_theme_By_ORGANIZATION_THEME_ID(new Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID
                {
                    ORGANIZATION_THEME_ID = i_Organization_theme.ORGANIZATION_THEME_ID
                });
            }
            i_Organization_theme.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_theme.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_theme.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_theme_Execution)
            {
                _Stop_Edit_Organization_theme_Execution = false;
                return;
            }
            i_Organization_theme.ORGANIZATION_THEME_ID = _AppContext.Edit_Organization_theme
            (
                i_Organization_theme.ORGANIZATION_THEME_ID,
                i_Organization_theme.ORGANIZATION_ID,
                i_Organization_theme.THEME_NAME,
                i_Organization_theme.THEME_CLASS,
                i_Organization_theme.ENTRY_USER_ID,
                i_Organization_theme.ENTRY_DATE,
                i_Organization_theme.LAST_UPDATE,
                i_Organization_theme.IS_DELETED,
                i_Organization_theme.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_theme", i_Organization_theme_json, false);
            }
        }
        #endregion
        #region Edit_Organization
        public void Edit_Organization(Organization i_Organization)
        {
            var i_Organization_json = JsonConvert.SerializeObject(i_Organization);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization.ORGANIZATION_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization", i_Organization_json, false);
            }
            #region Body Section.
            if (i_Organization.ORGANIZATION_ID == null || i_Organization.ORGANIZATION_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization.IS_DELETED = false;
            }
            else
            {
                _Organization = Get_Organization_By_ORGANIZATION_ID(new Params_Get_Organization_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Organization.ORGANIZATION_ID
                });
            }
            i_Organization.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Organization
            if (OnPreEvent_Edit_Organization != null)
            {
                OnPreEvent_Edit_Organization(i_Organization, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Organization_Execution)
            {
                _Stop_Edit_Organization_Execution = false;
                return;
            }
            i_Organization.ORGANIZATION_ID = _AppContext.Edit_Organization
            (
                i_Organization.ORGANIZATION_ID,
                i_Organization.ORGANIZATION_NAME,
                i_Organization.ORGANIZATION_EMAIL,
                i_Organization.ORGANIZATION_PHONE_NUMBER,
                i_Organization.ORGANIZATION_ADDRESS,
                i_Organization.DATA_RETENTION_PERIOD,
                i_Organization.TICKET_DURATION_IN_MINUTES,
                i_Organization.ORGANIZATION_TYPE_SETUP_ID,
                i_Organization.DATE_DELETED,
                i_Organization.MAX_NUMBER_OF_ADMINS,
                i_Organization.MAX_NUMBER_OF_USERS,
                i_Organization.ENTRY_USER_ID,
                i_Organization.ENTRY_DATE,
                i_Organization.LAST_UPDATE,
                i_Organization.IS_ACTIVE,
                i_Organization.IS_DELETED,
                i_Organization.OWNER_ID
            );
            #region PostEvent_Edit_Organization
            if (OnPostEvent_Edit_Organization != null)
            {
                OnPostEvent_Edit_Organization(i_Organization, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization", i_Organization_json, false);
            }
        }
        #endregion
        #region Edit_Organization_level_access
        public void Edit_Organization_level_access(Organization_level_access i_Organization_level_access)
        {
            var i_Organization_level_access_json = JsonConvert.SerializeObject(i_Organization_level_access);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_level_access", i_Organization_level_access_json, false);
            }
            #region Body Section.
            if (i_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID == null || i_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_level_access");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_level_access.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_level_access.IS_DELETED = false;
            }
            else
            {
                _Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(new Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
                {
                    ORGANIZATION_LEVEL_ACCESS_ID = i_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID
                });
            }
            i_Organization_level_access.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_level_access.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_level_access.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_level_access_Execution)
            {
                _Stop_Edit_Organization_level_access_Execution = false;
                return;
            }
            i_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID = _AppContext.Edit_Organization_level_access
            (
                i_Organization_level_access.ORGANIZATION_LEVEL_ACCESS_ID,
                i_Organization_level_access.ORGANIZATION_ID,
                i_Organization_level_access.LEVEL_ID,
                i_Organization_level_access.DATA_LEVEL_SETUP_ID,
                i_Organization_level_access.ENTRY_USER_ID,
                i_Organization_level_access.ENTRY_DATE,
                i_Organization_level_access.LAST_UPDATE,
                i_Organization_level_access.IS_DELETED,
                i_Organization_level_access.OWNER_ID,
                i_Organization_level_access.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_level_access", i_Organization_level_access_json, false);
            }
        }
        #endregion
        #region Edit_Organization_log_config
        public void Edit_Organization_log_config(Organization_log_config i_Organization_log_config)
        {
            var i_Organization_log_config_json = JsonConvert.SerializeObject(i_Organization_log_config);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_log_config", i_Organization_log_config_json, false);
            }
            #region Body Section.
            if (i_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID == null || i_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_log_config");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_log_config.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_log_config.IS_DELETED = false;
            }
            else
            {
                _Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID(new Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID
                {
                    ORGANIZATION_LOG_CONFIG_ID = i_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID
                });
            }
            i_Organization_log_config.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_log_config.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_log_config.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_log_config_Execution)
            {
                _Stop_Edit_Organization_log_config_Execution = false;
                return;
            }
            i_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID = _AppContext.Edit_Organization_log_config
            (
                i_Organization_log_config.ORGANIZATION_LOG_CONFIG_ID,
                i_Organization_log_config.ORGANIZATION_ID,
                i_Organization_log_config.LOG_TYPE_SETUP_ID,
                i_Organization_log_config.ENTRY_USER_ID,
                i_Organization_log_config.ENTRY_DATE,
                i_Organization_log_config.LAST_UPDATE,
                i_Organization_log_config.IS_DELETED,
                i_Organization_log_config.OWNER_ID,
                i_Organization_log_config.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_log_config", i_Organization_log_config_json, false);
            }
        }
        #endregion
        #region Edit_Organization_color_scheme
        public void Edit_Organization_color_scheme(Organization_color_scheme i_Organization_color_scheme)
        {
            var i_Organization_color_scheme_json = JsonConvert.SerializeObject(i_Organization_color_scheme);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_color_scheme", i_Organization_color_scheme_json, false);
            }
            #region Body Section.
            if (i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID == null || i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_color_scheme");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_color_scheme.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_color_scheme.IS_DELETED = false;
            }
            else
            {
                _Organization_color_scheme = Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID(new Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID
                {
                    ORGANIZATION_COLOR_SCHEME_ID = i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID
                });
            }
            i_Organization_color_scheme.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_color_scheme.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_color_scheme.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Organization_color_scheme
            if (OnPreEvent_Edit_Organization_color_scheme != null)
            {
                OnPreEvent_Edit_Organization_color_scheme(i_Organization_color_scheme, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Organization_color_scheme_Execution)
            {
                _Stop_Edit_Organization_color_scheme_Execution = false;
                return;
            }
            i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = _AppContext.Edit_Organization_color_scheme
            (
                i_Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID,
                i_Organization_color_scheme.ORGANIZATION_ID,
                i_Organization_color_scheme.PLATFORM_PRIMARY,
                i_Organization_color_scheme.PLATFORM_BUTTON,
                i_Organization_color_scheme.ENTRY_USER_ID,
                i_Organization_color_scheme.ENTRY_DATE,
                i_Organization_color_scheme.LAST_UPDATE,
                i_Organization_color_scheme.IS_DELETED,
                i_Organization_color_scheme.OWNER_ID
            );
            #region PostEvent_Edit_Organization_color_scheme
            if (OnPostEvent_Edit_Organization_color_scheme != null)
            {
                OnPostEvent_Edit_Organization_color_scheme(i_Organization_color_scheme, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_color_scheme", i_Organization_color_scheme_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category
        public void Edit_Setup_category(Setup_category i_Setup_category)
        {
            var i_Setup_category_json = JsonConvert.SerializeObject(i_Setup_category);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup_category.SETUP_CATEGORY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
            #region Body Section.
            if (i_Setup_category.SETUP_CATEGORY_ID == null || i_Setup_category.SETUP_CATEGORY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup_category");
            }
            if (Check_Setup_category_Uniqueness_Violation(i_Setup_category))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup_category"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup_category.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup_category.IS_DELETED = false;
            }
            else
            {
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                });
            }
            i_Setup_category.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup_category.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup_category.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Setup_category
            if (OnPreEvent_Edit_Setup_category != null)
            {
                OnPreEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Setup_category_Execution)
            {
                _Stop_Edit_Setup_category_Execution = false;
                return;
            }
            i_Setup_category.SETUP_CATEGORY_ID = _AppContext.Edit_Setup_category
            (
                i_Setup_category.SETUP_CATEGORY_ID,
                i_Setup_category.SETUP_CATEGORY_NAME,
                i_Setup_category.DESCRIPTION,
                i_Setup_category.ENTRY_USER_ID,
                i_Setup_category.ENTRY_DATE,
                i_Setup_category.LAST_UPDATE,
                i_Setup_category.IS_DELETED,
                i_Setup_category.OWNER_ID
            );
            #region PostEvent_Edit_Setup_category
            if (OnPostEvent_Edit_Setup_category != null)
            {
                OnPostEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
        }
        #endregion
        #region Edit_Organization_image
        public void Edit_Organization_image(Organization_image i_Organization_image)
        {
            var i_Organization_image_json = JsonConvert.SerializeObject(i_Organization_image);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_image.ORGANIZATION_IMAGE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_image", i_Organization_image_json, false);
            }
            #region Body Section.
            if (i_Organization_image.ORGANIZATION_IMAGE_ID == null || i_Organization_image.ORGANIZATION_IMAGE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_image");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_image.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_image.IS_DELETED = false;
            }
            else
            {
                _Organization_image = Get_Organization_image_By_ORGANIZATION_IMAGE_ID(new Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID
                {
                    ORGANIZATION_IMAGE_ID = i_Organization_image.ORGANIZATION_IMAGE_ID
                });
            }
            i_Organization_image.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_image.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_image.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_image_Execution)
            {
                _Stop_Edit_Organization_image_Execution = false;
                return;
            }
            i_Organization_image.ORGANIZATION_IMAGE_ID = _AppContext.Edit_Organization_image
            (
                i_Organization_image.ORGANIZATION_IMAGE_ID,
                i_Organization_image.ORGANIZATION_ID,
                i_Organization_image.IMAGE_NAME,
                i_Organization_image.IMAGE_EXTENSION,
                i_Organization_image.IMAGE_TYPE_SETUP_ID,
                i_Organization_image.ENTRY_USER_ID,
                i_Organization_image.ENTRY_DATE,
                i_Organization_image.LAST_UPDATE,
                i_Organization_image.IS_DELETED,
                i_Organization_image.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_image", i_Organization_image_json, false);
            }
        }
        #endregion
        #region Edit_Organization_relation
        public void Edit_Organization_relation(Organization_relation i_Organization_relation)
        {
            var i_Organization_relation_json = JsonConvert.SerializeObject(i_Organization_relation);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_relation.ORGANIZATION_RELATION_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_relation", i_Organization_relation_json, false);
            }
            #region Body Section.
            if (i_Organization_relation.ORGANIZATION_RELATION_ID == null || i_Organization_relation.ORGANIZATION_RELATION_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_relation");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_relation.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_relation.IS_DELETED = false;
            }
            else
            {
                _Organization_relation = Get_Organization_relation_By_ORGANIZATION_RELATION_ID(new Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID
                {
                    ORGANIZATION_RELATION_ID = i_Organization_relation.ORGANIZATION_RELATION_ID
                });
            }
            i_Organization_relation.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_relation.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_relation.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_relation_Execution)
            {
                _Stop_Edit_Organization_relation_Execution = false;
                return;
            }
            i_Organization_relation.ORGANIZATION_RELATION_ID = _AppContext.Edit_Organization_relation
            (
                i_Organization_relation.ORGANIZATION_RELATION_ID,
                i_Organization_relation.PARENT_ORGANIZATION_ID,
                i_Organization_relation.CHILD_ORGANIZATION_ID,
                i_Organization_relation.USER_ID,
                i_Organization_relation.ENTRY_USER_ID,
                i_Organization_relation.ENTRY_DATE,
                i_Organization_relation.LAST_UPDATE,
                i_Organization_relation.IS_DELETED,
                i_Organization_relation.OWNER_ID,
                i_Organization_relation.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_relation", i_Organization_relation_json, false);
            }
        }
        #endregion
        #region Edit_Setup
        public void Edit_Setup(Setup i_Setup)
        {
            var i_Setup_json = JsonConvert.SerializeObject(i_Setup);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup.SETUP_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup", i_Setup_json, false);
            }
            #region Body Section.
            if (i_Setup.SETUP_ID == null || i_Setup.SETUP_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup");
            }
            if (Check_Setup_Uniqueness_Violation(i_Setup))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup.IS_DELETED = false;
            }
            else
            {
                _Setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Setup.SETUP_ID
                });
            }
            i_Setup.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Setup_Execution)
            {
                _Stop_Edit_Setup_Execution = false;
                return;
            }
            i_Setup.SETUP_ID = _AppContext.Edit_Setup
            (
                i_Setup.SETUP_ID,
                i_Setup.SETUP_CATEGORY_ID,
                i_Setup.IS_SYSTEM,
                i_Setup.IS_DELETEABLE,
                i_Setup.IS_UPDATEABLE,
                i_Setup.IS_DELETED,
                i_Setup.IS_VISIBLE,
                i_Setup.DISPLAY_ORDER,
                i_Setup.VALUE,
                i_Setup.DESCRIPTION,
                i_Setup.ENTRY_USER_ID,
                i_Setup.ENTRY_DATE,
                i_Setup.LAST_UPDATE,
                i_Setup.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup", i_Setup_json, false);
            }
        }
        #endregion
        #region Edit_Organization_data_source_kpi
        public void Edit_Organization_data_source_kpi(Organization_data_source_kpi i_Organization_data_source_kpi)
        {
            var i_Organization_data_source_kpi_json = JsonConvert.SerializeObject(i_Organization_data_source_kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_data_source_kpi", i_Organization_data_source_kpi_json, false);
            }
            #region Body Section.
            if (i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == null || i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_data_source_kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_data_source_kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_data_source_kpi.IS_DELETED = false;
            }
            else
            {
                _Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                });
            }
            i_Organization_data_source_kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_data_source_kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_data_source_kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_data_source_kpi_Execution)
            {
                _Stop_Edit_Organization_data_source_kpi_Execution = false;
                return;
            }
            i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = _AppContext.Edit_Organization_data_source_kpi
            (
                i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Organization_data_source_kpi.DATA_SOURCE_ID,
                i_Organization_data_source_kpi.KPI_ID,
                i_Organization_data_source_kpi.ORGANIZATION_ID,
                i_Organization_data_source_kpi.ENTRY_USER_ID,
                i_Organization_data_source_kpi.ENTRY_DATE,
                i_Organization_data_source_kpi.LAST_UPDATE,
                i_Organization_data_source_kpi.IS_DELETED,
                i_Organization_data_source_kpi.OWNER_ID,
                i_Organization_data_source_kpi.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_data_source_kpi", i_Organization_data_source_kpi_json, false);
            }
        }
        #endregion
        #region Edit_Organization_chart_color
        public void Edit_Organization_chart_color(Organization_chart_color i_Organization_chart_color)
        {
            var i_Organization_chart_color_json = JsonConvert.SerializeObject(i_Organization_chart_color);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_chart_color", i_Organization_chart_color_json, false);
            }
            #region Body Section.
            if (i_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID == null || i_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_chart_color");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_chart_color.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_chart_color.IS_DELETED = false;
            }
            else
            {
                _Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID(new Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID
                {
                    ORGANIZATION_CHART_COLOR_ID = i_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID
                });
            }
            i_Organization_chart_color.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_chart_color.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_chart_color.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_chart_color_Execution)
            {
                _Stop_Edit_Organization_chart_color_Execution = false;
                return;
            }
            i_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID = _AppContext.Edit_Organization_chart_color
            (
                i_Organization_chart_color.ORGANIZATION_CHART_COLOR_ID,
                i_Organization_chart_color.ORGANIZATION_COLOR_SCHEME_ID,
                i_Organization_chart_color.COLOR,
                i_Organization_chart_color.DATA_LEVEL_SETUP_ID,
                i_Organization_chart_color.ENTRY_USER_ID,
                i_Organization_chart_color.ENTRY_DATE,
                i_Organization_chart_color.LAST_UPDATE,
                i_Organization_chart_color.IS_DELETED,
                i_Organization_chart_color.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_chart_color", i_Organization_chart_color_json, false);
            }
        }
        #endregion
        #region Edit_Organization_districtnex_module
        public void Edit_Organization_districtnex_module(Organization_districtnex_module i_Organization_districtnex_module)
        {
            var i_Organization_districtnex_module_json = JsonConvert.SerializeObject(i_Organization_districtnex_module);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_districtnex_module", i_Organization_districtnex_module_json, false);
            }
            #region Body Section.
            if (i_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == null || i_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_districtnex_module");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_districtnex_module.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_districtnex_module.IS_DELETED = false;
            }
            else
            {
                _Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID(new Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID
                {
                    ORGANIZATION_DISTRICTNEX_MODULE_ID = i_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID
                });
            }
            i_Organization_districtnex_module.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_districtnex_module.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_districtnex_module.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_districtnex_module_Execution)
            {
                _Stop_Edit_Organization_districtnex_module_Execution = false;
                return;
            }
            i_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID = _AppContext.Edit_Organization_districtnex_module
            (
                i_Organization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID,
                i_Organization_districtnex_module.ORGANIZATION_ID,
                i_Organization_districtnex_module.DISTRICTNEX_MODULE_ID,
                i_Organization_districtnex_module.ENTRY_USER_ID,
                i_Organization_districtnex_module.ENTRY_DATE,
                i_Organization_districtnex_module.LAST_UPDATE,
                i_Organization_districtnex_module.IS_DELETED,
                i_Organization_districtnex_module.OWNER_ID,
                i_Organization_districtnex_module.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_districtnex_module", i_Organization_districtnex_module_json, false);
            }
        }
        #endregion
        #region Edit_Organization_theme_List
        public void Edit_Organization_theme_List(Params_Edit_Organization_theme_List i_Params_Edit_Organization_theme_List)
        {
            var i_Params_Edit_Organization_theme_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_theme_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_theme_List", i_Params_Edit_Organization_theme_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_theme_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_theme_List.List_Failed_Edit = new List<Organization_theme>();
                if (i_Params_Edit_Organization_theme_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_theme in i_Params_Edit_Organization_theme_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_theme(oOrganization_theme);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_theme_List.List_Failed_Edit.Add(oOrganization_theme);
                        }
                    }
                }
                i_Params_Edit_Organization_theme_List.List_To_Edit = i_Params_Edit_Organization_theme_List.List_To_Edit.Except(i_Params_Edit_Organization_theme_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_theme_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_theme_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_theme_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_theme_ID in i_Params_Edit_Organization_theme_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_theme(new Params_Delete_Organization_theme()
                            {
                                ORGANIZATION_THEME_ID = Organization_theme_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_theme_List.List_Failed_Delete.Add(Organization_theme_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_theme_List.List_To_Delete = i_Params_Edit_Organization_theme_List.List_To_Delete.Except(i_Params_Edit_Organization_theme_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_theme_List", i_Params_Edit_Organization_theme_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_List
        public void Edit_Organization_List(Params_Edit_Organization_List i_Params_Edit_Organization_List)
        {
            var i_Params_Edit_Organization_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_List", i_Params_Edit_Organization_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_List.List_Failed_Edit = new List<Organization>();
                if (i_Params_Edit_Organization_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization in i_Params_Edit_Organization_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization(oOrganization);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_List.List_Failed_Edit.Add(oOrganization);
                        }
                    }
                }
                i_Params_Edit_Organization_List.List_To_Edit = i_Params_Edit_Organization_List.List_To_Edit.Except(i_Params_Edit_Organization_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_ID in i_Params_Edit_Organization_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization(new Params_Delete_Organization()
                            {
                                ORGANIZATION_ID = Organization_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_List.List_Failed_Delete.Add(Organization_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_List.List_To_Delete = i_Params_Edit_Organization_List.List_To_Delete.Except(i_Params_Edit_Organization_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_List", i_Params_Edit_Organization_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_level_access_List
        public void Edit_Organization_level_access_List(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List)
        {
            var i_Params_Edit_Organization_level_access_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_level_access_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_level_access_List", i_Params_Edit_Organization_level_access_List_json, false);
            }
            #region Body Section.
            #region PreEvent_Edit_Organization_level_access_List
            if (OnPreEvent_Edit_Organization_level_access_List != null)
            {
                OnPreEvent_Edit_Organization_level_access_List(i_Params_Edit_Organization_level_access_List);
            }
            #endregion
            if (i_Params_Edit_Organization_level_access_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_level_access_List.List_Failed_Edit = new List<Organization_level_access>();
                if (i_Params_Edit_Organization_level_access_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_level_access in i_Params_Edit_Organization_level_access_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_level_access(oOrganization_level_access);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_level_access_List.List_Failed_Edit.Add(oOrganization_level_access);
                        }
                    }
                }
                i_Params_Edit_Organization_level_access_List.List_To_Edit = i_Params_Edit_Organization_level_access_List.List_To_Edit.Except(i_Params_Edit_Organization_level_access_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_level_access_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_level_access_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Organization_level_access_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_level_access_ID in i_Params_Edit_Organization_level_access_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_level_access(new Params_Delete_Organization_level_access()
                            {
                                ORGANIZATION_LEVEL_ACCESS_ID = Organization_level_access_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_level_access_List.List_Failed_Delete.Add(Organization_level_access_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_level_access_List.List_To_Delete = i_Params_Edit_Organization_level_access_List.List_To_Delete.Except(i_Params_Edit_Organization_level_access_List.List_Failed_Delete);
            }
            #region PostEvent_Edit_Organization_level_access_List
            if (OnPostEvent_Edit_Organization_level_access_List != null)
            {
                OnPostEvent_Edit_Organization_level_access_List(i_Params_Edit_Organization_level_access_List);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_level_access_List", i_Params_Edit_Organization_level_access_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_log_config_List
        public void Edit_Organization_log_config_List(Params_Edit_Organization_log_config_List i_Params_Edit_Organization_log_config_List)
        {
            var i_Params_Edit_Organization_log_config_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_log_config_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_log_config_List", i_Params_Edit_Organization_log_config_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_log_config_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_log_config_List.List_Failed_Edit = new List<Organization_log_config>();
                if (i_Params_Edit_Organization_log_config_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_log_config in i_Params_Edit_Organization_log_config_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_log_config(oOrganization_log_config);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_log_config_List.List_Failed_Edit.Add(oOrganization_log_config);
                        }
                    }
                }
                i_Params_Edit_Organization_log_config_List.List_To_Edit = i_Params_Edit_Organization_log_config_List.List_To_Edit.Except(i_Params_Edit_Organization_log_config_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_log_config_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_log_config_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Organization_log_config_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_log_config_ID in i_Params_Edit_Organization_log_config_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_log_config(new Params_Delete_Organization_log_config()
                            {
                                ORGANIZATION_LOG_CONFIG_ID = Organization_log_config_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_log_config_List.List_Failed_Delete.Add(Organization_log_config_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_log_config_List.List_To_Delete = i_Params_Edit_Organization_log_config_List.List_To_Delete.Except(i_Params_Edit_Organization_log_config_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_log_config_List", i_Params_Edit_Organization_log_config_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_color_scheme_List
        public void Edit_Organization_color_scheme_List(Params_Edit_Organization_color_scheme_List i_Params_Edit_Organization_color_scheme_List)
        {
            var i_Params_Edit_Organization_color_scheme_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_color_scheme_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_color_scheme_List", i_Params_Edit_Organization_color_scheme_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_color_scheme_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_color_scheme_List.List_Failed_Edit = new List<Organization_color_scheme>();
                if (i_Params_Edit_Organization_color_scheme_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_color_scheme in i_Params_Edit_Organization_color_scheme_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_color_scheme(oOrganization_color_scheme);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_color_scheme_List.List_Failed_Edit.Add(oOrganization_color_scheme);
                        }
                    }
                }
                i_Params_Edit_Organization_color_scheme_List.List_To_Edit = i_Params_Edit_Organization_color_scheme_List.List_To_Edit.Except(i_Params_Edit_Organization_color_scheme_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_color_scheme_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_color_scheme_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_color_scheme_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_color_scheme_ID in i_Params_Edit_Organization_color_scheme_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_color_scheme(new Params_Delete_Organization_color_scheme()
                            {
                                ORGANIZATION_COLOR_SCHEME_ID = Organization_color_scheme_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_color_scheme_List.List_Failed_Delete.Add(Organization_color_scheme_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_color_scheme_List.List_To_Delete = i_Params_Edit_Organization_color_scheme_List.List_To_Delete.Except(i_Params_Edit_Organization_color_scheme_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_color_scheme_List", i_Params_Edit_Organization_color_scheme_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category_List
        public void Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
        {
            var i_Params_Edit_Setup_category_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_category_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_category_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Edit = new List<Setup_category>();
                if (i_Params_Edit_Setup_category_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup_category in i_Params_Edit_Setup_category_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup_category(oSetup_category);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Edit.Add(oSetup_category);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Edit = i_Params_Edit_Setup_category_List.List_To_Edit.Except(i_Params_Edit_Setup_category_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_category_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Setup_category_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_category_ID in i_Params_Edit_Setup_category_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup_category(new Params_Delete_Setup_category()
                            {
                                SETUP_CATEGORY_ID = Setup_category_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Delete.Add(Setup_category_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Delete = i_Params_Edit_Setup_category_List.List_To_Delete.Except(i_Params_Edit_Setup_category_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_image_List
        public void Edit_Organization_image_List(Params_Edit_Organization_image_List i_Params_Edit_Organization_image_List)
        {
            var i_Params_Edit_Organization_image_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_image_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_image_List", i_Params_Edit_Organization_image_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_image_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_image_List.List_Failed_Edit = new List<Organization_image>();
                if (i_Params_Edit_Organization_image_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_image in i_Params_Edit_Organization_image_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_image(oOrganization_image);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_image_List.List_Failed_Edit.Add(oOrganization_image);
                        }
                    }
                }
                i_Params_Edit_Organization_image_List.List_To_Edit = i_Params_Edit_Organization_image_List.List_To_Edit.Except(i_Params_Edit_Organization_image_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_image_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_image_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_image_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_image_ID in i_Params_Edit_Organization_image_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_image(new Params_Delete_Organization_image()
                            {
                                ORGANIZATION_IMAGE_ID = Organization_image_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_image_List.List_Failed_Delete.Add(Organization_image_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_image_List.List_To_Delete = i_Params_Edit_Organization_image_List.List_To_Delete.Except(i_Params_Edit_Organization_image_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_image_List", i_Params_Edit_Organization_image_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_relation_List
        public void Edit_Organization_relation_List(Params_Edit_Organization_relation_List i_Params_Edit_Organization_relation_List)
        {
            var i_Params_Edit_Organization_relation_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_relation_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_relation_List", i_Params_Edit_Organization_relation_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_relation_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_relation_List.List_Failed_Edit = new List<Organization_relation>();
                if (i_Params_Edit_Organization_relation_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_relation in i_Params_Edit_Organization_relation_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_relation(oOrganization_relation);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_relation_List.List_Failed_Edit.Add(oOrganization_relation);
                        }
                    }
                }
                i_Params_Edit_Organization_relation_List.List_To_Edit = i_Params_Edit_Organization_relation_List.List_To_Edit.Except(i_Params_Edit_Organization_relation_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_relation_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_relation_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_relation_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_relation_ID in i_Params_Edit_Organization_relation_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_relation(new Params_Delete_Organization_relation()
                            {
                                ORGANIZATION_RELATION_ID = Organization_relation_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_relation_List.List_Failed_Delete.Add(Organization_relation_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_relation_List.List_To_Delete = i_Params_Edit_Organization_relation_List.List_To_Delete.Except(i_Params_Edit_Organization_relation_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_relation_List", i_Params_Edit_Organization_relation_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_List
        public void Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List)
        {
            var i_Params_Edit_Setup_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Edit = new List<Setup>();
                if (i_Params_Edit_Setup_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup in i_Params_Edit_Setup_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup(oSetup);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Edit.Add(oSetup);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Edit = i_Params_Edit_Setup_List.List_To_Edit.Except(i_Params_Edit_Setup_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Setup_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_ID in i_Params_Edit_Setup_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup(new Params_Delete_Setup()
                            {
                                SETUP_ID = Setup_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Delete.Add(Setup_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Delete = i_Params_Edit_Setup_List.List_To_Delete.Except(i_Params_Edit_Setup_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_data_source_kpi_List
        public void Edit_Organization_data_source_kpi_List(Params_Edit_Organization_data_source_kpi_List i_Params_Edit_Organization_data_source_kpi_List)
        {
            var i_Params_Edit_Organization_data_source_kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_data_source_kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_data_source_kpi_List", i_Params_Edit_Organization_data_source_kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Edit = new List<Organization_data_source_kpi>();
                if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_data_source_kpi in i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_data_source_kpi(oOrganization_data_source_kpi);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Edit.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
                i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit = i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit.Except(i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_data_source_kpi_ID in i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_data_source_kpi(new Params_Delete_Organization_data_source_kpi()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Delete.Add(Organization_data_source_kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete = i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete.Except(i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_data_source_kpi_List", i_Params_Edit_Organization_data_source_kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_chart_color_List
        public void Edit_Organization_chart_color_List(Params_Edit_Organization_chart_color_List i_Params_Edit_Organization_chart_color_List)
        {
            var i_Params_Edit_Organization_chart_color_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_chart_color_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_chart_color_List", i_Params_Edit_Organization_chart_color_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_chart_color_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_chart_color_List.List_Failed_Edit = new List<Organization_chart_color>();
                if (i_Params_Edit_Organization_chart_color_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_chart_color in i_Params_Edit_Organization_chart_color_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_chart_color(oOrganization_chart_color);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_chart_color_List.List_Failed_Edit.Add(oOrganization_chart_color);
                        }
                    }
                }
                i_Params_Edit_Organization_chart_color_List.List_To_Edit = i_Params_Edit_Organization_chart_color_List.List_To_Edit.Except(i_Params_Edit_Organization_chart_color_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_chart_color_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_chart_color_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_chart_color_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_chart_color_ID in i_Params_Edit_Organization_chart_color_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_chart_color(new Params_Delete_Organization_chart_color()
                            {
                                ORGANIZATION_CHART_COLOR_ID = Organization_chart_color_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_chart_color_List.List_Failed_Delete.Add(Organization_chart_color_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_chart_color_List.List_To_Delete = i_Params_Edit_Organization_chart_color_List.List_To_Delete.Except(i_Params_Edit_Organization_chart_color_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_chart_color_List", i_Params_Edit_Organization_chart_color_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_districtnex_module_List
        public void Edit_Organization_districtnex_module_List(Params_Edit_Organization_districtnex_module_List i_Params_Edit_Organization_districtnex_module_List)
        {
            var i_Params_Edit_Organization_districtnex_module_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_districtnex_module_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_districtnex_module_List", i_Params_Edit_Organization_districtnex_module_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_districtnex_module_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_districtnex_module_List.List_Failed_Edit = new List<Organization_districtnex_module>();
                if (i_Params_Edit_Organization_districtnex_module_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_districtnex_module in i_Params_Edit_Organization_districtnex_module_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_districtnex_module(oOrganization_districtnex_module);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_districtnex_module_List.List_Failed_Edit.Add(oOrganization_districtnex_module);
                        }
                    }
                }
                i_Params_Edit_Organization_districtnex_module_List.List_To_Edit = i_Params_Edit_Organization_districtnex_module_List.List_To_Edit.Except(i_Params_Edit_Organization_districtnex_module_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_districtnex_module_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_districtnex_module_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_districtnex_module_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_districtnex_module_ID in i_Params_Edit_Organization_districtnex_module_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_districtnex_module(new Params_Delete_Organization_districtnex_module()
                            {
                                ORGANIZATION_DISTRICTNEX_MODULE_ID = Organization_districtnex_module_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_districtnex_module_List.List_Failed_Delete.Add(Organization_districtnex_module_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_districtnex_module_List.List_To_Delete = i_Params_Edit_Organization_districtnex_module_List.List_To_Delete.Except(i_Params_Edit_Organization_districtnex_module_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_districtnex_module_List", i_Params_Edit_Organization_districtnex_module_List_json, false);
            }
        }
        #endregion
    }
}