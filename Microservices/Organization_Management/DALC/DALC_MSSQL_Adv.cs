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
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv
        public Organization_theme Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv(int? ORGANIZATION_THEME_ID)
        {
            Organization_theme oOrganization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_THEME_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_theme = new Organization_theme();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_theme);
                oOrganization_theme.Organization = new Organization();
                oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
            }
            return oOrganization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_Adv
        public Organization Get_Organization_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            Organization oOrganization = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization = new Organization();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization);
                oOrganization.Organization_type_setup = new Setup();
                oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
            }
            return oOrganization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv
        public Organization_level_access Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(long? ORGANIZATION_LEVEL_ACCESS_ID)
        {
            Organization_level_access oOrganization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_level_access = new Organization_level_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_level_access);
                oOrganization_level_access.Organization = new Organization();
                oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
                oOrganization_level_access.Data_level_setup = new Setup();
                oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_ID");
                oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETED");
                oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_VALUE");
                oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_OWNER_ID");
            }
            return oOrganization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv
        public Organization_log_config Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv(long? ORGANIZATION_LOG_CONFIG_ID)
        {
            Organization_log_config oOrganization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_LOG_CONFIG_ID = ORGANIZATION_LOG_CONFIG_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_LOG_CONFIG_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_log_config = new Organization_log_config();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_log_config);
                oOrganization_log_config.Organization = new Organization();
                oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
                oOrganization_log_config.Log_type_setup = new Setup();
                oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_LOG_TYPE_SETUP_SETUP_ID");
                oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_LOG_TYPE_SETUP_IS_DELETED");
                oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_LOG_TYPE_SETUP_VALUE");
                oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_LOG_TYPE_SETUP_DESCRIPTION");
                oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_LOG_TYPE_SETUP_OWNER_ID");
            }
            return oOrganization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv
        public Organization_color_scheme Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(int? ORGANIZATION_COLOR_SCHEME_ID)
        {
            Organization_color_scheme oOrganization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_COLOR_SCHEME_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_color_scheme = new Organization_color_scheme();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_color_scheme);
                oOrganization_color_scheme.Organization = new Organization();
                oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
            }
            return oOrganization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv
        public Organization_image Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv(int? ORGANIZATION_IMAGE_ID)
        {
            Organization_image oOrganization_image = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_IMAGE_ID = ORGANIZATION_IMAGE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_IMAGE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_image = new Organization_image();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_image);
                oOrganization_image.Organization = new Organization();
                oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
                oOrganization_image.Image_type_setup = new Setup();
                oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_VALUE");
                oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_IMAGE_TYPE_SETUP_OWNER_ID");
            }
            return oOrganization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv
        public Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(int? ORGANIZATION_RELATION_ID)
        {
            Organization_relation oOrganization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_ORGANIZATION_RELATION_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_relation = new Organization_relation();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_relation);
                oOrganization_relation.User = new User();
                oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_USER_ID");
                oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_ORGANIZATION_ID");
                oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_USER_TYPE_SETUP_ID");
                oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_OWNER_ID");
                oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(_query_response, "T_USER_FIRST_NAME");
                oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(_query_response, "T_USER_LAST_NAME");
                oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(_query_response, "T_USER_USERNAME");
                oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(_query_response, "T_USER_PASSWORD");
                oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(_query_response, "T_USER_EMAIL");
                oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_USER_PHONE_NUMBER");
                oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_USER_IMAGE_URL");
                oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_ACTIVE");
                oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_DELETED");
                oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_RECEIVE_EMAIL");
                oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_USER_DATA_RETENTION_PERIOD");
                oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(_query_response, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(_query_response, "T_USER_USER_ADMIN_WALKTHROUGH");
                oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_USER_DATE_DELETED");
                oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_USER_ENTRY_DATE");
                oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_ENTRY_USER_ID");
                oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_USER_LAST_UPDATE");
            }
            return oOrganization_relation;
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
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_data_source_kpi = new Organization_data_source_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_data_source_kpi);
                oOrganization_data_source_kpi.Data_source = new Data_source();
                oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_SOURCE_DATA_SOURCE_ID");
                oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(_query_response, "T_DATA_SOURCE_NAME");
                oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(_query_response, "T_DATA_SOURCE_API_URL");
                oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_SOURCE_ENTRY_USER_ID");
                oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_SOURCE_ENTRY_DATE");
                oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_SOURCE_LAST_UPDATE");
                oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DATA_SOURCE_IS_DELETED");
                oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_SOURCE_OWNER_ID");
                oOrganization_data_source_kpi.Kpi = new Kpi();
                oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_KPI_ID");
                oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_DIMENSION_ID");
                oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_SETUP_CATEGORY_ID");
                oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(_query_response, "T_KPI_NAME");
                oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(_query_response, "T_KPI_UNIT");
                oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_KPI_TYPE_SETUP_ID");
                oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(_query_response, "T_KPI_HAS_CORRELATION");
                oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_TRENDLINE");
                oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_DECIMAL_VALUE");
                oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(_query_response, "T_KPI_HAS_SQM");
                oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_BY_SEVERITY");
                oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_ADDITIVE_DATA");
                oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(_query_response, "T_KPI_MINIMUM_VALUE");
                oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(_query_response, "T_KPI_MAXIMUM_VALUE");
                oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_LATEST_DATA_CREATION_DATE");
                oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_AUTO_GENERATE");
                oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_EXTERNAL");
                oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(_query_response, "T_KPI_HAS_ALERTS");
                oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_ENTRY_USER_ID");
                oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_ENTRY_DATE");
                oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_LAST_UPDATE");
                oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_KPI_IS_DELETED");
                oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_OWNER_ID");
                oOrganization_data_source_kpi.Organization = new Organization();
                oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv
        public Organization_chart_color Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv(int? ORGANIZATION_CHART_COLOR_ID)
        {
            Organization_chart_color oOrganization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_CHART_COLOR_ID = ORGANIZATION_CHART_COLOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_CHART_COLOR_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_chart_color = new Organization_chart_color();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_chart_color);
                oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                oOrganization_chart_color.Data_level_setup = new Setup();
                oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_ID");
                oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_DELETED");
                oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_VALUE");
                oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DATA_LEVEL_SETUP_OWNER_ID");
            }
            return oOrganization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv
        public Organization_districtnex_module Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv(int? ORGANIZATION_DISTRICTNEX_MODULE_ID)
        {
            Organization_districtnex_module oOrganization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DISTRICTNEX_MODULE_ID = ORGANIZATION_DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_DISTRICTNEX_MODULE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_districtnex_module = new Organization_districtnex_module();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_districtnex_module);
                oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICTNEX_MODULE_NAME");
                oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DISTRICTNEX_MODULE_IS_DELETED");
                oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICTNEX_MODULE_OWNER_ID");
                oOrganization_districtnex_module.Organization = new Organization();
                oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
            }
            return oOrganization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST)
        {
            List<Organization_theme> oList_Organization_theme = null;
            if (ORGANIZATION_THEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_THEME_ID_LIST = string.Join(",", ORGANIZATION_THEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_THEME_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_theme = new List<Organization_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_theme oOrganization_theme = new Organization_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                            oOrganization_theme.Organization = new Organization();
                            oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_theme.Add(oOrganization_theme);
                        }
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization> oList_Organization = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization = new List<Organization>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization oOrganization = new Organization();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                            oOrganization.Organization_type_setup = new Setup();
                            oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                            oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                            oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                            oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                            oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                            oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                            oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                            oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                            oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                            oList_Organization.Add(oOrganization);
                        }
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (ORGANIZATION_LEVEL_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_LEVEL_ACCESS_ID_LIST = string.Join(",", ORGANIZATION_LEVEL_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oOrganization_level_access.Organization = new Organization();
                            oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_level_access.Data_level_setup = new Setup();
                            oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv(IEnumerable<long?> ORGANIZATION_LOG_CONFIG_ID_LIST)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            if (ORGANIZATION_LOG_CONFIG_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_LOG_CONFIG_ID_LIST = string.Join(",", ORGANIZATION_LOG_CONFIG_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_LOG_CONFIG_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_log_config = new List<Organization_log_config>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_log_config oOrganization_log_config = new Organization_log_config();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                            oOrganization_log_config.Organization = new Organization();
                            oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_log_config.Log_type_setup = new Setup();
                            oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                            oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                            oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                            oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                            oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                            oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                            oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                            oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                            oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                            oList_Organization_log_config.Add(oOrganization_log_config);
                        }
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            if (ORGANIZATION_COLOR_SCHEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_COLOR_SCHEME_ID_LIST = string.Join(",", ORGANIZATION_COLOR_SCHEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_COLOR_SCHEME_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_color_scheme = new List<Organization_color_scheme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                            oOrganization_color_scheme.Organization = new Organization();
                            oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                        }
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv(IEnumerable<int?> ORGANIZATION_IMAGE_ID_LIST)
        {
            List<Organization_image> oList_Organization_image = null;
            if (ORGANIZATION_IMAGE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_IMAGE_ID_LIST = string.Join(",", ORGANIZATION_IMAGE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_IMAGE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_image = new List<Organization_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_image oOrganization_image = new Organization_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                            oOrganization_image.Organization = new Organization();
                            oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_image.Image_type_setup = new Setup();
                            oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                            oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                            oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                            oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                            oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                            oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                            oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                            oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                            oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                            oList_Organization_image.Add(oOrganization_image);
                        }
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (ORGANIZATION_RELATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_RELATION_ID_LIST = string.Join(",", ORGANIZATION_RELATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_ORGANIZATION_RELATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oOrganization_relation.User = new User();
                            oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
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
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oOrganization_data_source_kpi.Data_source = new Data_source();
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                            oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                            oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                            oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                            oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                            oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                            oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                            oOrganization_data_source_kpi.Kpi = new Kpi();
                            oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oOrganization_data_source_kpi.Organization = new Organization();
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv(IEnumerable<int?> ORGANIZATION_CHART_COLOR_ID_LIST)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            if (ORGANIZATION_CHART_COLOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_CHART_COLOR_ID_LIST = string.Join(",", ORGANIZATION_CHART_COLOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_CHART_COLOR_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_chart_color = new List<Organization_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                            oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                            oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                            oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                            oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                            oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                            oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                            oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                            oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                            oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                            oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                            oOrganization_chart_color.Data_level_setup = new Setup();
                            oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_chart_color.Add(oOrganization_chart_color);
                        }
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            if (ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST = string.Join(",", ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                            oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                            oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                            oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                            oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                            oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                            oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                            oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                            oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                            oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                            oOrganization_districtnex_module.Organization = new Organization();
                            oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                        }
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_Adv
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_Adv
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_theme> Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                        oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                        oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                        oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                        oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                        oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                        oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                        oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                        oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_Adv
        public List<Organization> Get_Organization_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                        oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                        oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                        oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                        oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                        oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                        oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                        oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                        oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(long? ORGANIZATION_TYPE_SETUP_ID)
        {
            List<Organization> oList_Organization = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_TYPE_SETUP_ID = ORGANIZATION_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                        oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                        oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                        oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                        oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                        oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                        oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                        oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                        oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_Adv(long? LEVEL_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.LEVEL_ID = LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv(int? ORGANIZATION_ID, long? DATA_LEVEL_SETUP_ID)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv(long? LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_LOG_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv(int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            _params.LOG_TYPE_SETUP_ID = LOG_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID_Adv
        public List<Organization_image> Get_Organization_image_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv(long? IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_IMAGE_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_image> Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv(int? ORGANIZATION_ID, long? IMAGE_TYPE_SETUP_ID)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            _params.IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(int? PARENT_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(int? CHILD_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_Adv(long? USER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_USER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
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
        #region Get_Organization_data_source_kpi_By_OWNER_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(int? DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_SOURCE_ID = DATA_SOURCE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_Adv(int? KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                        oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                        oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                        oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(int? ORGANIZATION_COLOR_SCHEME_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_COLOR_SCHEME_ID = ORGANIZATION_COLOR_SCHEME_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_COLOR_SCHEME_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                        oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                        oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                        oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                        oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                        oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                        oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                        oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                        oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                        oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                        oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                        oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                        oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                        oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                        oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                        oOrganization_districtnex_module.Organization = new Organization();
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                        oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                        oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                        oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                        oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                        oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                        oOrganization_districtnex_module.Organization = new Organization();
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(int? DISTRICTNEX_MODULE_ID)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                        oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                        oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                        oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                        oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                        oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                        oOrganization_districtnex_module.Organization = new Organization();
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                        oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                        oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                        oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                        oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                        oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                        oOrganization_districtnex_module.Organization = new Organization();
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_List_Adv
        public List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_theme> oList_Organization_theme = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_theme = new List<Organization_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_theme oOrganization_theme = new Organization_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                            oOrganization_theme.Organization = new Organization();
                            oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_theme.Add(oOrganization_theme);
                        }
                    }
                }
            }
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST)
        {
            List<Organization> oList_Organization = null;
            if (ORGANIZATION_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_TYPE_SETUP_ID_LIST = string.Join(",", ORGANIZATION_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_ORGANIZATION_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization = new List<Organization>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization oOrganization = new Organization();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                            oOrganization.Organization_type_setup = new Setup();
                            oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                            oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                            oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                            oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                            oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                            oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                            oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                            oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                            oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                            oList_Organization.Add(oOrganization);
                        }
                    }
                }
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oOrganization_level_access.Organization = new Organization();
                            oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_level_access.Data_level_setup = new Setup();
                            oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_List_Adv(IEnumerable<long?> LEVEL_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LEVEL_ID_LIST = string.Join(",", LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oOrganization_level_access.Organization = new Organization();
                            oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_level_access.Data_level_setup = new Setup();
                            oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_level_access = new List<Organization_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_level_access oOrganization_level_access = new Organization_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                            oOrganization_level_access.Organization = new Organization();
                            oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_level_access.Data_level_setup = new Setup();
                            oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_level_access.Add(oOrganization_level_access);
                        }
                    }
                }
            }
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_log_config = new List<Organization_log_config>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_log_config oOrganization_log_config = new Organization_log_config();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                            oOrganization_log_config.Organization = new Organization();
                            oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_log_config.Log_type_setup = new Setup();
                            oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                            oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                            oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                            oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                            oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                            oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                            oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                            oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                            oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                            oList_Organization_log_config.Add(oOrganization_log_config);
                        }
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            if (LOG_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LOG_TYPE_SETUP_ID_LIST = string.Join(",", LOG_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_LOG_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_log_config = new List<Organization_log_config>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_log_config oOrganization_log_config = new Organization_log_config();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                            oOrganization_log_config.Organization = new Organization();
                            oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_log_config.Log_type_setup = new Setup();
                            oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                            oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                            oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                            oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                            oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                            oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                            oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                            oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                            oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                            oList_Organization_log_config.Add(oOrganization_log_config);
                        }
                    }
                }
            }
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_color_scheme = new List<Organization_color_scheme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                            oOrganization_color_scheme.Organization = new Organization();
                            oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                        }
                    }
                }
            }
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_List_Adv
        public List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_image> oList_Organization_image = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_image = new List<Organization_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_image oOrganization_image = new Organization_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                            oOrganization_image.Organization = new Organization();
                            oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_image.Image_type_setup = new Setup();
                            oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                            oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                            oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                            oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                            oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                            oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                            oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                            oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                            oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                            oList_Organization_image.Add(oOrganization_image);
                        }
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv
        public List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST)
        {
            List<Organization_image> oList_Organization_image = null;
            if (IMAGE_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.IMAGE_TYPE_SETUP_ID_LIST = string.Join(",", IMAGE_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_IMAGE_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_image = new List<Organization_image>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_image oOrganization_image = new Organization_image();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                            oOrganization_image.Organization = new Organization();
                            oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oOrganization_image.Image_type_setup = new Setup();
                            oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                            oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                            oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                            oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                            oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                            oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                            oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                            oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                            oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                            oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                            oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                            oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                            oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                            oList_Organization_image.Add(oOrganization_image);
                        }
                    }
                }
            }
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (PARENT_ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.PARENT_ORGANIZATION_ID_LIST = string.Join(",", PARENT_ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oOrganization_relation.User = new User();
                            oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (CHILD_ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.CHILD_ORGANIZATION_ID_LIST = string.Join(",", CHILD_ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oOrganization_relation.User = new User();
                            oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_USER_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oOrganization_relation.User = new User();
                            oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
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
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(IEnumerable<int?> DATA_SOURCE_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (DATA_SOURCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_SOURCE_ID_LIST = string.Join(",", DATA_SOURCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oOrganization_data_source_kpi.Data_source = new Data_source();
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                            oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                            oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                            oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                            oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                            oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                            oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                            oOrganization_data_source_kpi.Kpi = new Kpi();
                            oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oOrganization_data_source_kpi.Organization = new Organization();
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oOrganization_data_source_kpi.Data_source = new Data_source();
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                            oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                            oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                            oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                            oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                            oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                            oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                            oOrganization_data_source_kpi.Kpi = new Kpi();
                            oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oOrganization_data_source_kpi.Organization = new Organization();
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oOrganization_data_source_kpi.Data_source = new Data_source();
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                            oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                            oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                            oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                            oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                            oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                            oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                            oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                            oOrganization_data_source_kpi.Kpi = new Kpi();
                            oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                            oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                            oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                            oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                            oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                            oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                            oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                            oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                            oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                            oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                            oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                            oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                            oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                            oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                            oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                            oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                            oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                            oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                            oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                            oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                            oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                            oOrganization_data_source_kpi.Organization = new Organization();
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            if (ORGANIZATION_COLOR_SCHEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_COLOR_SCHEME_ID_LIST = string.Join(",", ORGANIZATION_COLOR_SCHEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_ORGANIZATION_COLOR_SCHEME_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_chart_color = new List<Organization_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                            oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                            oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                            oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                            oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                            oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                            oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                            oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                            oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                            oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                            oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                            oOrganization_chart_color.Data_level_setup = new Setup();
                            oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_chart_color.Add(oOrganization_chart_color);
                        }
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_DATA_LEVEL_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_chart_color = new List<Organization_chart_color>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                            oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                            oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                            oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                            oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                            oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                            oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                            oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                            oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                            oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                            oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                            oOrganization_chart_color.Data_level_setup = new Setup();
                            oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                            oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                            oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                            oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                            oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                            oList_Organization_chart_color.Add(oOrganization_chart_color);
                        }
                    }
                }
            }
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                            oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                            oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                            oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                            oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                            oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                            oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                            oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                            oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                            oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                            oOrganization_districtnex_module.Organization = new Organization();
                            oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                        }
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            if (DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICTNEX_MODULE_ID_LIST = string.Join(",", DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                            oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                            oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                            oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                            oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                            oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                            oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                            oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                            oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                            oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                            oOrganization_districtnex_module.Organization = new Organization();
                            oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                        }
                    }
                }
            }
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where_Adv
        public List<Organization_theme> Get_Organization_theme_By_Where_Adv(string THEME_NAME, string THEME_CLASS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_theme> oList_Organization_theme = null;
            dynamic _params = new ExpandoObject();
            _params.THEME_NAME = THEME_NAME;
            _params.THEME_CLASS = THEME_CLASS;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where_Adv
        public List<Organization> Get_Organization_By_Where_Adv(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                        oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                        oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                        oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                        oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                        oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                        oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                        oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                        oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_level_access> oList_Organization_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_log_config> oList_Organization_log_config = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_Adv(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_color_scheme> oList_Organization_color_scheme = null;
            dynamic _params = new ExpandoObject();
            _params.PLATFORM_PRIMARY = PLATFORM_PRIMARY;
            _params.PLATFORM_BUTTON = PLATFORM_BUTTON;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_Where_Adv
        public List<Organization_image> Get_Organization_image_By_Where_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_image> oList_Organization_image = null;
            dynamic _params = new ExpandoObject();
            _params.IMAGE_NAME = IMAGE_NAME;
            _params.IMAGE_EXTENSION = IMAGE_EXTENSION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where_Adv
        public List<Organization_relation> Get_Organization_relation_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_relation;
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
        #region Get_Organization_data_source_kpi_By_Where_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where_Adv(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_chart_color> oList_Organization_chart_color = null;
            dynamic _params = new ExpandoObject();
            _params.COLOR = COLOR;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                        oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                        oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                        oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_districtnex_module> oList_Organization_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                        oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                        oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                        oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                        oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                        oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                        oOrganization_districtnex_module.Organization = new Organization();
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_districtnex_module;
        }
        #endregion
        #region Get_Organization_theme_By_Where_In_List_Adv
        public List<Organization_theme> Get_Organization_theme_By_Where_In_List_Adv(string THEME_NAME, string THEME_CLASS, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_THEME_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_theme = new List<Organization_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_theme oOrganization_theme = new Organization_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_theme);
                        oOrganization_theme.Organization = new Organization();
                        oOrganization_theme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_theme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_theme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_theme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_theme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_theme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_theme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_theme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_theme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_theme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_theme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_theme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_theme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_theme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_theme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_theme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_theme.Add(oOrganization_theme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_theme;
        }
        #endregion
        #region Get_Organization_By_Where_In_List_Adv
        public List<Organization> Get_Organization_By_Where_In_List_Adv(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization = new List<Organization>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        oOrganization.Organization_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_ID");
                        oOrganization.Organization_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization.Organization_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_SYSTEM");
                        oOrganization.Organization_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization.Organization_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization.Organization_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_DELETED");
                        oOrganization.Organization_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_TYPE_SETUP_IS_VISIBLE");
                        oOrganization.Organization_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization.Organization_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_VALUE");
                        oOrganization.Organization_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_DESCRIPTION");
                        oOrganization.Organization_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization.Organization_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_ENTRY_DATE");
                        oOrganization.Organization_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_TYPE_SETUP_LAST_UPDATE");
                        oOrganization.Organization_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TYPE_SETUP_OWNER_ID");
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_level_access_By_Where_In_List_Adv
        public List<Organization_level_access> Get_Organization_level_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LEVEL_ACCESS_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_level_access = new List<Organization_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_level_access oOrganization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_level_access);
                        oOrganization_level_access.Organization = new Organization();
                        oOrganization_level_access.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_level_access.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_level_access.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_level_access.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_level_access.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_level_access.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_level_access.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_level_access.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_level_access.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_level_access.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_level_access.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_level_access.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_level_access.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_level_access.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_level_access.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_level_access.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_level_access.Data_level_setup = new Setup();
                        oOrganization_level_access.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_level_access.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_level_access.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_level_access.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_level_access.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_level_access.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_level_access.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_level_access.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_level_access.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_level_access.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_level_access.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_level_access.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_level_access.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_level_access.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_level_access.Add(oOrganization_level_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_level_access;
        }
        #endregion
        #region Get_Organization_log_config_By_Where_In_List_Adv
        public List<Organization_log_config> Get_Organization_log_config_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_LOG_CONFIG_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_log_config = new List<Organization_log_config>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_log_config oOrganization_log_config = new Organization_log_config();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_log_config);
                        oOrganization_log_config.Organization = new Organization();
                        oOrganization_log_config.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_log_config.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_log_config.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_log_config.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_log_config.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_log_config.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_log_config.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_log_config.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_log_config.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_log_config.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_log_config.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_log_config.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_log_config.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_log_config.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_log_config.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_log_config.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_log_config.Log_type_setup = new Setup();
                        oOrganization_log_config.Log_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_SETUP_ID");
                        oOrganization_log_config.Log_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_log_config.Log_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_log_config.Log_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_log_config.Log_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_log_config.Log_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_DELETED");
                        oOrganization_log_config.Log_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_LOG_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_log_config.Log_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_log_config.Log_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_VALUE");
                        oOrganization_log_config.Log_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_DESCRIPTION");
                        oOrganization_log_config.Log_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_LOG_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_log_config.Log_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_log_config.Log_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_LOG_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_log_config.Log_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_LOG_TYPE_SETUP_OWNER_ID");
                        oList_Organization_log_config.Add(oOrganization_log_config);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_log_config;
        }
        #endregion
        #region Get_Organization_color_scheme_By_Where_In_List_Adv
        public List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_In_List_Adv(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_COLOR_SCHEME_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_color_scheme = new List<Organization_color_scheme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_color_scheme oOrganization_color_scheme = new Organization_color_scheme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_color_scheme);
                        oOrganization_color_scheme.Organization = new Organization();
                        oOrganization_color_scheme.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_color_scheme.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_color_scheme.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_color_scheme.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_color_scheme.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_color_scheme.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_color_scheme.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_color_scheme.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_color_scheme.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_color_scheme.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_color_scheme.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_color_scheme.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_color_scheme.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_color_scheme.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_color_scheme.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_color_scheme.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_color_scheme.Add(oOrganization_color_scheme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_color_scheme;
        }
        #endregion
        #region Get_Organization_image_By_Where_In_List_Adv
        public List<Organization_image> Get_Organization_image_By_Where_In_List_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_IMAGE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_image = new List<Organization_image>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_image oOrganization_image = new Organization_image();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_image);
                        oOrganization_image.Organization = new Organization();
                        oOrganization_image.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_image.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_image.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_image.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_image.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_image.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_image.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_image.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_image.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_image.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_image.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_image.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_image.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_image.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_image.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_image.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_image.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oOrganization_image.Image_type_setup = new Setup();
                        oOrganization_image.Image_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_SETUP_ID");
                        oOrganization_image.Image_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_image.Image_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_SYSTEM");
                        oOrganization_image.Image_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETEABLE");
                        oOrganization_image.Image_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_UPDATEABLE");
                        oOrganization_image.Image_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_DELETED");
                        oOrganization_image.Image_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_IMAGE_TYPE_SETUP_IS_VISIBLE");
                        oOrganization_image.Image_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_DISPLAY_ORDER");
                        oOrganization_image.Image_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_VALUE");
                        oOrganization_image.Image_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_DESCRIPTION");
                        oOrganization_image.Image_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_IMAGE_TYPE_SETUP_ENTRY_USER_ID");
                        oOrganization_image.Image_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_ENTRY_DATE");
                        oOrganization_image.Image_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_IMAGE_TYPE_SETUP_LAST_UPDATE");
                        oOrganization_image.Image_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_IMAGE_TYPE_SETUP_OWNER_ID");
                        oList_Organization_image.Add(oOrganization_image);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_image;
        }
        #endregion
        #region Get_Organization_relation_By_Where_In_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        oOrganization_relation.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oOrganization_relation.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oOrganization_relation.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oOrganization_relation.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oOrganization_relation.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oOrganization_relation.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oOrganization_relation.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oOrganization_relation.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oOrganization_relation.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oOrganization_relation.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oOrganization_relation.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oOrganization_relation.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oOrganization_relation.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oOrganization_relation.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oOrganization_relation.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oOrganization_relation.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oOrganization_relation.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oOrganization_relation.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oOrganization_relation.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oOrganization_relation.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oOrganization_relation.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_relation;
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
        #region Get_Organization_data_source_kpi_By_Where_In_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_ID");
                        oOrganization_data_source_kpi.Data_source.NAME = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_NAME");
                        oOrganization_data_source_kpi.Data_source.API_URL = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_API_URL");
                        oOrganization_data_source_kpi.Data_source.MIN_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MIN_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.MAX_DWELL_TIME_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_MAX_DWELL_TIME_IN_MINUTES");
                        oOrganization_data_source_kpi.Data_source.DATA_SOURCE_AUTHENTICATION_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_DATA_SOURCE_AUTHENTICATION_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_SOURCE_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Data_source.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_ENTRY_DATE");
                        oOrganization_data_source_kpi.Data_source.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_SOURCE_LAST_UPDATE");
                        oOrganization_data_source_kpi.Data_source.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_SOURCE_IS_DELETED");
                        oOrganization_data_source_kpi.Data_source.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_SOURCE_OWNER_ID");
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        oOrganization_data_source_kpi.Kpi.KPI_ID = Get_Data_Record_Value<int?>(element, "T_KPI_KPI_ID");
                        oOrganization_data_source_kpi.Kpi.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_KPI_DIMENSION_ID");
                        oOrganization_data_source_kpi.Kpi.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_SETUP_CATEGORY_ID");
                        oOrganization_data_source_kpi.Kpi.NAME = Get_Data_Record_Value<string>(element, "T_KPI_NAME");
                        oOrganization_data_source_kpi.Kpi.UNIT = Get_Data_Record_Value<string>(element, "T_KPI_UNIT");
                        oOrganization_data_source_kpi.Kpi.KPI_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_KPI_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.HAS_CORRELATION = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_CORRELATION");
                        oOrganization_data_source_kpi.Kpi.IS_TRENDLINE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_TRENDLINE");
                        oOrganization_data_source_kpi.Kpi.IS_DECIMAL_VALUE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DECIMAL_VALUE");
                        oOrganization_data_source_kpi.Kpi.HAS_SQM = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_SQM");
                        oOrganization_data_source_kpi.Kpi.IS_BY_SEVERITY = Get_Data_Record_Value<bool>(element, "T_KPI_IS_BY_SEVERITY");
                        oOrganization_data_source_kpi.Kpi.IS_ADDITIVE_DATA = Get_Data_Record_Value<bool>(element, "T_KPI_IS_ADDITIVE_DATA");
                        oOrganization_data_source_kpi.Kpi.MINIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MINIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.MAXIMUM_VALUE = Get_Data_Record_Value<decimal?>(element, "T_KPI_MAXIMUM_VALUE");
                        oOrganization_data_source_kpi.Kpi.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_KPI_LATEST_DATA_CREATION_DATE");
                        oOrganization_data_source_kpi.Kpi.IS_AUTO_GENERATE = Get_Data_Record_Value<bool>(element, "T_KPI_IS_AUTO_GENERATE");
                        oOrganization_data_source_kpi.Kpi.MIN_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MIN_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.MAX_DATA_LEVEL_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_MAX_DATA_LEVEL_SETUP_ID");
                        oOrganization_data_source_kpi.Kpi.IS_EXTERNAL = Get_Data_Record_Value<bool>(element, "T_KPI_IS_EXTERNAL");
                        oOrganization_data_source_kpi.Kpi.HAS_ALERTS = Get_Data_Record_Value<bool>(element, "T_KPI_HAS_ALERTS");
                        oOrganization_data_source_kpi.Kpi.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Kpi.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_ENTRY_DATE");
                        oOrganization_data_source_kpi.Kpi.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_LAST_UPDATE");
                        oOrganization_data_source_kpi.Kpi.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_IS_DELETED");
                        oOrganization_data_source_kpi.Kpi.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_OWNER_ID");
                        oOrganization_data_source_kpi.Organization = new Organization();
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_data_source_kpi.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_data_source_kpi.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_data_source_kpi.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_data_source_kpi.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_data_source_kpi.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_data_source_kpi.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_data_source_kpi.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_data_source_kpi.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_data_source_kpi.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_data_source_kpi.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_data_source_kpi.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_chart_color_By_Where_In_List_Adv
        public List<Organization_chart_color> Get_Organization_chart_color_By_Where_In_List_Adv(string COLOR, IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_CHART_COLOR_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_chart_color = new List<Organization_chart_color>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_chart_color oOrganization_chart_color = new Organization_chart_color();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_chart_color);
                        oOrganization_chart_color.Organization_color_scheme = new Organization_color_scheme();
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_COLOR_SCHEME_ID");
                        oOrganization_chart_color.Organization_color_scheme.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_ORGANIZATION_ID");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_PRIMARY = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_PRIMARY");
                        oOrganization_chart_color.Organization_color_scheme.PLATFORM_BUTTON = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_PLATFORM_BUTTON");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_USER_ID");
                        oOrganization_chart_color.Organization_color_scheme.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_ENTRY_DATE");
                        oOrganization_chart_color.Organization_color_scheme.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_COLOR_SCHEME_LAST_UPDATE");
                        oOrganization_chart_color.Organization_color_scheme.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_COLOR_SCHEME_IS_DELETED");
                        oOrganization_chart_color.Organization_color_scheme.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_COLOR_SCHEME_OWNER_ID");
                        oOrganization_chart_color.Data_level_setup = new Setup();
                        oOrganization_chart_color.Data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_SETUP_ID");
                        oOrganization_chart_color.Data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oOrganization_chart_color.Data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oOrganization_chart_color.Data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oOrganization_chart_color.Data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_DELETED");
                        oOrganization_chart_color.Data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oOrganization_chart_color.Data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oOrganization_chart_color.Data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_VALUE");
                        oOrganization_chart_color.Data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_DESCRIPTION");
                        oOrganization_chart_color.Data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oOrganization_chart_color.Data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oOrganization_chart_color.Data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oOrganization_chart_color.Data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DATA_LEVEL_SETUP_OWNER_ID");
                        oList_Organization_chart_color.Add(oOrganization_chart_color);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_chart_color;
        }
        #endregion
        #region Get_Organization_districtnex_module_By_Where_In_List_Adv
        public List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DISTRICTNEX_MODULE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_districtnex_module oOrganization_districtnex_module = new Organization_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_districtnex_module);
                        oOrganization_districtnex_module.Districtnex_module = new Districtnex_module();
                        oOrganization_districtnex_module.Districtnex_module.DISTRICTNEX_MODULE_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISTRICTNEX_MODULE_ID");
                        oOrganization_districtnex_module.Districtnex_module.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_NAME");
                        oOrganization_districtnex_module.Districtnex_module.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_DISPLAY_ORDER");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICTNEX_MODULE_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Districtnex_module.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_ENTRY_DATE");
                        oOrganization_districtnex_module.Districtnex_module.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICTNEX_MODULE_LAST_UPDATE");
                        oOrganization_districtnex_module.Districtnex_module.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICTNEX_MODULE_IS_DELETED");
                        oOrganization_districtnex_module.Districtnex_module.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICTNEX_MODULE_OWNER_ID");
                        oOrganization_districtnex_module.Organization = new Organization();
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oOrganization_districtnex_module.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oOrganization_districtnex_module.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oOrganization_districtnex_module.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oOrganization_districtnex_module.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oOrganization_districtnex_module.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oOrganization_districtnex_module.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oOrganization_districtnex_module.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oOrganization_districtnex_module.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oOrganization_districtnex_module.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oOrganization_districtnex_module.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oOrganization_districtnex_module.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oList_Organization_districtnex_module.Add(oOrganization_districtnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_districtnex_module;
        }
        #endregion
    }
}
