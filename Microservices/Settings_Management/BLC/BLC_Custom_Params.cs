using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Upload_Default_Picture
    public class Params_Upload_Default_Settings_Picture
    {
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    #endregion
    #region Params_Delete_Default_Settings_Picture
    public class Params_Delete_Default_Settings_Picture
    {
        public long? IMAGE_TYPE_SETUP_ID { get; set; }
    }
    #endregion
    #region Params_Update_Otp_Index
    public class Params_Update_Otp_Index
    {
        public int? OTP_TTL_IN_SECONDS { get; set; }
    }
    #endregion
    #region Params_Edit_Removed_extrusion_Custom
    public class Params_Edit_Removed_extrusion_Custom
    {
        public List<Removed_extrusion> List_Removed_extrusion { get; set; }
    }
    #endregion
    #region Params_Edit_Removed_extrusion_Custom_Old
    public class Params_Edit_Removed_extrusion_Custom_Old
    {
        public string ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public long? LEVEL_ID { get; set; }
    }
    #endregion
    #region Params_Create_Time_series_Collection
    public class Params_Create_Time_series_Collection
    {
        public string TIME_SERIES_COLLECTION_NAME { get; set; }
    }
    #endregion
    #region Params_Update_All_Indexes_Asynchronously
    public class Params_Update_All_Indexes_Asynchronously
    {
        public bool IS_ASYNC { get; set; }
    }
    #endregion
    #region Params_Edit_Object_View
    public class Params_Edit_Object_View
    {
        public int? DISTRICT_ID { get; set; }
        public int? AREA_ID { get; set; }
        public int? SITE_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public long? VIEW_TYPE_SETUP_ID { get; set; }
        public decimal PITCH { get; set; }
        public decimal BEARING { get; set; }
        public decimal ZOOM { get; set; }
        public decimal LONGITUDE { get; set; }
        public decimal LATITUDE { get; set; }
    }
    #endregion
    #region Params_Drop_Collection
    public class Params_Drop_Collection
    {
        public string COLLECTION_NAME { get; set; }
    }
    #endregion
    #region Params_Send_Support_Email
    public class Params_Send_Support_Email
    {
        public string TITLE { get; set; }
        public string MESSAGE { get; set; }
        public List<string> List_Email { get; set; }
    }
    #endregion
    #region Params_Custom_Edit_Build_version
    public class Params_Custom_Edit_Build_version
    {
        public Build_version Build_version { get; set; }
    }
    #endregion

    #region Params_Delete_Dimension_chart_configuration
    public class Params_Delete_Dimension_chart_configuration
    {
        public string DIMENSION_CHART_CONFIGURATION_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Kpi_chart_configuration
    public class Params_Delete_Kpi_chart_configuration
    {
        public string KPI_CHART_CONFIGURATION_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Specialized_chart_configuration
    public class Params_Delete_Specialized_chart_configuration
    {
        public string SPECIALIZED_CHART_CONFIGURATION_ID { get; set; }
    }
    #endregion
    #region Params_Get_Specialized_chart_configuration_By_MODULE
    public class Params_Get_Specialized_chart_configuration_By_MODULE
    {
        public string MODULE { get; set; }
    }
    #endregion

    #region Params_Edit_District_geojson
    public class Params_Edit_District_geojson
    {
        public string District_geojson { get; set; }
    }
    #endregion
    #region Params_Edit_Area_geojson
    public class Params_Edit_Area_geojson
    {
        public string Area_geojson { get; set; }
    }
    #endregion
    #region Params_Edit_Site_geojson
    public class Params_Edit_Site_geojson
    {
        public string Site_geojson { get; set; }
    }
    #endregion
    #region Params_Edit_Ext_study_zone_geojson
    public class Params_Edit_Ext_study_zone_geojson
    {
        public string Ext_study_zone_geojson { get; set; }
    }
    #endregion

    #region Params_Delete_District_geojson_By_DISTRICT_ID
    public class Params_Delete_District_geojson_By_DISTRICT_ID
    {
        public long? DISTRICT_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Area_geojson_By_AREA_ID
    public class Params_Delete_Area_geojson_By_AREA_ID
    {
        public long? AREA_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Site_geojson_By_SITE_ID
    public class Params_Delete_Site_geojson_By_SITE_ID
    {
        public long? SITE_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
    public class Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
    {
        public int? EXT_STUDY_ZONE_ID { get; set; }
    }
    #endregion
}