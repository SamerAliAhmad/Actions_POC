using System;

namespace DALC
{
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
        public Video_ai_engine Video_ai_engine { get; set; }
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
        public Entity Entity { get; set; }
        public Video_ai_asset Video_ai_asset { get; set; }
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
        public Video_ai_engine Video_ai_engine { get; set; }
        public Setup Connection_type_setup { get; set; }
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
        public Space_asset Space_asset { get; set; }
        public Video_ai_instance Video_ai_instance { get; set; }
    }
    #endregion
}
