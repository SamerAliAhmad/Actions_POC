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

                List<Service_Mesh.Area_view> oList_Area_view_Ext = this._service_mesh.Get_Area_view_By_AREA_ID_List(new Service_Mesh.Params_Get_Area_view_By_AREA_ID_List()
                {
                    AREA_ID_LIST = Area_ID_List
                }).i_Result;
                List<Area_view> oList_Area_view = Props.Copy_Prop_Values_From_Api_Response<List<Area_view>>(oList_Area_view_Ext);
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

                List<Service_Mesh.Site_view> oList_Site_view_Ext = this._service_mesh.Get_Site_view_By_SITE_ID_List(new Service_Mesh.Params_Get_Site_view_By_SITE_ID_List()
                {
                    SITE_ID_LIST = Site_ID_List
                }).i_Result;
                List<Site_view> oList_Site_view = Props.Copy_Prop_Values_From_Api_Response<List<Site_view>>(oList_Site_view_Ext);
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

                List<Service_Mesh.District_view> oList_District_view_Ext = this._service_mesh.Get_District_view_By_DISTRICT_ID_List(new Service_Mesh.Params_Get_District_view_By_DISTRICT_ID_List()
                {
                    DISTRICT_ID_LIST = District_ID_List
                }).i_Result;
                List<District_view> oList_District_view = Props.Copy_Prop_Values_From_Api_Response<List<District_view>>(oList_District_view_Ext);
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
                List<Floor> oList_Floor = Get_Floor_By_ENTITY_ID_List(new Params_Get_Floor_By_ENTITY_ID_List()
                {
                    ENTITY_ID_LIST = Entity_ID_List
                });
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

                List<Service_Mesh.Entity_view> oList_Entity_view_Ext = this._service_mesh.Get_Entity_view_By_ENTITY_ID_List(new Service_Mesh.Params_Get_Entity_view_By_ENTITY_ID_List()
                {
                    ENTITY_ID_LIST = Entity_ID_List
                }).i_Result;
                List<Entity_view> oList_Entity_view = Props.Copy_Prop_Values_From_Api_Response<List<Entity_view>>(oList_Entity_view_Ext);
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
                List<Service_Mesh.Organization_theme> oList_Organization_theme_Ext = new List<Service_Mesh.Organization_theme>();
                List<Organization_theme> oList_Organization_theme = new List<Organization_theme>();
                var Organization_theme_handle = Task.Run(() =>
                {

                    oList_Organization_theme_Ext = this._service_mesh.Get_Organization_theme_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_Organization_theme_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_theme = Props.Copy_Prop_Values_From_Api_Response<List<Organization_theme>>(oList_Organization_theme_Ext);
                });
                // ---------------------
                // Get All available Organization_color_scheme entries.
                // ---------------------
                List<Service_Mesh.Organization_color_scheme> oList_Organization_color_scheme_Ext = new List<Service_Mesh.Organization_color_scheme>();
                List<Organization_color_scheme> oList_Organization_color_scheme = new List<Organization_color_scheme>();
                var Organization_color_scheme_handle = Task.Run(() =>
                {

                    oList_Organization_color_scheme_Ext = this._service_mesh.Get_Organization_color_scheme_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_Organization_color_scheme_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_color_scheme = Props.Copy_Prop_Values_From_Api_Response<List<Organization_color_scheme>>(oList_Organization_color_scheme_Ext);
                });
                // ---------------------
                // Get All available Organization_districtnex_module entries.
                // ---------------------
                List<Service_Mesh.Organization_districtnex_module> oList_Organization_districtnex_module_Ext = new List<Service_Mesh.Organization_districtnex_module>();
                List<Organization_districtnex_module> oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                var Organization_districtnex_module_handle = Task.Run(() =>
                {

                    oList_Organization_districtnex_module_Ext = this._service_mesh.Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<Organization_districtnex_module>>(oList_Organization_districtnex_module_Ext);
                });
                // ---------------------
                // Get All available Organization_image entries.
                // ---------------------
                List<Service_Mesh.Organization_image> oList_Organization_image_Ext = new List<Service_Mesh.Organization_image>();
                List<Organization_image> oList_Organization_image = new List<Organization_image>();
                var Organization_image_handle = Task.Run(() =>
                {

                    oList_Organization_image_Ext = this._service_mesh.Get_Organization_image_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_Organization_image_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_image = Props.Copy_Prop_Values_From_Api_Response<List<Organization_image>>(oList_Organization_image_Ext);
                });
                // ---------------------
                // Get All available Organization_level_access entries.
                // ---------------------
                List<Service_Mesh.Organization_level_access> oList_Organization_level_access_Ext = new List<Service_Mesh.Organization_level_access>();
                List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();
                var Organization_level_access_handle = Task.Run(() =>
                {

                    oList_Organization_level_access_Ext = this._service_mesh.Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_Organization_level_access_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_level_access = Props.Copy_Prop_Values_From_Api_Response<List<Organization_level_access>>(oList_Organization_level_access_Ext);
                });
                // ---------------------
                // Get All available Organization_log_config entries.
                // ---------------------
                List<Service_Mesh.Organization_log_config> oList_Organization_log_config_Ext = new List<Service_Mesh.Organization_log_config>();
                List<Organization_log_config> oList_Organization_log_config = new List<Organization_log_config>();
                var Organization_log_config_handle = Task.Run(() =>
                {

                    oList_Organization_log_config_Ext = this._service_mesh.Get_Organization_log_config_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_Organization_log_config_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_log_config = Props.Copy_Prop_Values_From_Api_Response<List<Organization_log_config>>(oList_Organization_log_config_Ext);
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
                List<Service_Mesh.Organization_theme> oList_Organization_theme = new List<Service_Mesh.Organization_theme>();
                var Organization_theme_handle = Task.Run(() =>
                {
                    oList_Organization_theme = this._service_mesh.Get_Organization_theme_By_ORGANIZATION_ID_Adv(new Service_Mesh.Params_Get_Organization_theme_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = Organization_ID
                    }).i_Result;
                    _List_Organization_theme = Props.Copy_Prop_Values_From_Api_Response<List<Organization_theme>>(oList_Organization_theme);
                });
                // ---------------------
                // Get All available Organization_image entries.
                // ---------------------
                List<Organization_image> _List_Organization_image = new List<Organization_image>();
                List<Service_Mesh.Organization_image> oList_Organization_image = new List<Service_Mesh.Organization_image>();
                var Organization_image_handle = Task.Run(() =>
                {
                    oList_Organization_image = this._service_mesh.Get_Organization_image_By_ORGANIZATION_ID(new Service_Mesh.Params_Get_Organization_image_By_ORGANIZATION_ID()
                    {
                        ORGANIZATION_ID = Organization_ID
                    }).i_Result;
                    _List_Organization_image = Props.Copy_Prop_Values_From_Api_Response<List<Organization_image>>(oList_Organization_image);
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
                List<Service_Mesh.Organization_districtnex_module> oList_Organization_districtnex_module_Ext = new List<Service_Mesh.Organization_districtnex_module>();
                List<Organization_districtnex_module> oList_Organization_districtnex_module = new List<Organization_districtnex_module>();
                var Organization_districtnex_module_handle = Task.Run(() =>
                {

                    oList_Organization_districtnex_module_Ext = this._service_mesh.Get_Organization_districtnex_module_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_Organization_districtnex_module_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_districtnex_module = Props.Copy_Prop_Values_From_Api_Response<List<Organization_districtnex_module>>(oList_Organization_districtnex_module_Ext);
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
                List<Service_Mesh.Organization_image> oList_Organization_image_Ext = new List<Service_Mesh.Organization_image>();
                List<Organization_image> oList_Organization_image = new List<Organization_image>();
                var Organization_image_handle = Task.Run(() =>
                {

                    oList_Organization_image_Ext = this._service_mesh.Get_Organization_image_By_ORGANIZATION_ID_List(new Service_Mesh.Params_Get_Organization_image_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_image = Props.Copy_Prop_Values_From_Api_Response<List<Organization_image>>(oList_Organization_image_Ext);
                });
                // ---------------------
                // Get All available Organization_level_access entries.
                // ---------------------
                List<Service_Mesh.Organization_level_access> oList_Organization_level_access_Ext = new List<Service_Mesh.Organization_level_access>();
                List<Organization_level_access> oList_Organization_level_access = new List<Organization_level_access>();
                var Organization_level_access_handle = Task.Run(() =>
                {

                    oList_Organization_level_access_Ext = this._service_mesh.Get_Organization_level_access_By_ORGANIZATION_ID_List_Adv(new Service_Mesh.Params_Get_Organization_level_access_By_ORGANIZATION_ID_List()
                    {
                        ORGANIZATION_ID_LIST = Organization_ID_List
                    }).i_Result;
                    oList_Organization_level_access = Props.Copy_Prop_Values_From_Api_Response<List<Organization_level_access>>(oList_Organization_level_access_Ext);
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
        #region BLC_OnPostEvent_Get_Floor_By_ENTITY_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Floor_By_ENTITY_ID_Eager_Loading(List<Floor> i_Result, Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Floor_ID_List = i_Result.Select(floor => floor.FLOOR_ID).OrderBy(Floor_ID => Floor_ID);

                // ---------------------
                // Get All available Space entries.
                // ---------------------
                List<Space> oList_Space = Get_Space_By_FLOOR_ID_List(new Params_Get_Space_By_FLOOR_ID_List()
                {
                    FLOOR_ID_LIST = Floor_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oFloor =>
                {
                    oFloor.List_Space = oList_Space.Where(oSpace => oSpace.FLOOR_ID == oFloor.FLOOR_ID).ToList();
                    return oFloor;
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
            this.OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List += new PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID_List(BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Organization_By_ORGANIZATION_ID += new PostEvent_Handler_Get_Organization_By_ORGANIZATION_ID(BLC_OnPostEvent_Get_Organization_By_ORGANIZATION_ID_Eager_Loading);
            this.OnPostEvent_Get_Organization_By_OWNER_ID += new PostEvent_Handler_Get_Organization_By_OWNER_ID(BLC_OnPostEvent_Get_Organization_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Floor_By_ENTITY_ID += new PostEvent_Handler_Get_Floor_By_ENTITY_ID(BLC_OnPostEvent_Get_Floor_By_ENTITY_ID_Eager_Loading);
            #endregion
        }
        #endregion
    }
}