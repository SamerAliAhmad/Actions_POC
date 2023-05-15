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
public partial class OrganizationManagementController : ControllerBase
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
    #region Check_Organization_Deletion_Status
    [HttpPost]
    [Route("Check_Organization_Deletion_Status")]
    public Result_Check_Organization_Deletion_Status Check_Organization_Deletion_Status()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Check_Organization_Deletion_Status oResult_Check_Organization_Deletion_Status = new Result_Check_Organization_Deletion_Status();
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
                oBLC.Check_Organization_Deletion_Status();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Check_Organization_Deletion_Status.Exception_Message = string.Format("Check_Organization_Deletion_Status : {0}", ex.Message);
                oResult_Check_Organization_Deletion_Status.Stack_Trace = is_send_stack_trace ? string.Format("Check_Organization_Deletion_Status : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Check_Organization_Deletion_Status.Exception_Message = ex.Message;
                oResult_Check_Organization_Deletion_Status.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Check_Organization_Deletion_Status;
        #endregion
    }
    #endregion
    #region Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
    [HttpGet]
    [Route("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID")]
    public Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID = new Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID();
        Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID = new Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            if (HttpContext.Request.Query["LOG_TYPE_SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["LOG_TYPE_SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["LOG_TYPE_SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["LOG_TYPE_SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.LOG_TYPE_SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["LOG_TYPE_SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.i_Result = oBLC.Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID(oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID);
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID = oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID = oParams_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.Exception_Message = string.Format("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID : {0}", ex.Message);
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization
    [HttpPost]
    [Route("Edit_Organization")]
    public Result_Edit_Organization Edit_Organization(Organization i_Organization)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization oResult_Edit_Organization = new Result_Edit_Organization();
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
                oBLC.Edit_Organization(i_Organization);
                oResult_Edit_Organization.Organization = i_Organization;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization.Exception_Message = string.Format("Edit_Organization : {0}", ex.Message);
                oResult_Edit_Organization.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization.Exception_Message = ex.Message;
                oResult_Edit_Organization.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization;
        #endregion
    }
    #endregion
    #region Get_Organization_image_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_Organization_image_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv Get_Organization_image_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv = new Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv();
        Params_Get_Organization_image_By_ORGANIZATION_ID_List oParams_Get_Organization_image_By_ORGANIZATION_ID_List = new Params_Get_Organization_image_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																								.ToString()
																								.Split(',')
																								.Where(val => int.TryParse(val, out _))
																								.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_Organization_image_By_ORGANIZATION_ID_List_Adv(oParams_Get_Organization_image_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_image_By_ORGANIZATION_ID_List = oParams_Get_Organization_image_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_image_By_ORGANIZATION_ID_List = oParams_Get_Organization_image_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_Organization_image_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_image_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_image_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Delete_Organization_theme
    [HttpPost]
    [Route("Delete_Organization_theme")]
    public Result_Delete_Organization_theme Delete_Organization_theme(Params_Delete_Organization_theme i_Params_Delete_Organization_theme)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_theme oResult_Delete_Organization_theme = new Result_Delete_Organization_theme();
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
                oBLC.Delete_Organization_theme(i_Params_Delete_Organization_theme);
                oResult_Delete_Organization_theme.Params_Delete_Organization_theme = i_Params_Delete_Organization_theme;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_theme.Params_Delete_Organization_theme = i_Params_Delete_Organization_theme;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_theme.Exception_Message = string.Format("Delete_Organization_theme : {0}", ex.Message);
                oResult_Delete_Organization_theme.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_theme : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_theme.Exception_Message = ex.Message;
                oResult_Delete_Organization_theme.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_theme;
        #endregion
    }
    #endregion
    #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv
    [HttpGet]
    [Route("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv")]
    public Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv = new Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv();
        Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = new Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.i_Result = oBLC.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv(oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID);
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.Exception_Message = string.Format("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv : {0}", ex.Message);
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Organization_theme_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_Organization_theme_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv Get_Organization_theme_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv = new Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv();
        Params_Get_Organization_theme_By_ORGANIZATION_ID_List oParams_Get_Organization_theme_By_ORGANIZATION_ID_List = new Params_Get_Organization_theme_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_theme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																								.ToString()
																								.Split(',')
																								.Where(val => int.TryParse(val, out _))
																								.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(oParams_Get_Organization_theme_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_theme_By_ORGANIZATION_ID_List = oParams_Get_Organization_theme_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_theme_By_ORGANIZATION_ID_List = oParams_Get_Organization_theme_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_Organization_theme_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_theme_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Edit_Organization_Custom
    [HttpPost]
    [Route("Edit_Organization_Custom")]
    public Result_Edit_Organization_Custom Edit_Organization_Custom(Params_Edit_Organization_Custom i_Params_Edit_Organization_Custom)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_Custom oResult_Edit_Organization_Custom = new Result_Edit_Organization_Custom();
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
                oResult_Edit_Organization_Custom.i_Result = oBLC.Edit_Organization_Custom(i_Params_Edit_Organization_Custom);
                oResult_Edit_Organization_Custom.Params_Edit_Organization_Custom = i_Params_Edit_Organization_Custom;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Organization_Custom.Params_Edit_Organization_Custom = i_Params_Edit_Organization_Custom;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_Custom.Exception_Message = string.Format("Edit_Organization_Custom : {0}", ex.Message);
                oResult_Edit_Organization_Custom.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_Custom : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_Custom.Exception_Message = ex.Message;
                oResult_Edit_Organization_Custom.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_Custom;
        #endregion
    }
    #endregion
    #region Schedule_Organization_for_Delete
    [HttpPost]
    [Route("Schedule_Organization_for_Delete")]
    public Result_Schedule_Organization_for_Delete Schedule_Organization_for_Delete(Params_Schedule_Organization_for_Delete i_Params_Schedule_Organization_for_Delete)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Schedule_Organization_for_Delete oResult_Schedule_Organization_for_Delete = new Result_Schedule_Organization_for_Delete();
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
                oResult_Schedule_Organization_for_Delete.i_Result = oBLC.Schedule_Organization_for_Delete(i_Params_Schedule_Organization_for_Delete);
                oResult_Schedule_Organization_for_Delete.Params_Schedule_Organization_for_Delete = i_Params_Schedule_Organization_for_Delete;
            }
        }
        catch (Exception ex)
        {
            oResult_Schedule_Organization_for_Delete.Params_Schedule_Organization_for_Delete = i_Params_Schedule_Organization_for_Delete;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Schedule_Organization_for_Delete.Exception_Message = string.Format("Schedule_Organization_for_Delete : {0}", ex.Message);
                oResult_Schedule_Organization_for_Delete.Stack_Trace = is_send_stack_trace ? string.Format("Schedule_Organization_for_Delete : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Schedule_Organization_for_Delete.Exception_Message = ex.Message;
                oResult_Schedule_Organization_for_Delete.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Schedule_Organization_for_Delete;
        #endregion
    }
    #endregion
    #region Modify_Data_Settings
    [HttpPost]
    [Route("Modify_Data_Settings")]
    public Result_Modify_Data_Settings Modify_Data_Settings(Params_Modify_Data_Settings i_Params_Modify_Data_Settings)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Modify_Data_Settings oResult_Modify_Data_Settings = new Result_Modify_Data_Settings();
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
                oResult_Modify_Data_Settings.i_Result = oBLC.Modify_Data_Settings(i_Params_Modify_Data_Settings);
                oResult_Modify_Data_Settings.Params_Modify_Data_Settings = i_Params_Modify_Data_Settings;
            }
        }
        catch (Exception ex)
        {
            oResult_Modify_Data_Settings.Params_Modify_Data_Settings = i_Params_Modify_Data_Settings;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Modify_Data_Settings.Exception_Message = string.Format("Modify_Data_Settings : {0}", ex.Message);
                oResult_Modify_Data_Settings.Stack_Trace = is_send_stack_trace ? string.Format("Modify_Data_Settings : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Modify_Data_Settings.Exception_Message = ex.Message;
                oResult_Modify_Data_Settings.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Modify_Data_Settings;
        #endregion
    }
    #endregion
    #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List
    [HttpGet]
    [Route("Get_Organization_color_scheme_By_ORGANIZATION_ID_List")]
    public Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List Get_Organization_color_scheme_By_ORGANIZATION_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List = new Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List();
        Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID_List = new Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																										.ToString()
																										.Split(',')
																										.Where(val => int.TryParse(val, out _))
																										.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.i_Result = oBLC.Get_Organization_color_scheme_By_ORGANIZATION_ID_List(oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List = oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List = oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.Exception_Message = string.Format("Get_Organization_color_scheme_By_ORGANIZATION_ID_List : {0}", ex.Message);
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_color_scheme_By_ORGANIZATION_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.Exception_Message = ex.Message;
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID_List;
        #endregion
    }
    #endregion
    #region Modify_Organization_Details
    [HttpPost]
    [Route("Modify_Organization_Details")]
    public Result_Modify_Organization_Details Modify_Organization_Details(Params_Modify_Organization_Details i_Params_Modify_Organization_Details)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Modify_Organization_Details oResult_Modify_Organization_Details = new Result_Modify_Organization_Details();
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
                oResult_Modify_Organization_Details.i_Result = oBLC.Modify_Organization_Details(i_Params_Modify_Organization_Details);
                oResult_Modify_Organization_Details.Params_Modify_Organization_Details = i_Params_Modify_Organization_Details;
            }
        }
        catch (Exception ex)
        {
            oResult_Modify_Organization_Details.Params_Modify_Organization_Details = i_Params_Modify_Organization_Details;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Modify_Organization_Details.Exception_Message = string.Format("Modify_Organization_Details : {0}", ex.Message);
                oResult_Modify_Organization_Details.Stack_Trace = is_send_stack_trace ? string.Format("Modify_Organization_Details : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Modify_Organization_Details.Exception_Message = ex.Message;
                oResult_Modify_Organization_Details.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Modify_Organization_Details;
        #endregion
    }
    #endregion
    #region Edit_Organization_color_scheme
    [HttpPost]
    [Route("Edit_Organization_color_scheme")]
    public Result_Edit_Organization_color_scheme Edit_Organization_color_scheme(Organization_color_scheme i_Organization_color_scheme)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_color_scheme oResult_Edit_Organization_color_scheme = new Result_Edit_Organization_color_scheme();
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
                oBLC.Edit_Organization_color_scheme(i_Organization_color_scheme);
                oResult_Edit_Organization_color_scheme.Organization_color_scheme = i_Organization_color_scheme;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_color_scheme.Exception_Message = string.Format("Edit_Organization_color_scheme : {0}", ex.Message);
                oResult_Edit_Organization_color_scheme.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_color_scheme : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_color_scheme.Exception_Message = ex.Message;
                oResult_Edit_Organization_color_scheme.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_color_scheme;
        #endregion
    }
    #endregion
    #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_relation_By_PARENT_ORGANIZATION_ID")]
    public Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID Get_Organization_relation_By_PARENT_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID = new Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID();
        Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID = new Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["PARENT_ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["PARENT_ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["PARENT_ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["PARENT_ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["PARENT_ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_relation_By_PARENT_ORGANIZATION_ID(oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID);
                oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID = oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID = oParams_Get_Organization_relation_By_PARENT_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_relation_By_PARENT_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_relation_By_PARENT_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_relation_By_PARENT_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Organization_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_By_ORGANIZATION_ID")]
    public Result_Get_Organization_By_ORGANIZATION_ID Get_Organization_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_By_ORGANIZATION_ID oResult_Get_Organization_By_ORGANIZATION_ID = new Result_Get_Organization_By_ORGANIZATION_ID();
        Params_Get_Organization_By_ORGANIZATION_ID oParams_Get_Organization_By_ORGANIZATION_ID = new Params_Get_Organization_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_By_ORGANIZATION_ID(oParams_Get_Organization_By_ORGANIZATION_ID);
                oResult_Get_Organization_By_ORGANIZATION_ID.Params_Get_Organization_By_ORGANIZATION_ID = oParams_Get_Organization_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_By_ORGANIZATION_ID.Params_Get_Organization_By_ORGANIZATION_ID = oParams_Get_Organization_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Organization_theme_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_theme_By_ORGANIZATION_ID")]
    public Result_Get_Organization_theme_By_ORGANIZATION_ID Get_Organization_theme_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_theme_By_ORGANIZATION_ID oResult_Get_Organization_theme_By_ORGANIZATION_ID = new Result_Get_Organization_theme_By_ORGANIZATION_ID();
        Params_Get_Organization_theme_By_ORGANIZATION_ID oParams_Get_Organization_theme_By_ORGANIZATION_ID = new Params_Get_Organization_theme_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_theme_By_ORGANIZATION_ID(oParams_Get_Organization_theme_By_ORGANIZATION_ID);
                oResult_Get_Organization_theme_By_ORGANIZATION_ID.Params_Get_Organization_theme_By_ORGANIZATION_ID = oParams_Get_Organization_theme_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_theme_By_ORGANIZATION_ID.Params_Get_Organization_theme_By_ORGANIZATION_ID = oParams_Get_Organization_theme_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_theme_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_theme_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_theme_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_theme_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_theme_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
    [HttpGet]
    [Route("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID")]
    public Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID = new Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID();
        Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID = new Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            if (HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.i_Result = oBLC.Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID(oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID);
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID = oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID = oParams_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.Exception_Message = string.Format("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID : {0}", ex.Message);
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_districtnex_module_List
    [HttpPost]
    [Route("Edit_Organization_districtnex_module_List")]
    public Result_Edit_Organization_districtnex_module_List Edit_Organization_districtnex_module_List(Params_Edit_Organization_districtnex_module_List i_Params_Edit_Organization_districtnex_module_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_districtnex_module_List oResult_Edit_Organization_districtnex_module_List = new Result_Edit_Organization_districtnex_module_List();
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
                oBLC.Edit_Organization_districtnex_module_List(i_Params_Edit_Organization_districtnex_module_List);
                oResult_Edit_Organization_districtnex_module_List.Params_Edit_Organization_districtnex_module_List = i_Params_Edit_Organization_districtnex_module_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_districtnex_module_List.Exception_Message = string.Format("Edit_Organization_districtnex_module_List : {0}", ex.Message);
                oResult_Edit_Organization_districtnex_module_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_districtnex_module_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_districtnex_module_List.Exception_Message = ex.Message;
                oResult_Edit_Organization_districtnex_module_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_districtnex_module_List;
        #endregion
    }
    #endregion
    #region Get_Organization_By_PARENT_ORGANIZATION_ID
    [HttpPost]
    [Route("Get_Organization_By_PARENT_ORGANIZATION_ID")]
    public Result_Get_Organization_By_PARENT_ORGANIZATION_ID Get_Organization_By_PARENT_ORGANIZATION_ID(Params_Get_Organization_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_By_PARENT_ORGANIZATION_ID oResult_Get_Organization_By_PARENT_ORGANIZATION_ID = new Result_Get_Organization_By_PARENT_ORGANIZATION_ID();
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
                oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_By_PARENT_ORGANIZATION_ID(i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID);
                oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.Params_Get_Organization_By_PARENT_ORGANIZATION_ID = i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.Params_Get_Organization_By_PARENT_ORGANIZATION_ID = i_Params_Get_Organization_By_PARENT_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_By_PARENT_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_By_PARENT_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_By_PARENT_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_By_PARENT_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_level_access_List
    [HttpPost]
    [Route("Edit_Organization_level_access_List")]
    public Result_Edit_Organization_level_access_List Edit_Organization_level_access_List(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_level_access_List oResult_Edit_Organization_level_access_List = new Result_Edit_Organization_level_access_List();
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
                oBLC.Edit_Organization_level_access_List(i_Params_Edit_Organization_level_access_List);
                oResult_Edit_Organization_level_access_List.Params_Edit_Organization_level_access_List = i_Params_Edit_Organization_level_access_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_level_access_List.Exception_Message = string.Format("Edit_Organization_level_access_List : {0}", ex.Message);
                oResult_Edit_Organization_level_access_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_level_access_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_level_access_List.Exception_Message = ex.Message;
                oResult_Edit_Organization_level_access_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_level_access_List;
        #endregion
    }
    #endregion
    #region Edit_Organization_theme
    [HttpPost]
    [Route("Edit_Organization_theme")]
    public Result_Edit_Organization_theme Edit_Organization_theme(Organization_theme i_Organization_theme)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_theme oResult_Edit_Organization_theme = new Result_Edit_Organization_theme();
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
                oBLC.Edit_Organization_theme(i_Organization_theme);
                oResult_Edit_Organization_theme.Organization_theme = i_Organization_theme;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_theme.Exception_Message = string.Format("Edit_Organization_theme : {0}", ex.Message);
                oResult_Edit_Organization_theme.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_theme : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_theme.Exception_Message = ex.Message;
                oResult_Edit_Organization_theme.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_theme;
        #endregion
    }
    #endregion
    #region Delete_Organization_Picture
    [HttpPost]
    [Route("Delete_Organization_Picture")]
    public Result_Delete_Organization_Picture Delete_Organization_Picture(Params_Delete_Organization_Picture i_Params_Delete_Organization_Picture)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_Picture oResult_Delete_Organization_Picture = new Result_Delete_Organization_Picture();
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
                oResult_Delete_Organization_Picture.i_Result = oBLC.Delete_Organization_Picture(i_Params_Delete_Organization_Picture);
                oResult_Delete_Organization_Picture.Params_Delete_Organization_Picture = i_Params_Delete_Organization_Picture;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_Picture.Params_Delete_Organization_Picture = i_Params_Delete_Organization_Picture;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_Picture.Exception_Message = string.Format("Delete_Organization_Picture : {0}", ex.Message);
                oResult_Delete_Organization_Picture.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_Picture : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_Picture.Exception_Message = ex.Message;
                oResult_Delete_Organization_Picture.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_Picture;
        #endregion
    }
    #endregion
    #region Get_Organization_By_ORGANIZATION_ID_List
    [HttpGet]
    [Route("Get_Organization_By_ORGANIZATION_ID_List")]
    public Result_Get_Organization_By_ORGANIZATION_ID_List Get_Organization_By_ORGANIZATION_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_By_ORGANIZATION_ID_List oResult_Get_Organization_By_ORGANIZATION_ID_List = new Result_Get_Organization_By_ORGANIZATION_ID_List();
        Params_Get_Organization_By_ORGANIZATION_ID_List oParams_Get_Organization_By_ORGANIZATION_ID_List = new Params_Get_Organization_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																						.ToString()
																						.Split(',')
																						.Where(val => int.TryParse(val, out _))
																						.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_By_ORGANIZATION_ID_List.i_Result = oBLC.Get_Organization_By_ORGANIZATION_ID_List(oParams_Get_Organization_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_By_ORGANIZATION_ID_List.Params_Get_Organization_By_ORGANIZATION_ID_List = oParams_Get_Organization_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_By_ORGANIZATION_ID_List.Params_Get_Organization_By_ORGANIZATION_ID_List = oParams_Get_Organization_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_By_ORGANIZATION_ID_List.Exception_Message = string.Format("Get_Organization_By_ORGANIZATION_ID_List : {0}", ex.Message);
                oResult_Get_Organization_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_By_ORGANIZATION_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_By_ORGANIZATION_ID_List.Exception_Message = ex.Message;
                oResult_Get_Organization_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_By_ORGANIZATION_ID_List;
        #endregion
    }
    #endregion
    #region Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
    [HttpPost]
    [Route("Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading")]
    public Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading = new Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading();
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
                oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.i_Result = oBLC.Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading(i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading);
                oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading = i_Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.Exception_Message = string.Format("Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading : {0}", ex.Message);
                oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.Exception_Message = ex.Message;
                oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading;
        #endregion
    }
    #endregion
    #region Get_Organization_color_scheme_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_color_scheme_By_ORGANIZATION_ID")]
    public Result_Get_Organization_color_scheme_By_ORGANIZATION_ID Get_Organization_color_scheme_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_color_scheme_By_ORGANIZATION_ID oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID = new Result_Get_Organization_color_scheme_By_ORGANIZATION_ID();
        Params_Get_Organization_color_scheme_By_ORGANIZATION_ID oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID = new Params_Get_Organization_color_scheme_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_color_scheme_By_ORGANIZATION_ID(oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID);
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID = oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID = oParams_Get_Organization_color_scheme_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_color_scheme_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_color_scheme_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_color_scheme_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Organization_By_OWNER_ID
    [HttpGet]
    [Route("Get_Organization_By_OWNER_ID")]
    public Result_Get_Organization_By_OWNER_ID Get_Organization_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_By_OWNER_ID oResult_Get_Organization_By_OWNER_ID = new Result_Get_Organization_By_OWNER_ID();
        Params_Get_Organization_By_OWNER_ID oParams_Get_Organization_By_OWNER_ID = new Params_Get_Organization_By_OWNER_ID();
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
                oParams_Get_Organization_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_By_OWNER_ID.i_Result = oBLC.Get_Organization_By_OWNER_ID(oParams_Get_Organization_By_OWNER_ID);
                oResult_Get_Organization_By_OWNER_ID.Params_Get_Organization_By_OWNER_ID = oParams_Get_Organization_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_By_OWNER_ID.Params_Get_Organization_By_OWNER_ID = oParams_Get_Organization_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_By_OWNER_ID.Exception_Message = string.Format("Get_Organization_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Organization_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_chart_color_List
    [HttpPost]
    [Route("Edit_Organization_chart_color_List")]
    public Result_Edit_Organization_chart_color_List Edit_Organization_chart_color_List(Params_Edit_Organization_chart_color_List i_Params_Edit_Organization_chart_color_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_chart_color_List oResult_Edit_Organization_chart_color_List = new Result_Edit_Organization_chart_color_List();
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
                oBLC.Edit_Organization_chart_color_List(i_Params_Edit_Organization_chart_color_List);
                oResult_Edit_Organization_chart_color_List.Params_Edit_Organization_chart_color_List = i_Params_Edit_Organization_chart_color_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_chart_color_List.Exception_Message = string.Format("Edit_Organization_chart_color_List : {0}", ex.Message);
                oResult_Edit_Organization_chart_color_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_chart_color_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_chart_color_List.Exception_Message = ex.Message;
                oResult_Edit_Organization_chart_color_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_chart_color_List;
        #endregion
    }
    #endregion
    #region Get_Organization_level_access_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_level_access_By_ORGANIZATION_ID")]
    public Result_Get_Organization_level_access_By_ORGANIZATION_ID Get_Organization_level_access_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_level_access_By_ORGANIZATION_ID oResult_Get_Organization_level_access_By_ORGANIZATION_ID = new Result_Get_Organization_level_access_By_ORGANIZATION_ID();
        Params_Get_Organization_level_access_By_ORGANIZATION_ID oParams_Get_Organization_level_access_By_ORGANIZATION_ID = new Params_Get_Organization_level_access_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_level_access_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_level_access_By_ORGANIZATION_ID(oParams_Get_Organization_level_access_By_ORGANIZATION_ID);
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID.Params_Get_Organization_level_access_By_ORGANIZATION_ID = oParams_Get_Organization_level_access_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_level_access_By_ORGANIZATION_ID.Params_Get_Organization_level_access_By_ORGANIZATION_ID = oParams_Get_Organization_level_access_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_level_access_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_level_access_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_level_access_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv
    [HttpGet]
    [Route("Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv")]
    public Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv = new Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv();
        Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID = new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.i_Result = oBLC.Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv(oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID);
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID = oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID = oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.Exception_Message = string.Format("Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv : {0}", ex.Message);
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv;
        #endregion
    }
    #endregion
    #region Restore_Organization
    [HttpPost]
    [Route("Restore_Organization")]
    public Result_Restore_Organization Restore_Organization(Params_Restore_Organization i_Params_Restore_Organization)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Restore_Organization oResult_Restore_Organization = new Result_Restore_Organization();
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
                oResult_Restore_Organization.i_Result = oBLC.Restore_Organization(i_Params_Restore_Organization);
                oResult_Restore_Organization.Params_Restore_Organization = i_Params_Restore_Organization;
            }
        }
        catch (Exception ex)
        {
            oResult_Restore_Organization.Params_Restore_Organization = i_Params_Restore_Organization;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Restore_Organization.Exception_Message = string.Format("Restore_Organization : {0}", ex.Message);
                oResult_Restore_Organization.Stack_Trace = is_send_stack_trace ? string.Format("Restore_Organization : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Restore_Organization.Exception_Message = ex.Message;
                oResult_Restore_Organization.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Restore_Organization;
        #endregion
    }
    #endregion
    #region Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
    [HttpGet]
    [Route("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID")]
    public Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = new Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID();
        Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = new Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.i_Result = oBLC.Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID(oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID);
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID = oParams_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.Exception_Message = string.Format("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID : {0}", ex.Message);
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID;
        #endregion
    }
    #endregion
    #region Delete_Organization_level_access
    [HttpPost]
    [Route("Delete_Organization_level_access")]
    public Result_Delete_Organization_level_access Delete_Organization_level_access(Params_Delete_Organization_level_access i_Params_Delete_Organization_level_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_level_access oResult_Delete_Organization_level_access = new Result_Delete_Organization_level_access();
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
                oBLC.Delete_Organization_level_access(i_Params_Delete_Organization_level_access);
                oResult_Delete_Organization_level_access.Params_Delete_Organization_level_access = i_Params_Delete_Organization_level_access;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_level_access.Params_Delete_Organization_level_access = i_Params_Delete_Organization_level_access;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_level_access.Exception_Message = string.Format("Delete_Organization_level_access : {0}", ex.Message);
                oResult_Delete_Organization_level_access.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_level_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_level_access.Exception_Message = ex.Message;
                oResult_Delete_Organization_level_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_level_access;
        #endregion
    }
    #endregion
    #region Get_Organization_districtnex_module_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_districtnex_module_By_ORGANIZATION_ID")]
    public Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID Get_Organization_districtnex_module_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID = new Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID();
        Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID = new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_districtnex_module_By_ORGANIZATION_ID(oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID);
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID = oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID = oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_districtnex_module_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_districtnex_module_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_level_access
    [HttpPost]
    [Route("Edit_Organization_level_access")]
    public Result_Edit_Organization_level_access Edit_Organization_level_access(Organization_level_access i_Organization_level_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_level_access oResult_Edit_Organization_level_access = new Result_Edit_Organization_level_access();
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
                oBLC.Edit_Organization_level_access(i_Organization_level_access);
                oResult_Edit_Organization_level_access.Organization_level_access = i_Organization_level_access;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_level_access.Exception_Message = string.Format("Edit_Organization_level_access : {0}", ex.Message);
                oResult_Edit_Organization_level_access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_level_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_level_access.Exception_Message = ex.Message;
                oResult_Edit_Organization_level_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_level_access;
        #endregion
    }
    #endregion
    #region Delete_Organization_level_access_By_ORGANIZATION_ID
    [HttpPost]
    [Route("Delete_Organization_level_access_By_ORGANIZATION_ID")]
    public Result_Delete_Organization_level_access_By_ORGANIZATION_ID Delete_Organization_level_access_By_ORGANIZATION_ID(Params_Delete_Organization_level_access_By_ORGANIZATION_ID i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_level_access_By_ORGANIZATION_ID oResult_Delete_Organization_level_access_By_ORGANIZATION_ID = new Result_Delete_Organization_level_access_By_ORGANIZATION_ID();
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
                oBLC.Delete_Organization_level_access_By_ORGANIZATION_ID(i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID);
                oResult_Delete_Organization_level_access_By_ORGANIZATION_ID.Params_Delete_Organization_level_access_By_ORGANIZATION_ID = i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_level_access_By_ORGANIZATION_ID.Params_Delete_Organization_level_access_By_ORGANIZATION_ID = i_Params_Delete_Organization_level_access_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_level_access_By_ORGANIZATION_ID.Exception_Message = string.Format("Delete_Organization_level_access_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Delete_Organization_level_access_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_level_access_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_level_access_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Delete_Organization_level_access_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_level_access_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_districtnex_module
    [HttpPost]
    [Route("Edit_Organization_districtnex_module")]
    public Result_Edit_Organization_districtnex_module Edit_Organization_districtnex_module(Organization_districtnex_module i_Organization_districtnex_module)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_districtnex_module oResult_Edit_Organization_districtnex_module = new Result_Edit_Organization_districtnex_module();
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
                oBLC.Edit_Organization_districtnex_module(i_Organization_districtnex_module);
                oResult_Edit_Organization_districtnex_module.Organization_districtnex_module = i_Organization_districtnex_module;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_districtnex_module.Exception_Message = string.Format("Edit_Organization_districtnex_module : {0}", ex.Message);
                oResult_Edit_Organization_districtnex_module.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_districtnex_module : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_districtnex_module.Exception_Message = ex.Message;
                oResult_Edit_Organization_districtnex_module.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_districtnex_module;
        #endregion
    }
    #endregion
    #region Delete_Organization_districtnex_module_By_ORGANIZATION_ID
    [HttpPost]
    [Route("Delete_Organization_districtnex_module_By_ORGANIZATION_ID")]
    public Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID Delete_Organization_districtnex_module_By_ORGANIZATION_ID(Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID = new Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID();
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
                oBLC.Delete_Organization_districtnex_module_By_ORGANIZATION_ID(i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID);
                oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID = i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID = i_Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.Exception_Message = string.Format("Delete_Organization_districtnex_module_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_districtnex_module_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_districtnex_module_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_color_scheme_List
    [HttpPost]
    [Route("Edit_Organization_color_scheme_List")]
    public Result_Edit_Organization_color_scheme_List Edit_Organization_color_scheme_List(Params_Edit_Organization_color_scheme_List i_Params_Edit_Organization_color_scheme_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_color_scheme_List oResult_Edit_Organization_color_scheme_List = new Result_Edit_Organization_color_scheme_List();
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
                oBLC.Edit_Organization_color_scheme_List(i_Params_Edit_Organization_color_scheme_List);
                oResult_Edit_Organization_color_scheme_List.Params_Edit_Organization_color_scheme_List = i_Params_Edit_Organization_color_scheme_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_color_scheme_List.Exception_Message = string.Format("Edit_Organization_color_scheme_List : {0}", ex.Message);
                oResult_Edit_Organization_color_scheme_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_color_scheme_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_color_scheme_List.Exception_Message = ex.Message;
                oResult_Edit_Organization_color_scheme_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_color_scheme_List;
        #endregion
    }
    #endregion
    #region Delete_Organization_color_scheme_By_ORGANIZATION_ID
    [HttpPost]
    [Route("Delete_Organization_color_scheme_By_ORGANIZATION_ID")]
    public Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID Delete_Organization_color_scheme_By_ORGANIZATION_ID(Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID = new Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID();
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
                oBLC.Delete_Organization_color_scheme_By_ORGANIZATION_ID(i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID);
                oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID.Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID = i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID.Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID = i_Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID.Exception_Message = string.Format("Delete_Organization_color_scheme_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_color_scheme_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_color_scheme_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Edit_Organization_log_config
    [HttpPost]
    [Route("Edit_Organization_log_config")]
    public Result_Edit_Organization_log_config Edit_Organization_log_config(Organization_log_config i_Organization_log_config)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_log_config oResult_Edit_Organization_log_config = new Result_Edit_Organization_log_config();
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
                oBLC.Edit_Organization_log_config(i_Organization_log_config);
                oResult_Edit_Organization_log_config.Organization_log_config = i_Organization_log_config;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_log_config.Exception_Message = string.Format("Edit_Organization_log_config : {0}", ex.Message);
                oResult_Edit_Organization_log_config.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_log_config : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_log_config.Exception_Message = ex.Message;
                oResult_Edit_Organization_log_config.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_log_config;
        #endregion
    }
    #endregion
    #region Edit_Organization_log_config_List
    [HttpPost]
    [Route("Edit_Organization_log_config_List")]
    public Result_Edit_Organization_log_config_List Edit_Organization_log_config_List(Params_Edit_Organization_log_config_List i_Params_Edit_Organization_log_config_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Organization_log_config_List oResult_Edit_Organization_log_config_List = new Result_Edit_Organization_log_config_List();
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
                oBLC.Edit_Organization_log_config_List(i_Params_Edit_Organization_log_config_List);
                oResult_Edit_Organization_log_config_List.Params_Edit_Organization_log_config_List = i_Params_Edit_Organization_log_config_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Organization_log_config_List.Exception_Message = string.Format("Edit_Organization_log_config_List : {0}", ex.Message);
                oResult_Edit_Organization_log_config_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Organization_log_config_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Organization_log_config_List.Exception_Message = ex.Message;
                oResult_Edit_Organization_log_config_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Organization_log_config_List;
        #endregion
    }
    #endregion
    #region Get_Organization_log_config_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_log_config_By_ORGANIZATION_ID")]
    public Result_Get_Organization_log_config_By_ORGANIZATION_ID Get_Organization_log_config_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_log_config_By_ORGANIZATION_ID oResult_Get_Organization_log_config_By_ORGANIZATION_ID = new Result_Get_Organization_log_config_By_ORGANIZATION_ID();
        Params_Get_Organization_log_config_By_ORGANIZATION_ID oParams_Get_Organization_log_config_By_ORGANIZATION_ID = new Params_Get_Organization_log_config_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_log_config_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_log_config_By_ORGANIZATION_ID(oParams_Get_Organization_log_config_By_ORGANIZATION_ID);
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID.Params_Get_Organization_log_config_By_ORGANIZATION_ID = oParams_Get_Organization_log_config_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_log_config_By_ORGANIZATION_ID.Params_Get_Organization_log_config_By_ORGANIZATION_ID = oParams_Get_Organization_log_config_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_log_config_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_log_config_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_log_config_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Delete_Organization_log_config_By_ORGANIZATION_ID
    [HttpPost]
    [Route("Delete_Organization_log_config_By_ORGANIZATION_ID")]
    public Result_Delete_Organization_log_config_By_ORGANIZATION_ID Delete_Organization_log_config_By_ORGANIZATION_ID(Params_Delete_Organization_log_config_By_ORGANIZATION_ID i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Organization_log_config_By_ORGANIZATION_ID oResult_Delete_Organization_log_config_By_ORGANIZATION_ID = new Result_Delete_Organization_log_config_By_ORGANIZATION_ID();
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
                oBLC.Delete_Organization_log_config_By_ORGANIZATION_ID(i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID);
                oResult_Delete_Organization_log_config_By_ORGANIZATION_ID.Params_Delete_Organization_log_config_By_ORGANIZATION_ID = i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Organization_log_config_By_ORGANIZATION_ID.Params_Delete_Organization_log_config_By_ORGANIZATION_ID = i_Params_Delete_Organization_log_config_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Organization_log_config_By_ORGANIZATION_ID.Exception_Message = string.Format("Delete_Organization_log_config_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Delete_Organization_log_config_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Organization_log_config_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Organization_log_config_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Delete_Organization_log_config_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Organization_log_config_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv = new Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv();
        Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List = new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																											.ToString()
																											.Split(',')
																											.Where(val => int.TryParse(val, out _))
																											.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List = oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List = oParams_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_Organization_image_By_ORGANIZATION_ID_List
    [HttpGet]
    [Route("Get_Organization_image_By_ORGANIZATION_ID_List")]
    public Result_Get_Organization_image_By_ORGANIZATION_ID_List Get_Organization_image_By_ORGANIZATION_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_image_By_ORGANIZATION_ID_List oResult_Get_Organization_image_By_ORGANIZATION_ID_List = new Result_Get_Organization_image_By_ORGANIZATION_ID_List();
        Params_Get_Organization_image_By_ORGANIZATION_ID_List oParams_Get_Organization_image_By_ORGANIZATION_ID_List = new Params_Get_Organization_image_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_image_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																								.ToString()
																								.Split(',')
																								.Where(val => int.TryParse(val, out _))
																								.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List.i_Result = oBLC.Get_Organization_image_By_ORGANIZATION_ID_List(oParams_Get_Organization_image_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List.Params_Get_Organization_image_By_ORGANIZATION_ID_List = oParams_Get_Organization_image_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_image_By_ORGANIZATION_ID_List.Params_Get_Organization_image_By_ORGANIZATION_ID_List = oParams_Get_Organization_image_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List.Exception_Message = string.Format("Get_Organization_image_By_ORGANIZATION_ID_List : {0}", ex.Message);
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_image_By_ORGANIZATION_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List.Exception_Message = ex.Message;
                oResult_Get_Organization_image_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_image_By_ORGANIZATION_ID_List;
        #endregion
    }
    #endregion
    #region Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv = new Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv();
        Params_Get_Organization_level_access_By_ORGANIZATION_ID_List oParams_Get_Organization_level_access_By_ORGANIZATION_ID_List = new Params_Get_Organization_level_access_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_level_access_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																										.ToString()
																										.Split(',')
																										.Where(val => int.TryParse(val, out _))
																										.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(oParams_Get_Organization_level_access_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_level_access_By_ORGANIZATION_ID_List = oParams_Get_Organization_level_access_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_level_access_By_ORGANIZATION_ID_List = oParams_Get_Organization_level_access_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv = new Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv();
        Params_Get_Organization_log_config_By_ORGANIZATION_ID_List oParams_Get_Organization_log_config_By_ORGANIZATION_ID_List = new Params_Get_Organization_log_config_By_ORGANIZATION_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID_LIST"].ToString() != "")
            {
                oParams_Get_Organization_log_config_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																									.ToString()
																									.Split(',')
																									.Where(val => int.TryParse(val, out _))
																									.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(oParams_Get_Organization_log_config_By_ORGANIZATION_ID_List);
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_log_config_By_ORGANIZATION_ID_List = oParams_Get_Organization_log_config_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.Params_Get_Organization_log_config_By_ORGANIZATION_ID_List = oParams_Get_Organization_log_config_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Get_Organization_theme_By_ORGANIZATION_ID_Adv
    [HttpGet]
    [Route("Get_Organization_theme_By_ORGANIZATION_ID_Adv")]
    public Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv Get_Organization_theme_By_ORGANIZATION_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv = new Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv();
        Params_Get_Organization_theme_By_ORGANIZATION_ID oParams_Get_Organization_theme_By_ORGANIZATION_ID = new Params_Get_Organization_theme_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_theme_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.i_Result = oBLC.Get_Organization_theme_By_ORGANIZATION_ID_Adv(oParams_Get_Organization_theme_By_ORGANIZATION_ID);
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.Params_Get_Organization_theme_By_ORGANIZATION_ID = oParams_Get_Organization_theme_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.Params_Get_Organization_theme_By_ORGANIZATION_ID = oParams_Get_Organization_theme_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.Exception_Message = string.Format("Get_Organization_theme_By_ORGANIZATION_ID_Adv : {0}", ex.Message);
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_theme_By_ORGANIZATION_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_theme_By_ORGANIZATION_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Organization_image_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_Organization_image_By_ORGANIZATION_ID")]
    public Result_Get_Organization_image_By_ORGANIZATION_ID Get_Organization_image_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Organization_image_By_ORGANIZATION_ID oResult_Get_Organization_image_By_ORGANIZATION_ID = new Result_Get_Organization_image_By_ORGANIZATION_ID();
        Params_Get_Organization_image_By_ORGANIZATION_ID oParams_Get_Organization_image_By_ORGANIZATION_ID = new Params_Get_Organization_image_By_ORGANIZATION_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ORGANIZATION_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Organization_image_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID.i_Result = oBLC.Get_Organization_image_By_ORGANIZATION_ID(oParams_Get_Organization_image_By_ORGANIZATION_ID);
                oResult_Get_Organization_image_By_ORGANIZATION_ID.Params_Get_Organization_image_By_ORGANIZATION_ID = oParams_Get_Organization_image_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Organization_image_By_ORGANIZATION_ID.Params_Get_Organization_image_By_ORGANIZATION_ID = oParams_Get_Organization_image_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_Organization_image_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_Organization_image_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Organization_image_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Organization_image_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_Organization_image_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Organization_image_By_ORGANIZATION_ID;
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
#region Result_Check_Organization_Deletion_Status
public partial class Result_Check_Organization_Deletion_Status : Action_Result
{
    #region Properties.
    #endregion
}
#endregion
#region Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID
public partial class Result_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID : Action_Result
{
    #region Properties.
    public List<Organization_log_config> i_Result { get; set; }
    public Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID Params_Get_Organization_log_config_By_ORGANIZATION_ID_LOG_TYPE_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization
public partial class Result_Edit_Organization : Action_Result
{
    #region Properties.
    public Organization Organization { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_Organization_image_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Organization_image> i_Result { get; set; }
    public Params_Get_Organization_image_By_ORGANIZATION_ID_List Params_Get_Organization_image_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_theme
public partial class Result_Delete_Organization_theme : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_theme Params_Delete_Organization_theme { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv
public partial class Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID_Adv : Action_Result
{
    #region Properties.
    public List<Organization_level_access> i_Result { get; set; }
    public Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_Organization_theme_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Organization_theme> i_Result { get; set; }
    public Params_Get_Organization_theme_By_ORGANIZATION_ID_List Params_Get_Organization_theme_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_Custom
public partial class Result_Edit_Organization_Custom : Action_Result
{
    #region Properties.
    public Organization i_Result { get; set; }
    public Params_Edit_Organization_Custom Params_Edit_Organization_Custom { get; set; }
    #endregion
}
#endregion
#region Result_Schedule_Organization_for_Delete
public partial class Result_Schedule_Organization_for_Delete : Action_Result
{
    #region Properties.
    public Organization i_Result { get; set; }
    public Params_Schedule_Organization_for_Delete Params_Schedule_Organization_for_Delete { get; set; }
    #endregion
}
#endregion
#region Result_Modify_Data_Settings
public partial class Result_Modify_Data_Settings : Action_Result
{
    #region Properties.
    public Data_Settings i_Result { get; set; }
    public Params_Modify_Data_Settings Params_Modify_Data_Settings { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List
public partial class Result_Get_Organization_color_scheme_By_ORGANIZATION_ID_List : Action_Result
{
    #region Properties.
    public List<Organization_color_scheme> i_Result { get; set; }
    public Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Modify_Organization_Details
public partial class Result_Modify_Organization_Details : Action_Result
{
    #region Properties.
    public Organization i_Result { get; set; }
    public Params_Modify_Organization_Details Params_Modify_Organization_Details { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_color_scheme
public partial class Result_Edit_Organization_color_scheme : Action_Result
{
    #region Properties.
    public Organization_color_scheme Organization_color_scheme { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID
public partial class Result_Get_Organization_relation_By_PARENT_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_relation> i_Result { get; set; }
    public Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_By_ORGANIZATION_ID
public partial class Result_Get_Organization_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public Organization i_Result { get; set; }
    public Params_Get_Organization_By_ORGANIZATION_ID Params_Get_Organization_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_theme_By_ORGANIZATION_ID
public partial class Result_Get_Organization_theme_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_theme> i_Result { get; set; }
    public Params_Get_Organization_theme_By_ORGANIZATION_ID Params_Get_Organization_theme_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID
public partial class Result_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID : Action_Result
{
    #region Properties.
    public List<Organization_level_access> i_Result { get; set; }
    public Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID Params_Get_Organization_level_access_By_ORGANIZATION_ID_DATA_LEVEL_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_districtnex_module_List
public partial class Result_Edit_Organization_districtnex_module_List : Action_Result
{
    #region Properties.
    public Params_Edit_Organization_districtnex_module_List Params_Edit_Organization_districtnex_module_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_By_PARENT_ORGANIZATION_ID
public partial class Result_Get_Organization_By_PARENT_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization> i_Result { get; set; }
    public Params_Get_Organization_By_PARENT_ORGANIZATION_ID Params_Get_Organization_By_PARENT_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_level_access_List
public partial class Result_Edit_Organization_level_access_List : Action_Result
{
    #region Properties.
    public Params_Edit_Organization_level_access_List Params_Edit_Organization_level_access_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_theme
public partial class Result_Edit_Organization_theme : Action_Result
{
    #region Properties.
    public Organization_theme Organization_theme { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_Picture
public partial class Result_Delete_Organization_Picture : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Delete_Organization_Picture Params_Delete_Organization_Picture { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_By_ORGANIZATION_ID_List
public partial class Result_Get_Organization_By_ORGANIZATION_ID_List : Action_Result
{
    #region Properties.
    public List<Organization> i_Result { get; set; }
    public Params_Get_Organization_By_ORGANIZATION_ID_List Params_Get_Organization_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading
public partial class Result_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading : Action_Result
{
    #region Properties.
    public Organization i_Result { get; set; }
    public Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading Params_Get_Organization_By_ORGANIZATION_ID_with_Custom_Eager_Loading { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_color_scheme_By_ORGANIZATION_ID
public partial class Result_Get_Organization_color_scheme_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_color_scheme> i_Result { get; set; }
    public Params_Get_Organization_color_scheme_By_ORGANIZATION_ID Params_Get_Organization_color_scheme_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_By_OWNER_ID
public partial class Result_Get_Organization_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Organization> i_Result { get; set; }
    public Params_Get_Organization_By_OWNER_ID Params_Get_Organization_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_chart_color_List
public partial class Result_Edit_Organization_chart_color_List : Action_Result
{
    #region Properties.
    public Params_Edit_Organization_chart_color_List Params_Edit_Organization_chart_color_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_level_access_By_ORGANIZATION_ID
public partial class Result_Get_Organization_level_access_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_level_access> i_Result { get; set; }
    public Params_Get_Organization_level_access_By_ORGANIZATION_ID Params_Get_Organization_level_access_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv
public partial class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_Adv : Action_Result
{
    #region Properties.
    public List<Organization_districtnex_module> i_Result { get; set; }
    public Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Restore_Organization
public partial class Result_Restore_Organization : Action_Result
{
    #region Properties.
    public Organization i_Result { get; set; }
    public Params_Restore_Organization Params_Restore_Organization { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID
public partial class Result_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID : Action_Result
{
    #region Properties.
    public List<Organization_level_access> i_Result { get; set; }
    public Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID Params_Get_Organization_level_access_By_DATA_LEVEL_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_level_access
public partial class Result_Delete_Organization_level_access : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_level_access Params_Delete_Organization_level_access { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID
public partial class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_districtnex_module> i_Result { get; set; }
    public Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_level_access
public partial class Result_Edit_Organization_level_access : Action_Result
{
    #region Properties.
    public Organization_level_access Organization_level_access { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_level_access_By_ORGANIZATION_ID
public partial class Result_Delete_Organization_level_access_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_level_access_By_ORGANIZATION_ID Params_Delete_Organization_level_access_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_districtnex_module
public partial class Result_Edit_Organization_districtnex_module : Action_Result
{
    #region Properties.
    public Organization_districtnex_module Organization_districtnex_module { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID
public partial class Result_Delete_Organization_districtnex_module_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID Params_Delete_Organization_districtnex_module_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_color_scheme_List
public partial class Result_Edit_Organization_color_scheme_List : Action_Result
{
    #region Properties.
    public Params_Edit_Organization_color_scheme_List Params_Edit_Organization_color_scheme_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID
public partial class Result_Delete_Organization_color_scheme_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID Params_Delete_Organization_color_scheme_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_log_config
public partial class Result_Edit_Organization_log_config : Action_Result
{
    #region Properties.
    public Organization_log_config Organization_log_config { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Organization_log_config_List
public partial class Result_Edit_Organization_log_config_List : Action_Result
{
    #region Properties.
    public Params_Edit_Organization_log_config_List Params_Edit_Organization_log_config_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_log_config_By_ORGANIZATION_ID
public partial class Result_Get_Organization_log_config_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_log_config> i_Result { get; set; }
    public Params_Get_Organization_log_config_By_ORGANIZATION_ID Params_Get_Organization_log_config_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Organization_log_config_By_ORGANIZATION_ID
public partial class Result_Delete_Organization_log_config_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Organization_log_config_By_ORGANIZATION_ID Params_Delete_Organization_log_config_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Organization_districtnex_module> i_Result { get; set; }
    public Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_image_By_ORGANIZATION_ID_List
public partial class Result_Get_Organization_image_By_ORGANIZATION_ID_List : Action_Result
{
    #region Properties.
    public List<Organization_image> i_Result { get; set; }
    public Params_Get_Organization_image_By_ORGANIZATION_ID_List Params_Get_Organization_image_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Organization_level_access> i_Result { get; set; }
    public Params_Get_Organization_level_access_By_ORGANIZATION_ID_List Params_Get_Organization_level_access_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<Organization_log_config> i_Result { get; set; }
    public Params_Get_Organization_log_config_By_ORGANIZATION_ID_List Params_Get_Organization_log_config_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv
public partial class Result_Get_Organization_theme_By_ORGANIZATION_ID_Adv : Action_Result
{
    #region Properties.
    public List<Organization_theme> i_Result { get; set; }
    public Params_Get_Organization_theme_By_ORGANIZATION_ID Params_Get_Organization_theme_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Organization_image_By_ORGANIZATION_ID
public partial class Result_Get_Organization_image_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<Organization_image> i_Result { get; set; }
    public Params_Get_Organization_image_By_ORGANIZATION_ID Params_Get_Organization_image_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
