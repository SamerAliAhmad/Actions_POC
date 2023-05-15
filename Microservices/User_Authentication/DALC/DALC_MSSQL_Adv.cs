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
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_User_By_USER_ID_Adv
        public User Get_User_By_USER_ID_Adv(long? USER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
                oUser.Organization = new Organization();
                oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
                oUser.User_type_setup = new Setup();
                oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_TYPE_SETUP_SETUP_ID");
                oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_SYSTEM");
                oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_DELETED");
                oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_VISIBLE");
                oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_VALUE");
                oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_DESCRIPTION");
                oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_ENTRY_DATE");
                oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_LAST_UPDATE");
                oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_OWNER_ID");
            }
            return oUser;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_USER_ID_List_Adv
        public List<User> Get_User_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST)
        {
            List<User> oList_User = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oUser.Organization = new Organization();
                            oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oUser.User_type_setup = new Setup();
                            oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                            oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                            oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                            oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                            oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                            oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                            oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                            oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                            oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                            oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                            oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                            oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                            oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED_Adv
        public List<User> Get_User_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID_Adv
        public User Get_User_By_USERNAME_OWNER_ID_Adv(string USERNAME, int? OWNER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.USERNAME = USERNAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_OWNER_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
                oUser.Organization = new Organization();
                oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
                oUser.User_type_setup = new Setup();
                oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_TYPE_SETUP_SETUP_ID");
                oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_SYSTEM");
                oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_DELETED");
                oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_VISIBLE");
                oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_VALUE");
                oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_DESCRIPTION");
                oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_ENTRY_DATE");
                oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_LAST_UPDATE");
                oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_OWNER_ID");
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID_Adv
        public User Get_User_By_EMAIL_OWNER_ID_Adv(string EMAIL, int? OWNER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.EMAIL = EMAIL;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_EMAIL_OWNER_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
                oUser.Organization = new Organization();
                oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_ORGANIZATION_ID");
                oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_NAME");
                oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_DATE_DELETED");
                oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ORGANIZATION_ENTRY_USER_ID");
                oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_ENTRY_DATE");
                oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ORGANIZATION_LAST_UPDATE");
                oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_ACTIVE");
                oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ORGANIZATION_IS_DELETED");
                oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ORGANIZATION_OWNER_ID");
                oUser.User_type_setup = new Setup();
                oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_TYPE_SETUP_SETUP_ID");
                oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_SYSTEM");
                oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_DELETED");
                oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_USER_TYPE_SETUP_IS_VISIBLE");
                oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_VALUE");
                oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_DESCRIPTION");
                oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_ENTRY_DATE");
                oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_USER_TYPE_SETUP_LAST_UPDATE");
                oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_TYPE_SETUP_OWNER_ID");
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_Adv
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_Adv(long? USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_Adv
        public List<User> Get_User_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_ORGANIZATION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_Adv
        public List<User> Get_User_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL_Adv
        public List<User> Get_User_By_IS_RECEIVE_EMAIL_Adv(bool IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_IS_RECEIVE_EMAIL_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED_Adv
        public List<User> Get_User_By_IS_DELETED_Adv(bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_ACTIVE = IS_ACTIVE;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_IS_ACTIVE_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List_Adv
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST)
        {
            List<User> oList_User = null;
            if (USER_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_TYPE_SETUP_ID_LIST = string.Join(",", USER_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oUser.Organization = new Organization();
                            oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oUser.User_type_setup = new Setup();
                            oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                            oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                            oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                            oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                            oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                            oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                            oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                            oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                            oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                            oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                            oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                            oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                            oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List_Adv
        public List<User> Get_User_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<User> oList_User = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_ORGANIZATION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oUser.Organization = new Organization();
                            oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                            oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                            oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                            oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                            oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                            oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                            oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                            oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                            oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                            oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                            oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                            oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                            oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                            oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                            oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                            oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                            oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                            oUser.User_type_setup = new Setup();
                            oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                            oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                            oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                            oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                            oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                            oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                            oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                            oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                            oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                            oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                            oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                            oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                            oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_Where_Adv
        public List<User> Get_User_By_Where_Adv(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_User_By_Where_In_List_Adv
        public List<User> Get_User_By_Where_In_List_Adv(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oUser.Organization = new Organization();
                        oUser.Organization.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_ORGANIZATION_ID");
                        oUser.Organization.ORGANIZATION_NAME = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_NAME");
                        oUser.Organization.ORGANIZATION_EMAIL = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_EMAIL");
                        oUser.Organization.ORGANIZATION_PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_PHONE_NUMBER");
                        oUser.Organization.ORGANIZATION_ADDRESS = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ORGANIZATION_ADDRESS");
                        oUser.Organization.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_DATA_RETENTION_PERIOD");
                        oUser.Organization.TICKET_DURATION_IN_MINUTES = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_TICKET_DURATION_IN_MINUTES");
                        oUser.Organization.ORGANIZATION_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ORGANIZATION_TYPE_SETUP_ID");
                        oUser.Organization.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_DATE_DELETED");
                        oUser.Organization.MAX_NUMBER_OF_ADMINS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_ADMINS");
                        oUser.Organization.MAX_NUMBER_OF_USERS = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_MAX_NUMBER_OF_USERS");
                        oUser.Organization.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ORGANIZATION_ENTRY_USER_ID");
                        oUser.Organization.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_ENTRY_DATE");
                        oUser.Organization.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ORGANIZATION_LAST_UPDATE");
                        oUser.Organization.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_ACTIVE");
                        oUser.Organization.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ORGANIZATION_IS_DELETED");
                        oUser.Organization.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ORGANIZATION_OWNER_ID");
                        oUser.User_type_setup = new Setup();
                        oUser.User_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_SETUP_ID");
                        oUser.User_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oUser.User_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_SYSTEM");
                        oUser.User_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETEABLE");
                        oUser.User_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_UPDATEABLE");
                        oUser.User_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_DELETED");
                        oUser.User_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_USER_TYPE_SETUP_IS_VISIBLE");
                        oUser.User_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_DISPLAY_ORDER");
                        oUser.User_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_VALUE");
                        oUser.User_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_DESCRIPTION");
                        oUser.User_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_TYPE_SETUP_ENTRY_USER_ID");
                        oUser.User_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_ENTRY_DATE");
                        oUser.User_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_TYPE_SETUP_LAST_UPDATE");
                        oUser.User_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_TYPE_SETUP_OWNER_ID");
                        oList_User.Add(oUser);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User;
        }
        #endregion
    }
}
