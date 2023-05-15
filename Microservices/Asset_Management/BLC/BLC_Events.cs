using System;
using System.IO;
using SmartrTools;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Properties
        public Service_Mesh.Proxy _service_mesh { get; set; }
        #endregion
        #region Prepare_BLC_Initializer
        public BLC_Initializer Prepare_BLC_Initializer(string i_Ticket)
        {
            this.oBLC_Initializer = new BLC_Initializer();
            if (this.OnPreEvent_BLC_Init != null)
            {
                this.oBLC_Initializer = this.OnPreEvent_BLC_Init(i_Ticket);
            }
            else
            {
                this.oBLC_Initializer.Connection_String = ConfigurationManager.AppSettings["CONN_STR"];
                this.oBLC_Initializer.Messages_File_Path = ConfigurationManager.AppSettings["BLC_MESSAGES"];

                var oList_Ticket_Part = Resolve_Ticket(i_Ticket);
                this.oBLC_Initializer.User_ID = Convert.ToInt64(oList_Ticket_Part["USER_ID"]);
                this.oBLC_Initializer.Owner_ID = Convert.ToInt32(oList_Ticket_Part["OWNER_ID"]);
            }
            this._service_mesh = new Service_Mesh.Proxy();
            this._service_mesh.Ticket = i_Ticket;
            this._service_mesh.BaseURL = ConfigurationManager.AppSettings["API_GATEWAY_URL"];
            if (this.OnPostEvent_BLC_Init != null)
            {
                this.OnPostEvent_BLC_Init(i_Ticket);
            }
            return this.oBLC_Initializer;
        }
        #endregion
        #region General Pre/Post events
        public delegate void PreEvent_Handler_General(string i_Method_Name, string i_Method_Params, bool is_Cached);
        public delegate void PostEvent_Handler_General(string i_Method_Name, string i_Method_Params, bool is_Cached);
        public event PreEvent_Handler_General OnPreEvent_General;
        public event PostEvent_Handler_General OnPostEvent_General;
        #endregion
        #region General Pre/Post BLC_Init
        public delegate BLC_Initializer PreEvent_Handler_BLC_Init(string i_Ticket);
        public delegate BLC_Initializer PostEvent_Handler_BLC_Init(string i_Ticket);
        public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
        public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
        #endregion
        #region Events Handlers
        #region Get_Asset_By_ASSET_ID_Adv Event
        public delegate void PreEvent_Handler_Get_Asset_By_ASSET_ID_Adv(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID);
        public delegate void PostEvent_Handler_Get_Asset_By_ASSET_ID_Adv(ref Asset i_Result, Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID);
        public event PreEvent_Handler_Get_Asset_By_ASSET_ID_Adv OnPreEvent_Get_Asset_By_ASSET_ID_Adv;
        public event PostEvent_Handler_Get_Asset_By_ASSET_ID_Adv OnPostEvent_Get_Asset_By_ASSET_ID_Adv;
        #endregion
        #endregion
    }
}