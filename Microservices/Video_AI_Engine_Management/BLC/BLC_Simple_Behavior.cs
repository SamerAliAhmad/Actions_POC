using System;
using System.Linq;
using SmartrTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Members
        #region Used For Delete Operations
        private Video_ai_search_category _Video_ai_search_category;
        private List<Video_ai_search_category> _List_Video_ai_search_category;
        private Video_ai_asset_entity _Video_ai_asset_entity;
        private List<Video_ai_asset_entity> _List_Video_ai_asset_entity;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Video_ai_engine _Video_ai_engine;
        private List<Video_ai_engine> _List_Video_ai_engine;
        private Video_ai_instance _Video_ai_instance;
        private List<Video_ai_instance> _List_Video_ai_instance;
        private Video_ai_asset _Video_ai_asset;
        private List<Video_ai_asset> _List_Video_ai_asset;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Video_ai_search_category_Execution;
        private bool _Stop_Delete_Video_ai_search_category_Execution;
        private bool _Stop_Edit_Video_ai_asset_entity_Execution;
        private bool _Stop_Delete_Video_ai_asset_entity_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Video_ai_engine_Execution;
        private bool _Stop_Delete_Video_ai_engine_Execution;
        private bool _Stop_Edit_Video_ai_instance_Execution;
        private bool _Stop_Delete_Video_ai_instance_Execution;
        private bool _Stop_Edit_Video_ai_asset_Execution;
        private bool _Stop_Delete_Video_ai_asset_Execution;
        #endregion
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID
        public Video_ai_search_category Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID(Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID)
        {
            Video_ai_search_category oVideo_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_search_category oDBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID.VIDEO_AI_SEARCH_CATEGORY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_search_category").Replace("%2", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID.VIDEO_AI_SEARCH_CATEGORY_ID.ToString()));
            }
            oVideo_ai_search_category = new Video_ai_search_category();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_json, false);
            }
            return oVideo_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID
        public Video_ai_asset_entity Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID)
        {
            Video_ai_asset_entity oVideo_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_asset_entity oDBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID.VIDEO_AI_ASSET_ENTITY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_asset_entity").Replace("%2", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID.VIDEO_AI_ASSET_ENTITY_ID.ToString()));
            }
            oVideo_ai_asset_entity = new Video_ai_asset_entity();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_json, false);
            }
            return oVideo_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup_category").Replace("%2", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID.ToString()));
            }
            oSetup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID
        public Video_ai_engine Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID(Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID)
        {
            Video_ai_engine oVideo_ai_engine = null;
            var i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID", i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_engine oDBEntry = _AppContext.Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID(i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_engine").Replace("%2", i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID.ToString()));
            }
            oVideo_ai_engine = new Video_ai_engine();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_engine);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID", i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            return oVideo_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
        public Video_ai_instance Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID)
        {
            Video_ai_instance oVideo_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_instance oDBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_instance").Replace("%2", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID.ToString()));
            }
            oVideo_ai_instance = new Video_ai_instance();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            return oVideo_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
        public Video_ai_asset Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID)
        {
            Video_ai_asset oVideo_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_asset oDBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_asset").Replace("%2", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID.ToString()));
            }
            oVideo_ai_asset = new Video_ai_asset();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_json, false);
            }
            return oVideo_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List(Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List.VIDEO_AI_SEARCH_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List.VIDEO_AI_ASSET_ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List
        public List<Video_ai_engine> Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List(Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            var i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List", i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_engine> oList_DBEntry = _AppContext.Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List(i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List.VIDEO_AI_ENGINE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List", i_Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List(Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List.VIDEO_AI_INSTANCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List.VIDEO_AI_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID(Params_Get_Video_ai_search_category_By_OWNER_ID i_Params_Get_Video_ai_search_category_By_OWNER_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_OWNER_ID", i_Params_Get_Video_ai_search_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_OWNER_ID(i_Params_Get_Video_ai_search_category_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_OWNER_ID", i_Params_Get_Video_ai_search_category_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED(Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED(i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID(Params_Get_Video_ai_asset_entity_By_OWNER_ID i_Params_Get_Video_ai_asset_entity_By_OWNER_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_OWNER_ID(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID(Params_Get_Video_ai_asset_entity_By_ENTITY_ID i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_ENTITY_ID(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_OWNER_ID(oList_Setup_category, i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(Params_Get_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oSetup_category, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_engine_By_OWNER_ID
        public List<Video_ai_engine> Get_Video_ai_engine_By_OWNER_ID(Params_Get_Video_ai_engine_By_OWNER_ID i_Params_Get_Video_ai_engine_By_OWNER_ID)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            var i_Params_Get_Video_ai_engine_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_engine_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_engine_By_OWNER_ID", i_Params_Get_Video_ai_engine_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Video_ai_engine_By_OWNER_ID
            if (OnPreEvent_Get_Video_ai_engine_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Video_ai_engine_By_OWNER_ID(i_Params_Get_Video_ai_engine_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Video_ai_engine> oList_DBEntry = _AppContext.Get_Video_ai_engine_By_OWNER_ID(i_Params_Get_Video_ai_engine_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Video_ai_engine_By_OWNER_ID
            if (OnPostEvent_Get_Video_ai_engine_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Video_ai_engine_By_OWNER_ID(oList_Video_ai_engine, i_Params_Get_Video_ai_engine_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_engine_By_OWNER_ID", i_Params_Get_Video_ai_engine_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_engine_By_OWNER_ID_IS_DELETED
        public List<Video_ai_engine> Get_Video_ai_engine_By_OWNER_ID_IS_DELETED(Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_engine> oList_Video_ai_engine = null;
            var i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_engine_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_engine> oList_DBEntry = _AppContext.Get_Video_ai_engine_By_OWNER_ID_IS_DELETED(i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_engine_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID(Params_Get_Video_ai_instance_By_OWNER_ID i_Params_Get_Video_ai_instance_By_OWNER_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_OWNER_ID", i_Params_Get_Video_ai_instance_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_OWNER_ID(i_Params_Get_Video_ai_instance_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_OWNER_ID", i_Params_Get_Video_ai_instance_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID.CONNECTION_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_IS_DELETED
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_IS_DELETED(Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_OWNER_ID_IS_DELETED(i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID(Params_Get_Video_ai_asset_By_OWNER_ID i_Params_Get_Video_ai_asset_By_OWNER_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_OWNER_ID", i_Params_Get_Video_ai_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_OWNER_ID(i_Params_Get_Video_ai_asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_OWNER_ID", i_Params_Get_Video_ai_asset_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_SPACE_ASSET_ID(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_IS_DELETED
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_IS_DELETED(Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_OWNER_ID_IS_DELETED(i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF.VIDEO_AI_ASSET_ID_REF);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List(Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List.VIDEO_AI_ENGINE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List.VIDEO_AI_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_List(Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID_List", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_ENTITY_ID_List(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID_List", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List(Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List.VIDEO_AI_ENGINE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List(Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List.CONNECTION_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List(Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List.VIDEO_AI_INSTANCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_List(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID_List", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_SPACE_ASSET_ID_List(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID_List", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.VIDEO_AI_ASSET_ID_REF_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where(Params_Get_Video_ai_search_category_By_Where i_Params_Get_Video_ai_search_category_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_Where", i_Params_Get_Video_ai_search_category_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_search_category_By_Where.OWNER_ID == null || i_Params_Get_Video_ai_search_category_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_search_category_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_search_category_By_Where.OFFSET == null)
            {
                i_Params_Get_Video_ai_search_category_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_search_category_By_Where.FETCH_NEXT == null || i_Params_Get_Video_ai_search_category_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_search_category_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_Where(i_Params_Get_Video_ai_search_category_By_Where.CATEGORY_NAME, i_Params_Get_Video_ai_search_category_By_Where.OWNER_ID, i_Params_Get_Video_ai_search_category_By_Where.OFFSET, i_Params_Get_Video_ai_search_category_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            i_Params_Get_Video_ai_search_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_Where", i_Params_Get_Video_ai_search_category_By_Where_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where(Params_Get_Video_ai_asset_entity_By_Where i_Params_Get_Video_ai_asset_entity_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_Where", i_Params_Get_Video_ai_asset_entity_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_asset_entity_By_Where.OWNER_ID == null || i_Params_Get_Video_ai_asset_entity_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_asset_entity_By_Where.OFFSET == null)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_asset_entity_By_Where.FETCH_NEXT == null || i_Params_Get_Video_ai_asset_entity_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_Where(i_Params_Get_Video_ai_asset_entity_By_Where.DESCRIPTION, i_Params_Get_Video_ai_asset_entity_By_Where.OWNER_ID, i_Params_Get_Video_ai_asset_entity_By_Where.OFFSET, i_Params_Get_Video_ai_asset_entity_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_entity_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_Where", i_Params_Get_Video_ai_asset_entity_By_Where_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(Params_Get_Setup_category_By_Where i_Params_Get_Setup_category_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_category_By_Where.OWNER_ID == null || i_Params_Get_Setup_category_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_category_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_category_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_category_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_category_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_category_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_category_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_Where(i_Params_Get_Setup_category_By_Where.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_Where.DESCRIPTION, i_Params_Get_Setup_category_By_Where.OWNER_ID, i_Params_Get_Setup_category_By_Where.OFFSET, i_Params_Get_Setup_category_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            i_Params_Get_Setup_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where.OWNER_ID == null || i_Params_Get_Setup_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_engine_By_Where
        public List<Video_ai_engine> Get_Video_ai_engine_By_Where(Params_Get_Video_ai_engine_By_Where i_Params_Get_Video_ai_engine_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_engine> oList_Video_ai_engine = null;
            var i_Params_Get_Video_ai_engine_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_engine_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_engine_By_Where", i_Params_Get_Video_ai_engine_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_engine_By_Where.OWNER_ID == null || i_Params_Get_Video_ai_engine_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_engine_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_engine_By_Where.OFFSET == null)
            {
                i_Params_Get_Video_ai_engine_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_engine_By_Where.FETCH_NEXT == null || i_Params_Get_Video_ai_engine_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_engine_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Video_ai_engine> oList_DBEntry = _AppContext.Get_Video_ai_engine_By_Where(i_Params_Get_Video_ai_engine_By_Where.ENGINE_NAME, i_Params_Get_Video_ai_engine_By_Where.OWNER_ID, i_Params_Get_Video_ai_engine_By_Where.OFFSET, i_Params_Get_Video_ai_engine_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_engine = new List<Video_ai_engine>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_engine oVideo_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_engine);
                        oList_Video_ai_engine.Add(oVideo_ai_engine);
                    }
                }
            }
            i_Params_Get_Video_ai_engine_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_engine_By_Where", i_Params_Get_Video_ai_engine_By_Where_json, false);
            }
            return oList_Video_ai_engine;
        }
        #endregion
        #region Get_Video_ai_instance_By_Where
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where(Params_Get_Video_ai_instance_By_Where i_Params_Get_Video_ai_instance_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_Where", i_Params_Get_Video_ai_instance_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_instance_By_Where.OWNER_ID == null || i_Params_Get_Video_ai_instance_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_instance_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_instance_By_Where.OFFSET == null)
            {
                i_Params_Get_Video_ai_instance_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_instance_By_Where.FETCH_NEXT == null || i_Params_Get_Video_ai_instance_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_instance_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_Where(i_Params_Get_Video_ai_instance_By_Where.FRIENDLY_NAME, i_Params_Get_Video_ai_instance_By_Where.FUNCTIONAL_NAME, i_Params_Get_Video_ai_instance_By_Where.CONNECTION_URL, i_Params_Get_Video_ai_instance_By_Where.USERNAME, i_Params_Get_Video_ai_instance_By_Where.PASSWORD, i_Params_Get_Video_ai_instance_By_Where.OWNER_ID, i_Params_Get_Video_ai_instance_By_Where.OFFSET, i_Params_Get_Video_ai_instance_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            i_Params_Get_Video_ai_instance_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_Where", i_Params_Get_Video_ai_instance_By_Where_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where(Params_Get_Video_ai_asset_By_Where i_Params_Get_Video_ai_asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_Where", i_Params_Get_Video_ai_asset_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_asset_By_Where.OWNER_ID == null || i_Params_Get_Video_ai_asset_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_asset_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_asset_By_Where.OFFSET == null)
            {
                i_Params_Get_Video_ai_asset_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_asset_By_Where.FETCH_NEXT == null || i_Params_Get_Video_ai_asset_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_asset_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_Where(i_Params_Get_Video_ai_asset_By_Where.FRIENDLY_NAME, i_Params_Get_Video_ai_asset_By_Where.FUNCTIONAL_NAME, i_Params_Get_Video_ai_asset_By_Where.OWNER_ID, i_Params_Get_Video_ai_asset_By_Where.OFFSET, i_Params_Get_Video_ai_asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_Where", i_Params_Get_Video_ai_asset_By_Where_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where_In_List
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_In_List(Params_Get_Video_ai_search_category_By_Where_In_List i_Params_Get_Video_ai_search_category_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_Where_In_List", i_Params_Get_Video_ai_search_category_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_search_category_By_Where_In_List.OWNER_ID == null || i_Params_Get_Video_ai_search_category_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_search_category_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_search_category_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Video_ai_search_category_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_search_category_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Video_ai_search_category_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_search_category_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Video_ai_search_category_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST == null)
            {
                i_Params_Get_Video_ai_search_category_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST = new List<int?>();
            }
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_Where_In_List(i_Params_Get_Video_ai_search_category_By_Where_In_List.CATEGORY_NAME, i_Params_Get_Video_ai_search_category_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST, i_Params_Get_Video_ai_search_category_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_search_category_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_search_category_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            i_Params_Get_Video_ai_search_category_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_Where_In_List", i_Params_Get_Video_ai_search_category_By_Where_In_List_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_In_List
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_In_List(Params_Get_Video_ai_asset_entity_By_Where_In_List i_Params_Get_Video_ai_asset_entity_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_Where_In_List", i_Params_Get_Video_ai_asset_entity_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OWNER_ID == null || i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_asset_entity_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Video_ai_asset_entity_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Video_ai_asset_entity_By_Where_In_List.VIDEO_AI_ASSET_ID_LIST == null)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where_In_List.VIDEO_AI_ASSET_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Video_ai_asset_entity_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Video_ai_asset_entity_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_Where_In_List(i_Params_Get_Video_ai_asset_entity_By_Where_In_List.DESCRIPTION, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.VIDEO_AI_ASSET_ID_LIST, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_entity_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_Where_In_List", i_Params_Get_Video_ai_asset_entity_By_Where_In_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where_In_List.OWNER_ID == null || i_Params_Get_Setup_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST == null)
            {
                i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST = new List<int?>();
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_Where_In_List
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where_In_List(Params_Get_Video_ai_instance_By_Where_In_List i_Params_Get_Video_ai_instance_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_Where_In_List", i_Params_Get_Video_ai_instance_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_instance_By_Where_In_List.OWNER_ID == null || i_Params_Get_Video_ai_instance_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_instance_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_instance_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Video_ai_instance_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_instance_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Video_ai_instance_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_instance_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Video_ai_instance_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST == null)
            {
                i_Params_Get_Video_ai_instance_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Video_ai_instance_By_Where_In_List.CONNECTION_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Video_ai_instance_By_Where_In_List.CONNECTION_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_Where_In_List(i_Params_Get_Video_ai_instance_By_Where_In_List.FRIENDLY_NAME, i_Params_Get_Video_ai_instance_By_Where_In_List.FUNCTIONAL_NAME, i_Params_Get_Video_ai_instance_By_Where_In_List.CONNECTION_URL, i_Params_Get_Video_ai_instance_By_Where_In_List.USERNAME, i_Params_Get_Video_ai_instance_By_Where_In_List.PASSWORD, i_Params_Get_Video_ai_instance_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST, i_Params_Get_Video_ai_instance_By_Where_In_List.CONNECTION_TYPE_SETUP_ID_LIST, i_Params_Get_Video_ai_instance_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_instance_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_instance_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            i_Params_Get_Video_ai_instance_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_Where_In_List", i_Params_Get_Video_ai_instance_By_Where_In_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where_In_List
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where_In_List(Params_Get_Video_ai_asset_By_Where_In_List i_Params_Get_Video_ai_asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_Where_In_List", i_Params_Get_Video_ai_asset_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Video_ai_asset_By_Where_In_List.OWNER_ID == null || i_Params_Get_Video_ai_asset_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Video_ai_asset_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Video_ai_asset_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Video_ai_asset_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Video_ai_asset_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Video_ai_asset_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Video_ai_asset_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Video_ai_asset_By_Where_In_List.VIDEO_AI_INSTANCE_ID_LIST == null)
            {
                i_Params_Get_Video_ai_asset_By_Where_In_List.VIDEO_AI_INSTANCE_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Video_ai_asset_By_Where_In_List.SPACE_ASSET_ID_LIST == null)
            {
                i_Params_Get_Video_ai_asset_By_Where_In_List.SPACE_ASSET_ID_LIST = new List<long?>();
            }
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_Where_In_List(i_Params_Get_Video_ai_asset_By_Where_In_List.FRIENDLY_NAME, i_Params_Get_Video_ai_asset_By_Where_In_List.FUNCTIONAL_NAME, i_Params_Get_Video_ai_asset_By_Where_In_List.VIDEO_AI_INSTANCE_ID_LIST, i_Params_Get_Video_ai_asset_By_Where_In_List.SPACE_ASSET_ID_LIST, i_Params_Get_Video_ai_asset_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_asset_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_Where_In_List", i_Params_Get_Video_ai_asset_By_Where_In_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Delete_Video_ai_search_category
        public void Delete_Video_ai_search_category(Params_Delete_Video_ai_search_category i_Params_Delete_Video_ai_search_category)
        {
            var i_Params_Delete_Video_ai_search_category_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_search_category);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_search_category", i_Params_Delete_Video_ai_search_category_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID oParams_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID = new Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID
                {
                    VIDEO_AI_SEARCH_CATEGORY_ID = i_Params_Delete_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID
                };
                _Video_ai_search_category = Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID(oParams_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID);
                if (_Video_ai_search_category != null)
                {
                    if (_Stop_Delete_Video_ai_search_category_Execution)
                    {
                        _Stop_Delete_Video_ai_search_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_search_category(i_Params_Delete_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_search_category", i_Params_Delete_Video_ai_search_category_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_entity
        public void Delete_Video_ai_asset_entity(Params_Delete_Video_ai_asset_entity i_Params_Delete_Video_ai_asset_entity)
        {
            var i_Params_Delete_Video_ai_asset_entity_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_entity);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_entity", i_Params_Delete_Video_ai_asset_entity_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID oParams_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID = new Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID
                {
                    VIDEO_AI_ASSET_ENTITY_ID = i_Params_Delete_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID
                };
                _Video_ai_asset_entity = Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID(oParams_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID);
                if (_Video_ai_asset_entity != null)
                {
                    if (_Stop_Delete_Video_ai_asset_entity_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_entity(i_Params_Delete_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_entity", i_Params_Delete_Video_ai_asset_entity_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
        {
            var i_Params_Delete_Setup_category_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_category.SETUP_CATEGORY_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category(i_Params_Delete_Setup_category.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
        {
            var i_Params_Delete_Setup_json = JsonConvert.SerializeObject(i_Params_Delete_Setup);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_ID oParams_Get_Setup_By_SETUP_ID = new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Params_Delete_Setup.SETUP_ID
                };
                _Setup = Get_Setup_By_SETUP_ID(oParams_Get_Setup_By_SETUP_ID);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup(i_Params_Delete_Setup.SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_engine
        public void Delete_Video_ai_engine(Params_Delete_Video_ai_engine i_Params_Delete_Video_ai_engine)
        {
            var i_Params_Delete_Video_ai_engine_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_engine);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_engine", i_Params_Delete_Video_ai_engine_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID oParams_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID = new Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID
                {
                    VIDEO_AI_ENGINE_ID = i_Params_Delete_Video_ai_engine.VIDEO_AI_ENGINE_ID
                };
                _Video_ai_engine = Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID(oParams_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID);
                if (_Video_ai_engine != null)
                {
                    if (_Stop_Delete_Video_ai_engine_Execution)
                    {
                        _Stop_Delete_Video_ai_engine_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_engine(i_Params_Delete_Video_ai_engine.VIDEO_AI_ENGINE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_engine", i_Params_Delete_Video_ai_engine_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_instance
        public void Delete_Video_ai_instance(Params_Delete_Video_ai_instance i_Params_Delete_Video_ai_instance)
        {
            var i_Params_Delete_Video_ai_instance_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_instance);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_instance", i_Params_Delete_Video_ai_instance_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
                {
                    VIDEO_AI_INSTANCE_ID = i_Params_Delete_Video_ai_instance.VIDEO_AI_INSTANCE_ID
                };
                _Video_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID);
                if (_Video_ai_instance != null)
                {
                    if (_Stop_Delete_Video_ai_instance_Execution)
                    {
                        _Stop_Delete_Video_ai_instance_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_instance(i_Params_Delete_Video_ai_instance.VIDEO_AI_INSTANCE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_instance", i_Params_Delete_Video_ai_instance_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset
        public void Delete_Video_ai_asset(Params_Delete_Video_ai_asset i_Params_Delete_Video_ai_asset)
        {
            var i_Params_Delete_Video_ai_asset_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset", i_Params_Delete_Video_ai_asset_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID = new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
                {
                    VIDEO_AI_ASSET_ID = i_Params_Delete_Video_ai_asset.VIDEO_AI_ASSET_ID
                };
                _Video_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID);
                if (_Video_ai_asset != null)
                {
                    if (_Stop_Delete_Video_ai_asset_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset(i_Params_Delete_Video_ai_asset.VIDEO_AI_ASSET_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset", i_Params_Delete_Video_ai_asset_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_search_category_By_OWNER_ID
        public void Delete_Video_ai_search_category_By_OWNER_ID(Params_Delete_Video_ai_search_category_By_OWNER_ID i_Params_Delete_Video_ai_search_category_By_OWNER_ID)
        {
            var i_Params_Delete_Video_ai_search_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_search_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_search_category_By_OWNER_ID", i_Params_Delete_Video_ai_search_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_search_category_By_OWNER_ID oParams_Get_Video_ai_search_category_By_OWNER_ID = new Params_Get_Video_ai_search_category_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Video_ai_search_category_By_OWNER_ID.OWNER_ID
                };
                _List_Video_ai_search_category = Get_Video_ai_search_category_By_OWNER_ID(oParams_Get_Video_ai_search_category_By_OWNER_ID);
                if (_List_Video_ai_search_category != null && _List_Video_ai_search_category.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_search_category_Execution)
                    {
                        _Stop_Delete_Video_ai_search_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_search_category_By_OWNER_ID(i_Params_Delete_Video_ai_search_category_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_search_category_By_OWNER_ID", i_Params_Delete_Video_ai_search_category_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
        public void Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID)
        {
            var i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID", i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID oParams_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID = new Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID
                {
                    VIDEO_AI_ENGINE_ID = i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID
                };
                _List_Video_ai_search_category = Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(oParams_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID);
                if (_List_Video_ai_search_category != null && _List_Video_ai_search_category.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_search_category_Execution)
                    {
                        _Stop_Delete_Video_ai_search_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID(i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID", i_Params_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED(Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED oParams_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED = new Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Video_ai_search_category = Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED(oParams_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED);
                if (_List_Video_ai_search_category != null && _List_Video_ai_search_category.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_search_category_Execution)
                    {
                        _Stop_Delete_Video_ai_search_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED(i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_OWNER_ID
        public void Delete_Video_ai_asset_entity_By_OWNER_ID(Params_Delete_Video_ai_asset_entity_By_OWNER_ID i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID)
        {
            var i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_entity_By_OWNER_ID", i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_entity_By_OWNER_ID oParams_Get_Video_ai_asset_entity_By_OWNER_ID = new Params_Get_Video_ai_asset_entity_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID.OWNER_ID
                };
                _List_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_OWNER_ID(oParams_Get_Video_ai_asset_entity_By_OWNER_ID);
                if (_List_Video_ai_asset_entity != null && _List_Video_ai_asset_entity.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_entity_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_entity_By_OWNER_ID(i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_entity_By_OWNER_ID", i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
        public void Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID)
        {
            var i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID", i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID oParams_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID = new Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID
                {
                    VIDEO_AI_ASSET_ID = i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID
                };
                _List_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(oParams_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID);
                if (_List_Video_ai_asset_entity != null && _List_Video_ai_asset_entity.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_entity_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID", i_Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_ENTITY_ID
        public void Delete_Video_ai_asset_entity_By_ENTITY_ID(Params_Delete_Video_ai_asset_entity_By_ENTITY_ID i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID)
        {
            var i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_entity_By_ENTITY_ID", i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_entity_By_ENTITY_ID oParams_Get_Video_ai_asset_entity_By_ENTITY_ID = new Params_Get_Video_ai_asset_entity_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID.ENTITY_ID
                };
                _List_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_ENTITY_ID(oParams_Get_Video_ai_asset_entity_By_ENTITY_ID);
                if (_List_Video_ai_asset_entity != null && _List_Video_ai_asset_entity.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_entity_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_entity_By_ENTITY_ID(i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID.ENTITY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_entity_By_ENTITY_ID", i_Params_Delete_Video_ai_asset_entity_By_ENTITY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED oParams_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED = new Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(oParams_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED);
                if (_List_Video_ai_asset_entity != null && _List_Video_ai_asset_entity.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_entity_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED(i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(Params_Delete_Setup_category_By_OWNER_ID i_Params_Delete_Setup_category_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID oParams_Get_Setup_category_By_OWNER_ID = new Params_Get_Setup_category_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID(oParams_Get_Setup_category_By_OWNER_ID);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID(i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID_IS_DELETED oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
                {
                    SETUP_CATEGORY_NAME = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME,
                    OWNER_ID = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID_IS_DELETED oParams_Get_Setup_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup = Get_Setup_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_By_OWNER_ID_IS_DELETED);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID oParams_Get_Setup_By_SETUP_CATEGORY_ID = new Params_Get_Setup_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID
                };
                _List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(oParams_Get_Setup_By_SETUP_CATEGORY_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE = new Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID,
                    VALUE = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE
                };
                _Setup = Get_Setup_By_SETUP_CATEGORY_ID_VALUE(oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(Params_Delete_Setup_By_OWNER_ID i_Params_Delete_Setup_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID oParams_Get_Setup_By_OWNER_ID = new Params_Get_Setup_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID
                };
                _List_Setup = Get_Setup_By_OWNER_ID(oParams_Get_Setup_By_OWNER_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID(i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_engine_By_OWNER_ID
        public void Delete_Video_ai_engine_By_OWNER_ID(Params_Delete_Video_ai_engine_By_OWNER_ID i_Params_Delete_Video_ai_engine_By_OWNER_ID)
        {
            var i_Params_Delete_Video_ai_engine_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_engine_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_engine_By_OWNER_ID", i_Params_Delete_Video_ai_engine_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_engine_By_OWNER_ID oParams_Get_Video_ai_engine_By_OWNER_ID = new Params_Get_Video_ai_engine_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Video_ai_engine_By_OWNER_ID.OWNER_ID
                };
                _List_Video_ai_engine = Get_Video_ai_engine_By_OWNER_ID(oParams_Get_Video_ai_engine_By_OWNER_ID);
                if (_List_Video_ai_engine != null && _List_Video_ai_engine.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_engine_Execution)
                    {
                        _Stop_Delete_Video_ai_engine_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_engine_By_OWNER_ID(i_Params_Delete_Video_ai_engine_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_engine_By_OWNER_ID", i_Params_Delete_Video_ai_engine_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED(Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED oParams_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED = new Params_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Video_ai_engine = Get_Video_ai_engine_By_OWNER_ID_IS_DELETED(oParams_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED);
                if (_List_Video_ai_engine != null && _List_Video_ai_engine.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_engine_Execution)
                    {
                        _Stop_Delete_Video_ai_engine_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED(i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_instance_By_OWNER_ID
        public void Delete_Video_ai_instance_By_OWNER_ID(Params_Delete_Video_ai_instance_By_OWNER_ID i_Params_Delete_Video_ai_instance_By_OWNER_ID)
        {
            var i_Params_Delete_Video_ai_instance_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_instance_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_instance_By_OWNER_ID", i_Params_Delete_Video_ai_instance_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_instance_By_OWNER_ID oParams_Get_Video_ai_instance_By_OWNER_ID = new Params_Get_Video_ai_instance_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Video_ai_instance_By_OWNER_ID.OWNER_ID
                };
                _List_Video_ai_instance = Get_Video_ai_instance_By_OWNER_ID(oParams_Get_Video_ai_instance_By_OWNER_ID);
                if (_List_Video_ai_instance != null && _List_Video_ai_instance.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_instance_Execution)
                    {
                        _Stop_Delete_Video_ai_instance_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_instance_By_OWNER_ID(i_Params_Delete_Video_ai_instance_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_instance_By_OWNER_ID", i_Params_Delete_Video_ai_instance_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
        public void Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID)
        {
            var i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID", i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID = new Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
                {
                    VIDEO_AI_ENGINE_ID = i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID
                };
                _List_Video_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID);
                if (_List_Video_ai_instance != null && _List_Video_ai_instance.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_instance_Execution)
                    {
                        _Stop_Delete_Video_ai_instance_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID", i_Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
        public void Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID", i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID oParams_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID = new Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID
                {
                    CONNECTION_TYPE_SETUP_ID = i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID.CONNECTION_TYPE_SETUP_ID
                };
                _List_Video_ai_instance = Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(oParams_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID);
                if (_List_Video_ai_instance != null && _List_Video_ai_instance.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_instance_Execution)
                    {
                        _Stop_Delete_Video_ai_instance_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID(i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID.CONNECTION_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID", i_Params_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED(Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED oParams_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED = new Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Video_ai_instance = Get_Video_ai_instance_By_OWNER_ID_IS_DELETED(oParams_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED);
                if (_List_Video_ai_instance != null && _List_Video_ai_instance.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_instance_Execution)
                    {
                        _Stop_Delete_Video_ai_instance_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED(i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_By_OWNER_ID
        public void Delete_Video_ai_asset_By_OWNER_ID(Params_Delete_Video_ai_asset_By_OWNER_ID i_Params_Delete_Video_ai_asset_By_OWNER_ID)
        {
            var i_Params_Delete_Video_ai_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_By_OWNER_ID", i_Params_Delete_Video_ai_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_By_OWNER_ID oParams_Get_Video_ai_asset_By_OWNER_ID = new Params_Get_Video_ai_asset_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Video_ai_asset_By_OWNER_ID.OWNER_ID
                };
                _List_Video_ai_asset = Get_Video_ai_asset_By_OWNER_ID(oParams_Get_Video_ai_asset_By_OWNER_ID);
                if (_List_Video_ai_asset != null && _List_Video_ai_asset.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_By_OWNER_ID(i_Params_Delete_Video_ai_asset_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_By_OWNER_ID", i_Params_Delete_Video_ai_asset_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
        public void Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID)
        {
            var i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID", i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID oParams_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID = new Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID
                {
                    VIDEO_AI_INSTANCE_ID = i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID
                };
                _List_Video_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(oParams_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID);
                if (_List_Video_ai_asset != null && _List_Video_ai_asset.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID(i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID", i_Params_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_By_SPACE_ASSET_ID
        public void Delete_Video_ai_asset_By_SPACE_ASSET_ID(Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID)
        {
            var i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_By_SPACE_ASSET_ID", i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_By_SPACE_ASSET_ID oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID = new Params_Get_Video_ai_asset_By_SPACE_ASSET_ID
                {
                    SPACE_ASSET_ID = i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID
                };
                _List_Video_ai_asset = Get_Video_ai_asset_By_SPACE_ASSET_ID(oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID);
                if (_List_Video_ai_asset != null && _List_Video_ai_asset.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_By_SPACE_ASSET_ID(i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_By_SPACE_ASSET_ID", i_Params_Delete_Video_ai_asset_By_SPACE_ASSET_ID_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED
        public void Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED(Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED oParams_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED = new Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Video_ai_asset = Get_Video_ai_asset_By_OWNER_ID_IS_DELETED(oParams_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED);
                if (_List_Video_ai_asset != null && _List_Video_ai_asset.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED(i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
        public void Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF)
        {
            var i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json = JsonConvert.SerializeObject(i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF", i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF = new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF
                {
                    VIDEO_AI_ASSET_ID_REF = i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF.VIDEO_AI_ASSET_ID_REF
                };
                _List_Video_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF);
                if (_List_Video_ai_asset != null && _List_Video_ai_asset.Count > 0)
                {
                    if (_Stop_Delete_Video_ai_asset_Execution)
                    {
                        _Stop_Delete_Video_ai_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF(i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF.VIDEO_AI_ASSET_ID_REF);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF", i_Params_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_search_category
        public void Edit_Video_ai_search_category(Video_ai_search_category i_Video_ai_search_category)
        {
            var i_Video_ai_search_category_json = JsonConvert.SerializeObject(i_Video_ai_search_category);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_search_category", i_Video_ai_search_category_json, false);
            }
            #region Body Section.
            if (i_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID == null || i_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Video_ai_search_category");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Video_ai_search_category.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Video_ai_search_category.IS_DELETED = false;
            }
            else
            {
                _Video_ai_search_category = Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID(new Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID
                {
                    VIDEO_AI_SEARCH_CATEGORY_ID = i_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID
                });
            }
            i_Video_ai_search_category.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Video_ai_search_category.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Video_ai_search_category.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Video_ai_search_category_Execution)
            {
                _Stop_Edit_Video_ai_search_category_Execution = false;
                return;
            }
            i_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID = _AppContext.Edit_Video_ai_search_category
            (
                i_Video_ai_search_category.VIDEO_AI_SEARCH_CATEGORY_ID,
                i_Video_ai_search_category.VIDEO_AI_ENGINE_ID,
                i_Video_ai_search_category.CATEGORY_NAME,
                i_Video_ai_search_category.ENTRY_USER_ID,
                i_Video_ai_search_category.ENTRY_DATE,
                i_Video_ai_search_category.LAST_UPDATE,
                i_Video_ai_search_category.IS_DELETED,
                i_Video_ai_search_category.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_search_category", i_Video_ai_search_category_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_asset_entity
        public void Edit_Video_ai_asset_entity(Video_ai_asset_entity i_Video_ai_asset_entity)
        {
            var i_Video_ai_asset_entity_json = JsonConvert.SerializeObject(i_Video_ai_asset_entity);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_asset_entity", i_Video_ai_asset_entity_json, false);
            }
            #region Body Section.
            if (i_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID == null || i_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Video_ai_asset_entity");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Video_ai_asset_entity.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Video_ai_asset_entity.IS_DELETED = false;
            }
            else
            {
                _Video_ai_asset_entity = Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID(new Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID
                {
                    VIDEO_AI_ASSET_ENTITY_ID = i_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID
                });
            }
            i_Video_ai_asset_entity.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Video_ai_asset_entity.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Video_ai_asset_entity.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Video_ai_asset_entity_Execution)
            {
                _Stop_Edit_Video_ai_asset_entity_Execution = false;
                return;
            }
            i_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID = _AppContext.Edit_Video_ai_asset_entity
            (
                i_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID,
                i_Video_ai_asset_entity.VIDEO_AI_ASSET_ID,
                i_Video_ai_asset_entity.ENTITY_ID,
                i_Video_ai_asset_entity.ENTRY_USER_ID,
                i_Video_ai_asset_entity.ENTRY_DATE,
                i_Video_ai_asset_entity.LAST_UPDATE,
                i_Video_ai_asset_entity.IS_DELETED,
                i_Video_ai_asset_entity.OWNER_ID,
                i_Video_ai_asset_entity.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_asset_entity", i_Video_ai_asset_entity_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category
        public void Edit_Setup_category(Setup_category i_Setup_category)
        {
            var i_Setup_category_json = JsonConvert.SerializeObject(i_Setup_category);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup_category.SETUP_CATEGORY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
            #region Body Section.
            if (i_Setup_category.SETUP_CATEGORY_ID == null || i_Setup_category.SETUP_CATEGORY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup_category");
            }
            if (Check_Setup_category_Uniqueness_Violation(i_Setup_category))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup_category"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup_category.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup_category.IS_DELETED = false;
            }
            else
            {
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                });
            }
            i_Setup_category.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup_category.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup_category.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Setup_category
            if (OnPreEvent_Edit_Setup_category != null)
            {
                OnPreEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Setup_category_Execution)
            {
                _Stop_Edit_Setup_category_Execution = false;
                return;
            }
            i_Setup_category.SETUP_CATEGORY_ID = _AppContext.Edit_Setup_category
            (
                i_Setup_category.SETUP_CATEGORY_ID,
                i_Setup_category.SETUP_CATEGORY_NAME,
                i_Setup_category.DESCRIPTION,
                i_Setup_category.ENTRY_USER_ID,
                i_Setup_category.ENTRY_DATE,
                i_Setup_category.LAST_UPDATE,
                i_Setup_category.IS_DELETED,
                i_Setup_category.OWNER_ID
            );
            #region PostEvent_Edit_Setup_category
            if (OnPostEvent_Edit_Setup_category != null)
            {
                OnPostEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
        }
        #endregion
        #region Edit_Setup
        public void Edit_Setup(Setup i_Setup)
        {
            var i_Setup_json = JsonConvert.SerializeObject(i_Setup);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup.SETUP_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup", i_Setup_json, false);
            }
            #region Body Section.
            if (i_Setup.SETUP_ID == null || i_Setup.SETUP_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup");
            }
            if (Check_Setup_Uniqueness_Violation(i_Setup))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup.IS_DELETED = false;
            }
            else
            {
                _Setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Setup.SETUP_ID
                });
            }
            i_Setup.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Setup_Execution)
            {
                _Stop_Edit_Setup_Execution = false;
                return;
            }
            i_Setup.SETUP_ID = _AppContext.Edit_Setup
            (
                i_Setup.SETUP_ID,
                i_Setup.SETUP_CATEGORY_ID,
                i_Setup.IS_SYSTEM,
                i_Setup.IS_DELETEABLE,
                i_Setup.IS_UPDATEABLE,
                i_Setup.IS_DELETED,
                i_Setup.IS_VISIBLE,
                i_Setup.DISPLAY_ORDER,
                i_Setup.VALUE,
                i_Setup.DESCRIPTION,
                i_Setup.ENTRY_USER_ID,
                i_Setup.ENTRY_DATE,
                i_Setup.LAST_UPDATE,
                i_Setup.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup", i_Setup_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_engine
        public void Edit_Video_ai_engine(Video_ai_engine i_Video_ai_engine)
        {
            var i_Video_ai_engine_json = JsonConvert.SerializeObject(i_Video_ai_engine);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Video_ai_engine.VIDEO_AI_ENGINE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_engine", i_Video_ai_engine_json, false);
            }
            #region Body Section.
            if (i_Video_ai_engine.VIDEO_AI_ENGINE_ID == null || i_Video_ai_engine.VIDEO_AI_ENGINE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Video_ai_engine");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Video_ai_engine.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Video_ai_engine.IS_DELETED = false;
            }
            else
            {
                _Video_ai_engine = Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID(new Params_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID
                {
                    VIDEO_AI_ENGINE_ID = i_Video_ai_engine.VIDEO_AI_ENGINE_ID
                });
            }
            i_Video_ai_engine.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Video_ai_engine.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Video_ai_engine.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Video_ai_engine
            if (OnPreEvent_Edit_Video_ai_engine != null)
            {
                OnPreEvent_Edit_Video_ai_engine(i_Video_ai_engine, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Video_ai_engine_Execution)
            {
                _Stop_Edit_Video_ai_engine_Execution = false;
                return;
            }
            i_Video_ai_engine.VIDEO_AI_ENGINE_ID = _AppContext.Edit_Video_ai_engine
            (
                i_Video_ai_engine.VIDEO_AI_ENGINE_ID,
                i_Video_ai_engine.ENGINE_NAME,
                i_Video_ai_engine.ENTRY_USER_ID,
                i_Video_ai_engine.ENTRY_DATE,
                i_Video_ai_engine.LAST_UPDATE,
                i_Video_ai_engine.IS_DELETED,
                i_Video_ai_engine.OWNER_ID
            );
            #region PostEvent_Edit_Video_ai_engine
            if (OnPostEvent_Edit_Video_ai_engine != null)
            {
                OnPostEvent_Edit_Video_ai_engine(i_Video_ai_engine, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_engine", i_Video_ai_engine_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_instance
        public void Edit_Video_ai_instance(Video_ai_instance i_Video_ai_instance)
        {
            var i_Video_ai_instance_json = JsonConvert.SerializeObject(i_Video_ai_instance);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Video_ai_instance.VIDEO_AI_INSTANCE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_instance", i_Video_ai_instance_json, false);
            }
            #region Body Section.
            if (i_Video_ai_instance.VIDEO_AI_INSTANCE_ID == null || i_Video_ai_instance.VIDEO_AI_INSTANCE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Video_ai_instance");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Video_ai_instance.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Video_ai_instance.IS_DELETED = false;
            }
            else
            {
                _Video_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
                {
                    VIDEO_AI_INSTANCE_ID = i_Video_ai_instance.VIDEO_AI_INSTANCE_ID
                });
            }
            i_Video_ai_instance.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Video_ai_instance.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Video_ai_instance.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Video_ai_instance_Execution)
            {
                _Stop_Edit_Video_ai_instance_Execution = false;
                return;
            }
            i_Video_ai_instance.VIDEO_AI_INSTANCE_ID = _AppContext.Edit_Video_ai_instance
            (
                i_Video_ai_instance.VIDEO_AI_INSTANCE_ID,
                i_Video_ai_instance.VIDEO_AI_ENGINE_ID,
                i_Video_ai_instance.FRIENDLY_NAME,
                i_Video_ai_instance.FUNCTIONAL_NAME,
                i_Video_ai_instance.CONNECTION_URL,
                i_Video_ai_instance.CONNECTION_TYPE_SETUP_ID,
                i_Video_ai_instance.USERNAME,
                i_Video_ai_instance.PASSWORD,
                i_Video_ai_instance.IS_LPR,
                i_Video_ai_instance.ENTRY_USER_ID,
                i_Video_ai_instance.ENTRY_DATE,
                i_Video_ai_instance.LAST_UPDATE,
                i_Video_ai_instance.IS_DELETED,
                i_Video_ai_instance.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_instance", i_Video_ai_instance_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_asset
        public void Edit_Video_ai_asset(Video_ai_asset i_Video_ai_asset)
        {
            var i_Video_ai_asset_json = JsonConvert.SerializeObject(i_Video_ai_asset);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Video_ai_asset.VIDEO_AI_ASSET_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_asset", i_Video_ai_asset_json, false);
            }
            #region Body Section.
            if (i_Video_ai_asset.VIDEO_AI_ASSET_ID == null || i_Video_ai_asset.VIDEO_AI_ASSET_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Video_ai_asset");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Video_ai_asset.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Video_ai_asset.IS_DELETED = false;
            }
            else
            {
                _Video_ai_asset = Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID(new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID
                {
                    VIDEO_AI_ASSET_ID = i_Video_ai_asset.VIDEO_AI_ASSET_ID
                });
            }
            i_Video_ai_asset.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Video_ai_asset.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Video_ai_asset.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Video_ai_asset
            if (OnPreEvent_Edit_Video_ai_asset != null)
            {
                OnPreEvent_Edit_Video_ai_asset(i_Video_ai_asset, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Video_ai_asset_Execution)
            {
                _Stop_Edit_Video_ai_asset_Execution = false;
                return;
            }
            i_Video_ai_asset.VIDEO_AI_ASSET_ID = _AppContext.Edit_Video_ai_asset
            (
                i_Video_ai_asset.VIDEO_AI_ASSET_ID,
                i_Video_ai_asset.VIDEO_AI_INSTANCE_ID,
                i_Video_ai_asset.SPACE_ASSET_ID,
                i_Video_ai_asset.FRIENDLY_NAME,
                i_Video_ai_asset.VIDEO_AI_ASSET_ID_REF,
                i_Video_ai_asset.FUNCTIONAL_NAME,
                i_Video_ai_asset.RESOLUTION_X,
                i_Video_ai_asset.RESOLUTION_Y,
                i_Video_ai_asset.ENTRY_USER_ID,
                i_Video_ai_asset.ENTRY_DATE,
                i_Video_ai_asset.LAST_UPDATE,
                i_Video_ai_asset.IS_DELETED,
                i_Video_ai_asset.OWNER_ID
            );
            #region PostEvent_Edit_Video_ai_asset
            if (OnPostEvent_Edit_Video_ai_asset != null)
            {
                OnPostEvent_Edit_Video_ai_asset(i_Video_ai_asset, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_asset", i_Video_ai_asset_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_search_category_List
        public void Edit_Video_ai_search_category_List(Params_Edit_Video_ai_search_category_List i_Params_Edit_Video_ai_search_category_List)
        {
            var i_Params_Edit_Video_ai_search_category_List_json = JsonConvert.SerializeObject(i_Params_Edit_Video_ai_search_category_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_search_category_List", i_Params_Edit_Video_ai_search_category_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Video_ai_search_category_List.List_To_Edit != null)
            {
                i_Params_Edit_Video_ai_search_category_List.List_Failed_Edit = new List<Video_ai_search_category>();
                if (i_Params_Edit_Video_ai_search_category_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oVideo_ai_search_category in i_Params_Edit_Video_ai_search_category_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Video_ai_search_category(oVideo_ai_search_category);
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_search_category_List.List_Failed_Edit.Add(oVideo_ai_search_category);
                        }
                    }
                }
                i_Params_Edit_Video_ai_search_category_List.List_To_Edit = i_Params_Edit_Video_ai_search_category_List.List_To_Edit.Except(i_Params_Edit_Video_ai_search_category_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Video_ai_search_category_List.List_To_Delete != null)
            {
                i_Params_Edit_Video_ai_search_category_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Video_ai_search_category_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Video_ai_search_category_ID in i_Params_Edit_Video_ai_search_category_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Video_ai_search_category(new Params_Delete_Video_ai_search_category()
                            {
                                VIDEO_AI_SEARCH_CATEGORY_ID = Video_ai_search_category_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_search_category_List.List_Failed_Delete.Add(Video_ai_search_category_ID);
                        }
                    }
                }
                i_Params_Edit_Video_ai_search_category_List.List_To_Delete = i_Params_Edit_Video_ai_search_category_List.List_To_Delete.Except(i_Params_Edit_Video_ai_search_category_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_search_category_List", i_Params_Edit_Video_ai_search_category_List_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_asset_entity_List
        public void Edit_Video_ai_asset_entity_List(Params_Edit_Video_ai_asset_entity_List i_Params_Edit_Video_ai_asset_entity_List)
        {
            var i_Params_Edit_Video_ai_asset_entity_List_json = JsonConvert.SerializeObject(i_Params_Edit_Video_ai_asset_entity_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_asset_entity_List", i_Params_Edit_Video_ai_asset_entity_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Video_ai_asset_entity_List.List_To_Edit != null)
            {
                i_Params_Edit_Video_ai_asset_entity_List.List_Failed_Edit = new List<Video_ai_asset_entity>();
                if (i_Params_Edit_Video_ai_asset_entity_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oVideo_ai_asset_entity in i_Params_Edit_Video_ai_asset_entity_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Video_ai_asset_entity(oVideo_ai_asset_entity);
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_asset_entity_List.List_Failed_Edit.Add(oVideo_ai_asset_entity);
                        }
                    }
                }
                i_Params_Edit_Video_ai_asset_entity_List.List_To_Edit = i_Params_Edit_Video_ai_asset_entity_List.List_To_Edit.Except(i_Params_Edit_Video_ai_asset_entity_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Video_ai_asset_entity_List.List_To_Delete != null)
            {
                i_Params_Edit_Video_ai_asset_entity_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Video_ai_asset_entity_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Video_ai_asset_entity_ID in i_Params_Edit_Video_ai_asset_entity_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Video_ai_asset_entity(new Params_Delete_Video_ai_asset_entity()
                            {
                                VIDEO_AI_ASSET_ENTITY_ID = Video_ai_asset_entity_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_asset_entity_List.List_Failed_Delete.Add(Video_ai_asset_entity_ID);
                        }
                    }
                }
                i_Params_Edit_Video_ai_asset_entity_List.List_To_Delete = i_Params_Edit_Video_ai_asset_entity_List.List_To_Delete.Except(i_Params_Edit_Video_ai_asset_entity_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_asset_entity_List", i_Params_Edit_Video_ai_asset_entity_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category_List
        public void Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
        {
            var i_Params_Edit_Setup_category_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_category_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_category_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Edit = new List<Setup_category>();
                if (i_Params_Edit_Setup_category_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup_category in i_Params_Edit_Setup_category_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup_category(oSetup_category);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Edit.Add(oSetup_category);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Edit = i_Params_Edit_Setup_category_List.List_To_Edit.Except(i_Params_Edit_Setup_category_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_category_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Setup_category_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_category_ID in i_Params_Edit_Setup_category_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup_category(new Params_Delete_Setup_category()
                            {
                                SETUP_CATEGORY_ID = Setup_category_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Delete.Add(Setup_category_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Delete = i_Params_Edit_Setup_category_List.List_To_Delete.Except(i_Params_Edit_Setup_category_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_List
        public void Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List)
        {
            var i_Params_Edit_Setup_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Edit = new List<Setup>();
                if (i_Params_Edit_Setup_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup in i_Params_Edit_Setup_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup(oSetup);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Edit.Add(oSetup);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Edit = i_Params_Edit_Setup_List.List_To_Edit.Except(i_Params_Edit_Setup_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Setup_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_ID in i_Params_Edit_Setup_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup(new Params_Delete_Setup()
                            {
                                SETUP_ID = Setup_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Delete.Add(Setup_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Delete = i_Params_Edit_Setup_List.List_To_Delete.Except(i_Params_Edit_Setup_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_engine_List
        public void Edit_Video_ai_engine_List(Params_Edit_Video_ai_engine_List i_Params_Edit_Video_ai_engine_List)
        {
            var i_Params_Edit_Video_ai_engine_List_json = JsonConvert.SerializeObject(i_Params_Edit_Video_ai_engine_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_engine_List", i_Params_Edit_Video_ai_engine_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Video_ai_engine_List.List_To_Edit != null)
            {
                i_Params_Edit_Video_ai_engine_List.List_Failed_Edit = new List<Video_ai_engine>();
                if (i_Params_Edit_Video_ai_engine_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oVideo_ai_engine in i_Params_Edit_Video_ai_engine_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Video_ai_engine(oVideo_ai_engine);
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_engine_List.List_Failed_Edit.Add(oVideo_ai_engine);
                        }
                    }
                }
                i_Params_Edit_Video_ai_engine_List.List_To_Edit = i_Params_Edit_Video_ai_engine_List.List_To_Edit.Except(i_Params_Edit_Video_ai_engine_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Video_ai_engine_List.List_To_Delete != null)
            {
                i_Params_Edit_Video_ai_engine_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Video_ai_engine_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Video_ai_engine_ID in i_Params_Edit_Video_ai_engine_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Video_ai_engine(new Params_Delete_Video_ai_engine()
                            {
                                VIDEO_AI_ENGINE_ID = Video_ai_engine_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_engine_List.List_Failed_Delete.Add(Video_ai_engine_ID);
                        }
                    }
                }
                i_Params_Edit_Video_ai_engine_List.List_To_Delete = i_Params_Edit_Video_ai_engine_List.List_To_Delete.Except(i_Params_Edit_Video_ai_engine_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_engine_List", i_Params_Edit_Video_ai_engine_List_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_instance_List
        public void Edit_Video_ai_instance_List(Params_Edit_Video_ai_instance_List i_Params_Edit_Video_ai_instance_List)
        {
            var i_Params_Edit_Video_ai_instance_List_json = JsonConvert.SerializeObject(i_Params_Edit_Video_ai_instance_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_instance_List", i_Params_Edit_Video_ai_instance_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Video_ai_instance_List.List_To_Edit != null)
            {
                i_Params_Edit_Video_ai_instance_List.List_Failed_Edit = new List<Video_ai_instance>();
                if (i_Params_Edit_Video_ai_instance_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oVideo_ai_instance in i_Params_Edit_Video_ai_instance_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Video_ai_instance(oVideo_ai_instance);
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_instance_List.List_Failed_Edit.Add(oVideo_ai_instance);
                        }
                    }
                }
                i_Params_Edit_Video_ai_instance_List.List_To_Edit = i_Params_Edit_Video_ai_instance_List.List_To_Edit.Except(i_Params_Edit_Video_ai_instance_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Video_ai_instance_List.List_To_Delete != null)
            {
                i_Params_Edit_Video_ai_instance_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Video_ai_instance_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Video_ai_instance_ID in i_Params_Edit_Video_ai_instance_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Video_ai_instance(new Params_Delete_Video_ai_instance()
                            {
                                VIDEO_AI_INSTANCE_ID = Video_ai_instance_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_instance_List.List_Failed_Delete.Add(Video_ai_instance_ID);
                        }
                    }
                }
                i_Params_Edit_Video_ai_instance_List.List_To_Delete = i_Params_Edit_Video_ai_instance_List.List_To_Delete.Except(i_Params_Edit_Video_ai_instance_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_instance_List", i_Params_Edit_Video_ai_instance_List_json, false);
            }
        }
        #endregion
        #region Edit_Video_ai_asset_List
        public void Edit_Video_ai_asset_List(Params_Edit_Video_ai_asset_List i_Params_Edit_Video_ai_asset_List)
        {
            var i_Params_Edit_Video_ai_asset_List_json = JsonConvert.SerializeObject(i_Params_Edit_Video_ai_asset_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Video_ai_asset_List", i_Params_Edit_Video_ai_asset_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Video_ai_asset_List.List_To_Edit != null)
            {
                i_Params_Edit_Video_ai_asset_List.List_Failed_Edit = new List<Video_ai_asset>();
                if (i_Params_Edit_Video_ai_asset_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oVideo_ai_asset in i_Params_Edit_Video_ai_asset_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Video_ai_asset(oVideo_ai_asset);
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_asset_List.List_Failed_Edit.Add(oVideo_ai_asset);
                        }
                    }
                }
                i_Params_Edit_Video_ai_asset_List.List_To_Edit = i_Params_Edit_Video_ai_asset_List.List_To_Edit.Except(i_Params_Edit_Video_ai_asset_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Video_ai_asset_List.List_To_Delete != null)
            {
                i_Params_Edit_Video_ai_asset_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Video_ai_asset_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Video_ai_asset_ID in i_Params_Edit_Video_ai_asset_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Video_ai_asset(new Params_Delete_Video_ai_asset()
                            {
                                VIDEO_AI_ASSET_ID = Video_ai_asset_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Video_ai_asset_List.List_Failed_Delete.Add(Video_ai_asset_ID);
                        }
                    }
                }
                i_Params_Edit_Video_ai_asset_List.List_To_Delete = i_Params_Edit_Video_ai_asset_List.List_To_Delete.Except(i_Params_Edit_Video_ai_asset_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Video_ai_asset_List", i_Params_Edit_Video_ai_asset_List_json, false);
            }
        }
        #endregion
    }
}