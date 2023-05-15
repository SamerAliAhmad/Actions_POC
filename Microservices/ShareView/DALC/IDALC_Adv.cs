using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Setup_By_SETUP_ID_Adv
        Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID);
        #endregion
        #region Get_Share_file_By_SHARE_FILE_ID_Adv
        Share_file Get_Share_file_By_SHARE_FILE_ID_Adv(int? SHARE_FILE_ID);
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST);
        #endregion
        #region Get_Share_file_By_SHARE_FILE_ID_List_Adv
        List<Share_file> Get_Share_file_By_SHARE_FILE_ID_List_Adv(IEnumerable<int?> SHARE_FILE_ID_LIST);
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
        #region Get_Share_file_By_OWNER_ID_Adv
        List<Share_file> Get_Share_file_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Share_file_By_USER_ID_Adv
        List<Share_file> Get_Share_file_By_USER_ID_Adv(long? USER_ID);
        #endregion
        #region Get_Share_file_By_OWNER_ID_IS_DELETED_Adv
        List<Share_file> Get_Share_file_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Share_file_By_USER_ID_List_Adv
        List<Share_file> Get_Share_file_By_USER_ID_List_Adv(IEnumerable<long?> USER_ID_LIST);
        #endregion
        #region Get_Setup_By_Where_Adv
        List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Share_file_By_Where_Adv
        List<Share_file> Get_Share_file_By_Where_Adv(string FILE_NAME, string FILE_EXTENSION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Share_file_By_Where_In_List_Adv
        List<Share_file> Get_Share_file_By_Where_In_List_Adv(string FILE_NAME, string FILE_EXTENSION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
