using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Site_view_By_SITE_VIEW_ID
        Site_view Get_Site_view_By_SITE_VIEW_ID(long? SITE_VIEW_ID);
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
        Ext_study_zone Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(int? EXT_STUDY_ZONE_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID
        Site_field_logo Get_Site_field_logo_By_SITE_FIELD_LOGO_ID(long? SITE_FIELD_LOGO_ID);
        #endregion
        #region Get_Site_By_SITE_ID
        Site Get_Site_By_SITE_ID(long? SITE_ID);
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List
        List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List(IEnumerable<long?> SITE_VIEW_ID_LIST);
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List
        List<Ext_study_zone> Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(IEnumerable<int?> EXT_STUDY_ZONE_ID_LIST);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List
        List<Site_field_logo> Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List(IEnumerable<long?> SITE_FIELD_LOGO_ID_LIST);
        #endregion
        #region Get_Site_By_SITE_ID_List
        List<Site> Get_Site_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
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
        #region Get_Ext_study_zone_By_OWNER_ID
        List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
        List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Get_Site_field_logo_By_OWNER_ID_IS_DELETED
        List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Site_field_logo_By_OWNER_ID
        List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Site_field_logo_By_SITE_ID
        List<Site_field_logo> Get_Site_field_logo_By_SITE_ID(long? SITE_ID);
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
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List
        List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Site_view_By_SITE_ID_List
        List<Site_view> Get_Site_view_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Site_field_logo_By_SITE_ID_List
        List<Site_field_logo> Get_Site_field_logo_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST);
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
        #region Get_Site_view_By_Where
        List<Site_view> Get_Site_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Ext_study_zone_By_Where
        List<Ext_study_zone> Get_Ext_study_zone_By_Where(string NAME, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_field_logo_By_Where
        List<Site_field_logo> Get_Site_field_logo_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where
        List<Site> Get_Site_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_view_By_Where_In_List
        List<Site_view> Get_Site_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_field_logo_By_Where_In_List
        List<Site_field_logo> Get_Site_field_logo_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Site_By_Where_In_List
        List<Site> Get_Site_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Site_view
        void Delete_Site_view(long? SITE_VIEW_ID);
        #endregion
        #region Delete_Ext_study_zone
        void Delete_Ext_study_zone(int? EXT_STUDY_ZONE_ID);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Site_field_logo
        void Delete_Site_field_logo(long? SITE_FIELD_LOGO_ID);
        #endregion
        #region Delete_Site
        void Delete_Site(long? SITE_ID);
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
        #region Delete_Ext_study_zone_By_OWNER_ID
        void Delete_Ext_study_zone_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED
        void Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
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
        #region Delete_Site_field_logo_By_OWNER_ID_IS_DELETED
        void Delete_Site_field_logo_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Site_field_logo_By_OWNER_ID
        void Delete_Site_field_logo_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Site_field_logo_By_SITE_ID
        void Delete_Site_field_logo_By_SITE_ID(long? SITE_ID);
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
        #region Edit_Site_view
        long? Edit_Site_view(long? SITE_VIEW_ID, long? SITE_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Ext_study_zone
        int? Edit_Ext_study_zone(int? EXT_STUDY_ZONE_ID, string NAME, decimal? LATITUDE, decimal? LONGITUDE, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Site_field_logo
        long? Edit_Site_field_logo(long? SITE_FIELD_LOGO_ID, long? SITE_ID, decimal? LONGITUDE, decimal? LATITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION);
        #endregion
        #region Edit_Site
        long? Edit_Site(long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
