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
public partial class FloorManagementController : ControllerBase
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
    #region Get_Floor_By_ENTITY_ID
    [HttpGet]
    [Route("Get_Floor_By_ENTITY_ID")]
    public Result_Get_Floor_By_ENTITY_ID Get_Floor_By_ENTITY_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_By_ENTITY_ID oResult_Get_Floor_By_ENTITY_ID = new Result_Get_Floor_By_ENTITY_ID();
        Params_Get_Floor_By_ENTITY_ID oParams_Get_Floor_By_ENTITY_ID = new Params_Get_Floor_By_ENTITY_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ENTITY_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ENTITY_ID"].ToString() != "undefined" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "null" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Floor_By_ENTITY_ID.ENTITY_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Floor_By_ENTITY_ID.i_Result = oBLC.Get_Floor_By_ENTITY_ID(oParams_Get_Floor_By_ENTITY_ID);
                oResult_Get_Floor_By_ENTITY_ID.Params_Get_Floor_By_ENTITY_ID = oParams_Get_Floor_By_ENTITY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_By_ENTITY_ID.Params_Get_Floor_By_ENTITY_ID = oParams_Get_Floor_By_ENTITY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_By_ENTITY_ID.Exception_Message = string.Format("Get_Floor_By_ENTITY_ID : {0}", ex.Message);
                oResult_Get_Floor_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_By_ENTITY_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_By_ENTITY_ID.Exception_Message = ex.Message;
                oResult_Get_Floor_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_By_ENTITY_ID;
        #endregion
    }
    #endregion
    #region Get_Floor_By_ENTITY_ID_With_Space_Asset
    [HttpGet]
    [Route("Get_Floor_By_ENTITY_ID_With_Space_Asset")]
    public Result_Get_Floor_By_ENTITY_ID_With_Space_Asset Get_Floor_By_ENTITY_ID_With_Space_Asset()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_By_ENTITY_ID_With_Space_Asset oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset = new Result_Get_Floor_By_ENTITY_ID_With_Space_Asset();
        Params_Get_Floor_By_ENTITY_ID_With_Space_Asset oParams_Get_Floor_By_ENTITY_ID_With_Space_Asset = new Params_Get_Floor_By_ENTITY_ID_With_Space_Asset();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ENTITY_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ENTITY_ID"].ToString() != "undefined" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "null" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Floor_By_ENTITY_ID_With_Space_Asset.ENTITY_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.i_Result = oBLC.Get_Floor_By_ENTITY_ID_With_Space_Asset(oParams_Get_Floor_By_ENTITY_ID_With_Space_Asset);
                oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.Params_Get_Floor_By_ENTITY_ID_With_Space_Asset = oParams_Get_Floor_By_ENTITY_ID_With_Space_Asset;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.Params_Get_Floor_By_ENTITY_ID_With_Space_Asset = oParams_Get_Floor_By_ENTITY_ID_With_Space_Asset;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.Exception_Message = string.Format("Get_Floor_By_ENTITY_ID_With_Space_Asset : {0}", ex.Message);
                oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_By_ENTITY_ID_With_Space_Asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.Exception_Message = ex.Message;
                oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_By_ENTITY_ID_With_Space_Asset;
        #endregion
    }
    #endregion
    #region Get_Floor_By_OWNER_ID
    [HttpGet]
    [Route("Get_Floor_By_OWNER_ID")]
    public Result_Get_Floor_By_OWNER_ID Get_Floor_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_By_OWNER_ID oResult_Get_Floor_By_OWNER_ID = new Result_Get_Floor_By_OWNER_ID();
        Params_Get_Floor_By_OWNER_ID oParams_Get_Floor_By_OWNER_ID = new Params_Get_Floor_By_OWNER_ID();
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
                oParams_Get_Floor_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Floor_By_OWNER_ID.i_Result = oBLC.Get_Floor_By_OWNER_ID(oParams_Get_Floor_By_OWNER_ID);
                oResult_Get_Floor_By_OWNER_ID.Params_Get_Floor_By_OWNER_ID = oParams_Get_Floor_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_By_OWNER_ID.Params_Get_Floor_By_OWNER_ID = oParams_Get_Floor_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_By_OWNER_ID.Exception_Message = string.Format("Get_Floor_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Floor_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Floor_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Floor
    [HttpPost]
    [Route("Edit_Floor")]
    public Result_Edit_Floor Edit_Floor(Floor i_Floor)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Floor oResult_Edit_Floor = new Result_Edit_Floor();
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
                oBLC.Edit_Floor(i_Floor);
                oResult_Edit_Floor.Floor = i_Floor;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Floor.Exception_Message = string.Format("Edit_Floor : {0}", ex.Message);
                oResult_Edit_Floor.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Floor : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Floor.Exception_Message = ex.Message;
                oResult_Edit_Floor.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Floor;
        #endregion
    }
    #endregion
    #region Get_Floor_By_ENTITY_ID_Adv
    [HttpGet]
    [Route("Get_Floor_By_ENTITY_ID_Adv")]
    public Result_Get_Floor_By_ENTITY_ID_Adv Get_Floor_By_ENTITY_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Floor_By_ENTITY_ID_Adv oResult_Get_Floor_By_ENTITY_ID_Adv = new Result_Get_Floor_By_ENTITY_ID_Adv();
        Params_Get_Floor_By_ENTITY_ID oParams_Get_Floor_By_ENTITY_ID = new Params_Get_Floor_By_ENTITY_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ENTITY_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ENTITY_ID"].ToString() != "undefined" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "null" && HttpContext.Request.Query["ENTITY_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Floor_By_ENTITY_ID.ENTITY_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Floor_By_ENTITY_ID_Adv.i_Result = oBLC.Get_Floor_By_ENTITY_ID_Adv(oParams_Get_Floor_By_ENTITY_ID);
                oResult_Get_Floor_By_ENTITY_ID_Adv.Params_Get_Floor_By_ENTITY_ID = oParams_Get_Floor_By_ENTITY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Floor_By_ENTITY_ID_Adv.Params_Get_Floor_By_ENTITY_ID = oParams_Get_Floor_By_ENTITY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Floor_By_ENTITY_ID_Adv.Exception_Message = string.Format("Get_Floor_By_ENTITY_ID_Adv : {0}", ex.Message);
                oResult_Get_Floor_By_ENTITY_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Floor_By_ENTITY_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Floor_By_ENTITY_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Floor_By_ENTITY_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Floor_By_ENTITY_ID_Adv;
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
#region Result_Get_Floor_By_ENTITY_ID
public partial class Result_Get_Floor_By_ENTITY_ID : Action_Result
{
    #region Properties.
    public List<Floor> i_Result { get; set; }
    public Params_Get_Floor_By_ENTITY_ID Params_Get_Floor_By_ENTITY_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_By_ENTITY_ID_With_Space_Asset
public partial class Result_Get_Floor_By_ENTITY_ID_With_Space_Asset : Action_Result
{
    #region Properties.
    public List<Floor> i_Result { get; set; }
    public Params_Get_Floor_By_ENTITY_ID_With_Space_Asset Params_Get_Floor_By_ENTITY_ID_With_Space_Asset { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_By_OWNER_ID
public partial class Result_Get_Floor_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Floor> i_Result { get; set; }
    public Params_Get_Floor_By_OWNER_ID Params_Get_Floor_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Floor
public partial class Result_Edit_Floor : Action_Result
{
    #region Properties.
    public Floor Floor { get; set; }
    #endregion
}
#endregion
#region Result_Get_Floor_By_ENTITY_ID_Adv
public partial class Result_Get_Floor_By_ENTITY_ID_Adv : Action_Result
{
    #region Properties.
    public List<Floor> i_Result { get; set; }
    public Params_Get_Floor_By_ENTITY_ID Params_Get_Floor_By_ENTITY_ID { get; set; }
    #endregion
}
#endregion
