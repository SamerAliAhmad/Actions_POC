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
public partial class SettingsManagementController : ControllerBase
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
    #region Edit_Setup
    [HttpPost]
    [Route("Edit_Setup")]
    public Result_Edit_Setup Edit_Setup(Setup i_Setup)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Setup oResult_Edit_Setup = new Result_Edit_Setup();
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
                oBLC.Edit_Setup(i_Setup);
                oResult_Edit_Setup.Setup = i_Setup;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Setup.Exception_Message = string.Format("Edit_Setup : {0}", ex.Message);
                oResult_Edit_Setup.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Setup : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Setup.Exception_Message = ex.Message;
                oResult_Edit_Setup.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Setup;
        #endregion
    }
    #endregion
    #region Get_Specialized_chart_configuration_By_MODULE
    [HttpGet]
    [Route("Get_Specialized_chart_configuration_By_MODULE")]
    public Result_Get_Specialized_chart_configuration_By_MODULE Get_Specialized_chart_configuration_By_MODULE()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Specialized_chart_configuration_By_MODULE oResult_Get_Specialized_chart_configuration_By_MODULE = new Result_Get_Specialized_chart_configuration_By_MODULE();
        Params_Get_Specialized_chart_configuration_By_MODULE oParams_Get_Specialized_chart_configuration_By_MODULE = new Params_Get_Specialized_chart_configuration_By_MODULE();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["MODULE"].FirstOrDefault() != null && HttpContext.Request.Query["MODULE"].ToString() != "undefined" && HttpContext.Request.Query["MODULE"].ToString() != "null" && HttpContext.Request.Query["MODULE"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Get_Specialized_chart_configuration_By_MODULE.MODULE = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["MODULE"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Specialized_chart_configuration_By_MODULE.i_Result = oBLC.Get_Specialized_chart_configuration_By_MODULE(oParams_Get_Specialized_chart_configuration_By_MODULE);
                oResult_Get_Specialized_chart_configuration_By_MODULE.Params_Get_Specialized_chart_configuration_By_MODULE = oParams_Get_Specialized_chart_configuration_By_MODULE;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Specialized_chart_configuration_By_MODULE.Params_Get_Specialized_chart_configuration_By_MODULE = oParams_Get_Specialized_chart_configuration_By_MODULE;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Specialized_chart_configuration_By_MODULE.Exception_Message = string.Format("Get_Specialized_chart_configuration_By_MODULE : {0}", ex.Message);
                oResult_Get_Specialized_chart_configuration_By_MODULE.Stack_Trace = is_send_stack_trace ? string.Format("Get_Specialized_chart_configuration_By_MODULE : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Specialized_chart_configuration_By_MODULE.Exception_Message = ex.Message;
                oResult_Get_Specialized_chart_configuration_By_MODULE.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Specialized_chart_configuration_By_MODULE;
        #endregion
    }
    #endregion
    #region Delete_District_geojson_By_DISTRICT_ID
    [HttpPost]
    [Route("Delete_District_geojson_By_DISTRICT_ID")]
    public Result_Delete_District_geojson_By_DISTRICT_ID Delete_District_geojson_By_DISTRICT_ID(Params_Delete_District_geojson_By_DISTRICT_ID i_Params_Delete_District_geojson_By_DISTRICT_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_District_geojson_By_DISTRICT_ID oResult_Delete_District_geojson_By_DISTRICT_ID = new Result_Delete_District_geojson_By_DISTRICT_ID();
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
                oBLC.Delete_District_geojson_By_DISTRICT_ID(i_Params_Delete_District_geojson_By_DISTRICT_ID);
                oResult_Delete_District_geojson_By_DISTRICT_ID.Params_Delete_District_geojson_By_DISTRICT_ID = i_Params_Delete_District_geojson_By_DISTRICT_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_District_geojson_By_DISTRICT_ID.Params_Delete_District_geojson_By_DISTRICT_ID = i_Params_Delete_District_geojson_By_DISTRICT_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_District_geojson_By_DISTRICT_ID.Exception_Message = string.Format("Delete_District_geojson_By_DISTRICT_ID : {0}", ex.Message);
                oResult_Delete_District_geojson_By_DISTRICT_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_District_geojson_By_DISTRICT_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_District_geojson_By_DISTRICT_ID.Exception_Message = ex.Message;
                oResult_Delete_District_geojson_By_DISTRICT_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_District_geojson_By_DISTRICT_ID;
        #endregion
    }
    #endregion
    #region Get_Dimension_chart_configuration
    [HttpPost]
    [Route("Get_Dimension_chart_configuration")]
    public Result_Get_Dimension_chart_configuration Get_Dimension_chart_configuration()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_chart_configuration oResult_Get_Dimension_chart_configuration = new Result_Get_Dimension_chart_configuration();
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
                oResult_Get_Dimension_chart_configuration.i_Result = oBLC.Get_Dimension_chart_configuration();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_chart_configuration.Exception_Message = string.Format("Get_Dimension_chart_configuration : {0}", ex.Message);
                oResult_Get_Dimension_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_chart_configuration.Exception_Message = ex.Message;
                oResult_Get_Dimension_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_chart_configuration;
        #endregion
    }
    #endregion
    #region Edit_Setup_category_List
    [HttpPost]
    [Route("Edit_Setup_category_List")]
    public Result_Edit_Setup_category_List Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Setup_category_List oResult_Edit_Setup_category_List = new Result_Edit_Setup_category_List();
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
                oBLC.Edit_Setup_category_List(i_Params_Edit_Setup_category_List);
                oResult_Edit_Setup_category_List.Params_Edit_Setup_category_List = i_Params_Edit_Setup_category_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Setup_category_List.Exception_Message = string.Format("Edit_Setup_category_List : {0}", ex.Message);
                oResult_Edit_Setup_category_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Setup_category_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Setup_category_List.Exception_Message = ex.Message;
                oResult_Edit_Setup_category_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Setup_category_List;
        #endregion
    }
    #endregion
    #region Get_Districtnex_module_By_OWNER_ID
    [HttpGet]
    [Route("Get_Districtnex_module_By_OWNER_ID")]
    public Result_Get_Districtnex_module_By_OWNER_ID Get_Districtnex_module_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Districtnex_module_By_OWNER_ID oResult_Get_Districtnex_module_By_OWNER_ID = new Result_Get_Districtnex_module_By_OWNER_ID();
        Params_Get_Districtnex_module_By_OWNER_ID oParams_Get_Districtnex_module_By_OWNER_ID = new Params_Get_Districtnex_module_By_OWNER_ID();
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
                oParams_Get_Districtnex_module_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Districtnex_module_By_OWNER_ID.i_Result = oBLC.Get_Districtnex_module_By_OWNER_ID(oParams_Get_Districtnex_module_By_OWNER_ID);
                oResult_Get_Districtnex_module_By_OWNER_ID.Params_Get_Districtnex_module_By_OWNER_ID = oParams_Get_Districtnex_module_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Districtnex_module_By_OWNER_ID.Params_Get_Districtnex_module_By_OWNER_ID = oParams_Get_Districtnex_module_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Districtnex_module_By_OWNER_ID.Exception_Message = string.Format("Get_Districtnex_module_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Districtnex_module_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Districtnex_module_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Districtnex_module_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Districtnex_module_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Districtnex_module_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Dimension_chart_configuration
    [HttpPost]
    [Route("Edit_Dimension_chart_configuration")]
    public Result_Edit_Dimension_chart_configuration Edit_Dimension_chart_configuration(Dimension_chart_configuration i_Dimension_chart_configuration)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Dimension_chart_configuration oResult_Edit_Dimension_chart_configuration = new Result_Edit_Dimension_chart_configuration();
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
                oResult_Edit_Dimension_chart_configuration.i_Result = oBLC.Edit_Dimension_chart_configuration(i_Dimension_chart_configuration);
                oResult_Edit_Dimension_chart_configuration.Dimension_chart_configuration = i_Dimension_chart_configuration;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Dimension_chart_configuration.Dimension_chart_configuration = i_Dimension_chart_configuration;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Dimension_chart_configuration.Exception_Message = string.Format("Edit_Dimension_chart_configuration : {0}", ex.Message);
                oResult_Edit_Dimension_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Dimension_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Dimension_chart_configuration.Exception_Message = ex.Message;
                oResult_Edit_Dimension_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Dimension_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_Setup_By_SETUP_ID_Adv
    [HttpGet]
    [Route("Get_Setup_By_SETUP_ID_Adv")]
    public Result_Get_Setup_By_SETUP_ID_Adv Get_Setup_By_SETUP_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Setup_By_SETUP_ID_Adv oResult_Get_Setup_By_SETUP_ID_Adv = new Result_Get_Setup_By_SETUP_ID_Adv();
        Params_Get_Setup_By_SETUP_ID oParams_Get_Setup_By_SETUP_ID = new Params_Get_Setup_By_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Setup_By_SETUP_ID.SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Setup_By_SETUP_ID_Adv.i_Result = oBLC.Get_Setup_By_SETUP_ID_Adv(oParams_Get_Setup_By_SETUP_ID);
                oResult_Get_Setup_By_SETUP_ID_Adv.Params_Get_Setup_By_SETUP_ID = oParams_Get_Setup_By_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Setup_By_SETUP_ID_Adv.Params_Get_Setup_By_SETUP_ID = oParams_Get_Setup_By_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Setup_By_SETUP_ID_Adv.Exception_Message = string.Format("Get_Setup_By_SETUP_ID_Adv : {0}", ex.Message);
                oResult_Get_Setup_By_SETUP_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Setup_By_SETUP_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Setup_By_SETUP_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Setup_By_SETUP_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Setup_By_SETUP_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Default_settings_By_OWNER_ID
    [HttpGet]
    [Route("Get_Default_settings_By_OWNER_ID")]
    public Result_Get_Default_settings_By_OWNER_ID Get_Default_settings_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Default_settings_By_OWNER_ID oResult_Get_Default_settings_By_OWNER_ID = new Result_Get_Default_settings_By_OWNER_ID();
        Params_Get_Default_settings_By_OWNER_ID oParams_Get_Default_settings_By_OWNER_ID = new Params_Get_Default_settings_By_OWNER_ID();
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
                oParams_Get_Default_settings_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Default_settings_By_OWNER_ID.i_Result = oBLC.Get_Default_settings_By_OWNER_ID(oParams_Get_Default_settings_By_OWNER_ID);
                oResult_Get_Default_settings_By_OWNER_ID.Params_Get_Default_settings_By_OWNER_ID = oParams_Get_Default_settings_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Default_settings_By_OWNER_ID.Params_Get_Default_settings_By_OWNER_ID = oParams_Get_Default_settings_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Default_settings_By_OWNER_ID.Exception_Message = string.Format("Get_Default_settings_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Default_settings_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Default_settings_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Default_settings_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Default_settings_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Default_settings_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Object_View
    [HttpPost]
    [Route("Edit_Object_View")]
    public Result_Edit_Object_View Edit_Object_View(Params_Edit_Object_View i_Params_Edit_Object_View)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Object_View oResult_Edit_Object_View = new Result_Edit_Object_View();
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
                oBLC.Edit_Object_View(i_Params_Edit_Object_View);
                oResult_Edit_Object_View.Params_Edit_Object_View = i_Params_Edit_Object_View;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Object_View.Params_Edit_Object_View = i_Params_Edit_Object_View;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Object_View.Exception_Message = string.Format("Edit_Object_View : {0}", ex.Message);
                oResult_Edit_Object_View.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Object_View : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Object_View.Exception_Message = ex.Message;
                oResult_Edit_Object_View.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Object_View;
        #endregion
    }
    #endregion
    #region Get_Setup_category_By_OWNER_ID
    [HttpGet]
    [Route("Get_Setup_category_By_OWNER_ID")]
    public Result_Get_Setup_category_By_OWNER_ID Get_Setup_category_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Setup_category_By_OWNER_ID oResult_Get_Setup_category_By_OWNER_ID = new Result_Get_Setup_category_By_OWNER_ID();
        Params_Get_Setup_category_By_OWNER_ID oParams_Get_Setup_category_By_OWNER_ID = new Params_Get_Setup_category_By_OWNER_ID();
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
                oParams_Get_Setup_category_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Setup_category_By_OWNER_ID.i_Result = oBLC.Get_Setup_category_By_OWNER_ID(oParams_Get_Setup_category_By_OWNER_ID);
                oResult_Get_Setup_category_By_OWNER_ID.Params_Get_Setup_category_By_OWNER_ID = oParams_Get_Setup_category_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Setup_category_By_OWNER_ID.Params_Get_Setup_category_By_OWNER_ID = oParams_Get_Setup_category_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Setup_category_By_OWNER_ID.Exception_Message = string.Format("Get_Setup_category_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Setup_category_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Setup_category_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Setup_category_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Setup_category_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Setup_category_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Site_geojson
    [HttpPost]
    [Route("Get_Site_geojson")]
    public Result_Get_Site_geojson Get_Site_geojson()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Site_geojson oResult_Get_Site_geojson = new Result_Get_Site_geojson();
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
                oResult_Get_Site_geojson.i_Result = oBLC.Get_Site_geojson();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Site_geojson.Exception_Message = string.Format("Get_Site_geojson : {0}", ex.Message);
                oResult_Get_Site_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Get_Site_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Site_geojson.Exception_Message = ex.Message;
                oResult_Get_Site_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Site_geojson;
        #endregion
    }
    #endregion
    #region Edit_District_geojson
    [HttpPost]
    [Route("Edit_District_geojson")]
    public Result_Edit_District_geojson Edit_District_geojson(Params_Edit_District_geojson i_Params_Edit_District_geojson)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_District_geojson oResult_Edit_District_geojson = new Result_Edit_District_geojson();
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
                oResult_Edit_District_geojson.i_Result = oBLC.Edit_District_geojson(i_Params_Edit_District_geojson);
                oResult_Edit_District_geojson.Params_Edit_District_geojson = i_Params_Edit_District_geojson;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_District_geojson.Params_Edit_District_geojson = i_Params_Edit_District_geojson;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_District_geojson.Exception_Message = string.Format("Edit_District_geojson : {0}", ex.Message);
                oResult_Edit_District_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Edit_District_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_District_geojson.Exception_Message = ex.Message;
                oResult_Edit_District_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_District_geojson;
        #endregion
    }
    #endregion
    #region Delete_Build_version
    [HttpPost]
    [Route("Delete_Build_version")]
    public Result_Delete_Build_version Delete_Build_version(Params_Delete_Build_version i_Params_Delete_Build_version)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Build_version oResult_Delete_Build_version = new Result_Delete_Build_version();
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
                oBLC.Delete_Build_version(i_Params_Delete_Build_version);
                oResult_Delete_Build_version.Params_Delete_Build_version = i_Params_Delete_Build_version;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Build_version.Params_Delete_Build_version = i_Params_Delete_Build_version;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Build_version.Exception_Message = string.Format("Delete_Build_version : {0}", ex.Message);
                oResult_Delete_Build_version.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Build_version : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Build_version.Exception_Message = ex.Message;
                oResult_Delete_Build_version.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Build_version;
        #endregion
    }
    #endregion
    #region Edit_Ext_study_zone_geojson
    [HttpPost]
    [Route("Edit_Ext_study_zone_geojson")]
    public Result_Edit_Ext_study_zone_geojson Edit_Ext_study_zone_geojson(Params_Edit_Ext_study_zone_geojson i_Params_Edit_Ext_study_zone_geojson)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Ext_study_zone_geojson oResult_Edit_Ext_study_zone_geojson = new Result_Edit_Ext_study_zone_geojson();
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
                oResult_Edit_Ext_study_zone_geojson.i_Result = oBLC.Edit_Ext_study_zone_geojson(i_Params_Edit_Ext_study_zone_geojson);
                oResult_Edit_Ext_study_zone_geojson.Params_Edit_Ext_study_zone_geojson = i_Params_Edit_Ext_study_zone_geojson;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Ext_study_zone_geojson.Params_Edit_Ext_study_zone_geojson = i_Params_Edit_Ext_study_zone_geojson;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Ext_study_zone_geojson.Exception_Message = string.Format("Edit_Ext_study_zone_geojson : {0}", ex.Message);
                oResult_Edit_Ext_study_zone_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Ext_study_zone_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Ext_study_zone_geojson.Exception_Message = ex.Message;
                oResult_Edit_Ext_study_zone_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Ext_study_zone_geojson;
        #endregion
    }
    #endregion
    #region Delete_Default_Settings_Picture
    [HttpDelete]
    [Route("Delete_Default_Settings_Picture/{IMAGE_TYPE_SETUP_ID}")]
    public Result_Delete_Default_Settings_Picture Delete_Default_Settings_Picture(long? IMAGE_TYPE_SETUP_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Default_Settings_Picture oParams_Delete_Default_Settings_Picture = new Params_Delete_Default_Settings_Picture()
        {
            IMAGE_TYPE_SETUP_ID = IMAGE_TYPE_SETUP_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Default_Settings_Picture oResult_Delete_Default_Settings_Picture = new Result_Delete_Default_Settings_Picture();
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
                oResult_Delete_Default_Settings_Picture.i_Result = oBLC.Delete_Default_Settings_Picture(oParams_Delete_Default_Settings_Picture);
                oResult_Delete_Default_Settings_Picture.Params_Delete_Default_Settings_Picture = oParams_Delete_Default_Settings_Picture;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Default_Settings_Picture.Params_Delete_Default_Settings_Picture = oParams_Delete_Default_Settings_Picture;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Default_Settings_Picture.Exception_Message = string.Format("Delete_Default_Settings_Picture : {0}", ex.Message);
                oResult_Delete_Default_Settings_Picture.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Default_Settings_Picture : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Default_Settings_Picture.Exception_Message = ex.Message;
                oResult_Delete_Default_Settings_Picture.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Default_Settings_Picture;
        #endregion
    }
    #endregion
    #region Get_Specialized_chart_configuration
    [HttpGet]
    [Route("Get_Specialized_chart_configuration")]
    public Result_Get_Specialized_chart_configuration Get_Specialized_chart_configuration()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Specialized_chart_configuration oResult_Get_Specialized_chart_configuration = new Result_Get_Specialized_chart_configuration();
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
                oResult_Get_Specialized_chart_configuration.i_Result = oBLC.Get_Specialized_chart_configuration();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Specialized_chart_configuration.Exception_Message = string.Format("Get_Specialized_chart_configuration : {0}", ex.Message);
                oResult_Get_Specialized_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Get_Specialized_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Specialized_chart_configuration.Exception_Message = ex.Message;
                oResult_Get_Specialized_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Specialized_chart_configuration;
        #endregion
    }
    #endregion
    #region Edit_Removed_extrusion_Custom_Old
    [HttpPost]
    [Route("Edit_Removed_extrusion_Custom_Old")]
    public Result_Edit_Removed_extrusion_Custom_Old Edit_Removed_extrusion_Custom_Old(Params_Edit_Removed_extrusion_Custom_Old i_Params_Edit_Removed_extrusion_Custom_Old)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Removed_extrusion_Custom_Old oResult_Edit_Removed_extrusion_Custom_Old = new Result_Edit_Removed_extrusion_Custom_Old();
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
                oBLC.Edit_Removed_extrusion_Custom_Old(i_Params_Edit_Removed_extrusion_Custom_Old);
                oResult_Edit_Removed_extrusion_Custom_Old.Params_Edit_Removed_extrusion_Custom_Old = i_Params_Edit_Removed_extrusion_Custom_Old;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Removed_extrusion_Custom_Old.Params_Edit_Removed_extrusion_Custom_Old = i_Params_Edit_Removed_extrusion_Custom_Old;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Removed_extrusion_Custom_Old.Exception_Message = string.Format("Edit_Removed_extrusion_Custom_Old : {0}", ex.Message);
                oResult_Edit_Removed_extrusion_Custom_Old.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Removed_extrusion_Custom_Old : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Removed_extrusion_Custom_Old.Exception_Message = ex.Message;
                oResult_Edit_Removed_extrusion_Custom_Old.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Removed_extrusion_Custom_Old;
        #endregion
    }
    #endregion
    #region Get_Area_geojson
    [HttpPost]
    [Route("Get_Area_geojson")]
    public Result_Get_Area_geojson Get_Area_geojson()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_geojson oResult_Get_Area_geojson = new Result_Get_Area_geojson();
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
                oResult_Get_Area_geojson.i_Result = oBLC.Get_Area_geojson();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_geojson.Exception_Message = string.Format("Get_Area_geojson : {0}", ex.Message);
                oResult_Get_Area_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_geojson.Exception_Message = ex.Message;
                oResult_Get_Area_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_geojson;
        #endregion
    }
    #endregion
    #region Delete_Setup_category
    [HttpDelete]
    [Route("Delete_Setup_category/{SETUP_CATEGORY_ID}")]
    public Result_Delete_Setup_category Delete_Setup_category(int? SETUP_CATEGORY_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Setup_category oParams_Delete_Setup_category = new Params_Delete_Setup_category()
        {
            SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Setup_category oResult_Delete_Setup_category = new Result_Delete_Setup_category();
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
                oBLC.Delete_Setup_category(oParams_Delete_Setup_category);
                oResult_Delete_Setup_category.Params_Delete_Setup_category = oParams_Delete_Setup_category;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Setup_category.Params_Delete_Setup_category = oParams_Delete_Setup_category;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Setup_category.Exception_Message = string.Format("Delete_Setup_category : {0}", ex.Message);
                oResult_Delete_Setup_category.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Setup_category : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Setup_category.Exception_Message = ex.Message;
                oResult_Delete_Setup_category.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Setup_category;
        #endregion
    }
    #endregion
    #region Get_Build_version_By_OWNER_ID_Adv
    [HttpGet]
    [Route("Get_Build_version_By_OWNER_ID_Adv")]
    public Result_Get_Build_version_By_OWNER_ID_Adv Get_Build_version_By_OWNER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Build_version_By_OWNER_ID_Adv oResult_Get_Build_version_By_OWNER_ID_Adv = new Result_Get_Build_version_By_OWNER_ID_Adv();
        Params_Get_Build_version_By_OWNER_ID oParams_Get_Build_version_By_OWNER_ID = new Params_Get_Build_version_By_OWNER_ID();
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
                oParams_Get_Build_version_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Build_version_By_OWNER_ID_Adv.i_Result = oBLC.Get_Build_version_By_OWNER_ID_Adv(oParams_Get_Build_version_By_OWNER_ID);
                oResult_Get_Build_version_By_OWNER_ID_Adv.Params_Get_Build_version_By_OWNER_ID = oParams_Get_Build_version_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Build_version_By_OWNER_ID_Adv.Params_Get_Build_version_By_OWNER_ID = oParams_Get_Build_version_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Build_version_By_OWNER_ID_Adv.Exception_Message = string.Format("Get_Build_version_By_OWNER_ID_Adv : {0}", ex.Message);
                oResult_Get_Build_version_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Build_version_By_OWNER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Build_version_By_OWNER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Build_version_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Build_version_By_OWNER_ID_Adv;
        #endregion
    }
    #endregion
    #region Edit_Build_version
    [HttpPost]
    [Route("Edit_Build_version")]
    public Result_Edit_Build_version Edit_Build_version(Build_version i_Build_version)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Build_version oResult_Edit_Build_version = new Result_Edit_Build_version();
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
                oBLC.Edit_Build_version(i_Build_version);
                oResult_Edit_Build_version.Build_version = i_Build_version;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Build_version.Exception_Message = string.Format("Edit_Build_version : {0}", ex.Message);
                oResult_Edit_Build_version.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Build_version : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Build_version.Exception_Message = ex.Message;
                oResult_Edit_Build_version.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Build_version;
        #endregion
    }
    #endregion
    #region Get_Default_chart_color_By_OWNER_ID_Adv
    [HttpGet]
    [Route("Get_Default_chart_color_By_OWNER_ID_Adv")]
    public Result_Get_Default_chart_color_By_OWNER_ID_Adv Get_Default_chart_color_By_OWNER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Default_chart_color_By_OWNER_ID_Adv oResult_Get_Default_chart_color_By_OWNER_ID_Adv = new Result_Get_Default_chart_color_By_OWNER_ID_Adv();
        Params_Get_Default_chart_color_By_OWNER_ID oParams_Get_Default_chart_color_By_OWNER_ID = new Params_Get_Default_chart_color_By_OWNER_ID();
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
                oParams_Get_Default_chart_color_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Default_chart_color_By_OWNER_ID_Adv.i_Result = oBLC.Get_Default_chart_color_By_OWNER_ID_Adv(oParams_Get_Default_chart_color_By_OWNER_ID);
                oResult_Get_Default_chart_color_By_OWNER_ID_Adv.Params_Get_Default_chart_color_By_OWNER_ID = oParams_Get_Default_chart_color_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Default_chart_color_By_OWNER_ID_Adv.Params_Get_Default_chart_color_By_OWNER_ID = oParams_Get_Default_chart_color_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Default_chart_color_By_OWNER_ID_Adv.Exception_Message = string.Format("Get_Default_chart_color_By_OWNER_ID_Adv : {0}", ex.Message);
                oResult_Get_Default_chart_color_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Default_chart_color_By_OWNER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Default_chart_color_By_OWNER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Default_chart_color_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Default_chart_color_By_OWNER_ID_Adv;
        #endregion
    }
    #endregion
    #region Edit_Default_chart_color_List
    [HttpPost]
    [Route("Edit_Default_chart_color_List")]
    public Result_Edit_Default_chart_color_List Edit_Default_chart_color_List(Params_Edit_Default_chart_color_List i_Params_Edit_Default_chart_color_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Default_chart_color_List oResult_Edit_Default_chart_color_List = new Result_Edit_Default_chart_color_List();
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
                oBLC.Edit_Default_chart_color_List(i_Params_Edit_Default_chart_color_List);
                oResult_Edit_Default_chart_color_List.Params_Edit_Default_chart_color_List = i_Params_Edit_Default_chart_color_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Default_chart_color_List.Exception_Message = string.Format("Edit_Default_chart_color_List : {0}", ex.Message);
                oResult_Edit_Default_chart_color_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Default_chart_color_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Default_chart_color_List.Exception_Message = ex.Message;
                oResult_Edit_Default_chart_color_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Default_chart_color_List;
        #endregion
    }
    #endregion
    #region Get_District_geojson
    [HttpPost]
    [Route("Get_District_geojson")]
    public Result_Get_District_geojson Get_District_geojson()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_District_geojson oResult_Get_District_geojson = new Result_Get_District_geojson();
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
                oResult_Get_District_geojson.i_Result = oBLC.Get_District_geojson();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_District_geojson.Exception_Message = string.Format("Get_District_geojson : {0}", ex.Message);
                oResult_Get_District_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Get_District_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_District_geojson.Exception_Message = ex.Message;
                oResult_Get_District_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_District_geojson;
        #endregion
    }
    #endregion
    #region Edit_Specialized_chart_configuration
    [HttpPost]
    [Route("Edit_Specialized_chart_configuration")]
    public Result_Edit_Specialized_chart_configuration Edit_Specialized_chart_configuration(Specialized_chart_configuration i_Specialized_chart_configuration)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Specialized_chart_configuration oResult_Edit_Specialized_chart_configuration = new Result_Edit_Specialized_chart_configuration();
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
                oResult_Edit_Specialized_chart_configuration.i_Result = oBLC.Edit_Specialized_chart_configuration(i_Specialized_chart_configuration);
                oResult_Edit_Specialized_chart_configuration.Specialized_chart_configuration = i_Specialized_chart_configuration;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Specialized_chart_configuration.Specialized_chart_configuration = i_Specialized_chart_configuration;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Specialized_chart_configuration.Exception_Message = string.Format("Edit_Specialized_chart_configuration : {0}", ex.Message);
                oResult_Edit_Specialized_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Specialized_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Specialized_chart_configuration.Exception_Message = ex.Message;
                oResult_Edit_Specialized_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Specialized_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_Setup_category_By_SETUP_CATEGORY_ID
    [HttpGet]
    [Route("Get_Setup_category_By_SETUP_CATEGORY_ID")]
    public Result_Get_Setup_category_By_SETUP_CATEGORY_ID Get_Setup_category_By_SETUP_CATEGORY_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Setup_category_By_SETUP_CATEGORY_ID oResult_Get_Setup_category_By_SETUP_CATEGORY_ID = new Result_Get_Setup_category_By_SETUP_CATEGORY_ID();
        Params_Get_Setup_category_By_SETUP_CATEGORY_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SETUP_CATEGORY_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SETUP_CATEGORY_ID"].ToString() != "undefined" && HttpContext.Request.Query["SETUP_CATEGORY_ID"].ToString() != "null" && HttpContext.Request.Query["SETUP_CATEGORY_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["SETUP_CATEGORY_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.i_Result = oBLC.Get_Setup_category_By_SETUP_CATEGORY_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_ID);
                oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.Params_Get_Setup_category_By_SETUP_CATEGORY_ID = oParams_Get_Setup_category_By_SETUP_CATEGORY_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.Params_Get_Setup_category_By_SETUP_CATEGORY_ID = oParams_Get_Setup_category_By_SETUP_CATEGORY_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.Exception_Message = string.Format("Get_Setup_category_By_SETUP_CATEGORY_ID : {0}", ex.Message);
                oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Setup_category_By_SETUP_CATEGORY_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.Exception_Message = ex.Message;
                oResult_Get_Setup_category_By_SETUP_CATEGORY_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Setup_category_By_SETUP_CATEGORY_ID;
        #endregion
    }
    #endregion
    #region Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
    [HttpPost]
    [Route("Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID")]
    public Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID = new Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID();
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
                oBLC.Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID);
                oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID = i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID = i_Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.Exception_Message = string.Format("Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID : {0}", ex.Message);
                oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.Exception_Message = ex.Message;
                oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID;
        #endregion
    }
    #endregion
    #region Edit_Setup_category
    [HttpPost]
    [Route("Edit_Setup_category")]
    public Result_Edit_Setup_category Edit_Setup_category(Setup_category i_Setup_category)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Setup_category oResult_Edit_Setup_category = new Result_Edit_Setup_category();
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
                oBLC.Edit_Setup_category(i_Setup_category);
                oResult_Edit_Setup_category.Setup_category = i_Setup_category;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Setup_category.Exception_Message = string.Format("Edit_Setup_category : {0}", ex.Message);
                oResult_Edit_Setup_category.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Setup_category : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Setup_category.Exception_Message = ex.Message;
                oResult_Edit_Setup_category.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Setup_category;
        #endregion
    }
    #endregion
    #region Edit_Alert_settings_List
    [HttpPost]
    [Route("Edit_Alert_settings_List")]
    public Result_Edit_Alert_settings_List Edit_Alert_settings_List(Params_Edit_Alert_settings_List i_Params_Edit_Alert_settings_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Alert_settings_List oResult_Edit_Alert_settings_List = new Result_Edit_Alert_settings_List();
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
                oBLC.Edit_Alert_settings_List(i_Params_Edit_Alert_settings_List);
                oResult_Edit_Alert_settings_List.Params_Edit_Alert_settings_List = i_Params_Edit_Alert_settings_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Alert_settings_List.Exception_Message = string.Format("Edit_Alert_settings_List : {0}", ex.Message);
                oResult_Edit_Alert_settings_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Alert_settings_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Alert_settings_List.Exception_Message = ex.Message;
                oResult_Edit_Alert_settings_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Alert_settings_List;
        #endregion
    }
    #endregion
    #region Delete_Dimension_chart_configuration
    [HttpPost]
    [Route("Delete_Dimension_chart_configuration")]
    public Result_Delete_Dimension_chart_configuration Delete_Dimension_chart_configuration(Params_Delete_Dimension_chart_configuration i_Params_Delete_Dimension_chart_configuration)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Dimension_chart_configuration oResult_Delete_Dimension_chart_configuration = new Result_Delete_Dimension_chart_configuration();
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
                oBLC.Delete_Dimension_chart_configuration(i_Params_Delete_Dimension_chart_configuration);
                oResult_Delete_Dimension_chart_configuration.Params_Delete_Dimension_chart_configuration = i_Params_Delete_Dimension_chart_configuration;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Dimension_chart_configuration.Params_Delete_Dimension_chart_configuration = i_Params_Delete_Dimension_chart_configuration;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Dimension_chart_configuration.Exception_Message = string.Format("Delete_Dimension_chart_configuration : {0}", ex.Message);
                oResult_Delete_Dimension_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Dimension_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Dimension_chart_configuration.Exception_Message = ex.Message;
                oResult_Delete_Dimension_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Dimension_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_Initial_Districtnex_Admin_Settings
    [HttpGet]
    [Route("Get_Initial_Districtnex_Admin_Settings")]
    public Result_Get_Initial_Districtnex_Admin_Settings Get_Initial_Districtnex_Admin_Settings()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Initial_Districtnex_Admin_Settings oResult_Get_Initial_Districtnex_Admin_Settings = new Result_Get_Initial_Districtnex_Admin_Settings();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Initial_Districtnex_Admin_Settings.i_Result = oBLC.Get_Initial_Districtnex_Admin_Settings();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Initial_Districtnex_Admin_Settings.Exception_Message = string.Format("Get_Initial_Districtnex_Admin_Settings : {0}", ex.Message);
                oResult_Get_Initial_Districtnex_Admin_Settings.Stack_Trace = is_send_stack_trace ? string.Format("Get_Initial_Districtnex_Admin_Settings : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Initial_Districtnex_Admin_Settings.Exception_Message = ex.Message;
                oResult_Get_Initial_Districtnex_Admin_Settings.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Initial_Districtnex_Admin_Settings;
        #endregion
    }
    #endregion
    #region Edit_Site_geojson
    [HttpPost]
    [Route("Edit_Site_geojson")]
    public Result_Edit_Site_geojson Edit_Site_geojson(Params_Edit_Site_geojson i_Params_Edit_Site_geojson)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_geojson oResult_Edit_Site_geojson = new Result_Edit_Site_geojson();
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
                oResult_Edit_Site_geojson.i_Result = oBLC.Edit_Site_geojson(i_Params_Edit_Site_geojson);
                oResult_Edit_Site_geojson.Params_Edit_Site_geojson = i_Params_Edit_Site_geojson;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Site_geojson.Params_Edit_Site_geojson = i_Params_Edit_Site_geojson;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_geojson.Exception_Message = string.Format("Edit_Site_geojson : {0}", ex.Message);
                oResult_Edit_Site_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_geojson.Exception_Message = ex.Message;
                oResult_Edit_Site_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_geojson;
        #endregion
    }
    #endregion
    #region Delete_Area_geojson_By_AREA_ID
    [HttpPost]
    [Route("Delete_Area_geojson_By_AREA_ID")]
    public Result_Delete_Area_geojson_By_AREA_ID Delete_Area_geojson_By_AREA_ID(Params_Delete_Area_geojson_By_AREA_ID i_Params_Delete_Area_geojson_By_AREA_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Area_geojson_By_AREA_ID oResult_Delete_Area_geojson_By_AREA_ID = new Result_Delete_Area_geojson_By_AREA_ID();
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
                oBLC.Delete_Area_geojson_By_AREA_ID(i_Params_Delete_Area_geojson_By_AREA_ID);
                oResult_Delete_Area_geojson_By_AREA_ID.Params_Delete_Area_geojson_By_AREA_ID = i_Params_Delete_Area_geojson_By_AREA_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Area_geojson_By_AREA_ID.Params_Delete_Area_geojson_By_AREA_ID = i_Params_Delete_Area_geojson_By_AREA_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Area_geojson_By_AREA_ID.Exception_Message = string.Format("Delete_Area_geojson_By_AREA_ID : {0}", ex.Message);
                oResult_Delete_Area_geojson_By_AREA_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Area_geojson_By_AREA_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Area_geojson_By_AREA_ID.Exception_Message = ex.Message;
                oResult_Delete_Area_geojson_By_AREA_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Area_geojson_By_AREA_ID;
        #endregion
    }
    #endregion
    #region Edit_Default_settings
    [HttpPost]
    [Route("Edit_Default_settings")]
    public Result_Edit_Default_settings Edit_Default_settings(Default_settings i_Default_settings)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Default_settings oResult_Edit_Default_settings = new Result_Edit_Default_settings();
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
                oBLC.Edit_Default_settings(i_Default_settings);
                oResult_Edit_Default_settings.Default_settings = i_Default_settings;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Default_settings.Exception_Message = string.Format("Edit_Default_settings : {0}", ex.Message);
                oResult_Edit_Default_settings.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Default_settings : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Default_settings.Exception_Message = ex.Message;
                oResult_Edit_Default_settings.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Default_settings;
        #endregion
    }
    #endregion
    #region Delete_Specialized_chart_configuration
    [HttpPost]
    [Route("Delete_Specialized_chart_configuration")]
    public Result_Delete_Specialized_chart_configuration Delete_Specialized_chart_configuration(Params_Delete_Specialized_chart_configuration i_Params_Delete_Specialized_chart_configuration)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Specialized_chart_configuration oResult_Delete_Specialized_chart_configuration = new Result_Delete_Specialized_chart_configuration();
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
                oBLC.Delete_Specialized_chart_configuration(i_Params_Delete_Specialized_chart_configuration);
                oResult_Delete_Specialized_chart_configuration.Params_Delete_Specialized_chart_configuration = i_Params_Delete_Specialized_chart_configuration;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Specialized_chart_configuration.Params_Delete_Specialized_chart_configuration = i_Params_Delete_Specialized_chart_configuration;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Specialized_chart_configuration.Exception_Message = string.Format("Delete_Specialized_chart_configuration : {0}", ex.Message);
                oResult_Delete_Specialized_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Specialized_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Specialized_chart_configuration.Exception_Message = ex.Message;
                oResult_Delete_Specialized_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Specialized_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_Initial_Districtnex_UI_Settings
    [HttpGet]
    [Route("Get_Initial_Districtnex_UI_Settings")]
    public Result_Get_Initial_Districtnex_UI_Settings Get_Initial_Districtnex_UI_Settings()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Initial_Districtnex_UI_Settings oResult_Get_Initial_Districtnex_UI_Settings = new Result_Get_Initial_Districtnex_UI_Settings();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Initial_Districtnex_UI_Settings.i_Result = oBLC.Get_Initial_Districtnex_UI_Settings();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Initial_Districtnex_UI_Settings.Exception_Message = string.Format("Get_Initial_Districtnex_UI_Settings : {0}", ex.Message);
                oResult_Get_Initial_Districtnex_UI_Settings.Stack_Trace = is_send_stack_trace ? string.Format("Get_Initial_Districtnex_UI_Settings : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Initial_Districtnex_UI_Settings.Exception_Message = ex.Message;
                oResult_Get_Initial_Districtnex_UI_Settings.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Initial_Districtnex_UI_Settings;
        #endregion
    }
    #endregion
    #region Get_Alert_settings_By_OWNER_ID_Adv
    [HttpGet]
    [Route("Get_Alert_settings_By_OWNER_ID_Adv")]
    public Result_Get_Alert_settings_By_OWNER_ID_Adv Get_Alert_settings_By_OWNER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Alert_settings_By_OWNER_ID_Adv oResult_Get_Alert_settings_By_OWNER_ID_Adv = new Result_Get_Alert_settings_By_OWNER_ID_Adv();
        Params_Get_Alert_settings_By_OWNER_ID oParams_Get_Alert_settings_By_OWNER_ID = new Params_Get_Alert_settings_By_OWNER_ID();
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
                oParams_Get_Alert_settings_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Alert_settings_By_OWNER_ID_Adv.i_Result = oBLC.Get_Alert_settings_By_OWNER_ID_Adv(oParams_Get_Alert_settings_By_OWNER_ID);
                oResult_Get_Alert_settings_By_OWNER_ID_Adv.Params_Get_Alert_settings_By_OWNER_ID = oParams_Get_Alert_settings_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Alert_settings_By_OWNER_ID_Adv.Params_Get_Alert_settings_By_OWNER_ID = oParams_Get_Alert_settings_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Alert_settings_By_OWNER_ID_Adv.Exception_Message = string.Format("Get_Alert_settings_By_OWNER_ID_Adv : {0}", ex.Message);
                oResult_Get_Alert_settings_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Alert_settings_By_OWNER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Alert_settings_By_OWNER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Alert_settings_By_OWNER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Alert_settings_By_OWNER_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID
    [HttpGet]
    [Route("Get_Build_version_By_APPLICATION_NAME_SETUP_ID")]
    public Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID Get_Build_version_By_APPLICATION_NAME_SETUP_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID = new Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID();
        Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID = new Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["APPLICATION_NAME_SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["APPLICATION_NAME_SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["APPLICATION_NAME_SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["APPLICATION_NAME_SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["APPLICATION_NAME_SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.i_Result = oBLC.Get_Build_version_By_APPLICATION_NAME_SETUP_ID(oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID);
                oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID = oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID = oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.Exception_Message = string.Format("Get_Build_version_By_APPLICATION_NAME_SETUP_ID : {0}", ex.Message);
                oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Build_version_By_APPLICATION_NAME_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Build_version_By_APPLICATION_NAME_SETUP_ID;
        #endregion
    }
    #endregion
    #region Edit_Removed_extrusion_Custom
    [HttpPost]
    [Route("Edit_Removed_extrusion_Custom")]
    public Result_Edit_Removed_extrusion_Custom Edit_Removed_extrusion_Custom(Params_Edit_Removed_extrusion_Custom i_Params_Edit_Removed_extrusion_Custom)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Removed_extrusion_Custom oResult_Edit_Removed_extrusion_Custom = new Result_Edit_Removed_extrusion_Custom();
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
                oBLC.Edit_Removed_extrusion_Custom(i_Params_Edit_Removed_extrusion_Custom);
                oResult_Edit_Removed_extrusion_Custom.Params_Edit_Removed_extrusion_Custom = i_Params_Edit_Removed_extrusion_Custom;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Removed_extrusion_Custom.Params_Edit_Removed_extrusion_Custom = i_Params_Edit_Removed_extrusion_Custom;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Removed_extrusion_Custom.Exception_Message = string.Format("Edit_Removed_extrusion_Custom : {0}", ex.Message);
                oResult_Edit_Removed_extrusion_Custom.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Removed_extrusion_Custom : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Removed_extrusion_Custom.Exception_Message = ex.Message;
                oResult_Edit_Removed_extrusion_Custom.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Removed_extrusion_Custom;
        #endregion
    }
    #endregion
    #region Clean_Removed_extrusions
    [HttpPost]
    [Route("Clean_Removed_extrusions")]
    public Result_Clean_Removed_extrusions Clean_Removed_extrusions()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Clean_Removed_extrusions oResult_Clean_Removed_extrusions = new Result_Clean_Removed_extrusions();
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
                oBLC.Clean_Removed_extrusions();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Clean_Removed_extrusions.Exception_Message = string.Format("Clean_Removed_extrusions : {0}", ex.Message);
                oResult_Clean_Removed_extrusions.Stack_Trace = is_send_stack_trace ? string.Format("Clean_Removed_extrusions : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Clean_Removed_extrusions.Exception_Message = ex.Message;
                oResult_Clean_Removed_extrusions.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Clean_Removed_extrusions;
        #endregion
    }
    #endregion
    #region Delete_Kpi_chart_configuration
    [HttpPost]
    [Route("Delete_Kpi_chart_configuration")]
    public Result_Delete_Kpi_chart_configuration Delete_Kpi_chart_configuration(Params_Delete_Kpi_chart_configuration i_Params_Delete_Kpi_chart_configuration)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Kpi_chart_configuration oResult_Delete_Kpi_chart_configuration = new Result_Delete_Kpi_chart_configuration();
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
                oBLC.Delete_Kpi_chart_configuration(i_Params_Delete_Kpi_chart_configuration);
                oResult_Delete_Kpi_chart_configuration.Params_Delete_Kpi_chart_configuration = i_Params_Delete_Kpi_chart_configuration;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Kpi_chart_configuration.Params_Delete_Kpi_chart_configuration = i_Params_Delete_Kpi_chart_configuration;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Kpi_chart_configuration.Exception_Message = string.Format("Delete_Kpi_chart_configuration : {0}", ex.Message);
                oResult_Delete_Kpi_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Kpi_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Kpi_chart_configuration.Exception_Message = ex.Message;
                oResult_Delete_Kpi_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Kpi_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_UI_Build_Version_List
    [HttpPost]
    [Route("Get_UI_Build_Version_List")]
    public Result_Get_UI_Build_Version_List Get_UI_Build_Version_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_UI_Build_Version_List oResult_Get_UI_Build_Version_List = new Result_Get_UI_Build_Version_List();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_UI_Build_Version_List.i_Result = oBLC.Get_UI_Build_Version_List();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_UI_Build_Version_List.Exception_Message = string.Format("Get_UI_Build_Version_List : {0}", ex.Message);
                oResult_Get_UI_Build_Version_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_UI_Build_Version_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_UI_Build_Version_List.Exception_Message = ex.Message;
                oResult_Get_UI_Build_Version_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_UI_Build_Version_List;
        #endregion
    }
    #endregion
    #region Get_Ext_study_zone_geojson
    [HttpPost]
    [Route("Get_Ext_study_zone_geojson")]
    public Result_Get_Ext_study_zone_geojson Get_Ext_study_zone_geojson()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Ext_study_zone_geojson oResult_Get_Ext_study_zone_geojson = new Result_Get_Ext_study_zone_geojson();
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
                oResult_Get_Ext_study_zone_geojson.i_Result = oBLC.Get_Ext_study_zone_geojson();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Ext_study_zone_geojson.Exception_Message = string.Format("Get_Ext_study_zone_geojson : {0}", ex.Message);
                oResult_Get_Ext_study_zone_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Get_Ext_study_zone_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Ext_study_zone_geojson.Exception_Message = ex.Message;
                oResult_Get_Ext_study_zone_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Ext_study_zone_geojson;
        #endregion
    }
    #endregion
    #region Custom_Edit_Build_version
    [HttpPost]
    [Route("Custom_Edit_Build_version")]
    public Result_Custom_Edit_Build_version Custom_Edit_Build_version(Params_Custom_Edit_Build_version i_Params_Custom_Edit_Build_version)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Custom_Edit_Build_version oResult_Custom_Edit_Build_version = new Result_Custom_Edit_Build_version();
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
                oResult_Custom_Edit_Build_version.i_Result = oBLC.Custom_Edit_Build_version(i_Params_Custom_Edit_Build_version);
                oResult_Custom_Edit_Build_version.Params_Custom_Edit_Build_version = i_Params_Custom_Edit_Build_version;
            }
        }
        catch (Exception ex)
        {
            oResult_Custom_Edit_Build_version.Params_Custom_Edit_Build_version = i_Params_Custom_Edit_Build_version;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Custom_Edit_Build_version.Exception_Message = string.Format("Custom_Edit_Build_version : {0}", ex.Message);
                oResult_Custom_Edit_Build_version.Stack_Trace = is_send_stack_trace ? string.Format("Custom_Edit_Build_version : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Custom_Edit_Build_version.Exception_Message = ex.Message;
                oResult_Custom_Edit_Build_version.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Custom_Edit_Build_version;
        #endregion
    }
    #endregion
    #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
    [HttpGet]
    [Route("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID")]
    public Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = new Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID();
        Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SETUP_CATEGORY_NAME"].FirstOrDefault() != null && HttpContext.Request.Query["SETUP_CATEGORY_NAME"].ToString() != "undefined" && HttpContext.Request.Query["SETUP_CATEGORY_NAME"].ToString() != "null" && HttpContext.Request.Query["SETUP_CATEGORY_NAME"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(string));
                oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME = (string)typeConverter.ConvertFromString(HttpContext.Request.Query["SETUP_CATEGORY_NAME"].ToString());
            }
            if (HttpContext.Request.Query["OWNER_ID"].FirstOrDefault() != null && HttpContext.Request.Query["OWNER_ID"].ToString() != "undefined" && HttpContext.Request.Query["OWNER_ID"].ToString() != "null" && HttpContext.Request.Query["OWNER_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.i_Result = oBLC.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
                oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.Exception_Message = string.Format("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID : {0}", ex.Message);
                oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Default_chart_color_By_OWNER_ID
    [HttpGet]
    [Route("Get_Default_chart_color_By_OWNER_ID")]
    public Result_Get_Default_chart_color_By_OWNER_ID Get_Default_chart_color_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Default_chart_color_By_OWNER_ID oResult_Get_Default_chart_color_By_OWNER_ID = new Result_Get_Default_chart_color_By_OWNER_ID();
        Params_Get_Default_chart_color_By_OWNER_ID oParams_Get_Default_chart_color_By_OWNER_ID = new Params_Get_Default_chart_color_By_OWNER_ID();
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
                oParams_Get_Default_chart_color_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Default_chart_color_By_OWNER_ID.i_Result = oBLC.Get_Default_chart_color_By_OWNER_ID(oParams_Get_Default_chart_color_By_OWNER_ID);
                oResult_Get_Default_chart_color_By_OWNER_ID.Params_Get_Default_chart_color_By_OWNER_ID = oParams_Get_Default_chart_color_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Default_chart_color_By_OWNER_ID.Params_Get_Default_chart_color_By_OWNER_ID = oParams_Get_Default_chart_color_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Default_chart_color_By_OWNER_ID.Exception_Message = string.Format("Get_Default_chart_color_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Default_chart_color_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Default_chart_color_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Default_chart_color_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Default_chart_color_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Default_chart_color_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Setup_By_OWNER_ID
    [HttpGet]
    [Route("Get_Setup_By_OWNER_ID")]
    public Result_Get_Setup_By_OWNER_ID Get_Setup_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Setup_By_OWNER_ID oResult_Get_Setup_By_OWNER_ID = new Result_Get_Setup_By_OWNER_ID();
        Params_Get_Setup_By_OWNER_ID oParams_Get_Setup_By_OWNER_ID = new Params_Get_Setup_By_OWNER_ID();
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
                oParams_Get_Setup_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Setup_By_OWNER_ID.i_Result = oBLC.Get_Setup_By_OWNER_ID(oParams_Get_Setup_By_OWNER_ID);
                oResult_Get_Setup_By_OWNER_ID.Params_Get_Setup_By_OWNER_ID = oParams_Get_Setup_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Setup_By_OWNER_ID.Params_Get_Setup_By_OWNER_ID = oParams_Get_Setup_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Setup_By_OWNER_ID.Exception_Message = string.Format("Get_Setup_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Setup_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Setup_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Setup_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Setup_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Setup_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Edit_Area_geojson
    [HttpPost]
    [Route("Edit_Area_geojson")]
    public Result_Edit_Area_geojson Edit_Area_geojson(Params_Edit_Area_geojson i_Params_Edit_Area_geojson)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_geojson oResult_Edit_Area_geojson = new Result_Edit_Area_geojson();
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
                oResult_Edit_Area_geojson.i_Result = oBLC.Edit_Area_geojson(i_Params_Edit_Area_geojson);
                oResult_Edit_Area_geojson.Params_Edit_Area_geojson = i_Params_Edit_Area_geojson;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Area_geojson.Params_Edit_Area_geojson = i_Params_Edit_Area_geojson;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_geojson.Exception_Message = string.Format("Edit_Area_geojson : {0}", ex.Message);
                oResult_Edit_Area_geojson.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_geojson : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_geojson.Exception_Message = ex.Message;
                oResult_Edit_Area_geojson.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_geojson;
        #endregion
    }
    #endregion
    #region Delete_Site_geojson_By_SITE_ID
    [HttpPost]
    [Route("Delete_Site_geojson_By_SITE_ID")]
    public Result_Delete_Site_geojson_By_SITE_ID Delete_Site_geojson_By_SITE_ID(Params_Delete_Site_geojson_By_SITE_ID i_Params_Delete_Site_geojson_By_SITE_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Site_geojson_By_SITE_ID oResult_Delete_Site_geojson_By_SITE_ID = new Result_Delete_Site_geojson_By_SITE_ID();
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
                oBLC.Delete_Site_geojson_By_SITE_ID(i_Params_Delete_Site_geojson_By_SITE_ID);
                oResult_Delete_Site_geojson_By_SITE_ID.Params_Delete_Site_geojson_By_SITE_ID = i_Params_Delete_Site_geojson_By_SITE_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Site_geojson_By_SITE_ID.Params_Delete_Site_geojson_By_SITE_ID = i_Params_Delete_Site_geojson_By_SITE_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Site_geojson_By_SITE_ID.Exception_Message = string.Format("Delete_Site_geojson_By_SITE_ID : {0}", ex.Message);
                oResult_Delete_Site_geojson_By_SITE_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Site_geojson_By_SITE_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Site_geojson_By_SITE_ID.Exception_Message = ex.Message;
                oResult_Delete_Site_geojson_By_SITE_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Site_geojson_By_SITE_ID;
        #endregion
    }
    #endregion
    #region Get_Admin_Build_Version_List
    [HttpPost]
    [Route("Get_Admin_Build_Version_List")]
    public Result_Get_Admin_Build_Version_List Get_Admin_Build_Version_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Admin_Build_Version_List oResult_Get_Admin_Build_Version_List = new Result_Get_Admin_Build_Version_List();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Admin_Build_Version_List.i_Result = oBLC.Get_Admin_Build_Version_List();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Admin_Build_Version_List.Exception_Message = string.Format("Get_Admin_Build_Version_List : {0}", ex.Message);
                oResult_Get_Admin_Build_Version_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Admin_Build_Version_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Admin_Build_Version_List.Exception_Message = ex.Message;
                oResult_Get_Admin_Build_Version_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Admin_Build_Version_List;
        #endregion
    }
    #endregion
    #region Edit_Removed_extrusion_List
    [HttpPost]
    [Route("Edit_Removed_extrusion_List")]
    public Result_Edit_Removed_extrusion_List Edit_Removed_extrusion_List(Params_Edit_Removed_extrusion_List i_Params_Edit_Removed_extrusion_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Removed_extrusion_List oResult_Edit_Removed_extrusion_List = new Result_Edit_Removed_extrusion_List();
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
                oBLC.Edit_Removed_extrusion_List(i_Params_Edit_Removed_extrusion_List);
                oResult_Edit_Removed_extrusion_List.Params_Edit_Removed_extrusion_List = i_Params_Edit_Removed_extrusion_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Removed_extrusion_List.Exception_Message = string.Format("Edit_Removed_extrusion_List : {0}", ex.Message);
                oResult_Edit_Removed_extrusion_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Removed_extrusion_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Removed_extrusion_List.Exception_Message = ex.Message;
                oResult_Edit_Removed_extrusion_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Removed_extrusion_List;
        #endregion
    }
    #endregion
    #region Edit_Kpi_chart_configuration
    [HttpPost]
    [Route("Edit_Kpi_chart_configuration")]
    public Result_Edit_Kpi_chart_configuration Edit_Kpi_chart_configuration(Kpi_chart_configuration i_Kpi_chart_configuration)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Kpi_chart_configuration oResult_Edit_Kpi_chart_configuration = new Result_Edit_Kpi_chart_configuration();
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
                oResult_Edit_Kpi_chart_configuration.i_Result = oBLC.Edit_Kpi_chart_configuration(i_Kpi_chart_configuration);
                oResult_Edit_Kpi_chart_configuration.Kpi_chart_configuration = i_Kpi_chart_configuration;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_Kpi_chart_configuration.Kpi_chart_configuration = i_Kpi_chart_configuration;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Kpi_chart_configuration.Exception_Message = string.Format("Edit_Kpi_chart_configuration : {0}", ex.Message);
                oResult_Edit_Kpi_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Kpi_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Kpi_chart_configuration.Exception_Message = ex.Message;
                oResult_Edit_Kpi_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Kpi_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_Kpi_chart_configuration
    [HttpPost]
    [Route("Get_Kpi_chart_configuration")]
    public Result_Get_Kpi_chart_configuration Get_Kpi_chart_configuration()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Kpi_chart_configuration oResult_Get_Kpi_chart_configuration = new Result_Get_Kpi_chart_configuration();
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
                oResult_Get_Kpi_chart_configuration.i_Result = oBLC.Get_Kpi_chart_configuration();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Kpi_chart_configuration.Exception_Message = string.Format("Get_Kpi_chart_configuration : {0}", ex.Message);
                oResult_Get_Kpi_chart_configuration.Stack_Trace = is_send_stack_trace ? string.Format("Get_Kpi_chart_configuration : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Kpi_chart_configuration.Exception_Message = ex.Message;
                oResult_Get_Kpi_chart_configuration.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Kpi_chart_configuration;
        #endregion
    }
    #endregion
    #region Get_Removed_extrusion_By_OWNER_ID
    [HttpGet]
    [Route("Get_Removed_extrusion_By_OWNER_ID")]
    public Result_Get_Removed_extrusion_By_OWNER_ID Get_Removed_extrusion_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Removed_extrusion_By_OWNER_ID oResult_Get_Removed_extrusion_By_OWNER_ID = new Result_Get_Removed_extrusion_By_OWNER_ID();
        Params_Get_Removed_extrusion_By_OWNER_ID oParams_Get_Removed_extrusion_By_OWNER_ID = new Params_Get_Removed_extrusion_By_OWNER_ID();
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
                oParams_Get_Removed_extrusion_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Removed_extrusion_By_OWNER_ID.i_Result = oBLC.Get_Removed_extrusion_By_OWNER_ID(oParams_Get_Removed_extrusion_By_OWNER_ID);
                oResult_Get_Removed_extrusion_By_OWNER_ID.Params_Get_Removed_extrusion_By_OWNER_ID = oParams_Get_Removed_extrusion_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Removed_extrusion_By_OWNER_ID.Params_Get_Removed_extrusion_By_OWNER_ID = oParams_Get_Removed_extrusion_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Removed_extrusion_By_OWNER_ID.Exception_Message = string.Format("Get_Removed_extrusion_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Removed_extrusion_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Removed_extrusion_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Removed_extrusion_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Removed_extrusion_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Removed_extrusion_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Delete_Setup
    [HttpDelete]
    [Route("Delete_Setup/{SETUP_ID}")]
    public Result_Delete_Setup Delete_Setup(long? SETUP_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Setup oParams_Delete_Setup = new Params_Delete_Setup()
        {
            SETUP_ID = SETUP_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Setup oResult_Delete_Setup = new Result_Delete_Setup();
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
                oBLC.Delete_Setup(oParams_Delete_Setup);
                oResult_Delete_Setup.Params_Delete_Setup = oParams_Delete_Setup;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Setup.Params_Delete_Setup = oParams_Delete_Setup;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Setup.Exception_Message = string.Format("Delete_Setup : {0}", ex.Message);
                oResult_Delete_Setup.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Setup : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Setup.Exception_Message = ex.Message;
                oResult_Delete_Setup.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Setup;
        #endregion
    }
    #endregion
    #region Get_Alert_settings_By_USER_ID_Adv
    [HttpGet]
    [Route("Get_Alert_settings_By_USER_ID_Adv")]
    public Result_Get_Alert_settings_By_USER_ID_Adv Get_Alert_settings_By_USER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Alert_settings_By_USER_ID_Adv oResult_Get_Alert_settings_By_USER_ID_Adv = new Result_Get_Alert_settings_By_USER_ID_Adv();
        Params_Get_Alert_settings_By_USER_ID oParams_Get_Alert_settings_By_USER_ID = new Params_Get_Alert_settings_By_USER_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["USER_ID"].FirstOrDefault() != null && HttpContext.Request.Query["USER_ID"].ToString() != "undefined" && HttpContext.Request.Query["USER_ID"].ToString() != "null" && HttpContext.Request.Query["USER_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Alert_settings_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Alert_settings_By_USER_ID_Adv.i_Result = oBLC.Get_Alert_settings_By_USER_ID_Adv(oParams_Get_Alert_settings_By_USER_ID);
                oResult_Get_Alert_settings_By_USER_ID_Adv.Params_Get_Alert_settings_By_USER_ID = oParams_Get_Alert_settings_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Alert_settings_By_USER_ID_Adv.Params_Get_Alert_settings_By_USER_ID = oParams_Get_Alert_settings_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Alert_settings_By_USER_ID_Adv.Exception_Message = string.Format("Get_Alert_settings_By_USER_ID_Adv : {0}", ex.Message);
                oResult_Get_Alert_settings_By_USER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Alert_settings_By_USER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Alert_settings_By_USER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Alert_settings_By_USER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Alert_settings_By_USER_ID_Adv;
        #endregion
    }
    #endregion
    #region Send_Support_Email
    [HttpPost]
    [Route("Send_Support_Email")]
    public Result_Send_Support_Email Send_Support_Email(Params_Send_Support_Email i_Params_Send_Support_Email)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Send_Support_Email oResult_Send_Support_Email = new Result_Send_Support_Email();
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
                oBLC.Send_Support_Email(i_Params_Send_Support_Email);
                oResult_Send_Support_Email.Params_Send_Support_Email = i_Params_Send_Support_Email;
            }
        }
        catch (Exception ex)
        {
            oResult_Send_Support_Email.Params_Send_Support_Email = i_Params_Send_Support_Email;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Send_Support_Email.Exception_Message = string.Format("Send_Support_Email : {0}", ex.Message);
                oResult_Send_Support_Email.Stack_Trace = is_send_stack_trace ? string.Format("Send_Support_Email : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Send_Support_Email.Exception_Message = ex.Message;
                oResult_Send_Support_Email.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Send_Support_Email;
        #endregion
    }
    #endregion
    #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List
    [HttpGet]
    [Route("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List")]
    public Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List = new Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List();
        Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List = new Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["DISTRICTNEX_MODULE_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["DISTRICTNEX_MODULE_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["DISTRICTNEX_MODULE_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["DISTRICTNEX_MODULE_ID_LIST"].ToString() != "")
            {
                oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST = HttpContext.Request.Query["DISTRICTNEX_MODULE_ID_LIST"]
																											.ToString()
																											.Split(',')
																											.Where(val => int.TryParse(val, out _))
																											.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.i_Result = oBLC.Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List);
                oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List = oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List = oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.Exception_Message = string.Format("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List : {0}", ex.Message);
                oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.Exception_Message = ex.Message;
                oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List;
        #endregion
    }
    #endregion
    #region Drop_Collection
    [HttpPost]
    [Route("Drop_Collection")]
    public Result_Drop_Collection Drop_Collection(Params_Drop_Collection i_Params_Drop_Collection)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Drop_Collection oResult_Drop_Collection = new Result_Drop_Collection();
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
                oBLC.Drop_Collection(i_Params_Drop_Collection);
                oResult_Drop_Collection.Params_Drop_Collection = i_Params_Drop_Collection;
            }
        }
        catch (Exception ex)
        {
            oResult_Drop_Collection.Params_Drop_Collection = i_Params_Drop_Collection;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Drop_Collection.Exception_Message = string.Format("Drop_Collection : {0}", ex.Message);
                oResult_Drop_Collection.Stack_Trace = is_send_stack_trace ? string.Format("Drop_Collection : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Drop_Collection.Exception_Message = ex.Message;
                oResult_Drop_Collection.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Drop_Collection;
        #endregion
    }
    #endregion
    #region Edit_Build_version_List
    [HttpPost]
    [Route("Edit_Build_version_List")]
    public Result_Edit_Build_version_List Edit_Build_version_List(Params_Edit_Build_version_List i_Params_Edit_Build_version_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Build_version_List oResult_Edit_Build_version_List = new Result_Edit_Build_version_List();
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
                oBLC.Edit_Build_version_List(i_Params_Edit_Build_version_List);
                oResult_Edit_Build_version_List.Params_Edit_Build_version_List = i_Params_Edit_Build_version_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Build_version_List.Exception_Message = string.Format("Edit_Build_version_List : {0}", ex.Message);
                oResult_Edit_Build_version_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Build_version_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Build_version_List.Exception_Message = ex.Message;
                oResult_Edit_Build_version_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Build_version_List;
        #endregion
    }
    #endregion
    #region Create_Time_series_Collection
    [HttpPost]
    [Route("Create_Time_series_Collection")]
    public Result_Create_Time_series_Collection Create_Time_series_Collection(Params_Create_Time_series_Collection i_Params_Create_Time_series_Collection)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Create_Time_series_Collection oResult_Create_Time_series_Collection = new Result_Create_Time_series_Collection();
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
                oBLC.Create_Time_series_Collection(i_Params_Create_Time_series_Collection);
                oResult_Create_Time_series_Collection.Params_Create_Time_series_Collection = i_Params_Create_Time_series_Collection;
            }
        }
        catch (Exception ex)
        {
            oResult_Create_Time_series_Collection.Params_Create_Time_series_Collection = i_Params_Create_Time_series_Collection;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Create_Time_series_Collection.Exception_Message = string.Format("Create_Time_series_Collection : {0}", ex.Message);
                oResult_Create_Time_series_Collection.Stack_Trace = is_send_stack_trace ? string.Format("Create_Time_series_Collection : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Create_Time_series_Collection.Exception_Message = ex.Message;
                oResult_Create_Time_series_Collection.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Create_Time_series_Collection;
        #endregion
    }
    #endregion
    #region Get_Setup_By_SETUP_ID
    [HttpGet]
    [Route("Get_Setup_By_SETUP_ID")]
    public Result_Get_Setup_By_SETUP_ID Get_Setup_By_SETUP_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Setup_By_SETUP_ID oResult_Get_Setup_By_SETUP_ID = new Result_Get_Setup_By_SETUP_ID();
        Params_Get_Setup_By_SETUP_ID oParams_Get_Setup_By_SETUP_ID = new Params_Get_Setup_By_SETUP_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Setup_By_SETUP_ID.SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Setup_By_SETUP_ID.i_Result = oBLC.Get_Setup_By_SETUP_ID(oParams_Get_Setup_By_SETUP_ID);
                oResult_Get_Setup_By_SETUP_ID.Params_Get_Setup_By_SETUP_ID = oParams_Get_Setup_By_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Setup_By_SETUP_ID.Params_Get_Setup_By_SETUP_ID = oParams_Get_Setup_By_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Setup_By_SETUP_ID.Exception_Message = string.Format("Get_Setup_By_SETUP_ID : {0}", ex.Message);
                oResult_Get_Setup_By_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Setup_By_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Setup_By_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_Setup_By_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Setup_By_SETUP_ID;
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
#region Result_Edit_Setup
public partial class Result_Edit_Setup : Action_Result
{
    #region Properties.
    public Setup Setup { get; set; }
    #endregion
}
#endregion
#region Result_Get_Specialized_chart_configuration_By_MODULE
public partial class Result_Get_Specialized_chart_configuration_By_MODULE : Action_Result
{
    #region Properties.
    public List<Specialized_chart_configuration> i_Result { get; set; }
    public Params_Get_Specialized_chart_configuration_By_MODULE Params_Get_Specialized_chart_configuration_By_MODULE { get; set; }
    #endregion
}
#endregion
#region Result_Delete_District_geojson_By_DISTRICT_ID
public partial class Result_Delete_District_geojson_By_DISTRICT_ID : Action_Result
{
    #region Properties.
    public Params_Delete_District_geojson_By_DISTRICT_ID Params_Delete_District_geojson_By_DISTRICT_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_chart_configuration
public partial class Result_Get_Dimension_chart_configuration : Action_Result
{
    #region Properties.
    public List<Dimension_chart_configuration> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Setup_category_List
public partial class Result_Edit_Setup_category_List : Action_Result
{
    #region Properties.
    public Params_Edit_Setup_category_List Params_Edit_Setup_category_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Districtnex_module_By_OWNER_ID
public partial class Result_Get_Districtnex_module_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Districtnex_module> i_Result { get; set; }
    public Params_Get_Districtnex_module_By_OWNER_ID Params_Get_Districtnex_module_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Dimension_chart_configuration
public partial class Result_Edit_Dimension_chart_configuration : Action_Result
{
    #region Properties.
    public Dimension_chart_configuration i_Result { get; set; }
    public Dimension_chart_configuration Dimension_chart_configuration { get; set; }
    #endregion
}
#endregion
#region Result_Get_Setup_By_SETUP_ID_Adv
public partial class Result_Get_Setup_By_SETUP_ID_Adv : Action_Result
{
    #region Properties.
    public Setup i_Result { get; set; }
    public Params_Get_Setup_By_SETUP_ID Params_Get_Setup_By_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Default_settings_By_OWNER_ID
public partial class Result_Get_Default_settings_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Default_settings> i_Result { get; set; }
    public Params_Get_Default_settings_By_OWNER_ID Params_Get_Default_settings_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Object_View
public partial class Result_Edit_Object_View : Action_Result
{
    #region Properties.
    public Params_Edit_Object_View Params_Edit_Object_View { get; set; }
    #endregion
}
#endregion
#region Result_Get_Setup_category_By_OWNER_ID
public partial class Result_Get_Setup_category_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Setup_category> i_Result { get; set; }
    public Params_Get_Setup_category_By_OWNER_ID Params_Get_Setup_category_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Site_geojson
public partial class Result_Get_Site_geojson : Action_Result
{
    #region Properties.
    public List<string> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Edit_District_geojson
public partial class Result_Edit_District_geojson : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Edit_District_geojson Params_Edit_District_geojson { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Build_version
public partial class Result_Delete_Build_version : Action_Result
{
    #region Properties.
    public Params_Delete_Build_version Params_Delete_Build_version { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Ext_study_zone_geojson
public partial class Result_Edit_Ext_study_zone_geojson : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Edit_Ext_study_zone_geojson Params_Edit_Ext_study_zone_geojson { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Default_Settings_Picture
public partial class Result_Delete_Default_Settings_Picture : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Delete_Default_Settings_Picture Params_Delete_Default_Settings_Picture { get; set; }
    #endregion
}
#endregion
#region Result_Get_Specialized_chart_configuration
public partial class Result_Get_Specialized_chart_configuration : Action_Result
{
    #region Properties.
    public List<Specialized_chart_configuration> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Removed_extrusion_Custom_Old
public partial class Result_Edit_Removed_extrusion_Custom_Old : Action_Result
{
    #region Properties.
    public Params_Edit_Removed_extrusion_Custom_Old Params_Edit_Removed_extrusion_Custom_Old { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_geojson
public partial class Result_Get_Area_geojson : Action_Result
{
    #region Properties.
    public List<string> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Setup_category
public partial class Result_Delete_Setup_category : Action_Result
{
    #region Properties.
    public Params_Delete_Setup_category Params_Delete_Setup_category { get; set; }
    #endregion
}
#endregion
#region Result_Get_Build_version_By_OWNER_ID_Adv
public partial class Result_Get_Build_version_By_OWNER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Build_version> i_Result { get; set; }
    public Params_Get_Build_version_By_OWNER_ID Params_Get_Build_version_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Build_version
public partial class Result_Edit_Build_version : Action_Result
{
    #region Properties.
    public Build_version Build_version { get; set; }
    #endregion
}
#endregion
#region Result_Get_Default_chart_color_By_OWNER_ID_Adv
public partial class Result_Get_Default_chart_color_By_OWNER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Default_chart_color> i_Result { get; set; }
    public Params_Get_Default_chart_color_By_OWNER_ID Params_Get_Default_chart_color_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Default_chart_color_List
public partial class Result_Edit_Default_chart_color_List : Action_Result
{
    #region Properties.
    public Params_Edit_Default_chart_color_List Params_Edit_Default_chart_color_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_District_geojson
public partial class Result_Get_District_geojson : Action_Result
{
    #region Properties.
    public List<string> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Specialized_chart_configuration
public partial class Result_Edit_Specialized_chart_configuration : Action_Result
{
    #region Properties.
    public Specialized_chart_configuration i_Result { get; set; }
    public Specialized_chart_configuration Specialized_chart_configuration { get; set; }
    #endregion
}
#endregion
#region Result_Get_Setup_category_By_SETUP_CATEGORY_ID
public partial class Result_Get_Setup_category_By_SETUP_CATEGORY_ID : Action_Result
{
    #region Properties.
    public Setup_category i_Result { get; set; }
    public Params_Get_Setup_category_By_SETUP_CATEGORY_ID Params_Get_Setup_category_By_SETUP_CATEGORY_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
public partial class Result_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID Params_Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Setup_category
public partial class Result_Edit_Setup_category : Action_Result
{
    #region Properties.
    public Setup_category Setup_category { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Alert_settings_List
public partial class Result_Edit_Alert_settings_List : Action_Result
{
    #region Properties.
    public Params_Edit_Alert_settings_List Params_Edit_Alert_settings_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Dimension_chart_configuration
public partial class Result_Delete_Dimension_chart_configuration : Action_Result
{
    #region Properties.
    public Params_Delete_Dimension_chart_configuration Params_Delete_Dimension_chart_configuration { get; set; }
    #endregion
}
#endregion
#region Result_Get_Initial_Districtnex_Admin_Settings
public partial class Result_Get_Initial_Districtnex_Admin_Settings : Action_Result
{
    #region Properties.
    public Initial_Districtnex_Admin_Settings i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site_geojson
public partial class Result_Edit_Site_geojson : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Edit_Site_geojson Params_Edit_Site_geojson { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Area_geojson_By_AREA_ID
public partial class Result_Delete_Area_geojson_By_AREA_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Area_geojson_By_AREA_ID Params_Delete_Area_geojson_By_AREA_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Default_settings
public partial class Result_Edit_Default_settings : Action_Result
{
    #region Properties.
    public Default_settings Default_settings { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Specialized_chart_configuration
public partial class Result_Delete_Specialized_chart_configuration : Action_Result
{
    #region Properties.
    public Params_Delete_Specialized_chart_configuration Params_Delete_Specialized_chart_configuration { get; set; }
    #endregion
}
#endregion
#region Result_Get_Initial_Districtnex_UI_Settings
public partial class Result_Get_Initial_Districtnex_UI_Settings : Action_Result
{
    #region Properties.
    public Initial_Districtnex_UI_Settings i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Get_Alert_settings_By_OWNER_ID_Adv
public partial class Result_Get_Alert_settings_By_OWNER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Alert_settings> i_Result { get; set; }
    public Params_Get_Alert_settings_By_OWNER_ID Params_Get_Alert_settings_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID
public partial class Result_Get_Build_version_By_APPLICATION_NAME_SETUP_ID : Action_Result
{
    #region Properties.
    public List<Build_version> i_Result { get; set; }
    public Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Removed_extrusion_Custom
public partial class Result_Edit_Removed_extrusion_Custom : Action_Result
{
    #region Properties.
    public Params_Edit_Removed_extrusion_Custom Params_Edit_Removed_extrusion_Custom { get; set; }
    #endregion
}
#endregion
#region Result_Clean_Removed_extrusions
public partial class Result_Clean_Removed_extrusions : Action_Result
{
    #region Properties.
    #endregion
}
#endregion
#region Result_Delete_Kpi_chart_configuration
public partial class Result_Delete_Kpi_chart_configuration : Action_Result
{
    #region Properties.
    public Params_Delete_Kpi_chart_configuration Params_Delete_Kpi_chart_configuration { get; set; }
    #endregion
}
#endregion
#region Result_Get_UI_Build_Version_List
public partial class Result_Get_UI_Build_Version_List : Action_Result
{
    #region Properties.
    public Build_Version_List_With_Logs i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Get_Ext_study_zone_geojson
public partial class Result_Get_Ext_study_zone_geojson : Action_Result
{
    #region Properties.
    public List<string> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Custom_Edit_Build_version
public partial class Result_Custom_Edit_Build_version : Action_Result
{
    #region Properties.
    public Build_version i_Result { get; set; }
    public Params_Custom_Edit_Build_version Params_Custom_Edit_Build_version { get; set; }
    #endregion
}
#endregion
#region Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
public partial class Result_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID : Action_Result
{
    #region Properties.
    public Setup_category i_Result { get; set; }
    public Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Default_chart_color_By_OWNER_ID
public partial class Result_Get_Default_chart_color_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Default_chart_color> i_Result { get; set; }
    public Params_Get_Default_chart_color_By_OWNER_ID Params_Get_Default_chart_color_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Setup_By_OWNER_ID
public partial class Result_Get_Setup_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Setup> i_Result { get; set; }
    public Params_Get_Setup_By_OWNER_ID Params_Get_Setup_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_geojson
public partial class Result_Edit_Area_geojson : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Edit_Area_geojson Params_Edit_Area_geojson { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Site_geojson_By_SITE_ID
public partial class Result_Delete_Site_geojson_By_SITE_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Site_geojson_By_SITE_ID Params_Delete_Site_geojson_By_SITE_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Admin_Build_Version_List
public partial class Result_Get_Admin_Build_Version_List : Action_Result
{
    #region Properties.
    public Build_Version_List_With_Logs i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Removed_extrusion_List
public partial class Result_Edit_Removed_extrusion_List : Action_Result
{
    #region Properties.
    public Params_Edit_Removed_extrusion_List Params_Edit_Removed_extrusion_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Kpi_chart_configuration
public partial class Result_Edit_Kpi_chart_configuration : Action_Result
{
    #region Properties.
    public Kpi_chart_configuration i_Result { get; set; }
    public Kpi_chart_configuration Kpi_chart_configuration { get; set; }
    #endregion
}
#endregion
#region Result_Get_Kpi_chart_configuration
public partial class Result_Get_Kpi_chart_configuration : Action_Result
{
    #region Properties.
    public List<Kpi_chart_configuration> i_Result { get; set; }
    #endregion
}
#endregion
#region Result_Get_Removed_extrusion_By_OWNER_ID
public partial class Result_Get_Removed_extrusion_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Removed_extrusion> i_Result { get; set; }
    public Params_Get_Removed_extrusion_By_OWNER_ID Params_Get_Removed_extrusion_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Setup
public partial class Result_Delete_Setup : Action_Result
{
    #region Properties.
    public Params_Delete_Setup Params_Delete_Setup { get; set; }
    #endregion
}
#endregion
#region Result_Get_Alert_settings_By_USER_ID_Adv
public partial class Result_Get_Alert_settings_By_USER_ID_Adv : Action_Result
{
    #region Properties.
    public List<Alert_settings> i_Result { get; set; }
    public Params_Get_Alert_settings_By_USER_ID Params_Get_Alert_settings_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Send_Support_Email
public partial class Result_Send_Support_Email : Action_Result
{
    #region Properties.
    public Params_Send_Support_Email Params_Send_Support_Email { get; set; }
    #endregion
}
#endregion
#region Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List
public partial class Result_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List : Action_Result
{
    #region Properties.
    public List<Districtnex_module> i_Result { get; set; }
    public Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Drop_Collection
public partial class Result_Drop_Collection : Action_Result
{
    #region Properties.
    public Params_Drop_Collection Params_Drop_Collection { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Build_version_List
public partial class Result_Edit_Build_version_List : Action_Result
{
    #region Properties.
    public Params_Edit_Build_version_List Params_Edit_Build_version_List { get; set; }
    #endregion
}
#endregion
#region Result_Create_Time_series_Collection
public partial class Result_Create_Time_series_Collection : Action_Result
{
    #region Properties.
    public Params_Create_Time_series_Collection Params_Create_Time_series_Collection { get; set; }
    #endregion
}
#endregion
#region Result_Get_Setup_By_SETUP_ID
public partial class Result_Get_Setup_By_SETUP_ID : Action_Result
{
    #region Properties.
    public Setup i_Result { get; set; }
    public Params_Get_Setup_By_SETUP_ID Params_Get_Setup_By_SETUP_ID { get; set; }
    #endregion
}
#endregion
