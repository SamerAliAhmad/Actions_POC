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
public partial class PlatformLoggingController : ControllerBase
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
    #region Get_Logs_With_Filters
    [HttpPost]
    [Route("Get_Logs_With_Filters")]
    public Result_Get_Logs_With_Filters Get_Logs_With_Filters(Params_Get_Logs_With_Filters i_Params_Get_Logs_With_Filters)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Logs_With_Filters oResult_Get_Logs_With_Filters = new Result_Get_Logs_With_Filters();
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
                oResult_Get_Logs_With_Filters.i_Result = oBLC.Get_Logs_With_Filters(i_Params_Get_Logs_With_Filters);
                oResult_Get_Logs_With_Filters.Params_Get_Logs_With_Filters = i_Params_Get_Logs_With_Filters;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Logs_With_Filters.Params_Get_Logs_With_Filters = i_Params_Get_Logs_With_Filters;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Logs_With_Filters.Exception_Message = string.Format("Get_Logs_With_Filters : {0}", ex.Message);
                oResult_Get_Logs_With_Filters.Stack_Trace = is_send_stack_trace ? string.Format("Get_Logs_With_Filters : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Logs_With_Filters.Exception_Message = ex.Message;
                oResult_Get_Logs_With_Filters.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Logs_With_Filters;
        #endregion
    }
    #endregion
    #region Generate_Logs_Excel
    [HttpPost]
    [Route("Generate_Logs_Excel")]
    public Result_Generate_Logs_Excel Generate_Logs_Excel(Params_Generate_Logs_Excel i_Params_Generate_Logs_Excel)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Logs_Excel oResult_Generate_Logs_Excel = new Result_Generate_Logs_Excel();
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
                oResult_Generate_Logs_Excel.i_Result = oBLC.Generate_Logs_Excel(i_Params_Generate_Logs_Excel);
                oResult_Generate_Logs_Excel.Params_Generate_Logs_Excel = i_Params_Generate_Logs_Excel;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Logs_Excel.Params_Generate_Logs_Excel = i_Params_Generate_Logs_Excel;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Logs_Excel.Exception_Message = string.Format("Generate_Logs_Excel : {0}", ex.Message);
                oResult_Generate_Logs_Excel.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Logs_Excel : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Logs_Excel.Exception_Message = ex.Message;
                oResult_Generate_Logs_Excel.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Logs_Excel;
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
#region Result_Get_Logs_With_Filters
public partial class Result_Get_Logs_With_Filters : Action_Result
{
    #region Properties.
    public Log_With_Count i_Result { get; set; }
    public Params_Get_Logs_With_Filters Params_Get_Logs_With_Filters { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Logs_Excel
public partial class Result_Generate_Logs_Excel : Action_Result
{
    #region Properties.
    public Generate_Logs_Excel_Response i_Result { get; set; }
    public Params_Generate_Logs_Excel Params_Generate_Logs_Excel { get; set; }
    #endregion
}
#endregion
