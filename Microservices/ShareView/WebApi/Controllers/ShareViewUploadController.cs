using BLC;
using System;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public partial class ShareViewController
{
    [HttpPost]
    [Route("Upload_Share_File")]
    public IActionResult Upload_Share_File()
    {
        #region Declaration And Initialization Section.
        string i_Ticket = string.Empty;
        Result_Upload_Share_File oResult_Upload_Share_File = new Result_Upload_Share_File();
        Params_Upload_Share_File oParams_Upload_Share_File = new Params_Upload_Share_File();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            i_Ticket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if ((HttpContext.Request.Headers["userID"].FirstOrDefault() != null) && (HttpContext.Request.Headers["userID"].ToString() != ""))
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int));
                oParams_Upload_Share_File.USER_ID = (int)typeConverter.ConvertFromString(HttpContext.Request.Headers["userID"]);
            }
            oParams_Upload_Share_File.List_Uploaded_File = Request.Form.Files;
            using (BLC.BLC oBLC = new BLC.BLC(i_Ticket))
            {
                oResult_Upload_Share_File.i_Result = oBLC.Upload_Share_File(oParams_Upload_Share_File);
            }
        }
        catch (Exception ex)
        {
            if (ex.GetType().FullName != "BLC.BLCException")
            {
                oResult_Upload_Share_File.Exception_Message = string.Format("Upload_Share_File : {0}", ex.Message);
            }
            else
            {
                oResult_Upload_Share_File.Exception_Message = ex.Message;
            }
        }
        #endregion
        #region Return Section
        return Ok(oResult_Upload_Share_File);
        #endregion
    }
    #region Result_Upload_Share_File
    public partial class Result_Upload_Share_File : Action_Result
    {
        #region Properties.
        public string i_Result { get; set; }
        #endregion
    }
    #endregion
}
