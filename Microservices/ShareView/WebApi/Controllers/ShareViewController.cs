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
public partial class ShareViewController : ControllerBase
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
    #region Edit_Entity_share_data
    [HttpPost]
    [Route("Edit_Entity_share_data")]
    public Result_Edit_Entity_share_data Edit_Entity_share_data(Params_Edit_Entity_share_data i_Params_Edit_Entity_share_data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_share_data oResult_Edit_Entity_share_data = new Result_Edit_Entity_share_data();
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
                oResult_Edit_Entity_share_data.i_Result = oBLC.Edit_Entity_share_data(i_Params_Edit_Entity_share_data);
                oResult_Edit_Entity_share_data.Params_Edit_Entity_share_data = i_Params_Edit_Entity_share_data;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Entity_share_data.Params_Edit_Entity_share_data = i_Params_Edit_Entity_share_data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_share_data.Exception_Message = string.Format("Edit_Entity_share_data : {0}", ex.Message);
                oResult_Edit_Entity_share_data.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_share_data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_share_data.Exception_Message = ex.Message;
                oResult_Edit_Entity_share_data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_share_data;
        #endregion
    }
    #endregion
    #region Get_Share_file_By_USER_ID
    [HttpGet]
    [Route("Get_Share_file_By_USER_ID")]
    public Result_Get_Share_file_By_USER_ID Get_Share_file_By_USER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Share_file_By_USER_ID oResult_Get_Share_file_By_USER_ID = new Result_Get_Share_file_By_USER_ID();
        Params_Get_Share_file_By_USER_ID oParams_Get_Share_file_By_USER_ID = new Params_Get_Share_file_By_USER_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["USER_ID"].FirstOrDefault() != null && HttpContext.Request.Query["USER_ID"].ToString() != "undefined" && HttpContext.Request.Query["USER_ID"].ToString() != "null" && HttpContext.Request.Query["USER_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Share_file_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Share_file_By_USER_ID.i_Result = oBLC.Get_Share_file_By_USER_ID(oParams_Get_Share_file_By_USER_ID);
                oResult_Get_Share_file_By_USER_ID.Params_Get_Share_file_By_USER_ID = oParams_Get_Share_file_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Share_file_By_USER_ID.Params_Get_Share_file_By_USER_ID = oParams_Get_Share_file_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Share_file_By_USER_ID.Exception_Message = string.Format("Get_Share_file_By_USER_ID : {0}", ex.Message);
                oResult_Get_Share_file_By_USER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Share_file_By_USER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Share_file_By_USER_ID.Exception_Message = ex.Message;
                oResult_Get_Share_file_By_USER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Share_file_By_USER_ID;
        #endregion
    }
    #endregion
    #region Get_Share_file_By_SHARE_FILE_ID
    [HttpGet]
    [Route("Get_Share_file_By_SHARE_FILE_ID")]
    public Result_Get_Share_file_By_SHARE_FILE_ID Get_Share_file_By_SHARE_FILE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Share_file_By_SHARE_FILE_ID oResult_Get_Share_file_By_SHARE_FILE_ID = new Result_Get_Share_file_By_SHARE_FILE_ID();
        Params_Get_Share_file_By_SHARE_FILE_ID oParams_Get_Share_file_By_SHARE_FILE_ID = new Params_Get_Share_file_By_SHARE_FILE_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SHARE_FILE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SHARE_FILE_ID"].ToString() != "undefined" && HttpContext.Request.Query["SHARE_FILE_ID"].ToString() != "null" && HttpContext.Request.Query["SHARE_FILE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Share_file_By_SHARE_FILE_ID.SHARE_FILE_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SHARE_FILE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Share_file_By_SHARE_FILE_ID.i_Result = oBLC.Get_Share_file_By_SHARE_FILE_ID(oParams_Get_Share_file_By_SHARE_FILE_ID);
                oResult_Get_Share_file_By_SHARE_FILE_ID.Params_Get_Share_file_By_SHARE_FILE_ID = oParams_Get_Share_file_By_SHARE_FILE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Share_file_By_SHARE_FILE_ID.Params_Get_Share_file_By_SHARE_FILE_ID = oParams_Get_Share_file_By_SHARE_FILE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Share_file_By_SHARE_FILE_ID.Exception_Message = string.Format("Get_Share_file_By_SHARE_FILE_ID : {0}", ex.Message);
                oResult_Get_Share_file_By_SHARE_FILE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Share_file_By_SHARE_FILE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Share_file_By_SHARE_FILE_ID.Exception_Message = ex.Message;
                oResult_Get_Share_file_By_SHARE_FILE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Share_file_By_SHARE_FILE_ID;
        #endregion
    }
    #endregion
    #region Get_Entity_share_view_data
    [HttpPost]
    [Route("Get_Entity_share_view_data")]
    public Result_Get_Entity_share_view_data Get_Entity_share_view_data(Params_Get_Entity_share_view_data i_Params_Get_Entity_share_view_data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_share_view_data oResult_Get_Entity_share_view_data = new Result_Get_Entity_share_view_data();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_share_view_data.i_Result = oBLC.Get_Entity_share_view_data(i_Params_Get_Entity_share_view_data);
                oResult_Get_Entity_share_view_data.Params_Get_Entity_share_view_data = i_Params_Get_Entity_share_view_data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_share_view_data.Params_Get_Entity_share_view_data = i_Params_Get_Entity_share_view_data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_share_view_data.Exception_Message = string.Format("Get_Entity_share_view_data : {0}", ex.Message);
                oResult_Get_Entity_share_view_data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_share_view_data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_share_view_data.Exception_Message = ex.Message;
                oResult_Get_Entity_share_view_data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_share_view_data;
        #endregion
    }
    #endregion
    #region Send_Share_Link_By_Email
    [HttpPost]
    [Route("Send_Share_Link_By_Email")]
    public Result_Send_Share_Link_By_Email Send_Share_Link_By_Email(Params_Send_Share_Link_By_Email i_Params_Send_Share_Link_By_Email)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Send_Share_Link_By_Email oResult_Send_Share_Link_By_Email = new Result_Send_Share_Link_By_Email();
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
                oResult_Send_Share_Link_By_Email.i_Result = oBLC.Send_Share_Link_By_Email(i_Params_Send_Share_Link_By_Email);
                oResult_Send_Share_Link_By_Email.Params_Send_Share_Link_By_Email = i_Params_Send_Share_Link_By_Email;
            }
        }
        catch (Exception ex)
        {
            oResult_Send_Share_Link_By_Email.Params_Send_Share_Link_By_Email = i_Params_Send_Share_Link_By_Email;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Send_Share_Link_By_Email.Exception_Message = string.Format("Send_Share_Link_By_Email : {0}", ex.Message);
                oResult_Send_Share_Link_By_Email.Stack_Trace = is_send_stack_trace ? string.Format("Send_Share_Link_By_Email : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Send_Share_Link_By_Email.Exception_Message = ex.Message;
                oResult_Send_Share_Link_By_Email.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Send_Share_Link_By_Email;
        #endregion
    }
    #endregion
    #region Delete_Share_file
    [HttpPost]
    [Route("Delete_Share_file")]
    public Result_Delete_Share_file Delete_Share_file(Params_Delete_Share_file i_Params_Delete_Share_file)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Share_file oResult_Delete_Share_file = new Result_Delete_Share_file();
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
                oBLC.Delete_Share_file(i_Params_Delete_Share_file);
                oResult_Delete_Share_file.Params_Delete_Share_file = i_Params_Delete_Share_file;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Share_file.Params_Delete_Share_file = i_Params_Delete_Share_file;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Share_file.Exception_Message = string.Format("Delete_Share_file : {0}", ex.Message);
                oResult_Delete_Share_file.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Share_file : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Share_file.Exception_Message = ex.Message;
                oResult_Delete_Share_file.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Share_file;
        #endregion
    }
    #endregion
    #region Edit_Share_file
    [HttpPost]
    [Route("Edit_Share_file")]
    public Result_Edit_Share_file Edit_Share_file(Share_file i_Share_file)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Share_file oResult_Edit_Share_file = new Result_Edit_Share_file();
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
                oBLC.Edit_Share_file(i_Share_file);
                oResult_Edit_Share_file.Share_file = i_Share_file;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Share_file.Exception_Message = string.Format("Edit_Share_file : {0}", ex.Message);
                oResult_Edit_Share_file.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Share_file : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Share_file.Exception_Message = ex.Message;
                oResult_Edit_Share_file.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Share_file;
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
#region Result_Edit_Entity_share_data
public partial class Result_Edit_Entity_share_data : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Edit_Entity_share_data Params_Edit_Entity_share_data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Share_file_By_USER_ID
public partial class Result_Get_Share_file_By_USER_ID : Action_Result
{
    #region Properties.
    public List<Share_file> i_Result { get; set; }
    public Params_Get_Share_file_By_USER_ID Params_Get_Share_file_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Share_file_By_SHARE_FILE_ID
public partial class Result_Get_Share_file_By_SHARE_FILE_ID : Action_Result
{
    #region Properties.
    public Share_file i_Result { get; set; }
    public Params_Get_Share_file_By_SHARE_FILE_ID Params_Get_Share_file_By_SHARE_FILE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_share_view_data
public partial class Result_Get_Entity_share_view_data : Action_Result
{
    #region Properties.
    public Entity_share_view_data i_Result { get; set; }
    public Params_Get_Entity_share_view_data Params_Get_Entity_share_view_data { get; set; }
    #endregion
}
#endregion
#region Result_Send_Share_Link_By_Email
public partial class Result_Send_Share_Link_By_Email : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Send_Share_Link_By_Email Params_Send_Share_Link_By_Email { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Share_file
public partial class Result_Delete_Share_file : Action_Result
{
    #region Properties.
    public Params_Delete_Share_file Params_Delete_Share_file { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Share_file
public partial class Result_Edit_Share_file : Action_Result
{
    #region Properties.
    public Share_file Share_file { get; set; }
    #endregion
}
#endregion
