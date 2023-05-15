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
public partial class MethodMonitoringController : ControllerBase
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
    #region Get_Method_run_By_METHOD_RUN_ID
    [HttpPost]
    [Route("Get_Method_run_By_METHOD_RUN_ID")]
    public Result_Get_Method_run_By_METHOD_RUN_ID Get_Method_run_By_METHOD_RUN_ID(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Method_run_By_METHOD_RUN_ID oResult_Get_Method_run_By_METHOD_RUN_ID = new Result_Get_Method_run_By_METHOD_RUN_ID();
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
                oResult_Get_Method_run_By_METHOD_RUN_ID.i_Result = oBLC.Get_Method_run_By_METHOD_RUN_ID(i_Params_Get_Method_run_By_METHOD_RUN_ID);
                oResult_Get_Method_run_By_METHOD_RUN_ID.Params_Get_Method_run_By_METHOD_RUN_ID = i_Params_Get_Method_run_By_METHOD_RUN_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Method_run_By_METHOD_RUN_ID.Params_Get_Method_run_By_METHOD_RUN_ID = i_Params_Get_Method_run_By_METHOD_RUN_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Method_run_By_METHOD_RUN_ID.Exception_Message = string.Format("Get_Method_run_By_METHOD_RUN_ID : {0}", ex.Message);
                oResult_Get_Method_run_By_METHOD_RUN_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Method_run_By_METHOD_RUN_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Method_run_By_METHOD_RUN_ID.Exception_Message = ex.Message;
                oResult_Get_Method_run_By_METHOD_RUN_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Method_run_By_METHOD_RUN_ID;
        #endregion
    }
    #endregion
    #region Get_Method_run_By_METHOD_RUN_ID_List
    [HttpPost]
    [Route("Get_Method_run_By_METHOD_RUN_ID_List")]
    public Result_Get_Method_run_By_METHOD_RUN_ID_List Get_Method_run_By_METHOD_RUN_ID_List(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Method_run_By_METHOD_RUN_ID_List oResult_Get_Method_run_By_METHOD_RUN_ID_List = new Result_Get_Method_run_By_METHOD_RUN_ID_List();
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
                oResult_Get_Method_run_By_METHOD_RUN_ID_List.i_Result = oBLC.Get_Method_run_By_METHOD_RUN_ID_List(i_Params_Get_Method_run_By_METHOD_RUN_ID_List);
                oResult_Get_Method_run_By_METHOD_RUN_ID_List.Params_Get_Method_run_By_METHOD_RUN_ID_List = i_Params_Get_Method_run_By_METHOD_RUN_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Method_run_By_METHOD_RUN_ID_List.Params_Get_Method_run_By_METHOD_RUN_ID_List = i_Params_Get_Method_run_By_METHOD_RUN_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Method_run_By_METHOD_RUN_ID_List.Exception_Message = string.Format("Get_Method_run_By_METHOD_RUN_ID_List : {0}", ex.Message);
                oResult_Get_Method_run_By_METHOD_RUN_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Method_run_By_METHOD_RUN_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Method_run_By_METHOD_RUN_ID_List.Exception_Message = ex.Message;
                oResult_Get_Method_run_By_METHOD_RUN_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Method_run_By_METHOD_RUN_ID_List;
        #endregion
    }
    #endregion
    #region Get_Method_run_By_OWNER_ID
    [HttpPost]
    [Route("Get_Method_run_By_OWNER_ID")]
    public Result_Get_Method_run_By_OWNER_ID Get_Method_run_By_OWNER_ID(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Method_run_By_OWNER_ID oResult_Get_Method_run_By_OWNER_ID = new Result_Get_Method_run_By_OWNER_ID();
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
                oResult_Get_Method_run_By_OWNER_ID.i_Result = oBLC.Get_Method_run_By_OWNER_ID(i_Params_Get_Method_run_By_OWNER_ID);
                oResult_Get_Method_run_By_OWNER_ID.Params_Get_Method_run_By_OWNER_ID = i_Params_Get_Method_run_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Method_run_By_OWNER_ID.Params_Get_Method_run_By_OWNER_ID = i_Params_Get_Method_run_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Method_run_By_OWNER_ID.Exception_Message = string.Format("Get_Method_run_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Method_run_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Method_run_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Method_run_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Method_run_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Method_run_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Method_run_By_OWNER_ID_IS_DELETED
    [HttpPost]
    [Route("Get_Method_run_By_OWNER_ID_IS_DELETED")]
    public Result_Get_Method_run_By_OWNER_ID_IS_DELETED Get_Method_run_By_OWNER_ID_IS_DELETED(Params_Get_Method_run_By_OWNER_ID_IS_DELETED i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Method_run_By_OWNER_ID_IS_DELETED oResult_Get_Method_run_By_OWNER_ID_IS_DELETED = new Result_Get_Method_run_By_OWNER_ID_IS_DELETED();
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
                oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.i_Result = oBLC.Get_Method_run_By_OWNER_ID_IS_DELETED(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED);
                oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.Params_Get_Method_run_By_OWNER_ID_IS_DELETED = i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.Params_Get_Method_run_By_OWNER_ID_IS_DELETED = i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.Exception_Message = string.Format("Get_Method_run_By_OWNER_ID_IS_DELETED : {0}", ex.Message);
                oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.Stack_Trace = is_send_stack_trace ? string.Format("Get_Method_run_By_OWNER_ID_IS_DELETED : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.Exception_Message = ex.Message;
                oResult_Get_Method_run_By_OWNER_ID_IS_DELETED.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Method_run_By_OWNER_ID_IS_DELETED;
        #endregion
    }
    #endregion
    #region Get_Method_run_By_Where
    [HttpPost]
    [Route("Get_Method_run_By_Where")]
    public Result_Get_Method_run_By_Where Get_Method_run_By_Where(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Method_run_By_Where oResult_Get_Method_run_By_Where = new Result_Get_Method_run_By_Where();
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
                oResult_Get_Method_run_By_Where.i_Result = oBLC.Get_Method_run_By_Where(i_Params_Get_Method_run_By_Where);
                oResult_Get_Method_run_By_Where.Params_Get_Method_run_By_Where = i_Params_Get_Method_run_By_Where;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Method_run_By_Where.Params_Get_Method_run_By_Where = i_Params_Get_Method_run_By_Where;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Method_run_By_Where.Exception_Message = string.Format("Get_Method_run_By_Where : {0}", ex.Message);
                oResult_Get_Method_run_By_Where.Stack_Trace = is_send_stack_trace ? string.Format("Get_Method_run_By_Where : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Method_run_By_Where.Exception_Message = ex.Message;
                oResult_Get_Method_run_By_Where.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Method_run_By_Where;
        #endregion
    }
    #endregion
    #region Delete_Method_run
    [HttpPost]
    [Route("Delete_Method_run")]
    public Result_Delete_Method_run Delete_Method_run(Params_Delete_Method_run i_Params_Delete_Method_run)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Method_run oResult_Delete_Method_run = new Result_Delete_Method_run();
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
                oBLC.Delete_Method_run(i_Params_Delete_Method_run);
                oResult_Delete_Method_run.Params_Delete_Method_run = i_Params_Delete_Method_run;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Method_run.Params_Delete_Method_run = i_Params_Delete_Method_run;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Method_run.Exception_Message = string.Format("Delete_Method_run : {0}", ex.Message);
                oResult_Delete_Method_run.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Method_run : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Method_run.Exception_Message = ex.Message;
                oResult_Delete_Method_run.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Method_run;
        #endregion
    }
    #endregion
    #region Delete_Method_run_By_OWNER_ID
    [HttpPost]
    [Route("Delete_Method_run_By_OWNER_ID")]
    public Result_Delete_Method_run_By_OWNER_ID Delete_Method_run_By_OWNER_ID(Params_Delete_Method_run_By_OWNER_ID i_Params_Delete_Method_run_By_OWNER_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Method_run_By_OWNER_ID oResult_Delete_Method_run_By_OWNER_ID = new Result_Delete_Method_run_By_OWNER_ID();
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
                oBLC.Delete_Method_run_By_OWNER_ID(i_Params_Delete_Method_run_By_OWNER_ID);
                oResult_Delete_Method_run_By_OWNER_ID.Params_Delete_Method_run_By_OWNER_ID = i_Params_Delete_Method_run_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Method_run_By_OWNER_ID.Params_Delete_Method_run_By_OWNER_ID = i_Params_Delete_Method_run_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Method_run_By_OWNER_ID.Exception_Message = string.Format("Delete_Method_run_By_OWNER_ID : {0}", ex.Message);
                oResult_Delete_Method_run_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Method_run_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Method_run_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Delete_Method_run_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Method_run_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Delete_Method_run_By_OWNER_ID_IS_DELETED
    [HttpPost]
    [Route("Delete_Method_run_By_OWNER_ID_IS_DELETED")]
    public Result_Delete_Method_run_By_OWNER_ID_IS_DELETED Delete_Method_run_By_OWNER_ID_IS_DELETED(Params_Delete_Method_run_By_OWNER_ID_IS_DELETED i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Method_run_By_OWNER_ID_IS_DELETED oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED = new Result_Delete_Method_run_By_OWNER_ID_IS_DELETED();
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
                oBLC.Delete_Method_run_By_OWNER_ID_IS_DELETED(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED);
                oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED.Params_Delete_Method_run_By_OWNER_ID_IS_DELETED = i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED.Params_Delete_Method_run_By_OWNER_ID_IS_DELETED = i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED.Exception_Message = string.Format("Delete_Method_run_By_OWNER_ID_IS_DELETED : {0}", ex.Message);
                oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Method_run_By_OWNER_ID_IS_DELETED : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED.Exception_Message = ex.Message;
                oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Method_run_By_OWNER_ID_IS_DELETED;
        #endregion
    }
    #endregion
    #region Edit_Method_run
    [HttpPost]
    [Route("Edit_Method_run")]
    public Result_Edit_Method_run Edit_Method_run(Method_run i_Method_run)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Method_run oResult_Edit_Method_run = new Result_Edit_Method_run();
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
                oBLC.Edit_Method_run(i_Method_run);
                oResult_Edit_Method_run.Method_run = i_Method_run;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Method_run.Method_run = i_Method_run;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Method_run.Exception_Message = string.Format("Edit_Method_run : {0}", ex.Message);
                oResult_Edit_Method_run.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Method_run : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Method_run.Exception_Message = ex.Message;
                oResult_Edit_Method_run.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Method_run;
        #endregion
    }
    #endregion
    #region Edit_Method_run_List
    [HttpPost]
    [Route("Edit_Method_run_List")]
    public Result_Edit_Method_run_List Edit_Method_run_List(Params_Edit_Method_run_List i_Params_Edit_Method_run_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Method_run_List oResult_Edit_Method_run_List = new Result_Edit_Method_run_List();
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
                oBLC.Edit_Method_run_List(i_Params_Edit_Method_run_List);
                oResult_Edit_Method_run_List.Params_Edit_Method_run_List = i_Params_Edit_Method_run_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Method_run_List.Params_Edit_Method_run_List = i_Params_Edit_Method_run_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Method_run_List.Exception_Message = string.Format("Edit_Method_run_List : {0}", ex.Message);
                oResult_Edit_Method_run_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Method_run_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Method_run_List.Exception_Message = ex.Message;
                oResult_Edit_Method_run_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Method_run_List;
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
#region Result_Get_Method_run_By_METHOD_RUN_ID
public partial class Result_Get_Method_run_By_METHOD_RUN_ID : Action_Result
{
    #region Properties.
    public Method_run i_Result { get; set; }
    public Params_Get_Method_run_By_METHOD_RUN_ID Params_Get_Method_run_By_METHOD_RUN_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Method_run_By_METHOD_RUN_ID_List
public partial class Result_Get_Method_run_By_METHOD_RUN_ID_List : Action_Result
{
    #region Properties.
    public List<Method_run> i_Result { get; set; }
    public Params_Get_Method_run_By_METHOD_RUN_ID_List Params_Get_Method_run_By_METHOD_RUN_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Method_run_By_OWNER_ID
public partial class Result_Get_Method_run_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Method_run> i_Result { get; set; }
    public Params_Get_Method_run_By_OWNER_ID Params_Get_Method_run_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Method_run_By_OWNER_ID_IS_DELETED
public partial class Result_Get_Method_run_By_OWNER_ID_IS_DELETED : Action_Result
{
    #region Properties.
    public List<Method_run> i_Result { get; set; }
    public Params_Get_Method_run_By_OWNER_ID_IS_DELETED Params_Get_Method_run_By_OWNER_ID_IS_DELETED { get; set; }
    #endregion
}
#endregion
#region Result_Get_Method_run_By_Where
public partial class Result_Get_Method_run_By_Where : Action_Result
{
    #region Properties.
    public List<Method_run> i_Result { get; set; }
    public Params_Get_Method_run_By_Where Params_Get_Method_run_By_Where { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Method_run
public partial class Result_Delete_Method_run : Action_Result
{
    #region Properties.
    public Params_Delete_Method_run Params_Delete_Method_run { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Method_run_By_OWNER_ID
public partial class Result_Delete_Method_run_By_OWNER_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Method_run_By_OWNER_ID Params_Delete_Method_run_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Method_run_By_OWNER_ID_IS_DELETED
public partial class Result_Delete_Method_run_By_OWNER_ID_IS_DELETED : Action_Result
{
    #region Properties.
    public Params_Delete_Method_run_By_OWNER_ID_IS_DELETED Params_Delete_Method_run_By_OWNER_ID_IS_DELETED { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Method_run
public partial class Result_Edit_Method_run : Action_Result
{
    #region Properties.
    public Method_run Method_run { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Method_run_List
public partial class Result_Edit_Method_run_List : Action_Result
{
    #region Properties.
    public Params_Edit_Method_run_List Params_Edit_Method_run_List { get; set; }
    #endregion
}
#endregion
