using System.Linq;
using SmartrTools;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Get_Area_By_AREA_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Area_By_AREA_ID_List_Eager_Loading(List<Area> i_Result, Params_Get_Area_By_AREA_ID_List i_Params_Get_Area_By_AREA_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Area_ID_List = i_Result.Select(area => area.AREA_ID).OrderBy(Area_ID => Area_ID);

                // ---------------------
                // Get All available Area_view entries.
                // ---------------------
                List<Area_view> oList_Area_view = Get_Area_view_By_AREA_ID_List(new Params_Get_Area_view_By_AREA_ID_List()
                {
                    AREA_ID_LIST = Area_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oArea =>
                {
                    oArea.List_Area_view = oList_Area_view.Where(oArea_view => oArea_view.AREA_ID == oArea.AREA_ID).ToList();
                    return oArea;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Site_By_SITE_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Site_By_SITE_ID_List_Eager_Loading(ref List<Site> i_Result, Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Site_ID_List = i_Result.Select(site => site.SITE_ID).OrderBy(Site_ID => Site_ID);

                // ---------------------
                // Get All available Site_view entries.
                // ---------------------
                List<Site_view> oList_Site_view = Get_Site_view_By_SITE_ID_List(new Params_Get_Site_view_By_SITE_ID_List()
                {
                    SITE_ID_LIST = Site_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSite =>
                {
                    oSite.List_Site_view = oList_Site_view.Where(oSite_view => oSite_view.SITE_ID == oSite.SITE_ID).ToList();
                    return oSite;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Site_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Site_By_OWNER_ID_Eager_Loading(List<Site> i_Result, Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Site_ID_List = i_Result.Select(site => site.SITE_ID).OrderBy(Site_ID => Site_ID);

                // ---------------------
                // Get All available Site_field_logo entries.
                // ---------------------

                List<Service_Mesh.Site_field_logo> oList_Site_field_logo_Ext = this._service_mesh.Get_Site_field_logo_By_SITE_ID_List(new Service_Mesh.Params_Get_Site_field_logo_By_SITE_ID_List()
                {
                    SITE_ID_LIST = Site_ID_List
                }).i_Result;
                List<Site_field_logo> oList_Site_field_logo = Props.Copy_Prop_Values_From_Api_Response<List<Site_field_logo>>(oList_Site_field_logo_Ext);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSite =>
                {
                    oSite.List_Site_field_logo = oList_Site_field_logo.Where(oSite_field_logo => oSite_field_logo.SITE_ID == oSite.SITE_ID).ToList();
                    return oSite;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_District_By_DISTRICT_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_District_By_DISTRICT_ID_List_Eager_Loading(List<District> i_Result, Params_Get_District_By_DISTRICT_ID_List i_Params_Get_District_By_DISTRICT_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var District_ID_List = i_Result.Select(district => district.DISTRICT_ID).OrderBy(District_ID => District_ID);

                // ---------------------
                // Get All available District_view entries.
                // ---------------------
                List<District_view> oList_District_view = Get_District_view_By_DISTRICT_ID_List(new Params_Get_District_view_By_DISTRICT_ID_List()
                {
                    DISTRICT_ID_LIST = District_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oDistrict =>
                {
                    oDistrict.List_District_view = oList_District_view.Where(oDistrict_view => oDistrict_view.DISTRICT_ID == oDistrict.DISTRICT_ID).ToList();
                    return oDistrict;
                }).ToList();
            }
            #endregion
        }
        #endregion
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
        #region BLC_OnPostEvent_Get_Entity_By_TOP_LEVEL_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Entity_By_TOP_LEVEL_ID_Eager_Loading(List<Entity> i_Result, Params_Get_Entity_By_TOP_LEVEL_ID i_Params_Get_Entity_By_TOP_LEVEL_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Entity_ID_List = i_Result.Select(entity => entity.ENTITY_ID).OrderBy(Entity_ID => Entity_ID);

                // ---------------------
                // Get All available Floor entries.
                // ---------------------

                List<Service_Mesh.Floor> oList_Floor_Ext = this._service_mesh.Get_Floor_By_ENTITY_ID_List(new Service_Mesh.Params_Get_Floor_By_ENTITY_ID_List()
                {
                    ENTITY_ID_LIST = Entity_ID_List
                }).i_Result;
                List<Floor> oList_Floor = Props.Copy_Prop_Values_From_Api_Response<List<Floor>>(oList_Floor_Ext);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oEntity =>
                {
                    oEntity.List_Floor = oList_Floor.Where(oFloor => oFloor.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                    return oEntity;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Entity_By_ENTITY_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Entity_By_ENTITY_ID_List_Eager_Loading(List<Entity> i_Result, Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Entity_ID_List = i_Result.Select(entity => entity.ENTITY_ID).OrderBy(Entity_ID => Entity_ID);

                // ---------------------
                // Get All available Entity_view entries.
                // ---------------------
                List<Entity_view> oList_Entity_view = Get_Entity_view_By_ENTITY_ID_List(new Params_Get_Entity_view_By_ENTITY_ID_List()
                {
                    ENTITY_ID_LIST = Entity_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oEntity =>
                {
                    oEntity.List_Entity_view = oList_Entity_view.Where(oEntity_view => oEntity_view.ENTITY_ID == oEntity.ENTITY_ID).ToList();
                    return oEntity;
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
                List<User_districtnex_module> oList_User_districtnex_module = new List<User_districtnex_module>();
                var User_districtnex_module_handle = Task.Run(() =>
                {
                    oList_User_districtnex_module = Get_User_districtnex_module_By_USER_ID_List(new Params_Get_User_districtnex_module_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    });
                });
                // ---------------------
                // Get All available User_level_access entries.
                // ---------------------
                List<User_level_access> oList_User_level_access = new List<User_level_access>();
                var User_level_access_handle = Task.Run(() =>
                {
                    oList_User_level_access = Get_User_level_access_By_USER_ID_List(new Params_Get_User_level_access_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    });
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
                var User_districtnex_module_handle = Task.Run(() =>
                {
                    _List_User_districtnex_module = Get_User_districtnex_module_By_USER_ID(new Params_Get_User_districtnex_module_By_USER_ID()
                    {
                        USER_ID = User_ID
                    });
                });
                // ---------------------
                // Get All available User_level_access entries.
                // ---------------------
                List<User_level_access> _List_User_level_access = new List<User_level_access>();
                var User_level_access_handle = Task.Run(() =>
                {
                    _List_User_level_access = Get_User_level_access_By_USER_ID(new Params_Get_User_level_access_By_USER_ID()
                    {
                        USER_ID = User_ID
                    });
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
                List<User_districtnex_module> oList_User_districtnex_module = Get_User_districtnex_module_By_USER_ID_List(new Params_Get_User_districtnex_module_By_USER_ID_List()
                {
                    USER_ID_LIST = User_ID_List
                });
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
                List<User_level_access> oList_User_level_access = new List<User_level_access>();
                var User_level_access_handle = Task.Run(() =>
                {
                    oList_User_level_access = Get_User_level_access_By_USER_ID_List(new Params_Get_User_level_access_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    });
                });
                // ---------------------
                // Get All available User_districtnex_module entries.
                // ---------------------
                List<User_districtnex_module> oList_User_districtnex_module = new List<User_districtnex_module>();
                var User_districtnex_module_handle = Task.Run(() =>
                {
                    oList_User_districtnex_module = Get_User_districtnex_module_By_USER_ID_List(new Params_Get_User_districtnex_module_By_USER_ID_List()
                    {
                        USER_ID_LIST = User_ID_List
                    });
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
            this.OnPostEvent_Get_Area_By_AREA_ID_List += new PostEvent_Handler_Get_Area_By_AREA_ID_List(BLC_OnPostEvent_Get_Area_By_AREA_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Site_By_SITE_ID_List += new PostEvent_Handler_Get_Site_By_SITE_ID_List(BLC_OnPostEvent_Get_Site_By_SITE_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Site_By_OWNER_ID += new PostEvent_Handler_Get_Site_By_OWNER_ID(BLC_OnPostEvent_Get_Site_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_District_By_DISTRICT_ID_List += new PostEvent_Handler_Get_District_By_DISTRICT_ID_List(BLC_OnPostEvent_Get_District_By_DISTRICT_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Entity_By_TOP_LEVEL_ID += new PostEvent_Handler_Get_Entity_By_TOP_LEVEL_ID(BLC_OnPostEvent_Get_Entity_By_TOP_LEVEL_ID_Eager_Loading);
            this.OnPostEvent_Get_Entity_By_ENTITY_ID_List += new PostEvent_Handler_Get_Entity_By_ENTITY_ID_List(BLC_OnPostEvent_Get_Entity_By_ENTITY_ID_List_Eager_Loading);
            this.OnPostEvent_Get_User_By_ORGANIZATION_ID_List += new PostEvent_Handler_Get_User_By_ORGANIZATION_ID_List(BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Eager_Loading);
            this.OnPostEvent_Get_User_By_USER_ID_Adv += new PostEvent_Handler_Get_User_By_USER_ID_Adv(BLC_OnPostEvent_Get_User_By_USER_ID_Adv_Eager_Loading);
            this.OnPostEvent_Get_User_By_USER_ID_List += new PostEvent_Handler_Get_User_By_USER_ID_List(BLC_OnPostEvent_Get_User_By_USER_ID_List_Eager_Loading);
            this.OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv += new PostEvent_Handler_Get_User_By_ORGANIZATION_ID_List_Adv(BLC_OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv_Eager_Loading);
            #endregion
        }
        #endregion
    }
}