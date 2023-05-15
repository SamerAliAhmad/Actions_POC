using System;
using System.Collections.Generic;

namespace DALC
{
    public partial interface IDALC
    {
        #region Get_Kpi_By_KPI_ID
        Kpi Get_Kpi_By_KPI_ID(int? KPI_ID);
        #endregion
        #region Get_Dimension_By_DIMENSION_ID
        Dimension Get_Dimension_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Get_Report_By_REPORT_ID
        Report Get_Report_By_REPORT_ID(int? REPORT_ID);
        #endregion
        #region Get_Kpi_By_KPI_ID_List
        List<Kpi> Get_Kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST);
        #endregion
        #region Get_Dimension_By_DIMENSION_ID_List
        List<Dimension> Get_Dimension_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Report_By_REPORT_ID_List
        List<Report> Get_Report_By_REPORT_ID_List(IEnumerable<int?> REPORT_ID_LIST);
        #endregion
        #region Get_Kpi_By_OWNER_ID
        List<Kpi> Get_Kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Kpi_By_DIMENSION_ID
        List<Kpi> Get_Kpi_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED
        List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID);
        #endregion
        #region Get_Dimension_By_OWNER_ID
        List<Dimension> Get_Dimension_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Get_Dimension_By_OWNER_ID_IS_DELETED
        List<Dimension> Get_Dimension_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Get_Dimension_By_DIMENSION_ORDER
        List<Dimension> Get_Dimension_By_DIMENSION_ORDER(int? DIMENSION_ORDER);
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
        #region Get_Kpi_By_DIMENSION_ID_List
        List<Kpi> Get_Kpi_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List
        List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST);
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
        List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
        List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST);
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List
        List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST);
        #endregion
        #region Get_Dimension_By_DIMENSION_ORDER_List
        List<Dimension> Get_Dimension_By_DIMENSION_ORDER_List(IEnumerable<int?> DIMENSION_ORDER_LIST);
        #endregion
        #region Get_Report_By_DIMENSION_ID_List
        List<Report> Get_Report_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST);
        #endregion
        #region Get_Kpi_By_Where
        List<Kpi> Get_Kpi_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Dimension_By_Where
        List<Dimension> Get_Dimension_By_Where(string NAME, string DIMENSION_ICON, string ICON_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Report_By_Where
        List<Report> Get_Report_By_Where(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Kpi_By_Where_In_List
        List<Kpi> Get_Kpi_By_Where_In_List(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Get_Report_By_Where_In_List
        List<Report> Get_Report_By_Where_In_List(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, IEnumerable<int?> DIMENSION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT);
        #endregion
        #region Delete_Kpi
        void Delete_Kpi(int? KPI_ID);
        #endregion
        #region Delete_Dimension
        void Delete_Dimension(int? DIMENSION_ID);
        #endregion
        #region Delete_Report
        void Delete_Report(int? REPORT_ID);
        #endregion
        #region Delete_Kpi_By_OWNER_ID
        void Delete_Kpi_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Kpi_By_DIMENSION_ID
        void Delete_Kpi_By_DIMENSION_ID(int? DIMENSION_ID);
        #endregion
        #region Delete_Kpi_By_SETUP_CATEGORY_ID
        void Delete_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID);
        #endregion
        #region Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        void Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        void Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID);
        #endregion
        #region Delete_Kpi_By_OWNER_ID_IS_DELETED
        void Delete_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Kpi_By_KPI_TYPE_SETUP_ID
        void Delete_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID);
        #endregion
        #region Delete_Dimension_By_OWNER_ID
        void Delete_Dimension_By_OWNER_ID(int? OWNER_ID);
        #endregion
        #region Delete_Dimension_By_OWNER_ID_IS_DELETED
        void Delete_Dimension_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED);
        #endregion
        #region Delete_Dimension_By_DIMENSION_ORDER
        void Delete_Dimension_By_DIMENSION_ORDER(int? DIMENSION_ORDER);
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
        #region Edit_Kpi
        int? Edit_Kpi(int? KPI_ID, int? DIMENSION_ID, int? SETUP_CATEGORY_ID, string NAME, string UNIT, long? KPI_TYPE_SETUP_ID, bool HAS_CORRELATION, bool IS_TRENDLINE, bool IS_DECIMAL_VALUE, bool HAS_SQM, bool IS_BY_SEVERITY, bool IS_ADDITIVE_DATA, decimal? MINIMUM_VALUE, decimal? MAXIMUM_VALUE, string LATEST_DATA_CREATION_DATE, bool IS_AUTO_GENERATE, long? MIN_DATA_LEVEL_SETUP_ID, long? MAX_DATA_LEVEL_SETUP_ID, bool IS_EXTERNAL, bool HAS_ALERTS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Dimension
        int? Edit_Dimension(int? DIMENSION_ID, string NAME, string DIMENSION_ICON, int? DIMENSION_ORDER, string ICON_URL, string LATEST_DATA_CREATION_DATE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
        #region Edit_Report
        int? Edit_Report(int? REPORT_ID, int? DIMENSION_ID, string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID);
        #endregion
    }
}
