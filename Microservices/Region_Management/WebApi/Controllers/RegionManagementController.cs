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
public partial class RegionManagementController : ControllerBase
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
    #region Edit_Region
    [HttpPost]
    [Route("Edit_Region")]
    public Result_Edit_Region Edit_Region(Region i_Region)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Region oResult_Edit_Region = new Result_Edit_Region();
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
                oBLC.Edit_Region(i_Region);
                oResult_Edit_Region.Region = i_Region;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Region.Exception_Message = string.Format("Edit_Region : {0}", ex.Message);
                oResult_Edit_Region.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Region : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Region.Exception_Message = ex.Message;
                oResult_Edit_Region.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Region;
        #endregion
    }
    #endregion
    #region Get_Region_By_OWNER_ID
    [HttpGet]
    [Route("Get_Region_By_OWNER_ID")]
    public Result_Get_Region_By_OWNER_ID Get_Region_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Region_By_OWNER_ID oResult_Get_Region_By_OWNER_ID = new Result_Get_Region_By_OWNER_ID();
        Params_Get_Region_By_OWNER_ID oParams_Get_Region_By_OWNER_ID = new Params_Get_Region_By_OWNER_ID();
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
                oParams_Get_Region_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Region_By_OWNER_ID.i_Result = oBLC.Get_Region_By_OWNER_ID(oParams_Get_Region_By_OWNER_ID);
                oResult_Get_Region_By_OWNER_ID.Params_Get_Region_By_OWNER_ID = oParams_Get_Region_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Region_By_OWNER_ID.Params_Get_Region_By_OWNER_ID = oParams_Get_Region_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Region_By_OWNER_ID.Exception_Message = string.Format("Get_Region_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Region_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Region_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Region_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Region_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Region_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Region_view
    [HttpPost]
    [Route("Edit_Region_view")]
    public Result_Edit_Region_view Edit_Region_view(Region_view i_Region_view)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Region_view oResult_Edit_Region_view = new Result_Edit_Region_view();
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
                oBLC.Edit_Region_view(i_Region_view);
                oResult_Edit_Region_view.Region_view = i_Region_view;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Region_view.Exception_Message = string.Format("Edit_Region_view : {0}", ex.Message);
                oResult_Edit_Region_view.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Region_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Region_view.Exception_Message = ex.Message;
                oResult_Edit_Region_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Region_view;
        #endregion
    }
    #endregion
    #region Delete_Region_view
    [HttpPost]
    [Route("Delete_Region_view")]
    public Result_Delete_Region_view Delete_Region_view(Params_Delete_Region_view i_Params_Delete_Region_view)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Region_view oResult_Delete_Region_view = new Result_Delete_Region_view();
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
                oBLC.Delete_Region_view(i_Params_Delete_Region_view);
                oResult_Delete_Region_view.Params_Delete_Region_view = i_Params_Delete_Region_view;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Region_view.Params_Delete_Region_view = i_Params_Delete_Region_view;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Region_view.Exception_Message = string.Format("Delete_Region_view : {0}", ex.Message);
                oResult_Delete_Region_view.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Region_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Region_view.Exception_Message = ex.Message;
                oResult_Delete_Region_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Region_view;
        #endregion
    }
    #endregion
    #region Get_Region_view_By_REGION_ID
    [HttpGet]
    [Route("Get_Region_view_By_REGION_ID")]
    public Result_Get_Region_view_By_REGION_ID Get_Region_view_By_REGION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Region_view_By_REGION_ID oResult_Get_Region_view_By_REGION_ID = new Result_Get_Region_view_By_REGION_ID();
        Params_Get_Region_view_By_REGION_ID oParams_Get_Region_view_By_REGION_ID = new Params_Get_Region_view_By_REGION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["REGION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["REGION_ID"].ToString() != "undefined" && HttpContext.Request.Query["REGION_ID"].ToString() != "null" && HttpContext.Request.Query["REGION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Region_view_By_REGION_ID.REGION_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["REGION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Region_view_By_REGION_ID.i_Result = oBLC.Get_Region_view_By_REGION_ID(oParams_Get_Region_view_By_REGION_ID);
                oResult_Get_Region_view_By_REGION_ID.Params_Get_Region_view_By_REGION_ID = oParams_Get_Region_view_By_REGION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Region_view_By_REGION_ID.Params_Get_Region_view_By_REGION_ID = oParams_Get_Region_view_By_REGION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Region_view_By_REGION_ID.Exception_Message = string.Format("Get_Region_view_By_REGION_ID : {0}", ex.Message);
                oResult_Get_Region_view_By_REGION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Region_view_By_REGION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Region_view_By_REGION_ID.Exception_Message = ex.Message;
                oResult_Get_Region_view_By_REGION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Region_view_By_REGION_ID;
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
#region Result_Edit_Region
public partial class Result_Edit_Region : Action_Result
{
    #region Properties.
    public Region Region { get; set; }
    #endregion
}
#endregion
#region Result_Get_Region_By_OWNER_ID
public partial class Result_Get_Region_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Region> i_Result { get; set; }
    public Params_Get_Region_By_OWNER_ID Params_Get_Region_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Region_view
public partial class Result_Edit_Region_view : Action_Result
{
    #region Properties.
    public Region_view Region_view { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Region_view
public partial class Result_Delete_Region_view : Action_Result
{
    #region Properties.
    public Params_Delete_Region_view Params_Delete_Region_view { get; set; }
    #endregion
}
#endregion
#region Result_Get_Region_view_By_REGION_ID
public partial class Result_Get_Region_view_By_REGION_ID : Action_Result
{
    #region Properties.
    public List<Region_view> i_Result { get; set; }
    public Params_Get_Region_view_By_REGION_ID Params_Get_Region_view_By_REGION_ID { get; set; }
    #endregion
}
#endregion