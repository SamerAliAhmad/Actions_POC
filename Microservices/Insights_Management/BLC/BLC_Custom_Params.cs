using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Comparison_Data
    public class Params_Get_Comparison_Data
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Single_kpi_comparison
    public class Params_Get_Single_kpi_comparison
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Multi_kpi_comparison
    public class Params_Get_Multi_kpi_comparison
    {
        public List<Organization_data_source_kpi_By_Level> LIST_ORGANIZATION_DATA_SOURCE_KPI_BY_LEVEL { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Correlation
    public class Params_Get_Correlation
    {
        public int? RESOLUTION { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public int? CORRELATION_METHOD_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
        public Organization_data_source_kpi_By_Level First_Organization_data_source_kpi_By_Level { get; set; }
        public Organization_data_source_kpi_By_Level Second_Organization_data_source_kpi_By_Level { get; set; }
    }
    #endregion
}