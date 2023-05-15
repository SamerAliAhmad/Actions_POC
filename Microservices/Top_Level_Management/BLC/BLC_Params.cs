using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Top_level_By_TOP_LEVEL_ID
    public partial class Params_Get_Top_level_By_TOP_LEVEL_ID
    {
        #region Properties
        public long? TOP_LEVEL_ID { get; set; }
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
    #region Params_Get_Top_level_By_TOP_LEVEL_ID_List
    public partial class Params_Get_Top_level_By_TOP_LEVEL_ID_List
    {
        #region Properties
        public IEnumerable<long?> TOP_LEVEL_ID_LIST { get; set; }
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
    #region Params_Get_Top_level_By_OWNER_ID
    public partial class Params_Get_Top_level_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Top_level_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Top_level_By_OWNER_ID_IS_DELETED
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
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID_List
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_List
    {
        #region Properties
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Top_level_By_Where
    public partial class Params_Get_Top_level_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
        public string AREA_COLOR { get; set; }
        public string BORDER_COLOR { get; set; }
        public string STUDY_ZONE_NAME { get; set; }
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
    #region Params_Delete_Top_level
    public partial class Params_Delete_Top_level
    {
        #region Properties
        public long? TOP_LEVEL_ID { get; set; }
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
    #region Params_Delete_Top_level_By_OWNER_ID
    public partial class Params_Delete_Top_level_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Top_level_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Top_level_By_OWNER_ID_IS_DELETED
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
    #region Params_Edit_Top_level_List
    public partial class Params_Edit_Top_level_List
    {
        #region Properties
        public List<Top_level> List_To_Edit { get; set; }
        public List<Top_level> List_Failed_Edit { get; set; }
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