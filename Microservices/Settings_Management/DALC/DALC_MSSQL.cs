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
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID
        public Build_version_log Get_Build_version_log_By_BUILD_VERSION_LOG_ID(int? BUILD_VERSION_LOG_ID)
        {
            Build_version_log oBuild_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_VERSION_LOG_ID = BUILD_VERSION_LOG_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_LOG_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oBuild_version_log = new Build_version_log();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oBuild_version_log);
            }
            return oBuild_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
        public Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(int? REMOVED_EXTRUSION_ID)
        {
            Removed_extrusion oRemoved_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_REMOVED_EXTRUSION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRemoved_extrusion = new Removed_extrusion();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRemoved_extrusion);
            }
            return oRemoved_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID
        public Alert_settings Get_Alert_settings_By_ALERT_SETTINGS_ID(long? ALERT_SETTINGS_ID)
        {
            Alert_settings oAlert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.ALERT_SETTINGS_ID = ALERT_SETTINGS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_ALERT_SETTINGS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oAlert_settings = new Alert_settings();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oAlert_settings);
            }
            return oAlert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID
        public Default_settings_image Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID(int? DEFAULT_SETTINGS_IMAGE_ID)
        {
            Default_settings_image oDefault_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_IMAGE_ID = DEFAULT_SETTINGS_IMAGE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_IMAGE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDefault_settings_image = new Default_settings_image();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDefault_settings_image);
            }
            return oDefault_settings_image;
        }
        #endregion
        #region Get_Owner_By_OWNER_ID
        public Owner Get_Owner_By_OWNER_ID(int? OWNER_ID)
        {
            Owner oOwner = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOwner = new Owner();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOwner);
            }
            return oOwner;
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
        #region Get_Build_version_By_BUILD_VERSION_ID
        public Build_version Get_Build_version_By_BUILD_VERSION_ID(int? BUILD_VERSION_ID)
        {
            Build_version oBuild_version = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_VERSION_ID = BUILD_VERSION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_BUILD_VERSION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oBuild_version = new Build_version();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oBuild_version);
            }
            return oBuild_version;
        }
        #endregion
        #region Get_Default_settings_By_DEFAULT_SETTINGS_ID
        public Default_settings Get_Default_settings_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID)
        {
            Default_settings oDefault_settings = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_BY_DEFAULT_SETTINGS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDefault_settings = new Default_settings();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDefault_settings);
            }
            return oDefault_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID
        public Default_chart_color Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID(int? DEFAULT_CHART_COLOR_ID)
        {
            Default_chart_color oDefault_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_CHART_COLOR_ID = DEFAULT_CHART_COLOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_CHART_COLOR_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDefault_chart_color = new Default_chart_color();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDefault_chart_color);
            }
            return oDefault_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID
        public Districtnex_module Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID)
        {
            Districtnex_module oDistrictnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrictnex_module = new Districtnex_module();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrictnex_module);
            }
            return oDistrictnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List(IEnumerable<int?> BUILD_VERSION_LOG_ID_LIST)
        {
            List<Build_version_log> oList_Build_version_log = null;
            if (BUILD_VERSION_LOG_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_VERSION_LOG_ID_LIST = string.Join(",", BUILD_VERSION_LOG_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_LOG_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Build_version_log = new List<Build_version_log>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version_log oBuild_version_log = new Build_version_log();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                            oList_Build_version_log.Add(oBuild_version_log);
                        }
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (REMOVED_EXTRUSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REMOVED_EXTRUSION_ID_LIST = string.Join(",", REMOVED_EXTRUSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_REMOVED_EXTRUSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_List
        public List<Alert_settings> Get_Alert_settings_By_ALERT_SETTINGS_ID_List(IEnumerable<long?> ALERT_SETTINGS_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (ALERT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ALERT_SETTINGS_ID_LIST = string.Join(",", ALERT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_ALERT_SETTINGS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_IMAGE_ID_LIST)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            if (DEFAULT_SETTINGS_IMAGE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_IMAGE_ID_LIST = string.Join(",", DEFAULT_SETTINGS_IMAGE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_IMAGE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_settings_image = new List<Default_settings_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings_image oDefault_settings_image = new Default_settings_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                            oList_Default_settings_image.Add(oDefault_settings_image);
                        }
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Owner_By_OWNER_ID_List
        public List<Owner> Get_Owner_By_OWNER_ID_List(IEnumerable<int?> OWNER_ID_LIST)
        {
            List<Owner> oList_Owner = null;
            if (OWNER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Owner = new List<Owner>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Owner oOwner = new Owner();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOwner);
                            oList_Owner.Add(oOwner);
                        }
                    }
                }
            }
            return oList_Owner;
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
        #region Get_Build_version_By_BUILD_VERSION_ID_List
        public List<Build_version> Get_Build_version_By_BUILD_VERSION_ID_List(IEnumerable<int?> BUILD_VERSION_ID_LIST)
        {
            List<Build_version> oList_Build_version = null;
            if (BUILD_VERSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_VERSION_ID_LIST = string.Join(",", BUILD_VERSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_BUILD_VERSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Build_version = new List<Build_version>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version oBuild_version = new Build_version();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                            oList_Build_version.Add(oBuild_version);
                        }
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_settings_By_DEFAULT_SETTINGS_ID_List
        public List<Default_settings> Get_Default_settings_By_DEFAULT_SETTINGS_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST)
        {
            List<Default_settings> oList_Default_settings = null;
            if (DEFAULT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_ID_LIST = string.Join(",", DEFAULT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_BY_DEFAULT_SETTINGS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_settings = new List<Default_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings oDefault_settings = new Default_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings);
                            oList_Default_settings.Add(oDefault_settings);
                        }
                    }
                }
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List(IEnumerable<int?> DEFAULT_CHART_COLOR_ID_LIST)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            if (DEFAULT_CHART_COLOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_CHART_COLOR_ID_LIST = string.Join(",", DEFAULT_CHART_COLOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_CHART_COLOR_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_chart_color = new List<Default_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_chart_color oDefault_chart_color = new Default_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                            oList_Default_chart_color.Add(oDefault_chart_color);
                        }
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        public List<Districtnex_module> Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            if (DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICTNEX_MODULE_ID_LIST = string.Join(",", DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Districtnex_module = new List<Districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Districtnex_module oDistrictnex_module = new Districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrictnex_module);
                            oList_Districtnex_module.Add(oDistrictnex_module);
                        }
                    }
                }
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID(int? OWNER_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID(int? BUILD_VERSION_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_VERSION_ID = BUILD_VERSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_ID", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(long? BUILD_LOG_TYPE_SETUP_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_LOG_TYPE_SETUP_ID = BUILD_LOG_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_LOG_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_IS_DELETED
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID(int? OWNER_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.LEVEL_ID = LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID(int? OWNER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID(long? OPERATION_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OPERATION_SETUP_ID = OPERATION_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OPERATION_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID
        public List<Alert_settings> Get_Alert_settings_By_USER_ID(long? USER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_IS_DELETED
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID(int? KPI_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID(long? VALUE_TYPE_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE_TYPE_SETUP_ID = VALUE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_VALUE_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID(int? OWNER_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_ID", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_IMAGE_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_IS_DELETED
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Owner_By_IS_DELETED
        public List<Owner> Get_Owner_By_IS_DELETED(bool IS_DELETED)
        {
            List<Owner> oList_Owner = null;
            dynamic _params = new ExpandoObject();
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_OWNER_BY_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Owner = new List<Owner>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Owner oOwner = new Owner();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOwner);
                        oList_Owner.Add(oOwner);
                    }
                }
            }
            return oList_Owner;
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
        #region Get_Build_version_By_OWNER_ID
        public List<Build_version> Get_Build_version_By_OWNER_ID(int? OWNER_ID)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID(long? APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_APPLICATION_NAME_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID_IS_DELETED
        public List<Build_version> Get_Build_version_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
        public List<Build_version> Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(bool IS_CURRENT, long? APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.IS_CURRENT = IS_CURRENT;
            _params.APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_IS_CURRENT_APPLICATION_NAME_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_settings_By_OWNER_ID_IS_DELETED
        public List<Default_settings> Get_Default_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Default_settings> oList_Default_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_settings_By_OWNER_ID
        public List<Default_settings> Get_Default_settings_By_OWNER_ID(int? OWNER_ID)
        {
            List<Default_settings> oList_Default_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_settings_By_TELUS_REQUEST_ID
        public List<Default_settings> Get_Default_settings_By_TELUS_REQUEST_ID(string TELUS_REQUEST_ID)
        {
            List<Default_settings> oList_Default_settings = null;
            dynamic _params = new ExpandoObject();
            _params.TELUS_REQUEST_ID = TELUS_REQUEST_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_BY_TELUS_REQUEST_ID", _params);
            if (_query_response != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID(int? OWNER_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_SETTINGS_ID", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_IS_DELETED
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_OWNER_ID
        public List<Districtnex_module> Get_Districtnex_module_By_OWNER_ID(int? OWNER_ID)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICTNEX_MODULE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Districtnex_module_By_OWNER_ID_IS_DELETED
        public List<Districtnex_module> Get_Districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_List
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_List(IEnumerable<int?> BUILD_VERSION_ID_LIST)
        {
            List<Build_version_log> oList_Build_version_log = null;
            if (BUILD_VERSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_VERSION_ID_LIST = string.Join(",", BUILD_VERSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Build_version_log = new List<Build_version_log>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version_log oBuild_version_log = new Build_version_log();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                            oList_Build_version_log.Add(oBuild_version_log);
                        }
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List(IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST)
        {
            List<Build_version_log> oList_Build_version_log = null;
            if (BUILD_LOG_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_LOG_TYPE_SETUP_ID_LIST = string.Join(",", BUILD_LOG_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_LOG_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Build_version_log = new List<Build_version_log>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version_log oBuild_version_log = new Build_version_log();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                            oList_Build_version_log.Add(oBuild_version_log);
                        }
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LEVEL_ID_LIST = string.Join(",", LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_List
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_List(IEnumerable<long?> OPERATION_SETUP_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (OPERATION_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.OPERATION_SETUP_ID_LIST = string.Join(",", OPERATION_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OPERATION_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID_List
        public List<Alert_settings> Get_Alert_settings_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID_List
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List(IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (VALUE_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VALUE_TYPE_SETUP_ID_LIST = string.Join(",", VALUE_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_VALUE_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            if (DEFAULT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_ID_LIST = string.Join(",", DEFAULT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_settings_image = new List<Default_settings_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings_image oDefault_settings_image = new Default_settings_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                            oList_Default_settings_image.Add(oDefault_settings_image);
                        }
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            if (IMAGE_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.IMAGE_TYPE_SETUP_ID_LIST = string.Join(",", IMAGE_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_IMAGE_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_settings_image = new List<Default_settings_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings_image oDefault_settings_image = new Default_settings_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                            oList_Default_settings_image.Add(oDefault_settings_image);
                        }
                    }
                }
            }
            return oList_Default_settings_image;
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
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List(IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST)
        {
            List<Build_version> oList_Build_version = null;
            if (APPLICATION_NAME_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.APPLICATION_NAME_SETUP_ID_LIST = string.Join(",", APPLICATION_NAME_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_APPLICATION_NAME_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Build_version = new List<Build_version>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version oBuild_version = new Build_version();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                            oList_Build_version.Add(oBuild_version);
                        }
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            if (DEFAULT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_ID_LIST = string.Join(",", DEFAULT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_SETTINGS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_chart_color = new List<Default_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_chart_color oDefault_chart_color = new Default_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                            oList_Default_chart_color.Add(oDefault_chart_color);
                        }
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Default_chart_color = new List<Default_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_chart_color oDefault_chart_color = new Default_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                            oList_Default_chart_color.Add(oDefault_chart_color);
                        }
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_Where
        public List<Build_version_log> Get_Build_version_log_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where
        public List<Alert_settings> Get_Alert_settings_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where
        public List<Default_settings_image> Get_Default_settings_image_By_Where(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_NAME = IMAGE_NAME;
            _params.IMAGE_EXTENSION = IMAGE_EXTENSION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Owner_By_Where
        public List<Owner> Get_Owner_By_Where(string CODE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Owner> oList_Owner = null;
            dynamic _params = new ExpandoObject();
            _params.CODE = CODE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Owner = new List<Owner>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Owner oOwner = new Owner();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOwner);
                        oList_Owner.Add(oOwner);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Owner;
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
        #region Get_Build_version_By_Where
        public List<Build_version> Get_Build_version_By_Where(string BUILD_NUMBER, string COMMENTS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_NUMBER = BUILD_NUMBER;
            _params.COMMENTS = COMMENTS;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_settings_By_Where
        public List<Default_settings> Get_Default_settings_By_Where(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, string MAPBOX_GL_TOKEN, string GOOGLE_MAP_API_TOKEN, string TELUS_REQUEST_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_settings> oList_Default_settings = null;
            dynamic _params = new ExpandoObject();
            _params.PLATFORM_PRIMARY = PLATFORM_PRIMARY;
            _params.PLATFORM_BUTTON = PLATFORM_BUTTON;
            _params.MAPBOX_GL_TOKEN = MAPBOX_GL_TOKEN;
            _params.GOOGLE_MAP_API_TOKEN = GOOGLE_MAP_API_TOKEN;
            _params.TELUS_REQUEST_ID = TELUS_REQUEST_ID;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_Where
        public List<Default_chart_color> Get_Default_chart_color_By_Where(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.COLOR = COLOR;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_Where
        public List<Districtnex_module> Get_Districtnex_module_By_Where(string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICTNEX_MODULE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_Where_In_List
        public List<Build_version_log> Get_Build_version_log_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> BUILD_VERSION_ID_LIST, IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.BUILD_VERSION_ID_LIST = BUILD_VERSION_ID_LIST != null ? string.Join(",", BUILD_VERSION_ID_LIST) : "";
            _params.BUILD_LOG_TYPE_SETUP_ID_LIST = BUILD_LOG_TYPE_SETUP_ID_LIST != null ? string.Join(",", BUILD_LOG_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER;
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where_In_List
        public List<Alert_settings> Get_Alert_settings_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST, IEnumerable<long?> OPERATION_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.KPI_ID_LIST = KPI_ID_LIST != null ? string.Join(",", KPI_ID_LIST) : "";
            _params.VALUE_TYPE_SETUP_ID_LIST = VALUE_TYPE_SETUP_ID_LIST != null ? string.Join(",", VALUE_TYPE_SETUP_ID_LIST) : "";
            _params.OPERATION_SETUP_ID_LIST = OPERATION_SETUP_ID_LIST != null ? string.Join(",", OPERATION_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where_In_List
        public List<Default_settings_image> Get_Default_settings_image_By_Where_In_List(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_NAME = IMAGE_NAME;
            _params.IMAGE_EXTENSION = IMAGE_EXTENSION;
            _params.DEFAULT_SETTINGS_ID_LIST = DEFAULT_SETTINGS_ID_LIST != null ? string.Join(",", DEFAULT_SETTINGS_ID_LIST) : "";
            _params.IMAGE_TYPE_SETUP_ID_LIST = IMAGE_TYPE_SETUP_ID_LIST != null ? string.Join(",", IMAGE_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_settings_image;
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
        #region Get_Build_version_By_Where_In_List
        public List<Build_version> Get_Build_version_By_Where_In_List(string BUILD_NUMBER, string COMMENTS, IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_NUMBER = BUILD_NUMBER;
            _params.COMMENTS = COMMENTS;
            _params.APPLICATION_NAME_SETUP_ID_LIST = APPLICATION_NAME_SETUP_ID_LIST != null ? string.Join(",", APPLICATION_NAME_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_Where_In_List
        public List<Default_chart_color> Get_Default_chart_color_By_Where_In_List(string COLOR, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.COLOR = COLOR;
            _params.DEFAULT_SETTINGS_ID_LIST = DEFAULT_SETTINGS_ID_LIST != null ? string.Join(",", DEFAULT_SETTINGS_ID_LIST) : "";
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_chart_color;
        }
        #endregion
        #region Delete_Build_version_log
        public void Delete_Build_version_log(int? BUILD_VERSION_LOG_ID)
        {
            var _params = new
            {
                BUILD_VERSION_LOG_ID = BUILD_VERSION_LOG_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_LOG", _params);
        }
        #endregion
        #region Delete_Removed_extrusion
        public void Delete_Removed_extrusion(int? REMOVED_EXTRUSION_ID)
        {
            var _params = new
            {
                REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION", _params);
        }
        #endregion
        #region Delete_Alert_settings
        public void Delete_Alert_settings(long? ALERT_SETTINGS_ID)
        {
            var _params = new
            {
                ALERT_SETTINGS_ID = ALERT_SETTINGS_ID
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS", _params);
        }
        #endregion
        #region Delete_Default_settings_image
        public void Delete_Default_settings_image(int? DEFAULT_SETTINGS_IMAGE_ID)
        {
            var _params = new
            {
                DEFAULT_SETTINGS_IMAGE_ID = DEFAULT_SETTINGS_IMAGE_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_IMAGE", _params);
        }
        #endregion
        #region Delete_Owner
        public void Delete_Owner(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_OWNER", _params);
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
        #region Delete_Build_version
        public void Delete_Build_version(int? BUILD_VERSION_ID)
        {
            var _params = new
            {
                BUILD_VERSION_ID = BUILD_VERSION_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION", _params);
        }
        #endregion
        #region Delete_Default_settings
        public void Delete_Default_settings(int? DEFAULT_SETTINGS_ID)
        {
            var _params = new
            {
                DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS", _params);
        }
        #endregion
        #region Delete_Default_chart_color
        public void Delete_Default_chart_color(int? DEFAULT_CHART_COLOR_ID)
        {
            var _params = new
            {
                DEFAULT_CHART_COLOR_ID = DEFAULT_CHART_COLOR_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_CHART_COLOR", _params);
        }
        #endregion
        #region Delete_Districtnex_module
        public void Delete_Districtnex_module(int? DISTRICTNEX_MODULE_ID)
        {
            var _params = new
            {
                DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICTNEX_MODULE", _params);
        }
        #endregion
        #region Delete_Build_version_log_By_OWNER_ID
        public void Delete_Build_version_log_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_LOG_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Build_version_log_By_BUILD_VERSION_ID
        public void Delete_Build_version_log_By_BUILD_VERSION_ID(int? BUILD_VERSION_ID)
        {
            var _params = new
            {
                BUILD_VERSION_ID = BUILD_VERSION_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_LOG_BY_BUILD_VERSION_ID", _params);
        }
        #endregion
        #region Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
        public void Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(long? BUILD_LOG_TYPE_SETUP_ID)
        {
            var _params = new
            {
                BUILD_LOG_TYPE_SETUP_ID = BUILD_LOG_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_LOG_BY_BUILD_LOG_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Build_version_log_By_OWNER_ID_IS_DELETED
        public void Delete_Build_version_log_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_LOG_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID
        public void Delete_Removed_extrusion_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_LEVEL_ID
        public void Delete_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID)
        {
            var _params = new
            {
                LEVEL_ID = LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        public void Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED
        public void Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Alert_settings_By_OWNER_ID
        public void Delete_Alert_settings_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Alert_settings_By_OPERATION_SETUP_ID
        public void Delete_Alert_settings_By_OPERATION_SETUP_ID(long? OPERATION_SETUP_ID)
        {
            var _params = new
            {
                OPERATION_SETUP_ID = OPERATION_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS_BY_OPERATION_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Alert_settings_By_USER_ID
        public void Delete_Alert_settings_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_Alert_settings_By_OWNER_ID_IS_DELETED
        public void Delete_Alert_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Alert_settings_By_KPI_ID
        public void Delete_Alert_settings_By_KPI_ID(int? KPI_ID)
        {
            var _params = new
            {
                KPI_ID = KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS_BY_KPI_ID", _params);
        }
        #endregion
        #region Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID
        public void Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID(long? VALUE_TYPE_SETUP_ID)
        {
            var _params = new
            {
                VALUE_TYPE_SETUP_ID = VALUE_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ALERT_SETTINGS_BY_VALUE_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Default_settings_image_By_OWNER_ID
        public void Delete_Default_settings_image_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_IMAGE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID
        public void Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID)
        {
            var _params = new
            {
                DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_ID", _params);
        }
        #endregion
        #region Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
        public void Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID)
        {
            var _params = new
            {
                IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_IMAGE_BY_IMAGE_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Default_settings_image_By_OWNER_ID_IS_DELETED
        public void Delete_Default_settings_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_IMAGE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Owner_By_IS_DELETED
        public void Delete_Owner_By_IS_DELETED(bool IS_DELETED)
        {
            var _params = new
            {
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_OWNER_BY_IS_DELETED", _params);
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
        #region Delete_Build_version_By_OWNER_ID
        public void Delete_Build_version_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Build_version_By_APPLICATION_NAME_SETUP_ID
        public void Delete_Build_version_By_APPLICATION_NAME_SETUP_ID(long? APPLICATION_NAME_SETUP_ID)
        {
            var _params = new
            {
                APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_BY_APPLICATION_NAME_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Build_version_By_OWNER_ID_IS_DELETED
        public void Delete_Build_version_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
        public void Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(bool IS_CURRENT, long? APPLICATION_NAME_SETUP_ID)
        {
            var _params = new
            {
                IS_CURRENT = IS_CURRENT,
                APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_BUILD_VERSION_BY_IS_CURRENT_APPLICATION_NAME_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Default_settings_By_OWNER_ID_IS_DELETED
        public void Delete_Default_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Default_settings_By_OWNER_ID
        public void Delete_Default_settings_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Default_settings_By_TELUS_REQUEST_ID
        public void Delete_Default_settings_By_TELUS_REQUEST_ID(string TELUS_REQUEST_ID)
        {
            var _params = new
            {
                TELUS_REQUEST_ID = TELUS_REQUEST_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_SETTINGS_BY_TELUS_REQUEST_ID", _params);
        }
        #endregion
        #region Delete_Default_chart_color_By_OWNER_ID
        public void Delete_Default_chart_color_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_CHART_COLOR_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID
        public void Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID)
        {
            var _params = new
            {
                DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_CHART_COLOR_BY_DEFAULT_SETTINGS_ID", _params);
        }
        #endregion
        #region Delete_Default_chart_color_By_OWNER_ID_IS_DELETED
        public void Delete_Default_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_CHART_COLOR_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID
        public void Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_DEFAULT_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Districtnex_module_By_OWNER_ID
        public void Delete_Districtnex_module_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICTNEX_MODULE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Districtnex_module_By_OWNER_ID_IS_DELETED
        public void Delete_Districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Build_version_log
        public int? Edit_Build_version_log(int? BUILD_VERSION_LOG_ID, int? BUILD_VERSION_ID, long? BUILD_LOG_TYPE_SETUP_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Build_version_log oBuild_version_log = new Build_version_log()
            {
                BUILD_VERSION_LOG_ID = BUILD_VERSION_LOG_ID,
                BUILD_VERSION_ID = BUILD_VERSION_ID,
                BUILD_LOG_TYPE_SETUP_ID = BUILD_LOG_TYPE_SETUP_ID,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_BUILD_VERSION_LOG", oBuild_version_log, "BUILD_VERSION_LOG_ID");
            return oBuild_version_log.BUILD_VERSION_LOG_ID;
        }
        #endregion
        #region Edit_Removed_extrusion
        public int? Edit_Removed_extrusion(int? REMOVED_EXTRUSION_ID, string EXTRUSION_IDENTIFIER, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Removed_extrusion oRemoved_extrusion = new Removed_extrusion()
            {
                REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID,
                EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER,
                LEVEL_ID = LEVEL_ID,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_REMOVED_EXTRUSION", oRemoved_extrusion, "REMOVED_EXTRUSION_ID");
            return oRemoved_extrusion.REMOVED_EXTRUSION_ID;
        }
        #endregion
        #region Edit_Alert_settings
        public long? Edit_Alert_settings(long? ALERT_SETTINGS_ID, long? USER_ID, int? KPI_ID, decimal? VALUE, long? VALUE_TYPE_SETUP_ID, long? OPERATION_SETUP_ID, bool IS_ACTIVE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Alert_settings oAlert_settings = new Alert_settings()
            {
                ALERT_SETTINGS_ID = ALERT_SETTINGS_ID,
                USER_ID = USER_ID,
                KPI_ID = KPI_ID,
                VALUE = VALUE,
                VALUE_TYPE_SETUP_ID = VALUE_TYPE_SETUP_ID,
                OPERATION_SETUP_ID = OPERATION_SETUP_ID,
                IS_ACTIVE = IS_ACTIVE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ALERT_SETTINGS", oAlert_settings, "ALERT_SETTINGS_ID");
            return oAlert_settings.ALERT_SETTINGS_ID;
        }
        #endregion
        #region Edit_Default_settings_image
        public int? Edit_Default_settings_image(int? DEFAULT_SETTINGS_IMAGE_ID, int? DEFAULT_SETTINGS_ID, string IMAGE_NAME, string IMAGE_EXTENSION, long? IMAGE_TYPE_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Default_settings_image oDefault_settings_image = new Default_settings_image()
            {
                DEFAULT_SETTINGS_IMAGE_ID = DEFAULT_SETTINGS_IMAGE_ID,
                DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID,
                IMAGE_NAME = IMAGE_NAME,
                IMAGE_EXTENSION = IMAGE_EXTENSION,
                IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_DEFAULT_SETTINGS_IMAGE", oDefault_settings_image, "DEFAULT_SETTINGS_IMAGE_ID");
            return oDefault_settings_image.DEFAULT_SETTINGS_IMAGE_ID;
        }
        #endregion
        #region Edit_Owner
        public int? Edit_Owner(int? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string ENTRY_DATE, string DESCRIPTION, long? ENTRY_USER_ID, string LAST_UPDATE, bool IS_DELETED)
        {
            Owner oOwner = new Owner()
            {
                OWNER_ID = OWNER_ID,
                CODE = CODE,
                MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE,
                ENTRY_DATE = ENTRY_DATE,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED
            };
            ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
            return oOwner.OWNER_ID;
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
        #region Edit_Build_version
        public int? Edit_Build_version(int? BUILD_VERSION_ID, string BUILD_NUMBER, long? APPLICATION_NAME_SETUP_ID, bool IS_CURRENT, string BUILD_DATE, string COMMENTS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Build_version oBuild_version = new Build_version()
            {
                BUILD_VERSION_ID = BUILD_VERSION_ID,
                BUILD_NUMBER = BUILD_NUMBER,
                APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID,
                IS_CURRENT = IS_CURRENT,
                BUILD_DATE = BUILD_DATE,
                COMMENTS = COMMENTS,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_BUILD_VERSION", oBuild_version, "BUILD_VERSION_ID");
            return oBuild_version.BUILD_VERSION_ID;
        }
        #endregion
        #region Edit_Default_settings
        public int? Edit_Default_settings(int? DEFAULT_SETTINGS_ID, string PLATFORM_PRIMARY, string PLATFORM_BUTTON, int? DATA_RETENTION_PERIOD, int? TICKET_DURATION_IN_MINUTES, int? OTP_TTL_IN_SECONDS, string MAPBOX_GL_TOKEN, string GOOGLE_MAP_API_TOKEN, string TELUS_REQUEST_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Default_settings oDefault_settings = new Default_settings()
            {
                DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID,
                PLATFORM_PRIMARY = PLATFORM_PRIMARY,
                PLATFORM_BUTTON = PLATFORM_BUTTON,
                DATA_RETENTION_PERIOD = DATA_RETENTION_PERIOD,
                TICKET_DURATION_IN_MINUTES = TICKET_DURATION_IN_MINUTES,
                OTP_TTL_IN_SECONDS = OTP_TTL_IN_SECONDS,
                MAPBOX_GL_TOKEN = MAPBOX_GL_TOKEN,
                GOOGLE_MAP_API_TOKEN = GOOGLE_MAP_API_TOKEN,
                TELUS_REQUEST_ID = TELUS_REQUEST_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_DEFAULT_SETTINGS", oDefault_settings, "DEFAULT_SETTINGS_ID");
            return oDefault_settings.DEFAULT_SETTINGS_ID;
        }
        #endregion
        #region Edit_Default_chart_color
        public int? Edit_Default_chart_color(int? DEFAULT_CHART_COLOR_ID, int? DEFAULT_SETTINGS_ID, string COLOR, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Default_chart_color oDefault_chart_color = new Default_chart_color()
            {
                DEFAULT_CHART_COLOR_ID = DEFAULT_CHART_COLOR_ID,
                DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID,
                COLOR = COLOR,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_DEFAULT_CHART_COLOR", oDefault_chart_color, "DEFAULT_CHART_COLOR_ID");
            return oDefault_chart_color.DEFAULT_CHART_COLOR_ID;
        }
        #endregion
        #region Edit_Districtnex_module
        public int? Edit_Districtnex_module(int? DISTRICTNEX_MODULE_ID, string NAME, int? DISPLAY_ORDER, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Districtnex_module oDistrictnex_module = new Districtnex_module()
            {
                DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID,
                NAME = NAME,
                DISPLAY_ORDER = DISPLAY_ORDER,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_DISTRICTNEX_MODULE", oDistrictnex_module, "DISTRICTNEX_MODULE_ID");
            return oDistrictnex_module.DISTRICTNEX_MODULE_ID;
        }
        #endregion
    }
}
