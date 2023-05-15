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
        #region Edit_Organization_level_access_List Event
        public delegate void PreEvent_Handler_Edit_Organization_level_access_List(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List);
        public delegate void PostEvent_Handler_Edit_Organization_level_access_List(Params_Edit_Organization_level_access_List i_Params_Edit_Organization_level_access_List);
        public event PreEvent_Handler_Edit_Organization_level_access_List OnPreEvent_Edit_Organization_level_access_List;
        public event PostEvent_Handler_Edit_Organization_level_access_List OnPostEvent_Edit_Organization_level_access_List;
        #endregion
        #region Delete_Organization_districtnex_module Event
        public delegate void PreEvent_Handler_Delete_Organization_districtnex_module(Params_Delete_Organization_districtnex_module i_Params_Delete_Organization_districtnex_module);
        public delegate void PostEvent_Handler_Delete_Organization_districtnex_module(Params_Delete_Organization_districtnex_module i_Params_Delete_Organization_districtnex_module);
        public event PreEvent_Handler_Delete_Organization_districtnex_module OnPreEvent_Delete_Organization_districtnex_module;
        public event PostEvent_Handler_Delete_Organization_districtnex_module OnPostEvent_Delete_Organization_districtnex_module;
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID_List Event
        public delegate void PreEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List(Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List);
        public delegate void PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List(List<Organization> i_Result, Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List);
        public event PreEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List OnPreEvent_Get_Organization_By_ORGANIZATION_ID_List;
        public event PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List;
        #endregion
        #region Get_Organization_By_ORGANIZATION_ID Event
        public delegate void PreEvent_Handler_Get_Organization_By_ORGANIZATION_ID(Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID);
        public delegate void PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID(Organization i_Result, Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID);
        public event PreEvent_Handler_Get_Organization_By_ORGANIZATION_ID OnPreEvent_Get_Organization_By_ORGANIZATION_ID;
        public event PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID OnPostEvent_Get_Organization_By_ORGANIZATION_ID;
        #endregion
        #region Get_Organization_By_OWNER_ID Event
        public delegate void PreEvent_Handler_Get_Organization_By_OWNER_ID(Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID);
        public delegate void PostEvent_Handler_Get_Organization_By_OWNER_ID(ref List<Organization> i_Result, Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID);
        public event PreEvent_Handler_Get_Organization_By_OWNER_ID OnPreEvent_Get_Organization_By_OWNER_ID;
        public event PostEvent_Handler_Get_Organization_By_OWNER_ID OnPostEvent_Get_Organization_By_OWNER_ID;
        #endregion
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
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID Event
        public delegate void PreEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID);
        public delegate void PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID(List<Organization_color_scheme> i_Result, Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID);
        public event PreEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID;
        public event PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID;
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List Event
        public delegate void PreEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
        public delegate void PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List(List<Organization_color_scheme> i_Result, Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
        public event PreEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List;
        public event PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List;
        #endregion
        #region Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv Event
        public delegate void PreEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
        public delegate void PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(List<Organization_color_scheme> i_Result, Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List);
        public event PreEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv OnPreEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv;
        public event PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv;
        #endregion
        #region Edit_Organization_color_scheme Event
        public delegate void PreEvent_Handler_Edit_Organization_color_scheme(Organization_color_scheme i_Organization_color_scheme, Enum_Edit_Mode i_Enum_Edit_Mode);
        public delegate void PostEvent_Handler_Edit_Organization_color_scheme(Organization_color_scheme i_Organization_color_scheme, Enum_Edit_Mode i_Enum_Edit_Mode);
        public event PreEvent_Handler_Edit_Organization_color_scheme OnPreEvent_Edit_Organization_color_scheme;
        public event PostEvent_Handler_Edit_Organization_color_scheme OnPostEvent_Edit_Organization_color_scheme;
        #endregion
        #region Edit_Setup_category Event
        public delegate void PreEvent_Handler_Edit_Setup_category(Setup_category i_Setup_category, Enum_Edit_Mode i_Enum_Edit_Mode);
        public delegate void PostEvent_Handler_Edit_Setup_category(Setup_category i_Setup_category, Enum_Edit_Mode i_Enum_Edit_Mode);
        public event PreEvent_Handler_Edit_Setup_category OnPreEvent_Edit_Setup_category;
        public event PostEvent_Handler_Edit_Setup_category OnPostEvent_Edit_Setup_category;
        #endregion
        #region Edit_Organization Event
        public delegate void PreEvent_Handler_Edit_Organization(Organization i_Organization, Enum_Edit_Mode i_Enum_Edit_Mode);
        public delegate void PostEvent_Handler_Edit_Organization(Organization i_Organization, Enum_Edit_Mode i_Enum_Edit_Mode);
        public event PreEvent_Handler_Edit_Organization OnPreEvent_Edit_Organization;
        public event PostEvent_Handler_Edit_Organization OnPostEvent_Edit_Organization;
        #endregion
        #endregion
    }
}