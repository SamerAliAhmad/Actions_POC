using System.Linq;
using SmartrTools;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading(Setup_category i_Result, Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null)
            {
                // ---------------------
                // Get All available Setup entries.
                // ---------------------
                i_Result.List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID()
                {
                    SETUP_CATEGORY_ID = i_Result.SETUP_CATEGORY_ID
                });
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading(List<Setup_category> i_Result, Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Setup_category_ID_List = i_Result.Select(setup_category => setup_category.SETUP_CATEGORY_ID).OrderBy(Setup_category_ID => Setup_category_ID);

                // ---------------------
                // Get All available Setup entries.
                // ---------------------
                List<Setup> oList_Setup = Get_Setup_By_SETUP_CATEGORY_ID_List(new Params_Get_Setup_By_SETUP_CATEGORY_ID_List()
                {
                    SETUP_CATEGORY_ID_LIST = Setup_category_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSetup_category =>
                {
                    oSetup_category.List_Setup = oList_Setup.Where(oSetup => oSetup.SETUP_CATEGORY_ID == oSetup_category.SETUP_CATEGORY_ID).ToList();
                    return oSetup_category;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_Eager_Loading(List<Organization_color_scheme> i_Result, Params_Get_Organization_color_scheme_By_ORGANIZATION_ID i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Organization_color_scheme_ID_List = i_Result.Select(organization_color_scheme => organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID).OrderBy(Organization_color_scheme_ID => Organization_color_scheme_ID);

                // ---------------------
                // Get All available Organization_chart_color entries.
                // ---------------------
                List<Organization_chart_color> oList_Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(new Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List()
                {
                    ORGANIZATION_COLOR_SCHEME_ID_LIST = Organization_color_scheme_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oOrganization_color_scheme =>
                {
                    oOrganization_color_scheme.List_Organization_chart_color = oList_Organization_chart_color.Where(oOrganization_chart_color => oOrganization_chart_color.ORGANIZATION_COLOR_SCHEME_ID == oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID).ToList();
                    return oOrganization_color_scheme;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Eager_Loading(List<Organization_color_scheme> i_Result, Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Organization_color_scheme_ID_List = i_Result.Select(organization_color_scheme => organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID).OrderBy(Organization_color_scheme_ID => Organization_color_scheme_ID);

                // ---------------------
                // Get All available Organization_chart_color entries.
                // ---------------------
                List<Organization_chart_color> oList_Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(new Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List()
                {
                    ORGANIZATION_COLOR_SCHEME_ID_LIST = Organization_color_scheme_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oOrganization_color_scheme =>
                {
                    oOrganization_color_scheme.List_Organization_chart_color = oList_Organization_chart_color.Where(oOrganization_chart_color => oOrganization_chart_color.ORGANIZATION_COLOR_SCHEME_ID == oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID).ToList();
                    return oOrganization_color_scheme;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv_Eager_Loading
        public void BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv_Eager_Loading(List<Organization_color_scheme> i_Result, Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List i_Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Organization_color_scheme_ID_List = i_Result.Select(organization_color_scheme => organization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID).OrderBy(Organization_color_scheme_ID => Organization_color_scheme_ID);

                // ---------------------
                // Get All available Organization_chart_color entries.
                // ---------------------
                List<Organization_chart_color> oList_Organization_chart_color = Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List_Adv(new Params_Get_Organization_chart_color_By_ORGANIZATION_COLOR_SCHEME_ID_List()
                {
                    ORGANIZATION_COLOR_SCHEME_ID_LIST = Organization_color_scheme_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oOrganization_color_scheme =>
                {
                    oOrganization_color_scheme.List_Organization_chart_color = oList_Organization_chart_color.Where(oOrganization_chart_color => oOrganization_chart_color.ORGANIZATION_COLOR_SCHEME_ID == oOrganization_color_scheme.ORGANIZATION_COLOR_SCHEME_ID).ToList();
                    return oOrganization_color_scheme;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List_Eager_Loading(List<Organization> i_Result, Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Organization_ID_List = i_Result.Select(organization => organization.ORGANIZATION_ID).OrderBy(Organization_ID => Organization_ID);

                // ---------------------
                // Get All available User entries.
                // ---------------------
                List<Service_Mesh.User> oList_User_Ext = new List<Service_Mesh.User>();
                List<User> oList_User = new List<User>();
                var User_handle = Task.Run(() =>
                {

                    oList_User_Ext = this._service_mesh.Get_User_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_User_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_User = Props.Copy_Prop_Values_From_Api_Response<List<User>>(oList_User_Ext);
                });
                // ---------------------
                // Get All available Organization_theme entries.
                // ---------------------
                List<Organization_theme> oList_Organization_theme = new List<Organization_theme>();
                var Organization_theme_handle = Task.Run(() =>
                {
                    oList_Organization_theme = Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(new Params_Get_Organization_theme_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available Organization_color_scheme entries.
                // ---------------------
                List<Organization_color_scheme> oList_Organization_color_scheme = new List<Organization_color_scheme>();
                var Organization_color_scheme_handle = Task.Run(() =>
                {
                    oList_Organization_color_scheme = Get_Organization_color_scheme_By_ORGANIZATION_ID_List(new Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available Organization_districtnex_module entries.
                // ---------------------
                List<Organization_districtnex_module> oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                var Organization_districtnex_module_handle = Task.Run(() =>
                {
                    oList_Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available Organization_image entries.
                // ---------------------
                List<Organization_image> oList_Organization_image = new List<Organization_image>();
                var Organization_image_handle = Task.Run(() =>
                {
                    oList_Organization_image = Get_Organization_image_By_ORGANIZATION_ID_List(new Params_Get_Organization_image_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available Organization_level_access entries.
                // ---------------------
                List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();
                var Organization_level_access_handle = Task.Run(() =>
                {
                    oList_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(new Params_Get_Organization_level_access_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available Organization_log_config entries.
                // ---------------------
                List<Organization_log_config> oList_Organization_log_config = new List<Organization_log_config>();
                var Organization_log_config_handle = Task.Run(() =>
                {
                    oList_Organization_log_config = Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(new Params_Get_Organization_log_config_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                Task.WaitAll(User_handle, Organization_theme_handle, Organization_color_scheme_handle, Organization_districtnex_module_handle, Organization_image_handle, Organization_level_access_handle, Organization_log_config_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oOrganization =>
                {
                    oOrganization.List_User = oList_User.Where(oUser => oUser.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_theme = oList_Organization_theme.Where(oOrganization_theme => oOrganization_theme.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_color_scheme = oList_Organization_color_scheme.Where(oOrganization_color_scheme => oOrganization_color_scheme.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_districtnex_module = oList_Organization_districtnex_module.Where(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_image = oList_Organization_image.Where(oOrganization_image => oOrganization_image.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_level_access = oList_Organization_level_access.Where(oOrganization_level_access => oOrganization_level_access.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_log_config = oList_Organization_log_config.Where(oOrganization_log_config => oOrganization_log_config.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    return oOrganization;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_Eager_Loading(Organization i_Result, Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID)
        {
            #region Body Section
            if (i_Result != null)
            {
                var Organization_ID = i_Result.ORGANIZATION_ID;
                // ---------------------
                // Get All available Organization_theme entries.
                // ---------------------
                List<Organization_theme> _List_Organization_theme = new List<Organization_theme>();
                var Organization_theme_handle = Task.Run(() =>
                {
                    _List_Organization_theme = Get_Organization_theme_By_ORGANIZATION_ID_Adv(new Params_Get_Organization_theme_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = Organization_ID
                    });
                });
                // ---------------------
                // Get All available Organization_image entries.
                // ---------------------
                List<Organization_image> _List_Organization_image = new List<Organization_image>();
                var Organization_image_handle = Task.Run(() =>
                {
                    _List_Organization_image = Get_Organization_image_By_ORGANIZATION_ID(new Params_Get_Organization_image_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = Organization_ID
                    });
                });
                Task.WaitAll(Organization_theme_handle, Organization_image_handle);
                i_Result.List_Organization_theme = _List_Organization_theme;
                i_Result.List_Organization_image = _List_Organization_image;
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Organization_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Organization_By_OWNER_ID_Eager_Loading(ref List<Organization> i_Result, Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Organization_ID_List = i_Result.Select(organization => organization.ORGANIZATION_ID).OrderBy(Organization_ID => Organization_ID);

                // ---------------------
                // Get All available Organization_districtnex_module entries.
                // ---------------------
                List<Organization_districtnex_module> oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                var Organization_districtnex_module_handle = Task.Run(() =>
                {
                    oList_Organization_districtnex_module = Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(new Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available User entries.
                // ---------------------
                List<Service_Mesh.User> oList_User_Ext = new List<Service_Mesh.User>();
                List<User> oList_User = new List<User>();
                var User_handle = Task.Run(() =>
                {

                    oList_User_Ext = this._service_mesh.Get_User_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_User_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_User = Props.Copy_Prop_Values_From_Api_Response<List<User>>(oList_User_Ext);
                });
                // ---------------------
                // Get All available Organization_image entries.
                // ---------------------
                List<Organization_image> oList_Organization_image = new List<Organization_image>();
                var Organization_image_handle = Task.Run(() =>
                {
                    oList_Organization_image = Get_Organization_image_By_ORGANIZATION_ID_List(new Params_Get_Organization_image_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                // ---------------------
                // Get All available Organization_level_access entries.
                // ---------------------
                List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();
                var Organization_level_access_handle = Task.Run(() =>
                {
                    oList_Organization_level_access = Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(new Params_Get_Organization_level_access_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    });
                });
                Task.WaitAll(Organization_districtnex_module_handle, User_handle, Organization_image_handle, Organization_level_access_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oOrganization =>
                {
                    oOrganization.List_Organization_districtnex_module = oList_Organization_districtnex_module.Where(oOrganization_districtnex_module => oOrganization_districtnex_module.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_User = oList_User.Where(oUser => oUser.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_image = oList_Organization_image.Where(oOrganization_image => oOrganization_image.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    oOrganization.List_Organization_level_access = oList_Organization_level_access.Where(oOrganization_level_access => oOrganization_level_access.ORGANIZATION_ID == oOrganization.ORGANIZATION_ID).ToList();
                    return oOrganization;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region Initialize_Eager_Loading_Mechanism
        public void Initialize_Eager_Loading_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID += new PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID(BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_Eager_Loading);
            this.OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List += new PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List(BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv += new PostEvent_Handler_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv(BLC_OnPostEvent_Get_Organization_color_scheme_By_ORGANIZATION_ID_List_Adv_Eager_Loading);
            this.OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List += new PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List(BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Organization_By_ORGANIZATION_ID += new PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID(BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_Eager_Loading);
            this.OnPostEvent_Get_Organization_By_OWNER_ID += new PostEvent_Handler_Get_Organization_By_OWNER_ID(BLC_OnPostEvent_Get_Organization_By_OWNER_ID_Eager_Loading);
            #endregion
        }
        #endregion
    }
}