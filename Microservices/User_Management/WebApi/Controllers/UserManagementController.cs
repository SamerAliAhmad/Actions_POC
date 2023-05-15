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
public partial class UserManagementController : ControllerBase
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
    #region Create_User
    [HttpPost]
    [Route("Create_User")]
    public Result_Create_User Create_User(Params_Create_User i_Params_Create_User)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Create_User oResult_Create_User = new Result_Create_User();
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
                oResult_Create_User.i_Result = oBLC.Create_User(i_Params_Create_User);
                oResult_Create_User.Params_Create_User = i_Params_Create_User;
            }
        }
        catch (Exception ex)
        {
            oResult_Create_User.Params_Create_User = i_Params_Create_User;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Create_User.Exception_Message = string.Format("Create_User : {0}", ex.Message);
                oResult_Create_User.Stack_Trace = is_send_stack_trace ? string.Format("Create_User : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Create_User.Exception_Message = ex.Message;
                oResult_Create_User.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Create_User;
        #endregion
    }
    #endregion
    #region Change_User_Password
    [HttpPost]
    [Route("Change_User_Password")]
    public Result_Change_User_Password Change_User_Password(Params_Change_User_Password i_Params_Change_User_Password)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Change_User_Password oResult_Change_User_Password = new Result_Change_User_Password();
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
                oResult_Change_User_Password.i_Result = oBLC.Change_User_Password(i_Params_Change_User_Password);
                oResult_Change_User_Password.Params_Change_User_Password = i_Params_Change_User_Password;
            }
        }
        catch (Exception ex)
        {
            oResult_Change_User_Password.Params_Change_User_Password = i_Params_Change_User_Password;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Change_User_Password.Exception_Message = string.Format("Change_User_Password : {0}", ex.Message);
                oResult_Change_User_Password.Stack_Trace = is_send_stack_trace ? string.Format("Change_User_Password : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Change_User_Password.Exception_Message = ex.Message;
                oResult_Change_User_Password.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Change_User_Password;
        #endregion
    }
    #endregion
    #region Edit_Area_kpi
    [HttpPost]
    [Route("Edit_Area_kpi")]
    public Result_Edit_Area_kpi Edit_Area_kpi(Area_kpi i_Area_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_kpi oResult_Edit_Area_kpi = new Result_Edit_Area_kpi();
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
                oBLC.Edit_Area_kpi(i_Area_kpi);
                oResult_Edit_Area_kpi.Area_kpi = i_Area_kpi;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_kpi.Exception_Message = string.Format("Edit_Area_kpi : {0}", ex.Message);
                oResult_Edit_Area_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_kpi.Exception_Message = ex.Message;
                oResult_Edit_Area_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_kpi;
        #endregion
    }
    #endregion
    #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
    [HttpGet]
    [Route("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List")]
    public Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List = new Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List();
        Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List oParams_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List = new Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ORGANIZATION_LEVEL_ACCESS_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ORGANIZATION_LEVEL_ACCESS_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ORGANIZATION_LEVEL_ACCESS_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ORGANIZATION_LEVEL_ACCESS_ID_LIST"].ToString() != "")
            {
                oParams_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST = HttpContext.Request.Query["ORGANIZATION_LEVEL_ACCESS_ID_LIST"]
																														.ToString()
																														.Split(',')
																														.Where(val => long.TryParse(val, out _))
																														.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.i_Result = oBLC.Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(oParams_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List);
                oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List = oParams_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List = oParams_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.Exception_Message = string.Format("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List : {0}", ex.Message);
                oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.Exception_Message = ex.Message;
                oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List;
        #endregion
    }
    #endregion
    #region Edit_User_Walkthrough
    [HttpPost]
    [Route("Edit_User_Walkthrough")]
    public Result_Edit_User_Walkthrough Edit_User_Walkthrough(Params_Edit_User_Walkthrough i_Params_Edit_User_Walkthrough)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_Walkthrough oResult_Edit_User_Walkthrough = new Result_Edit_User_Walkthrough();
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
                oBLC.Edit_User_Walkthrough(i_Params_Edit_User_Walkthrough);
                oResult_Edit_User_Walkthrough.Params_Edit_User_Walkthrough = i_Params_Edit_User_Walkthrough;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_User_Walkthrough.Params_Edit_User_Walkthrough = i_Params_Edit_User_Walkthrough;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_Walkthrough.Exception_Message = string.Format("Edit_User_Walkthrough : {0}", ex.Message);
                oResult_Edit_User_Walkthrough.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_Walkthrough : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_Walkthrough.Exception_Message = ex.Message;
                oResult_Edit_User_Walkthrough.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_Walkthrough;
        #endregion
    }
    #endregion
    #region Schedule_User_for_Delete
    [HttpPost]
    [Route("Schedule_User_for_Delete")]
    public Result_Schedule_User_for_Delete Schedule_User_for_Delete(Params_Schedule_User_for_Delete i_Params_Schedule_User_for_Delete)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Schedule_User_for_Delete oResult_Schedule_User_for_Delete = new Result_Schedule_User_for_Delete();
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
                oResult_Schedule_User_for_Delete.i_Result = oBLC.Schedule_User_for_Delete(i_Params_Schedule_User_for_Delete);
                oResult_Schedule_User_for_Delete.Params_Schedule_User_for_Delete = i_Params_Schedule_User_for_Delete;
            }
        }
        catch (Exception ex)
        {
            oResult_Schedule_User_for_Delete.Params_Schedule_User_for_Delete = i_Params_Schedule_User_for_Delete;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Schedule_User_for_Delete.Exception_Message = string.Format("Schedule_User_for_Delete : {0}", ex.Message);
                oResult_Schedule_User_for_Delete.Stack_Trace = is_send_stack_trace ? string.Format("Schedule_User_for_Delete : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Schedule_User_for_Delete.Exception_Message = ex.Message;
                oResult_Schedule_User_for_Delete.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Schedule_User_for_Delete;
        #endregion
    }
    #endregion
    #region Get_User_Accessible_Level_List
    [HttpPost]
    [Route("Get_User_Accessible_Level_List")]
    public Result_Get_User_Accessible_Level_List Get_User_Accessible_Level_List(Params_Get_User_Accessible_Level_List i_Params_Get_User_Accessible_Level_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_Accessible_Level_List oResult_Get_User_Accessible_Level_List = new Result_Get_User_Accessible_Level_List();
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
                oResult_Get_User_Accessible_Level_List.i_Result = oBLC.Get_User_Accessible_Level_List(i_Params_Get_User_Accessible_Level_List);
                oResult_Get_User_Accessible_Level_List.Params_Get_User_Accessible_Level_List = i_Params_Get_User_Accessible_Level_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_Accessible_Level_List.Params_Get_User_Accessible_Level_List = i_Params_Get_User_Accessible_Level_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_Accessible_Level_List.Exception_Message = string.Format("Get_User_Accessible_Level_List : {0}", ex.Message);
                oResult_Get_User_Accessible_Level_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_Accessible_Level_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_Accessible_Level_List.Exception_Message = ex.Message;
                oResult_Get_User_Accessible_Level_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_Accessible_Level_List;
        #endregion
    }
    #endregion
    #region Edit_District_kpi_user_access_List
    [HttpPost]
    [Route("Edit_District_kpi_user_access_List")]
    public Result_Edit_District_kpi_user_access_List Edit_District_kpi_user_access_List(Params_Edit_District_kpi_user_access_List i_Params_Edit_District_kpi_user_access_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_District_kpi_user_access_List oResult_Edit_District_kpi_user_access_List = new Result_Edit_District_kpi_user_access_List();
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
                oBLC.Edit_District_kpi_user_access_List(i_Params_Edit_District_kpi_user_access_List);
                oResult_Edit_District_kpi_user_access_List.Params_Edit_District_kpi_user_access_List = i_Params_Edit_District_kpi_user_access_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_District_kpi_user_access_List.Exception_Message = string.Format("Edit_District_kpi_user_access_List : {0}", ex.Message);
                oResult_Edit_District_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_District_kpi_user_access_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_District_kpi_user_access_List.Exception_Message = ex.Message;
                oResult_Edit_District_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_District_kpi_user_access_List;
        #endregion
    }
    #endregion
    #region Delete_Area_kpi
    [HttpPost]
    [Route("Delete_Area_kpi")]
    public Result_Delete_Area_kpi Delete_Area_kpi(Params_Delete_Area_kpi i_Params_Delete_Area_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Area_kpi oResult_Delete_Area_kpi = new Result_Delete_Area_kpi();
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
                oBLC.Delete_Area_kpi(i_Params_Delete_Area_kpi);
                oResult_Delete_Area_kpi.Params_Delete_Area_kpi = i_Params_Delete_Area_kpi;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Area_kpi.Params_Delete_Area_kpi = i_Params_Delete_Area_kpi;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Area_kpi.Exception_Message = string.Format("Delete_Area_kpi : {0}", ex.Message);
                oResult_Delete_Area_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Area_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Area_kpi.Exception_Message = ex.Message;
                oResult_Delete_Area_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Area_kpi;
        #endregion
    }
    #endregion
    #region Get_User_level_access_By_USER_ID_List
    [HttpGet]
    [Route("Get_User_level_access_By_USER_ID_List")]
    public Result_Get_User_level_access_By_USER_ID_List Get_User_level_access_By_USER_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_level_access_By_USER_ID_List oResult_Get_User_level_access_By_USER_ID_List = new Result_Get_User_level_access_By_USER_ID_List();
        Params_Get_User_level_access_By_USER_ID_List oParams_Get_User_level_access_By_USER_ID_List = new Params_Get_User_level_access_By_USER_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["USER_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["USER_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["USER_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["USER_ID_LIST"].ToString() != "")
            {
                oParams_Get_User_level_access_By_USER_ID_List.USER_ID_LIST = HttpContext.Request.Query["USER_ID_LIST"]
																				.ToString()
																				.Split(',')
																				.Where(val => long.TryParse(val, out _))
																				.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_level_access_By_USER_ID_List.i_Result = oBLC.Get_User_level_access_By_USER_ID_List(oParams_Get_User_level_access_By_USER_ID_List);
                oResult_Get_User_level_access_By_USER_ID_List.Params_Get_User_level_access_By_USER_ID_List = oParams_Get_User_level_access_By_USER_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_level_access_By_USER_ID_List.Params_Get_User_level_access_By_USER_ID_List = oParams_Get_User_level_access_By_USER_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_level_access_By_USER_ID_List.Exception_Message = string.Format("Get_User_level_access_By_USER_ID_List : {0}", ex.Message);
                oResult_Get_User_level_access_By_USER_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_level_access_By_USER_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_level_access_By_USER_ID_List.Exception_Message = ex.Message;
                oResult_Get_User_level_access_By_USER_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_level_access_By_USER_ID_List;
        #endregion
    }
    #endregion
    #region Delete_User_level_access
    [HttpPost]
    [Route("Delete_User_level_access")]
    public Result_Delete_User_level_access Delete_User_level_access(Params_Delete_User_level_access i_Params_Delete_User_level_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_User_level_access oResult_Delete_User_level_access = new Result_Delete_User_level_access();
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
                oBLC.Delete_User_level_access(i_Params_Delete_User_level_access);
                oResult_Delete_User_level_access.Params_Delete_User_level_access = i_Params_Delete_User_level_access;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_User_level_access.Params_Delete_User_level_access = i_Params_Delete_User_level_access;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_User_level_access.Exception_Message = string.Format("Delete_User_level_access : {0}", ex.Message);
                oResult_Delete_User_level_access.Stack_Trace = is_send_stack_trace ? string.Format("Delete_User_level_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_User_level_access.Exception_Message = ex.Message;
                oResult_Delete_User_level_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_User_level_access;
        #endregion
    }
    #endregion
    #region Edit_Entity_kpi_List
    [HttpPost]
    [Route("Edit_Entity_kpi_List")]
    public Result_Edit_Entity_kpi_List Edit_Entity_kpi_List(Params_Edit_Entity_kpi_List i_Params_Edit_Entity_kpi_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_kpi_List oResult_Edit_Entity_kpi_List = new Result_Edit_Entity_kpi_List();
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
                oBLC.Edit_Entity_kpi_List(i_Params_Edit_Entity_kpi_List);
                oResult_Edit_Entity_kpi_List.Params_Edit_Entity_kpi_List = i_Params_Edit_Entity_kpi_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_kpi_List.Exception_Message = string.Format("Edit_Entity_kpi_List : {0}", ex.Message);
                oResult_Edit_Entity_kpi_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_kpi_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_kpi_List.Exception_Message = ex.Message;
                oResult_Edit_Entity_kpi_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_kpi_List;
        #endregion
    }
    #endregion
    #region Get_User_By_ORGANIZATION_ID_Adv
    [HttpGet]
    [Route("Get_User_By_ORGANIZATION_ID_Adv")]
    public Result_Get_User_By_ORGANIZATION_ID_Adv Get_User_By_ORGANIZATION_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_ORGANIZATION_ID_Adv oResult_Get_User_By_ORGANIZATION_ID_Adv = new Result_Get_User_By_ORGANIZATION_ID_Adv();
        Params_Get_User_By_ORGANIZATION_ID oParams_Get_User_By_ORGANIZATION_ID = new Params_Get_User_By_ORGANIZATION_ID();
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
                oParams_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_ORGANIZATION_ID_Adv.i_Result = oBLC.Get_User_By_ORGANIZATION_ID_Adv(oParams_Get_User_By_ORGANIZATION_ID);
                oResult_Get_User_By_ORGANIZATION_ID_Adv.Params_Get_User_By_ORGANIZATION_ID = oParams_Get_User_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_ORGANIZATION_ID_Adv.Params_Get_User_By_ORGANIZATION_ID = oParams_Get_User_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_ORGANIZATION_ID_Adv.Exception_Message = string.Format("Get_User_By_ORGANIZATION_ID_Adv : {0}", ex.Message);
                oResult_Get_User_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_ORGANIZATION_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_ORGANIZATION_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_User_By_ORGANIZATION_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_ORGANIZATION_ID_Adv;
        #endregion
    }
    #endregion
    #region Edit_User_Details
    [HttpPost]
    [Route("Edit_User_Details")]
    public Result_Edit_User_Details Edit_User_Details(Params_Edit_User_Details i_Params_Edit_User_Details)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_Details oResult_Edit_User_Details = new Result_Edit_User_Details();
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
                oResult_Edit_User_Details.i_Result = oBLC.Edit_User_Details(i_Params_Edit_User_Details);
                oResult_Edit_User_Details.Params_Edit_User_Details = i_Params_Edit_User_Details;
            }
        }
        catch (Exception ex)
        {
            oResult_Edit_User_Details.Params_Edit_User_Details = i_Params_Edit_User_Details;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_Details.Exception_Message = string.Format("Edit_User_Details : {0}", ex.Message);
                oResult_Edit_User_Details.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_Details : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_Details.Exception_Message = ex.Message;
                oResult_Edit_User_Details.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_Details;
        #endregion
    }
    #endregion
    #region Edit_District_kpi_List
    [HttpPost]
    [Route("Edit_District_kpi_List")]
    public Result_Edit_District_kpi_List Edit_District_kpi_List(Params_Edit_District_kpi_List i_Params_Edit_District_kpi_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_District_kpi_List oResult_Edit_District_kpi_List = new Result_Edit_District_kpi_List();
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
                oBLC.Edit_District_kpi_List(i_Params_Edit_District_kpi_List);
                oResult_Edit_District_kpi_List.Params_Edit_District_kpi_List = i_Params_Edit_District_kpi_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_District_kpi_List.Exception_Message = string.Format("Edit_District_kpi_List : {0}", ex.Message);
                oResult_Edit_District_kpi_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_District_kpi_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_District_kpi_List.Exception_Message = ex.Message;
                oResult_Edit_District_kpi_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_District_kpi_List;
        #endregion
    }
    #endregion
    #region Edit_Entity_kpi
    [HttpPost]
    [Route("Edit_Entity_kpi")]
    public Result_Edit_Entity_kpi Edit_Entity_kpi(Entity_kpi i_Entity_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_kpi oResult_Edit_Entity_kpi = new Result_Edit_Entity_kpi();
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
                oBLC.Edit_Entity_kpi(i_Entity_kpi);
                oResult_Edit_Entity_kpi.Entity_kpi = i_Entity_kpi;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_kpi.Exception_Message = string.Format("Edit_Entity_kpi : {0}", ex.Message);
                oResult_Edit_Entity_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_kpi.Exception_Message = ex.Message;
                oResult_Edit_Entity_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_kpi;
        #endregion
    }
    #endregion
    #region Get_User_Accessible_Data_With_Level_List
    [HttpPost]
    [Route("Get_User_Accessible_Data_With_Level_List")]
    public Result_Get_User_Accessible_Data_With_Level_List Get_User_Accessible_Data_With_Level_List(Params_Get_User_Accessible_Data_With_Level_List i_Params_Get_User_Accessible_Data_With_Level_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_Accessible_Data_With_Level_List oResult_Get_User_Accessible_Data_With_Level_List = new Result_Get_User_Accessible_Data_With_Level_List();
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
                oResult_Get_User_Accessible_Data_With_Level_List.i_Result = oBLC.Get_User_Accessible_Data_With_Level_List(i_Params_Get_User_Accessible_Data_With_Level_List);
                oResult_Get_User_Accessible_Data_With_Level_List.Params_Get_User_Accessible_Data_With_Level_List = i_Params_Get_User_Accessible_Data_With_Level_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_Accessible_Data_With_Level_List.Params_Get_User_Accessible_Data_With_Level_List = i_Params_Get_User_Accessible_Data_With_Level_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_Accessible_Data_With_Level_List.Exception_Message = string.Format("Get_User_Accessible_Data_With_Level_List : {0}", ex.Message);
                oResult_Get_User_Accessible_Data_With_Level_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_Accessible_Data_With_Level_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_Accessible_Data_With_Level_List.Exception_Message = ex.Message;
                oResult_Get_User_Accessible_Data_With_Level_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_Accessible_Data_With_Level_List;
        #endregion
    }
    #endregion
    #region Get_User_districtnex_module_By_USER_ID_List
    [HttpGet]
    [Route("Get_User_districtnex_module_By_USER_ID_List")]
    public Result_Get_User_districtnex_module_By_USER_ID_List Get_User_districtnex_module_By_USER_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_districtnex_module_By_USER_ID_List oResult_Get_User_districtnex_module_By_USER_ID_List = new Result_Get_User_districtnex_module_By_USER_ID_List();
        Params_Get_User_districtnex_module_By_USER_ID_List oParams_Get_User_districtnex_module_By_USER_ID_List = new Params_Get_User_districtnex_module_By_USER_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["USER_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["USER_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["USER_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["USER_ID_LIST"].ToString() != "")
            {
                oParams_Get_User_districtnex_module_By_USER_ID_List.USER_ID_LIST = HttpContext.Request.Query["USER_ID_LIST"]
																					.ToString()
																					.Split(',')
																					.Where(val => long.TryParse(val, out _))
																					.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_districtnex_module_By_USER_ID_List.i_Result = oBLC.Get_User_districtnex_module_By_USER_ID_List(oParams_Get_User_districtnex_module_By_USER_ID_List);
                oResult_Get_User_districtnex_module_By_USER_ID_List.Params_Get_User_districtnex_module_By_USER_ID_List = oParams_Get_User_districtnex_module_By_USER_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_districtnex_module_By_USER_ID_List.Params_Get_User_districtnex_module_By_USER_ID_List = oParams_Get_User_districtnex_module_By_USER_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_districtnex_module_By_USER_ID_List.Exception_Message = string.Format("Get_User_districtnex_module_By_USER_ID_List : {0}", ex.Message);
                oResult_Get_User_districtnex_module_By_USER_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_districtnex_module_By_USER_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_districtnex_module_By_USER_ID_List.Exception_Message = ex.Message;
                oResult_Get_User_districtnex_module_By_USER_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_districtnex_module_By_USER_ID_List;
        #endregion
    }
    #endregion
    #region Get_User_By_USER_ID_List
    [HttpPost]
    [Route("Get_User_By_USER_ID_List")]
    public Result_Get_User_By_USER_ID_List Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_USER_ID_List oResult_Get_User_By_USER_ID_List = new Result_Get_User_By_USER_ID_List();
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
                oResult_Get_User_By_USER_ID_List.i_Result = oBLC.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List);
                oResult_Get_User_By_USER_ID_List.Params_Get_User_By_USER_ID_List = i_Params_Get_User_By_USER_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_USER_ID_List.Params_Get_User_By_USER_ID_List = i_Params_Get_User_By_USER_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_USER_ID_List.Exception_Message = string.Format("Get_User_By_USER_ID_List : {0}", ex.Message);
                oResult_Get_User_By_USER_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_USER_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_USER_ID_List.Exception_Message = ex.Message;
                oResult_Get_User_By_USER_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_USER_ID_List;
        #endregion
    }
    #endregion
    #region Get_User_districtnex_module_By_USER_ID
    [HttpGet]
    [Route("Get_User_districtnex_module_By_USER_ID")]
    public Result_Get_User_districtnex_module_By_USER_ID Get_User_districtnex_module_By_USER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_districtnex_module_By_USER_ID oResult_Get_User_districtnex_module_By_USER_ID = new Result_Get_User_districtnex_module_By_USER_ID();
        Params_Get_User_districtnex_module_By_USER_ID oParams_Get_User_districtnex_module_By_USER_ID = new Params_Get_User_districtnex_module_By_USER_ID();
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
                oParams_Get_User_districtnex_module_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_districtnex_module_By_USER_ID.i_Result = oBLC.Get_User_districtnex_module_By_USER_ID(oParams_Get_User_districtnex_module_By_USER_ID);
                oResult_Get_User_districtnex_module_By_USER_ID.Params_Get_User_districtnex_module_By_USER_ID = oParams_Get_User_districtnex_module_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_districtnex_module_By_USER_ID.Params_Get_User_districtnex_module_By_USER_ID = oParams_Get_User_districtnex_module_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_districtnex_module_By_USER_ID.Exception_Message = string.Format("Get_User_districtnex_module_By_USER_ID : {0}", ex.Message);
                oResult_Get_User_districtnex_module_By_USER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_districtnex_module_By_USER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_districtnex_module_By_USER_ID.Exception_Message = ex.Message;
                oResult_Get_User_districtnex_module_By_USER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_districtnex_module_By_USER_ID;
        #endregion
    }
    #endregion
    #region Get_User_By_ORGANIZATION_ID
    [HttpGet]
    [Route("Get_User_By_ORGANIZATION_ID")]
    public Result_Get_User_By_ORGANIZATION_ID Get_User_By_ORGANIZATION_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_ORGANIZATION_ID oResult_Get_User_By_ORGANIZATION_ID = new Result_Get_User_By_ORGANIZATION_ID();
        Params_Get_User_By_ORGANIZATION_ID oParams_Get_User_By_ORGANIZATION_ID = new Params_Get_User_By_ORGANIZATION_ID();
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
                oParams_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["ORGANIZATION_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_ORGANIZATION_ID.i_Result = oBLC.Get_User_By_ORGANIZATION_ID(oParams_Get_User_By_ORGANIZATION_ID);
                oResult_Get_User_By_ORGANIZATION_ID.Params_Get_User_By_ORGANIZATION_ID = oParams_Get_User_By_ORGANIZATION_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_ORGANIZATION_ID.Params_Get_User_By_ORGANIZATION_ID = oParams_Get_User_By_ORGANIZATION_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_ORGANIZATION_ID.Exception_Message = string.Format("Get_User_By_ORGANIZATION_ID : {0}", ex.Message);
                oResult_Get_User_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_ORGANIZATION_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_ORGANIZATION_ID.Exception_Message = ex.Message;
                oResult_Get_User_By_ORGANIZATION_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_ORGANIZATION_ID;
        #endregion
    }
    #endregion
    #region Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
    [HttpGet]
    [Route("Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID")]
    public Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID = new Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID();
        Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID oParams_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID = new Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID();
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
                oParams_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            if (HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].FirstOrDefault() != null && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "undefined" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "null" && HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["DATA_LEVEL_SETUP_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.i_Result = oBLC.Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(oParams_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID);
                oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID = oParams_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID = oParams_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.Exception_Message = string.Format("Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID : {0}", ex.Message);
                oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.Exception_Message = ex.Message;
                oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID;
        #endregion
    }
    #endregion
    #region Edit_Entity_kpi_user_access_List
    [HttpPost]
    [Route("Edit_Entity_kpi_user_access_List")]
    public Result_Edit_Entity_kpi_user_access_List Edit_Entity_kpi_user_access_List(Params_Edit_Entity_kpi_user_access_List i_Params_Edit_Entity_kpi_user_access_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_kpi_user_access_List oResult_Edit_Entity_kpi_user_access_List = new Result_Edit_Entity_kpi_user_access_List();
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
                oBLC.Edit_Entity_kpi_user_access_List(i_Params_Edit_Entity_kpi_user_access_List);
                oResult_Edit_Entity_kpi_user_access_List.Params_Edit_Entity_kpi_user_access_List = i_Params_Edit_Entity_kpi_user_access_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_kpi_user_access_List.Exception_Message = string.Format("Edit_Entity_kpi_user_access_List : {0}", ex.Message);
                oResult_Edit_Entity_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_kpi_user_access_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_kpi_user_access_List.Exception_Message = ex.Message;
                oResult_Edit_Entity_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_kpi_user_access_List;
        #endregion
    }
    #endregion
    #region Get_User_By_USER_ID_List_Adv
    [HttpPost]
    [Route("Get_User_By_USER_ID_List_Adv")]
    public Result_Get_User_By_USER_ID_List_Adv Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_USER_ID_List_Adv oResult_Get_User_By_USER_ID_List_Adv = new Result_Get_User_By_USER_ID_List_Adv();
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
                oResult_Get_User_By_USER_ID_List_Adv.i_Result = oBLC.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List);
                oResult_Get_User_By_USER_ID_List_Adv.Params_Get_User_By_USER_ID_List = i_Params_Get_User_By_USER_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_USER_ID_List_Adv.Params_Get_User_By_USER_ID_List = i_Params_Get_User_By_USER_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_USER_ID_List_Adv.Exception_Message = string.Format("Get_User_By_USER_ID_List_Adv : {0}", ex.Message);
                oResult_Get_User_By_USER_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_USER_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_USER_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_User_By_USER_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_USER_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Edit_Site_kpi_user_access
    [HttpPost]
    [Route("Edit_Site_kpi_user_access")]
    public Result_Edit_Site_kpi_user_access Edit_Site_kpi_user_access(Site_kpi_user_access i_Site_kpi_user_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_kpi_user_access oResult_Edit_Site_kpi_user_access = new Result_Edit_Site_kpi_user_access();
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
                oBLC.Edit_Site_kpi_user_access(i_Site_kpi_user_access);
                oResult_Edit_Site_kpi_user_access.Site_kpi_user_access = i_Site_kpi_user_access;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_kpi_user_access.Exception_Message = string.Format("Edit_Site_kpi_user_access : {0}", ex.Message);
                oResult_Edit_Site_kpi_user_access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_kpi_user_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_kpi_user_access.Exception_Message = ex.Message;
                oResult_Edit_Site_kpi_user_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_kpi_user_access;
        #endregion
    }
    #endregion
    #region Edit_Entity_kpi_user_access
    [HttpPost]
    [Route("Edit_Entity_kpi_user_access")]
    public Result_Edit_Entity_kpi_user_access Edit_Entity_kpi_user_access(Entity_kpi_user_access i_Entity_kpi_user_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Entity_kpi_user_access oResult_Edit_Entity_kpi_user_access = new Result_Edit_Entity_kpi_user_access();
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
                oBLC.Edit_Entity_kpi_user_access(i_Entity_kpi_user_access);
                oResult_Edit_Entity_kpi_user_access.Entity_kpi_user_access = i_Entity_kpi_user_access;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Entity_kpi_user_access.Exception_Message = string.Format("Edit_Entity_kpi_user_access : {0}", ex.Message);
                oResult_Edit_Entity_kpi_user_access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Entity_kpi_user_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Entity_kpi_user_access.Exception_Message = ex.Message;
                oResult_Edit_Entity_kpi_user_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Entity_kpi_user_access;
        #endregion
    }
    #endregion
    #region Edit_Area_kpi_List
    [HttpPost]
    [Route("Edit_Area_kpi_List")]
    public Result_Edit_Area_kpi_List Edit_Area_kpi_List(Params_Edit_Area_kpi_List i_Params_Edit_Area_kpi_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_kpi_List oResult_Edit_Area_kpi_List = new Result_Edit_Area_kpi_List();
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
                oBLC.Edit_Area_kpi_List(i_Params_Edit_Area_kpi_List);
                oResult_Edit_Area_kpi_List.Params_Edit_Area_kpi_List = i_Params_Edit_Area_kpi_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_kpi_List.Exception_Message = string.Format("Edit_Area_kpi_List : {0}", ex.Message);
                oResult_Edit_Area_kpi_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_kpi_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_kpi_List.Exception_Message = ex.Message;
                oResult_Edit_Area_kpi_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_kpi_List;
        #endregion
    }
    #endregion
    #region Delete_Site_kpi
    [HttpPost]
    [Route("Delete_Site_kpi")]
    public Result_Delete_Site_kpi Delete_Site_kpi(Params_Delete_Site_kpi i_Params_Delete_Site_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Site_kpi oResult_Delete_Site_kpi = new Result_Delete_Site_kpi();
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
                oBLC.Delete_Site_kpi(i_Params_Delete_Site_kpi);
                oResult_Delete_Site_kpi.Params_Delete_Site_kpi = i_Params_Delete_Site_kpi;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Site_kpi.Params_Delete_Site_kpi = i_Params_Delete_Site_kpi;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Site_kpi.Exception_Message = string.Format("Delete_Site_kpi : {0}", ex.Message);
                oResult_Delete_Site_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Site_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Site_kpi.Exception_Message = ex.Message;
                oResult_Delete_Site_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Site_kpi;
        #endregion
    }
    #endregion
    #region Edit_User_level_access_List
    [HttpPost]
    [Route("Edit_User_level_access_List")]
    public Result_Edit_User_level_access_List Edit_User_level_access_List(Params_Edit_User_level_access_List i_Params_Edit_User_level_access_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_level_access_List oResult_Edit_User_level_access_List = new Result_Edit_User_level_access_List();
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
                oBLC.Edit_User_level_access_List(i_Params_Edit_User_level_access_List);
                oResult_Edit_User_level_access_List.Params_Edit_User_level_access_List = i_Params_Edit_User_level_access_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_level_access_List.Exception_Message = string.Format("Edit_User_level_access_List : {0}", ex.Message);
                oResult_Edit_User_level_access_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_level_access_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_level_access_List.Exception_Message = ex.Message;
                oResult_Edit_User_level_access_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_level_access_List;
        #endregion
    }
    #endregion
    #region Delete_Entity_kpi
    [HttpPost]
    [Route("Delete_Entity_kpi")]
    public Result_Delete_Entity_kpi Delete_Entity_kpi(Params_Delete_Entity_kpi i_Params_Delete_Entity_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Entity_kpi oResult_Delete_Entity_kpi = new Result_Delete_Entity_kpi();
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
                oBLC.Delete_Entity_kpi(i_Params_Delete_Entity_kpi);
                oResult_Delete_Entity_kpi.Params_Delete_Entity_kpi = i_Params_Delete_Entity_kpi;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Entity_kpi.Params_Delete_Entity_kpi = i_Params_Delete_Entity_kpi;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Entity_kpi.Exception_Message = string.Format("Delete_Entity_kpi : {0}", ex.Message);
                oResult_Delete_Entity_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Entity_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Entity_kpi.Exception_Message = ex.Message;
                oResult_Delete_Entity_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Entity_kpi;
        #endregion
    }
    #endregion
    #region Get_User_Accessible_Data
    [HttpPost]
    [Route("Get_User_Accessible_Data")]
    public Result_Get_User_Accessible_Data Get_User_Accessible_Data(Params_Get_User_Accessible_Data i_Params_Get_User_Accessible_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_Accessible_Data oResult_Get_User_Accessible_Data = new Result_Get_User_Accessible_Data();
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
                oResult_Get_User_Accessible_Data.i_Result = oBLC.Get_User_Accessible_Data(i_Params_Get_User_Accessible_Data);
                oResult_Get_User_Accessible_Data.Params_Get_User_Accessible_Data = i_Params_Get_User_Accessible_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_Accessible_Data.Params_Get_User_Accessible_Data = i_Params_Get_User_Accessible_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_Accessible_Data.Exception_Message = string.Format("Get_User_Accessible_Data : {0}", ex.Message);
                oResult_Get_User_Accessible_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_Accessible_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_Accessible_Data.Exception_Message = ex.Message;
                oResult_Get_User_Accessible_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_Accessible_Data;
        #endregion
    }
    #endregion
    #region Edit_User_districtnex_module_List
    [HttpPost]
    [Route("Edit_User_districtnex_module_List")]
    public Result_Edit_User_districtnex_module_List Edit_User_districtnex_module_List(Params_Edit_User_districtnex_module_List i_Params_Edit_User_districtnex_module_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_districtnex_module_List oResult_Edit_User_districtnex_module_List = new Result_Edit_User_districtnex_module_List();
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
                oBLC.Edit_User_districtnex_module_List(i_Params_Edit_User_districtnex_module_List);
                oResult_Edit_User_districtnex_module_List.Params_Edit_User_districtnex_module_List = i_Params_Edit_User_districtnex_module_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_districtnex_module_List.Exception_Message = string.Format("Edit_User_districtnex_module_List : {0}", ex.Message);
                oResult_Edit_User_districtnex_module_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_districtnex_module_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_districtnex_module_List.Exception_Message = ex.Message;
                oResult_Edit_User_districtnex_module_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_districtnex_module_List;
        #endregion
    }
    #endregion
    #region Edit_Site_kpi_user_access_List
    [HttpPost]
    [Route("Edit_Site_kpi_user_access_List")]
    public Result_Edit_Site_kpi_user_access_List Edit_Site_kpi_user_access_List(Params_Edit_Site_kpi_user_access_List i_Params_Edit_Site_kpi_user_access_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_kpi_user_access_List oResult_Edit_Site_kpi_user_access_List = new Result_Edit_Site_kpi_user_access_List();
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
                oBLC.Edit_Site_kpi_user_access_List(i_Params_Edit_Site_kpi_user_access_List);
                oResult_Edit_Site_kpi_user_access_List.Params_Edit_Site_kpi_user_access_List = i_Params_Edit_Site_kpi_user_access_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_kpi_user_access_List.Exception_Message = string.Format("Edit_Site_kpi_user_access_List : {0}", ex.Message);
                oResult_Edit_Site_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_kpi_user_access_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_kpi_user_access_List.Exception_Message = ex.Message;
                oResult_Edit_Site_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_kpi_user_access_List;
        #endregion
    }
    #endregion
    #region Get_Initial_Data
    [HttpPost]
    [Route("Get_Initial_Data")]
    public Result_Get_Initial_Data Get_Initial_Data(Params_Get_Initial_Data i_Params_Get_Initial_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Initial_Data oResult_Get_Initial_Data = new Result_Get_Initial_Data();
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
                oResult_Get_Initial_Data.i_Result = oBLC.Get_Initial_Data(i_Params_Get_Initial_Data);
                oResult_Get_Initial_Data.Params_Get_Initial_Data = i_Params_Get_Initial_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Initial_Data.Params_Get_Initial_Data = i_Params_Get_Initial_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Initial_Data.Exception_Message = string.Format("Get_Initial_Data : {0}", ex.Message);
                oResult_Get_Initial_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Initial_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Initial_Data.Exception_Message = ex.Message;
                oResult_Get_Initial_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Initial_Data;
        #endregion
    }
    #endregion
    #region Get_User_By_ORGANIZATION_ID_List
    [HttpGet]
    [Route("Get_User_By_ORGANIZATION_ID_List")]
    public Result_Get_User_By_ORGANIZATION_ID_List Get_User_By_ORGANIZATION_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_ORGANIZATION_ID_List oResult_Get_User_By_ORGANIZATION_ID_List = new Result_Get_User_By_ORGANIZATION_ID_List();
        Params_Get_User_By_ORGANIZATION_ID_List oParams_Get_User_By_ORGANIZATION_ID_List = new Params_Get_User_By_ORGANIZATION_ID_List();
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
                oParams_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																				.ToString()
																				.Split(',')
																				.Where(val => int.TryParse(val, out _))
																				.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_ORGANIZATION_ID_List.i_Result = oBLC.Get_User_By_ORGANIZATION_ID_List(oParams_Get_User_By_ORGANIZATION_ID_List);
                oResult_Get_User_By_ORGANIZATION_ID_List.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_ORGANIZATION_ID_List.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_ORGANIZATION_ID_List.Exception_Message = string.Format("Get_User_By_ORGANIZATION_ID_List : {0}", ex.Message);
                oResult_Get_User_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_ORGANIZATION_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_ORGANIZATION_ID_List.Exception_Message = ex.Message;
                oResult_Get_User_By_ORGANIZATION_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_ORGANIZATION_ID_List;
        #endregion
    }
    #endregion
    #region Edit_District_kpi
    [HttpPost]
    [Route("Edit_District_kpi")]
    public Result_Edit_District_kpi Edit_District_kpi(District_kpi i_District_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_District_kpi oResult_Edit_District_kpi = new Result_Edit_District_kpi();
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
                oBLC.Edit_District_kpi(i_District_kpi);
                oResult_Edit_District_kpi.District_kpi = i_District_kpi;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_District_kpi.Exception_Message = string.Format("Edit_District_kpi : {0}", ex.Message);
                oResult_Edit_District_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Edit_District_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_District_kpi.Exception_Message = ex.Message;
                oResult_Edit_District_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_District_kpi;
        #endregion
    }
    #endregion
    #region Change_Password
    [HttpPost]
    [Route("Change_Password")]
    public Result_Change_Password Change_Password(Params_Change_Password i_Params_Change_Password)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Change_Password oResult_Change_Password = new Result_Change_Password();
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
                oResult_Change_Password.i_Result = oBLC.Change_Password(i_Params_Change_Password);
                oResult_Change_Password.Params_Change_Password = i_Params_Change_Password;
            }
        }
        catch (Exception ex)
        {
            oResult_Change_Password.Params_Change_Password = i_Params_Change_Password;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Change_Password.Exception_Message = string.Format("Change_Password : {0}", ex.Message);
                oResult_Change_Password.Stack_Trace = is_send_stack_trace ? string.Format("Change_Password : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Change_Password.Exception_Message = ex.Message;
                oResult_Change_Password.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Change_Password;
        #endregion
    }
    #endregion
    #region Delete_District_kpi
    [HttpPost]
    [Route("Delete_District_kpi")]
    public Result_Delete_District_kpi Delete_District_kpi(Params_Delete_District_kpi i_Params_Delete_District_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_District_kpi oResult_Delete_District_kpi = new Result_Delete_District_kpi();
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
                oBLC.Delete_District_kpi(i_Params_Delete_District_kpi);
                oResult_Delete_District_kpi.Params_Delete_District_kpi = i_Params_Delete_District_kpi;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_District_kpi.Params_Delete_District_kpi = i_Params_Delete_District_kpi;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_District_kpi.Exception_Message = string.Format("Delete_District_kpi : {0}", ex.Message);
                oResult_Delete_District_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Delete_District_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_District_kpi.Exception_Message = ex.Message;
                oResult_Delete_District_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_District_kpi;
        #endregion
    }
    #endregion
    #region Edit_Site_kpi_List
    [HttpPost]
    [Route("Edit_Site_kpi_List")]
    public Result_Edit_Site_kpi_List Edit_Site_kpi_List(Params_Edit_Site_kpi_List i_Params_Edit_Site_kpi_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_kpi_List oResult_Edit_Site_kpi_List = new Result_Edit_Site_kpi_List();
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
                oBLC.Edit_Site_kpi_List(i_Params_Edit_Site_kpi_List);
                oResult_Edit_Site_kpi_List.Params_Edit_Site_kpi_List = i_Params_Edit_Site_kpi_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_kpi_List.Exception_Message = string.Format("Edit_Site_kpi_List : {0}", ex.Message);
                oResult_Edit_Site_kpi_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_kpi_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_kpi_List.Exception_Message = ex.Message;
                oResult_Edit_Site_kpi_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_kpi_List;
        #endregion
    }
    #endregion
    #region Get_Entity_Intersection_List
    [HttpPost]
    [Route("Get_Entity_Intersection_List")]
    public Result_Get_Entity_Intersection_List Get_Entity_Intersection_List(Params_Get_Entity_Intersection_List i_Params_Get_Entity_Intersection_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Entity_Intersection_List oResult_Get_Entity_Intersection_List = new Result_Get_Entity_Intersection_List();
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
                oResult_Get_Entity_Intersection_List.i_Result = oBLC.Get_Entity_Intersection_List(i_Params_Get_Entity_Intersection_List);
                oResult_Get_Entity_Intersection_List.Params_Get_Entity_Intersection_List = i_Params_Get_Entity_Intersection_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Entity_Intersection_List.Params_Get_Entity_Intersection_List = i_Params_Get_Entity_Intersection_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Entity_Intersection_List.Exception_Message = string.Format("Get_Entity_Intersection_List : {0}", ex.Message);
                oResult_Get_Entity_Intersection_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Entity_Intersection_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Entity_Intersection_List.Exception_Message = ex.Message;
                oResult_Get_Entity_Intersection_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Entity_Intersection_List;
        #endregion
    }
    #endregion
    #region Check_User_Deletion_Status
    [HttpPost]
    [Route("Check_User_Deletion_Status")]
    public Result_Check_User_Deletion_Status Check_User_Deletion_Status()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Check_User_Deletion_Status oResult_Check_User_Deletion_Status = new Result_Check_User_Deletion_Status();
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
                oBLC.Check_User_Deletion_Status();
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Check_User_Deletion_Status.Exception_Message = string.Format("Check_User_Deletion_Status : {0}", ex.Message);
                oResult_Check_User_Deletion_Status.Stack_Trace = is_send_stack_trace ? string.Format("Check_User_Deletion_Status : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Check_User_Deletion_Status.Exception_Message = ex.Message;
                oResult_Check_User_Deletion_Status.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Check_User_Deletion_Status;
        #endregion
    }
    #endregion
    #region Get_User_By_IS_RECEIVE_EMAIL
    [HttpGet]
    [Route("Get_User_By_IS_RECEIVE_EMAIL")]
    public Result_Get_User_By_IS_RECEIVE_EMAIL Get_User_By_IS_RECEIVE_EMAIL()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_IS_RECEIVE_EMAIL oResult_Get_User_By_IS_RECEIVE_EMAIL = new Result_Get_User_By_IS_RECEIVE_EMAIL();
        Params_Get_User_By_IS_RECEIVE_EMAIL oParams_Get_User_By_IS_RECEIVE_EMAIL = new Params_Get_User_By_IS_RECEIVE_EMAIL();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["IS_RECEIVE_EMAIL"].FirstOrDefault() != null && HttpContext.Request.Query["IS_RECEIVE_EMAIL"].ToString() != "undefined" && HttpContext.Request.Query["IS_RECEIVE_EMAIL"].ToString() != "null" && HttpContext.Request.Query["IS_RECEIVE_EMAIL"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(bool));
                oParams_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL = (bool)typeConverter.ConvertFromString(HttpContext.Request.Query["IS_RECEIVE_EMAIL"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_IS_RECEIVE_EMAIL.i_Result = oBLC.Get_User_By_IS_RECEIVE_EMAIL(oParams_Get_User_By_IS_RECEIVE_EMAIL);
                oResult_Get_User_By_IS_RECEIVE_EMAIL.Params_Get_User_By_IS_RECEIVE_EMAIL = oParams_Get_User_By_IS_RECEIVE_EMAIL;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_IS_RECEIVE_EMAIL.Params_Get_User_By_IS_RECEIVE_EMAIL = oParams_Get_User_By_IS_RECEIVE_EMAIL;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_IS_RECEIVE_EMAIL.Exception_Message = string.Format("Get_User_By_IS_RECEIVE_EMAIL : {0}", ex.Message);
                oResult_Get_User_By_IS_RECEIVE_EMAIL.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_IS_RECEIVE_EMAIL : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_IS_RECEIVE_EMAIL.Exception_Message = ex.Message;
                oResult_Get_User_By_IS_RECEIVE_EMAIL.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_IS_RECEIVE_EMAIL;
        #endregion
    }
    #endregion
    #region Get_User_By_USER_ID
    [HttpGet]
    [Route("Get_User_By_USER_ID")]
    public Result_Get_User_By_USER_ID Get_User_By_USER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_USER_ID oResult_Get_User_By_USER_ID = new Result_Get_User_By_USER_ID();
        Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
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
                oParams_Get_User_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_USER_ID.i_Result = oBLC.Get_User_By_USER_ID(oParams_Get_User_By_USER_ID);
                oResult_Get_User_By_USER_ID.Params_Get_User_By_USER_ID = oParams_Get_User_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_USER_ID.Params_Get_User_By_USER_ID = oParams_Get_User_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_USER_ID.Exception_Message = string.Format("Get_User_By_USER_ID : {0}", ex.Message);
                oResult_Get_User_By_USER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_USER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_USER_ID.Exception_Message = ex.Message;
                oResult_Get_User_By_USER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_USER_ID;
        #endregion
    }
    #endregion
    #region Get_User_level_access_By_USER_ID
    [HttpGet]
    [Route("Get_User_level_access_By_USER_ID")]
    public Result_Get_User_level_access_By_USER_ID Get_User_level_access_By_USER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_level_access_By_USER_ID oResult_Get_User_level_access_By_USER_ID = new Result_Get_User_level_access_By_USER_ID();
        Params_Get_User_level_access_By_USER_ID oParams_Get_User_level_access_By_USER_ID = new Params_Get_User_level_access_By_USER_ID();
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
                oParams_Get_User_level_access_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_level_access_By_USER_ID.i_Result = oBLC.Get_User_level_access_By_USER_ID(oParams_Get_User_level_access_By_USER_ID);
                oResult_Get_User_level_access_By_USER_ID.Params_Get_User_level_access_By_USER_ID = oParams_Get_User_level_access_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_level_access_By_USER_ID.Params_Get_User_level_access_By_USER_ID = oParams_Get_User_level_access_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_level_access_By_USER_ID.Exception_Message = string.Format("Get_User_level_access_By_USER_ID : {0}", ex.Message);
                oResult_Get_User_level_access_By_USER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_level_access_By_USER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_level_access_By_USER_ID.Exception_Message = ex.Message;
                oResult_Get_User_level_access_By_USER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_level_access_By_USER_ID;
        #endregion
    }
    #endregion
    #region Get_Level_Data
    [HttpPost]
    [Route("Get_Level_Data")]
    public Result_Get_Level_Data Get_Level_Data(Params_Get_Level_Data i_Params_Get_Level_Data)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Level_Data oResult_Get_Level_Data = new Result_Get_Level_Data();
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
                oResult_Get_Level_Data.i_Result = oBLC.Get_Level_Data(i_Params_Get_Level_Data);
                oResult_Get_Level_Data.Params_Get_Level_Data = i_Params_Get_Level_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Level_Data.Params_Get_Level_Data = i_Params_Get_Level_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Level_Data.Exception_Message = string.Format("Get_Level_Data : {0}", ex.Message);
                oResult_Get_Level_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Level_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Level_Data.Exception_Message = ex.Message;
                oResult_Get_Level_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Level_Data;
        #endregion
    }
    #endregion
    #region Restore_User
    [HttpPost]
    [Route("Restore_User")]
    public Result_Restore_User Restore_User(Params_Restore_User i_Params_Restore_User)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Restore_User oResult_Restore_User = new Result_Restore_User();
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
                oResult_Restore_User.i_Result = oBLC.Restore_User(i_Params_Restore_User);
                oResult_Restore_User.Params_Restore_User = i_Params_Restore_User;
            }
        }
        catch (Exception ex)
        {
            oResult_Restore_User.Params_Restore_User = i_Params_Restore_User;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Restore_User.Exception_Message = string.Format("Restore_User : {0}", ex.Message);
                oResult_Restore_User.Stack_Trace = is_send_stack_trace ? string.Format("Restore_User : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Restore_User.Exception_Message = ex.Message;
                oResult_Restore_User.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Restore_User;
        #endregion
    }
    #endregion
    #region Get_User_districtnex_module_By_USER_ID_Adv
    [HttpGet]
    [Route("Get_User_districtnex_module_By_USER_ID_Adv")]
    public Result_Get_User_districtnex_module_By_USER_ID_Adv Get_User_districtnex_module_By_USER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_districtnex_module_By_USER_ID_Adv oResult_Get_User_districtnex_module_By_USER_ID_Adv = new Result_Get_User_districtnex_module_By_USER_ID_Adv();
        Params_Get_User_districtnex_module_By_USER_ID oParams_Get_User_districtnex_module_By_USER_ID = new Params_Get_User_districtnex_module_By_USER_ID();
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
                oParams_Get_User_districtnex_module_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_districtnex_module_By_USER_ID_Adv.i_Result = oBLC.Get_User_districtnex_module_By_USER_ID_Adv(oParams_Get_User_districtnex_module_By_USER_ID);
                oResult_Get_User_districtnex_module_By_USER_ID_Adv.Params_Get_User_districtnex_module_By_USER_ID = oParams_Get_User_districtnex_module_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_districtnex_module_By_USER_ID_Adv.Params_Get_User_districtnex_module_By_USER_ID = oParams_Get_User_districtnex_module_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_districtnex_module_By_USER_ID_Adv.Exception_Message = string.Format("Get_User_districtnex_module_By_USER_ID_Adv : {0}", ex.Message);
                oResult_Get_User_districtnex_module_By_USER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_districtnex_module_By_USER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_districtnex_module_By_USER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_User_districtnex_module_By_USER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_districtnex_module_By_USER_ID_Adv;
        #endregion
    }
    #endregion
    #region Edit_User_theme
    [HttpPost]
    [Route("Edit_User_theme")]
    public Result_Edit_User_theme Edit_User_theme(User_theme i_User_theme)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_theme oResult_Edit_User_theme = new Result_Edit_User_theme();
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
                oBLC.Edit_User_theme(i_User_theme);
                oResult_Edit_User_theme.User_theme = i_User_theme;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_theme.Exception_Message = string.Format("Edit_User_theme : {0}", ex.Message);
                oResult_Edit_User_theme.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_theme : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_theme.Exception_Message = ex.Message;
                oResult_Edit_User_theme.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_theme;
        #endregion
    }
    #endregion
    #region Edit_User_List
    [HttpPost]
    [Route("Edit_User_List")]
    public Result_Edit_User_List Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_User_List oResult_Edit_User_List = new Result_Edit_User_List();
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
                oBLC.Edit_User_List(i_Params_Edit_User_List);
                oResult_Edit_User_List.Params_Edit_User_List = i_Params_Edit_User_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_User_List.Exception_Message = string.Format("Edit_User_List : {0}", ex.Message);
                oResult_Edit_User_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_User_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_User_List.Exception_Message = ex.Message;
                oResult_Edit_User_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_User_List;
        #endregion
    }
    #endregion
    #region Get_Admin_Data
    [HttpGet]
    [Route("Get_Admin_Data")]
    public Result_Get_Admin_Data Get_Admin_Data()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Admin_Data oResult_Get_Admin_Data = new Result_Get_Admin_Data();
        Params_Get_Admin_Data oParams_Get_Admin_Data = new Params_Get_Admin_Data();
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
                typeConverter = TypeDescriptor.GetConverter(typeof(int?));
                oParams_Get_Admin_Data.USER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            if (HttpContext.Request.Query["IS_GET_IMAGES_FROM_Cloud"].FirstOrDefault() != null && HttpContext.Request.Query["IS_GET_IMAGES_FROM_Cloud"].ToString() != "undefined" && HttpContext.Request.Query["IS_GET_IMAGES_FROM_Cloud"].ToString() != "null" && HttpContext.Request.Query["IS_GET_IMAGES_FROM_Cloud"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(bool?));
                oParams_Get_Admin_Data.IS_GET_IMAGES_FROM_Cloud = (bool?)typeConverter.ConvertFromString(HttpContext.Request.Query["IS_GET_IMAGES_FROM_Cloud"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Admin_Data.i_Result = oBLC.Get_Admin_Data(oParams_Get_Admin_Data);
                oResult_Get_Admin_Data.Params_Get_Admin_Data = oParams_Get_Admin_Data;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Admin_Data.Params_Get_Admin_Data = oParams_Get_Admin_Data;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Admin_Data.Exception_Message = string.Format("Get_Admin_Data : {0}", ex.Message);
                oResult_Get_Admin_Data.Stack_Trace = is_send_stack_trace ? string.Format("Get_Admin_Data : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Admin_Data.Exception_Message = ex.Message;
                oResult_Get_Admin_Data.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Admin_Data;
        #endregion
    }
    #endregion
    #region Get_User_By_USER_ID_Adv
    [HttpGet]
    [Route("Get_User_By_USER_ID_Adv")]
    public Result_Get_User_By_USER_ID_Adv Get_User_By_USER_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_USER_ID_Adv oResult_Get_User_By_USER_ID_Adv = new Result_Get_User_By_USER_ID_Adv();
        Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
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
                oParams_Get_User_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_USER_ID_Adv.i_Result = oBLC.Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
                oResult_Get_User_By_USER_ID_Adv.Params_Get_User_By_USER_ID = oParams_Get_User_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_USER_ID_Adv.Params_Get_User_By_USER_ID = oParams_Get_User_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_USER_ID_Adv.Exception_Message = string.Format("Get_User_By_USER_ID_Adv : {0}", ex.Message);
                oResult_Get_User_By_USER_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_USER_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_USER_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_User_By_USER_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_USER_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_User_theme_By_USER_ID
    [HttpGet]
    [Route("Get_User_theme_By_USER_ID")]
    public Result_Get_User_theme_By_USER_ID Get_User_theme_By_USER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_theme_By_USER_ID oResult_Get_User_theme_By_USER_ID = new Result_Get_User_theme_By_USER_ID();
        Params_Get_User_theme_By_USER_ID oParams_Get_User_theme_By_USER_ID = new Params_Get_User_theme_By_USER_ID();
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
                oParams_Get_User_theme_By_USER_ID.USER_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["USER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_theme_By_USER_ID.i_Result = oBLC.Get_User_theme_By_USER_ID(oParams_Get_User_theme_By_USER_ID);
                oResult_Get_User_theme_By_USER_ID.Params_Get_User_theme_By_USER_ID = oParams_Get_User_theme_By_USER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_theme_By_USER_ID.Params_Get_User_theme_By_USER_ID = oParams_Get_User_theme_By_USER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_theme_By_USER_ID.Exception_Message = string.Format("Get_User_theme_By_USER_ID : {0}", ex.Message);
                oResult_Get_User_theme_By_USER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_theme_By_USER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_theme_By_USER_ID.Exception_Message = ex.Message;
                oResult_Get_User_theme_By_USER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_theme_By_USER_ID;
        #endregion
    }
    #endregion
    #region Edit_Site_kpi
    [HttpPost]
    [Route("Edit_Site_kpi")]
    public Result_Edit_Site_kpi Edit_Site_kpi(Site_kpi i_Site_kpi)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Site_kpi oResult_Edit_Site_kpi = new Result_Edit_Site_kpi();
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
                oBLC.Edit_Site_kpi(i_Site_kpi);
                oResult_Edit_Site_kpi.Site_kpi = i_Site_kpi;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Site_kpi.Exception_Message = string.Format("Edit_Site_kpi : {0}", ex.Message);
                oResult_Edit_Site_kpi.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Site_kpi : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Site_kpi.Exception_Message = ex.Message;
                oResult_Edit_Site_kpi.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Site_kpi;
        #endregion
    }
    #endregion
    #region Edit_Area_kpi_user_access_List
    [HttpPost]
    [Route("Edit_Area_kpi_user_access_List")]
    public Result_Edit_Area_kpi_user_access_List Edit_Area_kpi_user_access_List(Params_Edit_Area_kpi_user_access_List i_Params_Edit_Area_kpi_user_access_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_kpi_user_access_List oResult_Edit_Area_kpi_user_access_List = new Result_Edit_Area_kpi_user_access_List();
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
                oBLC.Edit_Area_kpi_user_access_List(i_Params_Edit_Area_kpi_user_access_List);
                oResult_Edit_Area_kpi_user_access_List.Params_Edit_Area_kpi_user_access_List = i_Params_Edit_Area_kpi_user_access_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_kpi_user_access_List.Exception_Message = string.Format("Edit_Area_kpi_user_access_List : {0}", ex.Message);
                oResult_Edit_Area_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_kpi_user_access_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_kpi_user_access_List.Exception_Message = ex.Message;
                oResult_Edit_Area_kpi_user_access_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_kpi_user_access_List;
        #endregion
    }
    #endregion
    #region Get_User_By_ORGANIZATION_ID_List_Adv
    [HttpGet]
    [Route("Get_User_By_ORGANIZATION_ID_List_Adv")]
    public Result_Get_User_By_ORGANIZATION_ID_List_Adv Get_User_By_ORGANIZATION_ID_List_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_User_By_ORGANIZATION_ID_List_Adv oResult_Get_User_By_ORGANIZATION_ID_List_Adv = new Result_Get_User_By_ORGANIZATION_ID_List_Adv();
        Params_Get_User_By_ORGANIZATION_ID_List oParams_Get_User_By_ORGANIZATION_ID_List = new Params_Get_User_By_ORGANIZATION_ID_List();
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
                oParams_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST = HttpContext.Request.Query["ORGANIZATION_ID_LIST"]
																				.ToString()
																				.Split(',')
																				.Where(val => int.TryParse(val, out _))
																				.Select(val => (int?)int.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.i_Result = oBLC.Get_User_By_ORGANIZATION_ID_List_Adv(oParams_Get_User_By_ORGANIZATION_ID_List);
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Params_Get_User_By_ORGANIZATION_ID_List = oParams_Get_User_By_ORGANIZATION_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Exception_Message = string.Format("Get_User_By_ORGANIZATION_ID_List_Adv : {0}", ex.Message);
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_User_By_ORGANIZATION_ID_List_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Exception_Message = ex.Message;
                oResult_Get_User_By_ORGANIZATION_ID_List_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_User_By_ORGANIZATION_ID_List_Adv;
        #endregion
    }
    #endregion
    #region Delete_User_theme
    [HttpPost]
    [Route("Delete_User_theme")]
    public Result_Delete_User_theme Delete_User_theme(Params_Delete_User_theme i_Params_Delete_User_theme)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_User_theme oResult_Delete_User_theme = new Result_Delete_User_theme();
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
                oBLC.Delete_User_theme(i_Params_Delete_User_theme);
                oResult_Delete_User_theme.Params_Delete_User_theme = i_Params_Delete_User_theme;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_User_theme.Params_Delete_User_theme = i_Params_Delete_User_theme;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_User_theme.Exception_Message = string.Format("Delete_User_theme : {0}", ex.Message);
                oResult_Delete_User_theme.Stack_Trace = is_send_stack_trace ? string.Format("Delete_User_theme : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_User_theme.Exception_Message = ex.Message;
                oResult_Delete_User_theme.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_User_theme;
        #endregion
    }
    #endregion
    #region Edit_Area_kpi_user_access
    [HttpPost]
    [Route("Edit_Area_kpi_user_access")]
    public Result_Edit_Area_kpi_user_access Edit_Area_kpi_user_access(Area_kpi_user_access i_Area_kpi_user_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_kpi_user_access oResult_Edit_Area_kpi_user_access = new Result_Edit_Area_kpi_user_access();
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
                oBLC.Edit_Area_kpi_user_access(i_Area_kpi_user_access);
                oResult_Edit_Area_kpi_user_access.Area_kpi_user_access = i_Area_kpi_user_access;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_kpi_user_access.Exception_Message = string.Format("Edit_Area_kpi_user_access : {0}", ex.Message);
                oResult_Edit_Area_kpi_user_access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_kpi_user_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_kpi_user_access.Exception_Message = ex.Message;
                oResult_Edit_Area_kpi_user_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_kpi_user_access;
        #endregion
    }
    #endregion
    #region Edit_District_kpi_user_access
    [HttpPost]
    [Route("Edit_District_kpi_user_access")]
    public Result_Edit_District_kpi_user_access Edit_District_kpi_user_access(District_kpi_user_access i_District_kpi_user_access)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_District_kpi_user_access oResult_Edit_District_kpi_user_access = new Result_Edit_District_kpi_user_access();
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
                oBLC.Edit_District_kpi_user_access(i_District_kpi_user_access);
                oResult_Edit_District_kpi_user_access.District_kpi_user_access = i_District_kpi_user_access;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_District_kpi_user_access.Exception_Message = string.Format("Edit_District_kpi_user_access : {0}", ex.Message);
                oResult_Edit_District_kpi_user_access.Stack_Trace = is_send_stack_trace ? string.Format("Edit_District_kpi_user_access : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_District_kpi_user_access.Exception_Message = ex.Message;
                oResult_Edit_District_kpi_user_access.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_District_kpi_user_access;
        #endregion
    }
    #endregion
    #region Modify_User_Details
    [HttpPost]
    [Route("Modify_User_Details")]
    public Result_Modify_User_Details Modify_User_Details(Params_Modify_User_Details i_Params_Modify_User_Details)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Modify_User_Details oResult_Modify_User_Details = new Result_Modify_User_Details();
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
                oResult_Modify_User_Details.i_Result = oBLC.Modify_User_Details(i_Params_Modify_User_Details);
                oResult_Modify_User_Details.Params_Modify_User_Details = i_Params_Modify_User_Details;
            }
        }
        catch (Exception ex)
        {
            oResult_Modify_User_Details.Params_Modify_User_Details = i_Params_Modify_User_Details;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Modify_User_Details.Exception_Message = string.Format("Modify_User_Details : {0}", ex.Message);
                oResult_Modify_User_Details.Stack_Trace = is_send_stack_trace ? string.Format("Modify_User_Details : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Modify_User_Details.Exception_Message = ex.Message;
                oResult_Modify_User_Details.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Modify_User_Details;
        #endregion
    }
    #endregion
    #region Get_Dimension_Index_With_Simple_Upper_Level
    [HttpPost]
    [Route("Get_Dimension_Index_With_Simple_Upper_Level")]
    public Result_Get_Dimension_Index_With_Simple_Upper_Level Get_Dimension_Index_With_Simple_Upper_Level(Params_Get_Dimension_Index_With_Simple_Upper_Level i_Params_Get_Dimension_Index_With_Simple_Upper_Level)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Dimension_Index_With_Simple_Upper_Level oResult_Get_Dimension_Index_With_Simple_Upper_Level = new Result_Get_Dimension_Index_With_Simple_Upper_Level();
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
                oResult_Get_Dimension_Index_With_Simple_Upper_Level.i_Result = oBLC.Get_Dimension_Index_With_Simple_Upper_Level(i_Params_Get_Dimension_Index_With_Simple_Upper_Level);
                oResult_Get_Dimension_Index_With_Simple_Upper_Level.Params_Get_Dimension_Index_With_Simple_Upper_Level = i_Params_Get_Dimension_Index_With_Simple_Upper_Level;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Dimension_Index_With_Simple_Upper_Level.Params_Get_Dimension_Index_With_Simple_Upper_Level = i_Params_Get_Dimension_Index_With_Simple_Upper_Level;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Dimension_Index_With_Simple_Upper_Level.Exception_Message = string.Format("Get_Dimension_Index_With_Simple_Upper_Level : {0}", ex.Message);
                oResult_Get_Dimension_Index_With_Simple_Upper_Level.Stack_Trace = is_send_stack_trace ? string.Format("Get_Dimension_Index_With_Simple_Upper_Level : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Dimension_Index_With_Simple_Upper_Level.Exception_Message = ex.Message;
                oResult_Get_Dimension_Index_With_Simple_Upper_Level.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Dimension_Index_With_Simple_Upper_Level;
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
#region Result_Create_User
public partial class Result_Create_User : Action_Result
{
    #region Properties.
    public User i_Result { get; set; }
    public Params_Create_User Params_Create_User { get; set; }
    #endregion
}
#endregion
#region Result_Change_User_Password
public partial class Result_Change_User_Password : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Change_User_Password Params_Change_User_Password { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_kpi
public partial class Result_Edit_Area_kpi : Action_Result
{
    #region Properties.
    public Area_kpi Area_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
public partial class Result_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List : Action_Result
{
    #region Properties.
    public List<User_level_access> i_Result { get; set; }
    public Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_Walkthrough
public partial class Result_Edit_User_Walkthrough : Action_Result
{
    #region Properties.
    public Params_Edit_User_Walkthrough Params_Edit_User_Walkthrough { get; set; }
    #endregion
}
#endregion
#region Result_Schedule_User_for_Delete
public partial class Result_Schedule_User_for_Delete : Action_Result
{
    #region Properties.
    public User i_Result { get; set; }
    public Params_Schedule_User_for_Delete Params_Schedule_User_for_Delete { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_Accessible_Level_List
public partial class Result_Get_User_Accessible_Level_List : Action_Result
{
    #region Properties.
    public User_Accessible_Level_List i_Result { get; set; }
    public Params_Get_User_Accessible_Level_List Params_Get_User_Accessible_Level_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_District_kpi_user_access_List
public partial class Result_Edit_District_kpi_user_access_List : Action_Result
{
    #region Properties.
    public Params_Edit_District_kpi_user_access_List Params_Edit_District_kpi_user_access_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Area_kpi
public partial class Result_Delete_Area_kpi : Action_Result
{
    #region Properties.
    public Params_Delete_Area_kpi Params_Delete_Area_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_level_access_By_USER_ID_List
public partial class Result_Get_User_level_access_By_USER_ID_List : Action_Result
{
    #region Properties.
    public List<User_level_access> i_Result { get; set; }
    public Params_Get_User_level_access_By_USER_ID_List Params_Get_User_level_access_By_USER_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_User_level_access
public partial class Result_Delete_User_level_access : Action_Result
{
    #region Properties.
    public Params_Delete_User_level_access Params_Delete_User_level_access { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Entity_kpi_List
public partial class Result_Edit_Entity_kpi_List : Action_Result
{
    #region Properties.
    public Params_Edit_Entity_kpi_List Params_Edit_Entity_kpi_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_ORGANIZATION_ID_Adv
public partial class Result_Get_User_By_ORGANIZATION_ID_Adv : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_ORGANIZATION_ID Params_Get_User_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_Details
public partial class Result_Edit_User_Details : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Edit_User_Details Params_Edit_User_Details { get; set; }
    #endregion
}
#endregion
#region Result_Edit_District_kpi_List
public partial class Result_Edit_District_kpi_List : Action_Result
{
    #region Properties.
    public Params_Edit_District_kpi_List Params_Edit_District_kpi_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Entity_kpi
public partial class Result_Edit_Entity_kpi : Action_Result
{
    #region Properties.
    public Entity_kpi Entity_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_Accessible_Data_With_Level_List
public partial class Result_Get_User_Accessible_Data_With_Level_List : Action_Result
{
    #region Properties.
    public User_Accessible_Data_With_Level_List i_Result { get; set; }
    public Params_Get_User_Accessible_Data_With_Level_List Params_Get_User_Accessible_Data_With_Level_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_districtnex_module_By_USER_ID_List
public partial class Result_Get_User_districtnex_module_By_USER_ID_List : Action_Result
{
    #region Properties.
    public List<User_districtnex_module> i_Result { get; set; }
    public Params_Get_User_districtnex_module_By_USER_ID_List Params_Get_User_districtnex_module_By_USER_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_USER_ID_List
public partial class Result_Get_User_By_USER_ID_List : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_USER_ID_List Params_Get_User_By_USER_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_districtnex_module_By_USER_ID
public partial class Result_Get_User_districtnex_module_By_USER_ID : Action_Result
{
    #region Properties.
    public List<User_districtnex_module> i_Result { get; set; }
    public Params_Get_User_districtnex_module_By_USER_ID Params_Get_User_districtnex_module_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_ORGANIZATION_ID
public partial class Result_Get_User_By_ORGANIZATION_ID : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_ORGANIZATION_ID Params_Get_User_By_ORGANIZATION_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
public partial class Result_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID : Action_Result
{
    #region Properties.
    public List<User_level_access> i_Result { get; set; }
    public Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Entity_kpi_user_access_List
public partial class Result_Edit_Entity_kpi_user_access_List : Action_Result
{
    #region Properties.
    public Params_Edit_Entity_kpi_user_access_List Params_Edit_Entity_kpi_user_access_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_USER_ID_List_Adv
public partial class Result_Get_User_By_USER_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_USER_ID_List Params_Get_User_By_USER_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site_kpi_user_access
public partial class Result_Edit_Site_kpi_user_access : Action_Result
{
    #region Properties.
    public Site_kpi_user_access Site_kpi_user_access { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Entity_kpi_user_access
public partial class Result_Edit_Entity_kpi_user_access : Action_Result
{
    #region Properties.
    public Entity_kpi_user_access Entity_kpi_user_access { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_kpi_List
public partial class Result_Edit_Area_kpi_List : Action_Result
{
    #region Properties.
    public Params_Edit_Area_kpi_List Params_Edit_Area_kpi_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Site_kpi
public partial class Result_Delete_Site_kpi : Action_Result
{
    #region Properties.
    public Params_Delete_Site_kpi Params_Delete_Site_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_level_access_List
public partial class Result_Edit_User_level_access_List : Action_Result
{
    #region Properties.
    public Params_Edit_User_level_access_List Params_Edit_User_level_access_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Entity_kpi
public partial class Result_Delete_Entity_kpi : Action_Result
{
    #region Properties.
    public Params_Delete_Entity_kpi Params_Delete_Entity_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_Accessible_Data
public partial class Result_Get_User_Accessible_Data : Action_Result
{
    #region Properties.
    public User_Accessible_Data i_Result { get; set; }
    public Params_Get_User_Accessible_Data Params_Get_User_Accessible_Data { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_districtnex_module_List
public partial class Result_Edit_User_districtnex_module_List : Action_Result
{
    #region Properties.
    public Params_Edit_User_districtnex_module_List Params_Edit_User_districtnex_module_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site_kpi_user_access_List
public partial class Result_Edit_Site_kpi_user_access_List : Action_Result
{
    #region Properties.
    public Params_Edit_Site_kpi_user_access_List Params_Edit_Site_kpi_user_access_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Initial_Data
public partial class Result_Get_Initial_Data : Action_Result
{
    #region Properties.
    public Initial_Data i_Result { get; set; }
    public Params_Get_Initial_Data Params_Get_Initial_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_ORGANIZATION_ID_List
public partial class Result_Get_User_By_ORGANIZATION_ID_List : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_ORGANIZATION_ID_List Params_Get_User_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_District_kpi
public partial class Result_Edit_District_kpi : Action_Result
{
    #region Properties.
    public District_kpi District_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Change_Password
public partial class Result_Change_Password : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Change_Password Params_Change_Password { get; set; }
    #endregion
}
#endregion
#region Result_Delete_District_kpi
public partial class Result_Delete_District_kpi : Action_Result
{
    #region Properties.
    public Params_Delete_District_kpi Params_Delete_District_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site_kpi_List
public partial class Result_Edit_Site_kpi_List : Action_Result
{
    #region Properties.
    public Params_Edit_Site_kpi_List Params_Edit_Site_kpi_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Entity_Intersection_List
public partial class Result_Get_Entity_Intersection_List : Action_Result
{
    #region Properties.
    public List<Entity> i_Result { get; set; }
    public Params_Get_Entity_Intersection_List Params_Get_Entity_Intersection_List { get; set; }
    #endregion
}
#endregion
#region Result_Check_User_Deletion_Status
public partial class Result_Check_User_Deletion_Status : Action_Result
{
    #region Properties.
    #endregion
}
#endregion
#region Result_Get_User_By_IS_RECEIVE_EMAIL
public partial class Result_Get_User_By_IS_RECEIVE_EMAIL : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_IS_RECEIVE_EMAIL Params_Get_User_By_IS_RECEIVE_EMAIL { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_USER_ID
public partial class Result_Get_User_By_USER_ID : Action_Result
{
    #region Properties.
    public User i_Result { get; set; }
    public Params_Get_User_By_USER_ID Params_Get_User_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_level_access_By_USER_ID
public partial class Result_Get_User_level_access_By_USER_ID : Action_Result
{
    #region Properties.
    public List<User_level_access> i_Result { get; set; }
    public Params_Get_User_level_access_By_USER_ID Params_Get_User_level_access_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Level_Data
public partial class Result_Get_Level_Data : Action_Result
{
    #region Properties.
    public Level_Data i_Result { get; set; }
    public Params_Get_Level_Data Params_Get_Level_Data { get; set; }
    #endregion
}
#endregion
#region Result_Restore_User
public partial class Result_Restore_User : Action_Result
{
    #region Properties.
    public User i_Result { get; set; }
    public Params_Restore_User Params_Restore_User { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_districtnex_module_By_USER_ID_Adv
public partial class Result_Get_User_districtnex_module_By_USER_ID_Adv : Action_Result
{
    #region Properties.
    public List<User_districtnex_module> i_Result { get; set; }
    public Params_Get_User_districtnex_module_By_USER_ID Params_Get_User_districtnex_module_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_theme
public partial class Result_Edit_User_theme : Action_Result
{
    #region Properties.
    public User_theme User_theme { get; set; }
    #endregion
}
#endregion
#region Result_Edit_User_List
public partial class Result_Edit_User_List : Action_Result
{
    #region Properties.
    public Params_Edit_User_List Params_Edit_User_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Admin_Data
public partial class Result_Get_Admin_Data : Action_Result
{
    #region Properties.
    public Admin_Data i_Result { get; set; }
    public Params_Get_Admin_Data Params_Get_Admin_Data { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_USER_ID_Adv
public partial class Result_Get_User_By_USER_ID_Adv : Action_Result
{
    #region Properties.
    public User i_Result { get; set; }
    public Params_Get_User_By_USER_ID Params_Get_User_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_theme_By_USER_ID
public partial class Result_Get_User_theme_By_USER_ID : Action_Result
{
    #region Properties.
    public List<User_theme> i_Result { get; set; }
    public Params_Get_User_theme_By_USER_ID Params_Get_User_theme_By_USER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Site_kpi
public partial class Result_Edit_Site_kpi : Action_Result
{
    #region Properties.
    public Site_kpi Site_kpi { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_kpi_user_access_List
public partial class Result_Edit_Area_kpi_user_access_List : Action_Result
{
    #region Properties.
    public Params_Edit_Area_kpi_user_access_List Params_Edit_Area_kpi_user_access_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_User_By_ORGANIZATION_ID_List_Adv
public partial class Result_Get_User_By_ORGANIZATION_ID_List_Adv : Action_Result
{
    #region Properties.
    public List<User> i_Result { get; set; }
    public Params_Get_User_By_ORGANIZATION_ID_List Params_Get_User_By_ORGANIZATION_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_User_theme
public partial class Result_Delete_User_theme : Action_Result
{
    #region Properties.
    public Params_Delete_User_theme Params_Delete_User_theme { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_kpi_user_access
public partial class Result_Edit_Area_kpi_user_access : Action_Result
{
    #region Properties.
    public Area_kpi_user_access Area_kpi_user_access { get; set; }
    #endregion
}
#endregion
#region Result_Edit_District_kpi_user_access
public partial class Result_Edit_District_kpi_user_access : Action_Result
{
    #region Properties.
    public District_kpi_user_access District_kpi_user_access { get; set; }
    #endregion
}
#endregion
#region Result_Modify_User_Details
public partial class Result_Modify_User_Details : Action_Result
{
    #region Properties.
    public User i_Result { get; set; }
    public Params_Modify_User_Details Params_Modify_User_Details { get; set; }
    #endregion
}
#endregion
#region Result_Get_Dimension_Index_With_Simple_Upper_Level
public partial class Result_Get_Dimension_Index_With_Simple_Upper_Level : Action_Result
{
    #region Properties.
    public Dimension_Index_With_Simple_Upper_Level i_Result { get; set; }
    public Params_Get_Dimension_Index_With_Simple_Upper_Level Params_Get_Dimension_Index_With_Simple_Upper_Level { get; set; }
    #endregion
}
#endregion
