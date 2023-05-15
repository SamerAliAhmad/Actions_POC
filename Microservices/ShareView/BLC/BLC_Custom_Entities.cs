using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text.Json.Serialization;

namespace BLC
{
    public static partial class Global
    {
        public static string User_ID = "USER_ID";
        public static string Owner_ID = "OWNER_ID";
        public static string Start_Date = "START_DATE";
        public static string Ticket_Separator = "[~!@]";
        public static string Start_Minute = "START_MINUTE";
        public static string Session_Period = "SESSION_PERIOD";
        public static string Assets_Endpoint = ConfigurationManager.AppSettings["ASSETS_ENDPOINT"];
        public static string Shared_Files_Path = ConfigurationManager.AppSettings["SHARED_FILES_PATH"];
    }

    #region Organization
    public partial class Organization
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    #endregion
    #region Default_settings
    public partial class Default_settings
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    #endregion
    #region Entity_share_data
    public partial class Entity_share_data
    {
        public string ENTITY_SHARE_DATA_ID { get; set; }
        public string SHARING_USER_NAME { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string UNIQUE_STRING { get; set; }
        public DateTime? FILTER_START_DATE { get; set; }
        public DateTime? FILTER_END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_CAMERA_ONE_ON { get; set; }
        public bool? IS_CAMERA_TWO_ON { get; set; }
        public bool? IS_CAMERA_THREE_ON { get; set; }
        public List<Wifi_signal> LIST_FLOOR_ASSET_WIFI_SIGNAL { get; set; }
        public List<Wifi_signal> LIST_FLOOR_CHART_WIFI_SIGNAL { get; set; }
        public List<Wifi_signal> LIST_SUMMARY_WIFI_SIGNAL { get; set; }
        public List<long?> LIST_SUMMARY_SPACE_ASSET_ID { get; set; }
        public List<string> LIST_WIFI_SIGNAL_ALERT_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public bool IS_ALERT { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_INCIDENT_ID { get; set; }
        public List<Dimension_index_By_Level> LIST_FLOOR_DIMENSION_INDEX { get; set; }
        public Dimension_index_By_Level ENTITY_DIMENSION_INDEX { get; set; }
        public List<Level_Dimension_with_Status> LIST_ENTITY_LEVEL_DIMENSION_WITH_STATUS { get; set; }
        public bool? IS_ENTITY_SUMMARY_DRAWER_VISIBLE { get; set; }
    }
    #endregion
    #region Entity_share_view_data
    public partial class Entity_share_view_data
    {
        public string SHARING_USER_NAME { get; set; }
        public DateTime? FILTER_START_DATE { get; set; }
        public DateTime? FILTER_END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public Entity Entity { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_CAMERA_ONE_ON { get; set; }
        public bool? IS_CAMERA_TWO_ON { get; set; }
        public bool? IS_CAMERA_THREE_ON { get; set; }
        public List<Wifi_signal> List_Floor_asset_Wifi_signal { get; set; }
        public List<Wifi_signal> List_Floor_chart_Wifi_signal { get; set; }
        public List<Wifi_signal> List_Summary_Wifi_signal { get; set; }
        public List<Space_asset> List_Summary_Space_asset { get; set; }
        public List<Wifi_signal_alert> List_Wifi_signal_alert { get; set; }
        public int? DIMENSION_ID { get; set; }
        public bool IS_ALERT { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<Incident> List_Incident { get; set; }
        public List<Floor_Kpi_Dialog_Data> List_Floor_kpi_data { get; set; }
        public List<Entity_Kpi_Dialog_Data> List_Entity_kpi_data { get; set; }
        public List<Dimension_index_By_Level> List_Floor_Dimension_index { get; set; }
        public List<Kpi_chart_configuration> List_Kpi_chart_configuration { get; set; }
        public Dimension_index_By_Level Entity_Dimension_index { get; set; }
        public List<Dimension_chart_configuration> List_Dimension_chart_configuration { get; set; }
        public List<Setup_category> List_Setup_category { get; set; }
        public List<Level_Dimension_with_Status> List_Entity_Level_Dimension_with_Status { get; set; }
        public bool? IS_ENTITY_SUMMARY_DRAWER_VISIBLE { get; set; }
    }
    #endregion
    #region Wifi_signal
    #region Wifi_signal
    public partial class Wifi_signal
    {
        public DateTime? RECORD_DATE { get; set; }
        public decimal? VALUE { get; set; }
        public string VALUE_NAME { get; set; }
        public Wifi_signal_Metadata WIFI_SIGNAL_METADATA { get; set; }
    }
    #endregion
    #region Wifi_signal_Metadata
    public partial class Wifi_signal_Metadata
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    #endregion
    #endregion
    #region Wifi_signal_alert
    public partial class Wifi_signal_alert
    {
        public string WIFI_SIGNAL_ALERT_ID { get; set; }
        public decimal? ALERT_VALUE { get; set; }
        public decimal? RESOLVE_VALUE { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
        public bool? IS_RESOLVED { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    #endregion
    #region Level_Dimension_with_Status
    public class Level_Dimension_with_Status
    {
        public List<long?> LEVEL_ID_LIST { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Dimension DIMENSION { get; set; }
        public Enum_Dimension_Status ENUM_DIMENSION_STATUS { get; set; }
    }
    #endregion
    #region Space
    public partial class Space
    {
        public List<Space_asset> List_Space_asset { get; set; }
    }
    #endregion
    #region Surveillance_Camera
    public partial class Surveillance_Camera
    {
        [JsonPropertyName("content")]
        public Surveillance_Camera_Content[] Content { get; set; }

        [JsonPropertyName("pageable")]
        public Pageable Pageable { get; set; }

        [JsonPropertyName("last")]
        public bool Last { get; set; }

        [JsonPropertyName("totalPages")]
        public long TotalPages { get; set; }

        [JsonPropertyName("totalElements")]
        public long TotalElements { get; set; }

        [JsonPropertyName("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonPropertyName("first")]
        public bool First { get; set; }

        [JsonPropertyName("sort")]
        public Sort Sort { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("number")]
        public long Number { get; set; }

        [JsonPropertyName("empty")]
        public bool Empty { get; set; }
    }

    public partial class Surveillance_Camera_Content
    {
        [JsonPropertyName("createDate")]
        public DateTimeOffset CreateDate { get; set; }

        [JsonPropertyName("updateDate")]
        public DateTimeOffset UpdateDate { get; set; }

        [JsonPropertyName("cameraId")]
        public long CameraId { get; set; }

        [JsonPropertyName("nvr")]
        public object Nvr { get; set; }

        [JsonPropertyName("nvrChannel")]
        public object NvrChannel { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ip")]
        public object Ip { get; set; }

        [JsonPropertyName("port")]
        public object Port { get; set; }

        [JsonPropertyName("account")]
        public object Account { get; set; }

        [JsonPropertyName("password")]
        public object Password { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("streamUrl")]
        public string StreamUrl { get; set; }

        [JsonPropertyName("roiContour")]
        public RoiContour[] RoiContour { get; set; }

        [JsonPropertyName("manufacturer")]
        public object Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public object Model { get; set; }

        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [JsonPropertyName("frameRate")]
        public long? FrameRate { get; set; }

        [JsonPropertyName("plugins")]
        public object[] Plugins { get; set; }

        [JsonPropertyName("ainvrId")]
        public long AinvrId { get; set; }

        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        [JsonPropertyName("engineProfileId")]
        public long? EngineProfileId { get; set; }

        [JsonPropertyName("engineProfile")]
        public EngineProfile EngineProfile { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("latitude")]
        public object Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public object Longitude { get; set; }

        [JsonPropertyName("gpuId")]
        public object GpuId { get; set; }

        [JsonPropertyName("hwDecode")]
        public object HwDecode { get; set; }

        [JsonPropertyName("cscState")]
        public string CscState { get; set; }

        [JsonPropertyName("locationType")]
        public string LocationType { get; set; }

        [JsonPropertyName("floorPlanId")]
        public object FloorPlanId { get; set; }

        [JsonPropertyName("floorPlanX")]
        public object FloorPlanX { get; set; }

        [JsonPropertyName("floorPlanY")]
        public object FloorPlanY { get; set; }

        [JsonPropertyName("floorPlanAngle")]
        public object FloorPlanAngle { get; set; }

        [JsonPropertyName("engineModels")]
        public string[] EngineModels { get; set; }

        [JsonPropertyName("resource")]
        public long? Resource { get; set; }

        [JsonPropertyName("schedule")]
        public Schedule Schedule { get; set; }

        [JsonPropertyName("cameraType")]
        public string CameraType { get; set; }

        [JsonPropertyName("fpsType")]
        public string FpsType { get; set; }

        [JsonPropertyName("loop")]
        public long Loop { get; set; }

        [JsonPropertyName("externalMeta")]
        public string ExternalMeta { get; set; }

        [JsonPropertyName("authenticatedUrl")]
        public string AuthenticatedUrl { get; set; }
    }

    public partial class EngineProfile
    {
        [JsonPropertyName("createDate")]
        public DateTimeOffset CreateDate { get; set; }

        [JsonPropertyName("updateDate")]
        public DateTimeOffset UpdateDate { get; set; }

        [JsonPropertyName("engineProfileId")]
        public long EngineProfileId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("engineConfig")]
        public EngineConfig EngineConfig { get; set; }

        [JsonPropertyName("isDefault")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("engineModelId")]
        public long[] EngineModelId { get; set; }

        [JsonPropertyName("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class EngineConfig
    {
        [JsonPropertyName("pluginConfig")]
        public PluginConfig PluginConfig { get; set; }

        [JsonPropertyName("engineModelConfigList")]
        public EngineModelConfigList[] EngineModelConfigList { get; set; }
    }

    public partial class EngineModelConfigList
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        [JsonPropertyName("minObjSize")]
        public long MinObjSize { get; set; }

        [JsonPropertyName("maxObjSize")]
        public long MaxObjSize { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class PluginConfig
    {
        [JsonPropertyName("motionDetectSize")]
        public long MotionDetectSize { get; set; }

        [JsonPropertyName("motionDetectParam")]
        public double MotionDetectParam { get; set; }

        [JsonPropertyName("faceRecognitionSimilarityThreshold")]
        public double FaceRecognitionSimilarityThreshold { get; set; }

        [JsonPropertyName("faceRecognitionMinSize")]
        public long FaceRecognitionMinSize { get; set; }

        [JsonPropertyName("enableFrontalFaceDetection")]
        public bool EnableFrontalFaceDetection { get; set; }

        [JsonPropertyName("licensePlateConfidenceThreshold")]
        public double LicensePlateConfidenceThreshold { get; set; }

        [JsonPropertyName("licensePlateMinSize")]
        public long LicensePlateMinSize { get; set; }

        [JsonPropertyName("makeModelConfidenceThreshold")]
        public double MakeModelConfidenceThreshold { get; set; }

        [JsonPropertyName("makeModelMinSize")]
        public long MakeModelMinSize { get; set; }

        [JsonPropertyName("ageGenderMinSize")]
        public long AgeGenderMinSize { get; set; }

        [JsonPropertyName("enableAgeGenderQualityDetection")]
        public bool EnableAgeGenderQualityDetection { get; set; }
    }

    public partial class RoiContour
    {
        [JsonPropertyName("contour")]
        public Contour[] Contour { get; set; }
    }

    public partial class Contour
    {
        [JsonPropertyName("x")]
        public long X { get; set; }

        [JsonPropertyName("y")]
        public long Y { get; set; }
    }

    public partial class Schedule
    {
        [JsonPropertyName("weekdays")]
        public object[] Weekdays { get; set; }

        [JsonPropertyName("forever")]
        public bool Forever { get; set; }
    }

    public partial class Surveillance_Camera
    {
        public static Surveillance_Camera FromJson(string json) => JsonConvert.DeserializeObject<Surveillance_Camera>(json);
    }
    #endregion
    #region X_Auth_Token_Response
    public partial class X_Auth_Token_Response
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
        public static X_Auth_Token_Response FromJson(string json) => JsonConvert.DeserializeObject<X_Auth_Token_Response>(json);
    }
    #endregion
    #region Fetch_Scenes_Api_Response
    public partial class Fetch_Scenes_Api_Response
    {
        [JsonPropertyName("content")]
        public Fetch_Scenes_Response_Content[] Content { get; set; }

        [JsonPropertyName("pageable")]
        public Pageable Pageable { get; set; }

        [JsonPropertyName("last")]
        public bool Last { get; set; }

        [JsonPropertyName("totalPages")]
        public long TotalPages { get; set; }

        [JsonPropertyName("totalElements")]
        public long TotalElements { get; set; }

        [JsonPropertyName("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonPropertyName("first")]
        public bool First { get; set; }

        [JsonPropertyName("sort")]
        public Sort Sort { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("number")]
        public long Number { get; set; }

        [JsonPropertyName("empty")]
        public bool Empty { get; set; }
    }

    public partial class Fetch_Scenes_Response_Content
    {
        [JsonPropertyName("sceneId")]
        public long SceneId { get; set; }
        public bool isLoaded { get; set; }
        public bool isVpn { get; set; }

        [JsonPropertyName("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonPropertyName("cameraId")]
        public long CameraId { get; set; }

        [JsonPropertyName("footageId")]
        public object FootageId { get; set; }

        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("cameraName")]
        public string CameraName { get; set; }

        [JsonPropertyName("description")]
        public object Description { get; set; }

        [JsonPropertyName("latitude")]
        public object Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public object Longitude { get; set; }

        [JsonPropertyName("floorPlanId")]
        public object FloorPlanId { get; set; }

        [JsonPropertyName("floorPlanX")]
        public object FloorPlanX { get; set; }

        [JsonPropertyName("floorPlanY")]
        public object FloorPlanY { get; set; }

        [JsonPropertyName("floorPlanAngle")]
        public object FloorPlanAngle { get; set; }

        [JsonPropertyName("thumbnail")]
        public string Thumbnail { get; set; }

        [JsonPropertyName("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Pageable
    {
        [JsonPropertyName("sort")]
        public Sort Sort { get; set; }

        [JsonPropertyName("pageNumber")]
        public long PageNumber { get; set; }

        [JsonPropertyName("pageSize")]
        public long PageSize { get; set; }

        [JsonPropertyName("offset")]
        public long Offset { get; set; }

        [JsonPropertyName("unpaged")]
        public bool Unpaged { get; set; }

        [JsonPropertyName("paged")]
        public bool Paged { get; set; }
    }

    public partial class Sort
    {
        [JsonPropertyName("unsorted")]
        public bool Unsorted { get; set; }

        [JsonPropertyName("sorted")]
        public bool Sorted { get; set; }

        [JsonPropertyName("empty")]
        public bool Empty { get; set; }
    }

    public partial class Fetch_Scenes_Api_Response
    {
        public static Fetch_Scenes_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Fetch_Scenes_Api_Response>(json);
    }
    #endregion
    #region Incident
    public partial class Incident
    {
        public string INCIDENT_ID { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? SEVERITY_SETUP_ID { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        public DateTime? CREATED_TIME { get; set; }
        public DateTime? ASSIGNED_TIME { get; set; }
        public DateTime? CLOSED_TIME { get; set; }
        public Geo_Location GEO_LOCATION { get; set; }
        public long? SCENE_ID { get; set; }
        public long? VIDEO_AI_INSTANCE_ID { get; set; }
        public Surveillance_Camera_Content CAMERA { get; set; }
        public string BLACKLISTED_PERSON_NAME { get; set; }
        public string BLACKLISTED_LICENSE_PLATE { get; set; }
        public string BLACKLISTED_LICENSE_FILE_URL { get; set; }
        public Sustainability_Incident SUSTAINABILITY_INCIDENT { get; set; }
        public Security_Incident SECURITY_INCIDENT { get; set; }
        public Mobility_Incident MOBILITY_INCIDENT { get; set; }
        public Living_Incident LIVING_INCIDENT { get; set; }
    }
    #endregion
    #region Incident_Type_With_Count
    public partial class Incident_Type_With_Count
    {
        public long COUNT { get; set; }
        public string INCIDENT_NAME { get; set; }
    }
    #endregion
    #region Sustainability_Incident
    public partial class Sustainability_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Security_Incident
    public partial class Security_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Mobility_Incident
    public partial class Mobility_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Living_Incident
    public partial class Living_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Floor_kpi_data
    public partial class Floor_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Floor_metadata FLOOR_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Floor_metadata
    public partial class Floor_metadata
    {
        public long FLOOR_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Geo_Location
    public partial class Geo_Location
    {
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
    }
    #endregion
    #region Kpi_chart_configuration
    public partial class Kpi_chart_configuration
    {
        public string KPI_CHART_CONFIGURATION_ID { get; set; }
        public int? KPI_ID { get; set; }
        public long? POSITION_SETUP_ID { get; set; }
        public int? CHART_ORDER { get; set; }
        public List<Setting> LIST_SETTING { get; set; }
        public List<Action_Button> LIST_ACTION_BUTTON { get; set; }
    }

    #endregion
    #region Action_Button
    public class Action_Button
    {
        public string ICON { get; set; }
        public string FUNCTIONALITY { get; set; }
        public string TOOLTIP { get; set; }
    }
    #endregion
    #region Dimension_chart_configuration
    public partial class Dimension_chart_configuration
    {
        public string DIMENSION_CHART_CONFIGURATION_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public long? POSITION_SETUP_ID { get; set; }
        public int? CHART_ORDER { get; set; }
        public List<Setting> LIST_SETTING { get; set; }
    }
    #endregion
    #region Setting
    public partial class Setting
    {
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
        public string ICON { get; set; }
    }
    #endregion
    #region Dimension_index_By_Level
    public class Dimension_index_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
    }
    #endregion
    #region Dimension_index
    public partial class Dimension_index
    {
        public DateTime RECORD_DATE { get; set; }
        public Dimension_metadata DIMENSION_METADATA { get; set; }
        public decimal VALUE { get; set; }
    }
    #endregion
    #region Dimension_metadata
    public partial class Dimension_metadata
    {
        public int DIMENSION_ID { get; set; }
        public long LEVEL_ID { get; set; }
        public long LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Floor_Kpi_Dialog_Data
    public partial class Floor_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Floor_Data_point> LIST_KPI_DATA { get; set; }
        public List<Wifi_signal> WIFI_SIGNAL_LIST { get; set; }
        public List<Wifi_signal_alert> WIFI_SIGNAL_ALERT_LIST { get; set; }
    }
    #endregion
    #region Floor_Data_point
    public class Floor_Data_point
    {
        public long? SEVERITY_TYPE_SETUP_ID { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    #endregion
    #region Dataset
    public class Dataset
    {
        public string LABEL { get; set; }
        public List<decimal?> LIST_POINT { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Entity_Kpi_Dialog_Data
    public partial class Entity_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Entity_Data_point> LIST_KPI_DATA { get; set; }
    }
    #endregion
    #region Entity_Data_point
    public partial class Entity_Data_point
    {
        public long? SEVERITY_TYPE_SETUP_ID { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    #endregion
    #region Organization_data_source_kpi_Simple
    public partial class Organization_data_source_kpi_Simple
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
    }
    #endregion

    #region Enums
    public enum Enum_Language
    {
        English = 0,
        French = 1,
        Arabic = 2
    }
    public enum Enum_BR_Codes
    {
        ER_0001, // ACCESS_DENIED
        ER_0002, // SESSION_INVALID
        ER_0003, // SESSION_EXPIRED
        BR_0000, // %1 already exists!
        BR_0001, // %1 With ID %2 Does not Exist!
        BR_0002, // Invalid Ticket!
        BR_0003, // Invalid Email
        BR_0004, // Report Not Found
        BR_0005, // User Not Found
        BR_0006, // Invalid Password! Re-enter and Try Again
        BR_0007, // User Inactive. Please contact support.
        BR_0008, // Email Sending Failed! Check your Email and Try Again.
        BR_0009, // Report Not Found!
        BR_0010, // The chosen organization does not exist.
        BR_0011, // One of the sites chosen does not exist.
        BR_0012, // One of the dimensions chosen does not exist.
        BR_0013, // One of the entities chosen does not exist.
        BR_0014, // The organization does not have access to this site.
        BR_0015, // Invalid Input
        BR_0016, // User does not belong to an organization
        BR_0017, // Organization does not have access to this site.
        BR_0018, // Organization does not have access to this dimension in the site.
        BR_0019, // The organization does not have access to this entity.
        BR_0020, // The user does not have access to this entity.
        BR_0021, // Organization not found.
        BR_0022, // You do not have access to this content.
        BR_0023, // You do not belong to an active organization. Please contact support..
        BR_0024, // Site already belongs to an organization.
        BR_0025, // Super Admins can't be deleted.
        BR_0026, // Upload Failed.
        BR_0027, // Delete Failed.
        BR_0028, // Invalid Credentials
        BR_0029, // User ID Cannot be Null!
        BR_0030, // An Error has Occured! Contact Support.
        BR_0031, // No OTP exists for this username. Try again.
        BR_0032, // Codes do not match! Try Again.
        BR_0033, // Only Admins Can Log In.
        BR_0034, // This feature is currently unavailable
        BR_0035, // Max user quota reached
        BR_0036, // Max admin quota reached
        BR_0037, // No LPR Engine Active
        BR_0038, // Invalid Credentials or Connection Url
        BR_0039, // Cannot Access Video AI
        BR_0040, // Video ai asset with Space asset ID %2 not found
        BR_0041, // Your account is deactivated. Please contact support.
        BR_0042, // No FR Engine Active
        BR_0043, // Request is being processed, try again later
        BR_0044, // Data for %1 on date %2 already exists
        BR_0045, // %1 Setup Not Found.
        BR_0046, // %1 Does Not Exist!
        BR_0047, // The user does not have access to any level.
        BR_0048, // Request resulting in error, jobId has been deleted, try again
        BR_0049, // Invalid Cloud Provider
        BR_0050, // Couldn't Retrieve Secret
        BR_0051, // Google API Token not found
        BR_0052, // An error has occured, please try again later
        BR_0053, // Failed to Assign Dates: %1
        BR_0054, // Delete failed for Kpi_chart_configuration: %1
        BR_0055, // Delete failed for Dimension_chart_configuration: %1
        BR_0056, // Delete failed for Specialized_chart_configuration: %1
        BR_0057, // Unable to send OTP. Please contact support.
        BR_0058, // Error in parsing the CSV file.
    }
    public enum Enum_Edit_Mode
    {
        Add,
        Update
    }
    public enum Enum_Timespan
    {
        X_HOURLY_COLLECTION,
        X_DAILY_COLLECTION,
        X_WEEKLY_COLLECTION,
        X_MONTHLY_COLLECTION,
        X_QUARTERLY_COLLECTION
    }
    public enum Enum_Dimension_Status
    {
        ENABLED = 0,
        DISABLED = 1,
        HIDDEN = 2
    }
    #endregion
    public partial class BLC
    {
        #region Members
        public DALC.IDALC _AppContext { get; set; }
        public List<Message> oList_Message { get; set; }
        public DALC.DALC_MONGODB _MongoDb { get; set; }
        public BLC_Initializer oBLC_Initializer { get; set; }
        #endregion
    }
    #region Message
    public partial class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region BLC_Initializer
    public partial class BLC_Initializer
    {
        #region Properties
        public long? User_ID { get; set; }
        public int? Owner_ID { get; set; }
        public Enum_Language Language { get; set; }
        public string Connection_String { get; set; }
        public string Messages_File_Path { get; set; }
        #endregion
    }
    #endregion
}