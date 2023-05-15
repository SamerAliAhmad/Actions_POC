using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BLC
{
    public static class Global
    {
        public static string User_ID = "USER_ID";
        public static string Owner_ID = "OWNER_ID";
        public static string Start_Date = "START_DATE";
        public static string Ticket_Separator = "[~!@]";
        public static string Start_Minute = "START_MINUTE";
        public static string Session_Period = "SESSION_PERIOD";
    }

    #region Entities
    #region Report_Management
    #endregion
    #region Video_AI
    #region Scene_Info
    public partial class Scene_Info
    {
        public Scene_Details SCENE_DETAILS { get; set; }
        public List<Scene_Object> SCENE_OBJECT_LIST { get; set; }
    }
    #endregion
    #region Stream_Data
    public partial class Stream_Data
    {
        public List<string> List_Search_type { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    #endregion
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
    #region Camera_Lines
    public partial class Camera_Lines
    {
        public Surveillance_Camera_Content Camera { get; set; }
        public List<Get_Line_Sets_Response> LineSets { get; set; }
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
        public Nvr Nvr { get; set; }

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
    #region Vehicle_Counting_Table_Data
    public partial class Vehicle_Counting_Table_Data
    {
        public string TIME { get; set; }
        public int TOTAL_IN { get; set; }
        public int TOTAL_OUT { get; set; }
        public int TOTAL_OCCUPANCY { get; set; }
        public int BICYCLE_IN { get; set; }
        public int BICYCLE_OCCUPANCY { get; set; }
        public int BICYCLE_OUT { get; set; }
        public int BUS_IN { get; set; }
        public int BUS_OCCUPANCY { get; set; }
        public int BUS_OUT { get; set; }
        public int CAR_IN { get; set; }
        public int CAR_OCCUPANCY { get; set; }
        public int CAR_OUT { get; set; }
        public int MOTORBIKE_IN { get; set; }
        public int MOTORBIKE_OCCUPANCY { get; set; }
        public int MOTORBIKE_OUT { get; set; }
        public int TRUCK_IN { get; set; }
        public int TRUCK_OCCUPANCY { get; set; }
        public int TRUCK_OUT { get; set; }
    }
    #endregion
    #region Fetch_Scenes_Response
    public partial class Fetch_Scenes_Response
    {
        public Fetch_Scenes_Api_Response Fetch_Scenes_Api_Response { get; set; }
        public bool IS_ERROR { get; set; }
        public string ERROR_MESSAGE { get; set; }
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
    #region Get_Countings_Response
    public partial class Get_Countings_Response
    {
        public string MEASURE { get; set; }
        public string DATETIME { get; set; }
        public string TYPE { get; set; }
        public int OBJECTIN { get; set; }
        public int OBJECTOUT { get; set; }
        public int OCCUPANCY { get; set; }
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
    #region Fetch_Face_Target_Api_Response
    public partial class Fetch_Face_Target_Api_Response
    {
        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("content")]
        public Fetch_Face_Target_Api_Response_Content[] Content { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }
    public partial class Fetch_Face_Target_Api_Response
    {
        public static Fetch_Face_Target_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Fetch_Face_Target_Api_Response>(json);
    }

    public partial class Fetch_Face_Target_Api_Response_Content
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("faceTargetId")]
        public string FaceTargetId { get; set; }

        [JsonProperty("category")]
        public Face_Target_Api_Response_Category Category { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthYear")]
        public long? BirthYear { get; set; }

        [JsonProperty("driverLicenseNumber")]
        public string DriverLicenseNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("keys")]
        public Face_Target_Key_Api_Response[] Keys { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }
    public partial class Face_Target_Api_Response_Category
    {
        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }

        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("faceCategoryId")]
        public string FaceCategoryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }

    #endregion
    #region Fetch_Face_Targets_Response
    public partial class Fetch_Face_Targets_Response
    {
        public long TotalElements { get; set; }

        public long TotalPages { get; set; }

        public bool First { get; set; }

        public Sort Sort { get; set; }

        public long NumberOfElements { get; set; }

        public bool Last { get; set; }

        public Pageable Pageable { get; set; }

        public long Size { get; set; }

        public Fetch_Face_Target_Response_Content[] Content { get; set; }

        public long Number { get; set; }

        public bool Empty { get; set; }
    }

    public partial class Fetch_Face_Target_Response_Content
    {
        public string CreateDate { get; set; }

        public string UpdateDate { get; set; }

        public string FaceTargetId { get; set; }

        public Face_Target_Response_Category Category { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public long? BirthYear { get; set; }

        public string DriverLicenseNumber { get; set; }

        public string Description { get; set; }

        public Face_Target_Key_Response[] Keys { get; set; }

        public bool Deleted { get; set; }

        public long AinvrId { get; set; }
    }

    public partial class Face_Target_Response_Category
    {
        public long AinvrId { get; set; }

        public string CreateDate { get; set; }

        public string FaceCategoryId { get; set; }

        public string Name { get; set; }

        public string UpdateDate { get; set; }
    }

    #endregion
    #region Fetch_Facial_Recognition_Api_Reponse
    public partial class Fetch_Facial_Recognition_Api_Reponse
    {
        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("content")]
        public Fetch_Facial_Recognition_Api_Response_Content[] Content { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public partial class Fetch_Facial_Recognition_Api_Response_Content
    {
        [JsonProperty("faceMatchId")]
        public long FaceMatchId { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("faceKey")]
        public Face_Key_Api_Response FaceKey { get; set; }

        [JsonProperty("faceTarget")]
        public Fetch_Face_Target_Api_Response_Content FaceTarget { get; set; }

        [JsonProperty("faceTargetKey")]
        public Face_Target_Key_Api_Response FaceTargetKey { get; set; }

        [JsonProperty("similarity")]
        public double Similarity { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Face_Key_Api_Response
    {
        [JsonProperty("faceKeyId")]
        public long FaceKeyId { get; set; }

        [JsonProperty("sceneId")]
        public long SceneId { get; set; }

        [JsonProperty("cameraId")]
        public long CameraId { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("footageId")]
        public long? FootageId { get; set; }

        [JsonProperty("age")]
        public long Age { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public partial class Face_Target_Key_Api_Response
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("faceTargetKeyId")]
        public string FaceTargetKeyId { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("feature")]
        public long[] Feature { get; set; }

        [JsonProperty("similarity")]
        public double Similarity { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Fetch_Facial_Recognition_Api_Reponse
    {
        public static Fetch_Facial_Recognition_Api_Reponse FromJson(string json) => JsonConvert.DeserializeObject<Fetch_Facial_Recognition_Api_Reponse>(json);
    }
    #endregion
    #region Fetch_Facial_Recognition_Reponse
    public partial class Fetch_Facial_Recognition_Reponse
    {
        public long TotalElements { get; set; }

        public long TotalPages { get; set; }

        public bool First { get; set; }

        public Sort Sort { get; set; }

        public long NumberOfElements { get; set; }

        public bool Last { get; set; }

        public Pageable Pageable { get; set; }

        public long Size { get; set; }

        public Fetch_Facial_Recognition_Response_Content[] Content { get; set; }

        public long Number { get; set; }

        public bool Empty { get; set; }
    }

    public partial class Fetch_Facial_Recognition_Response_Content
    {
        public long FaceMatchId { get; set; }

        public bool isVpn { get; set; }

        public bool isLoaded { get; set; }

        public string Datetime { get; set; }

        public Face_Key_Response FaceKey { get; set; }

        public Fetch_Face_Target_Response_Content FaceTarget { get; set; }

        public Face_Target_Key_Response FaceTargetKey { get; set; }

        public double Similarity { get; set; }

        public long AinvrId { get; set; }
    }

    public partial class Face_Key_Response
    {
        public long FaceKeyId { get; set; }

        public long SceneId { get; set; }

        public long CameraId { get; set; }

        public string Datetime { get; set; }

        public string File { get; set; }

        public string Position { get; set; }

        public double Confidence { get; set; }

        public long? FootageId { get; set; }

        public long Age { get; set; }

        public string AgeGroup { get; set; }

        public string Gender { get; set; }
    }

    public partial class Face_Target_Key_Response
    {
        public string CreateDate { get; set; }

        public string UpdateDate { get; set; }

        public string FaceTargetKeyId { get; set; }

        public string File { get; set; }

        public long[] Feature { get; set; }

        public double Similarity { get; set; }

        public long AinvrId { get; set; }
    }
    #endregion
    #region Fetch_License_Plate_Targets_Response
    public class Fetch_License_Plate_Targets_Response
    {
        public Fetch_License_Plate_Targets_Response_Content[] Content { get; set; }

        public Pageable Pageable { get; set; }

        public bool Last { get; set; }

        public long TotalPages { get; set; }

        public long TotalElements { get; set; }

        public Sort Sort { get; set; }

        public long Size { get; set; }

        public long Number { get; set; }

        public bool First { get; set; }

        public long NumberOfElements { get; set; }

        public bool Empty { get; set; }
    }

    public partial class Fetch_License_Plate_Targets_Response_Content
    {
        public DateTimeOffset CreateDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

        public string LicensePlateTargetId { get; set; }

        public License_Plate_Category Category { get; set; }

        public string PlateNumber { get; set; }

        public string Description { get; set; }

        public string VehicleOwner { get; set; }

        public string Address { get; set; }

        public string RegistrationDate { get; set; }

        public long AinvrId { get; set; }
    }

    public partial class License_Plate_Category
    {
        public DateTimeOffset CreateDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }

        public string LicensePlateCategoryId { get; set; }

        public string Name { get; set; }

        public long AinvrId { get; set; }
    }
    #endregion
    #region Fetch_License_Plate_Targets_Api_Response
    public partial class Fetch_License_Plate_Targets_Api_Response
    {
        [JsonProperty("content")]
        public Fetch_License_Plate_Targets_Api_Response_Content[] Content { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        public static Fetch_License_Plate_Targets_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Fetch_License_Plate_Targets_Api_Response>(json);
    }

    public partial class Fetch_License_Plate_Targets_Api_Response_Content
    {
        [JsonProperty("createDate")]
        public DateTimeOffset CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public DateTimeOffset UpdateDate { get; set; }

        [JsonProperty("licensePlateTargetId")]
        public string LicensePlateTargetId { get; set; }

        [JsonProperty("category")]
        public License_Plate_Category_Api_Response Category { get; set; }

        [JsonProperty("plateNumber")]
        public string PlateNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("vehicleOwner")]
        public string VehicleOwner { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class License_Plate_Category_Api_Response
    {
        [JsonProperty("createDate")]
        public DateTimeOffset CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public DateTimeOffset UpdateDate { get; set; }

        [JsonProperty("licensePlateCategoryId")]
        public string LicensePlateCategoryId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }

    #endregion
    #region Fetch_License_Plate_Recognition_Response

    public partial class Fetch_License_Plate_Recognition_Response
    {
        public Fetch_License_Plate_Recognition_Response_Content[] List_Fetch_License_Plate_Recognition_Response_Content { get; set; }
        public int TotalElements { get; set; }
    }

    public partial class Fetch_License_Plate_Recognition_Response_Content
    {
        public bool isVpn { get; set; }
        public bool isLoaded { get; set; }
        public long LicensePlateId { get; set; }

        public long CameraId { get; set; }

        public long? FootageId { get; set; }

        public Fetch_License_Plate_Targets_Response_Content Target { get; set; }

        public long SceneId { get; set; }

        public string Datetime { get; set; }

        public string Type { get; set; }

        public string Characters { get; set; }

        public double Confidence { get; set; }

        public long X { get; set; }

        public long Y { get; set; }

        public long W { get; set; }

        public long H { get; set; }

        public string File { get; set; }

        public string Property { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string VehicleType { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public bool Modified { get; set; }

        public long AinvrId { get; set; }
    }
    #endregion
    #region Detect_Face_Api_Response
    public partial class Detect_Face_Api_Response
    {
        [JsonProperty("position")]
        public Position_Api_Response Position { get; set; }

        [JsonProperty("descriptor")]
        public string Descriptor { get; set; }

        [JsonProperty("confidence")]
        public double Confidence { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("age")]
        public long Age { get; set; }

        [JsonProperty("ageGroup")]
        public string AgeGroup { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }

    public partial class Position_Api_Response
    {
        [JsonProperty("x")]
        public long X { get; set; }

        [JsonProperty("y")]
        public long Y { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }
    }

    public partial class Detect_Face_Api_Response
    {
        public static Detect_Face_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Detect_Face_Api_Response>(json);
    }
    #endregion
    #region Detect_Face_Response
    public partial class Detect_Face_Response
    {
        public Position_Response Position { get; set; }

        public string Descriptor { get; set; }

        public double Confidence { get; set; }

        public string Path { get; set; }

        public long Age { get; set; }

        public string AgeGroup { get; set; }

        public string Gender { get; set; }
    }

    public partial class Position_Response
    {
        public long X { get; set; }

        public long Y { get; set; }

        public long W { get; set; }

        public long H { get; set; }
    }
    #endregion
    #region Search_Face_Target_Key_Response
    public partial class Search_Face_Target_Key_Response
    {
        public Fetch_Face_Target_Response_Content FaceTarget { get; set; }

        public Face_Target_Key_Response FaceTargetKey { get; set; }

    }
    #endregion
    #region Search_Face_Target_Key_Response_List
    public class Search_Face_Target_Key_Response_List
    {
        public List<Search_Face_Target_Key_Response> SEARCH_FACE_TARGET_KEY_RESPONSE_LIST { get; set; }
        public int TOTAL_ELEMENTS { get; set; }
    }
    #endregion
    #region Face_Key_Response_List
    public class Face_Key_Response_List
    {
        public List<Face_Key_Response> FACET_KEY_RESPONSE_LIST { get; set; }
        public int TOTAL_ELEMENTS { get; set; }
    }
    #endregion
    #region Get_Vehicle_Types_Response
    public partial class Get_Vehicle_Types_Response
    {
        public List<Engine_Object_Content> Content { get; set; }
        public Pageable Pageable { get; set; }
        public bool Last { get; set; }
        public long TotalPages { get; set; }
        public long TotalElements { get; set; }
        public long NumberOfElements { get; set; }
        public bool First { get; set; }
        public Sort Sort { get; set; }
        public long Size { get; set; }
        public long Number { get; set; }
        public bool Empty { get; set; }
    }

    public partial class Engine_Object_Content
    {
        public long EngineObjectId { get; set; }
        public string Engine { get; set; }
        public List<string> EngineObject { get; set; }
    }
    public partial class Get_Line_Sets_Response
    {
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
        public int LineSetId { get; set; }
        public int CameraId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public int AiNvrId { get; set; }
    }
    #endregion
    #region Vehicle_Counting
    public partial class Vehicle_Counting
    {
        public List<Get_Countings_Response> GET_COUNTINGS_RESPONSE_LIST { get; set; }
        public List<Vehicle_Counting_Table_Data> VEHICLE_COUNTING_TABLE_DATA_LIST { get; set; }
    }
    #endregion
    #region Video_ai_asset
    public partial class Video_ai_asset
    {
        public bool IS_ERROR { get; set; }
        public Surveillance_Camera_Content Surveillance_Camera_Content { get; set; }
    }
    #endregion
    #region Video_ai_assets_with_engine_assets
    public class Video_ai_assets_with_engine_assets
    {
        public List<Video_ai_asset> VIDEO_AI_ASSET_WITH_FLAG_LIST { get; set; }
        public List<Surveillance_Camera_Content> ASSET_LIST { get; set; }
    }
    #endregion
    #region Video_ai_instance_Credentials
    public class Video_ai_instance_Credentials
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
    }
    #endregion
    #region Sites_and_Entities
    public class Sites_and_Entities
    {
        public List<Site> SITES { get; set; }
        public List<Entity> ENTITIES { get; set; }
    }
    #endregion
    #region Video_ai_instance_with_connection_flag
    public class Video_ai_instance_with_connection_flag
    {
        public Video_ai_instance oVideo_ai_instance { get; set; }
        public bool IS_FORCE_CONNECTION { get; set; }
        public string RESPONSE_MESSAGE { get; set; }
    }
    #endregion
    #region Change_Video_ai_instance_Password_Response
    public partial class Change_Video_ai_instance_Password_Response
    {
        public bool SUCCESSFUL_PASSWORD_CHANGE { get; set; }
        public bool IS_FORCE_CONNECTION { get; set; }
        public string RESPONSE_MESSAGE { get; set; }
    }
    #endregion
    #region Fetch_Alerts_Api_Response
    public partial class Fetch_Alerts_Api_Response
    {
        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("content")]
        public Fetch_Alerts_Api_Response_Content[] Content { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }

    public partial class Fetch_Alerts_Api_Response_Content
    {
        [JsonProperty("alertId")]
        public long AlertId { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("alertRule")]
        public Alert_Rule_Api_Response Alert_Rule { get; set; }

        [JsonProperty("alertRuleId")]
        public string AlertRuleId { get; set; }

        [JsonProperty("alertType")]
        public string AlertType { get; set; }

        [JsonProperty("snapshot")]
        public string Snapshot { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        [JsonProperty("camera")]
        public Surveillance_Camera_Content Camera { get; set; }

        [JsonProperty("cameraId")]
        public long CameraId { get; set; }

        [JsonProperty("sceneId")]
        public long SceneId { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("latitude")]
        public long? Latitude { get; set; }

        [JsonProperty("longitude")]
        public long? Longitude { get; set; }

        [JsonProperty("alertName")]
        public string AlertName { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Alert_Rule_Api_Response
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("alertRuleId")]
        public string AlertRuleId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("alertType")]
        public string AlertType { get; set; }

        [JsonProperty("alertName")]
        public string AlertName { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("schedule")]
        public Schedule Schedule { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("isEnabled")]
        public bool IsEnabled { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }
    public partial class Nvr
    {
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        [JsonProperty("nvrId")]
        public string NvrId { get; set; }

        [JsonProperty("brand")]
        public Brand_Api_Response Brand { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }

        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("ainvrId")]
        public long AinvrId { get; set; }
    }

    public partial class Brand_Api_Response
    {
        [JsonProperty("brandId")]
        public long BrandId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public partial class Fetch_Alerts_Api_Response
    {
        public static Fetch_Alerts_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Fetch_Alerts_Api_Response>(json);
    }

    #endregion
    #region Fetch_Alerts_Response
    public partial class Fetch_Alerts_Response
    {
        public long TotalElements { get; set; }

        public long TotalPages { get; set; }

        public bool First { get; set; }

        public Sort Sort { get; set; }

        public long NumberOfElements { get; set; }

        public bool Last { get; set; }

        public Pageable Pageable { get; set; }

        public long Size { get; set; }

        public Fetch_Alerts_Response_Content[] Content { get; set; }

        public long Number { get; set; }

        public bool Empty { get; set; }
    }

    public partial class Fetch_Alerts_Response_Content
    {
        public long AlertId { get; set; }

        public string Datetime { get; set; }

        public Alert_Rule_Api_Response Alert_Rule { get; set; }

        public string AlertRuleId { get; set; }

        public string AlertType { get; set; }

        public string Snapshot { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public Surveillance_Camera_Content Camera { get; set; }

        public long CameraId { get; set; }

        public long SceneId { get; set; }

        public string Metadata { get; set; }

        public long? Latitude { get; set; }

        public long? Longitude { get; set; }

        public string AlertName { get; set; }

        public long AinvrId { get; set; }
    }

    public partial class Alert_Rule_Response
    {
        public string CreateDate { get; set; }

        public string UpdateDate { get; set; }

        public string AlertRuleId { get; set; }

        public string Description { get; set; }

        public string AlertType { get; set; }

        public string AlertName { get; set; }

        public string Condition { get; set; }

        public Schedule Schedule { get; set; }

        public string Trigger { get; set; }

        public bool IsEnabled { get; set; }

        public long AinvrId { get; set; }
    }
    #endregion
    #region Fetch_Alert_Rules_Api_Response
    public partial class Fetch_Alert_Rules_Api_Response
    {
        [JsonProperty("totalElements")]
        public long TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public long TotalPages { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("numberOfElements")]
        public long NumberOfElements { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("pageable")]
        public Pageable Pageable { get; set; }

        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonProperty("content")]
        public Alert_Rule_Api_Response[] Content { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }
    }
    #endregion

    #endregion
    #region User Management
    #region Super_Admin_Data
    public partial class Super_Admin_Data
    {
        public int NUMBER_OF_USERS { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public List<Entity> ENTITY_LIST { get; set; }
    }
    #endregion
    #endregion
    #region Organization Management
    #endregion
    #region Uploaded Images
    #region Organization_image
    public partial class Organization_image
    {
        public string IMAGE_GCP_URL { get; set; }
    }
    public partial class Organization
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    public partial class Default_settings
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    #endregion
    #region Default Settings Image Extra Entities
    public partial class Default_settings_image
    {
        public string IMAGE_GCP_URL { get; set; }
    }
    #endregion
    #endregion
    #region Log Management
    #region Log
    public partial class Log
    {
        public User User { get; set; }
        public Site Site { get; set; }
        public Entity Entity { get; set; }
    }
    #endregion
    #endregion
    #region Space
    public partial class Space
    {
        public bool HAS_VIDEO_AI_ASSETS { get; set; }
        public List<Space_asset> List_Space_asset { get; set; }
    }
    #endregion
    #region Space_asset
    public partial class Space_asset
    {
        public List<Incident> List_Space_asset_energy_incident { get; set; }
        public List<Incident> List_Space_asset_security_incident { get; set; }
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
        public int SITE_ID { get; set; }
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
    #region Log
    public partial class Log
    {
        public string LOG_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ACCESS_TYPE_SETUP_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public int? SITE_ID { get; set; }
        public string MESSAGE { get; set; }
        public DateTime? ENTRY_DATE { get; set; }
        public int? ORGANIZATION_ID { get; set; }
    }
    #endregion
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
        public BLC_Initializer oBLC_Initializer { get; set; }
        #endregion
    }
    #region Message
    public class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region BLC_Initializer
    public class BLC_Initializer
    {
        #region Properties
        public long? User_ID { get; set; }
        public int? Owner_ID { get; set; }
        public string Connection_String { get; set; }
        public string Messages_File_Path { get; set; }
        public Enum_Language Language { get; set; }
        #endregion
    }
    #endregion
}
