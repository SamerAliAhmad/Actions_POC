using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Entity_view_By_ENTITY_VIEW_ID
    public partial class Params_Get_Entity_view_By_ENTITY_VIEW_ID
    {
        #region Properties
        public long? ENTITY_VIEW_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_ENTITY_ID
    public partial class Params_Get_Entity_By_ENTITY_ID
    {
        #region Properties
        public long? ENTITY_ID { get; set; }
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
    #region Params_Get_Entity_view_By_ENTITY_VIEW_ID_List
    public partial class Params_Get_Entity_view_By_ENTITY_VIEW_ID_List
    {
        #region Properties
        public IEnumerable<long?> ENTITY_VIEW_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_ENTITY_ID_List
    public partial class Params_Get_Entity_By_ENTITY_ID_List
    {
        #region Properties
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
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
    #region Params_Get_Entity_view_By_OWNER_ID
    public partial class Params_Get_Entity_view_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID
    public partial class Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID
    {
        #region Properties
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_view_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Entity_view_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_view_By_ENTITY_ID
    public partial class Params_Get_Entity_view_By_ENTITY_ID
    {
        #region Properties
        public long? ENTITY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Entity_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_OWNER_ID
    public partial class Params_Get_Entity_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_SITE_ID
    public partial class Params_Get_Entity_By_SITE_ID
    {
        #region Properties
        public long? SITE_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_AREA_ID
    public partial class Params_Get_Entity_By_AREA_ID
    {
        #region Properties
        public long? AREA_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_DISTRICT_ID
    public partial class Params_Get_Entity_By_DISTRICT_ID
    {
        #region Properties
        public long? DISTRICT_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_REGION_ID
    public partial class Params_Get_Entity_By_REGION_ID
    {
        #region Properties
        public long? REGION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_TOP_LEVEL_ID
    public partial class Params_Get_Entity_By_TOP_LEVEL_ID
    {
        #region Properties
        public long? TOP_LEVEL_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID
    public partial class Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID
    {
        #region Properties
        public long? ENTITY_TYPE_SETUP_ID { get; set; }
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
    #region Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List
    public partial class Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_view_By_ENTITY_ID_List
    public partial class Params_Get_Entity_view_By_ENTITY_ID_List
    {
        #region Properties
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_SITE_ID_List
    public partial class Params_Get_Entity_By_SITE_ID_List
    {
        #region Properties
        public IEnumerable<long?> SITE_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_AREA_ID_List
    public partial class Params_Get_Entity_By_AREA_ID_List
    {
        #region Properties
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_DISTRICT_ID_List
    public partial class Params_Get_Entity_By_DISTRICT_ID_List
    {
        #region Properties
        public IEnumerable<long?> DISTRICT_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_REGION_ID_List
    public partial class Params_Get_Entity_By_REGION_ID_List
    {
        #region Properties
        public IEnumerable<long?> REGION_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_TOP_LEVEL_ID_List
    public partial class Params_Get_Entity_By_TOP_LEVEL_ID_List
    {
        #region Properties
        public IEnumerable<long?> TOP_LEVEL_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List
    public partial class Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST { get; set; }
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
    #region Params_Get_Entity_view_By_Where
    public partial class Params_Get_Entity_view_By_Where
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
    #region Params_Get_Entity_By_Where
    public partial class Params_Get_Entity_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string GLA_UNIT { get; set; }
        public string UNIT { get; set; }
        public string IMAGE_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
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
    #region Params_Get_Entity_view_By_Where_In_List
    public partial class Params_Get_Entity_view_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string DESCRIPTION { get; set; }
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
        public IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Entity_By_Where_In_List
    public partial class Params_Get_Entity_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string GLA_UNIT { get; set; }
        public string UNIT { get; set; }
        public string IMAGE_URL { get; set; }
        public string SOLID_GLTF_URL { get; set; }
        public IEnumerable<long?> SITE_ID_LIST { get; set; }
        public IEnumerable<long?> AREA_ID_LIST { get; set; }
        public IEnumerable<long?> DISTRICT_ID_LIST { get; set; }
        public IEnumerable<long?> REGION_ID_LIST { get; set; }
        public IEnumerable<long?> TOP_LEVEL_ID_LIST { get; set; }
        public IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST { get; set; }
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
    #region Params_Delete_Entity_view
    public partial class Params_Delete_Entity_view
    {
        #region Properties
        public long? ENTITY_VIEW_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity
    public partial class Params_Delete_Entity
    {
        #region Properties
        public long? ENTITY_ID { get; set; }
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
    #region Params_Delete_Entity_view_By_OWNER_ID
    public partial class Params_Delete_Entity_view_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID
    public partial class Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID
    {
        #region Properties
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_view_By_ENTITY_ID
    public partial class Params_Delete_Entity_view_By_ENTITY_ID
    {
        #region Properties
        public long? ENTITY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Entity_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_OWNER_ID
    public partial class Params_Delete_Entity_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_SITE_ID
    public partial class Params_Delete_Entity_By_SITE_ID
    {
        #region Properties
        public long? SITE_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_AREA_ID
    public partial class Params_Delete_Entity_By_AREA_ID
    {
        #region Properties
        public long? AREA_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_DISTRICT_ID
    public partial class Params_Delete_Entity_By_DISTRICT_ID
    {
        #region Properties
        public long? DISTRICT_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_REGION_ID
    public partial class Params_Delete_Entity_By_REGION_ID
    {
        #region Properties
        public long? REGION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_TOP_LEVEL_ID
    public partial class Params_Delete_Entity_By_TOP_LEVEL_ID
    {
        #region Properties
        public long? TOP_LEVEL_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID
    public partial class Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID
    {
        #region Properties
        public long? ENTITY_TYPE_SETUP_ID { get; set; }
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
    #region Params_Edit_Entity_view_List
    public partial class Params_Edit_Entity_view_List
    {
        #region Properties
        public List<Entity_view> List_To_Edit { get; set; }
        public List<Entity_view> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Entity_List
    public partial class Params_Edit_Entity_List
    {
        #region Properties
        public List<Entity> List_To_Edit { get; set; }
        public List<Entity> List_Failed_Edit { get; set; }
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