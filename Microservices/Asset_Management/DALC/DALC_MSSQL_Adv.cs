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
        #region Get_Asset_By_ASSET_ID_Adv
        public Asset Get_Asset_By_ASSET_ID_Adv(long? ASSET_ID)
        {
            Asset oAsset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_ID = ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oAsset = new Asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oAsset);
                oAsset.Asset_type_setup = new Setup();
                oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ASSET_TYPE_SETUP_SETUP_ID");
                oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ASSET_TYPE_SETUP_IS_DELETED");
                oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_ASSET_TYPE_SETUP_VALUE");
                oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ASSET_TYPE_SETUP_OWNER_ID");
            }
            return oAsset;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID_List_Adv
        public List<Asset> Get_Asset_By_ASSET_ID_List_Adv(IEnumerable<long?> ASSET_ID_LIST)
        {
            List<Asset> oList_Asset = null;
            if (ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_ID_LIST = string.Join(",", ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Asset = new List<Asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Asset oAsset = new Asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                            oAsset.Asset_type_setup = new Setup();
                            oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                            oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                            oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                            oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                            oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                            oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                            oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                            oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                            oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                            oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                            oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                            oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                            oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                            oList_Asset.Add(oAsset);
                        }
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_Adv
        public List<Asset> Get_Asset_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                        oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                        oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                        oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                        oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                        oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                        oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                        oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                        oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                        oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                        oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                        oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                        oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv(long? ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                        oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                        oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                        oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                        oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                        oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                        oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                        oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                        oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                        oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                        oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                        oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                        oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED_Adv
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                        oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                        oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                        oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                        oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                        oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                        oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                        oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                        oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                        oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                        oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                        oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                        oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST)
        {
            List<Asset> oList_Asset = null;
            if (ASSET_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_TYPE_SETUP_ID_LIST = string.Join(",", ASSET_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Asset = new List<Asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Asset oAsset = new Asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                            oAsset.Asset_type_setup = new Setup();
                            oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                            oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                            oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                            oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                            oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                            oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                            oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                            oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                            oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                            oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                            oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                            oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                            oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                            oList_Asset.Add(oAsset);
                        }
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where_Adv
        public List<Asset> Get_Asset_By_Where_Adv(string NAME, string GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLTF_URL = GLTF_URL;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                        oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                        oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                        oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                        oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                        oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                        oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                        oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                        oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                        oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                        oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                        oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                        oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where_In_List_Adv
        public List<Asset> Get_Asset_By_Where_In_List_Adv(string NAME, string GLTF_URL, IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        oAsset.Asset_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_SETUP_ID");
                        oAsset.Asset_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oAsset.Asset_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_SYSTEM");
                        oAsset.Asset_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETEABLE");
                        oAsset.Asset_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_UPDATEABLE");
                        oAsset.Asset_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_DELETED");
                        oAsset.Asset_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ASSET_TYPE_SETUP_IS_VISIBLE");
                        oAsset.Asset_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_DISPLAY_ORDER");
                        oAsset.Asset_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_VALUE");
                        oAsset.Asset_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_DESCRIPTION");
                        oAsset.Asset_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_TYPE_SETUP_ENTRY_USER_ID");
                        oAsset.Asset_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_ENTRY_DATE");
                        oAsset.Asset_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_TYPE_SETUP_LAST_UPDATE");
                        oAsset.Asset_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_TYPE_SETUP_OWNER_ID");
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Asset;
        }
        #endregion
    }
}
