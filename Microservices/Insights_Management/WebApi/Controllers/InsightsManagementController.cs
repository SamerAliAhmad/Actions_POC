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
public partial class InsightsManagementController : ControllerBase
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
    #region Edit_Correlation_method
    [HttpPost]
    [Route("Edit_Correlation_method")]
    public Result_Edit_Correlation_method Edit_Correlation_method(Correlation_method i_Correlation_method)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Correlation_method oResult_Edit_Correlation_method = new Result_Edit_Correlation_method();
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
                oBLC.Edit_Correlation_method(i_Correlation_method);
                oResult_Edit_Correlation_method.Correlation_method = i_Correlation_method;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Correlation_method.Exception_Message = string.Format("Edit_Correlation_method : {0}", ex.Message);
                oResult_Edit_Correlation_method.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Correlation_method : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Correlation_method.Exception_Message = ex.Message;
                oResult_Edit_Correlation_method.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Correlation_method;
        #endregion
    }
    #endregion
    #region Get_Correlation_method_By_OWNER_ID
    [HttpGet]
    [Route("Get_Correlation_method_By_OWNER_ID")]
    public Result_Get_Correlation_method_By_OWNER_ID Get_Correlation_method_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Correlation_method_By_OWNER_ID oResult_Get_Correlation_method_By_OWNER_ID = new Result_Get_Correlation_method_By_OWNER_ID();
        Params_Get_Correlation_method_By_OWNER_ID oParams_Get_Correlation_method_By_OWNER_ID = new Params_Get_Correlation_method_By_OWNER_ID();
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
                oParams_Get_Correlation_method_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Correlation_method_By_OWNER_ID.i_Result = oBLC.Get_Correlation_method_By_OWNER_ID(oParams_Get_Correlation_method_By_OWNER_ID);
                oResult_Get_Correlation_method_By_OWNER_ID.Params_Get_Correlation_method_By_OWNER_ID = oParams_Get_Correlation_method_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Correlation_method_By_OWNER_ID.Params_Get_Correlation_method_By_OWNER_ID = oParams_Get_Correlation_method_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Correlation_method_By_OWNER_ID.Exception_Message = string.Format("Get_Correlation_method_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Correlation_method_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Correlation_method_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Correlation_method_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Correlation_method_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Correlation_method_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Delete_Correlation_method
    [HttpPost]
    [Route("Delete_Correlation_method")]
    public Result_Delete_Correlation_method Delete_Correlation_method(Params_Delete_Correlation_method i_Params_Delete_Correlation_method)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Correlation_method oResult_Delete_Correlation_method = new Result_Delete_Correlation_method();
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
                oBLC.Delete_Correlation_method(i_Params_Delete_Correlation_method);
                oResult_Delete_Correlation_method.Params_Delete_Correlation_method = i_Params_Delete_Correlation_method;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Correlation_method.Params_Delete_Correlation_method = i_Params_Delete_Correlation_method;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Correlation_method.Exception_Message = string.Format("Delete_Correlation_method : {0}", ex.Message);
                oResult_Delete_Correlation_method.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Correlation_method : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Correlation_method.Exception_Message = ex.Message;
                oResult_Delete_Correlation_method.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Correlation_method;
        #endregion
    }
    #endregion
    #region Get_Correlation
    [HttpPost]
    [Route("Get_Correlation")]
    public Result_Get_Correlation Get_Correlation(Params_Get_Correlation i_Params_Get_Correlation)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Correlation oResult_Get_Correlation = new Result_Get_Correlation();
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
                oResult_Get_Correlation.i_Result = oBLC.Get_Correlation(i_Params_Get_Correlation);
                oResult_Get_Correlation.Params_Get_Correlation = i_Params_Get_Correlation;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Correlation.Params_Get_Correlation = i_Params_Get_Correlation;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Correlation.Exception_Message = string.Format("Get_Correlation : {0}", ex.Message);
                oResult_Get_Correlation.Stack_Trace = is_send_stack_trace ? string.Format("Get_Correlation : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Correlation.Exception_Message = ex.Message;
                oResult_Get_Correlation.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Correlation;
        #endregion
    }
    #endregion
    #region Get_Comparison_Data
    [HttpPost]
    [Route("Get_Comparison_Data")]
    public Result_Get_Comparison_Data Get_Comparison_Data(Params_Get_Comparison_Data i_Params_Get_Comparison_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Comparison_Data oResult_Get_Comparison_Data = new Result_Get_Comparison_Data();
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
                oResult_Get_Comparison_Data.i_Result = oBLC.Get_Comparison_Data(i_Params_Get_Comparison_Data);
                oResult_Get_Comparison_Data.Params_Get_Comparison_Data = i_Params_Get_Comparison_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Comparison_Data.Params_Get_Comparison_Data = i_Params_Get_Comparison_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Comparison_Data.Exception_Message = string.Format("Get_Comparison_Data : {0}", ex.Message);
                oResult_Get_Comparison_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Comparison_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Comparison_Data.Exception_Message = ex.Message;
                oResult_Get_Comparison_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Comparison_Data;
        #endregion
    }
    #endregion
    #region Get_Multi_kpi_comparison
    [HttpPost]
    [Route("Get_Multi_kpi_comparison")]
    public Result_Get_Multi_kpi_comparison Get_Multi_kpi_comparison(Params_Get_Multi_kpi_comparison i_Params_Get_Multi_kpi_comparison)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Multi_kpi_comparison oResult_Get_Multi_kpi_comparison = new Result_Get_Multi_kpi_comparison();
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
                oResult_Get_Multi_kpi_comparison.i_Result = oBLC.Get_Multi_kpi_comparison(i_Params_Get_Multi_kpi_comparison);
                oResult_Get_Multi_kpi_comparison.Params_Get_Multi_kpi_comparison = i_Params_Get_Multi_kpi_comparison;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Multi_kpi_comparison.Params_Get_Multi_kpi_comparison = i_Params_Get_Multi_kpi_comparison;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Multi_kpi_comparison.Exception_Message = string.Format("Get_Multi_kpi_comparison : {0}", ex.Message);
                oResult_Get_Multi_kpi_comparison.Stack_Trace = is_send_stack_trace ? string.Format("Get_Multi_kpi_comparison : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Multi_kpi_comparison.Exception_Message = ex.Message;
                oResult_Get_Multi_kpi_comparison.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Multi_kpi_comparison;
        #endregion
    }
    #endregion
    #region Get_Single_kpi_comparison
    [HttpPost]
    [Route("Get_Single_kpi_comparison")]
    public Result_Get_Single_kpi_comparison Get_Single_kpi_comparison(Params_Get_Single_kpi_comparison i_Params_Get_Single_kpi_comparison)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Single_kpi_comparison oResult_Get_Single_kpi_comparison = new Result_Get_Single_kpi_comparison();
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
                oResult_Get_Single_kpi_comparison.i_Result = oBLC.Get_Single_kpi_comparison(i_Params_Get_Single_kpi_comparison);
                oResult_Get_Single_kpi_comparison.Params_Get_Single_kpi_comparison = i_Params_Get_Single_kpi_comparison;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Single_kpi_comparison.Params_Get_Single_kpi_comparison = i_Params_Get_Single_kpi_comparison;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Single_kpi_comparison.Exception_Message = string.Format("Get_Single_kpi_comparison : {0}", ex.Message);
                oResult_Get_Single_kpi_comparison.Stack_Trace = is_send_stack_trace ? string.Format("Get_Single_kpi_comparison : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Single_kpi_comparison.Exception_Message = ex.Message;
                oResult_Get_Single_kpi_comparison.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Single_kpi_comparison;
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
#region Result_Edit_Correlation_method
public partial class Result_Edit_Correlation_method : Action_Result
{
    #region Properties.
    public Correlation_method Correlation_method { get; set; }
    #endregion
}
#endregion
#region Result_Get_Correlation_method_By_OWNER_ID
public partial class Result_Get_Correlation_method_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Correlation_method> i_Result { get; set; }
    public Params_Get_Correlation_method_By_OWNER_ID Params_Get_Correlation_method_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Correlation_method
public partial class Result_Delete_Correlation_method : Action_Result
{
    #region Properties.
    public Params_Delete_Correlation_method Params_Delete_Correlation_method { get; set; }
    #endregion
}
#endregion
#region Result_Get_Correlation
public partial class Result_Get_Correlation : Action_Result
{
    #region Properties.
    public List<Kpi_Value_By_Date> i_Result { get; set; }
    public Params_Get_Correlation Params_Get_Correlation { get; set; }
    #endregion
}
#endregion
#region Result_Get_Comparison_Data
public partial class Result_Get_Comparison_Data : Action_Result
{
    #region Properties.
    public Comparison_Data i_Result { get; set; }
    public Params_Get_Comparison_Data Params_Get_Comparison_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Multi_kpi_comparison
public partial class Result_Get_Multi_kpi_comparison : Action_Result
{
    #region Properties.
    public List<Kpi_Value_By_Direction> i_Result { get; set; }
    public Params_Get_Multi_kpi_comparison Params_Get_Multi_kpi_comparison { get; set; }
    #endregion
}
#endregion
#region Result_Get_Single_kpi_comparison
public partial class Result_Get_Single_kpi_comparison : Action_Result
{
    #region Properties.
    public List<Kpi_Value_By_Date> i_Result { get; set; }
    public Params_Get_Single_kpi_comparison Params_Get_Single_kpi_comparison { get; set; }
    #endregion
}
#endregion
