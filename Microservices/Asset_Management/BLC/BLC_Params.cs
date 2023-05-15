using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Asset_By_ASSET_ID
    public partial class Params_Get_Asset_By_ASSET_ID
    {
        #region Properties
        public long? ASSET_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_ASSET_ID_List
    public partial class Params_Get_Asset_By_ASSET_ID_List
    {
        #region Properties
        public IEnumerable<long?> ASSET_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_OWNER_ID
    public partial class Params_Get_Asset_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_ASSET_TYPE_SETUP_ID
    public partial class Params_Get_Asset_By_ASSET_TYPE_SETUP_ID
    {
        #region Properties
        public long? ASSET_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Asset_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List
    public partial class Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_Where
    public partial class Params_Get_Asset_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string GLTF_URL { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Asset_By_Where_In_List
    public partial class Params_Get_Asset_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string GLTF_URL { get; set; }
        public IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Asset
    public partial class Params_Delete_Asset
    {
        #region Properties
        public long? ASSET_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Asset_By_OWNER_ID
    public partial class Params_Delete_Asset_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID
    public partial class Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID
    {
        #region Properties
        public long? ASSET_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Asset_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Asset_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Asset_List
    public partial class Params_Edit_Asset_List
    {
        #region Properties
        public List<Asset> List_To_Edit { get; set; }
        public List<Asset> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}