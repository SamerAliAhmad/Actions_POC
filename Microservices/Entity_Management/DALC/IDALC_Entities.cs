using System;

namespace DALC
{
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
}
