using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Area_By_AREA_ID
    public partial class Params_Get_Area_By_AREA_ID
    {
        #region Properties
        public long? AREA_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_AREA_VIEW_ID
    public partial class Params_Get_Area_view_By_AREA_VIEW_ID
    {
        #region Properties
        public long? AREA_VIEW_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_SETUP_CATEGORY_ID
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_ID
    public partial class Params_Get_Setup_By_SETUP_ID
    {
        #region Properties
        public long? SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_AREA_ID_List
    public partial class Params_Get_Area_By_AREA_ID_List
    {
        #region Properties
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_AREA_VIEW_ID_List
    public partial class Params_Get_Area_view_By_AREA_VIEW_ID_List
    {
        #region Properties
        public IEnumerable<long?> AREA_VIEW_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List
    {
        #region Properties
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_ID_List
    public partial class Params_Get_Setup_By_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Area_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_OWNER_ID
    public partial class Params_Get_Area_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_DISTRICT_ID
    public partial class Params_Get_Area_By_DISTRICT_ID
    {
        #region Properties
        public long? DISTRICT_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_REGION_ID
    public partial class Params_Get_Area_By_REGION_ID
    {
        #region Properties
        public long? REGION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_TOP_LEVEL_ID
    public partial class Params_Get_Area_By_TOP_LEVEL_ID
    {
        #region Properties
        public long? TOP_LEVEL_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_OWNER_ID
    public partial class Params_Get_Area_view_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_AREA_ID
    public partial class Params_Get_Area_view_By_AREA_ID
    {
        #region Properties
        public long? AREA_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID
    public partial class Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID
    {
        #region Properties
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Area_view_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_OWNER_ID
    public partial class Params_Get_Setup_category_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    {
        #region Properties
        public string SETUP_CATEGORY_NAME { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Setup_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        public string VALUE { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_OWNER_ID
    public partial class Params_Get_Setup_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_DISTRICT_ID_List
    public partial class Params_Get_Area_By_DISTRICT_ID_List
    {
        #region Properties
        public IEnumerable<long?> DISTRICT_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_REGION_ID_List
    public partial class Params_Get_Area_By_REGION_ID_List
    {
        #region Properties
        public IEnumerable<long?> REGION_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_TOP_LEVEL_ID_List
    public partial class Params_Get_Area_By_TOP_LEVEL_ID_List
    {
        #region Properties
        public IEnumerable<long?> TOP_LEVEL_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_AREA_ID_List
    public partial class Params_Get_Area_view_By_AREA_ID_List
    {
        #region Properties
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List
    public partial class Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID_List
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_List
    {
        #region Properties
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_Where
    public partial class Params_Get_Area_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public string UNIT { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_Where
    public partial class Params_Get_Area_view_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_Where
    public partial class Params_Get_Setup_category_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string SETUP_CATEGORY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_Where
    public partial class Params_Get_Setup_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_By_Where_In_List
    public partial class Params_Get_Area_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public string UNIT { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
        public IEnumerable<long?> DISTRICT_ID_LIST { get; set; }
        public IEnumerable<long?> REGION_ID_LIST { get; set; }
        public IEnumerable<long?> TOP_LEVEL_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Area_view_By_Where_In_List
    public partial class Params_Get_Area_view_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
        public IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_Where_In_List
    public partial class Params_Get_Setup_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area
    public partial class Params_Delete_Area
    {
        #region Properties
        public long? AREA_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_view
    public partial class Params_Delete_Area_view
    {
        #region Properties
        public long? AREA_VIEW_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category
    public partial class Params_Delete_Setup_category
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup
    public partial class Params_Delete_Setup
    {
        #region Properties
        public long? SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Area_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_By_OWNER_ID
    public partial class Params_Delete_Area_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_By_DISTRICT_ID
    public partial class Params_Delete_Area_By_DISTRICT_ID
    {
        #region Properties
        public long? DISTRICT_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_By_REGION_ID
    public partial class Params_Delete_Area_By_REGION_ID
    {
        #region Properties
        public long? REGION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_By_TOP_LEVEL_ID
    public partial class Params_Delete_Area_By_TOP_LEVEL_ID
    {
        #region Properties
        public long? TOP_LEVEL_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_view_By_OWNER_ID
    public partial class Params_Delete_Area_view_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_view_By_AREA_ID
    public partial class Params_Delete_Area_view_By_AREA_ID
    {
        #region Properties
        public long? AREA_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID
    public partial class Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID
    {
        #region Properties
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Area_view_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Area_view_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category_By_OWNER_ID
    public partial class Params_Delete_Setup_category_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    public partial class Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    {
        #region Properties
        public string SETUP_CATEGORY_NAME { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Setup_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_SETUP_CATEGORY_ID
    public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
    public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        public string VALUE { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_OWNER_ID
    public partial class Params_Delete_Setup_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Area_List
    public partial class Params_Edit_Area_List
    {
        #region Properties
        public List<Area> List_To_Edit { get; set; }
        public List<Area> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Area_view_List
    public partial class Params_Edit_Area_view_List
    {
        #region Properties
        public List<Area_view> List_To_Edit { get; set; }
        public List<Area_view> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Setup_category_List
    public partial class Params_Edit_Setup_category_List
    {
        #region Properties
        public List<Setup_category> List_To_Edit { get; set; }
        public List<Setup_category> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Setup_List
    public partial class Params_Edit_Setup_List
    {
        #region Properties
        public List<Setup> List_To_Edit { get; set; }
        public List<Setup> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}