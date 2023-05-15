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
        private Area _Area;
        private List<Area> _List_Area;
        private Area_view _Area_view;
        private List<Area_view> _List_Area_view;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Area_Execution;
        private bool _Stop_Delete_Area_Execution;
        private bool _Stop_Edit_Area_view_Execution;
        private bool _Stop_Delete_Area_view_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        #endregion
        #endregion
        #region Get_Area_By_AREA_ID
        public Area Get_Area_By_AREA_ID(Params_Get_Area_By_AREA_ID i_Params_Get_Area_By_AREA_ID)
        {
            Area oArea = null;
            var i_Params_Get_Area_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_AREA_ID", i_Params_Get_Area_By_AREA_ID_json, false);
            }
            #region PreEvent_Get_Area_By_AREA_ID
            if (OnPreEvent_Get_Area_By_AREA_ID != null)
            {
                OnPreEvent_Get_Area_By_AREA_ID(i_Params_Get_Area_By_AREA_ID);
            }
            #endregion
            #region Body Section.
            DALC.Area oDBEntry = _AppContext.Get_Area_By_AREA_ID(i_Params_Get_Area_By_AREA_ID.AREA_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area").Replace("%2", i_Params_Get_Area_By_AREA_ID.AREA_ID.ToString()));
            }
            oArea = new Area();
            Props.Copy_Prop_Values(oDBEntry, oArea);
            #endregion
            #region PostEvent_Get_Area_By_AREA_ID
            if (OnPostEvent_Get_Area_By_AREA_ID != null)
            {
                OnPostEvent_Get_Area_By_AREA_ID(oArea, i_Params_Get_Area_By_AREA_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_AREA_ID", i_Params_Get_Area_By_AREA_ID_json, false);
            }
            return oArea;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID
        public Area_view Get_Area_view_By_AREA_VIEW_ID(Params_Get_Area_view_By_AREA_VIEW_ID i_Params_Get_Area_view_By_AREA_VIEW_ID)
        {
            Area_view oArea_view = null;
            var i_Params_Get_Area_view_By_AREA_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_VIEW_ID", i_Params_Get_Area_view_By_AREA_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Area_view oDBEntry = _AppContext.Get_Area_view_By_AREA_VIEW_ID(i_Params_Get_Area_view_By_AREA_VIEW_ID.AREA_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area_view").Replace("%2", i_Params_Get_Area_view_By_AREA_VIEW_ID.AREA_VIEW_ID.ToString()));
            }
            oArea_view = new Area_view();
            Props.Copy_Prop_Values(oDBEntry, oArea_view);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_VIEW_ID", i_Params_Get_Area_view_By_AREA_VIEW_ID_json, false);
            }
            return oArea_view;
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
        #region Get_Area_By_AREA_ID_List
        public List<Area> Get_Area_By_AREA_ID_List(Params_Get_Area_By_AREA_ID_List i_Params_Get_Area_By_AREA_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_AREA_ID_List", i_Params_Get_Area_By_AREA_ID_List_json, false);
            }
            #region PreEvent_Get_Area_By_AREA_ID_List
            if (OnPreEvent_Get_Area_By_AREA_ID_List != null)
            {
                OnPreEvent_Get_Area_By_AREA_ID_List(i_Params_Get_Area_By_AREA_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_AREA_ID_List(i_Params_Get_Area_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Area_By_AREA_ID_List
            if (OnPostEvent_Get_Area_By_AREA_ID_List != null)
            {
                OnPostEvent_Get_Area_By_AREA_ID_List(oList_Area, i_Params_Get_Area_By_AREA_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_AREA_ID_List", i_Params_Get_Area_By_AREA_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_List
        public List<Area_view> Get_Area_view_By_AREA_VIEW_ID_List(Params_Get_Area_view_By_AREA_VIEW_ID_List i_Params_Get_Area_view_By_AREA_VIEW_ID_List)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_AREA_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_VIEW_ID_List", i_Params_Get_Area_view_By_AREA_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_AREA_VIEW_ID_List(i_Params_Get_Area_view_By_AREA_VIEW_ID_List.AREA_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_VIEW_ID_List", i_Params_Get_Area_view_By_AREA_VIEW_ID_List_json, false);
            }
            return oList_Area_view;
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
        #region Get_Area_By_OWNER_ID_IS_DELETED
        public List<Area> Get_Area_By_OWNER_ID_IS_DELETED(Params_Get_Area_By_OWNER_ID_IS_DELETED i_Params_Get_Area_By_OWNER_ID_IS_DELETED)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_OWNER_ID_IS_DELETED(i_Params_Get_Area_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_OWNER_ID
        public List<Area> Get_Area_By_OWNER_ID(Params_Get_Area_By_OWNER_ID i_Params_Get_Area_By_OWNER_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_OWNER_ID", i_Params_Get_Area_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_OWNER_ID(i_Params_Get_Area_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_OWNER_ID", i_Params_Get_Area_By_OWNER_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID
        public List<Area> Get_Area_By_DISTRICT_ID(Params_Get_Area_By_DISTRICT_ID i_Params_Get_Area_By_DISTRICT_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_DISTRICT_ID", i_Params_Get_Area_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_DISTRICT_ID(i_Params_Get_Area_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_DISTRICT_ID", i_Params_Get_Area_By_DISTRICT_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID
        public List<Area> Get_Area_By_REGION_ID(Params_Get_Area_By_REGION_ID i_Params_Get_Area_By_REGION_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_REGION_ID", i_Params_Get_Area_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_REGION_ID(i_Params_Get_Area_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_REGION_ID", i_Params_Get_Area_By_REGION_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID
        public List<Area> Get_Area_By_TOP_LEVEL_ID(Params_Get_Area_By_TOP_LEVEL_ID i_Params_Get_Area_By_TOP_LEVEL_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_TOP_LEVEL_ID", i_Params_Get_Area_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_TOP_LEVEL_ID(i_Params_Get_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_TOP_LEVEL_ID", i_Params_Get_Area_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID
        public List<Area_view> Get_Area_view_By_OWNER_ID(Params_Get_Area_view_By_OWNER_ID i_Params_Get_Area_view_By_OWNER_ID)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_OWNER_ID", i_Params_Get_Area_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_OWNER_ID(i_Params_Get_Area_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_OWNER_ID", i_Params_Get_Area_view_By_OWNER_ID_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID
        public List<Area_view> Get_Area_view_By_AREA_ID(Params_Get_Area_view_By_AREA_ID i_Params_Get_Area_view_By_AREA_ID)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_ID", i_Params_Get_Area_view_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_AREA_ID(i_Params_Get_Area_view_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_ID", i_Params_Get_Area_view_By_AREA_ID_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID(Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_VIEW_TYPE_SETUP_ID(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID_IS_DELETED
        public List<Area_view> Get_Area_view_By_OWNER_ID_IS_DELETED(Params_Get_Area_view_By_OWNER_ID_IS_DELETED i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_OWNER_ID_IS_DELETED(i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area_view;
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
        #region Get_Area_By_DISTRICT_ID_List
        public List<Area> Get_Area_By_DISTRICT_ID_List(Params_Get_Area_By_DISTRICT_ID_List i_Params_Get_Area_By_DISTRICT_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_DISTRICT_ID_List", i_Params_Get_Area_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_DISTRICT_ID_List(i_Params_Get_Area_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_DISTRICT_ID_List", i_Params_Get_Area_By_DISTRICT_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_List
        public List<Area> Get_Area_By_REGION_ID_List(Params_Get_Area_By_REGION_ID_List i_Params_Get_Area_By_REGION_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_REGION_ID_List", i_Params_Get_Area_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_REGION_ID_List(i_Params_Get_Area_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_REGION_ID_List", i_Params_Get_Area_By_REGION_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List
        public List<Area> Get_Area_By_TOP_LEVEL_ID_List(Params_Get_Area_By_TOP_LEVEL_ID_List i_Params_Get_Area_By_TOP_LEVEL_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_TOP_LEVEL_ID_List", i_Params_Get_Area_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_TOP_LEVEL_ID_List(i_Params_Get_Area_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_TOP_LEVEL_ID_List", i_Params_Get_Area_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID_List
        public List<Area_view> Get_Area_view_By_AREA_ID_List(Params_Get_Area_view_By_AREA_ID_List i_Params_Get_Area_view_By_AREA_ID_List)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_ID_List", i_Params_Get_Area_view_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_AREA_ID_List(i_Params_Get_Area_view_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_ID_List", i_Params_Get_Area_view_By_AREA_ID_List_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_List(Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID_List", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_VIEW_TYPE_SETUP_ID_List(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID_List", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Area_view;
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
        #region Get_Area_By_Where
        public List<Area> Get_Area_By_Where(Params_Get_Area_By_Where i_Params_Get_Area_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_Where", i_Params_Get_Area_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_By_Where.OWNER_ID == null || i_Params_Get_Area_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Area_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_By_Where.OFFSET == null)
            {
                i_Params_Get_Area_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Area_By_Where.FETCH_NEXT == null || i_Params_Get_Area_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_Where(i_Params_Get_Area_By_Where.NAME, i_Params_Get_Area_By_Where.LOCATION, i_Params_Get_Area_By_Where.UNIT, i_Params_Get_Area_By_Where.IMAGE_URL, i_Params_Get_Area_By_Where.LOGO_URL, i_Params_Get_Area_By_Where.SOLID_GLTF_URL, i_Params_Get_Area_By_Where.AREA_COLOR, i_Params_Get_Area_By_Where.BORDER_COLOR, i_Params_Get_Area_By_Where.STUDY_ZONE_NAME, i_Params_Get_Area_By_Where.OWNER_ID, i_Params_Get_Area_By_Where.OFFSET, i_Params_Get_Area_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            i_Params_Get_Area_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_Where", i_Params_Get_Area_By_Where_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where
        public List<Area_view> Get_Area_view_By_Where(Params_Get_Area_view_By_Where i_Params_Get_Area_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_Where", i_Params_Get_Area_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_view_By_Where.OWNER_ID == null || i_Params_Get_Area_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Area_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Area_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Area_view_By_Where.FETCH_NEXT == null || i_Params_Get_Area_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_Where(i_Params_Get_Area_view_By_Where.DESCRIPTION, i_Params_Get_Area_view_By_Where.OWNER_ID, i_Params_Get_Area_view_By_Where.OFFSET, i_Params_Get_Area_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            i_Params_Get_Area_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_Where", i_Params_Get_Area_view_By_Where_json, false);
            }
            return oList_Area_view;
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
        #region Get_Area_By_Where_In_List
        public List<Area> Get_Area_By_Where_In_List(Params_Get_Area_By_Where_In_List i_Params_Get_Area_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_Where_In_List", i_Params_Get_Area_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_By_Where_In_List.OWNER_ID == null || i_Params_Get_Area_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Area_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Area_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Area_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Area_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_Where_In_List(i_Params_Get_Area_By_Where_In_List.NAME, i_Params_Get_Area_By_Where_In_List.LOCATION, i_Params_Get_Area_By_Where_In_List.UNIT, i_Params_Get_Area_By_Where_In_List.IMAGE_URL, i_Params_Get_Area_By_Where_In_List.LOGO_URL, i_Params_Get_Area_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Area_By_Where_In_List.AREA_COLOR, i_Params_Get_Area_By_Where_In_List.BORDER_COLOR, i_Params_Get_Area_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Area_By_Where_In_List.OWNER_ID, i_Params_Get_Area_By_Where_In_List.OFFSET, i_Params_Get_Area_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            i_Params_Get_Area_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_Where_In_List", i_Params_Get_Area_By_Where_In_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where_In_List
        public List<Area_view> Get_Area_view_By_Where_In_List(Params_Get_Area_view_By_Where_In_List i_Params_Get_Area_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_Where_In_List", i_Params_Get_Area_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Area_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Area_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Area_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Area_view_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Area_view_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Area_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_Where_In_List(i_Params_Get_Area_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Area_view_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Area_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Area_view_By_Where_In_List.OWNER_ID, i_Params_Get_Area_view_By_Where_In_List.OFFSET, i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            i_Params_Get_Area_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_Where_In_List", i_Params_Get_Area_view_By_Where_In_List_json, false);
            }
            return oList_Area_view;
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
        #region Delete_Area
        public void Delete_Area(Params_Delete_Area i_Params_Delete_Area)
        {
            var i_Params_Delete_Area_json = JsonConvert.SerializeObject(i_Params_Delete_Area);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area", i_Params_Delete_Area_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_AREA_ID oParams_Get_Area_By_AREA_ID = new Params_Get_Area_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Area.AREA_ID
                };
                _Area = Get_Area_By_AREA_ID(oParams_Get_Area_By_AREA_ID);
                if (_Area != null)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area(i_Params_Delete_Area.AREA_ID);
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
                OnPostEvent_General("Delete_Area", i_Params_Delete_Area_json, false);
            }
        }
        #endregion
        #region Delete_Area_view
        public void Delete_Area_view(Params_Delete_Area_view i_Params_Delete_Area_view)
        {
            var i_Params_Delete_Area_view_json = JsonConvert.SerializeObject(i_Params_Delete_Area_view);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_view", i_Params_Delete_Area_view_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_view_By_AREA_VIEW_ID oParams_Get_Area_view_By_AREA_VIEW_ID = new Params_Get_Area_view_By_AREA_VIEW_ID
                {
                    AREA_VIEW_ID = i_Params_Delete_Area_view.AREA_VIEW_ID
                };
                _Area_view = Get_Area_view_By_AREA_VIEW_ID(oParams_Get_Area_view_By_AREA_VIEW_ID);
                if (_Area_view != null)
                {
                    if (_Stop_Delete_Area_view_Execution)
                    {
                        _Stop_Delete_Area_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_view(i_Params_Delete_Area_view.AREA_VIEW_ID);
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
                OnPostEvent_General("Delete_Area_view", i_Params_Delete_Area_view_json, false);
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
        #region Delete_Area_By_OWNER_ID_IS_DELETED
        public void Delete_Area_By_OWNER_ID_IS_DELETED(Params_Delete_Area_By_OWNER_ID_IS_DELETED i_Params_Delete_Area_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Area_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_OWNER_ID_IS_DELETED oParams_Get_Area_By_OWNER_ID_IS_DELETED = new Params_Get_Area_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Area = Get_Area_By_OWNER_ID_IS_DELETED(oParams_Get_Area_By_OWNER_ID_IS_DELETED);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_OWNER_ID_IS_DELETED(i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Area_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_OWNER_ID
        public void Delete_Area_By_OWNER_ID(Params_Delete_Area_By_OWNER_ID i_Params_Delete_Area_By_OWNER_ID)
        {
            var i_Params_Delete_Area_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_OWNER_ID", i_Params_Delete_Area_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_OWNER_ID oParams_Get_Area_By_OWNER_ID = new Params_Get_Area_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Area_By_OWNER_ID.OWNER_ID
                };
                _List_Area = Get_Area_By_OWNER_ID(oParams_Get_Area_By_OWNER_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_OWNER_ID(i_Params_Delete_Area_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Area_By_OWNER_ID", i_Params_Delete_Area_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_DISTRICT_ID
        public void Delete_Area_By_DISTRICT_ID(Params_Delete_Area_By_DISTRICT_ID i_Params_Delete_Area_By_DISTRICT_ID)
        {
            var i_Params_Delete_Area_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_DISTRICT_ID", i_Params_Delete_Area_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_DISTRICT_ID oParams_Get_Area_By_DISTRICT_ID = new Params_Get_Area_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_Area_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_Area = Get_Area_By_DISTRICT_ID(oParams_Get_Area_By_DISTRICT_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_DISTRICT_ID(i_Params_Delete_Area_By_DISTRICT_ID.DISTRICT_ID);
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
                OnPostEvent_General("Delete_Area_By_DISTRICT_ID", i_Params_Delete_Area_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_REGION_ID
        public void Delete_Area_By_REGION_ID(Params_Delete_Area_By_REGION_ID i_Params_Delete_Area_By_REGION_ID)
        {
            var i_Params_Delete_Area_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_REGION_ID", i_Params_Delete_Area_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_REGION_ID oParams_Get_Area_By_REGION_ID = new Params_Get_Area_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_Area_By_REGION_ID.REGION_ID
                };
                _List_Area = Get_Area_By_REGION_ID(oParams_Get_Area_By_REGION_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_REGION_ID(i_Params_Delete_Area_By_REGION_ID.REGION_ID);
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
                OnPostEvent_General("Delete_Area_By_REGION_ID", i_Params_Delete_Area_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_TOP_LEVEL_ID
        public void Delete_Area_By_TOP_LEVEL_ID(Params_Delete_Area_By_TOP_LEVEL_ID i_Params_Delete_Area_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_Area_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_TOP_LEVEL_ID", i_Params_Delete_Area_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_TOP_LEVEL_ID oParams_Get_Area_By_TOP_LEVEL_ID = new Params_Get_Area_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_Area = Get_Area_By_TOP_LEVEL_ID(oParams_Get_Area_By_TOP_LEVEL_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_TOP_LEVEL_ID(i_Params_Delete_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
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
                OnPostEvent_General("Delete_Area_By_TOP_LEVEL_ID", i_Params_Delete_Area_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_view_By_OWNER_ID
        public void Delete_Area_view_By_OWNER_ID(Params_Delete_Area_view_By_OWNER_ID i_Params_Delete_Area_view_By_OWNER_ID)
        {
            var i_Params_Delete_Area_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_view_By_OWNER_ID", i_Params_Delete_Area_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_view_By_OWNER_ID oParams_Get_Area_view_By_OWNER_ID = new Params_Get_Area_view_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Area_view_By_OWNER_ID.OWNER_ID
                };
                _List_Area_view = Get_Area_view_By_OWNER_ID(oParams_Get_Area_view_By_OWNER_ID);
                if (_List_Area_view != null && _List_Area_view.Count > 0)
                {
                    if (_Stop_Delete_Area_view_Execution)
                    {
                        _Stop_Delete_Area_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_view_By_OWNER_ID(i_Params_Delete_Area_view_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Area_view_By_OWNER_ID", i_Params_Delete_Area_view_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_view_By_AREA_ID
        public void Delete_Area_view_By_AREA_ID(Params_Delete_Area_view_By_AREA_ID i_Params_Delete_Area_view_By_AREA_ID)
        {
            var i_Params_Delete_Area_view_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_view_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_view_By_AREA_ID", i_Params_Delete_Area_view_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_view_By_AREA_ID oParams_Get_Area_view_By_AREA_ID = new Params_Get_Area_view_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Area_view_By_AREA_ID.AREA_ID
                };
                _List_Area_view = Get_Area_view_By_AREA_ID(oParams_Get_Area_view_By_AREA_ID);
                if (_List_Area_view != null && _List_Area_view.Count > 0)
                {
                    if (_Stop_Delete_Area_view_Execution)
                    {
                        _Stop_Delete_Area_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_view_By_AREA_ID(i_Params_Delete_Area_view_By_AREA_ID.AREA_ID);
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
                OnPostEvent_General("Delete_Area_view_By_AREA_ID", i_Params_Delete_Area_view_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Area_view_By_VIEW_TYPE_SETUP_ID(Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_view_By_VIEW_TYPE_SETUP_ID", i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID oParams_Get_Area_view_By_VIEW_TYPE_SETUP_ID = new Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID
                {
                    VIEW_TYPE_SETUP_ID = i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID
                };
                _List_Area_view = Get_Area_view_By_VIEW_TYPE_SETUP_ID(oParams_Get_Area_view_By_VIEW_TYPE_SETUP_ID);
                if (_List_Area_view != null && _List_Area_view.Count > 0)
                {
                    if (_Stop_Delete_Area_view_Execution)
                    {
                        _Stop_Delete_Area_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_view_By_VIEW_TYPE_SETUP_ID(i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_Area_view_By_VIEW_TYPE_SETUP_ID", i_Params_Delete_Area_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_view_By_OWNER_ID_IS_DELETED
        public void Delete_Area_view_By_OWNER_ID_IS_DELETED(Params_Delete_Area_view_By_OWNER_ID_IS_DELETED i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_view_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_view_By_OWNER_ID_IS_DELETED oParams_Get_Area_view_By_OWNER_ID_IS_DELETED = new Params_Get_Area_view_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Area_view = Get_Area_view_By_OWNER_ID_IS_DELETED(oParams_Get_Area_view_By_OWNER_ID_IS_DELETED);
                if (_List_Area_view != null && _List_Area_view.Count > 0)
                {
                    if (_Stop_Delete_Area_view_Execution)
                    {
                        _Stop_Delete_Area_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_view_By_OWNER_ID_IS_DELETED(i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Area_view_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_view_By_OWNER_ID_IS_DELETED_json, false);
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
        #region Edit_Area
        public void Edit_Area(Area i_Area)
        {
            var i_Area_json = JsonConvert.SerializeObject(i_Area);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Area.AREA_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area", i_Area_json, false);
            }
            #region Body Section.
            if (i_Area.AREA_ID == null || i_Area.AREA_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Area");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Area.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Area.IS_DELETED = false;
            }
            else
            {
                _Area = Get_Area_By_AREA_ID(new Params_Get_Area_By_AREA_ID
                {
                    AREA_ID = i_Area.AREA_ID
                });
            }
            i_Area.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Area.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Area.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Area
            if (OnPreEvent_Edit_Area != null)
            {
                OnPreEvent_Edit_Area(i_Area, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Area_Execution)
            {
                _Stop_Edit_Area_Execution = false;
                return;
            }
            i_Area.AREA_ID = _AppContext.Edit_Area
            (
                i_Area.AREA_ID,
                i_Area.DISTRICT_ID,
                i_Area.REGION_ID,
                i_Area.TOP_LEVEL_ID,
                i_Area.NAME,
                i_Area.LOCATION,
                i_Area.AREA,
                i_Area.UNIT,
                i_Area.SCALE,
                i_Area.ROTATIONX,
                i_Area.ROTATIONY,
                i_Area.ROTATIONZ,
                i_Area.GLTF_LATITUDE,
                i_Area.GLTF_LONGITUDE,
                i_Area.CENTER_LATITUDE,
                i_Area.CENTER_LONGITUDE,
                i_Area.RADIUS_IN_METERS,
                i_Area.IMAGE_URL,
                i_Area.LOGO_URL,
                i_Area.SOLID_GLTF_URL,
                i_Area.AREA_COLOR,
                i_Area.BORDER_COLOR,
                i_Area.STUDY_ZONE_NAME,
                i_Area.ENTRY_USER_ID,
                i_Area.ENTRY_DATE,
                i_Area.LAST_UPDATE,
                i_Area.IS_DELETED,
                i_Area.OWNER_ID
            );
            #region PostEvent_Edit_Area
            if (OnPostEvent_Edit_Area != null)
            {
                OnPostEvent_Edit_Area(i_Area, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area", i_Area_json, false);
            }
        }
        #endregion
        #region Edit_Area_view
        public void Edit_Area_view(Area_view i_Area_view)
        {
            var i_Area_view_json = JsonConvert.SerializeObject(i_Area_view);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Area_view.AREA_VIEW_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_view", i_Area_view_json, false);
            }
            #region Body Section.
            if (i_Area_view.AREA_VIEW_ID == null || i_Area_view.AREA_VIEW_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Area_view");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Area_view.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Area_view.IS_DELETED = false;
            }
            else
            {
                _Area_view = Get_Area_view_By_AREA_VIEW_ID(new Params_Get_Area_view_By_AREA_VIEW_ID
                {
                    AREA_VIEW_ID = i_Area_view.AREA_VIEW_ID
                });
            }
            i_Area_view.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Area_view.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Area_view.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Area_view_Execution)
            {
                _Stop_Edit_Area_view_Execution = false;
                return;
            }
            i_Area_view.AREA_VIEW_ID = _AppContext.Edit_Area_view
            (
                i_Area_view.AREA_VIEW_ID,
                i_Area_view.AREA_ID,
                i_Area_view.VIEW_TYPE_SETUP_ID,
                i_Area_view.PITCH,
                i_Area_view.BEARING,
                i_Area_view.ZOOM,
                i_Area_view.LATITUDE,
                i_Area_view.LONGITUDE,
                i_Area_view.ENTRY_USER_ID,
                i_Area_view.ENTRY_DATE,
                i_Area_view.LAST_UPDATE,
                i_Area_view.IS_DELETED,
                i_Area_view.OWNER_ID,
                i_Area_view.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_view", i_Area_view_json, false);
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
        #region Edit_Area_List
        public void Edit_Area_List(Params_Edit_Area_List i_Params_Edit_Area_List)
        {
            var i_Params_Edit_Area_List_json = JsonConvert.SerializeObject(i_Params_Edit_Area_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_List", i_Params_Edit_Area_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Area_List.List_To_Edit != null)
            {
                i_Params_Edit_Area_List.List_Failed_Edit = new List<Area>();
                if (i_Params_Edit_Area_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oArea in i_Params_Edit_Area_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Area(oArea);
                        }
                        catch
                        {
                            i_Params_Edit_Area_List.List_Failed_Edit.Add(oArea);
                        }
                    }
                }
                i_Params_Edit_Area_List.List_To_Edit = i_Params_Edit_Area_List.List_To_Edit.Except(i_Params_Edit_Area_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Area_List.List_To_Delete != null)
            {
                i_Params_Edit_Area_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Area_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Area_ID in i_Params_Edit_Area_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Area(new Params_Delete_Area()
                            {
                                AREA_ID = Area_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Area_List.List_Failed_Delete.Add(Area_ID);
                        }
                    }
                }
                i_Params_Edit_Area_List.List_To_Delete = i_Params_Edit_Area_List.List_To_Delete.Except(i_Params_Edit_Area_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_List", i_Params_Edit_Area_List_json, false);
            }
        }
        #endregion
        #region Edit_Area_view_List
        public void Edit_Area_view_List(Params_Edit_Area_view_List i_Params_Edit_Area_view_List)
        {
            var i_Params_Edit_Area_view_List_json = JsonConvert.SerializeObject(i_Params_Edit_Area_view_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_view_List", i_Params_Edit_Area_view_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Area_view_List.List_To_Edit != null)
            {
                i_Params_Edit_Area_view_List.List_Failed_Edit = new List<Area_view>();
                if (i_Params_Edit_Area_view_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oArea_view in i_Params_Edit_Area_view_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Area_view(oArea_view);
                        }
                        catch
                        {
                            i_Params_Edit_Area_view_List.List_Failed_Edit.Add(oArea_view);
                        }
                    }
                }
                i_Params_Edit_Area_view_List.List_To_Edit = i_Params_Edit_Area_view_List.List_To_Edit.Except(i_Params_Edit_Area_view_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Area_view_List.List_To_Delete != null)
            {
                i_Params_Edit_Area_view_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Area_view_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Area_view_ID in i_Params_Edit_Area_view_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Area_view(new Params_Delete_Area_view()
                            {
                                AREA_VIEW_ID = Area_view_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Area_view_List.List_Failed_Delete.Add(Area_view_ID);
                        }
                    }
                }
                i_Params_Edit_Area_view_List.List_To_Delete = i_Params_Edit_Area_view_List.List_To_Delete.Except(i_Params_Edit_Area_view_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_view_List", i_Params_Edit_Area_view_List_json, false);
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
    }
}