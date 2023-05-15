using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv
        public Organization_theme Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv(Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID)
        {
            Organization_theme oOrganization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_theme oDBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID.ORGANIZATION_THEME_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_theme").Replace("%2", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID.ORGANIZATION_THEME_ID.ToString()));
            }
            oOrganization_theme = new Organization_theme();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
            oOrganization_theme.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_json, false);
            }
            return oOrganization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_Adv
        public Organization Get_Organization_By_ORGANIZATION_ID_Adv(Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID)
        {
            Organization oOrganization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            DALC.Organization oDBEntry = _AppContext.Get_Organization_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization").Replace("%2", i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID.ToString()));
            }
            oOrganization = new Organization();
            Props.Copy_Prop_Values(oDBEntry, oOrganization);
            oOrganization.Organization_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_json, false);
            }
            return oOrganization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv
        public Organization_level_access Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID)
        {
            Organization_level_access oOrganization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_level_access oDBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID.ORGANIZATION_LEVEL_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_level_access").Replace("%2", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID.ORGANIZATION_LEVEL_ACCESS_ID.ToString()));
            }
            oOrganization_level_access = new Organization_level_access();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
            oOrganization_level_access.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
            oOrganization_level_access.Data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json, false);
            }
            return oOrganization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv
        public Organization_log_config Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv(Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID)
        {
            Organization_log_config oOrganization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_log_config oDBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID.ORGANIZATION_LOG_CONFIG_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_log_config").Replace("%2", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID.ORGANIZATION_LOG_CONFIG_ID.ToString()));
            }
            oOrganization_log_config = new Organization_log_config();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
            oOrganization_log_config.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
            oOrganization_log_config.Log_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_json, false);
            }
            return oOrganization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv
        public Organization_color_scheme Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID)
        {
            Organization_color_scheme oOrganization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_color_scheme oDBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_color_scheme").Replace("%2", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID.ToString()));
            }
            oOrganization_color_scheme = new Organization_color_scheme();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
            oOrganization_color_scheme.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            return oOrganization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv
        public Organization_image Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv(Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID)
        {
            Organization_image oOrganization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_image oDBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID.ORGANIZATION_IMAGE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_image").Replace("%2", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID.ORGANIZATION_IMAGE_ID.ToString()));
            }
            oOrganization_image = new Organization_image();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
            oOrganization_image.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
            oOrganization_image.Image_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_json, false);
            }
            return oOrganization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv
        public Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID)
        {
            Organization_relation oOrganization_relation = null;
            var i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_relation oDBEntry = _AppContext.Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID.ORGANIZATION_RELATION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_relation").Replace("%2", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID.ORGANIZATION_RELATION_ID.ToString()));
            }
            oOrganization_relation = new Organization_relation();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
            oOrganization_relation.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json, false);
            }
            return oOrganization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID_Adv(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            oSetup.Setup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_data_source_kpi oDBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_data_source_kpi").Replace("%2", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID.ToString()));
            }
            oOrganization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
            oOrganization_data_source_kpi.Data_source = new Data_source();
            Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
            oOrganization_data_source_kpi.Kpi = new Kpi();
            Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
            oOrganization_data_source_kpi.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv
        public Organization_chart_color Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv(Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID)
        {
            Organization_chart_color oOrganization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_chart_color oDBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID.ORGANIZATION_CHART_COLOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_chart_color").Replace("%2", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID.ORGANIZATION_CHART_COLOR_ID.ToString()));
            }
            oOrganization_chart_color = new Organization_chart_color();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
            oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
            Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
            oOrganization_chart_color.Data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_json, false);
            }
            return oOrganization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv
        public Organization_districtnex_module Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv(Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID)
        {
            Organization_districtnex_module oOrganization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_districtnex_module oDBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID.ORGANIZATION_DISTRICTNEX_MODULE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_districtnex_module").Replace("%2", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID.ORGANIZATION_DISTRICTNEX_MODULE_ID.ToString()));
            }
            oOrganization_districtnex_module = new Organization_districtnex_module();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
            oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
            Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
            oOrganization_districtnex_module.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oOrganization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv(Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv(i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List.ORGANIZATION_THEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv(Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv(i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List.ORGANIZATION_LOG_CONFIG_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List.ORGANIZATION_COLOR_SCHEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv(Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv(i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List.ORGANIZATION_IMAGE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List.ORGANIZATION_RELATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List_Adv(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv(Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv(i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List.ORGANIZATION_CHART_COLOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv(Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List.ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_Adv
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_Adv(Params_Get_Organization_theme_By_ORGANIZATION_ID i_Params_Get_Organization_theme_By_ORGANIZATION_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_Adv
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID_Adv(Params_Get_Organization_theme_By_OWNER_ID i_Params_Get_Organization_theme_By_OWNER_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_OWNER_ID_Adv", i_Params_Get_Organization_theme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_OWNER_ID_Adv(i_Params_Get_Organization_theme_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_OWNER_ID_Adv", i_Params_Get_Organization_theme_By_OWNER_ID_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_By_OWNER_ID_IS_DELETED)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_Adv
        public List<Organization> Get_Organization_By_OWNER_ID_Adv(Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_OWNER_ID_Adv", i_Params_Get_Organization_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_OWNER_ID_Adv(i_Params_Get_Organization_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_OWNER_ID_Adv", i_Params_Get_Organization_By_OWNER_ID_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID.ORGANIZATION_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_Adv(Params_Get_Organization_level_access_By_OWNER_ID i_Params_Get_Organization_level_access_By_OWNER_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_OWNER_ID_Adv", i_Params_Get_Organization_level_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_OWNER_ID_Adv(i_Params_Get_Organization_level_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_OWNER_ID_Adv", i_Params_Get_Organization_level_access_By_OWNER_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_Adv(Params_Get_Organization_level_access_By_ORGANIZATION_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_Adv(Params_Get_Organization_level_access_By_LEVEL_ID i_Params_Get_Organization_level_access_By_LEVEL_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_LEVEL_ID_Adv", i_Params_Get_Organization_level_access_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_LEVEL_ID_Adv(i_Params_Get_Organization_level_access_By_LEVEL_ID.LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_LEVEL_ID_Adv", i_Params_Get_Organization_level_access_By_LEVEL_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID, i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_Adv(Params_Get_Organization_log_config_By_OWNER_ID i_Params_Get_Organization_log_config_By_OWNER_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_OWNER_ID_Adv", i_Params_Get_Organization_log_config_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_OWNER_ID_Adv(i_Params_Get_Organization_log_config_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_OWNER_ID_Adv", i_Params_Get_Organization_log_config_By_OWNER_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_Adv(Params_Get_Organization_log_config_By_ORGANIZATION_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv(Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv(Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID, i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_Adv(Params_Get_Organization_color_scheme_By_OWNER_ID i_Params_Get_Organization_color_scheme_By_OWNER_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_OWNER_ID_Adv", i_Params_Get_Organization_color_scheme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_OWNER_ID_Adv(i_Params_Get_Organization_color_scheme_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_OWNER_ID_Adv", i_Params_Get_Organization_color_scheme_By_OWNER_ID_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID_Adv
        public List<Organization_image> Get_Organization_image_By_OWNER_ID_Adv(Params_Get_Organization_image_By_OWNER_ID i_Params_Get_Organization_image_By_OWNER_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_OWNER_ID_Adv", i_Params_Get_Organization_image_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_OWNER_ID_Adv(i_Params_Get_Organization_image_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_OWNER_ID_Adv", i_Params_Get_Organization_image_By_OWNER_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_Adv(Params_Get_Organization_image_By_ORGANIZATION_ID i_Params_Get_Organization_image_By_ORGANIZATION_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv(Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_image> Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_image_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv(Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv(i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.ORGANIZATION_ID, i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_Adv(Params_Get_Organization_relation_By_OWNER_ID i_Params_Get_Organization_relation_By_OWNER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_OWNER_ID_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_OWNER_ID_Adv(i_Params_Get_Organization_relation_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_OWNER_ID_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID.CHILD_ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_Adv(Params_Get_Organization_relation_By_USER_ID i_Params_Get_Organization_relation_By_USER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_USER_ID_Adv", i_Params_Get_Organization_relation_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_USER_ID_Adv(i_Params_Get_Organization_relation_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_USER_ID_Adv", i_Params_Get_Organization_relation_By_USER_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
                oSetup.Setup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_Adv(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_Adv(Params_Get_Organization_data_source_kpi_By_OWNER_ID i_Params_Get_Organization_data_source_kpi_By_OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_Adv(Params_Get_Organization_data_source_kpi_By_KPI_ID i_Params_Get_Organization_data_source_kpi_By_KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_KPI_ID.KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_Adv(Params_Get_Organization_chart_color_By_OWNER_ID i_Params_Get_Organization_chart_color_By_OWNER_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_OWNER_ID_Adv", i_Params_Get_Organization_chart_color_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_OWNER_ID_Adv(i_Params_Get_Organization_chart_color_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_OWNER_ID_Adv", i_Params_Get_Organization_chart_color_By_OWNER_ID_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID.ORGANIZATION_COLOR_SCHEME_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_Adv(Params_Get_Organization_districtnex_module_By_OWNER_ID i_Params_Get_Organization_districtnex_module_By_OWNER_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_OWNER_ID_Adv", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_OWNER_ID_Adv(i_Params_Get_Organization_districtnex_module_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_OWNER_ID_Adv", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_List_Adv
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_theme_By_ORGANIZATION_ID_List i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List)
        {
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_theme_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List.ORGANIZATION_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_level_access_By_ORGANIZATION_ID_List i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_level_access_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_List_Adv(Params_Get_Organization_level_access_By_LEVEL_ID_List i_Params_Get_Organization_level_access_By_LEVEL_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_LEVEL_ID_List_Adv", i_Params_Get_Organization_level_access_By_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_LEVEL_ID_List_Adv(i_Params_Get_Organization_level_access_By_LEVEL_ID_List.LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_LEVEL_ID_List_Adv", i_Params_Get_Organization_level_access_By_LEVEL_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_log_config_By_ORGANIZATION_ID_List i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_log_config_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv(Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv(i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List.LOG_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv
            if (OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv != null)
            {
                OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv
            if (OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv != null)
            {
                OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(oList_Organization_color_scheme, i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_List_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_image_By_ORGANIZATION_ID_List i_Params_Get_Organization_image_By_ORGANIZATION_ID_List)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_image_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List)
        {
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List.IMAGE_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List.PARENT_ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List.CHILD_ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_List_Adv(Params_Get_Organization_relation_By_USER_ID_List i_Params_Get_Organization_relation_By_USER_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_USER_ID_List_Adv", i_Params_Get_Organization_relation_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_USER_ID_List_Adv(i_Params_Get_Organization_relation_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_USER_ID_List_Adv", i_Params_Get_Organization_relation_By_USER_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List.DATA_SOURCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List.ORGANIZATION_COLOR_SCHEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv", i_Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where_Adv
        public List<Organization_theme> Get_Organization_theme_By_Where_Adv(Params_Get_Organization_theme_By_Where i_Params_Get_Organization_theme_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_Where_Adv", i_Params_Get_Organization_theme_By_Where_json, false);
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
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_Where_Adv(i_Params_Get_Organization_theme_By_Where.THEME_NAME, i_Params_Get_Organization_theme_By_Where.THEME_CLASS, i_Params_Get_Organization_theme_By_Where.OWNER_ID, i_Params_Get_Organization_theme_By_Where.OFFSET, i_Params_Get_Organization_theme_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            i_Params_Get_Organization_theme_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_Where_Adv", i_Params_Get_Organization_theme_By_Where_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where_Adv
        public List<Organization> Get_Organization_By_Where_Adv(Params_Get_Organization_By_Where i_Params_Get_Organization_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_Where_Adv", i_Params_Get_Organization_By_Where_json, false);
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
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_Where_Adv(i_Params_Get_Organization_By_Where.ORGANIZATION_NAME, i_Params_Get_Organization_By_Where.ORGANIZATION_EMAIL, i_Params_Get_Organization_By_Where.ORGANIZATION_PHONE_NUMBER, i_Params_Get_Organization_By_Where.ORGANIZATION_ADDRESS, i_Params_Get_Organization_By_Where.OWNER_ID, i_Params_Get_Organization_By_Where.OFFSET, i_Params_Get_Organization_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            i_Params_Get_Organization_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_Where_Adv", i_Params_Get_Organization_By_Where_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_Where_Adv(Params_Get_Organization_level_access_By_Where i_Params_Get_Organization_level_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_Where_Adv", i_Params_Get_Organization_level_access_By_Where_json, false);
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
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_Where_Adv(i_Params_Get_Organization_level_access_By_Where.DESCRIPTION, i_Params_Get_Organization_level_access_By_Where.OWNER_ID, i_Params_Get_Organization_level_access_By_Where.OFFSET, i_Params_Get_Organization_level_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            i_Params_Get_Organization_level_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_Where_Adv", i_Params_Get_Organization_level_access_By_Where_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_Where_Adv(Params_Get_Organization_log_config_By_Where i_Params_Get_Organization_log_config_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_Where_Adv", i_Params_Get_Organization_log_config_By_Where_json, false);
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
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_Where_Adv(i_Params_Get_Organization_log_config_By_Where.DESCRIPTION, i_Params_Get_Organization_log_config_By_Where.OWNER_ID, i_Params_Get_Organization_log_config_By_Where.OFFSET, i_Params_Get_Organization_log_config_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            i_Params_Get_Organization_log_config_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_Where_Adv", i_Params_Get_Organization_log_config_By_Where_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_Adv(Params_Get_Organization_color_scheme_By_Where i_Params_Get_Organization_color_scheme_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_Where_Adv", i_Params_Get_Organization_color_scheme_By_Where_json, false);
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
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_Where_Adv(i_Params_Get_Organization_color_scheme_By_Where.PLATFORM_PRIMARY, i_Params_Get_Organization_color_scheme_By_Where.PLATFORM_BUTTON, i_Params_Get_Organization_color_scheme_By_Where.OWNER_ID, i_Params_Get_Organization_color_scheme_By_Where.OFFSET, i_Params_Get_Organization_color_scheme_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            i_Params_Get_Organization_color_scheme_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_Where_Adv", i_Params_Get_Organization_color_scheme_By_Where_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_Where_Adv
        public List<Organization_image> Get_Organization_image_By_Where_Adv(Params_Get_Organization_image_By_Where i_Params_Get_Organization_image_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_Where_Adv", i_Params_Get_Organization_image_By_Where_json, false);
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
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_Where_Adv(i_Params_Get_Organization_image_By_Where.IMAGE_NAME, i_Params_Get_Organization_image_By_Where.IMAGE_EXTENSION, i_Params_Get_Organization_image_By_Where.OWNER_ID, i_Params_Get_Organization_image_By_Where.OFFSET, i_Params_Get_Organization_image_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            i_Params_Get_Organization_image_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_Where_Adv", i_Params_Get_Organization_image_By_Where_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where_Adv
        public List<Organization_relation> Get_Organization_relation_By_Where_Adv(Params_Get_Organization_relation_By_Where i_Params_Get_Organization_relation_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_Where_Adv", i_Params_Get_Organization_relation_By_Where_json, false);
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
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_Where_Adv(i_Params_Get_Organization_relation_By_Where.DESCRIPTION, i_Params_Get_Organization_relation_By_Where.OWNER_ID, i_Params_Get_Organization_relation_By_Where.OFFSET, i_Params_Get_Organization_relation_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            i_Params_Get_Organization_relation_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_Where_Adv", i_Params_Get_Organization_relation_By_Where_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_Adv(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_Adv(Params_Get_Organization_data_source_kpi_By_Where i_Params_Get_Organization_data_source_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
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
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where_Adv(i_Params_Get_Organization_data_source_kpi_By_Where.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where_Adv(Params_Get_Organization_chart_color_By_Where i_Params_Get_Organization_chart_color_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_Where_Adv", i_Params_Get_Organization_chart_color_By_Where_json, false);
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
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_Where_Adv(i_Params_Get_Organization_chart_color_By_Where.COLOR, i_Params_Get_Organization_chart_color_By_Where.OWNER_ID, i_Params_Get_Organization_chart_color_By_Where.OFFSET, i_Params_Get_Organization_chart_color_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            i_Params_Get_Organization_chart_color_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_Where_Adv", i_Params_Get_Organization_chart_color_By_Where_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_Adv(Params_Get_Organization_districtnex_module_By_Where i_Params_Get_Organization_districtnex_module_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_Where_Adv", i_Params_Get_Organization_districtnex_module_By_Where_json, false);
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
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_Where_Adv(i_Params_Get_Organization_districtnex_module_By_Where.DESCRIPTION, i_Params_Get_Organization_districtnex_module_By_Where.OWNER_ID, i_Params_Get_Organization_districtnex_module_By_Where.OFFSET, i_Params_Get_Organization_districtnex_module_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            i_Params_Get_Organization_districtnex_module_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_Where_Adv", i_Params_Get_Organization_districtnex_module_By_Where_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where_In_List_Adv
        public List<Organization_theme> Get_Organization_theme_By_Where_In_List_Adv(Params_Get_Organization_theme_By_Where_In_List i_Params_Get_Organization_theme_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_theme> oList_Organization_theme = null;
            var i_Params_Get_Organization_theme_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_theme_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_theme_By_Where_In_List_Adv", i_Params_Get_Organization_theme_By_Where_In_List_json, false);
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
            List<DALC.Organization_theme> oList_DBEntry = _AppContext.Get_Organization_theme_By_Where_In_List_Adv(i_Params_Get_Organization_theme_By_Where_In_List.THEME_NAME, i_Params_Get_Organization_theme_By_Where_In_List.THEME_CLASS, i_Params_Get_Organization_theme_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_theme_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_theme_By_Where_In_List.OFFSET, i_Params_Get_Organization_theme_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_theme.Organization);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            i_Params_Get_Organization_theme_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_theme_By_Where_In_List_Adv", i_Params_Get_Organization_theme_By_Where_In_List_json, false);
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where_In_List_Adv
        public List<Organization> Get_Organization_By_Where_In_List_Adv(Params_Get_Organization_By_Where_In_List i_Params_Get_Organization_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_Where_In_List_Adv", i_Params_Get_Organization_By_Where_In_List_json, false);
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
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_Where_In_List_Adv(i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_NAME, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_EMAIL, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_PHONE_NUMBER, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_ADDRESS, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_By_Where_In_List.OFFSET, i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            i_Params_Get_Organization_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_Where_In_List_Adv", i_Params_Get_Organization_By_Where_In_List_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where_In_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_Where_In_List_Adv(Params_Get_Organization_level_access_By_Where_In_List i_Params_Get_Organization_level_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_level_access> oList_Organization_level_access = null;
            var i_Params_Get_Organization_level_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_level_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_level_access_By_Where_In_List_Adv", i_Params_Get_Organization_level_access_By_Where_In_List_json, false);
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
            List<DALC.Organization_level_access> oList_DBEntry = _AppContext.Get_Organization_level_access_By_Where_In_List_Adv(i_Params_Get_Organization_level_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_level_access_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Organization_level_access_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_level_access_By_Where_In_List.OFFSET, i_Params_Get_Organization_level_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_level_access.Organization);
                        oOrganization_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_level_access.Data_level_setup);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            i_Params_Get_Organization_level_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_level_access_By_Where_In_List_Adv", i_Params_Get_Organization_level_access_By_Where_In_List_json, false);
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where_In_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_Where_In_List_Adv(Params_Get_Organization_log_config_By_Where_In_List i_Params_Get_Organization_log_config_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_log_config> oList_Organization_log_config = null;
            var i_Params_Get_Organization_log_config_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_log_config_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_log_config_By_Where_In_List_Adv", i_Params_Get_Organization_log_config_By_Where_In_List_json, false);
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
            List<DALC.Organization_log_config> oList_DBEntry = _AppContext.Get_Organization_log_config_By_Where_In_List_Adv(i_Params_Get_Organization_log_config_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_log_config_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_log_config_By_Where_In_List.LOG_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_log_config_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_log_config_By_Where_In_List.OFFSET, i_Params_Get_Organization_log_config_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_log_config.Organization);
                        oOrganization_log_config.Log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Log_type_setup, oOrganization_log_config.Log_type_setup);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            i_Params_Get_Organization_log_config_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_log_config_By_Where_In_List_Adv", i_Params_Get_Organization_log_config_By_Where_In_List_json, false);
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where_In_List_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_In_List_Adv(Params_Get_Organization_color_scheme_By_Where_In_List i_Params_Get_Organization_color_scheme_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            var i_Params_Get_Organization_color_scheme_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_color_scheme_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_color_scheme_By_Where_In_List_Adv", i_Params_Get_Organization_color_scheme_By_Where_In_List_json, false);
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
            List<DALC.Organization_color_scheme> oList_DBEntry = _AppContext.Get_Organization_color_scheme_By_Where_In_List_Adv(i_Params_Get_Organization_color_scheme_By_Where_In_List.PLATFORM_PRIMARY, i_Params_Get_Organization_color_scheme_By_Where_In_List.PLATFORM_BUTTON, i_Params_Get_Organization_color_scheme_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_color_scheme_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_color_scheme_By_Where_In_List.OFFSET, i_Params_Get_Organization_color_scheme_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_color_scheme.Organization);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            i_Params_Get_Organization_color_scheme_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_color_scheme_By_Where_In_List_Adv", i_Params_Get_Organization_color_scheme_By_Where_In_List_json, false);
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_Where_In_List_Adv
        public List<Organization_image> Get_Organization_image_By_Where_In_List_Adv(Params_Get_Organization_image_By_Where_In_List i_Params_Get_Organization_image_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_image> oList_Organization_image = null;
            var i_Params_Get_Organization_image_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_image_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_image_By_Where_In_List_Adv", i_Params_Get_Organization_image_By_Where_In_List_json, false);
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
            List<DALC.Organization_image> oList_DBEntry = _AppContext.Get_Organization_image_By_Where_In_List_Adv(i_Params_Get_Organization_image_By_Where_In_List.IMAGE_NAME, i_Params_Get_Organization_image_By_Where_In_List.IMAGE_EXTENSION, i_Params_Get_Organization_image_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_image_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_image_By_Where_In_List.OFFSET, i_Params_Get_Organization_image_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_image.Organization);
                        oOrganization_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oOrganization_image.Image_type_setup);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            i_Params_Get_Organization_image_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_image_By_Where_In_List_Adv", i_Params_Get_Organization_image_By_Where_In_List_json, false);
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where_In_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_Where_In_List_Adv(Params_Get_Organization_relation_By_Where_In_List i_Params_Get_Organization_relation_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_Where_In_List_Adv", i_Params_Get_Organization_relation_By_Where_In_List_json, false);
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
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_Where_In_List_Adv(i_Params_Get_Organization_relation_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST, i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_relation_By_Where_In_List.OFFSET, i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            i_Params_Get_Organization_relation_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_Where_In_List_Adv", i_Params_Get_Organization_relation_By_Where_In_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List_Adv(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List_Adv(Params_Get_Organization_data_source_kpi_By_Where_In_List i_Params_Get_Organization_data_source_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where_In_List_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
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
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where_In_List_Adv(i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where_In_List_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where_In_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where_In_List_Adv(Params_Get_Organization_chart_color_By_Where_In_List i_Params_Get_Organization_chart_color_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_chart_color> oList_Organization_chart_color = null;
            var i_Params_Get_Organization_chart_color_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_chart_color_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_chart_color_By_Where_In_List_Adv", i_Params_Get_Organization_chart_color_By_Where_In_List_json, false);
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
            List<DALC.Organization_chart_color> oList_DBEntry = _AppContext.Get_Organization_chart_color_By_Where_In_List_Adv(i_Params_Get_Organization_chart_color_By_Where_In_List.COLOR, i_Params_Get_Organization_chart_color_By_Where_In_List.ORGANIZATION_COLOR_SCHEME_ID_LIST, i_Params_Get_Organization_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Organization_chart_color_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_chart_color_By_Where_In_List.OFFSET, i_Params_Get_Organization_chart_color_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_color_scheme, oOrganization_chart_color.Organization_color_scheme);
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oOrganization_chart_color.Data_level_setup);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            i_Params_Get_Organization_chart_color_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_chart_color_By_Where_In_List_Adv", i_Params_Get_Organization_chart_color_By_Where_In_List_json, false);
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where_In_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_In_List_Adv(Params_Get_Organization_districtnex_module_By_Where_In_List i_Params_Get_Organization_districtnex_module_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            var i_Params_Get_Organization_districtnex_module_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_districtnex_module_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_districtnex_module_By_Where_In_List_Adv", i_Params_Get_Organization_districtnex_module_By_Where_In_List_json, false);
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
            List<DALC.Organization_districtnex_module> oList_DBEntry = _AppContext.Get_Organization_districtnex_module_By_Where_In_List_Adv(i_Params_Get_Organization_districtnex_module_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_districtnex_module_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST, i_Params_Get_Organization_districtnex_module_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_districtnex_module_By_Where_In_List.OFFSET, i_Params_Get_Organization_districtnex_module_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oOrganization_districtnex_module.Districtnex_module);
                        oOrganization_districtnex_module.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_districtnex_module.Organization);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            i_Params_Get_Organization_districtnex_module_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_districtnex_module_By_Where_In_List_Adv", i_Params_Get_Organization_districtnex_module_By_Where_In_List_json, false);
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
    }
}
