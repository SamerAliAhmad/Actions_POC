using BLC;
using System;
using System.Linq;
using System.Configuration;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

public partial class PlatformLoggingController
{
    #region Create_Log
    [HttpPost]
    [Route("Create_Log")]
    public void Create_Log(Params_Create_Log i_Params_Create_Log)
    {
        Task.Run(() =>
        {
            #region Declaration And Initialization Section.
            string oTicket = string.Empty;
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
                    oBLC.Create_Log(i_Params_Create_Log);
                }
            }
            catch (Exception) { }
            #endregion
        });
    }
    #endregion
}