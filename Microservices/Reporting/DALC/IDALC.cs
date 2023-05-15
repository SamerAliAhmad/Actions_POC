using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Report_By_REPORT_ID
        Report Get_Report_By_REPORT_ID(int? REPORT_ID);
        #endregion
        #region Get_Report_By_REPORT_ID_List
        List<Report> Get_Report_By_REPORT_ID_List(IEnumerable<int?> REPORT_ID_LIST);
        #endregion
        #region Get_Report_By_OWNER_ID
        List<Report> Get_Report_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Report_By_DIMENSION_ID
        List<Report> Get_Report_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Get_Report_By_OWNER_ID_IS_DELETED
        List<Report> Get_Report_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Report_By_IDENTIFIER_TOKEN
        List<Report> Get_Report_By_IDENTIFIER_TOKEN(string IDENTIFIER_TOKEN);
        #endregion
        #region Get_Report_By_DIMENSION_ID_List
        List<Report> Get_Report_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Report_By_Where
        List<Report> Get_Report_By_Where(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Report_By_Where_In_List
        List<Report> Get_Report_By_Where_In_List(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, IEnumerable<int?> DIMENSION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Report
        void Delete_Report(int? REPORT_ID);
        #endregion
        #region Delete_Report_By_OWNER_ID
        void Delete_Report_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Report_By_DIMENSION_ID
        void Delete_Report_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Delete_Report_By_OWNER_ID_IS_DELETED
        void Delete_Report_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Report_By_IDENTIFIER_TOKEN
        void Delete_Report_By_IDENTIFIER_TOKEN(string IDENTIFIER_TOKEN);
        #endregion
        #region Edit_Report
        int? Edit_Report(int? REPORT_ID, int? DIMENSION_ID, string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
