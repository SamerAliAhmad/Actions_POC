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
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID Event
        public delegate void PreEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
        public delegate void PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Setup_category i_Result, Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
        public event PreEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID;
        public event PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID;
        #endregion
        #region Get_Setup_category_By_OWNER_ID Event
        public delegate void PreEvent_Handler_Get_Setup_category_By_OWNER_ID(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID);
        public delegate void PostEvent_Handler_Get_Setup_category_By_OWNER_ID(List<Setup_category> i_Result, Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID);
        public event PreEvent_Handler_Get_Setup_category_By_OWNER_ID OnPreEvent_Get_Setup_category_By_OWNER_ID;
        public event PostEvent_Handler_Get_Setup_category_By_OWNER_ID OnPostEvent_Get_Setup_category_By_OWNER_ID;
        #endregion
        #region Get_Video_ai_engine_By_OWNER_ID Event
        public delegate void PreEvent_Handler_Get_Video_ai_engine_By_OWNER_ID(Params_Get_Video_ai_engine_By_OWNER_ID i_Params_Get_Video_ai_engine_By_OWNER_ID);
        public delegate void PostEvent_Handler_Get_Video_ai_engine_By_OWNER_ID(List<Video_ai_engine> i_Result, Params_Get_Video_ai_engine_By_OWNER_ID i_Params_Get_Video_ai_engine_By_OWNER_ID);
        public event PreEvent_Handler_Get_Video_ai_engine_By_OWNER_ID OnPreEvent_Get_Video_ai_engine_By_OWNER_ID;
        public event PostEvent_Handler_Get_Video_ai_engine_By_OWNER_ID OnPostEvent_Get_Video_ai_engine_By_OWNER_ID;
        #endregion
        #region Edit_Video_ai_engine Event
        public delegate void PreEvent_Handler_Edit_Video_ai_engine(Video_ai_engine i_Video_ai_engine, Enum_Edit_Mode i_Enum_Edit_Mode);
        public delegate void PostEvent_Handler_Edit_Video_ai_engine(Video_ai_engine i_Video_ai_engine, Enum_Edit_Mode i_Enum_Edit_Mode);
        public event PreEvent_Handler_Edit_Video_ai_engine OnPreEvent_Edit_Video_ai_engine;
        public event PostEvent_Handler_Edit_Video_ai_engine OnPostEvent_Edit_Video_ai_engine;
        #endregion
        #region Edit_Setup_category Event
        public delegate void PreEvent_Handler_Edit_Setup_category(Setup_category i_Setup_category, Enum_Edit_Mode i_Enum_Edit_Mode);
        public delegate void PostEvent_Handler_Edit_Setup_category(Setup_category i_Setup_category, Enum_Edit_Mode i_Enum_Edit_Mode);
        public event PreEvent_Handler_Edit_Setup_category OnPreEvent_Edit_Setup_category;
        public event PostEvent_Handler_Edit_Setup_category OnPostEvent_Edit_Setup_category;
        #endregion
        #region Edit_Video_ai_asset Event
        public delegate void PreEvent_Handler_Edit_Video_ai_asset(Video_ai_asset i_Video_ai_asset, Enum_Edit_Mode i_Enum_Edit_Mode);
        public delegate void PostEvent_Handler_Edit_Video_ai_asset(Video_ai_asset i_Video_ai_asset, Enum_Edit_Mode i_Enum_Edit_Mode);
        public event PreEvent_Handler_Edit_Video_ai_asset OnPreEvent_Edit_Video_ai_asset;
        public event PostEvent_Handler_Edit_Video_ai_asset OnPostEvent_Edit_Video_ai_asset;
        #endregion
        #endregion
    }
}