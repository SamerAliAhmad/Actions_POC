using BLC;
using System;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public partial class OrganizationManagementController
{
    [HttpPost]
    [Route("Upload_Organization_Picture")]
    public IActionResult Upload_Organization_Picture()
    {
        #region Declaration And Initialization Section.
        string i_Ticket = string.Empty;
        Result_Upload_Organization_Picture oResult_Upload_Organization_Picture = new Result_Upload_Organization_Picture();
        Params_Upload_Organization_Picture oParams_Upload_Organization_Picture = new Params_Upload_Organization_Picture();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            i_Ticket = Validate_And_Extract_Ticket();
            //-------------------
            TypeConverter typeConverter;
            if ((HttpContext.Request.Headers["organizationID"].FirstOrDefault() != null) && (HttpContext.Request.Headers["organizationID"].ToString() != ""))
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int));
                oParams_Upload_Organization_Picture.ORGANIZATION_ID = (int)typeConverter.ConvertFromString(HttpContext.Request.Headers["organizationID"]);
            }
            if ((HttpContext.Request.Headers["imageSetupID"].FirstOrDefault() != null) && (HttpContext.Request.Headers["imageSetupID"].ToString() != ""))
            {
                typeConverter = TypeDescriptor.GetConverter(typeof(int));
                oParams_Upload_Organization_Picture.IMAGE_TYPE_SETUP_ID = (int)typeConverter.ConvertFromString(HttpContext.Request.Headers["imageSetupID"]);
            }
            oParams_Upload_Organization_Picture.List_Uploaded_File = Request.Form.Files;
            using (BLC.BLC oBLC = new BLC.BLC(i_Ticket))
            {
                oResult_Upload_Organization_Picture.i_Result = oBLC.Upload_Organization_Picture(oParams_Upload_Organization_Picture);
            }
        }
        catch (Exception ex)
        {
            if (ex.GetType().FullName != "BLC.BLCException")
            {
                oResult_Upload_Organization_Picture.Exception_Message = string.Format("Upload_Organization_Picture : {0}", ex.Message);
            }
            else
            {
                oResult_Upload_Organization_Picture.Exception_Message = ex.Message;
            }
        }
        #endregion
        #region Return Section
        return Ok(oResult_Upload_Organization_Picture);
        #endregion
    }
    #region Result_Upload_Organization_Picture
    public partial class Result_Upload_Organization_Picture : Action_Result
    {
        #region Properties.
        public string i_Result { get; set; }
        #endregion
    }
    #endregion
}
