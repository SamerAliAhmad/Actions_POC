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
public partial class FileManagementController : ControllerBase
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
    #region Delete_Object
    [HttpDelete]
    [Route("Delete_Object/{Object_Name}")]
    public Result_Delete_Object Delete_Object(string Object_Name)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Object oParams_Delete_Object = new Params_Delete_Object()
        {
            Object_Name = Object_Name
        };
        string oTicket = string.Empty;
        Result_Delete_Object oResult_Delete_Object = new Result_Delete_Object();
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
                oBLC.Delete_Object(oParams_Delete_Object);
                oResult_Delete_Object.Params_Delete_Object = oParams_Delete_Object;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Object.Params_Delete_Object = oParams_Delete_Object;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Object.Exception_Message = string.Format("Delete_Object : {0}", ex.Message);
                oResult_Delete_Object.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Object : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Object.Exception_Message = ex.Message;
                oResult_Delete_Object.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Object;
        #endregion
    }
    #endregion
    #region Delete_Object_List
    [HttpPost]
    [Route("Delete_Object_List")]
    public Result_Delete_Object_List Delete_Object_List(Params_Delete_Object_List i_Params_Delete_Object_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Object_List oResult_Delete_Object_List = new Result_Delete_Object_List();
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
                oBLC.Delete_Object_List(i_Params_Delete_Object_List);
                oResult_Delete_Object_List.Params_Delete_Object_List = i_Params_Delete_Object_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Object_List.Params_Delete_Object_List = i_Params_Delete_Object_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Object_List.Exception_Message = string.Format("Delete_Object_List : {0}", ex.Message);
                oResult_Delete_Object_List.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Object_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Object_List.Exception_Message = ex.Message;
                oResult_Delete_Object_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Object_List;
        #endregion
    }
    #endregion
    #region Upload_Object
    [HttpPost]
    [Route("Upload_Object")]
    public Result_Upload_Object Upload_Object(Params_Upload_Object i_Params_Upload_Object)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Upload_Object oResult_Upload_Object = new Result_Upload_Object();
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
                oBLC.Upload_Object(i_Params_Upload_Object);
                oResult_Upload_Object.Params_Upload_Object = i_Params_Upload_Object;
            }
        }
        catch (Exception ex)
        {
            oResult_Upload_Object.Params_Upload_Object = i_Params_Upload_Object;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Upload_Object.Exception_Message = string.Format("Upload_Object : {0}", ex.Message);
                oResult_Upload_Object.Stack_Trace = is_send_stack_trace ? string.Format("Upload_Object : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Upload_Object.Exception_Message = ex.Message;
                oResult_Upload_Object.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Upload_Object;
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
#region Result_Delete_Object
public partial class Result_Delete_Object : Action_Result
{
    #region Properties.
    public Params_Delete_Object Params_Delete_Object { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Object_List
public partial class Result_Delete_Object_List : Action_Result
{
    #region Properties.
    public Params_Delete_Object_List Params_Delete_Object_List { get; set; }
    #endregion
}
#endregion
#region Result_Upload_Object
public partial class Result_Upload_Object : Action_Result
{
    #region Properties.
    public Params_Upload_Object Params_Upload_Object { get; set; }
    #endregion
}
#endregion
