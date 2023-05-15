using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv
        Organization_theme Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv(int? ORGANIZATION_THEME_ID);
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_Adv
        Organization Get_Organization_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv
        Organization_level_access Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(long? ORGANIZATION_LEVEL_ACCESS_ID);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv
        Organization_log_config Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv(long? ORGANIZATION_LOG_CONFIG_ID);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv
        Organization_color_scheme Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(int? ORGANIZATION_COLOR_SCHEME_ID);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv
        Organization_image Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv(int? ORGANIZATION_IMAGE_ID);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv
        Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(int? ORGANIZATION_RELATION_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv
        Organization_chart_color Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv(int? ORGANIZATION_CHART_COLOR_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv
        Organization_districtnex_module Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv(int? ORGANIZATION_DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv
        List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST);
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List_Adv
        List<Organization> Get_Organization_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv(IEnumerable<long?> ORGANIZATION_LOG_CONFIG_ID_LIST);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv(IEnumerable<int?> ORGANIZATION_IMAGE_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv(IEnumerable<int?> ORGANIZATION_CHART_COLOR_ID_LIST);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_Adv
        List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_Adv
        List<Organization_theme> Get_Organization_theme_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_theme> Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_By_OWNER_ID_IS_DELETED_Adv
        List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_By_OWNER_ID_Adv
        List<Organization> Get_Organization_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv
        List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(long? ORGANIZATION_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_Adv
        List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_Adv
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_Adv
        List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_Adv(long? LEVEL_ID);
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv
        List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv(int? ORGANIZATION_ID, long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_Adv
        List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_Adv
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv
        List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv(long? LOG_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv(int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_image_By_OWNER_ID_Adv
        List<Organization_image> Get_Organization_image_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_Adv
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv
        List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv(long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_image> Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv(int? ORGANIZATION_ID, long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(int? PARENT_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(int? CHILD_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_USER_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(int? DATA_SOURCE_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_Adv(int? KPI_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv(int? ORGANIZATION_COLOR_SCHEME_ID);
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_List_Adv
        List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv
        List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_List_Adv
        List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_List_Adv(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv
        List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv
        List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_List_Adv
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv
        List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_USER_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(IEnumerable<int?> DATA_SOURCE_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST);
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Organization_theme_By_Where_Adv
        List<Organization_theme> Get_Organization_theme_By_Where_Adv(string THEME_NAME, string THEME_CLASS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_By_Where_Adv
        List<Organization> Get_Organization_By_Where_Adv(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_level_access_By_Where_Adv
        List<Organization_level_access> Get_Organization_level_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_log_config_By_Where_Adv
        List<Organization_log_config> Get_Organization_log_config_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_color_scheme_By_Where_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_Adv(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_image_By_Where_Adv
        List<Organization_image> Get_Organization_image_By_Where_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where_Adv
        List<Organization_relation> Get_Organization_relation_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_chart_color_By_Where_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_Where_Adv(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_districtnex_module_By_Where_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_theme_By_Where_In_List_Adv
        List<Organization_theme> Get_Organization_theme_By_Where_In_List_Adv(string THEME_NAME, string THEME_CLASS, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_By_Where_In_List_Adv
        List<Organization> Get_Organization_By_Where_In_List_Adv(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_level_access_By_Where_In_List_Adv
        List<Organization_level_access> Get_Organization_level_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_log_config_By_Where_In_List_Adv
        List<Organization_log_config> Get_Organization_log_config_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_color_scheme_By_Where_In_List_Adv
        List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_In_List_Adv(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_image_By_Where_In_List_Adv
        List<Organization_image> Get_Organization_image_By_Where_In_List_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where_In_List_Adv
        List<Organization_relation> Get_Organization_relation_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_chart_color_By_Where_In_List_Adv
        List<Organization_chart_color> Get_Organization_chart_color_By_Where_In_List_Adv(string COLOR, IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_districtnex_module_By_Where_In_List_Adv
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
