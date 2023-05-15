using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID
        Build_version_log Get_Build_version_log_By_BUILD_VERSION_LOG_ID(int? BUILD_VERSION_LOG_ID);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
        Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(int? REMOVED_EXTRUSION_ID);
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID
        Alert_settings Get_Alert_settings_By_ALERT_SETTINGS_ID(long? ALERT_SETTINGS_ID);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID
        Default_settings_image Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID(int? DEFAULT_SETTINGS_IMAGE_ID);
        #endregion
        #region Get_Owner_By_OWNER_ID
        Owner Get_Owner_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID
        Build_version Get_Build_version_By_BUILD_VERSION_ID(int? BUILD_VERSION_ID);
        #endregion
        #region Get_Default_settings_By_DEFAULT_SETTINGS_ID
        Default_settings Get_Default_settings_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID
        Default_chart_color Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID(int? DEFAULT_CHART_COLOR_ID);
        #endregion
        #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID
        Districtnex_module Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List
        List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List(IEnumerable<int?> BUILD_VERSION_LOG_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List
        List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_List
        List<Alert_settings> Get_Alert_settings_By_ALERT_SETTINGS_ID_List(IEnumerable<long?> ALERT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List
        List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_IMAGE_ID_LIST);
        #endregion
        #region Get_Owner_By_OWNER_ID_List
        List<Owner> Get_Owner_By_OWNER_ID_List(IEnumerable<int?> OWNER_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_List
        List<Build_version> Get_Build_version_By_BUILD_VERSION_ID_List(IEnumerable<int?> BUILD_VERSION_ID_LIST);
        #endregion
        #region Get_Default_settings_By_DEFAULT_SETTINGS_ID_List
        List<Default_settings> Get_Default_settings_By_DEFAULT_SETTINGS_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List
        List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List(IEnumerable<int?> DEFAULT_CHART_COLOR_ID_LIST);
        #endregion
        #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        List<Districtnex_module> Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Build_version_log_By_OWNER_ID
        List<Build_version_log> Get_Build_version_log_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID
        List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID(int? BUILD_VERSION_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
        List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(long? BUILD_LOG_TYPE_SETUP_ID);
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_IS_DELETED
        List<Build_version_log> Get_Build_version_log_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Alert_settings_By_OWNER_ID
        List<Alert_settings> Get_Alert_settings_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID
        List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID(long? OPERATION_SETUP_ID);
        #endregion
        #region Get_Alert_settings_By_USER_ID
        List<Alert_settings> Get_Alert_settings_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_IS_DELETED
        List<Alert_settings> Get_Alert_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Alert_settings_By_KPI_ID
        List<Alert_settings> Get_Alert_settings_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID
        List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID(long? VALUE_TYPE_SETUP_ID);
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID
        List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID
        List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
        List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_IS_DELETED
        List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Owner_By_IS_DELETED
        List<Owner> Get_Owner_By_IS_DELETED(bool IS_DELETED);
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
        #region Get_Build_version_By_OWNER_ID
        List<Build_version> Get_Build_version_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID
        List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID(long? APPLICATION_NAME_SETUP_ID);
        #endregion
        #region Get_Build_version_By_OWNER_ID_IS_DELETED
        List<Build_version> Get_Build_version_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
        List<Build_version> Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(bool IS_CURRENT, long? APPLICATION_NAME_SETUP_ID);
        #endregion
        #region Get_Default_settings_By_OWNER_ID_IS_DELETED
        List<Default_settings> Get_Default_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Default_settings_By_OWNER_ID
        List<Default_settings> Get_Default_settings_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Default_settings_By_TELUS_REQUEST_ID
        List<Default_settings> Get_Default_settings_By_TELUS_REQUEST_ID(string TELUS_REQUEST_ID);
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID
        List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID
        List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_IS_DELETED
        List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID
        List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Districtnex_module_By_OWNER_ID
        List<Districtnex_module> Get_Districtnex_module_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Districtnex_module_By_OWNER_ID_IS_DELETED
        List<Districtnex_module> Get_Districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_List
        List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_List(IEnumerable<int?> BUILD_VERSION_ID_LIST);
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List
        List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List(IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_List
        List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_List(IEnumerable<long?> OPERATION_SETUP_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_USER_ID_List
        List<Alert_settings> Get_Alert_settings_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_KPI_ID_List
        List<Alert_settings> Get_Alert_settings_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List
        List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List(IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List
        List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List
        List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List
        List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List(IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List
        List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List
        List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Build_version_log_By_Where
        List<Build_version_log> Get_Build_version_log_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where
        List<Removed_extrusion> Get_Removed_extrusion_By_Where(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Alert_settings_By_Where
        List<Alert_settings> Get_Alert_settings_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_settings_image_By_Where
        List<Default_settings_image> Get_Default_settings_image_By_Where(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Owner_By_Where
        List<Owner> Get_Owner_By_Where(string CODE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Build_version_By_Where
        List<Build_version> Get_Build_version_By_Where(string BUILD_NUMBER, string COMMENTS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_settings_By_Where
        List<Default_settings> Get_Default_settings_By_Where(string PLATFORM_PRIMARY, string PLATFORM_BUTTON, string MAPBOX_GL_TOKEN, string GOOGLE_MAP_API_TOKEN, string TELUS_REQUEST_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_chart_color_By_Where
        List<Default_chart_color> Get_Default_chart_color_By_Where(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Districtnex_module_By_Where
        List<Districtnex_module> Get_Districtnex_module_By_Where(string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Build_version_log_By_Where_In_List
        List<Build_version_log> Get_Build_version_log_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> BUILD_VERSION_ID_LIST, IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List
        List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Alert_settings_By_Where_In_List
        List<Alert_settings> Get_Alert_settings_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST, IEnumerable<long?> OPERATION_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_settings_image_By_Where_In_List
        List<Default_settings_image> Get_Default_settings_image_By_Where_In_List(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Build_version_By_Where_In_List
        List<Build_version> Get_Build_version_By_Where_In_List(string BUILD_NUMBER, string COMMENTS, IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_chart_color_By_Where_In_List
        List<Default_chart_color> Get_Default_chart_color_By_Where_In_List(string COLOR, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Build_version_log
        void Delete_Build_version_log(int? BUILD_VERSION_LOG_ID);
        #endregion
        #region Delete_Removed_extrusion
        void Delete_Removed_extrusion(int? REMOVED_EXTRUSION_ID);
        #endregion
        #region Delete_Alert_settings
        void Delete_Alert_settings(long? ALERT_SETTINGS_ID);
        #endregion
        #region Delete_Default_settings_image
        void Delete_Default_settings_image(int? DEFAULT_SETTINGS_IMAGE_ID);
        #endregion
        #region Delete_Owner
        void Delete_Owner(int? OWNER_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Build_version
        void Delete_Build_version(int? BUILD_VERSION_ID);
        #endregion
        #region Delete_Default_settings
        void Delete_Default_settings(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Delete_Default_chart_color
        void Delete_Default_chart_color(int? DEFAULT_CHART_COLOR_ID);
        #endregion
        #region Delete_Districtnex_module
        void Delete_Districtnex_module(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Delete_Build_version_log_By_OWNER_ID
        void Delete_Build_version_log_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Build_version_log_By_BUILD_VERSION_ID
        void Delete_Build_version_log_By_BUILD_VERSION_ID(int? BUILD_VERSION_ID);
        #endregion
        #region Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
        void Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(long? BUILD_LOG_TYPE_SETUP_ID);
        #endregion
        #region Delete_Build_version_log_By_OWNER_ID_IS_DELETED
        void Delete_Build_version_log_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID
        void Delete_Removed_extrusion_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Removed_extrusion_By_LEVEL_ID
        void Delete_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        void Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED
        void Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Alert_settings_By_OWNER_ID
        void Delete_Alert_settings_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Alert_settings_By_OPERATION_SETUP_ID
        void Delete_Alert_settings_By_OPERATION_SETUP_ID(long? OPERATION_SETUP_ID);
        #endregion
        #region Delete_Alert_settings_By_USER_ID
        void Delete_Alert_settings_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_Alert_settings_By_OWNER_ID_IS_DELETED
        void Delete_Alert_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Alert_settings_By_KPI_ID
        void Delete_Alert_settings_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID
        void Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID(long? VALUE_TYPE_SETUP_ID);
        #endregion
        #region Delete_Default_settings_image_By_OWNER_ID
        void Delete_Default_settings_image_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID
        void Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
        void Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Delete_Default_settings_image_By_OWNER_ID_IS_DELETED
        void Delete_Default_settings_image_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Owner_By_IS_DELETED
        void Delete_Owner_By_IS_DELETED(bool IS_DELETED);
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
        #region Delete_Build_version_By_OWNER_ID
        void Delete_Build_version_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Build_version_By_APPLICATION_NAME_SETUP_ID
        void Delete_Build_version_By_APPLICATION_NAME_SETUP_ID(long? APPLICATION_NAME_SETUP_ID);
        #endregion
        #region Delete_Build_version_By_OWNER_ID_IS_DELETED
        void Delete_Build_version_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
        void Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(bool IS_CURRENT, long? APPLICATION_NAME_SETUP_ID);
        #endregion
        #region Delete_Default_settings_By_OWNER_ID_IS_DELETED
        void Delete_Default_settings_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Default_settings_By_OWNER_ID
        void Delete_Default_settings_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Default_settings_By_TELUS_REQUEST_ID
        void Delete_Default_settings_By_TELUS_REQUEST_ID(string TELUS_REQUEST_ID);
        #endregion
        #region Delete_Default_chart_color_By_OWNER_ID
        void Delete_Default_chart_color_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID
        void Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Delete_Default_chart_color_By_OWNER_ID_IS_DELETED
        void Delete_Default_chart_color_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID
        void Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Districtnex_module_By_OWNER_ID
        void Delete_Districtnex_module_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Districtnex_module_By_OWNER_ID_IS_DELETED
        void Delete_Districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Build_version_log
        int? Edit_Build_version_log(int? BUILD_VERSION_LOG_ID, int? BUILD_VERSION_ID, long? BUILD_LOG_TYPE_SETUP_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Removed_extrusion
        int? Edit_Removed_extrusion(int? REMOVED_EXTRUSION_ID, string EXTRUSION_IDENTIFIER, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Alert_settings
        long? Edit_Alert_settings(long? ALERT_SETTINGS_ID, long? USER_ID, int? KPI_ID, decimal? VALUE, long? VALUE_TYPE_SETUP_ID, long? OPERATION_SETUP_ID, bool IS_ACTIVE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Default_settings_image
        int? Edit_Default_settings_image(int? DEFAULT_SETTINGS_IMAGE_ID, int? DEFAULT_SETTINGS_ID, string IMAGE_NAME, string IMAGE_EXTENSION, long? IMAGE_TYPE_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Owner
        int? Edit_Owner(int? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string ENTRY_DATE, string DESCRIPTION, long? ENTRY_USER_ID, string LAST_UPDATE, bool IS_DELETED);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Build_version
        int? Edit_Build_version(int? BUILD_VERSION_ID, string BUILD_NUMBER, long? APPLICATION_NAME_SETUP_ID, bool IS_CURRENT, string BUILD_DATE, string COMMENTS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Default_settings
        int? Edit_Default_settings(int? DEFAULT_SETTINGS_ID, string PLATFORM_PRIMARY, string PLATFORM_BUTTON, int? DATA_RETENTION_PERIOD, int? TICKET_DURATION_IN_MINUTES, int? OTP_TTL_IN_SECONDS, string MAPBOX_GL_TOKEN, string GOOGLE_MAP_API_TOKEN, string TELUS_REQUEST_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Default_chart_color
        int? Edit_Default_chart_color(int? DEFAULT_CHART_COLOR_ID, int? DEFAULT_SETTINGS_ID, string COLOR, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Districtnex_module
        int? Edit_Districtnex_module(int? DISTRICTNEX_MODULE_ID, string NAME, int? DISPLAY_ORDER, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
