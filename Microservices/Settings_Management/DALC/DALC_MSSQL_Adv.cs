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
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv
        public Build_version_log Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv(int? BUILD_VERSION_LOG_ID)
        {
            Build_version_log oBuild_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_VERSION_LOG_ID = BUILD_VERSION_LOG_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_LOG_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oBuild_version_log = new Build_version_log();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oBuild_version_log);
                oBuild_version_log.Build_version = new Build_version();
                oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(_query_response, "T_BUILD_VERSION_BUILD_VERSION_ID");
                oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_BUILD_VERSION_BUILD_NUMBER");
                oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_VERSION_IS_CURRENT");
                oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(_query_response, "T_BUILD_VERSION_BUILD_DATE");
                oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(_query_response, "T_BUILD_VERSION_COMMENTS");
                oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_BUILD_VERSION_ENTRY_USER_ID");
                oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_BUILD_VERSION_ENTRY_DATE");
                oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_BUILD_VERSION_LAST_UPDATE");
                oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_VERSION_IS_DELETED");
                oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_BUILD_VERSION_OWNER_ID");
                oBuild_version_log.Build_log_type_setup = new Setup();
                oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
            }
            return oBuild_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv
        public Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(int? REMOVED_EXTRUSION_ID)
        {
            Removed_extrusion oRemoved_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_REMOVED_EXTRUSION_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRemoved_extrusion = new Removed_extrusion();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRemoved_extrusion);
                oRemoved_extrusion.Data_level_setup = new Setup();
                oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_ID");
                oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETED");
                oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_VALUE");
                oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_OWNER_ID");
            }
            return oRemoved_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv
        public Alert_settings Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv(long? ALERT_SETTINGS_ID)
        {
            Alert_settings oAlert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.ALERT_SETTINGS_ID = ALERT_SETTINGS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_ALERT_SETTINGS_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oAlert_settings = new Alert_settings();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oAlert_settings);
                oAlert_settings.Kpi = new Kpi();
                oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_KPI_ID");
                oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_DIMENSION_ID");
                oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_SETUP_CATEGORY_ID");
                oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(_query_response, "T_KPI_NAME");
                oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(_query_response, "T_KPI_UNIT");
                oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_KPI_TYPE_SETUP_ID");
                oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(_query_response, "T_KPI_HAS_CORRELATION");
                oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_TRENDLINE");
                oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_DECIMAL_VALUE");
                oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(_query_response, "T_KPI_HAS_SQM");
                oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_BY_SEVERITY");
                oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_ADDITIVE_DATA");
                oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(_query_response, "T_KPI_MINIMUM_VALUE");
                oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(_query_response, "T_KPI_MAXIMUM_VALUE");
                oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_LATEST_DATA_CREATION_DATE");
                oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_AUTO_GENERATE");
                oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_EXTERNAL");
                oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(_query_response, "T_KPI_HAS_ALERTS");
                oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_ENTRY_USER_ID");
                oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_ENTRY_DATE");
                oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_LAST_UPDATE");
                oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_DELETED");
                oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_OWNER_ID");
                oAlert_settings.Operation_setup = new Setup();
                oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_OPERATION_SETUP_SETUP_ID");
                oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_OPERATION_SETUP_IS_SYSTEM");
                oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_OPERATION_SETUP_IS_DELETEABLE");
                oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_OPERATION_SETUP_IS_UPDATEABLE");
                oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_OPERATION_SETUP_IS_DELETED");
                oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_OPERATION_SETUP_IS_VISIBLE");
                oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_OPERATION_SETUP_DISPLAY_ORDER");
                oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_OPERATION_SETUP_VALUE");
                oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_OPERATION_SETUP_DESCRIPTION");
                oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_OPERATION_SETUP_ENTRY_USER_ID");
                oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_OPERATION_SETUP_ENTRY_DATE");
                oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_OPERATION_SETUP_LAST_UPDATE");
                oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_OPERATION_SETUP_OWNER_ID");
                oAlert_settings.Value_type_setup = new Setup();
                oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VALUE_TYPE_SETUP_SETUP_ID");
                oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VALUE_TYPE_SETUP_IS_DELETED");
                oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_VALUE_TYPE_SETUP_VALUE");
                oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VALUE_TYPE_SETUP_OWNER_ID");
                oAlert_settings.User = new User();
                oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_USER_ID");
                oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_ORGANIZATION_ID");
                oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_USER_TYPE_SETUP_ID");
                oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_OWNER_ID");
                oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(_query_response, "T_USER_FIRST_NAME");
                oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(_query_response, "T_USER_LAST_NAME");
                oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(_query_response, "T_USER_USERNAME");
                oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(_query_response, "T_USER_PASSWORD");
                oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(_query_response, "T_USER_EMAIL");
                oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_USER_PHONE_NUMBER");
                oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_USER_IMAGE_URL");
                oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_ACTIVE");
                oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_DELETED");
                oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_RECEIVE_EMAIL");
                oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_USER_DATA_RETENTION_PERIOD");
                oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(_query_response, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(_query_response, "T_USER_USER_ADMIN_WALKTHROUGH");
                oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_USER_DATE_DELETED");
                oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_USER_ENTRY_DATE");
                oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_ENTRY_USER_ID");
                oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_USER_LAST_UPDATE");
            }
            return oAlert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv
        public Default_settings_image Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv(int? DEFAULT_SETTINGS_IMAGE_ID)
        {
            Default_settings_image oDefault_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_IMAGE_ID = DEFAULT_SETTINGS_IMAGE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_IMAGE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDefault_settings_image = new Default_settings_image();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDefault_settings_image);
                oDefault_settings_image.Default_settings = new Default_settings();
                oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DEFAULT_SETTINGS_IS_DELETED");
                oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_OWNER_ID");
                oDefault_settings_image.Image_type_setup = new Setup();
                oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_VALUE");
                oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_IMAGE_TYPE_SETUP_OWNER_ID");
            }
            return oDefault_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_Adv
        public Build_version Get_Build_version_By_BUILD_VERSION_ID_Adv(int? BUILD_VERSION_ID)
        {
            Build_version oBuild_version = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_VERSION_ID = BUILD_VERSION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_BUILD_VERSION_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oBuild_version = new Build_version();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oBuild_version);
                oBuild_version.Application_name_setup = new Setup();
                oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_APPLICATION_NAME_SETUP_VALUE");
                oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_APPLICATION_NAME_SETUP_OWNER_ID");
            }
            return oBuild_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv
        public Default_chart_color Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv(int? DEFAULT_CHART_COLOR_ID)
        {
            Default_chart_color oDefault_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_CHART_COLOR_ID = DEFAULT_CHART_COLOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_CHART_COLOR_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDefault_chart_color = new Default_chart_color();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDefault_chart_color);
                oDefault_chart_color.Default_settings = new Default_settings();
                oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DEFAULT_SETTINGS_IS_DELETED");
                oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DEFAULT_SETTINGS_OWNER_ID");
                oDefault_chart_color.Data_level_setup = new Setup();
                oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_ID");
                oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETED");
                oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_VALUE");
                oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_OWNER_ID");
            }
            return oDefault_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv(IEnumerable<int?> BUILD_VERSION_LOG_ID_LIST)
        {
            List<Build_version_log> oList_Build_version_log = null;
            if (BUILD_VERSION_LOG_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_VERSION_LOG_ID_LIST = string.Join(",", BUILD_VERSION_LOG_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_LOG_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Build_version_log = new List<Build_version_log>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version_log oBuild_version_log = new Build_version_log();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                            oBuild_version_log.Build_version = new Build_version();
                            oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                            oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                            oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                            oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                            oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                            oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                            oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                            oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                            oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                            oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                            oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                            oBuild_version_log.Build_log_type_setup = new Setup();
                            oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                            oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                            oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                            oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                            oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                            oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                            oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                            oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                            oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                            oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                            oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                            oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                            oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                            oList_Build_version_log.Add(oBuild_version_log);
                        }
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (REMOVED_EXTRUSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REMOVED_EXTRUSION_ID_LIST = string.Join(",", REMOVED_EXTRUSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_REMOVED_EXTRUSION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oRemoved_extrusion.Data_level_setup = new Setup();
                            oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv(IEnumerable<long?> ALERT_SETTINGS_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (ALERT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ALERT_SETTINGS_ID_LIST = string.Join(",", ALERT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_ALERT_SETTINGS_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oAlert_settings.Kpi = new Kpi();
                            oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oAlert_settings.Operation_setup = new Setup();
                            oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                            oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                            oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                            oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                            oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                            oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                            oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                            oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                            oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                            oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                            oAlert_settings.Value_type_setup = new Setup();
                            oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                            oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                            oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                            oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                            oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                            oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                            oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                            oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                            oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                            oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                            oAlert_settings.User = new User();
                            oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv(IEnumerable<int?> DEFAULT_SETTINGS_IMAGE_ID_LIST)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            if (DEFAULT_SETTINGS_IMAGE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_IMAGE_ID_LIST = string.Join(",", DEFAULT_SETTINGS_IMAGE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_IMAGE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Default_settings_image = new List<Default_settings_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings_image oDefault_settings_image = new Default_settings_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                            oDefault_settings_image.Default_settings = new Default_settings();
                            oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                            oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                            oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                            oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                            oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                            oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                            oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                            oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                            oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                            oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                            oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                            oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                            oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                            oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                            oDefault_settings_image.Image_type_setup = new Setup();
                            oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                            oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                            oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                            oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                            oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                            oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                            oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                            oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                            oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                            oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                            oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                            oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                            oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                            oList_Default_settings_image.Add(oDefault_settings_image);
                        }
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_List_Adv
        public List<Build_version> Get_Build_version_By_BUILD_VERSION_ID_List_Adv(IEnumerable<int?> BUILD_VERSION_ID_LIST)
        {
            List<Build_version> oList_Build_version = null;
            if (BUILD_VERSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_VERSION_ID_LIST = string.Join(",", BUILD_VERSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_BUILD_VERSION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Build_version = new List<Build_version>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version oBuild_version = new Build_version();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                            oBuild_version.Application_name_setup = new Setup();
                            oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                            oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                            oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                            oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                            oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                            oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                            oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                            oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                            oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                            oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                            oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                            oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                            oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                            oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                            oList_Build_version.Add(oBuild_version);
                        }
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv(IEnumerable<int?> DEFAULT_CHART_COLOR_ID_LIST)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            if (DEFAULT_CHART_COLOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_CHART_COLOR_ID_LIST = string.Join(",", DEFAULT_CHART_COLOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_CHART_COLOR_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Default_chart_color = new List<Default_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_chart_color oDefault_chart_color = new Default_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                            oDefault_chart_color.Default_settings = new Default_settings();
                            oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                            oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                            oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                            oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                            oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                            oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                            oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                            oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                            oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                            oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                            oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                            oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                            oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                            oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                            oDefault_chart_color.Data_level_setup = new Setup();
                            oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Default_chart_color.Add(oDefault_chart_color);
                        }
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_Adv
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                        oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                        oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                        oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                        oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                        oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                        oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                        oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                        oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                        oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                        oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                        oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                        oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                        oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                        oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                        oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                        oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                        oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                        oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_Adv(int? BUILD_VERSION_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_VERSION_ID = BUILD_VERSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                        oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                        oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                        oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                        oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                        oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                        oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                        oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                        oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                        oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                        oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                        oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                        oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                        oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                        oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                        oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                        oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                        oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                        oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv(long? BUILD_LOG_TYPE_SETUP_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_LOG_TYPE_SETUP_ID = BUILD_LOG_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_LOG_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                        oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                        oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                        oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                        oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                        oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                        oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                        oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                        oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                        oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                        oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                        oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                        oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                        oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                        oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                        oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                        oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                        oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                        oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                        oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                        oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                        oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                        oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                        oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                        oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                        oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                        oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                        oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                        oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                        oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                        oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                        oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                        oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                        oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                        oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                        oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                        oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_Adv(long? LEVEL_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.LEVEL_ID = LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_Adv(long? OPERATION_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OPERATION_SETUP_ID = OPERATION_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OPERATION_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_USER_ID_Adv(long? USER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_USER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID_Adv(int? KPI_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_KPI_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv(long? VALUE_TYPE_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE_TYPE_SETUP_ID = VALUE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_VALUE_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_settings_image.Image_type_setup = new Setup();
                        oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv(int? DEFAULT_SETTINGS_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_settings_image.Image_type_setup = new Setup();
                        oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv(long? IMAGE_TYPE_SETUP_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_IMAGE_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_settings_image.Image_type_setup = new Setup();
                        oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_settings_image.Image_type_setup = new Setup();
                        oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID_Adv
        public List<Build_version> Get_Build_version_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                        oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                        oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                        oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                        oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                        oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                        oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                        oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                        oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                        oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                        oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                        oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                        oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv(long? APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_APPLICATION_NAME_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                        oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                        oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                        oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                        oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                        oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                        oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                        oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                        oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                        oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                        oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                        oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                        oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID_IS_DELETED_Adv
        public List<Build_version> Get_Build_version_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                        oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                        oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                        oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                        oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                        oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                        oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                        oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                        oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                        oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                        oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                        oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                        oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv
        public List<Build_version> Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv(bool IS_CURRENT, long? APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.IS_CURRENT = IS_CURRENT;
            _params.APPLICATION_NAME_SETUP_ID = APPLICATION_NAME_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_IS_CURRENT_APPLICATION_NAME_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                        oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                        oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                        oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                        oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                        oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                        oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                        oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                        oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                        oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                        oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                        oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                        oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_chart_color.Data_level_setup = new Setup();
                        oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv(int? DEFAULT_SETTINGS_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DEFAULT_SETTINGS_ID = DEFAULT_SETTINGS_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_SETTINGS_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_chart_color.Data_level_setup = new Setup();
                        oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_chart_color.Data_level_setup = new Setup();
                        oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_chart_color.Data_level_setup = new Setup();
                        oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv(IEnumerable<int?> BUILD_VERSION_ID_LIST)
        {
            List<Build_version_log> oList_Build_version_log = null;
            if (BUILD_VERSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_VERSION_ID_LIST = string.Join(",", BUILD_VERSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_VERSION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Build_version_log = new List<Build_version_log>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version_log oBuild_version_log = new Build_version_log();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                            oBuild_version_log.Build_version = new Build_version();
                            oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                            oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                            oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                            oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                            oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                            oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                            oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                            oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                            oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                            oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                            oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                            oBuild_version_log.Build_log_type_setup = new Setup();
                            oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                            oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                            oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                            oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                            oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                            oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                            oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                            oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                            oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                            oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                            oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                            oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                            oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                            oList_Build_version_log.Add(oBuild_version_log);
                        }
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST)
        {
            List<Build_version_log> oList_Build_version_log = null;
            if (BUILD_LOG_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.BUILD_LOG_TYPE_SETUP_ID_LIST = string.Join(",", BUILD_LOG_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_BUILD_LOG_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Build_version_log = new List<Build_version_log>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version_log oBuild_version_log = new Build_version_log();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                            oBuild_version_log.Build_version = new Build_version();
                            oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                            oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                            oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                            oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                            oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                            oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                            oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                            oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                            oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                            oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                            oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                            oBuild_version_log.Build_log_type_setup = new Setup();
                            oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                            oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                            oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                            oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                            oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                            oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                            oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                            oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                            oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                            oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                            oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                            oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                            oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                            oList_Build_version_log.Add(oBuild_version_log);
                        }
                    }
                }
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List_Adv(IEnumerable<long?> LEVEL_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LEVEL_ID_LIST = string.Join(",", LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oRemoved_extrusion.Data_level_setup = new Setup();
                            oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oRemoved_extrusion.Data_level_setup = new Setup();
                            oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv(IEnumerable<long?> OPERATION_SETUP_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (OPERATION_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.OPERATION_SETUP_ID_LIST = string.Join(",", OPERATION_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_OPERATION_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oAlert_settings.Kpi = new Kpi();
                            oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oAlert_settings.Operation_setup = new Setup();
                            oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                            oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                            oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                            oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                            oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                            oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                            oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                            oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                            oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                            oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                            oAlert_settings.Value_type_setup = new Setup();
                            oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                            oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                            oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                            oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                            oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                            oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                            oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                            oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                            oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                            oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                            oAlert_settings.User = new User();
                            oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_USER_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oAlert_settings.Kpi = new Kpi();
                            oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oAlert_settings.Operation_setup = new Setup();
                            oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                            oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                            oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                            oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                            oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                            oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                            oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                            oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                            oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                            oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                            oAlert_settings.Value_type_setup = new Setup();
                            oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                            oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                            oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                            oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                            oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                            oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                            oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                            oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                            oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                            oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                            oAlert_settings.User = new User();
                            oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_KPI_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oAlert_settings.Kpi = new Kpi();
                            oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oAlert_settings.Operation_setup = new Setup();
                            oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                            oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                            oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                            oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                            oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                            oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                            oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                            oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                            oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                            oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                            oAlert_settings.Value_type_setup = new Setup();
                            oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                            oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                            oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                            oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                            oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                            oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                            oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                            oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                            oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                            oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                            oAlert_settings.User = new User();
                            oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST)
        {
            List<Alert_settings> oList_Alert_settings = null;
            if (VALUE_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VALUE_TYPE_SETUP_ID_LIST = string.Join(",", VALUE_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_VALUE_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Alert_settings = new List<Alert_settings>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Alert_settings oAlert_settings = new Alert_settings();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                            oAlert_settings.Kpi = new Kpi();
                            oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oAlert_settings.Operation_setup = new Setup();
                            oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                            oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                            oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                            oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                            oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                            oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                            oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                            oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                            oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                            oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                            oAlert_settings.Value_type_setup = new Setup();
                            oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                            oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                            oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                            oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                            oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                            oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                            oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                            oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                            oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                            oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                            oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                            oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                            oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                            oAlert_settings.User = new User();
                            oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Alert_settings.Add(oAlert_settings);
                        }
                    }
                }
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            if (DEFAULT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_ID_LIST = string.Join(",", DEFAULT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_DEFAULT_SETTINGS_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Default_settings_image = new List<Default_settings_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings_image oDefault_settings_image = new Default_settings_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                            oDefault_settings_image.Default_settings = new Default_settings();
                            oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                            oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                            oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                            oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                            oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                            oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                            oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                            oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                            oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                            oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                            oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                            oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                            oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                            oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                            oDefault_settings_image.Image_type_setup = new Setup();
                            oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                            oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                            oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                            oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                            oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                            oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                            oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                            oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                            oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                            oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                            oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                            oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                            oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                            oList_Default_settings_image.Add(oDefault_settings_image);
                        }
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            if (IMAGE_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.IMAGE_TYPE_SETUP_ID_LIST = string.Join(",", IMAGE_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_IMAGE_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Default_settings_image = new List<Default_settings_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_settings_image oDefault_settings_image = new Default_settings_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                            oDefault_settings_image.Default_settings = new Default_settings();
                            oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                            oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                            oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                            oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                            oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                            oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                            oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                            oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                            oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                            oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                            oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                            oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                            oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                            oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                            oDefault_settings_image.Image_type_setup = new Setup();
                            oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                            oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                            oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                            oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                            oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                            oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                            oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                            oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                            oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                            oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                            oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                            oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                            oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                            oList_Default_settings_image.Add(oDefault_settings_image);
                        }
                    }
                }
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv(IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST)
        {
            List<Build_version> oList_Build_version = null;
            if (APPLICATION_NAME_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.APPLICATION_NAME_SETUP_ID_LIST = string.Join(",", APPLICATION_NAME_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_APPLICATION_NAME_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Build_version = new List<Build_version>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Build_version oBuild_version = new Build_version();
                            Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                            oBuild_version.Application_name_setup = new Setup();
                            oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                            oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                            oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                            oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                            oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                            oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                            oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                            oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                            oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                            oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                            oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                            oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                            oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                            oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                            oList_Build_version.Add(oBuild_version);
                        }
                    }
                }
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            if (DEFAULT_SETTINGS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DEFAULT_SETTINGS_ID_LIST = string.Join(",", DEFAULT_SETTINGS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DEFAULT_SETTINGS_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Default_chart_color = new List<Default_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_chart_color oDefault_chart_color = new Default_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                            oDefault_chart_color.Default_settings = new Default_settings();
                            oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                            oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                            oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                            oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                            oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                            oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                            oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                            oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                            oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                            oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                            oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                            oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                            oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                            oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                            oDefault_chart_color.Data_level_setup = new Setup();
                            oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Default_chart_color.Add(oDefault_chart_color);
                        }
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Default_chart_color = new List<Default_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Default_chart_color oDefault_chart_color = new Default_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                            oDefault_chart_color.Default_settings = new Default_settings();
                            oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                            oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                            oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                            oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                            oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                            oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                            oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                            oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                            oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                            oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                            oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                            oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                            oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                            oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                            oDefault_chart_color.Data_level_setup = new Setup();
                            oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Default_chart_color.Add(oDefault_chart_color);
                        }
                    }
                }
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_Where_Adv
        public List<Build_version_log> Get_Build_version_log_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Build_version_log> oList_Build_version_log = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                        oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                        oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                        oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                        oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                        oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                        oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                        oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                        oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                        oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                        oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                        oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                        oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                        oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                        oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                        oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                        oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                        oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                        oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_Adv(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where_Adv
        public List<Alert_settings> Get_Alert_settings_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Alert_settings> oList_Alert_settings = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_Where_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_NAME = IMAGE_NAME;
            _params.IMAGE_EXTENSION = IMAGE_EXTENSION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_settings_image.Image_type_setup = new Setup();
                        oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_Where_Adv
        public List<Build_version> Get_Build_version_By_Where_Adv(string BUILD_NUMBER, string COMMENTS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Build_version> oList_Build_version = null;
            dynamic _params = new ExpandoObject();
            _params.BUILD_NUMBER = BUILD_NUMBER;
            _params.COMMENTS = COMMENTS;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                        oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                        oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                        oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                        oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                        oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                        oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                        oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                        oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                        oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                        oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                        oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                        oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_Where_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_Where_Adv(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.COLOR = COLOR;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_chart_color.Data_level_setup = new Setup();
                        oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_Where_In_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> BUILD_VERSION_ID_LIST, IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_LOG_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        oBuild_version_log.Build_version.BUILD_VERSION_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_BUILD_VERSION_ID");
                        oBuild_version_log.Build_version.BUILD_NUMBER = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_NUMBER");
                        oBuild_version_log.Build_version.APPLICATION_NAME_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_APPLICATION_NAME_SETUP_ID");
                        oBuild_version_log.Build_version.IS_CURRENT = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_CURRENT");
                        oBuild_version_log.Build_version.BUILD_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_BUILD_DATE");
                        oBuild_version_log.Build_version.COMMENTS = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_COMMENTS");
                        oBuild_version_log.Build_version.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_VERSION_ENTRY_USER_ID");
                        oBuild_version_log.Build_version.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_ENTRY_DATE");
                        oBuild_version_log.Build_version.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_VERSION_LAST_UPDATE");
                        oBuild_version_log.Build_version.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_VERSION_IS_DELETED");
                        oBuild_version_log.Build_version.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_VERSION_OWNER_ID");
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        oBuild_version_log.Build_log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_ID");
                        oBuild_version_log.Build_log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version_log.Build_log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_SYSTEM");
                        oBuild_version_log.Build_log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oBuild_version_log.Build_log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_DELETED");
                        oBuild_version_log.Build_log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_BUILD_LOG_TYPE_SETUP_IS_VISIBLE");
                        oBuild_version_log.Build_log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oBuild_version_log.Build_log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_VALUE");
                        oBuild_version_log.Build_log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_DESCRIPTION");
                        oBuild_version_log.Build_log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oBuild_version_log.Build_log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_ENTRY_DATE");
                        oBuild_version_log.Build_log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_BUILD_LOG_TYPE_SETUP_LAST_UPDATE");
                        oBuild_version_log.Build_log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_BUILD_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List_Adv(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER;
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        oRemoved_extrusion.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oRemoved_extrusion.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oRemoved_extrusion.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oRemoved_extrusion.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oRemoved_extrusion.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oRemoved_extrusion.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oRemoved_extrusion.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oRemoved_extrusion.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oRemoved_extrusion.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oRemoved_extrusion.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oRemoved_extrusion.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oRemoved_extrusion.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oRemoved_extrusion.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where_In_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST, IEnumerable<long?> OPERATION_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ALERT_SETTINGS_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        oAlert_settings.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oAlert_settings.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oAlert_settings.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oAlert_settings.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oAlert_settings.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oAlert_settings.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oAlert_settings.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oAlert_settings.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oAlert_settings.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oAlert_settings.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oAlert_settings.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oAlert_settings.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oAlert_settings.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oAlert_settings.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oAlert_settings.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oAlert_settings.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oAlert_settings.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oAlert_settings.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oAlert_settings.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oAlert_settings.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oAlert_settings.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oAlert_settings.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oAlert_settings.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oAlert_settings.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oAlert_settings.Operation_setup = new Setup();
                        oAlert_settings.Operation_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_SETUP_ID");
                        oAlert_settings.Operation_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Operation_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_SYSTEM");
                        oAlert_settings.Operation_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETEABLE");
                        oAlert_settings.Operation_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Operation_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_DELETED");
                        oAlert_settings.Operation_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_OPERATION_SETUP_IS_VISIBLE");
                        oAlert_settings.Operation_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Operation_setup.VALUE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_VALUE");
                        oAlert_settings.Operation_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_DESCRIPTION");
                        oAlert_settings.Operation_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_OPERATION_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Operation_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_ENTRY_DATE");
                        oAlert_settings.Operation_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_OPERATION_SETUP_LAST_UPDATE");
                        oAlert_settings.Operation_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_OPERATION_SETUP_OWNER_ID");
                        oAlert_settings.Value_type_setup = new Setup();
                        oAlert_settings.Value_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_SETUP_ID");
                        oAlert_settings.Value_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAlert_settings.Value_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_SYSTEM");
                        oAlert_settings.Value_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETEABLE");
                        oAlert_settings.Value_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_UPDATEABLE");
                        oAlert_settings.Value_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_DELETED");
                        oAlert_settings.Value_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VALUE_TYPE_SETUP_IS_VISIBLE");
                        oAlert_settings.Value_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_DISPLAY_ORDER");
                        oAlert_settings.Value_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_VALUE");
                        oAlert_settings.Value_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_DESCRIPTION");
                        oAlert_settings.Value_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VALUE_TYPE_SETUP_ENTRY_USER_ID");
                        oAlert_settings.Value_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_ENTRY_DATE");
                        oAlert_settings.Value_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VALUE_TYPE_SETUP_LAST_UPDATE");
                        oAlert_settings.Value_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VALUE_TYPE_SETUP_OWNER_ID");
                        oAlert_settings.User = new User();
                        oAlert_settings.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oAlert_settings.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oAlert_settings.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oAlert_settings.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oAlert_settings.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oAlert_settings.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oAlert_settings.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oAlert_settings.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oAlert_settings.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oAlert_settings.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oAlert_settings.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oAlert_settings.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oAlert_settings.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oAlert_settings.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oAlert_settings.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oAlert_settings.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oAlert_settings.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oAlert_settings.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oAlert_settings.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oAlert_settings.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oAlert_settings.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where_In_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_Where_In_List_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_SETTINGS_IMAGE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        oDefault_settings_image.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_settings_image.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_settings_image.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_settings_image.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_settings_image.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_settings_image.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_settings_image.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_settings_image.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_settings_image.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_settings_image.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_settings_image.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_settings_image.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_settings_image.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_settings_image.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_settings_image.Image_type_setup = new Setup();
                        oDefault_settings_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oDefault_settings_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDefault_settings_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oDefault_settings_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oDefault_settings_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oDefault_settings_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oDefault_settings_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oDefault_settings_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oDefault_settings_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oDefault_settings_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oDefault_settings_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oDefault_settings_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oDefault_settings_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oDefault_settings_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_Where_In_List_Adv
        public List<Build_version> Get_Build_version_By_Where_In_List_Adv(string BUILD_NUMBER, string COMMENTS, IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_BUILD_VERSION_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Build_version = new List<Build_version>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values_From_Data_Record(element, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        oBuild_version.Application_name_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_SETUP_ID");
                        oBuild_version.Application_name_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_SETUP_CATEGORY_ID");
                        oBuild_version.Application_name_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_SYSTEM");
                        oBuild_version.Application_name_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETEABLE");
                        oBuild_version.Application_name_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_UPDATEABLE");
                        oBuild_version.Application_name_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_DELETED");
                        oBuild_version.Application_name_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_APPLICATION_NAME_SETUP_IS_VISIBLE");
                        oBuild_version.Application_name_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_DISPLAY_ORDER");
                        oBuild_version.Application_name_setup.VALUE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_VALUE");
                        oBuild_version.Application_name_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_DESCRIPTION");
                        oBuild_version.Application_name_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_APPLICATION_NAME_SETUP_ENTRY_USER_ID");
                        oBuild_version.Application_name_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_ENTRY_DATE");
                        oBuild_version.Application_name_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_APPLICATION_NAME_SETUP_LAST_UPDATE");
                        oBuild_version.Application_name_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_APPLICATION_NAME_SETUP_OWNER_ID");
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_Where_In_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_Where_In_List_Adv(string COLOR, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DEFAULT_CHART_COLOR_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        oDefault_chart_color.Default_settings.DEFAULT_SETTINGS_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DEFAULT_SETTINGS_ID");
                        oDefault_chart_color.Default_settings.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_PRIMARY");
                        oDefault_chart_color.Default_settings.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_PLATFORM_BUTTON");
                        oDefault_chart_color.Default_settings.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_DATA_RETENTION_PERIOD");
                        oDefault_chart_color.Default_settings.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_TICKET_DURATION_IN_MINUTES");
                        oDefault_chart_color.Default_settings.OTP_TTL_IN_SECONDS = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OTP_TTL_IN_SECONDS");
                        oDefault_chart_color.Default_settings.MAPBOX_GL_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_MAPBOX_GL_TOKEN");
                        oDefault_chart_color.Default_settings.GOOGLE_MAP_API_TOKEN = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_GOOGLE_MAP_API_TOKEN");
                        oDefault_chart_color.Default_settings.TELUS_REQUEST_ID = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_TELUS_REQUEST_ID");
                        oDefault_chart_color.Default_settings.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DEFAULT_SETTINGS_ENTRY_USER_ID");
                        oDefault_chart_color.Default_settings.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_ENTRY_DATE");
                        oDefault_chart_color.Default_settings.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DEFAULT_SETTINGS_LAST_UPDATE");
                        oDefault_chart_color.Default_settings.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DEFAULT_SETTINGS_IS_DELETED");
                        oDefault_chart_color.Default_settings.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DEFAULT_SETTINGS_OWNER_ID");
                        oDefault_chart_color.Data_level_setup = new Setup();
                        oDefault_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oDefault_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oDefault_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oDefault_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oDefault_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oDefault_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oDefault_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oDefault_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oDefault_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oDefault_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oDefault_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oDefault_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oDefault_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oDefault_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Default_chart_color;
        }
        #endregion
    }
}
