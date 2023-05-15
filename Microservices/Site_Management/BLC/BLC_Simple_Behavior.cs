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
        private Site_view _Site_view;
        private List<Site_view> _List_Site_view;
        private Ext_study_zone _Ext_study_zone;
        private List<Ext_study_zone> _List_Ext_study_zone;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Site_field_logo _Site_field_logo;
        private List<Site_field_logo> _List_Site_field_logo;
        private Site _Site;
        private List<Site> _List_Site;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Site_view_Execution;
        private bool _Stop_Delete_Site_view_Execution;
        private bool _Stop_Edit_Ext_study_zone_Execution;
        private bool _Stop_Delete_Ext_study_zone_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Site_field_logo_Execution;
        private bool _Stop_Delete_Site_field_logo_Execution;
        private bool _Stop_Edit_Site_Execution;
        private bool _Stop_Delete_Site_Execution;
        #endregion
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID
        public Site_view Get_Site_view_By_SITE_VIEW_ID(Params_Get_Site_view_By_SITE_VIEW_ID i_Params_Get_Site_view_By_SITE_VIEW_ID)
        {
            Site_view oSite_view = null;
            var i_Params_Get_Site_view_By_SITE_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_VIEW_ID", i_Params_Get_Site_view_By_SITE_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Site_view oDBEntry = _AppContext.Get_Site_view_By_SITE_VIEW_ID(i_Params_Get_Site_view_By_SITE_VIEW_ID.SITE_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_view").Replace("%2", i_Params_Get_Site_view_By_SITE_VIEW_ID.SITE_VIEW_ID.ToString()));
            }
            oSite_view = new Site_view();
            Props.Copy_Prop_Values(oDBEntry, oSite_view);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_VIEW_ID", i_Params_Get_Site_view_By_SITE_VIEW_ID_json, false);
            }
            return oSite_view;
        }
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
        public Ext_study_zone Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID)
        {
            Ext_study_zone oExt_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_json, false);
            }
            #region Body Section.
            DALC.Ext_study_zone oDBEntry = _AppContext.Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID.EXT_STUDY_ZONE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Ext_study_zone").Replace("%2", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID.EXT_STUDY_ZONE_ID.ToString()));
            }
            oExt_study_zone = new Ext_study_zone();
            Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_json, false);
            }
            return oExt_study_zone;
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
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID
        public Site_field_logo Get_Site_field_logo_By_SITE_FIELD_LOGO_ID(Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID)
        {
            Site_field_logo oSite_field_logo = null;
            var i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_SITE_FIELD_LOGO_ID", i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_json, false);
            }
            #region Body Section.
            DALC.Site_field_logo oDBEntry = _AppContext.Get_Site_field_logo_By_SITE_FIELD_LOGO_ID(i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID.SITE_FIELD_LOGO_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_field_logo").Replace("%2", i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID.SITE_FIELD_LOGO_ID.ToString()));
            }
            oSite_field_logo = new Site_field_logo();
            Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_SITE_FIELD_LOGO_ID", i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_json, false);
            }
            return oSite_field_logo;
        }
        #endregion
        #region Get_Site_By_SITE_ID
        public Site Get_Site_By_SITE_ID(Params_Get_Site_By_SITE_ID i_Params_Get_Site_By_SITE_ID)
        {
            Site oSite = null;
            var i_Params_Get_Site_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_SITE_ID", i_Params_Get_Site_By_SITE_ID_json, false);
            }
            #region PreEvent_Get_Site_By_SITE_ID
            if (OnPreEvent_Get_Site_By_SITE_ID != null)
            {
                OnPreEvent_Get_Site_By_SITE_ID(i_Params_Get_Site_By_SITE_ID);
            }
            #endregion
            #region Body Section.
            DALC.Site oDBEntry = _AppContext.Get_Site_By_SITE_ID(i_Params_Get_Site_By_SITE_ID.SITE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site").Replace("%2", i_Params_Get_Site_By_SITE_ID.SITE_ID.ToString()));
            }
            oSite = new Site();
            Props.Copy_Prop_Values(oDBEntry, oSite);
            #endregion
            #region PostEvent_Get_Site_By_SITE_ID
            if (OnPostEvent_Get_Site_By_SITE_ID != null)
            {
                OnPostEvent_Get_Site_By_SITE_ID(ref oSite, i_Params_Get_Site_By_SITE_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_SITE_ID", i_Params_Get_Site_By_SITE_ID_json, false);
            }
            return oSite;
        }
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List
        public List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List(Params_Get_Site_view_By_SITE_VIEW_ID_List i_Params_Get_Site_view_By_SITE_VIEW_ID_List)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_SITE_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_VIEW_ID_List", i_Params_Get_Site_view_By_SITE_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_SITE_VIEW_ID_List(i_Params_Get_Site_view_By_SITE_VIEW_ID_List.SITE_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_VIEW_ID_List", i_Params_Get_Site_view_By_SITE_VIEW_ID_List_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List
        public List<Ext_study_zone> Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List.EXT_STUDY_ZONE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_json, false);
            }
            return oList_Ext_study_zone;
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
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List(Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List", i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List(i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List.SITE_FIELD_LOGO_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List", i_Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_SITE_ID_List
        public List<Site> Get_Site_By_SITE_ID_List(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_SITE_ID_List", i_Params_Get_Site_By_SITE_ID_List_json, false);
            }
            #region PreEvent_Get_Site_By_SITE_ID_List
            if (OnPreEvent_Get_Site_By_SITE_ID_List != null)
            {
                OnPreEvent_Get_Site_By_SITE_ID_List(i_Params_Get_Site_By_SITE_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_SITE_ID_List(i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Site_By_SITE_ID_List
            if (OnPostEvent_Get_Site_By_SITE_ID_List != null)
            {
                OnPostEvent_Get_Site_By_SITE_ID_List(ref oList_Site, i_Params_Get_Site_By_SITE_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_SITE_ID_List", i_Params_Get_Site_By_SITE_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID_IS_DELETED
        public List<Site_view> Get_Site_view_By_OWNER_ID_IS_DELETED(Params_Get_Site_view_By_OWNER_ID_IS_DELETED i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_OWNER_ID_IS_DELETED(i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID(Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_VIEW_TYPE_SETUP_ID(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID
        public List<Site_view> Get_Site_view_By_OWNER_ID(Params_Get_Site_view_By_OWNER_ID i_Params_Get_Site_view_By_OWNER_ID)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_OWNER_ID", i_Params_Get_Site_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_OWNER_ID(i_Params_Get_Site_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_OWNER_ID", i_Params_Get_Site_view_By_OWNER_ID_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID
        public List<Site_view> Get_Site_view_By_SITE_ID(Params_Get_Site_view_By_SITE_ID i_Params_Get_Site_view_By_SITE_ID)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_ID", i_Params_Get_Site_view_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_SITE_ID(i_Params_Get_Site_view_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_ID", i_Params_Get_Site_view_By_SITE_ID_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID
        public List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID(Params_Get_Ext_study_zone_By_OWNER_ID i_Params_Get_Ext_study_zone_By_OWNER_ID)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_OWNER_ID", i_Params_Get_Ext_study_zone_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_OWNER_ID(i_Params_Get_Ext_study_zone_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_OWNER_ID", i_Params_Get_Ext_study_zone_By_OWNER_ID_json, false);
            }
            return oList_Ext_study_zone;
        }
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
        public List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Ext_study_zone;
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
        #region Get_Site_field_logo_By_OWNER_ID_IS_DELETED
        public List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID_IS_DELETED(Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_OWNER_ID_IS_DELETED(i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_field_logo_By_OWNER_ID
        public List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID(Params_Get_Site_field_logo_By_OWNER_ID i_Params_Get_Site_field_logo_By_OWNER_ID)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_OWNER_ID", i_Params_Get_Site_field_logo_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_OWNER_ID(i_Params_Get_Site_field_logo_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_OWNER_ID", i_Params_Get_Site_field_logo_By_OWNER_ID_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_field_logo_By_SITE_ID
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_ID(Params_Get_Site_field_logo_By_SITE_ID i_Params_Get_Site_field_logo_By_SITE_ID)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_SITE_ID", i_Params_Get_Site_field_logo_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_SITE_ID(i_Params_Get_Site_field_logo_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_SITE_ID", i_Params_Get_Site_field_logo_By_SITE_ID_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED
        public List<Site> Get_Site_By_OWNER_ID_IS_DELETED(Params_Get_Site_By_OWNER_ID_IS_DELETED i_Params_Get_Site_By_OWNER_ID_IS_DELETED)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_OWNER_ID_IS_DELETED(i_Params_Get_Site_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_OWNER_ID
        public List<Site> Get_Site_By_OWNER_ID(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_OWNER_ID", i_Params_Get_Site_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Site_By_OWNER_ID
            if (OnPreEvent_Get_Site_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Site_By_OWNER_ID(i_Params_Get_Site_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_OWNER_ID(i_Params_Get_Site_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Site_By_OWNER_ID
            if (OnPostEvent_Get_Site_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Site_By_OWNER_ID(oList_Site, i_Params_Get_Site_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_OWNER_ID", i_Params_Get_Site_By_OWNER_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_AREA_ID
        public List<Site> Get_Site_By_AREA_ID(Params_Get_Site_By_AREA_ID i_Params_Get_Site_By_AREA_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_AREA_ID", i_Params_Get_Site_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_AREA_ID(i_Params_Get_Site_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_AREA_ID", i_Params_Get_Site_By_AREA_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID
        public List<Site> Get_Site_By_DISTRICT_ID(Params_Get_Site_By_DISTRICT_ID i_Params_Get_Site_By_DISTRICT_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_DISTRICT_ID", i_Params_Get_Site_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_DISTRICT_ID(i_Params_Get_Site_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_DISTRICT_ID", i_Params_Get_Site_By_DISTRICT_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID
        public List<Site> Get_Site_By_REGION_ID(Params_Get_Site_By_REGION_ID i_Params_Get_Site_By_REGION_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_REGION_ID", i_Params_Get_Site_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_REGION_ID(i_Params_Get_Site_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_REGION_ID", i_Params_Get_Site_By_REGION_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID
        public List<Site> Get_Site_By_TOP_LEVEL_ID(Params_Get_Site_By_TOP_LEVEL_ID i_Params_Get_Site_By_TOP_LEVEL_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_TOP_LEVEL_ID", i_Params_Get_Site_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_TOP_LEVEL_ID(i_Params_Get_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_TOP_LEVEL_ID", i_Params_Get_Site_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List(Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID_List", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_VIEW_TYPE_SETUP_ID_List(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID_List", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID_List
        public List<Site_view> Get_Site_view_By_SITE_ID_List(Params_Get_Site_view_By_SITE_ID_List i_Params_Get_Site_view_By_SITE_ID_List)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_ID_List", i_Params_Get_Site_view_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_SITE_ID_List(i_Params_Get_Site_view_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_ID_List", i_Params_Get_Site_view_By_SITE_ID_List_json, false);
            }
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_SITE_ID_List
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_ID_List(Params_Get_Site_field_logo_By_SITE_ID_List i_Params_Get_Site_field_logo_By_SITE_ID_List)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_SITE_ID_List", i_Params_Get_Site_field_logo_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_SITE_ID_List(i_Params_Get_Site_field_logo_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_SITE_ID_List", i_Params_Get_Site_field_logo_By_SITE_ID_List_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_AREA_ID_List
        public List<Site> Get_Site_By_AREA_ID_List(Params_Get_Site_By_AREA_ID_List i_Params_Get_Site_By_AREA_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_AREA_ID_List", i_Params_Get_Site_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_AREA_ID_List(i_Params_Get_Site_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_AREA_ID_List", i_Params_Get_Site_By_AREA_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_List
        public List<Site> Get_Site_By_DISTRICT_ID_List(Params_Get_Site_By_DISTRICT_ID_List i_Params_Get_Site_By_DISTRICT_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_DISTRICT_ID_List", i_Params_Get_Site_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_DISTRICT_ID_List(i_Params_Get_Site_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_DISTRICT_ID_List", i_Params_Get_Site_By_DISTRICT_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_List
        public List<Site> Get_Site_By_REGION_ID_List(Params_Get_Site_By_REGION_ID_List i_Params_Get_Site_By_REGION_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_REGION_ID_List", i_Params_Get_Site_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_REGION_ID_List(i_Params_Get_Site_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_REGION_ID_List", i_Params_Get_Site_By_REGION_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List
        public List<Site> Get_Site_By_TOP_LEVEL_ID_List(Params_Get_Site_By_TOP_LEVEL_ID_List i_Params_Get_Site_By_TOP_LEVEL_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_TOP_LEVEL_ID_List", i_Params_Get_Site_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_TOP_LEVEL_ID_List(i_Params_Get_Site_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_TOP_LEVEL_ID_List", i_Params_Get_Site_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_Where
        public List<Site_view> Get_Site_view_By_Where(Params_Get_Site_view_By_Where i_Params_Get_Site_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_Where", i_Params_Get_Site_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_view_By_Where.OWNER_ID == null || i_Params_Get_Site_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_view_By_Where.FETCH_NEXT == null || i_Params_Get_Site_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_Where(i_Params_Get_Site_view_By_Where.DESCRIPTION, i_Params_Get_Site_view_By_Where.OWNER_ID, i_Params_Get_Site_view_By_Where.OFFSET, i_Params_Get_Site_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            i_Params_Get_Site_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_Where", i_Params_Get_Site_view_By_Where_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Ext_study_zone_By_Where
        public List<Ext_study_zone> Get_Ext_study_zone_By_Where(Params_Get_Ext_study_zone_By_Where i_Params_Get_Ext_study_zone_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_Where", i_Params_Get_Ext_study_zone_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Ext_study_zone_By_Where.OWNER_ID == null || i_Params_Get_Ext_study_zone_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Ext_study_zone_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Ext_study_zone_By_Where.OFFSET == null)
            {
                i_Params_Get_Ext_study_zone_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT == null || i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_Where(i_Params_Get_Ext_study_zone_By_Where.NAME, i_Params_Get_Ext_study_zone_By_Where.AREA_COLOR, i_Params_Get_Ext_study_zone_By_Where.BORDER_COLOR, i_Params_Get_Ext_study_zone_By_Where.STUDY_ZONE_NAME, i_Params_Get_Ext_study_zone_By_Where.OWNER_ID, i_Params_Get_Ext_study_zone_By_Where.OFFSET, i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            i_Params_Get_Ext_study_zone_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_Where", i_Params_Get_Ext_study_zone_By_Where_json, false);
            }
            return oList_Ext_study_zone;
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
        #region Get_Site_field_logo_By_Where
        public List<Site_field_logo> Get_Site_field_logo_By_Where(Params_Get_Site_field_logo_By_Where i_Params_Get_Site_field_logo_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_Where", i_Params_Get_Site_field_logo_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_field_logo_By_Where.OWNER_ID == null || i_Params_Get_Site_field_logo_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_field_logo_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_field_logo_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_field_logo_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_field_logo_By_Where.FETCH_NEXT == null || i_Params_Get_Site_field_logo_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_field_logo_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_Where(i_Params_Get_Site_field_logo_By_Where.DESCRIPTION, i_Params_Get_Site_field_logo_By_Where.OWNER_ID, i_Params_Get_Site_field_logo_By_Where.OFFSET, i_Params_Get_Site_field_logo_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            i_Params_Get_Site_field_logo_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_Where", i_Params_Get_Site_field_logo_By_Where_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_Where
        public List<Site> Get_Site_By_Where(Params_Get_Site_By_Where i_Params_Get_Site_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_Where", i_Params_Get_Site_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_By_Where.OWNER_ID == null || i_Params_Get_Site_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_By_Where.FETCH_NEXT == null || i_Params_Get_Site_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_Where(i_Params_Get_Site_By_Where.NAME, i_Params_Get_Site_By_Where.LOCATION, i_Params_Get_Site_By_Where.UNIT, i_Params_Get_Site_By_Where.IMAGE_URL, i_Params_Get_Site_By_Where.LOGO_URL, i_Params_Get_Site_By_Where.SOLID_GLTF_URL, i_Params_Get_Site_By_Where.AREA_COLOR, i_Params_Get_Site_By_Where.BORDER_COLOR, i_Params_Get_Site_By_Where.STUDY_ZONE_NAME, i_Params_Get_Site_By_Where.OWNER_ID, i_Params_Get_Site_By_Where.OFFSET, i_Params_Get_Site_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            i_Params_Get_Site_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_Where", i_Params_Get_Site_By_Where_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_Where_In_List
        public List<Site_view> Get_Site_view_By_Where_In_List(Params_Get_Site_view_By_Where_In_List i_Params_Get_Site_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_Where_In_List", i_Params_Get_Site_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_view_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Site_view_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Site_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_Where_In_List(i_Params_Get_Site_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_view_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Site_view_By_Where_In_List.OWNER_ID, i_Params_Get_Site_view_By_Where_In_List.OFFSET, i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            i_Params_Get_Site_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_Where_In_List", i_Params_Get_Site_view_By_Where_In_List_json, false);
            }
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_Where_In_List
        public List<Site_field_logo> Get_Site_field_logo_By_Where_In_List(Params_Get_Site_field_logo_By_Where_In_List i_Params_Get_Site_field_logo_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_field_logo> oList_Site_field_logo = null;
            var i_Params_Get_Site_field_logo_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_field_logo_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_field_logo_By_Where_In_List", i_Params_Get_Site_field_logo_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_field_logo_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_field_logo_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_field_logo_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_field_logo_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_field_logo_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_field_logo_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_field_logo_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_field_logo_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_field_logo_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Site_field_logo_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            List<DALC.Site_field_logo> oList_DBEntry = _AppContext.Get_Site_field_logo_By_Where_In_List(i_Params_Get_Site_field_logo_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_field_logo_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_field_logo_By_Where_In_List.OWNER_ID, i_Params_Get_Site_field_logo_By_Where_In_List.OFFSET, i_Params_Get_Site_field_logo_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values(oDBEntry, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            i_Params_Get_Site_field_logo_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_field_logo_By_Where_In_List", i_Params_Get_Site_field_logo_By_Where_In_List_json, false);
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_Where_In_List
        public List<Site> Get_Site_By_Where_In_List(Params_Get_Site_By_Where_In_List i_Params_Get_Site_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_Where_In_List", i_Params_Get_Site_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_Where_In_List(i_Params_Get_Site_By_Where_In_List.NAME, i_Params_Get_Site_By_Where_In_List.LOCATION, i_Params_Get_Site_By_Where_In_List.UNIT, i_Params_Get_Site_By_Where_In_List.IMAGE_URL, i_Params_Get_Site_By_Where_In_List.LOGO_URL, i_Params_Get_Site_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Site_By_Where_In_List.AREA_COLOR, i_Params_Get_Site_By_Where_In_List.BORDER_COLOR, i_Params_Get_Site_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Site_By_Where_In_List.OWNER_ID, i_Params_Get_Site_By_Where_In_List.OFFSET, i_Params_Get_Site_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            i_Params_Get_Site_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_Where_In_List", i_Params_Get_Site_By_Where_In_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Delete_Site_view
        public void Delete_Site_view(Params_Delete_Site_view i_Params_Delete_Site_view)
        {
            var i_Params_Delete_Site_view_json = JsonConvert.SerializeObject(i_Params_Delete_Site_view);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_view", i_Params_Delete_Site_view_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_view_By_SITE_VIEW_ID oParams_Get_Site_view_By_SITE_VIEW_ID = new Params_Get_Site_view_By_SITE_VIEW_ID
                {
                    SITE_VIEW_ID = i_Params_Delete_Site_view.SITE_VIEW_ID
                };
                _Site_view = Get_Site_view_By_SITE_VIEW_ID(oParams_Get_Site_view_By_SITE_VIEW_ID);
                if (_Site_view != null)
                {
                    if (_Stop_Delete_Site_view_Execution)
                    {
                        _Stop_Delete_Site_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_view(i_Params_Delete_Site_view.SITE_VIEW_ID);
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
                OnPostEvent_General("Delete_Site_view", i_Params_Delete_Site_view_json, false);
            }
        }
        #endregion
        #region Delete_Ext_study_zone
        public void Delete_Ext_study_zone(Params_Delete_Ext_study_zone i_Params_Delete_Ext_study_zone)
        {
            var i_Params_Delete_Ext_study_zone_json = JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Ext_study_zone", i_Params_Delete_Ext_study_zone_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID oParams_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID = new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
                {
                    EXT_STUDY_ZONE_ID = i_Params_Delete_Ext_study_zone.EXT_STUDY_ZONE_ID
                };
                _Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(oParams_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID);
                if (_Ext_study_zone != null)
                {
                    if (_Stop_Delete_Ext_study_zone_Execution)
                    {
                        _Stop_Delete_Ext_study_zone_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Ext_study_zone(i_Params_Delete_Ext_study_zone.EXT_STUDY_ZONE_ID);
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
                OnPostEvent_General("Delete_Ext_study_zone", i_Params_Delete_Ext_study_zone_json, false);
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
        #region Delete_Site_field_logo
        public void Delete_Site_field_logo(Params_Delete_Site_field_logo i_Params_Delete_Site_field_logo)
        {
            var i_Params_Delete_Site_field_logo_json = JsonConvert.SerializeObject(i_Params_Delete_Site_field_logo);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_field_logo", i_Params_Delete_Site_field_logo_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID oParams_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID = new Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID
                {
                    SITE_FIELD_LOGO_ID = i_Params_Delete_Site_field_logo.SITE_FIELD_LOGO_ID
                };
                _Site_field_logo = Get_Site_field_logo_By_SITE_FIELD_LOGO_ID(oParams_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID);
                if (_Site_field_logo != null)
                {
                    if (_Stop_Delete_Site_field_logo_Execution)
                    {
                        _Stop_Delete_Site_field_logo_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_field_logo(i_Params_Delete_Site_field_logo.SITE_FIELD_LOGO_ID);
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
                OnPostEvent_General("Delete_Site_field_logo", i_Params_Delete_Site_field_logo_json, false);
            }
        }
        #endregion
        #region Delete_Site
        public void Delete_Site(Params_Delete_Site i_Params_Delete_Site)
        {
            var i_Params_Delete_Site_json = JsonConvert.SerializeObject(i_Params_Delete_Site);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site", i_Params_Delete_Site_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_SITE_ID oParams_Get_Site_By_SITE_ID = new Params_Get_Site_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Site.SITE_ID
                };
                _Site = Get_Site_By_SITE_ID(oParams_Get_Site_By_SITE_ID);
                if (_Site != null)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site(i_Params_Delete_Site.SITE_ID);
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
                OnPostEvent_General("Delete_Site", i_Params_Delete_Site_json, false);
            }
        }
        #endregion
        #region Delete_Site_view_By_OWNER_ID_IS_DELETED
        public void Delete_Site_view_By_OWNER_ID_IS_DELETED(Params_Delete_Site_view_By_OWNER_ID_IS_DELETED i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_view_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_view_By_OWNER_ID_IS_DELETED oParams_Get_Site_view_By_OWNER_ID_IS_DELETED = new Params_Get_Site_view_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Site_view = Get_Site_view_By_OWNER_ID_IS_DELETED(oParams_Get_Site_view_By_OWNER_ID_IS_DELETED);
                if (_List_Site_view != null && _List_Site_view.Count > 0)
                {
                    if (_Stop_Delete_Site_view_Execution)
                    {
                        _Stop_Delete_Site_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_view_By_OWNER_ID_IS_DELETED(i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Site_view_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_view_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Site_view_By_VIEW_TYPE_SETUP_ID(Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_view_By_VIEW_TYPE_SETUP_ID", i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID oParams_Get_Site_view_By_VIEW_TYPE_SETUP_ID = new Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID
                {
                    VIEW_TYPE_SETUP_ID = i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID
                };
                _List_Site_view = Get_Site_view_By_VIEW_TYPE_SETUP_ID(oParams_Get_Site_view_By_VIEW_TYPE_SETUP_ID);
                if (_List_Site_view != null && _List_Site_view.Count > 0)
                {
                    if (_Stop_Delete_Site_view_Execution)
                    {
                        _Stop_Delete_Site_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_view_By_VIEW_TYPE_SETUP_ID(i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_Site_view_By_VIEW_TYPE_SETUP_ID", i_Params_Delete_Site_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_view_By_OWNER_ID
        public void Delete_Site_view_By_OWNER_ID(Params_Delete_Site_view_By_OWNER_ID i_Params_Delete_Site_view_By_OWNER_ID)
        {
            var i_Params_Delete_Site_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_view_By_OWNER_ID", i_Params_Delete_Site_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_view_By_OWNER_ID oParams_Get_Site_view_By_OWNER_ID = new Params_Get_Site_view_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Site_view_By_OWNER_ID.OWNER_ID
                };
                _List_Site_view = Get_Site_view_By_OWNER_ID(oParams_Get_Site_view_By_OWNER_ID);
                if (_List_Site_view != null && _List_Site_view.Count > 0)
                {
                    if (_Stop_Delete_Site_view_Execution)
                    {
                        _Stop_Delete_Site_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_view_By_OWNER_ID(i_Params_Delete_Site_view_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Site_view_By_OWNER_ID", i_Params_Delete_Site_view_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_view_By_SITE_ID
        public void Delete_Site_view_By_SITE_ID(Params_Delete_Site_view_By_SITE_ID i_Params_Delete_Site_view_By_SITE_ID)
        {
            var i_Params_Delete_Site_view_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_view_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_view_By_SITE_ID", i_Params_Delete_Site_view_By_SITE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_view_By_SITE_ID oParams_Get_Site_view_By_SITE_ID = new Params_Get_Site_view_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Site_view_By_SITE_ID.SITE_ID
                };
                _List_Site_view = Get_Site_view_By_SITE_ID(oParams_Get_Site_view_By_SITE_ID);
                if (_List_Site_view != null && _List_Site_view.Count > 0)
                {
                    if (_Stop_Delete_Site_view_Execution)
                    {
                        _Stop_Delete_Site_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_view_By_SITE_ID(i_Params_Delete_Site_view_By_SITE_ID.SITE_ID);
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
                OnPostEvent_General("Delete_Site_view_By_SITE_ID", i_Params_Delete_Site_view_By_SITE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID
        public void Delete_Ext_study_zone_By_OWNER_ID(Params_Delete_Ext_study_zone_By_OWNER_ID i_Params_Delete_Ext_study_zone_By_OWNER_ID)
        {
            var i_Params_Delete_Ext_study_zone_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Ext_study_zone_By_OWNER_ID", i_Params_Delete_Ext_study_zone_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Ext_study_zone_By_OWNER_ID oParams_Get_Ext_study_zone_By_OWNER_ID = new Params_Get_Ext_study_zone_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Ext_study_zone_By_OWNER_ID.OWNER_ID
                };
                _List_Ext_study_zone = Get_Ext_study_zone_By_OWNER_ID(oParams_Get_Ext_study_zone_By_OWNER_ID);
                if (_List_Ext_study_zone != null && _List_Ext_study_zone.Count > 0)
                {
                    if (_Stop_Delete_Ext_study_zone_Execution)
                    {
                        _Stop_Delete_Ext_study_zone_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Ext_study_zone_By_OWNER_ID(i_Params_Delete_Ext_study_zone_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Ext_study_zone_By_OWNER_ID", i_Params_Delete_Ext_study_zone_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED
        public void Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED oParams_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED = new Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Ext_study_zone = Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(oParams_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED);
                if (_List_Ext_study_zone != null && _List_Ext_study_zone.Count > 0)
                {
                    if (_Stop_Delete_Ext_study_zone_Execution)
                    {
                        _Stop_Delete_Ext_study_zone_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
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
        #region Delete_Site_field_logo_By_OWNER_ID_IS_DELETED
        public void Delete_Site_field_logo_By_OWNER_ID_IS_DELETED(Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_field_logo_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED oParams_Get_Site_field_logo_By_OWNER_ID_IS_DELETED = new Params_Get_Site_field_logo_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Site_field_logo = Get_Site_field_logo_By_OWNER_ID_IS_DELETED(oParams_Get_Site_field_logo_By_OWNER_ID_IS_DELETED);
                if (_List_Site_field_logo != null && _List_Site_field_logo.Count > 0)
                {
                    if (_Stop_Delete_Site_field_logo_Execution)
                    {
                        _Stop_Delete_Site_field_logo_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_field_logo_By_OWNER_ID_IS_DELETED(i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Site_field_logo_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_field_logo_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_field_logo_By_OWNER_ID
        public void Delete_Site_field_logo_By_OWNER_ID(Params_Delete_Site_field_logo_By_OWNER_ID i_Params_Delete_Site_field_logo_By_OWNER_ID)
        {
            var i_Params_Delete_Site_field_logo_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_field_logo_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_field_logo_By_OWNER_ID", i_Params_Delete_Site_field_logo_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_field_logo_By_OWNER_ID oParams_Get_Site_field_logo_By_OWNER_ID = new Params_Get_Site_field_logo_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Site_field_logo_By_OWNER_ID.OWNER_ID
                };
                _List_Site_field_logo = Get_Site_field_logo_By_OWNER_ID(oParams_Get_Site_field_logo_By_OWNER_ID);
                if (_List_Site_field_logo != null && _List_Site_field_logo.Count > 0)
                {
                    if (_Stop_Delete_Site_field_logo_Execution)
                    {
                        _Stop_Delete_Site_field_logo_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_field_logo_By_OWNER_ID(i_Params_Delete_Site_field_logo_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Site_field_logo_By_OWNER_ID", i_Params_Delete_Site_field_logo_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_field_logo_By_SITE_ID
        public void Delete_Site_field_logo_By_SITE_ID(Params_Delete_Site_field_logo_By_SITE_ID i_Params_Delete_Site_field_logo_By_SITE_ID)
        {
            var i_Params_Delete_Site_field_logo_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_field_logo_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_field_logo_By_SITE_ID", i_Params_Delete_Site_field_logo_By_SITE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_field_logo_By_SITE_ID oParams_Get_Site_field_logo_By_SITE_ID = new Params_Get_Site_field_logo_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Site_field_logo_By_SITE_ID.SITE_ID
                };
                _List_Site_field_logo = Get_Site_field_logo_By_SITE_ID(oParams_Get_Site_field_logo_By_SITE_ID);
                if (_List_Site_field_logo != null && _List_Site_field_logo.Count > 0)
                {
                    if (_Stop_Delete_Site_field_logo_Execution)
                    {
                        _Stop_Delete_Site_field_logo_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_field_logo_By_SITE_ID(i_Params_Delete_Site_field_logo_By_SITE_ID.SITE_ID);
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
                OnPostEvent_General("Delete_Site_field_logo_By_SITE_ID", i_Params_Delete_Site_field_logo_By_SITE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_OWNER_ID_IS_DELETED
        public void Delete_Site_By_OWNER_ID_IS_DELETED(Params_Delete_Site_By_OWNER_ID_IS_DELETED i_Params_Delete_Site_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Site_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_OWNER_ID_IS_DELETED oParams_Get_Site_By_OWNER_ID_IS_DELETED = new Params_Get_Site_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Site = Get_Site_By_OWNER_ID_IS_DELETED(oParams_Get_Site_By_OWNER_ID_IS_DELETED);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_OWNER_ID_IS_DELETED(i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Site_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_OWNER_ID
        public void Delete_Site_By_OWNER_ID(Params_Delete_Site_By_OWNER_ID i_Params_Delete_Site_By_OWNER_ID)
        {
            var i_Params_Delete_Site_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_OWNER_ID", i_Params_Delete_Site_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_OWNER_ID oParams_Get_Site_By_OWNER_ID = new Params_Get_Site_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Site_By_OWNER_ID.OWNER_ID
                };
                _List_Site = Get_Site_By_OWNER_ID(oParams_Get_Site_By_OWNER_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_OWNER_ID(i_Params_Delete_Site_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Site_By_OWNER_ID", i_Params_Delete_Site_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_AREA_ID
        public void Delete_Site_By_AREA_ID(Params_Delete_Site_By_AREA_ID i_Params_Delete_Site_By_AREA_ID)
        {
            var i_Params_Delete_Site_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_AREA_ID", i_Params_Delete_Site_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_AREA_ID oParams_Get_Site_By_AREA_ID = new Params_Get_Site_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Site_By_AREA_ID.AREA_ID
                };
                _List_Site = Get_Site_By_AREA_ID(oParams_Get_Site_By_AREA_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_AREA_ID(i_Params_Delete_Site_By_AREA_ID.AREA_ID);
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
                OnPostEvent_General("Delete_Site_By_AREA_ID", i_Params_Delete_Site_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_DISTRICT_ID
        public void Delete_Site_By_DISTRICT_ID(Params_Delete_Site_By_DISTRICT_ID i_Params_Delete_Site_By_DISTRICT_ID)
        {
            var i_Params_Delete_Site_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_DISTRICT_ID", i_Params_Delete_Site_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_DISTRICT_ID oParams_Get_Site_By_DISTRICT_ID = new Params_Get_Site_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_Site_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_Site = Get_Site_By_DISTRICT_ID(oParams_Get_Site_By_DISTRICT_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_DISTRICT_ID(i_Params_Delete_Site_By_DISTRICT_ID.DISTRICT_ID);
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
                OnPostEvent_General("Delete_Site_By_DISTRICT_ID", i_Params_Delete_Site_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_REGION_ID
        public void Delete_Site_By_REGION_ID(Params_Delete_Site_By_REGION_ID i_Params_Delete_Site_By_REGION_ID)
        {
            var i_Params_Delete_Site_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_REGION_ID", i_Params_Delete_Site_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_REGION_ID oParams_Get_Site_By_REGION_ID = new Params_Get_Site_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_Site_By_REGION_ID.REGION_ID
                };
                _List_Site = Get_Site_By_REGION_ID(oParams_Get_Site_By_REGION_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_REGION_ID(i_Params_Delete_Site_By_REGION_ID.REGION_ID);
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
                OnPostEvent_General("Delete_Site_By_REGION_ID", i_Params_Delete_Site_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_TOP_LEVEL_ID
        public void Delete_Site_By_TOP_LEVEL_ID(Params_Delete_Site_By_TOP_LEVEL_ID i_Params_Delete_Site_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_Site_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_TOP_LEVEL_ID", i_Params_Delete_Site_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_TOP_LEVEL_ID oParams_Get_Site_By_TOP_LEVEL_ID = new Params_Get_Site_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_Site = Get_Site_By_TOP_LEVEL_ID(oParams_Get_Site_By_TOP_LEVEL_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_TOP_LEVEL_ID(i_Params_Delete_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
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
                OnPostEvent_General("Delete_Site_By_TOP_LEVEL_ID", i_Params_Delete_Site_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Edit_Site_view
        public void Edit_Site_view(Site_view i_Site_view)
        {
            var i_Site_view_json = JsonConvert.SerializeObject(i_Site_view);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Site_view.SITE_VIEW_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_view", i_Site_view_json, false);
            }
            #region Body Section.
            if (i_Site_view.SITE_VIEW_ID == null || i_Site_view.SITE_VIEW_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Site_view");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Site_view.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Site_view.IS_DELETED = false;
            }
            else
            {
                _Site_view = Get_Site_view_By_SITE_VIEW_ID(new Params_Get_Site_view_By_SITE_VIEW_ID
                {
                    SITE_VIEW_ID = i_Site_view.SITE_VIEW_ID
                });
            }
            i_Site_view.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Site_view.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Site_view.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Site_view_Execution)
            {
                _Stop_Edit_Site_view_Execution = false;
                return;
            }
            i_Site_view.SITE_VIEW_ID = _AppContext.Edit_Site_view
            (
                i_Site_view.SITE_VIEW_ID,
                i_Site_view.SITE_ID,
                i_Site_view.VIEW_TYPE_SETUP_ID,
                i_Site_view.PITCH,
                i_Site_view.BEARING,
                i_Site_view.ZOOM,
                i_Site_view.LATITUDE,
                i_Site_view.LONGITUDE,
                i_Site_view.ENTRY_USER_ID,
                i_Site_view.ENTRY_DATE,
                i_Site_view.LAST_UPDATE,
                i_Site_view.IS_DELETED,
                i_Site_view.OWNER_ID,
                i_Site_view.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_view", i_Site_view_json, false);
            }
        }
        #endregion
        #region Edit_Ext_study_zone
        public void Edit_Ext_study_zone(Ext_study_zone i_Ext_study_zone)
        {
            var i_Ext_study_zone_json = JsonConvert.SerializeObject(i_Ext_study_zone);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Ext_study_zone.EXT_STUDY_ZONE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Ext_study_zone", i_Ext_study_zone_json, false);
            }
            #region Body Section.
            if (i_Ext_study_zone.EXT_STUDY_ZONE_ID == null || i_Ext_study_zone.EXT_STUDY_ZONE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Ext_study_zone");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Ext_study_zone.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Ext_study_zone.IS_DELETED = false;
            }
            else
            {
                _Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
                {
                    EXT_STUDY_ZONE_ID = i_Ext_study_zone.EXT_STUDY_ZONE_ID
                });
            }
            i_Ext_study_zone.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Ext_study_zone.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Ext_study_zone.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Ext_study_zone_Execution)
            {
                _Stop_Edit_Ext_study_zone_Execution = false;
                return;
            }
            i_Ext_study_zone.EXT_STUDY_ZONE_ID = _AppContext.Edit_Ext_study_zone
            (
                i_Ext_study_zone.EXT_STUDY_ZONE_ID,
                i_Ext_study_zone.NAME,
                i_Ext_study_zone.LATITUDE,
                i_Ext_study_zone.LONGITUDE,
                i_Ext_study_zone.AREA_COLOR,
                i_Ext_study_zone.BORDER_COLOR,
                i_Ext_study_zone.STUDY_ZONE_NAME,
                i_Ext_study_zone.ENTRY_USER_ID,
                i_Ext_study_zone.ENTRY_DATE,
                i_Ext_study_zone.LAST_UPDATE,
                i_Ext_study_zone.IS_DELETED,
                i_Ext_study_zone.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Ext_study_zone", i_Ext_study_zone_json, false);
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
        #region Edit_Site_field_logo
        public void Edit_Site_field_logo(Site_field_logo i_Site_field_logo)
        {
            var i_Site_field_logo_json = JsonConvert.SerializeObject(i_Site_field_logo);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Site_field_logo.SITE_FIELD_LOGO_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_field_logo", i_Site_field_logo_json, false);
            }
            #region Body Section.
            if (i_Site_field_logo.SITE_FIELD_LOGO_ID == null || i_Site_field_logo.SITE_FIELD_LOGO_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Site_field_logo");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Site_field_logo.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Site_field_logo.IS_DELETED = false;
            }
            else
            {
                _Site_field_logo = Get_Site_field_logo_By_SITE_FIELD_LOGO_ID(new Params_Get_Site_field_logo_By_SITE_FIELD_LOGO_ID
                {
                    SITE_FIELD_LOGO_ID = i_Site_field_logo.SITE_FIELD_LOGO_ID
                });
            }
            i_Site_field_logo.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Site_field_logo.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Site_field_logo.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Site_field_logo_Execution)
            {
                _Stop_Edit_Site_field_logo_Execution = false;
                return;
            }
            i_Site_field_logo.SITE_FIELD_LOGO_ID = _AppContext.Edit_Site_field_logo
            (
                i_Site_field_logo.SITE_FIELD_LOGO_ID,
                i_Site_field_logo.SITE_ID,
                i_Site_field_logo.LONGITUDE,
                i_Site_field_logo.LATITUDE,
                i_Site_field_logo.ENTRY_USER_ID,
                i_Site_field_logo.ENTRY_DATE,
                i_Site_field_logo.LAST_UPDATE,
                i_Site_field_logo.IS_DELETED,
                i_Site_field_logo.OWNER_ID,
                i_Site_field_logo.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_field_logo", i_Site_field_logo_json, false);
            }
        }
        #endregion
        #region Edit_Site
        public void Edit_Site(Site i_Site)
        {
            var i_Site_json = JsonConvert.SerializeObject(i_Site);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Site.SITE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site", i_Site_json, false);
            }
            #region Body Section.
            if (i_Site.SITE_ID == null || i_Site.SITE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Site");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Site.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Site.IS_DELETED = false;
            }
            else
            {
                _Site = Get_Site_By_SITE_ID(new Params_Get_Site_By_SITE_ID
                {
                    SITE_ID = i_Site.SITE_ID
                });
            }
            i_Site.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Site.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Site.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Site
            if (OnPreEvent_Edit_Site != null)
            {
                OnPreEvent_Edit_Site(i_Site, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Site_Execution)
            {
                _Stop_Edit_Site_Execution = false;
                return;
            }
            i_Site.SITE_ID = _AppContext.Edit_Site
            (
                i_Site.SITE_ID,
                i_Site.AREA_ID,
                i_Site.DISTRICT_ID,
                i_Site.REGION_ID,
                i_Site.TOP_LEVEL_ID,
                i_Site.NAME,
                i_Site.LOCATION,
                i_Site.AREA,
                i_Site.UNIT,
                i_Site.SCALE,
                i_Site.ROTATIONX,
                i_Site.ROTATIONY,
                i_Site.ROTATIONZ,
                i_Site.GLTF_LATITUDE,
                i_Site.GLTF_LONGITUDE,
                i_Site.CENTER_LATITUDE,
                i_Site.CENTER_LONGITUDE,
                i_Site.RADIUS_IN_METERS,
                i_Site.IMAGE_URL,
                i_Site.LOGO_URL,
                i_Site.SOLID_GLTF_URL,
                i_Site.AREA_COLOR,
                i_Site.BORDER_COLOR,
                i_Site.STUDY_ZONE_NAME,
                i_Site.ENTRY_USER_ID,
                i_Site.ENTRY_DATE,
                i_Site.LAST_UPDATE,
                i_Site.IS_DELETED,
                i_Site.OWNER_ID
            );
            #region PostEvent_Edit_Site
            if (OnPostEvent_Edit_Site != null)
            {
                OnPostEvent_Edit_Site(i_Site, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site", i_Site_json, false);
            }
        }
        #endregion
        #region Edit_Site_view_List
        public void Edit_Site_view_List(Params_Edit_Site_view_List i_Params_Edit_Site_view_List)
        {
            var i_Params_Edit_Site_view_List_json = JsonConvert.SerializeObject(i_Params_Edit_Site_view_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_view_List", i_Params_Edit_Site_view_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Site_view_List.List_To_Edit != null)
            {
                i_Params_Edit_Site_view_List.List_Failed_Edit = new List<Site_view>();
                if (i_Params_Edit_Site_view_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSite_view in i_Params_Edit_Site_view_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Site_view(oSite_view);
                        }
                        catch
                        {
                            i_Params_Edit_Site_view_List.List_Failed_Edit.Add(oSite_view);
                        }
                    }
                }
                i_Params_Edit_Site_view_List.List_To_Edit = i_Params_Edit_Site_view_List.List_To_Edit.Except(i_Params_Edit_Site_view_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Site_view_List.List_To_Delete != null)
            {
                i_Params_Edit_Site_view_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Site_view_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Site_view_ID in i_Params_Edit_Site_view_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Site_view(new Params_Delete_Site_view()
                            {
                                SITE_VIEW_ID = Site_view_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Site_view_List.List_Failed_Delete.Add(Site_view_ID);
                        }
                    }
                }
                i_Params_Edit_Site_view_List.List_To_Delete = i_Params_Edit_Site_view_List.List_To_Delete.Except(i_Params_Edit_Site_view_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_view_List", i_Params_Edit_Site_view_List_json, false);
            }
        }
        #endregion
        #region Edit_Ext_study_zone_List
        public void Edit_Ext_study_zone_List(Params_Edit_Ext_study_zone_List i_Params_Edit_Ext_study_zone_List)
        {
            var i_Params_Edit_Ext_study_zone_List_json = JsonConvert.SerializeObject(i_Params_Edit_Ext_study_zone_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Ext_study_zone_List", i_Params_Edit_Ext_study_zone_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Ext_study_zone_List.List_To_Edit != null)
            {
                i_Params_Edit_Ext_study_zone_List.List_Failed_Edit = new List<Ext_study_zone>();
                if (i_Params_Edit_Ext_study_zone_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oExt_study_zone in i_Params_Edit_Ext_study_zone_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Ext_study_zone(oExt_study_zone);
                        }
                        catch
                        {
                            i_Params_Edit_Ext_study_zone_List.List_Failed_Edit.Add(oExt_study_zone);
                        }
                    }
                }
                i_Params_Edit_Ext_study_zone_List.List_To_Edit = i_Params_Edit_Ext_study_zone_List.List_To_Edit.Except(i_Params_Edit_Ext_study_zone_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Ext_study_zone_List.List_To_Delete != null)
            {
                i_Params_Edit_Ext_study_zone_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Ext_study_zone_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Ext_study_zone_ID in i_Params_Edit_Ext_study_zone_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Ext_study_zone(new Params_Delete_Ext_study_zone()
                            {
                                EXT_STUDY_ZONE_ID = Ext_study_zone_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Ext_study_zone_List.List_Failed_Delete.Add(Ext_study_zone_ID);
                        }
                    }
                }
                i_Params_Edit_Ext_study_zone_List.List_To_Delete = i_Params_Edit_Ext_study_zone_List.List_To_Delete.Except(i_Params_Edit_Ext_study_zone_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Ext_study_zone_List", i_Params_Edit_Ext_study_zone_List_json, false);
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
        #region Edit_Site_field_logo_List
        public void Edit_Site_field_logo_List(Params_Edit_Site_field_logo_List i_Params_Edit_Site_field_logo_List)
        {
            var i_Params_Edit_Site_field_logo_List_json = JsonConvert.SerializeObject(i_Params_Edit_Site_field_logo_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_field_logo_List", i_Params_Edit_Site_field_logo_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Site_field_logo_List.List_To_Edit != null)
            {
                i_Params_Edit_Site_field_logo_List.List_Failed_Edit = new List<Site_field_logo>();
                if (i_Params_Edit_Site_field_logo_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSite_field_logo in i_Params_Edit_Site_field_logo_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Site_field_logo(oSite_field_logo);
                        }
                        catch
                        {
                            i_Params_Edit_Site_field_logo_List.List_Failed_Edit.Add(oSite_field_logo);
                        }
                    }
                }
                i_Params_Edit_Site_field_logo_List.List_To_Edit = i_Params_Edit_Site_field_logo_List.List_To_Edit.Except(i_Params_Edit_Site_field_logo_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Site_field_logo_List.List_To_Delete != null)
            {
                i_Params_Edit_Site_field_logo_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Site_field_logo_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Site_field_logo_ID in i_Params_Edit_Site_field_logo_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Site_field_logo(new Params_Delete_Site_field_logo()
                            {
                                SITE_FIELD_LOGO_ID = Site_field_logo_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Site_field_logo_List.List_Failed_Delete.Add(Site_field_logo_ID);
                        }
                    }
                }
                i_Params_Edit_Site_field_logo_List.List_To_Delete = i_Params_Edit_Site_field_logo_List.List_To_Delete.Except(i_Params_Edit_Site_field_logo_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_field_logo_List", i_Params_Edit_Site_field_logo_List_json, false);
            }
        }
        #endregion
        #region Edit_Site_List
        public void Edit_Site_List(Params_Edit_Site_List i_Params_Edit_Site_List)
        {
            var i_Params_Edit_Site_List_json = JsonConvert.SerializeObject(i_Params_Edit_Site_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_List", i_Params_Edit_Site_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Site_List.List_To_Edit != null)
            {
                i_Params_Edit_Site_List.List_Failed_Edit = new List<Site>();
                if (i_Params_Edit_Site_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSite in i_Params_Edit_Site_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Site(oSite);
                        }
                        catch
                        {
                            i_Params_Edit_Site_List.List_Failed_Edit.Add(oSite);
                        }
                    }
                }
                i_Params_Edit_Site_List.List_To_Edit = i_Params_Edit_Site_List.List_To_Edit.Except(i_Params_Edit_Site_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Site_List.List_To_Delete != null)
            {
                i_Params_Edit_Site_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Site_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Site_ID in i_Params_Edit_Site_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Site(new Params_Delete_Site()
                            {
                                SITE_ID = Site_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Site_List.List_Failed_Delete.Add(Site_ID);
                        }
                    }
                }
                i_Params_Edit_Site_List.List_To_Delete = i_Params_Edit_Site_List.List_To_Delete.Except(i_Params_Edit_Site_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_List", i_Params_Edit_Site_List_json, false);
            }
        }
        #endregion
    }
}