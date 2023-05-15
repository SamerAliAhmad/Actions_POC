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
public partial class EntityManagementController : ControllerBase
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
    #region Edit_Entity_view
    [HttpPost]
    [Route("Edit_Entity_view")]
    public Result_Edit_Entity_view Edit_Entity_view(Entity_view i_Entity_view)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_view oResult_Edit_Entity_view = new Result_Edit_Entity_view();
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
                oBLC.Edit_Entity_view(i_Entity_view);
                oResult_Edit_Entity_view.Entity_view = i_Entity_view;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_view.Exception_Message = string.Format("Edit_Entity_view : {0}", ex.Message);
                oResult_Edit_Entity_view.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_view.Exception_Message = ex.Message;
                oResult_Edit_Entity_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_view;
        #endregion
    }
    #endregion
    #region Get_Entity_view_By_ENTITY_ID
    [HttpGet]
    [Route("Get_Entity_view_By_ENTITY_ID")]
    public Result_Get_Entity_view_By_ENTITY_ID Get_Entity_view_By_ENTITY_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_view_By_ENTITY_ID oResult_Get_Entity_view_By_ENTITY_ID = new Result_Get_Entity_view_By_ENTITY_ID();
        Params_Get_Entity_view_By_ENTITY_ID oParams_Get_Entity_view_By_ENTITY_ID = new Params_Get_Entity_view_By_ENTITY_ID();
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
                oParams_Get_Entity_view_By_ENTITY_ID.ENTITY_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_view_By_ENTITY_ID.i_Result = oBLC.Get_Entity_view_By_ENTITY_ID(oParams_Get_Entity_view_By_ENTITY_ID);
                oResult_Get_Entity_view_By_ENTITY_ID.Params_Get_Entity_view_By_ENTITY_ID = oParams_Get_Entity_view_By_ENTITY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_view_By_ENTITY_ID.Params_Get_Entity_view_By_ENTITY_ID = oParams_Get_Entity_view_By_ENTITY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_view_By_ENTITY_ID.Exception_Message = string.Format("Get_Entity_view_By_ENTITY_ID : {0}", ex.Message);
                oResult_Get_Entity_view_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_view_By_ENTITY_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_view_By_ENTITY_ID.Exception_Message = ex.Message;
                oResult_Get_Entity_view_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_view_By_ENTITY_ID;
        #endregion
    }
    #endregion
    #region Delete_Entity_view
    [HttpPost]
    [Route("Delete_Entity_view")]
    public Result_Delete_Entity_view Delete_Entity_view(Params_Delete_Entity_view i_Params_Delete_Entity_view)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Entity_view oResult_Delete_Entity_view = new Result_Delete_Entity_view();
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
                oBLC.Delete_Entity_view(i_Params_Delete_Entity_view);
                oResult_Delete_Entity_view.Params_Delete_Entity_view = i_Params_Delete_Entity_view;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Entity_view.Params_Delete_Entity_view = i_Params_Delete_Entity_view;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Entity_view.Exception_Message = string.Format("Delete_Entity_view : {0}", ex.Message);
                oResult_Delete_Entity_view.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Entity_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Entity_view.Exception_Message = ex.Message;
                oResult_Delete_Entity_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Entity_view;
        #endregion
    }
    #endregion
    #region Get_Entity_By_SITE_ID
    [HttpGet]
    [Route("Get_Entity_By_SITE_ID")]
    public Result_Get_Entity_By_SITE_ID Get_Entity_By_SITE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_By_SITE_ID oResult_Get_Entity_By_SITE_ID = new Result_Get_Entity_By_SITE_ID();
        Params_Get_Entity_By_SITE_ID oParams_Get_Entity_By_SITE_ID = new Params_Get_Entity_By_SITE_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SITE_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SITE_ID"].ToString() != "undefined" && HttpContext.Request.Query["SITE_ID"].ToString() != "null" && HttpContext.Request.Query["SITE_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Entity_By_SITE_ID.SITE_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SITE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_By_SITE_ID.i_Result = oBLC.Get_Entity_By_SITE_ID(oParams_Get_Entity_By_SITE_ID);
                oResult_Get_Entity_By_SITE_ID.Params_Get_Entity_By_SITE_ID = oParams_Get_Entity_By_SITE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_By_SITE_ID.Params_Get_Entity_By_SITE_ID = oParams_Get_Entity_By_SITE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_By_SITE_ID.Exception_Message = string.Format("Get_Entity_By_SITE_ID : {0}", ex.Message);
                oResult_Get_Entity_By_SITE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_By_SITE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_By_SITE_ID.Exception_Message = ex.Message;
                oResult_Get_Entity_By_SITE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_By_SITE_ID;
        #endregion
    }
    #endregion
    #region Get_Entity_By_ENTITY_ID_Adv
    [HttpGet]
    [Route("Get_Entity_By_ENTITY_ID_Adv")]
    public Result_Get_Entity_By_ENTITY_ID_Adv Get_Entity_By_ENTITY_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_By_ENTITY_ID_Adv oResult_Get_Entity_By_ENTITY_ID_Adv = new Result_Get_Entity_By_ENTITY_ID_Adv();
        Params_Get_Entity_By_ENTITY_ID oParams_Get_Entity_By_ENTITY_ID = new Params_Get_Entity_By_ENTITY_ID();
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
                oParams_Get_Entity_By_ENTITY_ID.ENTITY_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_By_ENTITY_ID_Adv.i_Result = oBLC.Get_Entity_By_ENTITY_ID_Adv(oParams_Get_Entity_By_ENTITY_ID);
                oResult_Get_Entity_By_ENTITY_ID_Adv.Params_Get_Entity_By_ENTITY_ID = oParams_Get_Entity_By_ENTITY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_By_ENTITY_ID_Adv.Params_Get_Entity_By_ENTITY_ID = oParams_Get_Entity_By_ENTITY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_By_ENTITY_ID_Adv.Exception_Message = string.Format("Get_Entity_By_ENTITY_ID_Adv : {0}", ex.Message);
                oResult_Get_Entity_By_ENTITY_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_By_ENTITY_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_By_ENTITY_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Entity_By_ENTITY_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_By_ENTITY_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Entity_By_ENTITY_ID
    [HttpGet]
    [Route("Get_Entity_By_ENTITY_ID")]
    public Result_Get_Entity_By_ENTITY_ID Get_Entity_By_ENTITY_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_By_ENTITY_ID oResult_Get_Entity_By_ENTITY_ID = new Result_Get_Entity_By_ENTITY_ID();
        Params_Get_Entity_By_ENTITY_ID oParams_Get_Entity_By_ENTITY_ID = new Params_Get_Entity_By_ENTITY_ID();
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
                oParams_Get_Entity_By_ENTITY_ID.ENTITY_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ENTITY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_By_ENTITY_ID.i_Result = oBLC.Get_Entity_By_ENTITY_ID(oParams_Get_Entity_By_ENTITY_ID);
                oResult_Get_Entity_By_ENTITY_ID.Params_Get_Entity_By_ENTITY_ID = oParams_Get_Entity_By_ENTITY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_By_ENTITY_ID.Params_Get_Entity_By_ENTITY_ID = oParams_Get_Entity_By_ENTITY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_By_ENTITY_ID.Exception_Message = string.Format("Get_Entity_By_ENTITY_ID : {0}", ex.Message);
                oResult_Get_Entity_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_By_ENTITY_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_By_ENTITY_ID.Exception_Message = ex.Message;
                oResult_Get_Entity_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_By_ENTITY_ID;
        #endregion
    }
    #endregion
    #region Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID
    [HttpPost]
    [Route("Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID")]
    public Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID(Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID = new Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID();
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
                oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.i_Result = oBLC.Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID(i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID);
                oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID = i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID = i_Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.Exception_Message = string.Format("Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID : {0}", ex.Message);
                oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.Exception_Message = ex.Message;
                oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID;
        #endregion
    }
    #endregion
    #region Get_Entity_By_ENTITY_ID_List
    [HttpGet]
    [Route("Get_Entity_By_ENTITY_ID_List")]
    public Result_Get_Entity_By_ENTITY_ID_List Get_Entity_By_ENTITY_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_By_ENTITY_ID_List oResult_Get_Entity_By_ENTITY_ID_List = new Result_Get_Entity_By_ENTITY_ID_List();
        Params_Get_Entity_By_ENTITY_ID_List oParams_Get_Entity_By_ENTITY_ID_List = new Params_Get_Entity_By_ENTITY_ID_List();
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
                oParams_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST = HttpContext.Request.Query["ENTITY_ID_LIST"]
																		.ToString()
																		.Split(',')
																		.Where(val => long.TryParse(val, out _))
																		.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_By_ENTITY_ID_List.i_Result = oBLC.Get_Entity_By_ENTITY_ID_List(oParams_Get_Entity_By_ENTITY_ID_List);
                oResult_Get_Entity_By_ENTITY_ID_List.Params_Get_Entity_By_ENTITY_ID_List = oParams_Get_Entity_By_ENTITY_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_By_ENTITY_ID_List.Params_Get_Entity_By_ENTITY_ID_List = oParams_Get_Entity_By_ENTITY_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_By_ENTITY_ID_List.Exception_Message = string.Format("Get_Entity_By_ENTITY_ID_List : {0}", ex.Message);
                oResult_Get_Entity_By_ENTITY_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_By_ENTITY_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_By_ENTITY_ID_List.Exception_Message = ex.Message;
                oResult_Get_Entity_By_ENTITY_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_By_ENTITY_ID_List;
        #endregion
    }
    #endregion
    #region Get_Entity_By_OWNER_ID
    [HttpGet]
    [Route("Get_Entity_By_OWNER_ID")]
    public Result_Get_Entity_By_OWNER_ID Get_Entity_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_By_OWNER_ID oResult_Get_Entity_By_OWNER_ID = new Result_Get_Entity_By_OWNER_ID();
        Params_Get_Entity_By_OWNER_ID oParams_Get_Entity_By_OWNER_ID = new Params_Get_Entity_By_OWNER_ID();
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
                oParams_Get_Entity_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_By_OWNER_ID.i_Result = oBLC.Get_Entity_By_OWNER_ID(oParams_Get_Entity_By_OWNER_ID);
                oResult_Get_Entity_By_OWNER_ID.Params_Get_Entity_By_OWNER_ID = oParams_Get_Entity_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_By_OWNER_ID.Params_Get_Entity_By_OWNER_ID = oParams_Get_Entity_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_By_OWNER_ID.Exception_Message = string.Format("Get_Entity_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Entity_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Entity_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Entity
    [HttpPost]
    [Route("Edit_Entity")]
    public Result_Edit_Entity Edit_Entity(Entity i_Entity)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity oResult_Edit_Entity = new Result_Edit_Entity();
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
                oBLC.Edit_Entity(i_Entity);
                oResult_Edit_Entity.Entity = i_Entity;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity.Exception_Message = string.Format("Edit_Entity : {0}", ex.Message);
                oResult_Edit_Entity.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity.Exception_Message = ex.Message;
                oResult_Edit_Entity.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity;
        #endregion
    }
    #endregion
    #region Edit_Entity_view_List
    [HttpPost]
    [Route("Edit_Entity_view_List")]
    public Result_Edit_Entity_view_List Edit_Entity_view_List(Params_Edit_Entity_view_List i_Params_Edit_Entity_view_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_view_List oResult_Edit_Entity_view_List = new Result_Edit_Entity_view_List();
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
                oBLC.Edit_Entity_view_List(i_Params_Edit_Entity_view_List);
                oResult_Edit_Entity_view_List.Params_Edit_Entity_view_List = i_Params_Edit_Entity_view_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_view_List.Exception_Message = string.Format("Edit_Entity_view_List : {0}", ex.Message);
                oResult_Edit_Entity_view_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_view_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_view_List.Exception_Message = ex.Message;
                oResult_Edit_Entity_view_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_view_List;
        #endregion
    }
    #endregion
    #region Delete_Entity_view_By_ENTITY_ID
    [HttpPost]
    [Route("Delete_Entity_view_By_ENTITY_ID")]
    public Result_Delete_Entity_view_By_ENTITY_ID Delete_Entity_view_By_ENTITY_ID(Params_Delete_Entity_view_By_ENTITY_ID i_Params_Delete_Entity_view_By_ENTITY_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Entity_view_By_ENTITY_ID oResult_Delete_Entity_view_By_ENTITY_ID = new Result_Delete_Entity_view_By_ENTITY_ID();
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
                oBLC.Delete_Entity_view_By_ENTITY_ID(i_Params_Delete_Entity_view_By_ENTITY_ID);
                oResult_Delete_Entity_view_By_ENTITY_ID.Params_Delete_Entity_view_By_ENTITY_ID = i_Params_Delete_Entity_view_By_ENTITY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Entity_view_By_ENTITY_ID.Params_Delete_Entity_view_By_ENTITY_ID = i_Params_Delete_Entity_view_By_ENTITY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Entity_view_By_ENTITY_ID.Exception_Message = string.Format("Delete_Entity_view_By_ENTITY_ID : {0}", ex.Message);
                oResult_Delete_Entity_view_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Entity_view_By_ENTITY_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Entity_view_By_ENTITY_ID.Exception_Message = ex.Message;
                oResult_Delete_Entity_view_By_ENTITY_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Entity_view_By_ENTITY_ID;
        #endregion
    }
    #endregion
    #region Get_Entity_view_By_ENTITY_ID_List
    [HttpGet]
    [Route("Get_Entity_view_By_ENTITY_ID_List")]
    public Result_Get_Entity_view_By_ENTITY_ID_List Get_Entity_view_By_ENTITY_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_view_By_ENTITY_ID_List oResult_Get_Entity_view_By_ENTITY_ID_List = new Result_Get_Entity_view_By_ENTITY_ID_List();
        Params_Get_Entity_view_By_ENTITY_ID_List oParams_Get_Entity_view_By_ENTITY_ID_List = new Params_Get_Entity_view_By_ENTITY_ID_List();
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
                oParams_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST = HttpContext.Request.Query["ENTITY_ID_LIST"]
																			.ToString()
																			.Split(',')
																			.Where(val => long.TryParse(val, out _))
																			.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Entity_view_By_ENTITY_ID_List.i_Result = oBLC.Get_Entity_view_By_ENTITY_ID_List(oParams_Get_Entity_view_By_ENTITY_ID_List);
                oResult_Get_Entity_view_By_ENTITY_ID_List.Params_Get_Entity_view_By_ENTITY_ID_List = oParams_Get_Entity_view_By_ENTITY_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_view_By_ENTITY_ID_List.Params_Get_Entity_view_By_ENTITY_ID_List = oParams_Get_Entity_view_By_ENTITY_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_view_By_ENTITY_ID_List.Exception_Message = string.Format("Get_Entity_view_By_ENTITY_ID_List : {0}", ex.Message);
                oResult_Get_Entity_view_By_ENTITY_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_view_By_ENTITY_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_view_By_ENTITY_ID_List.Exception_Message = ex.Message;
                oResult_Get_Entity_view_By_ENTITY_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_view_By_ENTITY_ID_List;
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
#region Result_Edit_Entity_view
public partial class Result_Edit_Entity_view : Action_Result
{
    #region Properties.
    public Entity_view Entity_view { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_view_By_ENTITY_ID
public partial class Result_Get_Entity_view_By_ENTITY_ID : Action_Result
{
    #region Properties.
    public List<Entity_view> i_Result { get; set; }
    public Params_Get_Entity_view_By_ENTITY_ID Params_Get_Entity_view_By_ENTITY_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Entity_view
public partial class Result_Delete_Entity_view : Action_Result
{
    #region Properties.
    public Params_Delete_Entity_view Params_Delete_Entity_view { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_By_SITE_ID
public partial class Result_Get_Entity_By_SITE_ID : Action_Result
{
    #region Properties.
    public List<Entity> i_Result { get; set; }
    public Params_Get_Entity_By_SITE_ID Params_Get_Entity_By_SITE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_By_ENTITY_ID_Adv
public partial class Result_Get_Entity_By_ENTITY_ID_Adv : Action_Result
{
    #region Properties.
    public Entity i_Result { get; set; }
    public Params_Get_Entity_By_ENTITY_ID Params_Get_Entity_By_ENTITY_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_By_ENTITY_ID
public partial class Result_Get_Entity_By_ENTITY_ID : Action_Result
{
    #region Properties.
    public Entity i_Result { get; set; }
    public Params_Get_Entity_By_ENTITY_ID Params_Get_Entity_By_ENTITY_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID
public partial class Result_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID : Action_Result
{
    #region Properties.
    public Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID_Result i_Result { get; set; }
    public Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID Params_Get_Entity_By_ENTITY_ID_List_TOP_LEVEL_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_By_ENTITY_ID_List
public partial class Result_Get_Entity_By_ENTITY_ID_List : Action_Result
{
    #region Properties.
    public List<Entity> i_Result { get; set; }
    public Params_Get_Entity_By_ENTITY_ID_List Params_Get_Entity_By_ENTITY_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_By_OWNER_ID
public partial class Result_Get_Entity_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Entity> i_Result { get; set; }
    public Params_Get_Entity_By_OWNER_ID Params_Get_Entity_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Entity
public partial class Result_Edit_Entity : Action_Result
{
    #region Properties.
    public Entity Entity { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Entity_view_List
public partial class Result_Edit_Entity_view_List : Action_Result
{
    #region Properties.
    public Params_Edit_Entity_view_List Params_Edit_Entity_view_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Entity_view_By_ENTITY_ID
public partial class Result_Delete_Entity_view_By_ENTITY_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Entity_view_By_ENTITY_ID Params_Delete_Entity_view_By_ENTITY_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_view_By_ENTITY_ID_List
public partial class Result_Get_Entity_view_By_ENTITY_ID_List : Action_Result
{
    #region Properties.
    public List<Entity_view> i_Result { get; set; }
    public Params_Get_Entity_view_By_ENTITY_ID_List Params_Get_Entity_view_By_ENTITY_ID_List { get; set; }
    #endregion
}
#endregion
