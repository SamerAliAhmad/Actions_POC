using System;
using SmartrTools;
using System.Diagnostics;
using System.Configuration;
using System.Threading.Tasks;

namespace BLC
{
    public partial class BLC
    {
        #region StopWatch properties
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_engine_By_VIDEO_AI_ENGINE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_SEARCH_CATEGORY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ENTITY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_ENTITY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_VALUE { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_engine_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_engine_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_SPACE_ASSET_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_ENTITY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_SPACE_ASSET_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_ENTITY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_SPACE_ASSET_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_ENTITY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_SETUP_CATEGORY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_category_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_engine_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_search_category_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_entity_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Setup_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_instance_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_asset_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_search_category { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_entity { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_engine { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_instance { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_search_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_search_category_By_VIDEO_AI_ENGINE_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_search_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_entity_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_entity_By_ENTITY_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_entity_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE { get; set; }
        public Stopwatch _Execution_Time_Delete_Setup_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_engine_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_engine_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_instance_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_instance_By_CONNECTION_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_instance_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_By_VIDEO_AI_INSTANCE_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_By_SPACE_ASSET_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_search_category { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_asset_entity { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_category { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_engine { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_instance { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_asset { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_search_category_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_asset_entity_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_category_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Setup_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_engine_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_instance_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_asset_List { get; set; }
        public Stopwatch _Execution_Time_Get_Timezone { get; set; }
        public Stopwatch _Execution_Time_Get_Timezone_Date { get; set; }
        public Stopwatch _Execution_Time_isDark { get; set; }
        public Stopwatch _Execution_Time_Fetch_Scenes { get; set; }
        public Stopwatch _Execution_Time_Fetch_Facial_Recognition { get; set; }
        public Stopwatch _Execution_Time_Fetch_Face_Targets { get; set; }
        public Stopwatch _Execution_Time_Fetch_License_Plate_Recognition { get; set; }
        public Stopwatch _Execution_Time_Fetch_License_Plate_Targets { get; set; }
        public Stopwatch _Execution_Time_Fetch_License_Plate_Categories { get; set; }
        public Stopwatch _Execution_Time_Fetch_Face_Target_Categories { get; set; }
        public Stopwatch _Execution_Time_Get_Countings { get; set; }
        public Stopwatch _Execution_Time_Get_Line_Sets { get; set; }
        public Stopwatch _Execution_Time_Get_Scene_Info { get; set; }
        public Stopwatch _Execution_Time_Get_License_Plate_Scene { get; set; }
        public Stopwatch _Execution_Time_Validate_Query { get; set; }
        public Stopwatch _Execution_Time_Get_Stream_Data { get; set; }
        public Stopwatch _Execution_Time_Get_Camera_Lines { get; set; }
        public Stopwatch _Execution_Time_Get_Scene_Objects { get; set; }
        public Stopwatch _Execution_Time_Get_Vehicle_Types { get; set; }
        public Stopwatch _Execution_Time_Get_Vaidio_Auth_Token { get; set; }
        public Stopwatch _Execution_Time_Get_Vehicle_Countings { get; set; }
        public Stopwatch _Execution_Time_Get_Camera_By_Camera_ID { get; set; }
        public Stopwatch _Execution_Time_Get_All_Cameras { get; set; }
        public Stopwatch _Execution_Time_Get_Video_ai_assets_with_engine_assets { get; set; }
        public Stopwatch _Execution_Time_Delete_Video_ai_asset_Custom { get; set; }
        public Stopwatch _Execution_Time_Get_Sites_and_Entities { get; set; }
        public Stopwatch _Execution_Time_Create_Video_ai_instance { get; set; }
        public Stopwatch _Execution_Time_Edit_Video_ai_instance_custom { get; set; }
        public Stopwatch _Execution_Time_Create_Video_ai_asset { get; set; }
        public Stopwatch _Execution_Time_Change_Video_ai_instance_Password { get; set; }
        public Stopwatch _Execution_Time_Get_Space_asset_Vaidio_camera { get; set; }
        public Stopwatch _Execution_Time_Detect_Face_In_Image { get; set; }
        public Stopwatch _Execution_Time_Face_Search { get; set; }
        public Stopwatch _Execution_Time_Face_Target_Key_Search { get; set; }
        public Stopwatch _Execution_Time_Fetch_Alerts { get; set; }
        public Stopwatch _Execution_Time_Fetch_Alert_Rules { get; set; }
        public Stopwatch _Execution_Time_Update_Alerts { get; set; }
        public Stopwatch _Execution_Time_Update_Alerts_Custom { get; set; }
        public Stopwatch _Execution_Time_Update_Facial_Recognition_Alerts { get; set; }
        public Stopwatch _Execution_Time_Update_License_Plate_Recognition_Alerts { get; set; }
        public Stopwatch _Execution_Time_Send_Alerts_To_All_Emails { get; set; }
        public Stopwatch _Execution_Time_Send_Alerts_Email { get; set; }
        #endregion
        #region BLC_OnPreEvent_General_Monitoring
        public void BLC_OnPreEvent_General_Monitoring(string i_MethodName, string i_Method_Params, bool is_Cached)
        {
            #region Body Section.
            var oStopWatch = (Stopwatch)Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName));
            Props.Set_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName), Stopwatch.StartNew());
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_General_Monitoring
        public void BLC_OnPostEvent_General_Monitoring(string i_MethodName, string i_Method_Params, bool is_Cached)
        {
            Task.Run(() =>
            {
                if (i_MethodName != "Edit_Method_run")
                {
                    #region Declaration And Initialization Section.
                    Service_Mesh.Method_run oMethod_run = new Service_Mesh.Method_run();
                    #endregion
                    #region Body Section.
                    Props.Set_Properties_Default_Value(oMethod_run);
                    oMethod_run.METHOD_RUN_ID = -1;
                    oMethod_run.IS_CACHED = is_Cached;
                    oMethod_run.METHOD_NAME = i_MethodName;
                    oMethod_run.RUN_HOUR = DateTime.Now.Hour;
                    oMethod_run.METHOD_PARAMS = i_Method_Params;
                    oMethod_run.RUN_MINUTE = DateTime.Now.Minute;
                    oMethod_run.RUN_SECOND = DateTime.Now.Second;
                    oMethod_run.RUN_DATE = Tools.GetDateString(DateTime.Today);
                    // Calculate Execution time
                    if (Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName)) != null)
                    {
                        var oStopWatch = (Stopwatch)Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName));
                        oStopWatch.Stop();
                        var elapsedMs = oStopWatch.ElapsedMilliseconds;
                        oMethod_run.EXECUTION_TIME = (int)elapsedMs;
                    }
                    this._service_mesh.Edit_Method_run(oMethod_run);
                    #endregion
                }
            });
        }
        #endregion
        #region Initialize_Monitoring_Mechanism
        public void Initialize_Monitoring_Mechanism()
        {
            #region Body Section.
            if (ConfigurationManager.AppSettings["ENABLE_MONITORING"] != null && ConfigurationManager.AppSettings["ENABLE_MONITORING"] == "1")
            {
                this.OnPreEvent_General += new PreEvent_Handler_General(BLC_OnPreEvent_General_Monitoring);
                this.OnPostEvent_General += new PostEvent_Handler_General(BLC_OnPostEvent_General_Monitoring);
            }
            #endregion
        }
        #endregion
    }
}