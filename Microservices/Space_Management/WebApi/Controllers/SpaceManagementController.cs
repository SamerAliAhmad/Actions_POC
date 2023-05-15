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
public partial class SpaceManagementController : ControllerBase
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
    #region Edit_Space
    [HttpPost]
    [Route("Edit_Space")]
    public Result_Edit_Space Edit_Space(Space i_Space)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Space oResult_Edit_Space = new Result_Edit_Space();
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
                oBLC.Edit_Space(i_Space);
                oResult_Edit_Space.Space = i_Space;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Space.Exception_Message = string.Format("Edit_Space : {0}", ex.Message);
                oResult_Edit_Space.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Space : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Space.Exception_Message = ex.Message;
                oResult_Edit_Space.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Space;
        #endregion
    }
    #endregion
    #region Get_Space_asset_By_SPACE_ID_List_Adv
    [HttpGet]
    [Route("Get_Space_asset_By_SPACE_ID_List_Adv")]
    public Result_Get_Space_asset_By_SPACE_ID_List_Adv Get_Space_asset_By_SPACE_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_asset_By_SPACE_ID_List_Adv oResult_Get_Space_asset_By_SPACE_ID_List_Adv = new Result_Get_Space_asset_By_SPACE_ID_List_Adv();
        Params_Get_Space_asset_By_SPACE_ID_List oParams_Get_Space_asset_By_SPACE_ID_List = new Params_Get_Space_asset_By_SPACE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SPACE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SPACE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST = HttpContext.Request.Query["SPACE_ID_LIST"]
																			.ToString()
																			.Split(',')
																			.Where(val => long.TryParse(val, out _))
																			.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_asset_By_SPACE_ID_List_Adv.i_Result = oBLC.Get_Space_asset_By_SPACE_ID_List_Adv(oParams_Get_Space_asset_By_SPACE_ID_List);
                oResult_Get_Space_asset_By_SPACE_ID_List_Adv.Params_Get_Space_asset_By_SPACE_ID_List = oParams_Get_Space_asset_By_SPACE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_asset_By_SPACE_ID_List_Adv.Params_Get_Space_asset_By_SPACE_ID_List = oParams_Get_Space_asset_By_SPACE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_asset_By_SPACE_ID_List_Adv.Exception_Message = string.Format("Get_Space_asset_By_SPACE_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Space_asset_By_SPACE_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_asset_By_SPACE_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_asset_By_SPACE_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Space_asset_By_SPACE_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_asset_By_SPACE_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_Space_By_OWNER_ID
    [HttpGet]
    [Route("Get_Space_By_OWNER_ID")]
    public Result_Get_Space_By_OWNER_ID Get_Space_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_By_OWNER_ID oResult_Get_Space_By_OWNER_ID = new Result_Get_Space_By_OWNER_ID();
        Params_Get_Space_By_OWNER_ID oParams_Get_Space_By_OWNER_ID = new Params_Get_Space_By_OWNER_ID();
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
                oParams_Get_Space_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_By_OWNER_ID.i_Result = oBLC.Get_Space_By_OWNER_ID(oParams_Get_Space_By_OWNER_ID);
                oResult_Get_Space_By_OWNER_ID.Params_Get_Space_By_OWNER_ID = oParams_Get_Space_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_By_OWNER_ID.Params_Get_Space_By_OWNER_ID = oParams_Get_Space_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_By_OWNER_ID.Exception_Message = string.Format("Get_Space_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Space_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Space_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Space_asset
    [HttpPost]
    [Route("Edit_Space_asset")]
    public Result_Edit_Space_asset Edit_Space_asset(Space_asset i_Space_asset)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Space_asset oResult_Edit_Space_asset = new Result_Edit_Space_asset();
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
                oBLC.Edit_Space_asset(i_Space_asset);
                oResult_Edit_Space_asset.Space_asset = i_Space_asset;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Space_asset.Exception_Message = string.Format("Edit_Space_asset : {0}", ex.Message);
                oResult_Edit_Space_asset.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Space_asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Space_asset.Exception_Message = ex.Message;
                oResult_Edit_Space_asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Space_asset;
        #endregion
    }
    #endregion
    #region Edit_Space_List
    [HttpPost]
    [Route("Edit_Space_List")]
    public Result_Edit_Space_List Edit_Space_List(Params_Edit_Space_List i_Params_Edit_Space_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Space_List oResult_Edit_Space_List = new Result_Edit_Space_List();
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
                oBLC.Edit_Space_List(i_Params_Edit_Space_List);
                oResult_Edit_Space_List.Params_Edit_Space_List = i_Params_Edit_Space_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Space_List.Exception_Message = string.Format("Edit_Space_List : {0}", ex.Message);
                oResult_Edit_Space_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Space_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Space_List.Exception_Message = ex.Message;
                oResult_Edit_Space_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Space_List;
        #endregion
    }
    #endregion
    #region Get_Space_asset_By_SPACE_ID_Adv
    [HttpGet]
    [Route("Get_Space_asset_By_SPACE_ID_Adv")]
    public Result_Get_Space_asset_By_SPACE_ID_Adv Get_Space_asset_By_SPACE_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_asset_By_SPACE_ID_Adv oResult_Get_Space_asset_By_SPACE_ID_Adv = new Result_Get_Space_asset_By_SPACE_ID_Adv();
        Params_Get_Space_asset_By_SPACE_ID oParams_Get_Space_asset_By_SPACE_ID = new Params_Get_Space_asset_By_SPACE_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SPACE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ID"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ID"].ToString() != "null" && HttpContext.Request.Query["SPACE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Space_asset_By_SPACE_ID.SPACE_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SPACE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_asset_By_SPACE_ID_Adv.i_Result = oBLC.Get_Space_asset_By_SPACE_ID_Adv(oParams_Get_Space_asset_By_SPACE_ID);
                oResult_Get_Space_asset_By_SPACE_ID_Adv.Params_Get_Space_asset_By_SPACE_ID = oParams_Get_Space_asset_By_SPACE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_asset_By_SPACE_ID_Adv.Params_Get_Space_asset_By_SPACE_ID = oParams_Get_Space_asset_By_SPACE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_asset_By_SPACE_ID_Adv.Exception_Message = string.Format("Get_Space_asset_By_SPACE_ID_Adv : {0}", ex.Message);
                oResult_Get_Space_asset_By_SPACE_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_asset_By_SPACE_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_asset_By_SPACE_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Space_asset_By_SPACE_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_asset_By_SPACE_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Space_By_FLOOR_ID
    [HttpGet]
    [Route("Get_Space_By_FLOOR_ID")]
    public Result_Get_Space_By_FLOOR_ID Get_Space_By_FLOOR_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_By_FLOOR_ID oResult_Get_Space_By_FLOOR_ID = new Result_Get_Space_By_FLOOR_ID();
        Params_Get_Space_By_FLOOR_ID oParams_Get_Space_By_FLOOR_ID = new Params_Get_Space_By_FLOOR_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["FLOOR_ID"].FirstOrDefault() != null && HttpContext.Request.Query["FLOOR_ID"].ToString() != "undefined" && HttpContext.Request.Query["FLOOR_ID"].ToString() != "null" && HttpContext.Request.Query["FLOOR_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Space_By_FLOOR_ID.FLOOR_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["FLOOR_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_By_FLOOR_ID.i_Result = oBLC.Get_Space_By_FLOOR_ID(oParams_Get_Space_By_FLOOR_ID);
                oResult_Get_Space_By_FLOOR_ID.Params_Get_Space_By_FLOOR_ID = oParams_Get_Space_By_FLOOR_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_By_FLOOR_ID.Params_Get_Space_By_FLOOR_ID = oParams_Get_Space_By_FLOOR_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_By_FLOOR_ID.Exception_Message = string.Format("Get_Space_By_FLOOR_ID : {0}", ex.Message);
                oResult_Get_Space_By_FLOOR_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_By_FLOOR_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_By_FLOOR_ID.Exception_Message = ex.Message;
                oResult_Get_Space_By_FLOOR_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_By_FLOOR_ID;
        #endregion
    }
    #endregion
    #region Get_Space_asset_By_SPACE_ID_List
    [HttpGet]
    [Route("Get_Space_asset_By_SPACE_ID_List")]
    public Result_Get_Space_asset_By_SPACE_ID_List Get_Space_asset_By_SPACE_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_asset_By_SPACE_ID_List oResult_Get_Space_asset_By_SPACE_ID_List = new Result_Get_Space_asset_By_SPACE_ID_List();
        Params_Get_Space_asset_By_SPACE_ID_List oParams_Get_Space_asset_By_SPACE_ID_List = new Params_Get_Space_asset_By_SPACE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SPACE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SPACE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST = HttpContext.Request.Query["SPACE_ID_LIST"]
																			.ToString()
																			.Split(',')
																			.Where(val => long.TryParse(val, out _))
																			.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_asset_By_SPACE_ID_List.i_Result = oBLC.Get_Space_asset_By_SPACE_ID_List(oParams_Get_Space_asset_By_SPACE_ID_List);
                oResult_Get_Space_asset_By_SPACE_ID_List.Params_Get_Space_asset_By_SPACE_ID_List = oParams_Get_Space_asset_By_SPACE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_asset_By_SPACE_ID_List.Params_Get_Space_asset_By_SPACE_ID_List = oParams_Get_Space_asset_By_SPACE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_asset_By_SPACE_ID_List.Exception_Message = string.Format("Get_Space_asset_By_SPACE_ID_List : {0}", ex.Message);
                oResult_Get_Space_asset_By_SPACE_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_asset_By_SPACE_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_asset_By_SPACE_ID_List.Exception_Message = ex.Message;
                oResult_Get_Space_asset_By_SPACE_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_asset_By_SPACE_ID_List;
        #endregion
    }
    #endregion
    #region Get_Space_asset_By_SPACE_ASSET_ID_List_Adv
    [HttpGet]
    [Route("Get_Space_asset_By_SPACE_ASSET_ID_List_Adv")]
    public Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv Get_Space_asset_By_SPACE_ASSET_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv = new Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv();
        Params_Get_Space_asset_By_SPACE_ASSET_ID_List oParams_Get_Space_asset_By_SPACE_ASSET_ID_List = new Params_Get_Space_asset_By_SPACE_ASSET_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "")
            {
                oParams_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST = HttpContext.Request.Query["SPACE_ASSET_ID_LIST"]
																						.ToString()
																						.Split(',')
																						.Where(val => long.TryParse(val, out _))
																						.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.i_Result = oBLC.Get_Space_asset_By_SPACE_ASSET_ID_List_Adv(oParams_Get_Space_asset_By_SPACE_ASSET_ID_List);
                oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.Params_Get_Space_asset_By_SPACE_ASSET_ID_List = oParams_Get_Space_asset_By_SPACE_ASSET_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.Params_Get_Space_asset_By_SPACE_ASSET_ID_List = oParams_Get_Space_asset_By_SPACE_ASSET_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.Exception_Message = string.Format("Get_Space_asset_By_SPACE_ASSET_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_asset_By_SPACE_ASSET_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Edit_Space_asset_List
    [HttpPost]
    [Route("Edit_Space_asset_List")]
    public Result_Edit_Space_asset_List Edit_Space_asset_List(Params_Edit_Space_asset_List i_Params_Edit_Space_asset_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Space_asset_List oResult_Edit_Space_asset_List = new Result_Edit_Space_asset_List();
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
                oBLC.Edit_Space_asset_List(i_Params_Edit_Space_asset_List);
                oResult_Edit_Space_asset_List.Params_Edit_Space_asset_List = i_Params_Edit_Space_asset_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Space_asset_List.Exception_Message = string.Format("Edit_Space_asset_List : {0}", ex.Message);
                oResult_Edit_Space_asset_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Space_asset_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Space_asset_List.Exception_Message = ex.Message;
                oResult_Edit_Space_asset_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Space_asset_List;
        #endregion
    }
    #endregion
    #region Get_Space_asset_By_SPACE_ID
    [HttpGet]
    [Route("Get_Space_asset_By_SPACE_ID")]
    public Result_Get_Space_asset_By_SPACE_ID Get_Space_asset_By_SPACE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Space_asset_By_SPACE_ID oResult_Get_Space_asset_By_SPACE_ID = new Result_Get_Space_asset_By_SPACE_ID();
        Params_Get_Space_asset_By_SPACE_ID oParams_Get_Space_asset_By_SPACE_ID = new Params_Get_Space_asset_By_SPACE_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SPACE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ID"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ID"].ToString() != "null" && HttpContext.Request.Query["SPACE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Space_asset_By_SPACE_ID.SPACE_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SPACE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Space_asset_By_SPACE_ID.i_Result = oBLC.Get_Space_asset_By_SPACE_ID(oParams_Get_Space_asset_By_SPACE_ID);
                oResult_Get_Space_asset_By_SPACE_ID.Params_Get_Space_asset_By_SPACE_ID = oParams_Get_Space_asset_By_SPACE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Space_asset_By_SPACE_ID.Params_Get_Space_asset_By_SPACE_ID = oParams_Get_Space_asset_By_SPACE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Space_asset_By_SPACE_ID.Exception_Message = string.Format("Get_Space_asset_By_SPACE_ID : {0}", ex.Message);
                oResult_Get_Space_asset_By_SPACE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Space_asset_By_SPACE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Space_asset_By_SPACE_ID.Exception_Message = ex.Message;
                oResult_Get_Space_asset_By_SPACE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Space_asset_By_SPACE_ID;
        #endregion
    }
    #endregion
    #region Delete_Space_asset_By_SPACE_ID
    [HttpPost]
    [Route("Delete_Space_asset_By_SPACE_ID")]
    public Result_Delete_Space_asset_By_SPACE_ID Delete_Space_asset_By_SPACE_ID(Params_Delete_Space_asset_By_SPACE_ID i_Params_Delete_Space_asset_By_SPACE_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Space_asset_By_SPACE_ID oResult_Delete_Space_asset_By_SPACE_ID = new Result_Delete_Space_asset_By_SPACE_ID();
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
                oBLC.Delete_Space_asset_By_SPACE_ID(i_Params_Delete_Space_asset_By_SPACE_ID);
                oResult_Delete_Space_asset_By_SPACE_ID.Params_Delete_Space_asset_By_SPACE_ID = i_Params_Delete_Space_asset_By_SPACE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Space_asset_By_SPACE_ID.Params_Delete_Space_asset_By_SPACE_ID = i_Params_Delete_Space_asset_By_SPACE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Space_asset_By_SPACE_ID.Exception_Message = string.Format("Delete_Space_asset_By_SPACE_ID : {0}", ex.Message);
                oResult_Delete_Space_asset_By_SPACE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Space_asset_By_SPACE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Space_asset_By_SPACE_ID.Exception_Message = ex.Message;
                oResult_Delete_Space_asset_By_SPACE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Space_asset_By_SPACE_ID;
        #endregion
    }
    #endregion
    #region Get_Video_ai_asset_By_SPACE_ASSET_ID_List
    [HttpGet]
    [Route("Get_Video_ai_asset_By_SPACE_ASSET_ID_List")]
    public Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List Get_Video_ai_asset_By_SPACE_ASSET_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = new Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List();
        Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = new Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SPACE_ASSET_ID_LIST"].ToString() != "")
            {
                oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST = HttpContext.Request.Query["SPACE_ASSET_ID_LIST"]
																						.ToString()
																						.Split(',')
																						.Where(val => long.TryParse(val, out _))
																						.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.i_Result = oBLC.Get_Video_ai_asset_By_SPACE_ASSET_ID_List(oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List);
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List = oParams_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.Exception_Message = string.Format("Get_Video_ai_asset_By_SPACE_ASSET_ID_List : {0}", ex.Message);
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Video_ai_asset_By_SPACE_ASSET_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.Exception_Message = ex.Message;
                oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Video_ai_asset_By_SPACE_ASSET_ID_List;
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
#region Result_Edit_Space
public partial class Result_Edit_Space : Action_Result
{
    #region Properties.
    public Space Space { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_asset_By_SPACE_ID_List_Adv
public partial class Result_Get_Space_asset_By_SPACE_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Space_asset> i_Result { get; set; }
    public Params_Get_Space_asset_By_SPACE_ID_List Params_Get_Space_asset_By_SPACE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_By_OWNER_ID
public partial class Result_Get_Space_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Space> i_Result { get; set; }
    public Params_Get_Space_By_OWNER_ID Params_Get_Space_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Space_asset
public partial class Result_Edit_Space_asset : Action_Result
{
    #region Properties.
    public Space_asset Space_asset { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Space_List
public partial class Result_Edit_Space_List : Action_Result
{
    #region Properties.
    public Params_Edit_Space_List Params_Edit_Space_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_asset_By_SPACE_ID_Adv
public partial class Result_Get_Space_asset_By_SPACE_ID_Adv : Action_Result
{
    #region Properties.
    public List<Space_asset> i_Result { get; set; }
    public Params_Get_Space_asset_By_SPACE_ID Params_Get_Space_asset_By_SPACE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_By_FLOOR_ID
public partial class Result_Get_Space_By_FLOOR_ID : Action_Result
{
    #region Properties.
    public List<Space> i_Result { get; set; }
    public Params_Get_Space_By_FLOOR_ID Params_Get_Space_By_FLOOR_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_asset_By_SPACE_ID_List
public partial class Result_Get_Space_asset_By_SPACE_ID_List : Action_Result
{
    #region Properties.
    public List<Space_asset> i_Result { get; set; }
    public Params_Get_Space_asset_By_SPACE_ID_List Params_Get_Space_asset_By_SPACE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv
public partial class Result_Get_Space_asset_By_SPACE_ASSET_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Space_asset> i_Result { get; set; }
    public Params_Get_Space_asset_By_SPACE_ASSET_ID_List Params_Get_Space_asset_By_SPACE_ASSET_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Space_asset_List
public partial class Result_Edit_Space_asset_List : Action_Result
{
    #region Properties.
    public Params_Edit_Space_asset_List Params_Edit_Space_asset_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Space_asset_By_SPACE_ID
public partial class Result_Get_Space_asset_By_SPACE_ID : Action_Result
{
    #region Properties.
    public List<Space_asset> i_Result { get; set; }
    public Params_Get_Space_asset_By_SPACE_ID Params_Get_Space_asset_By_SPACE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Space_asset_By_SPACE_ID
public partial class Result_Delete_Space_asset_By_SPACE_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Space_asset_By_SPACE_ID Params_Delete_Space_asset_By_SPACE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List
public partial class Result_Get_Video_ai_asset_By_SPACE_ASSET_ID_List : Action_Result
{
    #region Properties.
    public List<Video_ai_asset> i_Result { get; set; }
    public Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List { get; set; }
    #endregion
}
#endregion
