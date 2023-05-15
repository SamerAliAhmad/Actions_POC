using BLC;
using System;
using System.Linq;
using System.Configuration;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

[Route("Api/[controller]")]
[ApiController]
public partial class VideoAIEngineManagementController : ControllerBase
{
    #region Validate_And_Extract_Ticket
    private string Validate_And_Extract_Ticket()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        #endregion
        #region Body Section.
        if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null && ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
        {
            if (
                (HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
                (HttpContext.Request.Headers["Ticket"].ToString() != "")
            )
            {
                oTicket = HttpContext.Request.Headers["Ticket"].ToString();
            }
            else
            {
                throw new Exception("Invalid Ticket");
            }
        }
        #endregion
        #region Return Section.
        return oTicket;
        #endregion
    }
    #endregion
    #region Fetch_Scenes
    [HttpPost]
    [Route("Fetch_Scenes")]
    public Result_Fetch_Scenes Fetch_Scenes(Params_Fetch_Scenes i_Params_Fetch_Scenes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_Scenes oResult_Fetch_Scenes = new Result_Fetch_Scenes();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_Scenes.i_Result = oBLC.Fetch_Scenes(i_Params_Fetch_Scenes);
                oResult_Fetch_Scenes.Params_Fetch_Scenes = i_Params_Fetch_Scenes;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_Scenes.Params_Fetch_Scenes = i_Params_Fetch_Scenes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_Scenes.Exception_Message = string.Format("Fetch_Scenes : {0}", ex.Message);
                oResult_Fetch_Scenes.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_Scenes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_Scenes.Exception_Message = ex.Message;
                oResult_Fetch_Scenes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_Scenes;
        #endregion
    }
    #endregion
    #region Get_Vehicle_Types
    [HttpGet]
    [Route("Get_Vehicle_Types")]
    public Result_Get_Vehicle_Types Get_Vehicle_Types()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Vehicle_Types oResult_Get_Vehicle_Types = new Result_Get_Vehicle_Types();
        Params_Get_Vehicle_Types oParams_Get_Vehicle_Types = new Params_Get_Vehicle_Types();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Vehicle_Types.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            if (HttpContext.Request.Query["ENTITY_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ENTITY_ID"].ToString() != "undefined" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "null" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Vehicle_Types.ENTITY_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Vehicle_Types.i_Result = oBLC.Get_Vehicle_Types(oParams_Get_Vehicle_Types);
                oResult_Get_Vehicle_Types.Params_Get_Vehicle_Types = oParams_Get_Vehicle_Types;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Vehicle_Types.Params_Get_Vehicle_Types = oParams_Get_Vehicle_Types;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Vehicle_Types.Exception_Message = string.Format("Get_Vehicle_Types : {0}", ex.Message);
                oResult_Get_Vehicle_Types.Stack_Trace = is_send_stack_trace ? string.Format("Get_Vehicle_Types : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Vehicle_Types.Exception_Message = ex.Message;
                oResult_Get_Vehicle_Types.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Vehicle_Types;
        #endregion
    }
    #endregion
    #region Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
    [HttpGet]
    [Route("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID")]
    public Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = new Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID();
        Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = new Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.i_Result = oBLC.Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID(oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID);
                oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID = oParams_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.Exception_Message = string.Format("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID : {0}", ex.Message);
                oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.Exception_Message = ex.Message;
                oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID;
        #endregion
    }
    #endregion
    #region Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
    [HttpGet]
    [Route("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID")]
    public Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID = new Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID();
        Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID = new Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_ENGINE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_ENGINE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_ENGINE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_ENGINE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.VIDEO_AI_ENGINE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_ENGINE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.i_Result = oBLC.Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID);
                oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID = oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID = oParams_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.Exception_Message = string.Format("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID : {0}", ex.Message);
                oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.Exception_Message = ex.Message;
                oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID;
        #endregion
    }
    #endregion
    #region Create_Video_ai_asset
    [HttpPost]
    [Route("Create_Video_ai_asset")]
    public Result_Create_Video_ai_asset Create_Video_ai_asset(Params_Create_Video_ai_asset i_Params_Create_Video_ai_asset)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Create_Video_ai_asset oResult_Create_Video_ai_asset = new Result_Create_Video_ai_asset();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Create_Video_ai_asset.i_Result = oBLC.Create_Video_ai_asset(i_Params_Create_Video_ai_asset);
                oResult_Create_Video_ai_asset.Params_Create_Video_ai_asset = i_Params_Create_Video_ai_asset;
            }
        }
        catch (Exception ex)
        {
            oResult_Create_Video_ai_asset.Params_Create_Video_ai_asset = i_Params_Create_Video_ai_asset;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Create_Video_ai_asset.Exception_Message = string.Format("Create_Video_ai_asset : {0}", ex.Message);
                oResult_Create_Video_ai_asset.Stack_Trace = is_send_stack_trace ? string.Format("Create_Video_ai_asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Create_Video_ai_asset.Exception_Message = ex.Message;
                oResult_Create_Video_ai_asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Create_Video_ai_asset;
        #endregion
    }
    #endregion
    #region Update_License_Plate_Recognition_Alerts
    [HttpPost]
    [Route("Update_License_Plate_Recognition_Alerts")]
    public Result_Update_License_Plate_Recognition_Alerts Update_License_Plate_Recognition_Alerts()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Update_License_Plate_Recognition_Alerts oResult_Update_License_Plate_Recognition_Alerts = new Result_Update_License_Plate_Recognition_Alerts();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Update_License_Plate_Recognition_Alerts.i_Result = oBLC.Update_License_Plate_Recognition_Alerts();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Update_License_Plate_Recognition_Alerts.Exception_Message = string.Format("Update_License_Plate_Recognition_Alerts : {0}", ex.Message);
                oResult_Update_License_Plate_Recognition_Alerts.Stack_Trace = is_send_stack_trace ? string.Format("Update_License_Plate_Recognition_Alerts : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Update_License_Plate_Recognition_Alerts.Exception_Message = ex.Message;
                oResult_Update_License_Plate_Recognition_Alerts.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Update_License_Plate_Recognition_Alerts;
        #endregion
    }
    #endregion
    #region Change_Video_ai_instance_Password
    [HttpPost]
    [Route("Change_Video_ai_instance_Password")]
    public Result_Change_Video_ai_instance_Password Change_Video_ai_instance_Password(Params_Change_Video_ai_instance_Password i_Params_Change_Video_ai_instance_Password)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Change_Video_ai_instance_Password oResult_Change_Video_ai_instance_Password = new Result_Change_Video_ai_instance_Password();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Change_Video_ai_instance_Password.i_Result = oBLC.Change_Video_ai_instance_Password(i_Params_Change_Video_ai_instance_Password);
                oResult_Change_Video_ai_instance_Password.Params_Change_Video_ai_instance_Password = i_Params_Change_Video_ai_instance_Password;
            }
        }
        catch (Exception ex)
        {
            oResult_Change_Video_ai_instance_Password.Params_Change_Video_ai_instance_Password = i_Params_Change_Video_ai_instance_Password;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Change_Video_ai_instance_Password.Exception_Message = string.Format("Change_Video_ai_instance_Password : {0}", ex.Message);
                oResult_Change_Video_ai_instance_Password.Stack_Trace = is_send_stack_trace ? string.Format("Change_Video_ai_instance_Password : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Change_Video_ai_instance_Password.Exception_Message = ex.Message;
                oResult_Change_Video_ai_instance_Password.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Change_Video_ai_instance_Password;
        #endregion
    }
    #endregion
    #region Face_Target_Key_Search
    [HttpPost]
    [Route("Face_Target_Key_Search")]
    public Result_Face_Target_Key_Search Face_Target_Key_Search(Params_Face_Target_Key_Search i_Params_Face_Target_Key_Search)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Face_Target_Key_Search oResult_Face_Target_Key_Search = new Result_Face_Target_Key_Search();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Face_Target_Key_Search.i_Result = oBLC.Face_Target_Key_Search(i_Params_Face_Target_Key_Search);
                oResult_Face_Target_Key_Search.Params_Face_Target_Key_Search = i_Params_Face_Target_Key_Search;
            }
        }
        catch (Exception ex)
        {
            oResult_Face_Target_Key_Search.Params_Face_Target_Key_Search = i_Params_Face_Target_Key_Search;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Face_Target_Key_Search.Exception_Message = string.Format("Face_Target_Key_Search : {0}", ex.Message);
                oResult_Face_Target_Key_Search.Stack_Trace = is_send_stack_trace ? string.Format("Face_Target_Key_Search : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Face_Target_Key_Search.Exception_Message = ex.Message;
                oResult_Face_Target_Key_Search.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Face_Target_Key_Search;
        #endregion
    }
    #endregion
    #region Face_Search
    [HttpPost]
    [Route("Face_Search")]
    public Result_Face_Search Face_Search(Params_Face_Search i_Params_Face_Search)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Face_Search oResult_Face_Search = new Result_Face_Search();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Face_Search.i_Result = oBLC.Face_Search(i_Params_Face_Search);
                oResult_Face_Search.Params_Face_Search = i_Params_Face_Search;
            }
        }
        catch (Exception ex)
        {
            oResult_Face_Search.Params_Face_Search = i_Params_Face_Search;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Face_Search.Exception_Message = string.Format("Face_Search : {0}", ex.Message);
                oResult_Face_Search.Stack_Trace = is_send_stack_trace ? string.Format("Face_Search : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Face_Search.Exception_Message = ex.Message;
                oResult_Face_Search.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Face_Search;
        #endregion
    }
    #endregion
    #region Fetch_License_Plate_Categories
    [HttpGet]
    [Route("Fetch_License_Plate_Categories")]
    public Result_Fetch_License_Plate_Categories Fetch_License_Plate_Categories()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_License_Plate_Categories oResult_Fetch_License_Plate_Categories = new Result_Fetch_License_Plate_Categories();
        Params_Fetch_License_Plate_Categories oParams_Fetch_License_Plate_Categories = new Params_Fetch_License_Plate_Categories();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Fetch_License_Plate_Categories.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_License_Plate_Categories.i_Result = oBLC.Fetch_License_Plate_Categories(oParams_Fetch_License_Plate_Categories);
                oResult_Fetch_License_Plate_Categories.Params_Fetch_License_Plate_Categories = oParams_Fetch_License_Plate_Categories;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_License_Plate_Categories.Params_Fetch_License_Plate_Categories = oParams_Fetch_License_Plate_Categories;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_License_Plate_Categories.Exception_Message = string.Format("Fetch_License_Plate_Categories : {0}", ex.Message);
                oResult_Fetch_License_Plate_Categories.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_License_Plate_Categories : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_License_Plate_Categories.Exception_Message = ex.Message;
                oResult_Fetch_License_Plate_Categories.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_License_Plate_Categories;
        #endregion
    }
    #endregion
    #region Fetch_Face_Targets
    [HttpGet]
    [Route("Fetch_Face_Targets")]
    public Result_Fetch_Face_Targets Fetch_Face_Targets()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_Face_Targets oResult_Fetch_Face_Targets = new Result_Fetch_Face_Targets();
        Params_Fetch_Face_Targets oParams_Fetch_Face_Targets = new Params_Fetch_Face_Targets();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SIZE"].FirstOrDefault() != null && HttpContext.Request.Query["SIZE"].ToString() != "undefined" && HttpContext.Request.Query["SIZE"].ToString() != "null" && HttpContext.Request.Query["SIZE"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Fetch_Face_Targets.SIZE = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SIZE"].ToString());
            }
            if (HttpContext.Request.Query["PAGE"].FirstOrDefault() != null && HttpContext.Request.Query["PAGE"].ToString() != "undefined" && HttpContext.Request.Query["PAGE"].ToString() != "null" && HttpContext.Request.Query["PAGE"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Fetch_Face_Targets.PAGE = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["PAGE"].ToString());
            }
            if (HttpContext.Request.Query["CATEGORY"].FirstOrDefault() != null && HttpContext.Request.Query["CATEGORY"].ToString() != "undefined" && HttpContext.Request.Query["CATEGORY"].ToString() != "null" && HttpContext.Request.Query["CATEGORY"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Fetch_Face_Targets.CATEGORY = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["CATEGORY"].ToString());
            }
            if (HttpContext.Request.Query["TARGET_NAME"].FirstOrDefault() != null && HttpContext.Request.Query["TARGET_NAME"].ToString() != "undefined" && HttpContext.Request.Query["TARGET_NAME"].ToString() != "null" && HttpContext.Request.Query["TARGET_NAME"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Fetch_Face_Targets.TARGET_NAME = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["TARGET_NAME"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_Face_Targets.i_Result = oBLC.Fetch_Face_Targets(oParams_Fetch_Face_Targets);
                oResult_Fetch_Face_Targets.Params_Fetch_Face_Targets = oParams_Fetch_Face_Targets;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_Face_Targets.Params_Fetch_Face_Targets = oParams_Fetch_Face_Targets;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_Face_Targets.Exception_Message = string.Format("Fetch_Face_Targets : {0}", ex.Message);
                oResult_Fetch_Face_Targets.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_Face_Targets : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_Face_Targets.Exception_Message = ex.Message;
                oResult_Fetch_Face_Targets.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_Face_Targets;
        #endregion
    }
    #endregion
    #region Fetch_Facial_Recognition
    [HttpPost]
    [Route("Fetch_Facial_Recognition")]
    public Result_Fetch_Facial_Recognition Fetch_Facial_Recognition(Params_Fetch_Facial_Recognition i_Params_Fetch_Facial_Recognition)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_Facial_Recognition oResult_Fetch_Facial_Recognition = new Result_Fetch_Facial_Recognition();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_Facial_Recognition.i_Result = oBLC.Fetch_Facial_Recognition(i_Params_Fetch_Facial_Recognition);
                oResult_Fetch_Facial_Recognition.Params_Fetch_Facial_Recognition = i_Params_Fetch_Facial_Recognition;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_Facial_Recognition.Params_Fetch_Facial_Recognition = i_Params_Fetch_Facial_Recognition;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_Facial_Recognition.Exception_Message = string.Format("Fetch_Facial_Recognition : {0}", ex.Message);
                oResult_Fetch_Facial_Recognition.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_Facial_Recognition : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_Facial_Recognition.Exception_Message = ex.Message;
                oResult_Fetch_Facial_Recognition.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_Facial_Recognition;
        #endregion
    }
    #endregion
    #region Delete_Video_ai_asset_Custom
    [HttpDelete]
    [Route("Delete_Video_ai_asset_Custom/{VIDEO_AI_ASSET_ID}")]
    public Result_Delete_Video_ai_asset_Custom Delete_Video_ai_asset_Custom(int? VIDEO_AI_ASSET_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Video_ai_asset_Custom oParams_Delete_Video_ai_asset_Custom = new Params_Delete_Video_ai_asset_Custom()
        {
            VIDEO_AI_ASSET_ID = VIDEO_AI_ASSET_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Video_ai_asset_Custom oResult_Delete_Video_ai_asset_Custom = new Result_Delete_Video_ai_asset_Custom();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Delete_Video_ai_asset_Custom.i_Result = oBLC.Delete_Video_ai_asset_Custom(oParams_Delete_Video_ai_asset_Custom);
                oResult_Delete_Video_ai_asset_Custom.Params_Delete_Video_ai_asset_Custom = oParams_Delete_Video_ai_asset_Custom;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Video_ai_asset_Custom.Params_Delete_Video_ai_asset_Custom = oParams_Delete_Video_ai_asset_Custom;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Video_ai_asset_Custom.Exception_Message = string.Format("Delete_Video_ai_asset_Custom : {0}", ex.Message);
                oResult_Delete_Video_ai_asset_Custom.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Video_ai_asset_Custom : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Video_ai_asset_Custom.Exception_Message = ex.Message;
                oResult_Delete_Video_ai_asset_Custom.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Video_ai_asset_Custom;
        #endregion
    }
    #endregion
    #region Update_Facial_Recognition_Alerts
    [HttpPost]
    [Route("Update_Facial_Recognition_Alerts")]
    public Result_Update_Facial_Recognition_Alerts Update_Facial_Recognition_Alerts()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Update_Facial_Recognition_Alerts oResult_Update_Facial_Recognition_Alerts = new Result_Update_Facial_Recognition_Alerts();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Update_Facial_Recognition_Alerts.i_Result = oBLC.Update_Facial_Recognition_Alerts();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Update_Facial_Recognition_Alerts.Exception_Message = string.Format("Update_Facial_Recognition_Alerts : {0}", ex.Message);
                oResult_Update_Facial_Recognition_Alerts.Stack_Trace = is_send_stack_trace ? string.Format("Update_Facial_Recognition_Alerts : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Update_Facial_Recognition_Alerts.Exception_Message = ex.Message;
                oResult_Update_Facial_Recognition_Alerts.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Update_Facial_Recognition_Alerts;
        #endregion
    }
    #endregion
    #region Get_Video_ai_engine_By_OWNER_ID
    [HttpGet]
    [Route("Get_Video_ai_engine_By_OWNER_ID")]
    public Result_Get_Video_ai_engine_By_OWNER_ID Get_Video_ai_engine_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_engine_By_OWNER_ID oResult_Get_Video_ai_engine_By_OWNER_ID = new Result_Get_Video_ai_engine_By_OWNER_ID();
        Params_Get_Video_ai_engine_By_OWNER_ID oParams_Get_Video_ai_engine_By_OWNER_ID = new Params_Get_Video_ai_engine_By_OWNER_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["OWNER_ID"].FirstOrDefault() != null && HttpContext.Request.Query["OWNER_ID"].ToString() != "undefined" && HttpContext.Request.Query["OWNER_ID"].ToString() != "null" && HttpContext.Request.Query["OWNER_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Video_ai_engine_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_engine_By_OWNER_ID.i_Result = oBLC.Get_Video_ai_engine_By_OWNER_ID(oParams_Get_Video_ai_engine_By_OWNER_ID);
                oResult_Get_Video_ai_engine_By_OWNER_ID.Params_Get_Video_ai_engine_By_OWNER_ID = oParams_Get_Video_ai_engine_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_engine_By_OWNER_ID.Params_Get_Video_ai_engine_By_OWNER_ID = oParams_Get_Video_ai_engine_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_engine_By_OWNER_ID.Exception_Message = string.Format("Get_Video_ai_engine_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Video_ai_engine_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_engine_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_engine_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Video_ai_engine_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_engine_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Fetch_License_Plate_Targets
    [HttpGet]
    [Route("Fetch_License_Plate_Targets")]
    public Result_Fetch_License_Plate_Targets Fetch_License_Plate_Targets()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_License_Plate_Targets oResult_Fetch_License_Plate_Targets = new Result_Fetch_License_Plate_Targets();
        Params_Fetch_License_Plate_Targets oParams_Fetch_License_Plate_Targets = new Params_Fetch_License_Plate_Targets();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SIZE"].FirstOrDefault() != null && HttpContext.Request.Query["SIZE"].ToString() != "undefined" && HttpContext.Request.Query["SIZE"].ToString() != "null" && HttpContext.Request.Query["SIZE"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Fetch_License_Plate_Targets.SIZE = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SIZE"].ToString());
            }
            if (HttpContext.Request.Query["PAGE"].FirstOrDefault() != null && HttpContext.Request.Query["PAGE"].ToString() != "undefined" && HttpContext.Request.Query["PAGE"].ToString() != "null" && HttpContext.Request.Query["PAGE"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Fetch_License_Plate_Targets.PAGE = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["PAGE"].ToString());
            }
            if (HttpContext.Request.Query["CATEGORY"].FirstOrDefault() != null && HttpContext.Request.Query["CATEGORY"].ToString() != "undefined" && HttpContext.Request.Query["CATEGORY"].ToString() != "null" && HttpContext.Request.Query["CATEGORY"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Fetch_License_Plate_Targets.CATEGORY = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["CATEGORY"].ToString());
            }
            if (HttpContext.Request.Query["PLATE_NUMBER"].FirstOrDefault() != null && HttpContext.Request.Query["PLATE_NUMBER"].ToString() != "undefined" && HttpContext.Request.Query["PLATE_NUMBER"].ToString() != "null" && HttpContext.Request.Query["PLATE_NUMBER"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Fetch_License_Plate_Targets.PLATE_NUMBER = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["PLATE_NUMBER"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_License_Plate_Targets.i_Result = oBLC.Fetch_License_Plate_Targets(oParams_Fetch_License_Plate_Targets);
                oResult_Fetch_License_Plate_Targets.Params_Fetch_License_Plate_Targets = oParams_Fetch_License_Plate_Targets;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_License_Plate_Targets.Params_Fetch_License_Plate_Targets = oParams_Fetch_License_Plate_Targets;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_License_Plate_Targets.Exception_Message = string.Format("Fetch_License_Plate_Targets : {0}", ex.Message);
                oResult_Fetch_License_Plate_Targets.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_License_Plate_Targets : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_License_Plate_Targets.Exception_Message = ex.Message;
                oResult_Fetch_License_Plate_Targets.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_License_Plate_Targets;
        #endregion
    }
    #endregion
    #region Get_Video_ai_asset_By_OWNER_ID
    [HttpGet]
    [Route("Get_Video_ai_asset_By_OWNER_ID")]
    public Result_Get_Video_ai_asset_By_OWNER_ID Get_Video_ai_asset_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_asset_By_OWNER_ID oResult_Get_Video_ai_asset_By_OWNER_ID = new Result_Get_Video_ai_asset_By_OWNER_ID();
        Params_Get_Video_ai_asset_By_OWNER_ID oParams_Get_Video_ai_asset_By_OWNER_ID = new Params_Get_Video_ai_asset_By_OWNER_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["OWNER_ID"].FirstOrDefault() != null && HttpContext.Request.Query["OWNER_ID"].ToString() != "undefined" && HttpContext.Request.Query["OWNER_ID"].ToString() != "null" && HttpContext.Request.Query["OWNER_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Video_ai_asset_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_asset_By_OWNER_ID.i_Result = oBLC.Get_Video_ai_asset_By_OWNER_ID(oParams_Get_Video_ai_asset_By_OWNER_ID);
                oResult_Get_Video_ai_asset_By_OWNER_ID.Params_Get_Video_ai_asset_By_OWNER_ID = oParams_Get_Video_ai_asset_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_asset_By_OWNER_ID.Params_Get_Video_ai_asset_By_OWNER_ID = oParams_Get_Video_ai_asset_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_asset_By_OWNER_ID.Exception_Message = string.Format("Get_Video_ai_asset_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Video_ai_asset_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_asset_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_asset_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Video_ai_asset_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_asset_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Stream_Data
    [HttpGet]
    [Route("Get_Stream_Data")]
    public Result_Get_Stream_Data Get_Stream_Data()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Stream_Data oResult_Get_Stream_Data = new Result_Get_Stream_Data();
        Params_Get_Stream_Data oParams_Get_Stream_Data = new Params_Get_Stream_Data();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ENTITY_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ENTITY_ID"].ToString() != "undefined" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "null" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Stream_Data.ENTITY_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Stream_Data.i_Result = oBLC.Get_Stream_Data(oParams_Get_Stream_Data);
                oResult_Get_Stream_Data.Params_Get_Stream_Data = oParams_Get_Stream_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Stream_Data.Params_Get_Stream_Data = oParams_Get_Stream_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Stream_Data.Exception_Message = string.Format("Get_Stream_Data : {0}", ex.Message);
                oResult_Get_Stream_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Stream_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Stream_Data.Exception_Message = ex.Message;
                oResult_Get_Stream_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Stream_Data;
        #endregion
    }
    #endregion
    #region Fetch_License_Plate_Recognition
    [HttpPost]
    [Route("Fetch_License_Plate_Recognition")]
    public Result_Fetch_License_Plate_Recognition Fetch_License_Plate_Recognition(Params_Fetch_License_Plate_Recognition i_Params_Fetch_License_Plate_Recognition)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_License_Plate_Recognition oResult_Fetch_License_Plate_Recognition = new Result_Fetch_License_Plate_Recognition();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_License_Plate_Recognition.i_Result = oBLC.Fetch_License_Plate_Recognition(i_Params_Fetch_License_Plate_Recognition);
                oResult_Fetch_License_Plate_Recognition.Params_Fetch_License_Plate_Recognition = i_Params_Fetch_License_Plate_Recognition;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_License_Plate_Recognition.Params_Fetch_License_Plate_Recognition = i_Params_Fetch_License_Plate_Recognition;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_License_Plate_Recognition.Exception_Message = string.Format("Fetch_License_Plate_Recognition : {0}", ex.Message);
                oResult_Fetch_License_Plate_Recognition.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_License_Plate_Recognition : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_License_Plate_Recognition.Exception_Message = ex.Message;
                oResult_Fetch_License_Plate_Recognition.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_License_Plate_Recognition;
        #endregion
    }
    #endregion
    #region Get_Scene_Info
    [HttpGet]
    [Route("Get_Scene_Info")]
    public Result_Get_Scene_Info Get_Scene_Info()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Scene_Info oResult_Get_Scene_Info = new Result_Get_Scene_Info();
        Params_Get_Scene_Info oParams_Get_Scene_Info = new Params_Get_Scene_Info();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Scene_Info.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            if (HttpContext.Request.Query["SCENE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SCENE_ID"].ToString() != "undefined" && HttpContext.Request.Query["SCENE_ID"].ToString() != "null" && HttpContext.Request.Query["SCENE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Scene_Info.SCENE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SCENE_ID"].ToString());
            }
            if (HttpContext.Request.Query["OBJECT_TYPE"].FirstOrDefault() != null && HttpContext.Request.Query["OBJECT_TYPE"].ToString() != "undefined" && HttpContext.Request.Query["OBJECT_TYPE"].ToString() != "null" && HttpContext.Request.Query["OBJECT_TYPE"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Get_Scene_Info.OBJECT_TYPE = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["OBJECT_TYPE"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Scene_Info.i_Result = oBLC.Get_Scene_Info(oParams_Get_Scene_Info);
                oResult_Get_Scene_Info.Params_Get_Scene_Info = oParams_Get_Scene_Info;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Scene_Info.Params_Get_Scene_Info = oParams_Get_Scene_Info;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Scene_Info.Exception_Message = string.Format("Get_Scene_Info : {0}", ex.Message);
                oResult_Get_Scene_Info.Stack_Trace = is_send_stack_trace ? string.Format("Get_Scene_Info : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Scene_Info.Exception_Message = ex.Message;
                oResult_Get_Scene_Info.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Scene_Info;
        #endregion
    }
    #endregion
    #region Update_Alerts_Custom
    [HttpPost]
    [Route("Update_Alerts_Custom")]
    public Result_Update_Alerts_Custom Update_Alerts_Custom()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Update_Alerts_Custom oResult_Update_Alerts_Custom = new Result_Update_Alerts_Custom();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Update_Alerts_Custom.i_Result = oBLC.Update_Alerts_Custom();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Update_Alerts_Custom.Exception_Message = string.Format("Update_Alerts_Custom : {0}", ex.Message);
                oResult_Update_Alerts_Custom.Stack_Trace = is_send_stack_trace ? string.Format("Update_Alerts_Custom : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Update_Alerts_Custom.Exception_Message = ex.Message;
                oResult_Update_Alerts_Custom.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Update_Alerts_Custom;
        #endregion
    }
    #endregion
    #region Get_Countings
    [HttpPost]
    [Route("Get_Countings")]
    public Result_Get_Countings Get_Countings(Params_Get_Countings i_Params_Get_Countings)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Countings oResult_Get_Countings = new Result_Get_Countings();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Countings.i_Result = oBLC.Get_Countings(i_Params_Get_Countings);
                oResult_Get_Countings.Params_Get_Countings = i_Params_Get_Countings;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Countings.Params_Get_Countings = i_Params_Get_Countings;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Countings.Exception_Message = string.Format("Get_Countings : {0}", ex.Message);
                oResult_Get_Countings.Stack_Trace = is_send_stack_trace ? string.Format("Get_Countings : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Countings.Exception_Message = ex.Message;
                oResult_Get_Countings.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Countings;
        #endregion
    }
    #endregion
    #region Get_Camera_Lines
    [HttpPost]
    [Route("Get_Camera_Lines")]
    public Result_Get_Camera_Lines Get_Camera_Lines(Params_Get_Camera_Lines i_Params_Get_Camera_Lines)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Camera_Lines oResult_Get_Camera_Lines = new Result_Get_Camera_Lines();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Camera_Lines.i_Result = oBLC.Get_Camera_Lines(i_Params_Get_Camera_Lines);
                oResult_Get_Camera_Lines.Params_Get_Camera_Lines = i_Params_Get_Camera_Lines;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Camera_Lines.Params_Get_Camera_Lines = i_Params_Get_Camera_Lines;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Camera_Lines.Exception_Message = string.Format("Get_Camera_Lines : {0}", ex.Message);
                oResult_Get_Camera_Lines.Stack_Trace = is_send_stack_trace ? string.Format("Get_Camera_Lines : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Camera_Lines.Exception_Message = ex.Message;
                oResult_Get_Camera_Lines.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Camera_Lines;
        #endregion
    }
    #endregion
    #region Edit_Video_ai_asset
    [HttpPost]
    [Route("Edit_Video_ai_asset")]
    public Result_Edit_Video_ai_asset Edit_Video_ai_asset(Video_ai_asset i_Video_ai_asset)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Video_ai_asset oResult_Edit_Video_ai_asset = new Result_Edit_Video_ai_asset();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oBLC.Edit_Video_ai_asset(i_Video_ai_asset);
                oResult_Edit_Video_ai_asset.Video_ai_asset = i_Video_ai_asset;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Video_ai_asset.Exception_Message = string.Format("Edit_Video_ai_asset : {0}", ex.Message);
                oResult_Edit_Video_ai_asset.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Video_ai_asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Video_ai_asset.Exception_Message = ex.Message;
                oResult_Edit_Video_ai_asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Video_ai_asset;
        #endregion
    }
    #endregion
    #region Get_Space_asset_Vaidio_camera
    [HttpGet]
    [Route("Get_Space_asset_Vaidio_camera")]
    public Result_Get_Space_asset_Vaidio_camera Get_Space_asset_Vaidio_camera()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_asset_Vaidio_camera oResult_Get_Space_asset_Vaidio_camera = new Result_Get_Space_asset_Vaidio_camera();
        Params_Get_Space_asset_Vaidio_camera oParams_Get_Space_asset_Vaidio_camera = new Params_Get_Space_asset_Vaidio_camera();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SPACE_ASSET_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ASSET_ID"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ASSET_ID"].ToString() != "null" && HttpContext.Request.Query["SPACE_ASSET_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Space_asset_Vaidio_camera.SPACE_ASSET_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SPACE_ASSET_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_asset_Vaidio_camera.i_Result = oBLC.Get_Space_asset_Vaidio_camera(oParams_Get_Space_asset_Vaidio_camera);
                oResult_Get_Space_asset_Vaidio_camera.Params_Get_Space_asset_Vaidio_camera = oParams_Get_Space_asset_Vaidio_camera;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_asset_Vaidio_camera.Params_Get_Space_asset_Vaidio_camera = oParams_Get_Space_asset_Vaidio_camera;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_asset_Vaidio_camera.Exception_Message = string.Format("Get_Space_asset_Vaidio_camera : {0}", ex.Message);
                oResult_Get_Space_asset_Vaidio_camera.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_asset_Vaidio_camera : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_asset_Vaidio_camera.Exception_Message = ex.Message;
                oResult_Get_Space_asset_Vaidio_camera.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_asset_Vaidio_camera;
        #endregion
    }
    #endregion
    #region Update_Alerts
    [HttpPost]
    [Route("Update_Alerts")]
    public Result_Update_Alerts Update_Alerts()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Update_Alerts oResult_Update_Alerts = new Result_Update_Alerts();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Update_Alerts.i_Result = oBLC.Update_Alerts();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Update_Alerts.Exception_Message = string.Format("Update_Alerts : {0}", ex.Message);
                oResult_Update_Alerts.Stack_Trace = is_send_stack_trace ? string.Format("Update_Alerts : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Update_Alerts.Exception_Message = ex.Message;
                oResult_Update_Alerts.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Update_Alerts;
        #endregion
    }
    #endregion
    #region Get_License_Plate_Scene
    [HttpGet]
    [Route("Get_License_Plate_Scene")]
    public Result_Get_License_Plate_Scene Get_License_Plate_Scene()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_License_Plate_Scene oResult_Get_License_Plate_Scene = new Result_Get_License_Plate_Scene();
        Params_Get_License_Plate_Scene oParams_Get_License_Plate_Scene = new Params_Get_License_Plate_Scene();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_License_Plate_Scene.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            if (HttpContext.Request.Query["SCENE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SCENE_ID"].ToString() != "undefined" && HttpContext.Request.Query["SCENE_ID"].ToString() != "null" && HttpContext.Request.Query["SCENE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_License_Plate_Scene.SCENE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SCENE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_License_Plate_Scene.i_Result = oBLC.Get_License_Plate_Scene(oParams_Get_License_Plate_Scene);
                oResult_Get_License_Plate_Scene.Params_Get_License_Plate_Scene = oParams_Get_License_Plate_Scene;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_License_Plate_Scene.Params_Get_License_Plate_Scene = oParams_Get_License_Plate_Scene;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_License_Plate_Scene.Exception_Message = string.Format("Get_License_Plate_Scene : {0}", ex.Message);
                oResult_Get_License_Plate_Scene.Stack_Trace = is_send_stack_trace ? string.Format("Get_License_Plate_Scene : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_License_Plate_Scene.Exception_Message = ex.Message;
                oResult_Get_License_Plate_Scene.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_License_Plate_Scene;
        #endregion
    }
    #endregion
    #region Get_Video_ai_assets_with_engine_assets
    [HttpGet]
    [Route("Get_Video_ai_assets_with_engine_assets")]
    public Result_Get_Video_ai_assets_with_engine_assets Get_Video_ai_assets_with_engine_assets()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_assets_with_engine_assets oResult_Get_Video_ai_assets_with_engine_assets = new Result_Get_Video_ai_assets_with_engine_assets();
        Params_Get_Video_ai_assets_with_engine_assets oParams_Get_Video_ai_assets_with_engine_assets = new Params_Get_Video_ai_assets_with_engine_assets();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Video_ai_assets_with_engine_assets.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_assets_with_engine_assets.i_Result = oBLC.Get_Video_ai_assets_with_engine_assets(oParams_Get_Video_ai_assets_with_engine_assets);
                oResult_Get_Video_ai_assets_with_engine_assets.Params_Get_Video_ai_assets_with_engine_assets = oParams_Get_Video_ai_assets_with_engine_assets;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_assets_with_engine_assets.Params_Get_Video_ai_assets_with_engine_assets = oParams_Get_Video_ai_assets_with_engine_assets;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_assets_with_engine_assets.Exception_Message = string.Format("Get_Video_ai_assets_with_engine_assets : {0}", ex.Message);
                oResult_Get_Video_ai_assets_with_engine_assets.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_assets_with_engine_assets : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_assets_with_engine_assets.Exception_Message = ex.Message;
                oResult_Get_Video_ai_assets_with_engine_assets.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_assets_with_engine_assets;
        #endregion
    }
    #endregion
    #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv
    [HttpGet]
    [Route("Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv")]
    public Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv = new Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv();
        Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = new Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "")
            {
                oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST = HttpContext.Request.Query["SPACE_ASSET_ID_LIST"]
																						.ToString()
																						.Split(',')
																						.Where(val => long.TryParse(val, out _))
																						.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.i_Result = oBLC.Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv(oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List);
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.Exception_Message = string.Format("Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
    [HttpGet]
    [Route("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List")]
    public Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List = new Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List();
        Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List = new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["VIDEO_AI_ASSET_ID_REF_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_ASSET_ID_REF_LIST"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_ASSET_ID_REF_LIST"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_ASSET_ID_REF_LIST"].ToString() != "")
            {
                oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.VIDEO_AI_ASSET_ID_REF_LIST = HttpContext.Request.Query["VIDEO_AI_ASSET_ID_REF_LIST"]
																										.ToString()
																										.Split(',')
																										.Where(val => int.TryParse(val, out _))
																										.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.i_Result = oBLC.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List(oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List);
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List = oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List = oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.Exception_Message = string.Format("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List : {0}", ex.Message);
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.Exception_Message = ex.Message;
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List;
        #endregion
    }
    #endregion
    #region Create_Video_ai_instance
    [HttpPost]
    [Route("Create_Video_ai_instance")]
    public Result_Create_Video_ai_instance Create_Video_ai_instance(Params_Create_Video_ai_instance i_Params_Create_Video_ai_instance)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Create_Video_ai_instance oResult_Create_Video_ai_instance = new Result_Create_Video_ai_instance();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Create_Video_ai_instance.i_Result = oBLC.Create_Video_ai_instance(i_Params_Create_Video_ai_instance);
                oResult_Create_Video_ai_instance.Params_Create_Video_ai_instance = i_Params_Create_Video_ai_instance;
            }
        }
        catch (Exception ex)
        {
            oResult_Create_Video_ai_instance.Params_Create_Video_ai_instance = i_Params_Create_Video_ai_instance;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Create_Video_ai_instance.Exception_Message = string.Format("Create_Video_ai_instance : {0}", ex.Message);
                oResult_Create_Video_ai_instance.Stack_Trace = is_send_stack_trace ? string.Format("Create_Video_ai_instance : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Create_Video_ai_instance.Exception_Message = ex.Message;
                oResult_Create_Video_ai_instance.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Create_Video_ai_instance;
        #endregion
    }
    #endregion
    #region Delete_Video_ai_engine
    [HttpDelete]
    [Route("Delete_Video_ai_engine/{VIDEO_AI_ENGINE_ID}")]
    public Result_Delete_Video_ai_engine Delete_Video_ai_engine(int? VIDEO_AI_ENGINE_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Video_ai_engine oParams_Delete_Video_ai_engine = new Params_Delete_Video_ai_engine()
        {
            VIDEO_AI_ENGINE_ID = VIDEO_AI_ENGINE_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Video_ai_engine oResult_Delete_Video_ai_engine = new Result_Delete_Video_ai_engine();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oBLC.Delete_Video_ai_engine(oParams_Delete_Video_ai_engine);
                oResult_Delete_Video_ai_engine.Params_Delete_Video_ai_engine = oParams_Delete_Video_ai_engine;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Video_ai_engine.Params_Delete_Video_ai_engine = oParams_Delete_Video_ai_engine;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Video_ai_engine.Exception_Message = string.Format("Delete_Video_ai_engine : {0}", ex.Message);
                oResult_Delete_Video_ai_engine.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Video_ai_engine : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Video_ai_engine.Exception_Message = ex.Message;
                oResult_Delete_Video_ai_engine.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Video_ai_engine;
        #endregion
    }
    #endregion
    #region Fetch_Face_Target_Categories
    [HttpGet]
    [Route("Fetch_Face_Target_Categories")]
    public Result_Fetch_Face_Target_Categories Fetch_Face_Target_Categories()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Fetch_Face_Target_Categories oResult_Fetch_Face_Target_Categories = new Result_Fetch_Face_Target_Categories();
        Params_Fetch_Face_Target_Categories oParams_Fetch_Face_Target_Categories = new Params_Fetch_Face_Target_Categories();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Fetch_Face_Target_Categories.VIDEO_AI_INSTANCE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_INSTANCE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Fetch_Face_Target_Categories.i_Result = oBLC.Fetch_Face_Target_Categories(oParams_Fetch_Face_Target_Categories);
                oResult_Fetch_Face_Target_Categories.Params_Fetch_Face_Target_Categories = oParams_Fetch_Face_Target_Categories;
            }
        }
        catch (Exception ex)
        {
            oResult_Fetch_Face_Target_Categories.Params_Fetch_Face_Target_Categories = oParams_Fetch_Face_Target_Categories;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Fetch_Face_Target_Categories.Exception_Message = string.Format("Fetch_Face_Target_Categories : {0}", ex.Message);
                oResult_Fetch_Face_Target_Categories.Stack_Trace = is_send_stack_trace ? string.Format("Fetch_Face_Target_Categories : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Fetch_Face_Target_Categories.Exception_Message = ex.Message;
                oResult_Fetch_Face_Target_Categories.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Fetch_Face_Target_Categories;
        #endregion
    }
    #endregion
    #region Get_Vehicle_Countings
    [HttpPost]
    [Route("Get_Vehicle_Countings")]
    public Result_Get_Vehicle_Countings Get_Vehicle_Countings(Params_Get_Vehicle_Countings i_Params_Get_Vehicle_Countings)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Vehicle_Countings oResult_Get_Vehicle_Countings = new Result_Get_Vehicle_Countings();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Vehicle_Countings.i_Result = oBLC.Get_Vehicle_Countings(i_Params_Get_Vehicle_Countings);
                oResult_Get_Vehicle_Countings.Params_Get_Vehicle_Countings = i_Params_Get_Vehicle_Countings;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Vehicle_Countings.Params_Get_Vehicle_Countings = i_Params_Get_Vehicle_Countings;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Vehicle_Countings.Exception_Message = string.Format("Get_Vehicle_Countings : {0}", ex.Message);
                oResult_Get_Vehicle_Countings.Stack_Trace = is_send_stack_trace ? string.Format("Get_Vehicle_Countings : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Vehicle_Countings.Exception_Message = ex.Message;
                oResult_Get_Vehicle_Countings.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Vehicle_Countings;
        #endregion
    }
    #endregion
    #region Edit_Video_ai_instance_custom
    [HttpPost]
    [Route("Edit_Video_ai_instance_custom")]
    public Result_Edit_Video_ai_instance_custom Edit_Video_ai_instance_custom(Params_Edit_Video_ai_instance_custom i_Params_Edit_Video_ai_instance_custom)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Video_ai_instance_custom oResult_Edit_Video_ai_instance_custom = new Result_Edit_Video_ai_instance_custom();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Edit_Video_ai_instance_custom.i_Result = oBLC.Edit_Video_ai_instance_custom(i_Params_Edit_Video_ai_instance_custom);
                oResult_Edit_Video_ai_instance_custom.Params_Edit_Video_ai_instance_custom = i_Params_Edit_Video_ai_instance_custom;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Video_ai_instance_custom.Params_Edit_Video_ai_instance_custom = i_Params_Edit_Video_ai_instance_custom;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Video_ai_instance_custom.Exception_Message = string.Format("Edit_Video_ai_instance_custom : {0}", ex.Message);
                oResult_Edit_Video_ai_instance_custom.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Video_ai_instance_custom : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Video_ai_instance_custom.Exception_Message = ex.Message;
                oResult_Edit_Video_ai_instance_custom.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Video_ai_instance_custom;
        #endregion
    }
    #endregion
    #region Send_Alerts_Email
    [HttpPost]
    [Route("Send_Alerts_Email")]
    public Result_Send_Alerts_Email Send_Alerts_Email(Params_Send_Alerts_Email i_Params_Send_Alerts_Email)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Send_Alerts_Email oResult_Send_Alerts_Email = new Result_Send_Alerts_Email();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Send_Alerts_Email.i_Result = oBLC.Send_Alerts_Email(i_Params_Send_Alerts_Email);
                oResult_Send_Alerts_Email.Params_Send_Alerts_Email = i_Params_Send_Alerts_Email;
            }
        }
        catch (Exception ex)
        {
            oResult_Send_Alerts_Email.Params_Send_Alerts_Email = i_Params_Send_Alerts_Email;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Send_Alerts_Email.Exception_Message = string.Format("Send_Alerts_Email : {0}", ex.Message);
                oResult_Send_Alerts_Email.Stack_Trace = is_send_stack_trace ? string.Format("Send_Alerts_Email : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Send_Alerts_Email.Exception_Message = ex.Message;
                oResult_Send_Alerts_Email.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Send_Alerts_Email;
        #endregion
    }
    #endregion
    #region Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv
    [HttpGet]
    [Route("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv")]
    public Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv = new Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv();
        Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID = new Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["VIDEO_AI_ASSET_ID"].FirstOrDefault() != null && HttpContext.Request.Query["VIDEO_AI_ASSET_ID"].ToString() != "undefined" && HttpContext.Request.Query["VIDEO_AI_ASSET_ID"].ToString() != "null" && HttpContext.Request.Query["VIDEO_AI_ASSET_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID.VIDEO_AI_ASSET_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["VIDEO_AI_ASSET_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.i_Result = oBLC.Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv(oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID);
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID = oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID = oParams_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.Exception_Message = string.Format("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv : {0}", ex.Message);
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv;
        #endregion
    }
    #endregion
    #region Delete_Video_ai_instance
    [HttpPost]
    [Route("Delete_Video_ai_instance")]
    public Result_Delete_Video_ai_instance Delete_Video_ai_instance(Params_Delete_Video_ai_instance i_Params_Delete_Video_ai_instance)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Video_ai_instance oResult_Delete_Video_ai_instance = new Result_Delete_Video_ai_instance();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oBLC.Delete_Video_ai_instance(i_Params_Delete_Video_ai_instance);
                oResult_Delete_Video_ai_instance.Params_Delete_Video_ai_instance = i_Params_Delete_Video_ai_instance;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Video_ai_instance.Params_Delete_Video_ai_instance = i_Params_Delete_Video_ai_instance;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Video_ai_instance.Exception_Message = string.Format("Delete_Video_ai_instance : {0}", ex.Message);
                oResult_Delete_Video_ai_instance.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Video_ai_instance : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Video_ai_instance.Exception_Message = ex.Message;
                oResult_Delete_Video_ai_instance.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Video_ai_instance;
        #endregion
    }
    #endregion
    #region Edit_Video_ai_instance
    [HttpPost]
    [Route("Edit_Video_ai_instance")]
    public Result_Edit_Video_ai_instance Edit_Video_ai_instance(Video_ai_instance i_Video_ai_instance)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Video_ai_instance oResult_Edit_Video_ai_instance = new Result_Edit_Video_ai_instance();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oBLC.Edit_Video_ai_instance(i_Video_ai_instance);
                oResult_Edit_Video_ai_instance.Video_ai_instance = i_Video_ai_instance;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Video_ai_instance.Exception_Message = string.Format("Edit_Video_ai_instance : {0}", ex.Message);
                oResult_Edit_Video_ai_instance.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Video_ai_instance : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Video_ai_instance.Exception_Message = ex.Message;
                oResult_Edit_Video_ai_instance.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Video_ai_instance;
        #endregion
    }
    #endregion
    #region Edit_Video_ai_engine_List
    [HttpPost]
    [Route("Edit_Video_ai_engine_List")]
    public Result_Edit_Video_ai_engine_List Edit_Video_ai_engine_List(Params_Edit_Video_ai_engine_List i_Params_Edit_Video_ai_engine_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Video_ai_engine_List oResult_Edit_Video_ai_engine_List = new Result_Edit_Video_ai_engine_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oBLC.Edit_Video_ai_engine_List(i_Params_Edit_Video_ai_engine_List);
                oResult_Edit_Video_ai_engine_List.Params_Edit_Video_ai_engine_List = i_Params_Edit_Video_ai_engine_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Video_ai_engine_List.Exception_Message = string.Format("Edit_Video_ai_engine_List : {0}", ex.Message);
                oResult_Edit_Video_ai_engine_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Video_ai_engine_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Video_ai_engine_List.Exception_Message = ex.Message;
                oResult_Edit_Video_ai_engine_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Video_ai_engine_List;
        #endregion
    }
    #endregion
    #region Edit_Video_ai_engine
    [HttpPost]
    [Route("Edit_Video_ai_engine")]
    public Result_Edit_Video_ai_engine Edit_Video_ai_engine(Video_ai_engine i_Video_ai_engine)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Video_ai_engine oResult_Edit_Video_ai_engine = new Result_Edit_Video_ai_engine();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oBLC.Edit_Video_ai_engine(i_Video_ai_engine);
                oResult_Edit_Video_ai_engine.Video_ai_engine = i_Video_ai_engine;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Video_ai_engine.Exception_Message = string.Format("Edit_Video_ai_engine : {0}", ex.Message);
                oResult_Edit_Video_ai_engine.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Video_ai_engine : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Video_ai_engine.Exception_Message = ex.Message;
                oResult_Edit_Video_ai_engine.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Video_ai_engine;
        #endregion
    }
    #endregion
    #region Get_Sites_and_Entities
    [HttpGet]
    [Route("Get_Sites_and_Entities")]
    public Result_Get_Sites_and_Entities Get_Sites_and_Entities()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Sites_and_Entities oResult_Get_Sites_and_Entities = new Result_Get_Sites_and_Entities();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Sites_and_Entities.i_Result = oBLC.Get_Sites_and_Entities();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Sites_and_Entities.Exception_Message = string.Format("Get_Sites_and_Entities : {0}", ex.Message);
                oResult_Get_Sites_and_Entities.Stack_Trace = is_send_stack_trace ? string.Format("Get_Sites_and_Entities : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Sites_and_Entities.Exception_Message = ex.Message;
                oResult_Get_Sites_and_Entities.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Sites_and_Entities;
        #endregion
    }
    #endregion
}

#region Action_Result
public partial class Action_Result
{
    #region Properties.
    public string Stack_Trace { get; set; }
    public string Exception_Message { get; set; }
    #endregion
    #region Constructor
    public Action_Result()
    {
        #region Body Section.
        this.Stack_Trace = string.Empty;
        this.Exception_Message = string.Empty;
        #endregion
    }
    #endregion
}
#endregion
#region Result_Fetch_Scenes
public partial class Result_Fetch_Scenes : Action_Result
{
    #region Properties.
    public Fetch_Scenes_Response i_Result { get; set; }
    public Params_Fetch_Scenes Params_Fetch_Scenes { get; set; }
    #endregion
}
#endregion
#region Result_Get_Vehicle_Types
public partial class Result_Get_Vehicle_Types : Action_Result
{
    #region Properties.
    public List<string> i_Result { get; set; }
    public Params_Get_Vehicle_Types Params_Get_Vehicle_Types { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID
public partial class Result_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID : Action_Result
{
    #region Properties.
    public Video_ai_instance i_Result { get; set; }
    public Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID Params_Get_Video_ai_instance_By_VIDEO_AI_INSTANCE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID
public partial class Result_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID : Action_Result
{
    #region Properties.
    public List<Video_ai_instance> i_Result { get; set; }
    public Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Create_Video_ai_asset
public partial class Result_Create_Video_ai_asset : Action_Result
{
    #region Properties.
    public Video_ai_asset i_Result { get; set; }
    public Params_Create_Video_ai_asset Params_Create_Video_ai_asset { get; set; }
    #endregion
}
#endregion
#region Result_Update_License_Plate_Recognition_Alerts
public partial class Result_Update_License_Plate_Recognition_Alerts : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Change_Video_ai_instance_Password
public partial class Result_Change_Video_ai_instance_Password : Action_Result
{
    #region Properties.
    public Change_Video_ai_instance_Password_Response i_Result { get; set; }
    public Params_Change_Video_ai_instance_Password Params_Change_Video_ai_instance_Password { get; set; }
    #endregion
}
#endregion
#region Result_Face_Target_Key_Search
public partial class Result_Face_Target_Key_Search : Action_Result
{
    #region Properties.
    public Search_Face_Target_Key_Response_List i_Result { get; set; }
    public Params_Face_Target_Key_Search Params_Face_Target_Key_Search { get; set; }
    #endregion
}
#endregion
#region Result_Face_Search
public partial class Result_Face_Search : Action_Result
{
    #region Properties.
    public Face_Key_Response_List i_Result { get; set; }
    public Params_Face_Search Params_Face_Search { get; set; }
    #endregion
}
#endregion
#region Result_Fetch_License_Plate_Categories
public partial class Result_Fetch_License_Plate_Categories : Action_Result
{
    #region Properties.
    public List<License_Plate_Category> i_Result { get; set; }
    public Params_Fetch_License_Plate_Categories Params_Fetch_License_Plate_Categories { get; set; }
    #endregion
}
#endregion
#region Result_Fetch_Face_Targets
public partial class Result_Fetch_Face_Targets : Action_Result
{
    #region Properties.
    public Fetch_Face_Targets_Response i_Result { get; set; }
    public Params_Fetch_Face_Targets Params_Fetch_Face_Targets { get; set; }
    #endregion
}
#endregion
#region Result_Fetch_Facial_Recognition
public partial class Result_Fetch_Facial_Recognition : Action_Result
{
    #region Properties.
    public Fetch_Facial_Recognition_Reponse i_Result { get; set; }
    public Params_Fetch_Facial_Recognition Params_Fetch_Facial_Recognition { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Video_ai_asset_Custom
public partial class Result_Delete_Video_ai_asset_Custom : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Delete_Video_ai_asset_Custom Params_Delete_Video_ai_asset_Custom { get; set; }
    #endregion
}
#endregion
#region Result_Update_Facial_Recognition_Alerts
public partial class Result_Update_Facial_Recognition_Alerts : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_engine_By_OWNER_ID
public partial class Result_Get_Video_ai_engine_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Video_ai_engine> i_Result { get; set; }
    public Params_Get_Video_ai_engine_By_OWNER_ID Params_Get_Video_ai_engine_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Fetch_License_Plate_Targets
public partial class Result_Fetch_License_Plate_Targets : Action_Result
{
    #region Properties.
    public Fetch_License_Plate_Targets_Response i_Result { get; set; }
    public Params_Fetch_License_Plate_Targets Params_Fetch_License_Plate_Targets { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_asset_By_OWNER_ID
public partial class Result_Get_Video_ai_asset_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Video_ai_asset> i_Result { get; set; }
    public Params_Get_Video_ai_asset_By_OWNER_ID Params_Get_Video_ai_asset_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Stream_Data
public partial class Result_Get_Stream_Data : Action_Result
{
    #region Properties.
    public Stream_Data i_Result { get; set; }
    public Params_Get_Stream_Data Params_Get_Stream_Data { get; set; }
    #endregion
}
#endregion
#region Result_Fetch_License_Plate_Recognition
public partial class Result_Fetch_License_Plate_Recognition : Action_Result
{
    #region Properties.
    public Fetch_License_Plate_Recognition_Response i_Result { get; set; }
    public Params_Fetch_License_Plate_Recognition Params_Fetch_License_Plate_Recognition { get; set; }
    #endregion
}
#endregion
#region Result_Get_Scene_Info
public partial class Result_Get_Scene_Info : Action_Result
{
    #region Properties.
    public Scene_Info i_Result { get; set; }
    public Params_Get_Scene_Info Params_Get_Scene_Info { get; set; }
    #endregion
}
#endregion
#region Result_Update_Alerts_Custom
public partial class Result_Update_Alerts_Custom : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Get_Countings
public partial class Result_Get_Countings : Action_Result
{
    #region Properties.
    public List<Get_Countings_Response> i_Result { get; set; }
    public Params_Get_Countings Params_Get_Countings { get; set; }
    #endregion
}
#endregion
#region Result_Get_Camera_Lines
public partial class Result_Get_Camera_Lines : Action_Result
{
    #region Properties.
    public List<Camera_Lines> i_Result { get; set; }
    public Params_Get_Camera_Lines Params_Get_Camera_Lines { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Video_ai_asset
public partial class Result_Edit_Video_ai_asset : Action_Result
{
    #region Properties.
    public Video_ai_asset Video_ai_asset { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_asset_Vaidio_camera
public partial class Result_Get_Space_asset_Vaidio_camera : Action_Result
{
    #region Properties.
    public Video_ai_asset i_Result { get; set; }
    public Params_Get_Space_asset_Vaidio_camera Params_Get_Space_asset_Vaidio_camera { get; set; }
    #endregion
}
#endregion
#region Result_Update_Alerts
public partial class Result_Update_Alerts : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Get_License_Plate_Scene
public partial class Result_Get_License_Plate_Scene : Action_Result
{
    #region Properties.
    public Scene_Details i_Result { get; set; }
    public Params_Get_License_Plate_Scene Params_Get_License_Plate_Scene { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_assets_with_engine_assets
public partial class Result_Get_Video_ai_assets_with_engine_assets : Action_Result
{
    #region Properties.
    public Video_ai_assets_with_engine_assets i_Result { get; set; }
    public Params_Get_Video_ai_assets_with_engine_assets Params_Get_Video_ai_assets_with_engine_assets { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv
public partial class Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Video_ai_asset> i_Result { get; set; }
    public Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List
public partial class Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List : Action_Result
{
    #region Properties.
    public List<Video_ai_asset> i_Result { get; set; }
    public Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_REF_List { get; set; }
    #endregion
}
#endregion
#region Result_Create_Video_ai_instance
public partial class Result_Create_Video_ai_instance : Action_Result
{
    #region Properties.
    public Video_ai_instance i_Result { get; set; }
    public Params_Create_Video_ai_instance Params_Create_Video_ai_instance { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Video_ai_engine
public partial class Result_Delete_Video_ai_engine : Action_Result
{
    #region Properties.
    public Params_Delete_Video_ai_engine Params_Delete_Video_ai_engine { get; set; }
    #endregion
}
#endregion
#region Result_Fetch_Face_Target_Categories
public partial class Result_Fetch_Face_Target_Categories : Action_Result
{
    #region Properties.
    public List<Face_Target_Response_Category> i_Result { get; set; }
    public Params_Fetch_Face_Target_Categories Params_Fetch_Face_Target_Categories { get; set; }
    #endregion
}
#endregion
#region Result_Get_Vehicle_Countings
public partial class Result_Get_Vehicle_Countings : Action_Result
{
    #region Properties.
    public Vehicle_Counting i_Result { get; set; }
    public Params_Get_Vehicle_Countings Params_Get_Vehicle_Countings { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Video_ai_instance_custom
public partial class Result_Edit_Video_ai_instance_custom : Action_Result
{
    #region Properties.
    public Video_ai_instance_with_connection_flag i_Result { get; set; }
    public Params_Edit_Video_ai_instance_custom Params_Edit_Video_ai_instance_custom { get; set; }
    #endregion
}
#endregion
#region Result_Send_Alerts_Email
public partial class Result_Send_Alerts_Email : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Send_Alerts_Email Params_Send_Alerts_Email { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv
public partial class Result_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID_Adv : Action_Result
{
    #region Properties.
    public Video_ai_asset i_Result { get; set; }
    public Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID Params_Get_Video_ai_asset_By_VIDEO_AI_ASSET_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Video_ai_instance
public partial class Result_Delete_Video_ai_instance : Action_Result
{
    #region Properties.
    public Params_Delete_Video_ai_instance Params_Delete_Video_ai_instance { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Video_ai_instance
public partial class Result_Edit_Video_ai_instance : Action_Result
{
    #region Properties.
    public Video_ai_instance Video_ai_instance { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Video_ai_engine_List
public partial class Result_Edit_Video_ai_engine_List : Action_Result
{
    #region Properties.
    public Params_Edit_Video_ai_engine_List Params_Edit_Video_ai_engine_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Video_ai_engine
public partial class Result_Edit_Video_ai_engine : Action_Result
{
    #region Properties.
    public Video_ai_engine Video_ai_engine { get; set; }
    #endregion
}
#endregion
#region Result_Get_Sites_and_Entities
public partial class Result_Get_Sites_and_Entities : Action_Result
{
    #region Properties.
    public Sites_and_Entities i_Result { get; set; }
    #endregion
}
#endregion
