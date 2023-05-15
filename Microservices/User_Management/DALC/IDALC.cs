using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Site_view_By_SITE_VIEW_ID
        Site_view Get_Site_view_By_SITE_VIEW_ID(long? SITE_VIEW_ID);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
        Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(int? REMOVED_EXTRUSION_ID);
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID
        Entity_view Get_Entity_view_By_ENTITY_VIEW_ID(long? ENTITY_VIEW_ID);
        #endregion
        #region Get_Top_level_By_TOP_LEVEL_ID
        Top_level Get_Top_level_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
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
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID
        User_level_access Get_User_level_access_By_USER_LEVEL_ACCESS_ID(long? USER_LEVEL_ACCESS_ID);
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID
        User_districtnex_module Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID(long? USER_DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID
        Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(long? ENTITY_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID
        District_view Get_District_view_By_DISTRICT_VIEW_ID(long? DISTRICT_VIEW_ID);
        #endregion
        #region Get_Area_By_AREA_ID
        Area Get_Area_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID
        Area_view Get_Area_view_By_AREA_VIEW_ID(long? AREA_VIEW_ID);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID
        Site_kpi Get_Site_kpi_By_SITE_KPI_ID(long? SITE_KPI_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID
        Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID(int? ORGANIZATION_RELATION_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID
        Area_kpi Get_Area_kpi_By_AREA_KPI_ID(long? AREA_KPI_ID);
        #endregion
        #region Get_Region_By_REGION_ID
        Region Get_Region_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_District_By_DISTRICT_ID
        District Get_District_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID
        District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(long? DISTRICT_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_User_By_USER_ID
        User Get_User_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Site_By_SITE_ID
        Site Get_Site_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_User_theme_By_USER_THEME_ID
        User_theme Get_User_theme_By_USER_THEME_ID(int? USER_THEME_ID);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID
        Region_view Get_Region_view_By_REGION_VIEW_ID(long? REGION_VIEW_ID);
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List
        List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List(IEnumerable<long?> SITE_VIEW_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List
        List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST);
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List
        List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List(IEnumerable<long?> ENTITY_VIEW_ID_LIST);
        #endregion
        #region Get_Top_level_By_TOP_LEVEL_ID_List
        List<Top_level> Get_Top_level_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
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
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List
        List<User_level_access> Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List(IEnumerable<long?> USER_LEVEL_ACCESS_ID_LIST);
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List
        List<User_districtnex_module> Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List(IEnumerable<long?> USER_DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List(IEnumerable<long?> ENTITY_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_List
        List<District_view> Get_District_view_By_DISTRICT_VIEW_ID_List(IEnumerable<long?> DISTRICT_VIEW_ID_LIST);
        #endregion
        #region Get_Area_By_AREA_ID_List
        List<Area> Get_Area_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_List
        List<Area_view> Get_Area_view_By_AREA_VIEW_ID_List(IEnumerable<long?> AREA_VIEW_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List
        List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List(IEnumerable<long?> SITE_KPI_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List
        List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List
        List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List(IEnumerable<long?> AREA_KPI_ID_LIST);
        #endregion
        #region Get_Region_By_REGION_ID_List
        List<Region> Get_Region_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_District_By_DISTRICT_ID_List
        List<District> Get_District_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List(IEnumerable<long?> DISTRICT_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_User_By_USER_ID_List
        List<User> Get_User_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Site_By_SITE_ID_List
        List<Site> Get_Site_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_User_theme_By_USER_THEME_ID_List
        List<User_theme> Get_User_theme_By_USER_THEME_ID_List(IEnumerable<int?> USER_THEME_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List
        List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List(IEnumerable<long?> REGION_VIEW_ID_LIST);
        #endregion
        #region Get_Site_view_By_OWNER_ID_IS_DELETED
        List<Site_view> Get_Site_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID
        List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Site_view_By_OWNER_ID
        List<Site_view> Get_Site_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Site_view_By_SITE_ID
        List<Site_view> Get_Site_view_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_view_By_OWNER_ID
        List<Entity_view> Get_Entity_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID
        List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED
        List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_view_By_ENTITY_ID
        List<Entity_view> Get_Entity_view_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_Top_level_By_OWNER_ID
        List<Top_level> Get_Top_level_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Top_level_By_OWNER_ID_IS_DELETED
        List<Top_level> Get_Top_level_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_User_level_access_By_OWNER_ID
        List<User_level_access> Get_User_level_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(long? ORGANIZATION_LEVEL_ACCESS_ID);
        #endregion
        #region Get_User_level_access_By_USER_ID
        List<User_level_access> Get_User_level_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_User_level_access_By_LEVEL_ID
        List<User_level_access> Get_User_level_access_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID
        List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_User_level_access_By_OWNER_ID_IS_DELETED
        List<User_level_access> Get_User_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
        List<User_level_access> Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(long? USER_ID, long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID
        List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_User_districtnex_module_By_USER_ID
        List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID
        List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID_IS_DELETED
        List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_District_view_By_OWNER_ID
        List<District_view> Get_District_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_District_view_By_DISTRICT_ID
        List<District_view> Get_District_view_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID
        List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_District_view_By_OWNER_ID_IS_DELETED
        List<District_view> Get_District_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_Area_view_By_OWNER_ID
        List<Area_view> Get_Area_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Area_view_By_AREA_ID
        List<Area_view> Get_Area_view_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID
        List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Area_view_By_OWNER_ID_IS_DELETED
        List<Area_view> Get_Area_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_USER_ID
        List<Organization_relation> Get_Organization_relation_By_USER_ID(long? USER_ID);
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
        #region Get_Region_By_OWNER_ID_IS_DELETED
        List<Region> Get_Region_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Region_By_OWNER_ID
        List<Region> Get_Region_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID
        List<Region> Get_Region_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
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
        #region Get_User_theme_By_OWNER_ID
        List<User_theme> Get_User_theme_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_User_theme_By_USER_ID
        List<User_theme> Get_User_theme_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID
        List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID(int? ORGANIZATION_THEME_ID);
        #endregion
        #region Get_User_theme_By_OWNER_ID_IS_DELETED
        List<User_theme> Get_User_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Region_view_By_OWNER_ID
        List<Region_view> Get_Region_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Region_view_By_REGION_ID
        List<Region_view> Get_Region_view_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID
        List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Region_view_By_OWNER_ID_IS_DELETED
        List<Region_view> Get_Region_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List
        List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_view_By_SITE_ID_List
        List<Site_view> Get_Site_view_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List
        List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List
        List<Entity_view> Get_Entity_view_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
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
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
        List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST);
        #endregion
        #region Get_User_level_access_By_USER_ID_List
        List<User_level_access> Get_User_level_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_User_level_access_By_LEVEL_ID_List
        List<User_level_access> Get_User_level_access_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List
        List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_User_districtnex_module_By_USER_ID_List
        List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST);
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
        #region Get_District_view_By_DISTRICT_ID_List
        List<District_view> Get_District_view_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_List
        List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
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
        #region Get_Area_view_By_AREA_ID_List
        List<Area_view> Get_Area_view_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_List
        List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List
        List<Site_kpi> Get_Site_kpi_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_USER_ID_List
        List<Organization_relation> Get_Organization_relation_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
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
        #region Get_Region_By_TOP_LEVEL_ID_List
        List<Region> Get_Region_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_District_By_REGION_ID_List
        List<District> Get_District_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List
        List<District> Get_District_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
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
        #region Get_User_theme_By_USER_ID_List
        List<User_theme> Get_User_theme_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID_List
        List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID_List(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_ID_List
        List<Region_view> Get_Region_view_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List
        List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_view_By_Where
        List<Site_view> Get_Site_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where
        List<Removed_extrusion> Get_Removed_extrusion_By_Where(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_view_By_Where
        List<Entity_view> Get_Entity_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Top_level_By_Where
        List<Top_level> Get_Top_level_By_Where(string NAME, string LOCATION, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
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
        #region Get_User_level_access_By_Where
        List<User_level_access> Get_User_level_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_districtnex_module_By_Where
        List<User_districtnex_module> Get_User_districtnex_module_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_user_access_By_Where
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_view_By_Where
        List<District_view> Get_District_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where
        List<Area> Get_Area_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_view_By_Where
        List<Area_view> Get_Area_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where
        List<Site_kpi> Get_Site_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where
        List<Organization_relation> Get_Organization_relation_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where
        List<Area_kpi> Get_Area_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where
        List<Region> Get_Region_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where
        List<District> Get_District_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where
        List<User> Get_User_By_Where(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where
        List<Site> Get_Site_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_theme_By_Where
        List<User_theme> Get_User_theme_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where
        List<Region_view> Get_Region_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_view_By_Where_In_List
        List<Site_view> Get_Site_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List
        List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_view_By_Where_In_List
        List<Entity_view> Get_Entity_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
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
        #region Get_User_level_access_By_Where_In_List
        List<User_level_access> Get_User_level_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_districtnex_module_By_Where_In_List
        List<User_districtnex_module> Get_User_districtnex_module_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_In_List
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_view_By_Where_In_List
        List<District_view> Get_District_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where_In_List
        List<Area> Get_Area_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_view_By_Where_In_List
        List<Area_view> Get_Area_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where_In_List
        List<Site_kpi> Get_Site_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where_In_List
        List<Organization_relation> Get_Organization_relation_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where_In_List
        List<Area_kpi> Get_Area_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where_In_List
        List<Region> Get_Region_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where_In_List
        List<District> Get_District_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_In_List
        List<User> Get_User_By_Where_In_List(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_In_List
        List<Site> Get_Site_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_theme_By_Where_In_List
        List<User_theme> Get_User_theme_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> ORGANIZATION_THEME_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where_In_List
        List<Region_view> Get_Region_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Site_view
        void Delete_Site_view(long? SITE_VIEW_ID);
        #endregion
        #region Delete_Removed_extrusion
        void Delete_Removed_extrusion(int? REMOVED_EXTRUSION_ID);
        #endregion
        #region Delete_Entity_view
        void Delete_Entity_view(long? ENTITY_VIEW_ID);
        #endregion
        #region Delete_Top_level
        void Delete_Top_level(long? TOP_LEVEL_ID);
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
        #region Delete_User_level_access
        void Delete_User_level_access(long? USER_LEVEL_ACCESS_ID);
        #endregion
        #region Delete_User_districtnex_module
        void Delete_User_districtnex_module(long? USER_DISTRICTNEX_MODULE_ID);
        #endregion
        #region Delete_Entity_kpi_user_access
        void Delete_Entity_kpi_user_access(long? ENTITY_KPI_USER_ACCESS_ID);
        #endregion
        #region Delete_District_view
        void Delete_District_view(long? DISTRICT_VIEW_ID);
        #endregion
        #region Delete_Area
        void Delete_Area(long? AREA_ID);
        #endregion
        #region Delete_Area_view
        void Delete_Area_view(long? AREA_VIEW_ID);
        #endregion
        #region Delete_Site_kpi
        void Delete_Site_kpi(long? SITE_KPI_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Organization_relation
        void Delete_Organization_relation(int? ORGANIZATION_RELATION_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Area_kpi
        void Delete_Area_kpi(long? AREA_KPI_ID);
        #endregion
        #region Delete_Region
        void Delete_Region(long? REGION_ID);
        #endregion
        #region Delete_District
        void Delete_District(long? DISTRICT_ID);
        #endregion
        #region Delete_District_kpi_user_access
        void Delete_District_kpi_user_access(long? DISTRICT_KPI_USER_ACCESS_ID);
        #endregion
        #region Delete_User
        void Delete_User(long? USER_ID);
        #endregion
        #region Delete_Site
        void Delete_Site(long? SITE_ID);
        #endregion
        #region Delete_User_theme
        void Delete_User_theme(int? USER_THEME_ID);
        #endregion
        #region Delete_Region_view
        void Delete_Region_view(long? REGION_VIEW_ID);
        #endregion
        #region Delete_Site_view_By_OWNER_ID_IS_DELETED
        void Delete_Site_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Site_view_By_VIEW_TYPE_SETUP_ID
        void Delete_Site_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Delete_Site_view_By_OWNER_ID
        void Delete_Site_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Site_view_By_SITE_ID
        void Delete_Site_view_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID
        void Delete_Removed_extrusion_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Removed_extrusion_By_LEVEL_ID
        void Delete_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        void Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED
        void Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Entity_view_By_OWNER_ID
        void Delete_Entity_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Entity_view_By_VIEW_TYPE_SETUP_ID
        void Delete_Entity_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Delete_Entity_view_By_OWNER_ID_IS_DELETED
        void Delete_Entity_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Entity_view_By_ENTITY_ID
        void Delete_Entity_view_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Delete_Top_level_By_OWNER_ID
        void Delete_Top_level_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Top_level_By_OWNER_ID_IS_DELETED
        void Delete_Top_level_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Delete_User_level_access_By_OWNER_ID
        void Delete_User_level_access_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        void Delete_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(long? ORGANIZATION_LEVEL_ACCESS_ID);
        #endregion
        #region Delete_User_level_access_By_USER_ID
        void Delete_User_level_access_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_User_level_access_By_LEVEL_ID
        void Delete_User_level_access_By_LEVEL_ID(long? LEVEL_ID);
        #endregion
        #region Delete_User_level_access_By_DATA_LEVEL_SETUP_ID
        void Delete_User_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_User_level_access_By_OWNER_ID_IS_DELETED
        void Delete_User_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
        void Delete_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(long? USER_ID, long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_User_districtnex_module_By_OWNER_ID
        void Delete_User_districtnex_module_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_User_districtnex_module_By_USER_ID
        void Delete_User_districtnex_module_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_User_districtnex_module_By_DISTRICTNEX_MODULE_ID
        void Delete_User_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Delete_User_districtnex_module_By_OWNER_ID_IS_DELETED
        void Delete_User_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Delete_District_view_By_OWNER_ID
        void Delete_District_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_District_view_By_DISTRICT_ID
        void Delete_District_view_By_DISTRICT_ID(long? DISTRICT_ID);
        #endregion
        #region Delete_District_view_By_VIEW_TYPE_SETUP_ID
        void Delete_District_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Delete_District_view_By_OWNER_ID_IS_DELETED
        void Delete_District_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Delete_Area_view_By_OWNER_ID
        void Delete_Area_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Area_view_By_AREA_ID
        void Delete_Area_view_By_AREA_ID(long? AREA_ID);
        #endregion
        #region Delete_Area_view_By_VIEW_TYPE_SETUP_ID
        void Delete_Area_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Delete_Area_view_By_OWNER_ID_IS_DELETED
        void Delete_Area_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Delete_Organization_relation_By_OWNER_ID_IS_DELETED
        void Delete_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID
        void Delete_Organization_relation_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Organization_relation_By_PARENT_ORGANIZATION_ID
        void Delete_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_relation_By_CHILD_ORGANIZATION_ID
        void Delete_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID);
        #endregion
        #region Delete_Organization_relation_By_USER_ID
        void Delete_Organization_relation_By_USER_ID(long? USER_ID);
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
        #region Delete_Region_By_OWNER_ID_IS_DELETED
        void Delete_Region_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Region_By_OWNER_ID
        void Delete_Region_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Region_By_TOP_LEVEL_ID
        void Delete_Region_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
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
        #region Delete_User_theme_By_OWNER_ID
        void Delete_User_theme_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_User_theme_By_USER_ID
        void Delete_User_theme_By_USER_ID(long? USER_ID);
        #endregion
        #region Delete_User_theme_By_ORGANIZATION_THEME_ID
        void Delete_User_theme_By_ORGANIZATION_THEME_ID(int? ORGANIZATION_THEME_ID);
        #endregion
        #region Delete_User_theme_By_OWNER_ID_IS_DELETED
        void Delete_User_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Region_view_By_OWNER_ID
        void Delete_Region_view_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Region_view_By_REGION_ID
        void Delete_Region_view_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Delete_Region_view_By_VIEW_TYPE_SETUP_ID
        void Delete_Region_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Delete_Region_view_By_OWNER_ID_IS_DELETED
        void Delete_Region_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Site_view
        long? Edit_Site_view(long? SITE_VIEW_ID, long? SITE_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Removed_extrusion
        int? Edit_Removed_extrusion(int? REMOVED_EXTRUSION_ID, string EXTRUSION_IDENTIFIER, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Entity_view
        long? Edit_Entity_view(long? ENTITY_VIEW_ID, long? ENTITY_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Top_level
        long? Edit_Top_level(long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? LOW_THRESHOLD, int? HIGH_THRESHOLD, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
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
        #region Edit_User_level_access
        long? Edit_User_level_access(long? USER_LEVEL_ACCESS_ID, long? ORGANIZATION_LEVEL_ACCESS_ID, long? USER_ID, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_User_districtnex_module
        long? Edit_User_districtnex_module(long? USER_DISTRICTNEX_MODULE_ID, long? USER_ID, int? DISTRICTNEX_MODULE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Entity_kpi_user_access
        long? Edit_Entity_kpi_user_access(long? ENTITY_KPI_USER_ACCESS_ID, long? USER_ID, long? ENTITY_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_District_view
        long? Edit_District_view(long? DISTRICT_VIEW_ID, long? DISTRICT_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Area
        long? Edit_Area(long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Area_view
        long? Edit_Area_view(long? AREA_VIEW_ID, long? AREA_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Site_kpi
        long? Edit_Site_kpi(long? SITE_KPI_ID, long? SITE_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Organization_relation
        int? Edit_Organization_relation(int? ORGANIZATION_RELATION_ID, int? PARENT_ORGANIZATION_ID, int? CHILD_ORGANIZATION_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Area_kpi
        long? Edit_Area_kpi(long? AREA_KPI_ID, long? AREA_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Region
        long? Edit_Region(long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_District
        long? Edit_District(long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_District_kpi_user_access
        long? Edit_District_kpi_user_access(long? DISTRICT_KPI_USER_ACCESS_ID, long? USER_ID, long? DISTRICT_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_User
        long? Edit_User(long? USER_ID, int? ORGANIZATION_ID, long? USER_TYPE_SETUP_ID, int? OWNER_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, bool IS_ACTIVE, bool IS_DELETED, bool IS_RECEIVE_EMAIL, int? DATA_RETENTION_PERIOD, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, string DATE_DELETED, string ENTRY_DATE, long? ENTRY_USER_ID, string LAST_UPDATE);
        #endregion
        #region Edit_Site
        long? Edit_Site(long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_User_theme
        int? Edit_User_theme(int? USER_THEME_ID, long? USER_ID, int? ORGANIZATION_THEME_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Region_view
        long? Edit_Region_view(long? REGION_VIEW_ID, long? REGION_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
    }
}
