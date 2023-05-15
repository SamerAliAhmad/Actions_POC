using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Report_By_REPORT_ID_Adv
        Report Get_Report_By_REPORT_ID_Adv(int? REPORT_ID);
        #endregion
        #region Get_Report_By_REPORT_ID_List_Adv
        List<Report> Get_Report_By_REPORT_ID_List_Adv(IEnumerable<int?> REPORT_ID_LIST);
        #endregion
        #region Get_Report_By_OWNER_ID_Adv
        List<Report> Get_Report_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Report_By_DIMENSION_ID_Adv
        List<Report> Get_Report_By_DIMENSION_ID_Adv(int? DIMENSION_ID);
        #endregion
        #region Get_Report_By_OWNER_ID_IS_DELETED_Adv
        List<Report> Get_Report_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Report_By_IDENTIFIER_TOKEN_Adv
        List<Report> Get_Report_By_IDENTIFIER_TOKEN_Adv(string IDENTIFIER_TOKEN);
        #endregion
        #region Get_Report_By_DIMENSION_ID_List_Adv
        List<Report> Get_Report_By_DIMENSION_ID_List_Adv(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Report_By_Where_Adv
        List<Report> Get_Report_By_Where_Adv(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Report_By_Where_In_List_Adv
        List<Report> Get_Report_By_Where_In_List_Adv(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, IEnumerable<int?> DIMENSION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
