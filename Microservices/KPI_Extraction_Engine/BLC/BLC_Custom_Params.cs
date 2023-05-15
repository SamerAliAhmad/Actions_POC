using System;
using System.Collections.Generic;

namespace BLC
{
    #region Utils
    #region Params_Get_Week_Of_Year
    public class Params_Get_Week_Of_Year
    {
        public int? DAY { get; set; }
        public int? MONTH { get; set; }
        public int? YEAR { get; set; }
    }
    #endregion
    #endregion
    #region Params_Get_Demographic_Data
    public class Params_Get_Demographic_Data
    {
        public string AUTH_TOKEN { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Visitor_Activity_Data
    public class Params_Get_Visitor_Activity_Data
    {
        public string AUTH_TOKEN { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public int? DWELL_BUCKET_TIME { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Delete_Job
    public class Params_Delete_Job
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<string> JOB_ID_LIST { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public List<int?> MIN_DWELL_TIME_LIST { get; set; }
        public List<int?> MAX_DWELL_TIME_LIST { get; set; }
        public List<int?> DWELL_TIME_BUCKET_LIST { get; set; }
        public List<long?> REQUEST_SETUP_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Edit_Job_List
    public class Params_Edit_Job_List
    {
        public List<Job> List_Job { get; set; }
    }
    #endregion
    #region Params_Get_Jobs_By_Where
    public class Params_Get_Jobs_By_Where
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<string> JOB_ID_LIST { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public List<int?> MIN_DWELL_TIME_LIST { get; set; }
        public List<int?> MAX_DWELL_TIME_LIST { get; set; }
        public List<int?> DWELL_TIME_BUCKET_LIST { get; set; }
        public List<long?> REQUEST_SETUP_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Visitor_Data
    public class Params_Get_Visitor_Data
    {
        public string AUTH_TOKEN { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public int? DWELL_BUCKET_TIME { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public int? MIN_DWELL_TIME_IN_MINUTES { get; set; }
        public int? MAX_DWELL_TIME_IN_MINUTES { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_place_coordinates
    public class Params_Get_place_coordinates
    {
        public string LOCATION_STRING { get; set; }
        public string GOOGLE_MAP_API_TOKEN { get; set; }
    }
    #endregion
    #region Params_Delete_Niche_categories
    public class Params_Delete_Niche_categories
    {
        public List<string> BUSINESS_NICHE_LIST { get; set; }
        public List<string> NICHE_CATEGORIES_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Edit_Niche_categories_List
    public class Params_Edit_Niche_categories_List
    {
        public List<Niche_categories> List_Niche_categories { get; set; }
    }
    #endregion
    #region Params_Get_Niche_categories_By_Where
    public class Params_Get_Niche_categories_By_Where
    {
        public List<string> BUSINESS_NICHE_LIST { get; set; }
        public List<string> NICHE_CATEGORIES_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Generate_Business_Count_And_Vacant_Business_Count
    public class Params_Generate_Business_Count_And_Vacant_Business_Count
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    #endregion
    #region Params_Extract_Kpi_Data_From_CSV
    public class Params_Extract_Kpi_Data_From_CSV
    {
        public int? ORGANIZATION_ID { get; set; }
        public string FILE_NAME { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Alerts
    #region Params_Delete_Alert
    public class Params_Delete_Alert
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? ARE_UNACKNOWLEDGEMENTS_CREATED { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Edit_Alert_List
    public class Params_Edit_Alert_List
    {
        public List<Alert> List_Alert { get; set; }
    }
    #endregion
    #region Params_Get_Alerts_By_Where
    public class Params_Get_Alerts_By_Where
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public List<long?> LEVEL_ID_LIST { get; set; }
    }
    #endregion
    #endregion

    #region GeoData
    #region Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    public class Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Get_And_Fill_Bylaw_complaints_From_Api
    public class Params_Get_And_Fill_Bylaw_complaints_From_Api
    {
        public DateTime? DATE_CREATED_START_DATE { get; set; }
    }
    #endregion
    #region Params_Get_And_Fill_Public_events_From_Api
    public class Params_Get_And_Fill_Public_events_From_Api
    {
        public DateTime? DATE_CREATED_START_DATE { get; set; }
    }
    #endregion
    #region Params_Get_GeoData_By_GEODATA_ID
    public class Params_Get_GeoData_By_GEODATA_ID
    {
        public string GEODATA_ID { get; set; }
    }
    #endregion
    #region Params_Get_GeoData_By_GEODATA_ID_List
    public class Params_Get_GeoData_By_GEODATA_ID_List
    {
        public List<string> GEODATA_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_GeoData_By_Where
    public class Params_Get_GeoData_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Get_Latest_GeoData_By_KPI
    public class Params_Get_Latest_GeoData_By_KPI
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    #endregion
    #region Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID
    public class Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    #endregion
    #region Params_Edit_GeoData_List
    public class Params_Edit_GeoData_List
    {
        public List<GeoData> List_GeoData { get; set; }
    }
    #endregion
    #region Params_Delete_GeoData_By_GEODATA_ID_List
    public class Params_Delete_GeoData_By_GEODATA_ID_List
    {
        public List<string> GEODATA_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Assign_Site_IDs_In_GeoData_List
    public class Params_Assign_Site_IDs_In_GeoData_List
    {
        public List<GeoData> List_GeoData { get; set; }
    }
    #endregion
    #region Params_Assign_Area_IDs_In_GeoData_List
    public class Params_Assign_Area_IDs_In_GeoData_List
    {
        public List<GeoData> List_GeoData { get; set; }
    }
    #endregion
    #region Params_Assign_District_IDs_In_GeoData_List
    public class Params_Assign_District_IDs_In_GeoData_List
    {
        public List<GeoData> List_GeoData { get; set; }
    }
    #endregion
    #region Params_Set_Business_Niche
    public class Params_Set_Business_Niche
    {
        public List<GeoData> LIST_GEODATA { get; set; }
    }
    #endregion
    #region Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
    public class Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
    {
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    #endregion
    #endregion
    #region District
    #region Params_Generate_District_Hourly_Indexes
    public class Params_Generate_District_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Generate_District_Dwell_Time
    public class Params_Generate_District_Dwell_Time
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    #endregion
    #region Params_Generate_District_Demographic_Data
    public class Params_Generate_District_Demographic_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    #endregion
    #region Params_Generate_Or_Compute_District_Hourly_Data
    public class Params_Generate_Or_Compute_District_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    public class Params_Edit_District_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<District_kpi_data> LIST_DISTRICT_KPI_DATA { get; set; }
    }
    #endregion
    #region Params_Insert_District_Kpi_Data_List
    public class Params_Insert_District_Kpi_Data_List
    {
        public List<District_kpi_data> DISTRICT_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Delete_District_Kpi_Data_By_Where
    public class Params_Delete_District_Kpi_Data_By_Where
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #endregion
    #region Area
    #region Params_Generate_Area_Hourly_Indexes
    public class Params_Generate_Area_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Generate_Area_Dwell_Time
    public class Params_Generate_Area_Dwell_Time
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    #endregion
    #region Params_Generate_Area_Demographic_Data
    public class Params_Generate_Area_Demographic_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
    }
    #endregion
    #region Params_Generate_Or_Compute_Area_Hourly_Data
    public class Params_Generate_Or_Compute_Area_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    public class Params_Edit_Area_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<Area_kpi_data> LIST_AREA_KPI_DATA { get; set; }
    }
    #endregion
    #region Params_Insert_Area_Kpi_Data_List
    public class Params_Insert_Area_Kpi_Data_List
    {
        public List<Area_kpi_data> AREA_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Delete_Area_Kpi_Data
    public class Delete_Area_Kpi_Data_By_Where
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #endregion
    #region Site
    #region Params_Get_Site_Kpi_Data_By_Where
    public class Params_Get_Site_Kpi_Data_By_Where
    {
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }

        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Generate_Visitor_Activity_Data
    public class Params_Generate_Visitor_Activity_Data
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Visitor_Activity Visitor_Activity { get; set; }
    }
    #endregion
    #region Params_Generate_Site_Visitor_Data_And_Dwell_Time
    public class Params_Generate_Site_Visitor_Data_And_Dwell_Time
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Visitor_Data Visitor_Data { get; set; }
        public Visitor_Data Dwell_Time_1 { get; set; }
        public Visitor_Data Dwell_Time_2 { get; set; }
        public Visitor_Data Dwell_Time_3 { get; set; }
        public Visitor_Data Dwell_Time_4 { get; set; }
    }
    #endregion
    #region Params_Generate_Site_Demographic_Data
    public class Params_Generate_Site_Demographic_Data
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Demographic_Data Demographic_Data { get; set; }
    }
    #endregion
    #region Params_Generate_Worker_Data
    public class Params_Generate_Worker_Data
    {
        public DateTime START_TIME { get; set; }
        public List<Site> List_Site { get; set; }
        public Visitor_Data Visitor_Data { get; set; }
    }
    #endregion
    #region Params_Generate_Site_Hourly_Indexes
    public class Params_Generate_Site_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Generate_Or_Compute_Site_Hourly_Data
    public class Params_Generate_Or_Compute_Site_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    public class Params_Edit_Site_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<Site_kpi_data> LIST_SITE_KPI_DATA { get; set; }
    }
    #endregion
    #region Params_Insert_Site_Kpi_Data_List
    public class Params_Insert_Site_Kpi_Data_List
    {
        public List<Site_kpi_data> SITE_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Delete_Site_Kpi_Data_By_Where
    public class Params_Delete_Site_Kpi_Data_By_Where
    {
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #endregion
    #region Entity
    #region Params_Generate_Entity_Hourly_Indexes
    public class Params_Generate_Entity_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Generate_Or_Compute_Entity_Hourly_Data
    public class Params_Generate_Or_Compute_Entity_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    public class Params_Edit_Entity_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<Entity_kpi_data> LIST_ENTITY_KPI_DATA { get; set; }
    }
    #endregion
    #region Params_Insert_Entity_Kpi_Data_List
    public class Params_Insert_Entity_Kpi_Data_List
    {
        public List<Entity_kpi_data> ENTITY_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Delete_Entity_Kpi_Data_By_Where
    public class Params_Delete_Entity_Kpi_Data_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #endregion
    #region Floor
    #region Params_Generate_Floor_Hourly_Indexes
    public class Params_Generate_Floor_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Generate_Or_Compute_Floor_Hourly_Data
    public class Params_Generate_Or_Compute_Floor_Hourly_Data
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    public class Params_Edit_Floor_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<Floor_kpi_data> LIST_FLOOR_KPI_DATA { get; set; }
    }
    #endregion
    #region Params_Insert_Floor_Kpi_Data_List
    public class Params_Insert_Floor_Kpi_Data_List
    {
        public List<Floor_kpi_data> FLOOR_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Delete_Floor_Kpi_Data_By_Where
    public class Params_Delete_Floor_Kpi_Data_By_Where
    {
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #endregion
    #region Space
    #region Params_Generate_Space_Hourly_Indexes
    public class Params_Generate_Space_Hourly_Indexes
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    public class Params_Edit_Space_Kpi_Data_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN
    {
        public DateTime? RECORD_DATE { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public List<Space_kpi_data> LIST_SPACE_KPI_DATA { get; set; }
    }
    #endregion
    #region Params_Insert_Space_Kpi_Data_List
    public class Params_Insert_Space_Kpi_Data_List
    {
        public List<Space_kpi_data> SPACE_KPI_DATA_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Delete_Space_Kpi_Data
    public class Params_Delete_Space_Kpi_Data_By_Where
    {
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #endregion
}