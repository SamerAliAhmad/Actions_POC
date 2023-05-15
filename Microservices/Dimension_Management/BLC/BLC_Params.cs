using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Kpi_By_KPI_ID
    public partial class Params_Get_Kpi_By_KPI_ID
    {
        #region Properties
        public int? KPI_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_DIMENSION_ID
    public partial class Params_Get_Dimension_By_DIMENSION_ID
    {
        #region Properties
        public int? DIMENSION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_REPORT_ID
    public partial class Params_Get_Report_By_REPORT_ID
    {
        #region Properties
        public int? REPORT_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_KPI_ID_List
    public partial class Params_Get_Kpi_By_KPI_ID_List
    {
        #region Properties
        public IEnumerable<int?> KPI_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_DIMENSION_ID_List
    public partial class Params_Get_Dimension_By_DIMENSION_ID_List
    {
        #region Properties
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_REPORT_ID_List
    public partial class Params_Get_Report_By_REPORT_ID_List
    {
        #region Properties
        public IEnumerable<int?> REPORT_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_OWNER_ID
    public partial class Params_Get_Kpi_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_DIMENSION_ID
    public partial class Params_Get_Kpi_By_DIMENSION_ID
    {
        #region Properties
        public int? DIMENSION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_SETUP_CATEGORY_ID
    public partial class Params_Get_Kpi_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
    public partial class Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
    {
        #region Properties
        public long? MIN_DATA_LEVEL_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
    public partial class Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
    {
        #region Properties
        public long? MAX_DATA_LEVEL_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Kpi_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_KPI_TYPE_SETUP_ID
    public partial class Params_Get_Kpi_By_KPI_TYPE_SETUP_ID
    {
        #region Properties
        public long? KPI_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_OWNER_ID
    public partial class Params_Get_Dimension_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Dimension_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_DIMENSION_ORDER
    public partial class Params_Get_Dimension_By_DIMENSION_ORDER
    {
        #region Properties
        public int? DIMENSION_ORDER { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_OWNER_ID
    public partial class Params_Get_Report_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_DIMENSION_ID
    public partial class Params_Get_Report_By_DIMENSION_ID
    {
        #region Properties
        public int? DIMENSION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Report_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_IDENTIFIER_TOKEN
    public partial class Params_Get_Report_By_IDENTIFIER_TOKEN
    {
        #region Properties
        public string IDENTIFIER_TOKEN { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_DIMENSION_ID_List
    public partial class Params_Get_Kpi_By_DIMENSION_ID_List
    {
        #region Properties
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_SETUP_CATEGORY_ID_List
    public partial class Params_Get_Kpi_By_SETUP_CATEGORY_ID_List
    {
        #region Properties
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
    public partial class Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
    public partial class Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List
    public partial class Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List
    {
        #region Properties
        public IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_DIMENSION_ORDER_List
    public partial class Params_Get_Dimension_By_DIMENSION_ORDER_List
    {
        #region Properties
        public IEnumerable<int?> DIMENSION_ORDER_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_DIMENSION_ID_List
    public partial class Params_Get_Report_By_DIMENSION_ID_List
    {
        #region Properties
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_Where
    public partial class Params_Get_Kpi_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Dimension_By_Where
    public partial class Params_Get_Dimension_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string DIMENSION_ICON { get; set; }
        public string ICON_URL { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_Where
    public partial class Params_Get_Report_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public string FILE_SIZE { get; set; }
        public string IDENTIFIER_TOKEN { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Kpi_By_Where_In_List
    public partial class Params_Get_Kpi_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
        public IEnumerable<int?> SETUP_CATEGORY_ID_LIST { get; set; }
        public IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST { get; set; }
        public IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST { get; set; }
        public IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Report_By_Where_In_List
    public partial class Params_Get_Report_By_Where_In_List
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public string FILE_SIZE { get; set; }
        public string IDENTIFIER_TOKEN { get; set; }
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi
    public partial class Params_Delete_Kpi
    {
        #region Properties
        public int? KPI_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Dimension
    public partial class Params_Delete_Dimension
    {
        #region Properties
        public int? DIMENSION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Report
    public partial class Params_Delete_Report
    {
        #region Properties
        public int? REPORT_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_OWNER_ID
    public partial class Params_Delete_Kpi_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_DIMENSION_ID
    public partial class Params_Delete_Kpi_By_DIMENSION_ID
    {
        #region Properties
        public int? DIMENSION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_SETUP_CATEGORY_ID
    public partial class Params_Delete_Kpi_By_SETUP_CATEGORY_ID
    {
        #region Properties
        public int? SETUP_CATEGORY_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
    public partial class Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
    {
        #region Properties
        public long? MIN_DATA_LEVEL_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
    public partial class Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
    {
        #region Properties
        public long? MAX_DATA_LEVEL_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Kpi_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID
    public partial class Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID
    {
        #region Properties
        public long? KPI_TYPE_SETUP_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Dimension_By_OWNER_ID
    public partial class Params_Delete_Dimension_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Dimension_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Dimension_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Dimension_By_DIMENSION_ORDER
    public partial class Params_Delete_Dimension_By_DIMENSION_ORDER
    {
        #region Properties
        public int? DIMENSION_ORDER { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Report_By_OWNER_ID
    public partial class Params_Delete_Report_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Report_By_DIMENSION_ID
    public partial class Params_Delete_Report_By_DIMENSION_ID
    {
        #region Properties
        public int? DIMENSION_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Report_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Report_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Report_By_IDENTIFIER_TOKEN
    public partial class Params_Delete_Report_By_IDENTIFIER_TOKEN
    {
        #region Properties
        public string IDENTIFIER_TOKEN { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Kpi_List
    public partial class Params_Edit_Kpi_List
    {
        #region Properties
        public List<Kpi> List_To_Edit { get; set; }
        public List<Kpi> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Dimension_List
    public partial class Params_Edit_Dimension_List
    {
        #region Properties
        public List<Dimension> List_To_Edit { get; set; }
        public List<Dimension> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Report_List
    public partial class Params_Edit_Report_List
    {
        #region Properties
        public List<Report> List_To_Edit { get; set; }
        public List<Report> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}