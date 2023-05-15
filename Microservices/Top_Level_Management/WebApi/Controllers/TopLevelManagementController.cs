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
public partial class TopLevelManagementController : ControllerBase
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
    #region Edit_Top_level
    [HttpPost]
    [Route("Edit_Top_level")]
    public Result_Edit_Top_level Edit_Top_level(Top_level i_Top_level)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Top_level oResult_Edit_Top_level = new Result_Edit_Top_level();
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
                oBLC.Edit_Top_level(i_Top_level);
                oResult_Edit_Top_level.Top_level = i_Top_level;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Top_level.Exception_Message = string.Format("Edit_Top_level : {0}", ex.Message);
                oResult_Edit_Top_level.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Top_level : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Top_level.Exception_Message = ex.Message;
                oResult_Edit_Top_level.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Top_level;
        #endregion
    }
    #endregion
    #region Get_Top_level_By_TOP_LEVEL_ID_List
    [HttpGet]
    [Route("Get_Top_level_By_TOP_LEVEL_ID_List")]
    public Result_Get_Top_level_By_TOP_LEVEL_ID_List Get_Top_level_By_TOP_LEVEL_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Top_level_By_TOP_LEVEL_ID_List oResult_Get_Top_level_By_TOP_LEVEL_ID_List = new Result_Get_Top_level_By_TOP_LEVEL_ID_List();
        Params_Get_Top_level_By_TOP_LEVEL_ID_List oParams_Get_Top_level_By_TOP_LEVEL_ID_List = new Params_Get_Top_level_By_TOP_LEVEL_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["TOP_LEVEL_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["TOP_LEVEL_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["TOP_LEVEL_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["TOP_LEVEL_ID_LIST"].ToString() != "")
            {
                oParams_Get_Top_level_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST = HttpContext.Request.Query["TOP_LEVEL_ID_LIST"]
																				.ToString()
																				.Split(',')
																				.Where(val => long.TryParse(val, out _))
																				.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Top_level_By_TOP_LEVEL_ID_List.i_Result = oBLC.Get_Top_level_By_TOP_LEVEL_ID_List(oParams_Get_Top_level_By_TOP_LEVEL_ID_List);
                oResult_Get_Top_level_By_TOP_LEVEL_ID_List.Params_Get_Top_level_By_TOP_LEVEL_ID_List = oParams_Get_Top_level_By_TOP_LEVEL_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Top_level_By_TOP_LEVEL_ID_List.Params_Get_Top_level_By_TOP_LEVEL_ID_List = oParams_Get_Top_level_By_TOP_LEVEL_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Top_level_By_TOP_LEVEL_ID_List.Exception_Message = string.Format("Get_Top_level_By_TOP_LEVEL_ID_List : {0}", ex.Message);
                oResult_Get_Top_level_By_TOP_LEVEL_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Top_level_By_TOP_LEVEL_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Top_level_By_TOP_LEVEL_ID_List.Exception_Message = ex.Message;
                oResult_Get_Top_level_By_TOP_LEVEL_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Top_level_By_TOP_LEVEL_ID_List;
        #endregion
    }
    #endregion
    #region Get_Top_level_By_OWNER_ID
    [HttpGet]
    [Route("Get_Top_level_By_OWNER_ID")]
    public Result_Get_Top_level_By_OWNER_ID Get_Top_level_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Top_level_By_OWNER_ID oResult_Get_Top_level_By_OWNER_ID = new Result_Get_Top_level_By_OWNER_ID();
        Params_Get_Top_level_By_OWNER_ID oParams_Get_Top_level_By_OWNER_ID = new Params_Get_Top_level_By_OWNER_ID();
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
                oParams_Get_Top_level_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Top_level_By_OWNER_ID.i_Result = oBLC.Get_Top_level_By_OWNER_ID(oParams_Get_Top_level_By_OWNER_ID);
                oResult_Get_Top_level_By_OWNER_ID.Params_Get_Top_level_By_OWNER_ID = oParams_Get_Top_level_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Top_level_By_OWNER_ID.Params_Get_Top_level_By_OWNER_ID = oParams_Get_Top_level_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Top_level_By_OWNER_ID.Exception_Message = string.Format("Get_Top_level_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Top_level_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Top_level_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Top_level_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Top_level_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Top_level_By_OWNER_ID;
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
#region Result_Edit_Top_level
public partial class Result_Edit_Top_level : Action_Result
{
    #region Properties.
    public Top_level Top_level { get; set; }
    #endregion
}
#endregion
#region Result_Get_Top_level_By_TOP_LEVEL_ID_List
public partial class Result_Get_Top_level_By_TOP_LEVEL_ID_List : Action_Result
{
    #region Properties.
    public List<Top_level> i_Result { get; set; }
    public Params_Get_Top_level_By_TOP_LEVEL_ID_List Params_Get_Top_level_By_TOP_LEVEL_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Top_level_By_OWNER_ID
public partial class Result_Get_Top_level_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Top_level> i_Result { get; set; }
    public Params_Get_Top_level_By_OWNER_ID Params_Get_Top_level_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
