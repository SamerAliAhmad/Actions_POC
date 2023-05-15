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
        public Organization Organization { get; set; }
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
        public Setup Organization_type_setup { get; set; }
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
        public Organization Organization { get; set; }
        public Setup Data_level_setup { get; set; }
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
        public Organization Organization { get; set; }
        public Setup Log_type_setup { get; set; }
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
        public Organization Organization { get; set; }
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
        public Organization Organization { get; set; }
        public Setup Image_type_setup { get; set; }
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
        public User User { get; set; }
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
        public Data_source Data_source { get; set; }
        public Kpi Kpi { get; set; }
        public Organization Organization { get; set; }
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
        public Organization_color_scheme Organization_color_scheme { get; set; }
        public Setup Data_level_setup { get; set; }
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
        public Districtnex_module Districtnex_module { get; set; }
        public Organization Organization { get; set; }
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
