using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_Adv
        Space_asset Get_Space_asset_By_SPACE_ASSET_ID_Adv(long? SPACE_ASSET_ID);
        #endregion
        #region Get_Floor_By_FLOOR_ID_Adv
        Floor Get_Floor_By_FLOOR_ID_Adv(long? FLOOR_ID);
        #endregion
        #region Get_Space_By_SPACE_ID_Adv
        Space Get_Space_By_SPACE_ID_Adv(long? SPACE_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_List_Adv
        List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(IEnumerable<long?> SPACE_ASSET_ID_LIST);
        #endregion
        #region Get_Floor_By_FLOOR_ID_List_Adv
        List<Floor> Get_Floor_By_FLOOR_ID_List_Adv(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_Space_By_SPACE_ID_List_Adv
        List<Space> Get_Space_By_SPACE_ID_List_Adv(IEnumerable<long?> SPACE_ID_LIST);
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
        #region Get_Space_asset_By_OWNER_ID_Adv
        List<Space_asset> Get_Space_asset_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Space_asset_By_SPACE_ID_Adv
        List<Space_asset> Get_Space_asset_By_SPACE_ID_Adv(long? SPACE_ID);
        #endregion
        #region Get_Space_asset_By_ASSET_ID_Adv
        List<Space_asset> Get_Space_asset_By_ASSET_ID_Adv(long? ASSET_ID);
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv
        List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID_Adv
        List<Space_asset> Get_Space_asset_By_EXTERNAL_ID_Adv(string EXTERNAL_ID);
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv
        List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv(bool IS_MERAKI_WIFI_SIGNAL);
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
        #region Get_Space_By_OWNER_ID_Adv
        List<Space> Get_Space_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Space_By_FLOOR_ID_Adv
        List<Space> Get_Space_By_FLOOR_ID_Adv(long? FLOOR_ID);
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED_Adv
        List<Space> Get_Space_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Space_asset_By_SPACE_ID_List_Adv
        List<Space_asset> Get_Space_asset_By_SPACE_ID_List_Adv(IEnumerable<long?> SPACE_ID_LIST);
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List_Adv
        List<Space_asset> Get_Space_asset_By_ASSET_ID_List_Adv(IEnumerable<long?> ASSET_ID_LIST);
        #endregion
        #region Get_Floor_By_ENTITY_ID_List_Adv
        List<Floor> Get_Floor_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Space_By_FLOOR_ID_List_Adv
        List<Space> Get_Space_By_FLOOR_ID_List_Adv(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_asset_By_Where_Adv
        List<Space_asset> Get_Space_asset_By_Where_Adv(string CUSTOM_NAME, string ASSET_ICON, string EXTERNAL_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where_Adv
        List<Floor> Get_Floor_By_Where_Adv(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where_Adv
        List<Space> Get_Space_By_Where_Adv(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_asset_By_Where_In_List_Adv
        List<Space_asset> Get_Space_asset_By_Where_In_List_Adv(string CUSTOM_NAME, string ASSET_ICON, IEnumerable<long?> SPACE_ID_LIST, IEnumerable<long?> ASSET_ID_LIST, IEnumerable<string> EXTERNAL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where_In_List_Adv
        List<Floor> Get_Floor_By_Where_In_List_Adv(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where_In_List_Adv
        List<Space> Get_Space_By_Where_In_List_Adv(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
