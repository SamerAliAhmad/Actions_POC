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
public partial class AreaManagementController : ControllerBase
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
    #region Get_Area_view_By_AREA_ID
    [HttpGet]
    [Route("Get_Area_view_By_AREA_ID")]
    public Result_Get_Area_view_By_AREA_ID Get_Area_view_By_AREA_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_view_By_AREA_ID oResult_Get_Area_view_By_AREA_ID = new Result_Get_Area_view_By_AREA_ID();
        Params_Get_Area_view_By_AREA_ID oParams_Get_Area_view_By_AREA_ID = new Params_Get_Area_view_By_AREA_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["AREA_ID"].FirstOrDefault() != null && HttpContext.Request.Query["AREA_ID"].ToString() != "undefined" && HttpContext.Request.Query["AREA_ID"].ToString() != "null" && HttpContext.Request.Query["AREA_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Area_view_By_AREA_ID.AREA_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["AREA_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Area_view_By_AREA_ID.i_Result = oBLC.Get_Area_view_By_AREA_ID(oParams_Get_Area_view_By_AREA_ID);
                oResult_Get_Area_view_By_AREA_ID.Params_Get_Area_view_By_AREA_ID = oParams_Get_Area_view_By_AREA_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_view_By_AREA_ID.Params_Get_Area_view_By_AREA_ID = oParams_Get_Area_view_By_AREA_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_view_By_AREA_ID.Exception_Message = string.Format("Get_Area_view_By_AREA_ID : {0}", ex.Message);
                oResult_Get_Area_view_By_AREA_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_view_By_AREA_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_view_By_AREA_ID.Exception_Message = ex.Message;
                oResult_Get_Area_view_By_AREA_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_view_By_AREA_ID;
        #endregion
    }
    #endregion
    #region Edit_Area_view
    [HttpPost]
    [Route("Edit_Area_view")]
    public Result_Edit_Area_view Edit_Area_view(Area_view i_Area_view)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_view oResult_Edit_Area_view = new Result_Edit_Area_view();
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
                oBLC.Edit_Area_view(i_Area_view);
                oResult_Edit_Area_view.Area_view = i_Area_view;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_view.Exception_Message = string.Format("Edit_Area_view : {0}", ex.Message);
                oResult_Edit_Area_view.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_view.Exception_Message = ex.Message;
                oResult_Edit_Area_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_view;
        #endregion
    }
    #endregion
    #region Edit_Area
    [HttpPost]
    [Route("Edit_Area")]
    public Result_Edit_Area Edit_Area(Area i_Area)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area oResult_Edit_Area = new Result_Edit_Area();
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
                oBLC.Edit_Area(i_Area);
                oResult_Edit_Area.Area = i_Area;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area.Exception_Message = string.Format("Edit_Area : {0}", ex.Message);
                oResult_Edit_Area.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area.Exception_Message = ex.Message;
                oResult_Edit_Area.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area;
        #endregion
    }
    #endregion
    #region Get_Area_geojson_By_AREA_ID_List
    [HttpPost]
    [Route("Get_Area_geojson_By_AREA_ID_List")]
    public Result_Get_Area_geojson_By_AREA_ID_List Get_Area_geojson_By_AREA_ID_List(Params_Get_Area_geojson_By_AREA_ID_List i_Params_Get_Area_geojson_By_AREA_ID_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_geojson_By_AREA_ID_List oResult_Get_Area_geojson_By_AREA_ID_List = new Result_Get_Area_geojson_By_AREA_ID_List();
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
                oResult_Get_Area_geojson_By_AREA_ID_List.i_Result = oBLC.Get_Area_geojson_By_AREA_ID_List(i_Params_Get_Area_geojson_By_AREA_ID_List);
                oResult_Get_Area_geojson_By_AREA_ID_List.Params_Get_Area_geojson_By_AREA_ID_List = i_Params_Get_Area_geojson_By_AREA_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_geojson_By_AREA_ID_List.Params_Get_Area_geojson_By_AREA_ID_List = i_Params_Get_Area_geojson_By_AREA_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_geojson_By_AREA_ID_List.Exception_Message = string.Format("Get_Area_geojson_By_AREA_ID_List : {0}", ex.Message);
                oResult_Get_Area_geojson_By_AREA_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_geojson_By_AREA_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_geojson_By_AREA_ID_List.Exception_Message = ex.Message;
                oResult_Get_Area_geojson_By_AREA_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_geojson_By_AREA_ID_List;
        #endregion
    }
    #endregion
    #region Get_Area_By_OWNER_ID
    [HttpGet]
    [Route("Get_Area_By_OWNER_ID")]
    public Result_Get_Area_By_OWNER_ID Get_Area_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_By_OWNER_ID oResult_Get_Area_By_OWNER_ID = new Result_Get_Area_By_OWNER_ID();
        Params_Get_Area_By_OWNER_ID oParams_Get_Area_By_OWNER_ID = new Params_Get_Area_By_OWNER_ID();
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
                oParams_Get_Area_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Area_By_OWNER_ID.i_Result = oBLC.Get_Area_By_OWNER_ID(oParams_Get_Area_By_OWNER_ID);
                oResult_Get_Area_By_OWNER_ID.Params_Get_Area_By_OWNER_ID = oParams_Get_Area_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_By_OWNER_ID.Params_Get_Area_By_OWNER_ID = oParams_Get_Area_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_By_OWNER_ID.Exception_Message = string.Format("Get_Area_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Area_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Area_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Area_By_AREA_ID_List
    [HttpGet]
    [Route("Get_Area_By_AREA_ID_List")]
    public Result_Get_Area_By_AREA_ID_List Get_Area_By_AREA_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_By_AREA_ID_List oResult_Get_Area_By_AREA_ID_List = new Result_Get_Area_By_AREA_ID_List();
        Params_Get_Area_By_AREA_ID_List oParams_Get_Area_By_AREA_ID_List = new Params_Get_Area_By_AREA_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["AREA_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["AREA_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["AREA_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["AREA_ID_LIST"].ToString() != "")
            {
                oParams_Get_Area_By_AREA_ID_List.AREA_ID_LIST = HttpContext.Request.Query["AREA_ID_LIST"]
																.ToString()
																.Split(',')
																.Where(val => long.TryParse(val, out _))
																.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Area_By_AREA_ID_List.i_Result = oBLC.Get_Area_By_AREA_ID_List(oParams_Get_Area_By_AREA_ID_List);
                oResult_Get_Area_By_AREA_ID_List.Params_Get_Area_By_AREA_ID_List = oParams_Get_Area_By_AREA_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_By_AREA_ID_List.Params_Get_Area_By_AREA_ID_List = oParams_Get_Area_By_AREA_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_By_AREA_ID_List.Exception_Message = string.Format("Get_Area_By_AREA_ID_List : {0}", ex.Message);
                oResult_Get_Area_By_AREA_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_By_AREA_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_By_AREA_ID_List.Exception_Message = ex.Message;
                oResult_Get_Area_By_AREA_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_By_AREA_ID_List;
        #endregion
    }
    #endregion
    #region Delete_Area_view
    [HttpDelete]
    [Route("Delete_Area_view/{AREA_VIEW_ID}")]
    public Result_Delete_Area_view Delete_Area_view(long? AREA_VIEW_ID)
    {
        #region Declaration And Initialization Section.
        Params_Delete_Area_view oParams_Delete_Area_view = new Params_Delete_Area_view()
        {
            AREA_VIEW_ID = AREA_VIEW_ID
        };
        string oTicket = string.Empty;
        Result_Delete_Area_view oResult_Delete_Area_view = new Result_Delete_Area_view();
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
                oBLC.Delete_Area_view(oParams_Delete_Area_view);
                oResult_Delete_Area_view.Params_Delete_Area_view = oParams_Delete_Area_view;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Area_view.Params_Delete_Area_view = oParams_Delete_Area_view;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Area_view.Exception_Message = string.Format("Delete_Area_view : {0}", ex.Message);
                oResult_Delete_Area_view.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Area_view : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Area_view.Exception_Message = ex.Message;
                oResult_Delete_Area_view.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Area_view;
        #endregion
    }
    #endregion
    #region Edit_Area_view_List
    [HttpPost]
    [Route("Edit_Area_view_List")]
    public Result_Edit_Area_view_List Edit_Area_view_List(Params_Edit_Area_view_List i_Params_Edit_Area_view_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Area_view_List oResult_Edit_Area_view_List = new Result_Edit_Area_view_List();
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
                oBLC.Edit_Area_view_List(i_Params_Edit_Area_view_List);
                oResult_Edit_Area_view_List.Params_Edit_Area_view_List = i_Params_Edit_Area_view_List;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Area_view_List.Exception_Message = string.Format("Edit_Area_view_List : {0}", ex.Message);
                oResult_Edit_Area_view_List.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Area_view_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Area_view_List.Exception_Message = ex.Message;
                oResult_Edit_Area_view_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Area_view_List;
        #endregion
    }
    #endregion
    #region Delete_Area_view_By_AREA_ID
    [HttpPost]
    [Route("Delete_Area_view_By_AREA_ID")]
    public Result_Delete_Area_view_By_AREA_ID Delete_Area_view_By_AREA_ID(Params_Delete_Area_view_By_AREA_ID i_Params_Delete_Area_view_By_AREA_ID)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Area_view_By_AREA_ID oResult_Delete_Area_view_By_AREA_ID = new Result_Delete_Area_view_By_AREA_ID();
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
                oBLC.Delete_Area_view_By_AREA_ID(i_Params_Delete_Area_view_By_AREA_ID);
                oResult_Delete_Area_view_By_AREA_ID.Params_Delete_Area_view_By_AREA_ID = i_Params_Delete_Area_view_By_AREA_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Area_view_By_AREA_ID.Params_Delete_Area_view_By_AREA_ID = i_Params_Delete_Area_view_By_AREA_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Area_view_By_AREA_ID.Exception_Message = string.Format("Delete_Area_view_By_AREA_ID : {0}", ex.Message);
                oResult_Delete_Area_view_By_AREA_ID.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Area_view_By_AREA_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Area_view_By_AREA_ID.Exception_Message = ex.Message;
                oResult_Delete_Area_view_By_AREA_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Area_view_By_AREA_ID;
        #endregion
    }
    #endregion
    #region Get_Area_view_By_AREA_ID_List
    [HttpGet]
    [Route("Get_Area_view_By_AREA_ID_List")]
    public Result_Get_Area_view_By_AREA_ID_List Get_Area_view_By_AREA_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Area_view_By_AREA_ID_List oResult_Get_Area_view_By_AREA_ID_List = new Result_Get_Area_view_By_AREA_ID_List();
        Params_Get_Area_view_By_AREA_ID_List oParams_Get_Area_view_By_AREA_ID_List = new Params_Get_Area_view_By_AREA_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["AREA_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["AREA_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["AREA_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["AREA_ID_LIST"].ToString() != "")
            {
                oParams_Get_Area_view_By_AREA_ID_List.AREA_ID_LIST = HttpContext.Request.Query["AREA_ID_LIST"]
																		.ToString()
																		.Split(',')
																		.Where(val => long.TryParse(val, out _))
																		.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Area_view_By_AREA_ID_List.i_Result = oBLC.Get_Area_view_By_AREA_ID_List(oParams_Get_Area_view_By_AREA_ID_List);
                oResult_Get_Area_view_By_AREA_ID_List.Params_Get_Area_view_By_AREA_ID_List = oParams_Get_Area_view_By_AREA_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Area_view_By_AREA_ID_List.Params_Get_Area_view_By_AREA_ID_List = oParams_Get_Area_view_By_AREA_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Area_view_By_AREA_ID_List.Exception_Message = string.Format("Get_Area_view_By_AREA_ID_List : {0}", ex.Message);
                oResult_Get_Area_view_By_AREA_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Area_view_By_AREA_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Area_view_By_AREA_ID_List.Exception_Message = ex.Message;
                oResult_Get_Area_view_By_AREA_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Area_view_By_AREA_ID_List;
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
#region Result_Get_Area_view_By_AREA_ID
public partial class Result_Get_Area_view_By_AREA_ID : Action_Result
{
    #region Properties.
    public List<Area_view> i_Result { get; set; }
    public Params_Get_Area_view_By_AREA_ID Params_Get_Area_view_By_AREA_ID { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_view
public partial class Result_Edit_Area_view : Action_Result
{
    #region Properties.
    public Area_view Area_view { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area
public partial class Result_Edit_Area : Action_Result
{
    #region Properties.
    public Area Area { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_geojson_By_AREA_ID_List
public partial class Result_Get_Area_geojson_By_AREA_ID_List : Action_Result
{
    #region Properties.
    public string i_Result { get; set; }
    public Params_Get_Area_geojson_By_AREA_ID_List Params_Get_Area_geojson_By_AREA_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_By_OWNER_ID
public partial class Result_Get_Area_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Area> i_Result { get; set; }
    public Params_Get_Area_By_OWNER_ID Params_Get_Area_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_By_AREA_ID_List
public partial class Result_Get_Area_By_AREA_ID_List : Action_Result
{
    #region Properties.
    public List<Area> i_Result { get; set; }
    public Params_Get_Area_By_AREA_ID_List Params_Get_Area_By_AREA_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Area_view
public partial class Result_Delete_Area_view : Action_Result
{
    #region Properties.
    public Params_Delete_Area_view Params_Delete_Area_view { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Area_view_List
public partial class Result_Edit_Area_view_List : Action_Result
{
    #region Properties.
    public Params_Edit_Area_view_List Params_Edit_Area_view_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Area_view_By_AREA_ID
public partial class Result_Delete_Area_view_By_AREA_ID : Action_Result
{
    #region Properties.
    public Params_Delete_Area_view_By_AREA_ID Params_Delete_Area_view_By_AREA_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Area_view_By_AREA_ID_List
public partial class Result_Get_Area_view_By_AREA_ID_List : Action_Result
{
    #region Properties.
    public List<Area_view> i_Result { get; set; }
    public Params_Get_Area_view_By_AREA_ID_List Params_Get_Area_view_By_AREA_ID_List { get; set; }
    #endregion
}
#endregion
