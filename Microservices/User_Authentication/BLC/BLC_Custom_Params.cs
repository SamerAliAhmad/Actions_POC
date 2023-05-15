using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Primary_Authentication
    public class Params_Primary_Authentication
    {
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool? IS_ADMIN { get; set; }
    }
    #endregion
    #region Params_OTP_Verification
    public class Params_OTP_Verification
    {
        public string USERNAME { get; set; }
        public long? USER_ID { get; set; }
        public string OTP { get; set; }
    }
    #endregion
    #region Params_Verify_Otp
    public class Params_Verify_Otp
    {
        public long? USER_ID { get; set; }
        public string OTP { get; set; }
    }
    #endregion
    #region Params_Change_User_Forgotten_Password
    public class Params_Change_User_Forgotten_Password
    {
        public string USERNAME { get; set; }
        public string NEW_PASSWORD { get; set; }
        public string OTP { get; set; }
    }
    #endregion
    #region Params_Send_Otp
    public class Params_Send_Otp
    {
        public string USERNAME { get; set; }
        public User USER { get; set; }
        public bool IS_FORGOT_PASSWORD { get; set; }
    }
    #endregion
    #region Params_Edit_Otp_List
    public class Params_Edit_Otp_List
    {
        public List<Otp> OTP_LIST { get; set; }
    }
    #endregion
    #region Params_Delete_Otp_By_USER_ID
    public class Params_Delete_Otp_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    #endregion
    #region Params_Delete_Otp_By_OTP_ID
    public class Params_Delete_Otp_By_OTP_ID
    {
        public string OTP_ID { get; set; }
    }
    #endregion
    #region Params_Get_Otp_By_USER_ID
    public class Params_Get_Otp_By_USER_ID
    {
        public long? USER_ID { get; set; }
    }
    #endregion
    
}
