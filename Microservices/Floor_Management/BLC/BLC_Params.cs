using System;
using System.Collections.Generic;

namespace BLC
{
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
    #region Params_Get_Space_asset_By_SPACE_ASSET_ID
    public partial class Params_Get_Space_asset_By_SPACE_ASSET_ID
    {
        #region Properties
        public long? SPACE_ASSET_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_FLOOR_ID
    public partial class Params_Get_Floor_By_FLOOR_ID
    {
        #region Properties
        public long? FLOOR_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_SPACE_ID
    public partial class Params_Get_Space_By_SPACE_ID
    {
        #region Properties
        public long? SPACE_ID { get; set; }
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
    #region Params_Get_Space_asset_By_SPACE_ASSET_ID_List
    public partial class Params_Get_Space_asset_By_SPACE_ASSET_ID_List
    {
        #region Properties
        public IEnumerable<long?> SPACE_ASSET_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_FLOOR_ID_List
    public partial class Params_Get_Floor_By_FLOOR_ID_List
    {
        #region Properties
        public IEnumerable<long?> FLOOR_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_SPACE_ID_List
    public partial class Params_Get_Space_By_SPACE_ID_List
    {
        #region Properties
        public IEnumerable<long?> SPACE_ID_LIST { get; set; }
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
    #region Params_Get_Space_asset_By_OWNER_ID
    public partial class Params_Get_Space_asset_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_asset_By_SPACE_ID
    public partial class Params_Get_Space_asset_By_SPACE_ID
    {
        #region Properties
        public long? SPACE_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_asset_By_ASSET_ID
    public partial class Params_Get_Space_asset_By_ASSET_ID
    {
        #region Properties
        public long? ASSET_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_asset_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Space_asset_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_asset_By_EXTERNAL_ID
    public partial class Params_Get_Space_asset_By_EXTERNAL_ID
    {
        #region Properties
        public string EXTERNAL_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
    public partial class Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
    {
        #region Properties
        public bool IS_MERAKI_WIFI_SIGNAL { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Floor_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_OWNER_ID
    public partial class Params_Get_Floor_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_ENTITY_ID
    public partial class Params_Get_Floor_By_ENTITY_ID
    {
        #region Properties
        public long? ENTITY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_OWNER_ID
    public partial class Params_Get_Space_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_FLOOR_ID
    public partial class Params_Get_Space_By_FLOOR_ID
    {
        #region Properties
        public long? FLOOR_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Space_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
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
    #region Params_Get_Space_asset_By_SPACE_ID_List
    public partial class Params_Get_Space_asset_By_SPACE_ID_List
    {
        #region Properties
        public IEnumerable<long?> SPACE_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_asset_By_ASSET_ID_List
    public partial class Params_Get_Space_asset_By_ASSET_ID_List
    {
        #region Properties
        public IEnumerable<long?> ASSET_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_ENTITY_ID_List
    public partial class Params_Get_Floor_By_ENTITY_ID_List
    {
        #region Properties
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_FLOOR_ID_List
    public partial class Params_Get_Space_By_FLOOR_ID_List
    {
        #region Properties
        public IEnumerable<long?> FLOOR_ID_LIST { get; set; }
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
    #region Params_Get_Space_asset_By_Where
    public partial class Params_Get_Space_asset_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string CUSTOM_NAME { get; set; }
        public string ASSET_ICON { get; set; }
        public string EXTERNAL_ID { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_Where
    public partial class Params_Get_Floor_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string SHELL_GLTF_URL { get; set; }
        public string CLIPPED_GLTF_URL { get; set; }
        public string ADVANCED_GLTF_URL { get; set; }
        public string UNIT { get; set; }
        public string NAME { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_Where
    public partial class Params_Get_Space_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
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
    #region Params_Get_Space_asset_By_Where_In_List
    public partial class Params_Get_Space_asset_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string CUSTOM_NAME { get; set; }
        public string ASSET_ICON { get; set; }
        public IEnumerable<long?> SPACE_ID_LIST { get; set; }
        public IEnumerable<long?> ASSET_ID_LIST { get; set; }
        public IEnumerable<string> EXTERNAL_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Floor_By_Where_In_List
    public partial class Params_Get_Floor_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string SHELL_GLTF_URL { get; set; }
        public string CLIPPED_GLTF_URL { get; set; }
        public string ADVANCED_GLTF_URL { get; set; }
        public string UNIT { get; set; }
        public string NAME { get; set; }
        public IEnumerable<long?> ENTITY_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Space_By_Where_In_List
    public partial class Params_Get_Space_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
        public IEnumerable<long?> FLOOR_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
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
    #region Params_Delete_Space_asset
    public partial class Params_Delete_Space_asset
    {
        #region Properties
        public long? SPACE_ASSET_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Floor
    public partial class Params_Delete_Floor
    {
        #region Properties
        public long? FLOOR_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space
    public partial class Params_Delete_Space
    {
        #region Properties
        public long? SPACE_ID { get; set; }
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
    #region Params_Delete_Space_asset_By_OWNER_ID
    public partial class Params_Delete_Space_asset_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_asset_By_SPACE_ID
    public partial class Params_Delete_Space_asset_By_SPACE_ID
    {
        #region Properties
        public long? SPACE_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_asset_By_ASSET_ID
    public partial class Params_Delete_Space_asset_By_ASSET_ID
    {
        #region Properties
        public long? ASSET_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_asset_By_EXTERNAL_ID
    public partial class Params_Delete_Space_asset_By_EXTERNAL_ID
    {
        #region Properties
        public string EXTERNAL_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
    public partial class Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
    {
        #region Properties
        public bool IS_MERAKI_WIFI_SIGNAL { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Floor_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Floor_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Floor_By_OWNER_ID
    public partial class Params_Delete_Floor_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Floor_By_ENTITY_ID
    public partial class Params_Delete_Floor_By_ENTITY_ID
    {
        #region Properties
        public long? ENTITY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_By_OWNER_ID
    public partial class Params_Delete_Space_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_By_FLOOR_ID
    public partial class Params_Delete_Space_By_FLOOR_ID
    {
        #region Properties
        public long? FLOOR_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Space_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Space_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
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
    #region Params_Edit_Space_asset_List
    public partial class Params_Edit_Space_asset_List
    {
        #region Properties
        public List<Space_asset> List_To_Edit { get; set; }
        public List<Space_asset> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Floor_List
    public partial class Params_Edit_Floor_List
    {
        #region Properties
        public List<Floor> List_To_Edit { get; set; }
        public List<Floor> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Space_List
    public partial class Params_Edit_Space_List
    {
        #region Properties
        public List<Space> List_To_Edit { get; set; }
        public List<Space> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}