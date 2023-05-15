using System;
using SmartrTools;
using System.Data;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace DALC
{
    public partial class MSSQL_DALC : DALC
    {
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID
        public Organization_theme Get_Organization_theme_By_ORGANIZATION_THEME_ID(int? ORGANIZATION_THEME_ID)
        {
            Organization_theme oOrganization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_THEME_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_theme = new Organization_theme();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_theme);
            }
            return oOrganization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID
        public Organization Get_Organization_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            Organization oOrganization = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization = new Organization();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization);
            }
            return oOrganization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        public Organization_level_access Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(long? ORGANIZATION_LEVEL_ACCESS_ID)
        {
            Organization_level_access oOrganization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_level_access = new Organization_level_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_level_access);
            }
            return oOrganization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID
        public Organization_log_config Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID(long? ORGANIZATION_LOG_CONFIG_ID)
        {
            Organization_log_config oOrganization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_LOG_CONFIG_ID = ORGANIZATION_LOG_CONFIG_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_LOG_CONFIG_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_log_config = new Organization_log_config();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_log_config);
            }
            return oOrganization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID
        public Organization_color_scheme Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID(int? ORGANIZATION_COLOR_SCHEME_ID)
        {
            Organization_color_scheme oOrganization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_COLOR_SCHEME_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_color_scheme = new Organization_color_scheme();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_color_scheme);
            }
            return oOrganization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID
        public Organization_image Get_Organization_image_By_ORGANIZATION_IMAGE_ID(int? ORGANIZATION_IMAGE_ID)
        {
            Organization_image oOrganization_image = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_IMAGE_ID = ORGANIZATION_IMAGE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_IMAGE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_image = new Organization_image();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_image);
            }
            return oOrganization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID
        public Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID(int? ORGANIZATION_RELATION_ID)
        {
            Organization_relation oOrganization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_ORGANIZATION_RELATION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_relation = new Organization_relation();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_relation);
            }
            return oOrganization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_data_source_kpi = new Organization_data_source_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_data_source_kpi);
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID
        public Organization_chart_color Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID(int? ORGANIZATION_CHART_COLOR_ID)
        {
            Organization_chart_color oOrganization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_CHART_COLOR_ID = ORGANIZATION_CHART_COLOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_CHART_COLOR_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_chart_color = new Organization_chart_color();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_chart_color);
            }
            return oOrganization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID
        public Organization_districtnex_module Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID(int? ORGANIZATION_DISTRICTNEX_MODULE_ID)
        {
            Organization_districtnex_module oOrganization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DISTRICTNEX_MODULE_ID = ORGANIZATION_DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_DISTRICTNEX_MODULE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_districtnex_module = new Organization_districtnex_module();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_districtnex_module);
            }
            return oOrganization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_List
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_THEME_ID_List(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST)
        {
            List<Organization_theme> oList_Organization_theme = null;
            if (ORGANIZATION_THEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_THEME_ID_LIST = string.Join(",", ORGANIZATION_THEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_THEME_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_theme = new List<Organization_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_theme oOrganization_theme = new Organization_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                            oList_Organization_theme.Add(oOrganization_theme);
                        }
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List
        public List<Organization> Get_Organization_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization> oList_Organization = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization = new List<Organization>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization oOrganization = new Organization();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                            oList_Organization.Add(oOrganization);
                        }
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (ORGANIZATION_LEVEL_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_LEVEL_ACCESS_ID_LIST = string.Join(",", ORGANIZATION_LEVEL_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List(IEnumerable<long?> ORGANIZATION_LOG_CONFIG_ID_LIST)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            if (ORGANIZATION_LOG_CONFIG_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_LOG_CONFIG_ID_LIST = string.Join(",", ORGANIZATION_LOG_CONFIG_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_LOG_CONFIG_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_log_config = new List<Organization_log_config>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_log_config oOrganization_log_config = new Organization_log_config();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                            oList_Organization_log_config.Add(oOrganization_log_config);
                        }
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            if (ORGANIZATION_COLOR_SCHEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_COLOR_SCHEME_ID_LIST = string.Join(",", ORGANIZATION_COLOR_SCHEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_COLOR_SCHEME_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_color_scheme = new List<Organization_color_scheme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                            oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                        }
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup_category> oList_Setup_category = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup_category = new List<Setup_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup_category oSetup_category = new Setup_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                            oList_Setup_category.Add(oSetup_category);
                        }
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List(IEnumerable<int?> ORGANIZATION_IMAGE_ID_LIST)
        {
            List<Organization_image> oList_Organization_image = null;
            if (ORGANIZATION_IMAGE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_IMAGE_ID_LIST = string.Join(",", ORGANIZATION_IMAGE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_IMAGE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_image = new List<Organization_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_image oOrganization_image = new Organization_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                            oList_Organization_image.Add(oOrganization_image);
                        }
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (ORGANIZATION_RELATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_RELATION_ID_LIST = string.Join(",", ORGANIZATION_RELATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_ORGANIZATION_RELATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List(IEnumerable<int?> ORGANIZATION_CHART_COLOR_ID_LIST)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            if (ORGANIZATION_CHART_COLOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_CHART_COLOR_ID_LIST = string.Join(",", ORGANIZATION_CHART_COLOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_CHART_COLOR_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_chart_color = new List<Organization_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                            oList_Organization_chart_color.Add(oOrganization_chart_color);
                        }
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            if (ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST = string.Join(",", ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                            oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                        }
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_IS_DELETED
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_IS_DELETED
        public List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID
        public List<Organization> Get_Organization_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID(long? ORGANIZATION_TYPE_SETUP_ID)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_TYPE_SETUP_ID = ORGANIZATION_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_IS_DELETED
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID(long? LEVEL_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.LEVEL_ID = LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(int? ORGANIZATION_ID, long? DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID(long? LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_LOG_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_IS_DELETED
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            _params.LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID
        public List<Organization_image> Get_Organization_image_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_IMAGE_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID_IS_DELETED
        public List<Organization_image> Get_Organization_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            _params.IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID
        public List<Organization_relation> Get_Organization_relation_By_USER_ID(long? USER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_SOURCE_ID = DATA_SOURCE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(int? ORGANIZATION_COLOR_SCHEME_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_COLOR_SCHEME_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_IS_DELETED
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_List
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_theme> oList_Organization_theme = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_theme = new List<Organization_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_theme oOrganization_theme = new Organization_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                            oList_Organization_theme.Add(oOrganization_theme);
                        }
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List(IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST)
        {
            List<Organization> oList_Organization = null;
            if (ORGANIZATION_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_TYPE_SETUP_ID_LIST = string.Join(",", ORGANIZATION_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization = new List<Organization>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization oOrganization = new Organization();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                            oList_Organization.Add(oOrganization);
                        }
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LEVEL_ID_LIST = string.Join(",", LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_List
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_log_config = new List<Organization_log_config>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_log_config oOrganization_log_config = new Organization_log_config();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                            oList_Organization_log_config.Add(oOrganization_log_config);
                        }
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List(IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            if (LOG_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LOG_TYPE_SETUP_ID_LIST = string.Join(",", LOG_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_LOG_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_log_config = new List<Organization_log_config>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_log_config oOrganization_log_config = new Organization_log_config();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                            oList_Organization_log_config.Add(oOrganization_log_config);
                        }
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_color_scheme = new List<Organization_color_scheme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                            oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                        }
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_List
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_image> oList_Organization_image = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_image = new List<Organization_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_image oOrganization_image = new Organization_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                            oList_Organization_image.Add(oOrganization_image);
                        }
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST)
        {
            List<Organization_image> oList_Organization_image = null;
            if (IMAGE_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.IMAGE_TYPE_SETUP_ID_LIST = string.Join(",", IMAGE_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_IMAGE_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_image = new List<Organization_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_image oOrganization_image = new Organization_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                            oList_Organization_image.Add(oOrganization_image);
                        }
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (PARENT_ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.PARENT_ORGANIZATION_ID_LIST = string.Join(",", PARENT_ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (CHILD_ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.CHILD_ORGANIZATION_ID_LIST = string.Join(",", CHILD_ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_List
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(IEnumerable<int?> DATA_SOURCE_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (DATA_SOURCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_SOURCE_ID_LIST = string.Join(",", DATA_SOURCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            if (ORGANIZATION_COLOR_SCHEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_COLOR_SCHEME_ID_LIST = string.Join(",", ORGANIZATION_COLOR_SCHEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_COLOR_SCHEME_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_chart_color = new List<Organization_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                            oList_Organization_chart_color.Add(oOrganization_chart_color);
                        }
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_chart_color = new List<Organization_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                            oList_Organization_chart_color.Add(oOrganization_chart_color);
                        }
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                            oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                        }
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            if (DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICTNEX_MODULE_ID_LIST = string.Join(",", DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                            oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                        }
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where
        public List<Organization_theme> Get_Organization_theme_By_Where(string THEME_NAME, string THEME_CLASS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.THEME_NAME = THEME_NAME;
            _params.THEME_CLASS = THEME_CLASS;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where
        public List<Organization> Get_Organization_By_Where(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_NAME = ORGANIZATION_NAME;
            _params.ORGANIZATION_EMAIL = ORGANIZATION_EMAIL;
            _params.ORGANIZATION_PHONE_NUMBER = ORGANIZATION_PHONE_NUMBER;
            _params.ORGANIZATION_ADDRESS = ORGANIZATION_ADDRESS;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where
        public List<Organization_level_access> Get_Organization_level_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where
        public List<Organization_log_config> Get_Organization_log_config_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.PLATFORM_PRIMARY = PLATFORM_PRIMARY;
            _params.PLATFORM_BUTTON = PLATFORM_BUTTON;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup_category;
        }
        #endregion
        #region Get_Organization_image_By_Where
        public List<Organization_image> Get_Organization_image_By_Where(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_NAME = IMAGE_NAME;
            _params.IMAGE_EXTENSION = IMAGE_EXTENSION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where
        public List<Organization_relation> Get_Organization_relation_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.COLOR = COLOR;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where_In_List
        public List<Organization_theme> Get_Organization_theme_By_Where_In_List(string THEME_NAME, string THEME_CLASS, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.THEME_NAME = THEME_NAME;
            _params.THEME_CLASS = THEME_CLASS;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where_In_List
        public List<Organization> Get_Organization_By_Where_In_List(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_NAME = ORGANIZATION_NAME;
            _params.ORGANIZATION_EMAIL = ORGANIZATION_EMAIL;
            _params.ORGANIZATION_PHONE_NUMBER = ORGANIZATION_PHONE_NUMBER;
            _params.ORGANIZATION_ADDRESS = ORGANIZATION_ADDRESS;
            _params.ORGANIZATION_TYPE_SETUP_ID_LIST = ORGANIZATION_TYPE_SETUP_ID_LIST != null ? string.Join(",", ORGANIZATION_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where_In_List
        public List<Organization_level_access> Get_Organization_level_access_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where_In_List
        public List<Organization_log_config> Get_Organization_log_config_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.LOG_TYPE_SETUP_ID_LIST = LOG_TYPE_SETUP_ID_LIST != null ? string.Join(",", LOG_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where_In_List
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_In_List(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.PLATFORM_PRIMARY = PLATFORM_PRIMARY;
            _params.PLATFORM_BUTTON = PLATFORM_BUTTON;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_Where_In_List
        public List<Organization_image> Get_Organization_image_By_Where_In_List(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_NAME = IMAGE_NAME;
            _params.IMAGE_EXTENSION = IMAGE_EXTENSION;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.IMAGE_TYPE_SETUP_ID_LIST = IMAGE_TYPE_SETUP_ID_LIST != null ? string.Join(",", IMAGE_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where_In_List
        public List<Organization_relation> Get_Organization_relation_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.SETUP_CATEGORY_ID_LIST = SETUP_CATEGORY_ID_LIST != null ? string.Join(",", SETUP_CATEGORY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.DATA_SOURCE_ID_LIST = DATA_SOURCE_ID_LIST != null ? string.Join(",", DATA_SOURCE_ID_LIST) : "";
            _params.KPI_ID_LIST = KPI_ID_LIST != null ? string.Join(",", KPI_ID_LIST) : "";
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where_In_List
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where_In_List(string COLOR, IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.COLOR = COLOR;
            _params.ORGANIZATION_COLOR_SCHEME_ID_LIST = ORGANIZATION_COLOR_SCHEME_ID_LIST != null ? string.Join(",", ORGANIZATION_COLOR_SCHEME_ID_LIST) : "";
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where_In_List
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.DISTRICTNEX_MODULE_ID_LIST = DISTRICTNEX_MODULE_ID_LIST != null ? string.Join(",", DISTRICTNEX_MODULE_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Delete_Organization_theme
        public void Delete_Organization_theme(int? ORGANIZATION_THEME_ID)
        {
            var _params = new
            {
                ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_THEME", _params);
        }
        #endregion
        #region Delete_Organization
        public void Delete_Organization(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION", _params);
        }
        #endregion
        #region Delete_Organization_level_access
        public void Delete_Organization_level_access(long? ORGANIZATION_LEVEL_ACCESS_ID)
        {
            var _params = new
            {
                ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS", _params);
        }
        #endregion
        #region Delete_Organization_log_config
        public void Delete_Organization_log_config(long? ORGANIZATION_LOG_CONFIG_ID)
        {
            var _params = new
            {
                ORGANIZATION_LOG_CONFIG_ID = ORGANIZATION_LOG_CONFIG_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LOG_CONFIG", _params);
        }
        #endregion
        #region Delete_Organization_color_scheme
        public void Delete_Organization_color_scheme(int? ORGANIZATION_COLOR_SCHEME_ID)
        {
            var _params = new
            {
                ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_COLOR_SCHEME", _params);
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY", _params);
        }
        #endregion
        #region Delete_Organization_image
        public void Delete_Organization_image(int? ORGANIZATION_IMAGE_ID)
        {
            var _params = new
            {
                ORGANIZATION_IMAGE_ID = ORGANIZATION_IMAGE_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_IMAGE", _params);
        }
        #endregion
        #region Delete_Organization_relation
        public void Delete_Organization_relation(int? ORGANIZATION_RELATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION", _params);
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(long? SETUP_ID)
        {
            var _params = new
            {
                SETUP_ID = SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi
        public void Delete_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI", _params);
        }
        #endregion
        #region Delete_Organization_chart_color
        public void Delete_Organization_chart_color(int? ORGANIZATION_CHART_COLOR_ID)
        {
            var _params = new
            {
                ORGANIZATION_CHART_COLOR_ID = ORGANIZATION_CHART_COLOR_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_CHART_COLOR", _params);
        }
        #endregion
        #region Delete_Organization_districtnex_module
        public void Delete_Organization_districtnex_module(int? ORGANIZATION_DISTRICTNEX_MODULE_ID)
        {
            var _params = new
            {
                ORGANIZATION_DISTRICTNEX_MODULE_ID = ORGANIZATION_DISTRICTNEX_MODULE_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DISTRICTNEX_MODULE", _params);
        }
        #endregion
        #region Delete_Organization_theme_By_ORGANIZATION_ID
        public void Delete_Organization_theme_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_THEME_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_theme_By_OWNER_ID
        public void Delete_Organization_theme_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_THEME_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_theme_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_THEME_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_By_OWNER_ID
        public void Delete_Organization_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID
        public void Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID(long? ORGANIZATION_TYPE_SETUP_ID)
        {
            var _params = new
            {
                ORGANIZATION_TYPE_SETUP_ID = ORGANIZATION_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_BY_ORGANIZATION_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_level_access_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_level_access_By_OWNER_ID
        public void Delete_Organization_level_access_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_level_access_By_ORGANIZATION_ID
        public void Delete_Organization_level_access_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_level_access_By_LEVEL_ID
        public void Delete_Organization_level_access_By_LEVEL_ID(long? LEVEL_ID)
        {
            var _params = new
            {
                LEVEL_ID = LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS_BY_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID
        public void Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
        public void Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(int? ORGANIZATION_ID, long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_log_config_By_OWNER_ID
        public void Delete_Organization_log_config_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LOG_CONFIG_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_log_config_By_ORGANIZATION_ID
        public void Delete_Organization_log_config_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID
        public void Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID(long? LOG_TYPE_SETUP_ID)
        {
            var _params = new
            {
                LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LOG_CONFIG_BY_LOG_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_log_config_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_log_config_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LOG_CONFIG_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
        public void Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID,
                LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID_LOG_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_color_scheme_By_OWNER_ID
        public void Delete_Organization_color_scheme_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_COLOR_SCHEME_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_color_scheme_By_ORGANIZATION_ID
        public void Delete_Organization_color_scheme_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_COLOR_SCHEME_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_image_By_OWNER_ID
        public void Delete_Organization_image_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_IMAGE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_image_By_ORGANIZATION_ID
        public void Delete_Organization_image_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID
        public void Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID)
        {
            var _params = new
            {
                IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_IMAGE_BY_IMAGE_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_image_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_IMAGE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
        public void Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? IMAGE_TYPE_SETUP_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID,
                IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID
        public void Delete_Organization_relation_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_PARENT_ORGANIZATION_ID
        public void Delete_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID)
        {
            var _params = new
            {
                PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_CHILD_ORGANIZATION_ID
        public void Delete_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID)
        {
            var _params = new
            {
                CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_USER_ID
        public void Delete_Organization_relation_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                VALUE = VALUE
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID
        public void Delete_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public void Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID)
        {
            var _params = new
            {
                DATA_SOURCE_ID = DATA_SOURCE_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_KPI_ID
        public void Delete_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID)
        {
            var _params = new
            {
                KPI_ID = KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_ORGANIZATION_ID
        public void Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_chart_color_By_OWNER_ID
        public void Delete_Organization_chart_color_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_CHART_COLOR_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
        public void Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(int? ORGANIZATION_COLOR_SCHEME_ID)
        {
            var _params = new
            {
                ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_COLOR_SCHEME_ID", _params);
        }
        #endregion
        #region Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_CHART_COLOR_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
        public void Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_OWNER_ID
        public void Delete_Organization_districtnex_module_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DISTRICTNEX_MODULE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_ORGANIZATION_ID
        public void Delete_Organization_districtnex_module_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
        public void Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID)
        {
            var _params = new
            {
                DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID", _params);
        }
        #endregion
        #region Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Organization_theme
        public int? Edit_Organization_theme(int? ORGANIZATION_THEME_ID, int? ORGANIZATION_ID, string THEME_NAME, string THEME_CLASS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Organization_theme oOrganization_theme = new Organization_theme()
            {
                ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                THEME_NAME = THEME_NAME,
                THEME_CLASS = THEME_CLASS,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_THEME", oOrganization_theme, "ORGANIZATION_THEME_ID");
            return oOrganization_theme.ORGANIZATION_THEME_ID;
        }
        #endregion
        #region Edit_Organization
        public int? Edit_Organization(int? ORGANIZATION_ID, string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? DATA_RETENTION_PERIOD, int? TICKET_DURATION_IN_MINUTES, long? ORGANIZATION_TYPE_SETUP_ID, string DATE_DELETED, int? MAX_NUMBER_OF_ADMINS, int? MAX_NUMBER_OF_USERS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_ACTIVE, bool IS_DELETED, int? OWNER_ID)
        {
            Organization oOrganization = new Organization()
            {
                ORGANIZATION_ID = ORGANIZATION_ID,
                ORGANIZATION_NAME = ORGANIZATION_NAME,
                ORGANIZATION_EMAIL = ORGANIZATION_EMAIL,
                ORGANIZATION_PHONE_NUMBER = ORGANIZATION_PHONE_NUMBER,
                ORGANIZATION_ADDRESS = ORGANIZATION_ADDRESS,
                DATA_RETENTION_PERIOD = DATA_RETENTION_PERIOD,
                TICKET_DURATION_IN_MINUTES = TICKET_DURATION_IN_MINUTES,
                ORGANIZATION_TYPE_SETUP_ID = ORGANIZATION_TYPE_SETUP_ID,
                DATE_DELETED = DATE_DELETED,
                MAX_NUMBER_OF_ADMINS = MAX_NUMBER_OF_ADMINS,
                MAX_NUMBER_OF_USERS = MAX_NUMBER_OF_USERS,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_ACTIVE = IS_ACTIVE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION", oOrganization, "ORGANIZATION_ID");
            return oOrganization.ORGANIZATION_ID;
        }
        #endregion
        #region Edit_Organization_level_access
        public long? Edit_Organization_level_access(long? ORGANIZATION_LEVEL_ACCESS_ID, int? ORGANIZATION_ID, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_level_access oOrganization_level_access = new Organization_level_access()
            {
                ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                LEVEL_ID = LEVEL_ID,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_LEVEL_ACCESS", oOrganization_level_access, "ORGANIZATION_LEVEL_ACCESS_ID");
            return oOrganization_level_access.ORGANIZATION_LEVEL_ACCESS_ID;
        }
        #endregion
        #region Edit_Organization_log_config
        public long? Edit_Organization_log_config(long? ORGANIZATION_LOG_CONFIG_ID, int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_log_config oOrganization_log_config = new Organization_log_config()
            {
                ORGANIZATION_LOG_CONFIG_ID = ORGANIZATION_LOG_CONFIG_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_LOG_CONFIG", oOrganization_log_config, "ORGANIZATION_LOG_CONFIG_ID");
            return oOrganization_log_config.ORGANIZATION_LOG_CONFIG_ID;
        }
        #endregion
        #region Edit_Organization_color_scheme
        public int? Edit_Organization_color_scheme(int? ORGANIZATION_COLOR_SCHEME_ID, int? ORGANIZATION_ID, string PLATFORM_PRIMARY, string PLATFORM_BUTTON, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme()
            {
                ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                PLATFORM_PRIMARY = PLATFORM_PRIMARY,
                PLATFORM_BUTTON = PLATFORM_BUTTON,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_COLOR_SCHEME", oOrganization_color_scheme, "ORGANIZATION_COLOR_SCHEME_ID");
            return oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID;
        }
        #endregion
        #region Edit_Setup_category
        public int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Setup_category oSetup_category = new Setup_category()
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP_CATEGORY", oSetup_category, "SETUP_CATEGORY_ID");
            return oSetup_category.SETUP_CATEGORY_ID;
        }
        #endregion
        #region Edit_Organization_image
        public int? Edit_Organization_image(int? ORGANIZATION_IMAGE_ID, int? ORGANIZATION_ID, string IMAGE_NAME, string IMAGE_EXTENSION, long? IMAGE_TYPE_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Organization_image oOrganization_image = new Organization_image()
            {
                ORGANIZATION_IMAGE_ID = ORGANIZATION_IMAGE_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                IMAGE_NAME = IMAGE_NAME,
                IMAGE_EXTENSION = IMAGE_EXTENSION,
                IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_IMAGE", oOrganization_image, "ORGANIZATION_IMAGE_ID");
            return oOrganization_image.ORGANIZATION_IMAGE_ID;
        }
        #endregion
        #region Edit_Organization_relation
        public int? Edit_Organization_relation(int? ORGANIZATION_RELATION_ID, int? PARENT_ORGANIZATION_ID, int? CHILD_ORGANIZATION_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_relation oOrganization_relation = new Organization_relation()
            {
                ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID,
                PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID,
                CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID,
                USER_ID = USER_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_RELATION", oOrganization_relation, "ORGANIZATION_RELATION_ID");
            return oOrganization_relation.ORGANIZATION_RELATION_ID;
        }
        #endregion
        #region Edit_Setup
        public long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID)
        {
            Setup oSetup = new Setup()
            {
                SETUP_ID = SETUP_ID,
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                IS_SYSTEM = IS_SYSTEM,
                IS_DELETEABLE = IS_DELETEABLE,
                IS_UPDATEABLE = IS_UPDATEABLE,
                IS_DELETED = IS_DELETED,
                IS_VISIBLE = IS_VISIBLE,
                DISPLAY_ORDER = DISPLAY_ORDER,
                VALUE = VALUE,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP", oSetup, "SETUP_ID");
            return oSetup.SETUP_ID;
        }
        #endregion
        #region Edit_Organization_data_source_kpi
        public int? Edit_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID, int? DATA_SOURCE_ID, int? KPI_ID, int? ORGANIZATION_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi()
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                DATA_SOURCE_ID = DATA_SOURCE_ID,
                KPI_ID = KPI_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_DATA_SOURCE_KPI", oOrganization_data_source_kpi, "ORGANIZATION_DATA_SOURCE_KPI_ID");
            return oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
        }
        #endregion
        #region Edit_Organization_chart_color
        public int? Edit_Organization_chart_color(int? ORGANIZATION_CHART_COLOR_ID, int? ORGANIZATION_COLOR_SCHEME_ID, string COLOR, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Organization_chart_color oOrganization_chart_color = new Organization_chart_color()
            {
                ORGANIZATION_CHART_COLOR_ID = ORGANIZATION_CHART_COLOR_ID,
                ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID,
                COLOR = COLOR,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_CHART_COLOR", oOrganization_chart_color, "ORGANIZATION_CHART_COLOR_ID");
            return oOrganization_chart_color.ORGANIZATION_CHART_COLOR_ID;
        }
        #endregion
        #region Edit_Organization_districtnex_module
        public int? Edit_Organization_districtnex_module(int? ORGANIZATION_DISTRICTNEX_MODULE_ID, int? ORGANIZATION_ID, int? DISTRICTNEX_MODULE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module()
            {
                ORGANIZATION_DISTRICTNEX_MODULE_ID = ORGANIZATION_DISTRICTNEX_MODULE_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_DISTRICTNEX_MODULE", oOrganization_districtnex_module, "ORGANIZATION_DISTRICTNEX_MODULE_ID");
            return oOrganization_districtnex_module.ORGANIZATION_DISTRICTNEX_MODULE_ID;
        }
        #endregion
    }
}
