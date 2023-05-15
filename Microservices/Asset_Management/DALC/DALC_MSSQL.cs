using System;
using SmartrTools;
using System.Data;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace DALC
{
    public partial class MSSQL_DALC : DALC
    {
        #region Get_Asset_By_ASSET_ID
        public Asset Get_Asset_By_ASSET_ID(long? ASSET_ID)
        {
            Asset oAsset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_ID = ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oAsset = new Asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oAsset);
            }
            return oAsset;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID_List
        public List<Asset> Get_Asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST)
        {
            List<Asset> oList_Asset = null;
            if (ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_ID_LIST = string.Join(",", ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Asset = new List<Asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Asset oAsset = new Asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                            oList_Asset.Add(oAsset);
                        }
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID
        public List<Asset> Get_Asset_By_OWNER_ID(int? OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST)
        {
            List<Asset> oList_Asset = null;
            if (ASSET_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_TYPE_SETUP_ID_LIST = string.Join(",", ASSET_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Asset = new List<Asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Asset oAsset = new Asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                            oList_Asset.Add(oAsset);
                        }
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where
        public List<Asset> Get_Asset_By_Where(string NAME, string GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLTF_URL = GLTF_URL;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where_In_List
        public List<Asset> Get_Asset_By_Where_In_List(string NAME, string GLTF_URL, IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLTF_URL = GLTF_URL;
            _params.ASSET_TYPE_SETUP_ID_LIST = ASSET_TYPE_SETUP_ID_LIST != null ? string.Join(",", ASSET_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Asset;
        }
        #endregion
        #region Delete_Asset
        public void Delete_Asset(long? ASSET_ID)
        {
            var _params = new
            {
                ASSET_ID = ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_ASSET", _params);
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID
        public void Delete_Asset_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ASSET_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        public void Delete_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID)
        {
            var _params = new
            {
                ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ASSET_BY_ASSET_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        public void Delete_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ASSET_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Asset
        public long? Edit_Asset(long? ASSET_ID, long? ASSET_TYPE_SETUP_ID, string NAME, string GLTF_URL, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Asset oAsset = new Asset()
            {
                ASSET_ID = ASSET_ID,
                ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID,
                NAME = NAME,
                GLTF_URL = GLTF_URL,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ASSET", oAsset, "ASSET_ID");
            return oAsset.ASSET_ID;
        }
        #endregion
    }
}
