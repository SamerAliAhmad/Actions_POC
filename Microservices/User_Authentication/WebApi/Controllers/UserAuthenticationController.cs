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
public partial class UserAuthenticationController : ControllerBase
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
    #region Primary_Authentication
    [HttpPost]
    [Route("Primary_Authentication")]
    public Result_Primary_Authentication Primary_Authentication(Params_Primary_Authentication i_Params_Primary_Authentication)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Primary_Authentication oResult_Primary_Authentication = new Result_Primary_Authentication();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Primary_Authentication.i_Result = oBLC.Primary_Authentication(i_Params_Primary_Authentication);
                oResult_Primary_Authentication.Params_Primary_Authentication = i_Params_Primary_Authentication;
            }
        }
        catch (Exception ex)
        {
            oResult_Primary_Authentication.Params_Primary_Authentication = i_Params_Primary_Authentication;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Primary_Authentication.Exception_Message = string.Format("Primary_Authentication : {0}", ex.Message);
                oResult_Primary_Authentication.Stack_Trace = is_send_stack_trace ? string.Format("Primary_Authentication : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Primary_Authentication.Exception_Message = ex.Message;
                oResult_Primary_Authentication.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Primary_Authentication;
        #endregion
    }
    #endregion
    #region OTP_Verification
    [HttpPost]
    [Route("OTP_Verification")]
    public Result_OTP_Verification OTP_Verification(Params_OTP_Verification i_Params_OTP_Verification)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_OTP_Verification oResult_OTP_Verification = new Result_OTP_Verification();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_OTP_Verification.i_Result = oBLC.OTP_Verification(i_Params_OTP_Verification);
                oResult_OTP_Verification.Params_OTP_Verification = i_Params_OTP_Verification;
            }
        }
        catch (Exception ex)
        {
            oResult_OTP_Verification.Params_OTP_Verification = i_Params_OTP_Verification;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_OTP_Verification.Exception_Message = string.Format("OTP_Verification : {0}", ex.Message);
                oResult_OTP_Verification.Stack_Trace = is_send_stack_trace ? string.Format("OTP_Verification : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_OTP_Verification.Exception_Message = ex.Message;
                oResult_OTP_Verification.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_OTP_Verification;
        #endregion
    }
    #endregion
    #region Send_Otp
    [HttpPost]
    [Route("Send_Otp")]
    public Result_Send_Otp Send_Otp(Params_Send_Otp i_Params_Send_Otp)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Send_Otp oResult_Send_Otp = new Result_Send_Otp();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Send_Otp.i_Result = oBLC.Send_Otp(i_Params_Send_Otp);
                oResult_Send_Otp.Params_Send_Otp = i_Params_Send_Otp;
            }
        }
        catch (Exception ex)
        {
            oResult_Send_Otp.Params_Send_Otp = i_Params_Send_Otp;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Send_Otp.Exception_Message = string.Format("Send_Otp : {0}", ex.Message);
                oResult_Send_Otp.Stack_Trace = is_send_stack_trace ? string.Format("Send_Otp : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Send_Otp.Exception_Message = ex.Message;
                oResult_Send_Otp.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Send_Otp;
        #endregion
    }
    #endregion
    #region Verify_Otp
    [HttpPost]
    [Route("Verify_Otp")]
    public Result_Verify_Otp Verify_Otp(Params_Verify_Otp i_Params_Verify_Otp)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Verify_Otp oResult_Verify_Otp = new Result_Verify_Otp();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Verify_Otp.i_Result = oBLC.Verify_Otp(i_Params_Verify_Otp);
                oResult_Verify_Otp.Params_Verify_Otp = i_Params_Verify_Otp;
            }
        }
        catch (Exception ex)
        {
            oResult_Verify_Otp.Params_Verify_Otp = i_Params_Verify_Otp;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Verify_Otp.Exception_Message = string.Format("Verify_Otp : {0}", ex.Message);
                oResult_Verify_Otp.Stack_Trace = is_send_stack_trace ? string.Format("Verify_Otp : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Verify_Otp.Exception_Message = ex.Message;
                oResult_Verify_Otp.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Verify_Otp;
        #endregion
    }
    #endregion
    #region Change_User_Forgotten_Password
    [HttpPost]
    [Route("Change_User_Forgotten_Password")]
    public Result_Change_User_Forgotten_Password Change_User_Forgotten_Password(Params_Change_User_Forgotten_Password i_Params_Change_User_Forgotten_Password)
    {
        #region Declaration And Initialization Section.
        string oTicket = string.Empty;
        Result_Change_User_Forgotten_Password oResult_Change_User_Forgotten_Password = new Result_Change_User_Forgotten_Password();
        #endregion
        #region Body Section.
        try
        {
            using (BLC.BLC oBLC = new BLC.BLC(oTicket))
            {
                oResult_Change_User_Forgotten_Password.i_Result = oBLC.Change_User_Forgotten_Password(i_Params_Change_User_Forgotten_Password);
                oResult_Change_User_Forgotten_Password.Params_Change_User_Forgotten_Password = i_Params_Change_User_Forgotten_Password;
            }
        }
        catch (Exception ex)
        {
            oResult_Change_User_Forgotten_Password.Params_Change_User_Forgotten_Password = i_Params_Change_User_Forgotten_Password;
            bool is_send_stack_trace = ConfigurationManager.AppSettings["IS_DEBUG_MODE"] != null && ConfigurationManager.AppSettings["IS_DEBUG_MODE"] == "1";
            if (ex.GetType().FullName != "BLC.BLC_Exception")
            {
                oResult_Change_User_Forgotten_Password.Exception_Message = string.Format("Change_User_Forgotten_Password : {0}", ex.Message);
                oResult_Change_User_Forgotten_Password.Stack_Trace = is_send_stack_trace ? string.Format("Change_User_Forgotten_Password : {0}", ex.StackTrace) : string.Empty;
            }
            else
            {
                oResult_Change_User_Forgotten_Password.Exception_Message = ex.Message;
                oResult_Change_User_Forgotten_Password.Stack_Trace = is_send_stack_trace ? ex.StackTrace : string.Empty;
            }
        }
        #endregion
        #region Return Section
        return oResult_Change_User_Forgotten_Password;
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
#region Result_Primary_Authentication
public partial class Result_Primary_Authentication : Action_Result
{
    #region Properties.
    public Primary_Authentication_Response i_Result { get; set; }
    public Params_Primary_Authentication Params_Primary_Authentication { get; set; }
    #endregion
}
#endregion
#region Result_OTP_Verification
public partial class Result_OTP_Verification : Action_Result
{
    #region Properties.
    public User_Details i_Result { get; set; }
    public Params_OTP_Verification Params_OTP_Verification { get; set; }
    #endregion
}
#endregion
#region Result_Send_Otp
public partial class Result_Send_Otp : Action_Result
{
    #region Properties.
    public Send_Otp_Response i_Result { get; set; }
    public Params_Send_Otp Params_Send_Otp { get; set; }
    #endregion
}
#endregion
#region Result_Verify_Otp
public partial class Result_Verify_Otp : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Verify_Otp Params_Verify_Otp { get; set; }
    #endregion
}
#endregion
#region Result_Change_User_Forgotten_Password
public partial class Result_Change_User_Forgotten_Password : Action_Result
{
    #region Properties.
    public bool i_Result { get; set; }
    public Params_Change_User_Forgotten_Password Params_Change_User_Forgotten_Password { get; set; }
    #endregion
}
#endregion
