using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv
        public Video_ai_search_category Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv(Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID)
        {
            Video_ai_search_category oVideo_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_search_category oDBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID.VIDEO_AI_SEARCH_CATEGORY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_search_category").Replace("%2", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID.VIDEO_AI_SEARCH_CATEGORY_ID.ToString()));
            }
            oVideo_ai_search_category = new Video_ai_search_category();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
            oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
            Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_json, false);
            }
            return oVideo_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv
        public Video_ai_asset_entity Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID)
        {
            Video_ai_asset_entity oVideo_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_asset_entity oDBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID.VIDEO_AI_ASSET_ENTITY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_asset_entity").Replace("%2", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID.VIDEO_AI_ASSET_ENTITY_ID.ToString()));
            }
            oVideo_ai_asset_entity = new Video_ai_asset_entity();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
            oVideo_ai_asset_entity.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
            oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
            Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_json, false);
            }
            return oVideo_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID_Adv(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            oSetup.Setup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv
        public Video_ai_instance Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv(Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID)
        {
            Video_ai_instance oVideo_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_instance oDBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_instance").Replace("%2", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID.ToString()));
            }
            oVideo_ai_instance = new Video_ai_instance();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
            oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
            Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
            oVideo_ai_instance.Connection_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            return oVideo_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv
        public Video_ai_asset Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID)
        {
            Video_ai_asset oVideo_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Video_ai_asset oDBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Video_ai_asset").Replace("%2", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID.ToString()));
            }
            oVideo_ai_asset = new Video_ai_asset();
            Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
            oVideo_ai_asset.Space_asset = new Space_asset();
            Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
            oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
            Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_json, false);
            }
            return oVideo_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv(Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List.VIDEO_AI_SEARCH_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List.VIDEO_AI_ASSET_ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List_Adv(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv(Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv(i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List.VIDEO_AI_INSTANCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List.VIDEO_AI_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_Adv(Params_Get_Video_ai_search_category_By_OWNER_ID i_Params_Get_Video_ai_search_category_By_OWNER_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_OWNER_ID_Adv", i_Params_Get_Video_ai_search_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_OWNER_ID_Adv(i_Params_Get_Video_ai_search_category_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_OWNER_ID_Adv", i_Params_Get_Video_ai_search_category_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv(Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_Adv(Params_Get_Video_ai_asset_entity_By_OWNER_ID i_Params_Get_Video_ai_asset_entity_By_OWNER_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_OWNER_ID_Adv(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(Params_Get_Video_ai_asset_entity_By_ENTITY_ID i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_ENTITY_ID_Adv(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID_Adv", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
                oSetup.Setup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_Adv(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_Adv(Params_Get_Video_ai_instance_By_OWNER_ID i_Params_Get_Video_ai_instance_By_OWNER_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_OWNER_ID_Adv", i_Params_Get_Video_ai_instance_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_OWNER_ID_Adv(i_Params_Get_Video_ai_instance_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_OWNER_ID_Adv", i_Params_Get_Video_ai_instance_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv(Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv(Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID.CONNECTION_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_Adv(Params_Get_Video_ai_asset_By_OWNER_ID i_Params_Get_Video_ai_asset_By_OWNER_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_OWNER_ID_Adv", i_Params_Get_Video_ai_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_OWNER_ID_Adv(i_Params_Get_Video_ai_asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_OWNER_ID_Adv", i_Params_Get_Video_ai_asset_By_OWNER_ID_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF.VIDEO_AI_ASSET_ID_REF);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv(Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List)
        {
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv(i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List.VIDEO_AI_ENGINE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv", i_Params_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv(Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv(i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List.VIDEO_AI_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv", i_Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv(Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List)
        {
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv(i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv", i_Params_Get_Video_ai_asset_entity_By_ENTITY_ID_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv(Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv(i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List.VIDEO_AI_ENGINE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv", i_Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv(Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List)
        {
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv(i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List.CONNECTION_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv", i_Params_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List.VIDEO_AI_INSTANCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv", i_Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv(Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List)
        {
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_json, false);
            }
            #region Body Section.
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv(i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.VIDEO_AI_ASSET_ID_REF_LIST);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv", i_Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_Adv(Params_Get_Video_ai_search_category_By_Where i_Params_Get_Video_ai_search_category_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_Where_Adv", i_Params_Get_Video_ai_search_category_By_Where_json, false);
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
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_Where_Adv(i_Params_Get_Video_ai_search_category_By_Where.CATEGORY_NAME, i_Params_Get_Video_ai_search_category_By_Where.OWNER_ID, i_Params_Get_Video_ai_search_category_By_Where.OFFSET, i_Params_Get_Video_ai_search_category_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            i_Params_Get_Video_ai_search_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_Where_Adv", i_Params_Get_Video_ai_search_category_By_Where_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_Adv(Params_Get_Video_ai_asset_entity_By_Where i_Params_Get_Video_ai_asset_entity_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_Where_Adv", i_Params_Get_Video_ai_asset_entity_By_Where_json, false);
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
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_Where_Adv(i_Params_Get_Video_ai_asset_entity_By_Where.DESCRIPTION, i_Params_Get_Video_ai_asset_entity_By_Where.OWNER_ID, i_Params_Get_Video_ai_asset_entity_By_Where.OFFSET, i_Params_Get_Video_ai_asset_entity_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_entity_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_Where_Adv", i_Params_Get_Video_ai_asset_entity_By_Where_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_Adv(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_Where_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where_Adv(Params_Get_Video_ai_instance_By_Where i_Params_Get_Video_ai_instance_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_Where_Adv", i_Params_Get_Video_ai_instance_By_Where_json, false);
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
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_Where_Adv(i_Params_Get_Video_ai_instance_By_Where.FRIENDLY_NAME, i_Params_Get_Video_ai_instance_By_Where.FUNCTIONAL_NAME, i_Params_Get_Video_ai_instance_By_Where.CONNECTION_URL, i_Params_Get_Video_ai_instance_By_Where.USERNAME, i_Params_Get_Video_ai_instance_By_Where.PASSWORD, i_Params_Get_Video_ai_instance_By_Where.OWNER_ID, i_Params_Get_Video_ai_instance_By_Where.OFFSET, i_Params_Get_Video_ai_instance_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            i_Params_Get_Video_ai_instance_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_Where_Adv", i_Params_Get_Video_ai_instance_By_Where_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where_Adv(Params_Get_Video_ai_asset_By_Where i_Params_Get_Video_ai_asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_Where_Adv", i_Params_Get_Video_ai_asset_By_Where_json, false);
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
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_Where_Adv(i_Params_Get_Video_ai_asset_By_Where.FRIENDLY_NAME, i_Params_Get_Video_ai_asset_By_Where.FUNCTIONAL_NAME, i_Params_Get_Video_ai_asset_By_Where.OWNER_ID, i_Params_Get_Video_ai_asset_By_Where.OFFSET, i_Params_Get_Video_ai_asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_Where_Adv", i_Params_Get_Video_ai_asset_By_Where_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
        #region Get_Video_ai_search_category_By_Where_In_List_Adv
        public List<Video_ai_search_category> Get_Video_ai_search_category_By_Where_In_List_Adv(Params_Get_Video_ai_search_category_By_Where_In_List i_Params_Get_Video_ai_search_category_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_search_category> oList_Video_ai_search_category = null;
            var i_Params_Get_Video_ai_search_category_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_search_category_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_search_category_By_Where_In_List_Adv", i_Params_Get_Video_ai_search_category_By_Where_In_List_json, false);
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
            List<DALC.Video_ai_search_category> oList_DBEntry = _AppContext.Get_Video_ai_search_category_By_Where_In_List_Adv(i_Params_Get_Video_ai_search_category_By_Where_In_List.CATEGORY_NAME, i_Params_Get_Video_ai_search_category_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST, i_Params_Get_Video_ai_search_category_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_search_category_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_search_category_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_search_category = new List<Video_ai_search_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_search_category oVideo_ai_search_category = new Video_ai_search_category();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_search_category);
                        oVideo_ai_search_category.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_search_category.Video_ai_engine);
                        oList_Video_ai_search_category.Add(oVideo_ai_search_category);
                    }
                }
            }
            i_Params_Get_Video_ai_search_category_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_search_category_By_Where_In_List_Adv", i_Params_Get_Video_ai_search_category_By_Where_In_List_json, false);
            }
            return oList_Video_ai_search_category;
        }
        #endregion
        #region Get_Video_ai_asset_entity_By_Where_In_List_Adv
        public List<Video_ai_asset_entity> Get_Video_ai_asset_entity_By_Where_In_List_Adv(Params_Get_Video_ai_asset_entity_By_Where_In_List i_Params_Get_Video_ai_asset_entity_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = null;
            var i_Params_Get_Video_ai_asset_entity_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_entity_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_entity_By_Where_In_List_Adv", i_Params_Get_Video_ai_asset_entity_By_Where_In_List_json, false);
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
            List<DALC.Video_ai_asset_entity> oList_DBEntry = _AppContext.Get_Video_ai_asset_entity_By_Where_In_List_Adv(i_Params_Get_Video_ai_asset_entity_By_Where_In_List.DESCRIPTION, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.VIDEO_AI_ASSET_ID_LIST, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_asset_entity_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset_entity = new List<Video_ai_asset_entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset_entity oVideo_ai_asset_entity = new Video_ai_asset_entity();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset_entity);
                        oVideo_ai_asset_entity.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oVideo_ai_asset_entity.Entity);
                        oVideo_ai_asset_entity.Video_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_asset, oVideo_ai_asset_entity.Video_ai_asset);
                        oList_Video_ai_asset_entity.Add(oVideo_ai_asset_entity);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_entity_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_entity_By_Where_In_List_Adv", i_Params_Get_Video_ai_asset_entity_By_Where_In_List_json, false);
            }
            return oList_Video_ai_asset_entity;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List_Adv(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Video_ai_instance_By_Where_In_List_Adv
        public List<Video_ai_instance> Get_Video_ai_instance_By_Where_In_List_Adv(Params_Get_Video_ai_instance_By_Where_In_List i_Params_Get_Video_ai_instance_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_instance> oList_Video_ai_instance = null;
            var i_Params_Get_Video_ai_instance_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_instance_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_instance_By_Where_In_List_Adv", i_Params_Get_Video_ai_instance_By_Where_In_List_json, false);
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
            List<DALC.Video_ai_instance> oList_DBEntry = _AppContext.Get_Video_ai_instance_By_Where_In_List_Adv(i_Params_Get_Video_ai_instance_By_Where_In_List.FRIENDLY_NAME, i_Params_Get_Video_ai_instance_By_Where_In_List.FUNCTIONAL_NAME, i_Params_Get_Video_ai_instance_By_Where_In_List.CONNECTION_URL, i_Params_Get_Video_ai_instance_By_Where_In_List.USERNAME, i_Params_Get_Video_ai_instance_By_Where_In_List.PASSWORD, i_Params_Get_Video_ai_instance_By_Where_In_List.VIDEO_AI_ENGINE_ID_LIST, i_Params_Get_Video_ai_instance_By_Where_In_List.CONNECTION_TYPE_SETUP_ID_LIST, i_Params_Get_Video_ai_instance_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_instance_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_instance_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_instance = new List<Video_ai_instance>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_instance oVideo_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_instance);
                        oVideo_ai_instance.Video_ai_engine = new Video_ai_engine();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_engine, oVideo_ai_instance.Video_ai_engine);
                        oVideo_ai_instance.Connection_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Connection_type_setup, oVideo_ai_instance.Connection_type_setup);
                        oList_Video_ai_instance.Add(oVideo_ai_instance);
                    }
                }
            }
            i_Params_Get_Video_ai_instance_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_instance_By_Where_In_List_Adv", i_Params_Get_Video_ai_instance_By_Where_In_List_json, false);
            }
            return oList_Video_ai_instance;
        }
        #endregion
        #region Get_Video_ai_asset_By_Where_In_List_Adv
        public List<Video_ai_asset> Get_Video_ai_asset_By_Where_In_List_Adv(Params_Get_Video_ai_asset_By_Where_In_List i_Params_Get_Video_ai_asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Video_ai_asset> oList_Video_ai_asset = null;
            var i_Params_Get_Video_ai_asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Video_ai_asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Video_ai_asset_By_Where_In_List_Adv", i_Params_Get_Video_ai_asset_By_Where_In_List_json, false);
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
            List<DALC.Video_ai_asset> oList_DBEntry = _AppContext.Get_Video_ai_asset_By_Where_In_List_Adv(i_Params_Get_Video_ai_asset_By_Where_In_List.FRIENDLY_NAME, i_Params_Get_Video_ai_asset_By_Where_In_List.FUNCTIONAL_NAME, i_Params_Get_Video_ai_asset_By_Where_In_List.VIDEO_AI_INSTANCE_ID_LIST, i_Params_Get_Video_ai_asset_By_Where_In_List.SPACE_ASSET_ID_LIST, i_Params_Get_Video_ai_asset_By_Where_In_List.OWNER_ID, i_Params_Get_Video_ai_asset_By_Where_In_List.OFFSET, i_Params_Get_Video_ai_asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Video_ai_asset = new List<Video_ai_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Video_ai_asset oVideo_ai_asset = new Video_ai_asset();
                        Props.Copy_Prop_Values(oDBEntry, oVideo_ai_asset);
                        oVideo_ai_asset.Space_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry.Space_asset, oVideo_ai_asset.Space_asset);
                        oVideo_ai_asset.Video_ai_instance = new Video_ai_instance();
                        Props.Copy_Prop_Values(oDBEntry.Video_ai_instance, oVideo_ai_asset.Video_ai_instance);
                        oList_Video_ai_asset.Add(oVideo_ai_asset);
                    }
                }
            }
            i_Params_Get_Video_ai_asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Video_ai_asset_By_Where_In_List_Adv", i_Params_Get_Video_ai_asset_By_Where_In_List_json, false);
            }
            return oList_Video_ai_asset;
        }
        #endregion
    }
}
