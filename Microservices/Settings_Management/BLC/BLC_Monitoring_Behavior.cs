using System;
using SmartrTools;
using System.Diagnostics;
using System.Configuration;
using System.Threading.Tasks;

namespace BLC
{
    public partial class BLC
    {
        #region StopWatch properties
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_LOG_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_ALERT_SETTINGS_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Owner_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_BUILD_VERSION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_By_DEFAULT_SETTINGS_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_BUILD_VERSION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_ALERT_SETTINGS_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Owner_By_OWNER_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_BUILD_VERSION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_BUILD_VERSION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_LEVEL_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OPERATION_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_USER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_KPI_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Owner_By_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_VALUE { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_APPLICATION_NAME_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_By_TELUS_REQUEST_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Districtnex_module_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Districtnex_module_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_LEVEL_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OPERATION_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_USER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_KPI_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_LEVEL_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OPERATION_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_USER_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_KPI_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_LEVEL_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_USER_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_KPI_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Owner_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Districtnex_module_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_log_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Removed_extrusion_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Alert_settings_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_settings_image_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Build_version_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Default_chart_color_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_log { get; set; }
        public Stopwatch _Execution_Time_Delete_Removed_extrusion { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_image { get; set; }
        public Stopwatch _Execution_Time_Delete_Owner { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_chart_color { get; set; }
        public Stopwatch _Execution_Time_Delete_Districtnex_module { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_log_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_log_By_BUILD_VERSION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_log_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Removed_extrusion_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Removed_extrusion_By_LEVEL_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings_By_OPERATION_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings_By_USER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings_By_KPI_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_image_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Owner_By_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_settings_By_TELUS_REQUEST_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_chart_color_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Districtnex_module_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Edit_Build_version_log { get; set; }
        public Stopwatch _Execution_Time_Edit_Removed_extrusion { get; set; }
        public Stopwatch _Execution_Time_Edit_Alert_settings { get; set; }
        public Stopwatch _Execution_Time_Edit_Default_settings_image { get; set; }
        public Stopwatch _Execution_Time_Edit_Owner { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_category { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup { get; set; }
        public Stopwatch _Execution_Time_Edit_Build_version { get; set; }
        public Stopwatch _Execution_Time_Edit_Default_settings { get; set; }
        public Stopwatch _Execution_Time_Edit_Default_chart_color { get; set; }
        public Stopwatch _Execution_Time_Edit_Districtnex_module { get; set; }
        public Stopwatch _Execution_Time_Edit_Build_version_log_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Removed_extrusion_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Alert_settings_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Default_settings_image_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Owner_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_category_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Build_version_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Default_settings_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Default_chart_color_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Districtnex_module_List { get; set; }
        public Stopwatch _Execution_Time_Get_Default_Organization_URL_By_Setup_Value { get; set; }
        public Stopwatch _Execution_Time_Upload_Default_Settings_Picture { get; set; }
        public Stopwatch _Execution_Time_Delete_Default_Settings_Picture { get; set; }
        public Stopwatch _Execution_Time_Get_Initial_Districtnex_UI_Settings { get; set; }
        public Stopwatch _Execution_Time_Get_Initial_Districtnex_Admin_Settings { get; set; }
        public Stopwatch _Execution_Time_Update_Otp_Index { get; set; }
        public Stopwatch _Execution_Time_Edit_Removed_extrusion_Custom { get; set; }
        public Stopwatch _Execution_Time_Edit_Removed_extrusion_Custom_Old { get; set; }
        public Stopwatch _Execution_Time_Clean_Removed_extrusions { get; set; }
        public Stopwatch _Execution_Time_Create_Time_series_Collection { get; set; }
        public Stopwatch _Execution_Time_Drop_Collection { get; set; }
        public Stopwatch _Execution_Time_Edit_Object_View { get; set; }
        public Stopwatch _Execution_Time_Send_Support_Email { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Get_Specialized_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Get_Specialized_chart_configuration_By_MODULE { get; set; }
        public Stopwatch _Execution_Time_Edit_Dimension_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Edit_Kpi_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Edit_Specialized_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Delete_Dimension_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Delete_Specialized_chart_configuration { get; set; }
        public Stopwatch _Execution_Time_Get_District_geojson { get; set; }
        public Stopwatch _Execution_Time_Get_Area_geojson { get; set; }
        public Stopwatch _Execution_Time_Get_Site_geojson { get; set; }
        public Stopwatch _Execution_Time_Get_Ext_study_zone_geojson { get; set; }
        public Stopwatch _Execution_Time_Edit_District_geojson { get; set; }
        public Stopwatch _Execution_Time_Edit_Area_geojson { get; set; }
        public Stopwatch _Execution_Time_Edit_Site_geojson { get; set; }
        public Stopwatch _Execution_Time_Edit_Ext_study_zone_geojson { get; set; }
        public Stopwatch _Execution_Time_Delete_District_geojson_By_DISTRICT_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Area_geojson_By_AREA_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Site_geojson_By_SITE_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_UI_Build_Version_List { get; set; }
        public Stopwatch _Execution_Time_Get_Admin_Build_Version_List { get; set; }
        public Stopwatch _Execution_Time_Custom_Edit_Build_version { get; set; }
        #endregion
        #region BLC_OnPreEvent_General_Monitoring
        public void BLC_OnPreEvent_General_Monitoring(string i_MethodName, string i_Method_Params, bool is_Cached)
        {
            #region Body Section.
            var oStopWatch = (Stopwatch)Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName));
            Props.Set_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName), Stopwatch.StartNew());
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_General_Monitoring
        public void BLC_OnPostEvent_General_Monitoring(string i_MethodName, string i_Method_Params, bool is_Cached)
        {
            Task.Run(() =>
            {
                if (i_MethodName != "Edit_Method_run")
                {
                    #region Declaration And Initialization Section.
                    Service_Mesh.Method_run oMethod_run = new Service_Mesh.Method_run();
                    #endregion
                    #region Body Section.
                    Props.Set_Properties_Default_Value(oMethod_run);
                    oMethod_run.METHOD_RUN_ID = -1;
                    oMethod_run.IS_CACHED = is_Cached;
                    oMethod_run.METHOD_NAME = i_MethodName;
                    oMethod_run.RUN_HOUR = DateTime.Now.Hour;
                    oMethod_run.METHOD_PARAMS = i_Method_Params;
                    oMethod_run.RUN_MINUTE = DateTime.Now.Minute;
                    oMethod_run.RUN_SECOND = DateTime.Now.Second;
                    oMethod_run.RUN_DATE = Tools.GetDateString(DateTime.Today);
                    // Calculate Execution time
                    if (Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName)) != null)
                    {
                        var oStopWatch = (Stopwatch)Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName));
                        oStopWatch.Stop();
                        var elapsedMs = oStopWatch.ElapsedMilliseconds;
                        oMethod_run.EXECUTION_TIME = (int)elapsedMs;
                    }
                    this._service_mesh.Edit_Method_run(oMethod_run);
                    #endregion
                }
            });
        }
        #endregion
        #region Initialize_Monitoring_Mechanism
        public void Initialize_Monitoring_Mechanism()
        {
            #region Body Section.
            if (ConfigurationManager.AppSettings["ENABLE_MONITORING"] != null && ConfigurationManager.AppSettings["ENABLE_MONITORING"] == "1")
            {
                this.OnPreEvent_General += new PreEvent_Handler_General(BLC_OnPreEvent_General_Monitoring);
                this.OnPostEvent_General += new PostEvent_Handler_General(BLC_OnPostEvent_General_Monitoring);
            }
            #endregion
        }
        #endregion
    }
}