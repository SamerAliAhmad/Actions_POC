using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Asset_By_ASSET_ID
        Asset Get_Asset_By_ASSET_ID(long? ASSET_ID);
        #endregion
        #region Get_Asset_By_ASSET_ID_List
        List<Asset> Get_Asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST);
        #endregion
        #region Get_Asset_By_OWNER_ID
        List<Asset> Get_Asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID);
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Asset_By_Where
        List<Asset> Get_Asset_By_Where(string NAME, string GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Asset_By_Where_In_List
        List<Asset> Get_Asset_By_Where_In_List(string NAME, string GLTF_URL, IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Asset
        void Delete_Asset(long? ASSET_ID);
        #endregion
        #region Delete_Asset_By_OWNER_ID
        void Delete_Asset_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        void Delete_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID);
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        void Delete_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Asset
        long? Edit_Asset(long? ASSET_ID, long? ASSET_TYPE_SETUP_ID, string NAME, string GLTF_URL, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
