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
public partial class ReportingController : ControllerBase
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
    #region Get_Report_Details
    [HttpPost]
    [Route("Get_Report_Details")]
    public Result_Get_Report_Details Get_Report_Details(Params_Get_Report_Details i_Params_Get_Report_Details)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Report_Details oResult_Get_Report_Details = new Result_Get_Report_Details();
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
                oResult_Get_Report_Details.i_Result = oBLC.Get_Report_Details(i_Params_Get_Report_Details);
                oResult_Get_Report_Details.Params_Get_Report_Details = i_Params_Get_Report_Details;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Report_Details.Params_Get_Report_Details = i_Params_Get_Report_Details;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Report_Details.Exception_Message = string.Format("Get_Report_Details : {0}", ex.Message);
                oResult_Get_Report_Details.Stack_Trace = is_send_stack_trace ? string.Format("Get_Report_Details : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Report_Details.Exception_Message = ex.Message;
                oResult_Get_Report_Details.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Report_Details;
        #endregion
    }
    #endregion
    #region Send_Report_Email
    [HttpPost]
    [Route("Send_Report_Email")]
    public Result_Send_Report_Email Send_Report_Email(Params_Send_Report_Email i_Params_Send_Report_Email)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Send_Report_Email oResult_Send_Report_Email = new Result_Send_Report_Email();
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
                oResult_Send_Report_Email.i_Result = oBLC.Send_Report_Email(i_Params_Send_Report_Email);
                oResult_Send_Report_Email.Params_Send_Report_Email = i_Params_Send_Report_Email;
            }
        }
        catch (Exception ex)
        {
            oResult_Send_Report_Email.Params_Send_Report_Email = i_Params_Send_Report_Email;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Send_Report_Email.Exception_Message = string.Format("Send_Report_Email : {0}", ex.Message);
                oResult_Send_Report_Email.Stack_Trace = is_send_stack_trace ? string.Format("Send_Report_Email : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Send_Report_Email.Exception_Message = ex.Message;
                oResult_Send_Report_Email.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Send_Report_Email;
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
#region Result_Get_Report_Details
public partial class Result_Get_Report_Details : Action_Result
{
    #region Properties.
    public Report_Details i_Result { get; set; }
    public Params_Get_Report_Details Params_Get_Report_Details { get; set; }
    #endregion
}
#endregion
#region Result_Send_Report_Email
public partial class Result_Send_Report_Email : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Send_Report_Email Params_Send_Report_Email { get; set; }
    #endregion
}
#endregion
