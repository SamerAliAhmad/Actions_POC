using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Vaidio_Auth_Token
    public class Params_Get_Vaidio_Auth_Token
    {
        public Video_ai_instance Video_ai_instance { get; set; }
    }
    #endregion
    #region Params_Get_Stream_Data
    public class Params_Get_Stream_Data
    {
        public int? ENTITY_ID { get; set; }
    }
    #endregion
    #region Params_Validate_Query
    public class Params_Validate_Query
    {
        public string QUERY { get; set; }
        public string X_AUTH_TOKEN { get; set; }
        public Video_ai_instance Video_ai_instance { get; set; }
    }
    #endregion
    #region Params_Get_Scene_Info
    public class Params_Get_Scene_Info
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? SCENE_ID { get; set; }
        public string OBJECT_TYPE { get; set; }
    }
    #endregion
    #region Params_Get_License_Plate_Scene
    public class Params_Get_License_Plate_Scene
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? SCENE_ID { get; set; }
    }
    #endregion
    #region Params_Get_Scene_Objects
    public class Params_Get_Scene_Objects
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? SCENE_ID { get; set; }
        public string X_AUTH_TOKEN { get; set; }
    }
    #endregion
    #region Params_Fetch_License_Plate_Targets
    public class Params_Fetch_License_Plate_Targets
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string CATEGORY { get; set; }
        public string PLATE_NUMBER { get; set; }
    }
    #endregion
    #region Params_Fetch_Face_Targets
    public class Params_Fetch_Face_Targets
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string CATEGORY { get; set; }
        public string TARGET_NAME { get; set; }
    }
    #endregion
    #region Params_Fetch_Scenes
    public class Params_Fetch_Scenes
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string QUERY { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }

    }
    #endregion
    #region Params_Fetch_Facial_Recognition
    public class Params_Fetch_Facial_Recognition
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string TARGET_NAME { get; set; }
        public double SCORES { get; set; }
        public string CATEGORIES { get; set; }
        public bool? HAS_MASK { get; set; }
        public string AGE { get; set; }
        public string GENDER { get; set; }
        public string EMOTION { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }

    }
    #endregion
    #region Params_Fetch_License_Plate_Recognition
    public class Params_Fetch_License_Plate_Recognition
    {
        public int? SIZE { get; set; }
        public int? PAGE { get; set; }
        public string END_DATE { get; set; }
        public string START_DATE { get; set; }
        public string VEHICLE_TYPE { get; set; }
        public string PLATE_NUMBER { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    #endregion
    #region Params_Fetch_License_Plate_Categories
    public class Params_Fetch_License_Plate_Categories
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Fetch_Face_Target_Category
    public class Params_Fetch_Face_Target_Categories
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Send_Alerts_To_All_Emails
    public class Params_Send_Alerts_To_All_Emails
    {
        public Scene_Details Scene { get; set; }
        public Incident Incident { get; set; }
    }
    #endregion
    #region Params_Send_Alerts_Email
    public class Params_Send_Alerts_Email
    {
        public Scene_Details Scene { get; set; }
        public Incident Incident { get; set; }
        public string TO_EMAIL { get; set; }
    }
    #endregion
    #region Params_Get_Countings
    public class Params_Get_Countings
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public List<string> TYPES { get; set; }
        public string MEASURE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<int> LINESET_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Vehicle_Countings
    public class Params_Get_Vehicle_Countings
    {
        public List<string> TYPES { get; set; }
        public string MEASURE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<int> LINESET_ID_LIST { get; set; }
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Get_Line_Sets
    public class Params_Get_Line_Sets
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public List<string> TYPES { get; set; }
    }
    #endregion
    #region Params_Get_Camera_Lines
    public class Params_Get_Camera_Lines
    {
        public List<string> TYPES { get; set; }
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Get_Vehicle_Types
    public class Params_Get_Vehicle_Types
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int? ENTITY_ID { get; set; }
    }
    #endregion
    #region Params_Get_Camera_By_Camera_ID
    public class Params_Get_Camera_By_Camera_ID
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public int ID { get; set; }
    }
    #endregion
    #region Params_Get_Video_ai_assets_with_engine_assets
    public class Params_Get_Video_ai_assets_with_engine_assets
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Get_All_Cameras
    public class Params_Get_All_Cameras
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Get_Alerts_By_Date
    public class Params_Get_Alerts_By_Date
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public string START_DATETIME { get; set; }
        public string END_DATETIME { get; set; }
        public string SURVEILLANCE_CAMERA_ID_LIST { get; set; }
    }
    #endregion
    #region Params_Get_Latest_Alerts
    public class Params_Get_Latest_Alerts
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public string SURVEILLANCE_CAMERA_ID_LIST { get; set; }
        public int NB_OF_ALERTS { get; set; }
    }
    #endregion
    #region Params_Delete_Video_ai_asset_Custom
    public class Params_Delete_Video_ai_asset_Custom
    {
        public int? VIDEO_AI_ASSET_ID { get; set; }
    }
    #endregion
    #region Params_Create_Video_ai_asset
    public class Params_Create_Video_ai_asset
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public int? SPACE_ASSET_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public int? VIDEO_AI_ASSET_ID_REF { get; set; }
        public int? RESOLUTION_X { get; set; }
        public int? RESOLUTION_Y { get; set; }
    }
    #endregion
    #region Params_Create_Video_ai_instance
    public class Params_Create_Video_ai_instance
    {
        public int? VIDEO_AI_ENGINE_ID { get; set; }
        public string FRIENDLY_NAME { get; set; }
        public string FUNCTIONAL_NAME { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string CONNECTION_URL { get; set; }
        public long? CONNECTION_TYPE_SETUP_ID { get; set; }
        public bool FORCE_CONNECTION { get; set; }
        public bool IS_LPR { get; set; }
    }
    #endregion
    #region Params_Change_Video_ai_instance_Password
    public class Params_Change_Video_ai_instance_Password
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
        public string NEW_PASSWORD { get; set; }
        public bool FORCE_CONNECTION { get; set; }
    }
    #endregion
    #region Params_Get_Video_ai_instance_with_credentials
    public class Params_Get_Video_ai_instance_with_credentials
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Get_Video_ai_Connection_Url
    public class Params_Get_Video_ai_Connection_Url
    {
        public int? VIDEO_AI_INSTANCE_ID { get; set; }
    }
    #endregion
    #region Params_Edit_Video_ai_instance_custom
    public class Params_Edit_Video_ai_instance_custom
    {
        public Video_ai_instance Video_ai_instance { get; set; }
        public bool FORCE_CONNECTION { get; set; }
    }
    #endregion
    #region Params_Get_Space_asset_Vaidio_camera
    public class Params_Get_Space_asset_Vaidio_camera
    {
        public int? SPACE_ASSET_ID { get; set; }
    }
    #endregion
    #region Params_Get_Space_asset_Alerts
    public class Params_Get_Space_asset_Alerts
    {
        public List<long?> SPACE_ASSET_ID_LIST { get; set; }
        public string START_DATETIME { get; set; }
        public string END_DATETIME { get; set; }
        public bool IS_GET_LATEST { get; set; }
    }
    #endregion
    #region Params_Face_Target_Key_Search
    public class Params_Face_Target_Key_Search
    {
        public int? PAGE { get; set; }
        public int? SIZE { get; set; }
        public string DESCRIPTOR { get; set; }
        public double SCORES { get; set; }
        public int? LIMIT { get; set; }

    }
    #endregion
    #region Params_Face_Search
    public class Params_Face_Search
    {
        public int? PAGE { get; set; }
        public int? SIZE { get; set; }
        public string DESCRIPTOR { get; set; }
        public double SCORES { get; set; }
        public int? LIMIT { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public List<Video_ai_asset> List_Video_ai_asset { get; set; }
    }
    #endregion
    #region Params_Detect_Face_In_Image
    public class Params_Detect_Face_In_Image
    {
        public IFormFileCollection List_Uploaded_File { get; set; }
    }
    #endregion
    #region Params_Fetch_Alerts
    public class Params_Fetch_Alerts
    {
        public int? PAGE { get; set; }
        public int? SIZE { get; set; }
        public string START_DATE { get; set; }
        public string END_DATE { get; set; }
        public string ALERT_RULES { get; set; }
    }
    #endregion
}
