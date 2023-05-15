using Microsoft.AspNetCore.Hosting.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    }
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
    #region Geo_Location
    public partial class Geo_Location
    {
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
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
        public Geo_Location Geo_Location { get; set; }
        public long? SCENE_ID { get; set; }
        public long? VIDEO_AI_INSTANCE_ID { get; set; }
        public Surveillance_Camera_Content CAMERA { get; set; }
        public string BLACKLISTED_PERSON_NAME { get; set; }
        public string BLACKLISTED_LICENSE_PLATE { get; set; }
        public string BLACKLISTED_LICENSE_FILE_URL { get; set; }
        public Sustainability_Incident Sustainability_Incident { get; set; }
        public Security_Incident Security_Incident { get; set; }
        public Mobility_Incident Mobility_Incident { get; set; }
        public Living_Incident Living_Incident { get; set; }
    }
    #endregion
    #region Incident_With_Count
    public partial class Incident_With_Count
    {
        public long COUNT { get; set; }
        public List<Incident> List_Incident { get; set; }
    }
    #endregion
    #region Pageable
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
    #endregion
    #region Sort
    public partial class Sort
    {
        [JsonPropertyName("unsorted")]
        public bool Unsorted { get; set; }

        [JsonPropertyName("sorted")]
        public bool Sorted { get; set; }

        [JsonPropertyName("empty")]
        public bool Empty { get; set; }
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

    public partial class BLC
    {
        #region Members
        public DALC.DALC_MONGODB _MongoDb { get; set; }
        public IServer oRedisServer { get; set; }
        #endregion
    }
}