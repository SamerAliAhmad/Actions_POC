using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv
        Build_version_log Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv(int? BUILD_VERSION_LOG_ID);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv
        Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(int? REMOVED_EXTRUSION_ID);
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv
        Alert_settings Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv(long? ALERT_SETTINGS_ID);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv
        Default_settings_image Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv(int? DEFAULT_SETTINGS_IMAGE_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_Adv
        Build_version Get_Build_version_By_BUILD_VERSION_ID_Adv(int? BUILD_VERSION_ID);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv
        Default_chart_color Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv(int? DEFAULT_CHART_COLOR_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv
        List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv(IEnumerable<int?> BUILD_VERSION_LOG_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv
        List<Alert_settings> Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv(IEnumerable<long?> ALERT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv
        List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv(IEnumerable<int?> DEFAULT_SETTINGS_IMAGE_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_List_Adv
        List<Build_version> Get_Build_version_By_BUILD_VERSION_ID_List_Adv(IEnumerable<int?> BUILD_VERSION_ID_LIST);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv
        List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv(IEnumerable<int?> DEFAULT_CHART_COLOR_ID_LIST);
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_Adv
        List<Build_version_log> Get_Build_version_log_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_Adv
        List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_Adv(int? BUILD_VERSION_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv
        List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv(long? BUILD_LOG_TYPE_SETUP_ID);
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv
        List<Build_version_log> Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_Adv(long? LEVEL_ID);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_Adv
        List<Alert_settings> Get_Alert_settings_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_Adv
        List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_Adv(long? OPERATION_SETUP_ID);
        #endregion
        #region Get_Alert_settings_By_USER_ID_Adv
        List<Alert_settings> Get_Alert_settings_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv
        List<Alert_settings> Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Alert_settings_By_KPI_ID_Adv
        List<Alert_settings> Get_Alert_settings_By_KPI_ID_Adv(int? KPI_ID);
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv
        List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv(long? VALUE_TYPE_SETUP_ID);
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_Adv
        List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv
        List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv
        List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv(long? IMAGE_TYPE_SETUP_ID);
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv
        List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_Build_version_By_OWNER_ID_Adv
        List<Build_version> Get_Build_version_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv
        List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv(long? APPLICATION_NAME_SETUP_ID);
        #endregion
        #region Get_Build_version_By_OWNER_ID_IS_DELETED_Adv
        List<Build_version> Get_Build_version_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv
        List<Build_version> Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv(bool IS_CURRENT, long? APPLICATION_NAME_SETUP_ID);
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_Adv
        List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv
        List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv(int? DEFAULT_SETTINGS_ID);
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv
        List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv
        List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv
        List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv(IEnumerable<int?> BUILD_VERSION_ID_LIST);
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv
        List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List_Adv(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv
        List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv(IEnumerable<long?> OPERATION_SETUP_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_USER_ID_List_Adv
        List<Alert_settings> Get_Alert_settings_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_KPI_ID_List_Adv
        List<Alert_settings> Get_Alert_settings_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv
        List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv
        List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv
        List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv
        List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv(IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST);
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv
        List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv(IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST);
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv
        List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Build_version_log_By_Where_Adv
        List<Build_version_log> Get_Build_version_log_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_Where_Adv(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Alert_settings_By_Where_Adv
        List<Alert_settings> Get_Alert_settings_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_settings_image_By_Where_Adv
        List<Default_settings_image> Get_Default_settings_image_By_Where_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Build_version_By_Where_Adv
        List<Build_version> Get_Build_version_By_Where_Adv(string BUILD_NUMBER, string COMMENTS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_chart_color_By_Where_Adv
        List<Default_chart_color> Get_Default_chart_color_By_Where_Adv(string COLOR, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Build_version_log_By_Where_In_List_Adv
        List<Build_version_log> Get_Build_version_log_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> BUILD_VERSION_ID_LIST, IEnumerable<long?> BUILD_LOG_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List_Adv(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Alert_settings_By_Where_In_List_Adv
        List<Alert_settings> Get_Alert_settings_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<long?> VALUE_TYPE_SETUP_ID_LIST, IEnumerable<long?> OPERATION_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_settings_image_By_Where_In_List_Adv
        List<Default_settings_image> Get_Default_settings_image_By_Where_In_List_Adv(string IMAGE_NAME, string IMAGE_EXTENSION, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> IMAGE_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Build_version_By_Where_In_List_Adv
        List<Build_version> Get_Build_version_By_Where_In_List_Adv(string BUILD_NUMBER, string COMMENTS, IEnumerable<long?> APPLICATION_NAME_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Default_chart_color_By_Where_In_List_Adv
        List<Default_chart_color> Get_Default_chart_color_By_Where_In_List_Adv(string COLOR, IEnumerable<int?> DEFAULT_SETTINGS_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
