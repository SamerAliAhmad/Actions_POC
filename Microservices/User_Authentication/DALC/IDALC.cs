using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID
        Setup Get_Setup_By_SETUP_ID(long? SETUP_ID);
        #endregion
        #region Get_User_By_USER_ID
        User Get_User_By_USER_ID(long? USER_ID);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_User_By_USER_ID_List
        List<User> Get_User_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID
        List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED
        List<User> Get_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID
        User Get_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID);
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID
        User Get_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID
        List<User> Get_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID);
        #endregion
        #region Get_User_By_ORGANIZATION_ID
        List<User> Get_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Get_User_By_OWNER_ID
        List<User> Get_User_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL
        List<User> Get_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL);
        #endregion
        #region Get_User_By_IS_DELETED
        List<User> Get_User_By_IS_DELETED(bool IS_DELETED);
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List
        List<User> Get_User_By_USER_TYPE_SETUP_ID_List(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List
        List<User> Get_User_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Setup_category_By_Where
        List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where
        List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where
        List<User> Get_User_By_Where(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List
        List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_In_List
        List<User> Get_User_By_Where_In_List(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Setup_category
        void Delete_Setup_category(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup
        void Delete_Setup(long? SETUP_ID);
        #endregion
        #region Delete_User
        void Delete_User(long? USER_ID);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID);
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Delete_Setup_By_OWNER_ID
        void Delete_Setup_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_User_By_OWNER_ID_IS_DELETED
        void Delete_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_User_By_USERNAME_OWNER_ID
        void Delete_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID);
        #endregion
        #region Delete_User_By_EMAIL_OWNER_ID
        void Delete_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID);
        #endregion
        #region Delete_User_By_USER_TYPE_SETUP_ID
        void Delete_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID);
        #endregion
        #region Delete_User_By_ORGANIZATION_ID
        void Delete_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID);
        #endregion
        #region Delete_User_By_OWNER_ID
        void Delete_User_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_User_By_IS_RECEIVE_EMAIL
        void Delete_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL);
        #endregion
        #region Delete_User_By_IS_DELETED
        void Delete_User_By_IS_DELETED(bool IS_DELETED);
        #endregion
        #region Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        void Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED);
        #endregion
        #region Edit_Setup_category
        int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Setup
        long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID);
        #endregion
        #region Edit_User
        long? Edit_User(long? USER_ID, int? ORGANIZATION_ID, long? USER_TYPE_SETUP_ID, int? OWNER_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, bool IS_ACTIVE, bool IS_DELETED, bool IS_RECEIVE_EMAIL, int? DATA_RETENTION_PERIOD, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, string DATE_DELETED, string ENTRY_DATE, long? ENTRY_USER_ID, string LAST_UPDATE);
        #endregion
    }
}
