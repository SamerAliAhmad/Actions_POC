using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Correlation_method_By_CORRELATION_METHOD_ID
        Correlation_method Get_Correlation_method_By_CORRELATION_METHOD_ID(int? CORRELATION_METHOD_ID);
        #endregion
        #region Get_Correlation_method_By_CORRELATION_METHOD_ID_List
        List<Correlation_method> Get_Correlation_method_By_CORRELATION_METHOD_ID_List(IEnumerable<int?> CORRELATION_METHOD_ID_LIST);
        #endregion
        #region Get_Correlation_method_By_OWNER_ID
        List<Correlation_method> Get_Correlation_method_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Correlation_method_By_OWNER_ID_IS_DELETED
        List<Correlation_method> Get_Correlation_method_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Correlation_method_By_Where
        List<Correlation_method> Get_Correlation_method_By_Where(string NAME, string DESCRIPTION, string EQUATION_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Correlation_method
        void Delete_Correlation_method(int? CORRELATION_METHOD_ID);
        #endregion
        #region Delete_Correlation_method_By_OWNER_ID
        void Delete_Correlation_method_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Correlation_method_By_OWNER_ID_IS_DELETED
        void Delete_Correlation_method_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Correlation_method
        int? Edit_Correlation_method(int? CORRELATION_METHOD_ID, string NAME, string DESCRIPTION, string EQUATION_URL, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
