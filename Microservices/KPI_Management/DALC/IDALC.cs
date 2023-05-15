using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Kpi_By_KPI_ID
        Kpi Get_Kpi_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Get_Asset_By_ASSET_ID
        Asset Get_Asset_By_ASSET_ID(long? ASSET_ID);
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
        Ext_study_zone Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(int? EXT_STUDY_ZONE_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID
        Area_kpi_user_access Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID(long? AREA_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID
        Site_kpi_user_access Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID(long? SITE_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID
        Entity_kpi Get_Entity_kpi_By_ENTITY_KPI_ID(long? ENTITY_KPI_ID);
        #endregion
        #region Get_Entity_By_ENTITY_ID
        Entity Get_Entity_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID
        District_kpi Get_District_kpi_By_DISTRICT_KPI_ID(long? DISTRICT_KPI_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID
        Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(long? ENTITY_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Area_By_AREA_ID
        Area Get_Area_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID
        Site_kpi Get_Site_kpi_By_SITE_KPI_ID(long? SITE_KPI_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID
        Area_kpi Get_Area_kpi_By_AREA_KPI_ID(long? AREA_KPI_ID);
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID
        Space_asset Get_Space_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID);
        #endregion
        #region Get_District_By_DISTRICT_ID
        District Get_District_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Floor_By_FLOOR_ID
        Floor Get_Floor_By_FLOOR_ID(long? FLOOR_ID);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID
        District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(long? DISTRICT_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_User_By_USER_ID
        User Get_User_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Space_By_SPACE_ID
        Space Get_Space_By_SPACE_ID(long? SPACE_ID);
        #endregion
        #region Get_Site_By_SITE_ID
        Site Get_Site_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_Kpi_By_KPI_ID_List
        List<Kpi> Get_Kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Asset_By_ASSET_ID_List
        List<Asset> Get_Asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST);
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List
        List<Ext_study_zone> Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(IEnumerable<int?> EXT_STUDY_ZONE_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List(IEnumerable<long?> AREA_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List(IEnumerable<long?> SITE_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_List
        List<Entity_kpi> Get_Entity_kpi_By_ENTITY_KPI_ID_List(IEnumerable<long?> ENTITY_KPI_ID_LIST);
        #endregion
        #region Get_Entity_By_ENTITY_ID_List
        List<Entity> Get_Entity_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_List
        List<District_kpi> Get_District_kpi_By_DISTRICT_KPI_ID_List(IEnumerable<long?> DISTRICT_KPI_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List(IEnumerable<long?> ENTITY_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Area_By_AREA_ID_List
        List<Area> Get_Area_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List
        List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List(IEnumerable<long?> SITE_KPI_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List
        List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List(IEnumerable<long?> AREA_KPI_ID_LIST);
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_List
        List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List(IEnumerable<long?> SPACE_ASSET_ID_LIST);
        #endregion
        #region Get_District_By_DISTRICT_ID_List
        List<District> Get_District_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Floor_By_FLOOR_ID_List
        List<Floor> Get_Floor_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List(IEnumerable<long?> DISTRICT_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_User_By_USER_ID_List
        List<User> Get_User_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Space_By_SPACE_ID_List
        List<Space> Get_Space_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST);
        #endregion
        #region Get_Site_By_SITE_ID_List
        List<Site> Get_Site_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Kpi_By_OWNER_ID
        List<Kpi> Get_Kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Kpi_By_DIMENSION_ID
        List<Kpi> Get_Kpi_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED
        List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID);
        #endregion
        #region Get_Asset_By_OWNER_ID
        List<Asset> Get_Asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID);
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID
        List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
        List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_IS_DELETED
        List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID
        List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID
        List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED
        List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_By_OWNER_ID
        List<Entity> Get_Entity_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Entity_By_SITE_ID
        List<Entity> Get_Entity_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_Entity_By_AREA_ID
        List<Entity> Get_Entity_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Entity_By_DISTRICT_ID
        List<Entity> Get_Entity_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_Entity_By_REGION_ID
        List<Entity> Get_Entity_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID
        List<Entity> Get_Entity_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID
        List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID(long? ENTITY_TYPE_SETUP_ID);
        #endregion
        #region Get_District_kpi_By_OWNER_ID
        List<District_kpi> Get_District_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_District_kpi_By_OWNER_ID_IS_DELETED
        List<District_kpi> Get_District_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID
        List<District_kpi> Get_District_kpi_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_By_OWNER_ID_IS_DELETED
        List<Area> Get_Area_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_By_OWNER_ID
        List<Area> Get_Area_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Area_By_DISTRICT_ID
        List<Area> Get_Area_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_Area_By_REGION_ID
        List<Area> Get_Area_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID
        List<Area> Get_Area_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Get_Site_kpi_By_OWNER_ID
        List<Site_kpi> Get_Site_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_IS_DELETED
        List<Site_kpi> Get_Site_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_kpi_By_SITE_ID
        List<Site_kpi> Get_Site_kpi_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID
        List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_IS_DELETED
        List<Area_kpi> Get_Area_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_kpi_By_OWNER_ID
        List<Area_kpi> Get_Area_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Area_kpi_By_AREA_ID
        List<Area_kpi> Get_Area_kpi_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Space_asset_By_OWNER_ID
        List<Space_asset> Get_Space_asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Space_asset_By_SPACE_ID
        List<Space_asset> Get_Space_asset_By_SPACE_ID(long? SPACE_ID);
        #endregion
        #region Get_Space_asset_By_ASSET_ID
        List<Space_asset> Get_Space_asset_By_ASSET_ID(long? ASSET_ID);
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED
        List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID
        List<Space_asset> Get_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID);
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL);
        #endregion
        #region Get_District_By_OWNER_ID_IS_DELETED
        List<District> Get_District_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_By_OWNER_ID
        List<District> Get_District_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_District_By_REGION_ID
        List<District> Get_District_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_District_By_TOP_LEVEL_ID
        List<District> Get_District_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED
        List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Floor_By_OWNER_ID
        List<Floor> Get_Floor_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Floor_By_ENTITY_ID
        List<Floor> Get_Floor_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED
        List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID
        List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID
        List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED
        List<User> Get_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID
        User Get_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID);
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID
        User Get_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID
        List<User> Get_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID);
        #endregion
        #region Get_User_By_ORGANIZATION_ID
        List<User> Get_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_User_By_OWNER_ID
        List<User> Get_User_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL
        List<User> Get_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL);
        #endregion
        #region Get_User_By_IS_DELETED
        List<User> Get_User_By_IS_DELETED(bool IS_DELETED);
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED);
        #endregion
        #region Get_Space_By_OWNER_ID
        List<Space> Get_Space_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Space_By_FLOOR_ID
        List<Space> Get_Space_By_FLOOR_ID(long? FLOOR_ID);
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED
        List<Space> Get_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED
        List<Site> Get_Site_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_By_OWNER_ID
        List<Site> Get_Site_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Site_By_AREA_ID
        List<Site> Get_Site_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Site_By_DISTRICT_ID
        List<Site> Get_Site_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_Site_By_REGION_ID
        List<Site> Get_Site_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID
        List<Site> Get_Site_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_List
        List<Kpi> Get_Kpi_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_List
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_List
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_List
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_List
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_List
        List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Entity_By_SITE_ID_List
        List<Entity> Get_Entity_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Entity_By_AREA_ID_List
        List<Entity> Get_Entity_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List
        List<Entity> Get_Entity_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Entity_By_REGION_ID_List
        List<Entity> Get_Entity_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List
        List<Entity> Get_Entity_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List
        List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List(IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_List
        List<District_kpi> Get_District_kpi_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Area_By_DISTRICT_ID_List
        List<Area> Get_Area_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Area_By_REGION_ID_List
        List<Area> Get_Area_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List
        List<Area> Get_Area_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List
        List<Site_kpi> Get_Site_kpi_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_AREA_ID_List
        List<Area_kpi> Get_Area_kpi_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Space_asset_By_SPACE_ID_List
        List<Space_asset> Get_Space_asset_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST);
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List
        List<Space_asset> Get_Space_asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST);
        #endregion
        #region Get_District_By_REGION_ID_List
        List<District> Get_District_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List
        List<District> Get_District_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(IEnumerable<int?> DATA_SOURCE_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Floor_By_ENTITY_ID_List
        List<Floor> Get_Floor_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List
        List<User> Get_User_By_USER_TYPE_SETUP_ID_List(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List
        List<User> Get_User_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Space_By_FLOOR_ID_List
        List<Space> Get_Space_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_Site_By_AREA_ID_List
        List<Site> Get_Site_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Site_By_DISTRICT_ID_List
        List<Site> Get_Site_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Site_By_REGION_ID_List
        List<Site> Get_Site_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List
        List<Site> Get_Site_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Kpi_By_Where
        List<Kpi> Get_Kpi_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Asset_By_Where
        List<Asset> Get_Asset_By_Where(string NAME, string GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Ext_study_zone_By_Where
        List<Ext_study_zone> Get_Ext_study_zone_By_Where(string NAME, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_user_access_By_Where
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_user_access_By_Where
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_By_Where
        List<Entity_kpi> Get_Entity_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_By_Where
        List<Entity> Get_Entity_By_Where(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_By_Where
        List<District_kpi> Get_District_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_user_access_By_Where
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where
        List<Area> Get_Area_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where
        List<Site_kpi> Get_Site_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where
        List<Area_kpi> Get_Area_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_asset_By_Where
        List<Space_asset> Get_Space_asset_By_Where(string CUSTOM_NAME, string ASSET_ICON, string EXTERNAL_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where
        List<District> Get_District_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where
        List<Floor> Get_Floor_By_Where(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where
        List<User> Get_User_By_Where(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where
        List<Space> Get_Space_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where
        List<Site> Get_Site_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Kpi_By_Where_In_List
        List<Kpi> Get_Kpi_By_Where_In_List(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Asset_By_Where_In_List
        List<Asset> Get_Asset_By_Where_In_List(string NAME, string GLTF_URL, IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_user_access_By_Where_In_List
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_user_access_By_Where_In_List
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_By_Where_In_List
        List<Entity_kpi> Get_Entity_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_By_Where_In_List
        List<Entity> Get_Entity_By_Where_In_List(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_By_Where_In_List
        List<District_kpi> Get_District_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_In_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where_In_List
        List<Area> Get_Area_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where_In_List
        List<Site_kpi> Get_Site_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where_In_List
        List<Area_kpi> Get_Area_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_asset_By_Where_In_List
        List<Space_asset> Get_Space_asset_By_Where_In_List(string CUSTOM_NAME, string ASSET_ICON, IEnumerable<long?> SPACE_ID_LIST, IEnumerable<long?> ASSET_ID_LIST, IEnumerable<string> EXTERNAL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where_In_List
        List<District> Get_District_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where_In_List
        List<Floor> Get_Floor_By_Where_In_List(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_In_List
        List<User> Get_User_By_Where_In_List(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where_In_List
        List<Space> Get_Space_By_Where_In_List(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_In_List
        List<Site> Get_Site_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Kpi
        void Delete_Kpi(int? KPI_ID);
        #endregion
        #region Delete_Asset
        void Delete_Asset(long? ASSET_ID);
        #endregion
        #region Delete_Ext_study_zone
        void Delete_Ext_study_zone(int? EXT_STUDY_ZONE_ID);
        #endregion
        #region Delete_Area_kpi_user_access
        void Delete_Area_kpi_user_access(long? AREA_KPI_USER_ACCESS_ID);
        #endregion
        #region Delete_Site_kpi_user_access
        void Delete_Site_kpi_user_access(long? SITE_KPI_USER_ACCESS_ID);
        #endregion
        #region Delete_Entity_kpi
        void Delete_Entity_kpi(long? ENTITY_KPI_ID);
        #endregion
        #region Delete_Entity
        void Delete_Entity(long? ENTITY_ID);
        #endregion
        #region Delete_District_kpi
        void Delete_District_kpi(long? DISTRICT_KPI_ID);
        #endregion
        #region Delete_Entity_kpi_user_access
        void Delete_Entity_kpi_user_access(long? ENTITY_KPI_USER_ACCESS_ID);
        #endregion
        #region Delete_Area
        void Delete_Area(long? AREA_ID);
        #endregion
        #region Delete_Site_kpi
        void Delete_Site_kpi(long? SITE_KPI_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Area_kpi
        void Delete_Area_kpi(long? AREA_KPI_ID);
        #endregion
        #region Delete_Space_asset
        void Delete_Space_asset(long? SPACE_ASSET_ID);
        #endregion
        #region Delete_District
        void Delete_District(long? DISTRICT_ID);
        #endregion
        #region Delete_Organization_data_source_kpi
        void Delete_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Floor
        void Delete_Floor(long? FLOOR_ID);
        #endregion
        #region Delete_District_kpi_user_access
        void Delete_District_kpi_user_access(long? DISTRICT_KPI_USER_ACCESS_ID);
        #endregion
        #region Delete_User
        void Delete_User(long? USER_ID);
        #endregion
        #region Delete_Space
        void Delete_Space(long? SPACE_ID);
        #endregion
        #region Delete_Site
        void Delete_Site(long? SITE_ID);
        #endregion
        #region Delete_Kpi_By_OWNER_ID
        void Delete_Kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Kpi_By_DIMENSION_ID
        void Delete_Kpi_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Delete_Kpi_By_SETUP_CATEGORY_ID
        void Delete_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        void Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        void Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Kpi_By_OWNER_ID_IS_DELETED
        void Delete_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Kpi_By_KPI_TYPE_SETUP_ID
        void Delete_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID);
        #endregion
        #region Delete_Asset_By_OWNER_ID
        void Delete_Asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        void Delete_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID);
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        void Delete_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID
        void Delete_Ext_study_zone_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED
        void Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Area_kpi_user_access_By_OWNER_ID
        void Delete_Area_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Area_kpi_user_access_By_USER_ID
        void Delete_Area_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_Area_kpi_user_access_By_AREA_ID
        void Delete_Area_kpi_user_access_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
        void Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Site_kpi_user_access_By_OWNER_ID
        void Delete_Site_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Site_kpi_user_access_By_USER_ID
        void Delete_Site_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_Site_kpi_user_access_By_SITE_ID
        void Delete_Site_kpi_user_access_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
        void Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Entity_kpi_By_OWNER_ID_IS_DELETED
        void Delete_Entity_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Entity_kpi_By_OWNER_ID
        void Delete_Entity_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Entity_kpi_By_ENTITY_ID
        void Delete_Entity_kpi_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Delete_Entity_By_OWNER_ID_IS_DELETED
        void Delete_Entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Entity_By_OWNER_ID
        void Delete_Entity_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Entity_By_SITE_ID
        void Delete_Entity_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Delete_Entity_By_AREA_ID
        void Delete_Entity_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Delete_Entity_By_DISTRICT_ID
        void Delete_Entity_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Delete_Entity_By_REGION_ID
        void Delete_Entity_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Delete_Entity_By_TOP_LEVEL_ID
        void Delete_Entity_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Delete_Entity_By_ENTITY_TYPE_SETUP_ID
        void Delete_Entity_By_ENTITY_TYPE_SETUP_ID(long? ENTITY_TYPE_SETUP_ID);
        #endregion
        #region Delete_District_kpi_By_OWNER_ID
        void Delete_District_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_District_kpi_By_OWNER_ID_IS_DELETED
        void Delete_District_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_District_kpi_By_DISTRICT_ID
        void Delete_District_kpi_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Delete_Entity_kpi_user_access_By_OWNER_ID
        void Delete_Entity_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Entity_kpi_user_access_By_USER_ID
        void Delete_Entity_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_Entity_kpi_user_access_By_ENTITY_ID
        void Delete_Entity_kpi_user_access_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
        void Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Area_By_OWNER_ID_IS_DELETED
        void Delete_Area_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Area_By_OWNER_ID
        void Delete_Area_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Area_By_DISTRICT_ID
        void Delete_Area_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Delete_Area_By_REGION_ID
        void Delete_Area_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Delete_Area_By_TOP_LEVEL_ID
        void Delete_Area_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Delete_Site_kpi_By_OWNER_ID
        void Delete_Site_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Site_kpi_By_OWNER_ID_IS_DELETED
        void Delete_Site_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Site_kpi_By_SITE_ID
        void Delete_Site_kpi_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Delete_Setup_By_OWNER_ID
        void Delete_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Area_kpi_By_OWNER_ID_IS_DELETED
        void Delete_Area_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Area_kpi_By_OWNER_ID
        void Delete_Area_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Area_kpi_By_AREA_ID
        void Delete_Area_kpi_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_Space_asset_By_OWNER_ID
        void Delete_Space_asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Space_asset_By_SPACE_ID
        void Delete_Space_asset_By_SPACE_ID(long? SPACE_ID);
        #endregion
        #region Delete_Space_asset_By_ASSET_ID
        void Delete_Space_asset_By_ASSET_ID(long? ASSET_ID);
        #endregion
        #region Delete_Space_asset_By_OWNER_ID_IS_DELETED
        void Delete_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Space_asset_By_EXTERNAL_ID
        void Delete_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID);
        #endregion
        #region Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        void Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL);
        #endregion
        #region Delete_District_By_OWNER_ID_IS_DELETED
        void Delete_District_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_District_By_OWNER_ID
        void Delete_District_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_District_By_REGION_ID
        void Delete_District_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Delete_District_By_TOP_LEVEL_ID
        void Delete_District_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID
        void Delete_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID
        void Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_KPI_ID
        void Delete_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_ORGANIZATION_ID
        void Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        void Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Floor_By_OWNER_ID_IS_DELETED
        void Delete_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Floor_By_OWNER_ID
        void Delete_Floor_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Floor_By_ENTITY_ID
        void Delete_Floor_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED
        void Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_District_kpi_user_access_By_OWNER_ID
        void Delete_District_kpi_user_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_District_kpi_user_access_By_USER_ID
        void Delete_District_kpi_user_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_District_kpi_user_access_By_DISTRICT_ID
        void Delete_District_kpi_user_access_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        void Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Delete_User_By_OWNER_ID_IS_DELETED
        void Delete_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_User_By_USERNAME_OWNER_ID
        void Delete_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID);
        #endregion
        #region Delete_User_By_EMAIL_OWNER_ID
        void Delete_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID);
        #endregion
        #region Delete_User_By_USER_TYPE_SETUP_ID
        void Delete_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID);
        #endregion
        #region Delete_User_By_ORGANIZATION_ID
        void Delete_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_User_By_OWNER_ID
        void Delete_User_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_User_By_IS_RECEIVE_EMAIL
        void Delete_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL);
        #endregion
        #region Delete_User_By_IS_DELETED
        void Delete_User_By_IS_DELETED(bool IS_DELETED);
        #endregion
        #region Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        void Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED);
        #endregion
        #region Delete_Space_By_OWNER_ID
        void Delete_Space_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Space_By_FLOOR_ID
        void Delete_Space_By_FLOOR_ID(long? FLOOR_ID);
        #endregion
        #region Delete_Space_By_OWNER_ID_IS_DELETED
        void Delete_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Site_By_OWNER_ID_IS_DELETED
        void Delete_Site_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Site_By_OWNER_ID
        void Delete_Site_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Site_By_AREA_ID
        void Delete_Site_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Delete_Site_By_DISTRICT_ID
        void Delete_Site_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Delete_Site_By_REGION_ID
        void Delete_Site_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Delete_Site_By_TOP_LEVEL_ID
        void Delete_Site_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
        #endregion
        #region Edit_Kpi
        int? Edit_Kpi(int? KPI_ID, int? DIMENSION_ID, int? SETUP_CATEGORY_ID, string NAME, string UNIT, long? KPI_TYPE_SETUP_ID, bool HAS_CORRELATION, bool IS_TRENDLINE, bool IS_DECIMAL_VALUE, bool HAS_SQM, bool IS_BY_SEVERITY, bool IS_ADDITIVE_DATA, decimal? MINIMUM_VALUE, decimal? MAXIMUM_VALUE, string LATEST_DATA_CREATION_DATE, bool IS_AUTO_GENERATE, long? MIN_DATA_LEVEL_SETUP_ID, long? MAX_DATA_LEVEL_SETUP_ID, bool IS_EXTERNAL, bool HAS_ALERTS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Asset
        long? Edit_Asset(long? ASSET_ID, long? ASSET_TYPE_SETUP_ID, string NAME, string GLTF_URL, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Ext_study_zone
        int? Edit_Ext_study_zone(int? EXT_STUDY_ZONE_ID, string NAME, decimal? LATITUDE, decimal? LONGITUDE, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Area_kpi_user_access
        long? Edit_Area_kpi_user_access(long? AREA_KPI_USER_ACCESS_ID, long? USER_ID, long? AREA_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Site_kpi_user_access
        long? Edit_Site_kpi_user_access(long? SITE_KPI_USER_ACCESS_ID, long? USER_ID, long? SITE_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Entity_kpi
        long? Edit_Entity_kpi(long? ENTITY_KPI_ID, long? ENTITY_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Entity
        long? Edit_Entity(long? ENTITY_ID, long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, long? ENTITY_TYPE_SETUP_ID, string NAME, int? NUMBER_OF_FLOORS, decimal? GLA, string GLA_UNIT, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string SOLID_GLTF_URL, decimal? POPUL_ALT_X, decimal? POPUP_ALT_Y, decimal? POPUP_ALT_Z, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_District_kpi
        long? Edit_District_kpi(long? DISTRICT_KPI_ID, long? DISTRICT_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Entity_kpi_user_access
        long? Edit_Entity_kpi_user_access(long? ENTITY_KPI_USER_ACCESS_ID, long? USER_ID, long? ENTITY_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Area
        long? Edit_Area(long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Site_kpi
        long? Edit_Site_kpi(long? SITE_KPI_ID, long? SITE_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Area_kpi
        long? Edit_Area_kpi(long? AREA_KPI_ID, long? AREA_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Space_asset
        long? Edit_Space_asset(long? SPACE_ASSET_ID, long? SPACE_ID, long? ASSET_ID, string EXTERNAL_ID, bool IS_MERAKI_WIFI_SIGNAL, string CUSTOM_NAME, decimal? POSITION_X, decimal? POSITION_Y, decimal? POSITION_Z, decimal? SCALE_MULTIPLIER, decimal? ROTATE_X, decimal? ROTATE_Y, decimal? ROTATE_Z, string ASSET_ICON, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_District
        long? Edit_District(long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization_data_source_kpi
        int? Edit_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID, int? DATA_SOURCE_ID, int? KPI_ID, int? ORGANIZATION_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Floor
        long? Edit_Floor(long? FLOOR_ID, long? ENTITY_ID, int? FLOOR_NUMBER, string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, decimal? AREA, string UNIT, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_District_kpi_user_access
        long? Edit_District_kpi_user_access(long? DISTRICT_KPI_USER_ACCESS_ID, long? USER_ID, long? DISTRICT_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_User
        long? Edit_User(long? USER_ID, int? ORGANIZATION_ID, long? USER_TYPE_SETUP_ID, int? OWNER_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, bool IS_ACTIVE, bool IS_DELETED, bool IS_RECEIVE_EMAIL, int? DATA_RETENTION_PERIOD, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, string DATE_DELETED, string ENTRY_DATE, long? ENTRY_USER_ID, string LAST_UPDATE);
        #endregion
        #region Edit_Space
        long? Edit_Space(long? SPACE_ID, long? FLOOR_ID, string NAME, decimal? AREA, string UNIT, int? OCCUPANT_LOAD_FACTOR, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Site
        long? Edit_Site(long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
