using System;

namespace DALC
{
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
        public Site Site { get; set; }
        public Setup View_type_setup { get; set; }
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
        public Entity Entity { get; set; }
        public Setup View_type_setup { get; set; }
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
        public Organization_level_access Organization_level_access { get; set; }
        public Setup Data_level_setup { get; set; }
        public User User { get; set; }
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
        public Districtnex_module Districtnex_module { get; set; }
        public User User { get; set; }
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
        public District District { get; set; }
        public Setup View_type_setup { get; set; }
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
        public Area Area { get; set; }
        public Setup View_type_setup { get; set; }
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
        public Top_level Top_level { get; set; }
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
        public Organization_theme Organization_theme { get; set; }
        public User User { get; set; }
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
        public Region Region { get; set; }
        public Setup View_type_setup { get; set; }
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
