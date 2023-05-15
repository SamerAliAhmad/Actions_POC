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
public partial class DimensionManagementController : ControllerBase
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
    #region Get_Latest_Dimension_index_By_Where
    [HttpPost]
    [Route("Get_Latest_Dimension_index_By_Where")]
    public Result_Get_Latest_Dimension_index_By_Where Get_Latest_Dimension_index_By_Where(Params_Get_Latest_Dimension_index_By_Where i_Params_Get_Latest_Dimension_index_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Latest_Dimension_index_By_Where oResult_Get_Latest_Dimension_index_By_Where = new Result_Get_Latest_Dimension_index_By_Where();
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
                oResult_Get_Latest_Dimension_index_By_Where.i_Result = oBLC.Get_Latest_Dimension_index_By_Where(i_Params_Get_Latest_Dimension_index_By_Where);
                oResult_Get_Latest_Dimension_index_By_Where.Params_Get_Latest_Dimension_index_By_Where = i_Params_Get_Latest_Dimension_index_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Latest_Dimension_index_By_Where.Params_Get_Latest_Dimension_index_By_Where = i_Params_Get_Latest_Dimension_index_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Latest_Dimension_index_By_Where.Exception_Message = string.Format("Get_Latest_Dimension_index_By_Where : {0}", ex.Message);
                oResult_Get_Latest_Dimension_index_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Latest_Dimension_index_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Latest_Dimension_index_By_Where.Exception_Message = ex.Message;
                oResult_Get_Latest_Dimension_index_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Latest_Dimension_index_By_Where;
        #endregion
    }
    #endregion
    #region Get_Dimension_By_DIMENSION_ORDER_List
    [HttpGet]
    [Route("Get_Dimension_By_DIMENSION_ORDER_List")]
    public Result_Get_Dimension_By_DIMENSION_ORDER_List Get_Dimension_By_DIMENSION_ORDER_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_By_DIMENSION_ORDER_List oResult_Get_Dimension_By_DIMENSION_ORDER_List = new Result_Get_Dimension_By_DIMENSION_ORDER_List();
        Params_Get_Dimension_By_DIMENSION_ORDER_List oParams_Get_Dimension_By_DIMENSION_ORDER_List = new Params_Get_Dimension_By_DIMENSION_ORDER_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["DIMENSION_ORDER_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["DIMENSION_ORDER_LIST"].ToString() != "undefined" && HttpContext.Request.Query["DIMENSION_ORDER_LIST"].ToString() != "null" && HttpContext.Request.Query["DIMENSION_ORDER_LIST"].ToString() != "")
            {
                oParams_Get_Dimension_By_DIMENSION_ORDER_List.DIMENSION_ORDER_LIST = HttpContext.Request.Query["DIMENSION_ORDER_LIST"]
																						.ToString()
																						.Split(',')
																						.Where(val => int.TryParse(val, out _))
																						.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Dimension_By_DIMENSION_ORDER_List.i_Result = oBLC.Get_Dimension_By_DIMENSION_ORDER_List(oParams_Get_Dimension_By_DIMENSION_ORDER_List);
                oResult_Get_Dimension_By_DIMENSION_ORDER_List.Params_Get_Dimension_By_DIMENSION_ORDER_List = oParams_Get_Dimension_By_DIMENSION_ORDER_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Dimension_By_DIMENSION_ORDER_List.Params_Get_Dimension_By_DIMENSION_ORDER_List = oParams_Get_Dimension_By_DIMENSION_ORDER_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_By_DIMENSION_ORDER_List.Exception_Message = string.Format("Get_Dimension_By_DIMENSION_ORDER_List : {0}", ex.Message);
                oResult_Get_Dimension_By_DIMENSION_ORDER_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_By_DIMENSION_ORDER_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_By_DIMENSION_ORDER_List.Exception_Message = ex.Message;
                oResult_Get_Dimension_By_DIMENSION_ORDER_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_By_DIMENSION_ORDER_List;
        #endregion
    }
    #endregion
    #region Edit_Dimension_List
    [HttpPost]
    [Route("Edit_Dimension_List")]
    public Result_Edit_Dimension_List Edit_Dimension_List(Params_Edit_Dimension_List i_Params_Edit_Dimension_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Dimension_List oResult_Edit_Dimension_List = new Result_Edit_Dimension_List();
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
                oBLC.Edit_Dimension_List(i_Params_Edit_Dimension_List);
                oResult_Edit_Dimension_List.Params_Edit_Dimension_List = i_Params_Edit_Dimension_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Dimension_List.Exception_Message = string.Format("Edit_Dimension_List : {0}", ex.Message);
                oResult_Edit_Dimension_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Dimension_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Dimension_List.Exception_Message = ex.Message;
                oResult_Edit_Dimension_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Dimension_List;
        #endregion
    }
    #endregion
    #region Get_Dimension_By_DIMENSION_ID_List
    [HttpGet]
    [Route("Get_Dimension_By_DIMENSION_ID_List")]
    public Result_Get_Dimension_By_DIMENSION_ID_List Get_Dimension_By_DIMENSION_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_By_DIMENSION_ID_List oResult_Get_Dimension_By_DIMENSION_ID_List = new Result_Get_Dimension_By_DIMENSION_ID_List();
        Params_Get_Dimension_By_DIMENSION_ID_List oParams_Get_Dimension_By_DIMENSION_ID_List = new Params_Get_Dimension_By_DIMENSION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["DIMENSION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["DIMENSION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["DIMENSION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["DIMENSION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Dimension_By_DIMENSION_ID_List.DIMENSION_ID_LIST = HttpContext.Request.Query["DIMENSION_ID_LIST"]
																				.ToString()
																				.Split(',')
																				.Where(val => int.TryParse(val, out _))
																				.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Dimension_By_DIMENSION_ID_List.i_Result = oBLC.Get_Dimension_By_DIMENSION_ID_List(oParams_Get_Dimension_By_DIMENSION_ID_List);
                oResult_Get_Dimension_By_DIMENSION_ID_List.Params_Get_Dimension_By_DIMENSION_ID_List = oParams_Get_Dimension_By_DIMENSION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Dimension_By_DIMENSION_ID_List.Params_Get_Dimension_By_DIMENSION_ID_List = oParams_Get_Dimension_By_DIMENSION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_By_DIMENSION_ID_List.Exception_Message = string.Format("Get_Dimension_By_DIMENSION_ID_List : {0}", ex.Message);
                oResult_Get_Dimension_By_DIMENSION_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_By_DIMENSION_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_By_DIMENSION_ID_List.Exception_Message = ex.Message;
                oResult_Get_Dimension_By_DIMENSION_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_By_DIMENSION_ID_List;
        #endregion
    }
    #endregion
    #region Get_Dimension_By_DIMENSION_ID
    [HttpGet]
    [Route("Get_Dimension_By_DIMENSION_ID")]
    public Result_Get_Dimension_By_DIMENSION_ID Get_Dimension_By_DIMENSION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_By_DIMENSION_ID oResult_Get_Dimension_By_DIMENSION_ID = new Result_Get_Dimension_By_DIMENSION_ID();
        Params_Get_Dimension_By_DIMENSION_ID oParams_Get_Dimension_By_DIMENSION_ID = new Params_Get_Dimension_By_DIMENSION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["DIMENSION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["DIMENSION_ID"].ToString() != "undefined" && HttpContext.Request.Query["DIMENSION_ID"].ToString() != "null" && HttpContext.Request.Query["DIMENSION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Dimension_By_DIMENSION_ID.DIMENSION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["DIMENSION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Dimension_By_DIMENSION_ID.i_Result = oBLC.Get_Dimension_By_DIMENSION_ID(oParams_Get_Dimension_By_DIMENSION_ID);
                oResult_Get_Dimension_By_DIMENSION_ID.Params_Get_Dimension_By_DIMENSION_ID = oParams_Get_Dimension_By_DIMENSION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Dimension_By_DIMENSION_ID.Params_Get_Dimension_By_DIMENSION_ID = oParams_Get_Dimension_By_DIMENSION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_By_DIMENSION_ID.Exception_Message = string.Format("Get_Dimension_By_DIMENSION_ID : {0}", ex.Message);
                oResult_Get_Dimension_By_DIMENSION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_By_DIMENSION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_By_DIMENSION_ID.Exception_Message = ex.Message;
                oResult_Get_Dimension_By_DIMENSION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_By_DIMENSION_ID;
        #endregion
    }
    #endregion
    #region Compute_Dimension_Index_Monthly
    [HttpPost]
    [Route("Compute_Dimension_Index_Monthly")]
    public Result_Compute_Dimension_Index_Monthly Compute_Dimension_Index_Monthly(Params_Compute_Dimension_Index_Monthly i_Params_Compute_Dimension_Index_Monthly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Dimension_Index_Monthly oResult_Compute_Dimension_Index_Monthly = new Result_Compute_Dimension_Index_Monthly();
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
                oBLC.Compute_Dimension_Index_Monthly(i_Params_Compute_Dimension_Index_Monthly);
                oResult_Compute_Dimension_Index_Monthly.Params_Compute_Dimension_Index_Monthly = i_Params_Compute_Dimension_Index_Monthly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Dimension_Index_Monthly.Params_Compute_Dimension_Index_Monthly = i_Params_Compute_Dimension_Index_Monthly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Dimension_Index_Monthly.Exception_Message = string.Format("Compute_Dimension_Index_Monthly : {0}", ex.Message);
                oResult_Compute_Dimension_Index_Monthly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Dimension_Index_Monthly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Dimension_Index_Monthly.Exception_Message = ex.Message;
                oResult_Compute_Dimension_Index_Monthly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Dimension_Index_Monthly;
        #endregion
    }
    #endregion
    #region Insert_Dimension_index_List
    [HttpPost]
    [Route("Insert_Dimension_index_List")]
    public Result_Insert_Dimension_index_List Insert_Dimension_index_List(Params_Insert_Dimension_index_List i_Params_Insert_Dimension_index_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_Dimension_index_List oResult_Insert_Dimension_index_List = new Result_Insert_Dimension_index_List();
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
                oBLC.Insert_Dimension_index_List(i_Params_Insert_Dimension_index_List);
                oResult_Insert_Dimension_index_List.Params_Insert_Dimension_index_List = i_Params_Insert_Dimension_index_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_Dimension_index_List.Params_Insert_Dimension_index_List = i_Params_Insert_Dimension_index_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_Dimension_index_List.Exception_Message = string.Format("Insert_Dimension_index_List : {0}", ex.Message);
                oResult_Insert_Dimension_index_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_Dimension_index_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_Dimension_index_List.Exception_Message = ex.Message;
                oResult_Insert_Dimension_index_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_Dimension_index_List;
        #endregion
    }
    #endregion
    #region Compute_Dimension_Index_Weekly
    [HttpPost]
    [Route("Compute_Dimension_Index_Weekly")]
    public Result_Compute_Dimension_Index_Weekly Compute_Dimension_Index_Weekly(Params_Compute_Dimension_Index_Weekly i_Params_Compute_Dimension_Index_Weekly)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Compute_Dimension_Index_Weekly oResult_Compute_Dimension_Index_Weekly = new Result_Compute_Dimension_Index_Weekly();
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
                oBLC.Compute_Dimension_Index_Weekly(i_Params_Compute_Dimension_Index_Weekly);
                oResult_Compute_Dimension_Index_Weekly.Params_Compute_Dimension_Index_Weekly = i_Params_Compute_Dimension_Index_Weekly;
            }
        }
        catch (Exception ex)
        {
            oResult_Compute_Dimension_Index_Weekly.Params_Compute_Dimension_Index_Weekly = i_Params_Compute_Dimension_Index_Weekly;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Compute_Dimension_Index_Weekly.Exception_Message = string.Format("Compute_Dimension_Index_Weekly : {0}", ex.Message);
                oResult_Compute_Dimension_Index_Weekly.Stack_Trace = is_send_stack_trace ? string.Format("Compute_Dimension_Index_Weekly : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Compute_Dimension_Index_Weekly.Exception_Message = ex.Message;
                oResult_Compute_Dimension_Index_Weekly.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Compute_Dimension_Index_Weekly;
        #endregion
    }
    #endregion
    #region Get_Dimension_By_OWNER_ID
    [HttpGet]
    [Route("Get_Dimension_By_OWNER_ID")]
    public Result_Get_Dimension_By_OWNER_ID Get_Dimension_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_By_OWNER_ID oResult_Get_Dimension_By_OWNER_ID = new Result_Get_Dimension_By_OWNER_ID();
        Params_Get_Dimension_By_OWNER_ID oParams_Get_Dimension_By_OWNER_ID = new Params_Get_Dimension_By_OWNER_ID();
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
                oParams_Get_Dimension_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Dimension_By_OWNER_ID.i_Result = oBLC.Get_Dimension_By_OWNER_ID(oParams_Get_Dimension_By_OWNER_ID);
                oResult_Get_Dimension_By_OWNER_ID.Params_Get_Dimension_By_OWNER_ID = oParams_Get_Dimension_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Dimension_By_OWNER_ID.Params_Get_Dimension_By_OWNER_ID = oParams_Get_Dimension_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_By_OWNER_ID.Exception_Message = string.Format("Get_Dimension_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Dimension_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Dimension_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Dimension_index_By_Where
    [HttpPost]
    [Route("Get_Dimension_index_By_Where")]
    public Result_Get_Dimension_index_By_Where Get_Dimension_index_By_Where(Params_Get_Dimension_index_By_Where i_Params_Get_Dimension_index_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_index_By_Where oResult_Get_Dimension_index_By_Where = new Result_Get_Dimension_index_By_Where();
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
                oResult_Get_Dimension_index_By_Where.i_Result = oBLC.Get_Dimension_index_By_Where(i_Params_Get_Dimension_index_By_Where);
                oResult_Get_Dimension_index_By_Where.Params_Get_Dimension_index_By_Where = i_Params_Get_Dimension_index_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Dimension_index_By_Where.Params_Get_Dimension_index_By_Where = i_Params_Get_Dimension_index_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_index_By_Where.Exception_Message = string.Format("Get_Dimension_index_By_Where : {0}", ex.Message);
                oResult_Get_Dimension_index_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_index_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_index_By_Where.Exception_Message = ex.Message;
                oResult_Get_Dimension_index_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_index_By_Where;
        #endregion
    }
    #endregion
    #region Generate_Dimension_Index_Daily
    [HttpPost]
    [Route("Generate_Dimension_Index_Daily")]
    public Result_Generate_Dimension_Index_Daily Generate_Dimension_Index_Daily(Params_Generate_Dimension_Index_Daily i_Params_Generate_Dimension_Index_Daily)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Dimension_Index_Daily oResult_Generate_Dimension_Index_Daily = new Result_Generate_Dimension_Index_Daily();
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
                oBLC.Generate_Dimension_Index_Daily(i_Params_Generate_Dimension_Index_Daily);
                oResult_Generate_Dimension_Index_Daily.Params_Generate_Dimension_Index_Daily = i_Params_Generate_Dimension_Index_Daily;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Dimension_Index_Daily.Params_Generate_Dimension_Index_Daily = i_Params_Generate_Dimension_Index_Daily;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Dimension_Index_Daily.Exception_Message = string.Format("Generate_Dimension_Index_Daily : {0}", ex.Message);
                oResult_Generate_Dimension_Index_Daily.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Dimension_Index_Daily : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Dimension_Index_Daily.Exception_Message = ex.Message;
                oResult_Generate_Dimension_Index_Daily.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Dimension_Index_Daily;
        #endregion
    }
    #endregion
    #region Delete_Dimension_index_By_Where
    [HttpPost]
    [Route("Delete_Dimension_index_By_Where")]
    public Result_Delete_Dimension_index_By_Where Delete_Dimension_index_By_Where(Params_Delete_Dimension_index_By_Where i_Params_Delete_Dimension_index_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Dimension_index_By_Where oResult_Delete_Dimension_index_By_Where = new Result_Delete_Dimension_index_By_Where();
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
                oBLC.Delete_Dimension_index_By_Where(i_Params_Delete_Dimension_index_By_Where);
                oResult_Delete_Dimension_index_By_Where.Params_Delete_Dimension_index_By_Where = i_Params_Delete_Dimension_index_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Dimension_index_By_Where.Params_Delete_Dimension_index_By_Where = i_Params_Delete_Dimension_index_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Dimension_index_By_Where.Exception_Message = string.Format("Delete_Dimension_index_By_Where : {0}", ex.Message);
                oResult_Delete_Dimension_index_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Dimension_index_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Dimension_index_By_Where.Exception_Message = ex.Message;
                oResult_Delete_Dimension_index_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Dimension_index_By_Where;
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
#region Result_Get_Latest_Dimension_index_By_Where
public partial class Result_Get_Latest_Dimension_index_By_Where : Action_Result
{
    #region Properties.
    public List<Dimension_index_By_Level> i_Result { get; set; }
    public Params_Get_Latest_Dimension_index_By_Where Params_Get_Latest_Dimension_index_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_By_DIMENSION_ORDER_List
public partial class Result_Get_Dimension_By_DIMENSION_ORDER_List : Action_Result
{
    #region Properties.
    public List<Dimension> i_Result { get; set; }
    public Params_Get_Dimension_By_DIMENSION_ORDER_List Params_Get_Dimension_By_DIMENSION_ORDER_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Dimension_List
public partial class Result_Edit_Dimension_List : Action_Result
{
    #region Properties.
    public Params_Edit_Dimension_List Params_Edit_Dimension_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_By_DIMENSION_ID_List
public partial class Result_Get_Dimension_By_DIMENSION_ID_List : Action_Result
{
    #region Properties.
    public List<Dimension> i_Result { get; set; }
    public Params_Get_Dimension_By_DIMENSION_ID_List Params_Get_Dimension_By_DIMENSION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_By_DIMENSION_ID
public partial class Result_Get_Dimension_By_DIMENSION_ID : Action_Result
{
    #region Properties.
    public Dimension i_Result { get; set; }
    public Params_Get_Dimension_By_DIMENSION_ID Params_Get_Dimension_By_DIMENSION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Dimension_Index_Monthly
public partial class Result_Compute_Dimension_Index_Monthly : Action_Result
{
    #region Properties.
    public Params_Compute_Dimension_Index_Monthly Params_Compute_Dimension_Index_Monthly { get; set; }
    #endregion
}
#endregion
#region Result_Insert_Dimension_index_List
public partial class Result_Insert_Dimension_index_List : Action_Result
{
    #region Properties.
    public Params_Insert_Dimension_index_List Params_Insert_Dimension_index_List { get; set; }
    #endregion
}
#endregion
#region Result_Compute_Dimension_Index_Weekly
public partial class Result_Compute_Dimension_Index_Weekly : Action_Result
{
    #region Properties.
    public Params_Compute_Dimension_Index_Weekly Params_Compute_Dimension_Index_Weekly { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_By_OWNER_ID
public partial class Result_Get_Dimension_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Dimension> i_Result { get; set; }
    public Params_Get_Dimension_By_OWNER_ID Params_Get_Dimension_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_index_By_Where
public partial class Result_Get_Dimension_index_By_Where : Action_Result
{
    #region Properties.
    public List<Dimension_index> i_Result { get; set; }
    public Params_Get_Dimension_index_By_Where Params_Get_Dimension_index_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Dimension_Index_Daily
public partial class Result_Generate_Dimension_Index_Daily : Action_Result
{
    #region Properties.
    public Params_Generate_Dimension_Index_Daily Params_Generate_Dimension_Index_Daily { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Dimension_index_By_Where
public partial class Result_Delete_Dimension_index_By_Where : Action_Result
{
    #region Properties.
    public Params_Delete_Dimension_index_By_Where Params_Delete_Dimension_index_By_Where { get; set; }
    #endregion
}
#endregion
