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
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_THEME_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_IMAGE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_ORGANIZATION_RELATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_THEME_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_THEME_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_LOG_CONFIG_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_IMAGE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_CHART_COLOR_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_DISTRICTNEX_MODULE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_LEVEL_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_PARENT_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_CHILD_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_USER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_VALUE { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_KPI_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_LEVEL_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_USER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_KPI_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_LEVEL_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_USER_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_KPI_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_LEVEL_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_LOG_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_IMAGE_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_USER_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_KPI_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_theme_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_level_access_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_log_config_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_color_scheme_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_image_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_relation_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_data_source_kpi_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_chart_color_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_districtnex_module_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_theme { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_log_config { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_color_scheme { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_image { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_relation { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_data_source_kpi { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_chart_color { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_districtnex_module { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_theme_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_theme_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_theme_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_By_ORGANIZATION_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access_By_LEVEL_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_log_config_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_log_config_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_log_config_By_LOG_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_log_config_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_color_scheme_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_color_scheme_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_color_scheme_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_image_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_image_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_image_By_IMAGE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_image_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_image_By_ORGANIZATION_ID_IMAGE_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_relation_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_relation_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_relation_By_PARENT_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_relation_By_CHILD_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_relation_By_USER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_data_source_kpi_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_data_source_kpi_By_KPI_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_chart_color_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_chart_color_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_chart_color_By_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_districtnex_module_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_districtnex_module_By_DISTRICTNEX_MODULE_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_districtnex_module_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_theme { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_level_access { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_log_config { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_color_scheme { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_category { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_image { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_relation { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_data_source_kpi { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_chart_color { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_districtnex_module { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_theme_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_level_access_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_log_config_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_color_scheme_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_category_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_image_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_relation_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_data_source_kpi_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_chart_color_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_districtnex_module_List { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_URL_By_Setup_Value { get; set; }
        public Stopwatch _Execution_Time_Restore_Organization { get; set; }
        public Stopwatch _Execution_Time_Modify_Data_Settings { get; set; }
        public Stopwatch _Execution_Time_Modify_Organization_Details { get; set; }
        public Stopwatch _Execution_Time_Upload_Organization_Picture { get; set; }
        public Stopwatch _Execution_Time_Delete_Organization_Picture { get; set; }
        public Stopwatch _Execution_Time_Permanently_Delete_Organization { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_Images_From_GCP { get; set; }
        public Stopwatch _Execution_Time_Schedule_Organization_for_Delete { get; set; }
        public Stopwatch _Execution_Time_Check_Organization_Deletion_Status { get; set; }
        public Stopwatch _Execution_Time_Send_Support_Email { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading { get; set; }
        public Stopwatch _Execution_Time_Get_Organization_By_PARENT_ORGANIZATION_ID { get; set; }
        public Stopwatch _Execution_Time_Edit_Organization_Custom { get; set; }
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