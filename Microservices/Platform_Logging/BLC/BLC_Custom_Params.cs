using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Create_Log
    public class Params_Create_Log
    {
        public long? SITE_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public string MESSAGE { get; set; }
        public int? VIDEO_AI_ASSET_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ACCESS_TYPE_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Edit_Log_List
    public class Params_Edit_Log_List
    {
        public List<Log> LOG_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Logs_By_Where
    public class Params_Get_Logs_By_Where
    {
        public List<string> LOG_ID_LIST { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<long?> LOG_TYPE_SETUP_ID_LIST { get; set; }
        public List<long?> ACCESS_TYPE_SETUP_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<string> MESSAGE_LIST { get; set; }
        public DateTime? ENTRY_DATE_START { get; set; }
        public DateTime? ENTRY_DATE_END { get; set; }
        public List<int?> ORGANIZATION_ID_LIST { get; set; }
        public List<int?> VIDEO_AI_ASSET_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Generate_Logs_Excel
    public class Params_Generate_Logs_Excel
    {
        public int? END_ROW { get; set; }
        public int? START_ROW { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_ID_LIST { get; set; }
        public List<int?> VIDEO_AI_ASSET_ID_LIST { get; set; }
        public List<long?> LOG_TYPE_SETUP_ID_LIST { get; set; }
        public List<long?> ACCESS_TYPE_SETUP_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Logs_With_Filters
    public class Params_Get_Logs_With_Filters
    {
        public int? END_ROW { get; set; }
        public int? START_ROW { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_ID_LIST { get; set; }
        public List<int?> VIDEO_AI_ASSET_ID_LIST { get; set; }
        public List<long?> LOG_TYPE_SETUP_ID_LIST { get; set; }
        public List<long?> ACCESS_TYPE_SETUP_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Logs_By_Where_Sorted_With_Pagination
    public class Params_Get_Logs_By_Where_Sorted_With_Pagination
    {
        public List<string> LOG_ID_LIST { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<long?> LOG_TYPE_SETUP_ID_LIST { get; set; }
        public List<long?> ACCESS_TYPE_SETUP_ID_LIST { get; set; }
        public List<int?> ENTITY_ID_LIST { get; set; }
        public List<int?> SITE_ID_LIST { get; set; }
        public List<string> MESSAGE_LIST { get; set; }
        public DateTime? ENTRY_DATE_START { get; set; }
        public DateTime? ENTRY_DATE_END { get; set; }
        public List<int?> ORGANIZATION_ID_LIST { get; set; }
        public int? START_ROW { get; set; }
        public int? END_ROW { get; set; }
        public List<int?> VIDEO_AI_ASSET_ID_LIST { get; set; }
    }
    #endregion
}