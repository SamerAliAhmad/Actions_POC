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
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_Adv
        public Space_asset Get_Space_asset_By_SPACE_ASSET_ID_Adv(long? SPACE_ASSET_ID)
        {
            Space_asset oSpace_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ASSET_ID = SPACE_ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ASSET_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSpace_asset = new Space_asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSpace_asset);
                oSpace_asset.Asset = new Asset();
                oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(_query_response, "T_ASSET_ASSET_ID");
                oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ASSET_ASSET_TYPE_SETUP_ID");
                oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(_query_response, "T_ASSET_NAME");
                oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_ASSET_GLTF_URL");
                oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ASSET_ENTRY_USER_ID");
                oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ASSET_ENTRY_DATE");
                oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ASSET_LAST_UPDATE");
                oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ASSET_IS_DELETED");
                oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ASSET_OWNER_ID");
                oSpace_asset.Space = new Space();
                oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_SPACE_ID");
                oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_FLOOR_ID");
                oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(_query_response, "T_SPACE_NAME");
                oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_AREA");
                oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(_query_response, "T_SPACE_UNIT");
                oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(_query_response, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_ENTRY_USER_ID");
                oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SPACE_ENTRY_DATE");
                oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SPACE_LAST_UPDATE");
                oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SPACE_IS_DELETED");
                oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SPACE_OWNER_ID");
            }
            return oSpace_asset;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_Adv
        public Floor Get_Floor_By_FLOOR_ID_Adv(long? FLOOR_ID)
        {
            Floor oFloor = null;
            dynamic _params = new ExpandoObject();
            _params.FLOOR_ID = FLOOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oFloor = new Floor();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oFloor);
                oFloor.Entity = new Entity();
                oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTITY_ID");
                oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_SITE_ID");
                oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_AREA_ID");
                oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_DISTRICT_ID");
                oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_REGION_ID");
                oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_TOP_LEVEL_ID");
                oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                oFloor.Entity.NAME = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_NAME");
                oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_NUMBER_OF_FLOORS");
                oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLA");
                oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_GLA_UNIT");
                oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_AREA");
                oFloor.Entity.UNIT = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_UNIT");
                oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_SCALE");
                oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONX");
                oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONY");
                oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONZ");
                oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLTF_LATITUDE");
                oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLTF_LONGITUDE");
                oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_CENTER_LATITUDE");
                oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_CENTER_LONGITUDE");
                oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_RADIUS_IN_METERS");
                oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_IMAGE_URL");
                oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_SOLID_GLTF_URL");
                oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUL_ALT_X");
                oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUP_ALT_Y");
                oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUP_ALT_Z");
                oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTRY_USER_ID");
                oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_ENTRY_DATE");
                oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_LAST_UPDATE");
                oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_IS_DELETED");
                oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_OWNER_ID");
            }
            return oFloor;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_Adv
        public Space Get_Space_By_SPACE_ID_Adv(long? SPACE_ID)
        {
            Space oSpace = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ID = SPACE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SPACE_BY_SPACE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSpace = new Space();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSpace);
                oSpace.Floor = new Floor();
                oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(_query_response, "T_FLOOR_FLOOR_ID");
                oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(_query_response, "T_FLOOR_ENTITY_ID");
                oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(_query_response, "T_FLOOR_FLOOR_NUMBER");
                oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_SHELL_GLTF_URL");
                oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_CLIPPED_GLTF_URL");
                oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_ADVANCED_GLTF_URL");
                oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_FLOOR_AREA");
                oSpace.Floor.UNIT = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_UNIT");
                oSpace.Floor.NAME = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_NAME");
                oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_FLOOR_ENTRY_USER_ID");
                oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_ENTRY_DATE");
                oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_FLOOR_LAST_UPDATE");
                oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_FLOOR_IS_DELETED");
                oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_FLOOR_OWNER_ID");
            }
            return oSpace;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_List_Adv
        public List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(IEnumerable<long?> SPACE_ASSET_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (SPACE_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ASSET_ID_LIST = string.Join(",", SPACE_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ASSET_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oSpace_asset.Asset = new Asset();
                            oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                            oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                            oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                            oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                            oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                            oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                            oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                            oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                            oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                            oSpace_asset.Space = new Space();
                            oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                            oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                            oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                            oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                            oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                            oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                            oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                            oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                            oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                            oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                            oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_List_Adv
        public List<Floor> Get_Floor_By_FLOOR_ID_List_Adv(IEnumerable<long?> FLOOR_ID_LIST)
        {
            List<Floor> oList_Floor = null;
            if (FLOOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Floor = new List<Floor>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Floor oFloor = new Floor();
                            Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                            oFloor.Entity = new Entity();
                            oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oList_Floor.Add(oFloor);
                        }
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_List_Adv
        public List<Space> Get_Space_By_SPACE_ID_List_Adv(IEnumerable<long?> SPACE_ID_LIST)
        {
            List<Space> oList_Space = null;
            if (SPACE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ID_LIST = string.Join(",", SPACE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_SPACE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Space = new List<Space>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space oSpace = new Space();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                            oSpace.Floor = new Floor();
                            oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                            oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                            oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                            oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                            oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                            oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                            oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                            oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                            oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                            oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                            oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                            oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                            oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                            oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                            oList_Space.Add(oSpace);
                        }
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_Adv
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID_Adv
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_Adv(long? SPACE_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ID = SPACE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_Adv
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_Adv(long? ASSET_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_ID = ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_ASSET_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID_Adv
        public List<Space_asset> Get_Space_asset_By_EXTERNAL_ID_Adv(string EXTERNAL_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.EXTERNAL_ID = EXTERNAL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_EXTERNAL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv
        public List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv(bool IS_MERAKI_WIFI_SIGNAL)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_IS_MERAKI_WIFI_SIGNAL_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED_Adv
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oFloor.Entity = new Entity();
                        oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_Adv
        public List<Floor> Get_Floor_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oFloor.Entity = new Entity();
                        oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_Adv
        public List<Floor> Get_Floor_By_ENTITY_ID_Adv(long? ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_ENTITY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oFloor.Entity = new Entity();
                        oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_Adv
        public List<Space> Get_Space_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oSpace.Floor = new Floor();
                        oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                        oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                        oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                        oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                        oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                        oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                        oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                        oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                        oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                        oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                        oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                        oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                        oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                        oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_Adv
        public List<Space> Get_Space_By_FLOOR_ID_Adv(long? FLOOR_ID)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.FLOOR_ID = FLOOR_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_FLOOR_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oSpace.Floor = new Floor();
                        oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                        oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                        oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                        oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                        oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                        oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                        oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                        oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                        oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                        oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                        oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                        oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                        oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                        oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED_Adv
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oSpace.Floor = new Floor();
                        oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                        oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                        oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                        oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                        oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                        oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                        oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                        oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                        oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                        oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                        oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                        oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                        oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                        oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID_List_Adv
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_List_Adv(IEnumerable<long?> SPACE_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (SPACE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ID_LIST = string.Join(",", SPACE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oSpace_asset.Asset = new Asset();
                            oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                            oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                            oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                            oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                            oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                            oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                            oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                            oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                            oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                            oSpace_asset.Space = new Space();
                            oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                            oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                            oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                            oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                            oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                            oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                            oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                            oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                            oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                            oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                            oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List_Adv
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_List_Adv(IEnumerable<long?> ASSET_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_ID_LIST = string.Join(",", ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_ASSET_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oSpace_asset.Asset = new Asset();
                            oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                            oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                            oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                            oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                            oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                            oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                            oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                            oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                            oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                            oSpace_asset.Space = new Space();
                            oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                            oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                            oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                            oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                            oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                            oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                            oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                            oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                            oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                            oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                            oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_List_Adv
        public List<Floor> Get_Floor_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Floor> oList_Floor = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_ENTITY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Floor = new List<Floor>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Floor oFloor = new Floor();
                            Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                            oFloor.Entity = new Entity();
                            oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oList_Floor.Add(oFloor);
                        }
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_List_Adv
        public List<Space> Get_Space_By_FLOOR_ID_List_Adv(IEnumerable<long?> FLOOR_ID_LIST)
        {
            List<Space> oList_Space = null;
            if (FLOOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_FLOOR_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Space = new List<Space>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space oSpace = new Space();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                            oSpace.Floor = new Floor();
                            oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                            oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                            oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                            oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                            oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                            oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                            oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                            oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                            oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                            oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                            oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                            oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                            oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                            oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                            oList_Space.Add(oSpace);
                        }
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_Where_Adv
        public List<Space_asset> Get_Space_asset_By_Where_Adv(string CUSTOM_NAME, string ASSET_ICON, string EXTERNAL_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_Where_Adv
        public List<Floor> Get_Floor_By_Where_Adv(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oFloor.Entity = new Entity();
                        oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_Where_Adv
        public List<Space> Get_Space_By_Where_Adv(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oSpace.Floor = new Floor();
                        oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                        oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                        oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                        oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                        oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                        oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                        oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                        oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                        oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                        oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                        oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                        oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                        oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                        oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                        oList_Space.Add(oSpace);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Space_asset_By_Where_In_List_Adv
        public List<Space_asset> Get_Space_asset_By_Where_In_List_Adv(string CUSTOM_NAME, string ASSET_ICON, IEnumerable<long?> SPACE_ID_LIST, IEnumerable<long?> ASSET_ID_LIST, IEnumerable<string> EXTERNAL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        oSpace_asset.Asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_ID");
                        oSpace_asset.Asset.ASSET_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ASSET_TYPE_SETUP_ID");
                        oSpace_asset.Asset.NAME = Get_Data_Record_Value<string>(element, "T_ASSET_NAME");
                        oSpace_asset.Asset.GLTF_URL = Get_Data_Record_Value<string>(element, "T_ASSET_GLTF_URL");
                        oSpace_asset.Asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ASSET_ENTRY_USER_ID");
                        oSpace_asset.Asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ASSET_ENTRY_DATE");
                        oSpace_asset.Asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ASSET_LAST_UPDATE");
                        oSpace_asset.Asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ASSET_IS_DELETED");
                        oSpace_asset.Asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ASSET_OWNER_ID");
                        oSpace_asset.Space = new Space();
                        oSpace_asset.Space.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_SPACE_ID");
                        oSpace_asset.Space.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_FLOOR_ID");
                        oSpace_asset.Space.NAME = Get_Data_Record_Value<string>(element, "T_SPACE_NAME");
                        oSpace_asset.Space.AREA = Get_Data_Record_Value<decimal?>(element, "T_SPACE_AREA");
                        oSpace_asset.Space.UNIT = Get_Data_Record_Value<string>(element, "T_SPACE_UNIT");
                        oSpace_asset.Space.OCCUPANT_LOAD_FACTOR = Get_Data_Record_Value<int?>(element, "T_SPACE_OCCUPANT_LOAD_FACTOR");
                        oSpace_asset.Space.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ENTRY_USER_ID");
                        oSpace_asset.Space.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ENTRY_DATE");
                        oSpace_asset.Space.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_LAST_UPDATE");
                        oSpace_asset.Space.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_IS_DELETED");
                        oSpace_asset.Space.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_OWNER_ID");
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_Where_In_List_Adv
        public List<Floor> Get_Floor_By_Where_In_List_Adv(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oFloor.Entity = new Entity();
                        oFloor.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oFloor.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oFloor.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oFloor.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oFloor.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oFloor.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oFloor.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oFloor.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oFloor.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oFloor.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oFloor.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oFloor.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oFloor.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oFloor.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oFloor.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oFloor.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oFloor.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oFloor.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oFloor.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oFloor.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oFloor.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oFloor.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oFloor.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oFloor.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oFloor.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oFloor.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oFloor.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oFloor.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oFloor.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oFloor.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oFloor.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oFloor.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_Where_In_List_Adv
        public List<Space> Get_Space_By_Where_In_List_Adv(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oSpace.Floor = new Floor();
                        oSpace.Floor.FLOOR_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_FLOOR_ID");
                        oSpace.Floor.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTITY_ID");
                        oSpace.Floor.FLOOR_NUMBER = Get_Data_Record_Value<int?>(element, "T_FLOOR_FLOOR_NUMBER");
                        oSpace.Floor.SHELL_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_SHELL_GLTF_URL");
                        oSpace.Floor.CLIPPED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_CLIPPED_GLTF_URL");
                        oSpace.Floor.ADVANCED_GLTF_URL = Get_Data_Record_Value<string>(element, "T_FLOOR_ADVANCED_GLTF_URL");
                        oSpace.Floor.AREA = Get_Data_Record_Value<decimal?>(element, "T_FLOOR_AREA");
                        oSpace.Floor.UNIT = Get_Data_Record_Value<string>(element, "T_FLOOR_UNIT");
                        oSpace.Floor.NAME = Get_Data_Record_Value<string>(element, "T_FLOOR_NAME");
                        oSpace.Floor.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_FLOOR_ENTRY_USER_ID");
                        oSpace.Floor.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_FLOOR_ENTRY_DATE");
                        oSpace.Floor.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_FLOOR_LAST_UPDATE");
                        oSpace.Floor.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_FLOOR_IS_DELETED");
                        oSpace.Floor.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_FLOOR_OWNER_ID");
                        oList_Space.Add(oSpace);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space;
        }
        #endregion
    }
}
