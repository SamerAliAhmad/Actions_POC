using BLC;
using System;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

public partial class VideoAIEngineManagementController
{
    [HttpPost]
    [Route("Detect_Face_In_Image")]
    public IActionResult Detect_Face_In_Image()
    {
        #region Declaration And Initialization Section.
        string i_Ticket = string.Empty;
        Result_Detect_Face_In_Image oResult_Detect_Face_In_Image = new Result_Detect_Face_In_Image();
        Params_Detect_Face_In_Image oParams_Detect_Face_In_Image = new Params_Detect_Face_In_Image();
        #endregion
        #region Body Section.
        try
        {
            // Ticket Checking
            //-------------------
            i_Ticket = Validate_And_Extract_Ticket();
            //-------------------
            oParams_Detect_Face_In_Image.List_Uploaded_File = Request.Form.Files;
            using (BLC.BLC oBLC = new BLC.BLC(i_Ticket))
            {
                oResult_Detect_Face_In_Image.i_Result = oBLC.Detect_Face_In_Image(oParams_Detect_Face_In_Image);
            }
        }
        catch (Exception ex)
        {
            if (ex.GetType().FullName != "BLC.BLCException")
            {
                oResult_Detect_Face_In_Image.Exception_Message = string.Format("Detect_Face_In_Image : {0}", ex.Message);
            }
            else
            {
                oResult_Detect_Face_In_Image.Exception_Message = ex.Message;
            }
        }
        #endregion
        #region Return Section
        return Ok(oResult_Detect_Face_In_Image);
        #endregion
    }
    #region Result_Detect_Face_In_Image
    public partial class Result_Detect_Face_In_Image : Action_Result
    {
        #region Properties.
        public Detect_Face_Response i_Result { get; set; }
        #endregion
    }
    #endregion
}
