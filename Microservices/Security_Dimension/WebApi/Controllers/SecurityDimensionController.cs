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
public partial class SecurityDimensionController : ControllerBase
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
    #region Get_Incidents_By_Where_Sorted_With_Pagination
    [HttpPost]
    [Route("Get_Incidents_By_Where_Sorted_With_Pagination")]
    public Result_Get_Incidents_By_Where_Sorted_With_Pagination Get_Incidents_By_Where_Sorted_With_Pagination(Params_Get_Incidents_By_Where_Sorted_With_Pagination i_Params_Get_Incidents_By_Where_Sorted_With_Pagination)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Incidents_By_Where_Sorted_With_Pagination oResult_Get_Incidents_By_Where_Sorted_With_Pagination = new Result_Get_Incidents_By_Where_Sorted_With_Pagination();
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
                oResult_Get_Incidents_By_Where_Sorted_With_Pagination.i_Result = oBLC.Get_Incidents_By_Where_Sorted_With_Pagination(i_Params_Get_Incidents_By_Where_Sorted_With_Pagination);
                oResult_Get_Incidents_By_Where_Sorted_With_Pagination.Params_Get_Incidents_By_Where_Sorted_With_Pagination = i_Params_Get_Incidents_By_Where_Sorted_With_Pagination;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Incidents_By_Where_Sorted_With_Pagination.Params_Get_Incidents_By_Where_Sorted_With_Pagination = i_Params_Get_Incidents_By_Where_Sorted_With_Pagination;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Incidents_By_Where_Sorted_With_Pagination.Exception_Message = string.Format("Get_Incidents_By_Where_Sorted_With_Pagination : {0}", ex.Message);
                oResult_Get_Incidents_By_Where_Sorted_With_Pagination.Stack_Trace = is_send_stack_trace ? string.Format("Get_Incidents_By_Where_Sorted_With_Pagination : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Incidents_By_Where_Sorted_With_Pagination.Exception_Message = ex.Message;
                oResult_Get_Incidents_By_Where_Sorted_With_Pagination.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Incidents_By_Where_Sorted_With_Pagination;
        #endregion
    }
    #endregion
    #region Edit_Incident_List
    [HttpPost]
    [Route("Edit_Incident_List")]
    public Result_Edit_Incident_List Edit_Incident_List(Params_Edit_Incident_List i_Params_Edit_Incident_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Incident_List oResult_Edit_Incident_List = new Result_Edit_Incident_List();
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
                oBLC.Edit_Incident_List(i_Params_Edit_Incident_List);
                oResult_Edit_Incident_List.Params_Edit_Incident_List = i_Params_Edit_Incident_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Incident_List.Params_Edit_Incident_List = i_Params_Edit_Incident_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Incident_List.Exception_Message = string.Format("Edit_Incident_List : {0}", ex.Message);
                oResult_Edit_Incident_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Incident_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Incident_List.Exception_Message = ex.Message;
                oResult_Edit_Incident_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Incident_List;
        #endregion
    }
    #endregion
    #region Delete_Incident
    [HttpPost]
    [Route("Delete_Incident")]
    public Result_Delete_Incident Delete_Incident()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Incident oResult_Delete_Incident = new Result_Delete_Incident();
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
                oBLC.Delete_Incident();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Incident.Exception_Message = string.Format("Delete_Incident : {0}", ex.Message);
                oResult_Delete_Incident.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Incident : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Incident.Exception_Message = ex.Message;
                oResult_Delete_Incident.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Incident;
        #endregion
    }
    #endregion
    #region Get_Incidents_By_Where_Count
    [HttpPost]
    [Route("Get_Incidents_By_Where_Count")]
    public Result_Get_Incidents_By_Where_Count Get_Incidents_By_Where_Count(Params_Get_Incidents_By_Where_Count i_Params_Get_Incidents_By_Where_Count)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Incidents_By_Where_Count oResult_Get_Incidents_By_Where_Count = new Result_Get_Incidents_By_Where_Count();
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
                oResult_Get_Incidents_By_Where_Count.i_Result = oBLC.Get_Incidents_By_Where_Count(i_Params_Get_Incidents_By_Where_Count);
                oResult_Get_Incidents_By_Where_Count.Params_Get_Incidents_By_Where_Count = i_Params_Get_Incidents_By_Where_Count;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Incidents_By_Where_Count.Params_Get_Incidents_By_Where_Count = i_Params_Get_Incidents_By_Where_Count;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Incidents_By_Where_Count.Exception_Message = string.Format("Get_Incidents_By_Where_Count : {0}", ex.Message);
                oResult_Get_Incidents_By_Where_Count.Stack_Trace = is_send_stack_trace ? string.Format("Get_Incidents_By_Where_Count : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Incidents_By_Where_Count.Exception_Message = ex.Message;
                oResult_Get_Incidents_By_Where_Count.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Incidents_By_Where_Count;
        #endregion
    }
    #endregion
    #region Get_Incidents_By_Where
    [HttpPost]
    [Route("Get_Incidents_By_Where")]
    public Result_Get_Incidents_By_Where Get_Incidents_By_Where(Params_Get_Incidents_By_Where i_Params_Get_Incidents_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Incidents_By_Where oResult_Get_Incidents_By_Where = new Result_Get_Incidents_By_Where();
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
                oResult_Get_Incidents_By_Where.i_Result = oBLC.Get_Incidents_By_Where(i_Params_Get_Incidents_By_Where);
                oResult_Get_Incidents_By_Where.Params_Get_Incidents_By_Where = i_Params_Get_Incidents_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Incidents_By_Where.Params_Get_Incidents_By_Where = i_Params_Get_Incidents_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Incidents_By_Where.Exception_Message = string.Format("Get_Incidents_By_Where : {0}", ex.Message);
                oResult_Get_Incidents_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Incidents_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Incidents_By_Where.Exception_Message = ex.Message;
                oResult_Get_Incidents_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Incidents_By_Where;
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
#region Result_Get_Incidents_By_Where_Sorted_With_Pagination
public partial class Result_Get_Incidents_By_Where_Sorted_With_Pagination : Action_Result
{
    #region Properties.
    public Incident_With_Count i_Result { get; set; }
    public Params_Get_Incidents_By_Where_Sorted_With_Pagination Params_Get_Incidents_By_Where_Sorted_With_Pagination { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Incident_List
public partial class Result_Edit_Incident_List : Action_Result
{
    #region Properties.
    public Params_Edit_Incident_List Params_Edit_Incident_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Incident
public partial class Result_Delete_Incident : Action_Result
{
    #region Properties.
    #endregion
}
#endregion
#region Result_Get_Incidents_By_Where_Count
public partial class Result_Get_Incidents_By_Where_Count : Action_Result
{
    #region Properties.
    public long i_Result { get; set; }
    public Params_Get_Incidents_By_Where_Count Params_Get_Incidents_By_Where_Count { get; set; }
    #endregion
}
#endregion
#region Result_Get_Incidents_By_Where
public partial class Result_Get_Incidents_By_Where : Action_Result
{
    #region Properties.
    public List<Incident> i_Result { get; set; }
    public Params_Get_Incidents_By_Where Params_Get_Incidents_By_Where { get; set; }
    #endregion
}
#endregion
