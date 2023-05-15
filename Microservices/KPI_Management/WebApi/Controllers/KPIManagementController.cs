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
public partial class KPIManagementController : ControllerBase
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
    #region Get_Wifi_signals
    [HttpPost]
    [Route("Get_Wifi_signals")]
    public Result_Get_Wifi_signals Get_Wifi_signals(Params_Get_Wifi_signals i_Params_Get_Wifi_signals)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Wifi_signals oResult_Get_Wifi_signals = new Result_Get_Wifi_signals();
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
                oResult_Get_Wifi_signals.i_Result = oBLC.Get_Wifi_signals(i_Params_Get_Wifi_signals);
                oResult_Get_Wifi_signals.Params_Get_Wifi_signals = i_Params_Get_Wifi_signals;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Wifi_signals.Params_Get_Wifi_signals = i_Params_Get_Wifi_signals;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Wifi_signals.Exception_Message = string.Format("Get_Wifi_signals : {0}", ex.Message);
                oResult_Get_Wifi_signals.Stack_Trace = is_send_stack_trace ? string.Format("Get_Wifi_signals : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Wifi_signals.Exception_Message = ex.Message;
                oResult_Get_Wifi_signals.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Wifi_signals;
        #endregion
    }
    #endregion
    #region Get_District_Kpi_Dialog_Data
    [HttpPost]
    [Route("Get_District_Kpi_Dialog_Data")]
    public Result_Get_District_Kpi_Dialog_Data Get_District_Kpi_Dialog_Data(Params_Get_District_Kpi_Dialog_Data i_Params_Get_District_Kpi_Dialog_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_District_Kpi_Dialog_Data oResult_Get_District_Kpi_Dialog_Data = new Result_Get_District_Kpi_Dialog_Data();
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
                oResult_Get_District_Kpi_Dialog_Data.i_Result = oBLC.Get_District_Kpi_Dialog_Data(i_Params_Get_District_Kpi_Dialog_Data);
                oResult_Get_District_Kpi_Dialog_Data.Params_Get_District_Kpi_Dialog_Data = i_Params_Get_District_Kpi_Dialog_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_District_Kpi_Dialog_Data.Params_Get_District_Kpi_Dialog_Data = i_Params_Get_District_Kpi_Dialog_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_District_Kpi_Dialog_Data.Exception_Message = string.Format("Get_District_Kpi_Dialog_Data : {0}", ex.Message);
                oResult_Get_District_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_District_Kpi_Dialog_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_District_Kpi_Dialog_Data.Exception_Message = ex.Message;
                oResult_Get_District_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_District_Kpi_Dialog_Data;
        #endregion
    }
    #endregion
    #region Get_Area_Kpi_Data_Aggregate_Sum
    [HttpPost]
    [Route("Get_Area_Kpi_Data_Aggregate_Sum")]
    public Result_Get_Area_Kpi_Data_Aggregate_Sum Get_Area_Kpi_Data_Aggregate_Sum(Params_Get_Area_Kpi_Data_Aggregate_Sum i_Params_Get_Area_Kpi_Data_Aggregate_Sum)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_Kpi_Data_Aggregate_Sum oResult_Get_Area_Kpi_Data_Aggregate_Sum = new Result_Get_Area_Kpi_Data_Aggregate_Sum();
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
                oResult_Get_Area_Kpi_Data_Aggregate_Sum.i_Result = oBLC.Get_Area_Kpi_Data_Aggregate_Sum(i_Params_Get_Area_Kpi_Data_Aggregate_Sum);
                oResult_Get_Area_Kpi_Data_Aggregate_Sum.Params_Get_Area_Kpi_Data_Aggregate_Sum = i_Params_Get_Area_Kpi_Data_Aggregate_Sum;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_Kpi_Data_Aggregate_Sum.Params_Get_Area_Kpi_Data_Aggregate_Sum = i_Params_Get_Area_Kpi_Data_Aggregate_Sum;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_Kpi_Data_Aggregate_Sum.Exception_Message = string.Format("Get_Area_Kpi_Data_Aggregate_Sum : {0}", ex.Message);
                oResult_Get_Area_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_Kpi_Data_Aggregate_Sum : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_Kpi_Data_Aggregate_Sum.Exception_Message = ex.Message;
                oResult_Get_Area_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_Kpi_Data_Aggregate_Sum;
        #endregion
    }
    #endregion
    #region Get_Entity_Kpi_Data_By_Where
    [HttpPost]
    [Route("Get_Entity_Kpi_Data_By_Where")]
    public Result_Get_Entity_Kpi_Data_By_Where Get_Entity_Kpi_Data_By_Where(Params_Get_Entity_Kpi_Data_By_Where i_Params_Get_Entity_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_Kpi_Data_By_Where oResult_Get_Entity_Kpi_Data_By_Where = new Result_Get_Entity_Kpi_Data_By_Where();
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
                oResult_Get_Entity_Kpi_Data_By_Where.i_Result = oBLC.Get_Entity_Kpi_Data_By_Where(i_Params_Get_Entity_Kpi_Data_By_Where);
                oResult_Get_Entity_Kpi_Data_By_Where.Params_Get_Entity_Kpi_Data_By_Where = i_Params_Get_Entity_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_Kpi_Data_By_Where.Params_Get_Entity_Kpi_Data_By_Where = i_Params_Get_Entity_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_Kpi_Data_By_Where.Exception_Message = string.Format("Get_Entity_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Get_Entity_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Get_Entity_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Compute_Area_Kpi_Data_Hourly
    [HttpPost]
    [Route("Compute_Area_Kpi_Data_Hourly")]
    public Result_Compute_Area_Kpi_Data_Hourly Compute_Area_Kpi_Data_Hourly(Params_Compute_Area_Kpi_Data_Hourly i_Params_Compute_Area_Kpi_Data_Hourly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Area_Kpi_Data_Hourly oResult_Compute_Area_Kpi_Data_Hourly = new Result_Compute_Area_Kpi_Data_Hourly();
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
                oBLC.Compute_Area_Kpi_Data_Hourly(i_Params_Compute_Area_Kpi_Data_Hourly);
                oResult_Compute_Area_Kpi_Data_Hourly.Params_Compute_Area_Kpi_Data_Hourly = i_Params_Compute_Area_Kpi_Data_Hourly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Area_Kpi_Data_Hourly.Params_Compute_Area_Kpi_Data_Hourly = i_Params_Compute_Area_Kpi_Data_Hourly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Area_Kpi_Data_Hourly.Exception_Message = string.Format("Compute_Area_Kpi_Data_Hourly : {0}", ex.Message);
                oResult_Compute_Area_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Area_Kpi_Data_Hourly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Area_Kpi_Data_Hourly.Exception_Message = ex.Message;
                oResult_Compute_Area_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Area_Kpi_Data_Hourly;
        #endregion
    }
    #endregion
    #region Get_Site_Kpi_Dialog_Data
    [HttpPost]
    [Route("Get_Site_Kpi_Dialog_Data")]
    public Result_Get_Site_Kpi_Dialog_Data Get_Site_Kpi_Dialog_Data(Params_Get_Site_Kpi_Dialog_Data i_Params_Get_Site_Kpi_Dialog_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_Kpi_Dialog_Data oResult_Get_Site_Kpi_Dialog_Data = new Result_Get_Site_Kpi_Dialog_Data();
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
                oResult_Get_Site_Kpi_Dialog_Data.i_Result = oBLC.Get_Site_Kpi_Dialog_Data(i_Params_Get_Site_Kpi_Dialog_Data);
                oResult_Get_Site_Kpi_Dialog_Data.Params_Get_Site_Kpi_Dialog_Data = i_Params_Get_Site_Kpi_Dialog_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_Kpi_Dialog_Data.Params_Get_Site_Kpi_Dialog_Data = i_Params_Get_Site_Kpi_Dialog_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_Kpi_Dialog_Data.Exception_Message = string.Format("Get_Site_Kpi_Dialog_Data : {0}", ex.Message);
                oResult_Get_Site_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_Kpi_Dialog_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_Kpi_Dialog_Data.Exception_Message = ex.Message;
                oResult_Get_Site_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_Kpi_Dialog_Data;
        #endregion
    }
    #endregion
    #region Get_Site_Kpi_Data_By_Where
    [HttpPost]
    [Route("Get_Site_Kpi_Data_By_Where")]
    public Result_Get_Site_Kpi_Data_By_Where Get_Site_Kpi_Data_By_Where(Params_Get_Site_Kpi_Data_By_Where i_Params_Get_Site_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_Kpi_Data_By_Where oResult_Get_Site_Kpi_Data_By_Where = new Result_Get_Site_Kpi_Data_By_Where();
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
                oResult_Get_Site_Kpi_Data_By_Where.i_Result = oBLC.Get_Site_Kpi_Data_By_Where(i_Params_Get_Site_Kpi_Data_By_Where);
                oResult_Get_Site_Kpi_Data_By_Where.Params_Get_Site_Kpi_Data_By_Where = i_Params_Get_Site_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_Kpi_Data_By_Where.Params_Get_Site_Kpi_Data_By_Where = i_Params_Get_Site_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_Kpi_Data_By_Where.Exception_Message = string.Format("Get_Site_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Get_Site_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Get_Site_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Edit_Alert_List
    [HttpPost]
    [Route("Edit_Alert_List")]
    public Result_Edit_Alert_List Edit_Alert_List(Params_Edit_Alert_List i_Params_Edit_Alert_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Alert_List oResult_Edit_Alert_List = new Result_Edit_Alert_List();
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
                oBLC.Edit_Alert_List(i_Params_Edit_Alert_List);
                oResult_Edit_Alert_List.Params_Edit_Alert_List = i_Params_Edit_Alert_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Alert_List.Params_Edit_Alert_List = i_Params_Edit_Alert_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Alert_List.Exception_Message = string.Format("Edit_Alert_List : {0}", ex.Message);
                oResult_Edit_Alert_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Alert_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Alert_List.Exception_Message = ex.Message;
                oResult_Edit_Alert_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Alert_List;
        #endregion
    }
    #endregion
    #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
    [HttpGet]
    [Route("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv")]
    public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv = new Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv();
        Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = HttpContext.Request
                                                                                                                                                   .Query["ORGANIZATION_DATA_SOURCE_KPI_ID_LIST"]
                                                                                                                                                   .ToString()
                                                                                                                                                   .Split(',')
                                                                                                                                                   .Where(val => int.TryParse(val, out _))
                                                                                                                                                   .Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.i_Result = oBLC.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.Exception_Message = string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Compute_District_Kpi_Data_Monthly
    [HttpPost]
    [Route("Compute_District_Kpi_Data_Monthly")]
    public Result_Compute_District_Kpi_Data_Monthly Compute_District_Kpi_Data_Monthly(Params_Compute_District_Kpi_Data_Monthly i_Params_Compute_District_Kpi_Data_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_District_Kpi_Data_Monthly oResult_Compute_District_Kpi_Data_Monthly = new Result_Compute_District_Kpi_Data_Monthly();
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
                oBLC.Compute_District_Kpi_Data_Monthly(i_Params_Compute_District_Kpi_Data_Monthly);
                oResult_Compute_District_Kpi_Data_Monthly.Params_Compute_District_Kpi_Data_Monthly = i_Params_Compute_District_Kpi_Data_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_District_Kpi_Data_Monthly.Params_Compute_District_Kpi_Data_Monthly = i_Params_Compute_District_Kpi_Data_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_District_Kpi_Data_Monthly.Exception_Message = string.Format("Compute_District_Kpi_Data_Monthly : {0}", ex.Message);
                oResult_Compute_District_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_District_Kpi_Data_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_District_Kpi_Data_Monthly.Exception_Message = ex.Message;
                oResult_Compute_District_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_District_Kpi_Data_Monthly;
        #endregion
    }
    #endregion
    #region Get_Bylaw_Complaint_List
    [HttpPost]
    [Route("Get_Bylaw_Complaint_List")]
    public Result_Get_Bylaw_Complaint_List Get_Bylaw_Complaint_List(Params_Get_Bylaw_Complaint_List i_Params_Get_Bylaw_Complaint_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Bylaw_Complaint_List oResult_Get_Bylaw_Complaint_List = new Result_Get_Bylaw_Complaint_List();
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
                oResult_Get_Bylaw_Complaint_List.i_Result = oBLC.Get_Bylaw_Complaint_List(i_Params_Get_Bylaw_Complaint_List);
                oResult_Get_Bylaw_Complaint_List.Params_Get_Bylaw_Complaint_List = i_Params_Get_Bylaw_Complaint_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Bylaw_Complaint_List.Params_Get_Bylaw_Complaint_List = i_Params_Get_Bylaw_Complaint_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Bylaw_Complaint_List.Exception_Message = string.Format("Get_Bylaw_Complaint_List : {0}", ex.Message);
                oResult_Get_Bylaw_Complaint_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Bylaw_Complaint_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Bylaw_Complaint_List.Exception_Message = ex.Message;
                oResult_Get_Bylaw_Complaint_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Bylaw_Complaint_List;
        #endregion
    }
    #endregion
    #region Delete_Kpi
    [HttpPost]
    [Route("Delete_Kpi")]
    public Result_Delete_Kpi Delete_Kpi(Params_Delete_Kpi i_Params_Delete_Kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Kpi oResult_Delete_Kpi = new Result_Delete_Kpi();
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
                oBLC.Delete_Kpi(i_Params_Delete_Kpi);
                oResult_Delete_Kpi.Params_Delete_Kpi = i_Params_Delete_Kpi;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Kpi.Params_Delete_Kpi = i_Params_Delete_Kpi;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Kpi.Exception_Message = string.Format("Delete_Kpi : {0}", ex.Message);
                oResult_Delete_Kpi.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Kpi.Exception_Message = ex.Message;
                oResult_Delete_Kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Kpi;
        #endregion
    }
    #endregion
    #region Delete_Wifi_signal
    [HttpPost]
    [Route("Delete_Wifi_signal")]
    public Result_Delete_Wifi_signal Delete_Wifi_signal(Params_Delete_Wifi_signal i_Params_Delete_Wifi_signal)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Wifi_signal oResult_Delete_Wifi_signal = new Result_Delete_Wifi_signal();
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
                oBLC.Delete_Wifi_signal(i_Params_Delete_Wifi_signal);
                oResult_Delete_Wifi_signal.Params_Delete_Wifi_signal = i_Params_Delete_Wifi_signal;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Wifi_signal.Params_Delete_Wifi_signal = i_Params_Delete_Wifi_signal;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Wifi_signal.Exception_Message = string.Format("Delete_Wifi_signal : {0}", ex.Message);
                oResult_Delete_Wifi_signal.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Wifi_signal : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Wifi_signal.Exception_Message = ex.Message;
                oResult_Delete_Wifi_signal.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Wifi_signal;
        #endregion
    }
    #endregion
    #region Compute_Floor_Kpi_Data_Monthly
    [HttpPost]
    [Route("Compute_Floor_Kpi_Data_Monthly")]
    public Result_Compute_Floor_Kpi_Data_Monthly Compute_Floor_Kpi_Data_Monthly(Params_Compute_Floor_Kpi_Data_Monthly i_Params_Compute_Floor_Kpi_Data_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Floor_Kpi_Data_Monthly oResult_Compute_Floor_Kpi_Data_Monthly = new Result_Compute_Floor_Kpi_Data_Monthly();
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
                oBLC.Compute_Floor_Kpi_Data_Monthly(i_Params_Compute_Floor_Kpi_Data_Monthly);
                oResult_Compute_Floor_Kpi_Data_Monthly.Params_Compute_Floor_Kpi_Data_Monthly = i_Params_Compute_Floor_Kpi_Data_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Floor_Kpi_Data_Monthly.Params_Compute_Floor_Kpi_Data_Monthly = i_Params_Compute_Floor_Kpi_Data_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Floor_Kpi_Data_Monthly.Exception_Message = string.Format("Compute_Floor_Kpi_Data_Monthly : {0}", ex.Message);
                oResult_Compute_Floor_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Floor_Kpi_Data_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Floor_Kpi_Data_Monthly.Exception_Message = ex.Message;
                oResult_Compute_Floor_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Floor_Kpi_Data_Monthly;
        #endregion
    }
    #endregion
    #region Edit_Wifi_signal_alert_List
    [HttpPost]
    [Route("Edit_Wifi_signal_alert_List")]
    public Result_Edit_Wifi_signal_alert_List Edit_Wifi_signal_alert_List(Params_Edit_Wifi_signal_alert_List i_Params_Edit_Wifi_signal_alert_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Wifi_signal_alert_List oResult_Edit_Wifi_signal_alert_List = new Result_Edit_Wifi_signal_alert_List();
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
                oBLC.Edit_Wifi_signal_alert_List(i_Params_Edit_Wifi_signal_alert_List);
                oResult_Edit_Wifi_signal_alert_List.Params_Edit_Wifi_signal_alert_List = i_Params_Edit_Wifi_signal_alert_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Wifi_signal_alert_List.Params_Edit_Wifi_signal_alert_List = i_Params_Edit_Wifi_signal_alert_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Wifi_signal_alert_List.Exception_Message = string.Format("Edit_Wifi_signal_alert_List : {0}", ex.Message);
                oResult_Edit_Wifi_signal_alert_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Wifi_signal_alert_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Wifi_signal_alert_List.Exception_Message = ex.Message;
                oResult_Edit_Wifi_signal_alert_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Wifi_signal_alert_List;
        #endregion
    }
    #endregion
    #region Delete_Alert
    [HttpPost]
    [Route("Delete_Alert")]
    public Result_Delete_Alert Delete_Alert(Params_Delete_Alert i_Params_Delete_Alert)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Alert oResult_Delete_Alert = new Result_Delete_Alert();
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
                oBLC.Delete_Alert(i_Params_Delete_Alert);
                oResult_Delete_Alert.Params_Delete_Alert = i_Params_Delete_Alert;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Alert.Params_Delete_Alert = i_Params_Delete_Alert;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Alert.Exception_Message = string.Format("Delete_Alert : {0}", ex.Message);
                oResult_Delete_Alert.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Alert : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Alert.Exception_Message = ex.Message;
                oResult_Delete_Alert.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Alert;
        #endregion
    }
    #endregion
    #region Compute_District_Kpi_Data_Weekly
    [HttpPost]
    [Route("Compute_District_Kpi_Data_Weekly")]
    public Result_Compute_District_Kpi_Data_Weekly Compute_District_Kpi_Data_Weekly(Params_Compute_District_Kpi_Data_Weekly i_Params_Compute_District_Kpi_Data_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_District_Kpi_Data_Weekly oResult_Compute_District_Kpi_Data_Weekly = new Result_Compute_District_Kpi_Data_Weekly();
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
                oBLC.Compute_District_Kpi_Data_Weekly(i_Params_Compute_District_Kpi_Data_Weekly);
                oResult_Compute_District_Kpi_Data_Weekly.Params_Compute_District_Kpi_Data_Weekly = i_Params_Compute_District_Kpi_Data_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_District_Kpi_Data_Weekly.Params_Compute_District_Kpi_Data_Weekly = i_Params_Compute_District_Kpi_Data_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_District_Kpi_Data_Weekly.Exception_Message = string.Format("Compute_District_Kpi_Data_Weekly : {0}", ex.Message);
                oResult_Compute_District_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_District_Kpi_Data_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_District_Kpi_Data_Weekly.Exception_Message = ex.Message;
                oResult_Compute_District_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_District_Kpi_Data_Weekly;
        #endregion
    }
    #endregion
    #region Get_District_Kpi_Data_Aggregate_Sum
    [HttpPost]
    [Route("Get_District_Kpi_Data_Aggregate_Sum")]
    public Result_Get_District_Kpi_Data_Aggregate_Sum Get_District_Kpi_Data_Aggregate_Sum(Params_Get_District_Kpi_Data_Aggregate_Sum i_Params_Get_District_Kpi_Data_Aggregate_Sum)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_District_Kpi_Data_Aggregate_Sum oResult_Get_District_Kpi_Data_Aggregate_Sum = new Result_Get_District_Kpi_Data_Aggregate_Sum();
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
                oResult_Get_District_Kpi_Data_Aggregate_Sum.i_Result = oBLC.Get_District_Kpi_Data_Aggregate_Sum(i_Params_Get_District_Kpi_Data_Aggregate_Sum);
                oResult_Get_District_Kpi_Data_Aggregate_Sum.Params_Get_District_Kpi_Data_Aggregate_Sum = i_Params_Get_District_Kpi_Data_Aggregate_Sum;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_District_Kpi_Data_Aggregate_Sum.Params_Get_District_Kpi_Data_Aggregate_Sum = i_Params_Get_District_Kpi_Data_Aggregate_Sum;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_District_Kpi_Data_Aggregate_Sum.Exception_Message = string.Format("Get_District_Kpi_Data_Aggregate_Sum : {0}", ex.Message);
                oResult_Get_District_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? string.Format("Get_District_Kpi_Data_Aggregate_Sum : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_District_Kpi_Data_Aggregate_Sum.Exception_Message = ex.Message;
                oResult_Get_District_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_District_Kpi_Data_Aggregate_Sum;
        #endregion
    }
    #endregion
    #region Get_Latest_Organization_data_source_kpi_By_Where
    [HttpPost]
    [Route("Get_Latest_Organization_data_source_kpi_By_Where")]
    public Result_Get_Latest_Organization_data_source_kpi_By_Where Get_Latest_Organization_data_source_kpi_By_Where(Params_Get_Latest_Organization_data_source_kpi_By_Where i_Params_Get_Latest_Organization_data_source_kpi_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Latest_Organization_data_source_kpi_By_Where oResult_Get_Latest_Organization_data_source_kpi_By_Where = new Result_Get_Latest_Organization_data_source_kpi_By_Where();
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
                oResult_Get_Latest_Organization_data_source_kpi_By_Where.i_Result = oBLC.Get_Latest_Organization_data_source_kpi_By_Where(i_Params_Get_Latest_Organization_data_source_kpi_By_Where);
                oResult_Get_Latest_Organization_data_source_kpi_By_Where.Params_Get_Latest_Organization_data_source_kpi_By_Where = i_Params_Get_Latest_Organization_data_source_kpi_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Latest_Organization_data_source_kpi_By_Where.Params_Get_Latest_Organization_data_source_kpi_By_Where = i_Params_Get_Latest_Organization_data_source_kpi_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Latest_Organization_data_source_kpi_By_Where.Exception_Message = string.Format("Get_Latest_Organization_data_source_kpi_By_Where : {0}", ex.Message);
                oResult_Get_Latest_Organization_data_source_kpi_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Latest_Organization_data_source_kpi_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Latest_Organization_data_source_kpi_By_Where.Exception_Message = ex.Message;
                oResult_Get_Latest_Organization_data_source_kpi_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Latest_Organization_data_source_kpi_By_Where;
        #endregion
    }
    #endregion
    #region Compute_Space_Kpi_Data_Monthly
    [HttpPost]
    [Route("Compute_Space_Kpi_Data_Monthly")]
    public Result_Compute_Space_Kpi_Data_Monthly Compute_Space_Kpi_Data_Monthly(Params_Compute_Space_Kpi_Data_Monthly i_Params_Compute_Space_Kpi_Data_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Space_Kpi_Data_Monthly oResult_Compute_Space_Kpi_Data_Monthly = new Result_Compute_Space_Kpi_Data_Monthly();
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
                oBLC.Compute_Space_Kpi_Data_Monthly(i_Params_Compute_Space_Kpi_Data_Monthly);
                oResult_Compute_Space_Kpi_Data_Monthly.Params_Compute_Space_Kpi_Data_Monthly = i_Params_Compute_Space_Kpi_Data_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Space_Kpi_Data_Monthly.Params_Compute_Space_Kpi_Data_Monthly = i_Params_Compute_Space_Kpi_Data_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Space_Kpi_Data_Monthly.Exception_Message = string.Format("Compute_Space_Kpi_Data_Monthly : {0}", ex.Message);
                oResult_Compute_Space_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Space_Kpi_Data_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Space_Kpi_Data_Monthly.Exception_Message = ex.Message;
                oResult_Compute_Space_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Space_Kpi_Data_Monthly;
        #endregion
    }
    #endregion
    #region Compute_Space_Kpi_Data_Daily
    [HttpPost]
    [Route("Compute_Space_Kpi_Data_Daily")]
    public Result_Compute_Space_Kpi_Data_Daily Compute_Space_Kpi_Data_Daily(Params_Compute_Space_Kpi_Data_Daily i_Params_Compute_Space_Kpi_Data_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Space_Kpi_Data_Daily oResult_Compute_Space_Kpi_Data_Daily = new Result_Compute_Space_Kpi_Data_Daily();
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
                oBLC.Compute_Space_Kpi_Data_Daily(i_Params_Compute_Space_Kpi_Data_Daily);
                oResult_Compute_Space_Kpi_Data_Daily.Params_Compute_Space_Kpi_Data_Daily = i_Params_Compute_Space_Kpi_Data_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Space_Kpi_Data_Daily.Params_Compute_Space_Kpi_Data_Daily = i_Params_Compute_Space_Kpi_Data_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Space_Kpi_Data_Daily.Exception_Message = string.Format("Compute_Space_Kpi_Data_Daily : {0}", ex.Message);
                oResult_Compute_Space_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Space_Kpi_Data_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Space_Kpi_Data_Daily.Exception_Message = ex.Message;
                oResult_Compute_Space_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Space_Kpi_Data_Daily;
        #endregion
    }
    #endregion
    #region Update_Kpi_Data_Record
    [HttpPost]
    [Route("Update_Kpi_Data_Record")]
    public Result_Update_Kpi_Data_Record Update_Kpi_Data_Record(Params_Update_Kpi_Data_Record i_Params_Update_Kpi_Data_Record)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Update_Kpi_Data_Record oResult_Update_Kpi_Data_Record = new Result_Update_Kpi_Data_Record();
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
                oBLC.Update_Kpi_Data_Record(i_Params_Update_Kpi_Data_Record);
                oResult_Update_Kpi_Data_Record.Params_Update_Kpi_Data_Record = i_Params_Update_Kpi_Data_Record;
            }
        }
        catch (Exception ex)
        {
            oResult_Update_Kpi_Data_Record.Params_Update_Kpi_Data_Record = i_Params_Update_Kpi_Data_Record;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Update_Kpi_Data_Record.Exception_Message = string.Format("Update_Kpi_Data_Record : {0}", ex.Message);
                oResult_Update_Kpi_Data_Record.Stack_Trace = is_send_stack_trace ? string.Format("Update_Kpi_Data_Record : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Update_Kpi_Data_Record.Exception_Message = ex.Message;
                oResult_Update_Kpi_Data_Record.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Update_Kpi_Data_Record;
        #endregion
    }
    #endregion
    #region Compute_Area_Kpi_Data_Daily
    [HttpPost]
    [Route("Compute_Area_Kpi_Data_Daily")]
    public Result_Compute_Area_Kpi_Data_Daily Compute_Area_Kpi_Data_Daily(Params_Compute_Area_Kpi_Data_Daily i_Params_Compute_Area_Kpi_Data_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Area_Kpi_Data_Daily oResult_Compute_Area_Kpi_Data_Daily = new Result_Compute_Area_Kpi_Data_Daily();
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
                oBLC.Compute_Area_Kpi_Data_Daily(i_Params_Compute_Area_Kpi_Data_Daily);
                oResult_Compute_Area_Kpi_Data_Daily.Params_Compute_Area_Kpi_Data_Daily = i_Params_Compute_Area_Kpi_Data_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Area_Kpi_Data_Daily.Params_Compute_Area_Kpi_Data_Daily = i_Params_Compute_Area_Kpi_Data_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Area_Kpi_Data_Daily.Exception_Message = string.Format("Compute_Area_Kpi_Data_Daily : {0}", ex.Message);
                oResult_Compute_Area_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Area_Kpi_Data_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Area_Kpi_Data_Daily.Exception_Message = ex.Message;
                oResult_Compute_Area_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Area_Kpi_Data_Daily;
        #endregion
    }
    #endregion
    #region Get_Latest_Wifi_signal_alerts
    [HttpPost]
    [Route("Get_Latest_Wifi_signal_alerts")]
    public Result_Get_Latest_Wifi_signal_alerts Get_Latest_Wifi_signal_alerts(Params_Get_Latest_Wifi_signal_alerts i_Params_Get_Latest_Wifi_signal_alerts)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Latest_Wifi_signal_alerts oResult_Get_Latest_Wifi_signal_alerts = new Result_Get_Latest_Wifi_signal_alerts();
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
                oResult_Get_Latest_Wifi_signal_alerts.i_Result = oBLC.Get_Latest_Wifi_signal_alerts(i_Params_Get_Latest_Wifi_signal_alerts);
                oResult_Get_Latest_Wifi_signal_alerts.Params_Get_Latest_Wifi_signal_alerts = i_Params_Get_Latest_Wifi_signal_alerts;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Latest_Wifi_signal_alerts.Params_Get_Latest_Wifi_signal_alerts = i_Params_Get_Latest_Wifi_signal_alerts;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Latest_Wifi_signal_alerts.Exception_Message = string.Format("Get_Latest_Wifi_signal_alerts : {0}", ex.Message);
                oResult_Get_Latest_Wifi_signal_alerts.Stack_Trace = is_send_stack_trace ? string.Format("Get_Latest_Wifi_signal_alerts : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Latest_Wifi_signal_alerts.Exception_Message = ex.Message;
                oResult_Get_Latest_Wifi_signal_alerts.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Latest_Wifi_signal_alerts;
        #endregion
    }
    #endregion
    #region Get_Floor_Kpi_Data_Aggregate_Sum
    [HttpPost]
    [Route("Get_Floor_Kpi_Data_Aggregate_Sum")]
    public Result_Get_Floor_Kpi_Data_Aggregate_Sum Get_Floor_Kpi_Data_Aggregate_Sum(Params_Get_Floor_Kpi_Data_Aggregate_Sum i_Params_Get_Floor_Kpi_Data_Aggregate_Sum)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_Kpi_Data_Aggregate_Sum oResult_Get_Floor_Kpi_Data_Aggregate_Sum = new Result_Get_Floor_Kpi_Data_Aggregate_Sum();
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
                oResult_Get_Floor_Kpi_Data_Aggregate_Sum.i_Result = oBLC.Get_Floor_Kpi_Data_Aggregate_Sum(i_Params_Get_Floor_Kpi_Data_Aggregate_Sum);
                oResult_Get_Floor_Kpi_Data_Aggregate_Sum.Params_Get_Floor_Kpi_Data_Aggregate_Sum = i_Params_Get_Floor_Kpi_Data_Aggregate_Sum;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_Kpi_Data_Aggregate_Sum.Params_Get_Floor_Kpi_Data_Aggregate_Sum = i_Params_Get_Floor_Kpi_Data_Aggregate_Sum;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_Kpi_Data_Aggregate_Sum.Exception_Message = string.Format("Get_Floor_Kpi_Data_Aggregate_Sum : {0}", ex.Message);
                oResult_Get_Floor_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_Kpi_Data_Aggregate_Sum : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_Kpi_Data_Aggregate_Sum.Exception_Message = ex.Message;
                oResult_Get_Floor_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_Kpi_Data_Aggregate_Sum;
        #endregion
    }
    #endregion
    #region Compute_Entity_Kpi_Data_Weekly
    [HttpPost]
    [Route("Compute_Entity_Kpi_Data_Weekly")]
    public Result_Compute_Entity_Kpi_Data_Weekly Compute_Entity_Kpi_Data_Weekly(Params_Compute_Entity_Kpi_Data_Weekly i_Params_Compute_Entity_Kpi_Data_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Entity_Kpi_Data_Weekly oResult_Compute_Entity_Kpi_Data_Weekly = new Result_Compute_Entity_Kpi_Data_Weekly();
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
                oBLC.Compute_Entity_Kpi_Data_Weekly(i_Params_Compute_Entity_Kpi_Data_Weekly);
                oResult_Compute_Entity_Kpi_Data_Weekly.Params_Compute_Entity_Kpi_Data_Weekly = i_Params_Compute_Entity_Kpi_Data_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Entity_Kpi_Data_Weekly.Params_Compute_Entity_Kpi_Data_Weekly = i_Params_Compute_Entity_Kpi_Data_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Entity_Kpi_Data_Weekly.Exception_Message = string.Format("Compute_Entity_Kpi_Data_Weekly : {0}", ex.Message);
                oResult_Compute_Entity_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Entity_Kpi_Data_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Entity_Kpi_Data_Weekly.Exception_Message = ex.Message;
                oResult_Compute_Entity_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Entity_Kpi_Data_Weekly;
        #endregion
    }
    #endregion
    #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
    [HttpGet]
    [Route("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv")]
    public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv = new Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv();
        Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_DATA_SOURCE_KPI_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.i_Result = oBLC.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.Exception_Message = string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv : {0}", ex.Message);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv;
        #endregion
    }
    #endregion
    #region Compute_Area_Kpi_Data_Weekly
    [HttpPost]
    [Route("Compute_Area_Kpi_Data_Weekly")]
    public Result_Compute_Area_Kpi_Data_Weekly Compute_Area_Kpi_Data_Weekly(Params_Compute_Area_Kpi_Data_Weekly i_Params_Compute_Area_Kpi_Data_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Area_Kpi_Data_Weekly oResult_Compute_Area_Kpi_Data_Weekly = new Result_Compute_Area_Kpi_Data_Weekly();
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
                oBLC.Compute_Area_Kpi_Data_Weekly(i_Params_Compute_Area_Kpi_Data_Weekly);
                oResult_Compute_Area_Kpi_Data_Weekly.Params_Compute_Area_Kpi_Data_Weekly = i_Params_Compute_Area_Kpi_Data_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Area_Kpi_Data_Weekly.Params_Compute_Area_Kpi_Data_Weekly = i_Params_Compute_Area_Kpi_Data_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Area_Kpi_Data_Weekly.Exception_Message = string.Format("Compute_Area_Kpi_Data_Weekly : {0}", ex.Message);
                oResult_Compute_Area_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Area_Kpi_Data_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Area_Kpi_Data_Weekly.Exception_Message = ex.Message;
                oResult_Compute_Area_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Area_Kpi_Data_Weekly;
        #endregion
    }
    #endregion
    #region Get_Business_Trendline
    [HttpPost]
    [Route("Get_Business_Trendline")]
    public Result_Get_Business_Trendline Get_Business_Trendline(Params_Get_Business_Trendline i_Params_Get_Business_Trendline)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Business_Trendline oResult_Get_Business_Trendline = new Result_Get_Business_Trendline();
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
                oResult_Get_Business_Trendline.i_Result = oBLC.Get_Business_Trendline(i_Params_Get_Business_Trendline);
                oResult_Get_Business_Trendline.Params_Get_Business_Trendline = i_Params_Get_Business_Trendline;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Business_Trendline.Params_Get_Business_Trendline = i_Params_Get_Business_Trendline;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Business_Trendline.Exception_Message = string.Format("Get_Business_Trendline : {0}", ex.Message);
                oResult_Get_Business_Trendline.Stack_Trace = is_send_stack_trace ? string.Format("Get_Business_Trendline : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Business_Trendline.Exception_Message = ex.Message;
                oResult_Get_Business_Trendline.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Business_Trendline;
        #endregion
    }
    #endregion
    #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
    [HttpGet]
    [Route("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv")]
    public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv = new Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv();
        Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.i_Result = oBLC.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.Exception_Message = string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv : {0}", ex.Message);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv;
        #endregion
    }
    #endregion
    #region Edit_Wifi_signal_List
    [HttpPost]
    [Route("Edit_Wifi_signal_List")]
    public Result_Edit_Wifi_signal_List Edit_Wifi_signal_List(Params_Edit_Wifi_signal_List i_Params_Edit_Wifi_signal_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Wifi_signal_List oResult_Edit_Wifi_signal_List = new Result_Edit_Wifi_signal_List();
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
                oBLC.Edit_Wifi_signal_List(i_Params_Edit_Wifi_signal_List);
                oResult_Edit_Wifi_signal_List.Params_Edit_Wifi_signal_List = i_Params_Edit_Wifi_signal_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Wifi_signal_List.Params_Edit_Wifi_signal_List = i_Params_Edit_Wifi_signal_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Wifi_signal_List.Exception_Message = string.Format("Edit_Wifi_signal_List : {0}", ex.Message);
                oResult_Edit_Wifi_signal_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Wifi_signal_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Wifi_signal_List.Exception_Message = ex.Message;
                oResult_Edit_Wifi_signal_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Wifi_signal_List;
        #endregion
    }
    #endregion
    #region Compute_Entity_Kpi_Data_Daily
    [HttpPost]
    [Route("Compute_Entity_Kpi_Data_Daily")]
    public Result_Compute_Entity_Kpi_Data_Daily Compute_Entity_Kpi_Data_Daily(Params_Compute_Entity_Kpi_Data_Daily i_Params_Compute_Entity_Kpi_Data_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Entity_Kpi_Data_Daily oResult_Compute_Entity_Kpi_Data_Daily = new Result_Compute_Entity_Kpi_Data_Daily();
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
                oBLC.Compute_Entity_Kpi_Data_Daily(i_Params_Compute_Entity_Kpi_Data_Daily);
                oResult_Compute_Entity_Kpi_Data_Daily.Params_Compute_Entity_Kpi_Data_Daily = i_Params_Compute_Entity_Kpi_Data_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Entity_Kpi_Data_Daily.Params_Compute_Entity_Kpi_Data_Daily = i_Params_Compute_Entity_Kpi_Data_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Entity_Kpi_Data_Daily.Exception_Message = string.Format("Compute_Entity_Kpi_Data_Daily : {0}", ex.Message);
                oResult_Compute_Entity_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Entity_Kpi_Data_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Entity_Kpi_Data_Daily.Exception_Message = ex.Message;
                oResult_Compute_Entity_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Entity_Kpi_Data_Daily;
        #endregion
    }
    #endregion
    #region Get_Floor_Kpi_Dialog_Data
    [HttpPost]
    [Route("Get_Floor_Kpi_Dialog_Data")]
    public Result_Get_Floor_Kpi_Dialog_Data Get_Floor_Kpi_Dialog_Data(Params_Get_Floor_Kpi_Dialog_Data i_Params_Get_Floor_Kpi_Dialog_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_Kpi_Dialog_Data oResult_Get_Floor_Kpi_Dialog_Data = new Result_Get_Floor_Kpi_Dialog_Data();
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
                oResult_Get_Floor_Kpi_Dialog_Data.i_Result = oBLC.Get_Floor_Kpi_Dialog_Data(i_Params_Get_Floor_Kpi_Dialog_Data);
                oResult_Get_Floor_Kpi_Dialog_Data.Params_Get_Floor_Kpi_Dialog_Data = i_Params_Get_Floor_Kpi_Dialog_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_Kpi_Dialog_Data.Params_Get_Floor_Kpi_Dialog_Data = i_Params_Get_Floor_Kpi_Dialog_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_Kpi_Dialog_Data.Exception_Message = string.Format("Get_Floor_Kpi_Dialog_Data : {0}", ex.Message);
                oResult_Get_Floor_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_Kpi_Dialog_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_Kpi_Dialog_Data.Exception_Message = ex.Message;
                oResult_Get_Floor_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_Kpi_Dialog_Data;
        #endregion
    }
    #endregion
    #region Get_Latest_GeoData_By_KPI
    [HttpPost]
    [Route("Get_Latest_GeoData_By_KPI")]
    public Result_Get_Latest_GeoData_By_KPI Get_Latest_GeoData_By_KPI(Params_Get_Latest_GeoData_By_KPI i_Params_Get_Latest_GeoData_By_KPI)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Latest_GeoData_By_KPI oResult_Get_Latest_GeoData_By_KPI = new Result_Get_Latest_GeoData_By_KPI();
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
                oResult_Get_Latest_GeoData_By_KPI.i_Result = oBLC.Get_Latest_GeoData_By_KPI(i_Params_Get_Latest_GeoData_By_KPI);
                oResult_Get_Latest_GeoData_By_KPI.Params_Get_Latest_GeoData_By_KPI = i_Params_Get_Latest_GeoData_By_KPI;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Latest_GeoData_By_KPI.Params_Get_Latest_GeoData_By_KPI = i_Params_Get_Latest_GeoData_By_KPI;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Latest_GeoData_By_KPI.Exception_Message = string.Format("Get_Latest_GeoData_By_KPI : {0}", ex.Message);
                oResult_Get_Latest_GeoData_By_KPI.Stack_Trace = is_send_stack_trace ? string.Format("Get_Latest_GeoData_By_KPI : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Latest_GeoData_By_KPI.Exception_Message = ex.Message;
                oResult_Get_Latest_GeoData_By_KPI.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Latest_GeoData_By_KPI;
        #endregion
    }
    #endregion
    #region Get_Public_Event_List
    [HttpPost]
    [Route("Get_Public_Event_List")]
    public Result_Get_Public_Event_List Get_Public_Event_List(Params_Get_Public_Event_List i_Params_Get_Public_Event_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Public_Event_List oResult_Get_Public_Event_List = new Result_Get_Public_Event_List();
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
                oResult_Get_Public_Event_List.i_Result = oBLC.Get_Public_Event_List(i_Params_Get_Public_Event_List);
                oResult_Get_Public_Event_List.Params_Get_Public_Event_List = i_Params_Get_Public_Event_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Public_Event_List.Params_Get_Public_Event_List = i_Params_Get_Public_Event_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Public_Event_List.Exception_Message = string.Format("Get_Public_Event_List : {0}", ex.Message);
                oResult_Get_Public_Event_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Public_Event_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Public_Event_List.Exception_Message = ex.Message;
                oResult_Get_Public_Event_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Public_Event_List;
        #endregion
    }
    #endregion
    #region Get_And_Save_Wifi_Signal_From_Api
    [HttpPost]
    [Route("Get_And_Save_Wifi_Signal_From_Api")]
    public Result_Get_And_Save_Wifi_Signal_From_Api Get_And_Save_Wifi_Signal_From_Api()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_And_Save_Wifi_Signal_From_Api oResult_Get_And_Save_Wifi_Signal_From_Api = new Result_Get_And_Save_Wifi_Signal_From_Api();
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
                oBLC.Get_And_Save_Wifi_Signal_From_Api();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_And_Save_Wifi_Signal_From_Api.Exception_Message = string.Format("Get_And_Save_Wifi_Signal_From_Api : {0}", ex.Message);
                oResult_Get_And_Save_Wifi_Signal_From_Api.Stack_Trace = is_send_stack_trace ? string.Format("Get_And_Save_Wifi_Signal_From_Api : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_And_Save_Wifi_Signal_From_Api.Exception_Message = ex.Message;
                oResult_Get_And_Save_Wifi_Signal_From_Api.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_And_Save_Wifi_Signal_From_Api;
        #endregion
    }
    #endregion
    #region Get_Alerts_By_Where
    [HttpPost]
    [Route("Get_Alerts_By_Where")]
    public Result_Get_Alerts_By_Where Get_Alerts_By_Where(Params_Get_Alerts_By_Where i_Params_Get_Alerts_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Alerts_By_Where oResult_Get_Alerts_By_Where = new Result_Get_Alerts_By_Where();
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
                oResult_Get_Alerts_By_Where.i_Result = oBLC.Get_Alerts_By_Where(i_Params_Get_Alerts_By_Where);
                oResult_Get_Alerts_By_Where.Params_Get_Alerts_By_Where = i_Params_Get_Alerts_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Alerts_By_Where.Params_Get_Alerts_By_Where = i_Params_Get_Alerts_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Alerts_By_Where.Exception_Message = string.Format("Get_Alerts_By_Where : {0}", ex.Message);
                oResult_Get_Alerts_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Alerts_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Alerts_By_Where.Exception_Message = ex.Message;
                oResult_Get_Alerts_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Alerts_By_Where;
        #endregion
    }
    #endregion
    #region Compute_Site_Kpi_Data_Hourly
    [HttpPost]
    [Route("Compute_Site_Kpi_Data_Hourly")]
    public Result_Compute_Site_Kpi_Data_Hourly Compute_Site_Kpi_Data_Hourly(Params_Compute_Site_Kpi_Data_Hourly i_Params_Compute_Site_Kpi_Data_Hourly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Site_Kpi_Data_Hourly oResult_Compute_Site_Kpi_Data_Hourly = new Result_Compute_Site_Kpi_Data_Hourly();
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
                oBLC.Compute_Site_Kpi_Data_Hourly(i_Params_Compute_Site_Kpi_Data_Hourly);
                oResult_Compute_Site_Kpi_Data_Hourly.Params_Compute_Site_Kpi_Data_Hourly = i_Params_Compute_Site_Kpi_Data_Hourly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Site_Kpi_Data_Hourly.Params_Compute_Site_Kpi_Data_Hourly = i_Params_Compute_Site_Kpi_Data_Hourly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Site_Kpi_Data_Hourly.Exception_Message = string.Format("Compute_Site_Kpi_Data_Hourly : {0}", ex.Message);
                oResult_Compute_Site_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Site_Kpi_Data_Hourly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Site_Kpi_Data_Hourly.Exception_Message = ex.Message;
                oResult_Compute_Site_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Site_Kpi_Data_Hourly;
        #endregion
    }
    #endregion
    #region Compute_Entity_Kpi_Data_Hourly
    [HttpPost]
    [Route("Compute_Entity_Kpi_Data_Hourly")]
    public Result_Compute_Entity_Kpi_Data_Hourly Compute_Entity_Kpi_Data_Hourly(Params_Compute_Entity_Kpi_Data_Hourly i_Params_Compute_Entity_Kpi_Data_Hourly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Entity_Kpi_Data_Hourly oResult_Compute_Entity_Kpi_Data_Hourly = new Result_Compute_Entity_Kpi_Data_Hourly();
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
                oBLC.Compute_Entity_Kpi_Data_Hourly(i_Params_Compute_Entity_Kpi_Data_Hourly);
                oResult_Compute_Entity_Kpi_Data_Hourly.Params_Compute_Entity_Kpi_Data_Hourly = i_Params_Compute_Entity_Kpi_Data_Hourly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Entity_Kpi_Data_Hourly.Params_Compute_Entity_Kpi_Data_Hourly = i_Params_Compute_Entity_Kpi_Data_Hourly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Entity_Kpi_Data_Hourly.Exception_Message = string.Format("Compute_Entity_Kpi_Data_Hourly : {0}", ex.Message);
                oResult_Compute_Entity_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Entity_Kpi_Data_Hourly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Entity_Kpi_Data_Hourly.Exception_Message = ex.Message;
                oResult_Compute_Entity_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Entity_Kpi_Data_Hourly;
        #endregion
    }
    #endregion
    #region Compute_Entity_Kpi_Data_Monthly
    [HttpPost]
    [Route("Compute_Entity_Kpi_Data_Monthly")]
    public Result_Compute_Entity_Kpi_Data_Monthly Compute_Entity_Kpi_Data_Monthly(Params_Compute_Entity_Kpi_Data_Monthly i_Params_Compute_Entity_Kpi_Data_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Entity_Kpi_Data_Monthly oResult_Compute_Entity_Kpi_Data_Monthly = new Result_Compute_Entity_Kpi_Data_Monthly();
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
                oBLC.Compute_Entity_Kpi_Data_Monthly(i_Params_Compute_Entity_Kpi_Data_Monthly);
                oResult_Compute_Entity_Kpi_Data_Monthly.Params_Compute_Entity_Kpi_Data_Monthly = i_Params_Compute_Entity_Kpi_Data_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Entity_Kpi_Data_Monthly.Params_Compute_Entity_Kpi_Data_Monthly = i_Params_Compute_Entity_Kpi_Data_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Entity_Kpi_Data_Monthly.Exception_Message = string.Format("Compute_Entity_Kpi_Data_Monthly : {0}", ex.Message);
                oResult_Compute_Entity_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Entity_Kpi_Data_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Entity_Kpi_Data_Monthly.Exception_Message = ex.Message;
                oResult_Compute_Entity_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Entity_Kpi_Data_Monthly;
        #endregion
    }
    #endregion
    #region Edit_User_Data_Access
    [HttpPost]
    [Route("Edit_User_Data_Access")]
    public Result_Edit_User_Data_Access Edit_User_Data_Access(Params_Edit_User_Data_Access i_Params_Edit_User_Data_Access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_Data_Access oResult_Edit_User_Data_Access = new Result_Edit_User_Data_Access();
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
                oResult_Edit_User_Data_Access.i_Result = oBLC.Edit_User_Data_Access(i_Params_Edit_User_Data_Access);
                oResult_Edit_User_Data_Access.Params_Edit_User_Data_Access = i_Params_Edit_User_Data_Access;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_User_Data_Access.Params_Edit_User_Data_Access = i_Params_Edit_User_Data_Access;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_Data_Access.Exception_Message = string.Format("Edit_User_Data_Access : {0}", ex.Message);
                oResult_Edit_User_Data_Access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_Data_Access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_Data_Access.Exception_Message = ex.Message;
                oResult_Edit_User_Data_Access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_Data_Access;
        #endregion
    }
    #endregion
    #region Get_Organization_Data_Access
    [HttpPost]
    [Route("Get_Organization_Data_Access")]
    public Result_Get_Organization_Data_Access Get_Organization_Data_Access(Params_Get_Organization_Data_Access i_Params_Get_Organization_Data_Access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_Data_Access oResult_Get_Organization_Data_Access = new Result_Get_Organization_Data_Access();
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
                oResult_Get_Organization_Data_Access.i_Result = oBLC.Get_Organization_Data_Access(i_Params_Get_Organization_Data_Access);
                oResult_Get_Organization_Data_Access.Params_Get_Organization_Data_Access = i_Params_Get_Organization_Data_Access;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_Data_Access.Params_Get_Organization_Data_Access = i_Params_Get_Organization_Data_Access;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_Data_Access.Exception_Message = string.Format("Get_Organization_Data_Access : {0}", ex.Message);
                oResult_Get_Organization_Data_Access.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_Data_Access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_Data_Access.Exception_Message = ex.Message;
                oResult_Get_Organization_Data_Access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_Data_Access;
        #endregion
    }
    #endregion
    #region Get_User_Data_Access
    [HttpPost]
    [Route("Get_User_Data_Access")]
    public Result_Get_User_Data_Access Get_User_Data_Access(Params_Get_User_Data_Access i_Params_Get_User_Data_Access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_Data_Access oResult_Get_User_Data_Access = new Result_Get_User_Data_Access();
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
                oResult_Get_User_Data_Access.i_Result = oBLC.Get_User_Data_Access(i_Params_Get_User_Data_Access);
                oResult_Get_User_Data_Access.Params_Get_User_Data_Access = i_Params_Get_User_Data_Access;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_Data_Access.Params_Get_User_Data_Access = i_Params_Get_User_Data_Access;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_Data_Access.Exception_Message = string.Format("Get_User_Data_Access : {0}", ex.Message);
                oResult_Get_User_Data_Access.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_Data_Access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_Data_Access.Exception_Message = ex.Message;
                oResult_Get_User_Data_Access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_Data_Access;
        #endregion
    }
    #endregion
    #region Delete_Wifi_signal_alert
    [HttpPost]
    [Route("Delete_Wifi_signal_alert")]
    public Result_Delete_Wifi_signal_alert Delete_Wifi_signal_alert(Params_Delete_Wifi_signal_alert i_Params_Delete_Wifi_signal_alert)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Wifi_signal_alert oResult_Delete_Wifi_signal_alert = new Result_Delete_Wifi_signal_alert();
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
                oBLC.Delete_Wifi_signal_alert(i_Params_Delete_Wifi_signal_alert);
                oResult_Delete_Wifi_signal_alert.Params_Delete_Wifi_signal_alert = i_Params_Delete_Wifi_signal_alert;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Wifi_signal_alert.Params_Delete_Wifi_signal_alert = i_Params_Delete_Wifi_signal_alert;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Wifi_signal_alert.Exception_Message = string.Format("Delete_Wifi_signal_alert : {0}", ex.Message);
                oResult_Delete_Wifi_signal_alert.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Wifi_signal_alert : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Wifi_signal_alert.Exception_Message = ex.Message;
                oResult_Delete_Wifi_signal_alert.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Wifi_signal_alert;
        #endregion
    }
    #endregion
    #region Get_Area_Kpi_Dialog_Data
    [HttpPost]
    [Route("Get_Area_Kpi_Dialog_Data")]
    public Result_Get_Area_Kpi_Dialog_Data Get_Area_Kpi_Dialog_Data(Params_Get_Area_Kpi_Dialog_Data i_Params_Get_Area_Kpi_Dialog_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_Kpi_Dialog_Data oResult_Get_Area_Kpi_Dialog_Data = new Result_Get_Area_Kpi_Dialog_Data();
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
                oResult_Get_Area_Kpi_Dialog_Data.i_Result = oBLC.Get_Area_Kpi_Dialog_Data(i_Params_Get_Area_Kpi_Dialog_Data);
                oResult_Get_Area_Kpi_Dialog_Data.Params_Get_Area_Kpi_Dialog_Data = i_Params_Get_Area_Kpi_Dialog_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_Kpi_Dialog_Data.Params_Get_Area_Kpi_Dialog_Data = i_Params_Get_Area_Kpi_Dialog_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_Kpi_Dialog_Data.Exception_Message = string.Format("Get_Area_Kpi_Dialog_Data : {0}", ex.Message);
                oResult_Get_Area_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_Kpi_Dialog_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_Kpi_Dialog_Data.Exception_Message = ex.Message;
                oResult_Get_Area_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_Kpi_Dialog_Data;
        #endregion
    }
    #endregion
    #region Get_Alerts_Count_For_Levels
    [HttpPost]
    [Route("Get_Alerts_Count_For_Levels")]
    public Result_Get_Alerts_Count_For_Levels Get_Alerts_Count_For_Levels(Params_Get_Alerts_Count_For_Levels i_Params_Get_Alerts_Count_For_Levels)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Alerts_Count_For_Levels oResult_Get_Alerts_Count_For_Levels = new Result_Get_Alerts_Count_For_Levels();
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
                oResult_Get_Alerts_Count_For_Levels.i_Result = oBLC.Get_Alerts_Count_For_Levels(i_Params_Get_Alerts_Count_For_Levels);
                oResult_Get_Alerts_Count_For_Levels.Params_Get_Alerts_Count_For_Levels = i_Params_Get_Alerts_Count_For_Levels;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Alerts_Count_For_Levels.Params_Get_Alerts_Count_For_Levels = i_Params_Get_Alerts_Count_For_Levels;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Alerts_Count_For_Levels.Exception_Message = string.Format("Get_Alerts_Count_For_Levels : {0}", ex.Message);
                oResult_Get_Alerts_Count_For_Levels.Stack_Trace = is_send_stack_trace ? string.Format("Get_Alerts_Count_For_Levels : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Alerts_Count_For_Levels.Exception_Message = ex.Message;
                oResult_Get_Alerts_Count_For_Levels.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Alerts_Count_For_Levels;
        #endregion
    }
    #endregion
    #region Get_Space_Kpi_Data_By_Where
    [HttpPost]
    [Route("Get_Space_Kpi_Data_By_Where")]
    public Result_Get_Space_Kpi_Data_By_Where Get_Space_Kpi_Data_By_Where(Params_Get_Space_Kpi_Data_By_Where i_Params_Get_Space_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_Kpi_Data_By_Where oResult_Get_Space_Kpi_Data_By_Where = new Result_Get_Space_Kpi_Data_By_Where();
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
                oResult_Get_Space_Kpi_Data_By_Where.i_Result = oBLC.Get_Space_Kpi_Data_By_Where(i_Params_Get_Space_Kpi_Data_By_Where);
                oResult_Get_Space_Kpi_Data_By_Where.Params_Get_Space_Kpi_Data_By_Where = i_Params_Get_Space_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_Kpi_Data_By_Where.Params_Get_Space_Kpi_Data_By_Where = i_Params_Get_Space_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_Kpi_Data_By_Where.Exception_Message = string.Format("Get_Space_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Get_Space_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Get_Space_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Get_Site_Kpi_Data_Aggregate_Sum
    [HttpPost]
    [Route("Get_Site_Kpi_Data_Aggregate_Sum")]
    public Result_Get_Site_Kpi_Data_Aggregate_Sum Get_Site_Kpi_Data_Aggregate_Sum(Params_Get_Site_Kpi_Data_Aggregate_Sum i_Params_Get_Site_Kpi_Data_Aggregate_Sum)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_Kpi_Data_Aggregate_Sum oResult_Get_Site_Kpi_Data_Aggregate_Sum = new Result_Get_Site_Kpi_Data_Aggregate_Sum();
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
                oResult_Get_Site_Kpi_Data_Aggregate_Sum.i_Result = oBLC.Get_Site_Kpi_Data_Aggregate_Sum(i_Params_Get_Site_Kpi_Data_Aggregate_Sum);
                oResult_Get_Site_Kpi_Data_Aggregate_Sum.Params_Get_Site_Kpi_Data_Aggregate_Sum = i_Params_Get_Site_Kpi_Data_Aggregate_Sum;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_Kpi_Data_Aggregate_Sum.Params_Get_Site_Kpi_Data_Aggregate_Sum = i_Params_Get_Site_Kpi_Data_Aggregate_Sum;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_Kpi_Data_Aggregate_Sum.Exception_Message = string.Format("Get_Site_Kpi_Data_Aggregate_Sum : {0}", ex.Message);
                oResult_Get_Site_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_Kpi_Data_Aggregate_Sum : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_Kpi_Data_Aggregate_Sum.Exception_Message = ex.Message;
                oResult_Get_Site_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_Kpi_Data_Aggregate_Sum;
        #endregion
    }
    #endregion
    #region Get_Organization_data_source_kpi_By_OWNER_ID_Adv
    [HttpGet]
    [Route("Get_Organization_data_source_kpi_By_OWNER_ID_Adv")]
    public Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv Get_Organization_data_source_kpi_By_OWNER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv = new Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv();
        Params_Get_Organization_data_source_kpi_By_OWNER_ID oParams_Get_Organization_data_source_kpi_By_OWNER_ID = new Params_Get_Organization_data_source_kpi_By_OWNER_ID();
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
                oParams_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.i_Result = oBLC.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(oParams_Get_Organization_data_source_kpi_By_OWNER_ID);
                oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.Params_Get_Organization_data_source_kpi_By_OWNER_ID = oParams_Get_Organization_data_source_kpi_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.Params_Get_Organization_data_source_kpi_By_OWNER_ID = oParams_Get_Organization_data_source_kpi_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.Exception_Message = string.Format("Get_Organization_data_source_kpi_By_OWNER_ID_Adv : {0}", ex.Message);
                oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_data_source_kpi_By_OWNER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_data_source_kpi_By_OWNER_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Latest_Visitor_Count_By_Where
    [HttpPost]
    [Route("Get_Latest_Visitor_Count_By_Where")]
    public Result_Get_Latest_Visitor_Count_By_Where Get_Latest_Visitor_Count_By_Where(Params_Get_Latest_Visitor_Count_By_Where i_Params_Get_Latest_Visitor_Count_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Latest_Visitor_Count_By_Where oResult_Get_Latest_Visitor_Count_By_Where = new Result_Get_Latest_Visitor_Count_By_Where();
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
                oResult_Get_Latest_Visitor_Count_By_Where.i_Result = oBLC.Get_Latest_Visitor_Count_By_Where(i_Params_Get_Latest_Visitor_Count_By_Where);
                oResult_Get_Latest_Visitor_Count_By_Where.Params_Get_Latest_Visitor_Count_By_Where = i_Params_Get_Latest_Visitor_Count_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Latest_Visitor_Count_By_Where.Params_Get_Latest_Visitor_Count_By_Where = i_Params_Get_Latest_Visitor_Count_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Latest_Visitor_Count_By_Where.Exception_Message = string.Format("Get_Latest_Visitor_Count_By_Where : {0}", ex.Message);
                oResult_Get_Latest_Visitor_Count_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Latest_Visitor_Count_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Latest_Visitor_Count_By_Where.Exception_Message = ex.Message;
                oResult_Get_Latest_Visitor_Count_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Latest_Visitor_Count_By_Where;
        #endregion
    }
    #endregion
    #region Get_Entity_Kpi_Data_Aggregate_Sum
    [HttpPost]
    [Route("Get_Entity_Kpi_Data_Aggregate_Sum")]
    public Result_Get_Entity_Kpi_Data_Aggregate_Sum Get_Entity_Kpi_Data_Aggregate_Sum(Params_Get_Entity_Kpi_Data_Aggregate_Sum i_Params_Get_Entity_Kpi_Data_Aggregate_Sum)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_Kpi_Data_Aggregate_Sum oResult_Get_Entity_Kpi_Data_Aggregate_Sum = new Result_Get_Entity_Kpi_Data_Aggregate_Sum();
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
                oResult_Get_Entity_Kpi_Data_Aggregate_Sum.i_Result = oBLC.Get_Entity_Kpi_Data_Aggregate_Sum(i_Params_Get_Entity_Kpi_Data_Aggregate_Sum);
                oResult_Get_Entity_Kpi_Data_Aggregate_Sum.Params_Get_Entity_Kpi_Data_Aggregate_Sum = i_Params_Get_Entity_Kpi_Data_Aggregate_Sum;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_Kpi_Data_Aggregate_Sum.Params_Get_Entity_Kpi_Data_Aggregate_Sum = i_Params_Get_Entity_Kpi_Data_Aggregate_Sum;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_Kpi_Data_Aggregate_Sum.Exception_Message = string.Format("Get_Entity_Kpi_Data_Aggregate_Sum : {0}", ex.Message);
                oResult_Get_Entity_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_Kpi_Data_Aggregate_Sum : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_Kpi_Data_Aggregate_Sum.Exception_Message = ex.Message;
                oResult_Get_Entity_Kpi_Data_Aggregate_Sum.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_Kpi_Data_Aggregate_Sum;
        #endregion
    }
    #endregion
    #region Compute_Floor_Kpi_Data_Hourly
    [HttpPost]
    [Route("Compute_Floor_Kpi_Data_Hourly")]
    public Result_Compute_Floor_Kpi_Data_Hourly Compute_Floor_Kpi_Data_Hourly(Params_Compute_Floor_Kpi_Data_Hourly i_Params_Compute_Floor_Kpi_Data_Hourly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Floor_Kpi_Data_Hourly oResult_Compute_Floor_Kpi_Data_Hourly = new Result_Compute_Floor_Kpi_Data_Hourly();
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
                oBLC.Compute_Floor_Kpi_Data_Hourly(i_Params_Compute_Floor_Kpi_Data_Hourly);
                oResult_Compute_Floor_Kpi_Data_Hourly.Params_Compute_Floor_Kpi_Data_Hourly = i_Params_Compute_Floor_Kpi_Data_Hourly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Floor_Kpi_Data_Hourly.Params_Compute_Floor_Kpi_Data_Hourly = i_Params_Compute_Floor_Kpi_Data_Hourly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Floor_Kpi_Data_Hourly.Exception_Message = string.Format("Compute_Floor_Kpi_Data_Hourly : {0}", ex.Message);
                oResult_Compute_Floor_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Floor_Kpi_Data_Hourly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Floor_Kpi_Data_Hourly.Exception_Message = ex.Message;
                oResult_Compute_Floor_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Floor_Kpi_Data_Hourly;
        #endregion
    }
    #endregion
    #region Get_Wifi_signal_alerts
    [HttpPost]
    [Route("Get_Wifi_signal_alerts")]
    public Result_Get_Wifi_signal_alerts Get_Wifi_signal_alerts(Params_Get_Wifi_signal_alerts i_Params_Get_Wifi_signal_alerts)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Wifi_signal_alerts oResult_Get_Wifi_signal_alerts = new Result_Get_Wifi_signal_alerts();
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
                oResult_Get_Wifi_signal_alerts.i_Result = oBLC.Get_Wifi_signal_alerts(i_Params_Get_Wifi_signal_alerts);
                oResult_Get_Wifi_signal_alerts.Params_Get_Wifi_signal_alerts = i_Params_Get_Wifi_signal_alerts;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Wifi_signal_alerts.Params_Get_Wifi_signal_alerts = i_Params_Get_Wifi_signal_alerts;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Wifi_signal_alerts.Exception_Message = string.Format("Get_Wifi_signal_alerts : {0}", ex.Message);
                oResult_Get_Wifi_signal_alerts.Stack_Trace = is_send_stack_trace ? string.Format("Get_Wifi_signal_alerts : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Wifi_signal_alerts.Exception_Message = ex.Message;
                oResult_Get_Wifi_signal_alerts.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Wifi_signal_alerts;
        #endregion
    }
    #endregion
    #region Get_District_Kpi_Data_By_Where
    [HttpPost]
    [Route("Get_District_Kpi_Data_By_Where")]
    public Result_Get_District_Kpi_Data_By_Where Get_District_Kpi_Data_By_Where(Params_Get_District_Kpi_Data_By_Where i_Params_Get_District_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_District_Kpi_Data_By_Where oResult_Get_District_Kpi_Data_By_Where = new Result_Get_District_Kpi_Data_By_Where();
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
                oResult_Get_District_Kpi_Data_By_Where.i_Result = oBLC.Get_District_Kpi_Data_By_Where(i_Params_Get_District_Kpi_Data_By_Where);
                oResult_Get_District_Kpi_Data_By_Where.Params_Get_District_Kpi_Data_By_Where = i_Params_Get_District_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_District_Kpi_Data_By_Where.Params_Get_District_Kpi_Data_By_Where = i_Params_Get_District_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_District_Kpi_Data_By_Where.Exception_Message = string.Format("Get_District_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Get_District_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_District_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_District_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Get_District_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_District_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Get_Kpi_By_OWNER_ID_Adv
    [HttpGet]
    [Route("Get_Kpi_By_OWNER_ID_Adv")]
    public Result_Get_Kpi_By_OWNER_ID_Adv Get_Kpi_By_OWNER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Kpi_By_OWNER_ID_Adv oResult_Get_Kpi_By_OWNER_ID_Adv = new Result_Get_Kpi_By_OWNER_ID_Adv();
        Params_Get_Kpi_By_OWNER_ID oParams_Get_Kpi_By_OWNER_ID = new Params_Get_Kpi_By_OWNER_ID();
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
                oParams_Get_Kpi_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Kpi_By_OWNER_ID_Adv.i_Result = oBLC.Get_Kpi_By_OWNER_ID_Adv(oParams_Get_Kpi_By_OWNER_ID);
                oResult_Get_Kpi_By_OWNER_ID_Adv.Params_Get_Kpi_By_OWNER_ID = oParams_Get_Kpi_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Kpi_By_OWNER_ID_Adv.Params_Get_Kpi_By_OWNER_ID = oParams_Get_Kpi_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Kpi_By_OWNER_ID_Adv.Exception_Message = string.Format("Get_Kpi_By_OWNER_ID_Adv : {0}", ex.Message);
                oResult_Get_Kpi_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Kpi_By_OWNER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Kpi_By_OWNER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Kpi_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Kpi_By_OWNER_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Floor_Kpi_Data_By_Where
    [HttpPost]
    [Route("Get_Floor_Kpi_Data_By_Where")]
    public Result_Get_Floor_Kpi_Data_By_Where Get_Floor_Kpi_Data_By_Where(Params_Get_Floor_Kpi_Data_By_Where i_Params_Get_Floor_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_Kpi_Data_By_Where oResult_Get_Floor_Kpi_Data_By_Where = new Result_Get_Floor_Kpi_Data_By_Where();
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
                oResult_Get_Floor_Kpi_Data_By_Where.i_Result = oBLC.Get_Floor_Kpi_Data_By_Where(i_Params_Get_Floor_Kpi_Data_By_Where);
                oResult_Get_Floor_Kpi_Data_By_Where.Params_Get_Floor_Kpi_Data_By_Where = i_Params_Get_Floor_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_Kpi_Data_By_Where.Params_Get_Floor_Kpi_Data_By_Where = i_Params_Get_Floor_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_Kpi_Data_By_Where.Exception_Message = string.Format("Get_Floor_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Get_Floor_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Get_Floor_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Compute_Floor_Kpi_Data_Weekly
    [HttpPost]
    [Route("Compute_Floor_Kpi_Data_Weekly")]
    public Result_Compute_Floor_Kpi_Data_Weekly Compute_Floor_Kpi_Data_Weekly(Params_Compute_Floor_Kpi_Data_Weekly i_Params_Compute_Floor_Kpi_Data_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Floor_Kpi_Data_Weekly oResult_Compute_Floor_Kpi_Data_Weekly = new Result_Compute_Floor_Kpi_Data_Weekly();
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
                oBLC.Compute_Floor_Kpi_Data_Weekly(i_Params_Compute_Floor_Kpi_Data_Weekly);
                oResult_Compute_Floor_Kpi_Data_Weekly.Params_Compute_Floor_Kpi_Data_Weekly = i_Params_Compute_Floor_Kpi_Data_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Floor_Kpi_Data_Weekly.Params_Compute_Floor_Kpi_Data_Weekly = i_Params_Compute_Floor_Kpi_Data_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Floor_Kpi_Data_Weekly.Exception_Message = string.Format("Compute_Floor_Kpi_Data_Weekly : {0}", ex.Message);
                oResult_Compute_Floor_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Floor_Kpi_Data_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Floor_Kpi_Data_Weekly.Exception_Message = ex.Message;
                oResult_Compute_Floor_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Floor_Kpi_Data_Weekly;
        #endregion
    }
    #endregion
    #region Update_Wifi_signal
    [HttpPost]
    [Route("Update_Wifi_signal")]
    public Result_Update_Wifi_signal Update_Wifi_signal(Params_Update_Wifi_signal i_Params_Update_Wifi_signal)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Update_Wifi_signal oResult_Update_Wifi_signal = new Result_Update_Wifi_signal();
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
                oResult_Update_Wifi_signal.i_Result = oBLC.Update_Wifi_signal(i_Params_Update_Wifi_signal);
                oResult_Update_Wifi_signal.Params_Update_Wifi_signal = i_Params_Update_Wifi_signal;
            }
        }
        catch (Exception ex)
        {
            oResult_Update_Wifi_signal.Params_Update_Wifi_signal = i_Params_Update_Wifi_signal;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Update_Wifi_signal.Exception_Message = string.Format("Update_Wifi_signal : {0}", ex.Message);
                oResult_Update_Wifi_signal.Stack_Trace = is_send_stack_trace ? string.Format("Update_Wifi_signal : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Update_Wifi_signal.Exception_Message = ex.Message;
                oResult_Update_Wifi_signal.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Update_Wifi_signal;
        #endregion
    }
    #endregion
    #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_data_source_kpi_By_ORGANIZATION_ID")]
    public Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID Get_Organization_data_source_kpi_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = new Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID();
        Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_data_source_kpi_By_ORGANIZATION_ID(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_data_source_kpi_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_data_source_kpi_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Visitor_Origins
    [HttpPost]
    [Route("Get_Visitor_Origins")]
    public Result_Get_Visitor_Origins Get_Visitor_Origins(Params_Get_Visitor_Origins i_Params_Get_Visitor_Origins)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Visitor_Origins oResult_Get_Visitor_Origins = new Result_Get_Visitor_Origins();
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
                oResult_Get_Visitor_Origins.i_Result = oBLC.Get_Visitor_Origins(i_Params_Get_Visitor_Origins);
                oResult_Get_Visitor_Origins.Params_Get_Visitor_Origins = i_Params_Get_Visitor_Origins;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Visitor_Origins.Params_Get_Visitor_Origins = i_Params_Get_Visitor_Origins;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Visitor_Origins.Exception_Message = string.Format("Get_Visitor_Origins : {0}", ex.Message);
                oResult_Get_Visitor_Origins.Stack_Trace = is_send_stack_trace ? string.Format("Get_Visitor_Origins : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Visitor_Origins.Exception_Message = ex.Message;
                oResult_Get_Visitor_Origins.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Visitor_Origins;
        #endregion
    }
    #endregion
    #region Compute_Site_Kpi_Data_Daily
    [HttpPost]
    [Route("Compute_Site_Kpi_Data_Daily")]
    public Result_Compute_Site_Kpi_Data_Daily Compute_Site_Kpi_Data_Daily(Params_Compute_Site_Kpi_Data_Daily i_Params_Compute_Site_Kpi_Data_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Site_Kpi_Data_Daily oResult_Compute_Site_Kpi_Data_Daily = new Result_Compute_Site_Kpi_Data_Daily();
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
                oBLC.Compute_Site_Kpi_Data_Daily(i_Params_Compute_Site_Kpi_Data_Daily);
                oResult_Compute_Site_Kpi_Data_Daily.Params_Compute_Site_Kpi_Data_Daily = i_Params_Compute_Site_Kpi_Data_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Site_Kpi_Data_Daily.Params_Compute_Site_Kpi_Data_Daily = i_Params_Compute_Site_Kpi_Data_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Site_Kpi_Data_Daily.Exception_Message = string.Format("Compute_Site_Kpi_Data_Daily : {0}", ex.Message);
                oResult_Compute_Site_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Site_Kpi_Data_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Site_Kpi_Data_Daily.Exception_Message = ex.Message;
                oResult_Compute_Site_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Site_Kpi_Data_Daily;
        #endregion
    }
    #endregion
    #region Compute_District_Kpi_Data_Daily
    [HttpPost]
    [Route("Compute_District_Kpi_Data_Daily")]
    public Result_Compute_District_Kpi_Data_Daily Compute_District_Kpi_Data_Daily(Params_Compute_District_Kpi_Data_Daily i_Params_Compute_District_Kpi_Data_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_District_Kpi_Data_Daily oResult_Compute_District_Kpi_Data_Daily = new Result_Compute_District_Kpi_Data_Daily();
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
                oBLC.Compute_District_Kpi_Data_Daily(i_Params_Compute_District_Kpi_Data_Daily);
                oResult_Compute_District_Kpi_Data_Daily.Params_Compute_District_Kpi_Data_Daily = i_Params_Compute_District_Kpi_Data_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_District_Kpi_Data_Daily.Params_Compute_District_Kpi_Data_Daily = i_Params_Compute_District_Kpi_Data_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_District_Kpi_Data_Daily.Exception_Message = string.Format("Compute_District_Kpi_Data_Daily : {0}", ex.Message);
                oResult_Compute_District_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Compute_District_Kpi_Data_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_District_Kpi_Data_Daily.Exception_Message = ex.Message;
                oResult_Compute_District_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_District_Kpi_Data_Daily;
        #endregion
    }
    #endregion
    #region Compute_Wifi_Signal_Space_Kpi_Data_Hourly
    [HttpPost]
    [Route("Compute_Wifi_Signal_Space_Kpi_Data_Hourly")]
    public Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly Compute_Wifi_Signal_Space_Kpi_Data_Hourly(Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly = new Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly();
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
                oBLC.Compute_Wifi_Signal_Space_Kpi_Data_Hourly(i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly);
                oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly = i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly = i_Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.Exception_Message = string.Format("Compute_Wifi_Signal_Space_Kpi_Data_Hourly : {0}", ex.Message);
                oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Wifi_Signal_Space_Kpi_Data_Hourly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.Exception_Message = ex.Message;
                oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Wifi_Signal_Space_Kpi_Data_Hourly;
        #endregion
    }
    #endregion
    #region Get_Latest_Wifi_signals
    [HttpPost]
    [Route("Get_Latest_Wifi_signals")]
    public Result_Get_Latest_Wifi_signals Get_Latest_Wifi_signals(Params_Get_Latest_Wifi_signals i_Params_Get_Latest_Wifi_signals)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Latest_Wifi_signals oResult_Get_Latest_Wifi_signals = new Result_Get_Latest_Wifi_signals();
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
                oResult_Get_Latest_Wifi_signals.i_Result = oBLC.Get_Latest_Wifi_signals(i_Params_Get_Latest_Wifi_signals);
                oResult_Get_Latest_Wifi_signals.Params_Get_Latest_Wifi_signals = i_Params_Get_Latest_Wifi_signals;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Latest_Wifi_signals.Params_Get_Latest_Wifi_signals = i_Params_Get_Latest_Wifi_signals;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Latest_Wifi_signals.Exception_Message = string.Format("Get_Latest_Wifi_signals : {0}", ex.Message);
                oResult_Get_Latest_Wifi_signals.Stack_Trace = is_send_stack_trace ? string.Format("Get_Latest_Wifi_signals : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Latest_Wifi_signals.Exception_Message = ex.Message;
                oResult_Get_Latest_Wifi_signals.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Latest_Wifi_signals;
        #endregion
    }
    #endregion
    #region Get_Alerts_By_Where_Count
    [HttpPost]
    [Route("Get_Alerts_By_Where_Count")]
    public Result_Get_Alerts_By_Where_Count Get_Alerts_By_Where_Count(Params_Get_Alerts_By_Where_Count i_Params_Get_Alerts_By_Where_Count)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Alerts_By_Where_Count oResult_Get_Alerts_By_Where_Count = new Result_Get_Alerts_By_Where_Count();
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
                oResult_Get_Alerts_By_Where_Count.i_Result = oBLC.Get_Alerts_By_Where_Count(i_Params_Get_Alerts_By_Where_Count);
                oResult_Get_Alerts_By_Where_Count.Params_Get_Alerts_By_Where_Count = i_Params_Get_Alerts_By_Where_Count;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Alerts_By_Where_Count.Params_Get_Alerts_By_Where_Count = i_Params_Get_Alerts_By_Where_Count;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Alerts_By_Where_Count.Exception_Message = string.Format("Get_Alerts_By_Where_Count : {0}", ex.Message);
                oResult_Get_Alerts_By_Where_Count.Stack_Trace = is_send_stack_trace ? string.Format("Get_Alerts_By_Where_Count : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Alerts_By_Where_Count.Exception_Message = ex.Message;
                oResult_Get_Alerts_By_Where_Count.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Alerts_By_Where_Count;
        #endregion
    }
    #endregion
    #region Get_Entity_Incidents
    [HttpPost]
    [Route("Get_Entity_Incidents")]
    public Result_Get_Entity_Incidents Get_Entity_Incidents(Params_Get_Entity_Incidents i_Params_Get_Entity_Incidents)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_Incidents oResult_Get_Entity_Incidents = new Result_Get_Entity_Incidents();
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
                oResult_Get_Entity_Incidents.i_Result = oBLC.Get_Entity_Incidents(i_Params_Get_Entity_Incidents);
                oResult_Get_Entity_Incidents.Params_Get_Entity_Incidents = i_Params_Get_Entity_Incidents;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_Incidents.Params_Get_Entity_Incidents = i_Params_Get_Entity_Incidents;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_Incidents.Exception_Message = string.Format("Get_Entity_Incidents : {0}", ex.Message);
                oResult_Get_Entity_Incidents.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_Incidents : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_Incidents.Exception_Message = ex.Message;
                oResult_Get_Entity_Incidents.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_Incidents;
        #endregion
    }
    #endregion
    #region Get_Bylaw_Complaints_Trendline
    [HttpPost]
    [Route("Get_Bylaw_Complaints_Trendline")]
    public Result_Get_Bylaw_Complaints_Trendline Get_Bylaw_Complaints_Trendline(Params_Get_Bylaw_Complaints_Trendline i_Params_Get_Bylaw_Complaints_Trendline)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Bylaw_Complaints_Trendline oResult_Get_Bylaw_Complaints_Trendline = new Result_Get_Bylaw_Complaints_Trendline();
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
                oResult_Get_Bylaw_Complaints_Trendline.i_Result = oBLC.Get_Bylaw_Complaints_Trendline(i_Params_Get_Bylaw_Complaints_Trendline);
                oResult_Get_Bylaw_Complaints_Trendline.Params_Get_Bylaw_Complaints_Trendline = i_Params_Get_Bylaw_Complaints_Trendline;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Bylaw_Complaints_Trendline.Params_Get_Bylaw_Complaints_Trendline = i_Params_Get_Bylaw_Complaints_Trendline;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Bylaw_Complaints_Trendline.Exception_Message = string.Format("Get_Bylaw_Complaints_Trendline : {0}", ex.Message);
                oResult_Get_Bylaw_Complaints_Trendline.Stack_Trace = is_send_stack_trace ? string.Format("Get_Bylaw_Complaints_Trendline : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Bylaw_Complaints_Trendline.Exception_Message = ex.Message;
                oResult_Get_Bylaw_Complaints_Trendline.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Bylaw_Complaints_Trendline;
        #endregion
    }
    #endregion
    #region Get_Alerts_For_Levels
    [HttpPost]
    [Route("Get_Alerts_For_Levels")]
    public Result_Get_Alerts_For_Levels Get_Alerts_For_Levels(Params_Get_Alerts_For_Levels i_Params_Get_Alerts_For_Levels)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Alerts_For_Levels oResult_Get_Alerts_For_Levels = new Result_Get_Alerts_For_Levels();
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
                oResult_Get_Alerts_For_Levels.i_Result = oBLC.Get_Alerts_For_Levels(i_Params_Get_Alerts_For_Levels);
                oResult_Get_Alerts_For_Levels.Params_Get_Alerts_For_Levels = i_Params_Get_Alerts_For_Levels;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Alerts_For_Levels.Params_Get_Alerts_For_Levels = i_Params_Get_Alerts_For_Levels;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Alerts_For_Levels.Exception_Message = string.Format("Get_Alerts_For_Levels : {0}", ex.Message);
                oResult_Get_Alerts_For_Levels.Stack_Trace = is_send_stack_trace ? string.Format("Get_Alerts_For_Levels : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Alerts_For_Levels.Exception_Message = ex.Message;
                oResult_Get_Alerts_For_Levels.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Alerts_For_Levels;
        #endregion
    }
    #endregion
    #region Compute_Space_Kpi_Data_Weekly
    [HttpPost]
    [Route("Compute_Space_Kpi_Data_Weekly")]
    public Result_Compute_Space_Kpi_Data_Weekly Compute_Space_Kpi_Data_Weekly(Params_Compute_Space_Kpi_Data_Weekly i_Params_Compute_Space_Kpi_Data_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Space_Kpi_Data_Weekly oResult_Compute_Space_Kpi_Data_Weekly = new Result_Compute_Space_Kpi_Data_Weekly();
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
                oBLC.Compute_Space_Kpi_Data_Weekly(i_Params_Compute_Space_Kpi_Data_Weekly);
                oResult_Compute_Space_Kpi_Data_Weekly.Params_Compute_Space_Kpi_Data_Weekly = i_Params_Compute_Space_Kpi_Data_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Space_Kpi_Data_Weekly.Params_Compute_Space_Kpi_Data_Weekly = i_Params_Compute_Space_Kpi_Data_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Space_Kpi_Data_Weekly.Exception_Message = string.Format("Compute_Space_Kpi_Data_Weekly : {0}", ex.Message);
                oResult_Compute_Space_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Space_Kpi_Data_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Space_Kpi_Data_Weekly.Exception_Message = ex.Message;
                oResult_Compute_Space_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Space_Kpi_Data_Weekly;
        #endregion
    }
    #endregion
    #region Get_Area_Kpi_Data_By_Where
    [HttpPost]
    [Route("Get_Area_Kpi_Data_By_Where")]
    public Result_Get_Area_Kpi_Data_By_Where Get_Area_Kpi_Data_By_Where(Params_Get_Area_Kpi_Data_By_Where i_Params_Get_Area_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_Kpi_Data_By_Where oResult_Get_Area_Kpi_Data_By_Where = new Result_Get_Area_Kpi_Data_By_Where();
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
                oResult_Get_Area_Kpi_Data_By_Where.i_Result = oBLC.Get_Area_Kpi_Data_By_Where(i_Params_Get_Area_Kpi_Data_By_Where);
                oResult_Get_Area_Kpi_Data_By_Where.Params_Get_Area_Kpi_Data_By_Where = i_Params_Get_Area_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_Kpi_Data_By_Where.Params_Get_Area_Kpi_Data_By_Where = i_Params_Get_Area_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_Kpi_Data_By_Where.Exception_Message = string.Format("Get_Area_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Get_Area_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Get_Area_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Compute_Site_Kpi_Data_Monthly
    [HttpPost]
    [Route("Compute_Site_Kpi_Data_Monthly")]
    public Result_Compute_Site_Kpi_Data_Monthly Compute_Site_Kpi_Data_Monthly(Params_Compute_Site_Kpi_Data_Monthly i_Params_Compute_Site_Kpi_Data_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Site_Kpi_Data_Monthly oResult_Compute_Site_Kpi_Data_Monthly = new Result_Compute_Site_Kpi_Data_Monthly();
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
                oBLC.Compute_Site_Kpi_Data_Monthly(i_Params_Compute_Site_Kpi_Data_Monthly);
                oResult_Compute_Site_Kpi_Data_Monthly.Params_Compute_Site_Kpi_Data_Monthly = i_Params_Compute_Site_Kpi_Data_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Site_Kpi_Data_Monthly.Params_Compute_Site_Kpi_Data_Monthly = i_Params_Compute_Site_Kpi_Data_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Site_Kpi_Data_Monthly.Exception_Message = string.Format("Compute_Site_Kpi_Data_Monthly : {0}", ex.Message);
                oResult_Compute_Site_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Site_Kpi_Data_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Site_Kpi_Data_Monthly.Exception_Message = ex.Message;
                oResult_Compute_Site_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Site_Kpi_Data_Monthly;
        #endregion
    }
    #endregion
    #region Compute_District_Kpi_Data_Hourly
    [HttpPost]
    [Route("Compute_District_Kpi_Data_Hourly")]
    public Result_Compute_District_Kpi_Data_Hourly Compute_District_Kpi_Data_Hourly(Params_Compute_District_Kpi_Data_Hourly i_Params_Compute_District_Kpi_Data_Hourly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_District_Kpi_Data_Hourly oResult_Compute_District_Kpi_Data_Hourly = new Result_Compute_District_Kpi_Data_Hourly();
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
                oBLC.Compute_District_Kpi_Data_Hourly(i_Params_Compute_District_Kpi_Data_Hourly);
                oResult_Compute_District_Kpi_Data_Hourly.Params_Compute_District_Kpi_Data_Hourly = i_Params_Compute_District_Kpi_Data_Hourly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_District_Kpi_Data_Hourly.Params_Compute_District_Kpi_Data_Hourly = i_Params_Compute_District_Kpi_Data_Hourly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_District_Kpi_Data_Hourly.Exception_Message = string.Format("Compute_District_Kpi_Data_Hourly : {0}", ex.Message);
                oResult_Compute_District_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_District_Kpi_Data_Hourly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_District_Kpi_Data_Hourly.Exception_Message = ex.Message;
                oResult_Compute_District_Kpi_Data_Hourly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_District_Kpi_Data_Hourly;
        #endregion
    }
    #endregion
    #region Get_Intersection_Kpi_Dialog_Data
    [HttpPost]
    [Route("Get_Intersection_Kpi_Dialog_Data")]
    public Result_Get_Intersection_Kpi_Dialog_Data Get_Intersection_Kpi_Dialog_Data(Params_Get_Intersection_Kpi_Dialog_Data i_Params_Get_Intersection_Kpi_Dialog_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Intersection_Kpi_Dialog_Data oResult_Get_Intersection_Kpi_Dialog_Data = new Result_Get_Intersection_Kpi_Dialog_Data();
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
                oResult_Get_Intersection_Kpi_Dialog_Data.i_Result = oBLC.Get_Intersection_Kpi_Dialog_Data(i_Params_Get_Intersection_Kpi_Dialog_Data);
                oResult_Get_Intersection_Kpi_Dialog_Data.Params_Get_Intersection_Kpi_Dialog_Data = i_Params_Get_Intersection_Kpi_Dialog_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Intersection_Kpi_Dialog_Data.Params_Get_Intersection_Kpi_Dialog_Data = i_Params_Get_Intersection_Kpi_Dialog_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Intersection_Kpi_Dialog_Data.Exception_Message = string.Format("Get_Intersection_Kpi_Dialog_Data : {0}", ex.Message);
                oResult_Get_Intersection_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Intersection_Kpi_Dialog_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Intersection_Kpi_Dialog_Data.Exception_Message = ex.Message;
                oResult_Get_Intersection_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Intersection_Kpi_Dialog_Data;
        #endregion
    }
    #endregion
    #region Compute_Floor_Kpi_Data_Daily
    [HttpPost]
    [Route("Compute_Floor_Kpi_Data_Daily")]
    public Result_Compute_Floor_Kpi_Data_Daily Compute_Floor_Kpi_Data_Daily(Params_Compute_Floor_Kpi_Data_Daily i_Params_Compute_Floor_Kpi_Data_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Floor_Kpi_Data_Daily oResult_Compute_Floor_Kpi_Data_Daily = new Result_Compute_Floor_Kpi_Data_Daily();
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
                oBLC.Compute_Floor_Kpi_Data_Daily(i_Params_Compute_Floor_Kpi_Data_Daily);
                oResult_Compute_Floor_Kpi_Data_Daily.Params_Compute_Floor_Kpi_Data_Daily = i_Params_Compute_Floor_Kpi_Data_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Floor_Kpi_Data_Daily.Params_Compute_Floor_Kpi_Data_Daily = i_Params_Compute_Floor_Kpi_Data_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Floor_Kpi_Data_Daily.Exception_Message = string.Format("Compute_Floor_Kpi_Data_Daily : {0}", ex.Message);
                oResult_Compute_Floor_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Floor_Kpi_Data_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Floor_Kpi_Data_Daily.Exception_Message = ex.Message;
                oResult_Compute_Floor_Kpi_Data_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Floor_Kpi_Data_Daily;
        #endregion
    }
    #endregion
    #region Get_Strongest_Wifi_signal
    [HttpPost]
    [Route("Get_Strongest_Wifi_signal")]
    public Result_Get_Strongest_Wifi_signal Get_Strongest_Wifi_signal(Params_Get_Strongest_Wifi_signal i_Params_Get_Strongest_Wifi_signal)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Strongest_Wifi_signal oResult_Get_Strongest_Wifi_signal = new Result_Get_Strongest_Wifi_signal();
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
                oResult_Get_Strongest_Wifi_signal.i_Result = oBLC.Get_Strongest_Wifi_signal(i_Params_Get_Strongest_Wifi_signal);
                oResult_Get_Strongest_Wifi_signal.Params_Get_Strongest_Wifi_signal = i_Params_Get_Strongest_Wifi_signal;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Strongest_Wifi_signal.Params_Get_Strongest_Wifi_signal = i_Params_Get_Strongest_Wifi_signal;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Strongest_Wifi_signal.Exception_Message = string.Format("Get_Strongest_Wifi_signal : {0}", ex.Message);
                oResult_Get_Strongest_Wifi_signal.Stack_Trace = is_send_stack_trace ? string.Format("Get_Strongest_Wifi_signal : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Strongest_Wifi_signal.Exception_Message = ex.Message;
                oResult_Get_Strongest_Wifi_signal.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Strongest_Wifi_signal;
        #endregion
    }
    #endregion
    #region Compute_Area_Kpi_Data_Monthly
    [HttpPost]
    [Route("Compute_Area_Kpi_Data_Monthly")]
    public Result_Compute_Area_Kpi_Data_Monthly Compute_Area_Kpi_Data_Monthly(Params_Compute_Area_Kpi_Data_Monthly i_Params_Compute_Area_Kpi_Data_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Area_Kpi_Data_Monthly oResult_Compute_Area_Kpi_Data_Monthly = new Result_Compute_Area_Kpi_Data_Monthly();
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
                oBLC.Compute_Area_Kpi_Data_Monthly(i_Params_Compute_Area_Kpi_Data_Monthly);
                oResult_Compute_Area_Kpi_Data_Monthly.Params_Compute_Area_Kpi_Data_Monthly = i_Params_Compute_Area_Kpi_Data_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Area_Kpi_Data_Monthly.Params_Compute_Area_Kpi_Data_Monthly = i_Params_Compute_Area_Kpi_Data_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Area_Kpi_Data_Monthly.Exception_Message = string.Format("Compute_Area_Kpi_Data_Monthly : {0}", ex.Message);
                oResult_Compute_Area_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Area_Kpi_Data_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Area_Kpi_Data_Monthly.Exception_Message = ex.Message;
                oResult_Compute_Area_Kpi_Data_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Area_Kpi_Data_Monthly;
        #endregion
    }
    #endregion
    #region Get_Business_List
    [HttpPost]
    [Route("Get_Business_List")]
    public Result_Get_Business_List Get_Business_List(Params_Get_Business_List i_Params_Get_Business_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Business_List oResult_Get_Business_List = new Result_Get_Business_List();
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
                oResult_Get_Business_List.i_Result = oBLC.Get_Business_List(i_Params_Get_Business_List);
                oResult_Get_Business_List.Params_Get_Business_List = i_Params_Get_Business_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Business_List.Params_Get_Business_List = i_Params_Get_Business_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Business_List.Exception_Message = string.Format("Get_Business_List : {0}", ex.Message);
                oResult_Get_Business_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Business_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Business_List.Exception_Message = ex.Message;
                oResult_Get_Business_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Business_List;
        #endregion
    }
    #endregion
    #region Edit_Organization_Data_Access
    [HttpPost]
    [Route("Edit_Organization_Data_Access")]
    public Result_Edit_Organization_Data_Access Edit_Organization_Data_Access(Params_Edit_Organization_Data_Access i_Params_Edit_Organization_Data_Access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_Data_Access oResult_Edit_Organization_Data_Access = new Result_Edit_Organization_Data_Access();
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
                oResult_Edit_Organization_Data_Access.i_Result = oBLC.Edit_Organization_Data_Access(i_Params_Edit_Organization_Data_Access);
                oResult_Edit_Organization_Data_Access.Params_Edit_Organization_Data_Access = i_Params_Edit_Organization_Data_Access;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Organization_Data_Access.Params_Edit_Organization_Data_Access = i_Params_Edit_Organization_Data_Access;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_Data_Access.Exception_Message = string.Format("Edit_Organization_Data_Access : {0}", ex.Message);
                oResult_Edit_Organization_Data_Access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_Data_Access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_Data_Access.Exception_Message = ex.Message;
                oResult_Edit_Organization_Data_Access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_Data_Access;
        #endregion
    }
    #endregion
    #region Edit_Kpi
    [HttpPost]
    [Route("Edit_Kpi")]
    public Result_Edit_Kpi Edit_Kpi(Kpi i_Kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Kpi oResult_Edit_Kpi = new Result_Edit_Kpi();
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
                oBLC.Edit_Kpi(i_Kpi);
                oResult_Edit_Kpi.Kpi = i_Kpi;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Kpi.Exception_Message = string.Format("Edit_Kpi : {0}", ex.Message);
                oResult_Edit_Kpi.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Kpi.Exception_Message = ex.Message;
                oResult_Edit_Kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Kpi;
        #endregion
    }
    #endregion
    #region Get_Entity_Kpi_Dialog_Data
    [HttpPost]
    [Route("Get_Entity_Kpi_Dialog_Data")]
    public Result_Get_Entity_Kpi_Dialog_Data Get_Entity_Kpi_Dialog_Data(Params_Get_Entity_Kpi_Dialog_Data i_Params_Get_Entity_Kpi_Dialog_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_Kpi_Dialog_Data oResult_Get_Entity_Kpi_Dialog_Data = new Result_Get_Entity_Kpi_Dialog_Data();
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
                oResult_Get_Entity_Kpi_Dialog_Data.i_Result = oBLC.Get_Entity_Kpi_Dialog_Data(i_Params_Get_Entity_Kpi_Dialog_Data);
                oResult_Get_Entity_Kpi_Dialog_Data.Params_Get_Entity_Kpi_Dialog_Data = i_Params_Get_Entity_Kpi_Dialog_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_Kpi_Dialog_Data.Params_Get_Entity_Kpi_Dialog_Data = i_Params_Get_Entity_Kpi_Dialog_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_Kpi_Dialog_Data.Exception_Message = string.Format("Get_Entity_Kpi_Dialog_Data : {0}", ex.Message);
                oResult_Get_Entity_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_Kpi_Dialog_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_Kpi_Dialog_Data.Exception_Message = ex.Message;
                oResult_Get_Entity_Kpi_Dialog_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_Kpi_Dialog_Data;
        #endregion
    }
    #endregion
    #region Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
    [HttpPost]
    [Route("Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID")]
    public Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID = new Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID();
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
                oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.i_Result = oBLC.Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID);
                oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID = i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID = i_Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.Exception_Message = string.Format("Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID : {0}", ex.Message);
                oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID;
        #endregion
    }
    #endregion
    #region Compute_Site_Kpi_Data_Weekly
    [HttpPost]
    [Route("Compute_Site_Kpi_Data_Weekly")]
    public Result_Compute_Site_Kpi_Data_Weekly Compute_Site_Kpi_Data_Weekly(Params_Compute_Site_Kpi_Data_Weekly i_Params_Compute_Site_Kpi_Data_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Site_Kpi_Data_Weekly oResult_Compute_Site_Kpi_Data_Weekly = new Result_Compute_Site_Kpi_Data_Weekly();
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
                oBLC.Compute_Site_Kpi_Data_Weekly(i_Params_Compute_Site_Kpi_Data_Weekly);
                oResult_Compute_Site_Kpi_Data_Weekly.Params_Compute_Site_Kpi_Data_Weekly = i_Params_Compute_Site_Kpi_Data_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Site_Kpi_Data_Weekly.Params_Compute_Site_Kpi_Data_Weekly = i_Params_Compute_Site_Kpi_Data_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Site_Kpi_Data_Weekly.Exception_Message = string.Format("Compute_Site_Kpi_Data_Weekly : {0}", ex.Message);
                oResult_Compute_Site_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Site_Kpi_Data_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Site_Kpi_Data_Weekly.Exception_Message = ex.Message;
                oResult_Compute_Site_Kpi_Data_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Site_Kpi_Data_Weekly;
        #endregion
    }
    #endregion
    #region Get_Most_Wifi_signal_Count_Per_Space_asset
    [HttpPost]
    [Route("Get_Most_Wifi_signal_Count_Per_Space_asset")]
    public Result_Get_Most_Wifi_signal_Count_Per_Space_asset Get_Most_Wifi_signal_Count_Per_Space_asset(Params_Get_Most_Wifi_signal_Count_Per_Space_asset i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Most_Wifi_signal_Count_Per_Space_asset oResult_Get_Most_Wifi_signal_Count_Per_Space_asset = new Result_Get_Most_Wifi_signal_Count_Per_Space_asset();
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
                oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.i_Result = oBLC.Get_Most_Wifi_signal_Count_Per_Space_asset(i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset);
                oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.Params_Get_Most_Wifi_signal_Count_Per_Space_asset = i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.Params_Get_Most_Wifi_signal_Count_Per_Space_asset = i_Params_Get_Most_Wifi_signal_Count_Per_Space_asset;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.Exception_Message = string.Format("Get_Most_Wifi_signal_Count_Per_Space_asset : {0}", ex.Message);
                oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.Stack_Trace = is_send_stack_trace ? string.Format("Get_Most_Wifi_signal_Count_Per_Space_asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.Exception_Message = ex.Message;
                oResult_Get_Most_Wifi_signal_Count_Per_Space_asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Most_Wifi_signal_Count_Per_Space_asset;
        #endregion
    }
    #endregion
    #region Get_Public_Events_Trendline
    [HttpPost]
    [Route("Get_Public_Events_Trendline")]
    public Result_Get_Public_Events_Trendline Get_Public_Events_Trendline(Params_Get_Public_Events_Trendline i_Params_Get_Public_Events_Trendline)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Public_Events_Trendline oResult_Get_Public_Events_Trendline = new Result_Get_Public_Events_Trendline();
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
                oResult_Get_Public_Events_Trendline.i_Result = oBLC.Get_Public_Events_Trendline(i_Params_Get_Public_Events_Trendline);
                oResult_Get_Public_Events_Trendline.Params_Get_Public_Events_Trendline = i_Params_Get_Public_Events_Trendline;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Public_Events_Trendline.Params_Get_Public_Events_Trendline = i_Params_Get_Public_Events_Trendline;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Public_Events_Trendline.Exception_Message = string.Format("Get_Public_Events_Trendline : {0}", ex.Message);
                oResult_Get_Public_Events_Trendline.Stack_Trace = is_send_stack_trace ? string.Format("Get_Public_Events_Trendline : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Public_Events_Trendline.Exception_Message = ex.Message;
                oResult_Get_Public_Events_Trendline.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Public_Events_Trendline;
        #endregion
    }
    #endregion
    #region Get_User_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_User_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_User_By_ORGANIZATION_ID_List_Adv Get_User_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_ORGANIZATION_ID_List_Adv oResult_Get_User_By_ORGANIZATION_ID_List_Adv = new Result_Get_User_By_ORGANIZATION_ID_List_Adv();
        Params_Get_User_By_ORGANIZATION_ID_List oParams_Get_User_By_ORGANIZATION_ID_List = new Params_Get_User_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request
                                                                                           .Query["ORGANIZATION_ID_LIST"]
                                                                                           .ToString()
                                                                                           .Split(',')
                                                                                           .Where(val => int.TryParse(val, out _))
                                                                                           .Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_User_By_ORGANIZATION_ID_List_Adv(oParams_Get_User_By_ORGANIZATION_ID_List);
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_User_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_User_By_ORGANIZATION_ID_List
    [HttpGet]
    [Route("Get_User_By_ORGANIZATION_ID_List")]
    public Result_Get_User_By_ORGANIZATION_ID_List Get_User_By_ORGANIZATION_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_ORGANIZATION_ID_List oResult_Get_User_By_ORGANIZATION_ID_List = new Result_Get_User_By_ORGANIZATION_ID_List();
        Params_Get_User_By_ORGANIZATION_ID_List oParams_Get_User_By_ORGANIZATION_ID_List = new Params_Get_User_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request
                                                                                           .Query["ORGANIZATION_ID_LIST"]
                                                                                           .ToString()
                                                                                           .Split(',')
                                                                                           .Where(val => int.TryParse(val, out _))
                                                                                           .Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_ORGANIZATION_ID_List.i_Result = oBLC.Get_User_By_ORGANIZATION_ID_List(oParams_Get_User_By_ORGANIZATION_ID_List);
                oResult_Get_User_By_ORGANIZATION_ID_List.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_ORGANIZATION_ID_List.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_ORGANIZATION_ID_List.Exception_Message = string.Format("Get_User_By_ORGANIZATION_ID_List : {0}", ex.Message);
                oResult_Get_User_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_ORGANIZATION_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_ORGANIZATION_ID_List.Exception_Message = ex.Message;
                oResult_Get_User_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_ORGANIZATION_ID_List;
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
#region Result_Get_Wifi_signals
public partial class Result_Get_Wifi_signals : Action_Result
{
    #region Properties.
    public List<Wifi_signal> i_Result { get; set; }
    public Params_Get_Wifi_signals Params_Get_Wifi_signals { get; set; }
    #endregion
}
#endregion
#region Result_Get_District_Kpi_Dialog_Data
public partial class Result_Get_District_Kpi_Dialog_Data : Action_Result
{
    #region Properties.
    public List<District_Kpi_Dialog_Data> i_Result { get; set; }
    public Params_Get_District_Kpi_Dialog_Data Params_Get_District_Kpi_Dialog_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_Kpi_Data_Aggregate_Sum
public partial class Result_Get_Area_Kpi_Data_Aggregate_Sum : Action_Result
{
    #region Properties.
    public List<Area_kpi_data> i_Result { get; set; }
    public Params_Get_Area_Kpi_Data_Aggregate_Sum Params_Get_Area_Kpi_Data_Aggregate_Sum { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_Kpi_Data_By_Where
public partial class Result_Get_Entity_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public List<Entity_kpi_data> i_Result { get; set; }
    public Params_Get_Entity_Kpi_Data_By_Where Params_Get_Entity_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Area_Kpi_Data_Hourly
public partial class Result_Compute_Area_Kpi_Data_Hourly : Action_Result
{
    #region Properties.
    public Params_Compute_Area_Kpi_Data_Hourly Params_Compute_Area_Kpi_Data_Hourly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_Kpi_Dialog_Data
public partial class Result_Get_Site_Kpi_Dialog_Data : Action_Result
{
    #region Properties.
    public List<Site_Kpi_Dialog_Data> i_Result { get; set; }
    public Params_Get_Site_Kpi_Dialog_Data Params_Get_Site_Kpi_Dialog_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_Kpi_Data_By_Where
public partial class Result_Get_Site_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public List<Site_kpi_data> i_Result { get; set; }
    public Params_Get_Site_Kpi_Data_By_Where Params_Get_Site_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Alert_List
public partial class Result_Edit_Alert_List : Action_Result
{
    #region Properties.
    public Params_Edit_Alert_List Params_Edit_Alert_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Organization_data_source_kpi> i_Result { get; set; }
    public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Compute_District_Kpi_Data_Monthly
public partial class Result_Compute_District_Kpi_Data_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_District_Kpi_Data_Monthly Params_Compute_District_Kpi_Data_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Bylaw_Complaint_List
public partial class Result_Get_Bylaw_Complaint_List : Action_Result
{
    #region Properties.
    public List<Bylaw_Complaint> i_Result { get; set; }
    public Params_Get_Bylaw_Complaint_List Params_Get_Bylaw_Complaint_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Kpi
public partial class Result_Delete_Kpi : Action_Result
{
    #region Properties.
    public Params_Delete_Kpi Params_Delete_Kpi { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Wifi_signal
public partial class Result_Delete_Wifi_signal : Action_Result
{
    #region Properties.
    public Params_Delete_Wifi_signal Params_Delete_Wifi_signal { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Floor_Kpi_Data_Monthly
public partial class Result_Compute_Floor_Kpi_Data_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_Floor_Kpi_Data_Monthly Params_Compute_Floor_Kpi_Data_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Wifi_signal_alert_List
public partial class Result_Edit_Wifi_signal_alert_List : Action_Result
{
    #region Properties.
    public Params_Edit_Wifi_signal_alert_List Params_Edit_Wifi_signal_alert_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Alert
public partial class Result_Delete_Alert : Action_Result
{
    #region Properties.
    public Params_Delete_Alert Params_Delete_Alert { get; set; }
    #endregion
}
#endregion
#region Result_Compute_District_Kpi_Data_Weekly
public partial class Result_Compute_District_Kpi_Data_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_District_Kpi_Data_Weekly Params_Compute_District_Kpi_Data_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Get_District_Kpi_Data_Aggregate_Sum
public partial class Result_Get_District_Kpi_Data_Aggregate_Sum : Action_Result
{
    #region Properties.
    public List<District_kpi_data> i_Result { get; set; }
    public Params_Get_District_Kpi_Data_Aggregate_Sum Params_Get_District_Kpi_Data_Aggregate_Sum { get; set; }
    #endregion
}
#endregion
#region Result_Get_Latest_Organization_data_source_kpi_By_Where
public partial class Result_Get_Latest_Organization_data_source_kpi_By_Where : Action_Result
{
    #region Properties.
    public List<Organization_data_source_kpi_By_Level> i_Result { get; set; }
    public Params_Get_Latest_Organization_data_source_kpi_By_Where Params_Get_Latest_Organization_data_source_kpi_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Space_Kpi_Data_Monthly
public partial class Result_Compute_Space_Kpi_Data_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_Space_Kpi_Data_Monthly Params_Compute_Space_Kpi_Data_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Space_Kpi_Data_Daily
public partial class Result_Compute_Space_Kpi_Data_Daily : Action_Result
{
    #region Properties.
    public Params_Compute_Space_Kpi_Data_Daily Params_Compute_Space_Kpi_Data_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Update_Kpi_Data_Record
public partial class Result_Update_Kpi_Data_Record : Action_Result
{
    #region Properties.
    public Params_Update_Kpi_Data_Record Params_Update_Kpi_Data_Record { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Area_Kpi_Data_Daily
public partial class Result_Compute_Area_Kpi_Data_Daily : Action_Result
{
    #region Properties.
    public Params_Compute_Area_Kpi_Data_Daily Params_Compute_Area_Kpi_Data_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Get_Latest_Wifi_signal_alerts
public partial class Result_Get_Latest_Wifi_signal_alerts : Action_Result
{
    #region Properties.
    public List<Wifi_signal_alert> i_Result { get; set; }
    public Params_Get_Latest_Wifi_signal_alerts Params_Get_Latest_Wifi_signal_alerts { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_Kpi_Data_Aggregate_Sum
public partial class Result_Get_Floor_Kpi_Data_Aggregate_Sum : Action_Result
{
    #region Properties.
    public List<Floor_kpi_data> i_Result { get; set; }
    public Params_Get_Floor_Kpi_Data_Aggregate_Sum Params_Get_Floor_Kpi_Data_Aggregate_Sum { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Entity_Kpi_Data_Weekly
public partial class Result_Compute_Entity_Kpi_Data_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_Entity_Kpi_Data_Weekly Params_Compute_Entity_Kpi_Data_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv : Action_Result
{
    #region Properties.
    public Organization_data_source_kpi i_Result { get; set; }
    public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Area_Kpi_Data_Weekly
public partial class Result_Compute_Area_Kpi_Data_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_Area_Kpi_Data_Weekly Params_Compute_Area_Kpi_Data_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Business_Trendline
public partial class Result_Get_Business_Trendline : Action_Result
{
    #region Properties.
    public List<Kpi_Value_By_Date> i_Result { get; set; }
    public Params_Get_Business_Trendline Params_Get_Business_Trendline { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv : Action_Result
{
    #region Properties.
    public List<Organization_data_source_kpi> i_Result { get; set; }
    public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Wifi_signal_List
public partial class Result_Edit_Wifi_signal_List : Action_Result
{
    #region Properties.
    public Params_Edit_Wifi_signal_List Params_Edit_Wifi_signal_List { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Entity_Kpi_Data_Daily
public partial class Result_Compute_Entity_Kpi_Data_Daily : Action_Result
{
    #region Properties.
    public Params_Compute_Entity_Kpi_Data_Daily Params_Compute_Entity_Kpi_Data_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_Kpi_Dialog_Data
public partial class Result_Get_Floor_Kpi_Dialog_Data : Action_Result
{
    #region Properties.
    public List<Floor_Kpi_Dialog_Data> i_Result { get; set; }
    public Params_Get_Floor_Kpi_Dialog_Data Params_Get_Floor_Kpi_Dialog_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Latest_GeoData_By_KPI
public partial class Result_Get_Latest_GeoData_By_KPI : Action_Result
{
    #region Properties.
    public GeoData i_Result { get; set; }
    public Params_Get_Latest_GeoData_By_KPI Params_Get_Latest_GeoData_By_KPI { get; set; }
    #endregion
}
#endregion
#region Result_Get_Public_Event_List
public partial class Result_Get_Public_Event_List : Action_Result
{
    #region Properties.
    public List<Public_Event> i_Result { get; set; }
    public Params_Get_Public_Event_List Params_Get_Public_Event_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_And_Save_Wifi_Signal_From_Api
public partial class Result_Get_And_Save_Wifi_Signal_From_Api : Action_Result
{
    #region Properties.
    #endregion
}
#endregion
#region Result_Get_Alerts_By_Where
public partial class Result_Get_Alerts_By_Where : Action_Result
{
    #region Properties.
    public List<Alert> i_Result { get; set; }
    public Params_Get_Alerts_By_Where Params_Get_Alerts_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Site_Kpi_Data_Hourly
public partial class Result_Compute_Site_Kpi_Data_Hourly : Action_Result
{
    #region Properties.
    public Params_Compute_Site_Kpi_Data_Hourly Params_Compute_Site_Kpi_Data_Hourly { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Entity_Kpi_Data_Hourly
public partial class Result_Compute_Entity_Kpi_Data_Hourly : Action_Result
{
    #region Properties.
    public Params_Compute_Entity_Kpi_Data_Hourly Params_Compute_Entity_Kpi_Data_Hourly { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Entity_Kpi_Data_Monthly
public partial class Result_Compute_Entity_Kpi_Data_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_Entity_Kpi_Data_Monthly Params_Compute_Entity_Kpi_Data_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_Data_Access
public partial class Result_Edit_User_Data_Access : Action_Result
{
    #region Properties.
    public Params_Edit_User_Data_Access i_Result { get; set; }
    public Params_Edit_User_Data_Access Params_Edit_User_Data_Access { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_Data_Access
public partial class Result_Get_Organization_Data_Access : Action_Result
{
    #region Properties.
    public Organization_Data_Access i_Result { get; set; }
    public Params_Get_Organization_Data_Access Params_Get_Organization_Data_Access { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_Data_Access
public partial class Result_Get_User_Data_Access : Action_Result
{
    #region Properties.
    public User_Data_Access i_Result { get; set; }
    public Params_Get_User_Data_Access Params_Get_User_Data_Access { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Wifi_signal_alert
public partial class Result_Delete_Wifi_signal_alert : Action_Result
{
    #region Properties.
    public Params_Delete_Wifi_signal_alert Params_Delete_Wifi_signal_alert { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_Kpi_Dialog_Data
public partial class Result_Get_Area_Kpi_Dialog_Data : Action_Result
{
    #region Properties.
    public List<Area_Kpi_Dialog_Data> i_Result { get; set; }
    public Params_Get_Area_Kpi_Dialog_Data Params_Get_Area_Kpi_Dialog_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Alerts_Count_For_Levels
public partial class Result_Get_Alerts_Count_For_Levels : Action_Result
{
    #region Properties.
    public long? i_Result { get; set; }
    public Params_Get_Alerts_Count_For_Levels Params_Get_Alerts_Count_For_Levels { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_Kpi_Data_By_Where
public partial class Result_Get_Space_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public List<Space_kpi_data> i_Result { get; set; }
    public Params_Get_Space_Kpi_Data_By_Where Params_Get_Space_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_Kpi_Data_Aggregate_Sum
public partial class Result_Get_Site_Kpi_Data_Aggregate_Sum : Action_Result
{
    #region Properties.
    public List<Site_kpi_data> i_Result { get; set; }
    public Params_Get_Site_Kpi_Data_Aggregate_Sum Params_Get_Site_Kpi_Data_Aggregate_Sum { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv
public partial class Result_Get_Organization_data_source_kpi_By_OWNER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Organization_data_source_kpi> i_Result { get; set; }
    public Params_Get_Organization_data_source_kpi_By_OWNER_ID Params_Get_Organization_data_source_kpi_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Latest_Visitor_Count_By_Where
public partial class Result_Get_Latest_Visitor_Count_By_Where : Action_Result
{
    #region Properties.
    public List<Visitor_Count_By_Level> i_Result { get; set; }
    public Params_Get_Latest_Visitor_Count_By_Where Params_Get_Latest_Visitor_Count_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_Kpi_Data_Aggregate_Sum
public partial class Result_Get_Entity_Kpi_Data_Aggregate_Sum : Action_Result
{
    #region Properties.
    public List<Entity_kpi_data> i_Result { get; set; }
    public Params_Get_Entity_Kpi_Data_Aggregate_Sum Params_Get_Entity_Kpi_Data_Aggregate_Sum { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Floor_Kpi_Data_Hourly
public partial class Result_Compute_Floor_Kpi_Data_Hourly : Action_Result
{
    #region Properties.
    public Params_Compute_Floor_Kpi_Data_Hourly Params_Compute_Floor_Kpi_Data_Hourly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Wifi_signal_alerts
public partial class Result_Get_Wifi_signal_alerts : Action_Result
{
    #region Properties.
    public List<Wifi_signal_alert> i_Result { get; set; }
    public Params_Get_Wifi_signal_alerts Params_Get_Wifi_signal_alerts { get; set; }
    #endregion
}
#endregion
#region Result_Get_District_Kpi_Data_By_Where
public partial class Result_Get_District_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public List<District_kpi_data> i_Result { get; set; }
    public Params_Get_District_Kpi_Data_By_Where Params_Get_District_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Get_Kpi_By_OWNER_ID_Adv
public partial class Result_Get_Kpi_By_OWNER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Kpi> i_Result { get; set; }
    public Params_Get_Kpi_By_OWNER_ID Params_Get_Kpi_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_Kpi_Data_By_Where
public partial class Result_Get_Floor_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public List<Floor_kpi_data> i_Result { get; set; }
    public Params_Get_Floor_Kpi_Data_By_Where Params_Get_Floor_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Floor_Kpi_Data_Weekly
public partial class Result_Compute_Floor_Kpi_Data_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_Floor_Kpi_Data_Weekly Params_Compute_Floor_Kpi_Data_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Update_Wifi_signal
public partial class Result_Update_Wifi_signal : Action_Result
{
    #region Properties.
    public Wifi_signal_data i_Result { get; set; }
    public Params_Update_Wifi_signal Params_Update_Wifi_signal { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID
public partial class Result_Get_Organization_data_source_kpi_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_data_source_kpi> i_Result { get; set; }
    public Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Visitor_Origins
public partial class Result_Get_Visitor_Origins : Action_Result
{
    #region Properties.
    public Visitor_Origins i_Result { get; set; }
    public Params_Get_Visitor_Origins Params_Get_Visitor_Origins { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Site_Kpi_Data_Daily
public partial class Result_Compute_Site_Kpi_Data_Daily : Action_Result
{
    #region Properties.
    public Params_Compute_Site_Kpi_Data_Daily Params_Compute_Site_Kpi_Data_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Compute_District_Kpi_Data_Daily
public partial class Result_Compute_District_Kpi_Data_Daily : Action_Result
{
    #region Properties.
    public Params_Compute_District_Kpi_Data_Daily Params_Compute_District_Kpi_Data_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly
public partial class Result_Compute_Wifi_Signal_Space_Kpi_Data_Hourly : Action_Result
{
    #region Properties.
    public Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly Params_Compute_Wifi_Signal_Space_Kpi_Data_Hourly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Latest_Wifi_signals
public partial class Result_Get_Latest_Wifi_signals : Action_Result
{
    #region Properties.
    public List<Wifi_signal> i_Result { get; set; }
    public Params_Get_Latest_Wifi_signals Params_Get_Latest_Wifi_signals { get; set; }
    #endregion
}
#endregion
#region Result_Get_Alerts_By_Where_Count
public partial class Result_Get_Alerts_By_Where_Count : Action_Result
{
    #region Properties.
    public long? i_Result { get; set; }
    public Params_Get_Alerts_By_Where_Count Params_Get_Alerts_By_Where_Count { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_Incidents
public partial class Result_Get_Entity_Incidents : Action_Result
{
    #region Properties.
    public Entity_Incidents i_Result { get; set; }
    public Params_Get_Entity_Incidents Params_Get_Entity_Incidents { get; set; }
    #endregion
}
#endregion
#region Result_Get_Bylaw_Complaints_Trendline
public partial class Result_Get_Bylaw_Complaints_Trendline : Action_Result
{
    #region Properties.
    public List<Kpi_Value_By_Date> i_Result { get; set; }
    public Params_Get_Bylaw_Complaints_Trendline Params_Get_Bylaw_Complaints_Trendline { get; set; }
    #endregion
}
#endregion
#region Result_Get_Alerts_For_Levels
public partial class Result_Get_Alerts_For_Levels : Action_Result
{
    #region Properties.
    public List<Alert> i_Result { get; set; }
    public Params_Get_Alerts_For_Levels Params_Get_Alerts_For_Levels { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Space_Kpi_Data_Weekly
public partial class Result_Compute_Space_Kpi_Data_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_Space_Kpi_Data_Weekly Params_Compute_Space_Kpi_Data_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_Kpi_Data_By_Where
public partial class Result_Get_Area_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public List<Area_kpi_data> i_Result { get; set; }
    public Params_Get_Area_Kpi_Data_By_Where Params_Get_Area_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Site_Kpi_Data_Monthly
public partial class Result_Compute_Site_Kpi_Data_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_Site_Kpi_Data_Monthly Params_Compute_Site_Kpi_Data_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Compute_District_Kpi_Data_Hourly
public partial class Result_Compute_District_Kpi_Data_Hourly : Action_Result
{
    #region Properties.
    public Params_Compute_District_Kpi_Data_Hourly Params_Compute_District_Kpi_Data_Hourly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Intersection_Kpi_Dialog_Data
public partial class Result_Get_Intersection_Kpi_Dialog_Data : Action_Result
{
    #region Properties.
    public List<Entity_Kpi_Dialog_Data> i_Result { get; set; }
    public Params_Get_Intersection_Kpi_Dialog_Data Params_Get_Intersection_Kpi_Dialog_Data { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Floor_Kpi_Data_Daily
public partial class Result_Compute_Floor_Kpi_Data_Daily : Action_Result
{
    #region Properties.
    public Params_Compute_Floor_Kpi_Data_Daily Params_Compute_Floor_Kpi_Data_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Get_Strongest_Wifi_signal
public partial class Result_Get_Strongest_Wifi_signal : Action_Result
{
    #region Properties.
    public Best_And_Worst_Object i_Result { get; set; }
    public Params_Get_Strongest_Wifi_signal Params_Get_Strongest_Wifi_signal { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Area_Kpi_Data_Monthly
public partial class Result_Compute_Area_Kpi_Data_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_Area_Kpi_Data_Monthly Params_Compute_Area_Kpi_Data_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Business_List
public partial class Result_Get_Business_List : Action_Result
{
    #region Properties.
    public List<Business> i_Result { get; set; }
    public Params_Get_Business_List Params_Get_Business_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_Data_Access
public partial class Result_Edit_Organization_Data_Access : Action_Result
{
    #region Properties.
    public Params_Edit_Organization_Data_Access i_Result { get; set; }
    public Params_Edit_Organization_Data_Access Params_Edit_Organization_Data_Access { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Kpi
public partial class Result_Edit_Kpi : Action_Result
{
    #region Properties.
    public Kpi Kpi { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_Kpi_Dialog_Data
public partial class Result_Get_Entity_Kpi_Dialog_Data : Action_Result
{
    #region Properties.
    public List<Entity_Kpi_Dialog_Data> i_Result { get; set; }
    public Params_Get_Entity_Kpi_Dialog_Data Params_Get_Entity_Kpi_Dialog_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
public partial class Result_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID : Action_Result
{
    #region Properties.
    public List<Business> i_Result { get; set; }
    public Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID Params_Get_Businesses_Simple_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Site_Kpi_Data_Weekly
public partial class Result_Compute_Site_Kpi_Data_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_Site_Kpi_Data_Weekly Params_Compute_Site_Kpi_Data_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Most_Wifi_signal_Count_Per_Space_asset
public partial class Result_Get_Most_Wifi_signal_Count_Per_Space_asset : Action_Result
{
    #region Properties.
    public Best_And_Worst_Object i_Result { get; set; }
    public Params_Get_Most_Wifi_signal_Count_Per_Space_asset Params_Get_Most_Wifi_signal_Count_Per_Space_asset { get; set; }
    #endregion
}
#endregion
#region Result_Get_Public_Events_Trendline
public partial class Result_Get_Public_Events_Trendline : Action_Result
{
    #region Properties.
    public List<Kpi_Value_By_Date> i_Result { get; set; }
    public Params_Get_Public_Events_Trendline Params_Get_Public_Events_Trendline { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_User_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_ORGANIZATION_ID_List Params_Get_User_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_ORGANIZATION_ID_List
public partial class Result_Get_User_By_ORGANIZATION_ID_List : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_ORGANIZATION_ID_List Params_Get_User_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
