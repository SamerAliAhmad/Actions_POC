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
        #region Get_User_By_USER_ID_Adv
        public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID_Adv", i_Params_Get_User_By_USER_ID_json, false);
            }
            #region PreEvent_Get_User_By_USER_ID_Adv
            if (OnPreEvent_Get_User_By_USER_ID_Adv != null)
            {
                OnPreEvent_Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID);
            }
            #endregion
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User").Replace("%2", i_Params_Get_User_By_USER_ID.USER_ID.ToString()));
            }
            oUser = new User();
            Props.Copy_Prop_Values(oDBEntry, oUser);
            oUser.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
            oUser.User_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
            #endregion
            #region PostEvent_Get_User_By_USER_ID_Adv
            if (OnPostEvent_Get_User_By_USER_ID_Adv != null)
            {
                OnPostEvent_Get_User_By_USER_ID_Adv(oUser, i_Params_Get_User_By_USER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID_Adv", i_Params_Get_User_By_USER_ID_json, false);
            }
            return oUser;
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
        #region Get_User_By_USER_ID_List_Adv
        public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID_List_Adv", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID_List_Adv", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            return oList_User;
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
        #region Get_User_By_OWNER_ID_IS_DELETED_Adv
        public List<User> Get_User_By_OWNER_ID_IS_DELETED_Adv(Params_Get_User_By_OWNER_ID_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_User_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID_Adv
        public User Get_User_By_USERNAME_OWNER_ID_Adv(Params_Get_User_By_USERNAME_OWNER_ID i_Params_Get_User_By_USERNAME_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USERNAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USERNAME_OWNER_ID_Adv", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USERNAME_OWNER_ID_Adv(i_Params_Get_User_By_USERNAME_OWNER_ID.USERNAME, i_Params_Get_User_By_USERNAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
                oUser.Organization = new Organization();
                Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                oUser.User_type_setup = new Setup();
                Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USERNAME_OWNER_ID_Adv", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID_Adv
        public User Get_User_By_EMAIL_OWNER_ID_Adv(Params_Get_User_By_EMAIL_OWNER_ID i_Params_Get_User_By_EMAIL_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_EMAIL_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_EMAIL_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_EMAIL_OWNER_ID_Adv", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_EMAIL_OWNER_ID_Adv(i_Params_Get_User_By_EMAIL_OWNER_ID.EMAIL, i_Params_Get_User_By_EMAIL_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
                oUser.Organization = new Organization();
                Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                oUser.User_type_setup = new Setup();
                Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_EMAIL_OWNER_ID_Adv", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_Adv
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_Adv(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID_Adv(i_Params_Get_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_Adv
        public List<User> Get_User_By_ORGANIZATION_ID_Adv(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID_Adv", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID_Adv(i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID_Adv", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_Adv
        public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_Adv", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_Adv", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL_Adv
        public List<User> Get_User_By_IS_RECEIVE_EMAIL_Adv(Params_Get_User_By_IS_RECEIVE_EMAIL i_Params_Get_User_By_IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_RECEIVE_EMAIL_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_RECEIVE_EMAIL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_RECEIVE_EMAIL_Adv", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_RECEIVE_EMAIL_Adv(i_Params_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_RECEIVE_EMAIL_Adv", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED_Adv
        public List<User> Get_User_By_IS_DELETED_Adv(Params_Get_User_By_IS_DELETED i_Params_Get_User_By_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_DELETED_Adv", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_DELETED_Adv(i_Params_Get_User_By_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_DELETED_Adv", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            return oList_User;
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
        #region Get_User_By_USER_TYPE_SETUP_ID_List_Adv
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List_Adv(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID_List_Adv(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List.USER_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List_Adv
        public List<User> Get_User_By_ORGANIZATION_ID_List_Adv(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID_List_Adv", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_User_By_ORGANIZATION_ID_List_Adv
            if (OnPreEvent_Get_User_By_ORGANIZATION_ID_List_Adv != null)
            {
                OnPreEvent_Get_User_By_ORGANIZATION_ID_List_Adv(i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID_List_Adv(i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_User_By_ORGANIZATION_ID_List_Adv
            if (OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv != null)
            {
                OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv(oList_User, i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID_List_Adv", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_User;
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
        #region Get_User_By_Where_Adv
        public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where_Adv", i_Params_Get_User_By_Where_json, false);
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
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.FIRST_NAME, i_Params_Get_User_By_Where.LAST_NAME, i_Params_Get_User_By_Where.USERNAME, i_Params_Get_User_By_Where.PASSWORD, i_Params_Get_User_By_Where.EMAIL, i_Params_Get_User_By_Where.PHONE_NUMBER, i_Params_Get_User_By_Where.IMAGE_URL, i_Params_Get_User_By_Where.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where.OWNER_ID, i_Params_Get_User_By_Where.OFFSET, i_Params_Get_User_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where_Adv", i_Params_Get_User_By_Where_json, false);
            }
            return oList_User;
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
        #region Get_User_By_Where_In_List_Adv
        public List<User> Get_User_By_Where_In_List_Adv(Params_Get_User_By_Where_In_List i_Params_Get_User_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where_In_List_Adv", i_Params_Get_User_By_Where_In_List_json, false);
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
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where_In_List_Adv(i_Params_Get_User_By_Where_In_List.FIRST_NAME, i_Params_Get_User_By_Where_In_List.LAST_NAME, i_Params_Get_User_By_Where_In_List.USERNAME, i_Params_Get_User_By_Where_In_List.PASSWORD, i_Params_Get_User_By_Where_In_List.EMAIL, i_Params_Get_User_By_Where_In_List.PHONE_NUMBER, i_Params_Get_User_By_Where_In_List.IMAGE_URL, i_Params_Get_User_By_Where_In_List.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST, i_Params_Get_User_By_Where_In_List.OWNER_ID, i_Params_Get_User_By_Where_In_List.OFFSET, i_Params_Get_User_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where_In_List_Adv", i_Params_Get_User_By_Where_In_List_json, false);
            }
            return oList_User;
        }
        #endregion
    }
}
