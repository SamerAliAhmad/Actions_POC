using System;
using SmartrTools;
using System.Data;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace DALC
{
    public partial class MSSQL_DALC : DALC
    {
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_User_By_USER_ID
        public User Get_User_By_USER_ID(long? USER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
            }
            return oUser;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup_category> oList_Setup_category = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup_category = new List<Setup_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup_category oSetup_category = new Setup_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                            oList_Setup_category.Add(oSetup_category);
                        }
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_USER_ID_List
        public List<User> Get_User_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<User> oList_User = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID
        public User Get_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.USERNAME = USERNAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID
        public User Get_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.EMAIL = EMAIL;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_EMAIL_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID
        public List<User> Get_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID
        public List<User> Get_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID
        public List<User> Get_User_By_OWNER_ID(int? OWNER_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL
        public List<User> Get_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_IS_RECEIVE_EMAIL", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED
        public List<User> Get_User_By_IS_DELETED(bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_ACTIVE = IS_ACTIVE;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_IS_ACTIVE_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST)
        {
            List<User> oList_User = null;
            if (USER_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_TYPE_SETUP_ID_LIST = string.Join(",", USER_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List
        public List<User> Get_User_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<User> oList_User = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_Where
        public List<User> Get_User_By_Where(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.FIRST_NAME = FIRST_NAME;
            _params.LAST_NAME = LAST_NAME;
            _params.USERNAME = USERNAME;
            _params.PASSWORD = PASSWORD;
            _params.EMAIL = EMAIL;
            _params.PHONE_NUMBER = PHONE_NUMBER;
            _params.IMAGE_URL = IMAGE_URL;
            _params.USER_DISTRICTNEX_WALKTHROUGH = USER_DISTRICTNEX_WALKTHROUGH;
            _params.USER_ADMIN_WALKTHROUGH = USER_ADMIN_WALKTHROUGH;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.SETUP_CATEGORY_ID_LIST = SETUP_CATEGORY_ID_LIST != null ? string.Join(",", SETUP_CATEGORY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_Where_In_List
        public List<User> Get_User_By_Where_In_List(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.FIRST_NAME = FIRST_NAME;
            _params.LAST_NAME = LAST_NAME;
            _params.USERNAME = USERNAME;
            _params.PASSWORD = PASSWORD;
            _params.EMAIL = EMAIL;
            _params.PHONE_NUMBER = PHONE_NUMBER;
            _params.IMAGE_URL = IMAGE_URL;
            _params.USER_DISTRICTNEX_WALKTHROUGH = USER_DISTRICTNEX_WALKTHROUGH;
            _params.USER_ADMIN_WALKTHROUGH = USER_ADMIN_WALKTHROUGH;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.USER_TYPE_SETUP_ID_LIST = USER_TYPE_SETUP_ID_LIST != null ? string.Join(",", USER_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User;
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY", _params);
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(long? SETUP_ID)
        {
            var _params = new
            {
                SETUP_ID = SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP", _params);
        }
        #endregion
        #region Delete_User
        public void Delete_User(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_USER", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                VALUE = VALUE
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_User_By_USERNAME_OWNER_ID
        public void Delete_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID)
        {
            var _params = new
            {
                USERNAME = USERNAME,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_USERNAME_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_EMAIL_OWNER_ID
        public void Delete_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID)
        {
            var _params = new
            {
                EMAIL = EMAIL,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_EMAIL_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_USER_TYPE_SETUP_ID
        public void Delete_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID)
        {
            var _params = new
            {
                USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_USER_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_User_By_ORGANIZATION_ID
        public void Delete_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_User_By_OWNER_ID
        public void Delete_User_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_IS_RECEIVE_EMAIL
        public void Delete_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL)
        {
            var _params = new
            {
                IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL
            };
            ExecuteDelete("UPG_DELETE_USER_BY_IS_RECEIVE_EMAIL", _params);
        }
        #endregion
        #region Delete_User_By_IS_DELETED
        public void Delete_User_By_IS_DELETED(bool IS_DELETED)
        {
            var _params = new
            {
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_BY_IS_DELETED", _params);
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_ACTIVE = IS_ACTIVE,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID_IS_ACTIVE_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Setup_category
        public int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Setup_category oSetup_category = new Setup_category()
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP_CATEGORY", oSetup_category, "SETUP_CATEGORY_ID");
            return oSetup_category.SETUP_CATEGORY_ID;
        }
        #endregion
        #region Edit_Setup
        public long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID)
        {
            Setup oSetup = new Setup()
            {
                SETUP_ID = SETUP_ID,
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                IS_SYSTEM = IS_SYSTEM,
                IS_DELETEABLE = IS_DELETEABLE,
                IS_UPDATEABLE = IS_UPDATEABLE,
                IS_DELETED = IS_DELETED,
                IS_VISIBLE = IS_VISIBLE,
                DISPLAY_ORDER = DISPLAY_ORDER,
                VALUE = VALUE,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP", oSetup, "SETUP_ID");
            return oSetup.SETUP_ID;
        }
        #endregion
        #region Edit_User
        public long? Edit_User(long? USER_ID, int? ORGANIZATION_ID, long? USER_TYPE_SETUP_ID, int? OWNER_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, bool IS_ACTIVE, bool IS_DELETED, bool IS_RECEIVE_EMAIL, int? DATA_RETENTION_PERIOD, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, string DATE_DELETED, string ENTRY_DATE, long? ENTRY_USER_ID, string LAST_UPDATE)
        {
            User oUser = new User()
            {
                USER_ID = USER_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID,
                OWNER_ID = OWNER_ID,
                FIRST_NAME = FIRST_NAME,
                LAST_NAME = LAST_NAME,
                USERNAME = USERNAME,
                PASSWORD = PASSWORD,
                EMAIL = EMAIL,
                PHONE_NUMBER = PHONE_NUMBER,
                IMAGE_URL = IMAGE_URL,
                IS_ACTIVE = IS_ACTIVE,
                IS_DELETED = IS_DELETED,
                IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL,
                DATA_RETENTION_PERIOD = DATA_RETENTION_PERIOD,
                USER_DISTRICTNEX_WALKTHROUGH = USER_DISTRICTNEX_WALKTHROUGH,
                USER_ADMIN_WALKTHROUGH = USER_ADMIN_WALKTHROUGH,
                DATE_DELETED = DATE_DELETED,
                ENTRY_DATE = ENTRY_DATE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                LAST_UPDATE = LAST_UPDATE
            };
            ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
            return oUser.USER_ID;
        }
        #endregion
    }
}
