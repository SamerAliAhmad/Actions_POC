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
        private Asset _Asset;
        private List<Asset> _List_Asset;
        private Video_ai_asset_entity _Video_ai_asset_entity;
        private List<Video_ai_asset_entity> _List_Video_ai_asset_entity;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Space_asset _Space_asset;
        private List<Space_asset> _List_Space_asset;
        private Space _Space;
        private List<Space> _List_Space;
        private Video_ai_asset _Video_ai_asset;
        private List<Video_ai_asset> _List_Video_ai_asset;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Asset_Execution;
        private bool _Stop_Delete_Asset_Execution;
        private bool _Stop_Edit_Video_ai_asset_entity_Execution;
        private bool _Stop_Delete_Video_ai_asset_entity_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Space_asset_Execution;
        private bool _Stop_Delete_Space_asset_Execution;
        private bool _Stop_Edit_Space_Execution;
        private bool _Stop_Delete_Space_Execution;
        private bool _Stop_Edit_Video_ai_asset_Execution;
        private bool _Stop_Delete_Video_ai_asset_Execution;
        #endregion
        #endregion
        #region Get_Asset_By_ASSET_ID
        public Asset Get_Asset_By_ASSET_ID(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID)
        {
            Asset oAsset = null;
            var i_Params_Get_Asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Asset oDBEntry = _AppContext.Get_Asset_By_ASSET_ID(i_Params_Get_Asset_By_ASSET_ID.ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Asset").Replace("%2", i_Params_Get_Asset_By_ASSET_ID.ASSET_ID.ToString()));
            }
            oAsset = new Asset();
            Props.Copy_Prop_Values(oDBEntry, oAsset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            return oAsset;
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
        #region Get_Space_asset_By_SPACE_ASSET_ID
        public Space_asset Get_Space_asset_By_SPACE_ASSET_ID(Params_Get_Space_asset_By_SPACE_ASSET_ID i_Params_Get_Space_asset_By_SPACE_ASSET_ID)
        {
            Space_asset oSpace_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ASSET_ID", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Space_asset oDBEntry = _AppContext.Get_Space_asset_By_SPACE_ASSET_ID(i_Params_Get_Space_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space_asset").Replace("%2", i_Params_Get_Space_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID.ToString()));
            }
            oSpace_asset = new Space_asset();
            Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ASSET_ID", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json, false);
            }
            return oSpace_asset;
        }
        #endregion
        #region Get_Space_By_SPACE_ID
        public Space Get_Space_By_SPACE_ID(Params_Get_Space_By_SPACE_ID i_Params_Get_Space_By_SPACE_ID)
        {
            Space oSpace = null;
            var i_Params_Get_Space_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            #region Body Section.
            DALC.Space oDBEntry = _AppContext.Get_Space_By_SPACE_ID(i_Params_Get_Space_By_SPACE_ID.SPACE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space").Replace("%2", i_Params_Get_Space_By_SPACE_ID.SPACE_ID.ToString()));
            }
            oSpace = new Space();
            Props.Copy_Prop_Values(oDBEntry, oSpace);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            return oSpace;
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
        #region Get_Asset_By_ASSET_ID_List
        public List<Asset> Get_Asset_By_ASSET_ID_List(Params_Get_Asset_By_ASSET_ID_List i_Params_Get_Asset_By_ASSET_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID_List", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_ID_List(i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID_List", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            return oList_Asset;
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
        #region Get_Space_asset_By_SPACE_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List(Params_Get_Space_asset_By_SPACE_ASSET_ID_List i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_List", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ASSET_ID_List(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_List", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_List
        public List<Space> Get_Space_By_SPACE_ID_List(Params_Get_Space_By_SPACE_ID_List i_Params_Get_Space_By_SPACE_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID_List", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_SPACE_ID_List(i_Params_Get_Space_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID_List", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            return oList_Space;
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
        #region Get_Asset_By_OWNER_ID
        public List<Asset> Get_Asset_By_OWNER_ID(Params_Get_Asset_By_OWNER_ID i_Params_Get_Asset_By_OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID(i_Params_Get_Asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(Params_Get_Asset_By_OWNER_ID_IS_DELETED i_Params_Get_Asset_By_OWNER_ID_IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID_IS_DELETED(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Asset;
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
        #region Get_Space_asset_By_OWNER_ID
        public List<Space_asset> Get_Space_asset_By_OWNER_ID(Params_Get_Space_asset_By_OWNER_ID i_Params_Get_Space_asset_By_OWNER_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_OWNER_ID", i_Params_Get_Space_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_OWNER_ID(i_Params_Get_Space_asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_OWNER_ID", i_Params_Get_Space_asset_By_OWNER_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID
        public List<Space_asset> Get_Space_asset_By_SPACE_ID(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ID", i_Params_Get_Space_asset_By_SPACE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ID(i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ID", i_Params_Get_Space_asset_By_SPACE_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID
        public List<Space_asset> Get_Space_asset_By_ASSET_ID(Params_Get_Space_asset_By_ASSET_ID i_Params_Get_Space_asset_By_ASSET_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_ASSET_ID", i_Params_Get_Space_asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_ASSET_ID(i_Params_Get_Space_asset_By_ASSET_ID.ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_ASSET_ID", i_Params_Get_Space_asset_By_ASSET_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED(Params_Get_Space_asset_By_OWNER_ID_IS_DELETED i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_OWNER_ID_IS_DELETED(i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID
        public List<Space_asset> Get_Space_asset_By_EXTERNAL_ID(Params_Get_Space_asset_By_EXTERNAL_ID i_Params_Get_Space_asset_By_EXTERNAL_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_EXTERNAL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_EXTERNAL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_EXTERNAL_ID", i_Params_Get_Space_asset_By_EXTERNAL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_EXTERNAL_ID(i_Params_Get_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_EXTERNAL_ID", i_Params_Get_Space_asset_By_EXTERNAL_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_By_OWNER_ID
        public List<Space> Get_Space_By_OWNER_ID(Params_Get_Space_By_OWNER_ID i_Params_Get_Space_By_OWNER_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID(i_Params_Get_Space_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID
        public List<Space> Get_Space_By_FLOOR_ID(Params_Get_Space_By_FLOOR_ID i_Params_Get_Space_By_FLOOR_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID(i_Params_Get_Space_By_FLOOR_ID.FLOOR_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED(Params_Get_Space_By_OWNER_ID_IS_DELETED i_Params_Get_Space_By_OWNER_ID_IS_DELETED)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID_IS_DELETED(i_Params_Get_Space_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space;
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
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID_List(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List.ASSET_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Asset;
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
        #region Get_Space_asset_By_SPACE_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_List(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ID_List", i_Params_Get_Space_asset_By_SPACE_ID_List_json, false);
            }
            #region PreEvent_Get_Space_asset_By_SPACE_ID_List
            if (OnPreEvent_Get_Space_asset_By_SPACE_ID_List != null)
            {
                OnPreEvent_Get_Space_asset_By_SPACE_ID_List(i_Params_Get_Space_asset_By_SPACE_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ID_List(i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Space_asset_By_SPACE_ID_List
            if (OnPostEvent_Get_Space_asset_By_SPACE_ID_List != null)
            {
                OnPostEvent_Get_Space_asset_By_SPACE_ID_List(oList_Space_asset, i_Params_Get_Space_asset_By_SPACE_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ID_List", i_Params_Get_Space_asset_By_SPACE_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_List(Params_Get_Space_asset_By_ASSET_ID_List i_Params_Get_Space_asset_By_ASSET_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_ASSET_ID_List", i_Params_Get_Space_asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_ASSET_ID_List(i_Params_Get_Space_asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_ASSET_ID_List", i_Params_Get_Space_asset_By_ASSET_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_List
        public List<Space> Get_Space_By_FLOOR_ID_List(Params_Get_Space_By_FLOOR_ID_List i_Params_Get_Space_By_FLOOR_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID_List", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID_List(i_Params_Get_Space_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID_List", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            return oList_Space;
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
        #region Get_Asset_By_Where
        public List<Asset> Get_Asset_By_Where(Params_Get_Asset_By_Where i_Params_Get_Asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where", i_Params_Get_Asset_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Asset_By_Where.OWNER_ID == null || i_Params_Get_Asset_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Asset_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Asset_By_Where.OFFSET == null)
            {
                i_Params_Get_Asset_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Asset_By_Where.FETCH_NEXT == null || i_Params_Get_Asset_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Asset_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where(i_Params_Get_Asset_By_Where.NAME, i_Params_Get_Asset_By_Where.GLTF_URL, i_Params_Get_Asset_By_Where.OWNER_ID, i_Params_Get_Asset_By_Where.OFFSET, i_Params_Get_Asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where", i_Params_Get_Asset_By_Where_json, false);
            }
            return oList_Asset;
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
        #region Get_Space_asset_By_Where
        public List<Space_asset> Get_Space_asset_By_Where(Params_Get_Space_asset_By_Where i_Params_Get_Space_asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_Where", i_Params_Get_Space_asset_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_asset_By_Where.OWNER_ID == null || i_Params_Get_Space_asset_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Space_asset_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_asset_By_Where.OFFSET == null)
            {
                i_Params_Get_Space_asset_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Space_asset_By_Where.FETCH_NEXT == null || i_Params_Get_Space_asset_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_asset_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_Where(i_Params_Get_Space_asset_By_Where.CUSTOM_NAME, i_Params_Get_Space_asset_By_Where.ASSET_ICON, i_Params_Get_Space_asset_By_Where.EXTERNAL_ID, i_Params_Get_Space_asset_By_Where.OWNER_ID, i_Params_Get_Space_asset_By_Where.OFFSET, i_Params_Get_Space_asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            i_Params_Get_Space_asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_Where", i_Params_Get_Space_asset_By_Where_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_By_Where
        public List<Space> Get_Space_By_Where(Params_Get_Space_By_Where i_Params_Get_Space_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where", i_Params_Get_Space_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_By_Where.OWNER_ID == null || i_Params_Get_Space_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Space_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_By_Where.OFFSET == null)
            {
                i_Params_Get_Space_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Space_By_Where.FETCH_NEXT == null || i_Params_Get_Space_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where(i_Params_Get_Space_By_Where.NAME, i_Params_Get_Space_By_Where.UNIT, i_Params_Get_Space_By_Where.OWNER_ID, i_Params_Get_Space_By_Where.OFFSET, i_Params_Get_Space_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where", i_Params_Get_Space_By_Where_json, false);
            }
            return oList_Space;
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
        #region Get_Asset_By_Where_In_List
        public List<Asset> Get_Asset_By_Where_In_List(Params_Get_Asset_By_Where_In_List i_Params_Get_Asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where_In_List", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Asset_By_Where_In_List.OWNER_ID == null || i_Params_Get_Asset_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Asset_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Asset_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Asset_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where_In_List(i_Params_Get_Asset_By_Where_In_List.NAME, i_Params_Get_Asset_By_Where_In_List.GLTF_URL, i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST, i_Params_Get_Asset_By_Where_In_List.OWNER_ID, i_Params_Get_Asset_By_Where_In_List.OFFSET, i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where_In_List", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            return oList_Asset;
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
        #region Get_Space_asset_By_Where_In_List
        public List<Space_asset> Get_Space_asset_By_Where_In_List(Params_Get_Space_asset_By_Where_In_List i_Params_Get_Space_asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_Where_In_List", i_Params_Get_Space_asset_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID == null || i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST = new List<string>();
            }
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_Where_In_List(i_Params_Get_Space_asset_By_Where_In_List.CUSTOM_NAME, i_Params_Get_Space_asset_By_Where_In_List.ASSET_ICON, i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID, i_Params_Get_Space_asset_By_Where_In_List.OFFSET, i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            i_Params_Get_Space_asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_Where_In_List", i_Params_Get_Space_asset_By_Where_In_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_By_Where_In_List
        public List<Space> Get_Space_By_Where_In_List(Params_Get_Space_By_Where_In_List i_Params_Get_Space_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where_In_List", i_Params_Get_Space_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_By_Where_In_List.OWNER_ID == null || i_Params_Get_Space_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Space_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Space_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Space_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Space_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST == null)
            {
                i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST = new List<long?>();
            }
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where_In_List(i_Params_Get_Space_By_Where_In_List.NAME, i_Params_Get_Space_By_Where_In_List.UNIT, i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST, i_Params_Get_Space_By_Where_In_List.OWNER_ID, i_Params_Get_Space_By_Where_In_List.OFFSET, i_Params_Get_Space_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where_In_List", i_Params_Get_Space_By_Where_In_List_json, false);
            }
            return oList_Space;
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
        #region Delete_Asset
        public void Delete_Asset(Params_Delete_Asset i_Params_Delete_Asset)
        {
            var i_Params_Delete_Asset_json = JsonConvert.SerializeObject(i_Params_Delete_Asset);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset", i_Params_Delete_Asset_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_ASSET_ID oParams_Get_Asset_By_ASSET_ID = new Params_Get_Asset_By_ASSET_ID
                {
                    ASSET_ID = i_Params_Delete_Asset.ASSET_ID
                };
                _Asset = Get_Asset_By_ASSET_ID(oParams_Get_Asset_By_ASSET_ID);
                if (_Asset != null)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset(i_Params_Delete_Asset.ASSET_ID);
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
                OnPostEvent_General("Delete_Asset", i_Params_Delete_Asset_json, false);
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
        #region Delete_Space_asset
        public void Delete_Space_asset(Params_Delete_Space_asset i_Params_Delete_Space_asset)
        {
            var i_Params_Delete_Space_asset_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset", i_Params_Delete_Space_asset_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_SPACE_ASSET_ID oParams_Get_Space_asset_By_SPACE_ASSET_ID = new Params_Get_Space_asset_By_SPACE_ASSET_ID
                {
                    SPACE_ASSET_ID = i_Params_Delete_Space_asset.SPACE_ASSET_ID
                };
                _Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(oParams_Get_Space_asset_By_SPACE_ASSET_ID);
                if (_Space_asset != null)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset(i_Params_Delete_Space_asset.SPACE_ASSET_ID);
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
                OnPostEvent_General("Delete_Space_asset", i_Params_Delete_Space_asset_json, false);
            }
        }
        #endregion
        #region Delete_Space
        public void Delete_Space(Params_Delete_Space i_Params_Delete_Space)
        {
            var i_Params_Delete_Space_json = JsonConvert.SerializeObject(i_Params_Delete_Space);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space", i_Params_Delete_Space_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_SPACE_ID oParams_Get_Space_By_SPACE_ID = new Params_Get_Space_By_SPACE_ID
                {
                    SPACE_ID = i_Params_Delete_Space.SPACE_ID
                };
                _Space = Get_Space_By_SPACE_ID(oParams_Get_Space_By_SPACE_ID);
                if (_Space != null)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space(i_Params_Delete_Space.SPACE_ID);
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
                OnPostEvent_General("Delete_Space", i_Params_Delete_Space_json, false);
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
        #region Delete_Asset_By_OWNER_ID
        public void Delete_Asset_By_OWNER_ID(Params_Delete_Asset_By_OWNER_ID i_Params_Delete_Asset_By_OWNER_ID)
        {
            var i_Params_Delete_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_OWNER_ID", i_Params_Delete_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_OWNER_ID oParams_Get_Asset_By_OWNER_ID = new Params_Get_Asset_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Asset_By_OWNER_ID.OWNER_ID
                };
                _List_Asset = Get_Asset_By_OWNER_ID(oParams_Get_Asset_By_OWNER_ID);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_OWNER_ID(i_Params_Delete_Asset_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Asset_By_OWNER_ID", i_Params_Delete_Asset_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        public void Delete_Asset_By_ASSET_TYPE_SETUP_ID(Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_ASSET_TYPE_SETUP_ID oParams_Get_Asset_By_ASSET_TYPE_SETUP_ID = new Params_Get_Asset_By_ASSET_TYPE_SETUP_ID
                {
                    ASSET_TYPE_SETUP_ID = i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID
                };
                _List_Asset = Get_Asset_By_ASSET_TYPE_SETUP_ID(oParams_Get_Asset_By_ASSET_TYPE_SETUP_ID);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_ASSET_TYPE_SETUP_ID(i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        public void Delete_Asset_By_OWNER_ID_IS_DELETED(Params_Delete_Asset_By_OWNER_ID_IS_DELETED i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_OWNER_ID_IS_DELETED oParams_Get_Asset_By_OWNER_ID_IS_DELETED = new Params_Get_Asset_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Asset = Get_Asset_By_OWNER_ID_IS_DELETED(oParams_Get_Asset_By_OWNER_ID_IS_DELETED);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_OWNER_ID_IS_DELETED(i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json, false);
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
        #region Delete_Space_asset_By_OWNER_ID
        public void Delete_Space_asset_By_OWNER_ID(Params_Delete_Space_asset_By_OWNER_ID i_Params_Delete_Space_asset_By_OWNER_ID)
        {
            var i_Params_Delete_Space_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_OWNER_ID", i_Params_Delete_Space_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_OWNER_ID oParams_Get_Space_asset_By_OWNER_ID = new Params_Get_Space_asset_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Space_asset_By_OWNER_ID.OWNER_ID
                };
                _List_Space_asset = Get_Space_asset_By_OWNER_ID(oParams_Get_Space_asset_By_OWNER_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_OWNER_ID(i_Params_Delete_Space_asset_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Space_asset_By_OWNER_ID", i_Params_Delete_Space_asset_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_SPACE_ID
        public void Delete_Space_asset_By_SPACE_ID(Params_Delete_Space_asset_By_SPACE_ID i_Params_Delete_Space_asset_By_SPACE_ID)
        {
            var i_Params_Delete_Space_asset_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_SPACE_ID", i_Params_Delete_Space_asset_By_SPACE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_SPACE_ID oParams_Get_Space_asset_By_SPACE_ID = new Params_Get_Space_asset_By_SPACE_ID
                {
                    SPACE_ID = i_Params_Delete_Space_asset_By_SPACE_ID.SPACE_ID
                };
                _List_Space_asset = Get_Space_asset_By_SPACE_ID(oParams_Get_Space_asset_By_SPACE_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_SPACE_ID(i_Params_Delete_Space_asset_By_SPACE_ID.SPACE_ID);
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
                OnPostEvent_General("Delete_Space_asset_By_SPACE_ID", i_Params_Delete_Space_asset_By_SPACE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_ASSET_ID
        public void Delete_Space_asset_By_ASSET_ID(Params_Delete_Space_asset_By_ASSET_ID i_Params_Delete_Space_asset_By_ASSET_ID)
        {
            var i_Params_Delete_Space_asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_ASSET_ID", i_Params_Delete_Space_asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_ASSET_ID oParams_Get_Space_asset_By_ASSET_ID = new Params_Get_Space_asset_By_ASSET_ID
                {
                    ASSET_ID = i_Params_Delete_Space_asset_By_ASSET_ID.ASSET_ID
                };
                _List_Space_asset = Get_Space_asset_By_ASSET_ID(oParams_Get_Space_asset_By_ASSET_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_ASSET_ID(i_Params_Delete_Space_asset_By_ASSET_ID.ASSET_ID);
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
                OnPostEvent_General("Delete_Space_asset_By_ASSET_ID", i_Params_Delete_Space_asset_By_ASSET_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_OWNER_ID_IS_DELETED
        public void Delete_Space_asset_By_OWNER_ID_IS_DELETED(Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_OWNER_ID_IS_DELETED oParams_Get_Space_asset_By_OWNER_ID_IS_DELETED = new Params_Get_Space_asset_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Space_asset = Get_Space_asset_By_OWNER_ID_IS_DELETED(oParams_Get_Space_asset_By_OWNER_ID_IS_DELETED);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_OWNER_ID_IS_DELETED(i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_EXTERNAL_ID
        public void Delete_Space_asset_By_EXTERNAL_ID(Params_Delete_Space_asset_By_EXTERNAL_ID i_Params_Delete_Space_asset_By_EXTERNAL_ID)
        {
            var i_Params_Delete_Space_asset_By_EXTERNAL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_EXTERNAL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_EXTERNAL_ID", i_Params_Delete_Space_asset_By_EXTERNAL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_EXTERNAL_ID oParams_Get_Space_asset_By_EXTERNAL_ID = new Params_Get_Space_asset_By_EXTERNAL_ID
                {
                    EXTERNAL_ID = i_Params_Delete_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID
                };
                _List_Space_asset = Get_Space_asset_By_EXTERNAL_ID(oParams_Get_Space_asset_By_EXTERNAL_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_EXTERNAL_ID(i_Params_Delete_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID);
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
                OnPostEvent_General("Delete_Space_asset_By_EXTERNAL_ID", i_Params_Delete_Space_asset_By_EXTERNAL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public void Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL)
        {
            var i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL oParams_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL = new Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
                {
                    IS_MERAKI_WIFI_SIGNAL = i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL
                };
                _List_Space_asset = Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(oParams_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL);
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
                OnPostEvent_General("Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
        }
        #endregion
        #region Delete_Space_By_OWNER_ID
        public void Delete_Space_By_OWNER_ID(Params_Delete_Space_By_OWNER_ID i_Params_Delete_Space_By_OWNER_ID)
        {
            var i_Params_Delete_Space_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_By_OWNER_ID", i_Params_Delete_Space_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_OWNER_ID oParams_Get_Space_By_OWNER_ID = new Params_Get_Space_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Space_By_OWNER_ID.OWNER_ID
                };
                _List_Space = Get_Space_By_OWNER_ID(oParams_Get_Space_By_OWNER_ID);
                if (_List_Space != null && _List_Space.Count > 0)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_By_OWNER_ID(i_Params_Delete_Space_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Space_By_OWNER_ID", i_Params_Delete_Space_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_By_FLOOR_ID
        public void Delete_Space_By_FLOOR_ID(Params_Delete_Space_By_FLOOR_ID i_Params_Delete_Space_By_FLOOR_ID)
        {
            var i_Params_Delete_Space_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_By_FLOOR_ID", i_Params_Delete_Space_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_FLOOR_ID oParams_Get_Space_By_FLOOR_ID = new Params_Get_Space_By_FLOOR_ID
                {
                    FLOOR_ID = i_Params_Delete_Space_By_FLOOR_ID.FLOOR_ID
                };
                _List_Space = Get_Space_By_FLOOR_ID(oParams_Get_Space_By_FLOOR_ID);
                if (_List_Space != null && _List_Space.Count > 0)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_By_FLOOR_ID(i_Params_Delete_Space_By_FLOOR_ID.FLOOR_ID);
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
                OnPostEvent_General("Delete_Space_By_FLOOR_ID", i_Params_Delete_Space_By_FLOOR_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_By_OWNER_ID_IS_DELETED
        public void Delete_Space_By_OWNER_ID_IS_DELETED(Params_Delete_Space_By_OWNER_ID_IS_DELETED i_Params_Delete_Space_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Space_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Space_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_OWNER_ID_IS_DELETED oParams_Get_Space_By_OWNER_ID_IS_DELETED = new Params_Get_Space_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Space = Get_Space_By_OWNER_ID_IS_DELETED(oParams_Get_Space_By_OWNER_ID_IS_DELETED);
                if (_List_Space != null && _List_Space.Count > 0)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_By_OWNER_ID_IS_DELETED(i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Space_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_By_OWNER_ID_IS_DELETED_json, false);
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
        #region Edit_Asset
        public void Edit_Asset(Asset i_Asset)
        {
            var i_Asset_json = JsonConvert.SerializeObject(i_Asset);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Asset.ASSET_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Asset", i_Asset_json, false);
            }
            #region Body Section.
            if (i_Asset.ASSET_ID == null || i_Asset.ASSET_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Asset");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Asset.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Asset.IS_DELETED = false;
            }
            else
            {
                _Asset = Get_Asset_By_ASSET_ID(new Params_Get_Asset_By_ASSET_ID
                {
                    ASSET_ID = i_Asset.ASSET_ID
                });
            }
            i_Asset.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Asset.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Asset.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Asset_Execution)
            {
                _Stop_Edit_Asset_Execution = false;
                return;
            }
            i_Asset.ASSET_ID = _AppContext.Edit_Asset
            (
                i_Asset.ASSET_ID,
                i_Asset.ASSET_TYPE_SETUP_ID,
                i_Asset.NAME,
                i_Asset.GLTF_URL,
                i_Asset.ENTRY_USER_ID,
                i_Asset.ENTRY_DATE,
                i_Asset.LAST_UPDATE,
                i_Asset.IS_DELETED,
                i_Asset.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Asset", i_Asset_json, false);
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
        #region Edit_Space_asset
        public void Edit_Space_asset(Space_asset i_Space_asset)
        {
            var i_Space_asset_json = JsonConvert.SerializeObject(i_Space_asset);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Space_asset.SPACE_ASSET_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space_asset", i_Space_asset_json, false);
            }
            #region Body Section.
            if (i_Space_asset.SPACE_ASSET_ID == null || i_Space_asset.SPACE_ASSET_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Space_asset");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Space_asset.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Space_asset.IS_DELETED = false;
            }
            else
            {
                _Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(new Params_Get_Space_asset_By_SPACE_ASSET_ID
                {
                    SPACE_ASSET_ID = i_Space_asset.SPACE_ASSET_ID
                });
            }
            i_Space_asset.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Space_asset.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Space_asset.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Space_asset_Execution)
            {
                _Stop_Edit_Space_asset_Execution = false;
                return;
            }
            i_Space_asset.SPACE_ASSET_ID = _AppContext.Edit_Space_asset
            (
                i_Space_asset.SPACE_ASSET_ID,
                i_Space_asset.SPACE_ID,
                i_Space_asset.ASSET_ID,
                i_Space_asset.EXTERNAL_ID,
                i_Space_asset.IS_MERAKI_WIFI_SIGNAL,
                i_Space_asset.CUSTOM_NAME,
                i_Space_asset.POSITION_X,
                i_Space_asset.POSITION_Y,
                i_Space_asset.POSITION_Z,
                i_Space_asset.SCALE_MULTIPLIER,
                i_Space_asset.ROTATE_X,
                i_Space_asset.ROTATE_Y,
                i_Space_asset.ROTATE_Z,
                i_Space_asset.ASSET_ICON,
                i_Space_asset.ENTRY_USER_ID,
                i_Space_asset.ENTRY_DATE,
                i_Space_asset.LAST_UPDATE,
                i_Space_asset.IS_DELETED,
                i_Space_asset.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space_asset", i_Space_asset_json, false);
            }
        }
        #endregion
        #region Edit_Space
        public void Edit_Space(Space i_Space)
        {
            var i_Space_json = JsonConvert.SerializeObject(i_Space);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Space.SPACE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space", i_Space_json, false);
            }
            #region Body Section.
            if (i_Space.SPACE_ID == null || i_Space.SPACE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Space");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Space.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Space.IS_DELETED = false;
            }
            else
            {
                _Space = Get_Space_By_SPACE_ID(new Params_Get_Space_By_SPACE_ID
                {
                    SPACE_ID = i_Space.SPACE_ID
                });
            }
            i_Space.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Space.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Space.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Space
            if (OnPreEvent_Edit_Space != null)
            {
                OnPreEvent_Edit_Space(i_Space, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Space_Execution)
            {
                _Stop_Edit_Space_Execution = false;
                return;
            }
            i_Space.SPACE_ID = _AppContext.Edit_Space
            (
                i_Space.SPACE_ID,
                i_Space.FLOOR_ID,
                i_Space.NAME,
                i_Space.AREA,
                i_Space.UNIT,
                i_Space.OCCUPANT_LOAD_FACTOR,
                i_Space.ENTRY_USER_ID,
                i_Space.ENTRY_DATE,
                i_Space.LAST_UPDATE,
                i_Space.IS_DELETED,
                i_Space.OWNER_ID
            );
            #region PostEvent_Edit_Space
            if (OnPostEvent_Edit_Space != null)
            {
                OnPostEvent_Edit_Space(i_Space, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space", i_Space_json, false);
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
        #region Edit_Asset_List
        public void Edit_Asset_List(Params_Edit_Asset_List i_Params_Edit_Asset_List)
        {
            var i_Params_Edit_Asset_List_json = JsonConvert.SerializeObject(i_Params_Edit_Asset_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Asset_List", i_Params_Edit_Asset_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Asset_List.List_To_Edit != null)
            {
                i_Params_Edit_Asset_List.List_Failed_Edit = new List<Asset>();
                if (i_Params_Edit_Asset_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oAsset in i_Params_Edit_Asset_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Asset(oAsset);
                        }
                        catch
                        {
                            i_Params_Edit_Asset_List.List_Failed_Edit.Add(oAsset);
                        }
                    }
                }
                i_Params_Edit_Asset_List.List_To_Edit = i_Params_Edit_Asset_List.List_To_Edit.Except(i_Params_Edit_Asset_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Asset_List.List_To_Delete != null)
            {
                i_Params_Edit_Asset_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Asset_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Asset_ID in i_Params_Edit_Asset_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Asset(new Params_Delete_Asset()
                            {
                                ASSET_ID = Asset_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Asset_List.List_Failed_Delete.Add(Asset_ID);
                        }
                    }
                }
                i_Params_Edit_Asset_List.List_To_Delete = i_Params_Edit_Asset_List.List_To_Delete.Except(i_Params_Edit_Asset_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Asset_List", i_Params_Edit_Asset_List_json, false);
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
        #region Edit_Space_asset_List
        public void Edit_Space_asset_List(Params_Edit_Space_asset_List i_Params_Edit_Space_asset_List)
        {
            var i_Params_Edit_Space_asset_List_json = JsonConvert.SerializeObject(i_Params_Edit_Space_asset_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space_asset_List", i_Params_Edit_Space_asset_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Space_asset_List.List_To_Edit != null)
            {
                i_Params_Edit_Space_asset_List.List_Failed_Edit = new List<Space_asset>();
                if (i_Params_Edit_Space_asset_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSpace_asset in i_Params_Edit_Space_asset_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Space_asset(oSpace_asset);
                        }
                        catch
                        {
                            i_Params_Edit_Space_asset_List.List_Failed_Edit.Add(oSpace_asset);
                        }
                    }
                }
                i_Params_Edit_Space_asset_List.List_To_Edit = i_Params_Edit_Space_asset_List.List_To_Edit.Except(i_Params_Edit_Space_asset_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Space_asset_List.List_To_Delete != null)
            {
                i_Params_Edit_Space_asset_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Space_asset_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Space_asset_ID in i_Params_Edit_Space_asset_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Space_asset(new Params_Delete_Space_asset()
                            {
                                SPACE_ASSET_ID = Space_asset_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Space_asset_List.List_Failed_Delete.Add(Space_asset_ID);
                        }
                    }
                }
                i_Params_Edit_Space_asset_List.List_To_Delete = i_Params_Edit_Space_asset_List.List_To_Delete.Except(i_Params_Edit_Space_asset_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space_asset_List", i_Params_Edit_Space_asset_List_json, false);
            }
        }
        #endregion
        #region Edit_Space_List
        public void Edit_Space_List(Params_Edit_Space_List i_Params_Edit_Space_List)
        {
            var i_Params_Edit_Space_List_json = JsonConvert.SerializeObject(i_Params_Edit_Space_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space_List", i_Params_Edit_Space_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Space_List.List_To_Edit != null)
            {
                i_Params_Edit_Space_List.List_Failed_Edit = new List<Space>();
                if (i_Params_Edit_Space_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSpace in i_Params_Edit_Space_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Space(oSpace);
                        }
                        catch
                        {
                            i_Params_Edit_Space_List.List_Failed_Edit.Add(oSpace);
                        }
                    }
                }
                i_Params_Edit_Space_List.List_To_Edit = i_Params_Edit_Space_List.List_To_Edit.Except(i_Params_Edit_Space_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Space_List.List_To_Delete != null)
            {
                i_Params_Edit_Space_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Space_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Space_ID in i_Params_Edit_Space_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Space(new Params_Delete_Space()
                            {
                                SPACE_ID = Space_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Space_List.List_Failed_Delete.Add(Space_ID);
                        }
                    }
                }
                i_Params_Edit_Space_List.List_To_Delete = i_Params_Edit_Space_List.List_To_Delete.Except(i_Params_Edit_Space_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space_List", i_Params_Edit_Space_List_json, false);
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