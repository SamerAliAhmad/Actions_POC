using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Kpi_By_KPI_ID_Adv
        Kpi Get_Kpi_By_KPI_ID_Adv(int? KPI_ID);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv
        Area_kpi_user_access Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv(long? AREA_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv
        Site_kpi_user_access Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv(long? SITE_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_Adv
        Organization Get_Organization_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
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
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv
        Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv(long? ENTITY_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Area_By_AREA_ID_Adv
        Area Get_Area_By_AREA_ID_Adv(long? AREA_ID);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_Adv
        Site_kpi Get_Site_kpi_By_SITE_KPI_ID_Adv(long? SITE_KPI_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_Adv
        Area_kpi Get_Area_kpi_By_AREA_KPI_ID_Adv(long? AREA_KPI_ID);
        #endregion
        #region Get_Data_source_By_DATA_SOURCE_ID_Adv
        Data_source Get_Data_source_By_DATA_SOURCE_ID_Adv(int? DATA_SOURCE_ID);
        #endregion
        #region Get_District_By_DISTRICT_ID_Adv
        District Get_District_By_DISTRICT_ID_Adv(long? DISTRICT_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(int? ORGANIZATION_DATA_SOURCE_KPI_ID);
        #endregion
        #region Get_Floor_By_FLOOR_ID_Adv
        Floor Get_Floor_By_FLOOR_ID_Adv(long? FLOOR_ID);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv
        District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv(long? DISTRICT_KPI_USER_ACCESS_ID);
        #endregion
        #region Get_Space_By_SPACE_ID_Adv
        Space Get_Space_By_SPACE_ID_Adv(long? SPACE_ID);
        #endregion
        #region Get_Site_By_SITE_ID_Adv
        Site Get_Site_By_SITE_ID_Adv(long? SITE_ID);
        #endregion
        #region Get_Kpi_By_KPI_ID_List_Adv
        List<Kpi> Get_Kpi_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> AREA_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> SITE_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List_Adv
        List<Organization> Get_Organization_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
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
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> ENTITY_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Area_By_AREA_ID_List_Adv
        List<Area> Get_Area_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List_Adv
        List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List_Adv(IEnumerable<long?> SITE_KPI_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List_Adv
        List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List_Adv(IEnumerable<long?> AREA_KPI_ID_LIST);
        #endregion
        #region Get_Data_source_By_DATA_SOURCE_ID_List_Adv
        List<Data_source> Get_Data_source_By_DATA_SOURCE_ID_List_Adv(IEnumerable<int?> DATA_SOURCE_ID_LIST);
        #endregion
        #region Get_District_By_DISTRICT_ID_List_Adv
        List<District> Get_District_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Floor_By_FLOOR_ID_List_Adv
        List<Floor> Get_Floor_By_FLOOR_ID_List_Adv(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv(IEnumerable<long?> DISTRICT_KPI_USER_ACCESS_ID_LIST);
        #endregion
        #region Get_Space_By_SPACE_ID_List_Adv
        List<Space> Get_Space_By_SPACE_ID_List_Adv(IEnumerable<long?> SPACE_ID_LIST);
        #endregion
        #region Get_Site_By_SITE_ID_List_Adv
        List<Site> Get_Site_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Kpi_By_OWNER_ID_Adv
        List<Kpi> Get_Kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_Adv
        List<Kpi> Get_Kpi_By_DIMENSION_ID_Adv(int? DIMENSION_ID);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_Adv
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv(long? MIN_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv(long? MAX_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv(long? KPI_TYPE_SETUP_ID);
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
        #region Get_Organization_By_OWNER_ID_IS_DELETED_Adv
        List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Organization_By_OWNER_ID_Adv
        List<Organization> Get_Organization_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv
        List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(long? ORGANIZATION_TYPE_SETUP_ID);
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
        #region Get_Data_source_By_OWNER_ID_Adv
        List<Data_source> Get_Data_source_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv
        List<Data_source> Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv(int? DATA_SOURCE_AUTHENTICATION_ID);
        #endregion
        #region Get_Data_source_By_OWNER_ID_IS_DELETED_Adv
        List<Data_source> Get_Data_source_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_Organization_data_source_kpi_By_OWNER_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(int? DATA_SOURCE_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_Adv(int? KPI_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED_Adv
        List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Floor_By_OWNER_ID_Adv
        List<Floor> Get_Floor_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Floor_By_ENTITY_ID_Adv
        List<Floor> Get_Floor_By_ENTITY_ID_Adv(long? ENTITY_ID);
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
        #region Get_Space_By_OWNER_ID_Adv
        List<Space> Get_Space_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Space_By_FLOOR_ID_Adv
        List<Space> Get_Space_By_FLOOR_ID_Adv(long? FLOOR_ID);
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED_Adv
        List<Space> Get_Space_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_Kpi_By_DIMENSION_ID_List_Adv
        List<Kpi> Get_Kpi_By_DIMENSION_ID_List_Adv(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST);
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
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv
        List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST);
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
        #region Get_Entity_kpi_user_access_By_USER_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
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
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List_Adv
        List<Site_kpi> Get_Site_kpi_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST);
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
        #region Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv
        List<Data_source> Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv(IEnumerable<int?> DATA_SOURCE_AUTHENTICATION_ID_LIST);
        #endregion
        #region Get_District_By_REGION_ID_List_Adv
        List<District> Get_District_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List_Adv
        List<District> Get_District_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(IEnumerable<int?> DATA_SOURCE_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Floor_By_ENTITY_ID_List_Adv
        List<Floor> Get_Floor_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
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
        #region Get_Space_By_FLOOR_ID_List_Adv
        List<Space> Get_Space_By_FLOOR_ID_List_Adv(IEnumerable<long?> FLOOR_ID_LIST);
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
        #region Get_Kpi_By_Where_Adv
        List<Kpi> Get_Kpi_By_Where_Adv(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_user_access_By_Where_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_user_access_By_Where_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_By_Where_Adv
        List<Organization> Get_Organization_By_Where_Adv(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
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
        #region Get_Entity_kpi_user_access_By_Where_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where_Adv
        List<Area> Get_Area_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where_Adv
        List<Site_kpi> Get_Site_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where_Adv
        List<Area_kpi> Get_Area_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Data_source_By_Where_Adv
        List<Data_source> Get_Data_source_By_Where_Adv(string NAME, string API_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where_Adv
        List<District> Get_District_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where_Adv
        List<Floor> Get_Floor_By_Where_Adv(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where_Adv
        List<Space> Get_Space_By_Where_Adv(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_Adv
        List<Site> Get_Site_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Kpi_By_Where_In_List_Adv
        List<Kpi> Get_Kpi_By_Where_In_List_Adv(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_user_access_By_Where_In_List_Adv
        List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_user_access_By_Where_In_List_Adv
        List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_By_Where_In_List_Adv
        List<Organization> Get_Organization_By_Where_In_List_Adv(string ORGANIZATION_NAME, string ORGANIZATION_EMAIL, string ORGANIZATION_PHONE_NUMBER, string ORGANIZATION_ADDRESS, IEnumerable<long?> ORGANIZATION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
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
        #region Get_Entity_kpi_user_access_By_Where_In_List_Adv
        List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_By_Where_In_List_Adv
        List<Area> Get_Area_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_kpi_By_Where_In_List_Adv
        List<Site_kpi> Get_Site_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Area_kpi_By_Where_In_List_Adv
        List<Area_kpi> Get_Area_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Data_source_By_Where_In_List_Adv
        List<Data_source> Get_Data_source_By_Where_In_List_Adv(string NAME, string API_URL, IEnumerable<int?> DATA_SOURCE_AUTHENTICATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_By_Where_In_List_Adv
        List<District> Get_District_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List_Adv
        List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where_In_List_Adv
        List<Floor> Get_Floor_By_Where_In_List_Adv(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List_Adv
        List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where_In_List_Adv
        List<Space> Get_Space_By_Where_In_List_Adv(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_In_List_Adv
        List<Site> Get_Site_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
