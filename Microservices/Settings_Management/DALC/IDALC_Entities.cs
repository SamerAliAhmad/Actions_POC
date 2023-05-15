using System;

namespace DALC
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
        public Build_version Build_version { get; set; }
        public Setup Build_log_type_setup { get; set; }
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
        public Setup Data_level_setup { get; set; }
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
        public Kpi Kpi { get; set; }
        public Setup Operation_setup { get; set; }
        public Setup Value_type_setup { get; set; }
        public User User { get; set; }
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
        public Default_settings Default_settings { get; set; }
        public Setup Image_type_setup { get; set; }
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
        public Setup_category Setup_category { get; set; }
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
        public Setup Application_name_setup { get; set; }
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
        public Default_settings Default_settings { get; set; }
        public Setup Data_level_setup { get; set; }
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
