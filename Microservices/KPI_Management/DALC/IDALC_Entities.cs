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
        public Dimension Dimension { get; set; }
        public Setup Kpi_type_setup { get; set; }
        public Setup Max_data_level_setup { get; set; }
        public Setup Min_data_level_setup { get; set; }
        public Setup_category Setup_category { get; set; }
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
        public Setup Asset_type_setup { get; set; }
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
        public Area Area { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
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
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public Site Site { get; set; }
        public User User { get; set; }
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
        public Entity Entity { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
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
        public Area Area { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Site Site { get; set; }
        public Top_level Top_level { get; set; }
        public Setup Entity_type_setup { get; set; }
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
        public District District { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
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
        public Entity Entity { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
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
        public District District { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
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
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public Site Site { get; set; }
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
        public Area Area { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
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
        public Asset Asset { get; set; }
        public Space Space { get; set; }
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
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
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
        public Entity Entity { get; set; }
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
        public District District { get; set; }
        public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
        public User User { get; set; }
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
        public Organization Organization { get; set; }
        public Setup User_type_setup { get; set; }
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
        public Floor Floor { get; set; }
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
        public Area Area { get; set; }
        public District District { get; set; }
        public Region Region { get; set; }
        public Top_level Top_level { get; set; }
    }
    #endregion
}
