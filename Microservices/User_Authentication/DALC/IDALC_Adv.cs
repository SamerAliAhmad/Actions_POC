using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_User_By_USER_ID_Adv
        User Get_User_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_User_By_USER_ID_List_Adv
        List<User> Get_User_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE);
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED_Adv
        List<User> Get_User_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID_Adv
        User Get_User_By_USERNAME_OWNER_ID_Adv(string USERNAME, int? OWNER_ID);
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID_Adv
        User Get_User_By_EMAIL_OWNER_ID_Adv(string EMAIL, int? OWNER_ID);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_Adv
        List<User> Get_User_By_USER_TYPE_SETUP_ID_Adv(long? USER_TYPE_SETUP_ID);
        #endregion
        #region Get_User_By_ORGANIZATION_ID_Adv
        List<User> Get_User_By_ORGANIZATION_ID_Adv(int? ORGANIZATION_ID);
        #endregion
        #region Get_User_By_OWNER_ID_Adv
        List<User> Get_User_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL_Adv
        List<User> Get_User_By_IS_RECEIVE_EMAIL_Adv(bool IS_RECEIVE_EMAIL);
        #endregion
        #region Get_User_By_IS_DELETED_Adv
        List<User> Get_User_By_IS_DELETED_Adv(bool IS_DELETED);
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv
        List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List_Adv
        List<User> Get_User_By_USER_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List_Adv
        List<User> Get_User_By_ORGANIZATION_ID_List_Adv(IEnumerable<int?> ORGANIZATION_ID_LIST);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_Adv
        List<User> Get_User_By_Where_Adv(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_User_By_Where_In_List_Adv
        List<User> Get_User_By_Where_In_List_Adv(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
