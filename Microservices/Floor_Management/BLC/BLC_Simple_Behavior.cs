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
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Space_asset _Space_asset;
        private List<Space_asset> _List_Space_asset;
        private Floor _Floor;
        private List<Floor> _List_Floor;
        private Space _Space;
        private List<Space> _List_Space;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Space_asset_Execution;
        private bool _Stop_Delete_Space_asset_Execution;
        private bool _Stop_Edit_Floor_Execution;
        private bool _Stop_Delete_Floor_Execution;
        private bool _Stop_Edit_Space_Execution;
        private bool _Stop_Delete_Space_Execution;
        #endregion
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
        #region Get_Floor_By_FLOOR_ID
        public Floor Get_Floor_By_FLOOR_ID(Params_Get_Floor_By_FLOOR_ID i_Params_Get_Floor_By_FLOOR_ID)
        {
            Floor oFloor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            DALC.Floor oDBEntry = _AppContext.Get_Floor_By_FLOOR_ID(i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Floor").Replace("%2", i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID.ToString()));
            }
            oFloor = new Floor();
            Props.Copy_Prop_Values(oDBEntry, oFloor);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            return oFloor;
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
        #region Get_Floor_By_FLOOR_ID_List
        public List<Floor> Get_Floor_By_FLOOR_ID_List(Params_Get_Floor_By_FLOOR_ID_List i_Params_Get_Floor_By_FLOOR_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID_List", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_FLOOR_ID_List(i_Params_Get_Floor_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID_List", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            return oList_Floor;
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
        #region Get_Floor_By_OWNER_ID_IS_DELETED
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED(Params_Get_Floor_By_OWNER_ID_IS_DELETED i_Params_Get_Floor_By_OWNER_ID_IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID_IS_DELETED(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID
        public List<Floor> Get_Floor_By_OWNER_ID(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID(i_Params_Get_Floor_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID
        public List<Floor> Get_Floor_By_ENTITY_ID(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            #region PreEvent_Get_Floor_By_ENTITY_ID
            if (OnPreEvent_Get_Floor_By_ENTITY_ID != null)
            {
                OnPreEvent_Get_Floor_By_ENTITY_ID(i_Params_Get_Floor_By_ENTITY_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID(i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Floor_By_ENTITY_ID
            if (OnPostEvent_Get_Floor_By_ENTITY_ID != null)
            {
                OnPostEvent_Get_Floor_By_ENTITY_ID(oList_Floor, i_Params_Get_Floor_By_ENTITY_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            return oList_Floor;
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
        #region Get_Floor_By_ENTITY_ID_List
        public List<Floor> Get_Floor_By_ENTITY_ID_List(Params_Get_Floor_By_ENTITY_ID_List i_Params_Get_Floor_By_ENTITY_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID_List", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID_List(i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID_List", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            return oList_Floor;
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
        #region Get_Floor_By_Where
        public List<Floor> Get_Floor_By_Where(Params_Get_Floor_By_Where i_Params_Get_Floor_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where", i_Params_Get_Floor_By_Where_json, false);
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
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where(i_Params_Get_Floor_By_Where.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where.UNIT, i_Params_Get_Floor_By_Where.NAME, i_Params_Get_Floor_By_Where.OWNER_ID, i_Params_Get_Floor_By_Where.OFFSET, i_Params_Get_Floor_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where", i_Params_Get_Floor_By_Where_json, false);
            }
            return oList_Floor;
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
        #region Get_Floor_By_Where_In_List
        public List<Floor> Get_Floor_By_Where_In_List(Params_Get_Floor_By_Where_In_List i_Params_Get_Floor_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where_In_List", i_Params_Get_Floor_By_Where_In_List_json, false);
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
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where_In_List(i_Params_Get_Floor_By_Where_In_List.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.UNIT, i_Params_Get_Floor_By_Where_In_List.NAME, i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Floor_By_Where_In_List.OWNER_ID, i_Params_Get_Floor_By_Where_In_List.OFFSET, i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where_In_List", i_Params_Get_Floor_By_Where_In_List_json, false);
            }
            return oList_Floor;
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
        #region Delete_Floor
        public void Delete_Floor(Params_Delete_Floor i_Params_Delete_Floor)
        {
            var i_Params_Delete_Floor_json = JsonConvert.SerializeObject(i_Params_Delete_Floor);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor", i_Params_Delete_Floor_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_FLOOR_ID oParams_Get_Floor_By_FLOOR_ID = new Params_Get_Floor_By_FLOOR_ID
                {
                    FLOOR_ID = i_Params_Delete_Floor.FLOOR_ID
                };
                _Floor = Get_Floor_By_FLOOR_ID(oParams_Get_Floor_By_FLOOR_ID);
                if (_Floor != null)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor(i_Params_Delete_Floor.FLOOR_ID);
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
                OnPostEvent_General("Delete_Floor", i_Params_Delete_Floor_json, false);
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
        #region Delete_Floor_By_OWNER_ID_IS_DELETED
        public void Delete_Floor_By_OWNER_ID_IS_DELETED(Params_Delete_Floor_By_OWNER_ID_IS_DELETED i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor_By_OWNER_ID_IS_DELETED", i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_OWNER_ID_IS_DELETED oParams_Get_Floor_By_OWNER_ID_IS_DELETED = new Params_Get_Floor_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Floor = Get_Floor_By_OWNER_ID_IS_DELETED(oParams_Get_Floor_By_OWNER_ID_IS_DELETED);
                if (_List_Floor != null && _List_Floor.Count > 0)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor_By_OWNER_ID_IS_DELETED(i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Floor_By_OWNER_ID_IS_DELETED", i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID
        public void Delete_Floor_By_OWNER_ID(Params_Delete_Floor_By_OWNER_ID i_Params_Delete_Floor_By_OWNER_ID)
        {
            var i_Params_Delete_Floor_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Floor_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor_By_OWNER_ID", i_Params_Delete_Floor_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_OWNER_ID oParams_Get_Floor_By_OWNER_ID = new Params_Get_Floor_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Floor_By_OWNER_ID.OWNER_ID
                };
                _List_Floor = Get_Floor_By_OWNER_ID(oParams_Get_Floor_By_OWNER_ID);
                if (_List_Floor != null && _List_Floor.Count > 0)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor_By_OWNER_ID(i_Params_Delete_Floor_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Floor_By_OWNER_ID", i_Params_Delete_Floor_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Floor_By_ENTITY_ID
        public void Delete_Floor_By_ENTITY_ID(Params_Delete_Floor_By_ENTITY_ID i_Params_Delete_Floor_By_ENTITY_ID)
        {
            var i_Params_Delete_Floor_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Floor_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor_By_ENTITY_ID", i_Params_Delete_Floor_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_ENTITY_ID oParams_Get_Floor_By_ENTITY_ID = new Params_Get_Floor_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Floor_By_ENTITY_ID.ENTITY_ID
                };
                _List_Floor = Get_Floor_By_ENTITY_ID(oParams_Get_Floor_By_ENTITY_ID);
                if (_List_Floor != null && _List_Floor.Count > 0)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor_By_ENTITY_ID(i_Params_Delete_Floor_By_ENTITY_ID.ENTITY_ID);
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
                OnPostEvent_General("Delete_Floor_By_ENTITY_ID", i_Params_Delete_Floor_By_ENTITY_ID_json, false);
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
        #region Edit_Floor
        public void Edit_Floor(Floor i_Floor)
        {
            var i_Floor_json = JsonConvert.SerializeObject(i_Floor);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Floor.FLOOR_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Floor", i_Floor_json, false);
            }
            #region Body Section.
            if (i_Floor.FLOOR_ID == null || i_Floor.FLOOR_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Floor");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Floor.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Floor.IS_DELETED = false;
            }
            else
            {
                _Floor = Get_Floor_By_FLOOR_ID(new Params_Get_Floor_By_FLOOR_ID
                {
                    FLOOR_ID = i_Floor.FLOOR_ID
                });
            }
            i_Floor.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Floor.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Floor.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Floor_Execution)
            {
                _Stop_Edit_Floor_Execution = false;
                return;
            }
            i_Floor.FLOOR_ID = _AppContext.Edit_Floor
            (
                i_Floor.FLOOR_ID,
                i_Floor.ENTITY_ID,
                i_Floor.FLOOR_NUMBER,
                i_Floor.SHELL_GLTF_URL,
                i_Floor.CLIPPED_GLTF_URL,
                i_Floor.ADVANCED_GLTF_URL,
                i_Floor.AREA,
                i_Floor.UNIT,
                i_Floor.NAME,
                i_Floor.ENTRY_USER_ID,
                i_Floor.ENTRY_DATE,
                i_Floor.LAST_UPDATE,
                i_Floor.IS_DELETED,
                i_Floor.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Floor", i_Floor_json, false);
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
        #region Edit_Floor_List
        public void Edit_Floor_List(Params_Edit_Floor_List i_Params_Edit_Floor_List)
        {
            var i_Params_Edit_Floor_List_json = JsonConvert.SerializeObject(i_Params_Edit_Floor_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Floor_List", i_Params_Edit_Floor_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Floor_List.List_To_Edit != null)
            {
                i_Params_Edit_Floor_List.List_Failed_Edit = new List<Floor>();
                if (i_Params_Edit_Floor_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oFloor in i_Params_Edit_Floor_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Floor(oFloor);
                        }
                        catch
                        {
                            i_Params_Edit_Floor_List.List_Failed_Edit.Add(oFloor);
                        }
                    }
                }
                i_Params_Edit_Floor_List.List_To_Edit = i_Params_Edit_Floor_List.List_To_Edit.Except(i_Params_Edit_Floor_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Floor_List.List_To_Delete != null)
            {
                i_Params_Edit_Floor_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Floor_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Floor_ID in i_Params_Edit_Floor_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Floor(new Params_Delete_Floor()
                            {
                                FLOOR_ID = Floor_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Floor_List.List_Failed_Delete.Add(Floor_ID);
                        }
                    }
                }
                i_Params_Edit_Floor_List.List_To_Delete = i_Params_Edit_Floor_List.List_To_Delete.Except(i_Params_Edit_Floor_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Floor_List", i_Params_Edit_Floor_List_json, false);
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
    }
}