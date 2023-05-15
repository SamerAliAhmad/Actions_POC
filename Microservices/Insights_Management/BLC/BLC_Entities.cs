using System;

namespace BLC
{
    #region Kpi
    public partial class Kpi
    {
        public int? KPI_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public int? SETUP_CATEGORY_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
        public long? KPI_TYPE_SETUP_ID { get; set; }
        public bool HAS_CORRELATION { get; set; }
        public bool IS_TRENDLINE { get; set; }
        public bool IS_DECIMAL_VALUE { get; set; }
        public bool HAS_SQM { get; set; }
        public bool IS_BY_SEVERITY { get; set; }
        public bool IS_ADDITIVE_DATA { get; set; }
        public decimal? MINIMUM_VALUE { get; set; }
        public decimal? MAXIMUM_VALUE { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public bool IS_AUTO_GENERATE { get; set; }
        public long? MIN_DATA_LEVEL_SETUP_ID { get; set; }
        public long? MAX_DATA_LEVEL_SETUP_ID { get; set; }
        public bool IS_EXTERNAL { get; set; }
        public bool HAS_ALERTS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Build_version_log
    public partial class Build_version_log
    {
        public int? BUILD_VERSION_LOG_ID { get; set; }
        public int? BUILD_VERSION_ID { get; set; }
        public long? BUILD_LOG_TYPE_SETUP_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Video_ai_search_category
    public partial class Video_ai_search_category
    {
        public int? VIDEO_AI_SEARCH_CATEGORY_ID { get; set; }
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string CATEGORY_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Site_view
    public partial class Site_view
    {
        public long? SITE_VIEW_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Removed_extrusion
    public partial class Removed_extrusion
    {
        public int? REMOVED_EXTRUSION_ID { get; set; }
        public string EXTRUSION_IDENTIFIER { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Correlation_method
    public partial class Correlation_method
    {
        public int? CORRELATION_METHOD_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EQUATION_URL { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Asset
    public partial class Asset
    {
        public long? ASSET_ID { get; set; }
        public long? ASSET_TYPE_SETUP_ID { get; set; }
        public string NAME { get; set; }
        public string GLTF_URL { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Entity_view
    public partial class Entity_view
    {
        public long? ENTITY_VIEW_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Ext_study_zone
    public partial class Ext_study_zone
    {
        public int? EXT_STUDY_ZONE_ID { get; set; }
        public string NAME { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Dimension
    public partial class Dimension
    {
        public int? DIMENSION_ID { get; set; }
        public string NAME { get; set; }
        public string DIMENSION_ICON { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        public string ICON_URL { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Data_source_kpi_request
    public partial class Data_source_kpi_request
    {
        public int? DATA_SOURCE_KPI_REQUEST_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string REQUEST_ENDPOINT { get; set; }
        public int? REQUEST_METHOD_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization_theme
    public partial class Organization_theme
    {
        public int? ORGANIZATION_THEME_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string THEME_NAME { get; set; }
        public string THEME_CLASS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Video_ai_asset_entity
    public partial class Video_ai_asset_entity
    {
        public int? VIDEO_AI_ASSET_ENTITY_ID { get; set; }
        public int? VIDEO_AI_ASSET_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Top_level
    public partial class Top_level
    {
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public int? LOW_THRESHOLD { get; set; }
        public int? HIGH_THRESHOLD { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Area_kpi_user_access
    public partial class Area_kpi_user_access
    {
        public long? AREA_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? AREA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Alert_settings
    public partial class Alert_settings
    {
        public long? ALERT_SETTINGS_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? KPI_ID { get; set; }
        public decimal? VALUE { get; set; }
        public long? VALUE_TYPE_SETUP_ID { get; set; }
        public long? OPERATION_SETUP_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Site_kpi_user_access
    public partial class Site_kpi_user_access
    {
        public long? SITE_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? SITE_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Default_settings_image
    public partial class Default_settings_image
    {
        public int? DEFAULT_SETTINGS_IMAGE_ID { get; set; }
        public int? DEFAULT_SETTINGS_ID { get; set; }
        public string IMAGE_NAME { get; set; }
        public string IMAGE_EXTENSION { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization
    public partial class Organization
    {
        public int? ORGANIZATION_ID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string ORGANIZATION_EMAIL { get; set; }
        public string ORGANIZATION_PHONE_NUMBER { get; set; }
        public string ORGANIZATION_ADDRESS { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public long? ORGANIZATION_TYPE_SETUP_ID { get; set; }
        public string DATE_DELETED { get; set; }
        public int? MAX_NUMBER_OF_ADMINS { get; set; }
        public int? MAX_NUMBER_OF_USERS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization_level_access
    public partial class Organization_level_access
    {
        public long? ORGANIZATION_LEVEL_ACCESS_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Entity_kpi
    public partial class Entity_kpi
    {
        public long? ENTITY_KPI_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Entity
    public partial class Entity
    {
        public long? ENTITY_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public long? ENTITY_TYPE_SETUP_ID { get; set; }
        public string NAME { get; set; }
        public int? NUMBER_OF_FLOORS { get; set; }
        public decimal? GLA { get; set; }
        public string GLA_UNIT { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public decimal? POPUL_ALT_X { get; set; }
        public decimal? POPUP_ALT_Y { get; set; }
        public decimal? POPUP_ALT_Z { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region District_kpi
    public partial class District_kpi
    {
        public long? DISTRICT_KPI_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Organization_log_config
    public partial class Organization_log_config
    {
        public long? ORGANIZATION_LOG_CONFIG_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region User_level_access
    public partial class User_level_access
    {
        public long? USER_LEVEL_ACCESS_ID { get; set; }
        public long? ORGANIZATION_LEVEL_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region User_districtnex_module
    public partial class User_districtnex_module
    {
        public long? USER_DISTRICTNEX_MODULE_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? DISTRICTNEX_MODULE_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Entity_kpi_user_access
    public partial class Entity_kpi_user_access
    {
        public long? ENTITY_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Organization_color_scheme
    public partial class Organization_color_scheme
    {
        public int? ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string PLATFORM_PRIMARY { get; set; }
        public string PLATFORM_BUTTON { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region District_view
    public partial class District_view
    {
        public long? DISTRICT_VIEW_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Owner
    public partial class Owner
    {
        public int? OWNER_ID { get; set; }
        public string CODE { get; set; }
        public string MAINTENANCE_DUE_DATE { get; set; }
        public string ENTRY_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
    }
    #endregion
    #region Area
    public partial class Area
    {
        public long? AREA_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Area_view
    public partial class Area_view
    {
        public long? AREA_VIEW_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Site_kpi
    public partial class Site_kpi
    {
        public long? SITE_KPI_ID { get; set; }
        public long? SITE_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Setup_category
    public partial class Setup_category
    {
        public int? SETUP_CATEGORY_ID { get; set; }
        public string SETUP_CATEGORY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization_image
    public partial class Organization_image
    {
        public int? ORGANIZATION_IMAGE_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string IMAGE_NAME { get; set; }
        public string IMAGE_EXTENSION { get; set; }
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization_relation
    public partial class Organization_relation
    {
        public int? ORGANIZATION_RELATION_ID { get; set; }
        public int? PARENT_ORGANIZATION_ID { get; set; }
        public int? CHILD_ORGANIZATION_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Setup
    public partial class Setup
    {
        public long? SETUP_ID { get; set; }
        public int? SETUP_CATEGORY_ID { get; set; }
        public bool IS_SYSTEM { get; set; }
        public bool IS_DELETEABLE { get; set; }
        public bool IS_UPDATEABLE { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_VISIBLE { get; set; }
        public int? DISPLAY_ORDER { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Area_kpi
    public partial class Area_kpi
    {
        public long? AREA_KPI_ID { get; set; }
        public long? AREA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Site_field_logo
    public partial class Site_field_logo
    {
        public long? SITE_FIELD_LOGO_ID { get; set; }
        public long? SITE_ID { get; set; }
        public decimal? LONGITUDE { get; set; }
        public decimal? LATITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Region
    public partial class Region
    {
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Space_asset
    public partial class Space_asset
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? ASSET_ID { get; set; }
        public string EXTERNAL_ID { get; set; }
        public bool IS_MERAKI_WIFI_SIGNAL { get; set; }
        public string CUSTOM_NAME { get; set; }
        public decimal? POSITION_X { get; set; }
        public decimal? POSITION_Y { get; set; }
        public decimal? POSITION_Z { get; set; }
        public decimal? SCALE_MULTIPLIER { get; set; }
        public decimal? ROTATE_X { get; set; }
        public decimal? ROTATE_Y { get; set; }
        public decimal? ROTATE_Z { get; set; }
        public string ASSET_ICON { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Data_source_authentication
    public partial class Data_source_authentication
    {
        public int? DATA_SOURCE_AUTHENTICATION_ID { get; set; }
        public string AUTH_ENDPOINT { get; set; }
        public int? AUTH_TYPE_SETUP_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string API_KEY { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Data_source
    public partial class Data_source
    {
        public int? DATA_SOURCE_ID { get; set; }
        public string NAME { get; set; }
        public string API_URL { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public int? DATA_SOURCE_AUTHENTICATION_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region District
    public partial class District
    {
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization_data_source_kpi
    public partial class Organization_data_source_kpi
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? DATA_SOURCE_ID { get; set; }
        public int? KPI_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Floor
    public partial class Floor
    {
        public long? FLOOR_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public int? FLOOR_NUMBER { get; set; }
        public string SHELL_GLTF_URL { get; set; }
        public string CLIPPED_GLTF_URL { get; set; }
        public string ADVANCED_GLTF_URL { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public string NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Share_file
    public partial class Share_file
    {
        public int? SHARE_FILE_ID { get; set; }
        public long? USER_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region District_kpi_user_access
    public partial class District_kpi_user_access
    {
        public long? DISTRICT_KPI_USER_ACCESS_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Method_run
    public partial class Method_run
    {
        public long? METHOD_RUN_ID { get; set; }
        public string METHOD_NAME { get; set; }
        public string RUN_DATE { get; set; }
        public int? RUN_HOUR { get; set; }
        public int? RUN_MINUTE { get; set; }
        public int? RUN_SECOND { get; set; }
        public int? EXECUTION_TIME { get; set; }
        public bool IS_CACHED { get; set; }
        public string METHOD_PARAMS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public int? OWNER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
    }
    #endregion
    #region User
    public partial class User
    {
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public long? USER_TYPE_SETUP_ID { get; set; }
        public int? OWNER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string IMAGE_URL { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_RECEIVE_EMAIL { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public string USER_DISTRICTNEX_WALKTHROUGH { get; set; }
        public string USER_ADMIN_WALKTHROUGH { get; set; }
        public string DATE_DELETED { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
    }
    #endregion
    #region Space
    public partial class Space
    {
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public string NAME { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public int? OCCUPANT_LOAD_FACTOR { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Build_version
    public partial class Build_version
    {
        public int? BUILD_VERSION_ID { get; set; }
        public string BUILD_NUMBER { get; set; }
        public long? APPLICATION_NAME_SETUP_ID { get; set; }
        public bool IS_CURRENT { get; set; }
        public string BUILD_DATE { get; set; }
        public string COMMENTS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Report
    public partial class Report
    {
        public int? REPORT_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public string FILE_SIZE { get; set; }
        public string IDENTIFIER_TOKEN { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Default_settings
    public partial class Default_settings
    {
        public int? DEFAULT_SETTINGS_ID { get; set; }
        public string PLATFORM_PRIMARY { get; set; }
        public string PLATFORM_BUTTON { get; set; }
        public int? DATA_RETENTION_PERIOD { get; set; }
        public int? TICKET_DURATION_IN_MINUTES { get; set; }
        public int? OTP_TTL_IN_SECONDS { get; set; }
        public string MAPBOX_GL_TOKEN { get; set; }
        public string GOOGLE_MAP_API_TOKEN { get; set; }
        public string TELUS_REQUEST_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Request_param
    public partial class Request_param
    {
        public int? REQUEST_PARAM_ID { get; set; }
        public int? PARAM_TYPE_SETUP_ID { get; set; }
        public int? REQUEST_ID { get; set; }
        public bool IS_AUTHENTICATION { get; set; }
        public string PARAM_NAME { get; set; }
        public string PARAM_VALUE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Site
    public partial class Site
    {
        public long? SITE_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? DISTRICT_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? TOP_LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public decimal? AREA { get; set; }
        public string UNIT { get; set; }
        public decimal? SCALE { get; set; }
        public decimal? ROTATIONX { get; set; }
        public decimal? ROTATIONY { get; set; }
        public decimal? ROTATIONZ { get; set; }
        public decimal? GLTF_LATITUDE { get; set; }
        public decimal? GLTF_LONGITUDE { get; set; }
        public decimal? CENTER_LATITUDE { get; set; }
        public decimal? CENTER_LONGITUDE { get; set; }
        public decimal? RADIUS_IN_METERS { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Video_ai_engine
    public partial class Video_ai_engine
    {
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string ENGINE_NAME { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region User_theme
    public partial class User_theme
    {
        public int? USER_THEME_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_THEME_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Organization_chart_color
    public partial class Organization_chart_color
    {
        public int? ORGANIZATION_CHART_COLOR_ID { get; set; }
        public int? ORGANIZATION_COLOR_SCHEME_ID { get; set; }
        public string COLOR { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Default_chart_color
    public partial class Default_chart_color
    {
        public int? DEFAULT_CHART_COLOR_ID { get; set; }
        public int? DEFAULT_SETTINGS_ID { get; set; }
        public string COLOR { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Video_ai_instance
    public partial class Video_ai_instance
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public string CONNECTION_URL { get; set; }
        public long? CONNECTION_TYPE_SETUP_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool IS_LPR { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Video_ai_asset
    public partial class Video_ai_asset
    {
        public int? VIDEO_AI_ASSET_ID { get; set; }
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public int? VIDEO_AI_ASSET_ID_REF { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public int? RESOLUTION_X { get; set; }
        public int? RESOLUTION_Y { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Organization_districtnex_module
    public partial class Organization_districtnex_module
    {
        public int? ORGANIZATION_DISTRICTNEX_MODULE_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public int? DISTRICTNEX_MODULE_ID { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Region_view
    public partial class Region_view
    {
        public long? REGION_VIEW_ID { get; set; }
        public long? REGION_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal? PITCH { get; set; }
        public decimal? BEARING { get; set; }
        public decimal? ZOOM { get; set; }
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
    }
    #endregion
    #region Districtnex_module
    public partial class Districtnex_module
    {
        public int? DISTRICTNEX_MODULE_ID { get; set; }
        public string NAME { get; set; }
        public int? DISPLAY_ORDER { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
}