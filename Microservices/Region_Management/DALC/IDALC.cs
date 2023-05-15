using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Region_By_REGION_ID
        Region Get_Region_By_REGION_ID(long? REGION_ID);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID
        Region_view Get_Region_view_By_REGION_VIEW_ID(long? REGION_VIEW_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Region_By_REGION_ID_List
        List<Region> Get_Region_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List
        List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List(IEnumerable<long?> REGION_VIEW_ID_LIST);
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
        #region Get_Region_By_OWNER_ID_IS_DELETED
        List<Region> Get_Region_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Region_By_OWNER_ID
        List<Region> Get_Region_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID
        List<Region> Get_Region_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
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
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_List
        List<Region> Get_Region_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_ID_List
        List<Region_view> Get_Region_view_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List
        List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where
        List<Region> Get_Region_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where
        List<Region_view> Get_Region_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where_In_List
        List<Region> Get_Region_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where_In_List
        List<Region_view> Get_Region_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Region
        void Delete_Region(long? REGION_ID);
        #endregion
        #region Delete_Region_view
        void Delete_Region_view(long? REGION_VIEW_ID);
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
        #region Delete_Region_By_OWNER_ID_IS_DELETED
        void Delete_Region_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Region_By_OWNER_ID
        void Delete_Region_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Region_By_TOP_LEVEL_ID
        void Delete_Region_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID);
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
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Region
        long? Edit_Region(long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Region_view
        long? Edit_Region_view(long? REGION_VIEW_ID, long? REGION_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
    }
}
