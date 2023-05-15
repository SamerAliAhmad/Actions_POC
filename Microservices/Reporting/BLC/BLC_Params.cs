using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Report_By_REPORT_ID
    public partial class Params_Get_Report_By_REPORT_ID
    {
        #region Properties
        public int? REPORT_ID { get; set; }
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
    #region Params_Get_Report_By_DIMENSION_ID_List
    public partial class Params_Get_Report_By_DIMENSION_ID_List
    {
        #region Properties
        public IEnumerable<int?> DIMENSION_ID_LIST { get; set; }
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
    #region Params_Delete_Report
    public partial class Params_Delete_Report
    {
        #region Properties
        public int? REPORT_ID { get; set; }
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