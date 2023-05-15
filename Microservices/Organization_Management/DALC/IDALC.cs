using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID
        Organization_theme Get_Organization_theme_By_ORGANIZATION_THEME_ID(int? ORGANIZATION_THEME_ID);
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID
        Organization Get_Organization_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        Organization_level_access Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(long? ORGANIZATION_LEVEL_ACCESS_ID);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID
        Organization_log_config Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID(long? ORGANIZATION_LOG_CONFIG_ID);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID
        Organization_color_scheme Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID(int? ORGANIZATION_COLOR_SCHEME_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID
        Organization_image Get_Organization_image_By_ORGANIZATION_IMAGE_ID(int? ORGANIZATION_IMAGE_ID);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID
        Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID(int? ORGANIZATION_RELATION_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID
        Organization_chart_color Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID(int? ORGANIZATION_CHART_COLOR_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID
        Organization_districtnex_module Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID(int? ORGANIZATION_DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_THEME_ID_List
        List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_THEME_ID_List(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST);
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List
        List<Organization> Get_Organization_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List(IEnumerable<long?> ORGANIZATION_LOG_CONFIG_ID_LIST);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List
        List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List(IEnumerable<int?> ORGANIZATION_IMAGE_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List
        List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List
        List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List(IEnumerable<int?> ORGANIZATION_CHART_COLOR_ID_LIST);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> ORGANIZATION_DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID
        List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_theme_By_OWNER_ID
        List<Organization_theme> Get_Organization_theme_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_theme_By_OWNER_ID_IS_DELETED
        List<Organization_theme> Get_Organization_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_By_OWNER_ID_IS_DELETED
        List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_By_OWNER_ID
        List<Organization> Get_Organization_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID
        List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID(long? ORGANIZATION_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID_IS_DELETED
        List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_level_access_By_OWNER_ID
        List<Organization_level_access> Get_Organization_level_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID
        List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
        List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(int? ORGANIZATION_ID, long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID
        List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID
        List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID(long? LOG_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_log_config_By_OWNER_ID_IS_DELETED
        List<Organization_log_config> Get_Organization_log_config_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID
        List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID
        List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED
        List<Organization_color_scheme> Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Get_Organization_image_By_OWNER_ID
        List<Organization_image> Get_Organization_image_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID
        List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_image_By_OWNER_ID_IS_DELETED
        List<Organization_image> Get_Organization_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_USER_ID
        List<Organization_relation> Get_Organization_relation_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID
        List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID
        List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
        List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(int? ORGANIZATION_COLOR_SCHEME_ID);
        #endregion
        #region Get_Organization_chart_color_By_OWNER_ID_IS_DELETED
        List<Organization_chart_color> Get_Organization_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
        List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_theme_By_ORGANIZATION_ID_List
        List<Organization_theme> Get_Organization_theme_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List
        List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List(IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_ORGANIZATION_ID_List
        List<Organization_level_access> Get_Organization_level_access_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_LEVEL_ID_List
        List<Organization_level_access> Get_Organization_level_access_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List
        List<Organization_level_access> Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_log_config_By_ORGANIZATION_ID_List
        List<Organization_log_config> Get_Organization_log_config_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List
        List<Organization_log_config> Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List(IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List
        List<Organization_color_scheme> Get_Organization_color_scheme_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_image_By_ORGANIZATION_ID_List
        List<Organization_image> Get_Organization_image_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List
        List<Organization_image> Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_USER_ID_List
        List<Organization_relation> Get_Organization_relation_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(IEnumerable<int?> DATA_SOURCE_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List
        List<Organization_chart_color> Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List(IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST);
        #endregion
        #region Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List
        List<Organization_chart_color> Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Organization_theme_By_Where
        List<Organization_theme> Get_Organization_theme_By_Where(string THEME_NAME, string THEME_CLASS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_By_Where
        List<Organization> Get_Organization_By_Where(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_level_access_By_Where
        List<Organization_level_access> Get_Organization_level_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_log_config_By_Where
        List<Organization_log_config> Get_Organization_log_config_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_color_scheme_By_Where
        List<Organization_color_scheme> Get_Organization_color_scheme_By_Where(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_image_By_Where
        List<Organization_image> Get_Organization_image_By_Where(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where
        List<Organization_relation> Get_Organization_relation_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_chart_color_By_Where
        List<Organization_chart_color> Get_Organization_chart_color_By_Where(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_districtnex_module_By_Where
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_theme_By_Where_In_List
        List<Organization_theme> Get_Organization_theme_By_Where_In_List(string THEME_NAME, string THEME_CLASS, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_By_Where_In_List
        List<Organization> Get_Organization_By_Where_In_List(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_level_access_By_Where_In_List
        List<Organization_level_access> Get_Organization_level_access_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_log_config_By_Where_In_List
        List<Organization_log_config> Get_Organization_log_config_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_color_scheme_By_Where_In_List
        List<Organization_color_scheme> Get_Organization_color_scheme_By_Where_In_List(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_image_By_Where_In_List
        List<Organization_image> Get_Organization_image_By_Where_In_List(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where_In_List
        List<Organization_relation> Get_Organization_relation_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_chart_color_By_Where_In_List
        List<Organization_chart_color> Get_Organization_chart_color_By_Where_In_List(string COLOR, IEnumerable<int?> ORGANIZATION_COLOR_SCHEME_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_districtnex_module_By_Where_In_List
        List<Organization_districtnex_module> Get_Organization_districtnex_module_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Organization_theme
        void Delete_Organization_theme(int? ORGANIZATION_THEME_ID);
        #endregion
        #region Delete_Organization
        void Delete_Organization(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_level_access
        void Delete_Organization_level_access(long? ORGANIZATION_LEVEL_ACCESS_ID);
        #endregion
        #region Delete_Organization_log_config
        void Delete_Organization_log_config(long? ORGANIZATION_LOG_CONFIG_ID);
        #endregion
        #region Delete_Organization_color_scheme
        void Delete_Organization_color_scheme(int? ORGANIZATION_COLOR_SCHEME_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Organization_image
        void Delete_Organization_image(int? ORGANIZATION_IMAGE_ID);
        #endregion
        #region Delete_Organization_relation
        void Delete_Organization_relation(int? ORGANIZATION_RELATION_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Organization_data_source_kpi
        void Delete_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Organization_chart_color
        void Delete_Organization_chart_color(int? ORGANIZATION_CHART_COLOR_ID);
        #endregion
        #region Delete_Organization_districtnex_module
        void Delete_Organization_districtnex_module(int? ORGANIZATION_DISTRICTNEX_MODULE_ID);
        #endregion
        #region Delete_Organization_theme_By_ORGANIZATION_ID
        void Delete_Organization_theme_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_theme_By_OWNER_ID
        void Delete_Organization_theme_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_theme_By_OWNER_ID_IS_DELETED
        void Delete_Organization_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_By_OWNER_ID_IS_DELETED
        void Delete_Organization_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_By_OWNER_ID
        void Delete_Organization_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID
        void Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID(long? ORGANIZATION_TYPE_SETUP_ID);
        #endregion
        #region Delete_Organization_level_access_By_OWNER_ID_IS_DELETED
        void Delete_Organization_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_level_access_By_OWNER_ID
        void Delete_Organization_level_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_level_access_By_ORGANIZATION_ID
        void Delete_Organization_level_access_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_level_access_By_LEVEL_ID
        void Delete_Organization_level_access_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID
        void Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
        void Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(int? ORGANIZATION_ID, long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Organization_log_config_By_OWNER_ID
        void Delete_Organization_log_config_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_log_config_By_ORGANIZATION_ID
        void Delete_Organization_log_config_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID
        void Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID(long? LOG_TYPE_SETUP_ID);
        #endregion
        #region Delete_Organization_log_config_By_OWNER_ID_IS_DELETED
        void Delete_Organization_log_config_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
        void Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID);
        #endregion
        #region Delete_Organization_color_scheme_By_OWNER_ID
        void Delete_Organization_color_scheme_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_color_scheme_By_ORGANIZATION_ID
        void Delete_Organization_color_scheme_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED
        void Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Delete_Organization_image_By_OWNER_ID
        void Delete_Organization_image_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_image_By_ORGANIZATION_ID
        void Delete_Organization_image_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID
        void Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Delete_Organization_image_By_OWNER_ID_IS_DELETED
        void Delete_Organization_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID
        void Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID(int? ORGANIZATION_ID, long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID_IS_DELETED
        void Delete_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID
        void Delete_Organization_relation_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_relation_By_PARENT_ORGANIZATION_ID
        void Delete_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_relation_By_CHILD_ORGANIZATION_ID
        void Delete_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_relation_By_USER_ID
        void Delete_Organization_relation_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Delete_Setup_By_OWNER_ID
        void Delete_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID
        void Delete_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID
        void Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_KPI_ID
        void Delete_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_ORGANIZATION_ID
        void Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        void Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_chart_color_By_OWNER_ID
        void Delete_Organization_chart_color_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID
        void Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID(int? ORGANIZATION_COLOR_SCHEME_ID);
        #endregion
        #region Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED
        void Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID
        void Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Organization_districtnex_module_By_OWNER_ID
        void Delete_Organization_districtnex_module_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_districtnex_module_By_ORGANIZATION_ID
        void Delete_Organization_districtnex_module_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID
        void Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED
        void Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Organization_theme
        int? Edit_Organization_theme(int? ORGANIZATION_THEME_ID, int? ORGANIZATION_ID, string THEME_NAME, string THEME_CLASS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization
        int? Edit_Organization(int? ORGANIZATION_ID, string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? DATA_RETENTION_PERIOD, int? TICKET_DURATION_IN_MINUTES, long? ORGANIZATION_TYPE_SETUP_ID, string DATE_DELETED, int? MAX_NUMBER_OF_ADMINS, int? MAX_NUMBER_OF_USERS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_ACTIVE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization_level_access
        long? Edit_Organization_level_access(long? ORGANIZATION_LEVEL_ACCESS_ID, int? ORGANIZATION_ID, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Organization_log_config
        long? Edit_Organization_log_config(long? ORGANIZATION_LOG_CONFIG_ID, int? ORGANIZATION_ID, long? LOG_TYPE_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Organization_color_scheme
        int? Edit_Organization_color_scheme(int? ORGANIZATION_COLOR_SCHEME_ID, int? ORGANIZATION_ID, string PLATFORM_PRIMARY, string PLATFORM_BUTTON, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization_image
        int? Edit_Organization_image(int? ORGANIZATION_IMAGE_ID, int? ORGANIZATION_ID, string IMAGE_NAME, string IMAGE_EXTENSION, long? IMAGE_TYPE_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization_relation
        int? Edit_Organization_relation(int? ORGANIZATION_RELATION_ID, int? PARENT_ORGANIZATION_ID, int? CHILD_ORGANIZATION_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Organization_data_source_kpi
        int? Edit_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID, int? DATA_SOURCE_ID, int? KPI_ID, int? ORGANIZATION_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Organization_chart_color
        int? Edit_Organization_chart_color(int? ORGANIZATION_CHART_COLOR_ID, int? ORGANIZATION_COLOR_SCHEME_ID, string COLOR, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization_districtnex_module
        int? Edit_Organization_districtnex_module(int? ORGANIZATION_DISTRICTNEX_MODULE_ID, int? ORGANIZATION_ID, int? DISTRICTNEX_MODULE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
    }
}
