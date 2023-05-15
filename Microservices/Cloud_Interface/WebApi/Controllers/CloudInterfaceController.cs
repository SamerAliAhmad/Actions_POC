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
public partial class CloudInterfaceController : ControllerBase
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
    #region Get_Secret
    [HttpGet]
    [Route("Get_Secret")]
    public Result_Get_Secret Get_Secret()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Secret oResult_Get_Secret = new Result_Get_Secret();
        Params_Get_Secret oParams_Get_Secret = new Params_Get_Secret();
        #endregion
        #region Body Section.
        try
        {
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["Secret_Id"].FirstOrDefault() != null && HttpContext.Request.Query["Secret_Id"].ToString() != "undefined" && HttpContext.Request.Query["Secret_Id"].ToString() != "null" && HttpContext.Request.Query["Secret_Id"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Get_Secret.Secret_Id = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["Secret_Id"].ToString());
            }
            if (HttpContext.Request.Query["Secret_Version"].FirstOrDefault() != null && HttpContext.Request.Query["Secret_Version"].ToString() != "undefined" && HttpContext.Request.Query["Secret_Version"].ToString() != "null" && HttpContext.Request.Query["Secret_Version"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Get_Secret.Secret_Version = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["Secret_Version"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Secret.i_Result = oBLC.Get_Secret(oParams_Get_Secret);
                oResult_Get_Secret.Params_Get_Secret = oParams_Get_Secret;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Secret.Params_Get_Secret = oParams_Get_Secret;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Secret.Exception_Message = string.Format("Get_Secret : {0}", ex.Message);
                oResult_Get_Secret.Stack_Trace = is_send_stack_trace ? string.Format("Get_Secret : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Secret.Exception_Message = ex.Message;
                oResult_Get_Secret.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Secret;
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
#region Result_Get_Secret
public partial class Result_Get_Secret : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Get_Secret Params_Get_Secret { get; set; }
    #endregion
}
#endregion
