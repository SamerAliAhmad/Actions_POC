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
public partial class AssetManagementController : ControllerBase
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
    #region Get_Asset_By_ASSET_ID_List
    [HttpGet]
    [Route("Get_Asset_By_ASSET_ID_List")]
    public Result_Get_Asset_By_ASSET_ID_List Get_Asset_By_ASSET_ID_List()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Asset_By_ASSET_ID_List oResult_Get_Asset_By_ASSET_ID_List = new Result_Get_Asset_By_ASSET_ID_List();
        Params_Get_Asset_By_ASSET_ID_List oParams_Get_Asset_By_ASSET_ID_List = new Params_Get_Asset_By_ASSET_ID_List();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            if (HttpContext.Request.Query["ASSET_ID_LIST"].FirstOrDefault() != null && HttpContext.Request.Query["ASSET_ID_LIST"].ToString() != "undefined" && HttpContext.Request.Query["ASSET_ID_LIST"].ToString() != "null" && HttpContext.Request.Query["ASSET_ID_LIST"].ToString() != "")
            {
                oParams_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST = HttpContext.Request.Query["ASSET_ID_LIST"]
																	.ToString()
																	.Split(',')
																	.Where(val => long.TryParse(val, out _))
																	.Select(val => (long?)long.Parse(val));
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Asset_By_ASSET_ID_List.i_Result = oBLC.Get_Asset_By_ASSET_ID_List(oParams_Get_Asset_By_ASSET_ID_List);
                oResult_Get_Asset_By_ASSET_ID_List.Params_Get_Asset_By_ASSET_ID_List = oParams_Get_Asset_By_ASSET_ID_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Asset_By_ASSET_ID_List.Params_Get_Asset_By_ASSET_ID_List = oParams_Get_Asset_By_ASSET_ID_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Asset_By_ASSET_ID_List.Exception_Message = string.Format("Get_Asset_By_ASSET_ID_List : {0}", ex.Message);
                oResult_Get_Asset_By_ASSET_ID_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Asset_By_ASSET_ID_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Asset_By_ASSET_ID_List.Exception_Message = ex.Message;
                oResult_Get_Asset_By_ASSET_ID_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Asset_By_ASSET_ID_List;
        #endregion
    }
    #endregion
    #region Edit_Asset
    [HttpPost]
    [Route("Edit_Asset")]
    public Result_Edit_Asset Edit_Asset(Asset i_Asset)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Edit_Asset oResult_Edit_Asset = new Result_Edit_Asset();
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
                oBLC.Edit_Asset(i_Asset);
                oResult_Edit_Asset.Asset = i_Asset;
            }
        }
        catch (Exception ex)
        {
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Edit_Asset.Exception_Message = string.Format("Edit_Asset : {0}", ex.Message);
                oResult_Edit_Asset.Stack_Trace = is_send_stack_trace ? string.Format("Edit_Asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Edit_Asset.Exception_Message = ex.Message;
                oResult_Edit_Asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Edit_Asset;
        #endregion
    }
    #endregion
    #region Get_Asset_By_OWNER_ID
    [HttpGet]
    [Route("Get_Asset_By_OWNER_ID")]
    public Result_Get_Asset_By_OWNER_ID Get_Asset_By_OWNER_ID()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Asset_By_OWNER_ID oResult_Get_Asset_By_OWNER_ID = new Result_Get_Asset_By_OWNER_ID();
        Params_Get_Asset_By_OWNER_ID oParams_Get_Asset_By_OWNER_ID = new Params_Get_Asset_By_OWNER_ID();
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
                oParams_Get_Asset_By_OWNER_ID.OWNER_ID = (int?)typeConverter.ConvertFromString(HttpContext.Request.Query["OWNER_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Asset_By_OWNER_ID.i_Result = oBLC.Get_Asset_By_OWNER_ID(oParams_Get_Asset_By_OWNER_ID);
                oResult_Get_Asset_By_OWNER_ID.Params_Get_Asset_By_OWNER_ID = oParams_Get_Asset_By_OWNER_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Asset_By_OWNER_ID.Params_Get_Asset_By_OWNER_ID = oParams_Get_Asset_By_OWNER_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Asset_By_OWNER_ID.Exception_Message = string.Format("Get_Asset_By_OWNER_ID : {0}", ex.Message);
                oResult_Get_Asset_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? string.Format("Get_Asset_By_OWNER_ID : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Asset_By_OWNER_ID.Exception_Message = ex.Message;
                oResult_Get_Asset_By_OWNER_ID.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Asset_By_OWNER_ID;
        #endregion
    }
    #endregion
    #region Get_Asset_By_ASSET_ID_Adv
    [HttpGet]
    [Route("Get_Asset_By_ASSET_ID_Adv")]
    public Result_Get_Asset_By_ASSET_ID_Adv Get_Asset_By_ASSET_ID_Adv()
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Asset_By_ASSET_ID_Adv oResult_Get_Asset_By_ASSET_ID_Adv = new Result_Get_Asset_By_ASSET_ID_Adv();
        Params_Get_Asset_By_ASSET_ID oParams_Get_Asset_By_ASSET_ID = new Params_Get_Asset_By_ASSET_ID();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            oTicket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if (HttpContext.Request.Query["ASSET_ID"].FirstOrDefault() != null && HttpContext.Request.Query["ASSET_ID"].ToString() != "undefined" && HttpContext.Request.Query["ASSET_ID"].ToString() != "null" && HttpContext.Request.Query["ASSET_ID"].ToString() != "")
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(long?));
                oParams_Get_Asset_By_ASSET_ID.ASSET_ID = (long?)typeConverter.ConvertFromString(HttpContext.Request.Query["ASSET_ID"].ToString());
            }
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Get_Asset_By_ASSET_ID_Adv.i_Result = oBLC.Get_Asset_By_ASSET_ID_Adv(oParams_Get_Asset_By_ASSET_ID);
                oResult_Get_Asset_By_ASSET_ID_Adv.Params_Get_Asset_By_ASSET_ID = oParams_Get_Asset_By_ASSET_ID;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Asset_By_ASSET_ID_Adv.Params_Get_Asset_By_ASSET_ID = oParams_Get_Asset_By_ASSET_ID;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Asset_By_ASSET_ID_Adv.Exception_Message = string.Format("Get_Asset_By_ASSET_ID_Adv : {0}", ex.Message);
                oResult_Get_Asset_By_ASSET_ID_Adv.Stack_Trace = is_send_stack_trace ? string.Format("Get_Asset_By_ASSET_ID_Adv : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Asset_By_ASSET_ID_Adv.Exception_Message = ex.Message;
                oResult_Get_Asset_By_ASSET_ID_Adv.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Asset_By_ASSET_ID_Adv;
        #endregion
    }
    #endregion
    #region Get_Asset_Data_List
    [HttpPost]
    [Route("Get_Asset_Data_List")]
    public Result_Get_Asset_Data_List Get_Asset_Data_List(Params_Get_Asset_Data_List i_Params_Get_Asset_Data_List)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Get_Asset_Data_List oResult_Get_Asset_Data_List = new Result_Get_Asset_Data_List();
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
                oResult_Get_Asset_Data_List.i_Result = oBLC.Get_Asset_Data_List(i_Params_Get_Asset_Data_List);
                oResult_Get_Asset_Data_List.Params_Get_Asset_Data_List = i_Params_Get_Asset_Data_List;
            }
        }
        catch (Exception ex)
        {
            oResult_Get_Asset_Data_List.Params_Get_Asset_Data_List = i_Params_Get_Asset_Data_List;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Get_Asset_Data_List.Exception_Message = string.Format("Get_Asset_Data_List : {0}", ex.Message);
                oResult_Get_Asset_Data_List.Stack_Trace = is_send_stack_trace ? string.Format("Get_Asset_Data_List : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Get_Asset_Data_List.Exception_Message = ex.Message;
                oResult_Get_Asset_Data_List.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Get_Asset_Data_List;
        #endregion
    }
    #endregion
    #region Delete_Asset
    [HttpPost]
    [Route("Delete_Asset")]
    public Result_Delete_Asset Delete_Asset(Params_Delete_Asset i_Params_Delete_Asset)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Delete_Asset oResult_Delete_Asset = new Result_Delete_Asset();
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
                oBLC.Delete_Asset(i_Params_Delete_Asset);
                oResult_Delete_Asset.Params_Delete_Asset = i_Params_Delete_Asset;
            }
        }
        catch (Exception ex)
        {
            oResult_Delete_Asset.Params_Delete_Asset = i_Params_Delete_Asset;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Delete_Asset.Exception_Message = string.Format("Delete_Asset : {0}", ex.Message);
                oResult_Delete_Asset.Stack_Trace = is_send_stack_trace ? string.Format("Delete_Asset : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Delete_Asset.Exception_Message = ex.Message;
                oResult_Delete_Asset.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Delete_Asset;
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
#region Result_Get_Asset_By_ASSET_ID_List
public partial class Result_Get_Asset_By_ASSET_ID_List : Action_Result
{
    #region Properties.
    public List<Asset> i_Result { get; set; }
    public Params_Get_Asset_By_ASSET_ID_List Params_Get_Asset_By_ASSET_ID_List { get; set; }
    #endregion
}
#endregion
#region Result_Edit_Asset
public partial class Result_Edit_Asset : Action_Result
{
    #region Properties.
    public Asset Asset { get; set; }
    #endregion
}
#endregion
#region Result_Get_Asset_By_OWNER_ID
public partial class Result_Get_Asset_By_OWNER_ID : Action_Result
{
    #region Properties.
    public List<Asset> i_Result { get; set; }
    public Params_Get_Asset_By_OWNER_ID Params_Get_Asset_By_OWNER_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Asset_By_ASSET_ID_Adv
public partial class Result_Get_Asset_By_ASSET_ID_Adv : Action_Result
{
    #region Properties.
    public Asset i_Result { get; set; }
    public Params_Get_Asset_By_ASSET_ID Params_Get_Asset_By_ASSET_ID { get; set; }
    #endregion
}
#endregion
#region Result_Get_Asset_Data_List
public partial class Result_Get_Asset_Data_List : Action_Result
{
    #region Properties.
    public Asset_Data i_Result { get; set; }
    public Params_Get_Asset_Data_List Params_Get_Asset_Data_List { get; set; }
    #endregion
}
#endregion
#region Result_Delete_Asset
public partial class Result_Delete_Asset : Action_Result
{
    #region Properties.
    public Params_Delete_Asset Params_Delete_Asset { get; set; }
    #endregion
}
#endregion
