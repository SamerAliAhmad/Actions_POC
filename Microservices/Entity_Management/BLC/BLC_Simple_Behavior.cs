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
        private Entity_view _Entity_view;
        private List<Entity_view> _List_Entity_view;
        private Entity _Entity;
        private List<Entity> _List_Entity;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Entity_view_Execution;
        private bool _Stop_Delete_Entity_view_Execution;
        private bool _Stop_Edit_Entity_Execution;
        private bool _Stop_Delete_Entity_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        #endregion
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID
        public Entity_view Get_Entity_view_By_ENTITY_VIEW_ID(Params_Get_Entity_view_By_ENTITY_VIEW_ID i_Params_Get_Entity_view_By_ENTITY_VIEW_ID)
        {
            Entity_view oEntity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_view oDBEntry = _AppContext.Get_Entity_view_By_ENTITY_VIEW_ID(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID.ENTITY_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_view").Replace("%2", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID.ENTITY_VIEW_ID.ToString()));
            }
            oEntity_view = new Entity_view();
            Props.Copy_Prop_Values(oDBEntry, oEntity_view);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json, false);
            }
            return oEntity_view;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID
        public Entity Get_Entity_By_ENTITY_ID(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            Entity oEntity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            #region PreEvent_Get_Entity_By_ENTITY_ID
            if (OnPreEvent_Get_Entity_By_ENTITY_ID != null)
            {
                OnPreEvent_Get_Entity_By_ENTITY_ID(i_Params_Get_Entity_By_ENTITY_ID);
            }
            #endregion
            #region Body Section.
            DALC.Entity oDBEntry = _AppContext.Get_Entity_By_ENTITY_ID(i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity").Replace("%2", i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID.ToString()));
            }
            oEntity = new Entity();
            Props.Copy_Prop_Values(oDBEntry, oEntity);
            #endregion
            #region PostEvent_Get_Entity_By_ENTITY_ID
            if (OnPostEvent_Get_Entity_By_ENTITY_ID != null)
            {
                OnPostEvent_Get_Entity_By_ENTITY_ID(ref oEntity, i_Params_Get_Entity_By_ENTITY_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            return oEntity;
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
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List
        public List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List(Params_Get_Entity_view_By_ENTITY_VIEW_ID_List i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_List", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_VIEW_ID_List(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List.ENTITY_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_List", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_List
        public List<Entity> Get_Entity_By_ENTITY_ID_List(Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID_List", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            #region PreEvent_Get_Entity_By_ENTITY_ID_List
            if (OnPreEvent_Get_Entity_By_ENTITY_ID_List != null)
            {
                OnPreEvent_Get_Entity_By_ENTITY_ID_List(i_Params_Get_Entity_By_ENTITY_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_ID_List(i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Entity_By_ENTITY_ID_List
            if (OnPostEvent_Get_Entity_By_ENTITY_ID_List != null)
            {
                OnPostEvent_Get_Entity_By_ENTITY_ID_List(oList_Entity, i_Params_Get_Entity_By_ENTITY_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID_List", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_OWNER_ID
        public List<Entity_view> Get_Entity_view_By_OWNER_ID(Params_Get_Entity_view_By_OWNER_ID i_Params_Get_Entity_view_By_OWNER_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_OWNER_ID", i_Params_Get_Entity_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_OWNER_ID(i_Params_Get_Entity_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_OWNER_ID", i_Params_Get_Entity_view_By_OWNER_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID(Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_VIEW_TYPE_SETUP_ID(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED(Params_Get_Entity_view_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_OWNER_ID_IS_DELETED(i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID(Params_Get_Entity_view_By_ENTITY_ID i_Params_Get_Entity_view_By_ENTITY_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_ID", i_Params_Get_Entity_view_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_ID(i_Params_Get_Entity_view_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_ID", i_Params_Get_Entity_view_By_ENTITY_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED
        public List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED(Params_Get_Entity_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_By_OWNER_ID_IS_DELETED)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID_IS_DELETED(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID
        public List<Entity> Get_Entity_By_OWNER_ID(Params_Get_Entity_By_OWNER_ID i_Params_Get_Entity_By_OWNER_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID(i_Params_Get_Entity_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_SITE_ID
        public List<Entity> Get_Entity_By_SITE_ID(Params_Get_Entity_By_SITE_ID i_Params_Get_Entity_By_SITE_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            #region PreEvent_Get_Entity_By_SITE_ID
            if (OnPreEvent_Get_Entity_By_SITE_ID != null)
            {
                OnPreEvent_Get_Entity_By_SITE_ID(i_Params_Get_Entity_By_SITE_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID(i_Params_Get_Entity_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Entity_By_SITE_ID
            if (OnPostEvent_Get_Entity_By_SITE_ID != null)
            {
                OnPostEvent_Get_Entity_By_SITE_ID(ref oList_Entity, i_Params_Get_Entity_By_SITE_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID
        public List<Entity> Get_Entity_By_AREA_ID(Params_Get_Entity_By_AREA_ID i_Params_Get_Entity_By_AREA_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID(i_Params_Get_Entity_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID
        public List<Entity> Get_Entity_By_DISTRICT_ID(Params_Get_Entity_By_DISTRICT_ID i_Params_Get_Entity_By_DISTRICT_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID(i_Params_Get_Entity_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID
        public List<Entity> Get_Entity_By_REGION_ID(Params_Get_Entity_By_REGION_ID i_Params_Get_Entity_By_REGION_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID(i_Params_Get_Entity_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID(Params_Get_Entity_By_TOP_LEVEL_ID i_Params_Get_Entity_By_TOP_LEVEL_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            #region PreEvent_Get_Entity_By_TOP_LEVEL_ID
            if (OnPreEvent_Get_Entity_By_TOP_LEVEL_ID != null)
            {
                OnPreEvent_Get_Entity_By_TOP_LEVEL_ID(i_Params_Get_Entity_By_TOP_LEVEL_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID(i_Params_Get_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Entity_By_TOP_LEVEL_ID
            if (OnPostEvent_Get_Entity_By_TOP_LEVEL_ID != null)
            {
                OnPostEvent_Get_Entity_By_TOP_LEVEL_ID(oList_Entity, i_Params_Get_Entity_By_TOP_LEVEL_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List(Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_List(Params_Get_Entity_view_By_ENTITY_ID_List i_Params_Get_Entity_view_By_ENTITY_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_ID_List", i_Params_Get_Entity_view_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_ID_List(i_Params_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_ID_List", i_Params_Get_Entity_view_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_List
        public List<Entity> Get_Entity_By_SITE_ID_List(Params_Get_Entity_By_SITE_ID_List i_Params_Get_Entity_By_SITE_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID_List", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID_List(i_Params_Get_Entity_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID_List", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_List
        public List<Entity> Get_Entity_By_AREA_ID_List(Params_Get_Entity_By_AREA_ID_List i_Params_Get_Entity_By_AREA_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID_List", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID_List(i_Params_Get_Entity_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID_List", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List
        public List<Entity> Get_Entity_By_DISTRICT_ID_List(Params_Get_Entity_By_DISTRICT_ID_List i_Params_Get_Entity_By_DISTRICT_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID_List", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID_List(i_Params_Get_Entity_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID_List", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_List
        public List<Entity> Get_Entity_By_REGION_ID_List(Params_Get_Entity_By_REGION_ID_List i_Params_Get_Entity_By_REGION_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID_List", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID_List(i_Params_Get_Entity_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID_List", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_List(Params_Get_Entity_By_TOP_LEVEL_ID_List i_Params_Get_Entity_By_TOP_LEVEL_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID_List", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID_List(i_Params_Get_Entity_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID_List", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID_List(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List.ENTITY_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_Where
        public List<Entity_view> Get_Entity_view_By_Where(Params_Get_Entity_view_By_Where i_Params_Get_Entity_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_Where", i_Params_Get_Entity_view_By_Where_json, false);
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
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_Where(i_Params_Get_Entity_view_By_Where.DESCRIPTION, i_Params_Get_Entity_view_By_Where.OWNER_ID, i_Params_Get_Entity_view_By_Where.OFFSET, i_Params_Get_Entity_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            i_Params_Get_Entity_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_Where", i_Params_Get_Entity_view_By_Where_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_Where
        public List<Entity> Get_Entity_By_Where(Params_Get_Entity_By_Where i_Params_Get_Entity_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where", i_Params_Get_Entity_By_Where_json, false);
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
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where(i_Params_Get_Entity_By_Where.NAME, i_Params_Get_Entity_By_Where.GLA_UNIT, i_Params_Get_Entity_By_Where.UNIT, i_Params_Get_Entity_By_Where.IMAGE_URL, i_Params_Get_Entity_By_Where.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where.OWNER_ID, i_Params_Get_Entity_By_Where.OFFSET, i_Params_Get_Entity_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where", i_Params_Get_Entity_By_Where_json, false);
            }
            return oList_Entity;
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
        #region Get_Entity_view_By_Where_In_List
        public List<Entity_view> Get_Entity_view_By_Where_In_List(Params_Get_Entity_view_By_Where_In_List i_Params_Get_Entity_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_Where_In_List", i_Params_Get_Entity_view_By_Where_In_List_json, false);
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
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_Where_In_List(i_Params_Get_Entity_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_view_By_Where_In_List.OFFSET, i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            i_Params_Get_Entity_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_Where_In_List", i_Params_Get_Entity_view_By_Where_In_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_Where_In_List
        public List<Entity> Get_Entity_By_Where_In_List(Params_Get_Entity_By_Where_In_List i_Params_Get_Entity_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where_In_List", i_Params_Get_Entity_By_Where_In_List_json, false);
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
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where_In_List(i_Params_Get_Entity_By_Where_In_List.NAME, i_Params_Get_Entity_By_Where_In_List.GLA_UNIT, i_Params_Get_Entity_By_Where_In_List.UNIT, i_Params_Get_Entity_By_Where_In_List.IMAGE_URL, i_Params_Get_Entity_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_By_Where_In_List.OFFSET, i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where_In_List", i_Params_Get_Entity_By_Where_In_List_json, false);
            }
            return oList_Entity;
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
        #region Delete_Entity_view
        public void Delete_Entity_view(Params_Delete_Entity_view i_Params_Delete_Entity_view)
        {
            var i_Params_Delete_Entity_view_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_view);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_view", i_Params_Delete_Entity_view_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_view_By_ENTITY_VIEW_ID oParams_Get_Entity_view_By_ENTITY_VIEW_ID = new Params_Get_Entity_view_By_ENTITY_VIEW_ID
                {
                    ENTITY_VIEW_ID = i_Params_Delete_Entity_view.ENTITY_VIEW_ID
                };
                _Entity_view = Get_Entity_view_By_ENTITY_VIEW_ID(oParams_Get_Entity_view_By_ENTITY_VIEW_ID);
                if (_Entity_view != null)
                {
                    if (_Stop_Delete_Entity_view_Execution)
                    {
                        _Stop_Delete_Entity_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_view(i_Params_Delete_Entity_view.ENTITY_VIEW_ID);
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
                OnPostEvent_General("Delete_Entity_view", i_Params_Delete_Entity_view_json, false);
            }
        }
        #endregion
        #region Delete_Entity
        public void Delete_Entity(Params_Delete_Entity i_Params_Delete_Entity)
        {
            var i_Params_Delete_Entity_json = JsonConvert.SerializeObject(i_Params_Delete_Entity);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity", i_Params_Delete_Entity_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_ENTITY_ID oParams_Get_Entity_By_ENTITY_ID = new Params_Get_Entity_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Entity.ENTITY_ID
                };
                _Entity = Get_Entity_By_ENTITY_ID(oParams_Get_Entity_By_ENTITY_ID);
                if (_Entity != null)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity(i_Params_Delete_Entity.ENTITY_ID);
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
                OnPostEvent_General("Delete_Entity", i_Params_Delete_Entity_json, false);
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
        #region Delete_Entity_view_By_OWNER_ID
        public void Delete_Entity_view_By_OWNER_ID(Params_Delete_Entity_view_By_OWNER_ID i_Params_Delete_Entity_view_By_OWNER_ID)
        {
            var i_Params_Delete_Entity_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_view_By_OWNER_ID", i_Params_Delete_Entity_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_view_By_OWNER_ID oParams_Get_Entity_view_By_OWNER_ID = new Params_Get_Entity_view_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Entity_view_By_OWNER_ID.OWNER_ID
                };
                _List_Entity_view = Get_Entity_view_By_OWNER_ID(oParams_Get_Entity_view_By_OWNER_ID);
                if (_List_Entity_view != null && _List_Entity_view.Count > 0)
                {
                    if (_Stop_Delete_Entity_view_Execution)
                    {
                        _Stop_Delete_Entity_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_view_By_OWNER_ID(i_Params_Delete_Entity_view_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Entity_view_By_OWNER_ID", i_Params_Delete_Entity_view_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Entity_view_By_VIEW_TYPE_SETUP_ID(Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_view_By_VIEW_TYPE_SETUP_ID", i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID oParams_Get_Entity_view_By_VIEW_TYPE_SETUP_ID = new Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID
                {
                    VIEW_TYPE_SETUP_ID = i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID
                };
                _List_Entity_view = Get_Entity_view_By_VIEW_TYPE_SETUP_ID(oParams_Get_Entity_view_By_VIEW_TYPE_SETUP_ID);
                if (_List_Entity_view != null && _List_Entity_view.Count > 0)
                {
                    if (_Stop_Delete_Entity_view_Execution)
                    {
                        _Stop_Delete_Entity_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_view_By_VIEW_TYPE_SETUP_ID(i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_Entity_view_By_VIEW_TYPE_SETUP_ID", i_Params_Delete_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_view_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_view_By_OWNER_ID_IS_DELETED(Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_view_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_view_By_OWNER_ID_IS_DELETED oParams_Get_Entity_view_By_OWNER_ID_IS_DELETED = new Params_Get_Entity_view_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Entity_view = Get_Entity_view_By_OWNER_ID_IS_DELETED(oParams_Get_Entity_view_By_OWNER_ID_IS_DELETED);
                if (_List_Entity_view != null && _List_Entity_view.Count > 0)
                {
                    if (_Stop_Delete_Entity_view_Execution)
                    {
                        _Stop_Delete_Entity_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_view_By_OWNER_ID_IS_DELETED(i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Entity_view_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Entity_view_By_ENTITY_ID
        public void Delete_Entity_view_By_ENTITY_ID(Params_Delete_Entity_view_By_ENTITY_ID i_Params_Delete_Entity_view_By_ENTITY_ID)
        {
            var i_Params_Delete_Entity_view_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_view_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_view_By_ENTITY_ID", i_Params_Delete_Entity_view_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_view_By_ENTITY_ID oParams_Get_Entity_view_By_ENTITY_ID = new Params_Get_Entity_view_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Entity_view_By_ENTITY_ID.ENTITY_ID
                };
                _List_Entity_view = Get_Entity_view_By_ENTITY_ID(oParams_Get_Entity_view_By_ENTITY_ID);
                if (_List_Entity_view != null && _List_Entity_view.Count > 0)
                {
                    if (_Stop_Delete_Entity_view_Execution)
                    {
                        _Stop_Delete_Entity_view_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_view_By_ENTITY_ID(i_Params_Delete_Entity_view_By_ENTITY_ID.ENTITY_ID);
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
                OnPostEvent_General("Delete_Entity_view_By_ENTITY_ID", i_Params_Delete_Entity_view_By_ENTITY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_By_OWNER_ID_IS_DELETED(Params_Delete_Entity_By_OWNER_ID_IS_DELETED i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_OWNER_ID_IS_DELETED oParams_Get_Entity_By_OWNER_ID_IS_DELETED = new Params_Get_Entity_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Entity = Get_Entity_By_OWNER_ID_IS_DELETED(oParams_Get_Entity_By_OWNER_ID_IS_DELETED);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_OWNER_ID_IS_DELETED(i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Entity_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_OWNER_ID
        public void Delete_Entity_By_OWNER_ID(Params_Delete_Entity_By_OWNER_ID i_Params_Delete_Entity_By_OWNER_ID)
        {
            var i_Params_Delete_Entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_OWNER_ID", i_Params_Delete_Entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_OWNER_ID oParams_Get_Entity_By_OWNER_ID = new Params_Get_Entity_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Entity_By_OWNER_ID.OWNER_ID
                };
                _List_Entity = Get_Entity_By_OWNER_ID(oParams_Get_Entity_By_OWNER_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_OWNER_ID(i_Params_Delete_Entity_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Entity_By_OWNER_ID", i_Params_Delete_Entity_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_SITE_ID
        public void Delete_Entity_By_SITE_ID(Params_Delete_Entity_By_SITE_ID i_Params_Delete_Entity_By_SITE_ID)
        {
            var i_Params_Delete_Entity_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_SITE_ID", i_Params_Delete_Entity_By_SITE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_SITE_ID oParams_Get_Entity_By_SITE_ID = new Params_Get_Entity_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Entity_By_SITE_ID.SITE_ID
                };
                _List_Entity = Get_Entity_By_SITE_ID(oParams_Get_Entity_By_SITE_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_SITE_ID(i_Params_Delete_Entity_By_SITE_ID.SITE_ID);
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
                OnPostEvent_General("Delete_Entity_By_SITE_ID", i_Params_Delete_Entity_By_SITE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_AREA_ID
        public void Delete_Entity_By_AREA_ID(Params_Delete_Entity_By_AREA_ID i_Params_Delete_Entity_By_AREA_ID)
        {
            var i_Params_Delete_Entity_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_AREA_ID", i_Params_Delete_Entity_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_AREA_ID oParams_Get_Entity_By_AREA_ID = new Params_Get_Entity_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Entity_By_AREA_ID.AREA_ID
                };
                _List_Entity = Get_Entity_By_AREA_ID(oParams_Get_Entity_By_AREA_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_AREA_ID(i_Params_Delete_Entity_By_AREA_ID.AREA_ID);
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
                OnPostEvent_General("Delete_Entity_By_AREA_ID", i_Params_Delete_Entity_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_DISTRICT_ID
        public void Delete_Entity_By_DISTRICT_ID(Params_Delete_Entity_By_DISTRICT_ID i_Params_Delete_Entity_By_DISTRICT_ID)
        {
            var i_Params_Delete_Entity_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_DISTRICT_ID", i_Params_Delete_Entity_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_DISTRICT_ID oParams_Get_Entity_By_DISTRICT_ID = new Params_Get_Entity_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_Entity_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_Entity = Get_Entity_By_DISTRICT_ID(oParams_Get_Entity_By_DISTRICT_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_DISTRICT_ID(i_Params_Delete_Entity_By_DISTRICT_ID.DISTRICT_ID);
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
                OnPostEvent_General("Delete_Entity_By_DISTRICT_ID", i_Params_Delete_Entity_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_REGION_ID
        public void Delete_Entity_By_REGION_ID(Params_Delete_Entity_By_REGION_ID i_Params_Delete_Entity_By_REGION_ID)
        {
            var i_Params_Delete_Entity_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_REGION_ID", i_Params_Delete_Entity_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_REGION_ID oParams_Get_Entity_By_REGION_ID = new Params_Get_Entity_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_Entity_By_REGION_ID.REGION_ID
                };
                _List_Entity = Get_Entity_By_REGION_ID(oParams_Get_Entity_By_REGION_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_REGION_ID(i_Params_Delete_Entity_By_REGION_ID.REGION_ID);
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
                OnPostEvent_General("Delete_Entity_By_REGION_ID", i_Params_Delete_Entity_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_TOP_LEVEL_ID
        public void Delete_Entity_By_TOP_LEVEL_ID(Params_Delete_Entity_By_TOP_LEVEL_ID i_Params_Delete_Entity_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_Entity_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_TOP_LEVEL_ID", i_Params_Delete_Entity_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_TOP_LEVEL_ID oParams_Get_Entity_By_TOP_LEVEL_ID = new Params_Get_Entity_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_Entity = Get_Entity_By_TOP_LEVEL_ID(oParams_Get_Entity_By_TOP_LEVEL_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_TOP_LEVEL_ID(i_Params_Delete_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
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
                OnPostEvent_General("Delete_Entity_By_TOP_LEVEL_ID", i_Params_Delete_Entity_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_ENTITY_TYPE_SETUP_ID
        public void Delete_Entity_By_ENTITY_TYPE_SETUP_ID(Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID oParams_Get_Entity_By_ENTITY_TYPE_SETUP_ID = new Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID
                {
                    ENTITY_TYPE_SETUP_ID = i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID
                };
                _List_Entity = Get_Entity_By_ENTITY_TYPE_SETUP_ID(oParams_Get_Entity_By_ENTITY_TYPE_SETUP_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_ENTITY_TYPE_SETUP_ID(i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
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
        #region Edit_Entity_view
        public void Edit_Entity_view(Entity_view i_Entity_view)
        {
            var i_Entity_view_json = JsonConvert.SerializeObject(i_Entity_view);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Entity_view.ENTITY_VIEW_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_view", i_Entity_view_json, false);
            }
            #region Body Section.
            if (i_Entity_view.ENTITY_VIEW_ID == null || i_Entity_view.ENTITY_VIEW_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Entity_view");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Entity_view.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Entity_view.IS_DELETED = false;
            }
            else
            {
                _Entity_view = Get_Entity_view_By_ENTITY_VIEW_ID(new Params_Get_Entity_view_By_ENTITY_VIEW_ID
                {
                    ENTITY_VIEW_ID = i_Entity_view.ENTITY_VIEW_ID
                });
            }
            i_Entity_view.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Entity_view.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Entity_view.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Entity_view_Execution)
            {
                _Stop_Edit_Entity_view_Execution = false;
                return;
            }
            i_Entity_view.ENTITY_VIEW_ID = _AppContext.Edit_Entity_view
            (
                i_Entity_view.ENTITY_VIEW_ID,
                i_Entity_view.ENTITY_ID,
                i_Entity_view.VIEW_TYPE_SETUP_ID,
                i_Entity_view.PITCH,
                i_Entity_view.BEARING,
                i_Entity_view.ZOOM,
                i_Entity_view.LATITUDE,
                i_Entity_view.LONGITUDE,
                i_Entity_view.ENTRY_USER_ID,
                i_Entity_view.ENTRY_DATE,
                i_Entity_view.LAST_UPDATE,
                i_Entity_view.IS_DELETED,
                i_Entity_view.OWNER_ID,
                i_Entity_view.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_view", i_Entity_view_json, false);
            }
        }
        #endregion
        #region Edit_Entity
        public void Edit_Entity(Entity i_Entity)
        {
            var i_Entity_json = JsonConvert.SerializeObject(i_Entity);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Entity.ENTITY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity", i_Entity_json, false);
            }
            #region Body Section.
            if (i_Entity.ENTITY_ID == null || i_Entity.ENTITY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Entity");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Entity.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Entity.IS_DELETED = false;
            }
            else
            {
                _Entity = Get_Entity_By_ENTITY_ID(new Params_Get_Entity_By_ENTITY_ID
                {
                    ENTITY_ID = i_Entity.ENTITY_ID
                });
            }
            i_Entity.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Entity.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Entity.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Entity
            if (OnPreEvent_Edit_Entity != null)
            {
                OnPreEvent_Edit_Entity(i_Entity, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Entity_Execution)
            {
                _Stop_Edit_Entity_Execution = false;
                return;
            }
            i_Entity.ENTITY_ID = _AppContext.Edit_Entity
            (
                i_Entity.ENTITY_ID,
                i_Entity.SITE_ID,
                i_Entity.AREA_ID,
                i_Entity.DISTRICT_ID,
                i_Entity.REGION_ID,
                i_Entity.TOP_LEVEL_ID,
                i_Entity.ENTITY_TYPE_SETUP_ID,
                i_Entity.NAME,
                i_Entity.NUMBER_OF_FLOORS,
                i_Entity.GLA,
                i_Entity.GLA_UNIT,
                i_Entity.AREA,
                i_Entity.UNIT,
                i_Entity.SCALE,
                i_Entity.ROTATIONX,
                i_Entity.ROTATIONY,
                i_Entity.ROTATIONZ,
                i_Entity.GLTF_LATITUDE,
                i_Entity.GLTF_LONGITUDE,
                i_Entity.CENTER_LATITUDE,
                i_Entity.CENTER_LONGITUDE,
                i_Entity.RADIUS_IN_METERS,
                i_Entity.IMAGE_URL,
                i_Entity.SOLID_GLTF_URL,
                i_Entity.POPUL_ALT_X,
                i_Entity.POPUP_ALT_Y,
                i_Entity.POPUP_ALT_Z,
                i_Entity.ENTRY_USER_ID,
                i_Entity.ENTRY_DATE,
                i_Entity.LAST_UPDATE,
                i_Entity.IS_DELETED,
                i_Entity.OWNER_ID
            );
            #region PostEvent_Edit_Entity
            if (OnPostEvent_Edit_Entity != null)
            {
                OnPostEvent_Edit_Entity(i_Entity, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity", i_Entity_json, false);
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
        #region Edit_Entity_view_List
        public void Edit_Entity_view_List(Params_Edit_Entity_view_List i_Params_Edit_Entity_view_List)
        {
            var i_Params_Edit_Entity_view_List_json = JsonConvert.SerializeObject(i_Params_Edit_Entity_view_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_view_List", i_Params_Edit_Entity_view_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Entity_view_List.List_To_Edit != null)
            {
                i_Params_Edit_Entity_view_List.List_Failed_Edit = new List<Entity_view>();
                if (i_Params_Edit_Entity_view_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oEntity_view in i_Params_Edit_Entity_view_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Entity_view(oEntity_view);
                        }
                        catch
                        {
                            i_Params_Edit_Entity_view_List.List_Failed_Edit.Add(oEntity_view);
                        }
                    }
                }
                i_Params_Edit_Entity_view_List.List_To_Edit = i_Params_Edit_Entity_view_List.List_To_Edit.Except(i_Params_Edit_Entity_view_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Entity_view_List.List_To_Delete != null)
            {
                i_Params_Edit_Entity_view_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Entity_view_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Entity_view_ID in i_Params_Edit_Entity_view_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Entity_view(new Params_Delete_Entity_view()
                            {
                                ENTITY_VIEW_ID = Entity_view_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Entity_view_List.List_Failed_Delete.Add(Entity_view_ID);
                        }
                    }
                }
                i_Params_Edit_Entity_view_List.List_To_Delete = i_Params_Edit_Entity_view_List.List_To_Delete.Except(i_Params_Edit_Entity_view_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_view_List", i_Params_Edit_Entity_view_List_json, false);
            }
        }
        #endregion
        #region Edit_Entity_List
        public void Edit_Entity_List(Params_Edit_Entity_List i_Params_Edit_Entity_List)
        {
            var i_Params_Edit_Entity_List_json = JsonConvert.SerializeObject(i_Params_Edit_Entity_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_List", i_Params_Edit_Entity_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Entity_List.List_To_Edit != null)
            {
                i_Params_Edit_Entity_List.List_Failed_Edit = new List<Entity>();
                if (i_Params_Edit_Entity_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oEntity in i_Params_Edit_Entity_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Entity(oEntity);
                        }
                        catch
                        {
                            i_Params_Edit_Entity_List.List_Failed_Edit.Add(oEntity);
                        }
                    }
                }
                i_Params_Edit_Entity_List.List_To_Edit = i_Params_Edit_Entity_List.List_To_Edit.Except(i_Params_Edit_Entity_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Entity_List.List_To_Delete != null)
            {
                i_Params_Edit_Entity_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Entity_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Entity_ID in i_Params_Edit_Entity_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Entity(new Params_Delete_Entity()
                            {
                                ENTITY_ID = Entity_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Entity_List.List_Failed_Delete.Add(Entity_ID);
                        }
                    }
                }
                i_Params_Edit_Entity_List.List_To_Delete = i_Params_Edit_Entity_List.List_To_Delete.Except(i_Params_Edit_Entity_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_List", i_Params_Edit_Entity_List_json, false);
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