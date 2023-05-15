using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Edit_Incident_List
    public class Params_Edit_Incident_List
    {
        public List<Incident> INCIDENT_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Incidents_By_Where
    public class Params_Get_Incidents_By_Where
    {
        public List<string> INCIDENT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
        public List<long?> SEVERITY_SETUP_ID_LIST { get; set; }
        public List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST { get; set; }
        public DateTime? CREATED_TIME_START { get; set; }
        public DateTime? CREATED_TIME_END { get; set; }
        public DateTime? ASSIGNED_TIME_START { get; set; }
        public DateTime? ASSIGNED_TIME_END { get; set; }
        public DateTime? CLOSED_TIME_START { get; set; }
        public DateTime? CLOSED_TIME_END { get; set; }
    }
    #endregion
    #region Params_Get_Incidents_By_Where_Count
    public class Params_Get_Incidents_By_Where_Count
    {
        public List<string> INCIDENT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
        public List<long?> SEVERITY_SETUP_ID_LIST { get; set; }
        public List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST { get; set; }
        public DateTime? CREATED_TIME_START { get; set; }
        public DateTime? CREATED_TIME_END { get; set; }
        public DateTime? ASSIGNED_TIME_START { get; set; }
        public DateTime? ASSIGNED_TIME_END { get; set; }
        public DateTime? CLOSED_TIME_START { get; set; }
        public DateTime? CLOSED_TIME_END { get; set; }
    }
    #endregion
    #region Params_Get_Incidents_By_Where_Sorted_With_Pagination
    public class Params_Get_Incidents_By_Where_Sorted_With_Pagination
    {
        public List<string> INCIDENT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
        public List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST { get; set; }
        public DateTime? CREATED_TIME_START { get; set; }
        public DateTime? CREATED_TIME_END { get; set; }
        public DateTime? ASSIGNED_TIME_START { get; set; }
        public DateTime? ASSIGNED_TIME_END { get; set; }
        public DateTime? CLOSED_TIME_START { get; set; }
        public DateTime? CLOSED_TIME_END { get; set; }
        public int? START_ROW { get; set; }
        public int? END_ROW { get; set; }
    }
    #endregion
}