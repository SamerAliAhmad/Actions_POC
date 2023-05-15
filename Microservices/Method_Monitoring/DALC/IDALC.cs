using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Method_run_By_METHOD_RUN_ID
        Method_run Get_Method_run_By_METHOD_RUN_ID(long? METHOD_RUN_ID);
        #endregion
        #region Get_Method_run_By_METHOD_RUN_ID_List
        List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List(IEnumerable<long?> METHOD_RUN_ID_LIST);
        #endregion
        #region Get_Method_run_By_OWNER_ID
        List<Method_run> Get_Method_run_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Method_run_By_OWNER_ID_IS_DELETED
        List<Method_run> Get_Method_run_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Method_run_By_Where
        List<Method_run> Get_Method_run_By_Where(string METHOD_NAME, string METHOD_PARAMS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Method_run
        void Delete_Method_run(long? METHOD_RUN_ID);
        #endregion
        #region Delete_Method_run_By_OWNER_ID
        void Delete_Method_run_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Method_run_By_OWNER_ID_IS_DELETED
        void Delete_Method_run_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Edit_Method_run
        long? Edit_Method_run(long? METHOD_RUN_ID, string METHOD_NAME, string RUN_DATE, int? RUN_HOUR, int? RUN_MINUTE, int? RUN_SECOND, int? EXECUTION_TIME, bool IS_CACHED, string METHOD_PARAMS, long? ENTRY_USER_ID, string ENTRY_DATE, int? OWNER_ID, string LAST_UPDATE, bool IS_DELETED);
        #endregion
    }
}
