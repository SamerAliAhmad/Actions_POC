using BLC;
using System;
using System.Linq;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public partial class FileManagementController
{
    [HttpPost]
    [Route("Upload_Asset")]
    public IActionResult Upload_Asset()
    {
        #region Declaration And Initialization Section.
        string i_Ticket = string.Empty;
        Result_Upload_Asset oResult_Upload_Asset = new Result_Upload_Asset();
        Params_Upload_Asset oParams_Upload_Asset = new Params_Upload_Asset();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            i_Ticket = Validate_And_Extract_Ticket();
            //-------------------
            if ((HttpContext.Request.Headers["relativePath"].FirstOrDefault() != null) && (HttpContext.Request.Headers["relativePath"].ToString() != ""))
            {
                oParams_Upload_Asset.Asset_Relative_Path = HttpContext.Request.Headers["relativePath"];
            }
            oParams_Upload_Asset.List_Uploaded_File = Request.Form.Files;
            using (BLC.BLC oBLC = new BLC.BLC(i_Ticket))
            {
                oResult_Upload_Asset.i_Result = oBLC.Upload_Asset(oParams_Upload_Asset);
            }
        }
        catch (Exception ex)
        {
            if (ex.GetType().FullName != "BLC.BLCException")
            {
                oResult_Upload_Asset.Exception_Message = string.Format("Upload_Asset : {0}", ex.Message);
            }
            else
            {
                oResult_Upload_Asset.Exception_Message = ex.Message;
            }
        }
        #endregion
        #region Return Section
        return Ok(oResult_Upload_Asset);
        #endregion
    }
    #region Result_Upload_Asset
    public partial class Result_Upload_Asset : Action_Result
    {
        #region Properties.
        public List<string> i_Result { get; set; }
        #endregion
    }
    #endregion
}
