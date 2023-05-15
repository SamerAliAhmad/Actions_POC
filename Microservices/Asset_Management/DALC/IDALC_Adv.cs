using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Asset_By_ASSET_ID_Adv
        Asset Get_Asset_By_ASSET_ID_Adv(long? ASSET_ID);
        #endregion
        #region Get_Asset_By_ASSET_ID_List_Adv
        List<Asset> Get_Asset_By_ASSET_ID_List_Adv(IEnumerable<long?> ASSET_ID_LIST);
        #endregion
        #region Get_Asset_By_OWNER_ID_Adv
        List<Asset> Get_Asset_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv
        List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv(long? ASSET_TYPE_SETUP_ID);
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED_Adv
        List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv
        List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Asset_By_Where_Adv
        List<Asset> Get_Asset_By_Where_Adv(string NAME, string GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Asset_By_Where_In_List_Adv
        List<Asset> Get_Asset_By_Where_In_List_Adv(string NAME, string GLTF_URL, IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
