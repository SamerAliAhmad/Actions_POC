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
        #region Get_Share_file_By_SHARE_FILE_ID_Adv
        public Share_file Get_Share_file_By_SHARE_FILE_ID_Adv(int? SHARE_FILE_ID)
        {
            Share_file oShare_file = null;
            dynamic _params = new ExpandoObject();
            _params.SHARE_FILE_ID = SHARE_FILE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_SHARE_FILE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oShare_file = new Share_file();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oShare_file);
                oShare_file.User = new User();
                oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_USER_ID");
                oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_ORGANIZATION_ID");
                oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_USER_TYPE_SETUP_ID");
                oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_USER_OWNER_ID");
                oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(_query_response, "T_USER_FIRST_NAME");
                oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(_query_response, "T_USER_LAST_NAME");
                oShare_file.User.USERNAME = Get_Data_Record_Value<string>(_query_response, "T_USER_USERNAME");
                oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(_query_response, "T_USER_PASSWORD");
                oShare_file.User.EMAIL = Get_Data_Record_Value<string>(_query_response, "T_USER_EMAIL");
                oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(_query_response, "T_USER_PHONE_NUMBER");
                oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_USER_IMAGE_URL");
                oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_ACTIVE");
                oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_DELETED");
                oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(_query_response, "T_USER_IS_RECEIVE_EMAIL");
                oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(_query_response, "T_USER_DATA_RETENTION_PERIOD");
                oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(_query_response, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(_query_response, "T_USER_USER_ADMIN_WALKTHROUGH");
                oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(_query_response, "T_USER_DATE_DELETED");
                oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_USER_ENTRY_DATE");
                oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_USER_ENTRY_USER_ID");
                oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_USER_LAST_UPDATE");
            }
            return oShare_file;
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
        #region Get_Share_file_By_SHARE_FILE_ID_List_Adv
        public List<Share_file> Get_Share_file_By_SHARE_FILE_ID_List_Adv(IEnumerable<int?> SHARE_FILE_ID_LIST)
        {
            List<Share_file> oList_Share_file = null;
            if (SHARE_FILE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SHARE_FILE_ID_LIST = string.Join(",", SHARE_FILE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_SHARE_FILE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Share_file = new List<Share_file>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Share_file oShare_file = new Share_file();
                            Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                            oShare_file.User = new User();
                            oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Share_file.Add(oShare_file);
                        }
                    }
                }
            }
            return oList_Share_file;
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
        #region Get_Share_file_By_OWNER_ID_Adv
        public List<Share_file> Get_Share_file_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Share_file> oList_Share_file = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Share_file = new List<Share_file>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Share_file oShare_file = new Share_file();
                        Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                        oShare_file.User = new User();
                        oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Share_file.Add(oShare_file);
                    }
                }
            }
            return oList_Share_file;
        }
        #endregion
        #region Get_Share_file_By_USER_ID_Adv
        public List<Share_file> Get_Share_file_By_USER_ID_Adv(long? USER_ID)
        {
            List<Share_file> oList_Share_file = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_USER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Share_file = new List<Share_file>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Share_file oShare_file = new Share_file();
                        Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                        oShare_file.User = new User();
                        oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Share_file.Add(oShare_file);
                    }
                }
            }
            return oList_Share_file;
        }
        #endregion
        #region Get_Share_file_By_OWNER_ID_IS_DELETED_Adv
        public List<Share_file> Get_Share_file_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Share_file> oList_Share_file = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Share_file = new List<Share_file>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Share_file oShare_file = new Share_file();
                        Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                        oShare_file.User = new User();
                        oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Share_file.Add(oShare_file);
                    }
                }
            }
            return oList_Share_file;
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
        #region Get_Share_file_By_USER_ID_List_Adv
        public List<Share_file> Get_Share_file_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST)
        {
            List<Share_file> oList_Share_file = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_USER_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Share_file = new List<Share_file>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Share_file oShare_file = new Share_file();
                            Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                            oShare_file.User = new User();
                            oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                            oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                            oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                            oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                            oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                            oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                            oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                            oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                            oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                            oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                            oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                            oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                            oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                            oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                            oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                            oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                            oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                            oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                            oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                            oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                            oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                            oList_Share_file.Add(oShare_file);
                        }
                    }
                }
            }
            return oList_Share_file;
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
        #region Get_Share_file_By_Where_Adv
        public List<Share_file> Get_Share_file_By_Where_Adv(string FILE_NAME, string FILE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Share_file> oList_Share_file = null;
            dynamic _params = new ExpandoObject();
            _params.FILE_NAME = FILE_NAME;
            _params.FILE_EXTENSION = FILE_EXTENSION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Share_file = new List<Share_file>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Share_file oShare_file = new Share_file();
                        Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                        oShare_file.User = new User();
                        oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Share_file.Add(oShare_file);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Share_file;
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
        #region Get_Share_file_By_Where_In_List_Adv
        public List<Share_file> Get_Share_file_By_Where_In_List_Adv(string FILE_NAME, string FILE_EXTENSION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Share_file> oList_Share_file = null;
            dynamic _params = new ExpandoObject();
            _params.FILE_NAME = FILE_NAME;
            _params.FILE_EXTENSION = FILE_EXTENSION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SHARE_FILE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Share_file = new List<Share_file>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Share_file oShare_file = new Share_file();
                        Props.Copy_Prop_Values_From_Data_Record(element, oShare_file);
                        oShare_file.User = new User();
                        oShare_file.User.USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_ID");
                        oShare_file.User.ORGANIZATION_ID = Get_Data_Record_Value<int?>(element, "T_USER_ORGANIZATION_ID");
                        oShare_file.User.USER_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_USER_USER_TYPE_SETUP_ID");
                        oShare_file.User.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_USER_OWNER_ID");
                        oShare_file.User.FIRST_NAME = Get_Data_Record_Value<string>(element, "T_USER_FIRST_NAME");
                        oShare_file.User.LAST_NAME = Get_Data_Record_Value<string>(element, "T_USER_LAST_NAME");
                        oShare_file.User.USERNAME = Get_Data_Record_Value<string>(element, "T_USER_USERNAME");
                        oShare_file.User.PASSWORD = Get_Data_Record_Value<string>(element, "T_USER_PASSWORD");
                        oShare_file.User.EMAIL = Get_Data_Record_Value<string>(element, "T_USER_EMAIL");
                        oShare_file.User.PHONE_NUMBER = Get_Data_Record_Value<string>(element, "T_USER_PHONE_NUMBER");
                        oShare_file.User.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_USER_IMAGE_URL");
                        oShare_file.User.IS_ACTIVE = Get_Data_Record_Value<bool>(element, "T_USER_IS_ACTIVE");
                        oShare_file.User.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_USER_IS_DELETED");
                        oShare_file.User.IS_RECEIVE_EMAIL = Get_Data_Record_Value<bool>(element, "T_USER_IS_RECEIVE_EMAIL");
                        oShare_file.User.DATA_RETENTION_PERIOD = Get_Data_Record_Value<int?>(element, "T_USER_DATA_RETENTION_PERIOD");
                        oShare_file.User.USER_DISTRICTNEX_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_DISTRICTNEX_WALKTHROUGH");
                        oShare_file.User.USER_ADMIN_WALKTHROUGH = Get_Data_Record_Value<string>(element, "T_USER_USER_ADMIN_WALKTHROUGH");
                        oShare_file.User.DATE_DELETED = Get_Data_Record_Value<string>(element, "T_USER_DATE_DELETED");
                        oShare_file.User.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_USER_ENTRY_DATE");
                        oShare_file.User.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_USER_ENTRY_USER_ID");
                        oShare_file.User.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_USER_LAST_UPDATE");
                        oList_Share_file.Add(oShare_file);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Share_file;
        }
        #endregion
    }
}
