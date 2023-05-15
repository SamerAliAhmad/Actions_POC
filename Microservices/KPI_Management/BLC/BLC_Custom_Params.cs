using System;
using System.Collections.Generic;

namespace BLC
{
    #region GeoData
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
    #region Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID
    public class Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    #endregion
    #region Params_Get_Latest_GeoData_By_KPI
    public class Params_Get_Latest_GeoData_By_KPI
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
    #endregion
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
    #region District
    #region Params_Get_District_Indexes
    public class Params_Get_District_Indexes
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_District_Kpi_Data
    public class Params_Get_District_Kpi_Data
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Compute_District_Kpi_Data_Hourly
    public class Params_Compute_District_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_District_Kpi_Data_Daily
    public class Params_Compute_District_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_District_Kpi_Data_Weekly
    public class Params_Compute_District_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_District_Kpi_Data_Monthly
    public class Params_Compute_District_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
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
    #region Params_Get_Area_Indexes
    public class Params_Get_Area_Indexes
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Get_Latest_Area_Kpi_Data_By_Where
    public class Params_Get_Latest_Area_Kpi_Data_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }


    }
    #endregion
    #region Params_Get_Area_Kpi_Data
    public class Params_Get_Area_Kpi_Data
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Compute_Area_Kpi_Data_Hourly
    public class Params_Compute_Area_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Compute_Area_Kpi_Data_Daily
    public class Params_Compute_Area_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Area_Kpi_Data_Weekly
    public class Params_Compute_Area_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Area_Kpi_Data_Monthly
    public class Params_Compute_Area_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
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
    #region Params_Delete_Area_Kpi_Data_By_Where
    public class Params_Delete_Area_Kpi_Data_By_Where
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #endregion
    #region Site
    #region Params_Get_Site_Incidents
    public class Params_Get_Site_Incidents
    {
        public long? SITE_ID { get; set; }
        public List<int?> DIMENSION_ORDER_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Site_Kpi_Data_By_Where
    public class Params_Get_Latest_Site_Kpi_Data_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Site_Kpi_Data
    public class Params_Get_Site_Kpi_Data
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Compute_Site_Kpi_Data_Hourly
    public class Params_Compute_Site_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Site_Kpi_Data_Daily
    public class Params_Compute_Site_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Site_Kpi_Data_Weekly
    public class Params_Compute_Site_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Site_Kpi_Data_Monthly
    public class Params_Compute_Site_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
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
    #region Params_Get_Latest_Entity_Kpi_Data_By_Where
    public class Params_Get_Latest_Entity_Kpi_Data_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Entity_Kpi_Data
    public class Params_Get_Entity_Kpi_Data
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Get_Entity_Incidents
    public class Params_Get_Entity_Incidents
    {
        public int? END_ROW { get; set; }
        public int? START_ROW { get; set; }
        public long? ENTITY_ID { get; set; }
        public string END_DATE { get; set; }
        public string START_DATE { get; set; }
        public List<Setup> CATEGORY_SETUP_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER
    public class Params_Get_Incidents_By_ENTITY_ID_DIMENSION_ORDER
    {
        public long? ENTITY_ID { get; set; }
        public int? DIMENSION_ORDER { get; set; }
    }
    #endregion
    #region Params_Compute_Entity_Kpi_Data_Hourly
    public class Params_Compute_Entity_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int HOUR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Entity_Kpi_Data_Daily
    public class Params_Compute_Entity_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Entity_Kpi_Data_Weekly
    public class Params_Compute_Entity_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Entity_Kpi_Data_Monthly
    public class Params_Compute_Entity_Kpi_Data_Monthly
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
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
    #region Params_Edit_Entity_Kpi_Data_List
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
    #region Params_Get_Floor_Data
    public class Params_Get_Floor_Data
    {
        public int FLOOR_ID { get; set; }
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Get_Floors_With_Indexes
    public class Params_Get_Floors_With_Indexes
    {
        public long? ENTITY_ID { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Floor_Kpi_Data
    public class Params_Get_Floor_Kpi_Data
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Floor_Kpi_Data_By_Where
    public class Params_Get_Latest_Floor_Kpi_Data_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> FLOOR_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }


    }
    #endregion
    #region Params_Get_Floors_With_Heatmap_Data
    public class Params_Get_Floors_With_Heatmap_Data
    {
        public long? ENTITY_ID { get; set; }
    }
    #endregion
    #region Params_Compute_Floor_Kpi_Data_Hourly
    public class Params_Compute_Floor_Kpi_Data_Hourly
    {
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int DAY { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Floor_Kpi_Data_Daily
    public class Params_Compute_Floor_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Floor_Kpi_Data_Weekly
    public class Params_Compute_Floor_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Floor_Kpi_Data_Monthly
    public class Params_Compute_Floor_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
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
    #region Params_Get_Space_Indexes_By_Where
    public class Params_Get_Space_Kpi_Data_By_Where
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Space_Kpi_Data
    public class Params_Get_Space_Kpi_Data
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Space_Kpi_Data_By_Where
    public class Params_Get_Latest_Space_Kpi_Data_By_Where
    {
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }


    }
    #endregion
    #region Params_Compute_Space_Kpi_Data_Daily
    public class Params_Compute_Space_Kpi_Data_Daily
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Space_Kpi_Data_Weekly
    public class Params_Compute_Space_Kpi_Data_Weekly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion
    #region Params_Compute_Space_Kpi_Data_Monthly
    public class Params_Compute_Space_Kpi_Data_Monthly
    {
        public int MONTH { get; set; }
        public int YEAR { get; set; }
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
    #region Params_Update_All_Indexes_Asynchronously
    public class Params_Update_All_Indexes_Asynchronously
    {
        public bool IS_ASYNC { get; set; }
    }
    #endregion
    #region Ext_study_zone_geojson
    #region Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_With_GeoJson
    public class Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_With_GeoJson
    {
        public List<int?> EXT_STUDY_ZONE_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List
    public class Params_Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List
    {
        public List<int?> EXT_STUDY_ZONE_ID_LIST { get; set; }
    }
    #endregion
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
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public List<long?> LEVEL_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Alerts_By_Where_Count
    public class Params_Get_Alerts_By_Where_Count
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public List<long?> LEVEL_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Alerts_For_Levels
    public class Params_Get_Alerts_For_Levels
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Alerts_Count_For_Levels
    public class Params_Get_Alerts_Count_For_Levels
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public List<long?> USER_ID_LIST { get; set; }
        public List<string> ALERT_ID_LIST { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
    }
    #endregion
    #endregion

    #region Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    public class Params_Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    public class Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    public class Params_Get_Businesses_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Get_GeoData_By_Where
    public class Params_Get_GeoData_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
    #endregion
    #region Params_Get_Bylaw_Complaint_By_Where
    public class Params_Get_Bylaw_Complaint_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
    #endregion
    #region Params_Get_Public_Event_By_Where
    public class Params_Get_Public_Event_By_Where
    {
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
    #endregion
    #region Params_Get_District_Kpi_Data_By_Where
    public class Params_Get_District_Kpi_Data_By_Where
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_District_Kpi_Data_Aggregate_Sum
    public class Params_Get_District_Kpi_Data_Aggregate_Sum
    {
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Area_Kpi_Data_By_Where
    public class Params_Get_Area_Kpi_Data_By_Where
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Area_Kpi_Data_Aggregate_Sum
    public class Params_Get_Area_Kpi_Data_Aggregate_Sum
    {
        public List<long?> AREA_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
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
    #region Params_Get_site_Kpi_Data_Aggregate_Sum
    public class Params_Get_Site_Kpi_Data_Aggregate_Sum
    {
        public List<long?> SITE_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Entity_Kpi_Data_By_Where
    public class Params_Get_Entity_Kpi_Data_By_Where
    {
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Entity_Kpi_Data_Aggregate_Sum
    public class Params_Get_Entity_Kpi_Data_Aggregate_Sum
    {
        public List<long?> ENTITY_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }

    }
    #endregion
    #region Params_Get_Floor_Kpi_Data_By_Where
    public class Params_Get_Floor_Kpi_Data_By_Where
    {
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Floor_Kpi_Data_Aggregate_Sum
    public class Params_Get_Floor_Kpi_Data_Aggregate_Sum
    {
        public List<long?> FLOOR_ID_LIST { get; set; }
        public List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }

    }
    #endregion

    #region Params_Get_Site_Kpi_Dialog_Data
    public class Params_Get_Site_Kpi_Dialog_Data
    {
        public long? DISTRICT_ID { get; set; }
        public long? AREA_ID { get; set; }
        public long? SITE_ID { get; set; }
        public List<int?> LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public List<int?> LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public List<int?> LIST_SITE_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Area_Kpi_Dialog_Data
    public class Params_Get_Area_Kpi_Dialog_Data
    {
        public long? DISTRICT_ID { get; set; }
        public long? AREA_ID { get; set; }
        public List<int?> LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public List<int?> LIST_AREA_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_District_Kpi_Dialog_Data
    public class Params_Get_District_Kpi_Dialog_Data
    {
        public long? DISTRICT_ID { get; set; }
        public List<int?> LIST_DISTRICT_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Entity_Kpi_Dialog_Data
    public class Params_Get_Entity_Kpi_Dialog_Data
    {
        public long? ENTITY_ID { get; set; }
        public List<int?> LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Floor_Kpi_Dialog_Data
    public class Params_Get_Floor_Kpi_Dialog_Data
    {
        public long? FLOOR_ID { get; set; }
        public long? SITE_ID { get; set; }
        public List<int?> LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Intersection_Kpi_Dialog_Data
    public class Params_Get_Intersection_Kpi_Dialog_Data
    {
        public long? ENTITY_ID { get; set; }
        public List<int?> LIST_ENTITY_ORGANIZATION_DATA_SOURCE_KPI_DATA_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion

    #region Params_Get_Bylaw_Complaint_List
    public class Params_Get_Bylaw_Complaint_List
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
    }
    #endregion
    #region Params_Get_Business_List
    public class Params_Get_Business_List
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_Public_Event_List
    public class Params_Get_Public_Event_List
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
    }
    #endregion
    #region Params_Get_Visitor_Origins
    public class Params_Get_Visitor_Origins
    {
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Visitor_Count_By_Where
    public class Params_Get_Latest_Visitor_Count_By_Where
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Organization_data_source_kpi_By_Where
    public class Params_Get_Latest_Organization_data_source_kpi_By_Where
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Business_Trendline
    public class Params_Get_Business_Trendline
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Bylaw_Complaints_Trendline
    public class Params_Get_Bylaw_Complaints_Trendline
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion
    #region Params_Get_Public_Events_Trendline
    public class Params_Get_Public_Events_Trendline
    {
        public List<long?> LIST_LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
    }
    #endregion

    #region Params_Get_Organization_Data_Access
    public class Params_Get_Organization_Data_Access
    {
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_User_Data_Access
    public class Params_Get_User_Data_Access
    {
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
    #region Params_Edit_Organization_Data_Access
    public class Params_Edit_Organization_Data_Access
    {
        public List<District_kpi> List_To_Edit_District_kpi { get; set; }
        public List<District_kpi> List_To_Delete_District_kpi { get; set; }
        public List<Area_kpi> List_To_Edit_Area_kpi { get; set; }
        public List<Area_kpi> List_To_Delete_Area_kpi { get; set; }
        public List<Site_kpi> List_To_Edit_Site_kpi { get; set; }
        public List<Site_kpi> List_To_Delete_Site_kpi { get; set; }
        public List<Entity_kpi> List_To_Edit_Entity_kpi { get; set; }
        public List<Entity_kpi> List_To_Delete_Entity_kpi { get; set; }
        public Setup Selected_Level_Setup { get; set; }
    }
    #endregion
    #region Params_Edit_User_Data_Access
    public class Params_Edit_User_Data_Access
    {
        public List<District_kpi_user_access> List_To_Edit_District_kpi_user_access { get; set; }
        public List<District_kpi_user_access> List_To_Delete_District_kpi_user_access { get; set; }
        public List<Area_kpi_user_access> List_To_Edit_Area_kpi_user_access { get; set; }
        public List<Area_kpi_user_access> List_To_Delete_Area_kpi_user_access { get; set; }
        public List<Site_kpi_user_access> List_To_Edit_Site_kpi_user_access { get; set; }
        public List<Site_kpi_user_access> List_To_Delete_Site_kpi_user_access { get; set; }
        public List<Entity_kpi_user_access> List_To_Edit_Entity_kpi_user_access { get; set; }
        public List<Entity_kpi_user_access> List_To_Delete_Entity_kpi_user_access { get; set; }
        public Setup Selected_Level_Setup { get; set; }
    }
    #endregion

    #region Params_Get_Latest_Wifi_signals
    public class Params_Get_Latest_Wifi_signals
    {
        public int? NUMBER_OF_POINTS { get; set; }
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Wifi_signals
    public class Params_Get_Wifi_signals
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Wifi_signal
    public class Params_Delete_Wifi_signal
    {
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Edit_Wifi_signal_List
    public class Params_Edit_Wifi_signal_List
    {
        public List<Wifi_signal> List_Wifi_signal { get; set; }
    }
    #endregion
    #region Params_Get_Strongest_Wifi_signal
    public class Params_Get_Strongest_Wifi_signal
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> FLOOR_ID_LIST { get; set; }
        public int? TOP_LEVEL_ID { get; set; }
    }
    #endregion
    #region Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly
    public class Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly
    {
        public int DAY { get; set; }
        public int YEAR { get; set; }
        public int MONTH { get; set; }
        public int HOUR { get; set; }
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
    }
    #endregion

    #region Params_Get_Latest_Wifi_signal_alerts
    public class Params_Get_Latest_Wifi_signal_alerts
    {
        public int? NUMBER_OF_POINTS { get; set; }
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Wifi_signal_alerts
    public class Params_Get_Wifi_signal_alerts
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<string> WIFI_SIGNAL_ALERT_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_RESOLVED { get; set; }
    }
    #endregion
    #region Params_Delete_Wifi_signal_alert
    public class Params_Delete_Wifi_signal_alert
    {
        public List<string> WIFI_SIGNAL_ALERT_ID_LIST { get; set; }
        public long? FLOOR_ID { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public bool? IS_RESOLVED { get; set; }
    }
    #endregion
    #region Params_Edit_Wifi_signal_alert_List
    public class Params_Edit_Wifi_signal_alert_List
    {
        public List<Wifi_signal_alert> List_Wifi_signal_alert { get; set; }
    }
    #endregion
    #region Params_Get_Most_Wifi_signal_Count_Per_Space_asset
    public class Params_Get_Most_Wifi_signal_Count_Per_Space_asset
    {
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public List<long?> SPACE_ID_LIST { get; set; }
        public List<int?> FLOOR_ID_LIST { get; set; }
        public int? TOP_LEVEL_ID { get; set; }
    }
    #endregion

    #region Params_Update_Wifi_signal
    public class Params_Update_Wifi_signal
    {
        public long? FLOOR_ID { get; set; }
    }
    #endregion
    #region Params_Update_Kpi_Data_Record
    public class Params_Update_Kpi_Data_Record
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public int? KPI_ID { get; set; }
        public bool IS_RANDOM { get; set; }
        public bool FORCE_INJECT { get; set; }
    }
    #endregion
}
