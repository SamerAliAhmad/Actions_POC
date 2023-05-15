using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Kpi_By_KPI_ID_Adv
        Kpi Get_Kpi_By_KPI_ID_Adv(int? KPI_ID);
        #endregion
        #region Get_Report_By_REPORT_ID_Adv
        Report Get_Report_By_REPORT_ID_Adv(int? REPORT_ID);
        #endregion
        #region Get_Kpi_By_KPI_ID_List_Adv
        List<Kpi> Get_Kpi_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Report_By_REPORT_ID_List_Adv
        List<Report> Get_Report_By_REPORT_ID_List_Adv(IEnumerable<int?> REPORT_ID_LIST);
        #endregion
        #region Get_Kpi_By_OWNER_ID_Adv
        List<Kpi> Get_Kpi_By_OWNER_ID_Adv(int? OWNER_ID);
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_Adv
        List<Kpi> Get_Kpi_By_DIMENSION_ID_Adv(int? DIMENSION_ID);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_Adv
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv(long? MIN_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv(long? MAX_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED_Adv
        List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv(long? KPI_TYPE_SETUP_ID);
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
        #region Get_Kpi_By_DIMENSION_ID_List_Adv
        List<Kpi> Get_Kpi_By_DIMENSION_ID_List_Adv(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Report_By_DIMENSION_ID_List_Adv
        List<Report> Get_Report_By_DIMENSION_ID_List_Adv(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Kpi_By_Where_Adv
        List<Kpi> Get_Kpi_By_Where_Adv(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Report_By_Where_Adv
        List<Report> Get_Report_By_Where_Adv(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Kpi_By_Where_In_List_Adv
        List<Kpi> Get_Kpi_By_Where_In_List_Adv(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Report_By_Where_In_List_Adv
        List<Report> Get_Report_By_Where_In_List_Adv(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, IEnumerable<int?> DIMENSION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
    }
}
