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
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv
        public Video_ai_search_category Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv(int? VIDEO_AI_SEARCH_CATEGORY_ID)
        {
            Video_ai_search_category oVideo_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_SEARCH_CATEGORY_ID = VIDEO_AI_SEARCH_CATEGORY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_SEARCH_CATEGORY_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_search_category = new Video_ai_search_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_search_category);
                oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIDEO_AI_ENGINE_IS_DELETED");
                oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ENGINE_OWNER_ID");
            }
            return oVideo_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv
        public Video_ai_asset_entity Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv(int? VIDEO_AI_ASSET_ENTITY_ID)
        {
            Video_ai_asset_entity oVideo_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ENTITY_ID = VIDEO_AI_ASSET_ENTITY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ENTITY_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_asset_entity = new Video_ai_asset_entity();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_asset_entity);
                oVideo_ai_asset_entity.Entity = new Entity();
                oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTITY_ID");
                oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_SITE_ID");
                oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_AREA_ID");
                oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_DISTRICT_ID");
                oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_REGION_ID");
                oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_TOP_LEVEL_ID");
                oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_NAME");
                oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_NUMBER_OF_FLOORS");
                oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLA");
                oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_GLA_UNIT");
                oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_AREA");
                oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_UNIT");
                oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_SCALE");
                oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONX");
                oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONY");
                oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONZ");
                oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLTF_LATITUDE");
                oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLTF_LONGITUDE");
                oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_CENTER_LATITUDE");
                oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_CENTER_LONGITUDE");
                oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_RADIUS_IN_METERS");
                oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_IMAGE_URL");
                oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_SOLID_GLTF_URL");
                oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUL_ALT_X");
                oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUP_ALT_Y");
                oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUP_ALT_Z");
                oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTRY_USER_ID");
                oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_ENTRY_DATE");
                oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_LAST_UPDATE");
                oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_IS_DELETED");
                oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_OWNER_ID");
                oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIDEO_AI_ASSET_IS_DELETED");
                oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ASSET_OWNER_ID");
            }
            return oVideo_ai_asset_entity;
        }
        #endregion
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
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv
        public Video_ai_instance Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv(int? VIDEO_AI_INSTANCE_ID)
        {
            Video_ai_instance oVideo_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_INSTANCE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_instance = new Video_ai_instance();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_instance);
                oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIDEO_AI_ENGINE_IS_DELETED");
                oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_ENGINE_OWNER_ID");
                oVideo_ai_instance.Connection_type_setup = new Setup();
                oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_CONNECTION_TYPE_SETUP_VALUE");
                oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
            }
            return oVideo_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv
        public Video_ai_asset Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(int? VIDEO_AI_ASSET_ID)
        {
            Video_ai_asset oVideo_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_asset = new Video_ai_asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_asset);
                oVideo_ai_asset.Space_asset = new Space_asset();
                oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_ASSET_SPACE_ASSET_ID");
                oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_ASSET_SPACE_ID");
                oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_ASSET_ASSET_ID");
                oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(_query_response, "T_SPACE_ASSET_EXTERNAL_ID");
                oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(_query_response, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(_query_response, "T_SPACE_ASSET_CUSTOM_NAME");
                oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_POSITION_X");
                oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_POSITION_Y");
                oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_POSITION_Z");
                oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_ROTATE_X");
                oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_ROTATE_Y");
                oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(_query_response, "T_SPACE_ASSET_ROTATE_Z");
                oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(_query_response, "T_SPACE_ASSET_ASSET_ICON");
                oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SPACE_ASSET_ENTRY_USER_ID");
                oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SPACE_ASSET_ENTRY_DATE");
                oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SPACE_ASSET_LAST_UPDATE");
                oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SPACE_ASSET_IS_DELETED");
                oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SPACE_ASSET_OWNER_ID");
                oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_USERNAME");
                oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_PASSWORD");
                oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(_query_response, "T_VIDEO_AI_INSTANCE_IS_LPR");
                oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIDEO_AI_INSTANCE_OWNER_ID");
            }
            return oVideo_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv(IEnumerable<int?> VIDEO_AI_SEARCH_CATEGORY_ID_LIST)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            if (VIDEO_AI_SEARCH_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_SEARCH_CATEGORY_ID_LIST = string.Join(",", VIDEO_AI_SEARCH_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_SEARCH_CATEGORY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_search_category = new List<Video_ai_search_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                            oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                            oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                            oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                            oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                            oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                            oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                            oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                            oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                        }
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ENTITY_ID_LIST)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            if (VIDEO_AI_ASSET_ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ENTITY_ID_LIST = string.Join(",", VIDEO_AI_ASSET_ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ENTITY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                            oVideo_ai_asset_entity.Entity = new Entity();
                            oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                            oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                            oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                            oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                            oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                            oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                            oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                            oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                            oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
            }
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            if (VIDEO_AI_INSTANCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_INSTANCE_ID_LIST = string.Join(",", VIDEO_AI_INSTANCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_INSTANCE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_instance = new List<Video_ai_instance>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                            oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                            oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                            oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                            oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                            oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                            oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                            oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                            oVideo_ai_instance.Connection_type_setup = new Setup();
                            oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                            oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                            oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                            oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                            oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                            oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                            oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                            oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                            oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                            oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                            oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                            oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                            oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                            oList_Video_ai_instance.Add(oVideo_ai_instance);
                        }
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (VIDEO_AI_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ID_LIST = string.Join(",", VIDEO_AI_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oVideo_ai_asset.Space_asset = new Space_asset();
                            oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                            oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                            oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                            oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                            oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                            oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                            oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                            oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                            oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                            oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                            oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                            oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                            oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                            oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                            oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                            oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                            oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                            oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                            oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                            oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                            oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                            oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                            oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                            oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                            oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv(int? VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_ENGINE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                        oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                        oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                        oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                        oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv(int? VIDEO_AI_ASSET_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                        oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                        oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                        oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                        oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(long? ENTITY_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_ENTITY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                        oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                        oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                        oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                        oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                        oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                        oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                        oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                        oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_OWNER_ID_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                        oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                        oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                        oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                        oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                        oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                        oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                        oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv(int? VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_ENGINE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                        oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                        oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                        oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                        oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                        oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                        oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                        oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv(long? CONNECTION_TYPE_SETUP_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.CONNECTION_TYPE_SETUP_ID = CONNECTION_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_CONNECTION_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                        oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                        oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                        oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                        oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                        oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                        oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                        oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                        oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                        oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                        oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                        oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                        oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                        oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                        oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv(int? VIDEO_AI_INSTANCE_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_INSTANCE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv(long? SPACE_ASSET_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ASSET_ID = SPACE_ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_SPACE_ASSET_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv(int? VIDEO_AI_ASSET_ID_REF)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ID_REF = VIDEO_AI_ASSET_ID_REF;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_REF_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            if (VIDEO_AI_ENGINE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ENGINE_ID_LIST = string.Join(",", VIDEO_AI_ENGINE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_ENGINE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_search_category = new List<Video_ai_search_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                            oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                            oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                            oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                            oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                            oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                            oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                            oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                            oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                        }
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            if (VIDEO_AI_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ID_LIST = string.Join(",", VIDEO_AI_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                            oVideo_ai_asset_entity.Entity = new Entity();
                            oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                            oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                            oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                            oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                            oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                            oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                            oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                            oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                            oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_ENTITY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                            oVideo_ai_asset_entity.Entity = new Entity();
                            oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                            oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                            oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                            oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                            oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                            oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                            oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                            oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                            oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                            oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
            }
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            if (VIDEO_AI_ENGINE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ENGINE_ID_LIST = string.Join(",", VIDEO_AI_ENGINE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_ENGINE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_instance = new List<Video_ai_instance>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                            oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                            oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                            oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                            oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                            oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                            oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                            oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                            oVideo_ai_instance.Connection_type_setup = new Setup();
                            oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                            oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                            oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                            oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                            oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                            oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                            oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                            oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                            oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                            oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                            oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                            oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                            oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                            oList_Video_ai_instance.Add(oVideo_ai_instance);
                        }
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            if (CONNECTION_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.CONNECTION_TYPE_SETUP_ID_LIST = string.Join(",", CONNECTION_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_CONNECTION_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_instance = new List<Video_ai_instance>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                            oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                            oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                            oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                            oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                            oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                            oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                            oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                            oVideo_ai_instance.Connection_type_setup = new Setup();
                            oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                            oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                            oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                            oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                            oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                            oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                            oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                            oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                            oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                            oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                            oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                            oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                            oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                            oList_Video_ai_instance.Add(oVideo_ai_instance);
                        }
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (VIDEO_AI_INSTANCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_INSTANCE_ID_LIST = string.Join(",", VIDEO_AI_INSTANCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_INSTANCE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oVideo_ai_asset.Space_asset = new Space_asset();
                            oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                            oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                            oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                            oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                            oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                            oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                            oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                            oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                            oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                            oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                            oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                            oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                            oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                            oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                            oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                            oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                            oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                            oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                            oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                            oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                            oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                            oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                            oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                            oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                            oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(IEnumerable<long?> SPACE_ASSET_ID_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (SPACE_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ASSET_ID_LIST = string.Join(",", SPACE_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_SPACE_ASSET_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oVideo_ai_asset.Space_asset = new Space_asset();
                            oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                            oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                            oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                            oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                            oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                            oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                            oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                            oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                            oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                            oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                            oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                            oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                            oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                            oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                            oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                            oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                            oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                            oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                            oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                            oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                            oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                            oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                            oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                            oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                            oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv(IEnumerable<int?> VIDEO_AI_ASSET_ID_REF_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (VIDEO_AI_ASSET_ID_REF_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ID_REF_LIST = string.Join(",", VIDEO_AI_ASSET_ID_REF_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_REF_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oVideo_ai_asset.Space_asset = new Space_asset();
                            oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                            oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                            oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                            oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                            oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                            oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                            oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                            oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                            oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                            oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                            oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                            oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                            oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                            oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                            oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                            oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                            oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                            oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                            oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                            oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                            oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                            oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                            oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                            oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                            oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                            oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                            oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                            oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                            oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                            oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                            oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_Adv(string CATEGORY_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.CATEGORY_NAME = CATEGORY_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                        oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                        oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                        oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                        oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_Where_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.FRIENDLY_NAME = FRIENDLY_NAME;
            _params.FUNCTIONAL_NAME = FUNCTIONAL_NAME;
            _params.CONNECTION_URL = CONNECTION_URL;
            _params.USERNAME = USERNAME;
            _params.PASSWORD = PASSWORD;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                        oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                        oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                        oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                        oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                        oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                        oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                        oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.FRIENDLY_NAME = FRIENDLY_NAME;
            _params.FUNCTIONAL_NAME = FUNCTIONAL_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where_In_List_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_In_List_Adv(string CATEGORY_NAME, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.CATEGORY_NAME = CATEGORY_NAME;
            _params.VIDEO_AI_ENGINE_ID_LIST = VIDEO_AI_ENGINE_ID_LIST != null ? string.Join(",", VIDEO_AI_ENGINE_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_search_category.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_search_category.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_search_category.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_search_category.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_search_category.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_In_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.VIDEO_AI_ASSET_ID_LIST = VIDEO_AI_ASSET_ID_LIST != null ? string.Join(",", VIDEO_AI_ASSET_ID_LIST) : "";
            _params.ENTITY_ID_LIST = ENTITY_ID_LIST != null ? string.Join(",", ENTITY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        oVideo_ai_asset_entity.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oVideo_ai_asset_entity.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oVideo_ai_asset_entity.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oVideo_ai_asset_entity.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oVideo_ai_asset_entity.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oVideo_ai_asset_entity.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oVideo_ai_asset_entity.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oVideo_ai_asset_entity.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oVideo_ai_asset_entity.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oVideo_ai_asset_entity.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oVideo_ai_asset_entity.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oVideo_ai_asset_entity.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oVideo_ai_asset_entity.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oVideo_ai_asset_entity.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oVideo_ai_asset_entity.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oVideo_ai_asset_entity.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oVideo_ai_asset_entity.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oVideo_ai_asset_entity.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oVideo_ai_asset_entity.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oVideo_ai_asset_entity.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oVideo_ai_asset_entity.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oVideo_ai_asset_entity.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oVideo_ai_asset_entity.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oVideo_ai_asset_entity.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oVideo_ai_asset_entity.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oVideo_ai_asset_entity.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oVideo_ai_asset_entity.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oVideo_ai_asset_entity.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oVideo_ai_asset_entity.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FRIENDLY_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.VIDEO_AI_ASSET_ID_REF = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_VIDEO_AI_ASSET_ID_REF");
                        oVideo_ai_asset_entity.Video_ai_asset.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_FUNCTIONAL_NAME");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_X = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_X");
                        oVideo_ai_asset_entity.Video_ai_asset.RESOLUTION_Y = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_RESOLUTION_Y");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset_entity.Video_ai_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_ENTRY_DATE");
                        oVideo_ai_asset_entity.Video_ai_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ASSET_LAST_UPDATE");
                        oVideo_ai_asset_entity.Video_ai_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ASSET_IS_DELETED");
                        oVideo_ai_asset_entity.Video_ai_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ASSET_OWNER_ID");
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_Where_In_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where_In_List_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.FRIENDLY_NAME = FRIENDLY_NAME;
            _params.FUNCTIONAL_NAME = FUNCTIONAL_NAME;
            _params.CONNECTION_URL = CONNECTION_URL;
            _params.USERNAME = USERNAME;
            _params.PASSWORD = PASSWORD;
            _params.VIDEO_AI_ENGINE_ID_LIST = VIDEO_AI_ENGINE_ID_LIST != null ? string.Join(",", VIDEO_AI_ENGINE_ID_LIST) : "";
            _params.CONNECTION_TYPE_SETUP_ID_LIST = CONNECTION_TYPE_SETUP_ID_LIST != null ? string.Join(",", CONNECTION_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        oVideo_ai_instance.Video_ai_engine.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_instance.Video_ai_engine.ENGINE_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENGINE_NAME");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_ENGINE_ENTRY_USER_ID");
                        oVideo_ai_instance.Video_ai_engine.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_ENTRY_DATE");
                        oVideo_ai_instance.Video_ai_engine.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_ENGINE_LAST_UPDATE");
                        oVideo_ai_instance.Video_ai_engine.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_ENGINE_IS_DELETED");
                        oVideo_ai_instance.Video_ai_engine.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_ENGINE_OWNER_ID");
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        oVideo_ai_instance.Connection_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_ID");
                        oVideo_ai_instance.Connection_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oVideo_ai_instance.Connection_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_SYSTEM");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_UPDATEABLE");
                        oVideo_ai_instance.Connection_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_DELETED");
                        oVideo_ai_instance.Connection_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_CONNECTION_TYPE_SETUP_IS_VISIBLE");
                        oVideo_ai_instance.Connection_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_DISPLAY_ORDER");
                        oVideo_ai_instance.Connection_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_VALUE");
                        oVideo_ai_instance.Connection_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_DESCRIPTION");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_USER_ID");
                        oVideo_ai_instance.Connection_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_ENTRY_DATE");
                        oVideo_ai_instance.Connection_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_CONNECTION_TYPE_SETUP_LAST_UPDATE");
                        oVideo_ai_instance.Connection_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_CONNECTION_TYPE_SETUP_OWNER_ID");
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where_In_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where_In_List_Adv(string FRIENDLY_NAME, string FUNCTIONAL_NAME, IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST, IEnumerable<long?> SPACE_ASSET_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.FRIENDLY_NAME = FRIENDLY_NAME;
            _params.FUNCTIONAL_NAME = FUNCTIONAL_NAME;
            _params.VIDEO_AI_INSTANCE_ID_LIST = VIDEO_AI_INSTANCE_ID_LIST != null ? string.Join(",", VIDEO_AI_INSTANCE_ID_LIST) : "";
            _params.SPACE_ASSET_ID_LIST = SPACE_ASSET_ID_LIST != null ? string.Join(",", SPACE_ASSET_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        oVideo_ai_asset.Space_asset.SPACE_ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ASSET_ID");
                        oVideo_ai_asset.Space_asset.SPACE_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_SPACE_ID");
                        oVideo_ai_asset.Space_asset.ASSET_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ASSET_ID");
                        oVideo_ai_asset.Space_asset.EXTERNAL_ID = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_EXTERNAL_ID");
                        oVideo_ai_asset.Space_asset.IS_MERAKI_WIFI_SIGNAL = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_MERAKI_WIFI_SIGNAL");
                        oVideo_ai_asset.Space_asset.CUSTOM_NAME = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_CUSTOM_NAME");
                        oVideo_ai_asset.Space_asset.POSITION_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_X");
                        oVideo_ai_asset.Space_asset.POSITION_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Y");
                        oVideo_ai_asset.Space_asset.POSITION_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_POSITION_Z");
                        oVideo_ai_asset.Space_asset.SCALE_MULTIPLIER = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_SCALE_MULTIPLIER");
                        oVideo_ai_asset.Space_asset.ROTATE_X = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_X");
                        oVideo_ai_asset.Space_asset.ROTATE_Y = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Y");
                        oVideo_ai_asset.Space_asset.ROTATE_Z = Get_Data_Record_Value<decimal?>(element, "T_SPACE_ASSET_ROTATE_Z");
                        oVideo_ai_asset.Space_asset.ASSET_ICON = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ASSET_ICON");
                        oVideo_ai_asset.Space_asset.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SPACE_ASSET_ENTRY_USER_ID");
                        oVideo_ai_asset.Space_asset.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_ENTRY_DATE");
                        oVideo_ai_asset.Space_asset.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SPACE_ASSET_LAST_UPDATE");
                        oVideo_ai_asset.Space_asset.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SPACE_ASSET_IS_DELETED");
                        oVideo_ai_asset.Space_asset.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SPACE_ASSET_OWNER_ID");
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_INSTANCE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_INSTANCE_ID");
                        oVideo_ai_asset.Video_ai_instance.VIDEO_AI_ENGINE_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_VIDEO_AI_ENGINE_ID");
                        oVideo_ai_asset.Video_ai_instance.FRIENDLY_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FRIENDLY_NAME");
                        oVideo_ai_asset.Video_ai_instance.FUNCTIONAL_NAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_FUNCTIONAL_NAME");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_URL = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_URL");
                        oVideo_ai_asset.Video_ai_instance.CONNECTION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_CONNECTION_TYPE_SETUP_ID");
                        oVideo_ai_asset.Video_ai_instance.USERNAME = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_USERNAME");
                        oVideo_ai_asset.Video_ai_instance.PASSWORD = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_PASSWORD");
                        oVideo_ai_asset.Video_ai_instance.IS_LPR = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_LPR");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIDEO_AI_INSTANCE_ENTRY_USER_ID");
                        oVideo_ai_asset.Video_ai_instance.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_ENTRY_DATE");
                        oVideo_ai_asset.Video_ai_instance.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIDEO_AI_INSTANCE_LAST_UPDATE");
                        oVideo_ai_asset.Video_ai_instance.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIDEO_AI_INSTANCE_IS_DELETED");
                        oVideo_ai_asset.Video_ai_instance.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIDEO_AI_INSTANCE_OWNER_ID");
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset;
        }
        #endregion
    }
}