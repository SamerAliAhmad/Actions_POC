using System;
using Newtonsoft.Json;
using System.Configuration;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

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
    }

    #region Video_AI
    #region Scene_Object
    public partial class Scene_Object
    {
        [JsonPropertyName("sceneObjectId")]
        public long SceneObjectId { get; set; }

        [JsonPropertyName("objectType")]
        public string ObjectType { get; set; }

        [JsonPropertyName("cameraId")]
        public long CameraId { get; set; }

        [JsonPropertyName("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonPropertyName("x")]
        public long X { get; set; }

        [JsonPropertyName("y")]
        public long Y { get; set; }

        [JsonPropertyName("w")]
        public long W { get; set; }

        [JsonPropertyName("h")]
        public long H { get; set; }

        [JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }

        [JsonPropertyName("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Metadata
    {
        [JsonPropertyName("colors")]
        public string[] Colors { get; set; }
    }

    public partial class Scene_Object
    {
        public static Scene_Object[] FromJson(string json) => JsonConvert.DeserializeObject<Scene_Object[]>(json);
    }
    #endregion
    #region Scene_Details
    public partial class Scene_Details
    {
        [JsonPropertyName("sceneId")]
        public long SceneId { get; set; }

        [JsonPropertyName("cameraId")]
        public long CameraId { get; set; }

        [JsonPropertyName("footageId")]
        public object FootageId { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("datetime")]
        public DateTimeOffset Datetime { get; set; }

        [JsonPropertyName("file")]
        public string File { get; set; }

        [JsonPropertyName("frameIndex")]
        public long FrameIndex { get; set; }

        [JsonPropertyName("camera")]
        public Surveillance_Camera_Content Camera { get; set; }

        [JsonPropertyName("latitude")]
        public object Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public object Longitude { get; set; }

        [JsonPropertyName("hashtagId")]
        public object[] HashtagId { get; set; }

        [JsonPropertyName("hashtags")]
        public object[] Hashtags { get; set; }

        [JsonPropertyName("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Scene_Details
    {
        public static Scene_Details FromJson(string json) => JsonConvert.DeserializeObject<Scene_Details>(json);
    }
    #endregion
    #region Query_Validator
    public partial class Query_Validator
    {
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

    public partial class Query_Validator
    {
        public static Query_Validator FromJson(string json) => JsonConvert.DeserializeObject<Query_Validator>(json);
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
    #region Geo_Location
    public partial class Geo_Location
    {
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
    }
    #endregion
    #region Incident_With_Count
    public partial class Incident_With_Count
    {
        public long COUNT { get; set; }
        public List<Incident> List_Incident { get; set; }
    }
    #endregion
    #region Entity_Incidents
    public partial class Entity_Incidents
    {
        public Incident_With_Count LIST_FIRE_ALARM_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_ACCESS_CONTROL_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_ABANDONED_OBJECT_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_SUSPICIOUS_BEHAVIOR_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_BLACKLISTED_FACE_INCIDENT_WITH_COUNT { get; set; }
        public Incident_With_Count LIST_BLACKLISTED_LICENSE_PLATE_INCIDENT_WITH_COUNT { get; set; }
    }
    #endregion



    #region GeoData
    public partial class GeoData
    {
        public string GEODATA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
        public DateTime? DATE_START { get; set; }
        public DateTime? DATE_END { get; set; }
        public List<Data> DATA_LIST { get; set; }
    }
    #endregion
    #region Data
    public partial class Data
    {
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string VALUE { get; set; }
    }
    #endregion
    #region District_kpi_data
    public partial class District_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public District_metadata DISTRICT_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region District_metadata
    public partial class District_metadata
    {
        public long DISTRICT_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Area_kpi_data
    public partial class Area_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Area_metadata AREA_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Area_metadata
    public partial class Area_metadata
    {
        public long AREA_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Site_kpi_data
    public partial class Site_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Site_metadata SITE_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Site_metadata
    public partial class Site_metadata
    {
        public long SITE_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Entity_kpi_data
    public partial class Entity_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Entity_metadata ENTITY_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Entity_metadata
    public partial class Entity_metadata
    {
        public long ENTITY_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
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
    #region Space_kpi_data
    public partial class Space_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Space_metadata SPACE_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Space_metadata
    public partial class Space_metadata
    {
        public long SPACE_ID { get; set; }
        public long FLOOR_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Location
    public partial class Location
    {
        public string type { get; set; }
        public List<decimal?> coordinates { get; set; }
    }
    #endregion

    #region Enum_Timespan
    public enum Enum_Timespan
    {
        X_HOURLY_COLLECTION,
        X_DAILY_COLLECTION,
        X_WEEKLY_COLLECTION,
        X_MONTHLY_COLLECTION,
        X_QUARTERLY_COLLECTION
    }
    #endregion

    #region District
    public partial class District
    {
        public List<Area> List_Area { get; set; }
    }
    #endregion
    #region Area
    public partial class Area
    {
        public List<Site> List_Site { get; set; }
    }
    #endregion
    #region Site
    public partial class Site
    {
        public List<Entity> List_Entity { get; set; }
    }
    #endregion
    #region Space
    public partial class Space
    {
        public bool HAS_VIDEO_AI_ASSETS { get; set; }
    }
    #endregion

    #endregion

    #region Site_Kpi_Dialog_Data
    public class Site_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    #endregion
    #region Area_Kpi_Dialog_Data
    public class Area_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    #endregion
    #region District_Kpi_Dialog_Data
    public class District_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    #endregion
    #region Entity_Kpi_Dialog_Data
    public class Entity_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Entity_Data_point> LIST_KPI_DATA { get; set; }
    }
    #endregion
    #region Floor_Kpi_Dialog_Data
    public class Floor_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Floor_Data_point> LIST_KPI_DATA { get; set; }
        public List<Wifi_signal> WIFI_SIGNAL_LIST { get; set; }
        public List<Wifi_signal_alert> WIFI_SIGNAL_ALERT_LIST { get; set; }
    }
    #endregion
    #region Entity_Data_point
    public class Entity_Data_point
    {
        public long? SEVERITY_TYPE_SETUP_ID { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
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
    #region Data_point
    public class Data_point
    {
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

    #region Kpi_chart_configuration
    public partial class Kpi_chart_configuration
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
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
    #region Setting
    public partial class Setting
    {
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
        public string ICON { get; set; }
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

    #region Business
    public class Business
    {
        public string BUSINESS_ID { get; set; }
        public string ICON { get; set; }
        public string ICON_BACKGROUND_COLOR { get; set; }
        public string ICON_MASK_BASE_URI { get; set; }
        public string NAME { get; set; }
        public string PLACE_ID { get; set; }
        public string REFERENCE { get; set; }
        public string SCOPE { get; set; }
        public List<string> LIST_BUSINESS_CATEGORY { get; set; }
        public string BUSINESS_NICHE { get; set; }
        public string VICINITY { get; set; }
        public string BUSINESS_STATUS { get; set; }
        public decimal? RATING { get; set; }
        public long? USER_RATINGS_TOTAL { get; set; }
        public bool? OPEN_NOW { get; set; }
        public long? PRICE_LEVEL { get; set; }
        public string COMPOUND_CODE { get; set; }
        public string GLOBAL_CODE { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    #endregion
    #region Bylaw_Complaint
    public partial class Bylaw_Complaint
    {
        public string BYLAW_COMPLAINT_ID { get; set; }
        public string ROW_ID { get; set; }
        public string YEAR { get; set; }
        public string MONTH { get; set; }
        public string COMPLAINT_CATEGORY { get; set; }
        public string TYPE_OF_COMPLAINT { get; set; }
        public DateTime? DATE_CREATED { get; set; }
        public string WAS_CANNABIS_INVOLVED { get; set; }
        public string OFFICER_INITIATED { get; set; }
        public string INFRACTION_STATUS { get; set; }
        public string NEIGHBOURHOOD_ID { get; set; }
        public string NEIGHBOURHOOD { get; set; }
        public string FULL_NAME_OF_STREET { get; set; }
        public string COUNT { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    #endregion
    #region Public_Event
    public partial class Public_Event
    {
        public string PUBLIC_EVENT_ID { get; set; }
        public string TITLE { get; set; }
        public string DATE_AND_TIME { get; set; }
        public DateTime? START_TIME { get; set; }
        public DateTime? END_TIME { get; set; }
        public string CITY_OR_TOWN { get; set; }
        public string NEIGHBOURHOOD_ID { get; set; }
        public string NEIGHBOURHOOD { get; set; }
        public string WHERE { get; set; }
        public string COST { get; set; }
        public string EVENT_CATEGORY { get; set; }
        public string EVENT_TYPE { get; set; }
        public string EVENT_URL { get; set; }
        public string EVENT_VENUE { get; set; }
        public string EVENT_EXTERNAL_ID { get; set; }
        public string WHERE_TO_PURCHASE_TICKETS { get; set; }
        public string TICKETS_PHONE { get; set; }
        public string CATEGORY_CALENDAR { get; set; }
        public string WEB_LINK { get; set; }
        public string PUBLIC_ENGAGEMENT_CATEGORY { get; set; }
        public string SHORT_DESCRIPTION { get; set; }
        public string PROJECT_NAME { get; set; }
        public string ADDITIONAL_INFORMATION { get; set; }
        public string NOTES_1 { get; set; }
        public string NOTES_2 { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    #endregion

    #region Visitor_Origins
    public class Visitor_Origins
    {
        public List<Ext_study_zone_With_Count> LIST_EXT_STUDY_ZONE_WITH_COUNT { get; set; }
        public string GEOJSON { get; set; }
    }
    #endregion
    #region Ext_study_zone_With_Count
    public class Ext_study_zone_With_Count
    {
        public Ext_study_zone EXT_STUDY_ZONE { get; set; }
        public decimal? COUNT { get; set; }
    }
    #endregion
    #region  Visitor_Count_By_Level
    public class Visitor_Count_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public decimal? VISITOR_COUNT { get; set; }
    }
    #endregion
    #region  Organization_data_source_kpi_By_Level
    public class Organization_data_source_kpi_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public decimal? VALUE { get; set; }
    }
    #endregion

    #region Kpi_Value_By_Date
    public class Kpi_Value_By_Date
    {
        public DateTime? RECORD_DATE { get; set; }
        public decimal? VALUE { get; set; }
    }
    #endregion

    #region Alert
    public partial class Alert
    {
        public string ALERT_ID { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public decimal? ALERT_VALUE { get; set; }
        public decimal? VALUE_PASSED { get; set; }
        public long? VALUE_TYPE_SETUP_ID { get; set; }
        public long? OPERATION_TYPE_SETUP_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public object Object { get; set; }
    }
    #endregion
    #region Level_id_with_percent
    public partial class Level_id_with_percent
    {
        public Site Site { get; set; }
        public Area Area { get; set; }
        public District District { get; set; }
        public long? LEVEL_ID { get; set; }
        public decimal? VALUE { get; set; }
        public decimal? PERCENT_INCREASE { get; set; }
    }
    #endregion

    #region Organization_Data_Access
    public class Organization_Data_Access
    {
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
        public List<District_kpi> LIST_DISTRICT_KPI { get; set; }
        public List<Area_kpi> LIST_AREA_KPI { get; set; }
        public List<Site_kpi> LIST_SITE_KPI { get; set; }
        public List<Entity_kpi> LIST_ENTITY_KPI { get; set; }
        public List<District> LIST_DISTRICT { get; set; }
        public List<Area> LIST_AREA { get; set; }
        public List<Site> LIST_SITE { get; set; }
        public List<Entity> LIST_ENTITY { get; set; }
    }
    #endregion
    #region User_Data_Access
    public class User_Data_Access
    {
        public List<Organization_data_source_kpi> LIST_ORGANIZATION_DATA_SOURCE_KPI { get; set; }
        public List<District_kpi_user_access> LIST_DISTRICT_KPI_USER_ACCESS { get; set; }
        public List<Area_kpi_user_access> LIST_AREA_KPI_USER_ACCESS { get; set; }
        public List<Site_kpi_user_access> LIST_SITE_KPI_USER_ACCESS { get; set; }
        public List<Entity_kpi_user_access> LIST_ENTITY_KPI_USER_ACCESS { get; set; }
        public List<District> LIST_DISTRICT { get; set; }
        public List<Area> LIST_AREA { get; set; }
        public List<Site> LIST_SITE { get; set; }
        public List<Entity> LIST_ENTITY { get; set; }
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
    #region Wifi_signal_data
    public partial class Wifi_signal_data
    {
        public List<Wifi_signal> WIFI_SIGNAL_LIST { get; set; }
        public List<Wifi_signal_alert> WIFI_SIGNAL_ALERT_LIST { get; set; }
    }
    #endregion
    #region Space_asset_id_With_Count
    public partial class Space_asset_id_With_Count
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? COUNT { get; set; }
    }
    #endregion
    #region Best_And_Worst_Object
    public partial class Best_And_Worst_Object
    {
        public Performance_object Best_Performance_object { get; set; }
        public Performance_object Worst_Performance_object { get; set; }
    }
    #endregion
    #region Performance_object
    public partial class Performance_object
    {
        public Entity Entity { get; set; }
        public Floor Floor { get; set; }
        public Space Space { get; set; }
        public Space_asset Space_asset { get; set; }
        public decimal? value { get; set; }
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

