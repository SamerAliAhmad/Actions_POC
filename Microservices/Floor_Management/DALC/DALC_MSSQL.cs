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
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID
        public Space_asset Get_Space_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID)
        {
            Space_asset oSpace_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ASSET_ID = SPACE_ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ASSET_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSpace_asset = new Space_asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSpace_asset);
            }
            return oSpace_asset;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID
        public Floor Get_Floor_By_FLOOR_ID(long? FLOOR_ID)
        {
            Floor oFloor = null;
            dynamic _params = new ExpandoObject();
            _params.FLOOR_ID = FLOOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oFloor = new Floor();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oFloor);
            }
            return oFloor;
        }
        #endregion
        #region Get_Space_By_SPACE_ID
        public Space Get_Space_By_SPACE_ID(long? SPACE_ID)
        {
            Space oSpace = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ID = SPACE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SPACE_BY_SPACE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSpace = new Space();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSpace);
            }
            return oSpace;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup_category> oList_Setup_category = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup_category = new List<Setup_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup_category oSetup_category = new Setup_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                            oList_Setup_category.Add(oSetup_category);
                        }
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List(IEnumerable<long?> SPACE_ASSET_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (SPACE_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ASSET_ID_LIST = string.Join(",", SPACE_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_List
        public List<Floor> Get_Floor_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST)
        {
            List<Floor> oList_Floor = null;
            if (FLOOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Floor = new List<Floor>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Floor oFloor = new Floor();
                            Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                            oList_Floor.Add(oFloor);
                        }
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_List
        public List<Space> Get_Space_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST)
        {
            List<Space> oList_Space = null;
            if (SPACE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ID_LIST = string.Join(",", SPACE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_SPACE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space = new List<Space>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space oSpace = new Space();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                            oList_Space.Add(oSpace);
                        }
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID
        public List<Space_asset> Get_Space_asset_By_OWNER_ID(int? OWNER_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID
        public List<Space_asset> Get_Space_asset_By_SPACE_ID(long? SPACE_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ID = SPACE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID
        public List<Space_asset> Get_Space_asset_By_ASSET_ID(long? ASSET_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_ID = ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_ASSET_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID
        public List<Space_asset> Get_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.EXTERNAL_ID = EXTERNAL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_EXTERNAL_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_IS_MERAKI_WIFI_SIGNAL", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID
        public List<Floor> Get_Floor_By_OWNER_ID(int? OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID
        public List<Floor> Get_Floor_By_ENTITY_ID(long? ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_ENTITY_ID", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_OWNER_ID
        public List<Space> Get_Space_By_OWNER_ID(int? OWNER_ID)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID
        public List<Space> Get_Space_By_FLOOR_ID(long? FLOOR_ID)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.FLOOR_ID = FLOOR_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_FLOOR_ID", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (SPACE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ID_LIST = string.Join(",", SPACE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_ID_LIST = string.Join(",", ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_List
        public List<Floor> Get_Floor_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Floor> oList_Floor = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Floor = new List<Floor>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Floor oFloor = new Floor();
                            Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                            oList_Floor.Add(oFloor);
                        }
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_List
        public List<Space> Get_Space_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST)
        {
            List<Space> oList_Space = null;
            if (FLOOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_FLOOR_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space = new List<Space>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space oSpace = new Space();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                            oList_Space.Add(oSpace);
                        }
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_Where
        public List<Space_asset> Get_Space_asset_By_Where(string CUSTOM_NAME, string ASSET_ICON, string EXTERNAL_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.CUSTOM_NAME = CUSTOM_NAME;
            _params.ASSET_ICON = ASSET_ICON;
            _params.EXTERNAL_ID = EXTERNAL_ID;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_Where
        public List<Floor> Get_Floor_By_Where(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.SHELL_GLTF_URL = SHELL_GLTF_URL;
            _params.CLIPPED_GLTF_URL = CLIPPED_GLTF_URL;
            _params.ADVANCED_GLTF_URL = ADVANCED_GLTF_URL;
            _params.UNIT = UNIT;
            _params.NAME = NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_Where
        public List<Space> Get_Space_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.SETUP_CATEGORY_ID_LIST = SETUP_CATEGORY_ID_LIST != null ? string.Join(",", SETUP_CATEGORY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_Where_In_List
        public List<Space_asset> Get_Space_asset_By_Where_In_List(string CUSTOM_NAME, string ASSET_ICON, IEnumerable<long?> SPACE_ID_LIST, IEnumerable<long?> ASSET_ID_LIST, IEnumerable<string> EXTERNAL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.CUSTOM_NAME = CUSTOM_NAME;
            _params.ASSET_ICON = ASSET_ICON;
            _params.SPACE_ID_LIST = SPACE_ID_LIST != null ? string.Join(",", SPACE_ID_LIST) : "";
            _params.ASSET_ID_LIST = ASSET_ID_LIST != null ? string.Join(",", ASSET_ID_LIST) : "";
            _params.EXTERNAL_ID_LIST = EXTERNAL_ID_LIST != null ? string.Join(",", EXTERNAL_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_Where_In_List
        public List<Floor> Get_Floor_By_Where_In_List(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.SHELL_GLTF_URL = SHELL_GLTF_URL;
            _params.CLIPPED_GLTF_URL = CLIPPED_GLTF_URL;
            _params.ADVANCED_GLTF_URL = ADVANCED_GLTF_URL;
            _params.UNIT = UNIT;
            _params.NAME = NAME;
            _params.ENTITY_ID_LIST = ENTITY_ID_LIST != null ? string.Join(",", ENTITY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_Where_In_List
        public List<Space> Get_Space_By_Where_In_List(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.FLOOR_ID_LIST = FLOOR_ID_LIST != null ? string.Join(",", FLOOR_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space;
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY", _params);
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(long? SETUP_ID)
        {
            var _params = new
            {
                SETUP_ID = SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP", _params);
        }
        #endregion
        #region Delete_Space_asset
        public void Delete_Space_asset(long? SPACE_ASSET_ID)
        {
            var _params = new
            {
                SPACE_ASSET_ID = SPACE_ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET", _params);
        }
        #endregion
        #region Delete_Floor
        public void Delete_Floor(long? FLOOR_ID)
        {
            var _params = new
            {
                FLOOR_ID = FLOOR_ID
            };
            ExecuteDelete("UPG_DELETE_FLOOR", _params);
        }
        #endregion
        #region Delete_Space
        public void Delete_Space(long? SPACE_ID)
        {
            var _params = new
            {
                SPACE_ID = SPACE_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                VALUE = VALUE
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_OWNER_ID
        public void Delete_Space_asset_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_SPACE_ID
        public void Delete_Space_asset_By_SPACE_ID(long? SPACE_ID)
        {
            var _params = new
            {
                SPACE_ID = SPACE_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_SPACE_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_ASSET_ID
        public void Delete_Space_asset_By_ASSET_ID(long? ASSET_ID)
        {
            var _params = new
            {
                ASSET_ID = ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_ASSET_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_OWNER_ID_IS_DELETED
        public void Delete_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Space_asset_By_EXTERNAL_ID
        public void Delete_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID)
        {
            var _params = new
            {
                EXTERNAL_ID = EXTERNAL_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_EXTERNAL_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public void Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL)
        {
            var _params = new
            {
                IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_IS_MERAKI_WIFI_SIGNAL", _params);
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID_IS_DELETED
        public void Delete_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_FLOOR_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID
        public void Delete_Floor_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_FLOOR_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Floor_By_ENTITY_ID
        public void Delete_Floor_By_ENTITY_ID(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_FLOOR_BY_ENTITY_ID", _params);
        }
        #endregion
        #region Delete_Space_By_OWNER_ID
        public void Delete_Space_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Space_By_FLOOR_ID
        public void Delete_Space_By_FLOOR_ID(long? FLOOR_ID)
        {
            var _params = new
            {
                FLOOR_ID = FLOOR_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_BY_FLOOR_ID", _params);
        }
        #endregion
        #region Delete_Space_By_OWNER_ID_IS_DELETED
        public void Delete_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SPACE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Setup_category
        public int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Setup_category oSetup_category = new Setup_category()
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP_CATEGORY", oSetup_category, "SETUP_CATEGORY_ID");
            return oSetup_category.SETUP_CATEGORY_ID;
        }
        #endregion
        #region Edit_Setup
        public long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID)
        {
            Setup oSetup = new Setup()
            {
                SETUP_ID = SETUP_ID,
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                IS_SYSTEM = IS_SYSTEM,
                IS_DELETEABLE = IS_DELETEABLE,
                IS_UPDATEABLE = IS_UPDATEABLE,
                IS_DELETED = IS_DELETED,
                IS_VISIBLE = IS_VISIBLE,
                DISPLAY_ORDER = DISPLAY_ORDER,
                VALUE = VALUE,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP", oSetup, "SETUP_ID");
            return oSetup.SETUP_ID;
        }
        #endregion
        #region Edit_Space_asset
        public long? Edit_Space_asset(long? SPACE_ASSET_ID, long? SPACE_ID, long? ASSET_ID, string EXTERNAL_ID, bool IS_MERAKI_WIFI_SIGNAL, string CUSTOM_NAME, decimal? POSITION_X, decimal? POSITION_Y, decimal? POSITION_Z, decimal? SCALE_MULTIPLIER, decimal? ROTATE_X, decimal? ROTATE_Y, decimal? ROTATE_Z, string ASSET_ICON, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Space_asset oSpace_asset = new Space_asset()
            {
                SPACE_ASSET_ID = SPACE_ASSET_ID,
                SPACE_ID = SPACE_ID,
                ASSET_ID = ASSET_ID,
                EXTERNAL_ID = EXTERNAL_ID,
                IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL,
                CUSTOM_NAME = CUSTOM_NAME,
                POSITION_X = POSITION_X,
                POSITION_Y = POSITION_Y,
                POSITION_Z = POSITION_Z,
                SCALE_MULTIPLIER = SCALE_MULTIPLIER,
                ROTATE_X = ROTATE_X,
                ROTATE_Y = ROTATE_Y,
                ROTATE_Z = ROTATE_Z,
                ASSET_ICON = ASSET_ICON,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SPACE_ASSET", oSpace_asset, "SPACE_ASSET_ID");
            return oSpace_asset.SPACE_ASSET_ID;
        }
        #endregion
        #region Edit_Floor
        public long? Edit_Floor(long? FLOOR_ID, long? ENTITY_ID, int? FLOOR_NUMBER, string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, decimal? AREA, string UNIT, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Floor oFloor = new Floor()
            {
                FLOOR_ID = FLOOR_ID,
                ENTITY_ID = ENTITY_ID,
                FLOOR_NUMBER = FLOOR_NUMBER,
                SHELL_GLTF_URL = SHELL_GLTF_URL,
                CLIPPED_GLTF_URL = CLIPPED_GLTF_URL,
                ADVANCED_GLTF_URL = ADVANCED_GLTF_URL,
                AREA = AREA,
                UNIT = UNIT,
                NAME = NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_FLOOR", oFloor, "FLOOR_ID");
            return oFloor.FLOOR_ID;
        }
        #endregion
        #region Edit_Space
        public long? Edit_Space(long? SPACE_ID, long? FLOOR_ID, string NAME, decimal? AREA, string UNIT, int? OCCUPANT_LOAD_FACTOR, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Space oSpace = new Space()
            {
                SPACE_ID = SPACE_ID,
                FLOOR_ID = FLOOR_ID,
                NAME = NAME,
                AREA = AREA,
                UNIT = UNIT,
                OCCUPANT_LOAD_FACTOR = OCCUPANT_LOAD_FACTOR,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SPACE", oSpace, "SPACE_ID");
            return oSpace.SPACE_ID;
        }
        #endregion
    }
}
