using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Dimension_index_By_Where
    public class Params_Get_Dimension_index_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Insert_Dimension_index_List
    public class Params_Insert_Dimension_index_List
    {
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Delete_Dimension_index_By_Where
    public class Params_Delete_Dimension_index_By_Where
    {
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Dimension_index_By_Where
    public class Params_Get_Latest_Dimension_index_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<Dimension_ID_By_Level_ID> LIST_DIMENSION_ID_BY_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Generate_Dimension_Index_Daily
    public class Params_Generate_Dimension_Index_Daily
    {
        public int DAY { get; set; }
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Dimension> LIST_DIMENSION { get; set; }
    }
    #endregion
    #region Params_Compute_Dimension_Index_Weekly
    public class Params_Compute_Dimension_Index_Weekly
    {
        public int DAY { get; set; }
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Dimension> LIST_DIMENSION { get; set; }
    }
    #endregion
    #region Params_Compute_Dimension_Index_Monthly
    public class Params_Compute_Dimension_Index_Monthly
    {
        public int DAY { get; set; }
        public int MONTH { get; set; }
        public int YEAR { get; set; }
        public List<Dimension> LIST_DIMENSION { get; set; }
    }
    #endregion
    #region Params_Edit_Dimension_index_List_By_RECORD_DATE
    public class Params_Edit_Dimension_index_List_By_RECORD_DATE
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_DIMENSION_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
    }
    #endregion
}