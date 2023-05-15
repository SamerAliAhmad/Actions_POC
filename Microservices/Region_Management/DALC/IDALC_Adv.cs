using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Region_By_REGION_ID_Adv
        Region Get_Region_By_REGION_ID_Adv(long? REGION_ID);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_Adv
        Region_view Get_Region_view_By_REGION_VIEW_ID_Adv(long? REGION_VIEW_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Region_By_REGION_ID_List_Adv
        List<Region> Get_Region_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List_Adv
        List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List_Adv(IEnumerable<long?> REGION_VIEW_ID_LIST);
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
        #region Get_Region_By_OWNER_ID_IS_DELETED_Adv
        List<Region> Get_Region_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Region_By_OWNER_ID_Adv
        List<Region> Get_Region_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_Adv
        List<Region> Get_Region_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID);
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
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_List_Adv
        List<Region> Get_Region_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST);
        #endregion
        #region Get_Region_view_By_REGION_ID_List_Adv
        List<Region_view> Get_Region_view_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST);
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where_Adv
        List<Region> Get_Region_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where_Adv
        List<Region_view> Get_Region_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_By_Where_In_List_Adv
        List<Region> Get_Region_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Region_view_By_Where_In_List_Adv
        List<Region_view> Get_Region_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
