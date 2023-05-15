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
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID
        public Video_ai_search_category Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID(int? VIDEO_AI_SEARCH_CATEGORY_ID)
        {
            Video_ai_search_category oVideo_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_SEARCH_CATEGORY_ID = VIDEO_AI_SEARCH_CATEGORY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_SEARCH_CATEGORY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_search_category = new Video_ai_search_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_search_category);
            }
            return oVideo_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID
        public Video_ai_asset_entity Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID(int? VIDEO_AI_ASSET_ENTITY_ID)
        {
            Video_ai_asset_entity oVideo_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ENTITY_ID = VIDEO_AI_ASSET_ENTITY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ENTITY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_asset_entity = new Video_ai_asset_entity();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_asset_entity);
            }
            return oVideo_ai_asset_entity;
        }
        #endregion
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
        #region Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID
        public Video_ai_engine Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID)
        {
            Video_ai_engine oVideo_ai_engine = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ENGINE_BY_VIDEO_AI_ENGINE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_engine = new Video_ai_engine();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_engine);
            }
            return oVideo_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
        public Video_ai_instance Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(int? VIDEO_AI_INSTANCE_ID)
        {
            Video_ai_instance oVideo_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_INSTANCE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_instance = new Video_ai_instance();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_instance);
            }
            return oVideo_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
        public Video_ai_asset Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(int? VIDEO_AI_ASSET_ID)
        {
            Video_ai_asset oVideo_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oVideo_ai_asset = new Video_ai_asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oVideo_ai_asset);
            }
            return oVideo_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List(IEnumerable<int?> VIDEO_AI_SEARCH_CATEGORY_ID_LIST)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            if (VIDEO_AI_SEARCH_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_SEARCH_CATEGORY_ID_LIST = string.Join(",", VIDEO_AI_SEARCH_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_SEARCH_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_search_category = new List<Video_ai_search_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                            oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                        }
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List(IEnumerable<int?> VIDEO_AI_ASSET_ENTITY_ID_LIST)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            if (VIDEO_AI_ASSET_ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ENTITY_ID_LIST = string.Join(",", VIDEO_AI_ASSET_ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                            oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
            }
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List
        public List<Video_ai_engine> Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            if (VIDEO_AI_ENGINE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ENGINE_ID_LIST = string.Join(",", VIDEO_AI_ENGINE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ENGINE_BY_VIDEO_AI_ENGINE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_engine = new List<Video_ai_engine>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_engine);
                            oList_Video_ai_engine.Add(oVideo_ai_engine);
                        }
                    }
                }
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            if (VIDEO_AI_INSTANCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_INSTANCE_ID_LIST = string.Join(",", VIDEO_AI_INSTANCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_INSTANCE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_instance = new List<Video_ai_instance>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                            oList_Video_ai_instance.Add(oVideo_ai_instance);
                        }
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (VIDEO_AI_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ID_LIST = string.Join(",", VIDEO_AI_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID(int? OWNER_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_ENGINE_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID(int? OWNER_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(int? VIDEO_AI_ASSET_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID(long? ENTITY_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_ENTITY_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_engine_By_OWNER_ID
        public List<Video_ai_engine> Get_Video_ai_engine_By_OWNER_ID(int? OWNER_ID)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ENGINE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_engine_By_OWNER_ID_IS_DELETED
        public List<Video_ai_engine> Get_Video_ai_engine_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ENGINE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID(int? OWNER_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_ENGINE_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(long? CONNECTION_TYPE_SETUP_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.CONNECTION_TYPE_SETUP_ID = CONNECTION_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_CONNECTION_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_IS_DELETED
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID(int? OWNER_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(int? VIDEO_AI_INSTANCE_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_INSTANCE_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ASSET_ID = SPACE_ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_SPACE_ASSET_ID", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_IS_DELETED
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(int? VIDEO_AI_ASSET_ID_REF)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.VIDEO_AI_ASSET_ID_REF = VIDEO_AI_ASSET_ID_REF;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_REF", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            if (VIDEO_AI_ENGINE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ENGINE_ID_LIST = string.Join(",", VIDEO_AI_ENGINE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_ENGINE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_search_category = new List<Video_ai_search_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                            oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                        }
                    }
                }
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List(IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            if (VIDEO_AI_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ID_LIST = string.Join(",", VIDEO_AI_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                            oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                            oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
            }
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List(IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            if (VIDEO_AI_ENGINE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ENGINE_ID_LIST = string.Join(",", VIDEO_AI_ENGINE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_VIDEO_AI_ENGINE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_instance = new List<Video_ai_instance>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                            oList_Video_ai_instance.Add(oVideo_ai_instance);
                        }
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List(IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            if (CONNECTION_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.CONNECTION_TYPE_SETUP_ID_LIST = string.Join(",", CONNECTION_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_CONNECTION_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_instance = new List<Video_ai_instance>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                            oList_Video_ai_instance.Add(oVideo_ai_instance);
                        }
                    }
                }
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List(IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (VIDEO_AI_INSTANCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_INSTANCE_ID_LIST = string.Join(",", VIDEO_AI_INSTANCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_INSTANCE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_List(IEnumerable<long?> SPACE_ASSET_ID_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (SPACE_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ASSET_ID_LIST = string.Join(",", SPACE_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_SPACE_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(IEnumerable<int?> VIDEO_AI_ASSET_ID_REF_LIST)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            if (VIDEO_AI_ASSET_ID_REF_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIDEO_AI_ASSET_ID_REF_LIST = string.Join(",", VIDEO_AI_ASSET_ID_REF_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_REF_LIST", _params);
                if (_query_response != null)
                {
                    oList_Video_ai_asset = new List<Video_ai_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                            oList_Video_ai_asset.Add(oVideo_ai_asset);
                        }
                    }
                }
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where(string CATEGORY_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.CATEGORY_NAME = CATEGORY_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_engine_By_Where
        public List<Video_ai_engine> Get_Video_ai_engine_By_Where(string ENGINE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            dynamic _params = new ExpandoObject();
            _params.ENGINE_NAME = ENGINE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ENGINE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_Where
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where(string FRIENDLY_NAME, string FUNCTIONAL_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            dynamic _params = new ExpandoObject();
            _params.FRIENDLY_NAME = FRIENDLY_NAME;
            _params.FUNCTIONAL_NAME = FUNCTIONAL_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where_In_List
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_In_List(string CATEGORY_NAME, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            dynamic _params = new ExpandoObject();
            _params.CATEGORY_NAME = CATEGORY_NAME;
            _params.VIDEO_AI_ENGINE_ID_LIST = VIDEO_AI_ENGINE_ID_LIST != null ? string.Join(",", VIDEO_AI_ENGINE_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_SEARCH_CATEGORY_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_In_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> VIDEO_AI_ASSET_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_ENTITY_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset_entity;
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
        #region Get_Video_ai_instance_By_Where_In_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where_In_List(string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, string USERNAME, string PASSWORD, IEnumerable<int?> VIDEO_AI_ENGINE_ID_LIST, IEnumerable<long?> CONNECTION_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_INSTANCE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where_In_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where_In_List(string FRIENDLY_NAME, string FUNCTIONAL_NAME, IEnumerable<int?> VIDEO_AI_INSTANCE_ID_LIST, IEnumerable<long?> SPACE_ASSET_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_VIDEO_AI_ASSET_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Video_ai_asset;
        }
        #endregion
        #region Delete_Video_ai_search_category
        public void Delete_Video_ai_search_category(int? VIDEO_AI_SEARCH_CATEGORY_ID)
        {
            var _params = new
            {
                VIDEO_AI_SEARCH_CATEGORY_ID = VIDEO_AI_SEARCH_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_SEARCH_CATEGORY", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_entity
        public void Delete_Video_ai_asset_entity(int? VIDEO_AI_ASSET_ENTITY_ID)
        {
            var _params = new
            {
                VIDEO_AI_ASSET_ENTITY_ID = VIDEO_AI_ASSET_ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_ENTITY", _params);
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
        #region Delete_Video_ai_engine
        public void Delete_Video_ai_engine(int? VIDEO_AI_ENGINE_ID)
        {
            var _params = new
            {
                VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ENGINE", _params);
        }
        #endregion
        #region Delete_Video_ai_instance
        public void Delete_Video_ai_instance(int? VIDEO_AI_INSTANCE_ID)
        {
            var _params = new
            {
                VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_INSTANCE", _params);
        }
        #endregion
        #region Delete_Video_ai_asset
        public void Delete_Video_ai_asset(int? VIDEO_AI_ASSET_ID)
        {
            var _params = new
            {
                VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET", _params);
        }
        #endregion
        #region Delete_Video_ai_search_category_By_OWNER_ID
        public void Delete_Video_ai_search_category_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_SEARCH_CATEGORY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
        public void Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID)
        {
            var _params = new
            {
                VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_SEARCH_CATEGORY_BY_VIDEO_AI_ENGINE_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_SEARCH_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_OWNER_ID
        public void Delete_Video_ai_asset_entity_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_ENTITY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
        public void Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(int? VIDEO_AI_ASSET_ID)
        {
            var _params = new
            {
                VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_ENTITY_BY_VIDEO_AI_ASSET_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_ENTITY_ID
        public void Delete_Video_ai_asset_entity_By_ENTITY_ID(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_ENTITY_BY_ENTITY_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_ENTITY_BY_OWNER_ID_IS_DELETED", _params);
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
        #region Delete_Video_ai_engine_By_OWNER_ID
        public void Delete_Video_ai_engine_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ENGINE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ENGINE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Video_ai_instance_By_OWNER_ID
        public void Delete_Video_ai_instance_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_INSTANCE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
        public void Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(int? VIDEO_AI_ENGINE_ID)
        {
            var _params = new
            {
                VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_INSTANCE_BY_VIDEO_AI_ENGINE_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
        public void Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(long? CONNECTION_TYPE_SETUP_ID)
        {
            var _params = new
            {
                CONNECTION_TYPE_SETUP_ID = CONNECTION_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_INSTANCE_BY_CONNECTION_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_INSTANCE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_By_OWNER_ID
        public void Delete_Video_ai_asset_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
        public void Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(int? VIDEO_AI_INSTANCE_ID)
        {
            var _params = new
            {
                VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_BY_VIDEO_AI_INSTANCE_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_By_SPACE_ASSET_ID
        public void Delete_Video_ai_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID)
        {
            var _params = new
            {
                SPACE_ASSET_ID = SPACE_ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_BY_SPACE_ASSET_ID", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
        public void Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(int? VIDEO_AI_ASSET_ID_REF)
        {
            var _params = new
            {
                VIDEO_AI_ASSET_ID_REF = VIDEO_AI_ASSET_ID_REF
            };
            ExecuteDelete("UPG_DELETE_VIDEO_AI_ASSET_BY_VIDEO_AI_ASSET_ID_REF", _params);
        }
        #endregion
        #region Edit_Video_ai_search_category
        public int? Edit_Video_ai_search_category(int? VIDEO_AI_SEARCH_CATEGORY_ID, int? VIDEO_AI_ENGINE_ID, string CATEGORY_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category()
            {
                VIDEO_AI_SEARCH_CATEGORY_ID = VIDEO_AI_SEARCH_CATEGORY_ID,
                VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID,
                CATEGORY_NAME = CATEGORY_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_VIDEO_AI_SEARCH_CATEGORY", oVideo_ai_search_category, "VIDEO_AI_SEARCH_CATEGORY_ID");
            return oVideo_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID;
        }
        #endregion
        #region Edit_Video_ai_asset_entity
        public int? Edit_Video_ai_asset_entity(int? VIDEO_AI_ASSET_ENTITY_ID, int? VIDEO_AI_ASSET_ID, long? ENTITY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity()
            {
                VIDEO_AI_ASSET_ENTITY_ID = VIDEO_AI_ASSET_ENTITY_ID,
                VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID,
                ENTITY_ID = ENTITY_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_VIDEO_AI_ASSET_ENTITY", oVideo_ai_asset_entity, "VIDEO_AI_ASSET_ENTITY_ID");
            return oVideo_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID;
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
        #region Edit_Video_ai_engine
        public int? Edit_Video_ai_engine(int? VIDEO_AI_ENGINE_ID, string ENGINE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Video_ai_engine oVideo_ai_engine = new Video_ai_engine()
            {
                VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID,
                ENGINE_NAME = ENGINE_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_VIDEO_AI_ENGINE", oVideo_ai_engine, "VIDEO_AI_ENGINE_ID");
            return oVideo_ai_engine.VIDEO_AI_ENGINE_ID;
        }
        #endregion
        #region Edit_Video_ai_instance
        public int? Edit_Video_ai_instance(int? VIDEO_AI_INSTANCE_ID, int? VIDEO_AI_ENGINE_ID, string FRIENDLY_NAME, string FUNCTIONAL_NAME, string CONNECTION_URL, long? CONNECTION_TYPE_SETUP_ID, string USERNAME, string PASSWORD, bool IS_LPR, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Video_ai_instance oVideo_ai_instance = new Video_ai_instance()
            {
                VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID,
                VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID,
                FRIENDLY_NAME = FRIENDLY_NAME,
                FUNCTIONAL_NAME = FUNCTIONAL_NAME,
                CONNECTION_URL = CONNECTION_URL,
                CONNECTION_TYPE_SETUP_ID = CONNECTION_TYPE_SETUP_ID,
                USERNAME = USERNAME,
                PASSWORD = PASSWORD,
                IS_LPR = IS_LPR,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_VIDEO_AI_INSTANCE", oVideo_ai_instance, "VIDEO_AI_INSTANCE_ID");
            return oVideo_ai_instance.VIDEO_AI_INSTANCE_ID;
        }
        #endregion
        #region Edit_Video_ai_asset
        public int? Edit_Video_ai_asset(int? VIDEO_AI_ASSET_ID, int? VIDEO_AI_INSTANCE_ID, long? SPACE_ASSET_ID, string FRIENDLY_NAME, int? VIDEO_AI_ASSET_ID_REF, string FUNCTIONAL_NAME, int? RESOLUTION_X, int? RESOLUTION_Y, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Video_ai_asset oVideo_ai_asset = new Video_ai_asset()
            {
                VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID,
                VIDEO_AI_INSTANCE_ID = VIDEO_AI_INSTANCE_ID,
                SPACE_ASSET_ID = SPACE_ASSET_ID,
                FRIENDLY_NAME = FRIENDLY_NAME,
                VIDEO_AI_ASSET_ID_REF = VIDEO_AI_ASSET_ID_REF,
                FUNCTIONAL_NAME = FUNCTIONAL_NAME,
                RESOLUTION_X = RESOLUTION_X,
                RESOLUTION_Y = RESOLUTION_Y,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_VIDEO_AI_ASSET", oVideo_ai_asset, "VIDEO_AI_ASSET_ID");
            return oVideo_ai_asset.VIDEO_AI_ASSET_ID;
        }
        #endregion
    }
}
