using System;

namespace DALC
{
    #region Kpi
    public partial class Kpi
    {
        public int? KPI_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public int? SETUP_CATEGORY_ID { get; set; }
        public string NAME { get; set; }
        public string UNIT { get; set; }
        public long? KPI_TYPE_SETUP_ID { get; set; }
        public bool HAS_CORRELATION { get; set; }
        public bool IS_TRENDLINE { get; set; }
        public bool IS_DECIMAL_VALUE { get; set; }
        public bool HAS_SQM { get; set; }
        public bool IS_BY_SEVERITY { get; set; }
        public bool IS_ADDITIVE_DATA { get; set; }
        public decimal? MINIMUM_VALUE { get; set; }
        public decimal? MAXIMUM_VALUE { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public bool IS_AUTO_GENERATE { get; set; }
        public long? MIN_DATA_LEVEL_SETUP_ID { get; set; }
        public long? MAX_DATA_LEVEL_SETUP_ID { get; set; }
        public bool IS_EXTERNAL { get; set; }
        public bool HAS_ALERTS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Dimension Dimension { get; set; }
        public Setup Kpi_type_setup { get; set; }
        public Setup Max_data_level_setup { get; set; }
        public Setup Min_data_level_setup { get; set; }
        public Setup_category Setup_category { get; set; }
    }
    #endregion
    #region Dimension
    public partial class Dimension
    {
        public int? DIMENSION_ID { get; set; }
        public string NAME { get; set; }
        public string DIMENSION_ICON { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        public string ICON_URL { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Setup_category
    public partial class Setup_category
    {
        public int? SETUP_CATEGORY_ID { get; set; }
        public string SETUP_CATEGORY_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Setup
    public partial class Setup
    {
        public long? SETUP_ID { get; set; }
        public int? SETUP_CATEGORY_ID { get; set; }
        public bool IS_SYSTEM { get; set; }
        public bool IS_DELETEABLE { get; set; }
        public bool IS_UPDATEABLE { get; set; }
        public bool IS_DELETED { get; set; }
        public bool IS_VISIBLE { get; set; }
        public int? DISPLAY_ORDER { get; set; }
        public string VALUE { get; set; }
        public string DESCRIPTION { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Report
    public partial class Report
    {
        public int? REPORT_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public string FILE_NAME { get; set; }
        public string FILE_EXTENSION { get; set; }
        public string FILE_SIZE { get; set; }
        public string IDENTIFIER_TOKEN { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
        public Dimension Dimension { get; set; }
    }
    #endregion
}
