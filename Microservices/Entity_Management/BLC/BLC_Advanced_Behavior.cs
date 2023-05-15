using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Entity_view_By_ENTITY_VIEW_ID_Adv
        public Entity_view Get_Entity_view_By_ENTITY_VIEW_ID_Adv(Params_Get_Entity_view_By_ENTITY_VIEW_ID i_Params_Get_Entity_view_By_ENTITY_VIEW_ID)
        {
            Entity_view oEntity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_view oDBEntry = _AppContext.Get_Entity_view_By_ENTITY_VIEW_ID_Adv(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID.ENTITY_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_view").Replace("%2", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID.ENTITY_VIEW_ID.ToString()));
            }
            oEntity_view = new Entity_view();
            Props.Copy_Prop_Values(oDBEntry, oEntity_view);
            oEntity_view.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
            oEntity_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json, false);
            }
            return oEntity_view;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_Adv
        public Entity Get_Entity_By_ENTITY_ID_Adv(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            Entity oEntity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID_Adv", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            DALC.Entity oDBEntry = _AppContext.Get_Entity_By_ENTITY_ID_Adv(i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity").Replace("%2", i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID.ToString()));
            }
            oEntity = new Entity();
            Props.Copy_Prop_Values(oDBEntry, oEntity);
            oEntity.Area = new Area();
            Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
            oEntity.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
            oEntity.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
            oEntity.Site = new Site();
            Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
            oEntity.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
            oEntity.Entity_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID_Adv", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            return oEntity;
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
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv(Params_Get_Entity_view_By_ENTITY_VIEW_ID_List i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List.ENTITY_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_List_Adv
        public List<Entity> Get_Entity_By_ENTITY_ID_List_Adv(Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_ID_List_Adv(i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_OWNER_ID_Adv
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_Adv(Params_Get_Entity_view_By_OWNER_ID i_Params_Get_Entity_view_By_OWNER_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_OWNER_ID_Adv", i_Params_Get_Entity_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_OWNER_ID_Adv(i_Params_Get_Entity_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_OWNER_ID_Adv", i_Params_Get_Entity_view_By_OWNER_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Entity_view_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_Adv(Params_Get_Entity_view_By_ENTITY_ID i_Params_Get_Entity_view_By_ENTITY_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_ID_Adv(i_Params_Get_Entity_view_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Entity_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_By_OWNER_ID_IS_DELETED)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_Adv
        public List<Entity> Get_Entity_By_OWNER_ID_Adv(Params_Get_Entity_By_OWNER_ID i_Params_Get_Entity_By_OWNER_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID_Adv", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID_Adv(i_Params_Get_Entity_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID_Adv", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_Adv
        public List<Entity> Get_Entity_By_SITE_ID_Adv(Params_Get_Entity_By_SITE_ID i_Params_Get_Entity_By_SITE_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID_Adv", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID_Adv(i_Params_Get_Entity_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID_Adv", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_Adv
        public List<Entity> Get_Entity_By_AREA_ID_Adv(Params_Get_Entity_By_AREA_ID i_Params_Get_Entity_By_AREA_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID_Adv", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID_Adv(i_Params_Get_Entity_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID_Adv", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_Adv
        public List<Entity> Get_Entity_By_DISTRICT_ID_Adv(Params_Get_Entity_By_DISTRICT_ID i_Params_Get_Entity_By_DISTRICT_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID_Adv", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID_Adv(i_Params_Get_Entity_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID_Adv", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_Adv
        public List<Entity> Get_Entity_By_REGION_ID_Adv(Params_Get_Entity_By_REGION_ID i_Params_Get_Entity_By_REGION_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID_Adv", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID_Adv(i_Params_Get_Entity_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID_Adv", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_Adv
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_Adv(Params_Get_Entity_By_TOP_LEVEL_ID i_Params_Get_Entity_By_TOP_LEVEL_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID_Adv(i_Params_Get_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_List_Adv(Params_Get_Entity_view_By_ENTITY_ID_List i_Params_Get_Entity_view_By_ENTITY_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_ID_List_Adv(i_Params_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_List_Adv
        public List<Entity> Get_Entity_By_SITE_ID_List_Adv(Params_Get_Entity_By_SITE_ID_List i_Params_Get_Entity_By_SITE_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID_List_Adv", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID_List_Adv(i_Params_Get_Entity_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID_List_Adv", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_List_Adv
        public List<Entity> Get_Entity_By_AREA_ID_List_Adv(Params_Get_Entity_By_AREA_ID_List i_Params_Get_Entity_By_AREA_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID_List_Adv", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID_List_Adv(i_Params_Get_Entity_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID_List_Adv", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List_Adv
        public List<Entity> Get_Entity_By_DISTRICT_ID_List_Adv(Params_Get_Entity_By_DISTRICT_ID_List i_Params_Get_Entity_By_DISTRICT_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID_List_Adv", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID_List_Adv(i_Params_Get_Entity_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID_List_Adv", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_List_Adv
        public List<Entity> Get_Entity_By_REGION_ID_List_Adv(Params_Get_Entity_By_REGION_ID_List i_Params_Get_Entity_By_REGION_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID_List_Adv", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID_List_Adv(i_Params_Get_Entity_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID_List_Adv", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List_Adv
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_List_Adv(Params_Get_Entity_By_TOP_LEVEL_ID_List i_Params_Get_Entity_By_TOP_LEVEL_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_Entity_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List.ENTITY_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_Where_Adv
        public List<Entity_view> Get_Entity_view_By_Where_Adv(Params_Get_Entity_view_By_Where i_Params_Get_Entity_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_Where_Adv", i_Params_Get_Entity_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_view_By_Where.OWNER_ID == null || i_Params_Get_Entity_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Entity_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Entity_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Entity_view_By_Where.FETCH_NEXT == null || i_Params_Get_Entity_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_Where_Adv(i_Params_Get_Entity_view_By_Where.DESCRIPTION, i_Params_Get_Entity_view_By_Where.OWNER_ID, i_Params_Get_Entity_view_By_Where.OFFSET, i_Params_Get_Entity_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            i_Params_Get_Entity_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_Where_Adv", i_Params_Get_Entity_view_By_Where_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_Where_Adv
        public List<Entity> Get_Entity_By_Where_Adv(Params_Get_Entity_By_Where i_Params_Get_Entity_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where_Adv", i_Params_Get_Entity_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_By_Where.OWNER_ID == null || i_Params_Get_Entity_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Entity_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_By_Where.OFFSET == null)
            {
                i_Params_Get_Entity_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Entity_By_Where.FETCH_NEXT == null || i_Params_Get_Entity_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where_Adv(i_Params_Get_Entity_By_Where.NAME, i_Params_Get_Entity_By_Where.GLA_UNIT, i_Params_Get_Entity_By_Where.UNIT, i_Params_Get_Entity_By_Where.IMAGE_URL, i_Params_Get_Entity_By_Where.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where.OWNER_ID, i_Params_Get_Entity_By_Where.OFFSET, i_Params_Get_Entity_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where_Adv", i_Params_Get_Entity_By_Where_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_Where_In_List_Adv
        public List<Entity_view> Get_Entity_view_By_Where_In_List_Adv(Params_Get_Entity_view_By_Where_In_List i_Params_Get_Entity_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_Where_In_List_Adv", i_Params_Get_Entity_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Entity_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_Where_In_List_Adv(i_Params_Get_Entity_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_view_By_Where_In_List.OFFSET, i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            i_Params_Get_Entity_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_Where_In_List_Adv", i_Params_Get_Entity_view_By_Where_In_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_Where_In_List_Adv
        public List<Entity> Get_Entity_By_Where_In_List_Adv(Params_Get_Entity_By_Where_In_List i_Params_Get_Entity_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where_In_List_Adv", i_Params_Get_Entity_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_By_Where_In_List.OWNER_ID == null || i_Params_Get_Entity_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Entity_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Entity_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where_In_List_Adv(i_Params_Get_Entity_By_Where_In_List.NAME, i_Params_Get_Entity_By_Where_In_List.GLA_UNIT, i_Params_Get_Entity_By_Where_In_List.UNIT, i_Params_Get_Entity_By_Where_In_List.IMAGE_URL, i_Params_Get_Entity_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_By_Where_In_List.OFFSET, i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where_In_List_Adv", i_Params_Get_Entity_By_Where_In_List_json, false);
            }
            return oList_Entity;
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
    }
}
