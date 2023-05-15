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
        #region Get_Region_By_REGION_ID_Adv
        public Region Get_Region_By_REGION_ID_Adv(Params_Get_Region_By_REGION_ID i_Params_Get_Region_By_REGION_ID)
        {
            Region oRegion = null;
            var i_Params_Get_Region_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_REGION_ID_Adv", i_Params_Get_Region_By_REGION_ID_json, false);
            }
            #region Body Section.
            DALC.Region oDBEntry = _AppContext.Get_Region_By_REGION_ID_Adv(i_Params_Get_Region_By_REGION_ID.REGION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Region").Replace("%2", i_Params_Get_Region_By_REGION_ID.REGION_ID.ToString()));
            }
            oRegion = new Region();
            Props.Copy_Prop_Values(oDBEntry, oRegion);
            oRegion.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_REGION_ID_Adv", i_Params_Get_Region_By_REGION_ID_json, false);
            }
            return oRegion;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_Adv
        public Region_view Get_Region_view_By_REGION_VIEW_ID_Adv(Params_Get_Region_view_By_REGION_VIEW_ID i_Params_Get_Region_view_By_REGION_VIEW_ID)
        {
            Region_view oRegion_view = null;
            var i_Params_Get_Region_view_By_REGION_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_VIEW_ID_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Region_view oDBEntry = _AppContext.Get_Region_view_By_REGION_VIEW_ID_Adv(i_Params_Get_Region_view_By_REGION_VIEW_ID.REGION_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Region_view").Replace("%2", i_Params_Get_Region_view_By_REGION_VIEW_ID.REGION_VIEW_ID.ToString()));
            }
            oRegion_view = new Region_view();
            Props.Copy_Prop_Values(oDBEntry, oRegion_view);
            oRegion_view.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
            oRegion_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_VIEW_ID_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_json, false);
            }
            return oRegion_view;
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
        #region Get_Region_By_REGION_ID_List_Adv
        public List<Region> Get_Region_By_REGION_ID_List_Adv(Params_Get_Region_By_REGION_ID_List i_Params_Get_Region_By_REGION_ID_List)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_REGION_ID_List_Adv", i_Params_Get_Region_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_REGION_ID_List_Adv(i_Params_Get_Region_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_REGION_ID_List_Adv", i_Params_Get_Region_By_REGION_ID_List_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List_Adv
        public List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List_Adv(Params_Get_Region_view_By_REGION_VIEW_ID_List i_Params_Get_Region_view_By_REGION_VIEW_ID_List)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_REGION_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_VIEW_ID_List_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_REGION_VIEW_ID_List_Adv(i_Params_Get_Region_view_By_REGION_VIEW_ID_List.REGION_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_VIEW_ID_List_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_List_json, false);
            }
            return oList_Region_view;
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
        #region Get_Region_By_OWNER_ID_IS_DELETED_Adv
        public List<Region> Get_Region_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Region_By_OWNER_ID_IS_DELETED i_Params_Get_Region_By_OWNER_ID_IS_DELETED)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Region_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Region_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_OWNER_ID_Adv
        public List<Region> Get_Region_By_OWNER_ID_Adv(Params_Get_Region_By_OWNER_ID i_Params_Get_Region_By_OWNER_ID)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_OWNER_ID_Adv", i_Params_Get_Region_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_OWNER_ID_Adv(i_Params_Get_Region_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_OWNER_ID_Adv", i_Params_Get_Region_By_OWNER_ID_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_Adv
        public List<Region> Get_Region_By_TOP_LEVEL_ID_Adv(Params_Get_Region_By_TOP_LEVEL_ID i_Params_Get_Region_By_TOP_LEVEL_ID)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_TOP_LEVEL_ID_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_TOP_LEVEL_ID_Adv(i_Params_Get_Region_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_TOP_LEVEL_ID_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_Adv
        public List<Region_view> Get_Region_view_By_OWNER_ID_Adv(Params_Get_Region_view_By_OWNER_ID i_Params_Get_Region_view_By_OWNER_ID)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_OWNER_ID_Adv", i_Params_Get_Region_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_OWNER_ID_Adv(i_Params_Get_Region_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_OWNER_ID_Adv", i_Params_Get_Region_view_By_OWNER_ID_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_Adv
        public List<Region_view> Get_Region_view_By_REGION_ID_Adv(Params_Get_Region_view_By_REGION_ID i_Params_Get_Region_view_By_REGION_ID)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_ID_Adv", i_Params_Get_Region_view_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_REGION_ID_Adv(i_Params_Get_Region_view_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_ID_Adv", i_Params_Get_Region_view_By_REGION_ID_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Region_view> Get_Region_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Region_view_By_OWNER_ID_IS_DELETED i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Region_view;
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
        #region Get_Region_By_TOP_LEVEL_ID_List_Adv
        public List<Region> Get_Region_By_TOP_LEVEL_ID_List_Adv(Params_Get_Region_By_TOP_LEVEL_ID_List i_Params_Get_Region_By_TOP_LEVEL_ID_List)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_Region_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_List_Adv
        public List<Region_view> Get_Region_view_By_REGION_ID_List_Adv(Params_Get_Region_view_By_REGION_ID_List i_Params_Get_Region_view_By_REGION_ID_List)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_ID_List_Adv", i_Params_Get_Region_view_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_REGION_ID_List_Adv(i_Params_Get_Region_view_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_ID_List_Adv", i_Params_Get_Region_view_By_REGION_ID_List_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Region_view;
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
        #region Get_Region_By_Where_Adv
        public List<Region> Get_Region_By_Where_Adv(Params_Get_Region_By_Where i_Params_Get_Region_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_Where_Adv", i_Params_Get_Region_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_By_Where.OWNER_ID == null || i_Params_Get_Region_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Region_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_By_Where.OFFSET == null)
            {
                i_Params_Get_Region_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Region_By_Where.FETCH_NEXT == null || i_Params_Get_Region_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_Where_Adv(i_Params_Get_Region_By_Where.NAME, i_Params_Get_Region_By_Where.LOCATION, i_Params_Get_Region_By_Where.UNIT, i_Params_Get_Region_By_Where.IMAGE_URL, i_Params_Get_Region_By_Where.LOGO_URL, i_Params_Get_Region_By_Where.AREA_COLOR, i_Params_Get_Region_By_Where.BORDER_COLOR, i_Params_Get_Region_By_Where.STUDY_ZONE_NAME, i_Params_Get_Region_By_Where.OWNER_ID, i_Params_Get_Region_By_Where.OFFSET, i_Params_Get_Region_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            i_Params_Get_Region_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_Where_Adv", i_Params_Get_Region_By_Where_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_Where_Adv
        public List<Region_view> Get_Region_view_By_Where_Adv(Params_Get_Region_view_By_Where i_Params_Get_Region_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_Where_Adv", i_Params_Get_Region_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_view_By_Where.OWNER_ID == null || i_Params_Get_Region_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Region_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Region_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Region_view_By_Where.FETCH_NEXT == null || i_Params_Get_Region_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_Where_Adv(i_Params_Get_Region_view_By_Where.DESCRIPTION, i_Params_Get_Region_view_By_Where.OWNER_ID, i_Params_Get_Region_view_By_Where.OFFSET, i_Params_Get_Region_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            i_Params_Get_Region_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_Where_Adv", i_Params_Get_Region_view_By_Where_json, false);
            }
            return oList_Region_view;
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
        #region Get_Region_By_Where_In_List_Adv
        public List<Region> Get_Region_By_Where_In_List_Adv(Params_Get_Region_By_Where_In_List i_Params_Get_Region_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_Where_In_List_Adv", i_Params_Get_Region_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_By_Where_In_List.OWNER_ID == null || i_Params_Get_Region_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Region_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Region_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Region_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Region_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Region_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Region_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_Where_In_List_Adv(i_Params_Get_Region_By_Where_In_List.NAME, i_Params_Get_Region_By_Where_In_List.LOCATION, i_Params_Get_Region_By_Where_In_List.UNIT, i_Params_Get_Region_By_Where_In_List.IMAGE_URL, i_Params_Get_Region_By_Where_In_List.LOGO_URL, i_Params_Get_Region_By_Where_In_List.AREA_COLOR, i_Params_Get_Region_By_Where_In_List.BORDER_COLOR, i_Params_Get_Region_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Region_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Region_By_Where_In_List.OWNER_ID, i_Params_Get_Region_By_Where_In_List.OFFSET, i_Params_Get_Region_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            i_Params_Get_Region_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_Where_In_List_Adv", i_Params_Get_Region_By_Where_In_List_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_Where_In_List_Adv
        public List<Region_view> Get_Region_view_By_Where_In_List_Adv(Params_Get_Region_view_By_Where_In_List i_Params_Get_Region_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_Where_In_List_Adv", i_Params_Get_Region_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Region_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Region_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Region_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Region_view_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Region_view_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Region_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Region_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_Where_In_List_Adv(i_Params_Get_Region_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Region_view_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Region_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Region_view_By_Where_In_List.OWNER_ID, i_Params_Get_Region_view_By_Where_In_List.OFFSET, i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            i_Params_Get_Region_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_Where_In_List_Adv", i_Params_Get_Region_view_By_Where_In_List_json, false);
            }
            return oList_Region_view;
        }
        #endregion
    }
}
