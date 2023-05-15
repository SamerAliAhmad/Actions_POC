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
public partial class SiteManagementController : ControllerBase
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
    #region Edit_Site_view
    [HttpPost]
    [Route("Edit_Site_view")]
    public Result_Edit_Site_view Edit_Site_view(Site_view i_Site_view)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_view oResult_Edit_Site_view = new Result_Edit_Site_view();
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
                oBLC.Edit_Site_view(i_Site_view);
                oResult_Edit_Site_view.Site_view = i_Site_view;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_view.Exception_Message = string.Format("Edit_Site_view : {0}", ex.Message);
                oResult_Edit_Site_view.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_view.Exception_Message = ex.Message;
                oResult_Edit_Site_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_view;
        #endregion
    }
    #endregion
    #region Get_Site_By_OWNER_ID_Adv
    [HttpGet]
    [Route("Get_Site_By_OWNER_ID_Adv")]
    public Result_Get_Site_By_OWNER_ID_Adv Get_Site_By_OWNER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_By_OWNER_ID_Adv oResult_Get_Site_By_OWNER_ID_Adv = new Result_Get_Site_By_OWNER_ID_Adv();
        Params_Get_Site_By_OWNER_ID oParams_Get_Site_By_OWNER_ID = new Params_Get_Site_By_OWNER_ID();
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
                oParams_Get_Site_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_By_OWNER_ID_Adv.i_Result = oBLC.Get_Site_By_OWNER_ID_Adv(oParams_Get_Site_By_OWNER_ID);
                oResult_Get_Site_By_OWNER_ID_Adv.Params_Get_Site_By_OWNER_ID = oParams_Get_Site_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_By_OWNER_ID_Adv.Params_Get_Site_By_OWNER_ID = oParams_Get_Site_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_By_OWNER_ID_Adv.Exception_Message = string.Format("Get_Site_By_OWNER_ID_Adv : {0}", ex.Message);
                oResult_Get_Site_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_By_OWNER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_By_OWNER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Site_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_By_OWNER_ID_Adv;
        #endregion
    }
    #endregion
    #region Edit_Site
    [HttpPost]
    [Route("Edit_Site")]
    public Result_Edit_Site Edit_Site(Site i_Site)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site oResult_Edit_Site = new Result_Edit_Site();
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
                oBLC.Edit_Site(i_Site);
                oResult_Edit_Site.Site = i_Site;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site.Exception_Message = string.Format("Edit_Site : {0}", ex.Message);
                oResult_Edit_Site.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site.Exception_Message = ex.Message;
                oResult_Edit_Site.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site;
        #endregion
    }
    #endregion
    #region Get_Site_By_SITE_ID_List_Adv
    [HttpGet]
    [Route("Get_Site_By_SITE_ID_List_Adv")]
    public Result_Get_Site_By_SITE_ID_List_Adv Get_Site_By_SITE_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_By_SITE_ID_List_Adv oResult_Get_Site_By_SITE_ID_List_Adv = new Result_Get_Site_By_SITE_ID_List_Adv();
        Params_Get_Site_By_SITE_ID_List oParams_Get_Site_By_SITE_ID_List = new Params_Get_Site_By_SITE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SITE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Site_By_SITE_ID_List.SITE_ID_LIST = HttpContext.Request.Query["SITE_ID_LIST"]
																.ToString()
																.Split(',')
																.Where(val => long.TryParse(val, out _))
																.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_By_SITE_ID_List_Adv.i_Result = oBLC.Get_Site_By_SITE_ID_List_Adv(oParams_Get_Site_By_SITE_ID_List);
                oResult_Get_Site_By_SITE_ID_List_Adv.Params_Get_Site_By_SITE_ID_List = oParams_Get_Site_By_SITE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_By_SITE_ID_List_Adv.Params_Get_Site_By_SITE_ID_List = oParams_Get_Site_By_SITE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_By_SITE_ID_List_Adv.Exception_Message = string.Format("Get_Site_By_SITE_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Site_By_SITE_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_By_SITE_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_By_SITE_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Site_By_SITE_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_By_SITE_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_Site_By_SITE_ID_List
    [HttpGet]
    [Route("Get_Site_By_SITE_ID_List")]
    public Result_Get_Site_By_SITE_ID_List Get_Site_By_SITE_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_By_SITE_ID_List oResult_Get_Site_By_SITE_ID_List = new Result_Get_Site_By_SITE_ID_List();
        Params_Get_Site_By_SITE_ID_List oParams_Get_Site_By_SITE_ID_List = new Params_Get_Site_By_SITE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SITE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Site_By_SITE_ID_List.SITE_ID_LIST = HttpContext.Request.Query["SITE_ID_LIST"]
																.ToString()
																.Split(',')
																.Where(val => long.TryParse(val, out _))
																.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_By_SITE_ID_List.i_Result = oBLC.Get_Site_By_SITE_ID_List(oParams_Get_Site_By_SITE_ID_List);
                oResult_Get_Site_By_SITE_ID_List.Params_Get_Site_By_SITE_ID_List = oParams_Get_Site_By_SITE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_By_SITE_ID_List.Params_Get_Site_By_SITE_ID_List = oParams_Get_Site_By_SITE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_By_SITE_ID_List.Exception_Message = string.Format("Get_Site_By_SITE_ID_List : {0}", ex.Message);
                oResult_Get_Site_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_By_SITE_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_By_SITE_ID_List.Exception_Message = ex.Message;
                oResult_Get_Site_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_By_SITE_ID_List;
        #endregion
    }
    #endregion
    #region Get_Ext_study_zone_By_OWNER_ID
    [HttpGet]
    [Route("Get_Ext_study_zone_By_OWNER_ID")]
    public Result_Get_Ext_study_zone_By_OWNER_ID Get_Ext_study_zone_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Ext_study_zone_By_OWNER_ID oResult_Get_Ext_study_zone_By_OWNER_ID = new Result_Get_Ext_study_zone_By_OWNER_ID();
        Params_Get_Ext_study_zone_By_OWNER_ID oParams_Get_Ext_study_zone_By_OWNER_ID = new Params_Get_Ext_study_zone_By_OWNER_ID();
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
                oParams_Get_Ext_study_zone_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Ext_study_zone_By_OWNER_ID.i_Result = oBLC.Get_Ext_study_zone_By_OWNER_ID(oParams_Get_Ext_study_zone_By_OWNER_ID);
                oResult_Get_Ext_study_zone_By_OWNER_ID.Params_Get_Ext_study_zone_By_OWNER_ID = oParams_Get_Ext_study_zone_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Ext_study_zone_By_OWNER_ID.Params_Get_Ext_study_zone_By_OWNER_ID = oParams_Get_Ext_study_zone_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Ext_study_zone_By_OWNER_ID.Exception_Message = string.Format("Get_Ext_study_zone_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Ext_study_zone_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Ext_study_zone_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Ext_study_zone_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Ext_study_zone_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Ext_study_zone_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Delete_Site_view
    [HttpDelete]
    [Route("Delete_Site_view/{SITE_VIEW_ID}")]
    public Result_Delete_Site_view Delete_Site_view(long? SITE_VIEW_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Site_view oParams_Delete_Site_view = new Params_Delete_Site_view()
        {
            SITE_VIEW_ID = SITE_VIEW_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Site_view oResult_Delete_Site_view = new Result_Delete_Site_view();
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
                oBLC.Delete_Site_view(oParams_Delete_Site_view);
                oResult_Delete_Site_view.Params_Delete_Site_view = oParams_Delete_Site_view;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Site_view.Params_Delete_Site_view = oParams_Delete_Site_view;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Site_view.Exception_Message = string.Format("Delete_Site_view : {0}", ex.Message);
                oResult_Delete_Site_view.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Site_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Site_view.Exception_Message = ex.Message;
                oResult_Delete_Site_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Site_view;
        #endregion
    }
    #endregion
    #region Get_Site_By_SITE_ID
    [HttpGet]
    [Route("Get_Site_By_SITE_ID")]
    public Result_Get_Site_By_SITE_ID Get_Site_By_SITE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_By_SITE_ID oResult_Get_Site_By_SITE_ID = new Result_Get_Site_By_SITE_ID();
        Params_Get_Site_By_SITE_ID oParams_Get_Site_By_SITE_ID = new Params_Get_Site_By_SITE_ID();
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
                oParams_Get_Site_By_SITE_ID.SITE_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SITE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_By_SITE_ID.i_Result = oBLC.Get_Site_By_SITE_ID(oParams_Get_Site_By_SITE_ID);
                oResult_Get_Site_By_SITE_ID.Params_Get_Site_By_SITE_ID = oParams_Get_Site_By_SITE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_By_SITE_ID.Params_Get_Site_By_SITE_ID = oParams_Get_Site_By_SITE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_By_SITE_ID.Exception_Message = string.Format("Get_Site_By_SITE_ID : {0}", ex.Message);
                oResult_Get_Site_By_SITE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_By_SITE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_By_SITE_ID.Exception_Message = ex.Message;
                oResult_Get_Site_By_SITE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_By_SITE_ID;
        #endregion
    }
    #endregion
    #region Get_Site_By_OWNER_ID
    [HttpGet]
    [Route("Get_Site_By_OWNER_ID")]
    public Result_Get_Site_By_OWNER_ID Get_Site_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_By_OWNER_ID oResult_Get_Site_By_OWNER_ID = new Result_Get_Site_By_OWNER_ID();
        Params_Get_Site_By_OWNER_ID oParams_Get_Site_By_OWNER_ID = new Params_Get_Site_By_OWNER_ID();
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
                oParams_Get_Site_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_By_OWNER_ID.i_Result = oBLC.Get_Site_By_OWNER_ID(oParams_Get_Site_By_OWNER_ID);
                oResult_Get_Site_By_OWNER_ID.Params_Get_Site_By_OWNER_ID = oParams_Get_Site_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_By_OWNER_ID.Params_Get_Site_By_OWNER_ID = oParams_Get_Site_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_By_OWNER_ID.Exception_Message = string.Format("Get_Site_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Site_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Site_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Site_geojson_By_SITE_ID_List
    [HttpPost]
    [Route("Get_Site_geojson_By_SITE_ID_List")]
    public Result_Get_Site_geojson_By_SITE_ID_List Get_Site_geojson_By_SITE_ID_List(Params_Get_Site_geojson_By_SITE_ID_List i_Params_Get_Site_geojson_By_SITE_ID_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_geojson_By_SITE_ID_List oResult_Get_Site_geojson_By_SITE_ID_List = new Result_Get_Site_geojson_By_SITE_ID_List();
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
                oResult_Get_Site_geojson_By_SITE_ID_List.i_Result = oBLC.Get_Site_geojson_By_SITE_ID_List(i_Params_Get_Site_geojson_By_SITE_ID_List);
                oResult_Get_Site_geojson_By_SITE_ID_List.Params_Get_Site_geojson_By_SITE_ID_List = i_Params_Get_Site_geojson_By_SITE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_geojson_By_SITE_ID_List.Params_Get_Site_geojson_By_SITE_ID_List = i_Params_Get_Site_geojson_By_SITE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_geojson_By_SITE_ID_List.Exception_Message = string.Format("Get_Site_geojson_By_SITE_ID_List : {0}", ex.Message);
                oResult_Get_Site_geojson_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_geojson_By_SITE_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_geojson_By_SITE_ID_List.Exception_Message = ex.Message;
                oResult_Get_Site_geojson_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_geojson_By_SITE_ID_List;
        #endregion
    }
    #endregion
    #region Get_Site_view_By_SITE_ID
    [HttpGet]
    [Route("Get_Site_view_By_SITE_ID")]
    public Result_Get_Site_view_By_SITE_ID Get_Site_view_By_SITE_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_view_By_SITE_ID oResult_Get_Site_view_By_SITE_ID = new Result_Get_Site_view_By_SITE_ID();
        Params_Get_Site_view_By_SITE_ID oParams_Get_Site_view_By_SITE_ID = new Params_Get_Site_view_By_SITE_ID();
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
                oParams_Get_Site_view_By_SITE_ID.SITE_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SITE_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_view_By_SITE_ID.i_Result = oBLC.Get_Site_view_By_SITE_ID(oParams_Get_Site_view_By_SITE_ID);
                oResult_Get_Site_view_By_SITE_ID.Params_Get_Site_view_By_SITE_ID = oParams_Get_Site_view_By_SITE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_view_By_SITE_ID.Params_Get_Site_view_By_SITE_ID = oParams_Get_Site_view_By_SITE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_view_By_SITE_ID.Exception_Message = string.Format("Get_Site_view_By_SITE_ID : {0}", ex.Message);
                oResult_Get_Site_view_By_SITE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_view_By_SITE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_view_By_SITE_ID.Exception_Message = ex.Message;
                oResult_Get_Site_view_By_SITE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_view_By_SITE_ID;
        #endregion
    }
    #endregion
    #region Edit_Ext_study_zone_List
    [HttpPost]
    [Route("Edit_Ext_study_zone_List")]
    public Result_Edit_Ext_study_zone_List Edit_Ext_study_zone_List(Params_Edit_Ext_study_zone_List i_Params_Edit_Ext_study_zone_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Ext_study_zone_List oResult_Edit_Ext_study_zone_List = new Result_Edit_Ext_study_zone_List();
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
                oBLC.Edit_Ext_study_zone_List(i_Params_Edit_Ext_study_zone_List);
                oResult_Edit_Ext_study_zone_List.Params_Edit_Ext_study_zone_List = i_Params_Edit_Ext_study_zone_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Ext_study_zone_List.Exception_Message = string.Format("Edit_Ext_study_zone_List : {0}", ex.Message);
                oResult_Edit_Ext_study_zone_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Ext_study_zone_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Ext_study_zone_List.Exception_Message = ex.Message;
                oResult_Edit_Ext_study_zone_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Ext_study_zone_List;
        #endregion
    }
    #endregion
    #region Edit_Site_view_List
    [HttpPost]
    [Route("Edit_Site_view_List")]
    public Result_Edit_Site_view_List Edit_Site_view_List(Params_Edit_Site_view_List i_Params_Edit_Site_view_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_view_List oResult_Edit_Site_view_List = new Result_Edit_Site_view_List();
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
                oBLC.Edit_Site_view_List(i_Params_Edit_Site_view_List);
                oResult_Edit_Site_view_List.Params_Edit_Site_view_List = i_Params_Edit_Site_view_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_view_List.Exception_Message = string.Format("Edit_Site_view_List : {0}", ex.Message);
                oResult_Edit_Site_view_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_view_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_view_List.Exception_Message = ex.Message;
                oResult_Edit_Site_view_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_view_List;
        #endregion
    }
    #endregion
    #region Delete_Site_view_By_SITE_ID
    [HttpPost]
    [Route("Delete_Site_view_By_SITE_ID")]
    public Result_Delete_Site_view_By_SITE_ID Delete_Site_view_By_SITE_ID(Params_Delete_Site_view_By_SITE_ID i_Params_Delete_Site_view_By_SITE_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Site_view_By_SITE_ID oResult_Delete_Site_view_By_SITE_ID = new Result_Delete_Site_view_By_SITE_ID();
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
                oBLC.Delete_Site_view_By_SITE_ID(i_Params_Delete_Site_view_By_SITE_ID);
                oResult_Delete_Site_view_By_SITE_ID.Params_Delete_Site_view_By_SITE_ID = i_Params_Delete_Site_view_By_SITE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Site_view_By_SITE_ID.Params_Delete_Site_view_By_SITE_ID = i_Params_Delete_Site_view_By_SITE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Site_view_By_SITE_ID.Exception_Message = string.Format("Delete_Site_view_By_SITE_ID : {0}", ex.Message);
                oResult_Delete_Site_view_By_SITE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Site_view_By_SITE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Site_view_By_SITE_ID.Exception_Message = ex.Message;
                oResult_Delete_Site_view_By_SITE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Site_view_By_SITE_ID;
        #endregion
    }
    #endregion
    #region Get_Site_view_By_SITE_ID_List
    [HttpGet]
    [Route("Get_Site_view_By_SITE_ID_List")]
    public Result_Get_Site_view_By_SITE_ID_List Get_Site_view_By_SITE_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_view_By_SITE_ID_List oResult_Get_Site_view_By_SITE_ID_List = new Result_Get_Site_view_By_SITE_ID_List();
        Params_Get_Site_view_By_SITE_ID_List oParams_Get_Site_view_By_SITE_ID_List = new Params_Get_Site_view_By_SITE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SITE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Site_view_By_SITE_ID_List.SITE_ID_LIST = HttpContext.Request.Query["SITE_ID_LIST"]
																		.ToString()
																		.Split(',')
																		.Where(val => long.TryParse(val, out _))
																		.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_view_By_SITE_ID_List.i_Result = oBLC.Get_Site_view_By_SITE_ID_List(oParams_Get_Site_view_By_SITE_ID_List);
                oResult_Get_Site_view_By_SITE_ID_List.Params_Get_Site_view_By_SITE_ID_List = oParams_Get_Site_view_By_SITE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_view_By_SITE_ID_List.Params_Get_Site_view_By_SITE_ID_List = oParams_Get_Site_view_By_SITE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_view_By_SITE_ID_List.Exception_Message = string.Format("Get_Site_view_By_SITE_ID_List : {0}", ex.Message);
                oResult_Get_Site_view_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_view_By_SITE_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_view_By_SITE_ID_List.Exception_Message = ex.Message;
                oResult_Get_Site_view_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_view_By_SITE_ID_List;
        #endregion
    }
    #endregion
    #region Get_Site_field_logo_By_SITE_ID_List
    [HttpGet]
    [Route("Get_Site_field_logo_By_SITE_ID_List")]
    public Result_Get_Site_field_logo_By_SITE_ID_List Get_Site_field_logo_By_SITE_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_field_logo_By_SITE_ID_List oResult_Get_Site_field_logo_By_SITE_ID_List = new Result_Get_Site_field_logo_By_SITE_ID_List();
        Params_Get_Site_field_logo_By_SITE_ID_List oParams_Get_Site_field_logo_By_SITE_ID_List = new Params_Get_Site_field_logo_By_SITE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["SITE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["SITE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Site_field_logo_By_SITE_ID_List.SITE_ID_LIST = HttpContext.Request.Query["SITE_ID_LIST"]
																			.ToString()
																			.Split(',')
																			.Where(val => long.TryParse(val, out _))
																			.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Site_field_logo_By_SITE_ID_List.i_Result = oBLC.Get_Site_field_logo_By_SITE_ID_List(oParams_Get_Site_field_logo_By_SITE_ID_List);
                oResult_Get_Site_field_logo_By_SITE_ID_List.Params_Get_Site_field_logo_By_SITE_ID_List = oParams_Get_Site_field_logo_By_SITE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Site_field_logo_By_SITE_ID_List.Params_Get_Site_field_logo_By_SITE_ID_List = oParams_Get_Site_field_logo_By_SITE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_field_logo_By_SITE_ID_List.Exception_Message = string.Format("Get_Site_field_logo_By_SITE_ID_List : {0}", ex.Message);
                oResult_Get_Site_field_logo_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_field_logo_By_SITE_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_field_logo_By_SITE_ID_List.Exception_Message = ex.Message;
                oResult_Get_Site_field_logo_By_SITE_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_field_logo_By_SITE_ID_List;
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
#region Result_Edit_Site_view
public partial class Result_Edit_Site_view : Action_Result
{
    #region Properties.
    public Site_view Site_view { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_By_OWNER_ID_Adv
public partial class Result_Get_Site_By_OWNER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Site> i_Result { get; set; }
    public Params_Get_Site_By_OWNER_ID Params_Get_Site_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site
public partial class Result_Edit_Site : Action_Result
{
    #region Properties.
    public Site Site { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_By_SITE_ID_List_Adv
public partial class Result_Get_Site_By_SITE_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Site> i_Result { get; set; }
    public Params_Get_Site_By_SITE_ID_List Params_Get_Site_By_SITE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_By_SITE_ID_List
public partial class Result_Get_Site_By_SITE_ID_List : Action_Result
{
    #region Properties.
    public List<Site> i_Result { get; set; }
    public Params_Get_Site_By_SITE_ID_List Params_Get_Site_By_SITE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Ext_study_zone_By_OWNER_ID
public partial class Result_Get_Ext_study_zone_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Ext_study_zone> i_Result { get; set; }
    public Params_Get_Ext_study_zone_By_OWNER_ID Params_Get_Ext_study_zone_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Site_view
public partial class Result_Delete_Site_view : Action_Result
{
    #region Properties.
    public Params_Delete_Site_view Params_Delete_Site_view { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_By_SITE_ID
public partial class Result_Get_Site_By_SITE_ID : Action_Result
{
    #region Properties.
    public Site i_Result { get; set; }
    public Params_Get_Site_By_SITE_ID Params_Get_Site_By_SITE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_By_OWNER_ID
public partial class Result_Get_Site_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Site> i_Result { get; set; }
    public Params_Get_Site_By_OWNER_ID Params_Get_Site_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_geojson_By_SITE_ID_List
public partial class Result_Get_Site_geojson_By_SITE_ID_List : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Get_Site_geojson_By_SITE_ID_List Params_Get_Site_geojson_By_SITE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_view_By_SITE_ID
public partial class Result_Get_Site_view_By_SITE_ID : Action_Result
{
    #region Properties.
    public List<Site_view> i_Result { get; set; }
    public Params_Get_Site_view_By_SITE_ID Params_Get_Site_view_By_SITE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Ext_study_zone_List
public partial class Result_Edit_Ext_study_zone_List : Action_Result
{
    #region Properties.
    public Params_Edit_Ext_study_zone_List Params_Edit_Ext_study_zone_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site_view_List
public partial class Result_Edit_Site_view_List : Action_Result
{
    #region Properties.
    public Params_Edit_Site_view_List Params_Edit_Site_view_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Site_view_By_SITE_ID
public partial class Result_Delete_Site_view_By_SITE_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Site_view_By_SITE_ID Params_Delete_Site_view_By_SITE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_view_By_SITE_ID_List
public partial class Result_Get_Site_view_By_SITE_ID_List : Action_Result
{
    #region Properties.
    public List<Site_view> i_Result { get; set; }
    public Params_Get_Site_view_By_SITE_ID_List Params_Get_Site_view_By_SITE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_field_logo_By_SITE_ID_List
public partial class Result_Get_Site_field_logo_By_SITE_ID_List : Action_Result
{
    #region Properties.
    public List<Site_field_logo> i_Result { get; set; }
    public Params_Get_Site_field_logo_By_SITE_ID_List Params_Get_Site_field_logo_By_SITE_ID_List { get; set; }
    #endregion
}
#endregion
