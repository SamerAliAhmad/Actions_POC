using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Setup_category_By_SETUP_CATEGORY_ID
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_ID
    public partial class Params_Get_Setup_By_SETUP_ID
    {
        #region Properties
        public long? SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_USER_ID
    public partial class Params_Get_User_By_USER_ID
    {
        #region Properties
        public long? USER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List
    {
        #region Properties
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_ID_List
    public partial class Params_Get_Setup_By_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_USER_ID_List
    public partial class Params_Get_User_By_USER_ID_List
    {
        #region Properties
        public IEnumerable<long?> USER_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_OWNER_ID
    public partial class Params_Get_Setup_category_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    public partial class Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    {
        #region Properties
        public string SETUP_CATEGORY_NAME { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Setup_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        public string VALUE { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_OWNER_ID
    public partial class Params_Get_Setup_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_User_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_USERNAME_OWNER_ID
    public partial class Params_Get_User_By_USERNAME_OWNER_ID
    {
        #region Properties
        public string USERNAME { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_EMAIL_OWNER_ID
    public partial class Params_Get_User_By_EMAIL_OWNER_ID
    {
        #region Properties
        public string EMAIL { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_USER_TYPE_SETUP_ID
    public partial class Params_Get_User_By_USER_TYPE_SETUP_ID
    {
        #region Properties
        public long? USER_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_ORGANIZATION_ID
    public partial class Params_Get_User_By_ORGANIZATION_ID
    {
        #region Properties
        public int? ORGANIZATION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_OWNER_ID
    public partial class Params_Get_User_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_IS_RECEIVE_EMAIL
    public partial class Params_Get_User_By_IS_RECEIVE_EMAIL
    {
        #region Properties
        public bool IS_RECEIVE_EMAIL { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_IS_DELETED
    public partial class Params_Get_User_By_IS_DELETED
    {
        #region Properties
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
    public partial class Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_SETUP_CATEGORY_ID_List
    public partial class Params_Get_Setup_By_SETUP_CATEGORY_ID_List
    {
        #region Properties
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_USER_TYPE_SETUP_ID_List
    public partial class Params_Get_User_By_USER_TYPE_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> USER_TYPE_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_ORGANIZATION_ID_List
    public partial class Params_Get_User_By_ORGANIZATION_ID_List
    {
        #region Properties
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_category_By_Where
    public partial class Params_Get_Setup_category_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string SETUP_CATEGORY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_Where
    public partial class Params_Get_Setup_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_Where
    public partial class Params_Get_User_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string IMAGE_URL { get; set; }
        public string USER_DISTRICTNEX_WALKTHROUGH { get; set; }
        public string USER_ADMIN_WALKTHROUGH { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Setup_By_Where_In_List
    public partial class Params_Get_Setup_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_User_By_Where_In_List
    public partial class Params_Get_User_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string EMAIL { get; set; }
        public string PHONE_NUMBER { get; set; }
        public string IMAGE_URL { get; set; }
        public string USER_DISTRICTNEX_WALKTHROUGH { get; set; }
        public string USER_ADMIN_WALKTHROUGH { get; set; }
        public IEnumerable<int?> ORGANIZATION_ID_LIST { get; set; }
        public IEnumerable<long?> USER_TYPE_SETUP_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category
    public partial class Params_Delete_Setup_category
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup
    public partial class Params_Delete_Setup
    {
        #region Properties
        public long? SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User
    public partial class Params_Delete_User
    {
        #region Properties
        public long? USER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category_By_OWNER_ID
    public partial class Params_Delete_Setup_category_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    public partial class Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    {
        #region Properties
        public string SETUP_CATEGORY_NAME { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Setup_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_SETUP_CATEGORY_ID
    public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
    public partial class Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        public string VALUE { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Setup_By_OWNER_ID
    public partial class Params_Delete_Setup_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_User_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_USERNAME_OWNER_ID
    public partial class Params_Delete_User_By_USERNAME_OWNER_ID
    {
        #region Properties
        public string USERNAME { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_EMAIL_OWNER_ID
    public partial class Params_Delete_User_By_EMAIL_OWNER_ID
    {
        #region Properties
        public string EMAIL { get; set; }
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_USER_TYPE_SETUP_ID
    public partial class Params_Delete_User_By_USER_TYPE_SETUP_ID
    {
        #region Properties
        public long? USER_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_ORGANIZATION_ID
    public partial class Params_Delete_User_By_ORGANIZATION_ID
    {
        #region Properties
        public int? ORGANIZATION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_OWNER_ID
    public partial class Params_Delete_User_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_IS_RECEIVE_EMAIL
    public partial class Params_Delete_User_By_IS_RECEIVE_EMAIL
    {
        #region Properties
        public bool IS_RECEIVE_EMAIL { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_IS_DELETED
    public partial class Params_Delete_User_By_IS_DELETED
    {
        #region Properties
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
    public partial class Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_ACTIVE { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Setup_category_List
    public partial class Params_Edit_Setup_category_List
    {
        #region Properties
        public List<Setup_category> List_To_Edit { get; set; }
        public List<Setup_category> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Setup_List
    public partial class Params_Edit_Setup_List
    {
        #region Properties
        public List<Setup> List_To_Edit { get; set; }
        public List<Setup> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_User_List
    public partial class Params_Edit_User_List
    {
        #region Properties
        public List<User> List_To_Edit { get; set; }
        public List<User> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}