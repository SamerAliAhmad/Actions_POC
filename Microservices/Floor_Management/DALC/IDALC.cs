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
        #region Get_Space_asset_By_SPACE_ASSET_ID
        Space_asset Get_Space_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID);
        #endregion
        #region Get_Floor_By_FLOOR_ID
        Floor Get_Floor_By_FLOOR_ID(long? FLOOR_ID);
        #endregion
        #region Get_Space_By_SPACE_ID
        Space Get_Space_By_SPACE_ID(long? SPACE_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_List
        List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List(IEnumerable<long?> SPACE_ASSET_ID_LIST);
        #endregion
        #region Get_Floor_By_FLOOR_ID_List
        List<Floor> Get_Floor_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_Space_By_SPACE_ID_List
        List<Space> Get_Space_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST);
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
        #region Get_Space_asset_By_OWNER_ID
        List<Space_asset> Get_Space_asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Space_asset_By_SPACE_ID
        List<Space_asset> Get_Space_asset_By_SPACE_ID(long? SPACE_ID);
        #endregion
        #region Get_Space_asset_By_ASSET_ID
        List<Space_asset> Get_Space_asset_By_ASSET_ID(long? ASSET_ID);
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED
        List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID
        List<Space_asset> Get_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID);
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL);
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED
        List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Floor_By_OWNER_ID
        List<Floor> Get_Floor_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Floor_By_ENTITY_ID
        List<Floor> Get_Floor_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Get_Space_By_OWNER_ID
        List<Space> Get_Space_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Space_By_FLOOR_ID
        List<Space> Get_Space_By_FLOOR_ID(long? FLOOR_ID);
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED
        List<Space> Get_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Space_asset_By_SPACE_ID_List
        List<Space_asset> Get_Space_asset_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST);
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List
        List<Space_asset> Get_Space_asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST);
        #endregion
        #region Get_Floor_By_ENTITY_ID_List
        List<Floor> Get_Floor_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST);
        #endregion
        #region Get_Space_By_FLOOR_ID_List
        List<Space> Get_Space_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_asset_By_Where
        List<Space_asset> Get_Space_asset_By_Where(string CUSTOM_NAME, string ASSET_ICON, string EXTERNAL_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where
        List<Floor> Get_Floor_By_Where(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where
        List<Space> Get_Space_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_asset_By_Where_In_List
        List<Space_asset> Get_Space_asset_By_Where_In_List(string CUSTOM_NAME, string ASSET_ICON, IEnumerable<long?> SPACE_ID_LIST, IEnumerable<long?> ASSET_ID_LIST, IEnumerable<string> EXTERNAL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Floor_By_Where_In_List
        List<Floor> Get_Floor_By_Where_In_List(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Space_By_Where_In_List
        List<Space> Get_Space_By_Where_In_List(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_Space_asset
        void Delete_Space_asset(long? SPACE_ASSET_ID);
        #endregion
        #region Delete_Floor
        void Delete_Floor(long? FLOOR_ID);
        #endregion
        #region Delete_Space
        void Delete_Space(long? SPACE_ID);
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
        #region Delete_Space_asset_By_OWNER_ID
        void Delete_Space_asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Space_asset_By_SPACE_ID
        void Delete_Space_asset_By_SPACE_ID(long? SPACE_ID);
        #endregion
        #region Delete_Space_asset_By_ASSET_ID
        void Delete_Space_asset_By_ASSET_ID(long? ASSET_ID);
        #endregion
        #region Delete_Space_asset_By_OWNER_ID_IS_DELETED
        void Delete_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Space_asset_By_EXTERNAL_ID
        void Delete_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID);
        #endregion
        #region Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        void Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL);
        #endregion
        #region Delete_Floor_By_OWNER_ID_IS_DELETED
        void Delete_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Floor_By_OWNER_ID
        void Delete_Floor_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Floor_By_ENTITY_ID
        void Delete_Floor_By_ENTITY_ID(long? ENTITY_ID);
        #endregion
        #region Delete_Space_By_OWNER_ID
        void Delete_Space_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Space_By_FLOOR_ID
        void Delete_Space_By_FLOOR_ID(long? FLOOR_ID);
        #endregion
        #region Delete_Space_By_OWNER_ID_IS_DELETED
        void Delete_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_Space_asset
        long? Edit_Space_asset(long? SPACE_ASSET_ID, long? SPACE_ID, long? ASSET_ID, string EXTERNAL_ID, bool IS_MERAKI_WIFI_SIGNAL, string CUSTOM_NAME, decimal? POSITION_X, decimal? POSITION_Y, decimal? POSITION_Z, decimal? SCALE_MULTIPLIER, decimal? ROTATE_X, decimal? ROTATE_Y, decimal? ROTATE_Z, string ASSET_ICON, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Floor
        long? Edit_Floor(long? FLOOR_ID, long? ENTITY_ID, int? FLOOR_NUMBER, string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, decimal? AREA, string UNIT, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Space
        long? Edit_Space(long? SPACE_ID, long? FLOOR_ID, string NAME, decimal? AREA, string UNIT, int? OCCUPANT_LOAD_FACTOR, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
