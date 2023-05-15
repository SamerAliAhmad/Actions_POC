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
        private User _User;
        private List<User> _List_User;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_User_Execution;
        private bool _Stop_Delete_User_Execution;
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
        #region Get_User_By_USER_ID
        public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID", i_Params_Get_User_By_USER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User").Replace("%2", i_Params_Get_User_By_USER_ID.USER_ID.ToString()));
            }
            oUser = new User();
            Props.Copy_Prop_Values(oDBEntry, oUser);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID", i_Params_Get_User_By_USER_ID_json, false);
            }
            return oUser;
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
        #region Get_User_By_USER_ID_List
        public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID_List", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            #region PreEvent_Get_User_By_USER_ID_List
            if (OnPreEvent_Get_User_By_USER_ID_List != null)
            {
                OnPreEvent_Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_User_By_USER_ID_List
            if (OnPostEvent_Get_User_By_USER_ID_List != null)
            {
                OnPostEvent_Get_User_By_USER_ID_List(oList_User, i_Params_Get_User_By_USER_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID_List", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            return oList_User;
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
        #region Get_User_By_OWNER_ID_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_DELETED(Params_Get_User_By_OWNER_ID_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_DELETED(i_Params_Get_User_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID
        public User Get_User_By_USERNAME_OWNER_ID(Params_Get_User_By_USERNAME_OWNER_ID i_Params_Get_User_By_USERNAME_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USERNAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USERNAME_OWNER_ID", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USERNAME_OWNER_ID(i_Params_Get_User_By_USERNAME_OWNER_ID.USERNAME, i_Params_Get_User_By_USERNAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USERNAME_OWNER_ID", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID
        public User Get_User_By_EMAIL_OWNER_ID(Params_Get_User_By_EMAIL_OWNER_ID i_Params_Get_User_By_EMAIL_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_EMAIL_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_EMAIL_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_EMAIL_OWNER_ID", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_EMAIL_OWNER_ID(i_Params_Get_User_By_EMAIL_OWNER_ID.EMAIL, i_Params_Get_User_By_EMAIL_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_EMAIL_OWNER_ID", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID
        public List<User> Get_User_By_USER_TYPE_SETUP_ID(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID(i_Params_Get_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID
        public List<User> Get_User_By_ORGANIZATION_ID(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID(i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID
        public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL
        public List<User> Get_User_By_IS_RECEIVE_EMAIL(Params_Get_User_By_IS_RECEIVE_EMAIL i_Params_Get_User_By_IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_RECEIVE_EMAIL_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_RECEIVE_EMAIL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_RECEIVE_EMAIL", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_RECEIVE_EMAIL(i_Params_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_RECEIVE_EMAIL", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED
        public List<User> Get_User_By_IS_DELETED(Params_Get_User_By_IS_DELETED i_Params_Get_User_By_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_DELETED", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_DELETED(i_Params_Get_User_By_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_DELETED", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            return oList_User;
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
        #region Get_User_By_USER_TYPE_SETUP_ID_List
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID_List(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List.USER_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List
        public List<User> Get_User_By_ORGANIZATION_ID_List(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID_List", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_User_By_ORGANIZATION_ID_List
            if (OnPreEvent_Get_User_By_ORGANIZATION_ID_List != null)
            {
                OnPreEvent_Get_User_By_ORGANIZATION_ID_List(i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID_List(i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_User_By_ORGANIZATION_ID_List
            if (OnPostEvent_Get_User_By_ORGANIZATION_ID_List != null)
            {
                OnPostEvent_Get_User_By_ORGANIZATION_ID_List(oList_User, i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID_List", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_User;
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
        #region Get_User_By_Where
        public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where", i_Params_Get_User_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_By_Where.OWNER_ID == null || i_Params_Get_User_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_User_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_By_Where.OFFSET == null)
            {
                i_Params_Get_User_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_User_By_Where.FETCH_NEXT == null || i_Params_Get_User_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_User_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.FIRST_NAME, i_Params_Get_User_By_Where.LAST_NAME, i_Params_Get_User_By_Where.USERNAME, i_Params_Get_User_By_Where.PASSWORD, i_Params_Get_User_By_Where.EMAIL, i_Params_Get_User_By_Where.PHONE_NUMBER, i_Params_Get_User_By_Where.IMAGE_URL, i_Params_Get_User_By_Where.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where.OWNER_ID, i_Params_Get_User_By_Where.OFFSET, i_Params_Get_User_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where", i_Params_Get_User_By_Where_json, false);
            }
            return oList_User;
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
        #region Get_User_By_Where_In_List
        public List<User> Get_User_By_Where_In_List(Params_Get_User_By_Where_In_List i_Params_Get_User_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where_In_List", i_Params_Get_User_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_By_Where_In_List.OWNER_ID == null || i_Params_Get_User_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_User_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_User_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_User_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_User_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_User_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where_In_List(i_Params_Get_User_By_Where_In_List.FIRST_NAME, i_Params_Get_User_By_Where_In_List.LAST_NAME, i_Params_Get_User_By_Where_In_List.USERNAME, i_Params_Get_User_By_Where_In_List.PASSWORD, i_Params_Get_User_By_Where_In_List.EMAIL, i_Params_Get_User_By_Where_In_List.PHONE_NUMBER, i_Params_Get_User_By_Where_In_List.IMAGE_URL, i_Params_Get_User_By_Where_In_List.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST, i_Params_Get_User_By_Where_In_List.OWNER_ID, i_Params_Get_User_By_Where_In_List.OFFSET, i_Params_Get_User_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where_In_List", i_Params_Get_User_By_Where_In_List_json, false);
            }
            return oList_User;
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
        #region Delete_User
        public void Delete_User(Params_Delete_User i_Params_Delete_User)
        {
            var i_Params_Delete_User_json = JsonConvert.SerializeObject(i_Params_Delete_User);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User", i_Params_Delete_User_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_Params_Delete_User.USER_ID
                };
                _User = Get_User_By_USER_ID(oParams_Get_User_By_USER_ID);
                if (_User != null)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User(i_Params_Delete_User.USER_ID);
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
                OnPostEvent_General("Delete_User", i_Params_Delete_User_json, false);
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
        #region Delete_User_By_OWNER_ID_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_DELETED(Params_Delete_User_By_OWNER_ID_IS_DELETED i_Params_Delete_User_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_User_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_OWNER_ID_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_OWNER_ID_IS_DELETED oParams_Get_User_By_OWNER_ID_IS_DELETED = new Params_Get_User_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_User_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_User_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_User = Get_User_By_OWNER_ID_IS_DELETED(oParams_Get_User_By_OWNER_ID_IS_DELETED);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_OWNER_ID_IS_DELETED(i_Params_Delete_User_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_User_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_User_By_OWNER_ID_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_User_By_USERNAME_OWNER_ID
        public void Delete_User_By_USERNAME_OWNER_ID(Params_Delete_User_By_USERNAME_OWNER_ID i_Params_Delete_User_By_USERNAME_OWNER_ID)
        {
            var i_Params_Delete_User_By_USERNAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_USERNAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_USERNAME_OWNER_ID", i_Params_Delete_User_By_USERNAME_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_USERNAME_OWNER_ID oParams_Get_User_By_USERNAME_OWNER_ID = new Params_Get_User_By_USERNAME_OWNER_ID
                {
                    USERNAME = i_Params_Delete_User_By_USERNAME_OWNER_ID.USERNAME,
                    OWNER_ID = i_Params_Delete_User_By_USERNAME_OWNER_ID.OWNER_ID
                };
                _User = Get_User_By_USERNAME_OWNER_ID(oParams_Get_User_By_USERNAME_OWNER_ID);
                if (_User != null)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_USERNAME_OWNER_ID(i_Params_Delete_User_By_USERNAME_OWNER_ID.USERNAME, i_Params_Delete_User_By_USERNAME_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_User_By_USERNAME_OWNER_ID", i_Params_Delete_User_By_USERNAME_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_EMAIL_OWNER_ID
        public void Delete_User_By_EMAIL_OWNER_ID(Params_Delete_User_By_EMAIL_OWNER_ID i_Params_Delete_User_By_EMAIL_OWNER_ID)
        {
            var i_Params_Delete_User_By_EMAIL_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_EMAIL_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_EMAIL_OWNER_ID", i_Params_Delete_User_By_EMAIL_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_EMAIL_OWNER_ID oParams_Get_User_By_EMAIL_OWNER_ID = new Params_Get_User_By_EMAIL_OWNER_ID
                {
                    EMAIL = i_Params_Delete_User_By_EMAIL_OWNER_ID.EMAIL,
                    OWNER_ID = i_Params_Delete_User_By_EMAIL_OWNER_ID.OWNER_ID
                };
                _User = Get_User_By_EMAIL_OWNER_ID(oParams_Get_User_By_EMAIL_OWNER_ID);
                if (_User != null)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_EMAIL_OWNER_ID(i_Params_Delete_User_By_EMAIL_OWNER_ID.EMAIL, i_Params_Delete_User_By_EMAIL_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_User_By_EMAIL_OWNER_ID", i_Params_Delete_User_By_EMAIL_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_USER_TYPE_SETUP_ID
        public void Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID)
        {
            var i_Params_Delete_User_By_USER_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_USER_TYPE_SETUP_ID", i_Params_Delete_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_USER_TYPE_SETUP_ID oParams_Get_User_By_USER_TYPE_SETUP_ID = new Params_Get_User_By_USER_TYPE_SETUP_ID
                {
                    USER_TYPE_SETUP_ID = i_Params_Delete_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID
                };
                _List_User = Get_User_By_USER_TYPE_SETUP_ID(oParams_Get_User_By_USER_TYPE_SETUP_ID);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_USER_TYPE_SETUP_ID(i_Params_Delete_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_User_By_USER_TYPE_SETUP_ID", i_Params_Delete_User_By_USER_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_ORGANIZATION_ID
        public void Delete_User_By_ORGANIZATION_ID(Params_Delete_User_By_ORGANIZATION_ID i_Params_Delete_User_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_User_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_ORGANIZATION_ID", i_Params_Delete_User_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_ORGANIZATION_ID oParams_Get_User_By_ORGANIZATION_ID = new Params_Get_User_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_User_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_User = Get_User_By_ORGANIZATION_ID(oParams_Get_User_By_ORGANIZATION_ID);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_ORGANIZATION_ID(i_Params_Delete_User_By_ORGANIZATION_ID.ORGANIZATION_ID);
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
                OnPostEvent_General("Delete_User_By_ORGANIZATION_ID", i_Params_Delete_User_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_OWNER_ID
        public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
        {
            var i_Params_Delete_User_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_OWNER_ID", i_Params_Delete_User_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_User_By_OWNER_ID.OWNER_ID
                };
                _List_User = Get_User_By_OWNER_ID(oParams_Get_User_By_OWNER_ID);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_User_By_OWNER_ID", i_Params_Delete_User_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_IS_RECEIVE_EMAIL
        public void Delete_User_By_IS_RECEIVE_EMAIL(Params_Delete_User_By_IS_RECEIVE_EMAIL i_Params_Delete_User_By_IS_RECEIVE_EMAIL)
        {
            var i_Params_Delete_User_By_IS_RECEIVE_EMAIL_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_IS_RECEIVE_EMAIL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_IS_RECEIVE_EMAIL", i_Params_Delete_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_IS_RECEIVE_EMAIL oParams_Get_User_By_IS_RECEIVE_EMAIL = new Params_Get_User_By_IS_RECEIVE_EMAIL
                {
                    IS_RECEIVE_EMAIL = i_Params_Delete_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL
                };
                _List_User = Get_User_By_IS_RECEIVE_EMAIL(oParams_Get_User_By_IS_RECEIVE_EMAIL);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_IS_RECEIVE_EMAIL(i_Params_Delete_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL);
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
                OnPostEvent_General("Delete_User_By_IS_RECEIVE_EMAIL", i_Params_Delete_User_By_IS_RECEIVE_EMAIL_json, false);
            }
        }
        #endregion
        #region Delete_User_By_IS_DELETED
        public void Delete_User_By_IS_DELETED(Params_Delete_User_By_IS_DELETED i_Params_Delete_User_By_IS_DELETED)
        {
            var i_Params_Delete_User_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_IS_DELETED", i_Params_Delete_User_By_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_IS_DELETED oParams_Get_User_By_IS_DELETED = new Params_Get_User_By_IS_DELETED
                {
                    IS_DELETED = i_Params_Delete_User_By_IS_DELETED.IS_DELETED
                };
                _List_User = Get_User_By_IS_DELETED(oParams_Get_User_By_IS_DELETED);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_IS_DELETED(i_Params_Delete_User_By_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_User_By_IS_DELETED", i_Params_Delete_User_By_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED)
        {
            var i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED oParams_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED = new Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID,
                    IS_ACTIVE = i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE,
                    IS_DELETED = i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED
                };
                _List_User = Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(oParams_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID, i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE, i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
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
        #region Edit_User
        public void Edit_User(User i_User)
        {
            var i_User_json = JsonConvert.SerializeObject(i_User);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_User.USER_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_User", i_User_json, false);
            }
            #region Body Section.
            if (i_User.USER_ID == null || i_User.USER_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_User");
            }
            if (Check_User_Uniqueness_Violation(i_User))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "User"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_User.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_User.IS_DELETED = false;
            }
            else
            {
                _User = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_User.USER_ID
                });
            }
            i_User.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_User.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_User.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_User
            if (OnPreEvent_Edit_User != null)
            {
                OnPreEvent_Edit_User(i_User, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_User_Execution)
            {
                _Stop_Edit_User_Execution = false;
                return;
            }
            i_User.USER_ID = _AppContext.Edit_User
            (
                i_User.USER_ID,
                i_User.ORGANIZATION_ID,
                i_User.USER_TYPE_SETUP_ID,
                i_User.OWNER_ID,
                i_User.FIRST_NAME,
                i_User.LAST_NAME,
                i_User.USERNAME,
                i_User.PASSWORD,
                i_User.EMAIL,
                i_User.PHONE_NUMBER,
                i_User.IMAGE_URL,
                i_User.IS_ACTIVE,
                i_User.IS_DELETED,
                i_User.IS_RECEIVE_EMAIL,
                i_User.DATA_RETENTION_PERIOD,
                i_User.USER_DISTRICTNEX_WALKTHROUGH,
                i_User.USER_ADMIN_WALKTHROUGH,
                i_User.DATE_DELETED,
                i_User.ENTRY_DATE,
                i_User.ENTRY_USER_ID,
                i_User.LAST_UPDATE
            );
            #region PostEvent_Edit_User
            if (OnPostEvent_Edit_User != null)
            {
                OnPostEvent_Edit_User(ref i_User, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_User", i_User_json, false);
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
        #region Edit_User_List
        public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
        {
            var i_Params_Edit_User_List_json = JsonConvert.SerializeObject(i_Params_Edit_User_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_User_List", i_Params_Edit_User_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_User_List.List_To_Edit != null)
            {
                i_Params_Edit_User_List.List_Failed_Edit = new List<User>();
                if (i_Params_Edit_User_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oUser in i_Params_Edit_User_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_User(oUser);
                        }
                        catch
                        {
                            i_Params_Edit_User_List.List_Failed_Edit.Add(oUser);
                        }
                    }
                }
                i_Params_Edit_User_List.List_To_Edit = i_Params_Edit_User_List.List_To_Edit.Except(i_Params_Edit_User_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_User_List.List_To_Delete != null)
            {
                i_Params_Edit_User_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_User_List.List_To_Delete.Count() > 0)
                {
                    foreach (var User_ID in i_Params_Edit_User_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_User(new Params_Delete_User()
                            {
                                USER_ID = User_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_User_List.List_Failed_Delete.Add(User_ID);
                        }
                    }
                }
                i_Params_Edit_User_List.List_To_Delete = i_Params_Edit_User_List.List_To_Delete.Except(i_Params_Edit_User_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_User_List", i_Params_Edit_User_List_json, false);
            }
        }
        #endregion
    }
}