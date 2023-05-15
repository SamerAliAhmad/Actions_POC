using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Entity_view_By_ENTITY_VIEW_ID
        Entity_view Get_Entity_view_By_ENTITY_VIEW_ID(long? ENTITY_VIEW_ID);
        #endregion
        #region Get_Entity_By_ENTITY_ID
        Entity Get_Entity_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List
        List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List(IEnumerable<long?> ENTITY_VIEW_ID_LIST);
        #endregion
        #region Get_Entity_By_ENTITY_ID_List
        List<Entity> Get_Entity_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
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
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List
        List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List
        List<Entity_view> Get_Entity_view_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
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
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Entity_view_By_Where
        List<Entity_view> Get_Entity_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_By_Where
        List<Entity> Get_Entity_By_Where(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_view_By_Where_In_List
        List<Entity_view> Get_Entity_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Entity_By_Where_In_List
        List<Entity> Get_Entity_By_Where_In_List(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Entity_view
        void Delete_Entity_view(long? ENTITY_VIEW_ID);
        #endregion
        #region Delete_Entity
        void Delete_Entity(long? ENTITY_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
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
        #region Edit_Entity_view
        long? Edit_Entity_view(long? ENTITY_VIEW_ID, long? ENTITY_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Entity
        long? Edit_Entity(long? ENTITY_ID, long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, long? ENTITY_TYPE_SETUP_ID, string NAME, int? NUMBER_OF_FLOORS, decimal? GLA, string GLA_UNIT, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string SOLID_GLTF_URL, decimal? POPUL_ALT_X, decimal? POPUP_ALT_Y, decimal? POPUP_ALT_Z, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
    }
}
