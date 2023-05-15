using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
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
        #region Get_Space_asset_By_SPACE_ASSET_ID_Adv
        public Space_asset Get_Space_asset_By_SPACE_ASSET_ID_Adv(Params_Get_Space_asset_By_SPACE_ASSET_ID i_Params_Get_Space_asset_By_SPACE_ASSET_ID)
        {
            Space_asset oSpace_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_Adv", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Space_asset oDBEntry = _AppContext.Get_Space_asset_By_SPACE_ASSET_ID_Adv(i_Params_Get_Space_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space_asset").Replace("%2", i_Params_Get_Space_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID.ToString()));
            }
            oSpace_asset = new Space_asset();
            Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
            oSpace_asset.Asset = new Asset();
            Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
            oSpace_asset.Space = new Space();
            Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_Adv", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json, false);
            }
            return oSpace_asset;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_Adv
        public Floor Get_Floor_By_FLOOR_ID_Adv(Params_Get_Floor_By_FLOOR_ID i_Params_Get_Floor_By_FLOOR_ID)
        {
            Floor oFloor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID_Adv", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            DALC.Floor oDBEntry = _AppContext.Get_Floor_By_FLOOR_ID_Adv(i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Floor").Replace("%2", i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID.ToString()));
            }
            oFloor = new Floor();
            Props.Copy_Prop_Values(oDBEntry, oFloor);
            oFloor.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID_Adv", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            return oFloor;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_Adv
        public Space Get_Space_By_SPACE_ID_Adv(Params_Get_Space_By_SPACE_ID i_Params_Get_Space_By_SPACE_ID)
        {
            Space oSpace = null;
            var i_Params_Get_Space_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID_Adv", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            #region Body Section.
            DALC.Space oDBEntry = _AppContext.Get_Space_By_SPACE_ID_Adv(i_Params_Get_Space_By_SPACE_ID.SPACE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space").Replace("%2", i_Params_Get_Space_By_SPACE_ID.SPACE_ID.ToString()));
            }
            oSpace = new Space();
            Props.Copy_Prop_Values(oDBEntry, oSpace);
            oSpace.Floor = new Floor();
            Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID_Adv", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            return oSpace;
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
        #region Get_Space_asset_By_SPACE_ASSET_ID_List_Adv
        public List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(Params_Get_Space_asset_By_SPACE_ASSET_ID_List i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_List_Adv", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_List_Adv", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_List_Adv
        public List<Floor> Get_Floor_By_FLOOR_ID_List_Adv(Params_Get_Floor_By_FLOOR_ID_List i_Params_Get_Floor_By_FLOOR_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID_List_Adv", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_FLOOR_ID_List_Adv(i_Params_Get_Floor_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID_List_Adv", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_List_Adv
        public List<Space> Get_Space_By_SPACE_ID_List_Adv(Params_Get_Space_By_SPACE_ID_List i_Params_Get_Space_By_SPACE_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID_List_Adv", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_SPACE_ID_List_Adv(i_Params_Get_Space_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID_List_Adv", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            return oList_Space;
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
        #region Get_Space_asset_By_OWNER_ID_Adv
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_Adv(Params_Get_Space_asset_By_OWNER_ID i_Params_Get_Space_asset_By_OWNER_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_OWNER_ID_Adv", i_Params_Get_Space_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_OWNER_ID_Adv(i_Params_Get_Space_asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_OWNER_ID_Adv", i_Params_Get_Space_asset_By_OWNER_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID_Adv
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_Adv(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ID_Adv", i_Params_Get_Space_asset_By_SPACE_ID_json, false);
            }
            #region PreEvent_Get_Space_asset_By_SPACE_ID_Adv
            if (OnPreEvent_Get_Space_asset_By_SPACE_ID_Adv != null)
            {
                OnPreEvent_Get_Space_asset_By_SPACE_ID_Adv(i_Params_Get_Space_asset_By_SPACE_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ID_Adv(i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Space_asset_By_SPACE_ID_Adv
            if (OnPostEvent_Get_Space_asset_By_SPACE_ID_Adv != null)
            {
                OnPostEvent_Get_Space_asset_By_SPACE_ID_Adv(oList_Space_asset, i_Params_Get_Space_asset_By_SPACE_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ID_Adv", i_Params_Get_Space_asset_By_SPACE_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_Adv
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_Adv(Params_Get_Space_asset_By_ASSET_ID i_Params_Get_Space_asset_By_ASSET_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_ASSET_ID_Adv", i_Params_Get_Space_asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_ASSET_ID_Adv(i_Params_Get_Space_asset_By_ASSET_ID.ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_ASSET_ID_Adv", i_Params_Get_Space_asset_By_ASSET_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Space_asset_By_OWNER_ID_IS_DELETED i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID_Adv
        public List<Space_asset> Get_Space_asset_By_EXTERNAL_ID_Adv(Params_Get_Space_asset_By_EXTERNAL_ID i_Params_Get_Space_asset_By_EXTERNAL_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_EXTERNAL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_EXTERNAL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_EXTERNAL_ID_Adv", i_Params_Get_Space_asset_By_EXTERNAL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_EXTERNAL_ID_Adv(i_Params_Get_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_EXTERNAL_ID_Adv", i_Params_Get_Space_asset_By_EXTERNAL_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv
        public List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv(Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv", i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv(i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_Adv", i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED_Adv
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Floor_By_OWNER_ID_IS_DELETED i_Params_Get_Floor_By_OWNER_ID_IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_Adv
        public List<Floor> Get_Floor_By_OWNER_ID_Adv(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID_Adv", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID_Adv(i_Params_Get_Floor_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID_Adv", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_Adv
        public List<Floor> Get_Floor_By_ENTITY_ID_Adv(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID_Adv", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID_Adv(i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID_Adv", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_Adv
        public List<Space> Get_Space_By_OWNER_ID_Adv(Params_Get_Space_By_OWNER_ID i_Params_Get_Space_By_OWNER_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID_Adv", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID_Adv(i_Params_Get_Space_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID_Adv", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_Adv
        public List<Space> Get_Space_By_FLOOR_ID_Adv(Params_Get_Space_By_FLOOR_ID i_Params_Get_Space_By_FLOOR_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID_Adv", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID_Adv(i_Params_Get_Space_By_FLOOR_ID.FLOOR_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID_Adv", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED_Adv
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Space_By_OWNER_ID_IS_DELETED i_Params_Get_Space_By_OWNER_ID_IS_DELETED)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Space_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space;
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
        #region Get_Space_asset_By_SPACE_ID_List_Adv
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_List_Adv(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ID_List_Adv", i_Params_Get_Space_asset_By_SPACE_ID_List_json, false);
            }
            #region PreEvent_Get_Space_asset_By_SPACE_ID_List_Adv
            if (OnPreEvent_Get_Space_asset_By_SPACE_ID_List_Adv != null)
            {
                OnPreEvent_Get_Space_asset_By_SPACE_ID_List_Adv(i_Params_Get_Space_asset_By_SPACE_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ID_List_Adv(i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Space_asset_By_SPACE_ID_List_Adv
            if (OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Adv != null)
            {
                OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Adv(oList_Space_asset, i_Params_Get_Space_asset_By_SPACE_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ID_List_Adv", i_Params_Get_Space_asset_By_SPACE_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List_Adv
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_List_Adv(Params_Get_Space_asset_By_ASSET_ID_List i_Params_Get_Space_asset_By_ASSET_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_ASSET_ID_List_Adv", i_Params_Get_Space_asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_ASSET_ID_List_Adv(i_Params_Get_Space_asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_ASSET_ID_List_Adv", i_Params_Get_Space_asset_By_ASSET_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_List_Adv
        public List<Floor> Get_Floor_By_ENTITY_ID_List_Adv(Params_Get_Floor_By_ENTITY_ID_List i_Params_Get_Floor_By_ENTITY_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID_List_Adv", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID_List_Adv(i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID_List_Adv", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_List_Adv
        public List<Space> Get_Space_By_FLOOR_ID_List_Adv(Params_Get_Space_By_FLOOR_ID_List i_Params_Get_Space_By_FLOOR_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID_List_Adv", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID_List_Adv(i_Params_Get_Space_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID_List_Adv", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            return oList_Space;
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
        #region Get_Space_asset_By_Where_Adv
        public List<Space_asset> Get_Space_asset_By_Where_Adv(Params_Get_Space_asset_By_Where i_Params_Get_Space_asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_Where_Adv", i_Params_Get_Space_asset_By_Where_json, false);
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
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_Where_Adv(i_Params_Get_Space_asset_By_Where.CUSTOM_NAME, i_Params_Get_Space_asset_By_Where.ASSET_ICON, i_Params_Get_Space_asset_By_Where.EXTERNAL_ID, i_Params_Get_Space_asset_By_Where.OWNER_ID, i_Params_Get_Space_asset_By_Where.OFFSET, i_Params_Get_Space_asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            i_Params_Get_Space_asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_Where_Adv", i_Params_Get_Space_asset_By_Where_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_Where_Adv
        public List<Floor> Get_Floor_By_Where_Adv(Params_Get_Floor_By_Where i_Params_Get_Floor_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where_Adv", i_Params_Get_Floor_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Floor_By_Where.OWNER_ID == null || i_Params_Get_Floor_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Floor_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Floor_By_Where.OFFSET == null)
            {
                i_Params_Get_Floor_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Floor_By_Where.FETCH_NEXT == null || i_Params_Get_Floor_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Floor_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where_Adv(i_Params_Get_Floor_By_Where.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where.UNIT, i_Params_Get_Floor_By_Where.NAME, i_Params_Get_Floor_By_Where.OWNER_ID, i_Params_Get_Floor_By_Where.OFFSET, i_Params_Get_Floor_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where_Adv", i_Params_Get_Floor_By_Where_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_Where_Adv
        public List<Space> Get_Space_By_Where_Adv(Params_Get_Space_By_Where i_Params_Get_Space_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where_Adv", i_Params_Get_Space_By_Where_json, false);
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
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where_Adv(i_Params_Get_Space_By_Where.NAME, i_Params_Get_Space_By_Where.UNIT, i_Params_Get_Space_By_Where.OWNER_ID, i_Params_Get_Space_By_Where.OFFSET, i_Params_Get_Space_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where_Adv", i_Params_Get_Space_By_Where_json, false);
            }
            return oList_Space;
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
        #region Get_Space_asset_By_Where_In_List_Adv
        public List<Space_asset> Get_Space_asset_By_Where_In_List_Adv(Params_Get_Space_asset_By_Where_In_List i_Params_Get_Space_asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_Where_In_List_Adv", i_Params_Get_Space_asset_By_Where_In_List_json, false);
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
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_Where_In_List_Adv(i_Params_Get_Space_asset_By_Where_In_List.CUSTOM_NAME, i_Params_Get_Space_asset_By_Where_In_List.ASSET_ICON, i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID, i_Params_Get_Space_asset_By_Where_In_List.OFFSET, i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oSpace_asset.Asset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry.Asset, oSpace_asset.Asset);
                        oSpace_asset.Space = new Space();
                        Props.Copy_Prop_Values(oDBEntry.Space, oSpace_asset.Space);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            i_Params_Get_Space_asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_Where_In_List_Adv", i_Params_Get_Space_asset_By_Where_In_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Floor_By_Where_In_List_Adv
        public List<Floor> Get_Floor_By_Where_In_List_Adv(Params_Get_Floor_By_Where_In_List i_Params_Get_Floor_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where_In_List_Adv", i_Params_Get_Floor_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Floor_By_Where_In_List.OWNER_ID == null || i_Params_Get_Floor_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Floor_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Floor_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Floor_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where_In_List_Adv(i_Params_Get_Floor_By_Where_In_List.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.UNIT, i_Params_Get_Floor_By_Where_In_List.NAME, i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Floor_By_Where_In_List.OWNER_ID, i_Params_Get_Floor_By_Where_In_List.OFFSET, i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where_In_List_Adv", i_Params_Get_Floor_By_Where_In_List_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Space_By_Where_In_List_Adv
        public List<Space> Get_Space_By_Where_In_List_Adv(Params_Get_Space_By_Where_In_List i_Params_Get_Space_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where_In_List_Adv", i_Params_Get_Space_By_Where_In_List_json, false);
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
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where_In_List_Adv(i_Params_Get_Space_By_Where_In_List.NAME, i_Params_Get_Space_By_Where_In_List.UNIT, i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST, i_Params_Get_Space_By_Where_In_List.OWNER_ID, i_Params_Get_Space_By_Where_In_List.OFFSET, i_Params_Get_Space_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where_In_List_Adv", i_Params_Get_Space_By_Where_In_List_json, false);
            }
            return oList_Space;
        }
        #endregion
    }
}
