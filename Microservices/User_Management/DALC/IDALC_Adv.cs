using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Site_view_By_SITE_VIEW_ID_Adv
        Site_view Get_Site_view_By_SITE_VIEW_ID_Adv(long? SITE_VIEW_ID);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv
        Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(int? REMOVED_EXTRUSION_ID);
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_Adv
        Entity_view Get_Entity_view_By_ENTITY_VIEW_ID_Adv(long? ENTITY_VIEW_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv
        Area_kpi_user_access Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv(long? AREA_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv
        Site_kpi_user_access Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv(long? SITE_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_Adv
        Entity_kpi Get_Entity_kpi_By_ENTITY_KPI_ID_Adv(long? ENTITY_KPI_ID);
        #endregion
        #region Get_Entity_By_ENTITY_ID_Adv
        Entity Get_Entity_By_ENTITY_ID_Adv(long? ENTITY_ID);
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_Adv
        District_kpi Get_District_kpi_By_DISTRICT_KPI_ID_Adv(long? DISTRICT_KPI_ID);
        #endregion
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv
        User_level_access Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv(long? USER_LEVEL_ACCESS_ID);
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv
        User_districtnex_module Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv(long? USER_DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv
        Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv(long? ENTITY_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_Adv
        District_view Get_District_view_By_DISTRICT_VIEW_ID_Adv(long? DISTRICT_VIEW_ID);
        #endregion
        #region Get_Area_By_AREA_ID_Adv
        Area Get_Area_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_Adv
        Area_view Get_Area_view_By_AREA_VIEW_ID_Adv(long? AREA_VIEW_ID);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_Adv
        Site_kpi Get_Site_kpi_By_SITE_KPI_ID_Adv(long? SITE_KPI_ID);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv
        Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(int? ORGANIZATION_RELATION_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_Adv
        Area_kpi Get_Area_kpi_By_AREA_KPI_ID_Adv(long? AREA_KPI_ID);
        #endregion
        #region Get_Region_By_REGION_ID_Adv
        Region Get_Region_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_District_By_DISTRICT_ID_Adv
        District Get_District_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv
        District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv(long? DISTRICT_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_User_By_USER_ID_Adv
        User Get_User_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Site_By_SITE_ID_Adv
        Site Get_Site_By_SITE_ID_Adv(long? SITE_ID);
        #endregion
        #region Get_User_theme_By_USER_THEME_ID_Adv
        User_theme Get_User_theme_By_USER_THEME_ID_Adv(int? USER_THEME_ID);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_Adv
        Region_view Get_Region_view_By_REGION_VIEW_ID_Adv(long? REGION_VIEW_ID);
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List_Adv
        List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List_Adv(IEnumerable<long?> SITE_VIEW_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST);
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv
        List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv(IEnumerable<long?> ENTITY_VIEW_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> AREA_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> SITE_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv
        List<Entity_kpi> Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv(IEnumerable<long?> ENTITY_KPI_ID_LIST);
        #endregion
        #region Get_Entity_By_ENTITY_ID_List_Adv
        List<Entity> Get_Entity_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv
        List<District_kpi> Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv(IEnumerable<long?> DISTRICT_KPI_ID_LIST);
        #endregion
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv
        List<User_level_access> Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv(IEnumerable<long?> USER_LEVEL_ACCESS_ID_LIST);
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv(IEnumerable<long?> USER_DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> ENTITY_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_List_Adv
        List<District_view> Get_District_view_By_DISTRICT_VIEW_ID_List_Adv(IEnumerable<long?> DISTRICT_VIEW_ID_LIST);
        #endregion
        #region Get_Area_By_AREA_ID_List_Adv
        List<Area> Get_Area_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_List_Adv
        List<Area_view> Get_Area_view_By_AREA_VIEW_ID_List_Adv(IEnumerable<long?> AREA_VIEW_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List_Adv
        List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List_Adv(IEnumerable<long?> SITE_KPI_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List_Adv
        List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List_Adv(IEnumerable<long?> AREA_KPI_ID_LIST);
        #endregion
        #region Get_Region_By_REGION_ID_List_Adv
        List<Region> Get_Region_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_District_By_DISTRICT_ID_List_Adv
        List<District> Get_District_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> DISTRICT_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_User_By_USER_ID_List_Adv
        List<User> Get_User_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Site_By_SITE_ID_List_Adv
        List<Site> Get_Site_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_User_theme_By_USER_THEME_ID_List_Adv
        List<User_theme> Get_User_theme_By_USER_THEME_ID_List_Adv(IEnumerable<int?> USER_THEME_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List_Adv
        List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List_Adv(IEnumerable<long?> REGION_VIEW_ID_LIST);
        #endregion
        #region Get_Site_view_By_OWNER_ID_IS_DELETED_Adv
        List<Site_view> Get_Site_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv
        List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Site_view_By_OWNER_ID_Adv
        List<Site_view> Get_Site_view_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Site_view_By_SITE_ID_Adv
        List<Site_view> Get_Site_view_By_SITE_ID_Adv(long? SITE_ID);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_Adv(long? LEVEL_ID);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_view_By_OWNER_ID_Adv
        List<Entity_view> Get_Entity_view_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv
        List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv
        List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_Adv
        List<Entity_view> Get_Entity_view_By_ENTITY_ID_Adv(long? ENTITY_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_Adv(long? SITE_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_Adv
        List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_Adv
        List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_Adv(long? ENTITY_ID);
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED_Adv
        List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_By_OWNER_ID_Adv
        List<Entity> Get_Entity_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Entity_By_SITE_ID_Adv
        List<Entity> Get_Entity_By_SITE_ID_Adv(long? SITE_ID);
        #endregion
        #region Get_Entity_By_AREA_ID_Adv
        List<Entity> Get_Entity_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Entity_By_DISTRICT_ID_Adv
        List<Entity> Get_Entity_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_Entity_By_REGION_ID_Adv
        List<Entity> Get_Entity_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_Adv
        List<Entity> Get_Entity_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID);
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv
        List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv(long? ENTITY_TYPE_SETUP_ID);
        #endregion
        #region Get_District_kpi_By_OWNER_ID_Adv
        List<District_kpi> Get_District_kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv
        List<District_kpi> Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_Adv
        List<District_kpi> Get_District_kpi_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_User_level_access_By_OWNER_ID_Adv
        List<User_level_access> Get_User_level_access_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv
        List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(long? ORGANIZATION_LEVEL_ACCESS_ID);
        #endregion
        #region Get_User_level_access_By_USER_ID_Adv
        List<User_level_access> Get_User_level_access_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_User_level_access_By_LEVEL_ID_Adv
        List<User_level_access> Get_User_level_access_By_LEVEL_ID_Adv(long? LEVEL_ID);
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv
        List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv(long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv
        List<User_level_access> Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv
        List<User_level_access> Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv(long? USER_ID, long? DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_User_districtnex_module_By_USER_ID_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(int? DISTRICTNEX_MODULE_ID);
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_Adv(long? ENTITY_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_view_By_OWNER_ID_Adv
        List<District_view> Get_District_view_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_District_view_By_DISTRICT_ID_Adv
        List<District_view> Get_District_view_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv
        List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_District_view_By_OWNER_ID_IS_DELETED_Adv
        List<District_view> Get_District_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_By_OWNER_ID_IS_DELETED_Adv
        List<Area> Get_Area_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_By_OWNER_ID_Adv
        List<Area> Get_Area_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Area_By_DISTRICT_ID_Adv
        List<Area> Get_Area_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_Area_By_REGION_ID_Adv
        List<Area> Get_Area_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_Adv
        List<Area> Get_Area_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID);
        #endregion
        #region Get_Area_view_By_OWNER_ID_Adv
        List<Area_view> Get_Area_view_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Area_view_By_AREA_ID_Adv
        List<Area_view> Get_Area_view_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv
        List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Area_view_By_OWNER_ID_IS_DELETED_Adv
        List<Area_view> Get_Area_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_Adv
        List<Site_kpi> Get_Site_kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Site_kpi> Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_kpi_By_SITE_ID_Adv
        List<Site_kpi> Get_Site_kpi_By_SITE_ID_Adv(long? SITE_ID);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(int? PARENT_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(int? CHILD_ORGANIZATION_ID);
        #endregion
        #region Get_Organization_relation_By_USER_ID_Adv
        List<Organization_relation> Get_Organization_relation_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Area_kpi> Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_Adv
        List<Area_kpi> Get_Area_kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Area_kpi_By_AREA_ID_Adv
        List<Area_kpi> Get_Area_kpi_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Region_By_OWNER_ID_IS_DELETED_Adv
        List<Region> Get_Region_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Region_By_OWNER_ID_Adv
        List<Region> Get_Region_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_Adv
        List<Region> Get_Region_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID);
        #endregion
        #region Get_District_By_OWNER_ID_IS_DELETED_Adv
        List<District> Get_District_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_By_OWNER_ID_Adv
        List<District> Get_District_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_District_By_REGION_ID_Adv
        List<District> Get_District_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_Adv
        List<District> Get_District_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID);
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED_Adv
        List<User> Get_User_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID_Adv
        User Get_User_By_USERNAME_OWNER_ID_Adv(string USERNAME, int? OWNER_ID);
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID_Adv
        User Get_User_By_EMAIL_OWNER_ID_Adv(string EMAIL, int? OWNER_ID);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_Adv
        List<User> Get_User_By_USER_TYPE_SETUP_ID_Adv(long? USER_TYPE_SETUP_ID);
        #endregion
        #region Get_User_By_ORGANIZATION_ID_Adv
        List<User> Get_User_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_User_By_OWNER_ID_Adv
        List<User> Get_User_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL_Adv
        List<User> Get_User_By_IS_RECEIVE_EMAIL_Adv(bool IS_RECEIVE_EMAIL);
        #endregion
        #region Get_User_By_IS_DELETED_Adv
        List<User> Get_User_By_IS_DELETED_Adv(bool IS_DELETED);
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv
        List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED);
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED_Adv
        List<Site> Get_Site_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_By_OWNER_ID_Adv
        List<Site> Get_Site_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Site_By_AREA_ID_Adv
        List<Site> Get_Site_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Site_By_DISTRICT_ID_Adv
        List<Site> Get_Site_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_Site_By_REGION_ID_Adv
        List<Site> Get_Site_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_Adv
        List<Site> Get_Site_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID);
        #endregion
        #region Get_User_theme_By_OWNER_ID_Adv
        List<User_theme> Get_User_theme_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_User_theme_By_USER_ID_Adv
        List<User_theme> Get_User_theme_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID_Adv
        List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID_Adv(int? ORGANIZATION_THEME_ID);
        #endregion
        #region Get_User_theme_By_OWNER_ID_IS_DELETED_Adv
        List<User_theme> Get_User_theme_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Region_view_By_OWNER_ID_Adv
        List<Region_view> Get_Region_view_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Region_view_By_REGION_ID_Adv
        List<Region_view> Get_Region_view_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv
        List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID);
        #endregion
        #region Get_Region_view_By_OWNER_ID_IS_DELETED_Adv
        List<Region_view> Get_Region_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_view_By_SITE_ID_List_Adv
        List<Site_view> Get_Site_view_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List_Adv(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List_Adv
        List<Entity_view> Get_Entity_view_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_List_Adv
        List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Entity_By_SITE_ID_List_Adv
        List<Entity> Get_Entity_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Entity_By_AREA_ID_List_Adv
        List<Entity> Get_Entity_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List_Adv
        List<Entity> Get_Entity_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Entity_By_REGION_ID_List_Adv
        List<Entity> Get_Entity_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List_Adv
        List<Entity> Get_Entity_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv
        List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_List_Adv
        List<District_kpi> Get_District_kpi_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv
        List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST);
        #endregion
        #region Get_User_level_access_By_USER_ID_List_Adv
        List<User_level_access> Get_User_level_access_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_User_level_access_By_LEVEL_ID_List_Adv
        List<User_level_access> Get_User_level_access_By_LEVEL_ID_List_Adv(IEnumerable<long?> LEVEL_ID_LIST);
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv
        List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_User_districtnex_module_By_USER_ID_List_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_District_view_By_DISTRICT_ID_List_Adv
        List<District_view> Get_District_view_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Area_By_DISTRICT_ID_List_Adv
        List<Area> Get_Area_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Area_By_REGION_ID_List_Adv
        List<Area> Get_Area_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List_Adv
        List<Area> Get_Area_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Area_view_By_AREA_ID_List_Adv
        List<Area_view> Get_Area_view_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List_Adv
        List<Site_kpi> Get_Site_kpi_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Organization_relation_By_USER_ID_List_Adv
        List<Organization_relation> Get_Organization_relation_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_AREA_ID_List_Adv
        List<Area_kpi> Get_Area_kpi_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_List_Adv
        List<Region> Get_Region_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_District_By_REGION_ID_List_Adv
        List<District> Get_District_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List_Adv
        List<District> Get_District_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List_Adv
        List<User> Get_User_By_USER_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List_Adv
        List<User> Get_User_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Site_By_AREA_ID_List_Adv
        List<Site> Get_Site_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Site_By_DISTRICT_ID_List_Adv
        List<Site> Get_Site_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Site_By_REGION_ID_List_Adv
        List<Site> Get_Site_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List_Adv
        List<Site> Get_Site_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_User_theme_By_USER_ID_List_Adv
        List<User_theme> Get_User_theme_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv
        List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_ID_List_Adv
        List<Region_view> Get_Region_view_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_view_By_Where_Adv
        List<Site_view> Get_Site_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_Where_Adv(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_view_By_Where_Adv
        List<Entity_view> Get_Entity_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_user_access_By_Where_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_user_access_By_Where_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_By_Where_Adv
        List<Entity_kpi> Get_Entity_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_By_Where_Adv
        List<Entity> Get_Entity_By_Where_Adv(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_By_Where_Adv
        List<District_kpi> Get_District_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_level_access_By_Where_Adv
        List<User_level_access> Get_User_level_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_districtnex_module_By_Where_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_view_By_Where_Adv
        List<District_view> Get_District_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where_Adv
        List<Area> Get_Area_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_view_By_Where_Adv
        List<Area_view> Get_Area_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where_Adv
        List<Site_kpi> Get_Site_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where_Adv
        List<Organization_relation> Get_Organization_relation_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where_Adv
        List<Area_kpi> Get_Area_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where_Adv
        List<Region> Get_Region_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where_Adv
        List<District> Get_District_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_Adv
        List<User> Get_User_By_Where_Adv(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_Adv
        List<Site> Get_Site_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_theme_By_Where_Adv
        List<User_theme> Get_User_theme_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where_Adv
        List<Region_view> Get_Region_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_view_By_Where_In_List_Adv
        List<Site_view> Get_Site_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List_Adv
        List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List_Adv(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_view_By_Where_In_List_Adv
        List<Entity_view> Get_Entity_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_user_access_By_Where_In_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_user_access_By_Where_In_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_By_Where_In_List_Adv
        List<Entity_kpi> Get_Entity_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_By_Where_In_List_Adv
        List<Entity> Get_Entity_By_Where_In_List_Adv(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_By_Where_In_List_Adv
        List<District_kpi> Get_District_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_level_access_By_Where_In_List_Adv
        List<User_level_access> Get_User_level_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_districtnex_module_By_Where_In_List_Adv
        List<User_districtnex_module> Get_User_districtnex_module_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_In_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_view_By_Where_In_List_Adv
        List<District_view> Get_District_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where_In_List_Adv
        List<Area> Get_Area_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_view_By_Where_In_List_Adv
        List<Area_view> Get_Area_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where_In_List_Adv
        List<Site_kpi> Get_Site_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_relation_By_Where_In_List_Adv
        List<Organization_relation> Get_Organization_relation_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where_In_List_Adv
        List<Area_kpi> Get_Area_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where_In_List_Adv
        List<Region> Get_Region_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where_In_List_Adv
        List<District> Get_District_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_In_List_Adv
        List<User> Get_User_By_Where_In_List_Adv(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_In_List_Adv
        List<Site> Get_Site_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_theme_By_Where_In_List_Adv
        List<User_theme> Get_User_theme_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> ORGANIZATION_THEME_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where_In_List_Adv
        List<Region_view> Get_Region_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
