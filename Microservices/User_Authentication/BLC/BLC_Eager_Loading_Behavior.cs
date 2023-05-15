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
        #region BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Eager_Loading(List<User> i_Result, Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var User_ID_List = i_Result.Select(user => user.USER_ID).OrderBy(User_ID => User_ID);

                // ---------------------
                // Get All available User_districtnex_module entries.
                // ---------------------
                List<Service_Mesh.User_districtnex_module> oList_User_districtnex_module_Ext = new List<Service_Mesh.User_districtnex_module>();
                List<User_districtnex_module> oList_User_districtnex_module = new List<User_districtnex_module>();
                var User_districtnex_module_handle = Task.Run(() =>
                {

                    oList_User_districtnex_module_Ext = this._service_mesh.Get_User_districtnex_module_By_USER_ID_List(new Service_Mesh.Params_Get_User_districtnex_module_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    }).i_Result;
                    oList_User_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<User_districtnex_module>>(oList_User_districtnex_module_Ext);
                });
                // ---------------------
                // Get All available User_level_access entries.
                // ---------------------
                List<Service_Mesh.User_level_access> oList_User_level_access_Ext = new List<Service_Mesh.User_level_access>();
                List<User_level_access> oList_User_level_access = new List<User_level_access>();
                var User_level_access_handle = Task.Run(() =>
                {

                    oList_User_level_access_Ext = this._service_mesh.Get_User_level_access_By_USER_ID_List(new Service_Mesh.Params_Get_User_level_access_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    }).i_Result;
                    oList_User_level_access = Props.Copy_Prop_Values_From_Api_Response<List<User_level_access>>(oList_User_level_access_Ext);
                });
                Task.WaitAll(User_districtnex_module_handle, User_level_access_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oUser =>
                {
                    oUser.List_User_districtnex_module = oList_User_districtnex_module.Where(oUser_districtnex_module => oUser_districtnex_module.USER_ID == oUser.USER_ID).ToList();
                    oUser.List_User_level_access = oList_User_level_access.Where(oUser_level_access => oUser_level_access.USER_ID == oUser.USER_ID).ToList();
                    return oUser;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_User_By_USER_ID_Adv_Eager_Loading
        public void BLC_OnPostEvent_Get_User_By_USER_ID_Adv_Eager_Loading(User i_Result, Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            #region Body Section
            if (i_Result != null)
            {
                var User_ID = i_Result.USER_ID;
                // ---------------------
                // Get All available User_districtnex_module entries.
                // ---------------------
                List<User_districtnex_module> _List_User_districtnex_module = new List<User_districtnex_module>();
                List<Service_Mesh.User_districtnex_module> oList_User_districtnex_module = new List<Service_Mesh.User_districtnex_module>();
                var User_districtnex_module_handle = Task.Run(() =>
                {
                    oList_User_districtnex_module = this._service_mesh.Get_User_districtnex_module_By_USER_ID(new Service_Mesh.Params_Get_User_districtnex_module_By_USER_ID()
                    {
                        USER_ID = User_ID
                    }).i_Result;
                    _List_User_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<User_districtnex_module>>(oList_User_districtnex_module);
                });
                // ---------------------
                // Get All available User_level_access entries.
                // ---------------------
                List<User_level_access> _List_User_level_access = new List<User_level_access>();
                List<Service_Mesh.User_level_access> oList_User_level_access = new List<Service_Mesh.User_level_access>();
                var User_level_access_handle = Task.Run(() =>
                {
                    oList_User_level_access = this._service_mesh.Get_User_level_access_By_USER_ID(new Service_Mesh.Params_Get_User_level_access_By_USER_ID()
                    {
                        USER_ID = User_ID
                    }).i_Result;
                    _List_User_level_access = Props.Copy_Prop_Values_From_Api_Response<List<User_level_access>>(oList_User_level_access);
                });
                Task.WaitAll(User_districtnex_module_handle, User_level_access_handle);
                i_Result.List_User_districtnex_module = _List_User_districtnex_module;
                i_Result.List_User_level_access = _List_User_level_access;
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_User_By_USER_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_User_By_USER_ID_List_Eager_Loading(List<User> i_Result, Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var User_ID_List = i_Result.Select(user => user.USER_ID).OrderBy(User_ID => User_ID);

                // ---------------------
                // Get All available User_districtnex_module entries.
                // ---------------------

                List<Service_Mesh.User_districtnex_module> oList_User_districtnex_module_Ext = this._service_mesh.Get_User_districtnex_module_By_USER_ID_List(new Service_Mesh.Params_Get_User_districtnex_module_By_USER_ID_List()
                {
                    USER_ID_LIST = User_ID_List
                }).i_Result;
                List<User_districtnex_module> oList_User_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<User_districtnex_module>>(oList_User_districtnex_module_Ext);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oUser =>
                {
                    oUser.List_User_districtnex_module = oList_User_districtnex_module.Where(oUser_districtnex_module => oUser_districtnex_module.USER_ID == oUser.USER_ID).ToList();
                    return oUser;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv_Eager_Loading
        public void BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv_Eager_Loading(List<User> i_Result, Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var User_ID_List = i_Result.Select(user => user.USER_ID).OrderBy(User_ID => User_ID);

                // ---------------------
                // Get All available User_level_access entries.
                // ---------------------
                List<Service_Mesh.User_level_access> oList_User_level_access_Ext = new List<Service_Mesh.User_level_access>();
                List<User_level_access> oList_User_level_access = new List<User_level_access>();
                var User_level_access_handle = Task.Run(() =>
                {

                    oList_User_level_access_Ext = this._service_mesh.Get_User_level_access_By_USER_ID_List(new Service_Mesh.Params_Get_User_level_access_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    }).i_Result;
                    oList_User_level_access = Props.Copy_Prop_Values_From_Api_Response<List<User_level_access>>(oList_User_level_access_Ext);
                });
                // ---------------------
                // Get All available User_districtnex_module entries.
                // ---------------------
                List<Service_Mesh.User_districtnex_module> oList_User_districtnex_module_Ext = new List<Service_Mesh.User_districtnex_module>();
                List<User_districtnex_module> oList_User_districtnex_module = new List<User_districtnex_module>();
                var User_districtnex_module_handle = Task.Run(() =>
                {

                    oList_User_districtnex_module_Ext = this._service_mesh.Get_User_districtnex_module_By_USER_ID_List(new Service_Mesh.Params_Get_User_districtnex_module_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    }).i_Result;
                    oList_User_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<User_districtnex_module>>(oList_User_districtnex_module_Ext);
                });
                Task.WaitAll(User_level_access_handle, User_districtnex_module_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oUser =>
                {
                    oUser.List_User_level_access = oList_User_level_access.Where(oUser_level_access => oUser_level_access.USER_ID == oUser.USER_ID).ToList();
                    oUser.List_User_districtnex_module = oList_User_districtnex_module.Where(oUser_districtnex_module => oUser_districtnex_module.USER_ID == oUser.USER_ID).ToList();
                    return oUser;
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
            this.OnPostEvent_Get_User_By_ORGANIZATION_ID_List += new PostEvent_Handler_Get_User_By_ORGANIZATION_ID_List(BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Eager_Loading);
            this.OnPostEvent_Get_User_By_USER_ID_Adv += new PostEvent_Handler_Get_User_By_USER_ID_Adv(BLC_OnPostEvent_Get_User_By_USER_ID_Adv_Eager_Loading);
            this.OnPostEvent_Get_User_By_USER_ID_List += new PostEvent_Handler_Get_User_By_USER_ID_List(BLC_OnPostEvent_Get_User_By_USER_ID_List_Eager_Loading);
            this.OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv += new PostEvent_Handler_Get_User_By_ORGANIZATION_ID_List_Adv(BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv_Eager_Loading);
            #endregion
        }
        #endregion
    }
}