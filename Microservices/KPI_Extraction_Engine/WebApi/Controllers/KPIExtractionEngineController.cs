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
public partial class KPIExtractionEngineController : ControllerBase
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
    #region Get_Visitor_Activity_Data
    [HttpPost]
    [Route("Get_Visitor_Activity_Data")]
    public Result_Get_Visitor_Activity_Data Get_Visitor_Activity_Data(Params_Get_Visitor_Activity_Data i_Params_Get_Visitor_Activity_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Visitor_Activity_Data oResult_Get_Visitor_Activity_Data = new Result_Get_Visitor_Activity_Data();
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
                oResult_Get_Visitor_Activity_Data.i_Result = oBLC.Get_Visitor_Activity_Data(i_Params_Get_Visitor_Activity_Data);
                oResult_Get_Visitor_Activity_Data.Params_Get_Visitor_Activity_Data = i_Params_Get_Visitor_Activity_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Visitor_Activity_Data.Params_Get_Visitor_Activity_Data = i_Params_Get_Visitor_Activity_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Visitor_Activity_Data.Exception_Message = string.Format("Get_Visitor_Activity_Data : {0}", ex.Message);
                oResult_Get_Visitor_Activity_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Visitor_Activity_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Visitor_Activity_Data.Exception_Message = ex.Message;
                oResult_Get_Visitor_Activity_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Visitor_Activity_Data;
        #endregion
    }
    #endregion
    #region Get_Demographic_Data
    [HttpPost]
    [Route("Get_Demographic_Data")]
    public Result_Get_Demographic_Data Get_Demographic_Data(Params_Get_Demographic_Data i_Params_Get_Demographic_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Demographic_Data oResult_Get_Demographic_Data = new Result_Get_Demographic_Data();
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
                oResult_Get_Demographic_Data.i_Result = oBLC.Get_Demographic_Data(i_Params_Get_Demographic_Data);
                oResult_Get_Demographic_Data.Params_Get_Demographic_Data = i_Params_Get_Demographic_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Demographic_Data.Params_Get_Demographic_Data = i_Params_Get_Demographic_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Demographic_Data.Exception_Message = string.Format("Get_Demographic_Data : {0}", ex.Message);
                oResult_Get_Demographic_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Demographic_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Demographic_Data.Exception_Message = ex.Message;
                oResult_Get_Demographic_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Demographic_Data;
        #endregion
    }
    #endregion
    #region Get_Visitor_Data
    [HttpPost]
    [Route("Get_Visitor_Data")]
    public Result_Get_Visitor_Data Get_Visitor_Data(Params_Get_Visitor_Data i_Params_Get_Visitor_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Visitor_Data oResult_Get_Visitor_Data = new Result_Get_Visitor_Data();
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
                oResult_Get_Visitor_Data.i_Result = oBLC.Get_Visitor_Data(i_Params_Get_Visitor_Data);
                oResult_Get_Visitor_Data.Params_Get_Visitor_Data = i_Params_Get_Visitor_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Visitor_Data.Params_Get_Visitor_Data = i_Params_Get_Visitor_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Visitor_Data.Exception_Message = string.Format("Get_Visitor_Data : {0}", ex.Message);
                oResult_Get_Visitor_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Visitor_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Visitor_Data.Exception_Message = ex.Message;
                oResult_Get_Visitor_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Visitor_Data;
        #endregion
    }
    #endregion
    #region Get_Jobs_By_Where
    [HttpPost]
    [Route("Get_Jobs_By_Where")]
    public Result_Get_Jobs_By_Where Get_Jobs_By_Where(Params_Get_Jobs_By_Where i_Params_Get_Jobs_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Jobs_By_Where oResult_Get_Jobs_By_Where = new Result_Get_Jobs_By_Where();
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
                oResult_Get_Jobs_By_Where.i_Result = oBLC.Get_Jobs_By_Where(i_Params_Get_Jobs_By_Where);
                oResult_Get_Jobs_By_Where.Params_Get_Jobs_By_Where = i_Params_Get_Jobs_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Jobs_By_Where.Params_Get_Jobs_By_Where = i_Params_Get_Jobs_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Jobs_By_Where.Exception_Message = string.Format("Get_Jobs_By_Where : {0}", ex.Message);
                oResult_Get_Jobs_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Jobs_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Jobs_By_Where.Exception_Message = ex.Message;
                oResult_Get_Jobs_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Jobs_By_Where;
        #endregion
    }
    #endregion
    #region Edit_Job_List
    [HttpPost]
    [Route("Edit_Job_List")]
    public Result_Edit_Job_List Edit_Job_List(Params_Edit_Job_List i_Params_Edit_Job_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Job_List oResult_Edit_Job_List = new Result_Edit_Job_List();
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
                oBLC.Edit_Job_List(i_Params_Edit_Job_List);
                oResult_Edit_Job_List.Params_Edit_Job_List = i_Params_Edit_Job_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Job_List.Params_Edit_Job_List = i_Params_Edit_Job_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Job_List.Exception_Message = string.Format("Edit_Job_List : {0}", ex.Message);
                oResult_Edit_Job_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Job_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Job_List.Exception_Message = ex.Message;
                oResult_Edit_Job_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Job_List;
        #endregion
    }
    #endregion
    #region Delete_Job
    [HttpPost]
    [Route("Delete_Job")]
    public Result_Delete_Job Delete_Job(Params_Delete_Job i_Params_Delete_Job)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Job oResult_Delete_Job = new Result_Delete_Job();
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
                oBLC.Delete_Job(i_Params_Delete_Job);
                oResult_Delete_Job.Params_Delete_Job = i_Params_Delete_Job;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Job.Params_Delete_Job = i_Params_Delete_Job;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Job.Exception_Message = string.Format("Delete_Job : {0}", ex.Message);
                oResult_Delete_Job.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Job : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Job.Exception_Message = ex.Message;
                oResult_Delete_Job.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Job;
        #endregion
    }
    #endregion
    #region Generate_Or_Compute_District_Hourly_Data
    [HttpPost]
    [Route("Generate_Or_Compute_District_Hourly_Data")]
    public Result_Generate_Or_Compute_District_Hourly_Data Generate_Or_Compute_District_Hourly_Data(Params_Generate_Or_Compute_District_Hourly_Data i_Params_Generate_Or_Compute_District_Hourly_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Or_Compute_District_Hourly_Data oResult_Generate_Or_Compute_District_Hourly_Data = new Result_Generate_Or_Compute_District_Hourly_Data();
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
                oBLC.Generate_Or_Compute_District_Hourly_Data(i_Params_Generate_Or_Compute_District_Hourly_Data);
                oResult_Generate_Or_Compute_District_Hourly_Data.Params_Generate_Or_Compute_District_Hourly_Data = i_Params_Generate_Or_Compute_District_Hourly_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Or_Compute_District_Hourly_Data.Params_Generate_Or_Compute_District_Hourly_Data = i_Params_Generate_Or_Compute_District_Hourly_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Or_Compute_District_Hourly_Data.Exception_Message = string.Format("Generate_Or_Compute_District_Hourly_Data : {0}", ex.Message);
                oResult_Generate_Or_Compute_District_Hourly_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Or_Compute_District_Hourly_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Or_Compute_District_Hourly_Data.Exception_Message = ex.Message;
                oResult_Generate_Or_Compute_District_Hourly_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Or_Compute_District_Hourly_Data;
        #endregion
    }
    #endregion
    #region Generate_District_Hourly_Indexes
    [HttpPost]
    [Route("Generate_District_Hourly_Indexes")]
    public Result_Generate_District_Hourly_Indexes Generate_District_Hourly_Indexes(Params_Generate_District_Hourly_Indexes i_Params_Generate_District_Hourly_Indexes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_District_Hourly_Indexes oResult_Generate_District_Hourly_Indexes = new Result_Generate_District_Hourly_Indexes();
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
                oBLC.Generate_District_Hourly_Indexes(i_Params_Generate_District_Hourly_Indexes);
                oResult_Generate_District_Hourly_Indexes.Params_Generate_District_Hourly_Indexes = i_Params_Generate_District_Hourly_Indexes;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_District_Hourly_Indexes.Params_Generate_District_Hourly_Indexes = i_Params_Generate_District_Hourly_Indexes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_District_Hourly_Indexes.Exception_Message = string.Format("Generate_District_Hourly_Indexes : {0}", ex.Message);
                oResult_Generate_District_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? string.Format("Generate_District_Hourly_Indexes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_District_Hourly_Indexes.Exception_Message = ex.Message;
                oResult_Generate_District_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_District_Hourly_Indexes;
        #endregion
    }
    #endregion
    #region Generate_Or_Compute_Area_Hourly_Data
    [HttpPost]
    [Route("Generate_Or_Compute_Area_Hourly_Data")]
    public Result_Generate_Or_Compute_Area_Hourly_Data Generate_Or_Compute_Area_Hourly_Data(Params_Generate_Or_Compute_Area_Hourly_Data i_Params_Generate_Or_Compute_Area_Hourly_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Or_Compute_Area_Hourly_Data oResult_Generate_Or_Compute_Area_Hourly_Data = new Result_Generate_Or_Compute_Area_Hourly_Data();
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
                oBLC.Generate_Or_Compute_Area_Hourly_Data(i_Params_Generate_Or_Compute_Area_Hourly_Data);
                oResult_Generate_Or_Compute_Area_Hourly_Data.Params_Generate_Or_Compute_Area_Hourly_Data = i_Params_Generate_Or_Compute_Area_Hourly_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Or_Compute_Area_Hourly_Data.Params_Generate_Or_Compute_Area_Hourly_Data = i_Params_Generate_Or_Compute_Area_Hourly_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Or_Compute_Area_Hourly_Data.Exception_Message = string.Format("Generate_Or_Compute_Area_Hourly_Data : {0}", ex.Message);
                oResult_Generate_Or_Compute_Area_Hourly_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Or_Compute_Area_Hourly_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Or_Compute_Area_Hourly_Data.Exception_Message = ex.Message;
                oResult_Generate_Or_Compute_Area_Hourly_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Or_Compute_Area_Hourly_Data;
        #endregion
    }
    #endregion
    #region Generate_Area_Hourly_Indexes
    [HttpPost]
    [Route("Generate_Area_Hourly_Indexes")]
    public Result_Generate_Area_Hourly_Indexes Generate_Area_Hourly_Indexes(Params_Generate_Area_Hourly_Indexes i_Params_Generate_Area_Hourly_Indexes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Area_Hourly_Indexes oResult_Generate_Area_Hourly_Indexes = new Result_Generate_Area_Hourly_Indexes();
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
                oBLC.Generate_Area_Hourly_Indexes(i_Params_Generate_Area_Hourly_Indexes);
                oResult_Generate_Area_Hourly_Indexes.Params_Generate_Area_Hourly_Indexes = i_Params_Generate_Area_Hourly_Indexes;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Area_Hourly_Indexes.Params_Generate_Area_Hourly_Indexes = i_Params_Generate_Area_Hourly_Indexes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Area_Hourly_Indexes.Exception_Message = string.Format("Generate_Area_Hourly_Indexes : {0}", ex.Message);
                oResult_Generate_Area_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Area_Hourly_Indexes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Area_Hourly_Indexes.Exception_Message = ex.Message;
                oResult_Generate_Area_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Area_Hourly_Indexes;
        #endregion
    }
    #endregion
    #region Generate_Space_Hourly_Indexes
    [HttpPost]
    [Route("Generate_Space_Hourly_Indexes")]
    public Result_Generate_Space_Hourly_Indexes Generate_Space_Hourly_Indexes(Params_Generate_Space_Hourly_Indexes i_Params_Generate_Space_Hourly_Indexes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Space_Hourly_Indexes oResult_Generate_Space_Hourly_Indexes = new Result_Generate_Space_Hourly_Indexes();
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
                oBLC.Generate_Space_Hourly_Indexes(i_Params_Generate_Space_Hourly_Indexes);
                oResult_Generate_Space_Hourly_Indexes.Params_Generate_Space_Hourly_Indexes = i_Params_Generate_Space_Hourly_Indexes;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Space_Hourly_Indexes.Params_Generate_Space_Hourly_Indexes = i_Params_Generate_Space_Hourly_Indexes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Space_Hourly_Indexes.Exception_Message = string.Format("Generate_Space_Hourly_Indexes : {0}", ex.Message);
                oResult_Generate_Space_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Space_Hourly_Indexes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Space_Hourly_Indexes.Exception_Message = ex.Message;
                oResult_Generate_Space_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Space_Hourly_Indexes;
        #endregion
    }
    #endregion
    #region Generate_Or_Compute_Floor_Hourly_Data
    [HttpPost]
    [Route("Generate_Or_Compute_Floor_Hourly_Data")]
    public Result_Generate_Or_Compute_Floor_Hourly_Data Generate_Or_Compute_Floor_Hourly_Data(Params_Generate_Or_Compute_Floor_Hourly_Data i_Params_Generate_Or_Compute_Floor_Hourly_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Or_Compute_Floor_Hourly_Data oResult_Generate_Or_Compute_Floor_Hourly_Data = new Result_Generate_Or_Compute_Floor_Hourly_Data();
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
                oBLC.Generate_Or_Compute_Floor_Hourly_Data(i_Params_Generate_Or_Compute_Floor_Hourly_Data);
                oResult_Generate_Or_Compute_Floor_Hourly_Data.Params_Generate_Or_Compute_Floor_Hourly_Data = i_Params_Generate_Or_Compute_Floor_Hourly_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Or_Compute_Floor_Hourly_Data.Params_Generate_Or_Compute_Floor_Hourly_Data = i_Params_Generate_Or_Compute_Floor_Hourly_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Or_Compute_Floor_Hourly_Data.Exception_Message = string.Format("Generate_Or_Compute_Floor_Hourly_Data : {0}", ex.Message);
                oResult_Generate_Or_Compute_Floor_Hourly_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Or_Compute_Floor_Hourly_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Or_Compute_Floor_Hourly_Data.Exception_Message = ex.Message;
                oResult_Generate_Or_Compute_Floor_Hourly_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Or_Compute_Floor_Hourly_Data;
        #endregion
    }
    #endregion
    #region Generate_Floor_Hourly_Indexes
    [HttpPost]
    [Route("Generate_Floor_Hourly_Indexes")]
    public Result_Generate_Floor_Hourly_Indexes Generate_Floor_Hourly_Indexes(Params_Generate_Floor_Hourly_Indexes i_Params_Generate_Floor_Hourly_Indexes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Floor_Hourly_Indexes oResult_Generate_Floor_Hourly_Indexes = new Result_Generate_Floor_Hourly_Indexes();
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
                oBLC.Generate_Floor_Hourly_Indexes(i_Params_Generate_Floor_Hourly_Indexes);
                oResult_Generate_Floor_Hourly_Indexes.Params_Generate_Floor_Hourly_Indexes = i_Params_Generate_Floor_Hourly_Indexes;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Floor_Hourly_Indexes.Params_Generate_Floor_Hourly_Indexes = i_Params_Generate_Floor_Hourly_Indexes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Floor_Hourly_Indexes.Exception_Message = string.Format("Generate_Floor_Hourly_Indexes : {0}", ex.Message);
                oResult_Generate_Floor_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Floor_Hourly_Indexes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Floor_Hourly_Indexes.Exception_Message = ex.Message;
                oResult_Generate_Floor_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Floor_Hourly_Indexes;
        #endregion
    }
    #endregion
    #region Generate_Or_Compute_Entity_Hourly_Data
    [HttpPost]
    [Route("Generate_Or_Compute_Entity_Hourly_Data")]
    public Result_Generate_Or_Compute_Entity_Hourly_Data Generate_Or_Compute_Entity_Hourly_Data(Params_Generate_Or_Compute_Entity_Hourly_Data i_Params_Generate_Or_Compute_Entity_Hourly_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Or_Compute_Entity_Hourly_Data oResult_Generate_Or_Compute_Entity_Hourly_Data = new Result_Generate_Or_Compute_Entity_Hourly_Data();
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
                oBLC.Generate_Or_Compute_Entity_Hourly_Data(i_Params_Generate_Or_Compute_Entity_Hourly_Data);
                oResult_Generate_Or_Compute_Entity_Hourly_Data.Params_Generate_Or_Compute_Entity_Hourly_Data = i_Params_Generate_Or_Compute_Entity_Hourly_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Or_Compute_Entity_Hourly_Data.Params_Generate_Or_Compute_Entity_Hourly_Data = i_Params_Generate_Or_Compute_Entity_Hourly_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Or_Compute_Entity_Hourly_Data.Exception_Message = string.Format("Generate_Or_Compute_Entity_Hourly_Data : {0}", ex.Message);
                oResult_Generate_Or_Compute_Entity_Hourly_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Or_Compute_Entity_Hourly_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Or_Compute_Entity_Hourly_Data.Exception_Message = ex.Message;
                oResult_Generate_Or_Compute_Entity_Hourly_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Or_Compute_Entity_Hourly_Data;
        #endregion
    }
    #endregion
    #region Generate_Entity_Hourly_Indexes
    [HttpPost]
    [Route("Generate_Entity_Hourly_Indexes")]
    public Result_Generate_Entity_Hourly_Indexes Generate_Entity_Hourly_Indexes(Params_Generate_Entity_Hourly_Indexes i_Params_Generate_Entity_Hourly_Indexes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Entity_Hourly_Indexes oResult_Generate_Entity_Hourly_Indexes = new Result_Generate_Entity_Hourly_Indexes();
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
                oBLC.Generate_Entity_Hourly_Indexes(i_Params_Generate_Entity_Hourly_Indexes);
                oResult_Generate_Entity_Hourly_Indexes.Params_Generate_Entity_Hourly_Indexes = i_Params_Generate_Entity_Hourly_Indexes;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Entity_Hourly_Indexes.Params_Generate_Entity_Hourly_Indexes = i_Params_Generate_Entity_Hourly_Indexes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Entity_Hourly_Indexes.Exception_Message = string.Format("Generate_Entity_Hourly_Indexes : {0}", ex.Message);
                oResult_Generate_Entity_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Entity_Hourly_Indexes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Entity_Hourly_Indexes.Exception_Message = ex.Message;
                oResult_Generate_Entity_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Entity_Hourly_Indexes;
        #endregion
    }
    #endregion
    #region Generate_Or_Compute_Site_Hourly_Data
    [HttpPost]
    [Route("Generate_Or_Compute_Site_Hourly_Data")]
    public Result_Generate_Or_Compute_Site_Hourly_Data Generate_Or_Compute_Site_Hourly_Data(Params_Generate_Or_Compute_Site_Hourly_Data i_Params_Generate_Or_Compute_Site_Hourly_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Or_Compute_Site_Hourly_Data oResult_Generate_Or_Compute_Site_Hourly_Data = new Result_Generate_Or_Compute_Site_Hourly_Data();
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
                oBLC.Generate_Or_Compute_Site_Hourly_Data(i_Params_Generate_Or_Compute_Site_Hourly_Data);
                oResult_Generate_Or_Compute_Site_Hourly_Data.Params_Generate_Or_Compute_Site_Hourly_Data = i_Params_Generate_Or_Compute_Site_Hourly_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Or_Compute_Site_Hourly_Data.Params_Generate_Or_Compute_Site_Hourly_Data = i_Params_Generate_Or_Compute_Site_Hourly_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Or_Compute_Site_Hourly_Data.Exception_Message = string.Format("Generate_Or_Compute_Site_Hourly_Data : {0}", ex.Message);
                oResult_Generate_Or_Compute_Site_Hourly_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Or_Compute_Site_Hourly_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Or_Compute_Site_Hourly_Data.Exception_Message = ex.Message;
                oResult_Generate_Or_Compute_Site_Hourly_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Or_Compute_Site_Hourly_Data;
        #endregion
    }
    #endregion
    #region Generate_Site_Hourly_Indexes
    [HttpPost]
    [Route("Generate_Site_Hourly_Indexes")]
    public Result_Generate_Site_Hourly_Indexes Generate_Site_Hourly_Indexes(Params_Generate_Site_Hourly_Indexes i_Params_Generate_Site_Hourly_Indexes)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Site_Hourly_Indexes oResult_Generate_Site_Hourly_Indexes = new Result_Generate_Site_Hourly_Indexes();
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
                oBLC.Generate_Site_Hourly_Indexes(i_Params_Generate_Site_Hourly_Indexes);
                oResult_Generate_Site_Hourly_Indexes.Params_Generate_Site_Hourly_Indexes = i_Params_Generate_Site_Hourly_Indexes;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Site_Hourly_Indexes.Params_Generate_Site_Hourly_Indexes = i_Params_Generate_Site_Hourly_Indexes;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Site_Hourly_Indexes.Exception_Message = string.Format("Generate_Site_Hourly_Indexes : {0}", ex.Message);
                oResult_Generate_Site_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Site_Hourly_Indexes : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Site_Hourly_Indexes.Exception_Message = ex.Message;
                oResult_Generate_Site_Hourly_Indexes.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Site_Hourly_Indexes;
        #endregion
    }
    #endregion
    #region Get_Telus_Auth_Token
    [HttpPost]
    [Route("Get_Telus_Auth_Token")]
    public Result_Get_Telus_Auth_Token Get_Telus_Auth_Token()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Telus_Auth_Token oResult_Get_Telus_Auth_Token = new Result_Get_Telus_Auth_Token();
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
                oResult_Get_Telus_Auth_Token.i_Result = oBLC.Get_Telus_Auth_Token();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Telus_Auth_Token.Exception_Message = string.Format("Get_Telus_Auth_Token : {0}", ex.Message);
                oResult_Get_Telus_Auth_Token.Stack_Trace = is_send_stack_trace ? string.Format("Get_Telus_Auth_Token : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Telus_Auth_Token.Exception_Message = ex.Message;
                oResult_Get_Telus_Auth_Token.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Telus_Auth_Token;
        #endregion
    }
    #endregion
    #region Insert_Floor_Kpi_Data_List
    [HttpPost]
    [Route("Insert_Floor_Kpi_Data_List")]
    public Result_Insert_Floor_Kpi_Data_List Insert_Floor_Kpi_Data_List(Params_Insert_Floor_Kpi_Data_List i_Params_Insert_Floor_Kpi_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_Floor_Kpi_Data_List oResult_Insert_Floor_Kpi_Data_List = new Result_Insert_Floor_Kpi_Data_List();
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
                oBLC.Insert_Floor_Kpi_Data_List(i_Params_Insert_Floor_Kpi_Data_List);
                oResult_Insert_Floor_Kpi_Data_List.Params_Insert_Floor_Kpi_Data_List = i_Params_Insert_Floor_Kpi_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_Floor_Kpi_Data_List.Params_Insert_Floor_Kpi_Data_List = i_Params_Insert_Floor_Kpi_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_Floor_Kpi_Data_List.Exception_Message = string.Format("Insert_Floor_Kpi_Data_List : {0}", ex.Message);
                oResult_Insert_Floor_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_Floor_Kpi_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_Floor_Kpi_Data_List.Exception_Message = ex.Message;
                oResult_Insert_Floor_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_Floor_Kpi_Data_List;
        #endregion
    }
    #endregion
    #region Insert_Area_Kpi_Data_List
    [HttpPost]
    [Route("Insert_Area_Kpi_Data_List")]
    public Result_Insert_Area_Kpi_Data_List Insert_Area_Kpi_Data_List(Params_Insert_Area_Kpi_Data_List i_Params_Insert_Area_Kpi_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_Area_Kpi_Data_List oResult_Insert_Area_Kpi_Data_List = new Result_Insert_Area_Kpi_Data_List();
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
                oBLC.Insert_Area_Kpi_Data_List(i_Params_Insert_Area_Kpi_Data_List);
                oResult_Insert_Area_Kpi_Data_List.Params_Insert_Area_Kpi_Data_List = i_Params_Insert_Area_Kpi_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_Area_Kpi_Data_List.Params_Insert_Area_Kpi_Data_List = i_Params_Insert_Area_Kpi_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_Area_Kpi_Data_List.Exception_Message = string.Format("Insert_Area_Kpi_Data_List : {0}", ex.Message);
                oResult_Insert_Area_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_Area_Kpi_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_Area_Kpi_Data_List.Exception_Message = ex.Message;
                oResult_Insert_Area_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_Area_Kpi_Data_List;
        #endregion
    }
    #endregion
    #region Delete_Area_Kpi_Data_By_Where
    [HttpPost]
    [Route("Delete_Area_Kpi_Data_By_Where")]
    public Result_Delete_Area_Kpi_Data_By_Where Delete_Area_Kpi_Data_By_Where(Delete_Area_Kpi_Data_By_Where i_Delete_Area_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Area_Kpi_Data_By_Where oResult_Delete_Area_Kpi_Data_By_Where = new Result_Delete_Area_Kpi_Data_By_Where();
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
                oBLC.Delete_Area_Kpi_Data_By_Where(i_Delete_Area_Kpi_Data_By_Where);
                oResult_Delete_Area_Kpi_Data_By_Where.Delete_Area_Kpi_Data_By_Where = i_Delete_Area_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Area_Kpi_Data_By_Where.Delete_Area_Kpi_Data_By_Where = i_Delete_Area_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Area_Kpi_Data_By_Where.Exception_Message = string.Format("Delete_Area_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Delete_Area_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Area_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Area_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Delete_Area_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Area_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Delete_Floor_Kpi_Data_By_Where
    [HttpPost]
    [Route("Delete_Floor_Kpi_Data_By_Where")]
    public Result_Delete_Floor_Kpi_Data_By_Where Delete_Floor_Kpi_Data_By_Where(Params_Delete_Floor_Kpi_Data_By_Where i_Params_Delete_Floor_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Floor_Kpi_Data_By_Where oResult_Delete_Floor_Kpi_Data_By_Where = new Result_Delete_Floor_Kpi_Data_By_Where();
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
                oBLC.Delete_Floor_Kpi_Data_By_Where(i_Params_Delete_Floor_Kpi_Data_By_Where);
                oResult_Delete_Floor_Kpi_Data_By_Where.Params_Delete_Floor_Kpi_Data_By_Where = i_Params_Delete_Floor_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Floor_Kpi_Data_By_Where.Params_Delete_Floor_Kpi_Data_By_Where = i_Params_Delete_Floor_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Floor_Kpi_Data_By_Where.Exception_Message = string.Format("Delete_Floor_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Delete_Floor_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Floor_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Floor_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Delete_Floor_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Floor_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Delete_Entity_Kpi_Data_By_Where
    [HttpPost]
    [Route("Delete_Entity_Kpi_Data_By_Where")]
    public Result_Delete_Entity_Kpi_Data_By_Where Delete_Entity_Kpi_Data_By_Where(Params_Delete_Entity_Kpi_Data_By_Where i_Params_Delete_Entity_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Entity_Kpi_Data_By_Where oResult_Delete_Entity_Kpi_Data_By_Where = new Result_Delete_Entity_Kpi_Data_By_Where();
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
                oBLC.Delete_Entity_Kpi_Data_By_Where(i_Params_Delete_Entity_Kpi_Data_By_Where);
                oResult_Delete_Entity_Kpi_Data_By_Where.Params_Delete_Entity_Kpi_Data_By_Where = i_Params_Delete_Entity_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Entity_Kpi_Data_By_Where.Params_Delete_Entity_Kpi_Data_By_Where = i_Params_Delete_Entity_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Entity_Kpi_Data_By_Where.Exception_Message = string.Format("Delete_Entity_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Delete_Entity_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Entity_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Entity_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Delete_Entity_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Entity_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Delete_District_Kpi_Data_By_Where
    [HttpPost]
    [Route("Delete_District_Kpi_Data_By_Where")]
    public Result_Delete_District_Kpi_Data_By_Where Delete_District_Kpi_Data_By_Where(Params_Delete_District_Kpi_Data_By_Where i_Params_Delete_District_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_District_Kpi_Data_By_Where oResult_Delete_District_Kpi_Data_By_Where = new Result_Delete_District_Kpi_Data_By_Where();
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
                oBLC.Delete_District_Kpi_Data_By_Where(i_Params_Delete_District_Kpi_Data_By_Where);
                oResult_Delete_District_Kpi_Data_By_Where.Params_Delete_District_Kpi_Data_By_Where = i_Params_Delete_District_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_District_Kpi_Data_By_Where.Params_Delete_District_Kpi_Data_By_Where = i_Params_Delete_District_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_District_Kpi_Data_By_Where.Exception_Message = string.Format("Delete_District_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Delete_District_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_District_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_District_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Delete_District_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_District_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Delete_Site_Kpi_Data_By_Where
    [HttpPost]
    [Route("Delete_Site_Kpi_Data_By_Where")]
    public Result_Delete_Site_Kpi_Data_By_Where Delete_Site_Kpi_Data_By_Where(Params_Delete_Site_Kpi_Data_By_Where i_Params_Delete_Site_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Site_Kpi_Data_By_Where oResult_Delete_Site_Kpi_Data_By_Where = new Result_Delete_Site_Kpi_Data_By_Where();
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
                oBLC.Delete_Site_Kpi_Data_By_Where(i_Params_Delete_Site_Kpi_Data_By_Where);
                oResult_Delete_Site_Kpi_Data_By_Where.Params_Delete_Site_Kpi_Data_By_Where = i_Params_Delete_Site_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Site_Kpi_Data_By_Where.Params_Delete_Site_Kpi_Data_By_Where = i_Params_Delete_Site_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Site_Kpi_Data_By_Where.Exception_Message = string.Format("Delete_Site_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Delete_Site_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Site_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Site_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Delete_Site_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Site_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Insert_Site_Kpi_Data_List
    [HttpPost]
    [Route("Insert_Site_Kpi_Data_List")]
    public Result_Insert_Site_Kpi_Data_List Insert_Site_Kpi_Data_List(Params_Insert_Site_Kpi_Data_List i_Params_Insert_Site_Kpi_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_Site_Kpi_Data_List oResult_Insert_Site_Kpi_Data_List = new Result_Insert_Site_Kpi_Data_List();
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
                oBLC.Insert_Site_Kpi_Data_List(i_Params_Insert_Site_Kpi_Data_List);
                oResult_Insert_Site_Kpi_Data_List.Params_Insert_Site_Kpi_Data_List = i_Params_Insert_Site_Kpi_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_Site_Kpi_Data_List.Params_Insert_Site_Kpi_Data_List = i_Params_Insert_Site_Kpi_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_Site_Kpi_Data_List.Exception_Message = string.Format("Insert_Site_Kpi_Data_List : {0}", ex.Message);
                oResult_Insert_Site_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_Site_Kpi_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_Site_Kpi_Data_List.Exception_Message = ex.Message;
                oResult_Insert_Site_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_Site_Kpi_Data_List;
        #endregion
    }
    #endregion
    #region Insert_District_Kpi_Data_List
    [HttpPost]
    [Route("Insert_District_Kpi_Data_List")]
    public Result_Insert_District_Kpi_Data_List Insert_District_Kpi_Data_List(Params_Insert_District_Kpi_Data_List i_Params_Insert_District_Kpi_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_District_Kpi_Data_List oResult_Insert_District_Kpi_Data_List = new Result_Insert_District_Kpi_Data_List();
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
                oBLC.Insert_District_Kpi_Data_List(i_Params_Insert_District_Kpi_Data_List);
                oResult_Insert_District_Kpi_Data_List.Params_Insert_District_Kpi_Data_List = i_Params_Insert_District_Kpi_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_District_Kpi_Data_List.Params_Insert_District_Kpi_Data_List = i_Params_Insert_District_Kpi_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_District_Kpi_Data_List.Exception_Message = string.Format("Insert_District_Kpi_Data_List : {0}", ex.Message);
                oResult_Insert_District_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_District_Kpi_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_District_Kpi_Data_List.Exception_Message = ex.Message;
                oResult_Insert_District_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_District_Kpi_Data_List;
        #endregion
    }
    #endregion
    #region Insert_Entity_Kpi_Data_List
    [HttpPost]
    [Route("Insert_Entity_Kpi_Data_List")]
    public Result_Insert_Entity_Kpi_Data_List Insert_Entity_Kpi_Data_List(Params_Insert_Entity_Kpi_Data_List i_Params_Insert_Entity_Kpi_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_Entity_Kpi_Data_List oResult_Insert_Entity_Kpi_Data_List = new Result_Insert_Entity_Kpi_Data_List();
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
                oBLC.Insert_Entity_Kpi_Data_List(i_Params_Insert_Entity_Kpi_Data_List);
                oResult_Insert_Entity_Kpi_Data_List.Params_Insert_Entity_Kpi_Data_List = i_Params_Insert_Entity_Kpi_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_Entity_Kpi_Data_List.Params_Insert_Entity_Kpi_Data_List = i_Params_Insert_Entity_Kpi_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_Entity_Kpi_Data_List.Exception_Message = string.Format("Insert_Entity_Kpi_Data_List : {0}", ex.Message);
                oResult_Insert_Entity_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_Entity_Kpi_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_Entity_Kpi_Data_List.Exception_Message = ex.Message;
                oResult_Insert_Entity_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_Entity_Kpi_Data_List;
        #endregion
    }
    #endregion
    #region Insert_Space_Kpi_Data_List
    [HttpPost]
    [Route("Insert_Space_Kpi_Data_List")]
    public Result_Insert_Space_Kpi_Data_List Insert_Space_Kpi_Data_List(Params_Insert_Space_Kpi_Data_List i_Params_Insert_Space_Kpi_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Insert_Space_Kpi_Data_List oResult_Insert_Space_Kpi_Data_List = new Result_Insert_Space_Kpi_Data_List();
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
                oBLC.Insert_Space_Kpi_Data_List(i_Params_Insert_Space_Kpi_Data_List);
                oResult_Insert_Space_Kpi_Data_List.Params_Insert_Space_Kpi_Data_List = i_Params_Insert_Space_Kpi_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Insert_Space_Kpi_Data_List.Params_Insert_Space_Kpi_Data_List = i_Params_Insert_Space_Kpi_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Insert_Space_Kpi_Data_List.Exception_Message = string.Format("Insert_Space_Kpi_Data_List : {0}", ex.Message);
                oResult_Insert_Space_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Insert_Space_Kpi_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Insert_Space_Kpi_Data_List.Exception_Message = ex.Message;
                oResult_Insert_Space_Kpi_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Insert_Space_Kpi_Data_List;
        #endregion
    }
    #endregion
    #region Delete_Space_Kpi_Data_By_Where
    [HttpPost]
    [Route("Delete_Space_Kpi_Data_By_Where")]
    public Result_Delete_Space_Kpi_Data_By_Where Delete_Space_Kpi_Data_By_Where(Params_Delete_Space_Kpi_Data_By_Where i_Params_Delete_Space_Kpi_Data_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Space_Kpi_Data_By_Where oResult_Delete_Space_Kpi_Data_By_Where = new Result_Delete_Space_Kpi_Data_By_Where();
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
                oBLC.Delete_Space_Kpi_Data_By_Where(i_Params_Delete_Space_Kpi_Data_By_Where);
                oResult_Delete_Space_Kpi_Data_By_Where.Params_Delete_Space_Kpi_Data_By_Where = i_Params_Delete_Space_Kpi_Data_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Space_Kpi_Data_By_Where.Params_Delete_Space_Kpi_Data_By_Where = i_Params_Delete_Space_Kpi_Data_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Space_Kpi_Data_By_Where.Exception_Message = string.Format("Delete_Space_Kpi_Data_By_Where : {0}", ex.Message);
                oResult_Delete_Space_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Space_Kpi_Data_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Space_Kpi_Data_By_Where.Exception_Message = ex.Message;
                oResult_Delete_Space_Kpi_Data_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Space_Kpi_Data_By_Where;
        #endregion
    }
    #endregion
    #region Generate_Site_Demographic_Data
    [HttpPost]
    [Route("Generate_Site_Demographic_Data")]
    public Result_Generate_Site_Demographic_Data Generate_Site_Demographic_Data(Params_Generate_Site_Demographic_Data i_Params_Generate_Site_Demographic_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Site_Demographic_Data oResult_Generate_Site_Demographic_Data = new Result_Generate_Site_Demographic_Data();
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
                oBLC.Generate_Site_Demographic_Data(i_Params_Generate_Site_Demographic_Data);
                oResult_Generate_Site_Demographic_Data.Params_Generate_Site_Demographic_Data = i_Params_Generate_Site_Demographic_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Site_Demographic_Data.Params_Generate_Site_Demographic_Data = i_Params_Generate_Site_Demographic_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Site_Demographic_Data.Exception_Message = string.Format("Generate_Site_Demographic_Data : {0}", ex.Message);
                oResult_Generate_Site_Demographic_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Site_Demographic_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Site_Demographic_Data.Exception_Message = ex.Message;
                oResult_Generate_Site_Demographic_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Site_Demographic_Data;
        #endregion
    }
    #endregion
    #region Generate_Site_Visitor_Data_And_Dwell_Time
    [HttpPost]
    [Route("Generate_Site_Visitor_Data_And_Dwell_Time")]
    public Result_Generate_Site_Visitor_Data_And_Dwell_Time Generate_Site_Visitor_Data_And_Dwell_Time(Params_Generate_Site_Visitor_Data_And_Dwell_Time i_Params_Generate_Site_Visitor_Data_And_Dwell_Time)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Site_Visitor_Data_And_Dwell_Time oResult_Generate_Site_Visitor_Data_And_Dwell_Time = new Result_Generate_Site_Visitor_Data_And_Dwell_Time();
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
                oBLC.Generate_Site_Visitor_Data_And_Dwell_Time(i_Params_Generate_Site_Visitor_Data_And_Dwell_Time);
                oResult_Generate_Site_Visitor_Data_And_Dwell_Time.Params_Generate_Site_Visitor_Data_And_Dwell_Time = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Site_Visitor_Data_And_Dwell_Time.Params_Generate_Site_Visitor_Data_And_Dwell_Time = i_Params_Generate_Site_Visitor_Data_And_Dwell_Time;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Site_Visitor_Data_And_Dwell_Time.Exception_Message = string.Format("Generate_Site_Visitor_Data_And_Dwell_Time : {0}", ex.Message);
                oResult_Generate_Site_Visitor_Data_And_Dwell_Time.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Site_Visitor_Data_And_Dwell_Time : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Site_Visitor_Data_And_Dwell_Time.Exception_Message = ex.Message;
                oResult_Generate_Site_Visitor_Data_And_Dwell_Time.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Site_Visitor_Data_And_Dwell_Time;
        #endregion
    }
    #endregion
    #region Generate_Visitor_Activity_Data
    [HttpPost]
    [Route("Generate_Visitor_Activity_Data")]
    public Result_Generate_Visitor_Activity_Data Generate_Visitor_Activity_Data(Params_Generate_Visitor_Activity_Data i_Params_Generate_Visitor_Activity_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Visitor_Activity_Data oResult_Generate_Visitor_Activity_Data = new Result_Generate_Visitor_Activity_Data();
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
                oBLC.Generate_Visitor_Activity_Data(i_Params_Generate_Visitor_Activity_Data);
                oResult_Generate_Visitor_Activity_Data.Params_Generate_Visitor_Activity_Data = i_Params_Generate_Visitor_Activity_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Visitor_Activity_Data.Params_Generate_Visitor_Activity_Data = i_Params_Generate_Visitor_Activity_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Visitor_Activity_Data.Exception_Message = string.Format("Generate_Visitor_Activity_Data : {0}", ex.Message);
                oResult_Generate_Visitor_Activity_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Visitor_Activity_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Visitor_Activity_Data.Exception_Message = ex.Message;
                oResult_Generate_Visitor_Activity_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Visitor_Activity_Data;
        #endregion
    }
    #endregion
    #region Generate_Worker_Data
    [HttpPost]
    [Route("Generate_Worker_Data")]
    public Result_Generate_Worker_Data Generate_Worker_Data(Params_Generate_Worker_Data i_Params_Generate_Worker_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Worker_Data oResult_Generate_Worker_Data = new Result_Generate_Worker_Data();
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
                oBLC.Generate_Worker_Data(i_Params_Generate_Worker_Data);
                oResult_Generate_Worker_Data.Params_Generate_Worker_Data = i_Params_Generate_Worker_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Worker_Data.Params_Generate_Worker_Data = i_Params_Generate_Worker_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Worker_Data.Exception_Message = string.Format("Generate_Worker_Data : {0}", ex.Message);
                oResult_Generate_Worker_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Worker_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Worker_Data.Exception_Message = ex.Message;
                oResult_Generate_Worker_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Worker_Data;
        #endregion
    }
    #endregion
    #region Generate_District_Dwell_Time
    [HttpPost]
    [Route("Generate_District_Dwell_Time")]
    public Result_Generate_District_Dwell_Time Generate_District_Dwell_Time(Params_Generate_District_Dwell_Time i_Params_Generate_District_Dwell_Time)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_District_Dwell_Time oResult_Generate_District_Dwell_Time = new Result_Generate_District_Dwell_Time();
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
                oBLC.Generate_District_Dwell_Time(i_Params_Generate_District_Dwell_Time);
                oResult_Generate_District_Dwell_Time.Params_Generate_District_Dwell_Time = i_Params_Generate_District_Dwell_Time;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_District_Dwell_Time.Params_Generate_District_Dwell_Time = i_Params_Generate_District_Dwell_Time;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_District_Dwell_Time.Exception_Message = string.Format("Generate_District_Dwell_Time : {0}", ex.Message);
                oResult_Generate_District_Dwell_Time.Stack_Trace = is_send_stack_trace ? string.Format("Generate_District_Dwell_Time : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_District_Dwell_Time.Exception_Message = ex.Message;
                oResult_Generate_District_Dwell_Time.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_District_Dwell_Time;
        #endregion
    }
    #endregion
    #region Generate_Area_Dwell_Time
    [HttpPost]
    [Route("Generate_Area_Dwell_Time")]
    public Result_Generate_Area_Dwell_Time Generate_Area_Dwell_Time(Params_Generate_Area_Dwell_Time i_Params_Generate_Area_Dwell_Time)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Area_Dwell_Time oResult_Generate_Area_Dwell_Time = new Result_Generate_Area_Dwell_Time();
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
                oBLC.Generate_Area_Dwell_Time(i_Params_Generate_Area_Dwell_Time);
                oResult_Generate_Area_Dwell_Time.Params_Generate_Area_Dwell_Time = i_Params_Generate_Area_Dwell_Time;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Area_Dwell_Time.Params_Generate_Area_Dwell_Time = i_Params_Generate_Area_Dwell_Time;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Area_Dwell_Time.Exception_Message = string.Format("Generate_Area_Dwell_Time : {0}", ex.Message);
                oResult_Generate_Area_Dwell_Time.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Area_Dwell_Time : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Area_Dwell_Time.Exception_Message = ex.Message;
                oResult_Generate_Area_Dwell_Time.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Area_Dwell_Time;
        #endregion
    }
    #endregion
    #region Generate_Area_Demographic_Data
    [HttpPost]
    [Route("Generate_Area_Demographic_Data")]
    public Result_Generate_Area_Demographic_Data Generate_Area_Demographic_Data(Params_Generate_Area_Demographic_Data i_Params_Generate_Area_Demographic_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Area_Demographic_Data oResult_Generate_Area_Demographic_Data = new Result_Generate_Area_Demographic_Data();
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
                oBLC.Generate_Area_Demographic_Data(i_Params_Generate_Area_Demographic_Data);
                oResult_Generate_Area_Demographic_Data.Params_Generate_Area_Demographic_Data = i_Params_Generate_Area_Demographic_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Area_Demographic_Data.Params_Generate_Area_Demographic_Data = i_Params_Generate_Area_Demographic_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Area_Demographic_Data.Exception_Message = string.Format("Generate_Area_Demographic_Data : {0}", ex.Message);
                oResult_Generate_Area_Demographic_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Area_Demographic_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Area_Demographic_Data.Exception_Message = ex.Message;
                oResult_Generate_Area_Demographic_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Area_Demographic_Data;
        #endregion
    }
    #endregion
    #region Generate_District_Demographic_Data
    [HttpPost]
    [Route("Generate_District_Demographic_Data")]
    public Result_Generate_District_Demographic_Data Generate_District_Demographic_Data(Params_Generate_District_Demographic_Data i_Params_Generate_District_Demographic_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_District_Demographic_Data oResult_Generate_District_Demographic_Data = new Result_Generate_District_Demographic_Data();
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
                oBLC.Generate_District_Demographic_Data(i_Params_Generate_District_Demographic_Data);
                oResult_Generate_District_Demographic_Data.Params_Generate_District_Demographic_Data = i_Params_Generate_District_Demographic_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_District_Demographic_Data.Params_Generate_District_Demographic_Data = i_Params_Generate_District_Demographic_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_District_Demographic_Data.Exception_Message = string.Format("Generate_District_Demographic_Data : {0}", ex.Message);
                oResult_Generate_District_Demographic_Data.Stack_Trace = is_send_stack_trace ? string.Format("Generate_District_Demographic_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_District_Demographic_Data.Exception_Message = ex.Message;
                oResult_Generate_District_Demographic_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_District_Demographic_Data;
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
    #region Edit_Kpi_List
    [HttpPost]
    [Route("Edit_Kpi_List")]
    public Result_Edit_Kpi_List Edit_Kpi_List(Params_Edit_Kpi_List i_Params_Edit_Kpi_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Kpi_List oResult_Edit_Kpi_List = new Result_Edit_Kpi_List();
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
                oBLC.Edit_Kpi_List(i_Params_Edit_Kpi_List);
                oResult_Edit_Kpi_List.Params_Edit_Kpi_List = i_Params_Edit_Kpi_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Kpi_List.Exception_Message = string.Format("Edit_Kpi_List : {0}", ex.Message);
                oResult_Edit_Kpi_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Kpi_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Kpi_List.Exception_Message = ex.Message;
                oResult_Edit_Kpi_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Kpi_List;
        #endregion
    }
    #endregion
    #region Get_And_Fill_Public_events_From_Api
    [HttpPost]
    [Route("Get_And_Fill_Public_events_From_Api")]
    public Result_Get_And_Fill_Public_events_From_Api Get_And_Fill_Public_events_From_Api(Params_Get_And_Fill_Public_events_From_Api i_Params_Get_And_Fill_Public_events_From_Api)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_And_Fill_Public_events_From_Api oResult_Get_And_Fill_Public_events_From_Api = new Result_Get_And_Fill_Public_events_From_Api();
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
                oBLC.Get_And_Fill_Public_events_From_Api(i_Params_Get_And_Fill_Public_events_From_Api);
                oResult_Get_And_Fill_Public_events_From_Api.Params_Get_And_Fill_Public_events_From_Api = i_Params_Get_And_Fill_Public_events_From_Api;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_And_Fill_Public_events_From_Api.Params_Get_And_Fill_Public_events_From_Api = i_Params_Get_And_Fill_Public_events_From_Api;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_And_Fill_Public_events_From_Api.Exception_Message = string.Format("Get_And_Fill_Public_events_From_Api : {0}", ex.Message);
                oResult_Get_And_Fill_Public_events_From_Api.Stack_Trace = is_send_stack_trace ? string.Format("Get_And_Fill_Public_events_From_Api : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_And_Fill_Public_events_From_Api.Exception_Message = ex.Message;
                oResult_Get_And_Fill_Public_events_From_Api.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_And_Fill_Public_events_From_Api;
        #endregion
    }
    #endregion
    #region Get_And_Fill_Businesses_From_Api
    [HttpPost]
    [Route("Get_And_Fill_Businesses_From_Api")]
    public Result_Get_And_Fill_Businesses_From_Api Get_And_Fill_Businesses_From_Api()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_And_Fill_Businesses_From_Api oResult_Get_And_Fill_Businesses_From_Api = new Result_Get_And_Fill_Businesses_From_Api();
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
                oBLC.Get_And_Fill_Businesses_From_Api();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_And_Fill_Businesses_From_Api.Exception_Message = string.Format("Get_And_Fill_Businesses_From_Api : {0}", ex.Message);
                oResult_Get_And_Fill_Businesses_From_Api.Stack_Trace = is_send_stack_trace ? string.Format("Get_And_Fill_Businesses_From_Api : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_And_Fill_Businesses_From_Api.Exception_Message = ex.Message;
                oResult_Get_And_Fill_Businesses_From_Api.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_And_Fill_Businesses_From_Api;
        #endregion
    }
    #endregion
    #region Get_And_Fill_Bylaw_complaints_From_Api
    [HttpPost]
    [Route("Get_And_Fill_Bylaw_complaints_From_Api")]
    public Result_Get_And_Fill_Bylaw_complaints_From_Api Get_And_Fill_Bylaw_complaints_From_Api(Params_Get_And_Fill_Bylaw_complaints_From_Api i_Params_Get_And_Fill_Bylaw_complaints_From_Api)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_And_Fill_Bylaw_complaints_From_Api oResult_Get_And_Fill_Bylaw_complaints_From_Api = new Result_Get_And_Fill_Bylaw_complaints_From_Api();
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
                oBLC.Get_And_Fill_Bylaw_complaints_From_Api(i_Params_Get_And_Fill_Bylaw_complaints_From_Api);
                oResult_Get_And_Fill_Bylaw_complaints_From_Api.Params_Get_And_Fill_Bylaw_complaints_From_Api = i_Params_Get_And_Fill_Bylaw_complaints_From_Api;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_And_Fill_Bylaw_complaints_From_Api.Params_Get_And_Fill_Bylaw_complaints_From_Api = i_Params_Get_And_Fill_Bylaw_complaints_From_Api;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_And_Fill_Bylaw_complaints_From_Api.Exception_Message = string.Format("Get_And_Fill_Bylaw_complaints_From_Api : {0}", ex.Message);
                oResult_Get_And_Fill_Bylaw_complaints_From_Api.Stack_Trace = is_send_stack_trace ? string.Format("Get_And_Fill_Bylaw_complaints_From_Api : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_And_Fill_Bylaw_complaints_From_Api.Exception_Message = ex.Message;
                oResult_Get_And_Fill_Bylaw_complaints_From_Api.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_And_Fill_Bylaw_complaints_From_Api;
        #endregion
    }
    #endregion
    #region Get_Data_source_By_OWNER_ID
    [HttpGet]
    [Route("Get_Data_source_By_OWNER_ID")]
    public Result_Get_Data_source_By_OWNER_ID Get_Data_source_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Data_source_By_OWNER_ID oResult_Get_Data_source_By_OWNER_ID = new Result_Get_Data_source_By_OWNER_ID();
        Params_Get_Data_source_By_OWNER_ID oParams_Get_Data_source_By_OWNER_ID = new Params_Get_Data_source_By_OWNER_ID();
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
                oParams_Get_Data_source_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Data_source_By_OWNER_ID.i_Result = oBLC.Get_Data_source_By_OWNER_ID(oParams_Get_Data_source_By_OWNER_ID);
                oResult_Get_Data_source_By_OWNER_ID.Params_Get_Data_source_By_OWNER_ID = oParams_Get_Data_source_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Data_source_By_OWNER_ID.Params_Get_Data_source_By_OWNER_ID = oParams_Get_Data_source_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Data_source_By_OWNER_ID.Exception_Message = string.Format("Get_Data_source_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Data_source_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Data_source_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Data_source_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Data_source_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Data_source_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Delete_Data_source
    [HttpPost]
    [Route("Delete_Data_source")]
    public Result_Delete_Data_source Delete_Data_source(Params_Delete_Data_source i_Params_Delete_Data_source)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Data_source oResult_Delete_Data_source = new Result_Delete_Data_source();
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
                oBLC.Delete_Data_source(i_Params_Delete_Data_source);
                oResult_Delete_Data_source.Params_Delete_Data_source = i_Params_Delete_Data_source;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Data_source.Params_Delete_Data_source = i_Params_Delete_Data_source;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Data_source.Exception_Message = string.Format("Delete_Data_source : {0}", ex.Message);
                oResult_Delete_Data_source.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Data_source : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Data_source.Exception_Message = ex.Message;
                oResult_Delete_Data_source.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Data_source;
        #endregion
    }
    #endregion
    #region Edit_Data_source
    [HttpPost]
    [Route("Edit_Data_source")]
    public Result_Edit_Data_source Edit_Data_source(Data_source i_Data_source)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Data_source oResult_Edit_Data_source = new Result_Edit_Data_source();
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
                oBLC.Edit_Data_source(i_Data_source);
                oResult_Edit_Data_source.Data_source = i_Data_source;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Data_source.Exception_Message = string.Format("Edit_Data_source : {0}", ex.Message);
                oResult_Edit_Data_source.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Data_source : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Data_source.Exception_Message = ex.Message;
                oResult_Edit_Data_source.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Data_source;
        #endregion
    }
    #endregion
    #region Delete_Organization_data_source_kpi
    [HttpPost]
    [Route("Delete_Organization_data_source_kpi")]
    public Result_Delete_Organization_data_source_kpi Delete_Organization_data_source_kpi(Params_Delete_Organization_data_source_kpi i_Params_Delete_Organization_data_source_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_data_source_kpi oResult_Delete_Organization_data_source_kpi = new Result_Delete_Organization_data_source_kpi();
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
                oBLC.Delete_Organization_data_source_kpi(i_Params_Delete_Organization_data_source_kpi);
                oResult_Delete_Organization_data_source_kpi.Params_Delete_Organization_data_source_kpi = i_Params_Delete_Organization_data_source_kpi;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_data_source_kpi.Params_Delete_Organization_data_source_kpi = i_Params_Delete_Organization_data_source_kpi;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_data_source_kpi.Exception_Message = string.Format("Delete_Organization_data_source_kpi : {0}", ex.Message);
                oResult_Delete_Organization_data_source_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_data_source_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_data_source_kpi.Exception_Message = ex.Message;
                oResult_Delete_Organization_data_source_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_data_source_kpi;
        #endregion
    }
    #endregion
    #region Edit_Organization_data_source_kpi
    [HttpPost]
    [Route("Edit_Organization_data_source_kpi")]
    public Result_Edit_Organization_data_source_kpi Edit_Organization_data_source_kpi(Organization_data_source_kpi i_Organization_data_source_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_data_source_kpi oResult_Edit_Organization_data_source_kpi = new Result_Edit_Organization_data_source_kpi();
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
                oBLC.Edit_Organization_data_source_kpi(i_Organization_data_source_kpi);
                oResult_Edit_Organization_data_source_kpi.Organization_data_source_kpi = i_Organization_data_source_kpi;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_data_source_kpi.Exception_Message = string.Format("Edit_Organization_data_source_kpi : {0}", ex.Message);
                oResult_Edit_Organization_data_source_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_data_source_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_data_source_kpi.Exception_Message = ex.Message;
                oResult_Edit_Organization_data_source_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_data_source_kpi;
        #endregion
    }
    #endregion
    #region Get_Niche_categories_By_Where
    [HttpPost]
    [Route("Get_Niche_categories_By_Where")]
    public Result_Get_Niche_categories_By_Where Get_Niche_categories_By_Where(Params_Get_Niche_categories_By_Where i_Params_Get_Niche_categories_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Niche_categories_By_Where oResult_Get_Niche_categories_By_Where = new Result_Get_Niche_categories_By_Where();
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
                oResult_Get_Niche_categories_By_Where.i_Result = oBLC.Get_Niche_categories_By_Where(i_Params_Get_Niche_categories_By_Where);
                oResult_Get_Niche_categories_By_Where.Params_Get_Niche_categories_By_Where = i_Params_Get_Niche_categories_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Niche_categories_By_Where.Params_Get_Niche_categories_By_Where = i_Params_Get_Niche_categories_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Niche_categories_By_Where.Exception_Message = string.Format("Get_Niche_categories_By_Where : {0}", ex.Message);
                oResult_Get_Niche_categories_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Niche_categories_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Niche_categories_By_Where.Exception_Message = ex.Message;
                oResult_Get_Niche_categories_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Niche_categories_By_Where;
        #endregion
    }
    #endregion
    #region Edit_Niche_categories_List
    [HttpPost]
    [Route("Edit_Niche_categories_List")]
    public Result_Edit_Niche_categories_List Edit_Niche_categories_List(Params_Edit_Niche_categories_List i_Params_Edit_Niche_categories_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Niche_categories_List oResult_Edit_Niche_categories_List = new Result_Edit_Niche_categories_List();
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
                oBLC.Edit_Niche_categories_List(i_Params_Edit_Niche_categories_List);
                oResult_Edit_Niche_categories_List.Params_Edit_Niche_categories_List = i_Params_Edit_Niche_categories_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Niche_categories_List.Params_Edit_Niche_categories_List = i_Params_Edit_Niche_categories_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Niche_categories_List.Exception_Message = string.Format("Edit_Niche_categories_List : {0}", ex.Message);
                oResult_Edit_Niche_categories_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Niche_categories_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Niche_categories_List.Exception_Message = ex.Message;
                oResult_Edit_Niche_categories_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Niche_categories_List;
        #endregion
    }
    #endregion
    #region Delete_Niche_categories
    [HttpPost]
    [Route("Delete_Niche_categories")]
    public Result_Delete_Niche_categories Delete_Niche_categories(Params_Delete_Niche_categories i_Params_Delete_Niche_categories)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Niche_categories oResult_Delete_Niche_categories = new Result_Delete_Niche_categories();
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
                oBLC.Delete_Niche_categories(i_Params_Delete_Niche_categories);
                oResult_Delete_Niche_categories.Params_Delete_Niche_categories = i_Params_Delete_Niche_categories;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Niche_categories.Params_Delete_Niche_categories = i_Params_Delete_Niche_categories;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Niche_categories.Exception_Message = string.Format("Delete_Niche_categories : {0}", ex.Message);
                oResult_Delete_Niche_categories.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Niche_categories : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Niche_categories.Exception_Message = ex.Message;
                oResult_Delete_Niche_categories.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Niche_categories;
        #endregion
    }
    #endregion
    #region Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
    [HttpPost]
    [Route("Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List")]
    public Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List = new Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List();
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
                oBLC.Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);
                oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List = i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List = i_Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.Exception_Message = string.Format("Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List : {0}", ex.Message);
                oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.Exception_Message = ex.Message;
                oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List;
        #endregion
    }
    #endregion
    #region Generate_Business_Count_And_Vacant_Business_Count
    [HttpPost]
    [Route("Generate_Business_Count_And_Vacant_Business_Count")]
    public Result_Generate_Business_Count_And_Vacant_Business_Count Generate_Business_Count_And_Vacant_Business_Count(Params_Generate_Business_Count_And_Vacant_Business_Count i_Params_Generate_Business_Count_And_Vacant_Business_Count)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Generate_Business_Count_And_Vacant_Business_Count oResult_Generate_Business_Count_And_Vacant_Business_Count = new Result_Generate_Business_Count_And_Vacant_Business_Count();
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
                oBLC.Generate_Business_Count_And_Vacant_Business_Count(i_Params_Generate_Business_Count_And_Vacant_Business_Count);
                oResult_Generate_Business_Count_And_Vacant_Business_Count.Params_Generate_Business_Count_And_Vacant_Business_Count = i_Params_Generate_Business_Count_And_Vacant_Business_Count;
            }
        }
        catch (Exception ex)
        {
            oResult_Generate_Business_Count_And_Vacant_Business_Count.Params_Generate_Business_Count_And_Vacant_Business_Count = i_Params_Generate_Business_Count_And_Vacant_Business_Count;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Generate_Business_Count_And_Vacant_Business_Count.Exception_Message = string.Format("Generate_Business_Count_And_Vacant_Business_Count : {0}", ex.Message);
                oResult_Generate_Business_Count_And_Vacant_Business_Count.Stack_Trace = is_send_stack_trace ? string.Format("Generate_Business_Count_And_Vacant_Business_Count : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Generate_Business_Count_And_Vacant_Business_Count.Exception_Message = ex.Message;
                oResult_Generate_Business_Count_And_Vacant_Business_Count.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Generate_Business_Count_And_Vacant_Business_Count;
        #endregion
    }
    #endregion
    #region Extract_Kpi_Data_From_CSV
    [HttpPost]
    [Route("Extract_Kpi_Data_From_CSV")]
    public Result_Extract_Kpi_Data_From_CSV Extract_Kpi_Data_From_CSV(Params_Extract_Kpi_Data_From_CSV i_Params_Extract_Kpi_Data_From_CSV)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Extract_Kpi_Data_From_CSV oResult_Extract_Kpi_Data_From_CSV = new Result_Extract_Kpi_Data_From_CSV();
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
                oResult_Extract_Kpi_Data_From_CSV.i_Result = oBLC.Extract_Kpi_Data_From_CSV(i_Params_Extract_Kpi_Data_From_CSV);
                oResult_Extract_Kpi_Data_From_CSV.Params_Extract_Kpi_Data_From_CSV = i_Params_Extract_Kpi_Data_From_CSV;
            }
        }
        catch (Exception ex)
        {
            oResult_Extract_Kpi_Data_From_CSV.Params_Extract_Kpi_Data_From_CSV = i_Params_Extract_Kpi_Data_From_CSV;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Extract_Kpi_Data_From_CSV.Exception_Message = string.Format("Extract_Kpi_Data_From_CSV : {0}", ex.Message);
                oResult_Extract_Kpi_Data_From_CSV.Stack_Trace = is_send_stack_trace ? string.Format("Extract_Kpi_Data_From_CSV : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Extract_Kpi_Data_From_CSV.Exception_Message = ex.Message;
                oResult_Extract_Kpi_Data_From_CSV.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Extract_Kpi_Data_From_CSV;
        #endregion
    }
    #endregion
    #region Get_Floor_By_ENTITY_ID_List
    [HttpGet]
    [Route("Get_Floor_By_ENTITY_ID_List")]
    public Result_Get_Floor_By_ENTITY_ID_List Get_Floor_By_ENTITY_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_By_ENTITY_ID_List oResult_Get_Floor_By_ENTITY_ID_List = new Result_Get_Floor_By_ENTITY_ID_List();
        Params_Get_Floor_By_ENTITY_ID_List oParams_Get_Floor_By_ENTITY_ID_List = new Params_Get_Floor_By_ENTITY_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ENTITY_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ENTITY_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ENTITY_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ENTITY_ID_LIST"].ToString() != "")
            {
                oParams_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST = HttpContext.Request
                                                                                .Query["ENTITY_ID_LIST"]
                                                                                .ToString()
                                                                                .Split(',')
                                                                                .Where(val => long.TryParse(val, out _))
                                                                                .Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Floor_By_ENTITY_ID_List.i_Result = oBLC.Get_Floor_By_ENTITY_ID_List(oParams_Get_Floor_By_ENTITY_ID_List);
                oResult_Get_Floor_By_ENTITY_ID_List.Params_Get_Floor_By_ENTITY_ID_List = oParams_Get_Floor_By_ENTITY_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_By_ENTITY_ID_List.Params_Get_Floor_By_ENTITY_ID_List = oParams_Get_Floor_By_ENTITY_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_By_ENTITY_ID_List.Exception_Message = string.Format("Get_Floor_By_ENTITY_ID_List : {0}", ex.Message);
                oResult_Get_Floor_By_ENTITY_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_By_ENTITY_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_By_ENTITY_ID_List.Exception_Message = ex.Message;
                oResult_Get_Floor_By_ENTITY_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_By_ENTITY_ID_List;
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
#region Result_Get_Visitor_Activity_Data
public partial class Result_Get_Visitor_Activity_Data : Action_Result
{
    #region Properties.
    public Visitor_Activity i_Result { get; set; }
    public Params_Get_Visitor_Activity_Data Params_Get_Visitor_Activity_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Demographic_Data
public partial class Result_Get_Demographic_Data : Action_Result
{
    #region Properties.
    public Demographic_Data i_Result { get; set; }
    public Params_Get_Demographic_Data Params_Get_Demographic_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Visitor_Data
public partial class Result_Get_Visitor_Data : Action_Result
{
    #region Properties.
    public Visitor_Data i_Result { get; set; }
    public Params_Get_Visitor_Data Params_Get_Visitor_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_Jobs_By_Where
public partial class Result_Get_Jobs_By_Where : Action_Result
{
    #region Properties.
    public List<Job> i_Result { get; set; }
    public Params_Get_Jobs_By_Where Params_Get_Jobs_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Job_List
public partial class Result_Edit_Job_List : Action_Result
{
    #region Properties.
    public Params_Edit_Job_List Params_Edit_Job_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Job
public partial class Result_Delete_Job : Action_Result
{
    #region Properties.
    public Params_Delete_Job Params_Delete_Job { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Or_Compute_District_Hourly_Data
public partial class Result_Generate_Or_Compute_District_Hourly_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Or_Compute_District_Hourly_Data Params_Generate_Or_Compute_District_Hourly_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_District_Hourly_Indexes
public partial class Result_Generate_District_Hourly_Indexes : Action_Result
{
    #region Properties.
    public Params_Generate_District_Hourly_Indexes Params_Generate_District_Hourly_Indexes { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Or_Compute_Area_Hourly_Data
public partial class Result_Generate_Or_Compute_Area_Hourly_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Or_Compute_Area_Hourly_Data Params_Generate_Or_Compute_Area_Hourly_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Area_Hourly_Indexes
public partial class Result_Generate_Area_Hourly_Indexes : Action_Result
{
    #region Properties.
    public Params_Generate_Area_Hourly_Indexes Params_Generate_Area_Hourly_Indexes { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Space_Hourly_Indexes
public partial class Result_Generate_Space_Hourly_Indexes : Action_Result
{
    #region Properties.
    public Params_Generate_Space_Hourly_Indexes Params_Generate_Space_Hourly_Indexes { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Or_Compute_Floor_Hourly_Data
public partial class Result_Generate_Or_Compute_Floor_Hourly_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Or_Compute_Floor_Hourly_Data Params_Generate_Or_Compute_Floor_Hourly_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Floor_Hourly_Indexes
public partial class Result_Generate_Floor_Hourly_Indexes : Action_Result
{
    #region Properties.
    public Params_Generate_Floor_Hourly_Indexes Params_Generate_Floor_Hourly_Indexes { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Or_Compute_Entity_Hourly_Data
public partial class Result_Generate_Or_Compute_Entity_Hourly_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Or_Compute_Entity_Hourly_Data Params_Generate_Or_Compute_Entity_Hourly_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Entity_Hourly_Indexes
public partial class Result_Generate_Entity_Hourly_Indexes : Action_Result
{
    #region Properties.
    public Params_Generate_Entity_Hourly_Indexes Params_Generate_Entity_Hourly_Indexes { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Or_Compute_Site_Hourly_Data
public partial class Result_Generate_Or_Compute_Site_Hourly_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Or_Compute_Site_Hourly_Data Params_Generate_Or_Compute_Site_Hourly_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Site_Hourly_Indexes
public partial class Result_Generate_Site_Hourly_Indexes : Action_Result
{
    #region Properties.
    public Params_Generate_Site_Hourly_Indexes Params_Generate_Site_Hourly_Indexes { get; set; }
    #endregion
}
#endregion
#region Result_Get_Telus_Auth_Token
public partial class Result_Get_Telus_Auth_Token : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Insert_Floor_Kpi_Data_List
public partial class Result_Insert_Floor_Kpi_Data_List : Action_Result
{
    #region Properties.
    public Params_Insert_Floor_Kpi_Data_List Params_Insert_Floor_Kpi_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Insert_Area_Kpi_Data_List
public partial class Result_Insert_Area_Kpi_Data_List : Action_Result
{
    #region Properties.
    public Params_Insert_Area_Kpi_Data_List Params_Insert_Area_Kpi_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Area_Kpi_Data_By_Where
public partial class Result_Delete_Area_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public Delete_Area_Kpi_Data_By_Where Delete_Area_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Floor_Kpi_Data_By_Where
public partial class Result_Delete_Floor_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public Params_Delete_Floor_Kpi_Data_By_Where Params_Delete_Floor_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Entity_Kpi_Data_By_Where
public partial class Result_Delete_Entity_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public Params_Delete_Entity_Kpi_Data_By_Where Params_Delete_Entity_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Delete_District_Kpi_Data_By_Where
public partial class Result_Delete_District_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public Params_Delete_District_Kpi_Data_By_Where Params_Delete_District_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Site_Kpi_Data_By_Where
public partial class Result_Delete_Site_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public Params_Delete_Site_Kpi_Data_By_Where Params_Delete_Site_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Insert_Site_Kpi_Data_List
public partial class Result_Insert_Site_Kpi_Data_List : Action_Result
{
    #region Properties.
    public Params_Insert_Site_Kpi_Data_List Params_Insert_Site_Kpi_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Insert_District_Kpi_Data_List
public partial class Result_Insert_District_Kpi_Data_List : Action_Result
{
    #region Properties.
    public Params_Insert_District_Kpi_Data_List Params_Insert_District_Kpi_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Insert_Entity_Kpi_Data_List
public partial class Result_Insert_Entity_Kpi_Data_List : Action_Result
{
    #region Properties.
    public Params_Insert_Entity_Kpi_Data_List Params_Insert_Entity_Kpi_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Insert_Space_Kpi_Data_List
public partial class Result_Insert_Space_Kpi_Data_List : Action_Result
{
    #region Properties.
    public Params_Insert_Space_Kpi_Data_List Params_Insert_Space_Kpi_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Space_Kpi_Data_By_Where
public partial class Result_Delete_Space_Kpi_Data_By_Where : Action_Result
{
    #region Properties.
    public Params_Delete_Space_Kpi_Data_By_Where Params_Delete_Space_Kpi_Data_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Site_Demographic_Data
public partial class Result_Generate_Site_Demographic_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Site_Demographic_Data Params_Generate_Site_Demographic_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Site_Visitor_Data_And_Dwell_Time
public partial class Result_Generate_Site_Visitor_Data_And_Dwell_Time : Action_Result
{
    #region Properties.
    public Params_Generate_Site_Visitor_Data_And_Dwell_Time Params_Generate_Site_Visitor_Data_And_Dwell_Time { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Visitor_Activity_Data
public partial class Result_Generate_Visitor_Activity_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Visitor_Activity_Data Params_Generate_Visitor_Activity_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Worker_Data
public partial class Result_Generate_Worker_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Worker_Data Params_Generate_Worker_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_District_Dwell_Time
public partial class Result_Generate_District_Dwell_Time : Action_Result
{
    #region Properties.
    public Params_Generate_District_Dwell_Time Params_Generate_District_Dwell_Time { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Area_Dwell_Time
public partial class Result_Generate_Area_Dwell_Time : Action_Result
{
    #region Properties.
    public Params_Generate_Area_Dwell_Time Params_Generate_Area_Dwell_Time { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Area_Demographic_Data
public partial class Result_Generate_Area_Demographic_Data : Action_Result
{
    #region Properties.
    public Params_Generate_Area_Demographic_Data Params_Generate_Area_Demographic_Data { get; set; }
    #endregion
}
#endregion
#region Result_Generate_District_Demographic_Data
public partial class Result_Generate_District_Demographic_Data : Action_Result
{
    #region Properties.
    public Params_Generate_District_Demographic_Data Params_Generate_District_Demographic_Data { get; set; }
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
#region Result_Edit_Kpi_List
public partial class Result_Edit_Kpi_List : Action_Result
{
    #region Properties.
    public Params_Edit_Kpi_List Params_Edit_Kpi_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_And_Fill_Public_events_From_Api
public partial class Result_Get_And_Fill_Public_events_From_Api : Action_Result
{
    #region Properties.
    public Params_Get_And_Fill_Public_events_From_Api Params_Get_And_Fill_Public_events_From_Api { get; set; }
    #endregion
}
#endregion
#region Result_Get_And_Fill_Businesses_From_Api
public partial class Result_Get_And_Fill_Businesses_From_Api : Action_Result
{
    #region Properties.
    #endregion
}
#endregion
#region Result_Get_And_Fill_Bylaw_complaints_From_Api
public partial class Result_Get_And_Fill_Bylaw_complaints_From_Api : Action_Result
{
    #region Properties.
    public Params_Get_And_Fill_Bylaw_complaints_From_Api Params_Get_And_Fill_Bylaw_complaints_From_Api { get; set; }
    #endregion
}
#endregion
#region Result_Get_Data_source_By_OWNER_ID
public partial class Result_Get_Data_source_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Data_source> i_Result { get; set; }
    public Params_Get_Data_source_By_OWNER_ID Params_Get_Data_source_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Data_source
public partial class Result_Delete_Data_source : Action_Result
{
    #region Properties.
    public Params_Delete_Data_source Params_Delete_Data_source { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Data_source
public partial class Result_Edit_Data_source : Action_Result
{
    #region Properties.
    public Data_source Data_source { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_data_source_kpi
public partial class Result_Delete_Organization_data_source_kpi : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_data_source_kpi Params_Delete_Organization_data_source_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_data_source_kpi
public partial class Result_Edit_Organization_data_source_kpi : Action_Result
{
    #region Properties.
    public Organization_data_source_kpi Organization_data_source_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Get_Niche_categories_By_Where
public partial class Result_Get_Niche_categories_By_Where : Action_Result
{
    #region Properties.
    public List<Niche_categories> i_Result { get; set; }
    public Params_Get_Niche_categories_By_Where Params_Get_Niche_categories_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Niche_categories_List
public partial class Result_Edit_Niche_categories_List : Action_Result
{
    #region Properties.
    public Params_Edit_Niche_categories_List Params_Edit_Niche_categories_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Niche_categories
public partial class Result_Delete_Niche_categories : Action_Result
{
    #region Properties.
    public Params_Delete_Niche_categories Params_Delete_Niche_categories { get; set; }
    #endregion
}
#endregion
#region Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
public partial class Result_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List : Action_Result
{
    #region Properties.
    public Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List Params_Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Generate_Business_Count_And_Vacant_Business_Count
public partial class Result_Generate_Business_Count_And_Vacant_Business_Count : Action_Result
{
    #region Properties.
    public Params_Generate_Business_Count_And_Vacant_Business_Count Params_Generate_Business_Count_And_Vacant_Business_Count { get; set; }
    #endregion
}
#endregion
#region Result_Extract_Kpi_Data_From_CSV
public partial class Result_Extract_Kpi_Data_From_CSV : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Extract_Kpi_Data_From_CSV Params_Extract_Kpi_Data_From_CSV { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_By_ENTITY_ID_List
public partial class Result_Get_Floor_By_ENTITY_ID_List : Action_Result
{
    #region Properties.
    public List<Floor> i_Result { get; set; }
    public Params_Get_Floor_By_ENTITY_ID_List Params_Get_Floor_By_ENTITY_ID_List { get; set; }
    #endregion
}
#endregion
